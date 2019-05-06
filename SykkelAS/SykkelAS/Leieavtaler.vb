Imports MySql.Data.MySqlClient
Public Class Leieavtaler
    Public fra, til As String
    Private fraDag, fraTime, tilDag, tilTime As Date
    Private kunde_nr, sykkel_id, utstyr_id, innloggetNr, innloggetNavn, søk, valgt, prisgrunnlag, spørring As String
    Private id, nr, dager, timer, rabatt, prisFørRabatt, prisEtterRabatt As Integer
    Private valgtIndeks As Integer = -1
    Private valgtKundeNr As Integer
    Private valgtSykkelID As New List(Of Integer)
    Private valgtUtstyrID As New List(Of Integer)
    Private SykkelKode As New List(Of String)
    Private UtstyrKode As New List(Of String)
    Private LeieavtaleTabell As New DataTable
    Private SykkelTabell As New DataTable
    Private UtstyrTabell As New DataTable
    Private rad As DataRow


    Private Function Utfylt() As Boolean
        'Funksjon for å validere skjema
        If lstTidspunkt.Items.Count > 0 And
        lstKunde.Items.Count > 0 And
        lstSykkel.Items.Count > 0 And
        cmbUtlevering.Text <> "" And
        cmbInnlevering.Text <> "" Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub Leieavtaler_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        'Viser innlogget avdeling
        innloggetNavn = Innlogging.innloggetAvdeling.HentAvdelingNavn
        lblInnloggetAvdeling.Text = "Innlogget på avdeling " & innloggetNavn
    End Sub

    Private Sub Leieavtaler_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Legger til avdelingsvalg for innlevering og utlevering
        For Each avdeling In AdministrereAvdeling.avdelingValg
            cmbUtlevering.Items.Add(avdeling)
            cmbInnlevering.Items.Add(avdeling)
        Next
        innloggetNr = Innlogging.innloggetAvdeling.HentAvdelingNr
        'Setter datovelger til dagens dato
        dtpFraDato.Value = Date.Now
        dtpFraTime.Value = Date.Now
        dtpTilDato.Value = Date.Now
        dtpTilTime.Value = Date.Now
    End Sub

    Public Sub TømSkjema()
        lstTidspunkt.Items.Clear()
        lstKunde.Items.Clear()
        lstSykkel.Items.Clear()
        lstUtstyr.Items.Clear()
        SykkelKode.Clear()
        txtRabatt.Text = ""
        txtValgtRabatt.Text = ""
        txtPrisFør.Text = ""
        txtPrisEtter.Text = ""
        prisFørRabatt = 0
        valgtSykkelID.Clear()
        valgtUtstyrID.Clear()
        txtLeieavtaleNr.Text = ""
        txtAvdeling.Text = ""
        txtStatus.Text = ""
    End Sub

    Private Sub HentTid()
        'Henter ut tidspunkt og konverterer til sql-format
        fraDag = dtpFraDato.Value
        fraTime = dtpFraTime.Value
        fra = fraDag.ToString("yyyy-MM-dd") & " " & fraTime.ToString("HH") & ":00:00"
        tilDag = dtpTilDato.Value
        tilTime = dtpTilTime.Value
        til = tilDag.ToString("yyyy-MM-dd") & " " & tilTime.ToString("HH") & ":00:00"
    End Sub

    Private Sub HentTabeller()
        'Henter tabeller ut i fra valgte datoer
        'Henter kundetabell
        AdministrereKunde.hentKunde()
        'Henter inn tabell over ledige sykler basert på valgt dato og status
        spørring = "SELECT * FROM sykkel WHERE status = 'Tilgjengelig' AND avdeling_nr = @innlogget AND sykkel_id NOT IN
                       (SELECT sykkel_id FROM utleid_sykkel WHERE leieavtale_nr IN 
                       (SELECT leieavtale_nr FROM leieavtale WHERE @fra < tidspunkt_til AND @til > tidspunkt_fra))"
        AdministrereSykkel.hentSykkel(spørring)
        'Henter inn tabell over ledig utstyr basert på valgt dato og status
        spørring = "SELECT * FROM utstyr WHERE status = 'Tilgjengelig' AND avdeling_nr = @innlogget AND utstyr_id NOT IN
                       (SELECT utstyr_id FROM utleid_utstyr WHERE leieavtale_nr IN 
                       (SELECT leieavtale_nr FROM leieavtale WHERE @fra < tidspunkt_til AND @til > tidspunkt_fra))"
        AdministrereUtstyr.hentUtstyr(spørring)
    End Sub

    Private Sub OppdaterPris()
        'Oppdaterer pris
        If prisgrunnlag = "helg" Then
            prisFørRabatt += rad("pris_helg")
        End If
        If prisgrunnlag = "dag" Then
            prisFørRabatt += rad("pris_dag") * dager
        End If
        If prisgrunnlag = "time" Then
            'Bytter til prisgrunnlag dag hvis timepris overskrider dagpris
            If rad("pris_time") * timer > rad("pris_dag") Then
                prisgrunnlag = "dag"
                lblPrisgrunnlag.Text = "Prisgrunnlag: " & prisgrunnlag
                prisFørRabatt = rad("pris_dag")
            Else
                prisFørRabatt += rad("pris_time") * timer
            End If
        End If
        prisEtterRabatt = prisFørRabatt
        txtPrisFør.Text = prisFørRabatt
        txtPrisEtter.Text = prisEtterRabatt
    End Sub

    Private Sub txtRabatt_TextChanged(sender As Object, e As EventArgs) Handles txtRabatt.TextChanged
        'Oppdaterer pris ut ifra rabatt
        If IsNumeric(txtRabatt.Text) Then
            rabatt = txtRabatt.Text
            txtValgtRabatt.Text = rabatt & "%"
            prisEtterRabatt = (100 - rabatt) * prisFørRabatt / 100
            txtPrisEtter.Text = prisEtterRabatt
        End If
    End Sub

    Private Sub btnFjernrabatt_Click(sender As Object, e As EventArgs) Handles btnFjernrabatt.Click
        txtRabatt.Text = ""
        txtValgtRabatt.Text = ""
        prisEtterRabatt = prisFørRabatt
        txtPrisEtter.Text = prisEtterRabatt
    End Sub

    Private Sub chkManuell_CheckedChanged(sender As Object, e As EventArgs) Handles chkManuell.CheckedChanged
        'Gir mulighet til å skrive inn en pris uavhengig av det som er beregnet
        If chkManuell.Checked = True Then
            txtPrisEtter.ReadOnly = False
        End If
        If chkManuell.Checked = False Then
            txtPrisEtter.ReadOnly = True
        End If
    End Sub


    Private Sub btnTid_Click(sender As Object, e As EventArgs) Handles btnTid.Click
        'Henter tidspunkt
        HentTid()
        'Validerer valgt tidspunkt
        Dim valider As Boolean = True
        If fra = til Then
            valider = False
            MsgBox("Tidspunktene kan ikke være like")
        End If
        If fra > til Then
            valider = False
            MsgBox("Til-tid kan ikke være før fra-tid")
        End If
        Dim tidnå As String = Date.Now.ToString("yyyy-MM-dd") & " " & Date.Now.ToString("HH") & ":00:00"
        If fra < tidnå Or til < tidnå Then
            valider = False
            MsgBox("Tidspunkt kan ikke være før nåværende dato og klokkeslett")
        End If
        'Velger tidspunkt hvis valideringen er ok
        If valider = True Then
            'Fjerner tidligere tidspunkt
            lstTidspunkt.Items.Clear()
            'Fjerner sykler og utstyr hvis tidspunkt endres
            valgtSykkelID.Clear()
            lstSykkel.Items.Clear()
            valgtUtstyrID.Clear()
            lstUtstyr.Items.Clear()
            With lstTidspunkt.Items
                .Add("Fra:")
                .Add(fraDag.ToString("dddd dd. MMMM") & " kl. " & fraTime.ToString("HH") & ":00")
                .Add("Til:")
                .Add(tilDag.ToString("dddd dd. MMMM") & " kl. " & tilTime.ToString("HH") & ":00")
            End With
            'Henter prosedyre for å fylle ut tabeller
            HentTabeller()
            'Finner prisgrunnlag ut ifra tidspunkt
            dager = DateDiff(DateInterval.Day, fraDag, tilDag)
            timer = DateDiff(DateInterval.Hour, fraTime, tilTime)
            If fraDag.ToString("dddd") = "fredag" And
                    tilDag.ToString("dddd") = "søndag" And
                    dager = 2 Then
                prisgrunnlag = "helg"
            ElseIf dager = 0 Then
                prisgrunnlag = "time"
            Else
                prisgrunnlag = "dag"
            End If
            lblPrisgrunnlag.Text = "Prisgrunnlag: " & prisgrunnlag
        End If
    End Sub

    Private Sub cmbKunde_TextChanged(sender As Object, e As EventArgs) Handles cmbKunde.TextChanged
        'Fjerner tidligere søkeresultat
        cmbKunde.Items.Clear()
        'Søker gjennom tabell
        søk = cmbKunde.Text
        'Første loop går gjennom hver rad i tabellen
        For Each rad In AdministrereKunde.kundetabell.Rows
            'Andre loop går gjennom hver celle i hver enkelt rad
            'Bruker ToLower for å kunne søke uavhengig av stor/liten bokstav
            For i = 0 To AdministrereKunde.kundetabell.Columns.Count - 1
                If CStr(rad(i)).ToLower.IndexOf(søk.ToLower()) > -1 Then
                    Dim resultat = rad(0) & " " & rad(2) & ", " & rad(1) & " (Tlf: " & rad(4) & ")"
                    'Gjør at resultat ikke blir lagt til flere ganger
                    If Not cmbKunde.Items.Contains(resultat) Then
                        cmbKunde.Items.Add(resultat)
                    End If
                End If
            Next
        Next
        cmbKunde.SelectionStart = cmbKunde.Text.Length + 1
    End Sub

    Private Sub cmbKunde_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbKunde.SelectionChangeCommitted
        'Henter nr til valgt kunde (tallet helt til venstre i resultatet)
        valgt = cmbKunde.SelectedItem.ToString.Split(" ")(0)
        'Henter ut riktig indeks i tabell
        For i = 0 To AdministrereKunde.kundetabell.Rows.Count - 1
            'Sjekker første kolonne i hver rad etter id til valgt kunde
            If AdministrereKunde.kundetabell.Rows(i).Item(0) = valgt Then
                valgtIndeks = i
                Exit For
            End If
        Next
        rad = AdministrereKunde.kundetabell.Rows(valgtIndeks)
        valgtKundeNr = rad(0)
        Dim valgtKunde = rad(0) & " " & rad(2) & ", " & rad(1) & " (Tlf: " & rad(4) & ")"
        If lstKunde.Items.Count = 0 Then
            lstKunde.Items.Add(valgtKunde)
        Else
            MsgBox("Du kan kun legge til én kunde")
        End If
    End Sub

    Private Sub cmbSykkel_TextChanged(sender As Object, e As EventArgs) Handles cmbSykkel.TextChanged
        'Fjerner tidligere søkeresultat
        cmbSykkel.Items.Clear()
        'Søker gjennom tabell
        søk = cmbSykkel.Text
        'Første loop går gjennom hver rad i tabellen
        For Each rad In AdministrereSykkel.sykkeltabell.Rows
            'Andre loop går gjennom hver celle i hver enkelt rad
            'Bruker ToLower for å kunne søke uavhengig av stor/liten bokstav
            For i = 0 To AdministrereSykkel.sykkeltabell.Columns.Count - 1
                If CStr(rad(i)).ToLower.IndexOf(søk.ToLower()) > -1 Then
                    Dim resultat = rad(0) & " " & rad(1) & " " & rad(2)
                    'Gjør at resultat ikke blir lagt til flere ganger
                    If Not cmbSykkel.Items.Contains(resultat) Then
                        cmbSykkel.Items.Add(resultat)
                    End If
                End If
            Next
        Next
        cmbSykkel.SelectionStart = cmbSykkel.Text.Length + 1
    End Sub

    Private Sub cmbSykkel_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbSykkel.SelectionChangeCommitted
        'Henter nr til valgt sykkel (tallet helt til venstre i resultatet)
        valgt = cmbSykkel.SelectedItem.ToString.Split(" ")(0)
        'Henter ut riktig indeks i tabell
        For i = 0 To AdministrereSykkel.sykkeltabell.Rows.Count - 1
            'Sjekker første kolonne i hver rad etter id til valgt sykkel
            If AdministrereSykkel.sykkeltabell.Rows(i).Item(0) = valgt Then
                valgtIndeks = i
                Exit For
            End If
        Next
        rad = AdministrereSykkel.sykkeltabell.Rows(valgtIndeks)
        valgtSykkelID.Add(rad(0))
        Dim valgtSykkel = rad(0) & " " & rad(1) & " " & rad(2)
        'Sjekker om samme sykkel allerede er lagt til
        If Not lstSykkel.Items.Contains(valgtSykkel) Then
            lstSykkel.Items.Add(valgtSykkel)
            'Legger til koder i arraylist for valgte sykler
            If rad(2) = "Terreng" Then
                SykkelKode.Add("T")
            ElseIf rad(2) = "Downhill" Then
                SykkelKode.Add("D")
            ElseIf rad(2) = "Racer" Then
                SykkelKode.Add("R")
            ElseIf rad(2) = "Tandem" Then
                SykkelKode.Add("M")
            ElseIf rad(2) = "Barn" Then
                SykkelKode.Add("B")
            End If
            OppdaterPris()
        Else
            MsgBox("Du kan ikke legge til samme sykkel på nytt")
        End If
    End Sub

    Private Sub cmbUtstyr_TextChanged(sender As Object, e As EventArgs) Handles cmbUtstyr.TextChanged
        'Fjerner tidligere søkeresultat
        cmbUtstyr.Items.Clear()
        'Søker gjennom tabell
        Dim søk As String
        søk = cmbUtstyr.Text
        'Første loop går gjennom hver rad i tabellen
        For Each rad In AdministrereUtstyr.utstyrtabell.Rows
            'Andre loop går gjennom hver celle i hver enkelt rad
            'Bruker ToLower for å kunne søke uavhengig av stor/liten bokstav
            For i = 0 To AdministrereUtstyr.utstyrtabell.Columns.Count - 1
                If CStr(rad(i)).ToLower.IndexOf(søk.ToLower()) > -1 Then
                    Dim resultat = rad(0) & " " & rad(1) & " " & rad(2)
                    'Gjør at resultat ikke blir lagt til flere ganger
                    If Not cmbUtstyr.Items.Contains(resultat) Then
                        cmbUtstyr.Items.Add(resultat)
                    End If
                End If
            Next
        Next
        cmbUtstyr.SelectionStart = cmbUtstyr.Text.Length + 1
    End Sub

    Private Sub cmbUtstyr_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbUtstyr.SelectionChangeCommitted
        'Henter nr til valgt utstyr (tallet helt til venstre i resultatet)
        Dim valgt = cmbUtstyr.SelectedItem.ToString.Split(" ")(0)
        'Henter ut riktig indeks i tabell
        For i = 0 To AdministrereUtstyr.utstyrtabell.Rows.Count - 1
            'Sjekker første kolonne i hver rad etter id til valgt sykkel
            If AdministrereUtstyr.utstyrtabell.Rows(i).Item(0) = valgt Then
                valgtIndeks = i
                Exit For
            End If
        Next
        rad = AdministrereUtstyr.utstyrtabell.Rows(valgtIndeks)
        valgtUtstyrID.Add(rad(0))
        Dim valgtUtstyr = rad(0) & " " & rad(1) & " " & rad(2)
        'Sjekker om det er lagt til sykkel
        If lstSykkel.Items.Count <> 0 Then
            'Sjekker om utstyr allerede er lagt til
            If Not lstUtstyr.Items.Contains(valgtUtstyr) Then
                'Sjekker om utstyr passer til valgt sykkel
                Dim koder() As Char = rad(6).ToCharArray
                For Each kode In koder
                    UtstyrKode.Add(kode)
                Next
                'Sammenligner lister og sjekker om koder finnes i begge
                Dim treff = UtstyrKode.Intersect(SykkelKode).ToArray()
                If treff.Length > 0 Then
                    lstUtstyr.Items.Add(valgtUtstyr)
                    OppdaterPris()
                Else
                    MsgBox("Utstyr passer ikke til valgt sykkel")
                End If
            Else
                MsgBox("Du kan ikke legge til samme utstyr på nytt")
            End If
        Else
            MsgBox("Du må legge til minst én sykkel før du kan velge utstyr")
        End If
    End Sub

    Private Sub btnRegistrer_Click(sender As Object, e As EventArgs) Handles btnRegistrer.Click
        'Registrerer leieavtale i database dersom skjema er utfylt, og det ikke er hentet inn en eksisterende avtale
        If txtLeieavtaleNr.Text = "" Then
            If Utfylt() Then

                Try
                    databasetilkobling.databaseTilkobling()
                    tilkobling.Open()

                    'Oppretter leieavtalen
                    Dim sql As New MySqlCommand("INSERT INTO leieavtale (lokasjon_utlevering, lokasjon_innlevering, pris, 
                                            tidspunkt_fra, tidspunkt_til, status, kunde_nr, avdeling_nr) 
                                            VALUES (@lokasjon_utlevering, @lokasjon_innlevering, @pris, 
                                            @tidspunkt_fra, @tidspunkt_til, @status, @kunde_nr, @avdeling_nr)", tilkobling)
                    With sql.Parameters
                        .AddWithValue("@lokasjon_utlevering", cmbUtlevering.Text)
                        .AddWithValue("@lokasjon_innlevering", cmbInnlevering.Text)
                        .AddWithValue("@pris", txtPrisEtter.Text)
                        .AddWithValue("@tidspunkt_fra", fra)
                        .AddWithValue("@tidspunkt_til", til)
                        .AddWithValue("@status", "Aktiv")
                        .AddWithValue("@kunde_nr", valgtKundeNr)
                        .AddWithValue("@avdeling_nr", innloggetNr)
                    End With
                    sql.ExecuteNonQuery()

                    'Henter leieavtale_nr på sist opprettede leieavtale
                    Dim sql2 As New MySqlCommand("SELECT MAX(leieavtale_nr) FROM leieavtale", tilkobling)
                    nr = sql2.ExecuteScalar()

                    'Kobler valgte sykler til leieavtalen
                    For i = 0 To valgtSykkelID.Count - 1
                        Dim sql3 As New MySqlCommand("INSERT INTO utleid_sykkel VALUES (@nr, @sykkel_id)", tilkobling)
                        With sql3.Parameters
                            .AddWithValue("@nr", nr)
                            .AddWithValue("@sykkel_id", valgtSykkelID(i))
                        End With
                        sql3.ExecuteNonQuery()
                    Next

                    'Kobler valgt utstyr til leieavtalen
                    For i = 0 To valgtUtstyrID.Count - 1
                        Dim sql4 As New MySqlCommand("INSERT INTO utleid_utstyr VALUES (@nr, @utstyr_id)", tilkobling)
                        With sql4.Parameters
                            .AddWithValue("@nr", nr)
                            .AddWithValue("@utstyr_id", valgtUtstyrID(i))
                        End With
                        sql4.ExecuteNonQuery()
                    Next

                    MsgBox("Avtale registrert")
                    tilkobling.Close()
                    If cmbUtlevering.Text <> innloggetNavn Then
                        meldOperatør()
                    End If

                    TømSkjema()
                Catch feilmelding As MySqlException
                    MsgBox(feilmelding.Message)
                Finally
                    tilkobling.Dispose()
                End Try



            Else
                MsgBox("Skjema er ikke korrekt utfylt")
            End If
        Else
            MsgBox("Eksisterende avtale er lagt inn. Tøm skjema før du fortsetter")
        End If
    End Sub

    Private Sub btnHent_Click(sender As Object, e As EventArgs) Handles btnHent.Click
        'Fjerner tidligere resultat
        lstLeieavtaler.Items.Clear()
        LeieavtaleTabell.Clear()
        'Henter alle leieavtaler tilhørende avdelingen med status aktiv
        innloggetNavn = Innlogging.innloggetAvdeling.HentAvdelingNavn()
        innloggetNr = Innlogging.innloggetAvdeling.HentAvdelingNr()
        Try
            databasetilkobling.databaseTilkobling()
            tilkobling.Open()
            Dim sql As New MySqlCommand("SELECT l.*, fornavn, etternavn, k.telefon, avdeling_navn FROM leieavtale l 
                                        INNER JOIN kunde k ON l.kunde_nr = k.kunde_nr 
                                        INNER JOIN avdeling a ON l.avdeling_nr = a.avdeling_nr
                                        WHERE(l.avdeling_nr = @innloggetNr 
                                        OR lokasjon_utlevering = @innloggetNavn OR lokasjon_innlevering = @innloggetNavn)
                                        AND (status = 'Aktiv' OR status = 'Utlevert')", tilkobling)
            With sql.Parameters
                .AddWithValue("@innloggetNavn", innloggetNavn)
                .AddWithValue("@innloggetNr", innloggetNr)
            End With
            Dim da As New MySqlDataAdapter
            da.SelectCommand = sql
            da.Fill(LeieavtaleTabell)
            tilkobling.Close()
        Catch feilmelding As MySqlException
            MsgBox(feilmelding.Message)
        Finally
            tilkobling.Dispose()
        End Try
        'Legger til i resultatliste
        For Each rad In LeieavtaleTabell.Rows
            lstLeieavtaler.Items.Add(rad("leieavtale_nr") & " - " & rad("etternavn") & ", " & rad("fornavn") &
                                         " (" & rad("status") & ", opprettet av " & rad("avdeling_navn") & ")")
        Next
    End Sub

    Private Sub lstLeieavtaler_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstLeieavtaler.SelectedIndexChanged
        'Legger inn info om valgt leieavtale i skjema, og deretter sykler og utstyr knyttet til avtalen
        TømSkjema()
        If lstLeieavtaler.SelectedItem <> "" Then
            nr = lstLeieavtaler.SelectedItem.Split(" ")(0)
            'Legger inn leieavtale
            Dim valgtIndeks = -1
            For i = 0 To LeieavtaleTabell.Rows.Count - 1
                If LeieavtaleTabell.Rows(i).Item(0) = nr Then
                    valgtIndeks = i
                    Exit For
                End If
            Next i
            rad = LeieavtaleTabell.Rows(valgtIndeks)
            cmbUtlevering.Text = rad("lokasjon_utlevering")
            cmbInnlevering.Text = rad("lokasjon_innlevering")
            txtPrisEtter.Text = rad("pris")
            fra = rad("tidspunkt_fra")
            dtpFraDato.Value = fra
            dtpFraTime.Value = fra
            til = rad("tidspunkt_til")
            dtpTilDato.Value = til
            dtpTilTime.Value = til
            With lstTidspunkt.Items
                .Add("Fra:")
                .Add(dtpFraDato.Value.ToString("dddd dd. MMMM") & " kl. " & dtpFraTime.Value.ToString("HH") & ":00")
                .Add("Til:")
                .Add(dtpTilDato.Value.ToString("dddd dd. MMMM") & " kl. " & dtpTilTime.Value.ToString("HH") & ":00")
            End With
            txtLeieavtaleNr.Text = rad("leieavtale_nr")
            txtAvdeling.Text = rad("avdeling_navn")
            txtStatus.Text = rad("status")
            valgtKundeNr = rad("kunde_nr")
            lstKunde.Items.Add(rad("kunde_nr") & " " & rad("etternavn") & ", " & rad("fornavn") & " (Tlf: " & rad("telefon") & ")")
            Try
                databasetilkobling.databaseTilkobling()
                tilkobling.Open()
                Dim da As New MySqlDataAdapter
                'Henter først sykler
                SykkelTabell.Clear()
                Dim sql As New MySqlCommand("SELECT * FROM sykkel WHERE sykkel_id IN
                                            (SELECT sykkel_id FROM utleid_sykkel WHERE leieavtale_nr = @nr)", tilkobling)
                sql.Parameters.AddWithValue("@nr", nr)
                da.SelectCommand = sql
                da.Fill(SykkelTabell)
                For Each rad In SykkelTabell.Rows
                    lstSykkel.Items.Add(rad("sykkel_id") & " " & rad("sykkel_merke") & " " & rad("sykkel_type"))
                Next
                'Henter deretter utstyr
                UtstyrTabell.Clear()
                Dim sql2 As New MySqlCommand("SELECT * FROM utstyr WHERE utstyr_id IN
                                            (SELECT utstyr_id FROM utleid_utstyr WHERE leieavtale_nr = @nr)", tilkobling)
                sql2.Parameters.AddWithValue("@nr", nr)
                da.SelectCommand = sql2
                da.Fill(UtstyrTabell)
                For Each rad In UtstyrTabell.Rows
                    lstUtstyr.Items.Add(rad("utstyr_id") & " " & rad("utstyr_merke") & " " & rad("utstyr_type"))
                Next
                tilkobling.Close()
            Catch feilmelding As MySqlException
                MsgBox(feilmelding.Message)
            Finally
                tilkobling.Dispose()
            End Try
        End If
    End Sub

    Private Sub btnOppdater_Click(sender As Object, e As EventArgs) Handles btnOppdater.Click
        'Sjekker først om avtale tilhører avdelingen
        If txtAvdeling.Text = innloggetNavn Then
            'Oppdaterer eksisterende leieavtale dersom skjema er utfylt
            If Utfylt() And txtLeieavtaleNr.Text <> "" Then
                HentTid()
                nr = txtLeieavtaleNr.Text

                Try
                    databasetilkobling.databaseTilkobling()
                    tilkobling.Open()

                    'Oppdaterer leieavtalen
                    Dim sql As New MySqlCommand("UPDATE leieavtale SET lokasjon_utlevering = @lokasjon_utlevering, 
                                            lokasjon_innlevering = @lokasjon_innlevering, pris = @pris, 
                                            tidspunkt_fra = @tidspunkt_fra, tidspunkt_til = @tidspunkt_til,
                                            kunde_nr = @kunde_nr", tilkobling)
                    With sql.Parameters
                        .AddWithValue("@nr", nr)
                        .AddWithValue("@lokasjon_utlevering", cmbUtlevering.Text)
                        .AddWithValue("@lokasjon_innlevering", cmbInnlevering.Text)
                        .AddWithValue("@pris", txtPrisEtter.Text)
                        .AddWithValue("@tidspunkt_fra", fra)
                        .AddWithValue("@tidspunkt_til", til)
                        .AddWithValue("@kunde_nr", valgtKundeNr)
                    End With
                    sql.ExecuteNonQuery()

                    'Legger til sykler
                    For i = 0 To valgtSykkelID.Count - 1
                        Dim sql2 As New MySqlCommand("INSERT INTO utleid_sykkel VALUES (@nr, @sykkel_id)", tilkobling)
                        With sql2.Parameters
                            .AddWithValue("@nr", nr)
                            .AddWithValue("@sykkel_id", valgtSykkelID(i))
                        End With
                        sql2.ExecuteNonQuery()
                    Next

                    'Legger til utstyr
                    For i = 0 To valgtUtstyrID.Count - 1
                        Dim sql3 As New MySqlCommand("INSERT INTO utleid_utstyr VALUES (@nr, @utstyr_id)", tilkobling)
                        With sql3.Parameters
                            .AddWithValue("@nr", nr)
                            .AddWithValue("@utstyr_id", valgtUtstyrID(i))
                        End With
                        sql3.ExecuteNonQuery()
                    Next

                    tilkobling.Close()
                    TømSkjema()
                Catch feilmelding As MySqlException
                    MsgBox(feilmelding.Message)
                Finally
                    tilkobling.Dispose()
                End Try
                lstLeieavtaler.Items.Clear()
            Else
                MsgBox("Skjema er ikke korrekt utfylt")
            End If
        Else
            MsgBox("Du kan ikke endre på en avtale som ikke tilhører avdelingen")
        End If
    End Sub

    Private Sub btnFjernKunde_Click(sender As Object, e As EventArgs) Handles btnFjernKunde.Click
        lstKunde.Items.Clear()
    End Sub

    Private Sub btnFjernSykkel_Click(sender As Object, e As EventArgs) Handles btnFjernSykkel.Click
        If lstSykkel.SelectedIndex > -1 Then
            'Fjerner valgt sykkel fra en eksisterende leieavtale, dersom en avtale er hentet inn
            If txtLeieavtaleNr.Text <> "" Then
                If MsgBox("Er du sikker på at du fjerne sykkelen fra avtalen?",
                      MsgBoxStyle.YesNo, "OBS!") = MsgBoxResult.Yes Then
                    valgt = lstSykkel.SelectedItem.ToString.Split(" ")(0)
                    nr = txtLeieavtaleNr.Text
                    Try
                        databasetilkobling.databaseTilkobling()
                        tilkobling.Open()
                        'Fjerner tidligere valgte sykler og utstyr
                        Dim sql As New MySqlCommand("DELETE from utleid_sykkel WHERE leieavtale_nr = @nr
                                                AND sykkel_id = @valgt", tilkobling)
                        With sql.Parameters
                            .AddWithValue("@nr", nr)
                            .AddWithValue("@valgt", valgt)
                        End With
                        sql.ExecuteNonQuery()
                        tilkobling.Close()
                        lstSykkel.Items.Remove(lstSykkel.SelectedItem)
                        HentTabeller()
                    Catch feilmelding As MySqlException
                        MsgBox(feilmelding.Message)
                    Finally
                        tilkobling.Dispose()
                    End Try
                End If
            Else
                lstSykkel.Items.Remove(lstSykkel.SelectedItem)
            End If
        Else
            MsgBox("Merk sykkel du ønsker å fjerne")
        End If
    End Sub

    Private Sub btnFjernUtstyr_Click(sender As Object, e As EventArgs) Handles btnFjernUtstyr.Click
        If lstUtstyr.SelectedIndex > -1 Then
            'Fjerner valgt utstyr fra en eksisterende leieavtale, dersom en avtale er hentet inn
            If txtLeieavtaleNr.Text <> "" Then
                If MsgBox("Er du sikker på at du fjerne utstyret fra avtalen?",
                      MsgBoxStyle.YesNo, "OBS!") = MsgBoxResult.Yes Then
                    valgt = lstUtstyr.SelectedItem.ToString.Split(" ")(0)
                    nr = txtLeieavtaleNr.Text
                    Try
                        databasetilkobling.databaseTilkobling()
                        tilkobling.Open()
                        'Fjerner tidligere valgte sykler og utstyr
                        Dim sql As New MySqlCommand("DELETE from utleid_utstyr WHERE leieavtale_nr = @nr
                                                AND utstyr_id = @valgt", tilkobling)
                        With sql.Parameters
                            .AddWithValue("@nr", nr)
                            .AddWithValue("@valgt", valgt)
                        End With
                        sql.ExecuteNonQuery()
                        tilkobling.Close()
                        lstUtstyr.Items.Remove(lstUtstyr.SelectedItem)
                        HentTabeller()
                    Catch feilmelding As MySqlException
                        MsgBox(feilmelding.Message)
                    Finally
                        tilkobling.Dispose()
                    End Try
                End If
            Else
                lstUtstyr.Items.Remove(lstUtstyr.SelectedItem)
            End If
        Else
            MsgBox("Merk utstyr du ønsker å fjerne")
        End If
    End Sub

    Private Sub btnUtlevering_Click(sender As Object, e As EventArgs) Handles btnUtlevering.Click
        nr = txtLeieavtaleNr.Text
        'Sjekker at utlevering gjøres på riktig avdeling
        If innloggetNavn = cmbUtlevering.Text Then
            Try
                databasetilkobling.databaseTilkobling()
                tilkobling.Open()
                Dim sql As New MySqlCommand("UPDATE leieavtale SET status = 'Utlevert' WHERE leieavtale_nr = @nr", tilkobling)
                sql.Parameters.AddWithValue("@nr", nr)
                sql.ExecuteNonQuery()
                Dim sql2 As New MySqlCommand("UPDATE sykkel SET lokasjon = 'Hos kunde' WHERE sykkel_id IN
                                         (SELECT sykkel_id FROM utleid_sykkel WHERE leieavtale_nr = @nr)", tilkobling)
                sql2.Parameters.AddWithValue("@nr", nr)
                sql2.ExecuteNonQuery()
                Dim sql3 As New MySqlCommand("UPDATE utstyr SET lokasjon = 'Hos kunde' WHERE utstyr_id IN
                                         (SELECT utstyr_id FROM utleid_utstyr WHERE leieavtale_nr = @nr)", tilkobling)
                sql3.Parameters.AddWithValue("@nr", nr)
                sql3.ExecuteNonQuery()
                tilkobling.Close()
                TømSkjema()
                lstLeieavtaler.Items.Clear()
            Catch feilmelding As MySqlException
                MsgBox(feilmelding.Message)
            Finally
                tilkobling.Dispose()
            End Try
        Else
            MsgBox("Valgt utleveringssted samsvarer ikke med innlogget avdeling")
        End If
    End Sub

    Private Sub btnInnlevering_Click(sender As Object, e As EventArgs) Handles btnInnlevering.Click
        nr = txtLeieavtaleNr.Text
        'Sjekker at innlevering gjøres på riktig avdeling
        If cmbInnlevering.Text = innloggetNavn Then
            'Sjekker at avtalen tidligere har blitt utlevert
            If txtStatus.Text = "Utlevert" Then
                Try
                    databasetilkobling.databaseTilkobling()
                    tilkobling.Open()
                    Dim sql As New MySqlCommand("UPDATE leieavtale SET status = 'Avsluttet' WHERE leieavtale_nr = @nr", tilkobling)
                    sql.Parameters.AddWithValue("@nr", nr)
                    sql.ExecuteNonQuery()
                    Dim sql2 As New MySqlCommand("UPDATE sykkel SET lokasjon = @innloggetNavn WHERE sykkel_id IN
                                         (SELECT sykkel_id FROM utleid_sykkel WHERE leieavtale_nr = @nr)", tilkobling)
                    With sql2.Parameters
                        .AddWithValue("@nr", nr)
                        .AddWithValue("innloggetNavn", innloggetNavn)
                    End With
                    sql2.ExecuteNonQuery()
                    Dim sql3 As New MySqlCommand("UPDATE utstyr SET lokasjon = @innloggetNavn WHERE utstyr_id IN
                                         (SELECT utstyr_id FROM utleid_utstyr WHERE leieavtale_nr = @nr)", tilkobling)
                    With sql3.Parameters
                        .AddWithValue("@nr", nr)
                        .AddWithValue("innloggetNavn", innloggetNavn)
                    End With
                    sql3.ExecuteNonQuery()
                    tilkobling.Close()
                    TømSkjema()
                    lstLeieavtaler.Items.Clear()
                Catch feilmelding As MySqlException
                    MsgBox(feilmelding.Message)
                Finally
                    tilkobling.Dispose()
                End Try
            Else
                MsgBox("Avtale må være utlevert før den kan tas imot")
            End If
        Else
            MsgBox("Valgt innleveringssted samsvarer ikke med innlogget avdeling")
        End If
    End Sub

    Private Sub btnTømSkjema_Click(sender As Object, e As EventArgs) Handles btnTømSkjema.Click
        TømSkjema()
    End Sub

    Private Sub btnTilbake_Click(sender As Object, e As EventArgs) Handles btnTilbake.Click
        Hovedmeny.Show()
        Me.Hide()
    End Sub

    Private Sub meldOperatør()
        'Varsler transportør om sykler som må fraktes, når og hvor de skal fraktes
        sendMail.info = fra.ToString() & vbNewLine
        Dim sykkelMail, utstyrMail As String

        sykkelMail = String.Join(vbNewLine, lstSykkel.Items.Cast(Of String))
        sendMail.info = sendMail.info & sykkelMail & vbNewLine

        utstyrMail = String.Join(" ", lstSykkel.Items.Cast(Of String))
        sendMail.info = sendMail.info & utstyrMail & vbNewLine
        sendMail.info = sendMail.info & cmbUtlevering.Text
        sendMail.Show()
    End Sub
End Class
Imports MySql.Data.MySqlClient
Public Class Leieavtaler
    Private fraDag, fraTime, tilDag, tilTime As Date
    Private kunde_nr, sykkel_id, utstyr_id, innlogget, søk, valgt, fra, til, prisgrunnlag As String
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

    Private Sub Leieavtaler_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        'Viser innlogget avdeling
        lblInnloggetAvdeling.Text = "Innlogget på avdeling " & Innlogging.innloggetAvdeling.HentAvdelingNavn
    End Sub

    Private Sub Leieavtaler_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Legger til avdelingsvalg for innlevering og utlevering
        For Each avdeling In AdministrereAvdeling.avdelingValg
            cmbUtlevering.Items.Add(avdeling)
            cmbInnlevering.Items.Add(avdeling)
        Next
        innlogget = Innlogging.innloggetAvdeling.HentAvdelingNr
        'Setter datovelger til dagens dato
        dtpFraDato.Value = Date.Now
        dtpFraTime.Value = Date.Now
        dtpTilDato.Value = Date.Now
        dtpTilTime.Value = Date.Now
    End Sub

    Private Sub TømSkjema()
        lstTidspunkt.Items.Clear()
        lstKunde.Items.Clear()
        lstSykkel.Items.Clear()
        lstUtstyr.Items.Clear()
        SykkelKode.Clear()
        txtRabatt.Text = ""
        txtPrisFør.Text = ""
        txtPrisEtter.Text = ""
        prisFørRabatt = 0
        valgtSykkelID.Clear()
        valgtUtstyrID.Clear()
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
        'Henter ut tidspunkt og konverterer til sql-format
        fraDag = dtpFraDato.Value
        fraTime = dtpFraTime.Value
        fra = fraDag.ToString("yyyy-MM-dd") & " " & fraTime.ToString("HH") & ":00:00"
        tilDag = dtpTilDato.Value
        tilTime = dtpTilTime.Value
        til = tilDag.ToString("yyyy-MM-dd") & " " & tilTime.ToString("HH") & ":00:00"
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
        MsgBox(tidnå)
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
            Dim spørring As String
            'Henter kundetabell
            AdministrereKunde.hentKunde()
            'Henter inn tabell over ledige sykler basert på valgt dato
            spørring = "SELECT * FROM sykkel WHERE avdeling_nr = @innlogget AND sykkel_id NOT IN
                       (SELECT sykkel_id FROM utleid_sykkel WHERE leieavtale_nr IN 
                       (SELECT leieavtale_nr FROM leieavtale WHERE '" &
                           fra & "' < tidspunkt_til AND '" &
                           til & "' > tidspunkt_fra))"
            AdministrereSykkel.hentSykkel(spørring)
            'Henter inn tabell over ledig utstyr basert på valgt dato
            spørring = "SELECT * FROM utstyr WHERE avdeling_nr = @innlogget AND utstyr_id NOT IN
                       (SELECT utstyr_id FROM utleid_utstyr WHERE leieavtale_nr IN 
                       (SELECT leieavtale_nr FROM leieavtale WHERE '" &
                           fra & "' < tidspunkt_til AND '" &
                           til & "' > tidspunkt_fra))"
            AdministrereUtstyr.hentUtstyr(spørring)

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
        'Sjekker at hele skjemaet er fylt ut
        Dim utfylt As Boolean
        If lstTidspunkt.Items.Count > 0 And
        lstKunde.Items.Count > 0 And
        lstSykkel.Items.Count > 0 And
        cmbUtlevering.Text <> "" And
        cmbInnlevering.Text <> "" Then
            utfylt = True
        End If

        'Registrerer leieavtale i database dersom validering er ok
        If utfylt = True Then

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
                    .AddWithValue("@pris", prisEtterRabatt)
                    .AddWithValue("@tidspunkt_fra", fra)
                    .AddWithValue("@tidspunkt_til", til)
                    .AddWithValue("@status", "Aktiv")
                    .AddWithValue("@kunde_nr", valgtKundeNr)
                    .AddWithValue("@avdeling_nr", innlogget)
                End With
                sql.ExecuteNonQuery()

                'Henter leieavtale_nr på sist opprettede leieavtale
                Dim sql2 As New MySqlCommand("SELECT MAX(leieavtale_nr) FROM leieavtale", tilkobling)
                Dim leieavtale_nr As Integer = sql2.ExecuteScalar()

                'Kobler valgte sykler til leieavtalen
                For i = 0 To valgtSykkelID.Count - 1
                    Dim sql3 As New MySqlCommand("INSERT INTO utleid_sykkel VALUES (@leieavtale_nr, @sykkel_id)", tilkobling)
                    With sql3.Parameters
                        .AddWithValue("@leieavtale_nr", leieavtale_nr)
                        .AddWithValue("@sykkel_id", valgtSykkelID(i))
                    End With
                    sql3.ExecuteNonQuery()
                Next

                'Kobler valgt utstyr til leieavtalen
                For i = 0 To valgtUtstyrID.Count - 1
                    Dim sql4 As New MySqlCommand("INSERT INTO utleid_utstyr VALUES (@leieavtale_nr, @utstyr_id)", tilkobling)
                    With sql4.Parameters
                        .AddWithValue("@leieavtale_nr", leieavtale_nr)
                        .AddWithValue("@utstyr_id", valgtSykkelID(i))
                    End With
                    sql4.ExecuteNonQuery()
                Next

                MsgBox("Avtale registrert")
                tilkobling.Close()
                TømSkjema()
            Catch feilmelding As MySqlException
                MsgBox(feilmelding.Message)
            Finally
                tilkobling.Dispose()
            End Try

        Else
            MsgBox("Skjema er ikke korrekt utfylt")
        End If
    End Sub

    Private Sub btnHent_Click(sender As Object, e As EventArgs) Handles btnHent.Click
        'Fjerner tidligere resultat
        lstLeieavtaler.Items.Clear()
        LeieavtaleTabell.Clear()
        'Henter alle leieavtaler tilhørende avdelingen med status aktiv
        innlogget = Innlogging.innloggetAvdeling.HentAvdelingNr()
        Try
            databasetilkobling.databaseTilkobling()
            tilkobling.Open()
            Dim sql As New MySqlCommand("SELECT l.*, fornavn, etternavn, telefon FROM leieavtale l INNER JOIN kunde k
                                        ON l.kunde_nr = k.kunde_nr WHERE status = 'Aktiv'", tilkobling)
            sql.Parameters.AddWithValue("@innlogget", innlogget)
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
            lstLeieavtaler.Items.Add(rad("leieavtale_nr") & " " & rad("etternavn") & ", " & rad("fornavn"))
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
            txtLeieavtaleNr.Text = rad("leieavtale_nr")
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

    Private Sub btnTømSkjema_Click(sender As Object, e As EventArgs) Handles btnTømSkjema.Click
        TømSkjema()
    End Sub

    Private Sub btnTilbake_Click(sender As Object, e As EventArgs) Handles btnTilbake.Click
        Hovedmeny.Show()
        Me.Hide()
    End Sub
End Class
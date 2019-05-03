Imports MySql.Data.MySqlClient
Public Class Leieavtaler
    Private fraDag, fraTime, tilDag, tilTime As Date
    Private kunde_nr, sykkel_id, utstyr_id, innlogget, søk, valgt, fra, til, prisgrunnlag As String
    Private dager, timer, prisFørRabatt As Integer
    Private valgtIndeks As Integer = -1
    Private SykkelKode As New List(Of String)
    Private UtstyrKode As New List(Of String)
    Private rad As DataRow

    Private Sub Leieavtaler_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Legger til avdelingsvalg for innlevering og utlevering
        For Each avdeling In AdministrereAvdeling.avdelingValg
            cmbUtlevering.Items.Add(avdeling)
            cmbInnlevering.Items.Add(avdeling)
        Next
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
        txtPrisFør.Text = prisFørRabatt
    End Sub

    Private Sub btnTid_Click(sender As Object, e As EventArgs) Handles btnTid.Click
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
            MsgBox("Tidspunkt til må være etter fra")
        End If

        'Velger tidspunkt hvis valideringen er ok
        If valider = True Then
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
                       (SELECT sykkel_id FROM utleid_sykkel WHERE leieavtale_nr = 
                       (SELECT leieavtale_nr FROM leieavtale WHERE '" &
                           fra & "' < tidspunkt_til AND '" &
                           til & "' > tidspunkt_fra))"
            AdministrereSykkel.hentSykkel(spørring)
            'Henter inn tabell over ledig utstyr basert på valgt dato
            spørring = "SELECT * FROM utstyr WHERE avdeling_nr = @innlogget AND utstyr_id NOT IN
                       (SELECT utstyr_id FROM utleid_utstyr WHERE leieavtale_nr = 
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
        Dim valgtSykkel = rad(0) & " " & rad(1) & " " & rad(2)
        'Sjekker om samme sykkel allerede er lagt til
        If lstSykkel.FindString(rad(0)) = -1 Then
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
        Dim valgtUtstyr = rad(0) & " " & rad(1) & " " & rad(2)

        'Sjekker om det er lagt til sykkel
        If lstSykkel.Items.Count <> 0 Then
            'Sjekker om utstyr allerede er lagt til
            If lstUtstyr.FindString(rad(0)) = -1 Then
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
        lstSykkel.Items.Count > 0 Then
            utfylt = True
        End If
        If utfylt = True Then
            MsgBox("ok")
        End If
    End Sub

    Private Sub btnTømSkjema_Click(sender As Object, e As EventArgs) Handles btnTømSkjema.Click
        lstTidspunkt.Items.Clear()
        lstKunde.Items.Clear()
        lstSykkel.Items.Clear()
        lstUtstyr.Items.Clear()
        SykkelKode.Clear()
        txtRabatt.Text = ""
        txtPrisFør.Text = ""
        txtPrisEtter.Text = ""
        prisFørRabatt = 0
    End Sub

    Private Sub btnTilbake_Click(sender As Object, e As EventArgs) Handles btnTilbake.Click
        Hovedmeny.Show()
        Me.Hide()
    End Sub
End Class
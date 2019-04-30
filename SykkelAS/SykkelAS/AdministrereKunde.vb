Imports MySql.Data.MySqlClient
Public Class AdministrereKunde
    Private fornavn, etternavn, adresse, telefon, epost, postnummer As String
    Private innlogget, nr As Integer
    Private maxRader, inc As Integer
    Private kundetabell As New DataTable
    Private rad As DataRow

    Private Sub AdminstrereKunde_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        'Viser innlogget avdeling
        lblInnloggetAvdeling.Text = "Innlogget på avdeling " & Innlogging.innloggetAvdeling.HentAvdelingNavn
    End Sub

    Private Sub TømSkjema()
        txtKundenummer.Text = ""
        txtFornavn.Text = ""
        txtEtternavn.Text = ""
        txtTelefon.Text = ""
        txtEpost.Text = ""
        txtAdresse.Text = ""
        txtPostnummer.Text = ""
        txtSted.Text = ""
    End Sub

    Private Sub hentKunde()
        kundetabell.Clear()
        Try
            databasetilkobling.databaseTilkobling()
            tilkobling.Open()
            Dim sql As New MySqlCommand("SELECT k.*, s.poststed FROM kunde k INNER JOIN sted s ON k.postnummer = s.postnummer", tilkobling)
            Dim da As New MySqlDataAdapter
            da.SelectCommand = sql
            da.Fill(kundetabell)
            tilkobling.Close()
        Catch feilmelding As MySqlException
            MsgBox(feilmelding.Message)
        Finally
            tilkobling.Dispose()
        End Try
        maxRader = kundetabell.Rows.Count
        'Resetter navigering
        inc = -1
    End Sub

    'Henter info fra tabell og legger i skjema
    Private Sub TabellTilSkjema(ByVal indeks As Integer)
        TømSkjema()
        rad = kundetabell.Rows(indeks)
        txtKundenummer.Text = rad(0)
        txtFornavn.Text = rad(1)
        txtEtternavn.Text = rad(2)
        txtAdresse.Text = rad(3)
        txtTelefon.Text = rad(4)
        txtEpost.Text = rad(5)
        txtPostnummer.Text = rad(6)
        txtSted.Text = rad(7)
    End Sub

    'Henter info fra skjema og legger i variabler
    Private Sub SkjemaTilVariabel()
        If txtKundenummer.Text <> "" Then
            nr = txtKundenummer.Text
        End If
        fornavn = txtFornavn.Text
        etternavn = txtEtternavn.Text
        telefon = txtTelefon.Text
        epost = txtEpost.Text
        adresse = txtAdresse.Text
        postnummer = txtPostnummer.Text
    End Sub

    Private Sub AdministrereKunde_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        hentKunde()
    End Sub

    Private Sub btnNeste_Click(sender As Object, e As EventArgs) Handles btnNeste.Click
        If inc < maxRader - 1 Then
            inc = inc + 1
            TabellTilSkjema(inc)
        Else
            MsgBox("Siste oppføring")
        End If
    End Sub

    Private Sub btnSiste_Click(sender As Object, e As EventArgs) Handles btnSiste.Click
        If inc <> maxRader - 1 Then
            inc = maxRader - 1
            TabellTilSkjema(inc)
        End If
    End Sub

    Private Sub btnForrige_Click(sender As Object, e As EventArgs) Handles btnForrige.Click
        If inc > 0 Then
            inc = inc - 1
            TabellTilSkjema(inc)
        ElseIf inc = -1 Then
            MsgBox("Ingen oppføringer enda")
        Else
            MsgBox("Første oppføring")
        End If
    End Sub

    Private Sub btnFørste_Click(sender As Object, e As EventArgs) Handles btnFørste.Click
        If inc <> 0 Then
            inc = 0
            TabellTilSkjema(inc)
        End If
    End Sub

    Private Sub btnOppdater_Click(sender As Object, e As EventArgs) Handles btnOppdater.Click
        'Henter prosedyre for å lese inn fra skjema
        SkjemaTilVariabel()
        'Oppretter et nytt objekt basert på informasjonen
        Dim oppdatertKunde As New Kunde(nr, fornavn, etternavn, telefon, epost, adresse, postnummer)
        'Henter metode for å oppdatere kunde i database
        oppdatertKunde.OppdaterKunde()
        'Sletter tekstfelt etter oppdatering
        TømSkjema()
        'Henter inn ny kundetabell
        hentKunde()
    End Sub

    Private Sub btnOpprett_Click(sender As Object, e As EventArgs) Handles btnOpprett.Click
        'Henter prosedyre for å lese inn fra skjema
        SkjemaTilVariabel()
        'Oppretter et nytt objekt basert på informasjonen
        Dim nyKunde As New Kunde(nr, fornavn, etternavn, telefon, epost, adresse, postnummer)
        'Henter metode for å opprette kunde i database
        nyKunde.OpprettKunde()
        'Sletter tekstfelt etter oppdatering
        TømSkjema()
        'Henter inn ny kundetabell
        hentKunde()
    End Sub

    Private Sub btnSlettKunde_Click(sender As Object, e As EventArgs) Handles btnSlettKunde.Click
        'Sletter valgt kunde fra database
        If MsgBox("Er du sikker på at du vil slette kunden?",
                  MsgBoxStyle.YesNo, "OBS!") = MsgBoxResult.Yes Then
            nr = txtKundenummer.Text
            Try
                databasetilkobling.databaseTilkobling()
                tilkobling.Open()
                Dim sql As New MySqlCommand("DELETE FROM kunde WHERE kunde_nr = @nr", tilkobling)
                sql.Parameters.AddWithValue("@nr", nr)
                sql.ExecuteNonQuery()
                MsgBox("Kunde slettet")
                tilkobling.Close()
            Catch feilmelding As MySqlException
                MsgBox(feilmelding.Message)
            Finally
                tilkobling.Dispose()
            End Try
            'Sletter tekstfelt etter oppdatering
            TømSkjema()
            'Henter in ny kundetabell
            hentKunde()
        End If
    End Sub

    Private Sub btnTømSkjema_Click(sender As Object, e As EventArgs) Handles btnTømSkjema.Click
        TømSkjema()
        inc = -1
    End Sub

    Private Sub btnSøk_Click(sender As Object, e As EventArgs) Handles btnSøk.Click
        'Sletter tidligere søkeresultat
        lstResultat.Items.Clear()
        'Søker gjennom kundetabell
        Dim søk As String
        søk = txtSok.Text
        'Første loop går gjennom hver rad i tabellen
        For Each rad In kundetabell.Rows
            'Andre loop går gjennom hver celle i hver enkelt rad
            'Bruker ToLower for å kunne søke uavhengig av stor/liten bokstav
            For i = 0 To kundetabell.Columns.Count - 1
                If CStr(rad(i)).ToLower = søk.ToLower Then
                    Dim resultat = rad(0) & " " & rad(2) & ", " & rad(1)
                    lstResultat.Items.Add(resultat)
                End If
            Next i
        Next rad
    End Sub

    Private Sub lstResultat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstResultat.SelectedIndexChanged
        TømSkjema()
        'Oppdaterer tekstfelt med valgt søkeresultat
        'Skjer bare hvis man klikker på en kunde i listeboksen
        If lstResultat.SelectedItem <> "" Then
            Dim valgt As String = lstResultat.SelectedItem
            'Henter nr til valgt kunde (tallet helt til venstre i resultatet)
            nr = CInt(valgt.Split(" ")(0))
            'Setter startindeks til -1 
            Dim valgtIndeks = -1
            'Henter ut riktig indeks i kundetabell for valgt kunde
            Dim i As Integer
            For i = 0 To kundetabell.Rows.Count - 1
                'Sjekker første kolonne i hver rad etter nr til valgt kunde
                If kundetabell.Rows(i).Item(0) = nr Then
                    valgtIndeks = i
                    Exit For
                End If
            Next i
            'Henter prosedyre for å skrive til tekstfelt
            TabellTilSkjema(valgtIndeks)
            'Oppdaterer posisjon på navigering
            inc = valgtIndeks
        End If
    End Sub

    Private Sub btnTilbake_Click(sender As Object, e As EventArgs) Handles btnTilbake.Click
        Hovedmeny.Show()
        Me.Hide()
    End Sub
End Class
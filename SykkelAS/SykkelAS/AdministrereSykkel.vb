Imports MySql.Data.MySqlClient
Public Class AdministrereSykkel
    Private merke, type, ramme, hjul, gir, vekt, rammenummer, lokasjon, status As String
    Private innlogget, id, pris_time, pris_dag, pris_helg, avdeling_nr As Integer
    Private maxRader, inc As Integer
    Public sykkeltabell As New DataTable
    Private rad As DataRow
    Private spørring As String = "SELECT * FROM sykkel WHERE avdeling_nr = @innlogget"

    Private Sub AdminstrereSykkel_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        'Viser innlogget avdeling
        lblInnloggetAvdeling.Text = "Innlogget på avdeling " & Innlogging.innloggetAvdeling.HentAvdelingNavn
    End Sub

    Private Sub TømSkjema()
        txtSykkelID.Text = ""
        txtSykkelMerke.Text = ""
        cmbSykkelType.SelectedIndex = -1
        txtSykkelRamme.Text = ""
        txtSykkelHjul.Text = ""
        txtSykkelGir.Text = ""
        txtSykkelVekt.Text = ""
        txtSykkelRammeNummer.Text = ""
        txtPrisTime.Text = ""
        txtPrisDag.Text = ""
        txtPrisHelg.Text = ""
        cmbLokasjon.SelectedIndex = -1
        cmbStatus.SelectedIndex = -1
        txtAvdeling.Text = ""
    End Sub

    Public Sub hentSykkel(ByVal spørring As String)
        'Henter avdelingsnummer til innlogget avdeling
        innlogget = Innlogging.innloggetAvdeling.HentAvdelingNr()
        sykkeltabell.Clear()
        Try
            databasetilkobling.databaseTilkobling()
            tilkobling.Open()
            'Henter kun sykler som tilhører avdelingen
            Dim sql As New MySqlCommand(spørring, tilkobling)
            sql.Parameters.AddWithValue("@innlogget", innlogget)
            Dim da As New MySqlDataAdapter
            da.SelectCommand = sql
            da.Fill(sykkeltabell)
            tilkobling.Close()
        Catch feilmelding As MySqlException
            MsgBox(feilmelding.Message)
        Finally
            tilkobling.Dispose()
        End Try
        maxRader = sykkeltabell.Rows.Count
        'Resetter navigering
        inc = -1
    End Sub

    Private Sub btnSendMail_Click(sender As Object, e As EventArgs) Handles btnSendMail.Click
        sendMail.info = "ID: " & rad(0) & vbNewLine
        sendMail.info = sendMail.info & "Merke: " & rad(1) & vbNewLine
        sendMail.info = sendMail.info & "Type: " & rad(2) & vbNewLine
        sendMail.info = sendMail.info & "Hjul: " & rad(3) & vbNewLine
        sendMail.info = sendMail.info & "Gir: " & rad(4) & vbNewLine
        sendMail.info = sendMail.info & "Vekt: " & rad(5) & vbNewLine
        sendMail.info = sendMail.info & "Rammenummer: " & rad(6) & vbNewLine
        sendMail.Show()
    End Sub

    'Henter info fra tabell og legger i skjema
    Private Sub TabellTilSkjema(ByVal indeks As Integer)
        TømSkjema()
        rad = sykkeltabell.Rows(indeks)
        txtSykkelID.Text = rad(0)
        txtSykkelMerke.Text = rad(1)
        cmbSykkelType.Text = rad(2)
        txtSykkelRamme.Text = rad(3)
        txtSykkelHjul.Text = rad(4)
        txtSykkelGir.Text = rad(5)
        txtSykkelVekt.Text = rad(6)
        txtSykkelRammeNummer.Text = rad(7)
        txtPrisTime.Text = rad(8)
        txtPrisDag.Text = rad(9)
        txtPrisHelg.Text = rad(10)
        cmbLokasjon.Text = rad(11)
        cmbStatus.Text = rad(12)
        txtAvdeling.Text = rad(13)
    End Sub

    'Henter info fra skjema og legger i variabler
    Private Sub SkjemaTilVariabel()
        If txtSykkelID.Text <> "" Then
            id = txtSykkelID.Text
        End If
        merke = txtSykkelMerke.Text
        type = cmbSykkelType.Text
        ramme = txtSykkelRamme.Text
        hjul = txtSykkelHjul.Text
        gir = txtSykkelGir.Text
        vekt = txtSykkelVekt.Text
        rammenummer = txtSykkelRammeNummer.Text
        pris_time = txtPrisTime.Text
        pris_dag = txtPrisDag.Text
        pris_helg = txtPrisHelg.Text
        lokasjon = cmbLokasjon.Text
        status = cmbStatus.Text
        If txtAvdeling.Text <> "" Then
            avdeling_nr = txtAvdeling.Text
        End If
    End Sub

    Private Sub AdministrereSykkel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        hentSykkel(spørring)
        'Oppdaterer liste for å velge mulige lokasjoner
        For Each avdeling In AdministrereAvdeling.avdelingValg
            cmbLokasjon.Items.Add(avdeling)
        Next
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
        Dim oppdatertSykkel As New Sykkel(id, merke, type, ramme, hjul, gir, vekt, rammenummer,
                                          pris_time, pris_dag, pris_helg, lokasjon, status, avdeling_nr)
        'Henter metode for å oppdatere sykkel i database
        oppdatertSykkel.OppdaterKunde()
        'Sletter tekstfelt etter oppdatering
        TømSkjema()
        'Henter inn ny sykkeltabell
        hentSykkel(spørring)
    End Sub

    Private Sub btnOpprett_Click(sender As Object, e As EventArgs) Handles btnOpprett.Click
        'Henter prosedyre for å lese inn fra skjema
        SkjemaTilVariabel()
        avdeling_nr = Innlogging.innloggetAvdeling.HentAvdelingNr()
        'Oppretter et nytt objekt basert på informasjonen
        Dim nySykkel As New Sykkel(id, merke, type, ramme, hjul, gir, vekt, rammenummer,
                                   pris_time, pris_dag, pris_helg, lokasjon, status, avdeling_nr)
        'Henter metode for å opprette sykkel i database
        nySykkel.OpprettKunde()
        'Sletter tekstfelt etter oppdatering
        TømSkjema()
        'Henter inn ny sykkeltabell
        hentSykkel(spørring)
    End Sub

    Private Sub btnSlettSykkel_Click(sender As Object, e As EventArgs) Handles btnSlettSykkel.Click
        'Sletter valgt sykkel fra database
        If MsgBox("Er du sikker på at du vil slette sykkelen?",
                  MsgBoxStyle.YesNo, "OBS!") = MsgBoxResult.Yes Then
            id = txtSykkelID.Text
            Try
                databasetilkobling.databaseTilkobling()
                tilkobling.Open()
                Dim sql As New MySqlCommand("DELETE FROM sykkel WHERE sykkel_id = @id", tilkobling)
                sql.Parameters.AddWithValue("@id", id)
                sql.ExecuteNonQuery()
                MsgBox("Sykkel slettet")
                tilkobling.Close()
            Catch feilmelding As MySqlException
                MsgBox(feilmelding.Message)
            Finally
                tilkobling.Dispose()
            End Try
            'Sletter tekstfelt etter oppdatering
            TømSkjema()
            'Henter in ny sykkeltabell
            hentSykkel(spørring)
        End If
    End Sub

    Private Sub btnTømSkjema_Click(sender As Object, e As EventArgs) Handles btnTømSkjema.Click
        TømSkjema()
        inc = -1
    End Sub

    Private Sub btnSøk_Click(sender As Object, e As EventArgs) Handles btnSøk.Click
        'Sletter tidligere søkeresultat
        lstResultat.Items.Clear()
        'Søker gjennom sykkeltabell
        Dim søk As String
        søk = txtSok.Text
        'Første loop går gjennom hver rad i tabellen
        For Each rad In sykkeltabell.Rows
            'Andre loop går gjennom hver celle i hver enkelt rad
            'Stopper på 12 for å ikke søke på avdeling_nr
            'Bruker ToLower for å kunne søke uavhengig av stor/liten bokstav
            For i = 0 To 12
                If CStr(rad(i)).ToLower.IndexOf(søk.ToLower()) > -1 Then
                    Dim resultat = rad(0) & " " & rad(1) & " " & rad(2)
                    lstResultat.Items.Add(resultat)
                End If
            Next i
        Next
    End Sub

    Private Sub lstResultat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstResultat.SelectedIndexChanged
        TømSkjema()
        'Oppdaterer tekstfelt med valgt søkeresultat
        'Skjer bare hvis man klikker på en sykkel i listeboksen
        If lstResultat.SelectedItem <> "" Then
            Dim valgt As String = lstResultat.SelectedItem
            'Henter id til valgt sykkel (tallet helt til venstre i resultatet)
            id = CInt(valgt.Split(" ")(0))
            'Setter startindeks til -1 
            Dim valgtIndeks = -1
            'Henter ut riktig indeks i sykkeltabell for valgt sykkel
            Dim i As Integer
            For i = 0 To sykkeltabell.Rows.Count - 1
                'Sjekker første kolonne i hver rad etter id til valgt sykkel
                If sykkeltabell.Rows(i).Item(0) = id Then
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
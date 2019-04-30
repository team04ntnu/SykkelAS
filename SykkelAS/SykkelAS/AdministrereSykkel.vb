Imports MySql.Data.MySqlClient
Public Class AdministrereSykkel
    Private merke, type, ramme, hjul, gir, vekt, rammenummer, lokasjon, status As String
    Private innlogget, id, pris_time, pris_døgn, pris_helg, avdeling_nr As Integer
    Private maxRader, inc As Integer
    Private sykkeltabell As New DataTable
    Private rad As DataRow

    Private Sub AdminstrereSykkel_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        'Viser innlogget avdeling
        lblInnloggetAvdeling.Text = "Innlogget på avdeling " & Innlogging.innloggetAvdeling.HentAvdelingNavn
    End Sub

    Private Sub SlettTekstfelt()
        txtSykkelID.Text = ""
        txtSykkelMerke.Text = ""
        cmbSykkelType.Text = ""
        txtSykkelRamme.Text = ""
        txtSykkelHjul.Text = ""
        txtSykkelGir.Text = ""
        txtSykkelVekt.Text = ""
        txtSykkelRammeNummer.Text = ""
        txtPrisTime.Text = ""
        txtPrisDøgn.Text = ""
        txtPrisHelg.Text = ""
        cmbLokasjon.Text = ""
        cmbStatus.Text = ""
        txtAvdeling.Text = ""
    End Sub

    Private Sub hentSykkel()
        'Henter avdelingsnummer til innlogget avdeling
        innlogget = Innlogging.innloggetAvdeling.HentAvdelingNr()
        sykkeltabell.Clear()
        Try
            databasetilkobling.databaseTilkobling()
            tilkobling.Open()
            'Henter kun sykler som tilhører avdelingen
            Dim sql As New MySqlCommand("SELECT * FROM sykkel WHERE avdeling_nr = @innlogget", tilkobling)
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

    Private Sub naviger()
        SlettTekstfelt()
        rad = sykkeltabell.Rows(inc)
        txtSykkelID.Text = rad(0)
        txtSykkelMerke.Text = rad(1)
        cmbSykkelType.Text = rad(2)
        txtSykkelRamme.Text = rad(3)
        txtSykkelHjul.Text = rad(4)
        txtSykkelGir.Text = rad(5)
        txtSykkelVekt.Text = rad(6)
        txtSykkelRammeNummer.Text = rad(7)
        txtPrisTime.Text = rad(8)
        txtPrisDøgn.Text = rad(9)
        txtPrisHelg.Text = rad(10)
        cmbLokasjon.Text = rad(11)
        cmbStatus.Text = rad(12)
        txtAvdeling.Text = rad(13)
    End Sub

    'Henter info fra skjema og legger i variabler
    Private Sub hentInfo()
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
        pris_døgn = txtPrisDøgn.Text
        pris_helg = txtPrisHelg.Text
        lokasjon = cmbLokasjon.Text
        status = cmbStatus.Text
        If txtAvdeling.Text <> "" Then
            avdeling_nr = txtAvdeling.Text
        End If
    End Sub

    Private Sub AdministrereSykkel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        hentSykkel()
        'Oppdaterer liste for å velge mulige lokasjoner
        For Each avdeling In AdministrereAvdeling.avdelingValg
            cmbLokasjon.Items.Add(avdeling)
        Next
    End Sub

    Private Sub btnNeste_Click(sender As Object, e As EventArgs) Handles btnNeste.Click
        If inc < maxRader - 1 Then
            inc = inc + 1
            naviger()
        Else
            MsgBox("Siste oppføring")
        End If
    End Sub

    Private Sub btnSiste_Click(sender As Object, e As EventArgs) Handles btnSiste.Click
        If inc <> maxRader - 1 Then
            inc = maxRader - 1
            naviger()
        End If
    End Sub

    Private Sub btnForrige_Click(sender As Object, e As EventArgs) Handles btnForrige.Click
        If inc > 0 Then
            inc = inc - 1
            naviger()
        ElseIf inc = -1 Then
            MsgBox("Ingen oppføringer enda")
        Else
            MsgBox("Første oppføring")
        End If
    End Sub

    Private Sub btnFørste_Click(sender As Object, e As EventArgs) Handles btnFørste.Click
        If inc <> 0 Then
            inc = 0
            naviger()
        End If
    End Sub

    Private Sub btnOppdater_Click(sender As Object, e As EventArgs) Handles btnOppdater.Click
        'Henter prosedyre for å lese inn fra skjema
        hentInfo()
        'Oppretter et nytt objekt basert på informasjonen
        Dim oppdatertSykkel As New Sykkel(id, merke, type, ramme, hjul, gir, vekt, rammenummer,
                                          pris_time, pris_døgn, pris_helg, lokasjon, status, avdeling_nr)
        'Henter metode for å oppdatere sykkel i database
        oppdatertSykkel.OppdaterSykkel()
        'Sletter tekstfelt etter oppdatering
        SlettTekstfelt()
        'Henter inn ny sykkeltabell
        hentSykkel()
    End Sub

    Private Sub btnOpprett_Click(sender As Object, e As EventArgs) Handles btnOpprett.Click
        'Henter prosedyre for å lese inn fra skjema
        hentInfo()
        avdeling_nr = Innlogging.innloggetAvdeling.HentAvdelingNr()
        'Oppretter et nytt objekt basert på informasjonen
        Dim nySykkel As New Sykkel(id, merke, type, ramme, hjul, gir, vekt, rammenummer,
                                   pris_time, pris_døgn, pris_helg, lokasjon, status, avdeling_nr)
        'Henter metode for å opprette sykkel i database
        nySykkel.OpprettSykkel()
        'Sletter tekstfelt etter oppdatering
        SlettTekstfelt()
        'Henter inn ny sykkeltabell
        hentSykkel()
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
            SlettTekstfelt()
            'Henter in ny sykkeltabell
            hentSykkel()
        End If
    End Sub

    Private Sub btnSlettTekstfelt_Click(sender As Object, e As EventArgs) Handles btnSlettTekstfelt.Click
        SlettTekstfelt()
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
                If CStr(rad(i)).ToLower = søk.ToLower Then
                    Dim resultat = rad(0) & " " & rad(1) & " " & rad(2)
                    lstResultat.Items.Add(resultat)
                End If
            Next i
        Next rad
    End Sub

    Private Sub lstResultat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstResultat.SelectedIndexChanged
        SlettTekstfelt()
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
            'Definerer rad som skal skrives til tekstfelt
            rad = sykkeltabell.Rows(valgtIndeks)
            txtSykkelID.Text = rad(0)
            txtSykkelMerke.Text = rad(1)
            cmbSykkelType.Text = rad(2)
            txtSykkelRamme.Text = rad(3)
            txtSykkelHjul.Text = rad(4)
            txtSykkelGir.Text = rad(5)
            txtSykkelVekt.Text = rad(6)
            txtSykkelRammeNummer.Text = rad(7)
            txtPrisTime.Text = rad(8)
            txtPrisDøgn.Text = rad(9)
            txtPrisHelg.Text = rad(10)
            cmbLokasjon.Text = rad(11)
            cmbStatus.Text = rad(12)
            txtAvdeling.Text = rad(13)
            'Oppdaterer posisjon på navigering
            inc = valgtIndeks
        End If
    End Sub

    Private Sub btnTilbake_Click(sender As Object, e As EventArgs) Handles btnTilbake.Click
        Hovedmeny.Show()
        Me.Hide()
    End Sub
End Class
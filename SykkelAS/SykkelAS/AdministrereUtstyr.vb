Imports MySql.Data.MySqlClient
Public Class AdministrereUtstyr
    Private merke, type, passer_til, lokasjon, status As String
    Private innlogget, id, pris_time, pris_dag, pris_helg, avdeling_nr As Integer
    Private maxRader, inc As Integer
    Public utstyrtabell As New DataTable
    Private rad As DataRow
    Private spørring As String = "SELECT * FROM utstyr WHERE avdeling_nr = @innlogget"

    Private Sub AdminstrereSykkel_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        'Viser innlogget avdeling
        lblInnloggetAvdeling.Text = "Innlogget på avdeling " & Innlogging.innloggetAvdeling.HentAvdelingNavn
    End Sub

    Private Sub TømSkjema()
        txtUtstyrID.Text = ""
        txtUtstyrMerke.Text = ""
        txtUtstyrType.Text = ""
        txtPrisTime.Text = ""
        txtPrisDag.Text = ""
        txtPrisHelg.Text = ""
        cmbLokasjon.SelectedIndex = -1
        cmbStatus.SelectedIndex = -1
        txtAvdeling.Text = ""
        chkAlle.Checked = False
        chkTerreng.Checked = False
        chkDownhill.Checked = False
        chkRacer.Checked = False
        chkTandem.Checked = False
        chkBarn.Checked = False
    End Sub

    Public Sub hentUtstyr(ByVal spørring As String)
        'Henter avdelingsnummer til innlogget avdeling
        innlogget = Innlogging.innloggetAvdeling.HentAvdelingNr()
        utstyrtabell.Clear()
        Try
            databasetilkobling.databaseTilkobling()
            tilkobling.Open()
            'Henter kun utstyr som tilhører avdelingen
            Dim sql As New MySqlCommand(spørring, tilkobling)
            sql.Parameters.AddWithValue("@innlogget", innlogget)
            Dim da As New MySqlDataAdapter
            da.SelectCommand = sql
            da.Fill(utstyrtabell)
            tilkobling.Close()
        Catch feilmelding As MySqlException
            MsgBox(feilmelding.Message)
        Finally
            tilkobling.Dispose()
        End Try
        maxRader = utstyrtabell.Rows.Count
        'Resetter navigering
        inc = -1
    End Sub

    'Henter info fra tabell og legger i skjema
    Private Sub TabellTilSkjema(ByVal indeks As Integer)
        TømSkjema()
        rad = utstyrtabell.Rows(indeks)
        txtUtstyrID.Text = rad(0)
        txtUtstyrMerke.Text = rad(1)
        txtUtstyrType.Text = rad(2)
        txtPrisTime.Text = rad(3)
        txtPrisDag.Text = rad(4)
        txtPrisHelg.Text = rad(5)
        cmbLokasjon.Text = rad(7)
        cmbStatus.Text = rad(8)
        txtAvdeling.Text = rad(9)
        Dim kode = rad(6)
        'Sjekker først om koden viser at utstyr passer til alle sykler
        If kode = "TDRMB" Then
            chkAlle.Checked = True
        Else
            'Deler opp koden i passer_til i individuelle bokstaver
            Dim koder() As Char = kode.ToCharArray
            Dim i As Integer
            'Krysser av korrekte bokser ut i fra kodene
            For i = 0 To koder.Length - 1
                If koder(i) = "T" Then
                    chkTerreng.Checked = True
                ElseIf koder(i) = "D" Then
                    chkDownhill.Checked = True
                ElseIf koder(i) = "R" Then
                    chkRacer.Checked = True
                ElseIf koder(i) = "M" Then
                    chkTandem.Checked = True
                ElseIf koder(i) = "B" Then
                    chkBarn.Checked = True
                End If
            Next i
        End If
    End Sub

    'Henter info fra skjema og legger i variabler
    Private Sub SkjemaTilVariabel()
        If txtUtstyrID.Text <> "" Then
            id = txtUtstyrID.Text
        End If
        merke = txtUtstyrMerke.Text
        type = txtUtstyrType.Text
        pris_time = txtPrisTime.Text
        pris_dag = txtPrisDag.Text
        pris_helg = txtPrisHelg.Text
        lokasjon = cmbLokasjon.Text
        status = cmbStatus.Text
        If txtAvdeling.Text <> "" Then
            avdeling_nr = txtAvdeling.Text
        End If
        Dim kode As String = ""
        If chkAlle.Checked = True Then
            kode = "TDRMB"
        End If
        If chkTerreng.Checked = True Then
            kode = "T"
        End If
        If chkDownhill.Checked = True Then
            kode = kode & "D"
        End If
        If chkRacer.Checked = True Then
            kode = kode & "R"
        End If
        If chkTandem.Checked = True Then
            kode = kode & "M"
        End If
        If chkBarn.Checked = True Then
            kode = kode & "B"
        End If
        passer_til = kode
    End Sub

    Private Sub AdministrereUtstyr_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        hentUtstyr(spørring)
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
        Dim oppdatertUtstyr As New Utstyr(id, merke, type, pris_time, pris_dag, pris_helg,
                                          passer_til, lokasjon, status, avdeling_nr)
        'Henter metode for å oppdatere utstyr i database
        oppdatertUtstyr.OppdaterUtstyr()
        'Sletter tekstfelt etter oppdatering
        TømSkjema()
        'Henter inn ny utstyrtabell
        hentUtstyr(spørring)
    End Sub

    Private Sub btnOpprett_Click(sender As Object, e As EventArgs) Handles btnOpprett.Click
        'Henter prosedyre for å lese inn fra skjema
        SkjemaTilVariabel()
        avdeling_nr = Innlogging.innloggetAvdeling.HentAvdelingNr()
        'Oppretter et nytt objekt basert på informasjonen
        Dim nyttUtstyr As New Utstyr(id, merke, type, pris_time, pris_dag, pris_helg,
                                     passer_til, lokasjon, status, avdeling_nr)
        'Henter metode for å opprette utstyr i database
        nyttUtstyr.OpprettUtstyr()
        'Sletter tekstfelt etter oppdatering
        TømSkjema()
        'Henter inn ny utstyrtabell
        hentUtstyr(spørring)
    End Sub

    Private Sub btnSlettUtstyr_Click(sender As Object, e As EventArgs) Handles btnSlettUtstyr.Click
        'Sletter valgt sykkel fra database
        If MsgBox("Er du sikker på at du vil slette utstyret?",
                  MsgBoxStyle.YesNo, "OBS!") = MsgBoxResult.Yes Then
            id = txtUtstyrID.Text
            Try
                databasetilkobling.databaseTilkobling()
                tilkobling.Open()
                Dim sql As New MySqlCommand("DELETE FROM utstyr WHERE utstyr_id = @id", tilkobling)
                sql.Parameters.AddWithValue("@id", id)
                sql.ExecuteNonQuery()
                MsgBox("Utstyr slettet")
                tilkobling.Close()
            Catch feilmelding As MySqlException
                MsgBox(feilmelding.Message)
            Finally
                tilkobling.Dispose()
            End Try
            'Sletter tekstfelt etter oppdatering
            TømSkjema()
            'Henter in ny utstyrtabell
            hentUtstyr(spørring)
        End If
    End Sub

    Private Sub chkAlle_CheckedChanged(sender As Object, e As EventArgs) Handles chkAlle.CheckedChanged
        'Dersom man krysser av for alle sykler, går det ikke an å krysse av for individuelle sykler
        If chkAlle.Checked = True Then
            chkTerreng.Enabled = False
            chkDownhill.Enabled = False
            chkRacer.Enabled = False
            chkTandem.Enabled = False
            chkBarn.Enabled = False
        End If
        If chkAlle.Checked = False Then
            chkTerreng.Enabled = True
            chkDownhill.Enabled = True
            chkRacer.Enabled = True
            chkTandem.Enabled = True
            chkBarn.Enabled = True
        End If
    End Sub

    Private Sub btnSendMail_Click(sender As Object, e As EventArgs) Handles btnSendMail.Click
        sendMail.info = "ID: " & rad(0) & vbNewLine
        sendMail.info = sendMail.info & "Merke: " & rad(1) & vbNewLine
        sendMail.info = sendMail.info & "Type: " & rad(2) & vbNewLine
        sendMail.Show()
    End Sub

    Private Sub Check()
        'Dersom man krysser av for individuelle sykler, går det ikke an å krysse av for alle sykler
        If chkTerreng.Checked = True Or
            chkDownhill.Checked = True Or
            chkRacer.Checked = True Or
            chkTandem.Checked = True Or
            chkBarn.Checked = True Then
            chkAlle.Enabled = False
        ElseIf chkTerreng.Checked = False Or
            chkDownhill.Checked = False Or
            chkRacer.Checked = False Or
            chkTandem.Checked = False Or
            chkBarn.Checked = False Then
            chkAlle.Enabled = True
        End If
    End Sub

    Private Sub chkTerreng_CheckedChanged(sender As Object, e As EventArgs) Handles chkTerreng.CheckedChanged
        Check()
    End Sub

    Private Sub chkDownhill_CheckedChanged(sender As Object, e As EventArgs) Handles chkDownhill.CheckedChanged
        Check()
    End Sub

    Private Sub chkRacer_CheckedChanged(sender As Object, e As EventArgs) Handles chkRacer.CheckedChanged
        Check()
    End Sub

    Private Sub chkTandem_CheckedChanged(sender As Object, e As EventArgs) Handles chkTandem.CheckedChanged
        Check()
    End Sub

    Private Sub chkBarn_CheckedChanged(sender As Object, e As EventArgs) Handles chkBarn.CheckedChanged
        Check()
    End Sub

    Private Sub btnTømSkjema_Click(sender As Object, e As EventArgs) Handles btnTømSkjema.Click
        TømSkjema()
        inc = -1
    End Sub

    Private Sub btnSøk_Click(sender As Object, e As EventArgs) Handles btnSøk.Click
        'Sletter tidligere søkeresultat
        lstResultat.Items.Clear()
        'Søker gjennom utstyrtabell
        Dim søk As String
        søk = txtSok.Text
        'Første loop går gjennom hver rad i tabellen
        For Each rad In utstyrtabell.Rows
            'Andre loop går gjennom hver celle i hver enkelt rad
            'Stopper på 12 for å ikke søke på avdeling_nr
            'Bruker ToLower for å kunne søke uavhengig av stor/liten bokstav
            For i = 0 To 8
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
        'Skjer bare hvis man klikker på utstyr i listeboksen
        If lstResultat.SelectedItem <> "" Then
            Dim valgt As String = lstResultat.SelectedItem
            'Henter id til valgt utstyr (tallet helt til venstre i resultatet)
            id = CInt(valgt.Split(" ")(0))
            'Setter startindeks til -1 
            Dim valgtIndeks = -1
            'Henter ut riktig indeks i utstyrtabell for valgt utstyr
            Dim i As Integer
            For i = 0 To utstyrtabell.Rows.Count - 1
                'Sjekker første kolonne i hver rad etter id til valgt utstyr
                If utstyrtabell.Rows(i).Item(0) = id Then
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
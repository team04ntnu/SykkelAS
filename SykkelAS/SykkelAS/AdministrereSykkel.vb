Imports MySql.Data.MySqlClient
Public Class AdministrereSykkel
    Private merke, type, ramme, hjul, gir, vekt, rammenummer, lokasjon, status As String
    Private innlogget, id, pris_time, pris_døgn, pris_helg, avdeling_nr As Integer
    Private maxRader, inc As Integer
    Private sykkeltabell As New DataTable
    Private sykkelrad As DataRow

    Private Sub SlettTekstfelt()
        txtSykkelID.Text = ""
        txtSykkelMerke.Text = ""
        txtSykkelType.Text = ""
        txtSykkelRamme.Text = ""
        txtSykkelHjul.Text = ""
        txtSykkelGir.Text = ""
        txtSykkelVekt.Text = ""
        txtSykkelRammeNummer.Text = ""
        txtPrisTime.Text = ""
        txtPrisDøgn.Text = ""
        txtPrisHelg.Text = ""
        txtLokasjon.Text = ""
        txtStatus.Text = ""
        'Resetter navigering
        inc = -1
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
    End Sub

    Private Sub naviger()
        sykkelrad = sykkeltabell.Rows(inc)
        txtSykkelID.Text = sykkelrad(0)
        txtSykkelMerke.Text = sykkelrad(1)
        txtSykkelType.Text = sykkelrad(2)
        txtSykkelRamme.Text = sykkelrad(3)
        txtSykkelHjul.Text = sykkelrad(4)
        txtSykkelGir.Text = sykkelrad(5)
        txtSykkelVekt.Text = sykkelrad(6)
        txtSykkelRammeNummer.Text = sykkelrad(7)
        txtPrisTime.Text = sykkelrad(8)
        txtPrisDøgn.Text = sykkelrad(9)
        txtPrisHelg.Text = sykkelrad(10)
        txtLokasjon.Text = sykkelrad(11)
        txtStatus.Text = sykkelrad(12)
        txtAvdeling.Text = sykkelrad(13)
    End Sub

    'Henter info fra tekstfelt og legger i variabler
    Private Sub hentInfo()
        id = txtSykkelID.Text
        merke = txtSykkelMerke.Text
        type = txtSykkelType.Text
        ramme = txtSykkelRamme.Text
        hjul = txtSykkelHjul.Text
        gir = txtSykkelGir.Text
        vekt = txtSykkelVekt.Text
        rammenummer = txtSykkelRammeNummer.Text
        pris_time = txtPrisTime.Text
        pris_døgn = txtPrisDøgn.Text
        pris_helg = txtPrisHelg.Text
        lokasjon = txtLokasjon.Text
        status = txtStatus.Text
        avdeling_nr = txtAvdeling.Text
    End Sub

    Private Sub AdministrereSykkel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        hentSykkel()
        maxRader = sykkeltabell.Rows.Count
        inc = -1
    End Sub

    Private Sub btnNeste_Click(sender As Object, e As EventArgs) Handles btnNeste.Click
        If inc < maxRader - 1 Then
            inc = inc + 1
            naviger()
        Else
            MsgBox("ingen flere sykler")
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
        'Henter prosedyre for å lese inn fra tekstfelt
        hentInfo()
        'Oppretter et nytt objekt basert på informasjonen
        Dim oppdatertSykkel As New Sykkel(id, merke, type, ramme, hjul, gir, vekt, rammenummer,
                                          pris_time, pris_døgn, pris_helg, lokasjon, status, avdeling_nr)
        'Henter metode for å oppdatere avdeling i database
        oppdatertSykkel.OppdaterSykkel()
        'Sletter tekstfelt etter at avdeling er oppdatert
        SlettTekstfelt()
        hentSykkel()
    End Sub

    Private Sub btnOpprett_Click(sender As Object, e As EventArgs) Handles btnOpprett.Click
        'Henter prosedyre for å lese inn fra tekstfelt
        hentInfo()
        'Oppretter et nytt objekt basert på informasjonen
        Dim nySykkel As New Sykkel(id, merke, type, ramme, hjul, gir, vekt, rammenummer,
                                   pris_time, pris_døgn, pris_helg, lokasjon, status, avdeling_nr)
        'Henter metode for å opprette avdeling i database
        nySykkel.OpprettSykkel()
        'Sletter tekstfelt etter at avdeling er opprettet
        SlettTekstfelt()
        hentSykkel()
    End Sub

    Private Sub btnSlett_Click(sender As Object, e As EventArgs) Handles btnSlett.Click
        SlettTekstfelt()
    End Sub

    Private Sub btnTilbake_Click(sender As Object, e As EventArgs) Handles btnTilbake.Click
        Hovedmeny.Show()
        Me.Hide()
    End Sub
End Class
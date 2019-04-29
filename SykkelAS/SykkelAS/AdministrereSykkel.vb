Imports MySql.Data.MySqlClient
Public Class AdministrereSykkel
    Private maxRader, inc, nr As Integer
    Private sykkeltabell As New DataTable
    Private sykkelrad As DataRow

    Private Sub hentSykkel()
        nr = Innlogging.innloggetAvdeling.HentAvdelingNr()
        Try
            databasetilkobling.databaseTilkobling()
            tilkobling.Open()
            Dim sql As New MySqlCommand("SELECT * FROM sykkel WHERE avdeling_nr = @nr", tilkobling)
            sql.Parameters.AddWithValue("@nr", nr)
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

    Private Sub naviger()
        sykkelrad = sykkeltabell.Rows(inc)
        txtSykkelNr.Text = sykkelrad(0)
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
        txtLokasjon.Text = sykkeltabell.Rows(inc).Item(11)
        txtStatus.Text = sykkeltabell.Rows(inc).Item(12)
    End Sub

    Private Sub btnTilbake_Click(sender As Object, e As EventArgs) Handles btnTilbake.Click
        Hovedmeny.Show()
        Me.Hide()
    End Sub
End Class
Imports MySql.Data.MySqlClient
Public Class AdministrereSykkel
    Private maxRader, inc, nr As Integer
    Private sykkeltabell As New DataTable

    Private Sub hentSykkel()
        nr = Innlogging.innloggetAvdeling.HentAvdelingNr()
        Try
            databasetilkobling.databaseTilkobling()
            tilkobling.Open()

            Dim sql As New MySqlCommand("SELECT * FROM sykkel WHERE avdeling_nr = @nr ", tilkobling)
            sql.Parameters.AddWithValue("@nr", nr)
            sql.ExecuteNonQuery()
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
        txtSykkelNr.Text = sykkeltabell.Rows(inc).Item(0)
        txtSykkelMerke.Text = sykkeltabell.Rows(inc).Item(1)
        txtSykkelType.Text = sykkeltabell.Rows(inc).Item(2)
        txtSykkelHjul.Text = sykkeltabell.Rows(inc).Item(3)
        txtSykkelGir.Text = sykkeltabell.Rows(inc).Item(4)
        txtSykkelRammeNummer.Text = sykkeltabell.Rows(inc).Item(5)
        txtPrisTime.Text = sykkeltabell.Rows(inc).Item(6)
        txtPrisDøgn.Text = sykkeltabell.Rows(inc).Item(7)
        txtPrisHelg.Text = sykkeltabell.Rows(inc).Item(8)
        txtLokasjon.Text = sykkeltabell.Rows(inc).Item(9)
        txtStatus.Text = sykkeltabell.Rows(inc).Item(10)
    End Sub

    Private Sub btnTilbake_Click(sender As Object, e As EventArgs) Handles btnTilbake.Click
        Hovedmeny.Show()
        Me.Hide()
    End Sub
End Class
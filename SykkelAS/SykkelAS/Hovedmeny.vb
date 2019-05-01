Public Class Hovedmeny
    Private Sub Hovedmeny_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        'Viser innlogget avdeling
        lblInnloggetAvdeling.Text = "Innlogget på avdeling " & Innlogging.innloggetAvdeling.HentAvdelingNavn
    End Sub

    Private Sub btnLoggUt_Click(sender As Object, e As EventArgs) Handles btnLoggUt.Click
        Innlogging.Show()
        Me.Hide()
    End Sub

    Private Sub btnKunde_Click(sender As Object, e As EventArgs) Handles btnKunde.Click
        AdministrereKunde.Show()
        Me.Hide()
    End Sub

    Private Sub btnSykkel_Click(sender As Object, e As EventArgs) Handles btnSykkel.Click
        AdministrereSykkel.Show()
        Me.Hide()
    End Sub

    Private Sub btnUtstyr_Click(sender As Object, e As EventArgs) Handles btnUtstyr.Click
        AdministrereUtstyr.Show()
        Me.Hide()
    End Sub

    Private Sub btnLeieavtaler_Click(sender As Object, e As EventArgs) Handles btnLeieavtaler.Click
        Leieavtaler.Show()
        Me.Hide()
    End Sub

    Private Sub btnSeStatistikk_Click(sender As Object, e As EventArgs) Handles btnSeStatistikk.Click
        Me.Hide()
        Statistikk.Show()
    End Sub
End Class
Public Class AdministrereSykkel
    Dim maxRader As Integer
    Dim inc As Integer


    Private Sub Administrator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Innlogging.innloggetAvdeling.hentSykkel()
        maxRader = Innlogging.innloggetAvdeling.sykkeltabell.Rows.Count
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
        txtSykkelNr.Text = Innlogging.innloggetAvdeling.sykkeltabell.Rows(inc).Item(0)
        txtSykkelMerke.Text = Innlogging.innloggetAvdeling.sykkeltabell.Rows(inc).Item(1)
        txtSykkelType.Text = Innlogging.innloggetAvdeling.sykkeltabell.Rows(inc).Item(2)
        txtSykkelHjul.Text = Innlogging.innloggetAvdeling.sykkeltabell.Rows(inc).Item(3)
        txtSykkelGir.Text = Innlogging.innloggetAvdeling.sykkeltabell.Rows(inc).Item(4)
        txtSykkelRammeNummer.Text = Innlogging.innloggetAvdeling.sykkeltabell.Rows(inc).Item(5)
        txtPrisTime.Text = Innlogging.innloggetAvdeling.sykkeltabell.Rows(inc).Item(6)
        txtPrisDøgn.Text = Innlogging.innloggetAvdeling.sykkeltabell.Rows(inc).Item(7)
        txtPrisHelg.Text = Innlogging.innloggetAvdeling.sykkeltabell.Rows(inc).Item(8)
        txtLokasjon.Text = Innlogging.innloggetAvdeling.sykkeltabell.Rows(inc).Item(9)
        txtStatus.Text = Innlogging.innloggetAvdeling.sykkeltabell.Rows(inc).Item(10)

    End Sub

End Class
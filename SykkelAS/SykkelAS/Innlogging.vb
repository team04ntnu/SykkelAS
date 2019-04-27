Imports MySql.Data.MySqlClient
Public Class Innlogging
    Private tilkobling As New MySqlConnection("Server=mysql.stud.iie.ntnu.no;Database=g_iini1010_04;Uid=g_iini1010_04;Pwd=QXXLn0wu")

    Private Sub Innlogging_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Fjerner tidligere oppføringer i avdelingsliste
        cmbAvdeling.Items.Clear()
        'Oppdaterer liste for å velge avdeling
        Administrator.OppdaterValg()
        For Each avdeling In Administrator.avdelingValg
            cmbAvdeling.Items.Add(avdeling)
        Next
    End Sub

    Private Sub btnLoggInn_Click(sender As Object, e As EventArgs) Handles btnLoggInn.Click
        'Sjekker om det er valgt avdeling
        If cmbAvdeling.Text = "" Then
            MsgBox("Du må velge en avdeling før du kan fortsette")
            'Sjekker om brukeren forsøker å logge inn som administrator
        ElseIf cmbAvdeling.Text = "admin" And txtPassord.Text = "admin" Then
            Administrator.Show()
            Me.Hide()
        Else
            MsgBox("Feil avdeling eller passord")
        End If
    End Sub

End Class

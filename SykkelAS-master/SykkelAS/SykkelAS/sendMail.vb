Imports System.Net.Mail
Public Class sendMail
    Public info As String
    Private Sub btnSendMail_Click(sender As Object, e As EventArgs) Handles btnSendMail.Click
        Dim server As New SmtpClient
        Dim email As New MailMessage()
        server.UseDefaultCredentials = False
        server.Credentials = New Net.NetworkCredential("sykkelas@yandex.com", "Test1234")
        server.Port = 587
        server.EnableSsl = True
        server.Host = "smtp.yandex.com"

        email = New MailMessage()
        email.From = New MailAddress("sykkelas@yandex.com")
        email.To.Add(txtTil.Text)
        email.Subject = txtEmne.Text
        email.Body = info & vbNewLine & "Kommentar: " & txtKommentar.Text
        Try

            server.Send(email)
            MsgBox("mail er sendt")
        Catch mailFeil As Exception
            MsgBox(mailFeil.ToString)
        End Try
        Me.Hide()
    End Sub
End Class
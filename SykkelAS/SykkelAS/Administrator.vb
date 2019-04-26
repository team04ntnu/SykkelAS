Public Class Administrator
    Private navn, telefon, epost, adresse, postnummer, passord As String

    Private Sub btnOppdater_Click(sender As Object, e As EventArgs) Handles btnOppdater.Click

    End Sub

    'Henter info fra tekstfelt og legger i variabler
    Private Sub hentInfo()
        navn = txtAvdelingsnavn.Text
        telefon = txtTelefon.Text
        epost = txtEpost.Text
        adresse = txtAdresse.Text
        postnummer = txtPostnummer.Text
        'Sjekker om passordene er skrevet inn likt
        If txtPassord.Text = txtBekreftPassord.Text Then
            passord = txtPassord.Text
        Else
            MsgBox("Passordene samsvarer ikke")
        End If
    End Sub

    Private Sub btnOpprett_Click(sender As Object, e As EventArgs) Handles btnOpprett.Click
        'Henter prosedyre for å lese inn fra tekstfelt
        hentInfo()
        'Oppretter et nytt objekt basert på informasjonen
        Dim nyAvdeling As New Avdeling(navn, telefon, epost, adresse, postnummer, passord)
        'Henter metode for å opprette avdeling i database
        'Legger til avdelingsnavn i nedrekksliste dersom den har blitt lagt til
        If nyAvdeling.Opprett() = True Then
            cmbAvdeling.Items.Add(navn)
            Innlogging.cmbAvdeling.Items.Add(navn)
        End If
    End Sub

    Private Sub btnSlett_Click(sender As Object, e As EventArgs) Handles btnSlett.Click
        'Knapp for å slette tekstfelt
        txtAvdelingsnavn.Text = ""
        txtTelefon.Text = ""
        txtEpost.Text = ""
        txtAdresse.Text = ""
        txtPostnummer.Text = ""
        txtPassord.Text = ""
        txtBekreftPassord.Text = ""
    End Sub

    Private Sub btnTilbake_Click(sender As Object, e As EventArgs) Handles btnTilbake.Click
        Innlogging.Show()
        Me.Hide()
    End Sub

End Class
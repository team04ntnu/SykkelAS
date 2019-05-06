Imports MySql.Data.MySqlClient
Public Class Innlogging
    'Private tilkobling As New MySqlConnection("Server=mysql.stud.iie.ntnu.no;Database=g_iini1010_04;Uid=g_iini1010_04;Pwd=QXXLn0wu")
    Private navn, telefon, epost, adresse, postnummer, passord As String



    Private nr As Integer
    Public innloggetAvdeling As Avdeling

    Private Sub Innlogging_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Fjerner tidligere oppføringer i avdelingsliste
        cmbAvdeling.Items.Clear()
        'Oppdaterer liste for å velge avdeling
        AdministrereAvdeling.OppdaterValg()
        For Each avdeling In AdministrereAvdeling.avdelingValg
            cmbAvdeling.Items.Add(avdeling)
        Next
    End Sub

    Private Sub btnLoggInn_Click(sender As Object, e As EventArgs) Handles btnLoggInn.Click
        'Sjekker om det er valgt avdeling
        If cmbAvdeling.Text = "" Then
            MsgBox("Du må velge en avdeling før du kan fortsette")
            'Sjekker om brukeren forsøker å logge inn som administrator
        ElseIf cmbAvdeling.Text = "admin" And txtPassord.Text = "admin" Then
            AdministrereAvdeling.Show()
            Me.Hide()
        ElseIf cmbAvdeling.Text <> "admin" Then
            'Setter variabelen navn til valgt avdeling
            navn = cmbAvdeling.Text
            'Henter info om valgt avdeling fra databasen
            Try
                databasetilkobling.databaseTilkobling()
                tilkobling.Open()
                Dim sql As New MySqlCommand("SELECT * FROM avdeling WHERE avdeling_navn = @navn", tilkobling)
                sql.Parameters.AddWithValue("@navn", navn)
                Dim leser = sql.ExecuteReader()
                While leser.Read()
                    nr = leser("avdeling_nr")
                    navn = leser("avdeling_navn")
                    telefon = leser("telefon")
                    epost = leser("epost")
                    adresse = leser("adresse")
                    postnummer = leser("postnummer")
                    passord = leser("passord")
                End While
            Catch feilmelding As MySqlException
                MsgBox(feilmelding.Message)
            Finally
                tilkobling.Dispose()
            End Try
            'Sammenligner lagret passord med det som er skrevet inn
            If txtPassord.Text = passord Then
                'Logger inn og oppretter et objekt dersom passord er korrekt
                innloggetAvdeling = New Avdeling(nr, navn, telefon, epost, adresse, postnummer, passord)
                'Hovedmeny.Show()
                Hovedmeny.Show()
                Me.Hide()
            Else
                MsgBox("Feil avdeling eller passord")
            End If
        Else
            MsgBox("Feil avdeling eller passord")
        End If
    End Sub
End Class

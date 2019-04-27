Imports MySql.Data.MySqlClient
Public Class Avdeling
    Private tilkobling As New MySqlConnection("Server=mysql.stud.iie.ntnu.no;Database=g_iini1010_04;Uid=g_iini1010_04;Pwd=QXXLn0wu")
    Private navn, telefon, epost, adresse, postnummer, passord As String

    'Konstruktør for å opprette avdeling
    Public Sub New(ByVal navn As String,
                   ByVal telefon As String,
                   ByVal epost As String,
                   ByVal adresse As String,
                   ByVal postnummer As String,
                   ByVal passord As String)
        Me.navn = navn
        Me.telefon = telefon
        Me.epost = epost
        Me.adresse = adresse
        Me.postnummer = postnummer
        Me.passord = passord
    End Sub

    'Metode for å opprette ny avdeling i databasen
    Public Sub Opprett()
        Try
            tilkobling.Open()

            Dim sql As New MySqlCommand("INSERT INTO avdeling (avdeling_navn, telefon, epost, adresse, postnummer, passord) 
                                        VALUES (@navn, @telefon, @epost, @adresse, @postnummer, @passord)", tilkobling)
            sql.Parameters.AddWithValue("@navn", navn)
            sql.Parameters.AddWithValue("@telefon", telefon)
            sql.Parameters.AddWithValue("@epost", epost)
            sql.Parameters.AddWithValue("@adresse", adresse)
            sql.Parameters.AddWithValue("@postnummer", postnummer)
            sql.Parameters.AddWithValue("@passord", passord)
            sql.ExecuteNonQuery()
            MsgBox("Utført")
            tilkobling.Close()
        Catch feilmelding As MySqlException
            MsgBox(feilmelding.Message)
        Finally
            tilkobling.Dispose()
        End Try
    End Sub

End Class

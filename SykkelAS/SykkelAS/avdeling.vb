Imports MySql.Data.MySqlClient
Public Class Avdeling
    'Private tilkobling As New MySqlConnection("Server=mysql.stud.iie.ntnu.no;Database=g_iini1010_04;Uid=g_iini1010_04;Pwd=QXXLn0wu")
    Private navn, telefon, epost, adresse, postnummer, passord As String
    Private nr As Integer

    'Konstruktør for å opprette avdeling
    Public Sub New(ByVal nr As Integer,
                   ByVal navn As String,
                   ByVal telefon As String,
                   ByVal epost As String,
                   ByVal adresse As String,
                   ByVal postnummer As String,
                   ByVal passord As String)
        Me.nr = nr
        Me.navn = navn
        Me.telefon = telefon
        Me.epost = epost
        Me.adresse = adresse
        Me.postnummer = postnummer
        Me.passord = passord
    End Sub

    'Metode for å opprette ny avdeling i databasen
    Public Sub OpprettAvdeling()
        Try
            databasetilkobling.databaseTilkobling()
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

    'Metode for å oppdatere eksisterende avdeling i databasen
    Public Sub OppdaterAvdeling()
        Try
            databasetilkobling.databaseTilkobling()
            tilkobling.Open()

            Dim sql As New MySqlCommand("UPDATE avdeling SET avdeling_navn = @navn, telefon = @telefon, epost = @epost, 
                                        adresse = @adresse, postnummer = @postnummer, passord = @passord
                                        WHERE avdeling_nr = @nr", tilkobling)
            sql.Parameters.AddWithValue("@nr", nr)
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

    Public Function HentAvdelingNavn() As String
        Return navn
    End Function

    Public Function hentSykkel() As DataTable
        Try
            databasetilkobling.databaseTilkobling()
            tilkobling.Open()

            Dim sql As New MySqlCommand("SELECT sykkel_merke, sykkel_type, pris_time, pris_døgn, pris_helg, status FROM sykkel WHERE lokasjon = @navn ", tilkobling)
            sql.Parameters.AddWithValue("@navn", navn)
            sql.ExecuteNonQuery()
            MsgBox("Utført")
            Dim da As New MySqlDataAdapter
            Dim sykkeltabell As New DataTable

            da.SelectCommand = sql
            da.Fill(sykkeltabell)
            tilkobling.Close()
            Return sykkeltabell
        Catch feilmelding As MySqlException
            MsgBox(feilmelding.Message)
        Finally
            tilkobling.Dispose()
        End Try
    End Function

    Public Function hentUtstyr() As DataTable
        Try
            databasetilkobling.databaseTilkobling()
            tilkobling.Open()

            Dim sql As New MySqlCommand("SELECT utstyr_merke, utstyr_type, pris_time, pris_døgn, pris_helg, status FROM utstyr WHERE lokasjon = @navn ", tilkobling)
            sql.Parameters.AddWithValue("@navn", navn)
            sql.ExecuteNonQuery()
            MsgBox("Utført")
            Dim da As New MySqlDataAdapter
            Dim utstyrstabell As New DataTable

            da.SelectCommand = sql
            da.Fill(utstyrstabell)
            tilkobling.Close()
            Return utstyrstabell
        Catch feilmelding As MySqlException
            MsgBox(feilmelding.Message)
        Finally
            tilkobling.Dispose()
        End Try
    End Function

End Class

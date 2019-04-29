Imports MySql.Data.MySqlClient
Public Class Avdeling
    Private navn, telefon, epost, adresse, postnummer, passord As String
    Private nr As Integer

    'Konstruktør for å opprette avdeling
    Public Sub New(ByVal navn As String,
                   ByVal telefon As String,
                   ByVal epost As String,
                   ByVal adresse As String,
                   ByVal postnummer As String,
                   ByVal passord As String,
                   ByVal nr As Integer)
        Me.navn = navn
        Me.telefon = telefon
        Me.epost = epost
        Me.adresse = adresse
        Me.postnummer = postnummer
        Me.passord = passord
        Me.nr = nr
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
            MsgBox("Avdeling opprettet")
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
            With sql.Parameters
                .AddWithValue("@nr", nr)
                .AddWithValue("@navn", navn)
                .AddWithValue("@telefon", telefon)
                .AddWithValue("@epost", epost)
                .AddWithValue("@adresse", adresse)
                .AddWithValue("@postnummer", postnummer)
                .AddWithValue("@passord", passord)
            End With
            sql.ExecuteNonQuery()
            MsgBox("Avdeling oppdatert")
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

    Public Function HentAvdelingNr() As String
        Return nr
    End Function

    'Public Function hentUtstyr() As DataTable
    'Try
    'databasetilkobling.databaseTilkobling()
    'tilkobling.Open()

    'Dim sql As New MySqlCommand("SELECT utstyr_merke, utstyr_type, pris_time, pris_døgn, pris_helg, status FROM utstyr WHERE lokasjon = @avdeling_nr ", tilkobling)
    'sql.Parameters.AddWithValue("@avdeling_nr", nr)
    'sql.ExecuteNonQuery()
    'Dim da As New MySqlDataAdapter
    'Dim utstyrstabell As New DataTable

    'da.SelectCommand = sql
    'da.Fill(utstyrstabell)
    'tilkobling.Close()
    'Return utstyrstabell
    'Catch feilmelding As MySqlException
    'MsgBox(feilmelding.Message)
    'Finally
    'tilkobling.Dispose()
    'End Try
    'End Function

End Class

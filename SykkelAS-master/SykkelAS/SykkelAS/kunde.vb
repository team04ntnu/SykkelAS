Imports MySql.Data.MySqlClient
Public Class Kunde
    Private fornavn, etternavn, adresse, postnummer, telefon, epost As String
    Private nr As Integer

    'Konstruktør for å opprette avdeling
    Public Sub New(ByVal nr As Integer,
                   ByVal fornavn As String,
                   ByVal etternavn As String,
                   ByVal telefon As String,
                   ByVal epost As String,
                   ByVal adresse As String,
                   ByVal postnummer As String)
        Me.nr = nr
        Me.fornavn = fornavn
        Me.etternavn = etternavn
        Me.telefon = telefon
        Me.epost = epost
        Me.adresse = adresse
        Me.postnummer = postnummer
    End Sub

    'Metode for å opprette ny kunde i databasen
    Public Sub OpprettKunde()
        Try
            databasetilkobling.databaseTilkobling()
            tilkobling.Open()

            Dim sql As New MySqlCommand("INSERT INTO kunde (fornavn, etternavn, adresse, postnummer, telefon, epost) 
                                        VALUES (@fornavn, @etternavn, @adresse, @postnummer, @telefon, @epost)", tilkobling)
            With sql.Parameters
                .AddWithValue("@fornavn", fornavn)
                .AddWithValue("@etternavn", etternavn)
                .AddWithValue("@adresse", adresse)
                .AddWithValue("@postnummer", postnummer)
                .AddWithValue("@telefon", telefon)
                .AddWithValue("@epost", epost)
            End With
            sql.ExecuteNonQuery()
            MsgBox("Kunde opprettet")
            tilkobling.Close()
        Catch feilmelding As MySqlException
            MsgBox(feilmelding.Message)
        Finally
            tilkobling.Dispose()
        End Try
    End Sub

    'Metode for å oppdatere eksisterende kunde i databasen
    Public Sub OppdaterKunde()
        Try
            databasetilkobling.databaseTilkobling()
            tilkobling.Open()

            Dim sql As New MySqlCommand("UPDATE kunde SET fornavn = @fornavn, etternavn = @etternavn, adresse = @adresse,
                                        postnummer = @postnummer, telefon = @telefon, epost = @epost
                                        WHERE kunde_nr = @nr", tilkobling)
            With sql.Parameters
                .AddWithValue("@nr", nr)
                .AddWithValue("@fornavn", fornavn)
                .AddWithValue("@etternavn", etternavn)
                .AddWithValue("@adresse", adresse)
                .AddWithValue("@postnummer", postnummer)
                .AddWithValue("@telefon", telefon)
                .AddWithValue("@epost", epost)
            End With
            sql.ExecuteNonQuery()
            MsgBox("Kunde oppdatert")
            tilkobling.Close()
        Catch feilmelding As MySqlException
            MsgBox(feilmelding.Message)
        Finally
            tilkobling.Dispose()
        End Try
    End Sub

End Class

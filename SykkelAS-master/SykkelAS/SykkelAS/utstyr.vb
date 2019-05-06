Imports MySql.Data.MySqlClient
Public Class Utstyr
    Private merke, type, passer_til, lokasjon, status As String
    Private id, pris_time, pris_dag, pris_helg, avdeling_nr As Integer

    'Konstruktør for å opprette utstyr
    Public Sub New(ByVal id As Integer,
                   ByVal merke As String,
                   ByVal type As String,
                   ByVal pris_time As Integer,
                   ByVal pris_dag As Integer,
                   ByVal pris_helg As Integer,
                   ByVal passer_til As String,
                   ByVal lokasjon As String,
                   ByVal status As String,
                   ByVal avdeling_nr As Integer)
        Me.id = id
        Me.merke = merke
        Me.type = type
        Me.pris_time = pris_time
        Me.pris_dag = pris_dag
        Me.pris_helg = pris_helg
        Me.passer_til = passer_til
        Me.lokasjon = lokasjon
        Me.status = status
        Me.avdeling_nr = avdeling_nr
    End Sub

    'Metode for å opprette nytt utstyr i databasen
    Public Sub OpprettUtstyr()
        Try
            databasetilkobling.databaseTilkobling()
            tilkobling.Open()

            Dim sql As New MySqlCommand("INSERT INTO utstyr (utstyr_merke, utstyr_type,
                                        pris_time, pris_dag, pris_helg, passer_til, lokasjon, status, avdeling_nr) 
                                        VALUES (@merke, @type, @pris_time, @pris_dag, @pris_helg, 
                                        @passer_til, @lokasjon, @status, @avdeling_nr)", tilkobling)
            With sql.Parameters
                .AddWithValue("@merke", merke)
                .AddWithValue("@type", type)
                .AddWithValue("@pris_time", pris_time)
                .AddWithValue("@pris_dag", pris_dag)
                .AddWithValue("@pris_helg", pris_helg)
                .AddWithValue("@passer_til", passer_til)
                .AddWithValue("@lokasjon", lokasjon)
                .AddWithValue("@status", status)
                .AddWithValue("@avdeling_nr", avdeling_nr)
            End With
            sql.ExecuteNonQuery()
            MsgBox("Utstyr opprettet")
            tilkobling.Close()
        Catch feilmelding As MySqlException
            MsgBox(feilmelding.Message)
        Finally
            tilkobling.Dispose()
        End Try
    End Sub

    'Metode for å oppdatere eksisterende utstyr i databasen
    Public Sub OppdaterUtstyr()
        Try
            databasetilkobling.databaseTilkobling()
            tilkobling.Open()

            Dim sql As New MySqlCommand("UPDATE utstyr SET utstyr_merke = @merke, utstyr_type = @type,
                                        pris_time = @pris_time, pris_dag = @pris_dag, pris_helg = @pris_helg, 
                                        passer_til = @passer_til, lokasjon = @lokasjon, status = @status, avdeling_nr = @avdeling_nr
                                        WHERE utstyr_id = @id", tilkobling)
            With sql.Parameters
                .AddWithValue("@id", id)
                .AddWithValue("@merke", merke)
                .AddWithValue("@type", type)
                .AddWithValue("@pris_time", pris_time)
                .AddWithValue("@pris_dag", pris_dag)
                .AddWithValue("@pris_helg", pris_helg)
                .AddWithValue("@passer_til", passer_til)
                .AddWithValue("@lokasjon", lokasjon)
                .AddWithValue("@status", status)
                .AddWithValue("@avdeling_nr", avdeling_nr)
            End With
            sql.ExecuteNonQuery()
            MsgBox("Utstyr oppdatert")
            tilkobling.Close()
        Catch feilmelding As MySqlException
            MsgBox(feilmelding.Message)
        Finally
            tilkobling.Dispose()
        End Try
    End Sub

End Class

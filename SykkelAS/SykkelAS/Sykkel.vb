Imports MySql.Data.MySqlClient
Public Class Sykkel
    Private merke, type, ramme, hjul, gir, vekt, rammenummer, lokasjon, status As String
    Private id, pris_time, pris_døgn, pris_helg, avdeling_nr As Integer

    'Konstruktør for å opprette sykkel
    Public Sub New(ByVal id As Integer,
                   ByVal merke As String,
                   ByVal type As String,
                   ByVal ramme As String,
                   ByVal hjul As String,
                   ByVal gir As String,
                   ByVal vekt As String,
                   ByVal rammenummer As String,
                   ByVal pris_time As Integer,
                   ByVal pris_døgn As Integer,
                   ByVal pris_helg As Integer,
                   ByVal lokasjon As String,
                   ByVal status As String,
                   ByVal avdeling_nr As Integer)
        Me.id = id
        Me.merke = merke
        Me.type = type
        Me.ramme = ramme
        Me.hjul = hjul
        Me.gir = gir
        Me.vekt = vekt
        Me.rammenummer = rammenummer
        Me.pris_time = pris_time
        Me.pris_døgn = pris_døgn
        Me.pris_helg = pris_helg
        Me.lokasjon = lokasjon
        Me.status = status
        Me.avdeling_nr = avdeling_nr
    End Sub

    'Metode for å opprette ny sykkel i databasen
    Public Sub OpprettSykkel()
        Try
            databasetilkobling.databaseTilkobling()
            tilkobling.Open()

            Dim sql As New MySqlCommand("INSERT INTO sykkel (sykkel_merke, sykkel_type, ramme, hjul, gir, vekt, rammenummer,
                                        pris_time, pris_døgn, pris_helg, lokasjon, status, avdeling_nr) 
                                        VALUES (@merke, @type, @ramme, @hjul, @gir, @vekt, @rammenummer, 
                                        @pris_time, @pris_døgn, @pris_helg, @lokasjon, @status, @avdeling_nr)", tilkobling)
            With sql.Parameters
                .AddWithValue("@merke", merke)
                .AddWithValue("@type", type)
                .AddWithValue("@ramme", ramme)
                .AddWithValue("@hjul", hjul)
                .AddWithValue("@gir", gir)
                .AddWithValue("@vekt", vekt)
                .AddWithValue("@rammenummer", rammenummer)
                .AddWithValue("@pris_time", pris_time)
                .AddWithValue("@pris_døgn", pris_døgn)
                .AddWithValue("@pris_helg", pris_helg)
                .AddWithValue("@lokasjon", lokasjon)
                .AddWithValue("@status", status)
                .AddWithValue("@avdeling_nr", avdeling_nr)
            End With
            sql.ExecuteNonQuery()
            MsgBox("Sykkel opprettet")
            tilkobling.Close()
        Catch feilmelding As MySqlException
            MsgBox(feilmelding.Message)
        Finally
            tilkobling.Dispose()
        End Try
    End Sub

    'Metode for å oppdatere eksisterende sykkel i databasen
    Public Sub OppdaterSykkel()
        Try
            databasetilkobling.databaseTilkobling()
            tilkobling.Open()

            Dim sql As New MySqlCommand("UPDATE sykkel SET sykkel_merke = @merke, sykkel_type = @type, ramme = @ramme, 
                                        hjul = @hjul, gir = @gir, vekt = @vekt, rammenummer = @rammenummer,
                                        pris_time = @pris_time, pris_døgn = @pris_døgn, pris_helg = @pris_helg, 
                                        lokasjon = @lokasjon, status = @status, avdeling_nr = @avdeling_nr
                                        WHERE sykkel_id = @id", tilkobling)
            With sql.Parameters
                .AddWithValue("@id", id)
                .AddWithValue("@merke", merke)
                .AddWithValue("@type", type)
                .AddWithValue("@ramme", ramme)
                .AddWithValue("@hjul", hjul)
                .AddWithValue("@gir", gir)
                .AddWithValue("@vekt", vekt)
                .AddWithValue("@rammenummer", rammenummer)
                .AddWithValue("@pris_time", pris_time)
                .AddWithValue("@pris_døgn", pris_døgn)
                .AddWithValue("@pris_helg", pris_helg)
                .AddWithValue("@lokasjon", lokasjon)
                .AddWithValue("@status", status)
                .AddWithValue("@avdeling_nr", avdeling_nr)
            End With
            sql.ExecuteNonQuery()
            MsgBox("Sykkel oppdatert")
            tilkobling.Close()
        Catch feilmelding As MySqlException
            MsgBox(feilmelding.Message)
        Finally
            tilkobling.Dispose()
        End Try
    End Sub

End Class

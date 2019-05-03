Imports MySql.Data.MySqlClient
Public Class Statistikk
    Dim dato_fra, dato_til As Date
    Dim fra, til As String
    Private Sub btnBeregn_Click(sender As Object, e As EventArgs) Handles btnBeregn.Click
        dato_fra = dtpDatoFra.Value
        dato_til = dtpDatoTil.Value
        fra = dato_fra.ToString("yyyy-MM-dd")
        til = dato_til.ToString("yyyy-MM-dd")

        MsgBox(til & fra)
        Try
            databasetilkobling.databaseTilkobling()
            tilkobling.Open()

            Dim tblFields As String = "SELECT COUNT(Location) AS LocationCount, Location AS LocationName FROM tblTagInfo group by Location"
            Dim oData As New MySqlDataAdapter(tblFields, tilkobling)
            Dim ds As New DataSet
            'Dim oCmd As New SqlCommand(tblFields, cnn3)


            'cnn3.Open()
            'oData.Fill(ds, "tblTagInfo")
            tilkobling.Close()


            Chart1.DataSource = ds.Tables("tblTagInfo")
            Series1 = Chart1.Series("Series1")
            Series1.Name = "Sales"
            Chart1.Series(Series1.Name).XValueMember = "LocationName"
            Chart1.Series(Series1.Name).YValueMembers = "Count"

            Chart1.Size = New System.Drawing.Size(780, 350)


        Catch feilmelding As Exception
            MsgBox(feilmelding.Message)

        Finally
            tilkobling.Dispose()

        End Try




    End Sub
End Class
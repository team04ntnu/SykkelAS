Imports MySql.Data.MySqlClient
Imports System.Windows.Forms.DataVisualization.Charting
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


            Dim ChartArea1 As ChartArea = New ChartArea()
            Dim Legend1 As Legend = New Legend()
            Dim Series1 As Series = New Series()
            Dim Chart1 = New Chart()
            Me.Controls.Add(Chart1)

            ChartArea1.Name = "ChartArea1"
            Chart1.ChartAreas.Add(ChartArea1)
            Legend1.Name = "Legend1"
            Chart1.Legends.Add(Legend1)
            Chart1.Location = New System.Drawing.Point(13, 13)
            Chart1.Name = "Chart1"
            Series1.ChartArea = "ChartArea1"
            Series1.Legend = "Legend1"
            Series1.Name = "Series1"
            Chart1.Series.Add(Series1)
            Chart1.Size = New System.Drawing.Size(800, 400)
            Chart1.TabIndex = 0
            Chart1.Text = "Chart1"

            Chart1.Series("Series1").XValueMember = "ProductName"
            Chart1.Series("Series1").YValueMembers = "UnitsInStock"

            Chart1.DataSource = ds.Tables("Products")


        Catch feilmelding As Exception
            MsgBox(feilmelding.Message)

        Finally
            tilkobling.Dispose()

        End Try




    End Sub
End Class
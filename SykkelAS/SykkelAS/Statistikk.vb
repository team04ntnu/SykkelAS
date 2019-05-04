Imports MySql.Data.MySqlClient
Imports System.Windows.Forms.DataVisualization.Charting
Public Class Statistikk
    Dim dato_fra, dato_til As Date
    Dim fra, til As String
    Dim statistikktabell As New DataTable

    Private Sub btnBeregn_Click(sender As Object, e As EventArgs) Handles btnBeregn.Click
        dato_fra = dtpDatoFra.Value
        dato_til = dtpDatoTil.Value
        fra = dato_fra.ToString("yyyy-MM-dd")
        til = dato_til.ToString("yyyy-MM-dd")


        Try
            databasetilkobling.databaseTilkobling()
            tilkobling.Open()

            Dim sporring As String = "SELECT sykkel_id, COUNT(*) FROM utleid_sykkel INNER JOIN leieavtale ON utleid_sykkel.leieavtale_nr = leieavtale.leieavtale_nr WHERE leieavtale.tidspunkt_fra BETWEEN '2019-05-02' AND '2019-05-08' GROUP BY sykkel_id"
            Dim sql As New MySqlCommand(sporring, tilkobling)
            Dim da As New MySqlDataAdapter
            da.SelectCommand = sql
            da.Fill(statistikktabell)

            tilkobling.Close()





            Me.Controls.Add(Chart1)
            Dim Series1 As New Series()



            Chart1.Name = "Chart1"
            Series1.ChartArea = "ChartArea1"
            Series1.Legend = "Legend1"
            Series1.Name = "Series1"
            Chart1.Size = New System.Drawing.Size(500, 200)
            Chart1.TabIndex = 0
            Chart1.Text = "Chart1"


            Chart1.Series("Series1").XValueMember = "Sykkel_id"
            Chart1.Series("Series1").YValueMembers = "COUNT(*)"

            Chart1.DataSource = statistikktabell.Rows


        Catch feilmelding As Exception
            MsgBox(feilmelding.Message)

        Finally
            tilkobling.Dispose()

        End Try




    End Sub
End Class
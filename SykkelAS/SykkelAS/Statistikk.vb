Public Class Statistikk
    Dim dato_fra, dato_til As Date
    Dim fra, til As String
    Private Sub btnBeregn_Click(sender As Object, e As EventArgs) Handles btnBeregn.Click
        dato_fra = dtpDatoFra.Value
        dato_til = dtpDatoTil.Value
        fra = dato_fra.ToString("yyyy-MM-dd")
        til = dato_til.ToString("yyyy-MM-dd")

        MsgBox(til & fra)
        'Dim cnn3 As New SqlConnection
        'Dim cmd3 As New SqlCommand

        'cnn3.ConnectionString = ("Data Source=SARAHSCOMPUTER;Initial Catalog=FYPDB1;Integrated Security=True")
        'cmd3.Connection = cnn3

        'Dim tblFields As String = "SELECT COUNT(Location) AS LocationCount, Location AS LocationName FROM tblTagInfo group by Location"
        'Dim oData As New SqlDataAdapter(tblFields, cnn3)
        'Dim ds As New DataSet
        'Dim oCmd As New SqlCommand(tblFields, cnn3)


        'cnn3.Open()
        'oData.Fill(ds, "tblTagInfo")
        'cnn3.Close()

        'Chart1.DataSource = ds.Tables("tblTagInfo")
        'Dim Series1 As Series = Chart1.Series("Series1")
        'Series1.Name = "Sales"
        'Chart1.Series(Series1.Name).XValueMember = "LocationName"
        'Chart1.Series(Series1.Name).YValueMembers = "LocationCount"

        'Chart1.Size = New System.Drawing.Size(780, 350


    End Sub
End Class
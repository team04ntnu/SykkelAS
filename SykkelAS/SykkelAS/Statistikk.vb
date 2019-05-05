Imports MySql.Data.MySqlClient
Imports System.Windows.Forms.DataVisualization.Charting

Public Class Statistikk
    Dim dato_fra, dato_til As Date
    Dim fra, til, navn, merke, type, lokasjon As String
    Dim statistikktabell As New DataTable
    Dim inntekt, sum, lønn, fasteUtgifter, variableUtgifter, nr, id As Integer

    Private Sub btnSykkelLokasjon_Click(sender As Object, e As EventArgs) Handles btnSykkelLokasjon.Click
        nr = Innlogging.innloggetAvdeling.HentAvdelingNr()
        navn = Innlogging.innloggetAvdeling.HentAvdelingNavn()
        Try
            databasetilkobling.databaseTilkobling()
            tilkobling.Open()

            Dim lokasjonTabell As New DataTable
            Dim sql As New MySqlCommand("SELECT sykkel_id, sykkel_merke, sykkel_type, lokasjon FROM sykkel WHERE avdeling_nr = @nr AND lokasjon != @navn", tilkobling)
            sql.Parameters.AddWithValue("@nr", nr)
            sql.Parameters.AddWithValue("@navn", navn)
            sql.ExecuteNonQuery()

            Dim da As New MySqlDataAdapter
            da.SelectCommand = sql
            da.Fill(lokasjonTabell)
            tilkobling.Close()
            Dim rad As DataRow
            lstboxSykkelLokasjon.Items.Clear()
            For Each rad In lokasjonTabell.Rows
                id = rad("sykkel_id")
                merke = rad("sykkel_merke")
                type = rad("sykkel_type")
                lokasjon = rad("lokasjon")
                lstboxSykkelLokasjon.Items.Add(id & vbTab & merke & vbTab & type & vbTab & lokasjon)

            Next rad

        Catch feil As Exception
            MsgBox(feil.Message)
        Finally
            tilkobling.Dispose()
        End Try

    End Sub

    Private Sub btnHovedmeny_Click(sender As Object, e As EventArgs) Handles btnHovedmeny.Click
        Me.Hide()
        Hovedmeny.Show()
    End Sub

    Private Sub rbtnAvanse_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnAvanse.CheckedChanged
        GroupBox1.Visible = True
    End Sub



    Private Sub btnBeregn_Click(sender As Object, e As EventArgs) Handles btnBeregn.Click
        dato_fra = dtpDatoFra.Value
        dato_til = dtpDatoTil.Value
        fra = dato_fra.ToString("yyyy-MM-dd")
        til = dato_til.ToString("yyyy-MM-dd")
        nr = Innlogging.innloggetAvdeling.HentAvdelingNr()

        'MsgBox(fra & vbNewLine & til & vbNewLine & nr)

        Try
            databasetilkobling.databaseTilkobling()
            tilkobling.Open()

            If rbtnSykkel.Checked = True Then

                Dim sql As New MySqlCommand("SELECT sykkel_id, COUNT(*) FROM utleid_sykkel INNER JOIN leieavtale ON utleid_sykkel.leieavtale_nr = leieavtale.leieavtale_nr WHERE leieavtale.avdeling_nr = @nr AND leieavtale.tidspunkt_fra BETWEEN @fra AND @til GROUP BY sykkel_id", tilkobling)
                sql.Parameters.AddWithValue("@nr", nr)
                sql.Parameters.AddWithValue("@fra", fra)
                sql.Parameters.AddWithValue("@til", til)
                sql.ExecuteNonQuery()

                'Dim leser = sql.ExecuteReader()
                Dim da As New MySqlDataAdapter
                da.SelectCommand = sql
                da.Fill(statistikktabell)
                'statistikktabell.Load(leser)


                tilkobling.Close()
                Me.Controls.Add(Chart1)
                Dim Series1 As New Series()
                Chart1.Name = "Chart1"
                Series1.ChartArea = "ChartArea1"
                Series1.Legend = "Legend1"
                Series1.Name = "Antall leieavtaler"
                Chart1.Size = New System.Drawing.Size(400, 200)
                Chart1.TabIndex = 0
                Chart1.Text = "leieavtaler per sykkel"
                Chart1.Series("Series1").XValueMember = "sykkel_id"
                Chart1.Series("Series1").YValueMembers = "COUNT(*)"
                Chart1.DataSource = statistikktabell.Rows

            ElseIf rbtnAvdeling.Checked = True Then

                Dim sql2 As New MySqlCommand("SELECT avdeling_nr, COUNT(*) FROM leieavtale WHERE avdeling_nr = @nr AND leieavtale.tidspunkt_fra BETWEEN @fra AND @til", tilkobling)
                sql2.Parameters.AddWithValue("@nr", nr)
                sql2.Parameters.AddWithValue("@fra", fra)
                sql2.Parameters.AddWithValue("@til", til)

                sql2.ExecuteNonQuery()
                Dim da As New MySqlDataAdapter
                da.SelectCommand = sql2
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
                Chart1.Series("Series1").XValueMember = "avdeling_nr"
                Chart1.Series("Series1").YValueMembers = "COUNT(*)"
                Chart1.DataSource = statistikktabell.Rows

            ElseIf rbtnAvanse.Checked = True Then

                Dim sql3 As New MySqlCommand("SELECT pris FROM leieavtale WHERE avdeling_nr = @nr AND tidspunkt_fra BETWEEN @fra AND @til", tilkobling)
                sql3.Parameters.AddWithValue("@nr", nr)
                sql3.Parameters.AddWithValue("@fra", fra)
                sql3.Parameters.AddWithValue("@til", til)
                ' sql3.ExecuteNonQuery()
                Dim leser = sql3.ExecuteReader()
                statistikktabell.Load(leser)
                Dim da As New MySqlDataAdapter
                'da.SelectCommand = sql3
                'da.Fill(statistikktabell)

                Dim rad As DataRow

                For i = 0 To statistikktabell.Rows.Count - 1
                    rad = statistikktabell(i)
                    inntekt = inntekt + rad(0)
                Next

                'Dim leser = sql3.ExecuteReader()

                'While leser.Read()
                'inntekt = inntekt + leser("pris")
                'End While

                tilkobling.Close()
                Me.Controls.Add(Chart1)
                Dim Series1 As New Series()

                sum = inntekt - txtLønn.Text - txtFasteUtgifter.Text - txtVariableUtgifter.Text
                Dim ratings() As Double = {inntekt, txtFasteUtgifter.Text, txtLønn.Text, txtVariableUtgifter.Text, sum}

                Dim descriptions() As String = {"inntekt", "faste utgifter", "lønn", "variable utgiter", "sum"}

                Chart1.Series(0).Points.DataBindXY(descriptions, ratings)

            End If

        Catch feilmelding As Exception
            MsgBox(feilmelding.Message)

        Finally
            tilkobling.Dispose()

        End Try




    End Sub
End Class
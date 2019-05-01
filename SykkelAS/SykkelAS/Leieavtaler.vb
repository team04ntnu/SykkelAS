Public Class Leieavtaler
    Private fraDag, fraTime, til As Date
    Private fra As String
    Private kunde_nr As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        fraDag = dtpFraDato.Value
        fraTime = dtpFraTid.Value
        fra = fraDag.ToString("yyyy-MM-dd") & " " & fraTime.ToString("HH") & ":00:00"
        MsgBox(fraTime)
        MsgBox(fra)
    End Sub

    Private Sub Leieavtaler_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AdministrereKunde.hentKunde()
        AdministrereUtstyr.hentUtstyr()
        AdministrereSykkel.hentSykkel()
    End Sub

    Private Sub cmbKunde_TextChanged(sender As Object, e As EventArgs) Handles cmbKunde.TextChanged
        'Sletter tidligere søkeresultat
        cmbKunde.Items.Clear()
        'Søker gjennom tabell
        Dim søk As String
        søk = cmbKunde.Text
        'Første loop går gjennom hver rad i tabellen
        For Each rad In AdministrereKunde.kundetabell.Rows
            'Andre loop går gjennom hver celle i hver enkelt rad
            'Bruker ToLower for å kunne søke uavhengig av stor/liten bokstav
            For i = 0 To AdministrereKunde.kundetabell.Columns.Count - 1
                If CStr(rad(i)).ToLower.IndexOf(søk.ToLower()) > -1 Then
                    Dim resultat = rad(0) & " " & rad(2) & ", " & rad(1) & " (Tlf: " & rad(4) & ")"
                    'Gjør at resultat ikke blir lagt til flere ganger
                    If cmbKunde.Items.Count = 0 Then
                        cmbKunde.Items.Add(resultat)
                    ElseIf cmbKunde.Items(0).IndexOf(rad(0)) = -1 Then
                        cmbKunde.Items.Add(resultat)
                    End If
                End If
            Next i
        Next
        cmbKunde.SelectionStart = cmbKunde.Text.Length + 1
    End Sub

    Private Sub cmbKunde_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbKunde.SelectedIndexChanged
        Dim rad As DataRow
        Dim valgt As String = cmbKunde.Text
        'Henter nr til valgt kunde (tallet helt til venstre i resultatet)
        kunde_nr = CInt(valgt.Split(" ")(0))
        'Setter startindeks til -1 
        Dim valgtIndeks = -1
        'Henter ut riktig indeks i utstyrtabell for valgt utstyr
        Dim i As Integer
        For i = 0 To AdministrereKunde.kundetabell.Rows.Count - 1
            'Sjekker første kolonne i hver rad etter id til valgt utstyr
            If AdministrereKunde.kundetabell.Rows(i).Item(0) = kunde_nr Then
                valgtIndeks = i
                Exit For
            End If
        Next i
        rad = AdministrereKunde.kundetabell.Rows(valgtIndeks)
        Dim valgtKunde = rad(0) & " " & rad(2) & ", " & rad(1) & " (Tlf: " & rad(4) & ")"
        lstLeieavtale.Items.Add("Kunde:")
        lstLeieavtale.Items.Add(valgtKunde)
    End Sub

    Private Sub cmbSykkel_TextChanged(sender As Object, e As EventArgs) Handles cmbSykkel.TextChanged
        'Sletter tidligere søkeresultat
        cmbSykkel.Items.Clear()
        'Søker gjennom tabell
        Dim søk As String
        søk = cmbSykkel.Text
        'Første loop går gjennom hver rad i tabellen
        For Each rad In AdministrereSykkel.sykkeltabell.Rows
            'Andre loop går gjennom hver celle i hver enkelt rad
            'Bruker ToLower for å kunne søke uavhengig av stor/liten bokstav
            For i = 0 To AdministrereSykkel.sykkeltabell.Columns.Count - 1
                If CStr(rad(i)).ToLower.IndexOf(søk.ToLower()) > -1 Then
                    Dim resultat = rad(0) & " " & rad(2) & ", " & rad(1)
                    'Gjør at resultat ikke blir lagt til flere ganger
                    If cmbSykkel.Items.Count = 0 Then
                        cmbSykkel.Items.Add(resultat)
                    ElseIf cmbSykkel.Items(0).IndexOf(rad(0)) = -1 Then
                        cmbSykkel.Items.Add(resultat)
                    End If
                End If
            Next i
        Next
        cmbSykkel.SelectionStart = cmbSykkel.Text.Length + 1
    End Sub

    Private Sub cmbUtstyr_TextChanged(sender As Object, e As EventArgs) Handles cmbUtstyr.TextChanged
        'Sletter tidligere søkeresultat
        cmbUtstyr.Items.Clear()
        'Søker gjennom tabell
        Dim søk As String
        søk = cmbUtstyr.Text
        'Første loop går gjennom hver rad i tabellen
        For Each rad In AdministrereUtstyr.utstyrtabell.Rows
            'Andre loop går gjennom hver celle i hver enkelt rad
            'Bruker ToLower for å kunne søke uavhengig av stor/liten bokstav
            For i = 0 To AdministrereUtstyr.utstyrtabell.Columns.Count - 1
                If CStr(rad(i)).ToLower.IndexOf(søk.ToLower()) > -1 Then
                    Dim resultat = rad(0) & " " & rad(2) & ", " & rad(1)
                    'Gjør at resultat ikke blir lagt til flere ganger
                    If cmbUtstyr.Items.Count = 0 Then
                        cmbUtstyr.Items.Add(resultat)
                    ElseIf cmbUtstyr.Items(0).IndexOf(rad(0)) = -1 Then
                        cmbUtstyr.Items.Add(resultat)
                    End If
                End If
            Next i
        Next
        cmbUtstyr.SelectionStart = cmbUtstyr.Text.Length + 1
    End Sub

    Private Sub btnTilbake_Click(sender As Object, e As EventArgs) Handles btnTilbake.Click
        Hovedmeny.Show()
        Me.Hide()
    End Sub
End Class
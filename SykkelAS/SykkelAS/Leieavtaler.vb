Imports MySql.Data.MySqlClient
Public Class Leieavtaler
    Private fraDag, fraTime, tilDag, tilTime As Date
    Private innlogget, fra, til As String
    Private kunde_nr, sykkel_id, utstyr_id
    Private SykkelKode As New List(Of String)
    Private UtstyrKode As New List(Of String)

    Private Sub Leieavtaler_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AdministrereKunde.hentKunde()
        AdministrereUtstyr.hentUtstyr()
    End Sub

    Private Sub btnTid_Click(sender As Object, e As EventArgs) Handles btnTid.Click
        fraDag = dtpFraDato.Value
        fraTime = dtpFraTid.Value
        fra = fraDag.ToString("yyyy-MM-dd") & " " & fraTime.ToString("HH") & ":00:00"
        tilDag = dtpTilDato.Value
        tilTime = dtpTilDato.Value
        til = tilDag.ToString("yyyy-MM-dd") & " " & tilTime.ToString("HH") & ":00:00"
        With lstTidspunkt.Items
            .Add("Fra:")
            .Add(fraDag.ToString("dddd dd. MMMM") & " kl. " & fraTime.ToString("HH") & ":00")
            .Add("Til:")
            .Add(tilDag.ToString("dddd dd. MMMM") & " kl. " & tilTime.ToString("HH") & ":00")
        End With
        'Henter inn tabell over ledige sykler basert på valgt dato
        Dim spørring = "SELECT * FROM sykkel WHERE avdeling_nr = @innlogget AND sykkel_id NOT IN
                       (SELECT sykkel_id FROM utleid_sykkel WHERE leieavtale_nr = 
                       (SELECT leieavtale_nr FROM leieavtale WHERE '" &
                       fra & "' < tidspunkt_til AND '" &
                       til & "' > tidspunkt_fra))"
        AdministrereSykkel.hentSykkel(spørring)
    End Sub

    Private Sub cmbKunde_TextChanged(sender As Object, e As EventArgs) Handles cmbKunde.TextChanged
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
                    Dim antall As Integer = cmbKunde.Items.Count
                    If antall = 0 Then
                        cmbKunde.Items.Add(resultat)
                    ElseIf cmbKunde.Items(antall - 1).IndexOf(rad(0)) = -1 Then
                        cmbKunde.Items.Add(resultat)
                    End If
                End If
            Next i
        Next
        cmbKunde.SelectionStart = cmbKunde.Text.Length + 1
    End Sub

    Private Sub cmbKunde_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbKunde.SelectedIndexChanged
        Dim rad As DataRow
        'Henter nr til valgt kunde (tallet helt til venstre i resultatet)
        Dim valgt As String = cmbKunde.Text.Split(" ")(0)
        'Setter startindeks til -1 
        Dim valgtIndeks = -1
        'Henter ut riktig indeks i tabell
        Dim i As Integer
        For i = 0 To AdministrereKunde.kundetabell.Rows.Count - 1
            'Sjekker første kolonne i hver rad etter id til valgt kunde
            If AdministrereKunde.kundetabell.Rows(i).Item(0) = valgt Then
                valgtIndeks = i
                Exit For
            End If
        Next i
        rad = AdministrereKunde.kundetabell.Rows(valgtIndeks)
        Dim valgtKunde = rad(0) & " " & rad(2) & ", " & rad(1) & " (Tlf: " & rad(4) & ")"
        If lstKunde.Items.Count = 0 Then
            lstKunde.Items.Add(valgtKunde)
        Else
            MsgBox("Du kan kun legge til én kunde")
        End If
    End Sub

    Private Sub cmbSykkel_TextChanged(sender As Object, e As EventArgs) Handles cmbSykkel.TextChanged
        'Søker gjennom tabell
        Dim søk As String
        søk = cmbSykkel.Text
        'Første loop går gjennom hver rad i tabellen
        For Each rad In AdministrereSykkel.sykkeltabell.Rows
            'Andre loop går gjennom hver celle i hver enkelt rad
            'Bruker ToLower for å kunne søke uavhengig av stor/liten bokstav
            For i = 0 To AdministrereSykkel.sykkeltabell.Columns.Count - 1
                If CStr(rad(i)).ToLower.IndexOf(søk.ToLower()) > -1 Then
                    Dim resultat = rad(0) & " " & rad(1) & " " & rad(2)
                    'Gjør at resultat ikke blir lagt til flere ganger
                    Dim antall As Integer = cmbSykkel.Items.Count
                    If antall = 0 Then
                        cmbSykkel.Items.Add(resultat)
                    ElseIf cmbSykkel.Items(antall - 1).IndexOf(rad(0)) = -1 Then
                        cmbSykkel.Items.Add(resultat)
                    End If
                End If
            Next i
        Next
        cmbSykkel.SelectionStart = cmbSykkel.Text.Length + 1
    End Sub

    Private Sub cmbSykkel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSykkel.SelectedIndexChanged
        Dim rad As DataRow
        'Henter nr til valgt sykkel (tallet helt til venstre i resultatet)
        Dim valgt As String = cmbSykkel.Text.Split(" ")(0)
        'Setter startindeks til -1 
        Dim valgtIndeks = -1
        'Henter ut riktig indeks i tabell
        Dim i As Integer
        For i = 0 To AdministrereSykkel.sykkeltabell.Rows.Count - 1
            'Sjekker første kolonne i hver rad etter id til valgt sykkel
            If AdministrereSykkel.sykkeltabell.Rows(i).Item(0) = valgt Then
                valgtIndeks = i
                Exit For
            End If
        Next i
        rad = AdministrereSykkel.sykkeltabell.Rows(valgtIndeks)
        Dim valgtSykkel = rad(0) & " " & rad(1) & " " & rad(2)
        'Sjekker om samme sykkel allerede er lagt til
        If lstSykkel.FindString(rad(0)) = -1 Then
            lstSykkel.Items.Add(valgtSykkel)
            'Legger til koder i arraylist for valgte sykler
            If rad(2) = "Terreng" Then
                SykkelKode.Add("T")
            ElseIf rad(2) = "Downhill" Then
                SykkelKode.Add("D")
            ElseIf rad(2) = "Racer" Then
                SykkelKode.Add("R")
            ElseIf rad(2) = "Tandem" Then
                SykkelKode.Add("M")
            ElseIf rad(2) = "Barn" Then
                SykkelKode.Add("B")
            End If
        Else
            MsgBox("Du kan ikke legge til samme sykkel på nytt")
        End If
    End Sub

    Private Sub cmbUtstyr_TextChanged(sender As Object, e As EventArgs) Handles cmbUtstyr.TextChanged
        'Søker gjennom tabell
        Dim søk As String
        søk = cmbUtstyr.Text
        'Første loop går gjennom hver rad i tabellen
        For Each rad In AdministrereUtstyr.utstyrtabell.Rows
            'Andre loop går gjennom hver celle i hver enkelt rad
            'Bruker ToLower for å kunne søke uavhengig av stor/liten bokstav
            For i = 0 To AdministrereUtstyr.utstyrtabell.Columns.Count - 1
                If CStr(rad(i)).ToLower.IndexOf(søk.ToLower()) > -1 Then
                    Dim resultat = rad(0) & " " & rad(1) & " " & rad(2)
                    'Gjør at resultat ikke blir lagt til flere ganger
                    Dim antall As Integer = cmbUtstyr.Items.Count
                    If antall = 0 Then
                        cmbUtstyr.Items.Add(resultat)
                    ElseIf cmbUtstyr.Items(antall - 1).IndexOf(rad(0)) = -1 Then
                        cmbUtstyr.Items.Add(resultat)
                    End If
                End If
            Next i
        Next
        cmbUtstyr.SelectionStart = cmbUtstyr.Text.Length + 1
    End Sub

    Private Sub cmbUtstyr_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbUtstyr.SelectedIndexChanged
        Dim rad As DataRow
        'Henter nr til valgt utstyr (tallet helt til venstre i resultatet)
        Dim valgt As String = cmbUtstyr.Text.Split(" ")(0)
        'Setter startindeks til -1 
        Dim valgtIndeks = -1
        'Henter ut riktig indeks i tabell
        Dim i As Integer
        For i = 0 To AdministrereUtstyr.utstyrtabell.Rows.Count - 1
            'Sjekker første kolonne i hver rad etter id til valgt sykkel
            If AdministrereUtstyr.utstyrtabell.Rows(i).Item(0) = valgt Then
                valgtIndeks = i
                Exit For
            End If
        Next i
        rad = AdministrereUtstyr.utstyrtabell.Rows(valgtIndeks)
        Dim valgtUtstyr = rad(0) & " " & rad(1) & " " & rad(2)

        'Sjekker om det er lagt til sykkel
        If lstSykkel.Items.Count <> 0 Then
            'Sjekker om utstyr allerede er lagt til
            If lstUtstyr.FindString(rad(0)) = -1 Then
                'Sjekker om utstyr passer til valgt sykkel
                Dim koder() As Char = rad(6).ToCharArray
                For Each kode In koder
                    UtstyrKode.Add(kode)
                Next
                'Sammenligner lister og sjekker om koder finnes i begge
                Dim treff = UtstyrKode.Intersect(SykkelKode).ToArray()
                If treff.Length > 0 Then
                    lstUtstyr.Items.Add(valgtUtstyr)
                Else
                    MsgBox("Utstyr passer ikke til valgt sykkel")
                End If
            Else
                MsgBox("Du kan ikke legge til samme utstyr på nytt")
            End If
        Else
            MsgBox("Du må legge til minst én sykkel før du kan velge utstyr")
        End If
    End Sub

    Private Sub btnTømSkjema_Click(sender As Object, e As EventArgs) Handles btnTømSkjema.Click
        lstTidspunkt.Items.Clear()
        lstKunde.Items.Clear()
        lstSykkel.Items.Clear()
        lstUtstyr.Items.Clear()
        SykkelKode.Clear()
    End Sub

    Private Sub btnTilbake_Click(sender As Object, e As EventArgs) Handles btnTilbake.Click
        Hovedmeny.Show()
        Me.Hide()
    End Sub
End Class
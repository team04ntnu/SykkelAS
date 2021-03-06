﻿Imports MySql.Data.MySqlClient
Public Class AdministrereAvdeling
    Private navn, telefon, epost, adresse, postnummer, passord As String
    Private nr As Integer
    Public avdelingValg As New ArrayList()

    Private Sub TømSkjema()
        txtAvdelingNr.Text = ""
        txtTelefon.Text = ""
        txtAvdelingsnavn.Text = ""
        txtEpost.Text = ""
        txtAdresse.Text = ""
        txtPostnummer.Text = ""
        txtSted.Text = ""
        txtPassord.Text = ""
        txtBekreftPassord.Text = ""
    End Sub

    'Henter info fra tekstfelt og legger i variabler
    Private Sub hentInfo()
        If txtAvdelingNr.Text <> "" Then
            nr = txtAvdelingNr.Text
        End If
        navn = txtTelefon.Text
        telefon = txtAvdelingsnavn.Text
        epost = txtEpost.Text
        adresse = txtAdresse.Text
        postnummer = txtPostnummer.Text
        'Sjekker om passordene er skrevet inn likt
        If txtPassord.Text = txtBekreftPassord.Text Then
            passord = txtPassord.Text
        Else
            MsgBox("Passordene samsvarer ikke")
        End If
    End Sub

    Public Sub OppdaterValg()
        'Henter navnet på alle avdelingene som ligger i databasen
        'Legger resultatet i en arraylist
        Try
            avdelingValg.Clear()
            databasetilkobling.databaseTilkobling()
            tilkobling.Open()
            Dim sql As New MySqlCommand("SELECT avdeling_navn FROM avdeling", tilkobling)
            Dim leser = sql.ExecuteReader()
            While leser.Read()
                avdelingValg.Add(leser("avdeling_navn"))
            End While
            tilkobling.Close()
        Catch feilmelding As MySqlException
            MsgBox(feilmelding.Message)
        Finally
            tilkobling.Dispose()
        End Try
    End Sub

    Private Sub AdministrereAvdeling_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Oppdaterer liste over eksisterende avdelinger når programmet starter
        For Each avdeling In avdelingValg
            cmbAvdeling.Items.Add(avdeling)
        Next
    End Sub

    Private Sub cmbAvdeling_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbAvdeling.SelectedIndexChanged
        'Fyller ut tekstfelt når avdeling velges
        navn = cmbAvdeling.Text
        Try
            databasetilkobling.databaseTilkobling()
            tilkobling.Open()
            Dim sql As New MySqlCommand("SELECT a.*, s.poststed FROM avdeling a INNER JOIN sted s ON a.postnummer = s.postnummer 
                                        WHERE avdeling_navn = @navn", tilkobling)
            sql.Parameters.AddWithValue("@navn", navn)
            Dim da As New MySqlDataAdapter
            Dim avdelingTabell As New DataTable
            'Kjører spørringen
            da.SelectCommand = sql
            'Fyller inn en rad i datatabell
            da.Fill(avdelingTabell)
            tilkobling.Close()
            'Henter ut informasjon fra raden og fyller ut tekstfeltene
            Dim avdelingRad As DataRow
            avdelingRad = avdelingTabell(0)
            txtAvdelingNr.Text = avdelingRad("avdeling_nr")
            txtTelefon.Text = avdelingRad("avdeling_navn")
            txtEpost.Text = avdelingRad("epost")
            txtAvdelingsnavn.Text = avdelingRad("telefon")
            txtAdresse.Text = avdelingRad("adresse")
            txtPostnummer.Text = avdelingRad("postnummer")
            txtSted.Text = avdelingRad("poststed")
        Catch feilmelding As MySqlException
            MsgBox(feilmelding.Message)
        Finally
            tilkobling.Dispose()
        End Try
    End Sub

    Private Sub btnOppdater_Click(sender As Object, e As EventArgs) Handles btnOppdater.Click
        'Henter prosedyre for å lese inn fra tekstfelt
        hentInfo()
        'Oppretter et nytt objekt basert på informasjonen
        Dim oppdatertAvdeling As New Avdeling(nr, navn, telefon, epost, adresse, postnummer, passord)
        'Henter metode for å oppdatere avdeling i database
        oppdatertAvdeling.OppdaterAvdeling()
        'Fjerner tidligere oppføringer i avdelingsliste
        cmbAvdeling.Items.Clear()
        'Oppdaterer liste over avdelinger
        OppdaterValg()
        For Each avdeling In avdelingValg
            cmbAvdeling.Items.Add(avdeling)
        Next
        'Sletter tekstfelt etter at avdeling er oppdatert
        TømSkjema()
    End Sub

    Private Sub btnOpprett_Click(sender As Object, e As EventArgs) Handles btnOpprett.Click
        'Henter prosedyre for å lese inn fra tekstfelt
        hentInfo()
        'Oppretter et nytt objekt basert på informasjonen
        Dim nyAvdeling As New Avdeling(nr, navn, telefon, epost, adresse, postnummer, passord)
        'Henter metode for å opprette avdeling i database
        nyAvdeling.OpprettAvdeling()
        'Fjerner tidligere oppføringer i avdelingsliste
        cmbAvdeling.Items.Clear()
        'Oppdaterer liste over avdelinger
        OppdaterValg()
        For Each avdeling In avdelingValg
            cmbAvdeling.Items.Add(avdeling)
        Next
        'Sletter tekstfelt etter at avdeling er opprettet
        TømSkjema()
    End Sub

    Private Sub btnTømSkjema_Click(sender As Object, e As EventArgs) Handles btnTømSkjema.Click
        'Knapp for å slette tekstfelt
        TømSkjema()
    End Sub

    Private Sub btnLoggUt_Click(sender As Object, e As EventArgs) Handles btnLoggUt.Click
        Innlogging.Show()
        Me.Hide()
    End Sub
End Class
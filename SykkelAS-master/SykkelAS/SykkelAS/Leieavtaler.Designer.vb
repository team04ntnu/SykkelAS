﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Leieavtaler
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnTilbake = New System.Windows.Forms.Button()
        Me.dtpFraDato = New System.Windows.Forms.DateTimePicker()
        Me.dtpTilDato = New System.Windows.Forms.DateTimePicker()
        Me.lblPrisgrunnlag = New System.Windows.Forms.Label()
        Me.lblFra = New System.Windows.Forms.Label()
        Me.lblTil = New System.Windows.Forms.Label()
        Me.cmbSykkel = New System.Windows.Forms.ComboBox()
        Me.cmbUtstyr = New System.Windows.Forms.ComboBox()
        Me.lblVelgKunde = New System.Windows.Forms.Label()
        Me.lblVelgSykkel = New System.Windows.Forms.Label()
        Me.lblVelgUtstyr = New System.Windows.Forms.Label()
        Me.cmbKunde = New System.Windows.Forms.ComboBox()
        Me.lstSykkel = New System.Windows.Forms.ListBox()
        Me.lblSykkel = New System.Windows.Forms.Label()
        Me.dtpTilTime = New System.Windows.Forms.DateTimePicker()
        Me.dtpFraTime = New System.Windows.Forms.DateTimePicker()
        Me.lblFraTid = New System.Windows.Forms.Label()
        Me.lblTilTid = New System.Windows.Forms.Label()
        Me.lblKunde = New System.Windows.Forms.Label()
        Me.lstUtstyr = New System.Windows.Forms.ListBox()
        Me.lblUtstyr = New System.Windows.Forms.Label()
        Me.btnTømSkjema = New System.Windows.Forms.Button()
        Me.lstTidspunkt = New System.Windows.Forms.ListBox()
        Me.btnTid = New System.Windows.Forms.Button()
        Me.lblTidspunkt = New System.Windows.Forms.Label()
        Me.lstKunde = New System.Windows.Forms.ListBox()
        Me.cmbUtlevering = New System.Windows.Forms.ComboBox()
        Me.cmbInnlevering = New System.Windows.Forms.ComboBox()
        Me.lblUtlevering = New System.Windows.Forms.Label()
        Me.lblInnlevering = New System.Windows.Forms.Label()
        Me.txtRabatt = New System.Windows.Forms.TextBox()
        Me.lblRabatt = New System.Windows.Forms.Label()
        Me.lblPrisFør = New System.Windows.Forms.Label()
        Me.txtPrisFør = New System.Windows.Forms.TextBox()
        Me.lblPrisEtter = New System.Windows.Forms.Label()
        Me.txtPrisEtter = New System.Windows.Forms.TextBox()
        Me.btnRegistrer = New System.Windows.Forms.Button()
        Me.chkManuell = New System.Windows.Forms.CheckBox()
        Me.btnFjernrabatt = New System.Windows.Forms.Button()
        Me.lblValgtRabatt = New System.Windows.Forms.Label()
        Me.txtValgtRabatt = New System.Windows.Forms.TextBox()
        Me.lblInnloggetAvdeling = New System.Windows.Forms.Label()
        Me.txtLeieavtaleNr = New System.Windows.Forms.TextBox()
        Me.lstLeieavtaler = New System.Windows.Forms.ListBox()
        Me.btnHent = New System.Windows.Forms.Button()
        Me.btnAvbestill = New System.Windows.Forms.Button()
        Me.btnOppdater = New System.Windows.Forms.Button()
        Me.btnUtlevering = New System.Windows.Forms.Button()
        Me.txtStatus = New System.Windows.Forms.TextBox()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.btnInnlevering = New System.Windows.Forms.Button()
        Me.btnFjernKunde = New System.Windows.Forms.Button()
        Me.btnFjernSykkel = New System.Windows.Forms.Button()
        Me.btnFjernUtstyr = New System.Windows.Forms.Button()
        Me.txtAvdeling = New System.Windows.Forms.TextBox()
        Me.lblAvdeling = New System.Windows.Forms.Label()
        Me.lblLeieavtaleNr = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnTilbake
        '
        Me.btnTilbake.Location = New System.Drawing.Point(982, 606)
        Me.btnTilbake.Name = "btnTilbake"
        Me.btnTilbake.Size = New System.Drawing.Size(167, 23)
        Me.btnTilbake.TabIndex = 42
        Me.btnTilbake.Text = "Hovedmeny"
        Me.btnTilbake.UseVisualStyleBackColor = True
        '
        'dtpFraDato
        '
        Me.dtpFraDato.CustomFormat = ""
        Me.dtpFraDato.Location = New System.Drawing.Point(77, 57)
        Me.dtpFraDato.Name = "dtpFraDato"
        Me.dtpFraDato.Size = New System.Drawing.Size(189, 20)
        Me.dtpFraDato.TabIndex = 43
        Me.dtpFraDato.Value = New Date(2019, 5, 1, 10, 0, 0, 0)
        '
        'dtpTilDato
        '
        Me.dtpTilDato.Location = New System.Drawing.Point(77, 82)
        Me.dtpTilDato.Name = "dtpTilDato"
        Me.dtpTilDato.Size = New System.Drawing.Size(189, 20)
        Me.dtpTilDato.TabIndex = 44
        Me.dtpTilDato.Value = New Date(2019, 5, 1, 10, 0, 0, 0)
        '
        'lblPrisgrunnlag
        '
        Me.lblPrisgrunnlag.AutoSize = True
        Me.lblPrisgrunnlag.Location = New System.Drawing.Point(9, 15)
        Me.lblPrisgrunnlag.Name = "lblPrisgrunnlag"
        Me.lblPrisgrunnlag.Size = New System.Drawing.Size(65, 13)
        Me.lblPrisgrunnlag.TabIndex = 47
        Me.lblPrisgrunnlag.Text = "Prisgrunnlag"
        '
        'lblFra
        '
        Me.lblFra.AutoSize = True
        Me.lblFra.Location = New System.Drawing.Point(10, 57)
        Me.lblFra.Name = "lblFra"
        Me.lblFra.Size = New System.Drawing.Size(42, 13)
        Me.lblFra.TabIndex = 51
        Me.lblFra.Text = "Leie fra"
        '
        'lblTil
        '
        Me.lblTil.AutoSize = True
        Me.lblTil.Location = New System.Drawing.Point(10, 83)
        Me.lblTil.Name = "lblTil"
        Me.lblTil.Size = New System.Drawing.Size(37, 13)
        Me.lblTil.TabIndex = 52
        Me.lblTil.Text = "Leie til"
        '
        'cmbSykkel
        '
        Me.cmbSykkel.FormattingEnabled = True
        Me.cmbSykkel.Location = New System.Drawing.Point(11, 207)
        Me.cmbSykkel.Name = "cmbSykkel"
        Me.cmbSykkel.Size = New System.Drawing.Size(350, 21)
        Me.cmbSykkel.TabIndex = 54
        '
        'cmbUtstyr
        '
        Me.cmbUtstyr.FormattingEnabled = True
        Me.cmbUtstyr.Location = New System.Drawing.Point(11, 323)
        Me.cmbUtstyr.Name = "cmbUtstyr"
        Me.cmbUtstyr.Size = New System.Drawing.Size(350, 21)
        Me.cmbUtstyr.TabIndex = 55
        '
        'lblVelgKunde
        '
        Me.lblVelgKunde.AutoSize = True
        Me.lblVelgKunde.Location = New System.Drawing.Point(10, 142)
        Me.lblVelgKunde.Name = "lblVelgKunde"
        Me.lblVelgKunde.Size = New System.Drawing.Size(61, 13)
        Me.lblVelgKunde.TabIndex = 56
        Me.lblVelgKunde.Text = "Velg kunde"
        '
        'lblVelgSykkel
        '
        Me.lblVelgSykkel.AutoSize = True
        Me.lblVelgSykkel.Location = New System.Drawing.Point(8, 191)
        Me.lblVelgSykkel.Name = "lblVelgSykkel"
        Me.lblVelgSykkel.Size = New System.Drawing.Size(61, 13)
        Me.lblVelgSykkel.TabIndex = 57
        Me.lblVelgSykkel.Text = "Velg sykkel"
        '
        'lblVelgUtstyr
        '
        Me.lblVelgUtstyr.AutoSize = True
        Me.lblVelgUtstyr.Location = New System.Drawing.Point(10, 305)
        Me.lblVelgUtstyr.Name = "lblVelgUtstyr"
        Me.lblVelgUtstyr.Size = New System.Drawing.Size(56, 13)
        Me.lblVelgUtstyr.TabIndex = 58
        Me.lblVelgUtstyr.Text = "Velg utstyr"
        '
        'cmbKunde
        '
        Me.cmbKunde.FormattingEnabled = True
        Me.cmbKunde.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmbKunde.Location = New System.Drawing.Point(11, 158)
        Me.cmbKunde.Name = "cmbKunde"
        Me.cmbKunde.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbKunde.Size = New System.Drawing.Size(350, 21)
        Me.cmbKunde.TabIndex = 60
        '
        'lstSykkel
        '
        Me.lstSykkel.FormattingEnabled = True
        Me.lstSykkel.Location = New System.Drawing.Point(405, 207)
        Me.lstSykkel.Name = "lstSykkel"
        Me.lstSykkel.Size = New System.Drawing.Size(350, 95)
        Me.lstSykkel.TabIndex = 61
        '
        'lblSykkel
        '
        Me.lblSykkel.AutoSize = True
        Me.lblSykkel.Location = New System.Drawing.Point(405, 191)
        Me.lblSykkel.Name = "lblSykkel"
        Me.lblSykkel.Size = New System.Drawing.Size(39, 13)
        Me.lblSykkel.TabIndex = 62
        Me.lblSykkel.Text = "Sykkel"
        '
        'dtpTilTime
        '
        Me.dtpTilTime.CustomFormat = "HH"
        Me.dtpTilTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTilTime.Location = New System.Drawing.Point(311, 83)
        Me.dtpTilTime.Name = "dtpTilTime"
        Me.dtpTilTime.ShowUpDown = True
        Me.dtpTilTime.Size = New System.Drawing.Size(50, 20)
        Me.dtpTilTime.TabIndex = 46
        Me.dtpTilTime.Value = New Date(2019, 5, 1, 10, 0, 0, 0)
        '
        'dtpFraTime
        '
        Me.dtpFraTime.CustomFormat = "HH"
        Me.dtpFraTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFraTime.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.dtpFraTime.Location = New System.Drawing.Point(311, 57)
        Me.dtpFraTime.Name = "dtpFraTime"
        Me.dtpFraTime.ShowUpDown = True
        Me.dtpFraTime.Size = New System.Drawing.Size(50, 20)
        Me.dtpFraTime.TabIndex = 45
        Me.dtpFraTime.Value = New Date(2019, 5, 1, 10, 0, 0, 0)
        '
        'lblFraTid
        '
        Me.lblFraTid.AutoSize = True
        Me.lblFraTid.Location = New System.Drawing.Point(289, 83)
        Me.lblFraTid.Name = "lblFraTid"
        Me.lblFraTid.Size = New System.Drawing.Size(16, 13)
        Me.lblFraTid.TabIndex = 64
        Me.lblFraTid.Text = "Kl"
        '
        'lblTilTid
        '
        Me.lblTilTid.AutoSize = True
        Me.lblTilTid.Location = New System.Drawing.Point(289, 57)
        Me.lblTilTid.Name = "lblTilTid"
        Me.lblTilTid.Size = New System.Drawing.Size(16, 13)
        Me.lblTilTid.TabIndex = 65
        Me.lblTilTid.Text = "Kl"
        '
        'lblKunde
        '
        Me.lblKunde.AutoSize = True
        Me.lblKunde.Location = New System.Drawing.Point(404, 142)
        Me.lblKunde.Name = "lblKunde"
        Me.lblKunde.Size = New System.Drawing.Size(38, 13)
        Me.lblKunde.TabIndex = 67
        Me.lblKunde.Text = "Kunde"
        '
        'lstUtstyr
        '
        Me.lstUtstyr.FormattingEnabled = True
        Me.lstUtstyr.Location = New System.Drawing.Point(405, 321)
        Me.lstUtstyr.Name = "lstUtstyr"
        Me.lstUtstyr.Size = New System.Drawing.Size(350, 95)
        Me.lstUtstyr.TabIndex = 61
        '
        'lblUtstyr
        '
        Me.lblUtstyr.AutoSize = True
        Me.lblUtstyr.Location = New System.Drawing.Point(405, 305)
        Me.lblUtstyr.Name = "lblUtstyr"
        Me.lblUtstyr.Size = New System.Drawing.Size(34, 13)
        Me.lblUtstyr.TabIndex = 68
        Me.lblUtstyr.Text = "Utstyr"
        '
        'btnTømSkjema
        '
        Me.btnTømSkjema.Location = New System.Drawing.Point(405, 10)
        Me.btnTømSkjema.Name = "btnTømSkjema"
        Me.btnTømSkjema.Size = New System.Drawing.Size(145, 23)
        Me.btnTømSkjema.TabIndex = 73
        Me.btnTømSkjema.Text = "Tøm skjema"
        Me.btnTømSkjema.UseVisualStyleBackColor = True
        '
        'lstTidspunkt
        '
        Me.lstTidspunkt.FormattingEnabled = True
        Me.lstTidspunkt.Location = New System.Drawing.Point(405, 57)
        Me.lstTidspunkt.Name = "lstTidspunkt"
        Me.lstTidspunkt.Size = New System.Drawing.Size(350, 82)
        Me.lstTidspunkt.TabIndex = 75
        '
        'btnTid
        '
        Me.btnTid.Location = New System.Drawing.Point(13, 116)
        Me.btnTid.Name = "btnTid"
        Me.btnTid.Size = New System.Drawing.Size(350, 23)
        Me.btnTid.TabIndex = 76
        Me.btnTid.Text = "Legg til tidspunkt"
        Me.btnTid.UseVisualStyleBackColor = True
        '
        'lblTidspunkt
        '
        Me.lblTidspunkt.AutoSize = True
        Me.lblTidspunkt.Location = New System.Drawing.Point(404, 41)
        Me.lblTidspunkt.Name = "lblTidspunkt"
        Me.lblTidspunkt.Size = New System.Drawing.Size(77, 13)
        Me.lblTidspunkt.TabIndex = 77
        Me.lblTidspunkt.Text = "Valgt tidspunkt"
        '
        'lstKunde
        '
        Me.lstKunde.FormattingEnabled = True
        Me.lstKunde.Location = New System.Drawing.Point(405, 158)
        Me.lstKunde.Name = "lstKunde"
        Me.lstKunde.Size = New System.Drawing.Size(350, 30)
        Me.lstKunde.TabIndex = 66
        '
        'cmbUtlevering
        '
        Me.cmbUtlevering.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbUtlevering.FormattingEnabled = True
        Me.cmbUtlevering.Location = New System.Drawing.Point(11, 421)
        Me.cmbUtlevering.Name = "cmbUtlevering"
        Me.cmbUtlevering.Size = New System.Drawing.Size(350, 21)
        Me.cmbUtlevering.TabIndex = 78
        '
        'cmbInnlevering
        '
        Me.cmbInnlevering.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbInnlevering.FormattingEnabled = True
        Me.cmbInnlevering.Location = New System.Drawing.Point(11, 461)
        Me.cmbInnlevering.Name = "cmbInnlevering"
        Me.cmbInnlevering.Size = New System.Drawing.Size(350, 21)
        Me.cmbInnlevering.TabIndex = 79
        '
        'lblUtlevering
        '
        Me.lblUtlevering.AutoSize = True
        Me.lblUtlevering.Location = New System.Drawing.Point(12, 403)
        Me.lblUtlevering.Name = "lblUtlevering"
        Me.lblUtlevering.Size = New System.Drawing.Size(102, 13)
        Me.lblUtlevering.TabIndex = 80
        Me.lblUtlevering.Text = "Velg utleveringssted"
        '
        'lblInnlevering
        '
        Me.lblInnlevering.AutoSize = True
        Me.lblInnlevering.Location = New System.Drawing.Point(12, 445)
        Me.lblInnlevering.Name = "lblInnlevering"
        Me.lblInnlevering.Size = New System.Drawing.Size(107, 13)
        Me.lblInnlevering.TabIndex = 81
        Me.lblInnlevering.Text = "Velg innleveringssted"
        '
        'txtRabatt
        '
        Me.txtRabatt.Location = New System.Drawing.Point(405, 422)
        Me.txtRabatt.MaxLength = 2
        Me.txtRabatt.Name = "txtRabatt"
        Me.txtRabatt.Size = New System.Drawing.Size(30, 20)
        Me.txtRabatt.TabIndex = 82
        '
        'lblRabatt
        '
        Me.lblRabatt.AutoSize = True
        Me.lblRabatt.Location = New System.Drawing.Point(441, 425)
        Me.lblRabatt.Name = "lblRabatt"
        Me.lblRabatt.Size = New System.Drawing.Size(56, 13)
        Me.lblRabatt.TabIndex = 83
        Me.lblRabatt.Text = "Rabatt (%)"
        '
        'lblPrisFør
        '
        Me.lblPrisFør.AutoSize = True
        Me.lblPrisFør.Location = New System.Drawing.Point(577, 425)
        Me.lblPrisFør.Name = "lblPrisFør"
        Me.lblPrisFør.Size = New System.Drawing.Size(72, 13)
        Me.lblPrisFør.TabIndex = 84
        Me.lblPrisFør.Text = "Pris før rabatt:"
        '
        'txtPrisFør
        '
        Me.txtPrisFør.Location = New System.Drawing.Point(655, 422)
        Me.txtPrisFør.Name = "txtPrisFør"
        Me.txtPrisFør.ReadOnly = True
        Me.txtPrisFør.Size = New System.Drawing.Size(100, 20)
        Me.txtPrisFør.TabIndex = 85
        '
        'lblPrisEtter
        '
        Me.lblPrisEtter.AutoSize = True
        Me.lblPrisEtter.Location = New System.Drawing.Point(568, 477)
        Me.lblPrisEtter.Name = "lblPrisEtter"
        Me.lblPrisEtter.Size = New System.Drawing.Size(81, 13)
        Me.lblPrisEtter.TabIndex = 86
        Me.lblPrisEtter.Text = "Pris etter rabatt:"
        '
        'txtPrisEtter
        '
        Me.txtPrisEtter.Location = New System.Drawing.Point(655, 474)
        Me.txtPrisEtter.Name = "txtPrisEtter"
        Me.txtPrisEtter.ReadOnly = True
        Me.txtPrisEtter.Size = New System.Drawing.Size(100, 20)
        Me.txtPrisEtter.TabIndex = 87
        '
        'btnRegistrer
        '
        Me.btnRegistrer.Location = New System.Drawing.Point(11, 511)
        Me.btnRegistrer.Name = "btnRegistrer"
        Me.btnRegistrer.Size = New System.Drawing.Size(350, 23)
        Me.btnRegistrer.TabIndex = 88
        Me.btnRegistrer.Text = "Registrer leieavtale"
        Me.btnRegistrer.UseVisualStyleBackColor = True
        '
        'chkManuell
        '
        Me.chkManuell.AutoSize = True
        Me.chkManuell.Location = New System.Drawing.Point(408, 488)
        Me.chkManuell.Name = "chkManuell"
        Me.chkManuell.Size = New System.Drawing.Size(126, 17)
        Me.chkManuell.TabIndex = 89
        Me.chkManuell.Text = "Legg inn pris manuelt"
        Me.chkManuell.UseVisualStyleBackColor = True
        '
        'btnFjernrabatt
        '
        Me.btnFjernrabatt.Location = New System.Drawing.Point(405, 461)
        Me.btnFjernrabatt.Name = "btnFjernrabatt"
        Me.btnFjernrabatt.Size = New System.Drawing.Size(92, 21)
        Me.btnFjernrabatt.TabIndex = 90
        Me.btnFjernrabatt.Text = "Fjern rabatt"
        Me.btnFjernrabatt.UseVisualStyleBackColor = True
        '
        'lblValgtRabatt
        '
        Me.lblValgtRabatt.AutoSize = True
        Me.lblValgtRabatt.Location = New System.Drawing.Point(607, 451)
        Me.lblValgtRabatt.Name = "lblValgtRabatt"
        Me.lblValgtRabatt.Size = New System.Drawing.Size(42, 13)
        Me.lblValgtRabatt.TabIndex = 91
        Me.lblValgtRabatt.Text = "Rabatt:"
        '
        'txtValgtRabatt
        '
        Me.txtValgtRabatt.Location = New System.Drawing.Point(655, 448)
        Me.txtValgtRabatt.Name = "txtValgtRabatt"
        Me.txtValgtRabatt.ReadOnly = True
        Me.txtValgtRabatt.Size = New System.Drawing.Size(100, 20)
        Me.txtValgtRabatt.TabIndex = 92
        '
        'lblInnloggetAvdeling
        '
        Me.lblInnloggetAvdeling.AutoSize = True
        Me.lblInnloggetAvdeling.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblInnloggetAvdeling.Location = New System.Drawing.Point(8, 609)
        Me.lblInnloggetAvdeling.Name = "lblInnloggetAvdeling"
        Me.lblInnloggetAvdeling.Size = New System.Drawing.Size(143, 17)
        Me.lblInnloggetAvdeling.TabIndex = 93
        Me.lblInnloggetAvdeling.Text = "Innlogget på avdeling"
        '
        'txtLeieavtaleNr
        '
        Me.txtLeieavtaleNr.Location = New System.Drawing.Point(957, 422)
        Me.txtLeieavtaleNr.Name = "txtLeieavtaleNr"
        Me.txtLeieavtaleNr.ReadOnly = True
        Me.txtLeieavtaleNr.Size = New System.Drawing.Size(175, 20)
        Me.txtLeieavtaleNr.TabIndex = 94
        '
        'lstLeieavtaler
        '
        Me.lstLeieavtaler.FormattingEnabled = True
        Me.lstLeieavtaler.Location = New System.Drawing.Point(782, 57)
        Me.lstLeieavtaler.Name = "lstLeieavtaler"
        Me.lstLeieavtaler.Size = New System.Drawing.Size(350, 355)
        Me.lstLeieavtaler.TabIndex = 95
        '
        'btnHent
        '
        Me.btnHent.Location = New System.Drawing.Point(992, 12)
        Me.btnHent.Name = "btnHent"
        Me.btnHent.Size = New System.Drawing.Size(140, 23)
        Me.btnHent.TabIndex = 96
        Me.btnHent.Text = "Hent leieavtaler"
        Me.btnHent.UseVisualStyleBackColor = True
        '
        'btnAvbestill
        '
        Me.btnAvbestill.Location = New System.Drawing.Point(11, 570)
        Me.btnAvbestill.Name = "btnAvbestill"
        Me.btnAvbestill.Size = New System.Drawing.Size(350, 23)
        Me.btnAvbestill.TabIndex = 97
        Me.btnAvbestill.Text = "Avbestill"
        Me.btnAvbestill.UseVisualStyleBackColor = True
        '
        'btnOppdater
        '
        Me.btnOppdater.Location = New System.Drawing.Point(11, 541)
        Me.btnOppdater.Name = "btnOppdater"
        Me.btnOppdater.Size = New System.Drawing.Size(350, 23)
        Me.btnOppdater.TabIndex = 98
        Me.btnOppdater.Text = "Oppdater leieavtale"
        Me.btnOppdater.UseVisualStyleBackColor = True
        '
        'btnUtlevering
        '
        Me.btnUtlevering.Location = New System.Drawing.Point(782, 511)
        Me.btnUtlevering.Name = "btnUtlevering"
        Me.btnUtlevering.Size = New System.Drawing.Size(350, 23)
        Me.btnUtlevering.TabIndex = 99
        Me.btnUtlevering.Text = "Utlever til kunde"
        Me.btnUtlevering.UseVisualStyleBackColor = True
        '
        'txtStatus
        '
        Me.txtStatus.Location = New System.Drawing.Point(957, 474)
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.ReadOnly = True
        Me.txtStatus.Size = New System.Drawing.Size(175, 20)
        Me.txtStatus.TabIndex = 100
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(911, 477)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(40, 13)
        Me.lblStatus.TabIndex = 101
        Me.lblStatus.Text = "Status:"
        '
        'btnInnlevering
        '
        Me.btnInnlevering.Location = New System.Drawing.Point(782, 541)
        Me.btnInnlevering.Name = "btnInnlevering"
        Me.btnInnlevering.Size = New System.Drawing.Size(350, 23)
        Me.btnInnlevering.TabIndex = 102
        Me.btnInnlevering.Text = "Ta i mot fra kunde"
        Me.btnInnlevering.UseVisualStyleBackColor = True
        '
        'btnFjernKunde
        '
        Me.btnFjernKunde.Location = New System.Drawing.Point(368, 156)
        Me.btnFjernKunde.Name = "btnFjernKunde"
        Me.btnFjernKunde.Size = New System.Drawing.Size(30, 23)
        Me.btnFjernKunde.TabIndex = 103
        Me.btnFjernKunde.Text = "X"
        Me.btnFjernKunde.UseVisualStyleBackColor = True
        '
        'btnFjernSykkel
        '
        Me.btnFjernSykkel.Location = New System.Drawing.Point(369, 207)
        Me.btnFjernSykkel.Name = "btnFjernSykkel"
        Me.btnFjernSykkel.Size = New System.Drawing.Size(30, 23)
        Me.btnFjernSykkel.TabIndex = 104
        Me.btnFjernSykkel.Text = "X"
        Me.btnFjernSykkel.UseVisualStyleBackColor = True
        '
        'btnFjernUtstyr
        '
        Me.btnFjernUtstyr.Location = New System.Drawing.Point(369, 321)
        Me.btnFjernUtstyr.Name = "btnFjernUtstyr"
        Me.btnFjernUtstyr.Size = New System.Drawing.Size(30, 23)
        Me.btnFjernUtstyr.TabIndex = 105
        Me.btnFjernUtstyr.Text = "X"
        Me.btnFjernUtstyr.UseVisualStyleBackColor = True
        '
        'txtAvdeling
        '
        Me.txtAvdeling.Location = New System.Drawing.Point(957, 448)
        Me.txtAvdeling.Name = "txtAvdeling"
        Me.txtAvdeling.ReadOnly = True
        Me.txtAvdeling.Size = New System.Drawing.Size(175, 20)
        Me.txtAvdeling.TabIndex = 106
        '
        'lblAvdeling
        '
        Me.lblAvdeling.AutoSize = True
        Me.lblAvdeling.Location = New System.Drawing.Point(900, 451)
        Me.lblAvdeling.Name = "lblAvdeling"
        Me.lblAvdeling.Size = New System.Drawing.Size(51, 13)
        Me.lblAvdeling.TabIndex = 107
        Me.lblAvdeling.Text = "Avdeling:"
        '
        'lblLeieavtaleNr
        '
        Me.lblLeieavtaleNr.AutoSize = True
        Me.lblLeieavtaleNr.Location = New System.Drawing.Point(880, 425)
        Me.lblLeieavtaleNr.Name = "lblLeieavtaleNr"
        Me.lblLeieavtaleNr.Size = New System.Drawing.Size(71, 13)
        Me.lblLeieavtaleNr.TabIndex = 108
        Me.lblLeieavtaleNr.Text = "Leieavtale nr:"
        '
        'Leieavtaler
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.Disable
        Me.ClientSize = New System.Drawing.Size(1161, 635)
        Me.Controls.Add(Me.lblLeieavtaleNr)
        Me.Controls.Add(Me.lblAvdeling)
        Me.Controls.Add(Me.txtAvdeling)
        Me.Controls.Add(Me.btnFjernUtstyr)
        Me.Controls.Add(Me.btnFjernSykkel)
        Me.Controls.Add(Me.btnFjernKunde)
        Me.Controls.Add(Me.btnInnlevering)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.txtStatus)
        Me.Controls.Add(Me.btnUtlevering)
        Me.Controls.Add(Me.btnOppdater)
        Me.Controls.Add(Me.btnAvbestill)
        Me.Controls.Add(Me.btnHent)
        Me.Controls.Add(Me.lstLeieavtaler)
        Me.Controls.Add(Me.txtLeieavtaleNr)
        Me.Controls.Add(Me.lblInnloggetAvdeling)
        Me.Controls.Add(Me.txtValgtRabatt)
        Me.Controls.Add(Me.lblValgtRabatt)
        Me.Controls.Add(Me.btnFjernrabatt)
        Me.Controls.Add(Me.chkManuell)
        Me.Controls.Add(Me.btnRegistrer)
        Me.Controls.Add(Me.txtPrisEtter)
        Me.Controls.Add(Me.lblPrisEtter)
        Me.Controls.Add(Me.txtPrisFør)
        Me.Controls.Add(Me.lblPrisFør)
        Me.Controls.Add(Me.lblRabatt)
        Me.Controls.Add(Me.txtRabatt)
        Me.Controls.Add(Me.lblInnlevering)
        Me.Controls.Add(Me.lblUtlevering)
        Me.Controls.Add(Me.cmbInnlevering)
        Me.Controls.Add(Me.cmbUtlevering)
        Me.Controls.Add(Me.lblTidspunkt)
        Me.Controls.Add(Me.btnTid)
        Me.Controls.Add(Me.lstTidspunkt)
        Me.Controls.Add(Me.btnTømSkjema)
        Me.Controls.Add(Me.lblUtstyr)
        Me.Controls.Add(Me.lblKunde)
        Me.Controls.Add(Me.lstKunde)
        Me.Controls.Add(Me.lblTilTid)
        Me.Controls.Add(Me.lblFraTid)
        Me.Controls.Add(Me.lblSykkel)
        Me.Controls.Add(Me.lstUtstyr)
        Me.Controls.Add(Me.lstSykkel)
        Me.Controls.Add(Me.cmbKunde)
        Me.Controls.Add(Me.lblVelgUtstyr)
        Me.Controls.Add(Me.lblVelgSykkel)
        Me.Controls.Add(Me.lblVelgKunde)
        Me.Controls.Add(Me.cmbUtstyr)
        Me.Controls.Add(Me.cmbSykkel)
        Me.Controls.Add(Me.lblTil)
        Me.Controls.Add(Me.lblFra)
        Me.Controls.Add(Me.lblPrisgrunnlag)
        Me.Controls.Add(Me.dtpTilTime)
        Me.Controls.Add(Me.dtpFraTime)
        Me.Controls.Add(Me.dtpTilDato)
        Me.Controls.Add(Me.dtpFraDato)
        Me.Controls.Add(Me.btnTilbake)
        Me.Name = "Leieavtaler"
        Me.Text = "Leieavtaler"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnTilbake As Button
    Friend WithEvents dtpFraDato As DateTimePicker
    Friend WithEvents dtpTilDato As DateTimePicker
    Friend WithEvents lblPrisgrunnlag As Label
    Friend WithEvents lblFra As Label
    Friend WithEvents lblTil As Label
    Friend WithEvents cmbSykkel As ComboBox
    Friend WithEvents cmbUtstyr As ComboBox
    Friend WithEvents lblVelgKunde As Label
    Friend WithEvents lblVelgSykkel As Label
    Friend WithEvents lblVelgUtstyr As Label
    Friend WithEvents cmbKunde As ComboBox
    Friend WithEvents lstSykkel As ListBox
    Friend WithEvents lblSykkel As Label
    Friend WithEvents dtpTilTime As DateTimePicker
    Friend WithEvents dtpFraTime As DateTimePicker
    Friend WithEvents lblFraTid As Label
    Friend WithEvents lblTilTid As Label
    Friend WithEvents lblKunde As Label
    Friend WithEvents lstUtstyr As ListBox
    Friend WithEvents lblUtstyr As Label
    Friend WithEvents btnTømSkjema As Button
    Friend WithEvents lstTidspunkt As ListBox
    Friend WithEvents btnTid As Button
    Friend WithEvents lblTidspunkt As Label
    Friend WithEvents lstKunde As ListBox
    Friend WithEvents cmbUtlevering As ComboBox
    Friend WithEvents cmbInnlevering As ComboBox
    Friend WithEvents lblUtlevering As Label
    Friend WithEvents lblInnlevering As Label
    Friend WithEvents txtRabatt As TextBox
    Friend WithEvents lblRabatt As Label
    Friend WithEvents lblPrisFør As Label
    Friend WithEvents txtPrisFør As TextBox
    Friend WithEvents lblPrisEtter As Label
    Friend WithEvents txtPrisEtter As TextBox
    Friend WithEvents btnRegistrer As Button
    Friend WithEvents chkManuell As CheckBox
    Friend WithEvents btnFjernrabatt As Button
    Friend WithEvents lblValgtRabatt As Label
    Friend WithEvents txtValgtRabatt As TextBox
    Friend WithEvents lblInnloggetAvdeling As Label
    Friend WithEvents txtLeieavtaleNr As TextBox
    Friend WithEvents lstLeieavtaler As ListBox
    Friend WithEvents btnHent As Button
    Friend WithEvents btnAvbestill As Button
    Friend WithEvents btnOppdater As Button
    Friend WithEvents btnUtlevering As Button
    Friend WithEvents txtStatus As TextBox
    Friend WithEvents lblStatus As Label
    Friend WithEvents btnInnlevering As Button
    Friend WithEvents btnFjernKunde As Button
    Friend WithEvents btnFjernSykkel As Button
    Friend WithEvents btnFjernUtstyr As Button
    Friend WithEvents txtAvdeling As TextBox
    Friend WithEvents lblAvdeling As Label
    Friend WithEvents lblLeieavtaleNr As Label
End Class

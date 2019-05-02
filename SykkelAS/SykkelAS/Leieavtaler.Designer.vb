<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Leieavtaler
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnTilbake = New System.Windows.Forms.Button()
        Me.dtpFraDato = New System.Windows.Forms.DateTimePicker()
        Me.dtpTilDato = New System.Windows.Forms.DateTimePicker()
        Me.lblPrisgrunnlag = New System.Windows.Forms.Label()
        Me.chkPrisTime = New System.Windows.Forms.CheckBox()
        Me.chkPrisDøgn = New System.Windows.Forms.CheckBox()
        Me.chkPrisHelg = New System.Windows.Forms.CheckBox()
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dtpTilTid = New System.Windows.Forms.DateTimePicker()
        Me.dtpFraTid = New System.Windows.Forms.DateTimePicker()
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
        Me.SuspendLayout()
        '
        'btnTilbake
        '
        Me.btnTilbake.Location = New System.Drawing.Point(805, 576)
        Me.btnTilbake.Name = "btnTilbake"
        Me.btnTilbake.Size = New System.Drawing.Size(167, 23)
        Me.btnTilbake.TabIndex = 42
        Me.btnTilbake.Text = "Hovedmeny"
        Me.btnTilbake.UseVisualStyleBackColor = True
        '
        'dtpFraDato
        '
        Me.dtpFraDato.Location = New System.Drawing.Point(15, 77)
        Me.dtpFraDato.Name = "dtpFraDato"
        Me.dtpFraDato.Size = New System.Drawing.Size(189, 20)
        Me.dtpFraDato.TabIndex = 43
        Me.dtpFraDato.Value = New Date(2019, 5, 1, 10, 0, 0, 0)
        '
        'dtpTilDato
        '
        Me.dtpTilDato.Location = New System.Drawing.Point(15, 129)
        Me.dtpTilDato.Name = "dtpTilDato"
        Me.dtpTilDato.Size = New System.Drawing.Size(189, 20)
        Me.dtpTilDato.TabIndex = 44
        Me.dtpTilDato.Value = New Date(2019, 5, 1, 10, 0, 0, 0)
        '
        'lblPrisgrunnlag
        '
        Me.lblPrisgrunnlag.AutoSize = True
        Me.lblPrisgrunnlag.Location = New System.Drawing.Point(12, 9)
        Me.lblPrisgrunnlag.Name = "lblPrisgrunnlag"
        Me.lblPrisgrunnlag.Size = New System.Drawing.Size(65, 13)
        Me.lblPrisgrunnlag.TabIndex = 47
        Me.lblPrisgrunnlag.Text = "Prisgrunnlag"
        '
        'chkPrisTime
        '
        Me.chkPrisTime.AutoSize = True
        Me.chkPrisTime.Location = New System.Drawing.Point(15, 27)
        Me.chkPrisTime.Name = "chkPrisTime"
        Me.chkPrisTime.Size = New System.Drawing.Size(49, 17)
        Me.chkPrisTime.TabIndex = 48
        Me.chkPrisTime.Text = "Time"
        Me.chkPrisTime.UseVisualStyleBackColor = True
        '
        'chkPrisDøgn
        '
        Me.chkPrisDøgn.AutoSize = True
        Me.chkPrisDøgn.Location = New System.Drawing.Point(70, 27)
        Me.chkPrisDøgn.Name = "chkPrisDøgn"
        Me.chkPrisDøgn.Size = New System.Drawing.Size(52, 17)
        Me.chkPrisDøgn.TabIndex = 49
        Me.chkPrisDøgn.Text = "Døgn"
        Me.chkPrisDøgn.UseVisualStyleBackColor = True
        '
        'chkPrisHelg
        '
        Me.chkPrisHelg.AutoSize = True
        Me.chkPrisHelg.Location = New System.Drawing.Point(128, 27)
        Me.chkPrisHelg.Name = "chkPrisHelg"
        Me.chkPrisHelg.Size = New System.Drawing.Size(48, 17)
        Me.chkPrisHelg.TabIndex = 50
        Me.chkPrisHelg.Text = "Helg"
        Me.chkPrisHelg.UseVisualStyleBackColor = True
        '
        'lblFra
        '
        Me.lblFra.AutoSize = True
        Me.lblFra.Location = New System.Drawing.Point(12, 60)
        Me.lblFra.Name = "lblFra"
        Me.lblFra.Size = New System.Drawing.Size(42, 13)
        Me.lblFra.TabIndex = 51
        Me.lblFra.Text = "Leie fra"
        '
        'lblTil
        '
        Me.lblTil.AutoSize = True
        Me.lblTil.Location = New System.Drawing.Point(17, 113)
        Me.lblTil.Name = "lblTil"
        Me.lblTil.Size = New System.Drawing.Size(37, 13)
        Me.lblTil.TabIndex = 52
        Me.lblTil.Text = "Leie til"
        '
        'cmbSykkel
        '
        Me.cmbSykkel.FormattingEnabled = True
        Me.cmbSykkel.Location = New System.Drawing.Point(12, 272)
        Me.cmbSykkel.Name = "cmbSykkel"
        Me.cmbSykkel.Size = New System.Drawing.Size(350, 21)
        Me.cmbSykkel.TabIndex = 54
        '
        'cmbUtstyr
        '
        Me.cmbUtstyr.FormattingEnabled = True
        Me.cmbUtstyr.Location = New System.Drawing.Point(12, 332)
        Me.cmbUtstyr.Name = "cmbUtstyr"
        Me.cmbUtstyr.Size = New System.Drawing.Size(350, 21)
        Me.cmbUtstyr.TabIndex = 55
        '
        'lblVelgKunde
        '
        Me.lblVelgKunde.AutoSize = True
        Me.lblVelgKunde.Location = New System.Drawing.Point(9, 203)
        Me.lblVelgKunde.Name = "lblVelgKunde"
        Me.lblVelgKunde.Size = New System.Drawing.Size(61, 13)
        Me.lblVelgKunde.TabIndex = 56
        Me.lblVelgKunde.Text = "Velg kunde"
        '
        'lblVelgSykkel
        '
        Me.lblVelgSykkel.AutoSize = True
        Me.lblVelgSykkel.Location = New System.Drawing.Point(9, 256)
        Me.lblVelgSykkel.Name = "lblVelgSykkel"
        Me.lblVelgSykkel.Size = New System.Drawing.Size(61, 13)
        Me.lblVelgSykkel.TabIndex = 57
        Me.lblVelgSykkel.Text = "Velg sykkel"
        '
        'lblVelgUtstyr
        '
        Me.lblVelgUtstyr.AutoSize = True
        Me.lblVelgUtstyr.Location = New System.Drawing.Point(8, 316)
        Me.lblVelgUtstyr.Name = "lblVelgUtstyr"
        Me.lblVelgUtstyr.Size = New System.Drawing.Size(56, 13)
        Me.lblVelgUtstyr.TabIndex = 58
        Me.lblVelgUtstyr.Text = "Velg utstyr"
        '
        'cmbKunde
        '
        Me.cmbKunde.FormattingEnabled = True
        Me.cmbKunde.Location = New System.Drawing.Point(12, 219)
        Me.cmbKunde.Name = "cmbKunde"
        Me.cmbKunde.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbKunde.Size = New System.Drawing.Size(350, 21)
        Me.cmbKunde.TabIndex = 60
        '
        'lstSykkel
        '
        Me.lstSykkel.FormattingEnabled = True
        Me.lstSykkel.Location = New System.Drawing.Point(394, 182)
        Me.lstSykkel.Name = "lstSykkel"
        Me.lstSykkel.Size = New System.Drawing.Size(350, 95)
        Me.lstSykkel.TabIndex = 61
        '
        'lblSykkel
        '
        Me.lblSykkel.AutoSize = True
        Me.lblSykkel.Location = New System.Drawing.Point(393, 165)
        Me.lblSykkel.Name = "lblSykkel"
        Me.lblSykkel.Size = New System.Drawing.Size(39, 13)
        Me.lblSykkel.TabIndex = 62
        Me.lblSykkel.Text = "Sykkel"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(117, 482)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(134, 23)
        Me.Button1.TabIndex = 63
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'dtpTilTid
        '
        Me.dtpTilTid.CustomFormat = "HH"
        Me.dtpTilTid.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTilTid.Location = New System.Drawing.Point(210, 129)
        Me.dtpTilTid.Name = "dtpTilTid"
        Me.dtpTilTid.ShowUpDown = True
        Me.dtpTilTid.Size = New System.Drawing.Size(50, 20)
        Me.dtpTilTid.TabIndex = 46
        Me.dtpTilTid.Value = New Date(2019, 5, 1, 10, 0, 0, 0)
        '
        'dtpFraTid
        '
        Me.dtpFraTid.CustomFormat = "HH"
        Me.dtpFraTid.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFraTid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.dtpFraTid.Location = New System.Drawing.Point(210, 77)
        Me.dtpFraTid.Name = "dtpFraTid"
        Me.dtpFraTid.ShowUpDown = True
        Me.dtpFraTid.Size = New System.Drawing.Size(50, 20)
        Me.dtpFraTid.TabIndex = 45
        Me.dtpFraTid.Value = New Date(2019, 5, 1, 10, 0, 0, 0)
        '
        'lblFraTid
        '
        Me.lblFraTid.AutoSize = True
        Me.lblFraTid.Location = New System.Drawing.Point(207, 113)
        Me.lblFraTid.Name = "lblFraTid"
        Me.lblFraTid.Size = New System.Drawing.Size(16, 13)
        Me.lblFraTid.TabIndex = 64
        Me.lblFraTid.Text = "Kl"
        '
        'lblTilTid
        '
        Me.lblTilTid.AutoSize = True
        Me.lblTilTid.Location = New System.Drawing.Point(207, 61)
        Me.lblTilTid.Name = "lblTilTid"
        Me.lblTilTid.Size = New System.Drawing.Size(16, 13)
        Me.lblTilTid.TabIndex = 65
        Me.lblTilTid.Text = "Kl"
        '
        'lblKunde
        '
        Me.lblKunde.AutoSize = True
        Me.lblKunde.Location = New System.Drawing.Point(391, 116)
        Me.lblKunde.Name = "lblKunde"
        Me.lblKunde.Size = New System.Drawing.Size(38, 13)
        Me.lblKunde.TabIndex = 67
        Me.lblKunde.Text = "Kunde"
        '
        'lstUtstyr
        '
        Me.lstUtstyr.FormattingEnabled = True
        Me.lstUtstyr.Location = New System.Drawing.Point(394, 296)
        Me.lstUtstyr.Name = "lstUtstyr"
        Me.lstUtstyr.Size = New System.Drawing.Size(350, 95)
        Me.lstUtstyr.TabIndex = 61
        '
        'lblUtstyr
        '
        Me.lblUtstyr.AutoSize = True
        Me.lblUtstyr.Location = New System.Drawing.Point(397, 280)
        Me.lblUtstyr.Name = "lblUtstyr"
        Me.lblUtstyr.Size = New System.Drawing.Size(34, 13)
        Me.lblUtstyr.TabIndex = 68
        Me.lblUtstyr.Text = "Utstyr"
        '
        'btnTømSkjema
        '
        Me.btnTømSkjema.Location = New System.Drawing.Point(394, 397)
        Me.btnTømSkjema.Name = "btnTømSkjema"
        Me.btnTømSkjema.Size = New System.Drawing.Size(127, 23)
        Me.btnTømSkjema.TabIndex = 73
        Me.btnTømSkjema.Text = "Tøm skjema"
        Me.btnTømSkjema.UseVisualStyleBackColor = True
        '
        'lstTidspunkt
        '
        Me.lstTidspunkt.FormattingEnabled = True
        Me.lstTidspunkt.Location = New System.Drawing.Point(394, 41)
        Me.lstTidspunkt.Name = "lstTidspunkt"
        Me.lstTidspunkt.Size = New System.Drawing.Size(350, 69)
        Me.lstTidspunkt.TabIndex = 75
        '
        'btnTid
        '
        Me.btnTid.Location = New System.Drawing.Point(12, 155)
        Me.btnTid.Name = "btnTid"
        Me.btnTid.Size = New System.Drawing.Size(192, 23)
        Me.btnTid.TabIndex = 76
        Me.btnTid.Text = "Legg til tidspunkt"
        Me.btnTid.UseVisualStyleBackColor = True
        '
        'lblTidspunkt
        '
        Me.lblTidspunkt.AutoSize = True
        Me.lblTidspunkt.Location = New System.Drawing.Point(391, 25)
        Me.lblTidspunkt.Name = "lblTidspunkt"
        Me.lblTidspunkt.Size = New System.Drawing.Size(77, 13)
        Me.lblTidspunkt.TabIndex = 77
        Me.lblTidspunkt.Text = "Valgt tidspunkt"
        '
        'lstKunde
        '
        Me.lstKunde.FormattingEnabled = True
        Me.lstKunde.Location = New System.Drawing.Point(394, 132)
        Me.lstKunde.Name = "lstKunde"
        Me.lstKunde.Size = New System.Drawing.Size(350, 30)
        Me.lstKunde.TabIndex = 66
        '
        'Leieavtaler
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 611)
        Me.Controls.Add(Me.lblTidspunkt)
        Me.Controls.Add(Me.btnTid)
        Me.Controls.Add(Me.lstTidspunkt)
        Me.Controls.Add(Me.btnTømSkjema)
        Me.Controls.Add(Me.lblUtstyr)
        Me.Controls.Add(Me.lblKunde)
        Me.Controls.Add(Me.lstKunde)
        Me.Controls.Add(Me.lblTilTid)
        Me.Controls.Add(Me.lblFraTid)
        Me.Controls.Add(Me.Button1)
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
        Me.Controls.Add(Me.chkPrisHelg)
        Me.Controls.Add(Me.chkPrisDøgn)
        Me.Controls.Add(Me.chkPrisTime)
        Me.Controls.Add(Me.lblPrisgrunnlag)
        Me.Controls.Add(Me.dtpTilTid)
        Me.Controls.Add(Me.dtpFraTid)
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
    Friend WithEvents chkPrisTime As CheckBox
    Friend WithEvents chkPrisDøgn As CheckBox
    Friend WithEvents chkPrisHelg As CheckBox
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
    Friend WithEvents Button1 As Button
    Friend WithEvents dtpTilTid As DateTimePicker
    Friend WithEvents dtpFraTid As DateTimePicker
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
End Class

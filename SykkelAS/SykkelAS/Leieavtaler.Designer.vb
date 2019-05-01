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
        Me.lstLeieavtale = New System.Windows.Forms.ListBox()
        Me.lblLeieavtale = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dtpTilTid = New System.Windows.Forms.DateTimePicker()
        Me.dtpFraTid = New System.Windows.Forms.DateTimePicker()
        Me.lblFraTid = New System.Windows.Forms.Label()
        Me.lblTilTid = New System.Windows.Forms.Label()
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
        Me.dtpFraDato.Location = New System.Drawing.Point(12, 92)
        Me.dtpFraDato.Name = "dtpFraDato"
        Me.dtpFraDato.Size = New System.Drawing.Size(200, 20)
        Me.dtpFraDato.TabIndex = 43
        '
        'dtpTilDato
        '
        Me.dtpTilDato.Location = New System.Drawing.Point(12, 180)
        Me.dtpTilDato.Name = "dtpTilDato"
        Me.dtpTilDato.Size = New System.Drawing.Size(200, 20)
        Me.dtpTilDato.TabIndex = 44
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
        Me.lblFra.Location = New System.Drawing.Point(12, 76)
        Me.lblFra.Name = "lblFra"
        Me.lblFra.Size = New System.Drawing.Size(42, 13)
        Me.lblFra.TabIndex = 51
        Me.lblFra.Text = "Leie fra"
        '
        'lblTil
        '
        Me.lblTil.AutoSize = True
        Me.lblTil.Location = New System.Drawing.Point(12, 164)
        Me.lblTil.Name = "lblTil"
        Me.lblTil.Size = New System.Drawing.Size(37, 13)
        Me.lblTil.TabIndex = 52
        Me.lblTil.Text = "Leie til"
        '
        'cmbSykkel
        '
        Me.cmbSykkel.FormattingEnabled = True
        Me.cmbSykkel.Location = New System.Drawing.Point(649, 67)
        Me.cmbSykkel.Name = "cmbSykkel"
        Me.cmbSykkel.Size = New System.Drawing.Size(323, 21)
        Me.cmbSykkel.TabIndex = 54
        '
        'cmbUtstyr
        '
        Me.cmbUtstyr.FormattingEnabled = True
        Me.cmbUtstyr.Location = New System.Drawing.Point(649, 107)
        Me.cmbUtstyr.Name = "cmbUtstyr"
        Me.cmbUtstyr.Size = New System.Drawing.Size(323, 21)
        Me.cmbUtstyr.TabIndex = 55
        '
        'lblVelgKunde
        '
        Me.lblVelgKunde.AutoSize = True
        Me.lblVelgKunde.Location = New System.Drawing.Point(647, 9)
        Me.lblVelgKunde.Name = "lblVelgKunde"
        Me.lblVelgKunde.Size = New System.Drawing.Size(61, 13)
        Me.lblVelgKunde.TabIndex = 56
        Me.lblVelgKunde.Text = "Velg kunde"
        '
        'lblVelgSykkel
        '
        Me.lblVelgSykkel.AutoSize = True
        Me.lblVelgSykkel.Location = New System.Drawing.Point(647, 51)
        Me.lblVelgSykkel.Name = "lblVelgSykkel"
        Me.lblVelgSykkel.Size = New System.Drawing.Size(61, 13)
        Me.lblVelgSykkel.TabIndex = 57
        Me.lblVelgSykkel.Text = "Velg sykkel"
        '
        'lblVelgUtstyr
        '
        Me.lblVelgUtstyr.AutoSize = True
        Me.lblVelgUtstyr.Location = New System.Drawing.Point(647, 92)
        Me.lblVelgUtstyr.Name = "lblVelgUtstyr"
        Me.lblVelgUtstyr.Size = New System.Drawing.Size(56, 13)
        Me.lblVelgUtstyr.TabIndex = 58
        Me.lblVelgUtstyr.Text = "Velg utstyr"
        '
        'cmbKunde
        '
        Me.cmbKunde.FormattingEnabled = True
        Me.cmbKunde.Location = New System.Drawing.Point(650, 27)
        Me.cmbKunde.Name = "cmbKunde"
        Me.cmbKunde.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbKunde.Size = New System.Drawing.Size(322, 21)
        Me.cmbKunde.TabIndex = 60
        '
        'lstLeieavtale
        '
        Me.lstLeieavtale.FormattingEnabled = True
        Me.lstLeieavtale.Location = New System.Drawing.Point(218, 27)
        Me.lstLeieavtale.Name = "lstLeieavtale"
        Me.lstLeieavtale.Size = New System.Drawing.Size(423, 199)
        Me.lstLeieavtale.TabIndex = 61
        '
        'lblLeieavtale
        '
        Me.lblLeieavtale.AutoSize = True
        Me.lblLeieavtale.Location = New System.Drawing.Point(215, 9)
        Me.lblLeieavtale.Name = "lblLeieavtale"
        Me.lblLeieavtale.Size = New System.Drawing.Size(56, 13)
        Me.lblLeieavtale.TabIndex = 62
        Me.lblLeieavtale.Text = "Leieavtale"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 256)
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
        Me.dtpTilTid.Location = New System.Drawing.Point(162, 206)
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
        Me.dtpFraTid.Location = New System.Drawing.Point(162, 118)
        Me.dtpFraTid.Name = "dtpFraTid"
        Me.dtpFraTid.ShowUpDown = True
        Me.dtpFraTid.Size = New System.Drawing.Size(50, 20)
        Me.dtpFraTid.TabIndex = 45
        Me.dtpFraTid.Value = New Date(2019, 5, 1, 10, 0, 0, 0)
        '
        'lblFraTid
        '
        Me.lblFraTid.AutoSize = True
        Me.lblFraTid.Location = New System.Drawing.Point(140, 124)
        Me.lblFraTid.Name = "lblFraTid"
        Me.lblFraTid.Size = New System.Drawing.Size(16, 13)
        Me.lblFraTid.TabIndex = 64
        Me.lblFraTid.Text = "Kl"
        '
        'lblTilTid
        '
        Me.lblTilTid.AutoSize = True
        Me.lblTilTid.Location = New System.Drawing.Point(140, 212)
        Me.lblTilTid.Name = "lblTilTid"
        Me.lblTilTid.Size = New System.Drawing.Size(16, 13)
        Me.lblTilTid.TabIndex = 65
        Me.lblTilTid.Text = "Kl"
        '
        'Leieavtaler
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 611)
        Me.Controls.Add(Me.lblTilTid)
        Me.Controls.Add(Me.lblFraTid)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblLeieavtale)
        Me.Controls.Add(Me.lstLeieavtale)
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
    Friend WithEvents lstLeieavtale As ListBox
    Friend WithEvents lblLeieavtale As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents dtpTilTid As DateTimePicker
    Friend WithEvents dtpFraTid As DateTimePicker
    Friend WithEvents lblFraTid As Label
    Friend WithEvents lblTilTid As Label
End Class

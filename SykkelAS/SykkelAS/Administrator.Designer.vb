<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Administrator
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
        Me.txtAvdelingsnavn = New System.Windows.Forms.TextBox()
        Me.lblAvdelingsnavn = New System.Windows.Forms.Label()
        Me.txtAdresse = New System.Windows.Forms.TextBox()
        Me.lblAdresse = New System.Windows.Forms.Label()
        Me.lblPostnummer = New System.Windows.Forms.Label()
        Me.txtPostnummer = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.lblSted = New System.Windows.Forms.Label()
        Me.txtEpost = New System.Windows.Forms.TextBox()
        Me.lblEpost = New System.Windows.Forms.Label()
        Me.txtTelefon = New System.Windows.Forms.TextBox()
        Me.lblTelefon = New System.Windows.Forms.Label()
        Me.txtPassord = New System.Windows.Forms.TextBox()
        Me.txtBekreftPassord = New System.Windows.Forms.TextBox()
        Me.lblPassord = New System.Windows.Forms.Label()
        Me.lblBekreftPassord = New System.Windows.Forms.Label()
        Me.txtAvdelingNr = New System.Windows.Forms.TextBox()
        Me.lblAvdelingNr = New System.Windows.Forms.Label()
        Me.btnOpprett = New System.Windows.Forms.Button()
        Me.btnOppdater = New System.Windows.Forms.Button()
        Me.btnSlett = New System.Windows.Forms.Button()
        Me.cmbAvdeling = New System.Windows.Forms.ComboBox()
        Me.btnTilbake = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtAvdelingsnavn
        '
        Me.txtAvdelingsnavn.Location = New System.Drawing.Point(107, 32)
        Me.txtAvdelingsnavn.Name = "txtAvdelingsnavn"
        Me.txtAvdelingsnavn.Size = New System.Drawing.Size(200, 20)
        Me.txtAvdelingsnavn.TabIndex = 0
        '
        'lblAvdelingsnavn
        '
        Me.lblAvdelingsnavn.AutoSize = True
        Me.lblAvdelingsnavn.Location = New System.Drawing.Point(25, 35)
        Me.lblAvdelingsnavn.Name = "lblAvdelingsnavn"
        Me.lblAvdelingsnavn.Size = New System.Drawing.Size(80, 13)
        Me.lblAvdelingsnavn.TabIndex = 2
        Me.lblAvdelingsnavn.Text = "Avdelingsnavn:"
        '
        'txtAdresse
        '
        Me.txtAdresse.Location = New System.Drawing.Point(107, 110)
        Me.txtAdresse.Name = "txtAdresse"
        Me.txtAdresse.Size = New System.Drawing.Size(200, 20)
        Me.txtAdresse.TabIndex = 3
        '
        'lblAdresse
        '
        Me.lblAdresse.AutoSize = True
        Me.lblAdresse.Location = New System.Drawing.Point(57, 113)
        Me.lblAdresse.Name = "lblAdresse"
        Me.lblAdresse.Size = New System.Drawing.Size(48, 13)
        Me.lblAdresse.TabIndex = 4
        Me.lblAdresse.Text = "Adresse:"
        '
        'lblPostnummer
        '
        Me.lblPostnummer.AutoSize = True
        Me.lblPostnummer.Location = New System.Drawing.Point(37, 139)
        Me.lblPostnummer.Name = "lblPostnummer"
        Me.lblPostnummer.Size = New System.Drawing.Size(68, 13)
        Me.lblPostnummer.TabIndex = 5
        Me.lblPostnummer.Text = "Postnummer:"
        '
        'txtPostnummer
        '
        Me.txtPostnummer.Location = New System.Drawing.Point(107, 136)
        Me.txtPostnummer.MaxLength = 4
        Me.txtPostnummer.Name = "txtPostnummer"
        Me.txtPostnummer.Size = New System.Drawing.Size(200, 20)
        Me.txtPostnummer.TabIndex = 6
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(107, 162)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(200, 20)
        Me.TextBox3.TabIndex = 7
        '
        'lblSted
        '
        Me.lblSted.AutoSize = True
        Me.lblSted.Location = New System.Drawing.Point(73, 165)
        Me.lblSted.Name = "lblSted"
        Me.lblSted.Size = New System.Drawing.Size(32, 13)
        Me.lblSted.TabIndex = 5
        Me.lblSted.Text = "Sted:"
        '
        'txtEpost
        '
        Me.txtEpost.Location = New System.Drawing.Point(107, 58)
        Me.txtEpost.Name = "txtEpost"
        Me.txtEpost.Size = New System.Drawing.Size(200, 20)
        Me.txtEpost.TabIndex = 8
        '
        'lblEpost
        '
        Me.lblEpost.AutoSize = True
        Me.lblEpost.Location = New System.Drawing.Point(68, 61)
        Me.lblEpost.Name = "lblEpost"
        Me.lblEpost.Size = New System.Drawing.Size(37, 13)
        Me.lblEpost.TabIndex = 9
        Me.lblEpost.Text = "Epost:"
        '
        'txtTelefon
        '
        Me.txtTelefon.Location = New System.Drawing.Point(107, 84)
        Me.txtTelefon.MaxLength = 8
        Me.txtTelefon.Name = "txtTelefon"
        Me.txtTelefon.Size = New System.Drawing.Size(200, 20)
        Me.txtTelefon.TabIndex = 10
        '
        'lblTelefon
        '
        Me.lblTelefon.AutoSize = True
        Me.lblTelefon.Location = New System.Drawing.Point(59, 87)
        Me.lblTelefon.Name = "lblTelefon"
        Me.lblTelefon.Size = New System.Drawing.Size(46, 13)
        Me.lblTelefon.TabIndex = 11
        Me.lblTelefon.Text = "Telefon:"
        '
        'txtPassord
        '
        Me.txtPassord.Location = New System.Drawing.Point(107, 188)
        Me.txtPassord.MaxLength = 16
        Me.txtPassord.Name = "txtPassord"
        Me.txtPassord.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassord.Size = New System.Drawing.Size(200, 20)
        Me.txtPassord.TabIndex = 12
        '
        'txtBekreftPassord
        '
        Me.txtBekreftPassord.Location = New System.Drawing.Point(107, 214)
        Me.txtBekreftPassord.MaxLength = 16
        Me.txtBekreftPassord.Name = "txtBekreftPassord"
        Me.txtBekreftPassord.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtBekreftPassord.Size = New System.Drawing.Size(200, 20)
        Me.txtBekreftPassord.TabIndex = 13
        '
        'lblPassord
        '
        Me.lblPassord.AutoSize = True
        Me.lblPassord.Location = New System.Drawing.Point(57, 191)
        Me.lblPassord.Name = "lblPassord"
        Me.lblPassord.Size = New System.Drawing.Size(48, 13)
        Me.lblPassord.TabIndex = 14
        Me.lblPassord.Text = "Passord:"
        '
        'lblBekreftPassord
        '
        Me.lblBekreftPassord.AutoSize = True
        Me.lblBekreftPassord.Location = New System.Drawing.Point(21, 217)
        Me.lblBekreftPassord.Name = "lblBekreftPassord"
        Me.lblBekreftPassord.Size = New System.Drawing.Size(84, 13)
        Me.lblBekreftPassord.TabIndex = 15
        Me.lblBekreftPassord.Text = "Bekreft passord:"
        '
        'txtAvdelingNr
        '
        Me.txtAvdelingNr.Location = New System.Drawing.Point(107, 6)
        Me.txtAvdelingNr.Name = "txtAvdelingNr"
        Me.txtAvdelingNr.ReadOnly = True
        Me.txtAvdelingNr.Size = New System.Drawing.Size(200, 20)
        Me.txtAvdelingNr.TabIndex = 16
        '
        'lblAvdelingNr
        '
        Me.lblAvdelingNr.AutoSize = True
        Me.lblAvdelingNr.Location = New System.Drawing.Point(12, 9)
        Me.lblAvdelingNr.Name = "lblAvdelingNr"
        Me.lblAvdelingNr.Size = New System.Drawing.Size(93, 13)
        Me.lblAvdelingNr.TabIndex = 18
        Me.lblAvdelingNr.Text = "Avdelingsnummer:"
        '
        'btnOpprett
        '
        Me.btnOpprett.Location = New System.Drawing.Point(15, 308)
        Me.btnOpprett.Name = "btnOpprett"
        Me.btnOpprett.Size = New System.Drawing.Size(292, 23)
        Me.btnOpprett.TabIndex = 21
        Me.btnOpprett.Text = "Opprett ny avdeling"
        Me.btnOpprett.UseVisualStyleBackColor = True
        '
        'btnOppdater
        '
        Me.btnOppdater.Location = New System.Drawing.Point(15, 279)
        Me.btnOppdater.Name = "btnOppdater"
        Me.btnOppdater.Size = New System.Drawing.Size(292, 23)
        Me.btnOppdater.TabIndex = 22
        Me.btnOppdater.Text = "Oppdater"
        Me.btnOppdater.UseVisualStyleBackColor = True
        '
        'btnSlett
        '
        Me.btnSlett.Location = New System.Drawing.Point(15, 337)
        Me.btnSlett.Name = "btnSlett"
        Me.btnSlett.Size = New System.Drawing.Size(292, 23)
        Me.btnSlett.TabIndex = 23
        Me.btnSlett.Text = "Slett tekstfelt"
        Me.btnSlett.UseVisualStyleBackColor = True
        '
        'cmbAvdeling
        '
        Me.cmbAvdeling.FormattingEnabled = True
        Me.cmbAvdeling.Location = New System.Drawing.Point(15, 252)
        Me.cmbAvdeling.Name = "cmbAvdeling"
        Me.cmbAvdeling.Size = New System.Drawing.Size(292, 21)
        Me.cmbAvdeling.TabIndex = 24
        '
        'btnTilbake
        '
        Me.btnTilbake.Location = New System.Drawing.Point(13, 415)
        Me.btnTilbake.Name = "btnTilbake"
        Me.btnTilbake.Size = New System.Drawing.Size(294, 23)
        Me.btnTilbake.TabIndex = 25
        Me.btnTilbake.Text = "Gå tilbake til innloggingsvindu"
        Me.btnTilbake.UseVisualStyleBackColor = True
        '
        'Administrator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnTilbake)
        Me.Controls.Add(Me.cmbAvdeling)
        Me.Controls.Add(Me.btnSlett)
        Me.Controls.Add(Me.btnOppdater)
        Me.Controls.Add(Me.btnOpprett)
        Me.Controls.Add(Me.txtAvdelingNr)
        Me.Controls.Add(Me.lblAvdelingNr)
        Me.Controls.Add(Me.txtAvdelingsnavn)
        Me.Controls.Add(Me.txtEpost)
        Me.Controls.Add(Me.lblAvdelingsnavn)
        Me.Controls.Add(Me.lblEpost)
        Me.Controls.Add(Me.lblBekreftPassord)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.txtAdresse)
        Me.Controls.Add(Me.txtTelefon)
        Me.Controls.Add(Me.lblPassord)
        Me.Controls.Add(Me.txtPostnummer)
        Me.Controls.Add(Me.lblAdresse)
        Me.Controls.Add(Me.lblTelefon)
        Me.Controls.Add(Me.txtBekreftPassord)
        Me.Controls.Add(Me.lblSted)
        Me.Controls.Add(Me.lblPostnummer)
        Me.Controls.Add(Me.txtPassord)
        Me.Name = "Administrator"
        Me.Text = "Administrator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtAvdelingsnavn As TextBox
    Friend WithEvents lblAvdelingsnavn As Label
    Friend WithEvents txtAdresse As TextBox
    Friend WithEvents lblAdresse As Label
    Friend WithEvents lblPostnummer As Label
    Friend WithEvents txtPostnummer As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents lblSted As Label
    Friend WithEvents txtEpost As TextBox
    Friend WithEvents lblEpost As Label
    Friend WithEvents txtTelefon As TextBox
    Friend WithEvents lblTelefon As Label
    Friend WithEvents txtPassord As TextBox
    Friend WithEvents txtBekreftPassord As TextBox
    Friend WithEvents lblPassord As Label
    Friend WithEvents lblBekreftPassord As Label
    Friend WithEvents txtAvdelingNr As TextBox
    Friend WithEvents lblAvdelingNr As Label
    Friend WithEvents btnOpprett As Button
    Friend WithEvents btnOppdater As Button
    Friend WithEvents btnSlett As Button
    Friend WithEvents cmbAvdeling As ComboBox
    Friend WithEvents btnTilbake As Button
End Class

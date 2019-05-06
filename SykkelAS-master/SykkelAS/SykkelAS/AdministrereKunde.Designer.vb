<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdministrereKunde
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
        Me.txtKundenummer = New System.Windows.Forms.TextBox()
        Me.lblKundenummer = New System.Windows.Forms.Label()
        Me.txtEtternavn = New System.Windows.Forms.TextBox()
        Me.txtFornavn = New System.Windows.Forms.TextBox()
        Me.lblFornavn = New System.Windows.Forms.Label()
        Me.lblEtternavn = New System.Windows.Forms.Label()
        Me.txtAdresse = New System.Windows.Forms.TextBox()
        Me.lblAdresse = New System.Windows.Forms.Label()
        Me.txtPostnummer = New System.Windows.Forms.TextBox()
        Me.lblPostnummer = New System.Windows.Forms.Label()
        Me.txtTelefon = New System.Windows.Forms.TextBox()
        Me.txtEpost = New System.Windows.Forms.TextBox()
        Me.lblTelefon = New System.Windows.Forms.Label()
        Me.lblEpost = New System.Windows.Forms.Label()
        Me.txtSted = New System.Windows.Forms.TextBox()
        Me.lblSted = New System.Windows.Forms.Label()
        Me.btnOppdater = New System.Windows.Forms.Button()
        Me.btnOpprett = New System.Windows.Forms.Button()
        Me.btnForrige = New System.Windows.Forms.Button()
        Me.btnNeste = New System.Windows.Forms.Button()
        Me.btnFørste = New System.Windows.Forms.Button()
        Me.btnSiste = New System.Windows.Forms.Button()
        Me.btnSlettKunde = New System.Windows.Forms.Button()
        Me.btnTømSkjema = New System.Windows.Forms.Button()
        Me.txtSok = New System.Windows.Forms.TextBox()
        Me.btnSøk = New System.Windows.Forms.Button()
        Me.lstResultat = New System.Windows.Forms.ListBox()
        Me.lblInnloggetAvdeling = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnTilbake
        '
        Me.btnTilbake.Location = New System.Drawing.Point(505, 576)
        Me.btnTilbake.Name = "btnTilbake"
        Me.btnTilbake.Size = New System.Drawing.Size(167, 23)
        Me.btnTilbake.TabIndex = 28
        Me.btnTilbake.Text = "Hovedmeny"
        Me.btnTilbake.UseVisualStyleBackColor = True
        '
        'txtKundenummer
        '
        Me.txtKundenummer.Location = New System.Drawing.Point(134, 26)
        Me.txtKundenummer.Name = "txtKundenummer"
        Me.txtKundenummer.ReadOnly = True
        Me.txtKundenummer.Size = New System.Drawing.Size(200, 20)
        Me.txtKundenummer.TabIndex = 0
        '
        'lblKundenummer
        '
        Me.lblKundenummer.AutoSize = True
        Me.lblKundenummer.Location = New System.Drawing.Point(53, 29)
        Me.lblKundenummer.Name = "lblKundenummer"
        Me.lblKundenummer.Size = New System.Drawing.Size(75, 13)
        Me.lblKundenummer.TabIndex = 19
        Me.lblKundenummer.Text = "Kundenummer"
        '
        'txtEtternavn
        '
        Me.txtEtternavn.Location = New System.Drawing.Point(134, 79)
        Me.txtEtternavn.Name = "txtEtternavn"
        Me.txtEtternavn.Size = New System.Drawing.Size(200, 20)
        Me.txtEtternavn.TabIndex = 2
        '
        'txtFornavn
        '
        Me.txtFornavn.Location = New System.Drawing.Point(134, 53)
        Me.txtFornavn.Name = "txtFornavn"
        Me.txtFornavn.Size = New System.Drawing.Size(200, 20)
        Me.txtFornavn.TabIndex = 1
        '
        'lblFornavn
        '
        Me.lblFornavn.AutoSize = True
        Me.lblFornavn.Location = New System.Drawing.Point(82, 56)
        Me.lblFornavn.Name = "lblFornavn"
        Me.lblFornavn.Size = New System.Drawing.Size(46, 13)
        Me.lblFornavn.TabIndex = 20
        Me.lblFornavn.Text = "Fornavn"
        '
        'lblEtternavn
        '
        Me.lblEtternavn.AutoSize = True
        Me.lblEtternavn.Location = New System.Drawing.Point(75, 82)
        Me.lblEtternavn.Name = "lblEtternavn"
        Me.lblEtternavn.Size = New System.Drawing.Size(53, 13)
        Me.lblEtternavn.TabIndex = 21
        Me.lblEtternavn.Text = "Etternavn"
        '
        'txtAdresse
        '
        Me.txtAdresse.Location = New System.Drawing.Point(134, 158)
        Me.txtAdresse.Name = "txtAdresse"
        Me.txtAdresse.Size = New System.Drawing.Size(200, 20)
        Me.txtAdresse.TabIndex = 5
        '
        'lblAdresse
        '
        Me.lblAdresse.AutoSize = True
        Me.lblAdresse.Location = New System.Drawing.Point(83, 161)
        Me.lblAdresse.Name = "lblAdresse"
        Me.lblAdresse.Size = New System.Drawing.Size(45, 13)
        Me.lblAdresse.TabIndex = 24
        Me.lblAdresse.Text = "Adresse"
        '
        'txtPostnummer
        '
        Me.txtPostnummer.Location = New System.Drawing.Point(134, 184)
        Me.txtPostnummer.MaxLength = 4
        Me.txtPostnummer.Name = "txtPostnummer"
        Me.txtPostnummer.Size = New System.Drawing.Size(200, 20)
        Me.txtPostnummer.TabIndex = 6
        '
        'lblPostnummer
        '
        Me.lblPostnummer.AutoSize = True
        Me.lblPostnummer.Location = New System.Drawing.Point(63, 187)
        Me.lblPostnummer.Name = "lblPostnummer"
        Me.lblPostnummer.Size = New System.Drawing.Size(65, 13)
        Me.lblPostnummer.TabIndex = 25
        Me.lblPostnummer.Text = "Postnummer"
        '
        'txtTelefon
        '
        Me.txtTelefon.Location = New System.Drawing.Point(134, 106)
        Me.txtTelefon.MaxLength = 8
        Me.txtTelefon.Name = "txtTelefon"
        Me.txtTelefon.Size = New System.Drawing.Size(200, 20)
        Me.txtTelefon.TabIndex = 3
        '
        'txtEpost
        '
        Me.txtEpost.Location = New System.Drawing.Point(134, 132)
        Me.txtEpost.Name = "txtEpost"
        Me.txtEpost.Size = New System.Drawing.Size(200, 20)
        Me.txtEpost.TabIndex = 4
        '
        'lblTelefon
        '
        Me.lblTelefon.AutoSize = True
        Me.lblTelefon.Location = New System.Drawing.Point(85, 109)
        Me.lblTelefon.Name = "lblTelefon"
        Me.lblTelefon.Size = New System.Drawing.Size(43, 13)
        Me.lblTelefon.TabIndex = 22
        Me.lblTelefon.Text = "Telefon"
        '
        'lblEpost
        '
        Me.lblEpost.AutoSize = True
        Me.lblEpost.Location = New System.Drawing.Point(94, 135)
        Me.lblEpost.Name = "lblEpost"
        Me.lblEpost.Size = New System.Drawing.Size(34, 13)
        Me.lblEpost.TabIndex = 23
        Me.lblEpost.Text = "Epost"
        '
        'txtSted
        '
        Me.txtSted.Location = New System.Drawing.Point(134, 211)
        Me.txtSted.Name = "txtSted"
        Me.txtSted.ReadOnly = True
        Me.txtSted.Size = New System.Drawing.Size(200, 20)
        Me.txtSted.TabIndex = 7
        '
        'lblSted
        '
        Me.lblSted.AutoSize = True
        Me.lblSted.Location = New System.Drawing.Point(99, 211)
        Me.lblSted.Name = "lblSted"
        Me.lblSted.Size = New System.Drawing.Size(29, 13)
        Me.lblSted.TabIndex = 26
        Me.lblSted.Text = "Sted"
        '
        'btnOppdater
        '
        Me.btnOppdater.Location = New System.Drawing.Point(134, 237)
        Me.btnOppdater.Name = "btnOppdater"
        Me.btnOppdater.Size = New System.Drawing.Size(200, 23)
        Me.btnOppdater.TabIndex = 12
        Me.btnOppdater.Text = "Oppdater kunde"
        Me.btnOppdater.UseVisualStyleBackColor = True
        '
        'btnOpprett
        '
        Me.btnOpprett.Location = New System.Drawing.Point(134, 266)
        Me.btnOpprett.Name = "btnOpprett"
        Me.btnOpprett.Size = New System.Drawing.Size(200, 23)
        Me.btnOpprett.TabIndex = 13
        Me.btnOpprett.Text = "Opprett ny kunde"
        Me.btnOpprett.UseVisualStyleBackColor = True
        '
        'btnForrige
        '
        Me.btnForrige.Location = New System.Drawing.Point(56, 237)
        Me.btnForrige.Name = "btnForrige"
        Me.btnForrige.Size = New System.Drawing.Size(75, 23)
        Me.btnForrige.TabIndex = 8
        Me.btnForrige.Text = "Forrige"
        Me.btnForrige.UseVisualStyleBackColor = True
        '
        'btnNeste
        '
        Me.btnNeste.Location = New System.Drawing.Point(340, 237)
        Me.btnNeste.Name = "btnNeste"
        Me.btnNeste.Size = New System.Drawing.Size(75, 23)
        Me.btnNeste.TabIndex = 9
        Me.btnNeste.Text = "Neste"
        Me.btnNeste.UseVisualStyleBackColor = True
        '
        'btnFørste
        '
        Me.btnFørste.Location = New System.Drawing.Point(56, 266)
        Me.btnFørste.Name = "btnFørste"
        Me.btnFørste.Size = New System.Drawing.Size(75, 23)
        Me.btnFørste.TabIndex = 10
        Me.btnFørste.Text = "Første"
        Me.btnFørste.UseVisualStyleBackColor = True
        '
        'btnSiste
        '
        Me.btnSiste.Location = New System.Drawing.Point(340, 266)
        Me.btnSiste.Name = "btnSiste"
        Me.btnSiste.Size = New System.Drawing.Size(75, 23)
        Me.btnSiste.TabIndex = 11
        Me.btnSiste.Text = "Siste"
        Me.btnSiste.UseVisualStyleBackColor = True
        '
        'btnSlettKunde
        '
        Me.btnSlettKunde.Location = New System.Drawing.Point(134, 295)
        Me.btnSlettKunde.Name = "btnSlettKunde"
        Me.btnSlettKunde.Size = New System.Drawing.Size(200, 23)
        Me.btnSlettKunde.TabIndex = 14
        Me.btnSlettKunde.Text = "Slett kunde"
        Me.btnSlettKunde.UseVisualStyleBackColor = True
        '
        'btnTømSkjema
        '
        Me.btnTømSkjema.Location = New System.Drawing.Point(134, 324)
        Me.btnTømSkjema.Name = "btnTømSkjema"
        Me.btnTømSkjema.Size = New System.Drawing.Size(200, 23)
        Me.btnTømSkjema.TabIndex = 15
        Me.btnTømSkjema.Text = "Tøm skjema"
        Me.btnTømSkjema.UseVisualStyleBackColor = True
        '
        'txtSok
        '
        Me.txtSok.Location = New System.Drawing.Point(480, 26)
        Me.txtSok.Name = "txtSok"
        Me.txtSok.Size = New System.Drawing.Size(192, 20)
        Me.txtSok.TabIndex = 16
        '
        'btnSøk
        '
        Me.btnSøk.Location = New System.Drawing.Point(480, 52)
        Me.btnSøk.Name = "btnSøk"
        Me.btnSøk.Size = New System.Drawing.Size(192, 23)
        Me.btnSøk.TabIndex = 17
        Me.btnSøk.Text = "Søk"
        Me.btnSøk.UseVisualStyleBackColor = True
        '
        'lstResultat
        '
        Me.lstResultat.FormattingEnabled = True
        Me.lstResultat.Location = New System.Drawing.Point(480, 81)
        Me.lstResultat.Name = "lstResultat"
        Me.lstResultat.Size = New System.Drawing.Size(192, 134)
        Me.lstResultat.TabIndex = 18
        '
        'lblInnloggetAvdeling
        '
        Me.lblInnloggetAvdeling.AutoSize = True
        Me.lblInnloggetAvdeling.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblInnloggetAvdeling.Location = New System.Drawing.Point(12, 585)
        Me.lblInnloggetAvdeling.Name = "lblInnloggetAvdeling"
        Me.lblInnloggetAvdeling.Size = New System.Drawing.Size(143, 17)
        Me.lblInnloggetAvdeling.TabIndex = 27
        Me.lblInnloggetAvdeling.Text = "Innlogget på avdeling"
        '
        'AdministrereKunde
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 611)
        Me.Controls.Add(Me.lblInnloggetAvdeling)
        Me.Controls.Add(Me.lstResultat)
        Me.Controls.Add(Me.btnSøk)
        Me.Controls.Add(Me.txtSok)
        Me.Controls.Add(Me.btnTømSkjema)
        Me.Controls.Add(Me.btnSlettKunde)
        Me.Controls.Add(Me.btnSiste)
        Me.Controls.Add(Me.btnFørste)
        Me.Controls.Add(Me.btnNeste)
        Me.Controls.Add(Me.btnForrige)
        Me.Controls.Add(Me.btnOpprett)
        Me.Controls.Add(Me.btnOppdater)
        Me.Controls.Add(Me.lblSted)
        Me.Controls.Add(Me.txtSted)
        Me.Controls.Add(Me.lblEpost)
        Me.Controls.Add(Me.lblTelefon)
        Me.Controls.Add(Me.txtEpost)
        Me.Controls.Add(Me.txtTelefon)
        Me.Controls.Add(Me.lblPostnummer)
        Me.Controls.Add(Me.txtPostnummer)
        Me.Controls.Add(Me.lblAdresse)
        Me.Controls.Add(Me.lblEtternavn)
        Me.Controls.Add(Me.lblFornavn)
        Me.Controls.Add(Me.txtFornavn)
        Me.Controls.Add(Me.txtAdresse)
        Me.Controls.Add(Me.txtEtternavn)
        Me.Controls.Add(Me.lblKundenummer)
        Me.Controls.Add(Me.txtKundenummer)
        Me.Controls.Add(Me.btnTilbake)
        Me.Name = "AdministrereKunde"
        Me.Text = "AS SykkelUtleie"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnTilbake As Button
    Friend WithEvents txtKundenummer As TextBox
    Friend WithEvents lblKundenummer As Label
    Friend WithEvents txtEtternavn As TextBox
    Friend WithEvents txtFornavn As TextBox
    Friend WithEvents lblFornavn As Label
    Friend WithEvents lblEtternavn As Label
    Friend WithEvents txtAdresse As TextBox
    Friend WithEvents lblAdresse As Label
    Friend WithEvents txtPostnummer As TextBox
    Friend WithEvents lblPostnummer As Label
    Friend WithEvents txtTelefon As TextBox
    Friend WithEvents txtEpost As TextBox
    Friend WithEvents lblTelefon As Label
    Friend WithEvents lblEpost As Label
    Friend WithEvents txtSted As TextBox
    Friend WithEvents lblSted As Label
    Friend WithEvents btnOppdater As Button
    Friend WithEvents btnOpprett As Button
    Friend WithEvents btnForrige As Button
    Friend WithEvents btnNeste As Button
    Friend WithEvents btnFørste As Button
    Friend WithEvents btnSiste As Button
    Friend WithEvents btnSlettKunde As Button
    Friend WithEvents btnTømSkjema As Button
    Friend WithEvents txtSok As TextBox
    Friend WithEvents btnSøk As Button
    Friend WithEvents lstResultat As ListBox
    Friend WithEvents lblInnloggetAvdeling As Label
End Class

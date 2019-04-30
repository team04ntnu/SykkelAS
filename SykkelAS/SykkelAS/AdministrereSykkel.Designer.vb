<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdministrereSykkel
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
        Me.btnOppdater = New System.Windows.Forms.Button()
        Me.btnOpprett = New System.Windows.Forms.Button()
        Me.btnSlettTekstfelt = New System.Windows.Forms.Button()
        Me.btnTilbake = New System.Windows.Forms.Button()
        Me.txtSykkelID = New System.Windows.Forms.TextBox()
        Me.txtSykkelMerke = New System.Windows.Forms.TextBox()
        Me.txtSykkelHjul = New System.Windows.Forms.TextBox()
        Me.txtSykkelGir = New System.Windows.Forms.TextBox()
        Me.txtSykkelVekt = New System.Windows.Forms.TextBox()
        Me.txtSykkelRammeNummer = New System.Windows.Forms.TextBox()
        Me.txtPrisTime = New System.Windows.Forms.TextBox()
        Me.txtPrisDøgn = New System.Windows.Forms.TextBox()
        Me.lblSykkelID = New System.Windows.Forms.Label()
        Me.lblSykkelMerke = New System.Windows.Forms.Label()
        Me.lblSykkelType = New System.Windows.Forms.Label()
        Me.lblHjul = New System.Windows.Forms.Label()
        Me.lblGir = New System.Windows.Forms.Label()
        Me.lblVekt = New System.Windows.Forms.Label()
        Me.lblRammenummer = New System.Windows.Forms.Label()
        Me.lblPrisTime = New System.Windows.Forms.Label()
        Me.lblPrisDøgn = New System.Windows.Forms.Label()
        Me.txtPrisHelg = New System.Windows.Forms.TextBox()
        Me.lblPrisHelg = New System.Windows.Forms.Label()
        Me.lblLokasjon = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.btnSiste = New System.Windows.Forms.Button()
        Me.btnNeste = New System.Windows.Forms.Button()
        Me.btnFørste = New System.Windows.Forms.Button()
        Me.btnForrige = New System.Windows.Forms.Button()
        Me.txtSykkelRamme = New System.Windows.Forms.TextBox()
        Me.lblRamme = New System.Windows.Forms.Label()
        Me.txtAvdeling = New System.Windows.Forms.TextBox()
        Me.lblAvdeling = New System.Windows.Forms.Label()
        Me.btnSøk = New System.Windows.Forms.Button()
        Me.txtSok = New System.Windows.Forms.TextBox()
        Me.lstResultat = New System.Windows.Forms.ListBox()
        Me.btnSlettSykkel = New System.Windows.Forms.Button()
        Me.lblInnloggetAvdeling = New System.Windows.Forms.Label()
        Me.cmbSykkelType = New System.Windows.Forms.ComboBox()
        Me.cmbLokasjon = New System.Windows.Forms.ComboBox()
        Me.cmbStatus = New System.Windows.Forms.ComboBox()
        Me.btnSendMail = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnOppdater
        '
        Me.btnOppdater.Location = New System.Drawing.Point(134, 422)
        Me.btnOppdater.Name = "btnOppdater"
        Me.btnOppdater.Size = New System.Drawing.Size(200, 23)
        Me.btnOppdater.TabIndex = 19
        Me.btnOppdater.Text = "Oppdater sykkel"
        Me.btnOppdater.UseVisualStyleBackColor = True
        '
        'btnOpprett
        '
        Me.btnOpprett.Location = New System.Drawing.Point(134, 451)
        Me.btnOpprett.Name = "btnOpprett"
        Me.btnOpprett.Size = New System.Drawing.Size(200, 23)
        Me.btnOpprett.TabIndex = 20
        Me.btnOpprett.Text = "Opprett ny sykkel"
        Me.btnOpprett.UseVisualStyleBackColor = True
        '
        'btnSlettTekstfelt
        '
        Me.btnSlettTekstfelt.Location = New System.Drawing.Point(134, 509)
        Me.btnSlettTekstfelt.Name = "btnSlettTekstfelt"
        Me.btnSlettTekstfelt.Size = New System.Drawing.Size(200, 23)
        Me.btnSlettTekstfelt.TabIndex = 21
        Me.btnSlettTekstfelt.Text = "Slett tekstfelt"
        Me.btnSlettTekstfelt.UseVisualStyleBackColor = True
        '
        'btnTilbake
        '
        Me.btnTilbake.Location = New System.Drawing.Point(505, 576)
        Me.btnTilbake.Name = "btnTilbake"
        Me.btnTilbake.Size = New System.Drawing.Size(167, 23)
        Me.btnTilbake.TabIndex = 39
        Me.btnTilbake.Text = "Hovedmeny"
        Me.btnTilbake.UseVisualStyleBackColor = True
        '
        'txtSykkelID
        '
        Me.txtSykkelID.Location = New System.Drawing.Point(134, 26)
        Me.txtSykkelID.Name = "txtSykkelID"
        Me.txtSykkelID.ReadOnly = True
        Me.txtSykkelID.Size = New System.Drawing.Size(200, 20)
        Me.txtSykkelID.TabIndex = 0
        '
        'txtSykkelMerke
        '
        Me.txtSykkelMerke.Location = New System.Drawing.Point(134, 52)
        Me.txtSykkelMerke.Name = "txtSykkelMerke"
        Me.txtSykkelMerke.Size = New System.Drawing.Size(200, 20)
        Me.txtSykkelMerke.TabIndex = 1
        '
        'txtSykkelHjul
        '
        Me.txtSykkelHjul.Location = New System.Drawing.Point(134, 130)
        Me.txtSykkelHjul.Name = "txtSykkelHjul"
        Me.txtSykkelHjul.Size = New System.Drawing.Size(200, 20)
        Me.txtSykkelHjul.TabIndex = 4
        '
        'txtSykkelGir
        '
        Me.txtSykkelGir.Location = New System.Drawing.Point(134, 156)
        Me.txtSykkelGir.Name = "txtSykkelGir"
        Me.txtSykkelGir.Size = New System.Drawing.Size(200, 20)
        Me.txtSykkelGir.TabIndex = 5
        '
        'txtSykkelVekt
        '
        Me.txtSykkelVekt.Location = New System.Drawing.Point(134, 182)
        Me.txtSykkelVekt.Name = "txtSykkelVekt"
        Me.txtSykkelVekt.Size = New System.Drawing.Size(200, 20)
        Me.txtSykkelVekt.TabIndex = 6
        '
        'txtSykkelRammeNummer
        '
        Me.txtSykkelRammeNummer.Location = New System.Drawing.Point(134, 208)
        Me.txtSykkelRammeNummer.MaxLength = 10
        Me.txtSykkelRammeNummer.Name = "txtSykkelRammeNummer"
        Me.txtSykkelRammeNummer.Size = New System.Drawing.Size(200, 20)
        Me.txtSykkelRammeNummer.TabIndex = 7
        '
        'txtPrisTime
        '
        Me.txtPrisTime.Location = New System.Drawing.Point(134, 234)
        Me.txtPrisTime.Name = "txtPrisTime"
        Me.txtPrisTime.Size = New System.Drawing.Size(200, 20)
        Me.txtPrisTime.TabIndex = 8
        '
        'txtPrisDøgn
        '
        Me.txtPrisDøgn.Location = New System.Drawing.Point(134, 260)
        Me.txtPrisDøgn.Name = "txtPrisDøgn"
        Me.txtPrisDøgn.Size = New System.Drawing.Size(200, 20)
        Me.txtPrisDøgn.TabIndex = 9
        '
        'lblSykkelID
        '
        Me.lblSykkelID.AutoSize = True
        Me.lblSykkelID.Location = New System.Drawing.Point(110, 29)
        Me.lblSykkelID.Name = "lblSykkelID"
        Me.lblSykkelID.Size = New System.Drawing.Size(18, 13)
        Me.lblSykkelID.TabIndex = 25
        Me.lblSykkelID.Text = "ID"
        '
        'lblSykkelMerke
        '
        Me.lblSykkelMerke.AutoSize = True
        Me.lblSykkelMerke.Location = New System.Drawing.Point(91, 55)
        Me.lblSykkelMerke.Name = "lblSykkelMerke"
        Me.lblSykkelMerke.Size = New System.Drawing.Size(37, 13)
        Me.lblSykkelMerke.TabIndex = 26
        Me.lblSykkelMerke.Text = "Merke"
        '
        'lblSykkelType
        '
        Me.lblSykkelType.AutoSize = True
        Me.lblSykkelType.Location = New System.Drawing.Point(97, 81)
        Me.lblSykkelType.Name = "lblSykkelType"
        Me.lblSykkelType.Size = New System.Drawing.Size(31, 13)
        Me.lblSykkelType.TabIndex = 27
        Me.lblSykkelType.Text = "Type"
        '
        'lblHjul
        '
        Me.lblHjul.AutoSize = True
        Me.lblHjul.Location = New System.Drawing.Point(103, 133)
        Me.lblHjul.Name = "lblHjul"
        Me.lblHjul.Size = New System.Drawing.Size(25, 13)
        Me.lblHjul.TabIndex = 29
        Me.lblHjul.Text = "Hjul"
        '
        'lblGir
        '
        Me.lblGir.AutoSize = True
        Me.lblGir.Location = New System.Drawing.Point(108, 159)
        Me.lblGir.Name = "lblGir"
        Me.lblGir.Size = New System.Drawing.Size(20, 13)
        Me.lblGir.TabIndex = 30
        Me.lblGir.Text = "Gir"
        '
        'lblVekt
        '
        Me.lblVekt.AutoSize = True
        Me.lblVekt.Location = New System.Drawing.Point(99, 185)
        Me.lblVekt.Name = "lblVekt"
        Me.lblVekt.Size = New System.Drawing.Size(29, 13)
        Me.lblVekt.TabIndex = 31
        Me.lblVekt.Text = "Vekt"
        '
        'lblRammenummer
        '
        Me.lblRammenummer.AutoSize = True
        Me.lblRammenummer.Location = New System.Drawing.Point(48, 211)
        Me.lblRammenummer.Name = "lblRammenummer"
        Me.lblRammenummer.Size = New System.Drawing.Size(80, 13)
        Me.lblRammenummer.TabIndex = 32
        Me.lblRammenummer.Text = "Rammenummer"
        '
        'lblPrisTime
        '
        Me.lblPrisTime.AutoSize = True
        Me.lblPrisTime.Location = New System.Drawing.Point(82, 237)
        Me.lblPrisTime.Name = "lblPrisTime"
        Me.lblPrisTime.Size = New System.Drawing.Size(46, 13)
        Me.lblPrisTime.TabIndex = 33
        Me.lblPrisTime.Text = "Pris time"
        '
        'lblPrisDøgn
        '
        Me.lblPrisDøgn.AutoSize = True
        Me.lblPrisDøgn.Location = New System.Drawing.Point(77, 263)
        Me.lblPrisDøgn.Name = "lblPrisDøgn"
        Me.lblPrisDøgn.Size = New System.Drawing.Size(51, 13)
        Me.lblPrisDøgn.TabIndex = 34
        Me.lblPrisDøgn.Text = "Pris døgn"
        '
        'txtPrisHelg
        '
        Me.txtPrisHelg.Location = New System.Drawing.Point(134, 286)
        Me.txtPrisHelg.Name = "txtPrisHelg"
        Me.txtPrisHelg.Size = New System.Drawing.Size(200, 20)
        Me.txtPrisHelg.TabIndex = 10
        '
        'lblPrisHelg
        '
        Me.lblPrisHelg.AutoSize = True
        Me.lblPrisHelg.Location = New System.Drawing.Point(81, 289)
        Me.lblPrisHelg.Name = "lblPrisHelg"
        Me.lblPrisHelg.Size = New System.Drawing.Size(47, 13)
        Me.lblPrisHelg.TabIndex = 35
        Me.lblPrisHelg.Text = "Pris helg"
        '
        'lblLokasjon
        '
        Me.lblLokasjon.AutoSize = True
        Me.lblLokasjon.Location = New System.Drawing.Point(78, 315)
        Me.lblLokasjon.Name = "lblLokasjon"
        Me.lblLokasjon.Size = New System.Drawing.Size(50, 13)
        Me.lblLokasjon.TabIndex = 36
        Me.lblLokasjon.Text = "Lokasjon"
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(91, 341)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(37, 13)
        Me.lblStatus.TabIndex = 37
        Me.lblStatus.Text = "Status"
        '
        'btnSiste
        '
        Me.btnSiste.Location = New System.Drawing.Point(340, 451)
        Me.btnSiste.Name = "btnSiste"
        Me.btnSiste.Size = New System.Drawing.Size(75, 23)
        Me.btnSiste.TabIndex = 18
        Me.btnSiste.Text = "Siste"
        Me.btnSiste.UseVisualStyleBackColor = True
        '
        'btnNeste
        '
        Me.btnNeste.Location = New System.Drawing.Point(340, 422)
        Me.btnNeste.Name = "btnNeste"
        Me.btnNeste.Size = New System.Drawing.Size(75, 23)
        Me.btnNeste.TabIndex = 16
        Me.btnNeste.Text = "Neste"
        Me.btnNeste.UseVisualStyleBackColor = True
        '
        'btnFørste
        '
        Me.btnFørste.Location = New System.Drawing.Point(53, 451)
        Me.btnFørste.Name = "btnFørste"
        Me.btnFørste.Size = New System.Drawing.Size(75, 23)
        Me.btnFørste.TabIndex = 17
        Me.btnFørste.Text = "Første"
        Me.btnFørste.UseVisualStyleBackColor = True
        '
        'btnForrige
        '
        Me.btnForrige.Location = New System.Drawing.Point(53, 422)
        Me.btnForrige.Name = "btnForrige"
        Me.btnForrige.Size = New System.Drawing.Size(75, 23)
        Me.btnForrige.TabIndex = 15
        Me.btnForrige.Text = "Forrige"
        Me.btnForrige.UseVisualStyleBackColor = True
        '
        'txtSykkelRamme
        '
        Me.txtSykkelRamme.Location = New System.Drawing.Point(134, 104)
        Me.txtSykkelRamme.Name = "txtSykkelRamme"
        Me.txtSykkelRamme.Size = New System.Drawing.Size(200, 20)
        Me.txtSykkelRamme.TabIndex = 3
        '
        'lblRamme
        '
        Me.lblRamme.AutoSize = True
        Me.lblRamme.Location = New System.Drawing.Point(85, 107)
        Me.lblRamme.Name = "lblRamme"
        Me.lblRamme.Size = New System.Drawing.Size(43, 13)
        Me.lblRamme.TabIndex = 28
        Me.lblRamme.Text = "Ramme"
        '
        'txtAvdeling
        '
        Me.txtAvdeling.Location = New System.Drawing.Point(134, 365)
        Me.txtAvdeling.Name = "txtAvdeling"
        Me.txtAvdeling.ReadOnly = True
        Me.txtAvdeling.Size = New System.Drawing.Size(200, 20)
        Me.txtAvdeling.TabIndex = 13
        '
        'lblAvdeling
        '
        Me.lblAvdeling.AutoSize = True
        Me.lblAvdeling.Location = New System.Drawing.Point(43, 368)
        Me.lblAvdeling.Name = "lblAvdeling"
        Me.lblAvdeling.Size = New System.Drawing.Size(85, 13)
        Me.lblAvdeling.TabIndex = 38
        Me.lblAvdeling.Text = "Tilhører avdeling"
        '
        'btnSøk
        '
        Me.btnSøk.Location = New System.Drawing.Point(410, 52)
        Me.btnSøk.Name = "btnSøk"
        Me.btnSøk.Size = New System.Drawing.Size(192, 23)
        Me.btnSøk.TabIndex = 23
        Me.btnSøk.Text = "Søk"
        Me.btnSøk.UseVisualStyleBackColor = True
        '
        'txtSok
        '
        Me.txtSok.Location = New System.Drawing.Point(410, 26)
        Me.txtSok.Name = "txtSok"
        Me.txtSok.Size = New System.Drawing.Size(192, 20)
        Me.txtSok.TabIndex = 22
        '
        'lstResultat
        '
        Me.lstResultat.FormattingEnabled = True
        Me.lstResultat.Location = New System.Drawing.Point(410, 82)
        Me.lstResultat.Name = "lstResultat"
        Me.lstResultat.Size = New System.Drawing.Size(192, 134)
        Me.lstResultat.TabIndex = 24
        '
        'btnSlettSykkel
        '
        Me.btnSlettSykkel.Location = New System.Drawing.Point(134, 480)
        Me.btnSlettSykkel.Name = "btnSlettSykkel"
        Me.btnSlettSykkel.Size = New System.Drawing.Size(200, 23)
        Me.btnSlettSykkel.TabIndex = 40
        Me.btnSlettSykkel.Text = "Slett sykkel"
        Me.btnSlettSykkel.UseVisualStyleBackColor = True
        '
        'lblInnloggetAvdeling
        '
        Me.lblInnloggetAvdeling.AutoSize = True
        Me.lblInnloggetAvdeling.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblInnloggetAvdeling.Location = New System.Drawing.Point(12, 585)
        Me.lblInnloggetAvdeling.Name = "lblInnloggetAvdeling"
        Me.lblInnloggetAvdeling.Size = New System.Drawing.Size(143, 17)
        Me.lblInnloggetAvdeling.TabIndex = 41
        Me.lblInnloggetAvdeling.Text = "Innlogget på avdeling"
        '
        'cmbSykkelType
        '
        Me.cmbSykkelType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSykkelType.FormattingEnabled = True
        Me.cmbSykkelType.Items.AddRange(New Object() {"Terreng", "Downhill", "Racer", "Tandem", "Barn"})
        Me.cmbSykkelType.Location = New System.Drawing.Point(134, 78)
        Me.cmbSykkelType.Name = "cmbSykkelType"
        Me.cmbSykkelType.Size = New System.Drawing.Size(200, 21)
        Me.cmbSykkelType.TabIndex = 42
        '
        'cmbLokasjon
        '
        Me.cmbLokasjon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLokasjon.FormattingEnabled = True
        Me.cmbLokasjon.Items.AddRange(New Object() {"Hos kunde"})
        Me.cmbLokasjon.Location = New System.Drawing.Point(134, 312)
        Me.cmbLokasjon.Name = "cmbLokasjon"
        Me.cmbLokasjon.Size = New System.Drawing.Size(200, 21)
        Me.cmbLokasjon.TabIndex = 43
        '
        'cmbStatus
        '
        Me.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbStatus.FormattingEnabled = True
        Me.cmbStatus.Items.AddRange(New Object() {"Ledig", "Utleid", "Stjålet", "Service"})
        Me.cmbStatus.Location = New System.Drawing.Point(134, 338)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Size = New System.Drawing.Size(200, 21)
        Me.cmbStatus.TabIndex = 44
        '
        'btnSendMail
        '
        Me.btnSendMail.Location = New System.Drawing.Point(134, 539)
        Me.btnSendMail.Name = "btnSendMail"
        Me.btnSendMail.Size = New System.Drawing.Size(200, 23)
        Me.btnSendMail.TabIndex = 45
        Me.btnSendMail.Text = "Send til reparasjon"
        Me.btnSendMail.UseVisualStyleBackColor = True
        '
        'AdministrereSykkel
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 611)
        Me.Controls.Add(Me.btnSendMail)
        Me.Controls.Add(Me.cmbStatus)
        Me.Controls.Add(Me.cmbLokasjon)
        Me.Controls.Add(Me.cmbSykkelType)
        Me.Controls.Add(Me.lblInnloggetAvdeling)
        Me.Controls.Add(Me.btnSlettSykkel)
        Me.Controls.Add(Me.lstResultat)
        Me.Controls.Add(Me.txtSok)
        Me.Controls.Add(Me.btnSøk)
        Me.Controls.Add(Me.lblAvdeling)
        Me.Controls.Add(Me.txtAvdeling)
        Me.Controls.Add(Me.lblRamme)
        Me.Controls.Add(Me.txtSykkelRamme)
        Me.Controls.Add(Me.btnFørste)
        Me.Controls.Add(Me.btnForrige)
        Me.Controls.Add(Me.btnSiste)
        Me.Controls.Add(Me.btnNeste)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.lblLokasjon)
        Me.Controls.Add(Me.lblPrisHelg)
        Me.Controls.Add(Me.txtPrisHelg)
        Me.Controls.Add(Me.lblPrisDøgn)
        Me.Controls.Add(Me.lblPrisTime)
        Me.Controls.Add(Me.lblRammenummer)
        Me.Controls.Add(Me.lblVekt)
        Me.Controls.Add(Me.lblGir)
        Me.Controls.Add(Me.lblHjul)
        Me.Controls.Add(Me.lblSykkelType)
        Me.Controls.Add(Me.lblSykkelMerke)
        Me.Controls.Add(Me.lblSykkelID)
        Me.Controls.Add(Me.txtPrisDøgn)
        Me.Controls.Add(Me.txtPrisTime)
        Me.Controls.Add(Me.txtSykkelRammeNummer)
        Me.Controls.Add(Me.txtSykkelVekt)
        Me.Controls.Add(Me.txtSykkelGir)
        Me.Controls.Add(Me.txtSykkelHjul)
        Me.Controls.Add(Me.txtSykkelMerke)
        Me.Controls.Add(Me.txtSykkelID)
        Me.Controls.Add(Me.btnTilbake)
        Me.Controls.Add(Me.btnSlettTekstfelt)
        Me.Controls.Add(Me.btnOpprett)
        Me.Controls.Add(Me.btnOppdater)
        Me.Name = "AdministrereSykkel"
        Me.Text = "AS SykkelUtleie"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnOppdater As Button
    Friend WithEvents btnOpprett As Button
    Friend WithEvents btnSlettTekstfelt As Button
    Friend WithEvents btnTilbake As Button
    Friend WithEvents txtSykkelID As TextBox
    Friend WithEvents txtSykkelMerke As TextBox
    Friend WithEvents txtSykkelHjul As TextBox
    Friend WithEvents txtSykkelGir As TextBox
    Friend WithEvents txtSykkelVekt As TextBox
    Friend WithEvents txtSykkelRammeNummer As TextBox
    Friend WithEvents txtPrisTime As TextBox
    Friend WithEvents txtPrisDøgn As TextBox
    Friend WithEvents lblSykkelID As Label
    Friend WithEvents lblSykkelMerke As Label
    Friend WithEvents lblSykkelType As Label
    Friend WithEvents lblHjul As Label
    Friend WithEvents lblGir As Label
    Friend WithEvents lblVekt As Label
    Friend WithEvents lblRammenummer As Label
    Friend WithEvents lblPrisTime As Label
    Friend WithEvents lblPrisDøgn As Label
    Friend WithEvents txtPrisHelg As TextBox
    Friend WithEvents lblPrisHelg As Label
    Friend WithEvents lblLokasjon As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents btnSiste As Button
    Friend WithEvents btnNeste As Button
    Friend WithEvents btnFørste As Button
    Friend WithEvents btnForrige As Button
    Friend WithEvents txtSykkelRamme As TextBox
    Friend WithEvents lblRamme As Label
    Friend WithEvents txtAvdeling As TextBox
    Friend WithEvents lblAvdeling As Label
    Friend WithEvents btnSøk As Button
    Friend WithEvents txtSok As TextBox
    Friend WithEvents lstResultat As ListBox
    Friend WithEvents btnSlettSykkel As Button
    Friend WithEvents lblInnloggetAvdeling As Label
    Friend WithEvents cmbSykkelType As ComboBox
    Friend WithEvents cmbLokasjon As ComboBox
    Friend WithEvents cmbStatus As ComboBox
    Friend WithEvents btnSendMail As Button
End Class

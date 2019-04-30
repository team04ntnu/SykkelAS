<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdministrereUtstyr
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
        Me.lblInnloggetAvdeling = New System.Windows.Forms.Label()
        Me.txtUtstyrID = New System.Windows.Forms.TextBox()
        Me.lblUtstyrID = New System.Windows.Forms.Label()
        Me.txtUtstyrMerke = New System.Windows.Forms.TextBox()
        Me.lblUtstyrMerke = New System.Windows.Forms.Label()
        Me.txtUtstyrType = New System.Windows.Forms.TextBox()
        Me.lblUtstyrType = New System.Windows.Forms.Label()
        Me.txtPrisTime = New System.Windows.Forms.TextBox()
        Me.lblPrisTime = New System.Windows.Forms.Label()
        Me.txtPrisDøgn = New System.Windows.Forms.TextBox()
        Me.lblPrisDøgn = New System.Windows.Forms.Label()
        Me.txtPrisHelg = New System.Windows.Forms.TextBox()
        Me.lblPrisHelg = New System.Windows.Forms.Label()
        Me.cmbLokasjon = New System.Windows.Forms.ComboBox()
        Me.lblLokasjon = New System.Windows.Forms.Label()
        Me.cmbStatus = New System.Windows.Forms.ComboBox()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.txtAvdeling = New System.Windows.Forms.TextBox()
        Me.lblAvdeling = New System.Windows.Forms.Label()
        Me.btnOppdater = New System.Windows.Forms.Button()
        Me.btnOpprett = New System.Windows.Forms.Button()
        Me.btnForrige = New System.Windows.Forms.Button()
        Me.btnNeste = New System.Windows.Forms.Button()
        Me.btnFørste = New System.Windows.Forms.Button()
        Me.btnSiste = New System.Windows.Forms.Button()
        Me.btnSlettUtstyr = New System.Windows.Forms.Button()
        Me.btnSlettTekstfelt = New System.Windows.Forms.Button()
        Me.txtSok = New System.Windows.Forms.TextBox()
        Me.btnSøk = New System.Windows.Forms.Button()
        Me.lstResultat = New System.Windows.Forms.ListBox()
        Me.lblPasserTil = New System.Windows.Forms.Label()
        Me.chkAlle = New System.Windows.Forms.CheckBox()
        Me.chkTerreng = New System.Windows.Forms.CheckBox()
        Me.chkDownhill = New System.Windows.Forms.CheckBox()
        Me.chkRacer = New System.Windows.Forms.CheckBox()
        Me.chkTandem = New System.Windows.Forms.CheckBox()
        Me.chkBarn = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'btnTilbake
        '
        Me.btnTilbake.Location = New System.Drawing.Point(505, 576)
        Me.btnTilbake.Name = "btnTilbake"
        Me.btnTilbake.Size = New System.Drawing.Size(167, 23)
        Me.btnTilbake.TabIndex = 4
        Me.btnTilbake.Text = "Hovedmeny"
        Me.btnTilbake.UseVisualStyleBackColor = True
        '
        'lblInnloggetAvdeling
        '
        Me.lblInnloggetAvdeling.AutoSize = True
        Me.lblInnloggetAvdeling.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblInnloggetAvdeling.Location = New System.Drawing.Point(12, 585)
        Me.lblInnloggetAvdeling.Name = "lblInnloggetAvdeling"
        Me.lblInnloggetAvdeling.Size = New System.Drawing.Size(143, 17)
        Me.lblInnloggetAvdeling.TabIndex = 42
        Me.lblInnloggetAvdeling.Text = "Innlogget på avdeling"
        '
        'txtUtstyrID
        '
        Me.txtUtstyrID.Location = New System.Drawing.Point(134, 26)
        Me.txtUtstyrID.Name = "txtUtstyrID"
        Me.txtUtstyrID.ReadOnly = True
        Me.txtUtstyrID.Size = New System.Drawing.Size(200, 20)
        Me.txtUtstyrID.TabIndex = 43
        '
        'lblUtstyrID
        '
        Me.lblUtstyrID.AutoSize = True
        Me.lblUtstyrID.Location = New System.Drawing.Point(110, 29)
        Me.lblUtstyrID.Name = "lblUtstyrID"
        Me.lblUtstyrID.Size = New System.Drawing.Size(18, 13)
        Me.lblUtstyrID.TabIndex = 44
        Me.lblUtstyrID.Text = "ID"
        '
        'txtUtstyrMerke
        '
        Me.txtUtstyrMerke.Location = New System.Drawing.Point(134, 52)
        Me.txtUtstyrMerke.Name = "txtUtstyrMerke"
        Me.txtUtstyrMerke.Size = New System.Drawing.Size(200, 20)
        Me.txtUtstyrMerke.TabIndex = 45
        '
        'lblUtstyrMerke
        '
        Me.lblUtstyrMerke.AutoSize = True
        Me.lblUtstyrMerke.Location = New System.Drawing.Point(91, 55)
        Me.lblUtstyrMerke.Name = "lblUtstyrMerke"
        Me.lblUtstyrMerke.Size = New System.Drawing.Size(37, 13)
        Me.lblUtstyrMerke.TabIndex = 46
        Me.lblUtstyrMerke.Text = "Merke"
        '
        'txtUtstyrType
        '
        Me.txtUtstyrType.Location = New System.Drawing.Point(134, 79)
        Me.txtUtstyrType.Name = "txtUtstyrType"
        Me.txtUtstyrType.Size = New System.Drawing.Size(200, 20)
        Me.txtUtstyrType.TabIndex = 47
        '
        'lblUtstyrType
        '
        Me.lblUtstyrType.AutoSize = True
        Me.lblUtstyrType.Location = New System.Drawing.Point(97, 82)
        Me.lblUtstyrType.Name = "lblUtstyrType"
        Me.lblUtstyrType.Size = New System.Drawing.Size(31, 13)
        Me.lblUtstyrType.TabIndex = 48
        Me.lblUtstyrType.Text = "Type"
        '
        'txtPrisTime
        '
        Me.txtPrisTime.Location = New System.Drawing.Point(134, 105)
        Me.txtPrisTime.Name = "txtPrisTime"
        Me.txtPrisTime.Size = New System.Drawing.Size(200, 20)
        Me.txtPrisTime.TabIndex = 49
        '
        'lblPrisTime
        '
        Me.lblPrisTime.AutoSize = True
        Me.lblPrisTime.Location = New System.Drawing.Point(82, 108)
        Me.lblPrisTime.Name = "lblPrisTime"
        Me.lblPrisTime.Size = New System.Drawing.Size(46, 13)
        Me.lblPrisTime.TabIndex = 50
        Me.lblPrisTime.Text = "Pris time"
        '
        'txtPrisDøgn
        '
        Me.txtPrisDøgn.Location = New System.Drawing.Point(134, 131)
        Me.txtPrisDøgn.Name = "txtPrisDøgn"
        Me.txtPrisDøgn.Size = New System.Drawing.Size(200, 20)
        Me.txtPrisDøgn.TabIndex = 51
        '
        'lblPrisDøgn
        '
        Me.lblPrisDøgn.AutoSize = True
        Me.lblPrisDøgn.Location = New System.Drawing.Point(77, 134)
        Me.lblPrisDøgn.Name = "lblPrisDøgn"
        Me.lblPrisDøgn.Size = New System.Drawing.Size(51, 13)
        Me.lblPrisDøgn.TabIndex = 52
        Me.lblPrisDøgn.Text = "Pris døgn"
        '
        'txtPrisHelg
        '
        Me.txtPrisHelg.Location = New System.Drawing.Point(134, 157)
        Me.txtPrisHelg.Name = "txtPrisHelg"
        Me.txtPrisHelg.Size = New System.Drawing.Size(200, 20)
        Me.txtPrisHelg.TabIndex = 53
        '
        'lblPrisHelg
        '
        Me.lblPrisHelg.AutoSize = True
        Me.lblPrisHelg.Location = New System.Drawing.Point(81, 160)
        Me.lblPrisHelg.Name = "lblPrisHelg"
        Me.lblPrisHelg.Size = New System.Drawing.Size(47, 13)
        Me.lblPrisHelg.TabIndex = 54
        Me.lblPrisHelg.Text = "Pris helg"
        '
        'cmbLokasjon
        '
        Me.cmbLokasjon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLokasjon.FormattingEnabled = True
        Me.cmbLokasjon.Items.AddRange(New Object() {"Hos kunde"})
        Me.cmbLokasjon.Location = New System.Drawing.Point(134, 183)
        Me.cmbLokasjon.Name = "cmbLokasjon"
        Me.cmbLokasjon.Size = New System.Drawing.Size(200, 21)
        Me.cmbLokasjon.TabIndex = 55
        '
        'lblLokasjon
        '
        Me.lblLokasjon.AutoSize = True
        Me.lblLokasjon.Location = New System.Drawing.Point(78, 186)
        Me.lblLokasjon.Name = "lblLokasjon"
        Me.lblLokasjon.Size = New System.Drawing.Size(50, 13)
        Me.lblLokasjon.TabIndex = 56
        Me.lblLokasjon.Text = "Lokasjon"
        '
        'cmbStatus
        '
        Me.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbStatus.FormattingEnabled = True
        Me.cmbStatus.Items.AddRange(New Object() {"Ledig", "Utleid", "Stjålet", "Service"})
        Me.cmbStatus.Location = New System.Drawing.Point(134, 210)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Size = New System.Drawing.Size(200, 21)
        Me.cmbStatus.TabIndex = 57
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(91, 213)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(37, 13)
        Me.lblStatus.TabIndex = 58
        Me.lblStatus.Text = "Status"
        '
        'txtAvdeling
        '
        Me.txtAvdeling.Location = New System.Drawing.Point(134, 237)
        Me.txtAvdeling.Name = "txtAvdeling"
        Me.txtAvdeling.ReadOnly = True
        Me.txtAvdeling.Size = New System.Drawing.Size(200, 20)
        Me.txtAvdeling.TabIndex = 59
        '
        'lblAvdeling
        '
        Me.lblAvdeling.AutoSize = True
        Me.lblAvdeling.Location = New System.Drawing.Point(43, 240)
        Me.lblAvdeling.Name = "lblAvdeling"
        Me.lblAvdeling.Size = New System.Drawing.Size(85, 13)
        Me.lblAvdeling.TabIndex = 60
        Me.lblAvdeling.Text = "Tilhører avdeling"
        '
        'btnOppdater
        '
        Me.btnOppdater.Location = New System.Drawing.Point(134, 451)
        Me.btnOppdater.Name = "btnOppdater"
        Me.btnOppdater.Size = New System.Drawing.Size(200, 23)
        Me.btnOppdater.TabIndex = 61
        Me.btnOppdater.Text = "Oppdater utstyr"
        Me.btnOppdater.UseVisualStyleBackColor = True
        '
        'btnOpprett
        '
        Me.btnOpprett.Location = New System.Drawing.Point(134, 422)
        Me.btnOpprett.Name = "btnOpprett"
        Me.btnOpprett.Size = New System.Drawing.Size(200, 23)
        Me.btnOpprett.TabIndex = 62
        Me.btnOpprett.Text = "Opprett nytt utstyr"
        Me.btnOpprett.UseVisualStyleBackColor = True
        '
        'btnForrige
        '
        Me.btnForrige.Location = New System.Drawing.Point(53, 422)
        Me.btnForrige.Name = "btnForrige"
        Me.btnForrige.Size = New System.Drawing.Size(75, 23)
        Me.btnForrige.TabIndex = 63
        Me.btnForrige.Text = "Forrige"
        Me.btnForrige.UseVisualStyleBackColor = True
        '
        'btnNeste
        '
        Me.btnNeste.Location = New System.Drawing.Point(340, 422)
        Me.btnNeste.Name = "btnNeste"
        Me.btnNeste.Size = New System.Drawing.Size(75, 23)
        Me.btnNeste.TabIndex = 64
        Me.btnNeste.Text = "Neste"
        Me.btnNeste.UseVisualStyleBackColor = True
        '
        'btnFørste
        '
        Me.btnFørste.Location = New System.Drawing.Point(53, 451)
        Me.btnFørste.Name = "btnFørste"
        Me.btnFørste.Size = New System.Drawing.Size(75, 23)
        Me.btnFørste.TabIndex = 65
        Me.btnFørste.Text = "Første"
        Me.btnFørste.UseVisualStyleBackColor = True
        '
        'btnSiste
        '
        Me.btnSiste.Location = New System.Drawing.Point(340, 451)
        Me.btnSiste.Name = "btnSiste"
        Me.btnSiste.Size = New System.Drawing.Size(75, 23)
        Me.btnSiste.TabIndex = 66
        Me.btnSiste.Text = "Siste"
        Me.btnSiste.UseVisualStyleBackColor = True
        '
        'btnSlettUtstyr
        '
        Me.btnSlettUtstyr.Location = New System.Drawing.Point(134, 480)
        Me.btnSlettUtstyr.Name = "btnSlettUtstyr"
        Me.btnSlettUtstyr.Size = New System.Drawing.Size(200, 23)
        Me.btnSlettUtstyr.TabIndex = 67
        Me.btnSlettUtstyr.Text = "Slett utstyr"
        Me.btnSlettUtstyr.UseVisualStyleBackColor = True
        '
        'btnSlettTekstfelt
        '
        Me.btnSlettTekstfelt.Location = New System.Drawing.Point(134, 509)
        Me.btnSlettTekstfelt.Name = "btnSlettTekstfelt"
        Me.btnSlettTekstfelt.Size = New System.Drawing.Size(200, 23)
        Me.btnSlettTekstfelt.TabIndex = 68
        Me.btnSlettTekstfelt.Text = "Slett tekstfelt"
        Me.btnSlettTekstfelt.UseVisualStyleBackColor = True
        '
        'txtSok
        '
        Me.txtSok.Location = New System.Drawing.Point(410, 26)
        Me.txtSok.Name = "txtSok"
        Me.txtSok.Size = New System.Drawing.Size(192, 20)
        Me.txtSok.TabIndex = 69
        '
        'btnSøk
        '
        Me.btnSøk.Location = New System.Drawing.Point(410, 50)
        Me.btnSøk.Name = "btnSøk"
        Me.btnSøk.Size = New System.Drawing.Size(192, 23)
        Me.btnSøk.TabIndex = 70
        Me.btnSøk.Text = "Søk"
        Me.btnSøk.UseVisualStyleBackColor = True
        '
        'lstResultat
        '
        Me.lstResultat.FormattingEnabled = True
        Me.lstResultat.Location = New System.Drawing.Point(410, 79)
        Me.lstResultat.Name = "lstResultat"
        Me.lstResultat.Size = New System.Drawing.Size(192, 134)
        Me.lstResultat.TabIndex = 71
        '
        'lblPasserTil
        '
        Me.lblPasserTil.AutoSize = True
        Me.lblPasserTil.Location = New System.Drawing.Point(77, 269)
        Me.lblPasserTil.Name = "lblPasserTil"
        Me.lblPasserTil.Size = New System.Drawing.Size(49, 13)
        Me.lblPasserTil.TabIndex = 72
        Me.lblPasserTil.Text = "Passer til"
        '
        'chkAlle
        '
        Me.chkAlle.AutoSize = True
        Me.chkAlle.Location = New System.Drawing.Point(133, 269)
        Me.chkAlle.Name = "chkAlle"
        Me.chkAlle.Size = New System.Drawing.Size(73, 17)
        Me.chkAlle.TabIndex = 73
        Me.chkAlle.Text = "Alle sykler"
        Me.chkAlle.UseVisualStyleBackColor = True
        '
        'chkTerreng
        '
        Me.chkTerreng.AutoSize = True
        Me.chkTerreng.Location = New System.Drawing.Point(133, 293)
        Me.chkTerreng.Name = "chkTerreng"
        Me.chkTerreng.Size = New System.Drawing.Size(63, 17)
        Me.chkTerreng.TabIndex = 74
        Me.chkTerreng.Text = "Terreng"
        Me.chkTerreng.UseVisualStyleBackColor = True
        '
        'chkDownhill
        '
        Me.chkDownhill.AutoSize = True
        Me.chkDownhill.Location = New System.Drawing.Point(133, 316)
        Me.chkDownhill.Name = "chkDownhill"
        Me.chkDownhill.Size = New System.Drawing.Size(66, 17)
        Me.chkDownhill.TabIndex = 74
        Me.chkDownhill.Text = "Downhill"
        Me.chkDownhill.UseVisualStyleBackColor = True
        '
        'chkRacer
        '
        Me.chkRacer.AutoSize = True
        Me.chkRacer.Location = New System.Drawing.Point(133, 340)
        Me.chkRacer.Name = "chkRacer"
        Me.chkRacer.Size = New System.Drawing.Size(55, 17)
        Me.chkRacer.TabIndex = 75
        Me.chkRacer.Text = "Racer"
        Me.chkRacer.UseVisualStyleBackColor = True
        '
        'chkTandem
        '
        Me.chkTandem.AutoSize = True
        Me.chkTandem.Location = New System.Drawing.Point(133, 364)
        Me.chkTandem.Name = "chkTandem"
        Me.chkTandem.Size = New System.Drawing.Size(65, 17)
        Me.chkTandem.TabIndex = 76
        Me.chkTandem.Text = "Tandem"
        Me.chkTandem.UseVisualStyleBackColor = True
        '
        'chkBarn
        '
        Me.chkBarn.AutoSize = True
        Me.chkBarn.Location = New System.Drawing.Point(133, 388)
        Me.chkBarn.Name = "chkBarn"
        Me.chkBarn.Size = New System.Drawing.Size(84, 17)
        Me.chkBarn.TabIndex = 77
        Me.chkBarn.Text = "Barnesykkel"
        Me.chkBarn.UseVisualStyleBackColor = True
        '
        'AdministrereUtstyr
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 611)
        Me.Controls.Add(Me.chkBarn)
        Me.Controls.Add(Me.chkTandem)
        Me.Controls.Add(Me.chkRacer)
        Me.Controls.Add(Me.chkDownhill)
        Me.Controls.Add(Me.chkTerreng)
        Me.Controls.Add(Me.chkAlle)
        Me.Controls.Add(Me.lblPasserTil)
        Me.Controls.Add(Me.lstResultat)
        Me.Controls.Add(Me.btnSøk)
        Me.Controls.Add(Me.txtSok)
        Me.Controls.Add(Me.btnSlettTekstfelt)
        Me.Controls.Add(Me.btnSlettUtstyr)
        Me.Controls.Add(Me.btnSiste)
        Me.Controls.Add(Me.btnFørste)
        Me.Controls.Add(Me.btnNeste)
        Me.Controls.Add(Me.btnForrige)
        Me.Controls.Add(Me.btnOpprett)
        Me.Controls.Add(Me.btnOppdater)
        Me.Controls.Add(Me.lblAvdeling)
        Me.Controls.Add(Me.txtAvdeling)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.cmbStatus)
        Me.Controls.Add(Me.lblLokasjon)
        Me.Controls.Add(Me.cmbLokasjon)
        Me.Controls.Add(Me.lblPrisHelg)
        Me.Controls.Add(Me.txtPrisHelg)
        Me.Controls.Add(Me.lblPrisDøgn)
        Me.Controls.Add(Me.txtPrisDøgn)
        Me.Controls.Add(Me.lblPrisTime)
        Me.Controls.Add(Me.txtPrisTime)
        Me.Controls.Add(Me.lblUtstyrType)
        Me.Controls.Add(Me.txtUtstyrType)
        Me.Controls.Add(Me.lblUtstyrMerke)
        Me.Controls.Add(Me.txtUtstyrMerke)
        Me.Controls.Add(Me.lblUtstyrID)
        Me.Controls.Add(Me.txtUtstyrID)
        Me.Controls.Add(Me.lblInnloggetAvdeling)
        Me.Controls.Add(Me.btnTilbake)
        Me.Name = "AdministrereUtstyr"
        Me.Text = "AS SykkelUtleie"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnTilbake As Button
    Friend WithEvents lblInnloggetAvdeling As Label
    Friend WithEvents txtUtstyrID As TextBox
    Friend WithEvents lblUtstyrID As Label
    Friend WithEvents txtUtstyrMerke As TextBox
    Friend WithEvents lblUtstyrMerke As Label
    Friend WithEvents txtUtstyrType As TextBox
    Friend WithEvents lblUtstyrType As Label
    Friend WithEvents txtPrisTime As TextBox
    Friend WithEvents lblPrisTime As Label
    Friend WithEvents txtPrisDøgn As TextBox
    Friend WithEvents lblPrisDøgn As Label
    Friend WithEvents txtPrisHelg As TextBox
    Friend WithEvents lblPrisHelg As Label
    Friend WithEvents cmbLokasjon As ComboBox
    Friend WithEvents lblLokasjon As Label
    Friend WithEvents cmbStatus As ComboBox
    Friend WithEvents lblStatus As Label
    Friend WithEvents txtAvdeling As TextBox
    Friend WithEvents lblAvdeling As Label
    Friend WithEvents btnOppdater As Button
    Friend WithEvents btnOpprett As Button
    Friend WithEvents btnForrige As Button
    Friend WithEvents btnNeste As Button
    Friend WithEvents btnFørste As Button
    Friend WithEvents btnSiste As Button
    Friend WithEvents btnSlettUtstyr As Button
    Friend WithEvents btnSlettTekstfelt As Button
    Friend WithEvents txtSok As TextBox
    Friend WithEvents btnSøk As Button
    Friend WithEvents lstResultat As ListBox
    Friend WithEvents lblPasserTil As Label
    Friend WithEvents chkAlle As CheckBox
    Friend WithEvents chkTerreng As CheckBox
    Friend WithEvents chkDownhill As CheckBox
    Friend WithEvents chkRacer As CheckBox
    Friend WithEvents chkTandem As CheckBox
    Friend WithEvents chkBarn As CheckBox
End Class

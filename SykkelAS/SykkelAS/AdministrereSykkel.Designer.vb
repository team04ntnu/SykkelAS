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
        Me.txtSykkelType = New System.Windows.Forms.TextBox()
        Me.txtSykkelHjul = New System.Windows.Forms.TextBox()
        Me.txtSykkelGir = New System.Windows.Forms.TextBox()
        Me.txtSykkelVekt = New System.Windows.Forms.TextBox()
        Me.txtSykkelRammeNummer = New System.Windows.Forms.TextBox()
        Me.txtPrisTime = New System.Windows.Forms.TextBox()
        Me.txtPrisDøgn = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtPrisHelg = New System.Windows.Forms.TextBox()
        Me.txtLokasjon = New System.Windows.Forms.TextBox()
        Me.txtStatus = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cmbSykkel = New System.Windows.Forms.ComboBox()
        Me.btnSiste = New System.Windows.Forms.Button()
        Me.btnNeste = New System.Windows.Forms.Button()
        Me.btnFørste = New System.Windows.Forms.Button()
        Me.btnForrige = New System.Windows.Forms.Button()
        Me.txtSykkelRamme = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtAvdeling = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.btnSøk = New System.Windows.Forms.Button()
        Me.txtSok = New System.Windows.Forms.TextBox()
        Me.lstResultat = New System.Windows.Forms.ListBox()
        Me.btnSlettSykkel = New System.Windows.Forms.Button()
        Me.lblInnloggetAvdeling = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnOppdater
        '
        Me.btnOppdater.Location = New System.Drawing.Point(134, 422)
        Me.btnOppdater.Name = "btnOppdater"
        Me.btnOppdater.Size = New System.Drawing.Size(200, 23)
        Me.btnOppdater.TabIndex = 19
        Me.btnOppdater.Text = "Oppdater"
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
        'txtSykkelType
        '
        Me.txtSykkelType.Location = New System.Drawing.Point(134, 78)
        Me.txtSykkelType.Name = "txtSykkelType"
        Me.txtSykkelType.Size = New System.Drawing.Size(200, 20)
        Me.txtSykkelType.TabIndex = 2
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(110, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 13)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(91, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Merke"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(97, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Type"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(103, 133)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(25, 13)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Hjul"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(108, 159)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(20, 13)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Gir"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(99, 185)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(29, 13)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "Vekt"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(48, 211)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 13)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "Rammenummer"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(82, 237)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 13)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "Pris time"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(77, 263)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(51, 13)
        Me.Label9.TabIndex = 34
        Me.Label9.Text = "Pris døgn"
        '
        'txtPrisHelg
        '
        Me.txtPrisHelg.Location = New System.Drawing.Point(134, 286)
        Me.txtPrisHelg.Name = "txtPrisHelg"
        Me.txtPrisHelg.Size = New System.Drawing.Size(200, 20)
        Me.txtPrisHelg.TabIndex = 10
        '
        'txtLokasjon
        '
        Me.txtLokasjon.Location = New System.Drawing.Point(134, 312)
        Me.txtLokasjon.Name = "txtLokasjon"
        Me.txtLokasjon.Size = New System.Drawing.Size(200, 20)
        Me.txtLokasjon.TabIndex = 11
        '
        'txtStatus
        '
        Me.txtStatus.Location = New System.Drawing.Point(134, 338)
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.Size = New System.Drawing.Size(200, 20)
        Me.txtStatus.TabIndex = 12
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(81, 289)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(47, 13)
        Me.Label10.TabIndex = 35
        Me.Label10.Text = "Pris helg"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(78, 315)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(50, 13)
        Me.Label11.TabIndex = 36
        Me.Label11.Text = "Lokasjon"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(91, 341)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(37, 13)
        Me.Label12.TabIndex = 37
        Me.Label12.Text = "Status"
        '
        'cmbSykkel
        '
        Me.cmbSykkel.FormattingEnabled = True
        Me.cmbSykkel.Location = New System.Drawing.Point(134, 395)
        Me.cmbSykkel.Name = "cmbSykkel"
        Me.cmbSykkel.Size = New System.Drawing.Size(200, 21)
        Me.cmbSykkel.TabIndex = 14
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
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(85, 107)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(43, 13)
        Me.Label13.TabIndex = 28
        Me.Label13.Text = "Ramme"
        '
        'txtAvdeling
        '
        Me.txtAvdeling.Location = New System.Drawing.Point(134, 365)
        Me.txtAvdeling.Name = "txtAvdeling"
        Me.txtAvdeling.ReadOnly = True
        Me.txtAvdeling.Size = New System.Drawing.Size(200, 20)
        Me.txtAvdeling.TabIndex = 13
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(43, 368)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(85, 13)
        Me.Label14.TabIndex = 38
        Me.Label14.Text = "Tilhører avdeling"
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
        'AdministrereSykkel
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 611)
        Me.Controls.Add(Me.lblInnloggetAvdeling)
        Me.Controls.Add(Me.btnSlettSykkel)
        Me.Controls.Add(Me.lstResultat)
        Me.Controls.Add(Me.txtSok)
        Me.Controls.Add(Me.btnSøk)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtAvdeling)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtSykkelRamme)
        Me.Controls.Add(Me.btnFørste)
        Me.Controls.Add(Me.btnForrige)
        Me.Controls.Add(Me.btnSiste)
        Me.Controls.Add(Me.btnNeste)
        Me.Controls.Add(Me.cmbSykkel)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtStatus)
        Me.Controls.Add(Me.txtLokasjon)
        Me.Controls.Add(Me.txtPrisHelg)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtPrisDøgn)
        Me.Controls.Add(Me.txtPrisTime)
        Me.Controls.Add(Me.txtSykkelRammeNummer)
        Me.Controls.Add(Me.txtSykkelVekt)
        Me.Controls.Add(Me.txtSykkelGir)
        Me.Controls.Add(Me.txtSykkelHjul)
        Me.Controls.Add(Me.txtSykkelType)
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
    Friend WithEvents txtSykkelType As TextBox
    Friend WithEvents txtSykkelHjul As TextBox
    Friend WithEvents txtSykkelGir As TextBox
    Friend WithEvents txtSykkelVekt As TextBox
    Friend WithEvents txtSykkelRammeNummer As TextBox
    Friend WithEvents txtPrisTime As TextBox
    Friend WithEvents txtPrisDøgn As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtPrisHelg As TextBox
    Friend WithEvents txtLokasjon As TextBox
    Friend WithEvents txtStatus As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents cmbSykkel As ComboBox
    Friend WithEvents btnSiste As Button
    Friend WithEvents btnNeste As Button
    Friend WithEvents btnFørste As Button
    Friend WithEvents btnForrige As Button
    Friend WithEvents txtSykkelRamme As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtAvdeling As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents btnSøk As Button
    Friend WithEvents txtSok As TextBox
    Friend WithEvents lstResultat As ListBox
    Friend WithEvents btnSlettSykkel As Button
    Friend WithEvents lblInnloggetAvdeling As Label
End Class

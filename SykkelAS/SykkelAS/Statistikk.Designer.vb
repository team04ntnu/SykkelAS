<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Statistikk
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.btnBeregn = New System.Windows.Forms.Button()
        Me.rbtnSykkel = New System.Windows.Forms.RadioButton()
        Me.rbtnAvdeling = New System.Windows.Forms.RadioButton()
        Me.rbtnAvanse = New System.Windows.Forms.RadioButton()
        Me.lstboxSykkelLokasjon = New System.Windows.Forms.ListBox()
        Me.dtpDatoFra = New System.Windows.Forms.DateTimePicker()
        Me.dtpDatoTil = New System.Windows.Forms.DateTimePicker()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.txtLønn = New System.Windows.Forms.TextBox()
        Me.txtFasteUtgifter = New System.Windows.Forms.TextBox()
        Me.txtVariableUtgifter = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnSykkelLokasjon = New System.Windows.Forms.Button()
        Me.btnHovedmeny = New System.Windows.Forms.Button()
        Me.rbtnKunde = New System.Windows.Forms.RadioButton()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnBeregn
        '
        Me.btnBeregn.Location = New System.Drawing.Point(23, 191)
        Me.btnBeregn.Name = "btnBeregn"
        Me.btnBeregn.Size = New System.Drawing.Size(164, 23)
        Me.btnBeregn.TabIndex = 0
        Me.btnBeregn.Text = "Fremstill Statistikk"
        Me.btnBeregn.UseVisualStyleBackColor = True
        '
        'rbtnSykkel
        '
        Me.rbtnSykkel.AutoSize = True
        Me.rbtnSykkel.Location = New System.Drawing.Point(276, 66)
        Me.rbtnSykkel.Name = "rbtnSykkel"
        Me.rbtnSykkel.Size = New System.Drawing.Size(68, 17)
        Me.rbtnSykkel.TabIndex = 1
        Me.rbtnSykkel.TabStop = True
        Me.rbtnSykkel.Text = "Pr sykkel"
        Me.rbtnSykkel.UseVisualStyleBackColor = True
        '
        'rbtnAvdeling
        '
        Me.rbtnAvdeling.AutoSize = True
        Me.rbtnAvdeling.Location = New System.Drawing.Point(276, 85)
        Me.rbtnAvdeling.Name = "rbtnAvdeling"
        Me.rbtnAvdeling.Size = New System.Drawing.Size(78, 17)
        Me.rbtnAvdeling.TabIndex = 2
        Me.rbtnAvdeling.TabStop = True
        Me.rbtnAvdeling.Text = "Pr avdeling"
        Me.rbtnAvdeling.UseVisualStyleBackColor = True
        '
        'rbtnAvanse
        '
        Me.rbtnAvanse.AutoSize = True
        Me.rbtnAvanse.Location = New System.Drawing.Point(276, 119)
        Me.rbtnAvanse.Name = "rbtnAvanse"
        Me.rbtnAvanse.Size = New System.Drawing.Size(61, 17)
        Me.rbtnAvanse.TabIndex = 3
        Me.rbtnAvanse.TabStop = True
        Me.rbtnAvanse.Text = "Avanse"
        Me.rbtnAvanse.UseVisualStyleBackColor = True
        '
        'lstboxSykkelLokasjon
        '
        Me.lstboxSykkelLokasjon.FormattingEnabled = True
        Me.lstboxSykkelLokasjon.Location = New System.Drawing.Point(547, 12)
        Me.lstboxSykkelLokasjon.Name = "lstboxSykkelLokasjon"
        Me.lstboxSykkelLokasjon.Size = New System.Drawing.Size(208, 173)
        Me.lstboxSykkelLokasjon.TabIndex = 4
        '
        'dtpDatoFra
        '
        Me.dtpDatoFra.Location = New System.Drawing.Point(23, 75)
        Me.dtpDatoFra.Name = "dtpDatoFra"
        Me.dtpDatoFra.Size = New System.Drawing.Size(200, 20)
        Me.dtpDatoFra.TabIndex = 5
        '
        'dtpDatoTil
        '
        Me.dtpDatoTil.Location = New System.Drawing.Point(23, 118)
        Me.dtpDatoTil.Name = "dtpDatoTil"
        Me.dtpDatoTil.Size = New System.Drawing.Size(200, 20)
        Me.dtpDatoTil.TabIndex = 6
        '
        'Chart1
        '
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(468, 215)
        Me.Chart1.Name = "Chart1"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(300, 300)
        Me.Chart1.TabIndex = 7
        Me.Chart1.Text = "Chart1"
        '
        'txtLønn
        '
        Me.txtLønn.Location = New System.Drawing.Point(112, 39)
        Me.txtLønn.Name = "txtLønn"
        Me.txtLønn.Size = New System.Drawing.Size(100, 20)
        Me.txtLønn.TabIndex = 8
        '
        'txtFasteUtgifter
        '
        Me.txtFasteUtgifter.Location = New System.Drawing.Point(112, 65)
        Me.txtFasteUtgifter.Name = "txtFasteUtgifter"
        Me.txtFasteUtgifter.Size = New System.Drawing.Size(100, 20)
        Me.txtFasteUtgifter.TabIndex = 9
        '
        'txtVariableUtgifter
        '
        Me.txtVariableUtgifter.Location = New System.Drawing.Point(112, 91)
        Me.txtVariableUtgifter.Name = "txtVariableUtgifter"
        Me.txtVariableUtgifter.Size = New System.Drawing.Size(100, 20)
        Me.txtVariableUtgifter.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Lønn"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Faste utgifter"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Variable utgifter"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtVariableUtgifter)
        Me.GroupBox1.Controls.Add(Me.txtLønn)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtFasteUtgifter)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(211, 215)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(251, 170)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Utgifter"
        Me.GroupBox1.Visible = False
        '
        'btnSykkelLokasjon
        '
        Me.btnSykkelLokasjon.Location = New System.Drawing.Point(770, 162)
        Me.btnSykkelLokasjon.Name = "btnSykkelLokasjon"
        Me.btnSykkelLokasjon.Size = New System.Drawing.Size(154, 23)
        Me.btnSykkelLokasjon.TabIndex = 17
        Me.btnSykkelLokasjon.Text = "Lokasjon av Sykkel"
        Me.btnSykkelLokasjon.UseVisualStyleBackColor = True
        '
        'btnHovedmeny
        '
        Me.btnHovedmeny.Location = New System.Drawing.Point(812, 542)
        Me.btnHovedmeny.Name = "btnHovedmeny"
        Me.btnHovedmeny.Size = New System.Drawing.Size(157, 23)
        Me.btnHovedmeny.TabIndex = 18
        Me.btnHovedmeny.Text = "Hovedmeny"
        Me.btnHovedmeny.UseVisualStyleBackColor = True
        '
        'rbtnKunde
        '
        Me.rbtnKunde.AutoSize = True
        Me.rbtnKunde.Location = New System.Drawing.Point(276, 102)
        Me.rbtnKunde.Name = "rbtnKunde"
        Me.rbtnKunde.Size = New System.Drawing.Size(68, 17)
        Me.rbtnKunde.TabIndex = 19
        Me.rbtnKunde.TabStop = True
        Me.rbtnKunde.Text = "Pr kunde"
        Me.rbtnKunde.UseVisualStyleBackColor = True
        '
        'Statistikk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(981, 577)
        Me.Controls.Add(Me.rbtnKunde)
        Me.Controls.Add(Me.btnHovedmeny)
        Me.Controls.Add(Me.btnSykkelLokasjon)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Chart1)
        Me.Controls.Add(Me.dtpDatoTil)
        Me.Controls.Add(Me.dtpDatoFra)
        Me.Controls.Add(Me.lstboxSykkelLokasjon)
        Me.Controls.Add(Me.rbtnAvanse)
        Me.Controls.Add(Me.rbtnAvdeling)
        Me.Controls.Add(Me.rbtnSykkel)
        Me.Controls.Add(Me.btnBeregn)
        Me.Name = "Statistikk"
        Me.Text = "Statistikk"
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBeregn As Button
    Friend WithEvents rbtnSykkel As RadioButton
    Friend WithEvents rbtnAvdeling As RadioButton
    Friend WithEvents rbtnAvanse As RadioButton
    Friend WithEvents lstboxSykkelLokasjon As ListBox
    Friend WithEvents dtpDatoFra As DateTimePicker
    Friend WithEvents dtpDatoTil As DateTimePicker
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents txtLønn As TextBox
    Friend WithEvents txtFasteUtgifter As TextBox
    Friend WithEvents txtVariableUtgifter As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnSykkelLokasjon As Button
    Friend WithEvents btnHovedmeny As Button
    Friend WithEvents rbtnKunde As RadioButton
End Class

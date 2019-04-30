<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Hovedmeny
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
        Me.lblInnloggetAvdeling = New System.Windows.Forms.Label()
        Me.btnLoggUt = New System.Windows.Forms.Button()
        Me.btnKunde = New System.Windows.Forms.Button()
        Me.btnSykkel = New System.Windows.Forms.Button()
        Me.btnUtstyr = New System.Windows.Forms.Button()
        Me.btnLeieavtaler = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblInnloggetAvdeling
        '
        Me.lblInnloggetAvdeling.AutoSize = True
        Me.lblInnloggetAvdeling.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblInnloggetAvdeling.Location = New System.Drawing.Point(12, 435)
        Me.lblInnloggetAvdeling.Name = "lblInnloggetAvdeling"
        Me.lblInnloggetAvdeling.Size = New System.Drawing.Size(143, 17)
        Me.lblInnloggetAvdeling.TabIndex = 0
        Me.lblInnloggetAvdeling.Text = "Innlogget på avdeling"
        '
        'btnLoggUt
        '
        Me.btnLoggUt.Location = New System.Drawing.Point(827, 429)
        Me.btnLoggUt.Name = "btnLoggUt"
        Me.btnLoggUt.Size = New System.Drawing.Size(145, 23)
        Me.btnLoggUt.TabIndex = 1
        Me.btnLoggUt.Text = "Logg ut"
        Me.btnLoggUt.UseVisualStyleBackColor = True
        '
        'btnKunde
        '
        Me.btnKunde.Location = New System.Drawing.Point(12, 12)
        Me.btnKunde.Name = "btnKunde"
        Me.btnKunde.Size = New System.Drawing.Size(200, 23)
        Me.btnKunde.TabIndex = 2
        Me.btnKunde.Text = "Administrer kunde"
        Me.btnKunde.UseVisualStyleBackColor = True
        '
        'btnSykkel
        '
        Me.btnSykkel.Location = New System.Drawing.Point(12, 41)
        Me.btnSykkel.Name = "btnSykkel"
        Me.btnSykkel.Size = New System.Drawing.Size(200, 23)
        Me.btnSykkel.TabIndex = 3
        Me.btnSykkel.Text = "Administrer sykkel"
        Me.btnSykkel.UseVisualStyleBackColor = True
        '
        'btnUtstyr
        '
        Me.btnUtstyr.Location = New System.Drawing.Point(12, 70)
        Me.btnUtstyr.Name = "btnUtstyr"
        Me.btnUtstyr.Size = New System.Drawing.Size(200, 23)
        Me.btnUtstyr.TabIndex = 4
        Me.btnUtstyr.Text = "Administrer utstyr"
        Me.btnUtstyr.UseVisualStyleBackColor = True
        '
        'btnLeieavtaler
        '
        Me.btnLeieavtaler.Location = New System.Drawing.Point(281, 12)
        Me.btnLeieavtaler.Name = "btnLeieavtaler"
        Me.btnLeieavtaler.Size = New System.Drawing.Size(200, 23)
        Me.btnLeieavtaler.TabIndex = 5
        Me.btnLeieavtaler.Text = "Leieavtaler"
        Me.btnLeieavtaler.UseVisualStyleBackColor = True
        '
        'Hovedmeny
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 461)
        Me.Controls.Add(Me.btnLeieavtaler)
        Me.Controls.Add(Me.btnUtstyr)
        Me.Controls.Add(Me.btnSykkel)
        Me.Controls.Add(Me.btnKunde)
        Me.Controls.Add(Me.btnLoggUt)
        Me.Controls.Add(Me.lblInnloggetAvdeling)
        Me.Name = "Hovedmeny"
        Me.Text = "AS SykkelUtleie"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblInnloggetAvdeling As Label
    Friend WithEvents btnLoggUt As Button
    Friend WithEvents btnKunde As Button
    Friend WithEvents btnSykkel As Button
    Friend WithEvents btnUtstyr As Button
    Friend WithEvents btnLeieavtaler As Button
End Class

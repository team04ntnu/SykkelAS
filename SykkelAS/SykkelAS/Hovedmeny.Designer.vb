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
        'Hovedmeny
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 461)
        Me.Controls.Add(Me.btnLoggUt)
        Me.Controls.Add(Me.lblInnloggetAvdeling)
        Me.Name = "Hovedmeny"
        Me.Text = "AS SykkelUtleie"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblInnloggetAvdeling As Label
    Friend WithEvents btnLoggUt As Button
End Class

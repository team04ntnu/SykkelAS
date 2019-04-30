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
        Me.SuspendLayout()
        '
        'btnTilbake
        '
        Me.btnTilbake.Location = New System.Drawing.Point(621, 415)
        Me.btnTilbake.Name = "btnTilbake"
        Me.btnTilbake.Size = New System.Drawing.Size(167, 23)
        Me.btnTilbake.TabIndex = 42
        Me.btnTilbake.Text = "Hovedmeny"
        Me.btnTilbake.UseVisualStyleBackColor = True
        '
        'Leieavtaler
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnTilbake)
        Me.Name = "Leieavtaler"
        Me.Text = "Leieavtaler"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnTilbake As Button
End Class

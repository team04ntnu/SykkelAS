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
        Me.btnBeregn = New System.Windows.Forms.Button()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.dtpDatoFra = New System.Windows.Forms.DateTimePicker()
        Me.dtpDatoTil = New System.Windows.Forms.DateTimePicker()
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
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(282, 74)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(90, 17)
        Me.RadioButton1.TabIndex = 1
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "RadioButton1"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(282, 98)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(90, 17)
        Me.RadioButton2.TabIndex = 2
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "RadioButton2"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(282, 122)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(90, 17)
        Me.RadioButton3.TabIndex = 3
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "RadioButton3"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(547, 12)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(208, 173)
        Me.ListBox1.TabIndex = 4
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
        'Statistikk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.dtpDatoTil)
        Me.Controls.Add(Me.dtpDatoFra)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.RadioButton3)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.btnBeregn)
        Me.Name = "Statistikk"
        Me.Text = "Statistikk"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBeregn As Button
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents dtpDatoFra As DateTimePicker
    Friend WithEvents dtpDatoTil As DateTimePicker
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Innlogging
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
        Me.cmbAvdeling = New System.Windows.Forms.ComboBox()
        Me.txtPassord = New System.Windows.Forms.TextBox()
        Me.btnLoggInn = New System.Windows.Forms.Button()
        Me.lblLoggInn = New System.Windows.Forms.Label()
        Me.lblAvdeling = New System.Windows.Forms.Label()
        Me.lblPassord = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbAvdeling
        '
        Me.cmbAvdeling.FormattingEnabled = True
        Me.cmbAvdeling.Location = New System.Drawing.Point(130, 174)
        Me.cmbAvdeling.Name = "cmbAvdeling"
        Me.cmbAvdeling.Size = New System.Drawing.Size(121, 21)
        Me.cmbAvdeling.TabIndex = 0
        Me.cmbAvdeling.Text = "Haugastøl"
        '
        'txtPassord
        '
        Me.txtPassord.Location = New System.Drawing.Point(130, 201)
        Me.txtPassord.Name = "txtPassord"
        Me.txtPassord.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassord.Size = New System.Drawing.Size(121, 20)
        Me.txtPassord.TabIndex = 1
        Me.txtPassord.Text = "1234"
        '
        'btnLoggInn
        '
        Me.btnLoggInn.Location = New System.Drawing.Point(75, 227)
        Me.btnLoggInn.Name = "btnLoggInn"
        Me.btnLoggInn.Size = New System.Drawing.Size(176, 23)
        Me.btnLoggInn.TabIndex = 2
        Me.btnLoggInn.Text = "Logg inn"
        Me.btnLoggInn.UseVisualStyleBackColor = True
        '
        'lblLoggInn
        '
        Me.lblLoggInn.AutoSize = True
        Me.lblLoggInn.Location = New System.Drawing.Point(9, 9)
        Me.lblLoggInn.Name = "lblLoggInn"
        Me.lblLoggInn.Size = New System.Drawing.Size(161, 13)
        Me.lblLoggInn.TabIndex = 4
        Me.lblLoggInn.Text = "Velg din avdeling for å logge inn:"
        '
        'lblAvdeling
        '
        Me.lblAvdeling.AutoSize = True
        Me.lblAvdeling.Location = New System.Drawing.Point(75, 177)
        Me.lblAvdeling.Name = "lblAvdeling"
        Me.lblAvdeling.Size = New System.Drawing.Size(51, 13)
        Me.lblAvdeling.TabIndex = 5
        Me.lblAvdeling.Text = "Avdeling:"
        '
        'lblPassord
        '
        Me.lblPassord.AutoSize = True
        Me.lblPassord.Location = New System.Drawing.Point(76, 201)
        Me.lblPassord.Name = "lblPassord"
        Me.lblPassord.Size = New System.Drawing.Size(48, 13)
        Me.lblPassord.TabIndex = 6
        Me.lblPassord.Text = "Passord:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(130, 83)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'Innlogging
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(322, 450)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblPassord)
        Me.Controls.Add(Me.lblAvdeling)
        Me.Controls.Add(Me.lblLoggInn)
        Me.Controls.Add(Me.btnLoggInn)
        Me.Controls.Add(Me.txtPassord)
        Me.Controls.Add(Me.cmbAvdeling)
        Me.Name = "Innlogging"
        Me.Text = "AS SykkelUtleie"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbAvdeling As ComboBox
    Friend WithEvents txtPassord As TextBox
    Friend WithEvents btnLoggInn As Button
    Friend WithEvents lblLoggInn As Label
    Friend WithEvents lblAvdeling As Label
    Friend WithEvents lblPassord As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class

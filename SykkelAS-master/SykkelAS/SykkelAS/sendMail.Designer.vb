<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sendMail
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
        Me.btnSendMail = New System.Windows.Forms.Button()
        Me.txtTil = New System.Windows.Forms.TextBox()
        Me.txtEmne = New System.Windows.Forms.TextBox()
        Me.txtKommentar = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnSendMail
        '
        Me.btnSendMail.Location = New System.Drawing.Point(256, 196)
        Me.btnSendMail.Name = "btnSendMail"
        Me.btnSendMail.Size = New System.Drawing.Size(136, 23)
        Me.btnSendMail.TabIndex = 0
        Me.btnSendMail.Text = "Send Mail"
        Me.btnSendMail.UseVisualStyleBackColor = True
        '
        'txtTil
        '
        Me.txtTil.Location = New System.Drawing.Point(256, 57)
        Me.txtTil.Name = "txtTil"
        Me.txtTil.Size = New System.Drawing.Size(136, 20)
        Me.txtTil.TabIndex = 1
        '
        'txtEmne
        '
        Me.txtEmne.Location = New System.Drawing.Point(256, 105)
        Me.txtEmne.Name = "txtEmne"
        Me.txtEmne.Size = New System.Drawing.Size(136, 20)
        Me.txtEmne.TabIndex = 2
        '
        'txtKommentar
        '
        Me.txtKommentar.Location = New System.Drawing.Point(256, 154)
        Me.txtKommentar.Name = "txtKommentar"
        Me.txtKommentar.Size = New System.Drawing.Size(136, 20)
        Me.txtKommentar.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(120, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Til"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(123, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Emne"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(126, 160)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Kommentar"
        '
        'sendMail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(518, 308)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtKommentar)
        Me.Controls.Add(Me.txtEmne)
        Me.Controls.Add(Me.txtTil)
        Me.Controls.Add(Me.btnSendMail)
        Me.Name = "sendMail"
        Me.Text = "sendMail"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSendMail As Button
    Friend WithEvents txtTil As TextBox
    Friend WithEvents txtEmne As TextBox
    Friend WithEvents txtKommentar As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class

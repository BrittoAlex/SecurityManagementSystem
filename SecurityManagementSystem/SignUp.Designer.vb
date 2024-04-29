<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SignUp
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.NameBOX = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.UsernameBOX = New System.Windows.Forms.TextBox()
        Me.PasswordBOX = New System.Windows.Forms.TextBox()
        Me.signupBTN = New System.Windows.Forms.Button()
        Me.UsernameTXT = New System.Windows.Forms.Label()
        Me.PasswordTXT = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.Panel1.Controls.Add(Me.NameBOX)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.UsernameBOX)
        Me.Panel1.Controls.Add(Me.PasswordBOX)
        Me.Panel1.Controls.Add(Me.signupBTN)
        Me.Panel1.Controls.Add(Me.UsernameTXT)
        Me.Panel1.Controls.Add(Me.PasswordTXT)
        Me.Panel1.Location = New System.Drawing.Point(268, 189)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(553, 283)
        Me.Panel1.TabIndex = 6
        '
        'NameBOX
        '
        Me.NameBOX.Location = New System.Drawing.Point(32, 61)
        Me.NameBOX.Name = "NameBOX"
        Me.NameBOX.Size = New System.Drawing.Size(222, 29)
        Me.NameBOX.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(28, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 23)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Name"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(279, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(274, 283)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'UsernameBOX
        '
        Me.UsernameBOX.Location = New System.Drawing.Point(32, 123)
        Me.UsernameBOX.Name = "UsernameBOX"
        Me.UsernameBOX.Size = New System.Drawing.Size(222, 29)
        Me.UsernameBOX.TabIndex = 3
        '
        'PasswordBOX
        '
        Me.PasswordBOX.Location = New System.Drawing.Point(32, 183)
        Me.PasswordBOX.Name = "PasswordBOX"
        Me.PasswordBOX.Size = New System.Drawing.Size(222, 29)
        Me.PasswordBOX.TabIndex = 4
        '
        'signupBTN
        '
        Me.signupBTN.Location = New System.Drawing.Point(90, 221)
        Me.signupBTN.Name = "signupBTN"
        Me.signupBTN.Size = New System.Drawing.Size(100, 34)
        Me.signupBTN.TabIndex = 0
        Me.signupBTN.Text = "SIGNUP"
        Me.signupBTN.UseVisualStyleBackColor = True
        '
        'UsernameTXT
        '
        Me.UsernameTXT.AutoSize = True
        Me.UsernameTXT.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.UsernameTXT.Location = New System.Drawing.Point(28, 89)
        Me.UsernameTXT.Name = "UsernameTXT"
        Me.UsernameTXT.Size = New System.Drawing.Size(92, 23)
        Me.UsernameTXT.TabIndex = 1
        Me.UsernameTXT.Text = "Username"
        '
        'PasswordTXT
        '
        Me.PasswordTXT.AutoSize = True
        Me.PasswordTXT.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PasswordTXT.Location = New System.Drawing.Point(28, 151)
        Me.PasswordTXT.Name = "PasswordTXT"
        Me.PasswordTXT.Size = New System.Drawing.Size(86, 23)
        Me.PasswordTXT.TabIndex = 2
        Me.PasswordTXT.Text = "Password"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(487, 569)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 34)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "LOGIN"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'SignUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(11, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1067, 658)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "SignUp"
        Me.Text = "SignUp"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents UsernameBOX As TextBox
    Friend WithEvents PasswordBOX As TextBox
    Friend WithEvents signupBTN As Button
    Friend WithEvents UsernameTXT As Label
    Friend WithEvents PasswordTXT As Label
    Friend WithEvents NameBOX As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.LoginBTN = New System.Windows.Forms.Button()
        Me.UsernameTXT = New System.Windows.Forms.Label()
        Me.PasswordTXT = New System.Windows.Forms.Label()
        Me.Login_username = New System.Windows.Forms.TextBox()
        Me.Login_password = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.AdminCheck = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LoginBTN
        '
        Me.LoginBTN.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LoginBTN.Location = New System.Drawing.Point(90, 221)
        Me.LoginBTN.Name = "LoginBTN"
        Me.LoginBTN.Size = New System.Drawing.Size(100, 34)
        Me.LoginBTN.TabIndex = 0
        Me.LoginBTN.Text = "LOGIN"
        Me.LoginBTN.UseVisualStyleBackColor = True
        '
        'UsernameTXT
        '
        Me.UsernameTXT.AutoSize = True
        Me.UsernameTXT.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.UsernameTXT.Location = New System.Drawing.Point(26, 38)
        Me.UsernameTXT.Name = "UsernameTXT"
        Me.UsernameTXT.Size = New System.Drawing.Size(92, 23)
        Me.UsernameTXT.TabIndex = 1
        Me.UsernameTXT.Text = "Username"
        '
        'PasswordTXT
        '
        Me.PasswordTXT.AutoSize = True
        Me.PasswordTXT.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PasswordTXT.Location = New System.Drawing.Point(26, 116)
        Me.PasswordTXT.Name = "PasswordTXT"
        Me.PasswordTXT.Size = New System.Drawing.Size(86, 23)
        Me.PasswordTXT.TabIndex = 2
        Me.PasswordTXT.Text = "Password"
        '
        'Login_username
        '
        Me.Login_username.Location = New System.Drawing.Point(30, 72)
        Me.Login_username.Name = "Login_username"
        Me.Login_username.Size = New System.Drawing.Size(222, 29)
        Me.Login_username.TabIndex = 3
        '
        'Login_password
        '
        Me.Login_password.Location = New System.Drawing.Point(30, 148)
        Me.Login_password.Name = "Login_password"
        Me.Login_password.Size = New System.Drawing.Size(222, 29)
        Me.Login_password.TabIndex = 4
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.AdminCheck)
        Me.Panel1.Controls.Add(Me.Login_username)
        Me.Panel1.Controls.Add(Me.Login_password)
        Me.Panel1.Controls.Add(Me.LoginBTN)
        Me.Panel1.Controls.Add(Me.UsernameTXT)
        Me.Panel1.Controls.Add(Me.PasswordTXT)
        Me.Panel1.Location = New System.Drawing.Point(268, 189)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(553, 283)
        Me.Panel1.TabIndex = 5
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(279, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(274, 283)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'AdminCheck
        '
        Me.AdminCheck.AutoSize = True
        Me.AdminCheck.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.AdminCheck.Location = New System.Drawing.Point(103, 192)
        Me.AdminCheck.Name = "AdminCheck"
        Me.AdminCheck.Size = New System.Drawing.Size(86, 27)
        Me.AdminCheck.TabIndex = 5
        Me.AdminCheck.Text = "Admin"
        Me.AdminCheck.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.Location = New System.Drawing.Point(495, 560)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 34)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "SIGNUP"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(84, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(922, 51)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "MALL SECURITY MANAGEMENT SYSTEM"
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(11, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1067, 658)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Login"
        Me.Text = "Login"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LoginBTN As Button
    Friend WithEvents UsernameTXT As Label
    Friend WithEvents PasswordTXT As Label
    Friend WithEvents Login_username As TextBox
    Friend WithEvents Login_password As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents AdminCheck As CheckBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
End Class

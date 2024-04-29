<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Security
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
        Me.UpdateBTN = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.UserLabel = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.SectorLOG = New System.Windows.Forms.RichTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SectorBOX = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.StatusBOX = New System.Windows.Forms.ComboBox()
        Me.StatusLOG = New System.Windows.Forms.RichTextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.BriefBOX = New System.Windows.Forms.RichTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.INCtypeBOX = New System.Windows.Forms.ComboBox()
        Me.INCsecBOX = New System.Windows.Forms.ComboBox()
        Me.DetailsBOX = New System.Windows.Forms.RichTextBox()
        Me.LastUpdate = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.LogoutBTN = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'UpdateBTN
        '
        Me.UpdateBTN.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.UpdateBTN.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.UpdateBTN.Location = New System.Drawing.Point(961, 611)
        Me.UpdateBTN.Name = "UpdateBTN"
        Me.UpdateBTN.Size = New System.Drawing.Size(94, 35)
        Me.UpdateBTN.TabIndex = 0
        Me.UpdateBTN.Text = "UPDATE"
        Me.UpdateBTN.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(23, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Logged In As"
        '
        'UserLabel
        '
        Me.UserLabel.AutoSize = True
        Me.UserLabel.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.UserLabel.Location = New System.Drawing.Point(23, 54)
        Me.UserLabel.Name = "UserLabel"
        Me.UserLabel.Size = New System.Drawing.Size(50, 21)
        Me.UserLabel.TabIndex = 2
        Me.UserLabel.Text = "USER"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.SectorLOG)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.SectorBOX)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox1.Location = New System.Drawing.Point(27, 105)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(504, 232)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "SECTOR"
        '
        'SectorLOG
        '
        Me.SectorLOG.Location = New System.Drawing.Point(312, 14)
        Me.SectorLOG.Name = "SectorLOG"
        Me.SectorLOG.Size = New System.Drawing.Size(186, 212)
        Me.SectorLOG.TabIndex = 12
        Me.SectorLOG.Text = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(9, 39)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 21)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Sector"
        '
        'SectorBOX
        '
        Me.SectorBOX.FormattingEnabled = True
        Me.SectorBOX.Items.AddRange(New Object() {"GATE", "COUNTER", "OFFICE", "SURVEILLANCE"})
        Me.SectorBOX.Location = New System.Drawing.Point(81, 38)
        Me.SectorBOX.Name = "SectorBOX"
        Me.SectorBOX.Size = New System.Drawing.Size(204, 27)
        Me.SectorBOX.TabIndex = 8
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.StatusBOX)
        Me.GroupBox2.Controls.Add(Me.StatusLOG)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox2.Location = New System.Drawing.Point(537, 105)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(502, 232)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "STATUS"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.Location = New System.Drawing.Point(10, 40)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 21)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Status"
        '
        'StatusBOX
        '
        Me.StatusBOX.FormattingEnabled = True
        Me.StatusBOX.Items.AddRange(New Object() {"ON DUTY", "OFF DUTY", "BREAK"})
        Me.StatusBOX.Location = New System.Drawing.Point(82, 39)
        Me.StatusBOX.Name = "StatusBOX"
        Me.StatusBOX.Size = New System.Drawing.Size(204, 27)
        Me.StatusBOX.TabIndex = 14
        '
        'StatusLOG
        '
        Me.StatusLOG.Location = New System.Drawing.Point(310, 14)
        Me.StatusLOG.Name = "StatusLOG"
        Me.StatusLOG.Size = New System.Drawing.Size(186, 212)
        Me.StatusLOG.TabIndex = 13
        Me.StatusLOG.Text = ""
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.GroupBox3.Controls.Add(Me.BriefBOX)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.INCtypeBOX)
        Me.GroupBox3.Controls.Add(Me.INCsecBOX)
        Me.GroupBox3.Controls.Add(Me.DetailsBOX)
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox3.Location = New System.Drawing.Point(27, 343)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1012, 235)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "INCIDENT"
        '
        'BriefBOX
        '
        Me.BriefBOX.Location = New System.Drawing.Point(81, 121)
        Me.BriefBOX.Name = "BriefBOX"
        Me.BriefBOX.Size = New System.Drawing.Size(423, 105)
        Me.BriefBOX.TabIndex = 11
        Me.BriefBOX.Text = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(9, 122)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 21)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Brief :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(434, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 21)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Details :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(9, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 21)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Type"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(9, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 21)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Sector"
        '
        'INCtypeBOX
        '
        Me.INCtypeBOX.FormattingEnabled = True
        Me.INCtypeBOX.Items.AddRange(New Object() {"TRESSPASSING", "ACCIDENT", "MALFUNCTION"})
        Me.INCtypeBOX.Location = New System.Drawing.Point(81, 77)
        Me.INCtypeBOX.Name = "INCtypeBOX"
        Me.INCtypeBOX.Size = New System.Drawing.Size(204, 27)
        Me.INCtypeBOX.TabIndex = 2
        '
        'INCsecBOX
        '
        Me.INCsecBOX.FormattingEnabled = True
        Me.INCsecBOX.Items.AddRange(New Object() {"GATE", "COUNTER", "OFFICE", "SURVEILLANCE"})
        Me.INCsecBOX.Location = New System.Drawing.Point(81, 35)
        Me.INCsecBOX.Name = "INCsecBOX"
        Me.INCsecBOX.Size = New System.Drawing.Size(204, 27)
        Me.INCsecBOX.TabIndex = 1
        '
        'DetailsBOX
        '
        Me.DetailsBOX.Location = New System.Drawing.Point(510, 15)
        Me.DetailsBOX.Name = "DetailsBOX"
        Me.DetailsBOX.Size = New System.Drawing.Size(496, 211)
        Me.DetailsBOX.TabIndex = 0
        Me.DetailsBOX.Text = ""
        '
        'LastUpdate
        '
        Me.LastUpdate.AutoSize = True
        Me.LastUpdate.Font = New System.Drawing.Font("Microsoft YaHei", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LastUpdate.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LastUpdate.Location = New System.Drawing.Point(833, 23)
        Me.LastUpdate.Name = "LastUpdate"
        Me.LastUpdate.Size = New System.Drawing.Size(232, 48)
        Me.LastUpdate.TabIndex = 6
        Me.LastUpdate.Text = "Last Update"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label8.Location = New System.Drawing.Point(733, 47)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(94, 19)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Last Update : "
        '
        'LogoutBTN
        '
        Me.LogoutBTN.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.LogoutBTN.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LogoutBTN.Location = New System.Drawing.Point(27, 611)
        Me.LogoutBTN.Name = "LogoutBTN"
        Me.LogoutBTN.Size = New System.Drawing.Size(94, 35)
        Me.LogoutBTN.TabIndex = 8
        Me.LogoutBTN.Text = "LOGOUT"
        Me.LogoutBTN.UseVisualStyleBackColor = False
        '
        'Security
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(11, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1067, 658)
        Me.Controls.Add(Me.LogoutBTN)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.LastUpdate)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.UserLabel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.UpdateBTN)
        Me.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Security"
        Me.Text = "Security"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents UpdateBTN As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents UserLabel As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents DetailsBOX As RichTextBox
    Friend WithEvents LastUpdate As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents INCtypeBOX As ComboBox
    Friend WithEvents INCsecBOX As ComboBox
    Friend WithEvents BriefBOX As RichTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents SectorLOG As RichTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents SectorBOX As ComboBox
    Friend WithEvents StatusLOG As RichTextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents StatusBOX As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents LogoutBTN As Button
End Class

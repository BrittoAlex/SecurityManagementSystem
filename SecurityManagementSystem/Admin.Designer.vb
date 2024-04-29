<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin
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
        Me.logoutBTN = New System.Windows.Forms.Button()
        Me.AdminLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.logGRID = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.incGRID = New System.Windows.Forms.DataGridView()
        CType(Me.logGRID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.incGRID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'logoutBTN
        '
        Me.logoutBTN.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.logoutBTN.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.logoutBTN.Location = New System.Drawing.Point(939, 25)
        Me.logoutBTN.Name = "logoutBTN"
        Me.logoutBTN.Size = New System.Drawing.Size(100, 34)
        Me.logoutBTN.TabIndex = 1
        Me.logoutBTN.Text = "LOGOUT"
        Me.logoutBTN.UseVisualStyleBackColor = False
        '
        'AdminLabel
        '
        Me.AdminLabel.AutoSize = True
        Me.AdminLabel.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdminLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.AdminLabel.Location = New System.Drawing.Point(23, 56)
        Me.AdminLabel.Name = "AdminLabel"
        Me.AdminLabel.Size = New System.Drawing.Size(50, 21)
        Me.AdminLabel.TabIndex = 4
        Me.AdminLabel.Text = "USER"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(23, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 19)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Logged In As"
        '
        'logGRID
        '
        Me.logGRID.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.logGRID.Location = New System.Drawing.Point(27, 173)
        Me.logGRID.Name = "logGRID"
        Me.logGRID.Size = New System.Drawing.Size(1012, 213)
        Me.logGRID.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(23, 134)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 21)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "SECURITY LOG"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(23, 394)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 21)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "INCIDENT LOG"
        '
        'incGRID
        '
        Me.incGRID.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.incGRID.Location = New System.Drawing.Point(27, 433)
        Me.incGRID.Name = "incGRID"
        Me.incGRID.Size = New System.Drawing.Size(1012, 213)
        Me.incGRID.TabIndex = 7
        '
        'Admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(11, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1067, 658)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.incGRID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.logGRID)
        Me.Controls.Add(Me.AdminLabel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.logoutBTN)
        Me.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Admin"
        Me.Text = "Admin"
        CType(Me.logGRID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.incGRID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents logoutBTN As Button
    Friend WithEvents AdminLabel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents logGRID As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents incGRID As DataGridView
End Class

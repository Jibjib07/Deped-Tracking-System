<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adminInterface
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
        Me.Guna2ShadowPanel1 = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.btnDashBoard = New Guna.UI2.WinForms.Guna2Button()
        Me.IconButton3 = New FontAwesome.Sharp.IconButton()
        Me.btnExit = New FontAwesome.Sharp.IconButton()
        Me.btnHistory = New Guna.UI2.WinForms.Guna2Button()
        Me.btnUsers = New Guna.UI2.WinForms.Guna2Button()
        Me.pbProfile = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.pnlDisplay = New Guna.UI2.WinForms.Guna2Panel()
        Me.cmsProfile = New Guna.UI2.WinForms.Guna2ContextMenuStrip()
        Me.AccountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Guna2ShadowPanel1.SuspendLayout()
        CType(Me.pbProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmsProfile.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2ShadowPanel1
        '
        Me.Guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ShadowPanel1.Controls.Add(Me.btnDashBoard)
        Me.Guna2ShadowPanel1.Controls.Add(Me.IconButton3)
        Me.Guna2ShadowPanel1.Controls.Add(Me.btnExit)
        Me.Guna2ShadowPanel1.Controls.Add(Me.btnHistory)
        Me.Guna2ShadowPanel1.Controls.Add(Me.btnUsers)
        Me.Guna2ShadowPanel1.Controls.Add(Me.pbProfile)
        Me.Guna2ShadowPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2ShadowPanel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Guna2ShadowPanel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2ShadowPanel1.Name = "Guna2ShadowPanel1"
        Me.Guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black
        Me.Guna2ShadowPanel1.ShadowDepth = 50
        Me.Guna2ShadowPanel1.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.Dropped
        Me.Guna2ShadowPanel1.Size = New System.Drawing.Size(1350, 62)
        Me.Guna2ShadowPanel1.TabIndex = 3
        '
        'btnDashBoard
        '
        Me.btnDashBoard.BackColor = System.Drawing.Color.Transparent
        Me.btnDashBoard.BorderRadius = 15
        Me.btnDashBoard.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnDashBoard.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnDashBoard.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnDashBoard.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnDashBoard.FillColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.btnDashBoard.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDashBoard.ForeColor = System.Drawing.Color.Black
        Me.btnDashBoard.Location = New System.Drawing.Point(425, 8)
        Me.btnDashBoard.Name = "btnDashBoard"
        Me.btnDashBoard.ShadowDecoration.BorderRadius = 15
        Me.btnDashBoard.ShadowDecoration.Enabled = True
        Me.btnDashBoard.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(3)
        Me.btnDashBoard.Size = New System.Drawing.Size(107, 34)
        Me.btnDashBoard.TabIndex = 8
        Me.btnDashBoard.Text = "DashBoard"
        '
        'IconButton3
        '
        Me.IconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.IconButton3.IconChar = FontAwesome.Sharp.IconChar.Minus
        Me.IconButton3.IconColor = System.Drawing.Color.Black
        Me.IconButton3.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton3.IconSize = 13
        Me.IconButton3.Location = New System.Drawing.Point(1267, 0)
        Me.IconButton3.Name = "IconButton3"
        Me.IconButton3.Size = New System.Drawing.Size(43, 29)
        Me.IconButton3.TabIndex = 7
        Me.IconButton3.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.btnExit.IconChar = FontAwesome.Sharp.IconChar.X
        Me.btnExit.IconColor = System.Drawing.Color.Black
        Me.btnExit.IconFont = FontAwesome.Sharp.IconFont.Solid
        Me.btnExit.IconSize = 15
        Me.btnExit.Location = New System.Drawing.Point(1307, 0)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(43, 29)
        Me.btnExit.TabIndex = 5
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnHistory
        '
        Me.btnHistory.BackColor = System.Drawing.Color.Transparent
        Me.btnHistory.BorderRadius = 15
        Me.btnHistory.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnHistory.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnHistory.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnHistory.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnHistory.FillColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.btnHistory.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHistory.ForeColor = System.Drawing.Color.Black
        Me.btnHistory.Location = New System.Drawing.Point(734, 8)
        Me.btnHistory.Name = "btnHistory"
        Me.btnHistory.ShadowDecoration.BorderRadius = 15
        Me.btnHistory.ShadowDecoration.Enabled = True
        Me.btnHistory.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(3)
        Me.btnHistory.Size = New System.Drawing.Size(107, 34)
        Me.btnHistory.TabIndex = 4
        Me.btnHistory.Text = "History"
        '
        'btnUsers
        '
        Me.btnUsers.BackColor = System.Drawing.Color.Transparent
        Me.btnUsers.BorderRadius = 15
        Me.btnUsers.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnUsers.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnUsers.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnUsers.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnUsers.FillColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.btnUsers.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUsers.ForeColor = System.Drawing.Color.Black
        Me.btnUsers.Location = New System.Drawing.Point(581, 8)
        Me.btnUsers.Name = "btnUsers"
        Me.btnUsers.ShadowDecoration.BorderRadius = 15
        Me.btnUsers.ShadowDecoration.Enabled = True
        Me.btnUsers.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(3)
        Me.btnUsers.Size = New System.Drawing.Size(107, 34)
        Me.btnUsers.TabIndex = 3
        Me.btnUsers.Text = "Users"
        '
        'pbProfile
        '
        Me.pbProfile.ImageRotate = 0!
        Me.pbProfile.Location = New System.Drawing.Point(1108, 3)
        Me.pbProfile.Name = "pbProfile"
        Me.pbProfile.ShadowDecoration.Enabled = True
        Me.pbProfile.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.pbProfile.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(2)
        Me.pbProfile.Size = New System.Drawing.Size(44, 44)
        Me.pbProfile.TabIndex = 0
        Me.pbProfile.TabStop = False
        '
        'pnlDisplay
        '
        Me.pnlDisplay.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlDisplay.Location = New System.Drawing.Point(0, 62)
        Me.pnlDisplay.Name = "pnlDisplay"
        Me.pnlDisplay.Size = New System.Drawing.Size(1350, 962)
        Me.pnlDisplay.TabIndex = 4
        '
        'cmsProfile
        '
        Me.cmsProfile.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.cmsProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.cmsProfile.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmsProfile.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AccountToolStripMenuItem, Me.LogoutToolStripMenuItem})
        Me.cmsProfile.Margin = New System.Windows.Forms.Padding(0, 3, 0, 3)
        Me.cmsProfile.Name = "cmsProfile"
        Me.cmsProfile.RenderStyle.ArrowColor = System.Drawing.Color.WhiteSmoke
        Me.cmsProfile.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro
        Me.cmsProfile.RenderStyle.ColorTable = Nothing
        Me.cmsProfile.RenderStyle.RoundedEdges = True
        Me.cmsProfile.RenderStyle.SelectionArrowColor = System.Drawing.Color.WhiteSmoke
        Me.cmsProfile.RenderStyle.SelectionBackColor = System.Drawing.Color.WhiteSmoke
        Me.cmsProfile.RenderStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.cmsProfile.RenderStyle.SeparatorColor = System.Drawing.Color.WhiteSmoke
        Me.cmsProfile.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.cmsProfile.Size = New System.Drawing.Size(145, 52)
        '
        'AccountToolStripMenuItem
        '
        Me.AccountToolStripMenuItem.Name = "AccountToolStripMenuItem"
        Me.AccountToolStripMenuItem.Size = New System.Drawing.Size(144, 24)
        Me.AccountToolStripMenuItem.Text = "Account"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(144, 24)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'adminInterface
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1350, 1024)
        Me.Controls.Add(Me.pnlDisplay)
        Me.Controls.Add(Me.Guna2ShadowPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "adminInterface"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "adminInterface"
        Me.Guna2ShadowPanel1.ResumeLayout(False)
        CType(Me.pbProfile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmsProfile.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2ShadowPanel1 As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents btnDashBoard As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents IconButton3 As FontAwesome.Sharp.IconButton
    Friend WithEvents btnExit As FontAwesome.Sharp.IconButton
    Friend WithEvents btnHistory As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnUsers As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents pbProfile As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents pnlDisplay As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents cmsProfile As Guna.UI2.WinForms.Guna2ContextMenuStrip
    Friend WithEvents AccountToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
End Class

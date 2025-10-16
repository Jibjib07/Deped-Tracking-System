<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class deptInterface
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(deptInterface))
        Me.btnDashBoard = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2ShadowPanel1 = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.lblID = New System.Windows.Forms.Label()
        Me.lblDept = New System.Windows.Forms.Label()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.IconButton3 = New FontAwesome.Sharp.IconButton()
        Me.btnExit = New FontAwesome.Sharp.IconButton()
        Me.btnHistory = New Guna.UI2.WinForms.Guna2Button()
        Me.btnChecklist = New Guna.UI2.WinForms.Guna2Button()
        Me.pbProfile = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.pnlDisplay = New Guna.UI2.WinForms.Guna2Panel()
        Me.cmsProfile = New Guna.UI2.WinForms.Guna2ContextMenuStrip()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Guna2ShadowPanel1.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmsProfile.SuspendLayout()
        Me.SuspendLayout()
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
        Me.btnDashBoard.Location = New System.Drawing.Point(561, 17)
        Me.btnDashBoard.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDashBoard.Name = "btnDashBoard"
        Me.btnDashBoard.ShadowDecoration.BorderRadius = 15
        Me.btnDashBoard.ShadowDecoration.Enabled = True
        Me.btnDashBoard.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(3)
        Me.btnDashBoard.Size = New System.Drawing.Size(152, 42)
        Me.btnDashBoard.TabIndex = 8
        Me.btnDashBoard.Text = "Dashboard"
        '
        'Guna2ShadowPanel1
        '
        Me.Guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ShadowPanel1.Controls.Add(Me.lblID)
        Me.Guna2ShadowPanel1.Controls.Add(Me.lblDept)
        Me.Guna2ShadowPanel1.Controls.Add(Me.Guna2PictureBox1)
        Me.Guna2ShadowPanel1.Controls.Add(Me.btnDashBoard)
        Me.Guna2ShadowPanel1.Controls.Add(Me.IconButton3)
        Me.Guna2ShadowPanel1.Controls.Add(Me.btnExit)
        Me.Guna2ShadowPanel1.Controls.Add(Me.btnHistory)
        Me.Guna2ShadowPanel1.Controls.Add(Me.btnChecklist)
        Me.Guna2ShadowPanel1.Controls.Add(Me.pbProfile)
        Me.Guna2ShadowPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2ShadowPanel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Guna2ShadowPanel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2ShadowPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Guna2ShadowPanel1.Name = "Guna2ShadowPanel1"
        Me.Guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black
        Me.Guna2ShadowPanel1.ShadowDepth = 50
        Me.Guna2ShadowPanel1.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.Dropped
        Me.Guna2ShadowPanel1.Size = New System.Drawing.Size(1800, 91)
        Me.Guna2ShadowPanel1.TabIndex = 0
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(405, 42)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(0, 16)
        Me.lblID.TabIndex = 12
        Me.lblID.Visible = False
        '
        'lblDept
        '
        Me.lblDept.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDept.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblDept.Location = New System.Drawing.Point(1164, 25)
        Me.lblDept.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDept.Name = "lblDept"
        Me.lblDept.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDept.Size = New System.Drawing.Size(303, 34)
        Me.lblDept.TabIndex = 11
        Me.lblDept.Text = "-"
        Me.lblDept.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BackgroundImage = Global.Deped_Tracking_System.My.Resources.Resources.LOGO
        Me.Guna2PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Guna2PictureBox1.Enabled = False
        Me.Guna2PictureBox1.ErrorImage = Nothing
        Me.Guna2PictureBox1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.Image = Global.Deped_Tracking_System.My.Resources.Resources.LOGO
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.InitialImage = Global.Deped_Tracking_System.My.Resources.Resources.LOGO
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(36, 7)
        Me.Guna2PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(108, 66)
        Me.Guna2PictureBox1.TabIndex = 10
        Me.Guna2PictureBox1.TabStop = False
        '
        'IconButton3
        '
        Me.IconButton3.FlatAppearance.BorderSize = 0
        Me.IconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton3.IconChar = FontAwesome.Sharp.IconChar.Minus
        Me.IconButton3.IconColor = System.Drawing.Color.Black
        Me.IconButton3.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton3.IconSize = 13
        Me.IconButton3.Location = New System.Drawing.Point(1685, 0)
        Me.IconButton3.Margin = New System.Windows.Forms.Padding(4)
        Me.IconButton3.Name = "IconButton3"
        Me.IconButton3.Size = New System.Drawing.Size(57, 36)
        Me.IconButton3.TabIndex = 7
        Me.IconButton3.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.FlatAppearance.BorderSize = 0
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.IconChar = FontAwesome.Sharp.IconChar.X
        Me.btnExit.IconColor = System.Drawing.Color.Black
        Me.btnExit.IconFont = FontAwesome.Sharp.IconFont.Solid
        Me.btnExit.IconSize = 15
        Me.btnExit.Location = New System.Drawing.Point(1743, 0)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(57, 36)
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
        Me.btnHistory.Location = New System.Drawing.Point(976, 17)
        Me.btnHistory.Margin = New System.Windows.Forms.Padding(4)
        Me.btnHistory.Name = "btnHistory"
        Me.btnHistory.ShadowDecoration.BorderRadius = 15
        Me.btnHistory.ShadowDecoration.Enabled = True
        Me.btnHistory.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(3)
        Me.btnHistory.Size = New System.Drawing.Size(143, 42)
        Me.btnHistory.TabIndex = 4
        Me.btnHistory.Text = "History"
        '
        'btnChecklist
        '
        Me.btnChecklist.BackColor = System.Drawing.Color.Transparent
        Me.btnChecklist.BorderRadius = 15
        Me.btnChecklist.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnChecklist.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnChecklist.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnChecklist.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnChecklist.FillColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.btnChecklist.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChecklist.ForeColor = System.Drawing.Color.Black
        Me.btnChecklist.Location = New System.Drawing.Point(768, 17)
        Me.btnChecklist.Margin = New System.Windows.Forms.Padding(4)
        Me.btnChecklist.Name = "btnChecklist"
        Me.btnChecklist.ShadowDecoration.BorderRadius = 15
        Me.btnChecklist.ShadowDecoration.Enabled = True
        Me.btnChecklist.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(3)
        Me.btnChecklist.Size = New System.Drawing.Size(143, 42)
        Me.btnChecklist.TabIndex = 3
        Me.btnChecklist.Text = "Checklist"
        '
        'pbProfile
        '
        Me.pbProfile.ImageRotate = 0!
        Me.pbProfile.Location = New System.Drawing.Point(1475, 9)
        Me.pbProfile.Margin = New System.Windows.Forms.Padding(4)
        Me.pbProfile.Name = "pbProfile"
        Me.pbProfile.ShadowDecoration.Enabled = True
        Me.pbProfile.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.pbProfile.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(2)
        Me.pbProfile.Size = New System.Drawing.Size(67, 62)
        Me.pbProfile.TabIndex = 0
        Me.pbProfile.TabStop = False
        '
        'pnlDisplay
        '
        Me.pnlDisplay.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlDisplay.Location = New System.Drawing.Point(0, 91)
        Me.pnlDisplay.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlDisplay.Name = "pnlDisplay"
        Me.pnlDisplay.Size = New System.Drawing.Size(1800, 894)
        Me.pnlDisplay.TabIndex = 2
        '
        'cmsProfile
        '
        Me.cmsProfile.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.cmsProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.cmsProfile.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmsProfile.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cmsProfile.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogoutToolStripMenuItem})
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
        Me.cmsProfile.Size = New System.Drawing.Size(147, 32)
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(146, 28)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'deptInterface
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1800, 985)
        Me.Controls.Add(Me.pnlDisplay)
        Me.Controls.Add(Me.Guna2ShadowPanel1)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "deptInterface"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Guna2ShadowPanel1.ResumeLayout(False)
        Me.Guna2ShadowPanel1.PerformLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbProfile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmsProfile.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnExit As FontAwesome.Sharp.IconButton
    Friend WithEvents btnDashBoard As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2ShadowPanel1 As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents IconButton3 As FontAwesome.Sharp.IconButton
    Friend WithEvents btnHistory As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents pbProfile As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents pnlDisplay As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnChecklist As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents cmsProfile As Guna.UI2.WinForms.Guna2ContextMenuStrip
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents lblDept As Label
    Friend WithEvents lblID As Label
End Class

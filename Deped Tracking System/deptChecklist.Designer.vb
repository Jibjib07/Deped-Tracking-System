<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class deptChecklist
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
        Me.txtSearch = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Separator1 = New Guna.UI2.WinForms.Guna2Separator()
        Me.btnCreate = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.flpPending = New System.Windows.Forms.FlowLayoutPanel()
        Me.flpChecklist = New System.Windows.Forms.FlowLayoutPanel()
        Me.Guna2CustomGradientPanel2 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.btnReceiveAll = New Guna.UI2.WinForms.Guna2Button()
        Me.btnRefresh = New FontAwesome.Sharp.IconButton()
        Me.chkSelect = New System.Windows.Forms.CheckBox()
        Me.IconPictureBox1 = New FontAwesome.Sharp.IconPictureBox()
        Me.cmbSort = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.btnSendAll = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel1.SuspendLayout()
        Me.Guna2CustomGradientPanel2.SuspendLayout()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtSearch
        '
        Me.txtSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.txtSearch.BorderColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.txtSearch.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.txtSearch.BorderThickness = 0
        Me.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSearch.DefaultText = "Name / Control Number"
        Me.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSearch.FillColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSearch.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSearch.Location = New System.Drawing.Point(32, 28)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.PlaceholderText = ""
        Me.txtSearch.SelectedText = ""
        Me.txtSearch.Size = New System.Drawing.Size(213, 33)
        Me.txtSearch.TabIndex = 1
        '
        'Guna2Separator1
        '
        Me.Guna2Separator1.Location = New System.Drawing.Point(32, 57)
        Me.Guna2Separator1.Name = "Guna2Separator1"
        Me.Guna2Separator1.Size = New System.Drawing.Size(240, 10)
        Me.Guna2Separator1.TabIndex = 2
        '
        'btnCreate
        '
        Me.btnCreate.BackColor = System.Drawing.Color.Transparent
        Me.btnCreate.BorderRadius = 15
        Me.btnCreate.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnCreate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnCreate.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnCreate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnCreate.FillColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.btnCreate.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreate.ForeColor = System.Drawing.Color.Black
        Me.btnCreate.Location = New System.Drawing.Point(763, 872)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.ShadowDecoration.BorderRadius = 15
        Me.btnCreate.ShadowDecoration.Enabled = True
        Me.btnCreate.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(3)
        Me.btnCreate.Size = New System.Drawing.Size(135, 51)
        Me.btnCreate.TabIndex = 4
        Me.btnCreate.Text = "Create New"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.Guna2Panel1.Controls.Add(Me.btnReceiveAll)
        Me.Guna2Panel1.Controls.Add(Me.flpPending)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Guna2Panel1.Location = New System.Drawing.Point(932, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Enabled = True
        Me.Guna2Panel1.Size = New System.Drawing.Size(418, 962)
        Me.Guna2Panel1.TabIndex = 6
        '
        'flpPending
        '
        Me.flpPending.AutoScroll = True
        Me.flpPending.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.flpPending.Location = New System.Drawing.Point(13, 57)
        Me.flpPending.Name = "flpPending"
        Me.flpPending.Size = New System.Drawing.Size(393, 796)
        Me.flpPending.TabIndex = 2
        Me.flpPending.WrapContents = False
        '
        'flpChecklist
        '
        Me.flpChecklist.AutoScroll = True
        Me.flpChecklist.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.flpChecklist.Location = New System.Drawing.Point(12, 150)
        Me.flpChecklist.Name = "flpChecklist"
        Me.flpChecklist.Size = New System.Drawing.Size(906, 703)
        Me.flpChecklist.TabIndex = 4
        Me.flpChecklist.WrapContents = False
        '
        'Guna2CustomGradientPanel2
        '
        Me.Guna2CustomGradientPanel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2CustomGradientPanel2.BorderRadius = 15
        Me.Guna2CustomGradientPanel2.Controls.Add(Me.btnSendAll)
        Me.Guna2CustomGradientPanel2.Controls.Add(Me.cmbSort)
        Me.Guna2CustomGradientPanel2.Controls.Add(Me.btnRefresh)
        Me.Guna2CustomGradientPanel2.Controls.Add(Me.chkSelect)
        Me.Guna2CustomGradientPanel2.FillColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Guna2CustomGradientPanel2.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Guna2CustomGradientPanel2.FillColor3 = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Guna2CustomGradientPanel2.FillColor4 = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Guna2CustomGradientPanel2.Location = New System.Drawing.Point(12, 88)
        Me.Guna2CustomGradientPanel2.Name = "Guna2CustomGradientPanel2"
        Me.Guna2CustomGradientPanel2.ShadowDecoration.BorderRadius = 20
        Me.Guna2CustomGradientPanel2.ShadowDecoration.Depth = 4
        Me.Guna2CustomGradientPanel2.ShadowDecoration.Enabled = True
        Me.Guna2CustomGradientPanel2.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(10)
        Me.Guna2CustomGradientPanel2.Size = New System.Drawing.Size(906, 47)
        Me.Guna2CustomGradientPanel2.TabIndex = 65
        '
        'btnReceiveAll
        '
        Me.btnReceiveAll.BorderRadius = 20
        Me.btnReceiveAll.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnReceiveAll.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnReceiveAll.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnReceiveAll.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnReceiveAll.FillColor = System.Drawing.Color.Transparent
        Me.btnReceiveAll.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReceiveAll.ForeColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnReceiveAll.Location = New System.Drawing.Point(295, 12)
        Me.btnReceiveAll.Name = "btnReceiveAll"
        Me.btnReceiveAll.Size = New System.Drawing.Size(111, 40)
        Me.btnReceiveAll.TabIndex = 20
        Me.btnReceiveAll.Text = "Receive All"
        '
        'btnRefresh
        '
        Me.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefresh.ForeColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.btnRefresh.IconChar = FontAwesome.Sharp.IconChar.Repeat
        Me.btnRefresh.IconColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnRefresh.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnRefresh.IconSize = 20
        Me.btnRefresh.Location = New System.Drawing.Point(65, 9)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(31, 28)
        Me.btnRefresh.TabIndex = 19
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'chkSelect
        '
        Me.chkSelect.AutoSize = True
        Me.chkSelect.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSelect.Location = New System.Drawing.Point(31, 17)
        Me.chkSelect.Name = "chkSelect"
        Me.chkSelect.Size = New System.Drawing.Size(15, 14)
        Me.chkSelect.TabIndex = 18
        Me.chkSelect.UseVisualStyleBackColor = True
        '
        'IconPictureBox1
        '
        Me.IconPictureBox1.BackColor = System.Drawing.SystemColors.Control
        Me.IconPictureBox1.ForeColor = System.Drawing.Color.Gray
        Me.IconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass
        Me.IconPictureBox1.IconColor = System.Drawing.Color.Gray
        Me.IconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconPictureBox1.IconSize = 21
        Me.IconPictureBox1.Location = New System.Drawing.Point(251, 37)
        Me.IconPictureBox1.Name = "IconPictureBox1"
        Me.IconPictureBox1.Size = New System.Drawing.Size(21, 24)
        Me.IconPictureBox1.TabIndex = 3
        Me.IconPictureBox1.TabStop = False
        '
        'cmbSort
        '
        Me.cmbSort.BackColor = System.Drawing.Color.Transparent
        Me.cmbSort.BorderThickness = 0
        Me.cmbSort.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSort.FillColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.cmbSort.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbSort.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbSort.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSort.ForeColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.cmbSort.ItemHeight = 30
        Me.cmbSort.Items.AddRange(New Object() {"Sort By", "Title (A-Z)", "Title (Z-A)", "Date (Newest)", "Date (Oldest)", "Client (A-Z)", "Client (Z-A)"})
        Me.cmbSort.Location = New System.Drawing.Point(109, 6)
        Me.cmbSort.Name = "cmbSort"
        Me.cmbSort.Size = New System.Drawing.Size(151, 36)
        Me.cmbSort.TabIndex = 21
        '
        'btnSendAll
        '
        Me.btnSendAll.BorderRadius = 20
        Me.btnSendAll.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSendAll.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSendAll.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSendAll.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSendAll.FillColor = System.Drawing.Color.Transparent
        Me.btnSendAll.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSendAll.ForeColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnSendAll.Location = New System.Drawing.Point(814, 3)
        Me.btnSendAll.Name = "btnSendAll"
        Me.btnSendAll.Size = New System.Drawing.Size(89, 40)
        Me.btnSendAll.TabIndex = 21
        Me.btnSendAll.Text = "Send All"
        Me.btnSendAll.Visible = False
        '
        'deptChecklist
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1350, 962)
        Me.Controls.Add(Me.Guna2CustomGradientPanel2)
        Me.Controls.Add(Me.flpChecklist)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.btnCreate)
        Me.Controls.Add(Me.IconPictureBox1)
        Me.Controls.Add(Me.Guna2Separator1)
        Me.Controls.Add(Me.txtSearch)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "deptChecklist"
        Me.Text = "deptChecklist"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2CustomGradientPanel2.ResumeLayout(False)
        Me.Guna2CustomGradientPanel2.PerformLayout()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtSearch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Separator1 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents btnCreate As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents flpChecklist As FlowLayoutPanel
    Friend WithEvents flpPending As FlowLayoutPanel
    Friend WithEvents Guna2CustomGradientPanel2 As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents btnRefresh As FontAwesome.Sharp.IconButton
    Friend WithEvents chkSelect As CheckBox
    Friend WithEvents btnReceiveAll As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents IconPictureBox1 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents cmbSort As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents btnSendAll As Guna.UI2.WinForms.Guna2Button
End Class

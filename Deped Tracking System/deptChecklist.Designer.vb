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
        Me.flpChecklist = New System.Windows.Forms.FlowLayoutPanel()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnReceiveAll = New Guna.UI2.WinForms.Guna2Button()
        Me.flpPending = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnSendAll = New Guna.UI2.WinForms.Guna2Button()
        Me.cmbSort = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.btnRefresh = New FontAwesome.Sharp.IconButton()
        Me.chkSelect = New System.Windows.Forms.CheckBox()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnCreate = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel1.SuspendLayout()
        Me.Guna2Panel2.SuspendLayout()
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
        Me.txtSearch.Location = New System.Drawing.Point(43, 34)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(5)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.PlaceholderText = ""
        Me.txtSearch.SelectedText = ""
        Me.txtSearch.Size = New System.Drawing.Size(475, 41)
        Me.txtSearch.TabIndex = 1
        '
        'Guna2Separator1
        '
        Me.Guna2Separator1.Location = New System.Drawing.Point(43, 70)
        Me.Guna2Separator1.Margin = New System.Windows.Forms.Padding(4)
        Me.Guna2Separator1.Name = "Guna2Separator1"
        Me.Guna2Separator1.Size = New System.Drawing.Size(475, 12)
        Me.Guna2Separator1.TabIndex = 2
        '
        'flpChecklist
        '
        Me.flpChecklist.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.flpChecklist.AutoScroll = True
        Me.flpChecklist.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.flpChecklist.Location = New System.Drawing.Point(16, 177)
        Me.flpChecklist.Margin = New System.Windows.Forms.Padding(4)
        Me.flpChecklist.Name = "flpChecklist"
        Me.flpChecklist.Size = New System.Drawing.Size(1208, 605)
        Me.flpChecklist.TabIndex = 4
        Me.flpChecklist.WrapContents = False
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.White
        Me.Guna2Panel1.Controls.Add(Me.btnReceiveAll)
        Me.Guna2Panel1.Controls.Add(Me.flpPending)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Guna2Panel1.Location = New System.Drawing.Point(1247, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(553, 894)
        Me.Guna2Panel1.TabIndex = 66
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
        Me.btnReceiveAll.Location = New System.Drawing.Point(396, 15)
        Me.btnReceiveAll.Margin = New System.Windows.Forms.Padding(4)
        Me.btnReceiveAll.Name = "btnReceiveAll"
        Me.btnReceiveAll.Size = New System.Drawing.Size(148, 49)
        Me.btnReceiveAll.TabIndex = 22
        Me.btnReceiveAll.Text = "Receive All"
        '
        'flpPending
        '
        Me.flpPending.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.flpPending.AutoScroll = True
        Me.flpPending.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.flpPending.Location = New System.Drawing.Point(16, 70)
        Me.flpPending.Margin = New System.Windows.Forms.Padding(4)
        Me.flpPending.Name = "flpPending"
        Me.flpPending.Size = New System.Drawing.Size(524, 712)
        Me.flpPending.TabIndex = 21
        Me.flpPending.WrapContents = False
        '
        'btnSendAll
        '
        Me.btnSendAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSendAll.BackColor = System.Drawing.Color.Transparent
        Me.btnSendAll.BorderRadius = 20
        Me.btnSendAll.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSendAll.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSendAll.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSendAll.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSendAll.FillColor = System.Drawing.Color.Transparent
        Me.btnSendAll.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSendAll.ForeColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnSendAll.Location = New System.Drawing.Point(1064, 7)
        Me.btnSendAll.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSendAll.Name = "btnSendAll"
        Me.btnSendAll.Size = New System.Drawing.Size(119, 34)
        Me.btnSendAll.TabIndex = 24
        Me.btnSendAll.Text = "Send All"
        Me.btnSendAll.Visible = False
        '
        'cmbSort
        '
        Me.cmbSort.BackColor = System.Drawing.Color.Transparent
        Me.cmbSort.BorderColor = System.Drawing.SystemColors.ActiveBorder
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
        Me.cmbSort.Location = New System.Drawing.Point(119, 9)
        Me.cmbSort.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbSort.Name = "cmbSort"
        Me.cmbSort.Size = New System.Drawing.Size(230, 36)
        Me.cmbSort.TabIndex = 25
        '
        'btnRefresh
        '
        Me.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefresh.ForeColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.btnRefresh.IconChar = FontAwesome.Sharp.IconChar.Repeat
        Me.btnRefresh.IconColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnRefresh.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnRefresh.IconSize = 20
        Me.btnRefresh.Location = New System.Drawing.Point(59, 9)
        Me.btnRefresh.Margin = New System.Windows.Forms.Padding(4)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(41, 34)
        Me.btnRefresh.TabIndex = 23
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'chkSelect
        '
        Me.chkSelect.AutoSize = True
        Me.chkSelect.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSelect.Location = New System.Drawing.Point(24, 17)
        Me.chkSelect.Margin = New System.Windows.Forms.Padding(4)
        Me.chkSelect.Name = "chkSelect"
        Me.chkSelect.Size = New System.Drawing.Size(18, 17)
        Me.chkSelect.TabIndex = 22
        Me.chkSelect.UseVisualStyleBackColor = True
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.Guna2Panel2.BorderRadius = 20
        Me.Guna2Panel2.BorderThickness = 1
        Me.Guna2Panel2.Controls.Add(Me.cmbSort)
        Me.Guna2Panel2.Controls.Add(Me.chkSelect)
        Me.Guna2Panel2.Controls.Add(Me.btnRefresh)
        Me.Guna2Panel2.Controls.Add(Me.btnSendAll)
        Me.Guna2Panel2.Location = New System.Drawing.Point(16, 101)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(1191, 55)
        Me.Guna2Panel2.TabIndex = 0
        '
        'btnCreate
        '
        Me.btnCreate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCreate.BackColor = System.Drawing.Color.Transparent
        Me.btnCreate.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnCreate.BorderRadius = 15
        Me.btnCreate.BorderThickness = 1
        Me.btnCreate.CustomBorderColor = System.Drawing.Color.White
        Me.btnCreate.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnCreate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnCreate.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnCreate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnCreate.FillColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.btnCreate.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreate.ForeColor = System.Drawing.Color.Black
        Me.btnCreate.Location = New System.Drawing.Point(1034, 811)
        Me.btnCreate.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.ShadowDecoration.BorderRadius = 15
        Me.btnCreate.ShadowDecoration.Enabled = True
        Me.btnCreate.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(3)
        Me.btnCreate.Size = New System.Drawing.Size(190, 58)
        Me.btnCreate.TabIndex = 110
        Me.btnCreate.Text = "Create New"
        '
        'deptChecklist
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1800, 894)
        Me.Controls.Add(Me.btnCreate)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.flpChecklist)
        Me.Controls.Add(Me.Guna2Separator1)
        Me.Controls.Add(Me.txtSearch)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "deptChecklist"
        Me.Text = "deptChecklist"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtSearch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Separator1 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents flpChecklist As FlowLayoutPanel
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnReceiveAll As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents flpPending As FlowLayoutPanel
    Friend WithEvents btnSendAll As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents cmbSort As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents btnRefresh As FontAwesome.Sharp.IconButton
    Friend WithEvents chkSelect As CheckBox
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnCreate As Guna.UI2.WinForms.Guna2Button
End Class

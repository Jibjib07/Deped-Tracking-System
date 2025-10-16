<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class adminUsers
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Guna2Separator1 = New Guna.UI2.WinForms.Guna2Separator()
        Me.txtSearch = New Guna.UI2.WinForms.Guna2TextBox()
        Me.cmbDepartment = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.dgvUsers = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.pbUser = New System.Windows.Forms.PictureBox()
        Me.lblUserID = New System.Windows.Forms.Label()
        Me.Guna2Separator2 = New Guna.UI2.WinForms.Guna2Separator()
        Me.lblName = New System.Windows.Forms.Label()
        Me.Guna2Separator3 = New Guna.UI2.WinForms.Guna2Separator()
        Me.lblDepartment = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.btnRegister = New Guna.UI2.WinForms.Guna2Button()
        Me.btnEdit = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2GradientPanel1 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.btnRefresh = New FontAwesome.Sharp.IconButton()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Separator5 = New Guna.UI2.WinForms.Guna2Separator()
        Me.Guna2Separator4 = New Guna.UI2.WinForms.Guna2Separator()
        Me.btnDeactivate = New Guna.UI2.WinForms.Guna2Button()
        CType(Me.dgvUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2GradientPanel1.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Separator1
        '
        Me.Guna2Separator1.Location = New System.Drawing.Point(64, 89)
        Me.Guna2Separator1.Margin = New System.Windows.Forms.Padding(4)
        Me.Guna2Separator1.Name = "Guna2Separator1"
        Me.Guna2Separator1.Size = New System.Drawing.Size(528, 12)
        Me.Guna2Separator1.TabIndex = 84
        '
        'txtSearch
        '
        Me.txtSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.txtSearch.BorderColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.txtSearch.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.txtSearch.BorderThickness = 0
        Me.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSearch.DefaultText = ""
        Me.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSearch.FillColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSearch.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSearch.Location = New System.Drawing.Point(64, 53)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(5)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.txtSearch.PlaceholderText = "Name / ID"
        Me.txtSearch.SelectedText = ""
        Me.txtSearch.Size = New System.Drawing.Size(528, 41)
        Me.txtSearch.TabIndex = 83
        '
        'cmbDepartment
        '
        Me.cmbDepartment.BackColor = System.Drawing.Color.Transparent
        Me.cmbDepartment.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmbDepartment.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDepartment.FillColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmbDepartment.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbDepartment.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbDepartment.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDepartment.ForeColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.cmbDepartment.ItemHeight = 30
        Me.cmbDepartment.Items.AddRange(New Object() {"Sort By", "Title (A-Z)", "Title (Z-A)", "Date (Newest)", "Date (Oldest)", "Client (A-Z)", "Client (Z-A)"})
        Me.cmbDepartment.Location = New System.Drawing.Point(79, 9)
        Me.cmbDepartment.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbDepartment.Name = "cmbDepartment"
        Me.cmbDepartment.Size = New System.Drawing.Size(518, 36)
        Me.cmbDepartment.TabIndex = 21
        '
        'dgvUsers
        '
        Me.dgvUsers.AllowUserToAddRows = False
        Me.dgvUsers.AllowUserToDeleteRows = False
        Me.dgvUsers.AllowUserToResizeColumns = False
        Me.dgvUsers.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgvUsers.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvUsers.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(34, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(34, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvUsers.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvUsers.ColumnHeadersHeight = 47
        Me.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvUsers.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvUsers.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvUsers.Location = New System.Drawing.Point(35, 204)
        Me.dgvUsers.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvUsers.MultiSelect = False
        Me.dgvUsers.Name = "dgvUsers"
        Me.dgvUsers.ReadOnly = True
        Me.dgvUsers.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvUsers.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvUsers.RowHeadersVisible = False
        Me.dgvUsers.RowHeadersWidth = 51
        Me.dgvUsers.RowTemplate.Height = 45
        Me.dgvUsers.Size = New System.Drawing.Size(985, 665)
        Me.dgvUsers.TabIndex = 88
        Me.dgvUsers.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvUsers.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvUsers.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvUsers.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvUsers.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvUsers.ThemeStyle.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgvUsers.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvUsers.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvUsers.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvUsers.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvUsers.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvUsers.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvUsers.ThemeStyle.HeaderStyle.Height = 47
        Me.dgvUsers.ThemeStyle.ReadOnly = True
        Me.dgvUsers.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvUsers.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvUsers.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvUsers.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgvUsers.ThemeStyle.RowsStyle.Height = 45
        Me.dgvUsers.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvUsers.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'pbUser
        '
        Me.pbUser.BackColor = System.Drawing.SystemColors.Control
        Me.pbUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbUser.ErrorImage = Nothing
        Me.pbUser.InitialImage = Nothing
        Me.pbUser.Location = New System.Drawing.Point(186, 124)
        Me.pbUser.Margin = New System.Windows.Forms.Padding(4)
        Me.pbUser.Name = "pbUser"
        Me.pbUser.Size = New System.Drawing.Size(333, 308)
        Me.pbUser.TabIndex = 99
        Me.pbUser.TabStop = False
        '
        'lblUserID
        '
        Me.lblUserID.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblUserID.BackColor = System.Drawing.Color.Transparent
        Me.lblUserID.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.lblUserID.Location = New System.Drawing.Point(47, 57)
        Me.lblUserID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUserID.Name = "lblUserID"
        Me.lblUserID.Size = New System.Drawing.Size(620, 59)
        Me.lblUserID.TabIndex = 101
        Me.lblUserID.Text = "USER ID"
        Me.lblUserID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Guna2Separator2
        '
        Me.Guna2Separator2.Location = New System.Drawing.Point(52, 104)
        Me.Guna2Separator2.Margin = New System.Windows.Forms.Padding(4)
        Me.Guna2Separator2.Name = "Guna2Separator2"
        Me.Guna2Separator2.Size = New System.Drawing.Size(615, 12)
        Me.Guna2Separator2.TabIndex = 88
        '
        'lblName
        '
        Me.lblName.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblName.BackColor = System.Drawing.Color.White
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.lblName.Location = New System.Drawing.Point(56, 436)
        Me.lblName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(615, 58)
        Me.lblName.TabIndex = 103
        Me.lblName.Text = "NAME"
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Guna2Separator3
        '
        Me.Guna2Separator3.BackColor = System.Drawing.Color.White
        Me.Guna2Separator3.Location = New System.Drawing.Point(61, 482)
        Me.Guna2Separator3.Margin = New System.Windows.Forms.Padding(4)
        Me.Guna2Separator3.Name = "Guna2Separator3"
        Me.Guna2Separator3.Size = New System.Drawing.Size(615, 12)
        Me.Guna2Separator3.TabIndex = 102
        '
        'lblDepartment
        '
        Me.lblDepartment.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDepartment.BackColor = System.Drawing.Color.White
        Me.lblDepartment.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDepartment.ForeColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.lblDepartment.Location = New System.Drawing.Point(56, 498)
        Me.lblDepartment.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDepartment.Name = "lblDepartment"
        Me.lblDepartment.Size = New System.Drawing.Size(620, 74)
        Me.lblDepartment.TabIndex = 105
        Me.lblDepartment.Text = "DEPARTMENT"
        Me.lblDepartment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblEmail
        '
        Me.lblEmail.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblEmail.BackColor = System.Drawing.Color.White
        Me.lblEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.lblEmail.Location = New System.Drawing.Point(70, 586)
        Me.lblEmail.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(597, 59)
        Me.lblEmail.TabIndex = 107
        Me.lblEmail.Text = "EMAIL"
        Me.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnRegister
        '
        Me.btnRegister.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRegister.BackColor = System.Drawing.Color.Transparent
        Me.btnRegister.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnRegister.BorderRadius = 15
        Me.btnRegister.BorderThickness = 1
        Me.btnRegister.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnRegister.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnRegister.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnRegister.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnRegister.FillColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnRegister.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegister.ForeColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.btnRegister.Location = New System.Drawing.Point(481, 781)
        Me.btnRegister.Margin = New System.Windows.Forms.Padding(4)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.ShadowDecoration.BorderRadius = 15
        Me.btnRegister.ShadowDecoration.Enabled = True
        Me.btnRegister.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(3)
        Me.btnRegister.Size = New System.Drawing.Size(195, 70)
        Me.btnRegister.TabIndex = 108
        Me.btnRegister.Text = "Register"
        '
        'btnEdit
        '
        Me.btnEdit.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEdit.BackColor = System.Drawing.Color.Transparent
        Me.btnEdit.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnEdit.BorderRadius = 15
        Me.btnEdit.BorderThickness = 1
        Me.btnEdit.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnEdit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnEdit.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnEdit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnEdit.FillColor = System.Drawing.Color.White
        Me.btnEdit.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnEdit.Location = New System.Drawing.Point(282, 781)
        Me.btnEdit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.ShadowDecoration.BorderRadius = 15
        Me.btnEdit.ShadowDecoration.Enabled = True
        Me.btnEdit.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(3)
        Me.btnEdit.Size = New System.Drawing.Size(156, 70)
        Me.btnEdit.TabIndex = 109
        Me.btnEdit.Text = "Edit"
        '
        'Guna2GradientPanel1
        '
        Me.Guna2GradientPanel1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Guna2GradientPanel1.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.Guna2GradientPanel1.BorderRadius = 3
        Me.Guna2GradientPanel1.BorderThickness = 1
        Me.Guna2GradientPanel1.Controls.Add(Me.cmbDepartment)
        Me.Guna2GradientPanel1.Controls.Add(Me.btnRefresh)
        Me.Guna2GradientPanel1.Location = New System.Drawing.Point(35, 126)
        Me.Guna2GradientPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Guna2GradientPanel1.Name = "Guna2GradientPanel1"
        Me.Guna2GradientPanel1.Size = New System.Drawing.Size(985, 55)
        Me.Guna2GradientPanel1.TabIndex = 112
        '
        'btnRefresh
        '
        Me.btnRefresh.BackColor = System.Drawing.Color.Transparent
        Me.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefresh.ForeColor = System.Drawing.Color.White
        Me.btnRefresh.IconChar = FontAwesome.Sharp.IconChar.Repeat
        Me.btnRefresh.IconColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnRefresh.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnRefresh.IconSize = 20
        Me.btnRefresh.Location = New System.Drawing.Point(16, 9)
        Me.btnRefresh.Margin = New System.Windows.Forms.Padding(4)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(42, 36)
        Me.btnRefresh.TabIndex = 19
        Me.btnRefresh.UseVisualStyleBackColor = False
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Guna2Panel1.Controls.Add(Me.btnDeactivate)
        Me.Guna2Panel1.Controls.Add(Me.pbUser)
        Me.Guna2Panel1.Controls.Add(Me.btnEdit)
        Me.Guna2Panel1.Controls.Add(Me.Guna2Separator2)
        Me.Guna2Panel1.Controls.Add(Me.Guna2Separator5)
        Me.Guna2Panel1.Controls.Add(Me.btnRegister)
        Me.Guna2Panel1.Controls.Add(Me.lblEmail)
        Me.Guna2Panel1.Controls.Add(Me.lblUserID)
        Me.Guna2Panel1.Controls.Add(Me.Guna2Separator4)
        Me.Guna2Panel1.Controls.Add(Me.Guna2Separator3)
        Me.Guna2Panel1.Controls.Add(Me.lblDepartment)
        Me.Guna2Panel1.Controls.Add(Me.lblName)
        Me.Guna2Panel1.CustomBorderColor = System.Drawing.Color.Transparent
        Me.Guna2Panel1.CustomizableEdges.BottomLeft = False
        Me.Guna2Panel1.CustomizableEdges.BottomRight = False
        Me.Guna2Panel1.CustomizableEdges.TopLeft = False
        Me.Guna2Panel1.CustomizableEdges.TopRight = False
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Guna2Panel1.Location = New System.Drawing.Point(1073, 0)
        Me.Guna2Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Guna2Panel1.Size = New System.Drawing.Size(727, 894)
        Me.Guna2Panel1.TabIndex = 113
        '
        'Guna2Separator5
        '
        Me.Guna2Separator5.BackColor = System.Drawing.Color.White
        Me.Guna2Separator5.Location = New System.Drawing.Point(74, 633)
        Me.Guna2Separator5.Margin = New System.Windows.Forms.Padding(4)
        Me.Guna2Separator5.Name = "Guna2Separator5"
        Me.Guna2Separator5.Size = New System.Drawing.Size(602, 12)
        Me.Guna2Separator5.TabIndex = 106
        '
        'Guna2Separator4
        '
        Me.Guna2Separator4.BackColor = System.Drawing.Color.White
        Me.Guna2Separator4.Location = New System.Drawing.Point(74, 560)
        Me.Guna2Separator4.Margin = New System.Windows.Forms.Padding(4)
        Me.Guna2Separator4.Name = "Guna2Separator4"
        Me.Guna2Separator4.Size = New System.Drawing.Size(602, 12)
        Me.Guna2Separator4.TabIndex = 104
        '
        'btnDeactivate
        '
        Me.btnDeactivate.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDeactivate.BackColor = System.Drawing.Color.Transparent
        Me.btnDeactivate.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnDeactivate.BorderRadius = 15
        Me.btnDeactivate.BorderThickness = 1
        Me.btnDeactivate.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnDeactivate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnDeactivate.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnDeactivate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnDeactivate.FillColor = System.Drawing.Color.White
        Me.btnDeactivate.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeactivate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnDeactivate.Location = New System.Drawing.Point(74, 781)
        Me.btnDeactivate.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDeactivate.Name = "btnDeactivate"
        Me.btnDeactivate.ShadowDecoration.BorderRadius = 15
        Me.btnDeactivate.ShadowDecoration.Enabled = True
        Me.btnDeactivate.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(3)
        Me.btnDeactivate.Size = New System.Drawing.Size(156, 70)
        Me.btnDeactivate.TabIndex = 110
        Me.btnDeactivate.Text = "Deactivate"
        '
        'adminUsers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1800, 894)
        Me.Controls.Add(Me.Guna2GradientPanel1)
        Me.Controls.Add(Me.Guna2Separator1)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.dgvUsers)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "adminUsers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "adminUsers"
        CType(Me.dgvUsers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2GradientPanel1.ResumeLayout(False)
        Me.Guna2Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Guna2Separator1 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents txtSearch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnRefresh As FontAwesome.Sharp.IconButton
    Friend WithEvents dgvUsers As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents cmbDepartment As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents pbUser As PictureBox
    Friend WithEvents lblUserID As Label
    Friend WithEvents Guna2Separator2 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents lblName As Label
    Friend WithEvents Guna2Separator3 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents lblDepartment As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents btnRegister As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnEdit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2GradientPanel1 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Separator5 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents Guna2Separator4 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents btnDeactivate As Guna.UI2.WinForms.Guna2Button
End Class

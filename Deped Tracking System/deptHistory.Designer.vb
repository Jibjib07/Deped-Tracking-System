<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class deptHistory
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
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvRecords = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Guna2Separator1 = New Guna.UI2.WinForms.Guna2Separator()
        Me.txtSearch = New Guna.UI2.WinForms.Guna2TextBox()
        Me.cmbSort = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cmbARTA = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.btnRefresh = New FontAwesome.Sharp.IconButton()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblControlNum = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbltype = New System.Windows.Forms.Label()
        Me.txtDescription = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Panel4 = New Guna.UI2.WinForms.Guna2Panel()
        Me.dgvHistory = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblContactNum = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.Guna2Panel5 = New Guna.UI2.WinForms.Guna2Panel()
        CType(Me.dgvRecords, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel1.SuspendLayout()
        Me.Guna2Panel3.SuspendLayout()
        Me.Guna2Panel4.SuspendLayout()
        CType(Me.dgvHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel2.SuspendLayout()
        Me.Guna2Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvRecords
        '
        Me.dgvRecords.AllowUserToAddRows = False
        Me.dgvRecords.AllowUserToDeleteRows = False
        Me.dgvRecords.AllowUserToResizeColumns = False
        Me.dgvRecords.AllowUserToResizeRows = False
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgvRecords.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle9
        Me.dgvRecords.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer))
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(34, Byte), Integer))
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(34, Byte), Integer))
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvRecords.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.dgvRecords.ColumnHeadersHeight = 47
        Me.dgvRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer))
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(34, Byte), Integer))
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvRecords.DefaultCellStyle = DataGridViewCellStyle11
        Me.dgvRecords.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvRecords.Location = New System.Drawing.Point(16, 192)
        Me.dgvRecords.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvRecords.MultiSelect = False
        Me.dgvRecords.Name = "dgvRecords"
        Me.dgvRecords.ReadOnly = True
        Me.dgvRecords.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer))
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer))
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvRecords.RowHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.dgvRecords.RowHeadersVisible = False
        Me.dgvRecords.RowHeadersWidth = 51
        Me.dgvRecords.RowTemplate.Height = 45
        Me.dgvRecords.Size = New System.Drawing.Size(928, 656)
        Me.dgvRecords.TabIndex = 79
        Me.dgvRecords.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvRecords.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvRecords.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvRecords.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvRecords.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvRecords.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.dgvRecords.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvRecords.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvRecords.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvRecords.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvRecords.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvRecords.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvRecords.ThemeStyle.HeaderStyle.Height = 47
        Me.dgvRecords.ThemeStyle.ReadOnly = True
        Me.dgvRecords.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvRecords.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvRecords.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvRecords.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgvRecords.ThemeStyle.RowsStyle.Height = 45
        Me.dgvRecords.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvRecords.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Guna2Separator1
        '
        Me.Guna2Separator1.Location = New System.Drawing.Point(43, 70)
        Me.Guna2Separator1.Margin = New System.Windows.Forms.Padding(4)
        Me.Guna2Separator1.Name = "Guna2Separator1"
        Me.Guna2Separator1.Size = New System.Drawing.Size(429, 12)
        Me.Guna2Separator1.TabIndex = 81
        '
        'txtSearch
        '
        Me.txtSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.txtSearch.BorderColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.txtSearch.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.txtSearch.BorderThickness = 0
        Me.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSearch.DefaultText = "Search..."
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
        Me.txtSearch.Size = New System.Drawing.Size(429, 41)
        Me.txtSearch.TabIndex = 80
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
        Me.cmbSort.Location = New System.Drawing.Point(80, 10)
        Me.cmbSort.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbSort.Name = "cmbSort"
        Me.cmbSort.Size = New System.Drawing.Size(200, 36)
        Me.cmbSort.TabIndex = 23
        '
        'cmbARTA
        '
        Me.cmbARTA.BackColor = System.Drawing.Color.Transparent
        Me.cmbARTA.BorderThickness = 0
        Me.cmbARTA.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbARTA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbARTA.FillColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.cmbARTA.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbARTA.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbARTA.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbARTA.ForeColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.cmbARTA.ItemHeight = 30
        Me.cmbARTA.Items.AddRange(New Object() {"Type of Transaction"})
        Me.cmbARTA.Location = New System.Drawing.Point(701, 10)
        Me.cmbARTA.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbARTA.Name = "cmbARTA"
        Me.cmbARTA.Size = New System.Drawing.Size(200, 36)
        Me.cmbARTA.TabIndex = 22
        '
        'btnRefresh
        '
        Me.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefresh.ForeColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.btnRefresh.IconChar = FontAwesome.Sharp.IconChar.Repeat
        Me.btnRefresh.IconColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnRefresh.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnRefresh.IconSize = 20
        Me.btnRefresh.Location = New System.Drawing.Point(16, 10)
        Me.btnRefresh.Margin = New System.Windows.Forms.Padding(4)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(41, 34)
        Me.btnRefresh.TabIndex = 19
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Guna2Panel1.Controls.Add(Me.Guna2Panel3)
        Me.Guna2Panel1.Controls.Add(Me.Guna2Panel4)
        Me.Guna2Panel1.Controls.Add(Me.Guna2Panel2)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Guna2Panel1.Location = New System.Drawing.Point(972, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(828, 894)
        Me.Guna2Panel1.TabIndex = 115
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Guna2Panel3.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.Guna2Panel3.BorderThickness = 1
        Me.Guna2Panel3.Controls.Add(Me.Label2)
        Me.Guna2Panel3.Controls.Add(Me.lblControlNum)
        Me.Guna2Panel3.Controls.Add(Me.lblDate)
        Me.Guna2Panel3.Controls.Add(Me.lblTitle)
        Me.Guna2Panel3.Controls.Add(Me.lblStatus)
        Me.Guna2Panel3.Controls.Add(Me.Label1)
        Me.Guna2Panel3.Controls.Add(Me.lbltype)
        Me.Guna2Panel3.Controls.Add(Me.txtDescription)
        Me.Guna2Panel3.Location = New System.Drawing.Point(28, 24)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.Size = New System.Drawing.Size(778, 291)
        Me.Guna2Panel3.TabIndex = 107
        '
        'Label2
        '
        Me.Label2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(10, 10)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(754, 41)
        Me.Label2.TabIndex = 98
        Me.Label2.Text = "Transaction Details"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblControlNum
        '
        Me.lblControlNum.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblControlNum.AutoSize = True
        Me.lblControlNum.BackColor = System.Drawing.Color.Transparent
        Me.lblControlNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblControlNum.ForeColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.lblControlNum.Location = New System.Drawing.Point(10, 63)
        Me.lblControlNum.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblControlNum.Name = "lblControlNum"
        Me.lblControlNum.Size = New System.Drawing.Size(164, 24)
        Me.lblControlNum.TabIndex = 93
        Me.lblControlNum.Text = "Control Number:"
        Me.lblControlNum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDate
        '
        Me.lblDate.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDate.AutoSize = True
        Me.lblDate.BackColor = System.Drawing.Color.Transparent
        Me.lblDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.lblDate.Location = New System.Drawing.Point(10, 115)
        Me.lblDate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(137, 24)
        Me.lblDate.TabIndex = 95
        Me.lblDate.Text = "Date Created:"
        Me.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTitle
        '
        Me.lblTitle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(10, 89)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(164, 24)
        Me.lblTitle.TabIndex = 99
        Me.lblTitle.Text = "Document Type:"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblStatus
        '
        Me.lblStatus.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblStatus.AutoSize = True
        Me.lblStatus.BackColor = System.Drawing.Color.Transparent
        Me.lblStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.lblStatus.Location = New System.Drawing.Point(472, 63)
        Me.lblStatus.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(72, 24)
        Me.lblStatus.TabIndex = 100
        Me.lblStatus.Text = "Status:"
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(10, 168)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 25)
        Me.Label1.TabIndex = 102
        Me.Label1.Text = "Description:"
        '
        'lbltype
        '
        Me.lbltype.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbltype.AutoSize = True
        Me.lbltype.BackColor = System.Drawing.Color.Transparent
        Me.lbltype.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltype.ForeColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.lbltype.Location = New System.Drawing.Point(11, 142)
        Me.lbltype.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbltype.Name = "lbltype"
        Me.lbltype.Size = New System.Drawing.Size(178, 24)
        Me.lbltype.TabIndex = 105
        Me.lbltype.Text = "Transaction Type:"
        '
        'txtDescription
        '
        Me.txtDescription.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDescription.DefaultText = ""
        Me.txtDescription.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtDescription.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtDescription.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtDescription.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtDescription.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescription.ForeColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.txtDescription.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDescription.Location = New System.Drawing.Point(14, 206)
        Me.txtDescription.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.txtDescription.PlaceholderText = ""
        Me.txtDescription.ReadOnly = True
        Me.txtDescription.SelectedText = ""
        Me.txtDescription.Size = New System.Drawing.Size(747, 67)
        Me.txtDescription.TabIndex = 103
        '
        'Guna2Panel4
        '
        Me.Guna2Panel4.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Guna2Panel4.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.Guna2Panel4.BorderThickness = 1
        Me.Guna2Panel4.Controls.Add(Me.dgvHistory)
        Me.Guna2Panel4.Controls.Add(Me.Label3)
        Me.Guna2Panel4.Location = New System.Drawing.Point(28, 497)
        Me.Guna2Panel4.Name = "Guna2Panel4"
        Me.Guna2Panel4.Size = New System.Drawing.Size(778, 351)
        Me.Guna2Panel4.TabIndex = 108
        '
        'dgvHistory
        '
        Me.dgvHistory.AllowUserToAddRows = False
        Me.dgvHistory.AllowUserToDeleteRows = False
        Me.dgvHistory.AllowUserToResizeColumns = False
        Me.dgvHistory.AllowUserToResizeRows = False
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgvHistory.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle13
        Me.dgvHistory.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer))
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(34, Byte), Integer))
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Century Gothic", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(34, Byte), Integer))
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvHistory.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle14
        Me.dgvHistory.ColumnHeadersHeight = 47
        Me.dgvHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer))
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(34, Byte), Integer))
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvHistory.DefaultCellStyle = DataGridViewCellStyle15
        Me.dgvHistory.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvHistory.Location = New System.Drawing.Point(15, 61)
        Me.dgvHistory.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvHistory.MultiSelect = False
        Me.dgvHistory.Name = "dgvHistory"
        Me.dgvHistory.ReadOnly = True
        Me.dgvHistory.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer))
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer))
        DataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvHistory.RowHeadersDefaultCellStyle = DataGridViewCellStyle16
        Me.dgvHistory.RowHeadersVisible = False
        Me.dgvHistory.RowHeadersWidth = 51
        Me.dgvHistory.RowTemplate.Height = 45
        Me.dgvHistory.Size = New System.Drawing.Size(747, 267)
        Me.dgvHistory.TabIndex = 80
        Me.dgvHistory.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvHistory.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvHistory.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvHistory.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvHistory.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvHistory.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.dgvHistory.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvHistory.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvHistory.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvHistory.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvHistory.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvHistory.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvHistory.ThemeStyle.HeaderStyle.Height = 47
        Me.dgvHistory.ThemeStyle.ReadOnly = True
        Me.dgvHistory.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvHistory.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvHistory.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvHistory.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgvHistory.ThemeStyle.RowsStyle.Height = 45
        Me.dgvHistory.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvHistory.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Label3
        '
        Me.Label3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(10, 10)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(754, 47)
        Me.Label3.TabIndex = 87
        Me.Label3.Text = "Timeline"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Guna2Panel2.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.Guna2Panel2.BorderThickness = 1
        Me.Guna2Panel2.Controls.Add(Me.Label7)
        Me.Guna2Panel2.Controls.Add(Me.lblName)
        Me.Guna2Panel2.Controls.Add(Me.lblContactNum)
        Me.Guna2Panel2.Controls.Add(Me.lblEmail)
        Me.Guna2Panel2.Location = New System.Drawing.Point(28, 330)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(778, 144)
        Me.Guna2Panel2.TabIndex = 106
        '
        'Label7
        '
        Me.Label7.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(10, 10)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(754, 36)
        Me.Label7.TabIndex = 97
        Me.Label7.Text = "Client Details"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblName
        '
        Me.lblName.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblName.AutoSize = True
        Me.lblName.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.lblName.Location = New System.Drawing.Point(6, 51)
        Me.lblName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(71, 24)
        Me.lblName.TabIndex = 94
        Me.lblName.Text = "Name:"
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblContactNum
        '
        Me.lblContactNum.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblContactNum.AutoSize = True
        Me.lblContactNum.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblContactNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContactNum.ForeColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.lblContactNum.Location = New System.Drawing.Point(6, 77)
        Me.lblContactNum.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblContactNum.Name = "lblContactNum"
        Me.lblContactNum.Size = New System.Drawing.Size(167, 24)
        Me.lblContactNum.TabIndex = 101
        Me.lblContactNum.Text = "Contact Number:"
        Me.lblContactNum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblEmail
        '
        Me.lblEmail.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblEmail.AutoSize = True
        Me.lblEmail.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.lblEmail.Location = New System.Drawing.Point(6, 103)
        Me.lblEmail.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(68, 24)
        Me.lblEmail.TabIndex = 96
        Me.lblEmail.Text = "Email:"
        Me.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Guna2Panel5
        '
        Me.Guna2Panel5.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.Guna2Panel5.BorderRadius = 20
        Me.Guna2Panel5.BorderThickness = 1
        Me.Guna2Panel5.Controls.Add(Me.btnRefresh)
        Me.Guna2Panel5.Controls.Add(Me.cmbSort)
        Me.Guna2Panel5.Controls.Add(Me.cmbARTA)
        Me.Guna2Panel5.Location = New System.Drawing.Point(16, 105)
        Me.Guna2Panel5.Name = "Guna2Panel5"
        Me.Guna2Panel5.Size = New System.Drawing.Size(928, 58)
        Me.Guna2Panel5.TabIndex = 116
        '
        'deptHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1800, 894)
        Me.Controls.Add(Me.Guna2Panel5)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.Guna2Separator1)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.dgvRecords)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "deptHistory"
        Me.Text = "deptHistory"
        CType(Me.dgvRecords, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel3.ResumeLayout(False)
        Me.Guna2Panel3.PerformLayout()
        Me.Guna2Panel4.ResumeLayout(False)
        CType(Me.dgvHistory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel2.PerformLayout()
        Me.Guna2Panel5.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvRecords As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Guna2Separator1 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents txtSearch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnRefresh As FontAwesome.Sharp.IconButton
    Friend WithEvents Guna2DataGridViewStyler1 As Guna.UI2.WinForms.Guna2DataGridViewStyler
    Friend WithEvents cmbARTA As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents cmbSort As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents lblControlNum As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lbltype As Label
    Friend WithEvents txtDescription As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Panel4 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents dgvHistory As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblContactNum As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents Guna2Panel5 As Guna.UI2.WinForms.Guna2Panel
End Class

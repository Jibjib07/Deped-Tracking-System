<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adminDept
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvDept = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnRemove = New Guna.UI2.WinForms.Guna2Button()
        Me.btnAdd = New Guna.UI2.WinForms.Guna2Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnCancel = New Guna.UI2.WinForms.Guna2Button()
        Me.btnSave = New Guna.UI2.WinForms.Guna2Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Guna2Separator1 = New Guna.UI2.WinForms.Guna2Separator()
        Me.Guna2Separator2 = New Guna.UI2.WinForms.Guna2Separator()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtAbbre = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        CType(Me.dgvDept, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel1.SuspendLayout()
        Me.Guna2Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvDept
        '
        Me.dgvDept.AllowUserToAddRows = False
        Me.dgvDept.AllowUserToDeleteRows = False
        Me.dgvDept.AllowUserToResizeColumns = False
        Me.dgvDept.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgvDept.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvDept.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(34, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(34, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDept.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvDept.ColumnHeadersHeight = 47
        Me.dgvDept.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvDept.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvDept.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvDept.Location = New System.Drawing.Point(28, 81)
        Me.dgvDept.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvDept.MultiSelect = False
        Me.dgvDept.Name = "dgvDept"
        Me.dgvDept.ReadOnly = True
        Me.dgvDept.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDept.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvDept.RowHeadersVisible = False
        Me.dgvDept.RowHeadersWidth = 51
        Me.dgvDept.RowTemplate.Height = 45
        Me.dgvDept.Size = New System.Drawing.Size(1140, 679)
        Me.dgvDept.TabIndex = 89
        Me.dgvDept.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvDept.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvDept.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvDept.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvDept.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvDept.ThemeStyle.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgvDept.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvDept.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvDept.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvDept.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvDept.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvDept.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvDept.ThemeStyle.HeaderStyle.Height = 47
        Me.dgvDept.ThemeStyle.ReadOnly = True
        Me.dgvDept.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvDept.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvDept.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvDept.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgvDept.ThemeStyle.RowsStyle.Height = 45
        Me.dgvDept.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvDept.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(23, 32)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(168, 29)
        Me.Label3.TabIndex = 90
        Me.Label3.Text = "Departments:"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BorderColor = System.Drawing.Color.DimGray
        Me.Guna2Panel1.Controls.Add(Me.btnRemove)
        Me.Guna2Panel1.Controls.Add(Me.btnAdd)
        Me.Guna2Panel1.Controls.Add(Me.Label1)
        Me.Guna2Panel1.Controls.Add(Me.dgvDept)
        Me.Guna2Panel1.Controls.Add(Me.Guna2Panel2)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(1800, 894)
        Me.Guna2Panel1.TabIndex = 0
        '
        'btnRemove
        '
        Me.btnRemove.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRemove.BackColor = System.Drawing.Color.Transparent
        Me.btnRemove.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnRemove.BorderRadius = 15
        Me.btnRemove.BorderThickness = 1
        Me.btnRemove.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnRemove.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnRemove.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnRemove.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnRemove.FillColor = System.Drawing.Color.White
        Me.btnRemove.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemove.ForeColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnRemove.Location = New System.Drawing.Point(683, 783)
        Me.btnRemove.Margin = New System.Windows.Forms.Padding(4)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.ShadowDecoration.BorderRadius = 15
        Me.btnRemove.ShadowDecoration.Enabled = True
        Me.btnRemove.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(3)
        Me.btnRemove.Size = New System.Drawing.Size(206, 69)
        Me.btnRemove.TabIndex = 124
        Me.btnRemove.Text = "Remove Department"
        '
        'btnAdd
        '
        Me.btnAdd.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAdd.BackColor = System.Drawing.Color.Transparent
        Me.btnAdd.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnAdd.BorderRadius = 15
        Me.btnAdd.BorderThickness = 1
        Me.btnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAdd.FillColor = System.Drawing.Color.White
        Me.btnAdd.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnAdd.Location = New System.Drawing.Point(936, 783)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.ShadowDecoration.BorderRadius = 15
        Me.btnAdd.ShadowDecoration.Enabled = True
        Me.btnAdd.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(3)
        Me.btnAdd.Size = New System.Drawing.Size(232, 69)
        Me.btnAdd.TabIndex = 125
        Me.btnAdd.Text = "Add Department"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(1211, 89)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(225, 30)
        Me.Label1.TabIndex = 116
        Me.Label1.Text = "Edit Department:"
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Guna2Panel2.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.Guna2Panel2.BorderThickness = 1
        Me.Guna2Panel2.Controls.Add(Me.btnCancel)
        Me.Guna2Panel2.Controls.Add(Me.btnSave)
        Me.Guna2Panel2.Controls.Add(Me.Label4)
        Me.Guna2Panel2.Controls.Add(Me.Guna2Separator1)
        Me.Guna2Panel2.Controls.Add(Me.Guna2Separator2)
        Me.Guna2Panel2.Controls.Add(Me.Label2)
        Me.Guna2Panel2.Controls.Add(Me.txtAbbre)
        Me.Guna2Panel2.Controls.Add(Me.txtName)
        Me.Guna2Panel2.Location = New System.Drawing.Point(1197, 81)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(572, 679)
        Me.Guna2Panel2.TabIndex = 0
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.BackColor = System.Drawing.Color.Transparent
        Me.btnCancel.BorderRadius = 15
        Me.btnCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnCancel.FillColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnCancel.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.btnCancel.Location = New System.Drawing.Point(259, 591)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.ShadowDecoration.BorderRadius = 15
        Me.btnCancel.ShadowDecoration.Enabled = True
        Me.btnCancel.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(3)
        Me.btnCancel.Size = New System.Drawing.Size(133, 67)
        Me.btnCancel.TabIndex = 124
        Me.btnCancel.Text = "Cancel"
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.BackColor = System.Drawing.Color.Transparent
        Me.btnSave.BorderRadius = 15
        Me.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSave.FillColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnSave.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.btnSave.Location = New System.Drawing.Point(422, 591)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.ShadowDecoration.BorderRadius = 15
        Me.btnSave.ShadowDecoration.Enabled = True
        Me.btnSave.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(3)
        Me.btnSave.Size = New System.Drawing.Size(133, 67)
        Me.btnSave.TabIndex = 123
        Me.btnSave.Text = "Save"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(14, 207)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(225, 30)
        Me.Label4.TabIndex = 121
        Me.Label4.Text = "Abbreviation:"
        '
        'Guna2Separator1
        '
        Me.Guna2Separator1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Guna2Separator1.Location = New System.Drawing.Point(19, 175)
        Me.Guna2Separator1.Margin = New System.Windows.Forms.Padding(4)
        Me.Guna2Separator1.Name = "Guna2Separator1"
        Me.Guna2Separator1.Size = New System.Drawing.Size(536, 12)
        Me.Guna2Separator1.TabIndex = 117
        '
        'Guna2Separator2
        '
        Me.Guna2Separator2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Guna2Separator2.Location = New System.Drawing.Point(19, 290)
        Me.Guna2Separator2.Margin = New System.Windows.Forms.Padding(4)
        Me.Guna2Separator2.Name = "Guna2Separator2"
        Me.Guna2Separator2.Size = New System.Drawing.Size(536, 12)
        Me.Guna2Separator2.TabIndex = 119
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 92)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(225, 30)
        Me.Label2.TabIndex = 120
        Me.Label2.Text = "Name:"
        '
        'txtAbbre
        '
        Me.txtAbbre.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtAbbre.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAbbre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.txtAbbre.Location = New System.Drawing.Point(19, 241)
        Me.txtAbbre.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAbbre.Name = "txtAbbre"
        Me.txtAbbre.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtAbbre.Size = New System.Drawing.Size(536, 41)
        Me.txtAbbre.TabIndex = 118
        '
        'txtName
        '
        Me.txtName.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.txtName.Location = New System.Drawing.Point(19, 126)
        Me.txtName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtName.Name = "txtName"
        Me.txtName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtName.Size = New System.Drawing.Size(536, 41)
        Me.txtName.TabIndex = 115
        '
        'adminDept
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1800, 894)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "adminDept"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "adminDept"
        CType(Me.dgvDept, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvDept As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2Separator1 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Guna2Separator2 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents txtAbbre As TextBox
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnSave As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnAdd As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnRemove As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnCancel As Guna.UI2.WinForms.Guna2Button
End Class

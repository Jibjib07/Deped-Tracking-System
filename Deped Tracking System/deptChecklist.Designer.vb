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
        Me.IconPictureBox1 = New FontAwesome.Sharp.IconPictureBox()
        Me.btnCreate = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.flpPending = New System.Windows.Forms.FlowLayoutPanel()
        Me.flpChecklist = New System.Windows.Forms.FlowLayoutPanel()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel1.SuspendLayout()
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
        Me.Guna2Panel1.Controls.Add(Me.flpPending)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Guna2Panel1.Location = New System.Drawing.Point(932, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Enabled = True
        Me.Guna2Panel1.Size = New System.Drawing.Size(418, 788)
        Me.Guna2Panel1.TabIndex = 6
        '
        'flpPending
        '
        Me.flpPending.AutoScroll = True
        Me.flpPending.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.flpPending.Location = New System.Drawing.Point(13, 12)
        Me.flpPending.Name = "flpPending"
        Me.flpPending.Size = New System.Drawing.Size(393, 841)
        Me.flpPending.TabIndex = 2
        Me.flpPending.WrapContents = False
        '
        'flpChecklist
        '
        Me.flpChecklist.AutoScroll = True
        Me.flpChecklist.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.flpChecklist.Location = New System.Drawing.Point(12, 110)
        Me.flpChecklist.Name = "flpChecklist"
        Me.flpChecklist.Size = New System.Drawing.Size(906, 743)
        Me.flpChecklist.TabIndex = 4
        Me.flpChecklist.WrapContents = False
        '
        'deptChecklist
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1350, 788)
        Me.Controls.Add(Me.flpChecklist)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.btnCreate)
        Me.Controls.Add(Me.IconPictureBox1)
        Me.Controls.Add(Me.Guna2Separator1)
        Me.Controls.Add(Me.txtSearch)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "deptChecklist"
        Me.Text = "deptChecklist"
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtSearch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Separator1 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents IconPictureBox1 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents btnCreate As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents flpChecklist As FlowLayoutPanel
    Friend WithEvents flpPending As FlowLayoutPanel
End Class

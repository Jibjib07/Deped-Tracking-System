<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.Guna2ShadowPanel1 = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.btnExit = New FontAwesome.Sharp.IconButton()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnShow = New FontAwesome.Sharp.IconButton()
        Me.lblerror = New System.Windows.Forms.Label()
        Me.txtPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Separator2 = New Guna.UI2.WinForms.Guna2Separator()
        Me.txtUserID = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Separator1 = New Guna.UI2.WinForms.Guna2Separator()
        Me.Guna2Panel4 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnLogin = New Guna.UI2.WinForms.Guna2Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Guna2ShadowPanel1.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        Me.Guna2Panel4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2ShadowPanel1
        '
        Me.Guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ShadowPanel1.Controls.Add(Me.btnExit)
        Me.Guna2ShadowPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2ShadowPanel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Guna2ShadowPanel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2ShadowPanel1.Name = "Guna2ShadowPanel1"
        Me.Guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black
        Me.Guna2ShadowPanel1.ShadowDepth = 50
        Me.Guna2ShadowPanel1.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.Dropped
        Me.Guna2ShadowPanel1.Size = New System.Drawing.Size(1350, 62)
        Me.Guna2ShadowPanel1.TabIndex = 1
        '
        'btnExit
        '
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
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
        'Guna2Panel1
        '
        Me.Guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Guna2Panel1.BorderRadius = 20
        Me.Guna2Panel1.BorderThickness = 1
        Me.Guna2Panel1.Controls.Add(Me.btnShow)
        Me.Guna2Panel1.Controls.Add(Me.lblerror)
        Me.Guna2Panel1.Controls.Add(Me.txtPassword)
        Me.Guna2Panel1.Controls.Add(Me.Guna2Separator2)
        Me.Guna2Panel1.Controls.Add(Me.txtUserID)
        Me.Guna2Panel1.Controls.Add(Me.Guna2Separator1)
        Me.Guna2Panel1.Controls.Add(Me.Guna2Panel4)
        Me.Guna2Panel1.Controls.Add(Me.btnLogin)
        Me.Guna2Panel1.Location = New System.Drawing.Point(411, 161)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(573, 393)
        Me.Guna2Panel1.TabIndex = 2
        '
        'btnShow
        '
        Me.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnShow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.btnShow.IconChar = FontAwesome.Sharp.IconChar.EyeSlash
        Me.btnShow.IconColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnShow.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnShow.IconSize = 30
        Me.btnShow.Location = New System.Drawing.Point(484, 218)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(43, 35)
        Me.btnShow.TabIndex = 87
        Me.btnShow.UseVisualStyleBackColor = True
        '
        'lblerror
        '
        Me.lblerror.AutoSize = True
        Me.lblerror.Font = New System.Drawing.Font("Inter", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblerror.ForeColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.lblerror.Location = New System.Drawing.Point(53, 165)
        Me.lblerror.Name = "lblerror"
        Me.lblerror.Size = New System.Drawing.Size(20, 17)
        Me.lblerror.TabIndex = 86
        Me.lblerror.Text = "__"
        Me.lblerror.Visible = False
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.txtPassword.BorderColor = System.Drawing.Color.LightGray
        Me.txtPassword.BorderThickness = 0
        Me.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPassword.DefaultText = "Password"
        Me.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPassword.FillColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPassword.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPassword.IconLeft = CType(resources.GetObject("txtPassword.IconLeft"), System.Drawing.Image)
        Me.txtPassword.IconLeftSize = New System.Drawing.Size(21, 21)
        Me.txtPassword.Location = New System.Drawing.Point(56, 205)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(5)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PlaceholderForeColor = System.Drawing.Color.Black
        Me.txtPassword.PlaceholderText = ""
        Me.txtPassword.SelectedText = ""
        Me.txtPassword.Size = New System.Drawing.Size(420, 50)
        Me.txtPassword.TabIndex = 77
        Me.txtPassword.TextOffset = New System.Drawing.Point(2, 0)
        '
        'Guna2Separator2
        '
        Me.Guna2Separator2.Location = New System.Drawing.Point(55, 250)
        Me.Guna2Separator2.Name = "Guna2Separator2"
        Me.Guna2Separator2.Size = New System.Drawing.Size(421, 10)
        Me.Guna2Separator2.TabIndex = 85
        '
        'txtUserID
        '
        Me.txtUserID.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.txtUserID.BorderColor = System.Drawing.Color.Transparent
        Me.txtUserID.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.txtUserID.BorderThickness = 0
        Me.txtUserID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUserID.DefaultText = "User ID"
        Me.txtUserID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtUserID.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtUserID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtUserID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtUserID.FillColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.txtUserID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtUserID.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserID.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtUserID.IconLeft = CType(resources.GetObject("txtUserID.IconLeft"), System.Drawing.Image)
        Me.txtUserID.IconLeftOffset = New System.Drawing.Point(0, 1)
        Me.txtUserID.IconLeftSize = New System.Drawing.Size(24, 24)
        Me.txtUserID.Location = New System.Drawing.Point(56, 110)
        Me.txtUserID.Margin = New System.Windows.Forms.Padding(5)
        Me.txtUserID.Name = "txtUserID"
        Me.txtUserID.PlaceholderForeColor = System.Drawing.Color.Black
        Me.txtUserID.PlaceholderText = ""
        Me.txtUserID.SelectedText = ""
        Me.txtUserID.Size = New System.Drawing.Size(460, 50)
        Me.txtUserID.TabIndex = 78
        Me.txtUserID.TextOffset = New System.Drawing.Point(2, 0)
        '
        'Guna2Separator1
        '
        Me.Guna2Separator1.Location = New System.Drawing.Point(56, 158)
        Me.Guna2Separator1.Name = "Guna2Separator1"
        Me.Guna2Separator1.Size = New System.Drawing.Size(461, 10)
        Me.Guna2Separator1.TabIndex = 84
        '
        'Guna2Panel4
        '
        Me.Guna2Panel4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel4.Controls.Add(Me.Label1)
        Me.Guna2Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel4.FillColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Guna2Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel4.Name = "Guna2Panel4"
        Me.Guna2Panel4.Size = New System.Drawing.Size(573, 67)
        Me.Guna2Panel4.TabIndex = 83
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Inter ExtraBold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(218, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(141, 35)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "User Login"
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.Transparent
        Me.btnLogin.BorderRadius = 15
        Me.btnLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnLogin.FillColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnLogin.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.Color.White
        Me.btnLogin.Location = New System.Drawing.Point(95, 304)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.ShadowDecoration.BorderRadius = 15
        Me.btnLogin.ShadowDecoration.Enabled = True
        Me.btnLogin.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(3)
        Me.btnLogin.Size = New System.Drawing.Size(381, 60)
        Me.btnLogin.TabIndex = 78
        Me.btnLogin.Text = "LOGIN"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(1120, 542)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(146, 138)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1008, 657)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1350, 788)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.Guna2ShadowPanel1)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Login"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.Guna2ShadowPanel1.ResumeLayout(False)
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.Guna2Panel4.ResumeLayout(False)
        Me.Guna2Panel4.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2ShadowPanel1 As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents btnExit As FontAwesome.Sharp.IconButton
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents txtPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnLogin As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtUserID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Panel4 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Separator1 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents Guna2Separator2 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents Label1 As Label
    Friend WithEvents lblerror As Label
    Friend WithEvents btnShow As FontAwesome.Sharp.IconButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
End Class

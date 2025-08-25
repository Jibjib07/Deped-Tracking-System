<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class deptDashboard
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
        Me.Guna2CustomGradientPanel1 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Guna2CustomGradientPanel2 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblReceived = New System.Windows.Forms.Label()
        Me.Guna2CustomGradientPanel3 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblPending = New System.Windows.Forms.Label()
        Me.Guna2CustomGradientPanel4 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblCompleted = New System.Windows.Forms.Label()
        Me.Guna2CircleProgressBar1 = New Guna.UI2.WinForms.Guna2CircleProgressBar()
        Me.Guna2CustomGradientPanel1.SuspendLayout()
        Me.Guna2CustomGradientPanel2.SuspendLayout()
        Me.Guna2CustomGradientPanel3.SuspendLayout()
        Me.Guna2CustomGradientPanel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2CustomGradientPanel1
        '
        Me.Guna2CustomGradientPanel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2CustomGradientPanel1.BorderRadius = 30
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.Label2)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.Label1)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.lblTotal)
        Me.Guna2CustomGradientPanel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Guna2CustomGradientPanel1.Location = New System.Drawing.Point(68, 125)
        Me.Guna2CustomGradientPanel1.Name = "Guna2CustomGradientPanel1"
        Me.Guna2CustomGradientPanel1.ShadowDecoration.BorderRadius = 40
        Me.Guna2CustomGradientPanel1.ShadowDecoration.Depth = 4
        Me.Guna2CustomGradientPanel1.ShadowDecoration.Enabled = True
        Me.Guna2CustomGradientPanel1.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(10)
        Me.Guna2CustomGradientPanel1.Size = New System.Drawing.Size(341, 273)
        Me.Guna2CustomGradientPanel1.TabIndex = 63
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(41, 201)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Transactions"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(41, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 33)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Active"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.lblTotal.Location = New System.Drawing.Point(23, 64)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(99, 108)
        Me.lblTotal.TabIndex = 0
        Me.lblTotal.Text = "0"
        '
        'Guna2CustomGradientPanel2
        '
        Me.Guna2CustomGradientPanel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2CustomGradientPanel2.BorderRadius = 30
        Me.Guna2CustomGradientPanel2.Controls.Add(Me.Label5)
        Me.Guna2CustomGradientPanel2.Controls.Add(Me.Label4)
        Me.Guna2CustomGradientPanel2.Controls.Add(Me.lblReceived)
        Me.Guna2CustomGradientPanel2.FillColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Guna2CustomGradientPanel2.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Guna2CustomGradientPanel2.FillColor3 = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Guna2CustomGradientPanel2.FillColor4 = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Guna2CustomGradientPanel2.Location = New System.Drawing.Point(485, 125)
        Me.Guna2CustomGradientPanel2.Name = "Guna2CustomGradientPanel2"
        Me.Guna2CustomGradientPanel2.ShadowDecoration.BorderRadius = 40
        Me.Guna2CustomGradientPanel2.ShadowDecoration.Depth = 4
        Me.Guna2CustomGradientPanel2.ShadowDecoration.Enabled = True
        Me.Guna2CustomGradientPanel2.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(10)
        Me.Guna2CustomGradientPanel2.Size = New System.Drawing.Size(341, 273)
        Me.Guna2CustomGradientPanel2.TabIndex = 64
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(41, 201)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(137, 25)
        Me.Label5.TabIndex = 66
        Me.Label5.Text = "Transactions"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(39, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(145, 33)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Received"
        '
        'lblReceived
        '
        Me.lblReceived.AutoSize = True
        Me.lblReceived.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblReceived.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReceived.ForeColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.lblReceived.Location = New System.Drawing.Point(23, 64)
        Me.lblReceived.Name = "lblReceived"
        Me.lblReceived.Size = New System.Drawing.Size(99, 108)
        Me.lblReceived.TabIndex = 66
        Me.lblReceived.Text = "0"
        '
        'Guna2CustomGradientPanel3
        '
        Me.Guna2CustomGradientPanel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2CustomGradientPanel3.BorderRadius = 30
        Me.Guna2CustomGradientPanel3.Controls.Add(Me.Label6)
        Me.Guna2CustomGradientPanel3.Controls.Add(Me.Label7)
        Me.Guna2CustomGradientPanel3.Controls.Add(Me.lblPending)
        Me.Guna2CustomGradientPanel3.FillColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Guna2CustomGradientPanel3.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Guna2CustomGradientPanel3.FillColor3 = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Guna2CustomGradientPanel3.FillColor4 = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Guna2CustomGradientPanel3.Location = New System.Drawing.Point(906, 125)
        Me.Guna2CustomGradientPanel3.Name = "Guna2CustomGradientPanel3"
        Me.Guna2CustomGradientPanel3.ShadowDecoration.BorderRadius = 40
        Me.Guna2CustomGradientPanel3.ShadowDecoration.Depth = 4
        Me.Guna2CustomGradientPanel3.ShadowDecoration.Enabled = True
        Me.Guna2CustomGradientPanel3.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(10)
        Me.Guna2CustomGradientPanel3.Size = New System.Drawing.Size(341, 273)
        Me.Guna2CustomGradientPanel3.TabIndex = 65
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(41, 201)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(137, 25)
        Me.Label6.TabIndex = 66
        Me.Label6.Text = "Transactions"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(39, 23)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(128, 33)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Pending"
        '
        'lblPending
        '
        Me.lblPending.AutoSize = True
        Me.lblPending.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblPending.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPending.ForeColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.lblPending.Location = New System.Drawing.Point(23, 64)
        Me.lblPending.Name = "lblPending"
        Me.lblPending.Size = New System.Drawing.Size(99, 108)
        Me.lblPending.TabIndex = 66
        Me.lblPending.Text = "0"
        '
        'Guna2CustomGradientPanel4
        '
        Me.Guna2CustomGradientPanel4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2CustomGradientPanel4.BorderRadius = 30
        Me.Guna2CustomGradientPanel4.Controls.Add(Me.Label9)
        Me.Guna2CustomGradientPanel4.Controls.Add(Me.Label10)
        Me.Guna2CustomGradientPanel4.Controls.Add(Me.lblCompleted)
        Me.Guna2CustomGradientPanel4.FillColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Guna2CustomGradientPanel4.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Guna2CustomGradientPanel4.FillColor3 = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Guna2CustomGradientPanel4.FillColor4 = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Guna2CustomGradientPanel4.Location = New System.Drawing.Point(906, 469)
        Me.Guna2CustomGradientPanel4.Name = "Guna2CustomGradientPanel4"
        Me.Guna2CustomGradientPanel4.ShadowDecoration.BorderRadius = 40
        Me.Guna2CustomGradientPanel4.ShadowDecoration.Depth = 4
        Me.Guna2CustomGradientPanel4.ShadowDecoration.Enabled = True
        Me.Guna2CustomGradientPanel4.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(10)
        Me.Guna2CustomGradientPanel4.Size = New System.Drawing.Size(341, 273)
        Me.Guna2CustomGradientPanel4.TabIndex = 66
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(41, 201)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(137, 25)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Transactions"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(41, 27)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(165, 33)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Completed"
        '
        'lblCompleted
        '
        Me.lblCompleted.AutoSize = True
        Me.lblCompleted.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblCompleted.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompleted.ForeColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.lblCompleted.Location = New System.Drawing.Point(23, 64)
        Me.lblCompleted.Name = "lblCompleted"
        Me.lblCompleted.Size = New System.Drawing.Size(99, 108)
        Me.lblCompleted.TabIndex = 0
        Me.lblCompleted.Text = "0"
        '
        'Guna2CircleProgressBar1
        '
        Me.Guna2CircleProgressBar1.FillColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.Guna2CircleProgressBar1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Guna2CircleProgressBar1.ForeColor = System.Drawing.Color.White
        Me.Guna2CircleProgressBar1.Location = New System.Drawing.Point(273, 453)
        Me.Guna2CircleProgressBar1.Minimum = 0
        Me.Guna2CircleProgressBar1.Name = "Guna2CircleProgressBar1"
        Me.Guna2CircleProgressBar1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CircleProgressBar1.Size = New System.Drawing.Size(315, 315)
        Me.Guna2CircleProgressBar1.TabIndex = 67
        Me.Guna2CircleProgressBar1.Text = "Guna2CircleProgressBar1"
        Me.Guna2CircleProgressBar1.TextMode = Guna.UI2.WinForms.Enums.ProgressBarTextMode.Value
        '
        'deptDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1350, 962)
        Me.Controls.Add(Me.Guna2CircleProgressBar1)
        Me.Controls.Add(Me.Guna2CustomGradientPanel4)
        Me.Controls.Add(Me.Guna2CustomGradientPanel3)
        Me.Controls.Add(Me.Guna2CustomGradientPanel2)
        Me.Controls.Add(Me.Guna2CustomGradientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "deptDashboard"
        Me.Text = "deptDashboard"
        Me.Guna2CustomGradientPanel1.ResumeLayout(False)
        Me.Guna2CustomGradientPanel1.PerformLayout()
        Me.Guna2CustomGradientPanel2.ResumeLayout(False)
        Me.Guna2CustomGradientPanel2.PerformLayout()
        Me.Guna2CustomGradientPanel3.ResumeLayout(False)
        Me.Guna2CustomGradientPanel3.PerformLayout()
        Me.Guna2CustomGradientPanel4.ResumeLayout(False)
        Me.Guna2CustomGradientPanel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2CustomGradientPanel1 As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents Guna2CustomGradientPanel2 As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents lblTotal As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblReceived As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Guna2CustomGradientPanel3 As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblPending As Label
    Friend WithEvents Guna2CustomGradientPanel4 As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lblCompleted As Label
    Friend WithEvents Guna2CircleProgressBar1 As Guna.UI2.WinForms.Guna2CircleProgressBar
End Class

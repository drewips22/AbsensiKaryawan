Namespace Forms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class LoginForm
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
            panel = New Panel()
            btnLogin = New Button()
            txtPassword = New TextBox()
            lblPass = New Label()
            txtUsername = New TextBox()
            lblUser = New Label()
            lblTitle = New Label()
            panel.SuspendLayout()
            SuspendLayout()
            ' 
            ' panel
            ' 
            panel.Anchor = AnchorStyles.None
            panel.BackColor = Color.White
            panel.Controls.Add(btnLogin)
            panel.Controls.Add(txtPassword)
            panel.Controls.Add(lblPass)
            panel.Controls.Add(txtUsername)
            panel.Controls.Add(lblUser)
            panel.Controls.Add(lblTitle)
            panel.Location = New Point(41, 48)
            panel.Margin = New Padding(4, 5, 4, 5)
            panel.Name = "panel"
            panel.Padding = New Padding(27, 31, 27, 31)
            panel.Size = New Size(427, 585)
            panel.TabIndex = 0
            ' 
            ' btnLogin
            ' 
            btnLogin.BackColor = Color.White
            btnLogin.FlatAppearance.BorderSize = 0
            btnLogin.FlatStyle = FlatStyle.Flat
            btnLogin.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
            btnLogin.ForeColor = Color.FromArgb(CByte(0), CByte(122), CByte(204))
            btnLogin.Location = New Point(31, 446)
            btnLogin.Margin = New Padding(4, 5, 4, 5)
            btnLogin.Name = "btnLogin"
            btnLogin.Size = New Size(365, 77)
            btnLogin.TabIndex = 5
            btnLogin.Text = "LOGIN"
            btnLogin.UseVisualStyleBackColor = False
            ' 
            ' txtPassword
            ' 
            txtPassword.Font = New Font("Segoe UI", 10F)
            txtPassword.Location = New Point(31, 338)
            txtPassword.Margin = New Padding(4, 5, 4, 5)
            txtPassword.Name = "txtPassword"
            txtPassword.PasswordChar = "*"c
            txtPassword.Size = New Size(364, 30)
            txtPassword.TabIndex = 4
            ' 
            ' lblPass
            ' 
            lblPass.AutoSize = True
            lblPass.Font = New Font("Segoe UI", 10F)
            lblPass.Location = New Point(31, 300)
            lblPass.Margin = New Padding(4, 0, 4, 0)
            lblPass.Name = "lblPass"
            lblPass.Size = New Size(80, 23)
            lblPass.TabIndex = 3
            lblPass.Text = "Password"
            ' 
            ' txtUsername
            ' 
            txtUsername.Font = New Font("Segoe UI", 10F)
            txtUsername.Location = New Point(31, 223)
            txtUsername.Margin = New Padding(4, 5, 4, 5)
            txtUsername.Name = "txtUsername"
            txtUsername.Size = New Size(364, 30)
            txtUsername.TabIndex = 2
            ' 
            ' lblUser
            ' 
            lblUser.AutoSize = True
            lblUser.Font = New Font("Segoe UI", 10F)
            lblUser.Location = New Point(31, 185)
            lblUser.Margin = New Padding(4, 0, 4, 0)
            lblUser.Name = "lblUser"
            lblUser.Size = New Size(87, 23)
            lblUser.TabIndex = 1
            lblUser.Text = "Username"
            ' 
            ' lblTitle
            ' 
            lblTitle.Dock = DockStyle.Top
            lblTitle.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
            lblTitle.ForeColor = Color.FromArgb(CByte(0), CByte(122), CByte(204))
            lblTitle.Location = New Point(27, 31)
            lblTitle.Margin = New Padding(4, 0, 4, 0)
            lblTitle.Name = "lblTitle"
            lblTitle.Size = New Size(373, 92)
            lblTitle.TabIndex = 0
            lblTitle.Text = "LOGIN"
            lblTitle.TextAlign = ContentAlignment.MiddleCenter
            ' 
            ' LoginForm
            ' 
            AutoScaleDimensions = New SizeF(8F, 20F)
            AutoScaleMode = AutoScaleMode.Font
            BackColor = Color.WhiteSmoke
            ClientSize = New Size(509, 697)
            Controls.Add(panel)
            FormBorderStyle = FormBorderStyle.FixedDialog
            Margin = New Padding(4, 5, 4, 5)
            MaximizeBox = False
            Name = "LoginForm"
            StartPosition = FormStartPosition.CenterScreen
            Text = "Login Absensi"
            panel.ResumeLayout(False)
            panel.PerformLayout()
            ResumeLayout(False)

        End Sub

        Friend WithEvents panel As System.Windows.Forms.Panel
        Friend WithEvents lblTitle As System.Windows.Forms.Label
        Friend WithEvents lblUser As System.Windows.Forms.Label
        Friend WithEvents txtUsername As System.Windows.Forms.TextBox
        Friend WithEvents lblPass As System.Windows.Forms.Label
        Friend WithEvents txtPassword As System.Windows.Forms.TextBox
        Friend WithEvents btnLogin As System.Windows.Forms.Button
    End Class
End Namespace

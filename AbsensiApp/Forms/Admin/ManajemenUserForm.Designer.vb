Namespace Forms.Admin
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class ManajemenUserForm
        Inherits System.Windows.Forms.Form

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

        Private components As System.ComponentModel.IContainer

        <System.Diagnostics.DebuggerStepThrough()> _
        Private Sub InitializeComponent()
            Me.dgvUser = New System.Windows.Forms.DataGridView()
            Me.lblUsername = New System.Windows.Forms.Label()
            Me.txtUsername = New System.Windows.Forms.TextBox()
            Me.lblPassword = New System.Windows.Forms.Label()
            Me.txtPassword = New System.Windows.Forms.TextBox()
            Me.lblRole = New System.Windows.Forms.Label()
            Me.cmbRole = New System.Windows.Forms.ComboBox()
            Me.lblKaryawan = New System.Windows.Forms.Label()
            Me.cmbKaryawan = New System.Windows.Forms.ComboBox()
            Me.btnSimpan = New System.Windows.Forms.Button()
            Me.btnHapus = New System.Windows.Forms.Button()
            Me.btnReset = New System.Windows.Forms.Button()
            CType(Me.dgvUser, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'dgvUser
            '
            Me.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvUser.Location = New System.Drawing.Point(12, 12)
            Me.dgvUser.Name = "dgvUser"
            Me.dgvUser.RowTemplate.Height = 25
            Me.dgvUser.Size = New System.Drawing.Size(400, 200)
            Me.dgvUser.TabIndex = 0
            '
            'lblUsername
            '
            Me.lblUsername.AutoSize = True
            Me.lblUsername.Location = New System.Drawing.Point(430, 20)
            Me.lblUsername.Name = "lblUsername"
            Me.lblUsername.Size = New System.Drawing.Size(60, 15)
            Me.lblUsername.TabIndex = 1
            Me.lblUsername.Text = "Username"
            '
            'txtUsername
            '
            Me.txtUsername.Location = New System.Drawing.Point(430, 40)
            Me.txtUsername.Name = "txtUsername"
            Me.txtUsername.Size = New System.Drawing.Size(200, 23)
            Me.txtUsername.TabIndex = 2
            '
            'lblPassword
            '
            Me.lblPassword.AutoSize = True
            Me.lblPassword.Location = New System.Drawing.Point(430, 70)
            Me.lblPassword.Name = "lblPassword"
            Me.lblPassword.Size = New System.Drawing.Size(57, 15)
            Me.lblPassword.TabIndex = 3
            Me.lblPassword.Text = "Password"
            '
            'txtPassword
            '
            Me.txtPassword.Location = New System.Drawing.Point(430, 90)
            Me.txtPassword.Name = "txtPassword"
            Me.txtPassword.PasswordChar = "*"c
            Me.txtPassword.Size = New System.Drawing.Size(200, 23)
            Me.txtPassword.TabIndex = 4
            '
            'lblRole
            '
            Me.lblRole.AutoSize = True
            Me.lblRole.Location = New System.Drawing.Point(430, 120)
            Me.lblRole.Name = "lblRole"
            Me.lblRole.Size = New System.Drawing.Size(30, 15)
            Me.lblRole.TabIndex = 5
            Me.lblRole.Text = "Role"
            '
            'cmbRole
            '
            Me.cmbRole.FormattingEnabled = True
            Me.cmbRole.Items.AddRange(New Object() {"Admin", "HR", "Atasan", "Karyawan"})
            Me.cmbRole.Location = New System.Drawing.Point(430, 140)
            Me.cmbRole.Name = "cmbRole"
            Me.cmbRole.Size = New System.Drawing.Size(200, 23)
            Me.cmbRole.TabIndex = 6
            '
            'lblKaryawan
            '
            Me.lblKaryawan.AutoSize = True
            Me.lblKaryawan.Location = New System.Drawing.Point(430, 170)
            Me.lblKaryawan.Name = "lblKaryawan"
            Me.lblKaryawan.Size = New System.Drawing.Size(107, 15)
            Me.lblKaryawan.TabIndex = 7
            Me.lblKaryawan.Text = "Link ke Karyawan"
            '
            'cmbKaryawan
            '
            Me.cmbKaryawan.FormattingEnabled = True
            Me.cmbKaryawan.Location = New System.Drawing.Point(430, 190)
            Me.cmbKaryawan.Name = "cmbKaryawan"
            Me.cmbKaryawan.Size = New System.Drawing.Size(200, 23)
            Me.cmbKaryawan.TabIndex = 8
            '
            'btnSimpan
            '
            Me.btnSimpan.Location = New System.Drawing.Point(430, 230)
            Me.btnSimpan.Name = "btnSimpan"
            Me.btnSimpan.Size = New System.Drawing.Size(75, 23)
            Me.btnSimpan.TabIndex = 9
            Me.btnSimpan.Text = "Simpan"
            Me.btnSimpan.UseVisualStyleBackColor = True
            '
            'btnHapus
            '
            Me.btnHapus.Location = New System.Drawing.Point(511, 230)
            Me.btnHapus.Name = "btnHapus"
            Me.btnHapus.Size = New System.Drawing.Size(75, 23)
            Me.btnHapus.TabIndex = 10
            Me.btnHapus.Text = "Hapus"
            Me.btnHapus.UseVisualStyleBackColor = True
            '
            'btnReset
            '
            Me.btnReset.Location = New System.Drawing.Point(430, 260)
            Me.btnReset.Name = "btnReset"
            Me.btnReset.Size = New System.Drawing.Size(156, 23)
            Me.btnReset.TabIndex = 11
            Me.btnReset.Text = "Reset"
            Me.btnReset.UseVisualStyleBackColor = True
            '
            'ManajemenUserForm
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(650, 300)
            Me.Controls.Add(Me.btnReset)
            Me.Controls.Add(Me.btnHapus)
            Me.Controls.Add(Me.btnSimpan)
            Me.Controls.Add(Me.cmbKaryawan)
            Me.Controls.Add(Me.lblKaryawan)
            Me.Controls.Add(Me.cmbRole)
            Me.Controls.Add(Me.lblRole)
            Me.Controls.Add(Me.txtPassword)
            Me.Controls.Add(Me.lblPassword)
            Me.Controls.Add(Me.txtUsername)
            Me.Controls.Add(Me.lblUsername)
            Me.Controls.Add(Me.dgvUser)
            Me.Name = "ManajemenUserForm"
            Me.Text = "Manajemen User"
            CType(Me.dgvUser, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents dgvUser As System.Windows.Forms.DataGridView
        Friend WithEvents lblUsername As System.Windows.Forms.Label
        Friend WithEvents txtUsername As System.Windows.Forms.TextBox
        Friend WithEvents lblPassword As System.Windows.Forms.Label
        Friend WithEvents txtPassword As System.Windows.Forms.TextBox
        Friend WithEvents lblRole As System.Windows.Forms.Label
        Friend WithEvents cmbRole As System.Windows.Forms.ComboBox
        Friend WithEvents lblKaryawan As System.Windows.Forms.Label
        Friend WithEvents cmbKaryawan As System.Windows.Forms.ComboBox
        Friend WithEvents btnSimpan As System.Windows.Forms.Button
        Friend WithEvents btnHapus As System.Windows.Forms.Button
        Friend WithEvents btnReset As System.Windows.Forms.Button
    End Class
End Namespace

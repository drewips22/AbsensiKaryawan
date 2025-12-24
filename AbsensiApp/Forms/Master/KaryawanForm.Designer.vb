Namespace Forms.Master
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class KaryawanForm
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
            Me.dgvKaryawan = New System.Windows.Forms.DataGridView()
            Me.lblNIK = New System.Windows.Forms.Label()
            Me.txtNIK = New System.Windows.Forms.TextBox()
            Me.lblNama = New System.Windows.Forms.Label()
            Me.txtNama = New System.Windows.Forms.TextBox()
            Me.lblDept = New System.Windows.Forms.Label()
            Me.cmbDept = New System.Windows.Forms.ComboBox()
            Me.lblJabatan = New System.Windows.Forms.Label()
            Me.cmbJabatan = New System.Windows.Forms.ComboBox()
            Me.lblMasuk = New System.Windows.Forms.Label()
            Me.dtpMasuk = New System.Windows.Forms.DateTimePicker()
            Me.lblStatus = New System.Windows.Forms.Label()
            Me.cmbStatus = New System.Windows.Forms.ComboBox()
            Me.btnSimpan = New System.Windows.Forms.Button()
            Me.btnHapus = New System.Windows.Forms.Button()
            Me.btnReset = New System.Windows.Forms.Button()
            CType(Me.dgvKaryawan, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'dgvKaryawan
            '
            Me.dgvKaryawan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvKaryawan.Location = New System.Drawing.Point(12, 12)
            Me.dgvKaryawan.Name = "dgvKaryawan"
            Me.dgvKaryawan.RowTemplate.Height = 25
            Me.dgvKaryawan.Size = New System.Drawing.Size(500, 300)
            Me.dgvKaryawan.TabIndex = 0
            '
            'lblNIK
            '
            Me.lblNIK.AutoSize = True
            Me.lblNIK.Location = New System.Drawing.Point(530, 20)
            Me.lblNIK.Name = "lblNIK"
            Me.lblNIK.Size = New System.Drawing.Size(26, 15)
            Me.lblNIK.TabIndex = 1
            Me.lblNIK.Text = "NIK"
            '
            'txtNIK
            '
            Me.txtNIK.Location = New System.Drawing.Point(530, 40)
            Me.txtNIK.Name = "txtNIK"
            Me.txtNIK.Size = New System.Drawing.Size(200, 23)
            Me.txtNIK.TabIndex = 2
            '
            'lblNama
            '
            Me.lblNama.AutoSize = True
            Me.lblNama.Location = New System.Drawing.Point(530, 70)
            Me.lblNama.Name = "lblNama"
            Me.lblNama.Size = New System.Drawing.Size(39, 15)
            Me.lblNama.TabIndex = 3
            Me.lblNama.Text = "Nama"
            '
            'txtNama
            '
            Me.txtNama.Location = New System.Drawing.Point(530, 90)
            Me.txtNama.Name = "txtNama"
            Me.txtNama.Size = New System.Drawing.Size(200, 23)
            Me.txtNama.TabIndex = 4
            '
            'lblDept
            '
            Me.lblDept.AutoSize = True
            Me.lblDept.Location = New System.Drawing.Point(530, 120)
            Me.lblDept.Name = "lblDept"
            Me.lblDept.Size = New System.Drawing.Size(72, 15)
            Me.lblDept.TabIndex = 5
            Me.lblDept.Text = "Departemen"
            '
            'cmbDept
            '
            Me.cmbDept.FormattingEnabled = True
            Me.cmbDept.Location = New System.Drawing.Point(530, 140)
            Me.cmbDept.Name = "cmbDept"
            Me.cmbDept.Size = New System.Drawing.Size(200, 23)
            Me.cmbDept.TabIndex = 6
            '
            'lblJabatan
            '
            Me.lblJabatan.AutoSize = True
            Me.lblJabatan.Location = New System.Drawing.Point(530, 170)
            Me.lblJabatan.Name = "lblJabatan"
            Me.lblJabatan.Size = New System.Drawing.Size(47, 15)
            Me.lblJabatan.TabIndex = 7
            Me.lblJabatan.Text = "Jabatan"
            '
            'cmbJabatan
            '
            Me.cmbJabatan.FormattingEnabled = True
            Me.cmbJabatan.Location = New System.Drawing.Point(530, 190)
            Me.cmbJabatan.Name = "cmbJabatan"
            Me.cmbJabatan.Size = New System.Drawing.Size(200, 23)
            Me.cmbJabatan.TabIndex = 8
            '
            'lblMasuk
            '
            Me.lblMasuk.AutoSize = True
            Me.lblMasuk.Location = New System.Drawing.Point(530, 220)
            Me.lblMasuk.Name = "lblMasuk"
            Me.lblMasuk.Size = New System.Drawing.Size(86, 15)
            Me.lblMasuk.TabIndex = 9
            Me.lblMasuk.Text = "Tanggal Masuk"
            '
            'dtpMasuk
            '
            Me.dtpMasuk.Format = System.Windows.Forms.DateTimePickerFormat.Short
            Me.dtpMasuk.Location = New System.Drawing.Point(530, 240)
            Me.dtpMasuk.Name = "dtpMasuk"
            Me.dtpMasuk.Size = New System.Drawing.Size(200, 23)
            Me.dtpMasuk.TabIndex = 10
            '
            'lblStatus
            '
            Me.lblStatus.AutoSize = True
            Me.lblStatus.Location = New System.Drawing.Point(530, 270)
            Me.lblStatus.Name = "lblStatus"
            Me.lblStatus.Size = New System.Drawing.Size(39, 15)
            Me.lblStatus.TabIndex = 11
            Me.lblStatus.Text = "Status"
            '
            'cmbStatus
            '
            Me.cmbStatus.FormattingEnabled = True
            Me.cmbStatus.Items.AddRange(New Object() {"Aktif", "Nonaktif"})
            Me.cmbStatus.Location = New System.Drawing.Point(530, 290)
            Me.cmbStatus.Name = "cmbStatus"
            Me.cmbStatus.Size = New System.Drawing.Size(200, 23)
            Me.cmbStatus.TabIndex = 12
            '
            'btnSimpan
            '
            Me.btnSimpan.Location = New System.Drawing.Point(530, 330)
            Me.btnSimpan.Name = "btnSimpan"
            Me.btnSimpan.Size = New System.Drawing.Size(75, 23)
            Me.btnSimpan.TabIndex = 13
            Me.btnSimpan.Text = "Simpan"
            Me.btnSimpan.UseVisualStyleBackColor = True
            '
            'btnHapus
            '
            Me.btnHapus.Location = New System.Drawing.Point(611, 330)
            Me.btnHapus.Name = "btnHapus"
            Me.btnHapus.Size = New System.Drawing.Size(75, 23)
            Me.btnHapus.TabIndex = 14
            Me.btnHapus.Text = "Hapus"
            Me.btnHapus.UseVisualStyleBackColor = True
            '
            'btnReset
            '
            Me.btnReset.Location = New System.Drawing.Point(530, 360)
            Me.btnReset.Name = "btnReset"
            Me.btnReset.Size = New System.Drawing.Size(156, 23)
            Me.btnReset.TabIndex = 15
            Me.btnReset.Text = "Reset"
            Me.btnReset.UseVisualStyleBackColor = True
            '
            'KaryawanForm
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(750, 400)
            Me.Controls.Add(Me.btnReset)
            Me.Controls.Add(Me.btnHapus)
            Me.Controls.Add(Me.btnSimpan)
            Me.Controls.Add(Me.cmbStatus)
            Me.Controls.Add(Me.lblStatus)
            Me.Controls.Add(Me.dtpMasuk)
            Me.Controls.Add(Me.lblMasuk)
            Me.Controls.Add(Me.cmbJabatan)
            Me.Controls.Add(Me.lblJabatan)
            Me.Controls.Add(Me.cmbDept)
            Me.Controls.Add(Me.lblDept)
            Me.Controls.Add(Me.txtNama)
            Me.Controls.Add(Me.lblNama)
            Me.Controls.Add(Me.txtNIK)
            Me.Controls.Add(Me.lblNIK)
            Me.Controls.Add(Me.dgvKaryawan)
            Me.Name = "KaryawanForm"
            Me.Text = "Master Karyawan"
            CType(Me.dgvKaryawan, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents dgvKaryawan As System.Windows.Forms.DataGridView
        Friend WithEvents lblNIK As System.Windows.Forms.Label
        Friend WithEvents txtNIK As System.Windows.Forms.TextBox
        Friend WithEvents lblNama As System.Windows.Forms.Label
        Friend WithEvents txtNama As System.Windows.Forms.TextBox
        Friend WithEvents lblDept As System.Windows.Forms.Label
        Friend WithEvents cmbDept As System.Windows.Forms.ComboBox
        Friend WithEvents lblJabatan As System.Windows.Forms.Label
        Friend WithEvents cmbJabatan As System.Windows.Forms.ComboBox
        Friend WithEvents lblMasuk As System.Windows.Forms.Label
        Friend WithEvents dtpMasuk As System.Windows.Forms.DateTimePicker
        Friend WithEvents lblStatus As System.Windows.Forms.Label
        Friend WithEvents cmbStatus As System.Windows.Forms.ComboBox
        Friend WithEvents btnSimpan As System.Windows.Forms.Button
        Friend WithEvents btnHapus As System.Windows.Forms.Button
        Friend WithEvents btnReset As System.Windows.Forms.Button
    End Class
End Namespace

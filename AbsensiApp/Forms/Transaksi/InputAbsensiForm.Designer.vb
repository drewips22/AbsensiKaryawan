Namespace Forms.Transaksi
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class InputAbsensiForm
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
            lblTanggal = New Label()
            dtpTanggal = New DateTimePicker()
            lblKaryawan = New Label()
            cmbKaryawan = New ComboBox()
            lblShift = New Label()
            cmbShift = New ComboBox()
            lblMasuk = New Label()
            dtpMasuk = New DateTimePicker()
            lblPulang = New Label()
            dtpPulang = New DateTimePicker()
            lblStatus = New Label()
            cmbStatus = New ComboBox()
            btnSimpan = New Button()
            SuspendLayout()
            ' 
            ' lblTanggal
            ' 
            lblTanggal.AutoSize = True
            lblTanggal.Location = New Point(23, 27)
            lblTanggal.Name = "lblTanggal"
            lblTanggal.Size = New Size(61, 20)
            lblTanggal.TabIndex = 0
            lblTanggal.Text = "Tanggal"
            ' 
            ' dtpTanggal
            ' 
            dtpTanggal.Format = DateTimePickerFormat.Short
            dtpTanggal.Location = New Point(114, 23)
            dtpTanggal.Margin = New Padding(3, 4, 3, 4)
            dtpTanggal.Name = "dtpTanggal"
            dtpTanggal.Size = New Size(228, 27)
            dtpTanggal.TabIndex = 1
            ' 
            ' lblKaryawan
            ' 
            lblKaryawan.AutoSize = True
            lblKaryawan.Location = New Point(23, 80)
            lblKaryawan.Name = "lblKaryawan"
            lblKaryawan.Size = New Size(73, 20)
            lblKaryawan.TabIndex = 2
            lblKaryawan.Text = "Karyawan"
            ' 
            ' cmbKaryawan
            ' 
            cmbKaryawan.FormattingEnabled = True
            cmbKaryawan.Location = New Point(114, 80)
            cmbKaryawan.Margin = New Padding(3, 4, 3, 4)
            cmbKaryawan.Name = "cmbKaryawan"
            cmbKaryawan.Size = New Size(228, 28)
            cmbKaryawan.TabIndex = 3
            ' 
            ' lblShift
            ' 
            lblShift.AutoSize = True
            lblShift.Location = New Point(23, 133)
            lblShift.Name = "lblShift"
            lblShift.Size = New Size(39, 20)
            lblShift.TabIndex = 4
            lblShift.Text = "Shift"
            ' 
            ' cmbShift
            ' 
            cmbShift.FormattingEnabled = True
            cmbShift.Location = New Point(114, 129)
            cmbShift.Margin = New Padding(3, 4, 3, 4)
            cmbShift.Name = "cmbShift"
            cmbShift.Size = New Size(228, 28)
            cmbShift.TabIndex = 5
            ' 
            ' lblMasuk
            ' 
            lblMasuk.AutoSize = True
            lblMasuk.Location = New Point(23, 187)
            lblMasuk.Name = "lblMasuk"
            lblMasuk.Size = New Size(81, 20)
            lblMasuk.TabIndex = 6
            lblMasuk.Text = "Jam Masuk"
            ' 
            ' dtpMasuk
            ' 
            dtpMasuk.Format = DateTimePickerFormat.Time
            dtpMasuk.Location = New Point(114, 183)
            dtpMasuk.Margin = New Padding(3, 4, 3, 4)
            dtpMasuk.Name = "dtpMasuk"
            dtpMasuk.ShowUpDown = True
            dtpMasuk.Size = New Size(228, 27)
            dtpMasuk.TabIndex = 7
            ' 
            ' lblPulang
            ' 
            lblPulang.AutoSize = True
            lblPulang.Location = New Point(23, 240)
            lblPulang.Name = "lblPulang"
            lblPulang.Size = New Size(84, 20)
            lblPulang.TabIndex = 8
            lblPulang.Text = "Jam Pulang"
            ' 
            ' dtpPulang
            ' 
            dtpPulang.Format = DateTimePickerFormat.Time
            dtpPulang.Location = New Point(114, 236)
            dtpPulang.Margin = New Padding(3, 4, 3, 4)
            dtpPulang.Name = "dtpPulang"
            dtpPulang.ShowUpDown = True
            dtpPulang.Size = New Size(228, 27)
            dtpPulang.TabIndex = 9
            ' 
            ' lblStatus
            ' 
            lblStatus.AutoSize = True
            lblStatus.Location = New Point(23, 293)
            lblStatus.Name = "lblStatus"
            lblStatus.Size = New Size(49, 20)
            lblStatus.TabIndex = 10
            lblStatus.Text = "Status"
            ' 
            ' cmbStatus
            ' 
            cmbStatus.FormattingEnabled = True
            cmbStatus.Items.AddRange(New Object() {"H", "A", "I", "S", "C"})
            cmbStatus.Location = New Point(114, 289)
            cmbStatus.Margin = New Padding(3, 4, 3, 4)
            cmbStatus.Name = "cmbStatus"
            cmbStatus.Size = New Size(228, 28)
            cmbStatus.TabIndex = 11
            cmbStatus.Text = "H"
            ' 
            ' btnSimpan
            ' 
            btnSimpan.Location = New Point(114, 347)
            btnSimpan.Margin = New Padding(3, 4, 3, 4)
            btnSimpan.Name = "btnSimpan"
            btnSimpan.Size = New Size(86, 31)
            btnSimpan.TabIndex = 12
            btnSimpan.Text = "Simpan"
            btnSimpan.UseVisualStyleBackColor = True
            ' 
            ' InputAbsensiForm
            ' 
            AutoScaleDimensions = New SizeF(8F, 20F)
            AutoScaleMode = AutoScaleMode.Font
            ClientSize = New Size(400, 427)
            Controls.Add(btnSimpan)
            Controls.Add(cmbStatus)
            Controls.Add(lblStatus)
            Controls.Add(dtpPulang)
            Controls.Add(lblPulang)
            Controls.Add(dtpMasuk)
            Controls.Add(lblMasuk)
            Controls.Add(cmbShift)
            Controls.Add(lblShift)
            Controls.Add(cmbKaryawan)
            Controls.Add(lblKaryawan)
            Controls.Add(dtpTanggal)
            Controls.Add(lblTanggal)
            Margin = New Padding(3, 4, 3, 4)
            Name = "InputAbsensiForm"
            Text = "Input Absensi Harian"
            ResumeLayout(False)
            PerformLayout()

        End Sub
        Friend WithEvents lblTanggal As System.Windows.Forms.Label
        Friend WithEvents dtpTanggal As System.Windows.Forms.DateTimePicker
        Friend WithEvents lblKaryawan As System.Windows.Forms.Label
        Friend WithEvents cmbKaryawan As System.Windows.Forms.ComboBox
        Friend WithEvents lblShift As System.Windows.Forms.Label
        Friend WithEvents cmbShift As System.Windows.Forms.ComboBox
        Friend WithEvents lblMasuk As System.Windows.Forms.Label
        Friend WithEvents dtpMasuk As System.Windows.Forms.DateTimePicker
        Friend WithEvents lblPulang As System.Windows.Forms.Label
        Friend WithEvents dtpPulang As System.Windows.Forms.DateTimePicker
        Friend WithEvents lblStatus As System.Windows.Forms.Label
        Friend WithEvents cmbStatus As System.Windows.Forms.ComboBox
        Friend WithEvents btnSimpan As System.Windows.Forms.Button
    End Class
End Namespace

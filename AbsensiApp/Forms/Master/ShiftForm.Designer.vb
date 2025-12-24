Namespace Forms.Master
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class ShiftForm
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
            Me.dgvShift = New System.Windows.Forms.DataGridView()
            Me.lblNama = New System.Windows.Forms.Label()
            Me.txtNama = New System.Windows.Forms.TextBox()
            Me.lblMasuk = New System.Windows.Forms.Label()
            Me.dtpMasuk = New System.Windows.Forms.DateTimePicker()
            Me.lblPulang = New System.Windows.Forms.Label()
            Me.dtpPulang = New System.Windows.Forms.DateTimePicker()
            Me.lblToleransi = New System.Windows.Forms.Label()
            Me.numToleransi = New System.Windows.Forms.NumericUpDown()
            Me.btnSimpan = New System.Windows.Forms.Button()
            Me.btnHapus = New System.Windows.Forms.Button()
            Me.btnReset = New System.Windows.Forms.Button()
            CType(Me.dgvShift, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.numToleransi, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'dgvShift
            '
            Me.dgvShift.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvShift.Location = New System.Drawing.Point(12, 12)
            Me.dgvShift.Name = "dgvShift"
            Me.dgvShift.RowTemplate.Height = 25
            Me.dgvShift.Size = New System.Drawing.Size(400, 250)
            Me.dgvShift.TabIndex = 0
            '
            'lblNama
            '
            Me.lblNama.AutoSize = True
            Me.lblNama.Location = New System.Drawing.Point(430, 20)
            Me.lblNama.Name = "lblNama"
            Me.lblNama.Size = New System.Drawing.Size(66, 15)
            Me.lblNama.TabIndex = 1
            Me.lblNama.Text = "Nama Shift"
            '
            'txtNama
            '
            Me.txtNama.Location = New System.Drawing.Point(430, 40)
            Me.txtNama.Name = "txtNama"
            Me.txtNama.Size = New System.Drawing.Size(200, 23)
            Me.txtNama.TabIndex = 2
            '
            'lblMasuk
            '
            Me.lblMasuk.AutoSize = True
            Me.lblMasuk.Location = New System.Drawing.Point(430, 70)
            Me.lblMasuk.Name = "lblMasuk"
            Me.lblMasuk.Size = New System.Drawing.Size(65, 15)
            Me.lblMasuk.TabIndex = 3
            Me.lblMasuk.Text = "Jam Masuk"
            '
            'dtpMasuk
            '
            Me.dtpMasuk.Format = System.Windows.Forms.DateTimePickerFormat.Time
            Me.dtpMasuk.Location = New System.Drawing.Point(430, 90)
            Me.dtpMasuk.Name = "dtpMasuk"
            Me.dtpMasuk.ShowUpDown = True
            Me.dtpMasuk.Size = New System.Drawing.Size(200, 23)
            Me.dtpMasuk.TabIndex = 4
            '
            'lblPulang
            '
            Me.lblPulang.AutoSize = True
            Me.lblPulang.Location = New System.Drawing.Point(430, 120)
            Me.lblPulang.Name = "lblPulang"
            Me.lblPulang.Size = New System.Drawing.Size(67, 15)
            Me.lblPulang.TabIndex = 5
            Me.lblPulang.Text = "Jam Pulang"
            '
            'dtpPulang
            '
            Me.dtpPulang.Format = System.Windows.Forms.DateTimePickerFormat.Time
            Me.dtpPulang.Location = New System.Drawing.Point(430, 140)
            Me.dtpPulang.Name = "dtpPulang"
            Me.dtpPulang.ShowUpDown = True
            Me.dtpPulang.Size = New System.Drawing.Size(200, 23)
            Me.dtpPulang.TabIndex = 6
            '
            'lblToleransi
            '
            Me.lblToleransi.AutoSize = True
            Me.lblToleransi.Location = New System.Drawing.Point(430, 170)
            Me.lblToleransi.Name = "lblToleransi"
            Me.lblToleransi.Size = New System.Drawing.Size(121, 15)
            Me.lblToleransi.TabIndex = 7
            Me.lblToleransi.Text = "Toleransi Telat (Menit)"
            '
            'numToleransi
            '
            Me.numToleransi.Location = New System.Drawing.Point(430, 190)
            Me.numToleransi.Name = "numToleransi"
            Me.numToleransi.Size = New System.Drawing.Size(200, 23)
            Me.numToleransi.TabIndex = 8
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
            'ShiftForm
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(650, 300)
            Me.Controls.Add(Me.btnReset)
            Me.Controls.Add(Me.btnHapus)
            Me.Controls.Add(Me.btnSimpan)
            Me.Controls.Add(Me.numToleransi)
            Me.Controls.Add(Me.lblToleransi)
            Me.Controls.Add(Me.dtpPulang)
            Me.Controls.Add(Me.lblPulang)
            Me.Controls.Add(Me.dtpMasuk)
            Me.Controls.Add(Me.lblMasuk)
            Me.Controls.Add(Me.txtNama)
            Me.Controls.Add(Me.lblNama)
            Me.Controls.Add(Me.dgvShift)
            Me.Name = "ShiftForm"
            Me.Text = "Master Shift"
            CType(Me.dgvShift, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.numToleransi, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents dgvShift As System.Windows.Forms.DataGridView
        Friend WithEvents lblNama As System.Windows.Forms.Label
        Friend WithEvents txtNama As System.Windows.Forms.TextBox
        Friend WithEvents lblMasuk As System.Windows.Forms.Label
        Friend WithEvents dtpMasuk As System.Windows.Forms.DateTimePicker
        Friend WithEvents lblPulang As System.Windows.Forms.Label
        Friend WithEvents dtpPulang As System.Windows.Forms.DateTimePicker
        Friend WithEvents lblToleransi As System.Windows.Forms.Label
        Friend WithEvents numToleransi As System.Windows.Forms.NumericUpDown
        Friend WithEvents btnSimpan As System.Windows.Forms.Button
        Friend WithEvents btnHapus As System.Windows.Forms.Button
        Friend WithEvents btnReset As System.Windows.Forms.Button
    End Class
End Namespace

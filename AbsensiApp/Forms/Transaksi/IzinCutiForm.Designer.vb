Namespace Forms.Transaksi
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class IzinCutiForm
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
            Me.lblKaryawan = New System.Windows.Forms.Label()
            Me.cmbKaryawan = New System.Windows.Forms.ComboBox()
            Me.lblMulai = New System.Windows.Forms.Label()
            Me.dtpMulai = New System.Windows.Forms.DateTimePicker()
            Me.lblSelesai = New System.Windows.Forms.Label()
            Me.dtpSelesai = New System.Windows.Forms.DateTimePicker()
            Me.lblJenis = New System.Windows.Forms.Label()
            Me.cmbJenis = New System.Windows.Forms.ComboBox()
            Me.lblAlasan = New System.Windows.Forms.Label()
            Me.txtAlasan = New System.Windows.Forms.TextBox()
            Me.btnAjukan = New System.Windows.Forms.Button()
            Me.lblListTitle = New System.Windows.Forms.Label()
            Me.SuspendLayout()
            '
            'lblKaryawan
            '
            Me.lblKaryawan.AutoSize = True
            Me.lblKaryawan.Location = New System.Drawing.Point(20, 20)
            Me.lblKaryawan.Name = "lblKaryawan"
            Me.lblKaryawan.Size = New System.Drawing.Size(58, 15)
            Me.lblKaryawan.TabIndex = 0
            Me.lblKaryawan.Text = "Karyawan"
            '
            'cmbKaryawan
            '
            Me.cmbKaryawan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbKaryawan.FormattingEnabled = True
            Me.cmbKaryawan.Location = New System.Drawing.Point(120, 17)
            Me.cmbKaryawan.Name = "cmbKaryawan"
            Me.cmbKaryawan.Size = New System.Drawing.Size(250, 23)
            Me.cmbKaryawan.TabIndex = 1
            '
            'lblMulai
            '
            Me.lblMulai.AutoSize = True
            Me.lblMulai.Location = New System.Drawing.Point(20, 55)
            Me.lblMulai.Name = "lblMulai"
            Me.lblMulai.Size = New System.Drawing.Size(83, 15)
            Me.lblMulai.TabIndex = 2
            Me.lblMulai.Text = "Tanggal Mulai"
            '
            'dtpMulai
            '
            Me.dtpMulai.Format = System.Windows.Forms.DateTimePickerFormat.Short
            Me.dtpMulai.Location = New System.Drawing.Point(120, 52)
            Me.dtpMulai.Name = "dtpMulai"
            Me.dtpMulai.Size = New System.Drawing.Size(250, 23)
            Me.dtpMulai.TabIndex = 3
            '
            'lblSelesai
            '
            Me.lblSelesai.AutoSize = True
            Me.lblSelesai.Location = New System.Drawing.Point(20, 90)
            Me.lblSelesai.Name = "lblSelesai"
            Me.lblSelesai.Size = New System.Drawing.Size(86, 15)
            Me.lblSelesai.TabIndex = 4
            Me.lblSelesai.Text = "Tanggal Selesai"
            '
            'dtpSelesai
            '
            Me.dtpSelesai.Format = System.Windows.Forms.DateTimePickerFormat.Short
            Me.dtpSelesai.Location = New System.Drawing.Point(120, 87)
            Me.dtpSelesai.Name = "dtpSelesai"
            Me.dtpSelesai.Size = New System.Drawing.Size(250, 23)
            Me.dtpSelesai.TabIndex = 5
            '
            'lblJenis
            '
            Me.lblJenis.AutoSize = True
            Me.lblJenis.Location = New System.Drawing.Point(20, 125)
            Me.lblJenis.Name = "lblJenis"
            Me.lblJenis.Size = New System.Drawing.Size(32, 15)
            Me.lblJenis.TabIndex = 6
            Me.lblJenis.Text = "Jenis"
            '
            'cmbJenis
            '
            Me.cmbJenis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbJenis.FormattingEnabled = True
            Me.cmbJenis.Items.AddRange(New Object() {"Izin", "Cuti", "Sakit"})
            Me.cmbJenis.Location = New System.Drawing.Point(120, 122)
            Me.cmbJenis.Name = "cmbJenis"
            Me.cmbJenis.Size = New System.Drawing.Size(250, 23)
            Me.cmbJenis.TabIndex = 7
            '
            'lblAlasan
            '
            Me.lblAlasan.AutoSize = True
            Me.lblAlasan.Location = New System.Drawing.Point(20, 160)
            Me.lblAlasan.Name = "lblAlasan"
            Me.lblAlasan.Size = New System.Drawing.Size(42, 15)
            Me.lblAlasan.TabIndex = 8
            Me.lblAlasan.Text = "Alasan"
            '
            'txtAlasan
            '
            Me.txtAlasan.Location = New System.Drawing.Point(120, 157)
            Me.txtAlasan.Multiline = True
            Me.txtAlasan.Name = "txtAlasan"
            Me.txtAlasan.Size = New System.Drawing.Size(250, 50)
            Me.txtAlasan.TabIndex = 9
            '
            'btnAjukan
            '
            Me.btnAjukan.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
            Me.btnAjukan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnAjukan.ForeColor = System.Drawing.Color.White
            Me.btnAjukan.Location = New System.Drawing.Point(120, 215)
            Me.btnAjukan.Name = "btnAjukan"
            Me.btnAjukan.Size = New System.Drawing.Size(100, 30)
            Me.btnAjukan.TabIndex = 10
            Me.btnAjukan.Text = "Ajukan"
            Me.btnAjukan.UseVisualStyleBackColor = False
            '
            'lblListTitle
            '
            Me.lblListTitle.AutoSize = True
            Me.lblListTitle.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
            Me.lblListTitle.Location = New System.Drawing.Point(20, 260)
            Me.lblListTitle.Name = "lblListTitle"
            Me.lblListTitle.Size = New System.Drawing.Size(150, 19)
            Me.lblListTitle.TabIndex = 11
            Me.lblListTitle.Text = "Daftar Pengajuan"
            '
            'IzinCutiForm
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(800, 550)
            Me.Controls.Add(Me.lblListTitle)
            Me.Controls.Add(Me.btnAjukan)
            Me.Controls.Add(Me.txtAlasan)
            Me.Controls.Add(Me.lblAlasan)
            Me.Controls.Add(Me.cmbJenis)
            Me.Controls.Add(Me.lblJenis)
            Me.Controls.Add(Me.dtpSelesai)
            Me.Controls.Add(Me.lblSelesai)
            Me.Controls.Add(Me.dtpMulai)
            Me.Controls.Add(Me.lblMulai)
            Me.Controls.Add(Me.cmbKaryawan)
            Me.Controls.Add(Me.lblKaryawan)
            Me.Name = "IzinCutiForm"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Pengajuan Izin/Cuti"
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents lblKaryawan As System.Windows.Forms.Label
        Friend WithEvents cmbKaryawan As System.Windows.Forms.ComboBox
        Friend WithEvents lblMulai As System.Windows.Forms.Label
        Friend WithEvents dtpMulai As System.Windows.Forms.DateTimePicker
        Friend WithEvents lblSelesai As System.Windows.Forms.Label
        Friend WithEvents dtpSelesai As System.Windows.Forms.DateTimePicker
        Friend WithEvents lblJenis As System.Windows.Forms.Label
        Friend WithEvents cmbJenis As System.Windows.Forms.ComboBox
        Friend WithEvents lblAlasan As System.Windows.Forms.Label
        Friend WithEvents txtAlasan As System.Windows.Forms.TextBox
        Friend WithEvents btnAjukan As System.Windows.Forms.Button
        Friend WithEvents lblListTitle As System.Windows.Forms.Label
    End Class
End Namespace

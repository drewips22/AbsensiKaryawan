Namespace Forms.Laporan
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class LaporanForm
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
            Me.dgvLaporan = New System.Windows.Forms.DataGridView()
            Me.lblMulai = New System.Windows.Forms.Label()
            Me.dtpMulai = New System.Windows.Forms.DateTimePicker()
            Me.lblSelesai = New System.Windows.Forms.Label()
            Me.dtpSelesai = New System.Windows.Forms.DateTimePicker()
            Me.btnFilter = New System.Windows.Forms.Button()
            Me.btnExport = New System.Windows.Forms.Button()
            CType(Me.dgvLaporan, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'dgvLaporan
            '
            Me.dgvLaporan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvLaporan.Location = New System.Drawing.Point(12, 60)
            Me.dgvLaporan.Name = "dgvLaporan"
            Me.dgvLaporan.RowTemplate.Height = 25
            Me.dgvLaporan.Size = New System.Drawing.Size(760, 380)
            Me.dgvLaporan.TabIndex = 0
            '
            'lblMulai
            '
            Me.lblMulai.AutoSize = True
            Me.lblMulai.Location = New System.Drawing.Point(12, 20)
            Me.lblMulai.Name = "lblMulai"
            Me.lblMulai.Size = New System.Drawing.Size(54, 15)
            Me.lblMulai.TabIndex = 1
            Me.lblMulai.Text = "Dari Tgl"
            '
            'dtpMulai
            '
            Me.dtpMulai.Format = System.Windows.Forms.DateTimePickerFormat.Short
            Me.dtpMulai.Location = New System.Drawing.Point(70, 17)
            Me.dtpMulai.Name = "dtpMulai"
            Me.dtpMulai.Size = New System.Drawing.Size(120, 23)
            Me.dtpMulai.TabIndex = 2
            '
            'lblSelesai
            '
            Me.lblSelesai.AutoSize = True
            Me.lblSelesai.Location = New System.Drawing.Point(200, 20)
            Me.lblSelesai.Name = "lblSelesai"
            Me.lblSelesai.Size = New System.Drawing.Size(51, 15)
            Me.lblSelesai.TabIndex = 3
            Me.lblSelesai.Text = "Sampai"
            '
            'dtpSelesai
            '
            Me.dtpSelesai.Format = System.Windows.Forms.DateTimePickerFormat.Short
            Me.dtpSelesai.Location = New System.Drawing.Point(260, 17)
            Me.dtpSelesai.Name = "dtpSelesai"
            Me.dtpSelesai.Size = New System.Drawing.Size(120, 23)
            Me.dtpSelesai.TabIndex = 4
            '
            'btnFilter
            '
            Me.btnFilter.Location = New System.Drawing.Point(400, 17)
            Me.btnFilter.Name = "btnFilter"
            Me.btnFilter.Size = New System.Drawing.Size(75, 23)
            Me.btnFilter.TabIndex = 5
            Me.btnFilter.Text = "Filter"
            Me.btnFilter.UseVisualStyleBackColor = True
            '
            'btnExport
            '
            Me.btnExport.Location = New System.Drawing.Point(490, 17)
            Me.btnExport.Name = "btnExport"
            Me.btnExport.Size = New System.Drawing.Size(100, 23)
            Me.btnExport.TabIndex = 6
            Me.btnExport.Text = "Export Excel"
            Me.btnExport.UseVisualStyleBackColor = True
            '
            'LaporanForm
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(800, 450)
            Me.Controls.Add(Me.btnExport)
            Me.Controls.Add(Me.btnFilter)
            Me.Controls.Add(Me.dtpSelesai)
            Me.Controls.Add(Me.lblSelesai)
            Me.Controls.Add(Me.dtpMulai)
            Me.Controls.Add(Me.lblMulai)
            Me.Controls.Add(Me.dgvLaporan)
            Me.Name = "LaporanForm"
            Me.Text = "Laporan Absensi"
            CType(Me.dgvLaporan, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents dgvLaporan As System.Windows.Forms.DataGridView
        Friend WithEvents lblMulai As System.Windows.Forms.Label
        Friend WithEvents dtpMulai As System.Windows.Forms.DateTimePicker
        Friend WithEvents lblSelesai As System.Windows.Forms.Label
        Friend WithEvents dtpSelesai As System.Windows.Forms.DateTimePicker
        Friend WithEvents btnFilter As System.Windows.Forms.Button
        Friend WithEvents btnExport As System.Windows.Forms.Button
    End Class
End Namespace

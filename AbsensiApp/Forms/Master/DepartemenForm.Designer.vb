Namespace Forms.Master
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class DepartemenForm
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
            Me.dgvDepartemen = New System.Windows.Forms.DataGridView()
            Me.lblNama = New System.Windows.Forms.Label()
            Me.txtNama = New System.Windows.Forms.TextBox()
            Me.btnSimpan = New System.Windows.Forms.Button()
            Me.btnHapus = New System.Windows.Forms.Button()
            Me.btnReset = New System.Windows.Forms.Button()
            CType(Me.dgvDepartemen, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'dgvDepartemen
            '
            Me.dgvDepartemen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvDepartemen.Location = New System.Drawing.Point(12, 12)
            Me.dgvDepartemen.Name = "dgvDepartemen"
            Me.dgvDepartemen.RowTemplate.Height = 25
            Me.dgvDepartemen.Size = New System.Drawing.Size(400, 200)
            Me.dgvDepartemen.TabIndex = 0
            '
            'lblNama
            '
            Me.lblNama.AutoSize = True
            Me.lblNama.Location = New System.Drawing.Point(430, 20)
            Me.lblNama.Name = "lblNama"
            Me.lblNama.Size = New System.Drawing.Size(108, 15)
            Me.lblNama.TabIndex = 1
            Me.lblNama.Text = "Nama Departemen"
            '
            'txtNama
            '
            Me.txtNama.Location = New System.Drawing.Point(430, 40)
            Me.txtNama.Name = "txtNama"
            Me.txtNama.Size = New System.Drawing.Size(200, 23)
            Me.txtNama.TabIndex = 2
            '
            'btnSimpan
            '
            Me.btnSimpan.Location = New System.Drawing.Point(430, 80)
            Me.btnSimpan.Name = "btnSimpan"
            Me.btnSimpan.Size = New System.Drawing.Size(75, 23)
            Me.btnSimpan.TabIndex = 3
            Me.btnSimpan.Text = "Simpan"
            Me.btnSimpan.UseVisualStyleBackColor = True
            '
            'btnHapus
            '
            Me.btnHapus.Location = New System.Drawing.Point(511, 80)
            Me.btnHapus.Name = "btnHapus"
            Me.btnHapus.Size = New System.Drawing.Size(75, 23)
            Me.btnHapus.TabIndex = 4
            Me.btnHapus.Text = "Hapus"
            Me.btnHapus.UseVisualStyleBackColor = True
            '
            'btnReset
            '
            Me.btnReset.Location = New System.Drawing.Point(430, 110)
            Me.btnReset.Name = "btnReset"
            Me.btnReset.Size = New System.Drawing.Size(156, 23)
            Me.btnReset.TabIndex = 5
            Me.btnReset.Text = "Reset"
            Me.btnReset.UseVisualStyleBackColor = True
            '
            'DepartemenForm
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(650, 250)
            Me.Controls.Add(Me.btnReset)
            Me.Controls.Add(Me.btnHapus)
            Me.Controls.Add(Me.btnSimpan)
            Me.Controls.Add(Me.txtNama)
            Me.Controls.Add(Me.lblNama)
            Me.Controls.Add(Me.dgvDepartemen)
            Me.Name = "DepartemenForm"
            Me.Text = "Master Departemen"
            CType(Me.dgvDepartemen, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents dgvDepartemen As System.Windows.Forms.DataGridView
        Friend WithEvents lblNama As System.Windows.Forms.Label
        Friend WithEvents txtNama As System.Windows.Forms.TextBox
        Friend WithEvents btnSimpan As System.Windows.Forms.Button
        Friend WithEvents btnHapus As System.Windows.Forms.Button
        Friend WithEvents btnReset As System.Windows.Forms.Button
    End Class
End Namespace

Imports AbsensiApp.Utils

Namespace Forms.Master
    Public Class KaryawanForm
        Private _selectedId As Integer = -1

        Private Sub KaryawanForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            LoadComboBoxes()
            LoadData()
        End Sub

        Private Sub LoadComboBoxes()
            ' Load Departemen
            Dim dtDept As DataTable = DatabaseHelper.ExecuteDataTable("SELECT * FROM tblDepartemen")
            cmbDept.DataSource = dtDept
            cmbDept.DisplayMember = "NamaDepartemen"
            cmbDept.ValueMember = "IDDepartemen"
            cmbDept.SelectedIndex = -1

            ' Load Jabatan
            Dim dtJabatan As DataTable = DatabaseHelper.ExecuteDataTable("SELECT * FROM tblJabatan")
            cmbJabatan.DataSource = dtJabatan
            cmbJabatan.DisplayMember = "NamaJabatan"
            cmbJabatan.ValueMember = "IDJabatan"
            cmbJabatan.SelectedIndex = -1
        End Sub

        Private Sub LoadData()
            Dim query As String = "SELECT k.KaryawanID, k.NIK, k.Nama, d.NamaDepartemen, j.NamaJabatan, k.TanggalMasuk, k.Status, k.IDDepartemen, k.IDJabatan " &
                                  "FROM tblKaryawan k " &
                                  "LEFT JOIN tblDepartemen d ON k.IDDepartemen = d.IDDepartemen " &
                                  "LEFT JOIN tblJabatan j ON k.IDJabatan = j.IDJabatan"
            dgvKaryawan.DataSource = DatabaseHelper.ExecuteDataTable(query)
            
            ' Hide ID columns
            If dgvKaryawan.Columns("IDDepartemen") IsNot Nothing Then dgvKaryawan.Columns("IDDepartemen").Visible = False
            If dgvKaryawan.Columns("IDJabatan") IsNot Nothing Then dgvKaryawan.Columns("IDJabatan").Visible = False
        End Sub

        Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
            If String.IsNullOrWhiteSpace(txtNIK.Text) OrElse String.IsNullOrWhiteSpace(txtNama.Text) Then
                MessageBox.Show("NIK dan Nama harus diisi!")
                Return
            End If

            Dim query As String
            Dim params As New Dictionary(Of String, Object)
            params.Add("@NIK", txtNIK.Text)
            params.Add("@Nama", txtNama.Text)
            params.Add("@IDDept", If(cmbDept.SelectedValue, DBNull.Value))
            params.Add("@IDJabatan", If(cmbJabatan.SelectedValue, DBNull.Value))
            params.Add("@TglMasuk", dtpMasuk.Value)
            params.Add("@Status", If(cmbStatus.SelectedItem, "Aktif"))

            If _selectedId = -1 Then
                query = "INSERT INTO tblKaryawan (NIK, Nama, IDDepartemen, IDJabatan, TanggalMasuk, Status) VALUES (@NIK, @Nama, @IDDept, @IDJabatan, @TglMasuk, @Status)"
            Else
                query = "UPDATE tblKaryawan SET NIK = @NIK, Nama = @Nama, IDDepartemen = @IDDept, IDJabatan = @IDJabatan, TanggalMasuk = @TglMasuk, Status = @Status WHERE KaryawanID = @ID"
                params.Add("@ID", _selectedId)
            End If

            DatabaseHelper.ExecuteNonQuery(query, params)
            ResetForm()
            LoadData()
        End Sub

        Private Sub dgvKaryawan_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvKaryawan.CellClick
            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow = dgvKaryawan.Rows(e.RowIndex)
                _selectedId = Convert.ToInt32(row.Cells("KaryawanID").Value)
                txtNIK.Text = row.Cells("NIK").Value.ToString()
                txtNama.Text = row.Cells("Nama").Value.ToString()
                cmbDept.SelectedValue = If(IsDBNull(row.Cells("IDDepartemen").Value), -1, row.Cells("IDDepartemen").Value)
                cmbJabatan.SelectedValue = If(IsDBNull(row.Cells("IDJabatan").Value), -1, row.Cells("IDJabatan").Value)
                dtpMasuk.Value = Convert.ToDateTime(row.Cells("TanggalMasuk").Value)
                cmbStatus.SelectedItem = row.Cells("Status").Value.ToString()
            End If
        End Sub

        Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
            If _selectedId = -1 Then
                MessageBox.Show("Pilih data terlebih dahulu!")
                Return
            End If

            If MessageBox.Show("Yakin ingin menghapus?", "Konfirmasi", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                Dim query As String = "DELETE FROM tblKaryawan WHERE KaryawanID = @ID"
                Dim params As New Dictionary(Of String, Object)
                params.Add("@ID", _selectedId)
                DatabaseHelper.ExecuteNonQuery(query, params)
                ResetForm()
                LoadData()
            End If
        End Sub

        Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
            ResetForm()
        End Sub

        Private Sub ResetForm()
            _selectedId = -1
            txtNIK.Clear()
            txtNama.Clear()
            cmbDept.SelectedIndex = -1
            cmbJabatan.SelectedIndex = -1
            dtpMasuk.Value = DateTime.Now
            cmbStatus.SelectedIndex = -1
        End Sub
    End Class
End Namespace

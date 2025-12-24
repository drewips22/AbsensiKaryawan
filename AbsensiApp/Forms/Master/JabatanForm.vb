Imports AbsensiApp.Utils

Namespace Forms.Master
    Public Class JabatanForm
        Private _selectedId As Integer = -1

        Private Sub JabatanForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            LoadData()
        End Sub

        Private Sub LoadData()
            Dim query As String = "SELECT * FROM tblJabatan"
            dgvJabatan.DataSource = DatabaseHelper.ExecuteDataTable(query)
        End Sub

        Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
            If String.IsNullOrWhiteSpace(txtNama.Text) Then
                MessageBox.Show("Nama Jabatan harus diisi!")
                Return
            End If

            Dim query As String
            Dim params As New Dictionary(Of String, Object)
            params.Add("@Nama", txtNama.Text)

            If _selectedId = -1 Then
                query = "INSERT INTO tblJabatan (NamaJabatan) VALUES (@Nama)"
            Else
                query = "UPDATE tblJabatan SET NamaJabatan = @Nama WHERE IDJabatan = @ID"
                params.Add("@ID", _selectedId)
            End If

            DatabaseHelper.ExecuteNonQuery(query, params)
            ResetForm()
            LoadData()
        End Sub

        Private Sub dgvJabatan_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvJabatan.CellClick
            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow = dgvJabatan.Rows(e.RowIndex)
                _selectedId = Convert.ToInt32(row.Cells("IDJabatan").Value)
                txtNama.Text = row.Cells("NamaJabatan").Value.ToString()
            End If
        End Sub

        Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
            If _selectedId = -1 Then
                MessageBox.Show("Pilih data terlebih dahulu!")
                Return
            End If

            If MessageBox.Show("Yakin ingin menghapus?", "Konfirmasi", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                Dim query As String = "DELETE FROM tblJabatan WHERE IDJabatan = @ID"
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
            txtNama.Clear()
        End Sub
    End Class
End Namespace

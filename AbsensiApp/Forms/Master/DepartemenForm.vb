Imports AbsensiApp.Utils

Namespace Forms.Master
    Public Class DepartemenForm
        Private _selectedId As Integer = -1

        Private Sub DepartemenForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            LoadData()
        End Sub

        Private Sub LoadData()
            Dim query As String = "SELECT * FROM tblDepartemen"
            dgvDepartemen.DataSource = DatabaseHelper.ExecuteDataTable(query)
        End Sub

        Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
            If String.IsNullOrWhiteSpace(txtNama.Text) Then
                MessageBox.Show("Nama Departemen harus diisi!")
                Return
            End If

            Dim query As String
            Dim params As New Dictionary(Of String, Object)
            params.Add("@Nama", txtNama.Text)

            If _selectedId = -1 Then
                query = "INSERT INTO tblDepartemen (NamaDepartemen) VALUES (@Nama)"
            Else
                query = "UPDATE tblDepartemen SET NamaDepartemen = @Nama WHERE IDDepartemen = @ID"
                params.Add("@ID", _selectedId)
            End If

            DatabaseHelper.ExecuteNonQuery(query, params)
            ResetForm()
            LoadData()
        End Sub

        Private Sub dgvDepartemen_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDepartemen.CellClick
            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow = dgvDepartemen.Rows(e.RowIndex)
                _selectedId = Convert.ToInt32(row.Cells("IDDepartemen").Value)
                txtNama.Text = row.Cells("NamaDepartemen").Value.ToString()
            End If
        End Sub

        Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
            If _selectedId = -1 Then
                MessageBox.Show("Pilih data terlebih dahulu!")
                Return
            End If

            If MessageBox.Show("Yakin ingin menghapus?", "Konfirmasi", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                Dim query As String = "DELETE FROM tblDepartemen WHERE IDDepartemen = @ID"
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

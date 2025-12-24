Imports AbsensiApp.Utils

Namespace Forms.Admin
    Public Class ManajemenUserForm
        Private _selectedId As Integer = -1

        Private Sub ManajemenUserForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            LoadKaryawan()
            LoadData()
        End Sub

        Private Sub LoadKaryawan()
            Dim dt As DataTable = DatabaseHelper.ExecuteDataTable("SELECT KaryawanID, Nama FROM tblKaryawan")
            ' Add empty option
            Dim row As DataRow = dt.NewRow()
            row("KaryawanID") = DBNull.Value
            row("Nama") = "-- Tidak Ada --"
            dt.Rows.InsertAt(row, 0)
            
            cmbKaryawan.DataSource = dt
            cmbKaryawan.DisplayMember = "Nama"
            cmbKaryawan.ValueMember = "KaryawanID"
        End Sub

        Private Sub LoadData()
            Dim query As String = "SELECT u.UserID, u.Username, u.Role, k.Nama AS NamaKaryawan, u.KaryawanID " &
                                  "FROM tblUser u LEFT JOIN tblKaryawan k ON u.KaryawanID = k.KaryawanID"
            dgvUser.DataSource = DatabaseHelper.ExecuteDataTable(query)
            If dgvUser.Columns("KaryawanID") IsNot Nothing Then dgvUser.Columns("KaryawanID").Visible = False
            If dgvUser.Columns("NamaKaryawan") IsNot Nothing Then dgvUser.Columns("NamaKaryawan").HeaderText = "Nama Karyawan"
        End Sub

        Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
            If String.IsNullOrWhiteSpace(txtUsername.Text) OrElse String.IsNullOrWhiteSpace(txtPassword.Text) Then
                MessageBox.Show("Username dan Password harus diisi!")
                Return
            End If

            Dim query As String
            Dim params As New Dictionary(Of String, Object)
            params.Add("@Username", txtUsername.Text)
            params.Add("@Password", txtPassword.Text) ' In production, hash this!
            params.Add("@Role", cmbRole.SelectedItem.ToString())
            params.Add("@KaryawanID", If(cmbKaryawan.SelectedValue Is DBNull.Value, DBNull.Value, cmbKaryawan.SelectedValue))

            If _selectedId = -1 Then
                query = "INSERT INTO tblUser (Username, PasswordHash, Role, KaryawanID) VALUES (@Username, @Password, @Role, @KaryawanID)"
            Else
                query = "UPDATE tblUser SET Username = @Username, PasswordHash = @Password, Role = @Role, KaryawanID = @KaryawanID WHERE UserID = @ID"
                params.Add("@ID", _selectedId)
            End If

            DatabaseHelper.ExecuteNonQuery(query, params)
            ResetForm()
            LoadData()
        End Sub

        Private Sub dgvUser_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUser.CellClick
            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow = dgvUser.Rows(e.RowIndex)
                _selectedId = Convert.ToInt32(row.Cells("UserID").Value)
                txtUsername.Text = row.Cells("Username").Value.ToString()
                txtPassword.Text = "" ' Don't show password
                cmbRole.SelectedItem = row.Cells("Role").Value.ToString()
                cmbKaryawan.SelectedValue = If(IsDBNull(row.Cells("KaryawanID").Value), DBNull.Value, row.Cells("KaryawanID").Value)
            End If
        End Sub

        Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
            If _selectedId = -1 Then
                MessageBox.Show("Pilih data terlebih dahulu!")
                Return
            End If

            If MessageBox.Show("Yakin ingin menghapus?", "Konfirmasi", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                Dim query As String = "DELETE FROM tblUser WHERE UserID = @ID"
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
            txtUsername.Clear()
            txtPassword.Clear()
            cmbRole.SelectedIndex = -1
            cmbKaryawan.SelectedIndex = 0
            LoadKaryawan() ' Refresh list in case new employees were added
        End Sub
    End Class
End Namespace

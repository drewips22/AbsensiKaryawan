Imports AbsensiApp.Utils

Namespace Forms.Master
    Public Class ShiftForm
        Private _selectedId As Integer = -1

        Private Sub ShiftForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            LoadData()
        End Sub

        Private Sub LoadData()
            Dim query As String = "SELECT * FROM tblShift"
            dgvShift.DataSource = DatabaseHelper.ExecuteDataTable(query)
        End Sub

        Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
            If String.IsNullOrWhiteSpace(txtNama.Text) Then
                MessageBox.Show("Nama Shift harus diisi!")
                Return
            End If

            Dim query As String
            Dim params As New Dictionary(Of String, Object)
            params.Add("@Nama", txtNama.Text)
            Dim tsMasuk As TimeSpan = New TimeSpan(dtpMasuk.Value.Hour, dtpMasuk.Value.Minute, 0)
            Dim tsPulang As TimeSpan = New TimeSpan(dtpPulang.Value.Hour, dtpPulang.Value.Minute, 0)
            params.Add("@Masuk", tsMasuk)
            params.Add("@Pulang", tsPulang)
            params.Add("@Toleransi", Convert.ToInt32(numToleransi.Value))

            If _selectedId = -1 Then
                query = "INSERT INTO tblShift (NamaShift, JamMasuk, JamPulang, ToleransiTelatMenit) VALUES (@Nama, @Masuk, @Pulang, @Toleransi)"
            Else
                query = "UPDATE tblShift SET NamaShift = @Nama, JamMasuk = @Masuk, JamPulang = @Pulang, ToleransiTelatMenit = @Toleransi WHERE IDShift = @ID"
                params.Add("@ID", _selectedId)
            End If

            DatabaseHelper.ExecuteNonQuery(query, params)
            ResetForm()
            LoadData()
        End Sub

        Private Sub dgvShift_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvShift.CellClick
            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow = dgvShift.Rows(e.RowIndex)
                _selectedId = Convert.ToInt32(row.Cells("IDShift").Value)
                txtNama.Text = row.Cells("NamaShift").Value.ToString()
                Dim vMasuk = row.Cells("JamMasuk").Value
                Dim tsMasuk As TimeSpan
                If TypeOf vMasuk Is TimeSpan Then
                    tsMasuk = DirectCast(vMasuk, TimeSpan)
                Else
                    TimeSpan.TryParse(vMasuk.ToString(), tsMasuk)
                End If
                dtpMasuk.Value = DateTime.Today.Add(tsMasuk)

                Dim vPulang = row.Cells("JamPulang").Value
                Dim tsPulang As TimeSpan
                If TypeOf vPulang Is TimeSpan Then
                    tsPulang = DirectCast(vPulang, TimeSpan)
                Else
                    TimeSpan.TryParse(vPulang.ToString(), tsPulang)
                End If
                dtpPulang.Value = DateTime.Today.Add(tsPulang)
                numToleransi.Value = Convert.ToInt32(row.Cells("ToleransiTelatMenit").Value)
            End If
        End Sub

        Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
            If _selectedId = -1 Then
                MessageBox.Show("Pilih data terlebih dahulu!")
                Return
            End If

            If MessageBox.Show("Yakin ingin menghapus?", "Konfirmasi", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                Dim query As String = "DELETE FROM tblShift WHERE IDShift = @ID"
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
            numToleransi.Value = 0
            dtpMasuk.Value = DateTime.Now
            dtpPulang.Value = DateTime.Now
        End Sub
    End Class
End Namespace

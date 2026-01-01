Imports AbsensiApp.Utils

Namespace Forms.Laporan
    Public Class LaporanForm
        Private Sub LaporanForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            ' Default to current month
            dtpMulai.Value = New DateTime(DateTime.Now.Year, DateTime.Now.Month, 1)
            dtpSelesai.Value = DateTime.Now
            LoadData()
        End Sub

        Private Sub LoadData()
            Dim query As String = "SELECT a.Tanggal, k.Nama AS Karyawan, s.NamaShift, a.JamMasuk, a.JamPulang, a.Status, a.TelatMenit, a.LemburMenit " &
                                  "FROM tblAbsensi a " &
                                  "JOIN tblKaryawan k ON a.KaryawanID = k.KaryawanID " &
                                  "LEFT JOIN tblShift s ON a.IDShift = s.IDShift " &
                                  "WHERE a.Tanggal BETWEEN @Mulai AND @Selesai "

            Dim params As New Dictionary(Of String, Object)
            params.Add("@Mulai", dtpMulai.Value.Date)
            params.Add("@Selesai", dtpSelesai.Value.Date)

            ' Check Role - support both MainForm and MainFormKaryawan
            Dim currentUser As Models.User = Nothing

            ' Try to get user from MainFormKaryawan (for Karyawan role)
            Dim karyawanForm As MainFormKaryawan = CType(Application.OpenForms("MainFormKaryawan"), MainFormKaryawan)
            If karyawanForm IsNot Nothing Then
                currentUser = karyawanForm.CurrentUser
            Else
                ' Try to get user from MainForm (for Admin/HR/Atasan)
                Dim mainForm As MainForm = CType(Application.OpenForms("MainForm"), MainForm)
                If mainForm IsNot Nothing Then
                    currentUser = mainForm.CurrentUser
                End If
            End If

            ' Filter by KaryawanID if user is Karyawan
            If currentUser IsNot Nothing AndAlso currentUser.Role = "Karyawan" Then
                If currentUser.KaryawanID.HasValue Then
                    query &= " AND a.KaryawanID = @KaryawanID"
                    params.Add("@KaryawanID", currentUser.KaryawanID.Value)
                End If
            End If

            query &= " ORDER BY a.Tanggal DESC, k.Nama ASC"
            
            dgvLaporan.DataSource = DatabaseHelper.ExecuteDataTable(query, params)
        End Sub

        Private Sub btnFilter_Click(sender As Object, e As EventArgs) Handles btnFilter.Click
            LoadData()
        End Sub

        Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
            MessageBox.Show("Fitur Export ke Excel belum diimplementasikan (membutuhkan library tambahan).", "Info")
        End Sub
    End Class
End Namespace

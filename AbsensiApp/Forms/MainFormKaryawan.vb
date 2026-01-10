Imports AbsensiApp.Models
Imports AbsensiApp.Services
Imports AbsensiApp.Utils

Namespace Forms
    Public Class MainFormKaryawan
        <System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)>
        Public Property CurrentUser As User

        Private Sub MainFormKaryawan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            If CurrentUser IsNot Nothing AndAlso CurrentUser.KaryawanID.HasValue Then
                Dim karyawanName As String = DashboardService.GetKaryawanName(CurrentUser.KaryawanID.Value)
                If Not String.IsNullOrEmpty(karyawanName) Then
                    lblWelcome.Text = "Selamat Datang, " & karyawanName & "! 👋"
                Else
                    lblWelcome.Text = "Selamat Datang, " & CurrentUser.Username & "! 👋"
                End If
            Else
                lblWelcome.Text = "Selamat Datang! 👋"
            End If

            UpdateClock()
            CheckAbsensiStatus()
            LoadHistory()
        End Sub

        Private Sub UpdateClock()
            lblDateTime.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy")
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss")
        End Sub

        Private Sub tmrClock_Tick(sender As Object, e As EventArgs) Handles tmrClock.Tick
            UpdateClock()
        End Sub

        Private Sub tmrRefresh_Tick(sender As Object, e As EventArgs) Handles tmrRefresh.Tick
            CheckAbsensiStatus()
            LoadHistory()
        End Sub

        Private Sub CheckAbsensiStatus()
            If CurrentUser Is Nothing OrElse Not CurrentUser.KaryawanID.HasValue Then
                lblStatusIcon.Text = "⚠️"
                lblStatusInfo.Text = "Akun tidak terhubung dengan data karyawan"
                lblStatusInfo.ForeColor = Color.Red
                btnAbsenMasuk.Enabled = False
                btnAbsenPulang.Enabled = False
                Return
            End If

            Dim hasCheckedIn As Boolean = DashboardService.HasCheckedInToday(CurrentUser.KaryawanID.Value)
            Dim hasCheckedOut As Boolean = DashboardService.HasCheckedOutToday(CurrentUser.KaryawanID.Value)

            If Not hasCheckedIn Then
                ' Belum absen masuk
                lblStatusIcon.Text = "⏰"
                lblStatusInfo.Text = "Anda belum melakukan absen masuk hari ini"
                lblStatusInfo.ForeColor = Color.FromArgb(220, 53, 69)
                btnAbsenMasuk.Enabled = True
                btnAbsenMasuk.BackColor = Color.FromArgb(25, 135, 84)
                btnAbsenPulang.Enabled = False
                btnAbsenPulang.BackColor = Color.Gray
                lblAbsenInfo.Text = "Silakan klik tombol ABSEN MASUK untuk memulai"

            ElseIf hasCheckedIn And Not hasCheckedOut Then
                ' Sudah masuk, belum pulang
                lblStatusIcon.Text = "✅"
                lblStatusInfo.Text = "Sudah absen masuk! Silakan absen pulang saat selesai bekerja."
                lblStatusInfo.ForeColor = Color.FromArgb(25, 135, 84)
                btnAbsenMasuk.Enabled = False
                btnAbsenMasuk.BackColor = Color.Gray
                btnAbsenPulang.Enabled = True
                btnAbsenPulang.BackColor = Color.FromArgb(220, 53, 69)
                lblAbsenInfo.Text = "Klik tombol ABSEN PULANG saat selesai bekerja"

            Else
                ' Sudah pulang
                lblStatusIcon.Text = "🎉"
                lblStatusInfo.Text = "Absensi hari ini sudah lengkap (Masuk & Pulang). Terima kasih!"
                lblStatusInfo.ForeColor = Color.FromArgb(0, 122, 204)
                btnAbsenMasuk.Enabled = False
                btnAbsenMasuk.BackColor = Color.Gray
                btnAbsenPulang.Enabled = False
                btnAbsenPulang.BackColor = Color.Gray
                lblAbsenInfo.Text = "Sampai jumpa besok! 👋"
            End If
        End Sub

        Private Sub LoadHistory()
            If CurrentUser Is Nothing OrElse Not CurrentUser.KaryawanID.HasValue Then
                Return
            End If

            Try
                Dim query As String = "
                    SELECT 
                        a.Tanggal,
                        COALESCE(s.NamaShift, '-') AS Shift,
                        CASE 
                            WHEN a.JamMasuk IS NOT NULL THEN strftime('%H:%M', a.JamMasuk)
                            ELSE '-'
                        END AS JamMasuk,
                        CASE 
                            WHEN a.JamPulang IS NOT NULL THEN strftime('%H:%M', a.JamPulang)
                            ELSE '-'
                        END AS JamPulang,
                        CASE 
                            WHEN a.TelatMenit > 0 THEN 'Terlambat ' || a.TelatMenit || ' menit'
                            WHEN a.Status = 'H' THEN 'Hadir'
                            WHEN a.Status = 'I' THEN 'Izin'
                            WHEN a.Status = 'S' THEN 'Sakit'
                            WHEN a.Status = 'C' THEN 'Cuti'
                            WHEN a.Status = 'A' THEN 'Alpha'
                            ELSE '-'
                        END AS Status
                    FROM tblAbsensi a
                    LEFT JOIN tblShift s ON a.IDShift = s.IDShift
                    WHERE a.KaryawanID = @KaryawanID
                    AND a.Tanggal >= date('now', '-7 days')
                    ORDER BY a.Tanggal DESC
                "
                Dim params As New Dictionary(Of String, Object)
                params.Add("@KaryawanID", CurrentUser.KaryawanID.Value)
                Dim dt As DataTable = DatabaseHelper.ExecuteDataTable(query, params)
                dgvHistory.DataSource = dt

                ' Set column headers
                If dgvHistory.Columns.Contains("Tanggal") Then dgvHistory.Columns("Tanggal").HeaderText = "Tanggal"
                If dgvHistory.Columns.Contains("Shift") Then dgvHistory.Columns("Shift").HeaderText = "Shift"
                If dgvHistory.Columns.Contains("JamMasuk") Then dgvHistory.Columns("JamMasuk").HeaderText = "Jam Masuk"
                If dgvHistory.Columns.Contains("JamPulang") Then dgvHistory.Columns("JamPulang").HeaderText = "Jam Pulang"
                If dgvHistory.Columns.Contains("Status") Then dgvHistory.Columns("Status").HeaderText = "Status"

            Catch ex As Exception
                ' Silent fail for history
            End Try
        End Sub

        Private Sub btnAbsenMasuk_Click(sender As Object, e As EventArgs) Handles btnAbsenMasuk.Click
            If Not CurrentUser.KaryawanID.HasValue Then
                MessageBox.Show("Akun tidak terhubung dengan data karyawan!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            Try
                ' Auto-detect shift based on current time
                Dim shiftID As Integer = 1
                Dim currentTime As TimeSpan = DateTime.Now.TimeOfDay
                Dim dtShift As DataTable = DatabaseHelper.ExecuteDataTable("SELECT IDShift, JamMasuk, JamPulang FROM tblShift")

                For Each row As DataRow In dtShift.Rows
                    Dim vMasuk = row("JamMasuk")
                    Dim vPulang = row("JamPulang")
                    Dim masuk As TimeSpan
                    Dim pulang As TimeSpan

                    If TypeOf vMasuk Is TimeSpan Then
                        masuk = DirectCast(vMasuk, TimeSpan)
                    Else
                        TimeSpan.TryParse(vMasuk.ToString(), masuk)
                    End If

                    If TypeOf vPulang Is TimeSpan Then
                        pulang = DirectCast(vPulang, TimeSpan)
                    Else
                        TimeSpan.TryParse(vPulang.ToString(), pulang)
                    End If

                    If masuk <= pulang Then
                        If currentTime >= masuk AndAlso currentTime < pulang Then
                            shiftID = Convert.ToInt32(row("IDShift"))
                            Exit For
                        End If
                    Else
                        If currentTime >= masuk OrElse currentTime < pulang Then
                            shiftID = Convert.ToInt32(row("IDShift"))
                            Exit For
                        End If
                    End If
                Next

                Dim query As String = "INSERT INTO tblAbsensi (Tanggal, KaryawanID, IDShift, JamMasuk, Status) VALUES (@Tanggal, @KaryawanID, @IDShift, @JamMasuk, 'H')"
                Dim params As New Dictionary(Of String, Object)
                params.Add("@Tanggal", DateTime.Today.ToString("yyyy-MM-dd"))
                params.Add("@KaryawanID", CurrentUser.KaryawanID.Value)
                params.Add("@IDShift", shiftID)
                params.Add("@JamMasuk", DateTime.Now)

                DatabaseHelper.ExecuteNonQuery(query, params)
                MessageBox.Show("✅ Berhasil Absen Masuk!" & vbCrLf & vbCrLf & "Waktu: " & DateTime.Now.ToString("HH:mm:ss"), "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                CheckAbsensiStatus()
                LoadHistory()

            Catch ex As Exception
                MessageBox.Show("Error saat absen masuk: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub

        Private Sub btnAbsenPulang_Click(sender As Object, e As EventArgs) Handles btnAbsenPulang.Click
            If Not CurrentUser.KaryawanID.HasValue Then
                MessageBox.Show("Akun tidak terhubung dengan data karyawan!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            Try
                Dim query As String = "UPDATE tblAbsensi SET JamPulang = @JamPulang WHERE KaryawanID = @KaryawanID AND Tanggal = @Tanggal"
                Dim params As New Dictionary(Of String, Object)
                params.Add("@JamPulang", DateTime.Now)
                params.Add("@KaryawanID", CurrentUser.KaryawanID.Value)
                params.Add("@Tanggal", DateTime.Today.ToString("yyyy-MM-dd"))

                DatabaseHelper.ExecuteNonQuery(query, params)
                MessageBox.Show("✅ Berhasil Absen Pulang!" & vbCrLf & vbCrLf & "Waktu: " & DateTime.Now.ToString("HH:mm:ss") & vbCrLf & "Terima kasih, sampai jumpa besok!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                CheckAbsensiStatus()
                LoadHistory()

            Catch ex As Exception
                MessageBox.Show("Error saat absen pulang: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub

        ' ==========================================
        ' Menu Click Handlers
        ' ==========================================

        Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
            Dim loginForm As New LoginForm()
            loginForm.Show()
            Me.Close()
        End Sub

        Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
            Application.Exit()
        End Sub

        Private Sub AbsensiSelfToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AbsensiSelfToolStripMenuItem.Click
            If CurrentUser.KaryawanID.HasValue Then
                Dim frm As New Transaksi.AbsensiSelfForm(CurrentUser.KaryawanID.Value)
                frm.ShowDialog()
                CheckAbsensiStatus()
                LoadHistory()
            Else
                MessageBox.Show("Akun anda tidak terhubung dengan data Karyawan!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End Sub

        Private Sub IzinCutiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IzinCutiToolStripMenuItem.Click
            Dim frm As New Transaksi.IzinCutiForm()
            frm.ShowDialog()
        End Sub

        Private Sub LaporanSayaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaporanSayaToolStripMenuItem.Click
            Dim frm As New Laporan.LaporanForm()
            frm.ShowDialog()
        End Sub

        Private Sub MainFormKaryawan_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
            ' Form closed
        End Sub

        Private Sub pnlHeader_Paint(sender As Object, e As PaintEventArgs) Handles pnlHeader.Paint

        End Sub
    End Class
End Namespace

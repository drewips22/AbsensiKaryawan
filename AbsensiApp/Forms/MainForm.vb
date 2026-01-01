Imports AbsensiApp.Models
Imports AbsensiApp.Services
Imports AbsensiApp.Utils

Namespace Forms
    ''' <summary>
    ''' MainForm untuk Admin, HR, dan Atasan
    ''' Karyawan menggunakan MainFormKaryawan
    ''' </summary>
    Public Class MainForm
        <System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)>
        Public Property CurrentUser As User

        Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            If CurrentUser IsNot Nothing Then
                Dim displayName As String = CurrentUser.Username
                If CurrentUser.KaryawanID.HasValue Then
                    Dim karyawanName As String = DashboardService.GetKaryawanName(CurrentUser.KaryawanID.Value)
                    If Not String.IsNullOrEmpty(karyawanName) Then
                        displayName = karyawanName
                    End If
                End If
                lblWelcome.Text = "Selamat Datang, " & displayName & "!"
                ApplyRolePermissions()
                SetupDashboard()
                LoadDashboardData()
            Else
                lblWelcome.Text = "Selamat Datang, Tamu"
                DisableAllMenus()
            End If
            UpdateClock()
        End Sub

        Private Sub ApplyRolePermissions()
            ' Default: Hide all restricted menus
            MasterDataToolStripMenuItem.Visible = False
            TransaksiToolStripMenuItem.Visible = False
            AdminToolStripMenuItem.Visible = False
            LaporanToolStripMenuItem.Visible = True

            Select Case CurrentUser.Role
                Case "Admin"
                    MasterDataToolStripMenuItem.Visible = True
                    AdminToolStripMenuItem.Visible = True
                    TransaksiToolStripMenuItem.Visible = True
                    InputAbsensiToolStripMenuItem.Visible = True
                    AbsensiSelfToolStripMenuItem.Visible = False

                Case "HR"
                    MasterDataToolStripMenuItem.Visible = True
                    TransaksiToolStripMenuItem.Visible = True
                    InputAbsensiToolStripMenuItem.Visible = True
                    AbsensiSelfToolStripMenuItem.Visible = False

                Case "Atasan"
                    LaporanToolStripMenuItem.Visible = True
                    TransaksiToolStripMenuItem.Visible = True
                    InputAbsensiToolStripMenuItem.Visible = False
                    AbsensiSelfToolStripMenuItem.Visible = False
                    IzinCutiToolStripMenuItem.Visible = True
            End Select
        End Sub

        Private Sub SetupDashboard()
            ' Show dashboard for Admin/HR/Atasan
            pnlStats.Visible = True
            pnlContent.Visible = True
            pnlEmployeeStatus.Visible = False
            btnAbsenMasuk.Visible = False
            btnAbsenPulang.Visible = False

            Select Case CurrentUser.Role
                Case "Admin", "HR"
                    btnInputAbsensi.Visible = True
                    lblAbsensiTitle.Text = "📋 Absensi Hari Ini - Semua Karyawan"

                Case "Atasan"
                    btnInputAbsensi.Visible = False
                    lblAbsensiTitle.Text = "📋 Absensi Hari Ini"
            End Select
        End Sub

        Private Sub LoadDashboardData()
            Try
                ' Load statistics
                lblKaryawanCount.Text = DashboardService.GetTotalKaryawanAktif().ToString()
                lblHadirCount.Text = DashboardService.GetHadirHariIni().ToString()
                lblTerlambatCount.Text = DashboardService.GetTerlambatHariIni().ToString()
                lblPendingCount.Text = DashboardService.GetPendingCuti().ToString()

                ' Load attendance table
                Dim dt As DataTable = DashboardService.GetAbsensiHariIni()
                dgvAbsensi.DataSource = dt

                ' Hide ID column if exists
                If dgvAbsensi.Columns.Contains("IDAbsensi") Then
                    dgvAbsensi.Columns("IDAbsensi").Visible = False
                End If

                ' Set column headers
                If dgvAbsensi.Columns.Contains("NIK") Then dgvAbsensi.Columns("NIK").HeaderText = "NIK"
                If dgvAbsensi.Columns.Contains("Nama") Then dgvAbsensi.Columns("Nama").HeaderText = "Nama Karyawan"
                If dgvAbsensi.Columns.Contains("Departemen") Then dgvAbsensi.Columns("Departemen").HeaderText = "Departemen"
                If dgvAbsensi.Columns.Contains("JamMasuk") Then dgvAbsensi.Columns("JamMasuk").HeaderText = "Jam Masuk"
                If dgvAbsensi.Columns.Contains("JamPulang") Then dgvAbsensi.Columns("JamPulang").HeaderText = "Jam Pulang"
                If dgvAbsensi.Columns.Contains("Status") Then dgvAbsensi.Columns("Status").Visible = False
                If dgvAbsensi.Columns.Contains("TelatMenit") Then dgvAbsensi.Columns("TelatMenit").Visible = False
                If dgvAbsensi.Columns.Contains("StatusDisplay") Then dgvAbsensi.Columns("StatusDisplay").HeaderText = "Status"

            Catch ex As Exception
                MessageBox.Show("Error loading dashboard: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub

        Private Sub DisableAllMenus()
            MasterDataToolStripMenuItem.Visible = False
            TransaksiToolStripMenuItem.Visible = False
            LaporanToolStripMenuItem.Visible = False
            AdminToolStripMenuItem.Visible = False
        End Sub

        Private Sub UpdateClock()
            lblDateTime.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy")
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss")
        End Sub

        Private Sub tmrClock_Tick(sender As Object, e As EventArgs) Handles tmrClock.Tick
            UpdateClock()
        End Sub

        Private Sub tmrRefresh_Tick(sender As Object, e As EventArgs) Handles tmrRefresh.Tick
            LoadDashboardData()
        End Sub

        Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
            LoadDashboardData()
            MessageBox.Show("Data berhasil diperbarui!", "Refresh", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Sub

        Private Sub btnInputAbsensi_Click(sender As Object, e As EventArgs) Handles btnInputAbsensi.Click
            Dim frm As New Transaksi.InputAbsensiForm()
            frm.ShowDialog()
            LoadDashboardData()
        End Sub

        Private Sub btnLihatLaporan_Click(sender As Object, e As EventArgs) Handles btnLihatLaporan.Click
            Dim frm As New Laporan.LaporanForm()
            frm.ShowDialog()
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

        Private Sub MainForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
            ' Form closed
        End Sub

        Private Sub KaryawanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KaryawanToolStripMenuItem.Click
            Dim frm As New Master.KaryawanForm()
            frm.ShowDialog()
            LoadDashboardData()
        End Sub

        Private Sub DepartemenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DepartemenToolStripMenuItem.Click
            Dim frm As New Master.DepartemenForm()
            frm.ShowDialog()
        End Sub

        Private Sub JabatanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JabatanToolStripMenuItem.Click
            Dim frm As New Master.JabatanForm()
            frm.ShowDialog()
        End Sub

        Private Sub ShiftToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShiftToolStripMenuItem.Click
            Dim frm As New Master.ShiftForm()
            frm.ShowDialog()
        End Sub

        Private Sub InputAbsensiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InputAbsensiToolStripMenuItem.Click
            Dim frm As New Transaksi.InputAbsensiForm()
            frm.ShowDialog()
            LoadDashboardData()
        End Sub

        Private Sub IzinCutiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IzinCutiToolStripMenuItem.Click
            Dim frm As New Transaksi.IzinCutiForm()
            frm.ShowDialog()
            LoadDashboardData()
        End Sub

        Private Sub AbsensiSelfToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AbsensiSelfToolStripMenuItem.Click
            ' This shouldn't be called from Admin form, but keep for safety
            MessageBox.Show("Fitur ini hanya tersedia untuk role Karyawan.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Sub

        Private Sub LaporanHarianToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaporanHarianToolStripMenuItem.Click
            Dim frm As New Laporan.LaporanForm()
            frm.ShowDialog()
        End Sub

        Private Sub LaporanBulananToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaporanBulananToolStripMenuItem.Click
            Dim frm As New Laporan.LaporanForm()
            frm.ShowDialog()
        End Sub

        Private Sub ManajemenUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManajemenUserToolStripMenuItem.Click
            Dim frm As New Admin.ManajemenUserForm()
            frm.ShowDialog()
        End Sub

        ' Empty event handlers (can be removed if not needed by designer)
        Private Sub lblKaryawanCount_Click(sender As Object, e As EventArgs) Handles lblKaryawanCount.Click
        End Sub

        Private Sub lblKaryawanTitle_Click(sender As Object, e As EventArgs) Handles lblKaryawanTitle.Click
        End Sub

        Private Sub lblPendingIcon_Click(sender As Object, e As EventArgs) Handles lblPendingIcon.Click
        End Sub

        Private Sub lblWelcome_Click(sender As Object, e As EventArgs) Handles lblWelcome.Click
        End Sub
    End Class
End Namespace

Imports AbsensiApp.Models

Namespace Forms
    Public Class MainForm
        <System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)>
        Public Property CurrentUser As User

        Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            If CurrentUser IsNot Nothing Then
                lblWelcome.Text = "Selamat Datang, " & CurrentUser.Username & " (" & CurrentUser.Role & ")"
                ApplyRolePermissions()
            Else
                ' Fallback if opened without login (should not happen in prod)
                lblWelcome.Text = "Selamat Datang, Tamu"
                DisableAllMenus()
            End If
        End Sub

        Private Sub ApplyRolePermissions()
            ' Default: Hide all restricted menus
            MasterDataToolStripMenuItem.Visible = False
            TransaksiToolStripMenuItem.Visible = False
            AdminToolStripMenuItem.Visible = False
            LaporanToolStripMenuItem.Visible = True ' Everyone can see reports (filtered later)

            Select Case CurrentUser.Role
                Case "Admin"
                    MasterDataToolStripMenuItem.Visible = True
                    AdminToolStripMenuItem.Visible = True
                    TransaksiToolStripMenuItem.Visible = True
                    InputAbsensiToolStripMenuItem.Visible = True
                    AbsensiSelfToolStripMenuItem.Visible = False ' Admin doesn't self-absen usually

                Case "HR"
                    MasterDataToolStripMenuItem.Visible = True
                    TransaksiToolStripMenuItem.Visible = True
                    InputAbsensiToolStripMenuItem.Visible = True
                    AbsensiSelfToolStripMenuItem.Visible = False

                Case "Atasan"
                    LaporanToolStripMenuItem.Visible = True

                Case "Karyawan"
                    TransaksiToolStripMenuItem.Visible = True
                    InputAbsensiToolStripMenuItem.Visible = False ' Karyawan cannot input manual attendance for others
                    AbsensiSelfToolStripMenuItem.Visible = True
                    IzinCutiToolStripMenuItem.Visible = True
                    LaporanToolStripMenuItem.Visible = True ' Can see own reports
            End Select
        End Sub

        Private Sub DisableAllMenus()
            MasterDataToolStripMenuItem.Visible = False
            TransaksiToolStripMenuItem.Visible = False
            LaporanToolStripMenuItem.Visible = False
            AdminToolStripMenuItem.Visible = False
        End Sub

        Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
            Dim loginForm As New LoginForm()
            loginForm.Show()
            Me.Close()
        End Sub

        Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
            Application.Exit()
        End Sub

        Private Sub MainForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
            ' Ensure application exits if main form is closed (unless logging out)
            ' Note: Logout handles this by showing login form first
        End Sub

        Private Sub KaryawanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KaryawanToolStripMenuItem.Click
            Dim frm As New Master.KaryawanForm()
            frm.ShowDialog()
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
        End Sub

        Private Sub IzinCutiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IzinCutiToolStripMenuItem.Click
            Dim frm As New Transaksi.IzinCutiForm()
            frm.ShowDialog()
        End Sub

        Private Sub AbsensiSelfToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AbsensiSelfToolStripMenuItem.Click
            If CurrentUser.KaryawanID.HasValue Then
                Dim frm As New Transaksi.AbsensiSelfForm(CurrentUser.KaryawanID.Value)
                frm.ShowDialog()
            Else
                MessageBox.Show("Akun anda tidak terhubung dengan data Karyawan!", "Error")
            End If
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

        Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

        End Sub
    End Class
End Namespace

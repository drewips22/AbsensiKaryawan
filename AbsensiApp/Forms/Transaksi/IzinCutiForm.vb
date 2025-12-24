Imports AbsensiApp.Utils

Imports AbsensiApp.Models

Namespace Forms.Transaksi
    Public Class IzinCutiForm
        Private _currentUser As User
        Private dgvRequests As DataGridView

        Public Sub New()
            InitializeComponent()
            InitializeCustomUI()
        End Sub

        Private Sub InitializeCustomUI()
            ' Add DataGridView for history/approvals
            dgvRequests = New DataGridView()
            dgvRequests.Location = New Point(20, 250)
            dgvRequests.Size = New Size(740, 300)
            dgvRequests.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
            dgvRequests.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            dgvRequests.AllowUserToAddRows = False
            dgvRequests.ReadOnly = True
            dgvRequests.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            Me.Controls.Add(dgvRequests)

            ' Add Context Menu for Approval (Admin only)
            Dim ctxMenu As New ContextMenuStrip()
            Dim itemApprove As New ToolStripMenuItem("Setujui")
            Dim itemReject As New ToolStripMenuItem("Tolak")
            AddHandler itemApprove.Click, AddressOf ApproveRequest
            AddHandler itemReject.Click, AddressOf RejectRequest
            ctxMenu.Items.Add(itemApprove)
            ctxMenu.Items.Add(itemReject)
            dgvRequests.ContextMenuStrip = ctxMenu
        End Sub

        Private Sub IzinCutiForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            LoadKaryawan()
            
            Dim mainForm As MainForm = CType(Application.OpenForms("MainForm"), MainForm)
            _currentUser = mainForm.CurrentUser

            If _currentUser.Role = "Karyawan" Then
                ' Karyawan View: Request Form + Own History
                If _currentUser.KaryawanID.HasValue Then
                    cmbKaryawan.SelectedValue = _currentUser.KaryawanID.Value
                    cmbKaryawan.Enabled = False
                Else
                    MessageBox.Show("Akun anda tidak terhubung dengan data Karyawan!", "Error")
                    Me.Close()
                End If
                dgvRequests.ContextMenuStrip = Nothing ' No approval actions
            Else
                ' Admin/HR View: Approval List
                ' Hide input fields or make them optional/for admin override
                ' For simplicity, we keep input fields but focus on the list
            End If

            LoadRequests()
        End Sub

        Private Sub LoadKaryawan()
            Dim dt As DataTable = DatabaseHelper.ExecuteDataTable("SELECT KaryawanID, Nama FROM tblKaryawan WHERE Status = 'Aktif'")
            cmbKaryawan.DataSource = dt
            cmbKaryawan.DisplayMember = "Nama"
            cmbKaryawan.ValueMember = "KaryawanID"
        End Sub

        Private Sub LoadRequests()
            Dim query As String
            Dim params As New Dictionary(Of String, Object)

            If _currentUser.Role = "Karyawan" Then
                query = "SELECT IDIzin, TanggalMulai, TanggalSelesai, Jenis, Alasan, StatusPersetujuan, TanggalPengajuan " &
                        "FROM tblIzinCuti WHERE KaryawanID = @KaryawanID ORDER BY TanggalPengajuan DESC"
                params.Add("@KaryawanID", _currentUser.KaryawanID)
            Else
                query = "SELECT t.IDIzin, k.Nama, t.TanggalMulai, t.TanggalSelesai, t.Jenis, t.Alasan, t.StatusPersetujuan " &
                        "FROM tblIzinCuti t JOIN tblKaryawan k ON t.KaryawanID = k.KaryawanID " &
                        "ORDER BY CASE WHEN StatusPersetujuan = 'Pending' THEN 0 ELSE 1 END, t.TanggalPengajuan DESC"
            End If

            Dim dt As DataTable = DatabaseHelper.ExecuteDataTable(query, params)
            dgvRequests.DataSource = dt
        End Sub

        Private Sub btnAjukan_Click(sender As Object, e As EventArgs) Handles btnAjukan.Click
            If cmbKaryawan.SelectedIndex = -1 OrElse cmbJenis.SelectedIndex = -1 Then
                MessageBox.Show("Lengkapi data!")
                Return
            End If

            Dim query As String = "INSERT INTO tblIzinCuti (KaryawanID, TanggalMulai, TanggalSelesai, Jenis, Alasan, StatusPersetujuan) " &
                                  "VALUES (@KaryawanID, @Mulai, @Selesai, @Jenis, @Alasan, 'Pending')"
            
            Dim params As New Dictionary(Of String, Object)
            params.Add("@KaryawanID", cmbKaryawan.SelectedValue)
            params.Add("@Mulai", dtpMulai.Value.ToString("yyyy-MM-dd"))
            params.Add("@Selesai", dtpSelesai.Value.ToString("yyyy-MM-dd"))
            params.Add("@Jenis", cmbJenis.SelectedItem.ToString())
            params.Add("@Alasan", txtAlasan.Text)

            DatabaseHelper.ExecuteNonQuery(query, params)
            MessageBox.Show("Pengajuan berhasil disimpan!")
            LoadRequests()
            txtAlasan.Clear()
        End Sub

        Private Sub ApproveRequest(sender As Object, e As EventArgs)
            UpdateStatus("Disetujui")
        End Sub

        Private Sub RejectRequest(sender As Object, e As EventArgs)
            UpdateStatus("Ditolak")
        End Sub

        Private Sub UpdateStatus(status As String)
            If dgvRequests.SelectedRows.Count > 0 Then
                Dim idIzin As Integer = Convert.ToInt32(dgvRequests.SelectedRows(0).Cells("IDIzin").Value)
                Dim query As String = "UPDATE tblIzinCuti SET StatusPersetujuan = @Status, DisetujuiOleh = @UserID, TanggalPersetujuan = @Date WHERE IDIzin = @ID"
                
                Dim params As New Dictionary(Of String, Object)
                params.Add("@Status", status)
                params.Add("@UserID", _currentUser.UserID)
                params.Add("@Date", DateTime.Now)
                params.Add("@ID", idIzin)

                DatabaseHelper.ExecuteNonQuery(query, params)
                MessageBox.Show("Status berhasil diubah menjadi " & status)
                LoadRequests()
            End If
        End Sub
    End Class
End Namespace

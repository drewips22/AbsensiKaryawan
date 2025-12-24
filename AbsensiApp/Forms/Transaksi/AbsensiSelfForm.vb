Imports AbsensiApp.Utils
Imports AbsensiApp.Models

Namespace Forms.Transaksi
    Public Class AbsensiSelfForm
        Inherits Form

        Private _karyawanID As Integer
        Private lblDate As New Label()
        Private lblTime As New Label()
        Private lblStatus As New Label()
        Private btnMasuk As New Button()
        Private btnPulang As New Button()
        Private Timer1 As New Timer()

        Public Sub New(karyawanID As Integer)
            InitializeComponent()
            _karyawanID = karyawanID
        End Sub

        Private Sub InitializeComponent()
            Me.Text = "Absensi Mandiri"
            Me.Size = New Size(500, 400)
            Me.StartPosition = FormStartPosition.CenterParent
            Me.BackColor = Color.White
            Me.FormBorderStyle = FormBorderStyle.FixedDialog
            Me.MaximizeBox = False

            ' Main Container
            Dim panel As New Panel()
            panel.Dock = DockStyle.Fill
            panel.Padding = New Padding(20)
            Me.Controls.Add(panel)

            ' Date Label
            lblDate.Font = New Font("Segoe UI", 12)
            lblDate.TextAlign = ContentAlignment.MiddleCenter
            lblDate.Dock = DockStyle.Top
            lblDate.Height = 30
            panel.Controls.Add(lblDate)

            ' Time Label
            lblTime.Font = New Font("Segoe UI", 32, FontStyle.Bold)
            lblTime.TextAlign = ContentAlignment.MiddleCenter
            lblTime.Dock = DockStyle.Top
            lblTime.Height = 80
            lblTime.ForeColor = Color.FromArgb(0, 122, 204)
            panel.Controls.Add(lblTime)

            ' Status Label
            lblStatus.Font = New Font("Segoe UI", 14, FontStyle.Bold)
            lblStatus.TextAlign = ContentAlignment.MiddleCenter
            lblStatus.Dock = DockStyle.Top
            lblStatus.Height = 40
            panel.Controls.Add(lblStatus)

            ' Buttons Panel
            Dim btnPanel As New FlowLayoutPanel()
            btnPanel.Dock = DockStyle.Top
            btnPanel.Height = 100
            btnPanel.FlowDirection = FlowDirection.LeftToRight
            btnPanel.Padding = New Padding(40, 20, 0, 0)
            panel.Controls.Add(btnPanel)

            ' Button Masuk
            btnMasuk.Text = "MASUK"
            btnMasuk.Size = New Size(180, 60)
            btnMasuk.BackColor = Color.FromArgb(40, 167, 69)
            btnMasuk.ForeColor = Color.White
            btnMasuk.Font = New Font("Segoe UI", 14, FontStyle.Bold)
            btnMasuk.FlatStyle = FlatStyle.Flat
            btnMasuk.FlatAppearance.BorderSize = 0
            btnPanel.Controls.Add(btnMasuk)

            ' Button Pulang
            btnPulang.Text = "PULANG"
            btnPulang.Size = New Size(180, 60)
            btnPulang.BackColor = Color.FromArgb(220, 53, 69)
            btnPulang.ForeColor = Color.White
            btnPulang.Font = New Font("Segoe UI", 14, FontStyle.Bold)
            btnPulang.FlatStyle = FlatStyle.Flat
            btnPulang.FlatAppearance.BorderSize = 0
            btnPanel.Controls.Add(btnPulang)

            ' Timer
            Timer1.Interval = 1000
            Timer1.Enabled = True
            
            ' Event Handlers
            AddHandler Timer1.Tick, AddressOf Timer1_Tick
            AddHandler btnMasuk.Click, AddressOf btnMasuk_Click
            AddHandler btnPulang.Click, AddressOf btnPulang_Click
        End Sub

        Private Sub AbsensiSelfForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            UpdateClock()
            CheckStatus()
        End Sub

        Private Sub Timer1_Tick(sender As Object, e As EventArgs)
            UpdateClock()
        End Sub

        Private Sub UpdateClock()
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss")
            lblDate.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy")
        End Sub

        Private Sub CheckStatus()
            Dim query As String = "SELECT * FROM tblAbsensi WHERE KaryawanID = @ID AND Tanggal = @Tanggal"
            Dim params As New Dictionary(Of String, Object)
            params.Add("@ID", _karyawanID)
            params.Add("@Tanggal", DateTime.Today.ToString("yyyy-MM-dd"))

            Dim dt As DataTable = DatabaseHelper.ExecuteDataTable(query, params)
            If dt.Rows.Count > 0 Then
                Dim row As DataRow = dt.Rows(0)
                If IsDBNull(row("JamPulang")) Then
                    btnMasuk.Enabled = False
                    btnMasuk.BackColor = Color.Gray
                    btnPulang.Enabled = True
                    btnPulang.BackColor = Color.FromArgb(220, 53, 69)
                    lblStatus.Text = "Status: Sudah Masuk (" & CType(row("JamMasuk"), DateTime).ToString("HH:mm") & ")"
                    lblStatus.ForeColor = Color.FromArgb(40, 167, 69)
                Else
                    btnMasuk.Enabled = False
                    btnMasuk.BackColor = Color.Gray
                    btnPulang.Enabled = False
                    btnPulang.BackColor = Color.Gray
                    lblStatus.Text = "Status: Sudah Pulang (" & CType(row("JamPulang"), DateTime).ToString("HH:mm") & ")"
                    lblStatus.ForeColor = Color.FromArgb(0, 122, 204)
                End If
            Else
                btnMasuk.Enabled = True
                btnMasuk.BackColor = Color.FromArgb(40, 167, 69)
                btnPulang.Enabled = False
                btnPulang.BackColor = Color.Gray
                lblStatus.Text = "Status: Belum Absen"
                lblStatus.ForeColor = Color.Black
            End If
        End Sub

        Private Sub btnMasuk_Click(sender As Object, e As EventArgs)
            ' Auto-detect shift based on current time
            Dim shiftID As Integer = 1 ' fallback
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
                    ' Normal shift (e.g. 07:00 - 15:00)
                    If currentTime >= masuk AndAlso currentTime < pulang Then
                        shiftID = Convert.ToInt32(row("IDShift"))
                        Exit For
                    End If
                Else
                    ' Overnight shift (e.g. 23:00 - 07:00)
                    If currentTime >= masuk OrElse currentTime < pulang Then
                        shiftID = Convert.ToInt32(row("IDShift"))
                        Exit For
                    End If
                End If
            Next
            
            Dim query As String = "INSERT INTO tblAbsensi (Tanggal, KaryawanID, IDShift, JamMasuk, Status) VALUES (@Tanggal, @KaryawanID, @IDShift, @JamMasuk, 'H')"
            Dim params As New Dictionary(Of String, Object)
            params.Add("@Tanggal", DateTime.Today.ToString("yyyy-MM-dd"))
            params.Add("@KaryawanID", _karyawanID)
            params.Add("@IDShift", shiftID)
            params.Add("@JamMasuk", DateTime.Now)

            DatabaseHelper.ExecuteNonQuery(query, params)
            MessageBox.Show("Berhasil Absen Masuk!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            CheckStatus()
        End Sub

        Private Sub btnPulang_Click(sender As Object, e As EventArgs)
            Dim query As String = "UPDATE tblAbsensi SET JamPulang = @JamPulang WHERE KaryawanID = @KaryawanID AND Tanggal = @Tanggal"
            Dim params As New Dictionary(Of String, Object)
            params.Add("@JamPulang", DateTime.Now)
            params.Add("@KaryawanID", _karyawanID)
            params.Add("@Tanggal", DateTime.Today.ToString("yyyy-MM-dd"))

            DatabaseHelper.ExecuteNonQuery(query, params)
            MessageBox.Show("Berhasil Absen Pulang!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            CheckStatus()
        End Sub
    End Class
End Namespace

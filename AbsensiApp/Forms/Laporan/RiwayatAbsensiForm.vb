Imports System.Data.SQLite
Imports AbsensiApp.Utils
Imports AbsensiApp.Models

Namespace Forms.Laporan
    Public Class RiwayatAbsensiForm
        Inherits Form

        Private _karyawanID As Integer
        Private dgvRiwayat As DataGridView
        Private lblSummary As Label

        Public Sub New(karyawanID As Integer)
            _karyawanID = karyawanID
            InitializeComponent()
            LoadRiwayat()
        End Sub

        Private Sub InitializeComponent()
            Me.Text = "Riwayat Absensi Saya"
            Me.Size = New Size(800, 600)
            Me.StartPosition = FormStartPosition.CenterParent
            Me.BackColor = Color.White

            ' Header
            Dim lblTitle As New Label()
            lblTitle.Text = "Riwayat Absensi"
            lblTitle.Font = New Font("Segoe UI", 16, FontStyle.Bold)
            lblTitle.Location = New Point(20, 20)
            lblTitle.AutoSize = True
            Me.Controls.Add(lblTitle)

            ' Summary Label
            lblSummary = New Label()
            lblSummary.Location = New Point(20, 60)
            lblSummary.AutoSize = True
            lblSummary.Font = New Font("Segoe UI", 10)
            Me.Controls.Add(lblSummary)

            ' DataGridView
            dgvRiwayat = New DataGridView()
            dgvRiwayat.Location = New Point(20, 100)
            dgvRiwayat.Size = New Size(740, 440)
            dgvRiwayat.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
            dgvRiwayat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            dgvRiwayat.AllowUserToAddRows = False
            dgvRiwayat.ReadOnly = True
            dgvRiwayat.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            dgvRiwayat.BackgroundColor = Color.WhiteSmoke
            dgvRiwayat.BorderStyle = BorderStyle.None
            dgvRiwayat.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 122, 204)
            dgvRiwayat.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
            dgvRiwayat.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 10, FontStyle.Bold)
            dgvRiwayat.EnableHeadersVisualStyles = False
            Me.Controls.Add(dgvRiwayat)
        End Sub

        Private Sub LoadRiwayat()
            Try
                Dim query As String = "SELECT Tanggal, JamMasuk, JamPulang, Status, TelatMenit, LemburMenit, Keterangan " &
                                      "FROM tblAbsensi WHERE KaryawanID = @KaryawanID ORDER BY Tanggal DESC"

                Dim params As New Dictionary(Of String, Object)
                params.Add("@KaryawanID", _karyawanID)

                Dim dt As DataTable = DatabaseHelper.ExecuteDataTable(query, params)
                dgvRiwayat.DataSource = dt

                ' Calculate Summary
                Dim hadir As Integer = 0
                Dim telat As Integer = 0

                For Each row As DataRow In dt.Rows
                    If row("Status").ToString() = "H" Then hadir += 1
                    If Convert.ToInt32(row("TelatMenit")) > 0 Then telat += 1
                Next

                lblSummary.Text = $"Total Hadir: {hadir} | Terlambat: {telat} kali"

            Catch ex As Exception
                MessageBox.Show("Error loading history: " & ex.Message)
            End Try
        End Sub
    End Class
End Namespace

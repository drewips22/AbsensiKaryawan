Namespace Forms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class MainFormKaryawan
        Inherits System.Windows.Forms.Form

        <System.Diagnostics.DebuggerNonUserCode()>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            Try
                If disposing AndAlso components IsNot Nothing Then
                    components.Dispose()
                End If
            Finally
                MyBase.Dispose(disposing)
            End Try
        End Sub

        Private components As System.ComponentModel.IContainer

        <System.Diagnostics.DebuggerStepThrough()>
        Private Sub InitializeComponent()
            components = New ComponentModel.Container()
            Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
            Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
            Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
            MenuStrip1 = New MenuStrip()
            FileToolStripMenuItem = New ToolStripMenuItem()
            LogoutToolStripMenuItem = New ToolStripMenuItem()
            ExitToolStripMenuItem = New ToolStripMenuItem()
            TransaksiToolStripMenuItem = New ToolStripMenuItem()
            AbsensiSelfToolStripMenuItem = New ToolStripMenuItem()
            IzinCutiToolStripMenuItem = New ToolStripMenuItem()
            LaporanToolStripMenuItem = New ToolStripMenuItem()
            LaporanSayaToolStripMenuItem = New ToolStripMenuItem()
            pnlMain = New Panel()
            pnlHistory = New Panel()
            dgvHistory = New DataGridView()
            lblHistoryTitle = New Label()
            pnlQuickAbsen = New Panel()
            lblAbsenInfo = New Label()
            btnAbsenPulang = New Button()
            btnAbsenMasuk = New Button()
            pnlStatusCard = New Panel()
            lblStatusInfo = New Label()
            lblStatusTitle = New Label()
            lblStatusIcon = New Label()
            pnlHeader = New Panel()
            lblTime = New Label()
            lblDateTime = New Label()
            lblWelcome = New Label()
            tmrClock = New Timer(components)
            tmrRefresh = New Timer(components)
            MenuStrip1.SuspendLayout()
            pnlMain.SuspendLayout()
            pnlHistory.SuspendLayout()
            CType(dgvHistory, ComponentModel.ISupportInitialize).BeginInit()
            pnlQuickAbsen.SuspendLayout()
            pnlStatusCard.SuspendLayout()
            pnlHeader.SuspendLayout()
            SuspendLayout()
            ' 
            ' MenuStrip1
            ' 
            MenuStrip1.BackColor = Color.FromArgb(CByte(25), CByte(135), CByte(84))
            MenuStrip1.ForeColor = Color.White
            MenuStrip1.ImageScalingSize = New Size(20, 20)
            MenuStrip1.Items.AddRange(New ToolStripItem() {FileToolStripMenuItem, TransaksiToolStripMenuItem, LaporanToolStripMenuItem})
            MenuStrip1.Location = New Point(0, 0)
            MenuStrip1.Name = "MenuStrip1"
            MenuStrip1.Padding = New Padding(7, 3, 0, 3)
            MenuStrip1.Size = New Size(1200, 30)
            MenuStrip1.TabIndex = 0
            ' 
            ' FileToolStripMenuItem
            ' 
            FileToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {LogoutToolStripMenuItem, ExitToolStripMenuItem})
            FileToolStripMenuItem.ForeColor = Color.White
            FileToolStripMenuItem.Name = "FileToolStripMenuItem"
            FileToolStripMenuItem.Size = New Size(46, 24)
            FileToolStripMenuItem.Text = "File"
            ' 
            ' LogoutToolStripMenuItem
            ' 
            LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
            LogoutToolStripMenuItem.Size = New Size(139, 26)
            LogoutToolStripMenuItem.Text = "Logout"
            ' 
            ' ExitToolStripMenuItem
            ' 
            ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
            ExitToolStripMenuItem.Size = New Size(139, 26)
            ExitToolStripMenuItem.Text = "Keluar"
            ' 
            ' TransaksiToolStripMenuItem
            ' 
            TransaksiToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {AbsensiSelfToolStripMenuItem, IzinCutiToolStripMenuItem})
            TransaksiToolStripMenuItem.ForeColor = Color.White
            TransaksiToolStripMenuItem.Name = "TransaksiToolStripMenuItem"
            TransaksiToolStripMenuItem.Size = New Size(74, 24)
            TransaksiToolStripMenuItem.Text = "Absensi"
            ' 
            ' AbsensiSelfToolStripMenuItem
            ' 
            AbsensiSelfToolStripMenuItem.Name = "AbsensiSelfToolStripMenuItem"
            AbsensiSelfToolStripMenuItem.Size = New Size(219, 26)
            AbsensiSelfToolStripMenuItem.Text = "Absensi Mandiri"
            ' 
            ' IzinCutiToolStripMenuItem
            ' 
            IzinCutiToolStripMenuItem.Name = "IzinCutiToolStripMenuItem"
            IzinCutiToolStripMenuItem.Size = New Size(219, 26)
            IzinCutiToolStripMenuItem.Text = "Pengajuan Izin/Cuti"
            ' 
            ' LaporanToolStripMenuItem
            ' 
            LaporanToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {LaporanSayaToolStripMenuItem})
            LaporanToolStripMenuItem.ForeColor = Color.White
            LaporanToolStripMenuItem.Name = "LaporanToolStripMenuItem"
            LaporanToolStripMenuItem.Size = New Size(77, 24)
            LaporanToolStripMenuItem.Text = "Laporan"
            ' 
            ' LaporanSayaToolStripMenuItem
            ' 
            LaporanSayaToolStripMenuItem.Name = "LaporanSayaToolStripMenuItem"
            LaporanSayaToolStripMenuItem.Size = New Size(181, 26)
            LaporanSayaToolStripMenuItem.Text = "Laporan Saya"
            ' 
            ' pnlMain
            ' 
            pnlMain.BackColor = Color.FromArgb(CByte(240), CByte(242), CByte(245))
            pnlMain.Controls.Add(pnlHistory)
            pnlMain.Controls.Add(pnlQuickAbsen)
            pnlMain.Controls.Add(pnlStatusCard)
            pnlMain.Controls.Add(pnlHeader)
            pnlMain.Dock = DockStyle.Fill
            pnlMain.Location = New Point(0, 30)
            pnlMain.Name = "pnlMain"
            pnlMain.Padding = New Padding(30)
            pnlMain.Size = New Size(1200, 670)
            pnlMain.TabIndex = 0
            ' 
            ' pnlHistory
            ' 
            pnlHistory.BackColor = Color.White
            pnlHistory.Controls.Add(dgvHistory)
            pnlHistory.Controls.Add(lblHistoryTitle)
            pnlHistory.Dock = DockStyle.Fill
            pnlHistory.Location = New Point(30, 400)
            pnlHistory.Name = "pnlHistory"
            pnlHistory.Padding = New Padding(25)
            pnlHistory.Size = New Size(1140, 240)
            pnlHistory.TabIndex = 0
            ' 
            ' dgvHistory
            ' 
            dgvHistory.AllowUserToAddRows = False
            dgvHistory.AllowUserToDeleteRows = False
            DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(248), CByte(249), CByte(250))
            dgvHistory.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            dgvHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            dgvHistory.BackgroundColor = Color.White
            dgvHistory.BorderStyle = BorderStyle.None
            dgvHistory.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
            DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(25), CByte(135), CByte(84))
            DataGridViewCellStyle2.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
            DataGridViewCellStyle2.ForeColor = Color.White
            DataGridViewCellStyle2.Padding = New Padding(10)
            DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
            DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
            DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
            dgvHistory.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
            dgvHistory.ColumnHeadersHeight = 45
            dgvHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
            DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle3.BackColor = SystemColors.Window
            DataGridViewCellStyle3.Font = New Font("Segoe UI", 10.0F)
            DataGridViewCellStyle3.ForeColor = SystemColors.ControlText
            DataGridViewCellStyle3.Padding = New Padding(5)
            DataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight
            DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText
            DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
            dgvHistory.DefaultCellStyle = DataGridViewCellStyle3
            dgvHistory.Dock = DockStyle.Fill
            dgvHistory.EnableHeadersVisualStyles = False
            dgvHistory.GridColor = Color.FromArgb(CByte(230), CByte(230), CByte(230))
            dgvHistory.Location = New Point(25, 70)
            dgvHistory.Name = "dgvHistory"
            dgvHistory.ReadOnly = True
            dgvHistory.RowHeadersVisible = False
            dgvHistory.RowHeadersWidth = 51
            dgvHistory.RowTemplate.Height = 40
            dgvHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            dgvHistory.Size = New Size(1090, 145)
            dgvHistory.TabIndex = 0
            ' 
            ' lblHistoryTitle
            ' 
            lblHistoryTitle.Dock = DockStyle.Top
            lblHistoryTitle.Font = New Font("Segoe UI", 14.0F, FontStyle.Bold)
            lblHistoryTitle.ForeColor = Color.FromArgb(CByte(45), CByte(52), CByte(64))
            lblHistoryTitle.Location = New Point(25, 25)
            lblHistoryTitle.Name = "lblHistoryTitle"
            lblHistoryTitle.Padding = New Padding(0, 10, 0, 0)
            lblHistoryTitle.Size = New Size(1090, 45)
            lblHistoryTitle.TabIndex = 1
            lblHistoryTitle.Text = "📅 Riwayat Absensi (7 Hari Terakhir)"
            ' 
            ' pnlQuickAbsen
            ' 
            pnlQuickAbsen.BackColor = Color.White
            pnlQuickAbsen.Controls.Add(lblAbsenInfo)
            pnlQuickAbsen.Controls.Add(btnAbsenPulang)
            pnlQuickAbsen.Controls.Add(btnAbsenMasuk)
            pnlQuickAbsen.Dock = DockStyle.Top
            pnlQuickAbsen.Location = New Point(30, 250)
            pnlQuickAbsen.Margin = New Padding(0, 15, 0, 0)
            pnlQuickAbsen.Name = "pnlQuickAbsen"
            pnlQuickAbsen.Padding = New Padding(25)
            pnlQuickAbsen.Size = New Size(1140, 150)
            pnlQuickAbsen.TabIndex = 1
            ' 
            ' lblAbsenInfo
            ' 
            lblAbsenInfo.Font = New Font("Segoe UI", 11.0F, FontStyle.Italic)
            lblAbsenInfo.ForeColor = Color.Gray
            lblAbsenInfo.Location = New Point(570, 65)
            lblAbsenInfo.Name = "lblAbsenInfo"
            lblAbsenInfo.Size = New Size(500, 30)
            lblAbsenInfo.TabIndex = 0
            lblAbsenInfo.Text = "Klik tombol untuk melakukan absensi"
            ' 
            ' btnAbsenPulang
            ' 
            btnAbsenPulang.BackColor = Color.FromArgb(CByte(220), CByte(53), CByte(69))
            btnAbsenPulang.Cursor = Cursors.Hand
            btnAbsenPulang.FlatAppearance.BorderSize = 0
            btnAbsenPulang.FlatStyle = FlatStyle.Flat
            btnAbsenPulang.Font = New Font("Segoe UI", 14.0F, FontStyle.Bold)
            btnAbsenPulang.ForeColor = Color.White
            btnAbsenPulang.Location = New Point(295, 40)
            btnAbsenPulang.Name = "btnAbsenPulang"
            btnAbsenPulang.Size = New Size(250, 80)
            btnAbsenPulang.TabIndex = 1
            btnAbsenPulang.Text = "🏠  ABSEN PULANG"
            btnAbsenPulang.UseVisualStyleBackColor = False
            ' 
            ' btnAbsenMasuk
            ' 
            btnAbsenMasuk.BackColor = Color.FromArgb(CByte(25), CByte(135), CByte(84))
            btnAbsenMasuk.Cursor = Cursors.Hand
            btnAbsenMasuk.FlatAppearance.BorderSize = 0
            btnAbsenMasuk.FlatStyle = FlatStyle.Flat
            btnAbsenMasuk.Font = New Font("Segoe UI", 14.0F, FontStyle.Bold)
            btnAbsenMasuk.ForeColor = Color.White
            btnAbsenMasuk.Location = New Point(25, 40)
            btnAbsenMasuk.Name = "btnAbsenMasuk"
            btnAbsenMasuk.Size = New Size(250, 80)
            btnAbsenMasuk.TabIndex = 2
            btnAbsenMasuk.Text = "🕐  ABSEN MASUK"
            btnAbsenMasuk.UseVisualStyleBackColor = False
            ' 
            ' pnlStatusCard
            ' 
            pnlStatusCard.BackColor = Color.White
            pnlStatusCard.Controls.Add(lblStatusInfo)
            pnlStatusCard.Controls.Add(lblStatusTitle)
            pnlStatusCard.Controls.Add(lblStatusIcon)
            pnlStatusCard.Dock = DockStyle.Top
            pnlStatusCard.Location = New Point(30, 130)
            pnlStatusCard.Name = "pnlStatusCard"
            pnlStatusCard.Padding = New Padding(25)
            pnlStatusCard.Size = New Size(1140, 120)
            pnlStatusCard.TabIndex = 2
            ' 
            ' lblStatusInfo
            ' 
            lblStatusInfo.Font = New Font("Segoe UI", 13.0F)
            lblStatusInfo.ForeColor = Color.Gray
            lblStatusInfo.Location = New Point(120, 60)
            lblStatusInfo.Name = "lblStatusInfo"
            lblStatusInfo.Size = New Size(700, 35)
            lblStatusInfo.TabIndex = 0
            lblStatusInfo.Text = "Memuat status..."
            ' 
            ' lblStatusTitle
            ' 
            lblStatusTitle.Font = New Font("Segoe UI", 16.0F, FontStyle.Bold)
            lblStatusTitle.ForeColor = Color.FromArgb(CByte(45), CByte(52), CByte(64))
            lblStatusTitle.Location = New Point(120, 25)
            lblStatusTitle.Name = "lblStatusTitle"
            lblStatusTitle.Size = New Size(400, 30)
            lblStatusTitle.TabIndex = 1
            lblStatusTitle.Text = "Status Absensi Hari Ini"
            ' 
            ' lblStatusIcon
            ' 
            lblStatusIcon.Font = New Font("Segoe UI Emoji", 40.0F)
            lblStatusIcon.Location = New Point(25, 20)
            lblStatusIcon.Name = "lblStatusIcon"
            lblStatusIcon.Size = New Size(80, 80)
            lblStatusIcon.TabIndex = 2
            lblStatusIcon.Text = "📋"
            lblStatusIcon.TextAlign = ContentAlignment.MiddleCenter
            ' 
            ' pnlHeader
            ' 
            pnlHeader.BackColor = Color.Transparent
            pnlHeader.Controls.Add(lblTime)
            pnlHeader.Controls.Add(lblDateTime)
            pnlHeader.Controls.Add(lblWelcome)
            pnlHeader.Dock = DockStyle.Top
            pnlHeader.Location = New Point(30, 30)
            pnlHeader.Name = "pnlHeader"
            pnlHeader.Size = New Size(1140, 100)
            pnlHeader.TabIndex = 3
            ' 
            ' lblTime
            ' 
            lblTime.Anchor = AnchorStyles.Top Or AnchorStyles.Right
            lblTime.Font = New Font("Segoe UI", 32.0F, FontStyle.Bold)
            lblTime.ForeColor = Color.FromArgb(CByte(25), CByte(135), CByte(84))
            lblTime.Location = New Point(1690, 40)
            lblTime.Name = "lblTime"
            lblTime.Size = New Size(400, 55)
            lblTime.TabIndex = 0
            lblTime.Text = "21:00:00"
            lblTime.TextAlign = ContentAlignment.TopRight
            ' 
            ' lblDateTime
            ' 
            lblDateTime.Anchor = AnchorStyles.Top Or AnchorStyles.Right
            lblDateTime.Font = New Font("Segoe UI", 12.0F)
            lblDateTime.ForeColor = Color.FromArgb(CByte(100), CByte(100), CByte(100))
            lblDateTime.Location = New Point(1690, 15)
            lblDateTime.Name = "lblDateTime"
            lblDateTime.Size = New Size(400, 25)
            lblDateTime.TabIndex = 1
            lblDateTime.Text = "Rabu, 1 Januari 2026"
            lblDateTime.TextAlign = ContentAlignment.TopRight
            ' 
            ' lblWelcome
            ' 
            lblWelcome.Font = New Font("Segoe UI", 22.0F, FontStyle.Bold)
            lblWelcome.ForeColor = Color.FromArgb(CByte(25), CByte(135), CByte(84))
            lblWelcome.Location = New Point(3, 10)
            lblWelcome.Name = "lblWelcome"
            lblWelcome.Size = New Size(700, 45)
            lblWelcome.TabIndex = 2
            lblWelcome.Text = "Selamat Datang!"
            ' 
            ' tmrClock
            ' 
            tmrClock.Enabled = True
            tmrClock.Interval = 1000
            ' 
            ' tmrRefresh
            ' 
            tmrRefresh.Enabled = True
            tmrRefresh.Interval = 30000
            ' 
            ' MainFormKaryawan
            ' 
            AutoScaleDimensions = New SizeF(8.0F, 20.0F)
            AutoScaleMode = AutoScaleMode.Font
            ClientSize = New Size(1200, 700)
            Controls.Add(pnlMain)
            Controls.Add(MenuStrip1)
            MainMenuStrip = MenuStrip1
            Name = "MainFormKaryawan"
            Text = "Portal Karyawan - Sistem Absensi"
            WindowState = FormWindowState.Maximized
            MenuStrip1.ResumeLayout(False)
            MenuStrip1.PerformLayout()
            pnlMain.ResumeLayout(False)
            pnlHistory.ResumeLayout(False)
            CType(dgvHistory, ComponentModel.ISupportInitialize).EndInit()
            pnlQuickAbsen.ResumeLayout(False)
            pnlStatusCard.ResumeLayout(False)
            pnlHeader.ResumeLayout(False)
            ResumeLayout(False)
            PerformLayout()
        End Sub

        ' Menu Items
        Friend WithEvents MenuStrip1 As MenuStrip
        Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
        Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
        Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
        Friend WithEvents TransaksiToolStripMenuItem As ToolStripMenuItem
        Friend WithEvents AbsensiSelfToolStripMenuItem As ToolStripMenuItem
        Friend WithEvents IzinCutiToolStripMenuItem As ToolStripMenuItem
        Friend WithEvents LaporanToolStripMenuItem As ToolStripMenuItem
        Friend WithEvents LaporanSayaToolStripMenuItem As ToolStripMenuItem

        ' Main Container
        Friend WithEvents pnlMain As Panel
        Friend WithEvents pnlHeader As Panel
        Friend WithEvents lblWelcome As Label
        Friend WithEvents lblDateTime As Label
        Friend WithEvents lblTime As Label

        ' Status Card
        Friend WithEvents pnlStatusCard As Panel
        Friend WithEvents lblStatusTitle As Label
        Friend WithEvents lblStatusInfo As Label
        Friend WithEvents lblStatusIcon As Label

        ' Quick Absen
        Friend WithEvents pnlQuickAbsen As Panel
        Friend WithEvents btnAbsenMasuk As Button
        Friend WithEvents btnAbsenPulang As Button
        Friend WithEvents lblAbsenInfo As Label

        ' History
        Friend WithEvents pnlHistory As Panel
        Friend WithEvents lblHistoryTitle As Label
        Friend WithEvents dgvHistory As DataGridView

        ' Timers
        Friend WithEvents tmrClock As Timer
        Friend WithEvents tmrRefresh As Timer
    End Class
End Namespace

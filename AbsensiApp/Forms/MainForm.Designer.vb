Namespace Forms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class MainForm
        Inherits System.Windows.Forms.Form

        <System.Diagnostics.DebuggerNonUserCode()> _
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

        <System.Diagnostics.DebuggerStepThrough()> _
        Private Sub InitializeComponent()
            components = New ComponentModel.Container()
            Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
            Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
            Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
            MenuStrip1 = New MenuStrip()
            FileToolStripMenuItem = New ToolStripMenuItem()
            LogoutToolStripMenuItem = New ToolStripMenuItem()
            ExitToolStripMenuItem = New ToolStripMenuItem()
            MasterDataToolStripMenuItem = New ToolStripMenuItem()
            KaryawanToolStripMenuItem = New ToolStripMenuItem()
            DepartemenToolStripMenuItem = New ToolStripMenuItem()
            JabatanToolStripMenuItem = New ToolStripMenuItem()
            ShiftToolStripMenuItem = New ToolStripMenuItem()
            TransaksiToolStripMenuItem = New ToolStripMenuItem()
            InputAbsensiToolStripMenuItem = New ToolStripMenuItem()
            IzinCutiToolStripMenuItem = New ToolStripMenuItem()
            AbsensiSelfToolStripMenuItem = New ToolStripMenuItem()
            LaporanToolStripMenuItem = New ToolStripMenuItem()
            LaporanHarianToolStripMenuItem = New ToolStripMenuItem()
            LaporanBulananToolStripMenuItem = New ToolStripMenuItem()
            AdminToolStripMenuItem = New ToolStripMenuItem()
            ManajemenUserToolStripMenuItem = New ToolStripMenuItem()
            pnlMain = New Panel()
            pnlContent = New Panel()
            dgvAbsensi = New DataGridView()
            lblAbsensiTitle = New Label()
            pnlQuickActions = New FlowLayoutPanel()
            btnAbsenMasuk = New Button()
            btnAbsenPulang = New Button()
            btnInputAbsensi = New Button()
            btnLihatLaporan = New Button()
            btnRefresh = New Button()
            pnlEmployeeStatus = New Panel()
            lblEmployeeStatusInfo = New Label()
            lblEmployeeStatusTitle = New Label()
            pnlStats = New FlowLayoutPanel()
            pnlKaryawan = New Panel()
            lblKaryawanTitle = New Label()
            lblKaryawanCount = New Label()
            lblKaryawanIcon = New Label()
            pnlHadir = New Panel()
            lblHadirTitle = New Label()
            lblHadirCount = New Label()
            lblHadirIcon = New Label()
            pnlTerlambat = New Panel()
            lblTerlambatCount = New Label()
            lblTerlambatTitle = New Label()
            lblTerlambatIcon = New Label()
            pnlPending = New Panel()
            lblPendingTitle = New Label()
            lblPendingCount = New Label()
            lblPendingIcon = New Label()
            pnlHeader = New Panel()
            lblTime = New Label()
            lblDateTime = New Label()
            lblWelcome = New Label()
            tmrClock = New Timer(components)
            tmrRefresh = New Timer(components)
            MenuStrip1.SuspendLayout()
            pnlMain.SuspendLayout()
            pnlContent.SuspendLayout()
            CType(dgvAbsensi, ComponentModel.ISupportInitialize).BeginInit()
            pnlQuickActions.SuspendLayout()
            pnlEmployeeStatus.SuspendLayout()
            pnlStats.SuspendLayout()
            pnlKaryawan.SuspendLayout()
            pnlHadir.SuspendLayout()
            pnlTerlambat.SuspendLayout()
            pnlPending.SuspendLayout()
            pnlHeader.SuspendLayout()
            SuspendLayout()
            ' 
            ' MenuStrip1
            ' 
            MenuStrip1.BackColor = Color.FromArgb(CByte(45), CByte(52), CByte(64))
            MenuStrip1.ForeColor = Color.White
            MenuStrip1.ImageScalingSize = New Size(20, 20)
            MenuStrip1.Items.AddRange(New ToolStripItem() {FileToolStripMenuItem, MasterDataToolStripMenuItem, TransaksiToolStripMenuItem, LaporanToolStripMenuItem, AdminToolStripMenuItem})
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
            ' MasterDataToolStripMenuItem
            ' 
            MasterDataToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {KaryawanToolStripMenuItem, DepartemenToolStripMenuItem, JabatanToolStripMenuItem, ShiftToolStripMenuItem})
            MasterDataToolStripMenuItem.ForeColor = Color.White
            MasterDataToolStripMenuItem.Name = "MasterDataToolStripMenuItem"
            MasterDataToolStripMenuItem.Size = New Size(104, 24)
            MasterDataToolStripMenuItem.Text = "Master Data"
            ' 
            ' KaryawanToolStripMenuItem
            ' 
            KaryawanToolStripMenuItem.Name = "KaryawanToolStripMenuItem"
            KaryawanToolStripMenuItem.Size = New Size(175, 26)
            KaryawanToolStripMenuItem.Text = "Karyawan"
            ' 
            ' DepartemenToolStripMenuItem
            ' 
            DepartemenToolStripMenuItem.Name = "DepartemenToolStripMenuItem"
            DepartemenToolStripMenuItem.Size = New Size(175, 26)
            DepartemenToolStripMenuItem.Text = "Departemen"
            ' 
            ' JabatanToolStripMenuItem
            ' 
            JabatanToolStripMenuItem.Name = "JabatanToolStripMenuItem"
            JabatanToolStripMenuItem.Size = New Size(175, 26)
            JabatanToolStripMenuItem.Text = "Jabatan"
            ' 
            ' ShiftToolStripMenuItem
            ' 
            ShiftToolStripMenuItem.Name = "ShiftToolStripMenuItem"
            ShiftToolStripMenuItem.Size = New Size(175, 26)
            ShiftToolStripMenuItem.Text = "Shift"
            ' 
            ' TransaksiToolStripMenuItem
            ' 
            TransaksiToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {InputAbsensiToolStripMenuItem, IzinCutiToolStripMenuItem, AbsensiSelfToolStripMenuItem})
            TransaksiToolStripMenuItem.ForeColor = Color.White
            TransaksiToolStripMenuItem.Name = "TransaksiToolStripMenuItem"
            TransaksiToolStripMenuItem.Size = New Size(74, 24)
            TransaksiToolStripMenuItem.Text = "Absensi"
            ' 
            ' InputAbsensiToolStripMenuItem
            ' 
            InputAbsensiToolStripMenuItem.Name = "InputAbsensiToolStripMenuItem"
            InputAbsensiToolStripMenuItem.Size = New Size(229, 26)
            InputAbsensiToolStripMenuItem.Text = "Input Absensi Harian"
            ' 
            ' IzinCutiToolStripMenuItem
            ' 
            IzinCutiToolStripMenuItem.Name = "IzinCutiToolStripMenuItem"
            IzinCutiToolStripMenuItem.Size = New Size(229, 26)
            IzinCutiToolStripMenuItem.Text = "Pengajuan Izin/Cuti"
            ' 
            ' AbsensiSelfToolStripMenuItem
            ' 
            AbsensiSelfToolStripMenuItem.Name = "AbsensiSelfToolStripMenuItem"
            AbsensiSelfToolStripMenuItem.Size = New Size(229, 26)
            AbsensiSelfToolStripMenuItem.Text = "Absensi Mandiri"
            ' 
            ' LaporanToolStripMenuItem
            ' 
            LaporanToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {LaporanHarianToolStripMenuItem, LaporanBulananToolStripMenuItem})
            LaporanToolStripMenuItem.ForeColor = Color.White
            LaporanToolStripMenuItem.Name = "LaporanToolStripMenuItem"
            LaporanToolStripMenuItem.Size = New Size(77, 24)
            LaporanToolStripMenuItem.Text = "Laporan"
            ' 
            ' LaporanHarianToolStripMenuItem
            ' 
            LaporanHarianToolStripMenuItem.Name = "LaporanHarianToolStripMenuItem"
            LaporanHarianToolStripMenuItem.Size = New Size(203, 26)
            LaporanHarianToolStripMenuItem.Text = "Laporan Harian"
            ' 
            ' LaporanBulananToolStripMenuItem
            ' 
            LaporanBulananToolStripMenuItem.Name = "LaporanBulananToolStripMenuItem"
            LaporanBulananToolStripMenuItem.Size = New Size(203, 26)
            LaporanBulananToolStripMenuItem.Text = "Laporan Bulanan"
            ' 
            ' AdminToolStripMenuItem
            ' 
            AdminToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ManajemenUserToolStripMenuItem})
            AdminToolStripMenuItem.ForeColor = Color.White
            AdminToolStripMenuItem.Name = "AdminToolStripMenuItem"
            AdminToolStripMenuItem.Size = New Size(67, 24)
            AdminToolStripMenuItem.Text = "Admin"
            ' 
            ' ManajemenUserToolStripMenuItem
            ' 
            ManajemenUserToolStripMenuItem.Name = "ManajemenUserToolStripMenuItem"
            ManajemenUserToolStripMenuItem.Size = New Size(203, 26)
            ManajemenUserToolStripMenuItem.Text = "Manajemen User"
            ' 
            ' pnlMain
            ' 
            pnlMain.BackColor = Color.FromArgb(CByte(240), CByte(242), CByte(245))
            pnlMain.Controls.Add(pnlContent)
            pnlMain.Controls.Add(pnlQuickActions)
            pnlMain.Controls.Add(pnlEmployeeStatus)
            pnlMain.Controls.Add(pnlStats)
            pnlMain.Controls.Add(pnlHeader)
            pnlMain.Dock = DockStyle.Fill
            pnlMain.Location = New Point(0, 30)
            pnlMain.Name = "pnlMain"
            pnlMain.Padding = New Padding(20)
            pnlMain.Size = New Size(1200, 670)
            pnlMain.TabIndex = 0
            ' 
            ' pnlContent
            ' 
            pnlContent.BackColor = Color.White
            pnlContent.Controls.Add(dgvAbsensi)
            pnlContent.Controls.Add(lblAbsensiTitle)
            pnlContent.Dock = DockStyle.Fill
            pnlContent.Location = New Point(20, 400)
            pnlContent.Name = "pnlContent"
            pnlContent.Padding = New Padding(20)
            pnlContent.Size = New Size(1160, 250)
            pnlContent.TabIndex = 0
            ' 
            ' dgvAbsensi
            ' 
            dgvAbsensi.AllowUserToAddRows = False
            dgvAbsensi.AllowUserToDeleteRows = False
            DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(248), CByte(249), CByte(250))
            dgvAbsensi.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            dgvAbsensi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            dgvAbsensi.BackgroundColor = Color.White
            dgvAbsensi.BorderStyle = BorderStyle.None
            dgvAbsensi.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
            DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(45), CByte(52), CByte(64))
            DataGridViewCellStyle2.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
            DataGridViewCellStyle2.ForeColor = Color.White
            DataGridViewCellStyle2.Padding = New Padding(10)
            DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
            DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
            DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
            dgvAbsensi.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
            dgvAbsensi.ColumnHeadersHeight = 45
            dgvAbsensi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
            DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle3.BackColor = SystemColors.Window
            DataGridViewCellStyle3.Font = New Font("Segoe UI", 10F)
            DataGridViewCellStyle3.ForeColor = SystemColors.ControlText
            DataGridViewCellStyle3.Padding = New Padding(5)
            DataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight
            DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText
            DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
            dgvAbsensi.DefaultCellStyle = DataGridViewCellStyle3
            dgvAbsensi.Dock = DockStyle.Fill
            dgvAbsensi.EnableHeadersVisualStyles = False
            dgvAbsensi.GridColor = Color.FromArgb(CByte(230), CByte(230), CByte(230))
            dgvAbsensi.Location = New Point(20, 60)
            dgvAbsensi.Name = "dgvAbsensi"
            dgvAbsensi.ReadOnly = True
            dgvAbsensi.RowHeadersVisible = False
            dgvAbsensi.RowHeadersWidth = 51
            dgvAbsensi.RowTemplate.Height = 40
            dgvAbsensi.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            dgvAbsensi.Size = New Size(1120, 170)
            dgvAbsensi.TabIndex = 0
            ' 
            ' lblAbsensiTitle
            ' 
            lblAbsensiTitle.Dock = DockStyle.Top
            lblAbsensiTitle.Font = New Font("Segoe UI", 14F, FontStyle.Bold)
            lblAbsensiTitle.ForeColor = Color.FromArgb(CByte(45), CByte(52), CByte(64))
            lblAbsensiTitle.Location = New Point(20, 20)
            lblAbsensiTitle.Name = "lblAbsensiTitle"
            lblAbsensiTitle.Padding = New Padding(0, 10, 0, 0)
            lblAbsensiTitle.Size = New Size(1120, 40)
            lblAbsensiTitle.TabIndex = 1
            lblAbsensiTitle.Text = "📋 Absensi Hari Ini"
            ' 
            ' pnlQuickActions
            ' 
            pnlQuickActions.BackColor = Color.Transparent
            pnlQuickActions.Controls.Add(btnAbsenMasuk)
            pnlQuickActions.Controls.Add(btnAbsenPulang)
            pnlQuickActions.Controls.Add(btnInputAbsensi)
            pnlQuickActions.Controls.Add(btnLihatLaporan)
            pnlQuickActions.Controls.Add(btnRefresh)
            pnlQuickActions.Dock = DockStyle.Top
            pnlQuickActions.Location = New Point(20, 330)
            pnlQuickActions.Name = "pnlQuickActions"
            pnlQuickActions.Padding = New Padding(0, 10, 0, 10)
            pnlQuickActions.Size = New Size(1160, 70)
            pnlQuickActions.TabIndex = 1
            ' 
            ' btnAbsenMasuk
            ' 
            btnAbsenMasuk.BackColor = Color.FromArgb(CByte(40), CByte(167), CByte(69))
            btnAbsenMasuk.Cursor = Cursors.Hand
            btnAbsenMasuk.FlatAppearance.BorderSize = 0
            btnAbsenMasuk.FlatStyle = FlatStyle.Flat
            btnAbsenMasuk.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
            btnAbsenMasuk.ForeColor = Color.White
            btnAbsenMasuk.Location = New Point(0, 10)
            btnAbsenMasuk.Margin = New Padding(0, 0, 10, 0)
            btnAbsenMasuk.Name = "btnAbsenMasuk"
            btnAbsenMasuk.Size = New Size(160, 45)
            btnAbsenMasuk.TabIndex = 0
            btnAbsenMasuk.Text = "🕐  Absen Masuk"
            btnAbsenMasuk.UseVisualStyleBackColor = False
            btnAbsenMasuk.Visible = False
            ' 
            ' btnAbsenPulang
            ' 
            btnAbsenPulang.BackColor = Color.FromArgb(CByte(220), CByte(53), CByte(69))
            btnAbsenPulang.Cursor = Cursors.Hand
            btnAbsenPulang.FlatAppearance.BorderSize = 0
            btnAbsenPulang.FlatStyle = FlatStyle.Flat
            btnAbsenPulang.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
            btnAbsenPulang.ForeColor = Color.White
            btnAbsenPulang.Location = New Point(170, 10)
            btnAbsenPulang.Margin = New Padding(0, 0, 10, 0)
            btnAbsenPulang.Name = "btnAbsenPulang"
            btnAbsenPulang.Size = New Size(160, 45)
            btnAbsenPulang.TabIndex = 1
            btnAbsenPulang.Text = "🏠  Absen Pulang"
            btnAbsenPulang.UseVisualStyleBackColor = False
            btnAbsenPulang.Visible = False
            ' 
            ' btnInputAbsensi
            ' 
            btnInputAbsensi.BackColor = Color.FromArgb(CByte(0), CByte(122), CByte(204))
            btnInputAbsensi.Cursor = Cursors.Hand
            btnInputAbsensi.FlatAppearance.BorderSize = 0
            btnInputAbsensi.FlatStyle = FlatStyle.Flat
            btnInputAbsensi.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
            btnInputAbsensi.ForeColor = Color.White
            btnInputAbsensi.Location = New Point(340, 10)
            btnInputAbsensi.Margin = New Padding(0, 0, 10, 0)
            btnInputAbsensi.Name = "btnInputAbsensi"
            btnInputAbsensi.Size = New Size(160, 45)
            btnInputAbsensi.TabIndex = 2
            btnInputAbsensi.Text = "📝  Input Absensi"
            btnInputAbsensi.UseVisualStyleBackColor = False
            ' 
            ' btnLihatLaporan
            ' 
            btnLihatLaporan.BackColor = Color.FromArgb(CByte(108), CByte(117), CByte(125))
            btnLihatLaporan.Cursor = Cursors.Hand
            btnLihatLaporan.FlatAppearance.BorderSize = 0
            btnLihatLaporan.FlatStyle = FlatStyle.Flat
            btnLihatLaporan.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
            btnLihatLaporan.ForeColor = Color.White
            btnLihatLaporan.Location = New Point(510, 10)
            btnLihatLaporan.Margin = New Padding(0, 0, 10, 0)
            btnLihatLaporan.Name = "btnLihatLaporan"
            btnLihatLaporan.Size = New Size(160, 45)
            btnLihatLaporan.TabIndex = 3
            btnLihatLaporan.Text = "📊  Lihat Laporan"
            btnLihatLaporan.UseVisualStyleBackColor = False
            ' 
            ' btnRefresh
            ' 
            btnRefresh.BackColor = Color.FromArgb(CByte(23), CByte(162), CByte(184))
            btnRefresh.Cursor = Cursors.Hand
            btnRefresh.FlatAppearance.BorderSize = 0
            btnRefresh.FlatStyle = FlatStyle.Flat
            btnRefresh.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
            btnRefresh.ForeColor = Color.White
            btnRefresh.Location = New Point(683, 13)
            btnRefresh.Name = "btnRefresh"
            btnRefresh.Size = New Size(120, 45)
            btnRefresh.TabIndex = 4
            btnRefresh.Text = "🔄  Refresh"
            btnRefresh.UseVisualStyleBackColor = False
            ' 
            ' pnlEmployeeStatus
            ' 
            pnlEmployeeStatus.BackColor = Color.White
            pnlEmployeeStatus.Controls.Add(lblEmployeeStatusInfo)
            pnlEmployeeStatus.Controls.Add(lblEmployeeStatusTitle)
            pnlEmployeeStatus.Dock = DockStyle.Top
            pnlEmployeeStatus.Location = New Point(20, 230)
            pnlEmployeeStatus.Margin = New Padding(0, 10, 0, 10)
            pnlEmployeeStatus.Name = "pnlEmployeeStatus"
            pnlEmployeeStatus.Padding = New Padding(20)
            pnlEmployeeStatus.Size = New Size(1160, 100)
            pnlEmployeeStatus.TabIndex = 2
            pnlEmployeeStatus.Visible = False
            ' 
            ' lblEmployeeStatusInfo
            ' 
            lblEmployeeStatusInfo.Font = New Font("Segoe UI", 12F)
            lblEmployeeStatusInfo.ForeColor = Color.Gray
            lblEmployeeStatusInfo.Location = New Point(20, 50)
            lblEmployeeStatusInfo.Name = "lblEmployeeStatusInfo"
            lblEmployeeStatusInfo.Size = New Size(600, 30)
            lblEmployeeStatusInfo.TabIndex = 0
            lblEmployeeStatusInfo.Text = "Belum Absen"
            ' 
            ' lblEmployeeStatusTitle
            ' 
            lblEmployeeStatusTitle.Font = New Font("Segoe UI", 14F, FontStyle.Bold)
            lblEmployeeStatusTitle.ForeColor = Color.FromArgb(CByte(45), CByte(52), CByte(64))
            lblEmployeeStatusTitle.Location = New Point(20, 15)
            lblEmployeeStatusTitle.Name = "lblEmployeeStatusTitle"
            lblEmployeeStatusTitle.Size = New Size(300, 30)
            lblEmployeeStatusTitle.TabIndex = 1
            lblEmployeeStatusTitle.Text = "Status Absensi Hari Ini"
            ' 
            ' pnlStats
            ' 
            pnlStats.BackColor = Color.Transparent
            pnlStats.Controls.Add(pnlKaryawan)
            pnlStats.Controls.Add(pnlHadir)
            pnlStats.Controls.Add(pnlTerlambat)
            pnlStats.Controls.Add(pnlPending)
            pnlStats.Dock = DockStyle.Top
            pnlStats.Location = New Point(20, 100)
            pnlStats.Name = "pnlStats"
            pnlStats.Padding = New Padding(0, 10, 0, 10)
            pnlStats.Size = New Size(1160, 130)
            pnlStats.TabIndex = 3
            ' 
            ' pnlKaryawan
            ' 
            pnlKaryawan.BackColor = Color.White
            pnlKaryawan.Controls.Add(lblKaryawanTitle)
            pnlKaryawan.Controls.Add(lblKaryawanCount)
            pnlKaryawan.Controls.Add(lblKaryawanIcon)
            pnlKaryawan.Location = New Point(0, 10)
            pnlKaryawan.Margin = New Padding(0, 0, 20, 0)
            pnlKaryawan.Name = "pnlKaryawan"
            pnlKaryawan.Size = New Size(200, 100)
            pnlKaryawan.TabIndex = 0
            ' 
            ' lblKaryawanTitle
            ' 
            lblKaryawanTitle.Font = New Font("Segoe UI", 10F)
            lblKaryawanTitle.ForeColor = Color.Gray
            lblKaryawanTitle.Location = New Point(70, 62)
            lblKaryawanTitle.Name = "lblKaryawanTitle"
            lblKaryawanTitle.Size = New Size(120, 25)
            lblKaryawanTitle.TabIndex = 0
            lblKaryawanTitle.Text = "Karyawan Aktif"
            ' 
            ' lblKaryawanCount
            ' 
            lblKaryawanCount.Font = New Font("Segoe UI", 28F, FontStyle.Bold)
            lblKaryawanCount.ForeColor = Color.FromArgb(CByte(45), CByte(52), CByte(64))
            lblKaryawanCount.Location = New Point(71, 2)
            lblKaryawanCount.Name = "lblKaryawanCount"
            lblKaryawanCount.Size = New Size(120, 72)
            lblKaryawanCount.TabIndex = 1
            lblKaryawanCount.Text = "0"
            lblKaryawanCount.TextAlign = ContentAlignment.MiddleLeft
            ' 
            ' lblKaryawanIcon
            ' 
            lblKaryawanIcon.Font = New Font("Segoe UI Emoji", 24F)
            lblKaryawanIcon.Location = New Point(3, 20)
            lblKaryawanIcon.Name = "lblKaryawanIcon"
            lblKaryawanIcon.Size = New Size(62, 50)
            lblKaryawanIcon.TabIndex = 2
            lblKaryawanIcon.Text = "👥"
            ' 
            ' pnlHadir
            ' 
            pnlHadir.BackColor = Color.White
            pnlHadir.Controls.Add(lblHadirTitle)
            pnlHadir.Controls.Add(lblHadirCount)
            pnlHadir.Controls.Add(lblHadirIcon)
            pnlHadir.Location = New Point(220, 10)
            pnlHadir.Margin = New Padding(0, 0, 20, 0)
            pnlHadir.Name = "pnlHadir"
            pnlHadir.Size = New Size(200, 100)
            pnlHadir.TabIndex = 1
            ' 
            ' lblHadirTitle
            ' 
            lblHadirTitle.Font = New Font("Segoe UI", 10F)
            lblHadirTitle.ForeColor = Color.Gray
            lblHadirTitle.Location = New Point(70, 60)
            lblHadirTitle.Name = "lblHadirTitle"
            lblHadirTitle.Size = New Size(120, 25)
            lblHadirTitle.TabIndex = 0
            lblHadirTitle.Text = "Hadir Hari Ini"
            ' 
            ' lblHadirCount
            ' 
            lblHadirCount.Font = New Font("Segoe UI", 28F, FontStyle.Bold)
            lblHadirCount.ForeColor = Color.FromArgb(CByte(40), CByte(167), CByte(69))
            lblHadirCount.Location = New Point(70, 8)
            lblHadirCount.Name = "lblHadirCount"
            lblHadirCount.Size = New Size(120, 52)
            lblHadirCount.TabIndex = 1
            lblHadirCount.Text = "0"
            lblHadirCount.TextAlign = ContentAlignment.MiddleLeft
            ' 
            ' lblHadirIcon
            ' 
            lblHadirIcon.Font = New Font("Segoe UI Emoji", 24F)
            lblHadirIcon.Location = New Point(3, 20)
            lblHadirIcon.Name = "lblHadirIcon"
            lblHadirIcon.Size = New Size(61, 50)
            lblHadirIcon.TabIndex = 2
            lblHadirIcon.Text = "✅"
            ' 
            ' pnlTerlambat
            ' 
            pnlTerlambat.BackColor = Color.White
            pnlTerlambat.Controls.Add(lblTerlambatCount)
            pnlTerlambat.Controls.Add(lblTerlambatTitle)
            pnlTerlambat.Controls.Add(lblTerlambatIcon)
            pnlTerlambat.Location = New Point(440, 10)
            pnlTerlambat.Margin = New Padding(0, 0, 20, 0)
            pnlTerlambat.Name = "pnlTerlambat"
            pnlTerlambat.Size = New Size(200, 100)
            pnlTerlambat.TabIndex = 2
            ' 
            ' lblTerlambatCount
            ' 
            lblTerlambatCount.Font = New Font("Segoe UI", 28F, FontStyle.Bold)
            lblTerlambatCount.ForeColor = Color.FromArgb(CByte(255), CByte(153), CByte(0))
            lblTerlambatCount.Location = New Point(70, 8)
            lblTerlambatCount.Name = "lblTerlambatCount"
            lblTerlambatCount.Size = New Size(120, 58)
            lblTerlambatCount.TabIndex = 1
            lblTerlambatCount.Text = "0"
            lblTerlambatCount.TextAlign = ContentAlignment.MiddleLeft
            ' 
            ' lblTerlambatTitle
            ' 
            lblTerlambatTitle.Font = New Font("Segoe UI", 10F)
            lblTerlambatTitle.ForeColor = Color.Gray
            lblTerlambatTitle.Location = New Point(70, 60)
            lblTerlambatTitle.Name = "lblTerlambatTitle"
            lblTerlambatTitle.Size = New Size(120, 25)
            lblTerlambatTitle.TabIndex = 0
            lblTerlambatTitle.Text = "Terlambat"
            ' 
            ' lblTerlambatIcon
            ' 
            lblTerlambatIcon.Font = New Font("Segoe UI Emoji", 24F)
            lblTerlambatIcon.Location = New Point(3, 20)
            lblTerlambatIcon.Name = "lblTerlambatIcon"
            lblTerlambatIcon.Size = New Size(61, 50)
            lblTerlambatIcon.TabIndex = 2
            lblTerlambatIcon.Text = "⚠️"
            ' 
            ' pnlPending
            ' 
            pnlPending.BackColor = Color.White
            pnlPending.Controls.Add(lblPendingTitle)
            pnlPending.Controls.Add(lblPendingCount)
            pnlPending.Controls.Add(lblPendingIcon)
            pnlPending.Location = New Point(660, 10)
            pnlPending.Margin = New Padding(0, 0, 20, 0)
            pnlPending.Name = "pnlPending"
            pnlPending.Size = New Size(200, 100)
            pnlPending.TabIndex = 3
            ' 
            ' lblPendingTitle
            ' 
            lblPendingTitle.Font = New Font("Segoe UI", 10F)
            lblPendingTitle.ForeColor = Color.Gray
            lblPendingTitle.Location = New Point(70, 60)
            lblPendingTitle.Name = "lblPendingTitle"
            lblPendingTitle.Size = New Size(120, 25)
            lblPendingTitle.TabIndex = 0
            lblPendingTitle.Text = "Pending Cuti"
            ' 
            ' lblPendingCount
            ' 
            lblPendingCount.Font = New Font("Segoe UI", 28F, FontStyle.Bold)
            lblPendingCount.ForeColor = Color.FromArgb(CByte(0), CByte(122), CByte(204))
            lblPendingCount.Location = New Point(70, 10)
            lblPendingCount.Name = "lblPendingCount"
            lblPendingCount.Size = New Size(120, 56)
            lblPendingCount.TabIndex = 1
            lblPendingCount.Text = "0"
            lblPendingCount.TextAlign = ContentAlignment.MiddleLeft
            ' 
            ' lblPendingIcon
            ' 
            lblPendingIcon.Font = New Font("Segoe UI Emoji", 24F)
            lblPendingIcon.Location = New Point(3, 20)
            lblPendingIcon.Name = "lblPendingIcon"
            lblPendingIcon.Size = New Size(61, 50)
            lblPendingIcon.TabIndex = 2
            lblPendingIcon.Text = "📋"
            ' 
            ' pnlHeader
            ' 
            pnlHeader.BackColor = Color.Transparent
            pnlHeader.Controls.Add(lblTime)
            pnlHeader.Controls.Add(lblDateTime)
            pnlHeader.Controls.Add(lblWelcome)
            pnlHeader.Dock = DockStyle.Top
            pnlHeader.Location = New Point(20, 20)
            pnlHeader.Name = "pnlHeader"
            pnlHeader.Size = New Size(1160, 80)
            pnlHeader.TabIndex = 4
            ' 
            ' lblTime
            ' 
            lblTime.Anchor = AnchorStyles.Top Or AnchorStyles.Right
            lblTime.Font = New Font("Segoe UI", 24F, FontStyle.Bold)
            lblTime.ForeColor = Color.FromArgb(CByte(0), CByte(122), CByte(204))
            lblTime.Location = New Point(1760, 35)
            lblTime.Name = "lblTime"
            lblTime.Size = New Size(350, 40)
            lblTime.TabIndex = 0
            lblTime.Text = "20:45:03"
            lblTime.TextAlign = ContentAlignment.TopRight
            ' 
            ' lblDateTime
            ' 
            lblDateTime.Anchor = AnchorStyles.Top Or AnchorStyles.Right
            lblDateTime.Font = New Font("Segoe UI", 11F)
            lblDateTime.ForeColor = Color.FromArgb(CByte(100), CByte(100), CByte(100))
            lblDateTime.Location = New Point(1760, 10)
            lblDateTime.Name = "lblDateTime"
            lblDateTime.Size = New Size(350, 25)
            lblDateTime.TabIndex = 1
            lblDateTime.Text = "Rabu, 1 Januari 2026"
            lblDateTime.TextAlign = ContentAlignment.TopRight
            ' 
            ' lblWelcome
            ' 
            lblWelcome.Font = New Font("Segoe UI", 18F, FontStyle.Bold)
            lblWelcome.ForeColor = Color.FromArgb(CByte(45), CByte(52), CByte(64))
            lblWelcome.Location = New Point(3, 9)
            lblWelcome.Name = "lblWelcome"
            lblWelcome.Size = New Size(600, 43)
            lblWelcome.TabIndex = 2
            lblWelcome.Text = "Selamat Datang"
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
            ' MainForm
            ' 
            AutoScaleDimensions = New SizeF(8F, 20F)
            AutoScaleMode = AutoScaleMode.Font
            ClientSize = New Size(1200, 700)
            Controls.Add(pnlMain)
            Controls.Add(MenuStrip1)
            MainMenuStrip = MenuStrip1
            Name = "MainForm"
            Text = "Sistem Absensi Karyawan"
            WindowState = FormWindowState.Maximized
            MenuStrip1.ResumeLayout(False)
            MenuStrip1.PerformLayout()
            pnlMain.ResumeLayout(False)
            pnlContent.ResumeLayout(False)
            CType(dgvAbsensi, ComponentModel.ISupportInitialize).EndInit()
            pnlQuickActions.ResumeLayout(False)
            pnlEmployeeStatus.ResumeLayout(False)
            pnlStats.ResumeLayout(False)
            pnlKaryawan.ResumeLayout(False)
            pnlHadir.ResumeLayout(False)
            pnlTerlambat.ResumeLayout(False)
            pnlPending.ResumeLayout(False)
            pnlHeader.ResumeLayout(False)
            ResumeLayout(False)
            PerformLayout()
        End Sub

        ' Menu Items
        Friend WithEvents MenuStrip1 As MenuStrip
        Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
        Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
        Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
        Friend WithEvents MasterDataToolStripMenuItem As ToolStripMenuItem
        Friend WithEvents KaryawanToolStripMenuItem As ToolStripMenuItem
        Friend WithEvents DepartemenToolStripMenuItem As ToolStripMenuItem
        Friend WithEvents JabatanToolStripMenuItem As ToolStripMenuItem
        Friend WithEvents ShiftToolStripMenuItem As ToolStripMenuItem
        Friend WithEvents TransaksiToolStripMenuItem As ToolStripMenuItem
        Friend WithEvents InputAbsensiToolStripMenuItem As ToolStripMenuItem
        Friend WithEvents IzinCutiToolStripMenuItem As ToolStripMenuItem
        Friend WithEvents AbsensiSelfToolStripMenuItem As ToolStripMenuItem
        Friend WithEvents LaporanToolStripMenuItem As ToolStripMenuItem
        Friend WithEvents LaporanHarianToolStripMenuItem As ToolStripMenuItem
        Friend WithEvents LaporanBulananToolStripMenuItem As ToolStripMenuItem
        Friend WithEvents AdminToolStripMenuItem As ToolStripMenuItem
        Friend WithEvents ManajemenUserToolStripMenuItem As ToolStripMenuItem
        
        ' Dashboard Components
        Friend WithEvents pnlMain As Panel
        Friend WithEvents pnlHeader As Panel
        Friend WithEvents lblWelcome As Label
        Friend WithEvents lblDateTime As Label
        Friend WithEvents lblTime As Label
        
        ' Statistics Cards
        Friend WithEvents pnlStats As FlowLayoutPanel
        Friend WithEvents pnlKaryawan As Panel
        Friend WithEvents lblKaryawanIcon As Label
        Friend WithEvents lblKaryawanCount As Label
        Friend WithEvents lblKaryawanTitle As Label
        Friend WithEvents pnlHadir As Panel
        Friend WithEvents lblHadirIcon As Label
        Friend WithEvents lblHadirCount As Label
        Friend WithEvents lblHadirTitle As Label
        Friend WithEvents pnlTerlambat As Panel
        Friend WithEvents lblTerlambatIcon As Label
        Friend WithEvents lblTerlambatCount As Label
        Friend WithEvents lblTerlambatTitle As Label
        Friend WithEvents pnlPending As Panel
        Friend WithEvents lblPendingIcon As Label
        Friend WithEvents lblPendingCount As Label
        Friend WithEvents lblPendingTitle As Label
        
        ' Content Section
        Friend WithEvents pnlContent As Panel
        Friend WithEvents lblAbsensiTitle As Label
        Friend WithEvents dgvAbsensi As DataGridView
        
        ' Quick Actions
        Friend WithEvents pnlQuickActions As FlowLayoutPanel
        Friend WithEvents btnAbsenMasuk As Button
        Friend WithEvents btnAbsenPulang As Button
        Friend WithEvents btnInputAbsensi As Button
        Friend WithEvents btnLihatLaporan As Button
        Friend WithEvents btnRefresh As Button
        
        ' Employee Status Panel
        Friend WithEvents pnlEmployeeStatus As Panel
        Friend WithEvents lblEmployeeStatusTitle As Label
        Friend WithEvents lblEmployeeStatusInfo As Label
        
        ' Timers
        Friend WithEvents tmrClock As Timer
        Friend WithEvents tmrRefresh As Timer
    End Class
End Namespace

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
            lblWelcome = New Label()
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
            MenuStrip1.SuspendLayout()
            SuspendLayout()
            ' 
            ' lblWelcome
            ' 
            lblWelcome.AutoSize = True
            lblWelcome.Font = New Font("Microsoft Sans Serif", 14.0F, FontStyle.Bold)
            lblWelcome.Location = New Point(23, 53)
            lblWelcome.Name = "lblWelcome"
            lblWelcome.Size = New Size(197, 29)
            lblWelcome.TabIndex = 0
            lblWelcome.Text = "Selamat Datang"
            ' 
            ' MenuStrip1
            ' 
            MenuStrip1.ImageScalingSize = New Size(20, 20)
            MenuStrip1.Items.AddRange(New ToolStripItem() {FileToolStripMenuItem, MasterDataToolStripMenuItem, TransaksiToolStripMenuItem, LaporanToolStripMenuItem, AdminToolStripMenuItem})
            MenuStrip1.Location = New Point(0, 0)
            MenuStrip1.Name = "MenuStrip1"
            MenuStrip1.Padding = New Padding(7, 3, 0, 3)
            MenuStrip1.Size = New Size(914, 30)
            MenuStrip1.TabIndex = 1
            MenuStrip1.Text = "MenuStrip1"
            ' 
            ' FileToolStripMenuItem
            ' 
            FileToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {LogoutToolStripMenuItem, ExitToolStripMenuItem})
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
            ' MainForm
            ' 
            AutoScaleDimensions = New SizeF(8.0F, 20.0F)
            AutoScaleMode = AutoScaleMode.Font
            ClientSize = New Size(914, 600)
            Controls.Add(lblWelcome)
            Controls.Add(MenuStrip1)
            MainMenuStrip = MenuStrip1
            Margin = New Padding(3, 4, 3, 4)
            Name = "MainForm"
            Text = "0"
            WindowState = FormWindowState.Maximized
            MenuStrip1.ResumeLayout(False)
            MenuStrip1.PerformLayout()
            ResumeLayout(False)
            PerformLayout()

        End Sub
        Friend WithEvents lblWelcome As System.Windows.Forms.Label
        Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
        Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents LogoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents MasterDataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents KaryawanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents DepartemenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents JabatanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents ShiftToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents TransaksiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents InputAbsensiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents IzinCutiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents AbsensiSelfToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents LaporanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents LaporanHarianToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents LaporanBulananToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents AdminToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents ManajemenUserToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    End Class
End Namespace

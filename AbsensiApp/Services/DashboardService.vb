Imports AbsensiApp.Utils

Namespace Services
    Public Class DashboardService

        ''' <summary>
        ''' Get total active employees
        ''' </summary>
        Public Shared Function GetTotalKaryawanAktif() As Integer
            Dim query As String = "SELECT COUNT(*) FROM tblKaryawan WHERE Status = 'Aktif'"
            Dim result As Object = DatabaseHelper.ExecuteScalar(query)
            If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                Return Convert.ToInt32(result)
            End If
            Return 0
        End Function

        ''' <summary>
        ''' Get count of employees who have checked in today
        ''' </summary>
        Public Shared Function GetHadirHariIni() As Integer
            Dim query As String = "SELECT COUNT(*) FROM tblAbsensi WHERE Tanggal = @Tanggal AND JamMasuk IS NOT NULL"
            Dim params As New Dictionary(Of String, Object)
            params.Add("@Tanggal", DateTime.Today.ToString("yyyy-MM-dd"))
            Dim result As Object = DatabaseHelper.ExecuteScalar(query, params)
            If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                Return Convert.ToInt32(result)
            End If
            Return 0
        End Function

        ''' <summary>
        ''' Get count of employees who were late today
        ''' </summary>
        Public Shared Function GetTerlambatHariIni() As Integer
            Dim query As String = "SELECT COUNT(*) FROM tblAbsensi WHERE Tanggal = @Tanggal AND TelatMenit > 0"
            Dim params As New Dictionary(Of String, Object)
            params.Add("@Tanggal", DateTime.Today.ToString("yyyy-MM-dd"))
            Dim result As Object = DatabaseHelper.ExecuteScalar(query, params)
            If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                Return Convert.ToInt32(result)
            End If
            Return 0
        End Function

        ''' <summary>
        ''' Get count of pending leave requests
        ''' </summary>
        Public Shared Function GetPendingCuti() As Integer
            Dim query As String = "SELECT COUNT(*) FROM tblIzinCuti WHERE StatusPersetujuan = 'Pending'"
            Dim result As Object = DatabaseHelper.ExecuteScalar(query)
            If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                Return Convert.ToInt32(result)
            End If
            Return 0
        End Function

        ''' <summary>
        ''' Get today's attendance data with employee and department info
        ''' </summary>
        Public Shared Function GetAbsensiHariIni() As DataTable
            Dim query As String = "
                SELECT 
                    a.IDAbsensi,
                    k.NIK,
                    k.Nama,
                    COALESCE(d.NamaDepartemen, '-') AS Departemen,
                    CASE 
                        WHEN a.JamMasuk IS NOT NULL THEN strftime('%H:%M', a.JamMasuk)
                        ELSE '-'
                    END AS JamMasuk,
                    CASE 
                        WHEN a.JamPulang IS NOT NULL THEN strftime('%H:%M', a.JamPulang)
                        ELSE '-'
                    END AS JamPulang,
                    a.Status,
                    a.TelatMenit,
                    CASE 
                        WHEN a.TelatMenit > 0 THEN 'Terlambat'
                        WHEN a.Status = 'H' THEN 'Hadir'
                        WHEN a.Status = 'I' THEN 'Izin'
                        WHEN a.Status = 'S' THEN 'Sakit'
                        WHEN a.Status = 'C' THEN 'Cuti'
                        WHEN a.Status = 'A' THEN 'Alpha'
                        ELSE 'Unknown'
                    END AS StatusDisplay
                FROM tblAbsensi a
                INNER JOIN tblKaryawan k ON a.KaryawanID = k.KaryawanID
                LEFT JOIN tblDepartemen d ON k.IDDepartemen = d.IDDepartemen
                WHERE a.Tanggal = @Tanggal
                ORDER BY a.JamMasuk DESC
            "
            Dim params As New Dictionary(Of String, Object)
            params.Add("@Tanggal", DateTime.Today.ToString("yyyy-MM-dd"))
            Return DatabaseHelper.ExecuteDataTable(query, params)
        End Function

        ''' <summary>
        ''' Get today's attendance for a specific employee
        ''' </summary>
        Public Shared Function GetMyAbsensiHariIni(karyawanID As Integer) As DataTable
            Dim query As String = "
                SELECT 
                    a.IDAbsensi,
                    a.Tanggal,
                    CASE 
                        WHEN a.JamMasuk IS NOT NULL THEN strftime('%H:%M', a.JamMasuk)
                        ELSE '-'
                    END AS JamMasuk,
                    CASE 
                        WHEN a.JamPulang IS NOT NULL THEN strftime('%H:%M', a.JamPulang)
                        ELSE '-'
                    END AS JamPulang,
                    a.Status,
                    a.TelatMenit,
                    s.NamaShift
                FROM tblAbsensi a
                LEFT JOIN tblShift s ON a.IDShift = s.IDShift
                WHERE a.KaryawanID = @KaryawanID AND a.Tanggal = @Tanggal
            "
            Dim params As New Dictionary(Of String, Object)
            params.Add("@KaryawanID", karyawanID)
            params.Add("@Tanggal", DateTime.Today.ToString("yyyy-MM-dd"))
            Return DatabaseHelper.ExecuteDataTable(query, params)
        End Function

        ''' <summary>
        ''' Get pending leave requests list
        ''' </summary>
        Public Shared Function GetPendingCutiList() As DataTable
            Dim query As String = "
                SELECT 
                    i.IDIzin,
                    k.Nama,
                    i.Jenis,
                    i.TanggalMulai,
                    i.TanggalSelesai,
                    i.Alasan,
                    i.TanggalPengajuan
                FROM tblIzinCuti i
                INNER JOIN tblKaryawan k ON i.KaryawanID = k.KaryawanID
                WHERE i.StatusPersetujuan = 'Pending'
                ORDER BY i.TanggalPengajuan DESC
            "
            Return DatabaseHelper.ExecuteDataTable(query)
        End Function

        ''' <summary>
        ''' Check if employee has checked in today
        ''' </summary>
        Public Shared Function HasCheckedInToday(karyawanID As Integer) As Boolean
            Dim query As String = "SELECT COUNT(*) FROM tblAbsensi WHERE KaryawanID = @ID AND Tanggal = @Tanggal AND JamMasuk IS NOT NULL"
            Dim params As New Dictionary(Of String, Object)
            params.Add("@ID", karyawanID)
            params.Add("@Tanggal", DateTime.Today.ToString("yyyy-MM-dd"))
            Dim result As Object = DatabaseHelper.ExecuteScalar(query, params)
            Return result IsNot Nothing AndAlso Convert.ToInt32(result) > 0
        End Function

        ''' <summary>
        ''' Check if employee has checked out today
        ''' </summary>
        Public Shared Function HasCheckedOutToday(karyawanID As Integer) As Boolean
            Dim query As String = "SELECT COUNT(*) FROM tblAbsensi WHERE KaryawanID = @ID AND Tanggal = @Tanggal AND JamPulang IS NOT NULL"
            Dim params As New Dictionary(Of String, Object)
            params.Add("@ID", karyawanID)
            params.Add("@Tanggal", DateTime.Today.ToString("yyyy-MM-dd"))
            Dim result As Object = DatabaseHelper.ExecuteScalar(query, params)
            Return result IsNot Nothing AndAlso Convert.ToInt32(result) > 0
        End Function

        ''' <summary>
        ''' Get employee name by ID
        ''' </summary>
        Public Shared Function GetKaryawanName(karyawanID As Integer) As String
            Dim query As String = "SELECT Nama FROM tblKaryawan WHERE KaryawanID = @ID"
            Dim params As New Dictionary(Of String, Object)
            params.Add("@ID", karyawanID)
            Dim result As Object = DatabaseHelper.ExecuteScalar(query, params)
            If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                Return result.ToString()
            End If
            Return ""
        End Function

    End Class
End Namespace

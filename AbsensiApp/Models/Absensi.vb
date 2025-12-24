Namespace Models
    Public Class Absensi
        Public Property IDAbsensi As Integer
        Public Property Tanggal As Date
        Public Property KaryawanID As Integer
        Public Property IDShift As Integer?
        Public Property JamMasuk As DateTime?
        Public Property JamPulang As DateTime?
        Public Property Status As String
        Public Property TelatMenit As Integer
        Public Property LemburMenit As Integer
        Public Property Keterangan As String
    End Class
End Namespace

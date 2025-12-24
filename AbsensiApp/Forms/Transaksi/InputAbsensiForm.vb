Imports AbsensiApp.Utils

Namespace Forms.Transaksi
    Public Class InputAbsensiForm
        Private Sub InputAbsensiForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            LoadComboBoxes()
        End Sub

        Private Sub LoadComboBoxes()
            ' Load Karyawan
            Dim dtKaryawan As DataTable = DatabaseHelper.ExecuteDataTable("SELECT KaryawanID, Nama FROM tblKaryawan WHERE Status = 'Aktif'")
            cmbKaryawan.DataSource = dtKaryawan
            cmbKaryawan.DisplayMember = "Nama"
            cmbKaryawan.ValueMember = "KaryawanID"

            ' Load Shift
            Dim dtShift As DataTable = DatabaseHelper.ExecuteDataTable("SELECT IDShift, NamaShift, JamMasuk, JamPulang FROM tblShift")

            ' Calculate best shift FIRST before binding
            Dim currentTime As TimeSpan = DateTime.Now.TimeOfDay
            Dim bestShiftID As Integer = -1

            For Each row As DataRow In dtShift.Rows
                Dim shiftID As Integer = Convert.ToInt32(row("IDShift"))
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
                        bestShiftID = shiftID
                        Exit For
                    End If
                Else
                    ' Overnight shift (e.g. 23:00 - 07:00)
                    If currentTime >= masuk OrElse currentTime < pulang Then
                        bestShiftID = shiftID
                        Exit For
                    End If
                End If
            Next

            ' NOW bind the ComboBox
            cmbShift.DataSource = dtShift
            cmbShift.DisplayMember = "NamaShift"
            cmbShift.ValueMember = "IDShift"

            ' Set selection AFTER binding
            If bestShiftID <> -1 Then
                cmbShift.SelectedValue = bestShiftID
            End If
        End Sub

        Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
            If cmbKaryawan.SelectedIndex = -1 OrElse cmbShift.SelectedIndex = -1 Then
                MessageBox.Show("Pilih Karyawan dan Shift!")
                Return
            End If

            Dim telatMenit As Integer = 0
            Dim lemburMenit As Integer = 0
            Dim status As String = cmbStatus.Text

            ' Calculate Late/Overtime if Present
            If status = "H" Then
                Dim shiftID As Integer = Convert.ToInt32(cmbShift.SelectedValue)
                Dim dtShift As DataTable = DatabaseHelper.ExecuteDataTable("SELECT * FROM tblShift WHERE IDShift = " & shiftID)

                If dtShift.Rows.Count > 0 Then
                    Dim shiftMasuk As TimeSpan = CType(dtShift.Rows(0)("JamMasuk"), TimeSpan)
                    Dim shiftPulang As TimeSpan = CType(dtShift.Rows(0)("JamPulang"), TimeSpan)
                    Dim toleransi As Integer = Convert.ToInt32(dtShift.Rows(0)("ToleransiTelatMenit"))

                    Dim actualMasuk As TimeSpan = dtpMasuk.Value.TimeOfDay
                    Dim actualPulang As TimeSpan = dtpPulang.Value.TimeOfDay

                    ' Hitung Telat
                    If actualMasuk > shiftMasuk.Add(TimeSpan.FromMinutes(toleransi)) Then
                        telatMenit = CInt((actualMasuk - shiftMasuk).TotalMinutes)
                    End If

                    ' Hitung Lembur (Simple logic: Pulang > ShiftPulang)
                    If actualPulang > shiftPulang Then
                        lemburMenit = CInt((actualPulang - shiftPulang).TotalMinutes)
                    End If
                End If
            End If

            Dim query As String = "INSERT INTO tblAbsensi (Tanggal, KaryawanID, IDShift, JamMasuk, JamPulang, Status, TelatMenit, LemburMenit) " &
                                  "VALUES (@Tanggal, @KaryawanID, @IDShift, @JamMasuk, @JamPulang, @Status, @Telat, @Lembur)"

            Dim params As New Dictionary(Of String, Object)
            params.Add("@Tanggal", dtpTanggal.Value.Date)
            params.Add("@KaryawanID", cmbKaryawan.SelectedValue)
            params.Add("@IDShift", cmbShift.SelectedValue)
            params.Add("@JamMasuk", dtpMasuk.Value)
            params.Add("@JamPulang", dtpPulang.Value)
            params.Add("@Status", status)
            params.Add("@Telat", telatMenit)
            params.Add("@Lembur", lemburMenit)

            Try
                DatabaseHelper.ExecuteNonQuery(query, params)
                MessageBox.Show("Absensi berhasil disimpan!")
                Me.Close()
            Catch ex As Exception
                MessageBox.Show("Gagal menyimpan (Mungkin duplikat?): " & ex.Message)
            End Try
        End Sub

        Private Sub cmbKaryawan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbKaryawan.SelectedIndexChanged

        End Sub
    End Class
End Namespace

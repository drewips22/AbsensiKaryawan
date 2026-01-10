Imports AbsensiApp.Utils
Imports ClosedXML.Excel

Namespace Forms.Laporan
    Public Class LaporanForm
        Private Sub LaporanForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            ' Default to current month
            dtpMulai.Value = New DateTime(DateTime.Now.Year, DateTime.Now.Month, 1)
            dtpSelesai.Value = DateTime.Now
            LoadData()
        End Sub

        Private Sub LoadData()
            Dim query As String = "SELECT a.Tanggal, k.Nama AS Karyawan, s.NamaShift, a.JamMasuk, a.JamPulang, a.Status, a.TelatMenit, a.LemburMenit " &
                                  "FROM tblAbsensi a " &
                                  "JOIN tblKaryawan k ON a.KaryawanID = k.KaryawanID " &
                                  "LEFT JOIN tblShift s ON a.IDShift = s.IDShift " &
                                  "WHERE a.Tanggal BETWEEN @Mulai AND @Selesai "

            Dim params As New Dictionary(Of String, Object)
            params.Add("@Mulai", dtpMulai.Value.Date)
            params.Add("@Selesai", dtpSelesai.Value.Date)

            ' Check Role - support both MainForm and MainFormKaryawan
            Dim currentUser As Models.User = Nothing

            ' Try to get user from MainFormKaryawan (for Karyawan role)
            Dim karyawanForm As MainFormKaryawan = CType(Application.OpenForms("MainFormKaryawan"), MainFormKaryawan)
            If karyawanForm IsNot Nothing Then
                currentUser = karyawanForm.CurrentUser
            Else
                ' Try to get user from MainForm (for Admin/HR/Atasan)
                Dim mainForm As MainForm = CType(Application.OpenForms("MainForm"), MainForm)
                If mainForm IsNot Nothing Then
                    currentUser = mainForm.CurrentUser
                End If
            End If

            ' Filter by KaryawanID if user is Karyawan
            If currentUser IsNot Nothing AndAlso currentUser.Role = "Karyawan" Then
                If currentUser.KaryawanID.HasValue Then
                    query &= " AND a.KaryawanID = @KaryawanID"
                    params.Add("@KaryawanID", currentUser.KaryawanID.Value)
                End If
            End If

            query &= " ORDER BY a.Tanggal DESC, k.Nama ASC"
            
            dgvLaporan.DataSource = DatabaseHelper.ExecuteDataTable(query, params)
        End Sub

        Private Sub btnFilter_Click(sender As Object, e As EventArgs) Handles btnFilter.Click
            LoadData()
        End Sub

        Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
            ExportToExcel()
        End Sub

        Private Sub ExportToExcel()
            ' Check if there's data to export
            If dgvLaporan.Rows.Count = 0 Then
                MessageBox.Show("Tidak ada data untuk diekspor.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If

            ' Show save dialog
            Using saveDialog As New SaveFileDialog()
                saveDialog.Filter = "Excel Files (*.xlsx)|*.xlsx"
                saveDialog.Title = "Simpan Laporan Absensi"
                saveDialog.FileName = $"Laporan_Absensi_{dtpMulai.Value:yyyyMMdd}_{dtpSelesai.Value:yyyyMMdd}.xlsx"

                If saveDialog.ShowDialog() = DialogResult.OK Then
                    Try
                        Cursor = Cursors.WaitCursor

                        ' Create new workbook
                        Using workbook As New XLWorkbook()
                            Dim worksheet = workbook.Worksheets.Add("Laporan Absensi")

                            ' Add title
                            worksheet.Cell(1, 1).Value = "LAPORAN ABSENSI KARYAWAN"
                            worksheet.Range(1, 1, 1, 8).Merge()
                            worksheet.Cell(1, 1).Style.Font.Bold = True
                            worksheet.Cell(1, 1).Style.Font.FontSize = 14
                            worksheet.Cell(1, 1).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center

                            ' Add period info
                            worksheet.Cell(2, 1).Value = $"Periode: {dtpMulai.Value:dd/MM/yyyy} - {dtpSelesai.Value:dd/MM/yyyy}"
                            worksheet.Range(2, 1, 2, 8).Merge()
                            worksheet.Cell(2, 1).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center

                            ' Add headers (row 4)
                            Dim headers() As String = {"No", "Tanggal", "Nama Karyawan", "Shift", "Jam Masuk", "Jam Pulang", "Status", "Telat (Menit)", "Lembur (Menit)"}
                            For col As Integer = 0 To headers.Length - 1
                                worksheet.Cell(4, col + 1).Value = headers(col)
                                worksheet.Cell(4, col + 1).Style.Font.Bold = True
                                worksheet.Cell(4, col + 1).Style.Fill.BackgroundColor = XLColor.FromArgb(0, 122, 204)
                                worksheet.Cell(4, col + 1).Style.Font.FontColor = XLColor.White
                                worksheet.Cell(4, col + 1).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center
                                worksheet.Cell(4, col + 1).Style.Border.OutsideBorder = XLBorderStyleValues.Thin
                            Next

                            ' Add data
                            Dim rowIndex As Integer = 5
                            Dim dataCount As Integer = 1
                            For Each row As DataGridViewRow In dgvLaporan.Rows
                                If Not row.IsNewRow Then
                                    worksheet.Cell(rowIndex, 1).Value = dataCount
                                    worksheet.Cell(rowIndex, 2).Value = If(row.Cells("Tanggal").Value IsNot Nothing, Convert.ToDateTime(row.Cells("Tanggal").Value).ToString("dd/MM/yyyy"), "")
                                    worksheet.Cell(rowIndex, 3).Value = If(row.Cells("Karyawan").Value IsNot Nothing, row.Cells("Karyawan").Value.ToString(), "")
                                    worksheet.Cell(rowIndex, 4).Value = If(row.Cells("NamaShift").Value IsNot Nothing, row.Cells("NamaShift").Value.ToString(), "")
                                    worksheet.Cell(rowIndex, 5).Value = If(row.Cells("JamMasuk").Value IsNot Nothing AndAlso row.Cells("JamMasuk").Value IsNot DBNull.Value, row.Cells("JamMasuk").Value.ToString(), "")
                                    worksheet.Cell(rowIndex, 6).Value = If(row.Cells("JamPulang").Value IsNot Nothing AndAlso row.Cells("JamPulang").Value IsNot DBNull.Value, row.Cells("JamPulang").Value.ToString(), "")
                                    worksheet.Cell(rowIndex, 7).Value = If(row.Cells("Status").Value IsNot Nothing, row.Cells("Status").Value.ToString(), "")
                                    worksheet.Cell(rowIndex, 8).Value = If(row.Cells("TelatMenit").Value IsNot Nothing AndAlso row.Cells("TelatMenit").Value IsNot DBNull.Value, Convert.ToInt32(row.Cells("TelatMenit").Value), 0)
                                    worksheet.Cell(rowIndex, 9).Value = If(row.Cells("LemburMenit").Value IsNot Nothing AndAlso row.Cells("LemburMenit").Value IsNot DBNull.Value, Convert.ToInt32(row.Cells("LemburMenit").Value), 0)

                                    ' Add borders
                                    For col As Integer = 1 To 9
                                        worksheet.Cell(rowIndex, col).Style.Border.OutsideBorder = XLBorderStyleValues.Thin
                                    Next

                                    rowIndex += 1
                                    dataCount += 1
                                End If
                            Next

                            ' Auto-fit columns
                            worksheet.Columns().AdjustToContents()

                            ' Add export info at the bottom
                            worksheet.Cell(rowIndex + 1, 1).Value = $"Diekspor pada: {DateTime.Now:dd/MM/yyyy HH:mm:ss}"
                            worksheet.Cell(rowIndex + 1, 1).Style.Font.Italic = True

                            ' Save the workbook
                            workbook.SaveAs(saveDialog.FileName)
                        End Using

                        Cursor = Cursors.Default
                        MessageBox.Show($"Data berhasil diekspor ke:{Environment.NewLine}{saveDialog.FileName}", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    Catch ex As Exception
                        Cursor = Cursors.Default
                        MessageBox.Show($"Gagal mengekspor data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End If
            End Using
        End Sub
    End Class
End Namespace

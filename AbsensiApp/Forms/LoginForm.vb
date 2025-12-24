Imports System.Data.SQLite
Imports AbsensiApp.Data
Imports AbsensiApp.Models

Namespace Forms
    Public Class LoginForm
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
            Dim username As String = txtUsername.Text
            Dim password As String = txtPassword.Text

            If String.IsNullOrEmpty(username) OrElse String.IsNullOrEmpty(password) Then
                MessageBox.Show("Username dan Password harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim user As User = Nothing
            Dim errorMsg As String = ""

            Try
                Using conn As SQLiteConnection = DbConnection.GetConnection()
                    conn.Open()
                    Dim query As String = "SELECT UserID, Role, KaryawanID FROM tblUser WHERE Username = @Username AND PasswordHash = @Password"
                    Using cmd As New SQLiteCommand(query, conn)
                        cmd.Parameters.Add("@Username", DbType.String).Value = username
                        cmd.Parameters.Add("@Password", DbType.String).Value = password

                        Using reader As SQLiteDataReader = cmd.ExecuteReader()
                            If reader.Read() Then
                                user = New User()
                                user.UserID = Convert.ToInt32(reader("UserID"))
                                user.Username = username
                                user.Role = reader("Role").ToString()

                                If IsDBNull(reader("KaryawanID")) Then
                                    user.KaryawanID = Nothing
                                Else
                                    user.KaryawanID = Convert.ToInt32(reader("KaryawanID"))
                                End If
                            End If
                        End Using
                    End Using
                End Using
            Catch ex As Exception
                errorMsg = ex.Message
            End Try

            If Not String.IsNullOrEmpty(errorMsg) Then
                MessageBox.Show("Terjadi kesalahan database: " & errorMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            If user IsNot Nothing Then
                ' Open Main Form
                Dim mainForm As New MainForm()
                mainForm.CurrentUser = user
                mainForm.Show()
                Me.Hide()
            Else
                MessageBox.Show("Username atau Password salah!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End Sub

        Private Sub lblTitle_Click(sender As Object, e As EventArgs) Handles lblTitle.Click

        End Sub
    End Class
End Namespace

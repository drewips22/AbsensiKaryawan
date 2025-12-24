Imports System.Data.SQLite
Imports System.Configuration

Namespace Data
    Public Class DbConnection
        Private Shared _connectionString As String = ConfigurationManager.ConnectionStrings("AbsensiConn").ConnectionString

        Public Shared Function GetConnection() As SQLiteConnection
            Return New SQLiteConnection(_connectionString)
        End Function

        Public Shared Function TestConnection() As Boolean
            Using conn As SQLiteConnection = GetConnection()
                Try
                    conn.Open()
                    Return True
                Catch ex As Exception
                    Console.WriteLine("Connection Error: " & ex.Message)
                    Return False
                End Try
            End Using
        End Function
    End Class
End Namespace
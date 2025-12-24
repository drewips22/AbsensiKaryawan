Imports System.Data.SQLite
Imports System.IO
Imports AbsensiApp.Data

Namespace Utils
    Public Class DatabaseHelper
        Public Shared Sub InitializeDatabase()
            Dim dbFile As String = "AbsensiDB.sqlite"
            
            ' Check if database exists
            If Not File.Exists(dbFile) Then
                SQLiteConnection.CreateFile(dbFile)
                
                ' Execute Schema
                Dim schemaPath As String = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "sqlite_schema.sql")
                
                If File.Exists(schemaPath) Then
                    Dim script As String = File.ReadAllText(schemaPath)
                    Using conn As SQLiteConnection = DbConnection.GetConnection()
                        conn.Open()
                        Using cmd As New SQLiteCommand(script, conn)
                            cmd.ExecuteNonQuery()
                        End Using
                    End Using
                Else
                    MessageBox.Show("CRITICAL ERROR: Schema file not found at: " & schemaPath & vbCrLf & "Please ensure sqlite_schema.sql is copied to the output directory.")
                End If
            End If
        End Sub

        Public Shared Function ExecuteDataTable(query As String, Optional parameters As Dictionary(Of String, Object) = Nothing) As DataTable
            Dim dt As New DataTable()
            Using conn As SQLiteConnection = DbConnection.GetConnection()
                Using cmd As New SQLiteCommand(query, conn)
                    If parameters IsNot Nothing Then
                        For Each kvp In parameters
                            cmd.Parameters.AddWithValue(kvp.Key, kvp.Value)
                        Next
                    End If
                    Try
                        conn.Open()
                        Using adapter As New SQLiteDataAdapter(cmd)
                            adapter.Fill(dt)
                        End Using
                    Catch ex As Exception
                        MessageBox.Show("Error Database: " & ex.Message)
                    End Try
                End Using
            End Using
            Return dt
        End Function

        Public Shared Function ExecuteNonQuery(query As String, Optional parameters As Dictionary(Of String, Object) = Nothing) As Integer
            Dim rowsAffected As Integer = 0
            Using conn As SQLiteConnection = DbConnection.GetConnection()
                Using cmd As New SQLiteCommand(query, conn)
                    If parameters IsNot Nothing Then
                        For Each kvp In parameters
                            cmd.Parameters.AddWithValue(kvp.Key, kvp.Value)
                        Next
                    End If
                    Try
                        conn.Open()
                        rowsAffected = cmd.ExecuteNonQuery()
                    Catch ex As Exception
                        MessageBox.Show("Error Database: " & ex.Message)
                    End Try
                End Using
            End Using
            Return rowsAffected
        End Function

        Public Shared Function ExecuteScalar(query As String, Optional parameters As Dictionary(Of String, Object) = Nothing) As Object
            Dim result As Object = Nothing
            Using conn As SQLiteConnection = DbConnection.GetConnection()
                Using cmd As New SQLiteCommand(query, conn)
                    If parameters IsNot Nothing Then
                        For Each kvp In parameters
                            cmd.Parameters.AddWithValue(kvp.Key, kvp.Value)
                        Next
                    End If
                    Try
                        conn.Open()
                        result = cmd.ExecuteScalar()
                    Catch ex As Exception
                        MessageBox.Show("Error Database: " & ex.Message)
                    End Try
                End Using
            End Using
            Return result
        End Function
    End Class
End Namespace

Imports Microsoft.VisualBasic
Imports System
Imports System.Data
Imports System.Data.OleDb
Public Class dal
    Private std As String = ""
    Public Function LoadDataTable(ByVal Query As String) As DataTable
        Try
            Dim da As New OleDbDataAdapter(Query, std)
            Dim dt As New DataTable
            da.Fill(dt)
            Return dt
        Catch ex As Exception
            Return New DataTable
        End Try
    End Function
    Public Function ExecuteNonQuery(ByVal Query As String) As Integer
        Try
            Dim conn As New OleDbConnection(std)
            conn.Open()
            Dim cmd As New OleDbCommand(Query, conn)
            Dim result As Integer = cmd.ExecuteNonQuery
            conn.Close()
            cmd.Dispose()
            conn.Dispose()
            Return result
        Catch ex As Exception
            Return -1
        End Try
    End Function
    Public Function ExecuteScalar(ByVal Query As String) As Object
        Try
            Dim conn As New OleDbConnection(std)
            conn.Open()
            Dim cmd As New OleDbCommand(Query, conn)
            Dim result As Object = cmd.ExecuteScalar
            conn.Close()
            cmd.Dispose()
            conn.Dispose()
            Return result
        Catch ex As Exception
            Return Nothing
        End Try

    End Function
End Class

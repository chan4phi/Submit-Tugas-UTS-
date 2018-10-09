Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient
Module modkon
    Public sql As String
    Public conn As New SqlConnection

    Public str As String = "Data Source =MIKEHAHN;" &
                           "Initial Catalog=dbPengajuan;" &
                           "Persist Security Info=True;" &
                           "UID=sa;PWD=m3ll1s4m4y4"
    Public Sub openkon()
        If conn.State = ConnectionState.Closed Then
            conn.ConnectionString = str
            Try
                conn.Open()
            Catch ex As Exception
                MsgBox("Koneksi gagal:" & ex.ToString)
            End Try
        End If
    End Sub
    Public Sub closekon()
        If conn.State = ConnectionState.Open Then
            Try
                conn.Close()
            Catch ex As Exception
                MsgBox("Error " & ex.ToString)
            End Try
        End If

    End Sub
End Module

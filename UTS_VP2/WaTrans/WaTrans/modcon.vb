Imports System.Data.SqlClient
Module modcon
    Public sql As String
    Public conn As New SqlConnection
    Public str As String = "Data Source=MIKEHAHN; Initial Catalog=dbRental; Persist Security Info=True; UID=sa; PWD=m3ll1s4m4y4"
    Public Sub opencon()
        If conn.State = ConnectionState.Closed Then
            conn.ConnectionString = str
            Try
                conn.Open()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
    End Sub
    Public Sub closecon()
        If conn.State = ConnectionState.Open Then
            Try
                conn.Close()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
    End Sub
End Module

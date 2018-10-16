Imports System.Data.SqlClient
Public Class FRequest
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        tbtggl.Text = FormatDateTime(Now, DateFormat.LongDate) + "   " + FormatDateTime(Now, DateFormat.LongTime)
    End Sub

    Private Sub otoma()
        Dim query As String
        Dim cmd As SqlCommand
        Dim dr As SqlDataReader
        Dim urutan As String

        Try
            Call opencon()
            query = "select * from orderan where RequestId in (select max(RequestId) from orderan) order by RequestId desc"
            cmd = New SqlCommand(query, conn)
            dr = cmd.ExecuteReader
            dr.Read()

            If Not dr.HasRows() Then
                urutan = "1"
            Else
                urutan = dr("RequestId") + 1
            End If
            tbID.Text = urutan
            dr.Close()
            Call closecon()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub FRequest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btbtl.Visible = False
        btsimpan.Visible = True
        btupdt.Visible = False
        Call ViewLV()
        Call otoma()
        tbtmbhn.Visible = False

    End Sub

    Private Sub cbpilihan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbpilihan.SelectedIndexChanged
        If cbpilihan.Text = "Other" Then
            tbtmbhn.Visible = True
        Else
            tbtmbhn.Visible = False
        End If
    End Sub
    Private Sub ViewLV()
        Dim cmd As SqlCommand
        Dim dr As SqlDataReader

        LVdata.View = View.Details
        LVdata.Columns.Add("No", 35)
        LVdata.Columns.Add("Name Of Requestor", 150)
        LVdata.Columns.Add("Unit From", 100)
        LVdata.Columns.Add("Unit To", 100)
        LVdata.Columns.Add("Request Date", 165)
        LVdata.Columns.Add("Transportation", 175)

        Try
            Call opencon()
            Dim query As String = "select * from orderan"
            cmd = New SqlCommand(query, conn)
            dr = cmd.ExecuteReader

            Do While dr.Read
                LVdata.Items.Add(dr("RequestId"))
                LVdata.Items(LVdata.Items.Count - 1).SubItems.Add(dr("NameRequestor"))
                LVdata.Items(LVdata.Items.Count - 1).SubItems.Add(dr("Unit"))
                LVdata.Items(LVdata.Items.Count - 1).SubItems.Add(dr("UnitDestination"))
                LVdata.Items(LVdata.Items.Count - 1).SubItems.Add(dr("DateIssue"))
                LVdata.Items(LVdata.Items.Count - 1).SubItems.Add(dr("Transportation"))
            Loop
            dr.Close()
            Call closecon()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub clearall()
        tbID.Text = ""
        tbidnama.Text = ""
        tbket.Text = ""
        tbnama.Text = ""
        tbnotelp.Text = ""
        tbtmbhn.Text = ""
        tbAC.Text = ""
        tbtujuan.Text = ""
        tbunit.Text = ""
        cbpilihan.Text = ""
    End Sub

    Private Sub btsimpan_Click(sender As Object, e As EventArgs) Handles btsimpan.Click
        Dim query As String
        Dim cmd As SqlCommand
        Dim dr As SqlDataReader
        Dim tggl As String = Format(Date.Now)


        If cbpilihan.Text = "Other" Then
            query = "insert into orderan (RequestId, NameRequestor, RequestorId, Unit, DateIssue, UnitDestination, acRegix, Transportation, Phone, Instruction) values ('" & tbID.Text & "', '" & tbnama.Text & "', '" & tbidnama.Text & "', '" & tbunit.Text & "', '" & tggl & "', '" & tbtujuan.Text & "', '" & tbAC.Text & "', '" & tbtmbhn.Text & "', '" & tbnotelp.Text & "', '" & tbket.Text & "')"
        Else
            query = "insert into orderan (RequestId, NameRequestor, RequestorId, Unit, DateIssue, UnitDestination, acRegix, Transportation, Phone, Instruction) values ('" & tbID.Text & "', '" & tbnama.Text & "', '" & tbidnama.Text & "', '" & tbunit.Text & "', '" & tggl & "', '" & tbtujuan.Text & "', '" & tbAC.Text & "', '" & cbpilihan.Text & "', '" & tbnotelp.Text & "', '" & tbket.Text & "')"
        End If

        Try
            Call opencon()
            cmd = New SqlCommand(query, conn)
            dr = cmd.ExecuteReader
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Call closecon()
        MsgBox("All of the Datas has been saved", MsgBoxStyle.Information, "Message")
        LVdata.Clear()
        Call ViewLV()
        Call clearall()
        Call otoma()
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        Dim cmd As SqlCommand
        Dim dr As SqlDataReader
        Dim idddkn As String


        If MsgBox("Are You sure that You'll delete this data ?", vbYesNo, "Confirmation") = vbYes Then
            idddkn = LVdata.SelectedItems(0).Text
            Try
                Call opencon()
                Dim query As String = "delete from orderan where RequestId= '" + idddkn + "'"
                cmd = New SqlCommand(query, conn)
                dr = cmd.ExecuteReader
                Call closecon()
                dr.Close()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        Else Exit Sub
        End If

        MsgBox("Data has been deleted succesfully")
        Call clearall()
        LVdata.Clear()
        Call otoma()
        Call ViewLV()
    End Sub

    Private Sub EditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem.Click
        btsimpan.Visible = False
        btbtl.Visible = True
        btupdt.Visible = True
        Dim cmd As SqlCommand
        Dim dr As SqlDataReader
        Dim idsmntr As String = LVdata.SelectedItems(0).Text
        Dim tggl As String = Format(Date.Now)
        Try

            Call opencon()
            Dim query As String = "select * from orderan where RequestId = '" + idsmntr + "'"
            cmd = New SqlCommand(query, conn)
            dr = cmd.ExecuteReader
            dr.Read()

            tbID.Text = dr("RequestId")
            tbidnama.Text = dr("RequestorId")
            tbnama.Text = dr("NameRequestor")
            tbunit.Text = dr("Unit")
            tbtujuan.Text = dr("UnitDestination")
            tbAC.Text = dr("acRegix")
            tbnotelp.Text = dr("Phone")
            tbket.Text = dr("Instruction")
            If dr("Transportation").ToString.Trim() = "Pick Up" Then
                cbpilihan.Text = "Pick Up"
            ElseIf dr("Transportation").ToString.Trim() = "Box" Then
                cbpilihan.Text = "Box"
            ElseIf dr("Transportation").ToString.Trim() = "Blind Van" Then
                cbpilihan.Text = "Blind Van"
            ElseIf dr("Transportation").ToString.Trim() = "Truck" Then
                cbpilihan.Text = "Truck"
            ElseIf dr("Transportation").ToString.Trim() = "BTT" Then
                cbpilihan.Text = "BTT"
            ElseIf dr("Transportation").ToString.Trim() = "Forklift" Then
                cbpilihan.Text = "Forklift"
            Else
                cbpilihan.Text = "Other"
                tbtmbhn.Text = dr("Transportation")
            End If

            dr.Close()
            Call closecon()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btupdt_Click(sender As Object, e As EventArgs) Handles btupdt.Click
        Dim query As String
        Dim cmd As SqlCommand
        Dim dr As SqlDataReader
        Dim tggl As String = Format(Date.Now)


        If cbpilihan.Text = "Other" Then
            query = "update orderan set NameRequestor = '" & tbnama.Text & "', RequestorId = '" & tbidnama.Text & "', Unit = '" & tbunit.Text & "', DateIssue = '" & tggl & "', UnitDestination = '" & tbtujuan.Text & "', acRegix = '" & tbAC.Text & "', Transportation = '" & tbtmbhn.Text & "', Phone = '" & tbnotelp.Text & "', Instruction = '" & tbket.Text & "' where RequestId = '" & tbID.Text & "'"
        Else
            query = "update orderan set NameRequestor = '" & tbnama.Text & "', RequestorId = '" & tbidnama.Text & "', Unit = '" & tbunit.Text & "', DateIssue = '" & tggl & "', UnitDestination = '" & tbtujuan.Text & "', acRegix = '" & tbAC.Text & "', Transportation = '" & cbpilihan.Text & "', Phone = '" & tbnotelp.Text & "', Instruction = '" & tbket.Text & "' where RequestId = '" & tbID.Text & "'"
        End If

        Try
            Call opencon()
            cmd = New SqlCommand(query, conn)
            dr = cmd.ExecuteReader
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Call closecon()
        MsgBox("All of the Datas has been updated", MsgBoxStyle.Information, "Message")
        LVdata.Clear()
        Call ViewLV()
        Call clearall()
        Call otoma()
    End Sub

    Private Sub btbtl_Click(sender As Object, e As EventArgs) Handles btbtl.Click
        btsimpan.Visible = True
        btbtl.Visible = False
        btupdt.Visible = False
        Call clearall()
        Call otoma()
    End Sub
End Class


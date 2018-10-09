Imports System.Data.SqlClient
Imports System.Data
Public Class FPengajuan
    Private Sub FPengajuan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lihat_list_pengajuan()
        Call otoma()
        btSimpan.Visible = True
        btupdt.Visible = False
        btbtl.Visible = False
    End Sub
    Private Sub lihat_list_pengajuan()
        Dim cmd As SqlCommand
        Dim dr As SqlDataReader

        LVPengajuan.View = View.Details
        LVPengajuan.Columns.Add("No", 69)
        LVPengajuan.Columns.Add("Nama Penyelenggara", 235)
        LVPengajuan.Columns.Add("Bidang", 150)
        LVPengajuan.Columns.Add("Jumlah", 200)
        LVPengajuan.Columns.Add("Bentuk", 125)

        Try
            Call openkon()
            Dim query_id As String = "select * from Proposal"
            cmd = New SqlCommand(query_id, conn)
            dr = cmd.ExecuteReader

            Do While dr.Read
                LVPengajuan.Items.Add(dr("PID"))
                LVPengajuan.Items(LVPengajuan.Items.Count - 1).SubItems.Add(dr("NamaPlksna"))
                LVPengajuan.Items(LVPengajuan.Items.Count - 1).SubItems.Add(dr("Bidang"))
                LVPengajuan.Items(LVPengajuan.Items.Count - 1).SubItems.Add(dr("Jumlah"))
                LVPengajuan.Items(LVPengajuan.Items.Count - 1).SubItems.Add(dr("Bentuk"))
            Loop
            dr.Close()

            Call closekon()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btSimpan_Click(sender As Object, e As EventArgs) Handles btSimpan.Click
        Dim query As String
        Dim cmd As SqlCommand
        Dim dr As SqlDataReader

        Dim tggl As String = FormatDateTime(Now, DateFormat.ShortDate)

        Call openkon()

        Dim rbt As String
        If rb1.Checked = True Then
            rbt = rb1.Text
        ElseIf rb2.Checked = True Then
            rbt = rb2.Text
        ElseIf rb3.Checked = True Then
            rbt = rb3.Text
        End If

        query = "insert into Proposal (PID, NamaPlksna, Bidang, Jumlah, Bentuk, Keperluan, Tanggal) values ('" & tbID.Text & "', '" & tbnama.Text & "', '" & cbbidang.Text & "', '" & tbjumlah.Text & "', '" & rbt & "', '" & tbkprln.Text & "', '" & tggl & "')"
        cmd = New SqlCommand(query, conn)
        On Error Resume Next
        dr = cmd.ExecuteReader
        dr.Close()
        MsgBox("Data Berhasil diSimpan")
        Call closekon()
        Call clear()
        LVPengajuan.Clear()
        Call otoma()
        Call lihat_list_pengajuan()
    End Sub
    Private Sub clear()
        tbjumlah.Text = ""
        cbbidang.Text = ""
        tbkprln.Text = ""
        tbnama.Text = ""
        tbID.Text = ""
        rb1.Checked = Nothing
        rb2.Checked = Nothing
        rb3.Checked = Nothing

    End Sub

    Private Sub HapusToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HapusToolStripMenuItem.Click
        Dim idsmntr As String
        Dim cmd As SqlCommand
        Dim dr As SqlDataReader

        If MsgBox("Apakah Anda Yakin menghapus Data ini ?", vbYesNo, "Konfirmasi") = vbYes Then
            idsmntr = LVPengajuan.SelectedItems(0).Text

            Try
                Call openkon()
                Dim query As String = "delete from Proposal where PID= '" + idsmntr + "'"
                cmd = New SqlCommand(query, conn)
                dr = cmd.ExecuteReader
                Call closekon()
                dr.Close()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        Else Exit Sub
        End If

        MsgBox("Data berhasil diHapus")
        Call clear()
        Call otoma()
        LVPengajuan.Clear()
        lihat_list_pengajuan()
    End Sub

    Private Sub EditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem.Click
        Dim cmd As SqlCommand
        Dim dr As SqlDataReader
        Dim idddkn As String
        btupdt.Visible = True
        btSimpan.Visible = False
        btbtl.Visible = True
        Try
            idddkn = LVPengajuan.SelectedItems(0).Text

            Call openkon()
            Dim query As String = "select * from Proposal where PID = '" + idddkn + "'"
            cmd = New SqlCommand(query, conn)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr("Bentuk") = "Tunai" Then
                rb1.Checked = True
            ElseIf dr("Bentuk") = "Cek Bank" Then
                rb2.Checked = True
            ElseIf dr("Bentuk") = "Giro" Then
                rb3.Checked = True
            End If
            tbID.Text = dr("PID")
            tbjumlah.Text = dr("Jumlah")
            tbnama.Text = dr("NamaPlksna")
            cbbidang.Text = dr("Bidang")
            tbkprln.Text = dr("Keperluan")
            dr.Close()
            Call closekon()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub tbjumlah_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbjumlah.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub otoma()
        Dim cmd As SqlCommand
        Dim dr As SqlDataReader
        Dim query As String
        Dim urutan As String
        Dim hitung As Long

        Try
            Call openkon()
            query = "select * from Proposal where PID in (select max(PID) from Proposal) order by PID desc"
            cmd = New SqlCommand(query, conn)
            dr = cmd.ExecuteReader
            dr.Read()

            If Not dr.HasRows() Then
                urutan = "PJ" + Format(Now, "ddMMyy") + "01"
            Else
                hitung = Microsoft.VisualBasic.Right(dr.GetString(0), 2) + 1
                urutan = "PJ" + Format(Now, "ddMMyy") + Microsoft.VisualBasic.Right("00" & hitung, 2)
            End If
            tbID.Text = urutan
            dr.Close()
            Call closekon()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub btupdt_Click(sender As Object, e As EventArgs) Handles btupdt.Click
        Dim query As String
        Dim cmd As SqlCommand
        Dim dr As SqlDataReader
        Dim rbe As String

        If rb1.Checked = True Then
            rbe = rb1.Text
        ElseIf rb2.Checked = True Then
            rbe = rb2.Text
        ElseIf rb3.Checked = True Then
            rbe = rb3.Text

        End If
        Try
            Call openkon()
            query = "update Proposal set NamaPlksna = '" & tbnama.Text & "', Bidang = '" & cbbidang.Text & "', Jumlah = '" & tbjumlah.Text & "', Bentuk = '" & rbe & "', Keperluan = '" & tbkprln.Text & "' where PID = '" & tbID.Text & "'"
            cmd = New SqlCommand(query, conn)
            dr = cmd.ExecuteReader
            dr.Close()
            Call closekon()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        MsgBox("Proses update berhasil")
        LVPengajuan.Clear()
        Call clear()
        Call otoma()
        lihat_list_pengajuan()
        btbtl.Visible = False
        btupdt.Visible = False
        btSimpan.Visible = True
    End Sub

    Private Sub btbtl_Click(sender As Object, e As EventArgs) Handles btbtl.Click
        LVPengajuan.Clear()
        Call clear()
        Call otoma()
        lihat_list_pengajuan()
        btSimpan.Visible = True
        btupdt.Visible = False
        btbtl.Visible = False
    End Sub
End Class

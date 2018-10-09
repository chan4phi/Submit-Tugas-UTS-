<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FPengajuan
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbnama = New System.Windows.Forms.TextBox()
        Me.cbbidang = New System.Windows.Forms.ComboBox()
        Me.tbjumlah = New System.Windows.Forms.TextBox()
        Me.rb1 = New System.Windows.Forms.RadioButton()
        Me.rb3 = New System.Windows.Forms.RadioButton()
        Me.rb2 = New System.Windows.Forms.RadioButton()
        Me.tbkprln = New System.Windows.Forms.TextBox()
        Me.btSimpan = New System.Windows.Forms.Button()
        Me.tbID = New System.Windows.Forms.TextBox()
        Me.btupdt = New System.Windows.Forms.Button()
        Me.LVPengajuan = New System.Windows.Forms.ListView()
        Me.CMSLV = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HapusToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btbtl = New System.Windows.Forms.Button()
        Me.CMSLV.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(128, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(246, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Form Pengajuan Dana"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(41, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama Pelaksana"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(41, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Bidang"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(41, 143)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Jumlah Permintaan"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(41, 177)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Bentuk Dana"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(41, 253)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Keperluan"
        '
        'tbnama
        '
        Me.tbnama.Location = New System.Drawing.Point(189, 78)
        Me.tbnama.Name = "tbnama"
        Me.tbnama.Size = New System.Drawing.Size(235, 20)
        Me.tbnama.TabIndex = 6
        '
        'cbbidang
        '
        Me.cbbidang.FormattingEnabled = True
        Me.cbbidang.Items.AddRange(New Object() {"ICT", "Akademik", "Keuangan", "Marketing"})
        Me.cbbidang.Location = New System.Drawing.Point(189, 108)
        Me.cbbidang.Name = "cbbidang"
        Me.cbbidang.Size = New System.Drawing.Size(235, 21)
        Me.cbbidang.TabIndex = 7
        '
        'tbjumlah
        '
        Me.tbjumlah.Location = New System.Drawing.Point(189, 140)
        Me.tbjumlah.Name = "tbjumlah"
        Me.tbjumlah.Size = New System.Drawing.Size(235, 20)
        Me.tbjumlah.TabIndex = 8
        '
        'rb1
        '
        Me.rb1.AutoSize = True
        Me.rb1.Location = New System.Drawing.Point(189, 177)
        Me.rb1.Name = "rb1"
        Me.rb1.Size = New System.Drawing.Size(52, 17)
        Me.rb1.TabIndex = 9
        Me.rb1.TabStop = True
        Me.rb1.Text = "Tunai"
        Me.rb1.UseVisualStyleBackColor = True
        '
        'rb3
        '
        Me.rb3.AutoSize = True
        Me.rb3.Location = New System.Drawing.Point(189, 223)
        Me.rb3.Name = "rb3"
        Me.rb3.Size = New System.Drawing.Size(44, 17)
        Me.rb3.TabIndex = 10
        Me.rb3.TabStop = True
        Me.rb3.Text = "Giro"
        Me.rb3.UseVisualStyleBackColor = True
        '
        'rb2
        '
        Me.rb2.AutoSize = True
        Me.rb2.Location = New System.Drawing.Point(189, 200)
        Me.rb2.Name = "rb2"
        Me.rb2.Size = New System.Drawing.Size(72, 17)
        Me.rb2.TabIndex = 11
        Me.rb2.TabStop = True
        Me.rb2.Text = "Cek Bank"
        Me.rb2.UseVisualStyleBackColor = True
        '
        'tbkprln
        '
        Me.tbkprln.Location = New System.Drawing.Point(189, 253)
        Me.tbkprln.Multiline = True
        Me.tbkprln.Name = "tbkprln"
        Me.tbkprln.Size = New System.Drawing.Size(235, 177)
        Me.tbkprln.TabIndex = 12
        '
        'btSimpan
        '
        Me.btSimpan.Location = New System.Drawing.Point(216, 445)
        Me.btSimpan.Name = "btSimpan"
        Me.btSimpan.Size = New System.Drawing.Size(75, 23)
        Me.btSimpan.TabIndex = 13
        Me.btSimpan.Text = "Simpan"
        Me.btSimpan.UseVisualStyleBackColor = True
        '
        'tbID
        '
        Me.tbID.Location = New System.Drawing.Point(321, 199)
        Me.tbID.Name = "tbID"
        Me.tbID.Size = New System.Drawing.Size(136, 20)
        Me.tbID.TabIndex = 14
        Me.tbID.Visible = False
        '
        'btupdt
        '
        Me.btupdt.Location = New System.Drawing.Point(216, 445)
        Me.btupdt.Name = "btupdt"
        Me.btupdt.Size = New System.Drawing.Size(75, 23)
        Me.btupdt.TabIndex = 15
        Me.btupdt.Text = "Ubah"
        Me.btupdt.UseVisualStyleBackColor = True
        '
        'LVPengajuan
        '
        Me.LVPengajuan.ContextMenuStrip = Me.CMSLV
        Me.LVPengajuan.Location = New System.Drawing.Point(12, 487)
        Me.LVPengajuan.Name = "LVPengajuan"
        Me.LVPengajuan.Size = New System.Drawing.Size(466, 185)
        Me.LVPengajuan.TabIndex = 16
        Me.LVPengajuan.UseCompatibleStateImageBehavior = False
        '
        'CMSLV
        '
        Me.CMSLV.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditToolStripMenuItem, Me.HapusToolStripMenuItem})
        Me.CMSLV.Name = "CMSLV"
        Me.CMSLV.Size = New System.Drawing.Size(109, 48)
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(108, 22)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'HapusToolStripMenuItem
        '
        Me.HapusToolStripMenuItem.Name = "HapusToolStripMenuItem"
        Me.HapusToolStripMenuItem.Size = New System.Drawing.Size(108, 22)
        Me.HapusToolStripMenuItem.Text = "Hapus"
        '
        'btbtl
        '
        Me.btbtl.Location = New System.Drawing.Point(403, 445)
        Me.btbtl.Name = "btbtl"
        Me.btbtl.Size = New System.Drawing.Size(75, 23)
        Me.btbtl.TabIndex = 17
        Me.btbtl.Text = "Batal"
        Me.btbtl.UseVisualStyleBackColor = True
        '
        'FPengajuan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(490, 684)
        Me.Controls.Add(Me.btbtl)
        Me.Controls.Add(Me.LVPengajuan)
        Me.Controls.Add(Me.btupdt)
        Me.Controls.Add(Me.tbID)
        Me.Controls.Add(Me.btSimpan)
        Me.Controls.Add(Me.tbkprln)
        Me.Controls.Add(Me.rb2)
        Me.Controls.Add(Me.rb3)
        Me.Controls.Add(Me.rb1)
        Me.Controls.Add(Me.tbjumlah)
        Me.Controls.Add(Me.cbbidang)
        Me.Controls.Add(Me.tbnama)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FPengajuan"
        Me.Text = "Pengajuan"
        Me.CMSLV.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents tbnama As TextBox
    Friend WithEvents cbbidang As ComboBox
    Friend WithEvents tbjumlah As TextBox
    Friend WithEvents rb1 As RadioButton
    Friend WithEvents rb3 As RadioButton
    Friend WithEvents rb2 As RadioButton
    Friend WithEvents tbkprln As TextBox
    Friend WithEvents btSimpan As Button
    Friend WithEvents tbID As TextBox
    Friend WithEvents btupdt As Button
    Friend WithEvents LVPengajuan As ListView
    Friend WithEvents CMSLV As ContextMenuStrip
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HapusToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btbtl As Button
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRequest
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.tbnama = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbpilihan = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tbidnama = New System.Windows.Forms.TextBox()
        Me.tbunit = New System.Windows.Forms.TextBox()
        Me.tbtggl = New System.Windows.Forms.TextBox()
        Me.tbket = New System.Windows.Forms.TextBox()
        Me.tbtujuan = New System.Windows.Forms.TextBox()
        Me.tbAC = New System.Windows.Forms.TextBox()
        Me.btsimpan = New System.Windows.Forms.Button()
        Me.btupdt = New System.Windows.Forms.Button()
        Me.btbtl = New System.Windows.Forms.Button()
        Me.tbnotelp = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.tbtmbhn = New System.Windows.Forms.TextBox()
        Me.tbID = New System.Windows.Forms.TextBox()
        Me.tbheaderLV = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.LVdata = New System.Windows.Forms.ListView()
        Me.CMSmanipulation = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CMSmanipulation.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbnama
        '
        Me.tbnama.Location = New System.Drawing.Point(134, 71)
        Me.tbnama.Name = "tbnama"
        Me.tbnama.Size = New System.Drawing.Size(149, 20)
        Me.tbnama.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 17.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(129, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(388, 28)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Transportation Request Form"
        '
        'cbpilihan
        '
        Me.cbpilihan.FormattingEnabled = True
        Me.cbpilihan.Items.AddRange(New Object() {"Pick Up", "Box", "Blind Van", "Truck", "BTT", "Forklift", "Other"})
        Me.cbpilihan.Location = New System.Drawing.Point(463, 163)
        Me.cbpilihan.Name = "cbpilihan"
        Me.cbpilihan.Size = New System.Drawing.Size(159, 21)
        Me.cbpilihan.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Name of Requestor"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "ID Number"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(26, 167)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(26, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Unit"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(26, 215)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Date Issue"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(26, 265)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Instruction"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(358, 74)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 13)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "to Unit/Destination"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(358, 120)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 13)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "A/C Reg"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(358, 166)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(75, 13)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Transportation"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(358, 234)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(79, 13)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "Ext. Phone/HP"
        '
        'tbidnama
        '
        Me.tbidnama.Location = New System.Drawing.Point(134, 117)
        Me.tbidnama.Name = "tbidnama"
        Me.tbidnama.Size = New System.Drawing.Size(149, 20)
        Me.tbidnama.TabIndex = 13
        '
        'tbunit
        '
        Me.tbunit.Location = New System.Drawing.Point(134, 164)
        Me.tbunit.Name = "tbunit"
        Me.tbunit.Size = New System.Drawing.Size(149, 20)
        Me.tbunit.TabIndex = 14
        '
        'tbtggl
        '
        Me.tbtggl.BackColor = System.Drawing.SystemColors.Menu
        Me.tbtggl.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbtggl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbtggl.Location = New System.Drawing.Point(134, 215)
        Me.tbtggl.Name = "tbtggl"
        Me.tbtggl.Size = New System.Drawing.Size(209, 13)
        Me.tbtggl.TabIndex = 15
        '
        'tbket
        '
        Me.tbket.Location = New System.Drawing.Point(134, 262)
        Me.tbket.Multiline = True
        Me.tbket.Name = "tbket"
        Me.tbket.Size = New System.Drawing.Size(497, 115)
        Me.tbket.TabIndex = 16
        '
        'tbtujuan
        '
        Me.tbtujuan.Location = New System.Drawing.Point(463, 71)
        Me.tbtujuan.Name = "tbtujuan"
        Me.tbtujuan.Size = New System.Drawing.Size(159, 20)
        Me.tbtujuan.TabIndex = 17
        '
        'tbAC
        '
        Me.tbAC.Location = New System.Drawing.Point(463, 117)
        Me.tbAC.Name = "tbAC"
        Me.tbAC.Size = New System.Drawing.Size(159, 20)
        Me.tbAC.TabIndex = 18
        '
        'btsimpan
        '
        Me.btsimpan.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btsimpan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btsimpan.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btsimpan.ForeColor = System.Drawing.SystemColors.Info
        Me.btsimpan.Location = New System.Drawing.Point(284, 393)
        Me.btsimpan.Name = "btsimpan"
        Me.btsimpan.Size = New System.Drawing.Size(86, 23)
        Me.btsimpan.TabIndex = 19
        Me.btsimpan.Text = "Send Request"
        Me.btsimpan.UseVisualStyleBackColor = False
        '
        'btupdt
        '
        Me.btupdt.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btupdt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btupdt.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btupdt.ForeColor = System.Drawing.SystemColors.Info
        Me.btupdt.Location = New System.Drawing.Point(284, 393)
        Me.btupdt.Name = "btupdt"
        Me.btupdt.Size = New System.Drawing.Size(86, 23)
        Me.btupdt.TabIndex = 20
        Me.btupdt.Text = "Change Data"
        Me.btupdt.UseVisualStyleBackColor = False
        '
        'btbtl
        '
        Me.btbtl.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btbtl.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btbtl.ForeColor = System.Drawing.SystemColors.Info
        Me.btbtl.Location = New System.Drawing.Point(518, 393)
        Me.btbtl.Name = "btbtl"
        Me.btbtl.Size = New System.Drawing.Size(86, 23)
        Me.btbtl.TabIndex = 21
        Me.btbtl.Text = "Cancel"
        Me.btbtl.UseVisualStyleBackColor = False
        '
        'tbnotelp
        '
        Me.tbnotelp.Location = New System.Drawing.Point(463, 231)
        Me.tbnotelp.Name = "tbnotelp"
        Me.tbnotelp.Size = New System.Drawing.Size(159, 20)
        Me.tbnotelp.TabIndex = 22
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 500
        '
        'tbtmbhn
        '
        Me.tbtmbhn.Location = New System.Drawing.Point(463, 190)
        Me.tbtmbhn.Name = "tbtmbhn"
        Me.tbtmbhn.Size = New System.Drawing.Size(159, 20)
        Me.tbtmbhn.TabIndex = 23
        '
        'tbID
        '
        Me.tbID.Location = New System.Drawing.Point(12, 317)
        Me.tbID.Name = "tbID"
        Me.tbID.Size = New System.Drawing.Size(100, 20)
        Me.tbID.TabIndex = 24
        Me.tbID.Visible = False
        '
        'tbheaderLV
        '
        Me.tbheaderLV.BackColor = System.Drawing.SystemColors.MenuText
        Me.tbheaderLV.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbheaderLV.ForeColor = System.Drawing.SystemColors.WindowText
        Me.tbheaderLV.Location = New System.Drawing.Point(1, 423)
        Me.tbheaderLV.Multiline = True
        Me.tbheaderLV.Name = "tbheaderLV"
        Me.tbheaderLV.Size = New System.Drawing.Size(641, 37)
        Me.tbheaderLV.TabIndex = 25
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.Info
        Me.Label11.Location = New System.Drawing.Point(265, 429)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(124, 24)
        Me.Label11.TabIndex = 26
        Me.Label11.Text = "Request List"
        '
        'LVdata
        '
        Me.LVdata.ContextMenuStrip = Me.CMSmanipulation
        Me.LVdata.Location = New System.Drawing.Point(1, 463)
        Me.LVdata.Name = "LVdata"
        Me.LVdata.Size = New System.Drawing.Size(641, 206)
        Me.LVdata.TabIndex = 27
        Me.LVdata.UseCompatibleStateImageBehavior = False
        '
        'CMSmanipulation
        '
        Me.CMSmanipulation.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditToolStripMenuItem, Me.DeleteToolStripMenuItem})
        Me.CMSmanipulation.Name = "CMSmanipulation"
        Me.CMSmanipulation.Size = New System.Drawing.Size(108, 48)
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'FRequest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(643, 665)
        Me.Controls.Add(Me.LVdata)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.tbheaderLV)
        Me.Controls.Add(Me.tbID)
        Me.Controls.Add(Me.tbtmbhn)
        Me.Controls.Add(Me.tbnotelp)
        Me.Controls.Add(Me.btbtl)
        Me.Controls.Add(Me.btupdt)
        Me.Controls.Add(Me.btsimpan)
        Me.Controls.Add(Me.tbAC)
        Me.Controls.Add(Me.tbtujuan)
        Me.Controls.Add(Me.tbket)
        Me.Controls.Add(Me.tbtggl)
        Me.Controls.Add(Me.tbunit)
        Me.Controls.Add(Me.tbidnama)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbpilihan)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbnama)
        Me.Name = "FRequest"
        Me.Text = "Rent"
        Me.CMSmanipulation.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbnama As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cbpilihan As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents tbidnama As TextBox
    Friend WithEvents tbunit As TextBox
    Friend WithEvents tbtggl As TextBox
    Friend WithEvents tbket As TextBox
    Friend WithEvents tbtujuan As TextBox
    Friend WithEvents tbAC As TextBox
    Friend WithEvents btsimpan As Button
    Friend WithEvents btupdt As Button
    Friend WithEvents btbtl As Button
    Friend WithEvents tbnotelp As TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents tbtmbhn As TextBox
    Friend WithEvents tbID As TextBox
    Friend WithEvents tbheaderLV As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents LVdata As ListView
    Friend WithEvents CMSmanipulation As ContextMenuStrip
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As ToolStripMenuItem
End Class

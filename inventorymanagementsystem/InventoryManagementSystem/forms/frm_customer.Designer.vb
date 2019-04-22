<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_customer
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
        Me.dtglist = New System.Windows.Forms.DataGridView()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtsearch = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtcusid = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtaddress = New System.Windows.Forms.RichTextBox()
        Me.txtfname = New System.Windows.Forms.TextBox()
        Me.txttelephone = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtmobile = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtlname = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblmax = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnlast = New System.Windows.Forms.Button()
        Me.btnnext = New System.Windows.Forms.Button()
        Me.btnprev = New System.Windows.Forms.Button()
        Me.btnfirst = New System.Windows.Forms.Button()
        Me.lblinc = New System.Windows.Forms.Label()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.btnclear = New System.Windows.Forms.Button()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dtglist, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtglist
        '
        Me.dtglist.AllowUserToAddRows = False
        Me.dtglist.AllowUserToDeleteRows = False
        Me.dtglist.AllowUserToResizeColumns = False
        Me.dtglist.AllowUserToResizeRows = False
        Me.dtglist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtglist.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtglist.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dtglist.Location = New System.Drawing.Point(0, 34)
        Me.dtglist.Name = "dtglist"
        Me.dtglist.Size = New System.Drawing.Size(823, 291)
        Me.dtglist.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(0, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(823, 34)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "List Of Customer"
        '
        'btnadd
        '
        Me.btnadd.Location = New System.Drawing.Point(415, 206)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(109, 29)
        Me.btnadd.TabIndex = 6
        Me.btnadd.Text = "Add"
        Me.btnadd.UseVisualStyleBackColor = True
        Me.btnadd.Visible = False
        '
        'btndelete
        '
        Me.btndelete.BackColor = System.Drawing.Color.Black
        Me.btndelete.ForeColor = System.Drawing.Color.White
        Me.btndelete.Location = New System.Drawing.Point(264, 192)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(114, 29)
        Me.btndelete.TabIndex = 12
        Me.btndelete.Text = "Delete"
        Me.btndelete.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.dtglist)
        Me.Panel2.Controls.Add(Me.btnadd)
        Me.Panel2.Controls.Add(Me.btndelete)
        Me.Panel2.Controls.Add(Me.txtsearch)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 219)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(823, 325)
        Me.Panel2.TabIndex = 24
        '
        'txtsearch
        '
        Me.txtsearch.Location = New System.Drawing.Point(614, 6)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(197, 20)
        Me.txtsearch.TabIndex = 37
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(562, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 13)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "Search :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(86, 47)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(69, 13)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Customer Id :"
        '
        'txtcusid
        '
        Me.txtcusid.Enabled = False
        Me.txtcusid.Location = New System.Drawing.Point(163, 44)
        Me.txtcusid.Name = "txtcusid"
        Me.txtcusid.Size = New System.Drawing.Size(214, 20)
        Me.txtcusid.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(8, 7)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(175, 24)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Add New Customer"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(99, 110)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Address :"
        '
        'txtaddress
        '
        Me.txtaddress.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtaddress.Location = New System.Drawing.Point(163, 107)
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.Size = New System.Drawing.Size(213, 46)
        Me.txtaddress.TabIndex = 4
        Me.txtaddress.Text = ""
        '
        'txtfname
        '
        Me.txtfname.Location = New System.Drawing.Point(163, 73)
        Me.txtfname.Name = "txtfname"
        Me.txtfname.Size = New System.Drawing.Size(214, 20)
        Me.txtfname.TabIndex = 0
        '
        'txttelephone
        '
        Me.txttelephone.Location = New System.Drawing.Point(463, 131)
        Me.txttelephone.Name = "txttelephone"
        Me.txttelephone.Size = New System.Drawing.Size(226, 20)
        Me.txttelephone.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(403, 108)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Mobile # :"
        '
        'txtmobile
        '
        Me.txtmobile.Location = New System.Drawing.Point(463, 104)
        Me.txtmobile.Name = "txtmobile"
        Me.txtmobile.Size = New System.Drawing.Size(226, 20)
        Me.txtmobile.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(392, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Last Name :"
        '
        'txtlname
        '
        Me.txtlname.Location = New System.Drawing.Point(463, 73)
        Me.txtlname.Name = "txtlname"
        Me.txtlname.Size = New System.Drawing.Size(226, 20)
        Me.txtlname.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.lblmax)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.btnlast)
        Me.Panel1.Controls.Add(Me.btnnext)
        Me.Panel1.Controls.Add(Me.btnprev)
        Me.Panel1.Controls.Add(Me.btnfirst)
        Me.Panel1.Controls.Add(Me.lblinc)
        Me.Panel1.Controls.Add(Me.btnsave)
        Me.Panel1.Controls.Add(Me.btnclear)
        Me.Panel1.Controls.Add(Me.btnupdate)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.txtcusid)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txttelephone)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtmobile)
        Me.Panel1.Controls.Add(Me.txtaddress)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtlname)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtfname)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(823, 219)
        Me.Panel1.TabIndex = 25
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(372, 170)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(114, 29)
        Me.Button1.TabIndex = 49
        Me.Button1.Text = "Close"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'lblmax
        '
        Me.lblmax.AutoSize = True
        Me.lblmax.Location = New System.Drawing.Point(539, 178)
        Me.lblmax.Name = "lblmax"
        Me.lblmax.Size = New System.Drawing.Size(13, 13)
        Me.lblmax.TabIndex = 47
        Me.lblmax.Text = "0"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(516, 178)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(16, 13)
        Me.Label11.TabIndex = 46
        Me.Label11.Text = "of"
        '
        'btnlast
        '
        Me.btnlast.BackColor = System.Drawing.Color.Transparent
        Me.btnlast.ForeColor = System.Drawing.Color.Black
        Me.btnlast.Location = New System.Drawing.Point(754, 170)
        Me.btnlast.Name = "btnlast"
        Me.btnlast.Size = New System.Drawing.Size(56, 29)
        Me.btnlast.TabIndex = 45
        Me.btnlast.Text = ">>"
        Me.btnlast.UseVisualStyleBackColor = False
        '
        'btnnext
        '
        Me.btnnext.BackColor = System.Drawing.Color.Transparent
        Me.btnnext.ForeColor = System.Drawing.Color.Black
        Me.btnnext.Location = New System.Drawing.Point(692, 170)
        Me.btnnext.Name = "btnnext"
        Me.btnnext.Size = New System.Drawing.Size(56, 29)
        Me.btnnext.TabIndex = 44
        Me.btnnext.Text = ">"
        Me.btnnext.UseVisualStyleBackColor = False
        '
        'btnprev
        '
        Me.btnprev.BackColor = System.Drawing.Color.Transparent
        Me.btnprev.ForeColor = System.Drawing.Color.Black
        Me.btnprev.Location = New System.Drawing.Point(628, 170)
        Me.btnprev.Name = "btnprev"
        Me.btnprev.Size = New System.Drawing.Size(56, 29)
        Me.btnprev.TabIndex = 43
        Me.btnprev.Text = "<"
        Me.btnprev.UseVisualStyleBackColor = False
        '
        'btnfirst
        '
        Me.btnfirst.BackColor = System.Drawing.Color.Transparent
        Me.btnfirst.ForeColor = System.Drawing.Color.Black
        Me.btnfirst.Location = New System.Drawing.Point(566, 169)
        Me.btnfirst.Name = "btnfirst"
        Me.btnfirst.Size = New System.Drawing.Size(56, 29)
        Me.btnfirst.TabIndex = 42
        Me.btnfirst.Text = "<<"
        Me.btnfirst.UseVisualStyleBackColor = False
        '
        'lblinc
        '
        Me.lblinc.AutoSize = True
        Me.lblinc.Location = New System.Drawing.Point(497, 178)
        Me.lblinc.Name = "lblinc"
        Me.lblinc.Size = New System.Drawing.Size(13, 13)
        Me.lblinc.TabIndex = 48
        Me.lblinc.Text = "0"
        '
        'btnsave
        '
        Me.btnsave.BackColor = System.Drawing.Color.Transparent
        Me.btnsave.ForeColor = System.Drawing.Color.Black
        Me.btnsave.Location = New System.Drawing.Point(12, 171)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(114, 29)
        Me.btnsave.TabIndex = 40
        Me.btnsave.Text = "Save"
        Me.btnsave.UseVisualStyleBackColor = False
        '
        'btnclear
        '
        Me.btnclear.BackColor = System.Drawing.Color.Transparent
        Me.btnclear.ForeColor = System.Drawing.Color.Black
        Me.btnclear.Location = New System.Drawing.Point(252, 170)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(114, 29)
        Me.btnclear.TabIndex = 39
        Me.btnclear.Text = "New"
        Me.btnclear.UseVisualStyleBackColor = False
        '
        'btnupdate
        '
        Me.btnupdate.BackColor = System.Drawing.Color.Transparent
        Me.btnupdate.ForeColor = System.Drawing.Color.Black
        Me.btnupdate.Location = New System.Drawing.Point(132, 171)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(114, 29)
        Me.btnupdate.TabIndex = 41
        Me.btnupdate.Text = "Update"
        Me.btnupdate.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(387, 135)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Telephone # :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(89, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "First Name :"
        '
        'frm_customer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(823, 552)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frm_customer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Customer"
        CType(Me.dtglist, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dtglist As DataGridView
    Friend WithEvents Label8 As Label
    Friend WithEvents btnadd As Button
    Friend WithEvents btndelete As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents txtcusid As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtaddress As RichTextBox
    Friend WithEvents txtfname As TextBox
    Friend WithEvents txttelephone As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtmobile As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtlname As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents lblmax As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents btnlast As Button
    Friend WithEvents btnnext As Button
    Friend WithEvents btnprev As Button
    Friend WithEvents btnfirst As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txtsearch As TextBox
    Friend WithEvents lblinc As Label
    Friend WithEvents btnsave As Button
    Friend WithEvents btnclear As Button
    Friend WithEvents btnupdate As Button
End Class

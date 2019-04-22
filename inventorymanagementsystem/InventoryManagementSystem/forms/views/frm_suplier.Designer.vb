<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_suplier
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
        Me.btndelete = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txttelephone = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtmobile = New System.Windows.Forms.TextBox()
        Me.txtaddress = New System.Windows.Forms.RichTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtlname = New System.Windows.Forms.TextBox()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtsearch = New System.Windows.Forms.TextBox()
        Me.dtglist = New System.Windows.Forms.DataGridView()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtfname = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnclear = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        CType(Me.dtglist, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btndelete
        '
        Me.btndelete.Location = New System.Drawing.Point(282, 166)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(129, 23)
        Me.btndelete.TabIndex = 24
        Me.btndelete.Text = "Delete"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(8, 6)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(153, 24)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Add New Suplier"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(22, 71)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Address :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(267, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Telephone # :"
        '
        'txttelephone
        '
        Me.txttelephone.Location = New System.Drawing.Point(343, 94)
        Me.txttelephone.Name = "txttelephone"
        Me.txttelephone.Size = New System.Drawing.Size(181, 20)
        Me.txttelephone.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(283, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Mobile # :"
        '
        'txtmobile
        '
        Me.txtmobile.Location = New System.Drawing.Point(343, 68)
        Me.txtmobile.Name = "txtmobile"
        Me.txtmobile.Size = New System.Drawing.Size(181, 20)
        Me.txtmobile.TabIndex = 5
        '
        'txtaddress
        '
        Me.txtaddress.Location = New System.Drawing.Point(79, 68)
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.Size = New System.Drawing.Size(185, 68)
        Me.txtaddress.TabIndex = 4
        Me.txtaddress.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(273, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Last Name :"
        '
        'txtlname
        '
        Me.txtlname.Location = New System.Drawing.Point(343, 42)
        Me.txtlname.Name = "txtlname"
        Me.txtlname.Size = New System.Drawing.Size(181, 20)
        Me.txtlname.TabIndex = 2
        '
        'btnadd
        '
        Me.btnadd.Location = New System.Drawing.Point(407, 167)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(120, 23)
        Me.btnadd.TabIndex = 20
        Me.btnadd.Text = "Add"
        Me.btnadd.UseVisualStyleBackColor = True
        Me.btnadd.Visible = False
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.btnadd)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.txtsearch)
        Me.Panel2.Controls.Add(Me.dtglist)
        Me.Panel2.Location = New System.Drawing.Point(12, 205)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(535, 196)
        Me.Panel2.TabIndex = 20
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 173)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Search :"
        '
        'txtsearch
        '
        Me.txtsearch.Location = New System.Drawing.Point(62, 170)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(232, 20)
        Me.txtsearch.TabIndex = 4
        '
        'dtglist
        '
        Me.dtglist.AllowUserToAddRows = False
        Me.dtglist.AllowUserToDeleteRows = False
        Me.dtglist.AllowUserToResizeColumns = False
        Me.dtglist.AllowUserToResizeRows = False
        Me.dtglist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtglist.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dtglist.Location = New System.Drawing.Point(12, 13)
        Me.dtglist.Name = "dtglist"
        Me.dtglist.Size = New System.Drawing.Size(515, 151)
        Me.dtglist.TabIndex = 0
        '
        'btnupdate
        '
        Me.btnupdate.Location = New System.Drawing.Point(147, 166)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(129, 23)
        Me.btnupdate.TabIndex = 25
        Me.btnupdate.Text = "Update"
        Me.btnupdate.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "First Name :"
        '
        'txtfname
        '
        Me.txtfname.Location = New System.Drawing.Point(78, 42)
        Me.txtfname.Name = "txtfname"
        Me.txtfname.Size = New System.Drawing.Size(186, 20)
        Me.txtfname.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
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
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(535, 148)
        Me.Panel1.TabIndex = 21
        '
        'btnclear
        '
        Me.btnclear.Location = New System.Drawing.Point(420, 166)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(129, 23)
        Me.btnclear.TabIndex = 22
        Me.btnclear.Text = "Clear"
        Me.btnclear.UseVisualStyleBackColor = True
        '
        'btnsave
        '
        Me.btnsave.Location = New System.Drawing.Point(12, 166)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(129, 23)
        Me.btnsave.TabIndex = 23
        Me.btnsave.Text = "Save"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'frm_suplier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(561, 411)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnclear)
        Me.Controls.Add(Me.btnsave)
        Me.Name = "frm_suplier"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Suplier"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.dtglist, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btndelete As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txttelephone As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtmobile As TextBox
    Friend WithEvents txtaddress As RichTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtlname As TextBox
    Friend WithEvents btnadd As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents txtsearch As TextBox
    Friend WithEvents dtglist As DataGridView
    Friend WithEvents btnupdate As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtfname As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnclear As Button
    Friend WithEvents btnsave As Button
End Class

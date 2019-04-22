<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_settings
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtunit = New System.Windows.Forms.TextBox()
        Me.btnusave = New System.Windows.Forms.Button()
        Me.btncdel = New System.Windows.Forms.Button()
        Me.btntypeupdate = New System.Windows.Forms.Button()
        Me.btntypeLoad = New System.Windows.Forms.Button()
        Me.dtgtypelist = New System.Windows.Forms.DataGridView()
        Me.txtCategory = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnuupdate = New System.Windows.Forms.Button()
        Me.btnuload = New System.Windows.Forms.Button()
        Me.dtgulist = New System.Windows.Forms.DataGridView()
        Me.btnTypesave = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnunit = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.dtgtypelist, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtgulist, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtunit
        '
        Me.txtunit.Location = New System.Drawing.Point(72, 28)
        Me.txtunit.Name = "txtunit"
        Me.txtunit.Size = New System.Drawing.Size(212, 20)
        Me.txtunit.TabIndex = 2
        '
        'btnusave
        '
        Me.btnusave.BackColor = System.Drawing.Color.White
        Me.btnusave.ForeColor = System.Drawing.Color.Black
        Me.btnusave.Location = New System.Drawing.Point(290, 31)
        Me.btnusave.Name = "btnusave"
        Me.btnusave.Size = New System.Drawing.Size(75, 23)
        Me.btnusave.TabIndex = 0
        Me.btnusave.Text = "Save"
        Me.btnusave.UseVisualStyleBackColor = False
        '
        'btncdel
        '
        Me.btncdel.BackColor = System.Drawing.Color.White
        Me.btncdel.ForeColor = System.Drawing.Color.Black
        Me.btncdel.Location = New System.Drawing.Point(290, 89)
        Me.btncdel.Name = "btncdel"
        Me.btncdel.Size = New System.Drawing.Size(75, 23)
        Me.btncdel.TabIndex = 6
        Me.btncdel.Text = "Delete"
        Me.btncdel.UseVisualStyleBackColor = False
        '
        'btntypeupdate
        '
        Me.btntypeupdate.BackColor = System.Drawing.Color.White
        Me.btntypeupdate.ForeColor = System.Drawing.Color.Black
        Me.btntypeupdate.Location = New System.Drawing.Point(290, 60)
        Me.btntypeupdate.Name = "btntypeupdate"
        Me.btntypeupdate.Size = New System.Drawing.Size(75, 23)
        Me.btntypeupdate.TabIndex = 5
        Me.btntypeupdate.Text = "Update"
        Me.btntypeupdate.UseVisualStyleBackColor = False
        '
        'btntypeLoad
        '
        Me.btntypeLoad.BackColor = System.Drawing.Color.White
        Me.btntypeLoad.ForeColor = System.Drawing.Color.Black
        Me.btntypeLoad.Location = New System.Drawing.Point(290, 121)
        Me.btntypeLoad.Name = "btntypeLoad"
        Me.btntypeLoad.Size = New System.Drawing.Size(75, 23)
        Me.btntypeLoad.TabIndex = 4
        Me.btntypeLoad.Text = "Load"
        Me.btntypeLoad.UseVisualStyleBackColor = False
        '
        'dtgtypelist
        '
        Me.dtgtypelist.AllowUserToAddRows = False
        Me.dtgtypelist.AllowUserToDeleteRows = False
        Me.dtgtypelist.AllowUserToResizeColumns = False
        Me.dtgtypelist.AllowUserToResizeRows = False
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.dtgtypelist.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dtgtypelist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgtypelist.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dtgtypelist.Location = New System.Drawing.Point(6, 54)
        Me.dtgtypelist.Name = "dtgtypelist"
        Me.dtgtypelist.RowHeadersVisible = False
        Me.dtgtypelist.Size = New System.Drawing.Size(278, 312)
        Me.dtgtypelist.TabIndex = 3
        '
        'txtCategory
        '
        Me.txtCategory.Location = New System.Drawing.Point(72, 28)
        Me.txtCategory.Name = "txtCategory"
        Me.txtCategory.Size = New System.Drawing.Size(212, 20)
        Me.txtCategory.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(6, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Category :"
        '
        'btnuupdate
        '
        Me.btnuupdate.BackColor = System.Drawing.Color.White
        Me.btnuupdate.ForeColor = System.Drawing.Color.Black
        Me.btnuupdate.Location = New System.Drawing.Point(290, 60)
        Me.btnuupdate.Name = "btnuupdate"
        Me.btnuupdate.Size = New System.Drawing.Size(75, 23)
        Me.btnuupdate.TabIndex = 5
        Me.btnuupdate.Text = "Update"
        Me.btnuupdate.UseVisualStyleBackColor = False
        '
        'btnuload
        '
        Me.btnuload.BackColor = System.Drawing.Color.White
        Me.btnuload.ForeColor = System.Drawing.Color.Black
        Me.btnuload.Location = New System.Drawing.Point(290, 117)
        Me.btnuload.Name = "btnuload"
        Me.btnuload.Size = New System.Drawing.Size(75, 23)
        Me.btnuload.TabIndex = 4
        Me.btnuload.Text = "Load"
        Me.btnuload.UseVisualStyleBackColor = False
        '
        'dtgulist
        '
        Me.dtgulist.AllowUserToAddRows = False
        Me.dtgulist.AllowUserToDeleteRows = False
        Me.dtgulist.AllowUserToResizeColumns = False
        Me.dtgulist.AllowUserToResizeRows = False
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        Me.dtgulist.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dtgulist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgulist.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dtgulist.Location = New System.Drawing.Point(6, 54)
        Me.dtgulist.Name = "dtgulist"
        Me.dtgulist.RowHeadersVisible = False
        Me.dtgulist.Size = New System.Drawing.Size(278, 312)
        Me.dtgulist.TabIndex = 3
        '
        'btnTypesave
        '
        Me.btnTypesave.BackColor = System.Drawing.Color.White
        Me.btnTypesave.ForeColor = System.Drawing.Color.Black
        Me.btnTypesave.Location = New System.Drawing.Point(290, 31)
        Me.btnTypesave.Name = "btnTypesave"
        Me.btnTypesave.Size = New System.Drawing.Size(75, 23)
        Me.btnTypesave.TabIndex = 0
        Me.btnTypesave.Text = "Save"
        Me.btnTypesave.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnunit)
        Me.GroupBox2.Controls.Add(Me.btnuupdate)
        Me.GroupBox2.Controls.Add(Me.btnuload)
        Me.GroupBox2.Controls.Add(Me.dtgulist)
        Me.GroupBox2.Controls.Add(Me.txtunit)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.btnusave)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(392, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(374, 372)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Add New Item Unit"
        '
        'btnunit
        '
        Me.btnunit.BackColor = System.Drawing.Color.White
        Me.btnunit.ForeColor = System.Drawing.Color.Black
        Me.btnunit.Location = New System.Drawing.Point(290, 88)
        Me.btnunit.Name = "btnunit"
        Me.btnunit.Size = New System.Drawing.Size(75, 23)
        Me.btnunit.TabIndex = 7
        Me.btnunit.Text = "Delete"
        Me.btnunit.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(6, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Item Unit :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btncdel)
        Me.GroupBox1.Controls.Add(Me.btntypeupdate)
        Me.GroupBox1.Controls.Add(Me.btntypeLoad)
        Me.GroupBox1.Controls.Add(Me.dtgtypelist)
        Me.GroupBox1.Controls.Add(Me.txtCategory)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnTypesave)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(374, 372)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Add new Category"
        '
        'frm_settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 407)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frm_settings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Settings"
        CType(Me.dtgtypelist, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtgulist, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtunit As TextBox
    Friend WithEvents btnusave As Button
    Friend WithEvents btncdel As Button
    Friend WithEvents btntypeupdate As Button
    Friend WithEvents btntypeLoad As Button
    Friend WithEvents dtgtypelist As DataGridView
    Friend WithEvents txtCategory As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnuupdate As Button
    Friend WithEvents btnuload As Button
    Friend WithEvents dtgulist As DataGridView
    Friend WithEvents btnTypesave As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnunit As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
End Class

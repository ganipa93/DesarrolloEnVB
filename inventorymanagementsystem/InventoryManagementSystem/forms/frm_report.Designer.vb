<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_report
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
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnitemlisat = New System.Windows.Forms.Button()
        Me.cbooption = New System.Windows.Forms.ComboBox()
        Me.btnListStockin = New System.Windows.Forms.Button()
        Me.btnStockOut = New System.Windows.Forms.Button()
        Me.btnStockReturn = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpto = New System.Windows.Forms.DateTimePicker()
        Me.dptfrom = New System.Windows.Forms.DateTimePicker()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.AutoScroll = True
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(164, 0)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.ShowCloseButton = False
        Me.CrystalReportViewer1.ShowGotoPageButton = False
        Me.CrystalReportViewer1.ShowGroupTreeButton = False
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(967, 593)
        Me.CrystalReportViewer1.TabIndex = 3
        Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(164, 593)
        Me.Panel1.TabIndex = 4
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnitemlisat)
        Me.GroupBox2.Controls.Add(Me.cbooption)
        Me.GroupBox2.Controls.Add(Me.btnListStockin)
        Me.GroupBox2.Controls.Add(Me.btnStockOut)
        Me.GroupBox2.Controls.Add(Me.btnStockReturn)
        Me.GroupBox2.Location = New System.Drawing.Point(5, 24)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(146, 211)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Report Type"
        '
        'btnitemlisat
        '
        Me.btnitemlisat.BackColor = System.Drawing.Color.Transparent
        Me.btnitemlisat.ForeColor = System.Drawing.Color.Black
        Me.btnitemlisat.Location = New System.Drawing.Point(9, 19)
        Me.btnitemlisat.Name = "btnitemlisat"
        Me.btnitemlisat.Size = New System.Drawing.Size(124, 30)
        Me.btnitemlisat.TabIndex = 3
        Me.btnitemlisat.Text = "List Of Items"
        Me.btnitemlisat.UseVisualStyleBackColor = False
        '
        'cbooption
        '
        Me.cbooption.FormattingEnabled = True
        Me.cbooption.Items.AddRange(New Object() {"Daily Report", "Weekly Report", "Monthly Report"})
        Me.cbooption.Location = New System.Drawing.Point(9, 55)
        Me.cbooption.Name = "cbooption"
        Me.cbooption.Size = New System.Drawing.Size(124, 21)
        Me.cbooption.TabIndex = 2
        Me.cbooption.Text = "Daily Report"
        '
        'btnListStockin
        '
        Me.btnListStockin.BackColor = System.Drawing.Color.Transparent
        Me.btnListStockin.ForeColor = System.Drawing.Color.Black
        Me.btnListStockin.Location = New System.Drawing.Point(9, 84)
        Me.btnListStockin.Name = "btnListStockin"
        Me.btnListStockin.Size = New System.Drawing.Size(124, 30)
        Me.btnListStockin.TabIndex = 0
        Me.btnListStockin.Text = "List Of Stock Items"
        Me.btnListStockin.UseVisualStyleBackColor = False
        '
        'btnStockOut
        '
        Me.btnStockOut.BackColor = System.Drawing.Color.Transparent
        Me.btnStockOut.ForeColor = System.Drawing.Color.Black
        Me.btnStockOut.Location = New System.Drawing.Point(9, 120)
        Me.btnStockOut.Name = "btnStockOut"
        Me.btnStockOut.Size = New System.Drawing.Size(124, 30)
        Me.btnStockOut.TabIndex = 0
        Me.btnStockOut.Text = "List Of Sold Items"
        Me.btnStockOut.UseVisualStyleBackColor = False
        '
        'btnStockReturn
        '
        Me.btnStockReturn.BackColor = System.Drawing.Color.Transparent
        Me.btnStockReturn.ForeColor = System.Drawing.Color.Black
        Me.btnStockReturn.Location = New System.Drawing.Point(9, 156)
        Me.btnStockReturn.Name = "btnStockReturn"
        Me.btnStockReturn.Size = New System.Drawing.Size(124, 30)
        Me.btnStockReturn.TabIndex = 0
        Me.btnStockReturn.Text = "List Of Returned Items"
        Me.btnStockReturn.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.dtpto)
        Me.GroupBox1.Controls.Add(Me.dptfrom)
        Me.GroupBox1.Location = New System.Drawing.Point(5, 254)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(146, 117)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Report Date Filter"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(20, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "To"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "From"
        '
        'dtpto
        '
        Me.dtpto.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpto.Location = New System.Drawing.Point(9, 83)
        Me.dtpto.Name = "dtpto"
        Me.dtpto.Size = New System.Drawing.Size(131, 20)
        Me.dtpto.TabIndex = 2
        '
        'dptfrom
        '
        Me.dptfrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dptfrom.Location = New System.Drawing.Point(9, 44)
        Me.dptfrom.Name = "dptfrom"
        Me.dptfrom.Size = New System.Drawing.Size(131, 20)
        Me.dptfrom.TabIndex = 2
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"January", "February", "March ", "April", "June", "July", "August", "September", "October", "November", "December"})
        Me.ComboBox1.Location = New System.Drawing.Point(266, 77)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(124, 21)
        Me.ComboBox1.TabIndex = 5
        '
        'frm_report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1131, 593)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Name = "frm_report"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Report"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnitemlisat As Button
    Friend WithEvents cbooption As ComboBox
    Friend WithEvents btnListStockin As Button
    Friend WithEvents btnStockOut As Button
    Friend WithEvents btnStockReturn As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dtpto As DateTimePicker
    Friend WithEvents dptfrom As DateTimePicker
    Friend WithEvents ComboBox1 As ComboBox
End Class

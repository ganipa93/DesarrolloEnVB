<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pagos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.ProveedoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DatosDataSetBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DatosDataSet = New HSKLMWLPST.datosDataSet
        Me.DatosDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BtnGuardar = New System.Windows.Forms.Button
        Me.BtnBuscar = New System.Windows.Forms.Button
        Me.ProveedoresTableAdapter = New HSKLMWLPST.datosDataSetTableAdapters.proveedoresTableAdapter
        Me.LblRS = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.LblSaldo = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.LblPendiente = New System.Windows.Forms.Label
        CType(Me.ProveedoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatosDataSetBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatosDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 17)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Id Pago:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 43)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Id Proveedor:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 70)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Razon social:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 97)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(119, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Monto a pagar:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(131, 14)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(152, 21)
        Me.TextBox1.TabIndex = 1
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(131, 94)
        Me.TextBox4.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(105, 21)
        Me.TextBox4.TabIndex = 4
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.ProveedoresBindingSource
        Me.ComboBox1.DisplayMember = "id_proveedor"
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(131, 40)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(270, 21)
        Me.ComboBox1.TabIndex = 3
        '
        'ProveedoresBindingSource
        '
        Me.ProveedoresBindingSource.DataMember = "proveedores"
        Me.ProveedoresBindingSource.DataSource = Me.DatosDataSetBindingSource1
        '
        'DatosDataSetBindingSource1
        '
        Me.DatosDataSetBindingSource1.DataSource = Me.DatosDataSet
        Me.DatosDataSetBindingSource1.Position = 0
        '
        'DatosDataSet
        '
        Me.DatosDataSet.DataSetName = "datosDataSet"
        Me.DatosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DatosDataSetBindingSource
        '
        Me.DatosDataSetBindingSource.DataSource = Me.DatosDataSet
        Me.DatosDataSetBindingSource.Position = 0
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Location = New System.Drawing.Point(21, 121)
        Me.BtnGuardar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(380, 23)
        Me.BtnGuardar.TabIndex = 5
        Me.BtnGuardar.Text = "&Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Location = New System.Drawing.Point(291, 11)
        Me.BtnBuscar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(110, 23)
        Me.BtnBuscar.TabIndex = 2
        Me.BtnBuscar.Text = "&Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'ProveedoresTableAdapter
        '
        Me.ProveedoresTableAdapter.ClearBeforeFill = True
        '
        'LblRS
        '
        Me.LblRS.AutoSize = True
        Me.LblRS.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblRS.Location = New System.Drawing.Point(131, 72)
        Me.LblRS.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblRS.Name = "LblRS"
        Me.LblRS.Size = New System.Drawing.Size(105, 15)
        Me.LblRS.TabIndex = 11
        Me.LblRS.Text = "Razon Social"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(20, 184)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "&Salir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(244, 97)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Usted Debe:"
        '
        'LblSaldo
        '
        Me.LblSaldo.AutoSize = True
        Me.LblSaldo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblSaldo.Location = New System.Drawing.Point(336, 95)
        Me.LblSaldo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblSaldo.Name = "LblSaldo"
        Me.LblSaldo.Size = New System.Drawing.Size(65, 15)
        Me.LblSaldo.TabIndex = 13
        Me.LblSaldo.Text = "$saldo$"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(21, 151)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(167, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Queda una cuenta de:"
        '
        'LblPendiente
        '
        Me.LblPendiente.AutoSize = True
        Me.LblPendiente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblPendiente.Location = New System.Drawing.Point(195, 151)
        Me.LblPendiente.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblPendiente.Name = "LblPendiente"
        Me.LblPendiente.Size = New System.Drawing.Size(113, 15)
        Me.LblPendiente.TabIndex = 15
        Me.LblPendiente.Text = "$Saldo Final$"
        '
        'pagos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(426, 228)
        Me.ControlBox = False
        Me.Controls.Add(Me.LblPendiente)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.LblSaldo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.LblRS)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("OCR A Extended", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "pagos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "|Pagos|"
        CType(Me.ProveedoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatosDataSetBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatosDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents DatosDataSet As HSKLMWLPST.datosDataSet
    Friend WithEvents DatosDataSetBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents DatosDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BtnGuardar As System.Windows.Forms.Button
    Friend WithEvents BtnBuscar As System.Windows.Forms.Button
    Friend WithEvents ProveedoresBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProveedoresTableAdapter As HSKLMWLPST.datosDataSetTableAdapters.proveedoresTableAdapter
    Friend WithEvents LblRS As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents LblSaldo As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents LblPendiente As System.Windows.Forms.Label
End Class

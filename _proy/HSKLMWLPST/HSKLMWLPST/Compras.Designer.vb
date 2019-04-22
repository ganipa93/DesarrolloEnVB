<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Compras
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
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.TxtCantidad = New System.Windows.Forms.TextBox
        Me.BtnAgregar = New System.Windows.Forms.Button
        Me.BtnBuscar = New System.Windows.Forms.Button
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.ProveedoresBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DatosDataSet = New HSKLMWLPST.datosDataSet
        Me.ComboBox3 = New System.Windows.Forms.ComboBox
        Me.ArticulosBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProveedoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProveedoresTableAdapter = New HSKLMWLPST.datosDataSetTableAdapters.proveedoresTableAdapter
        Me.ArticulosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ArticulosTableAdapter = New HSKLMWLPST.datosDataSetTableAdapters.articulosTableAdapter
        Me.TxtId = New System.Windows.Forms.TextBox
        Me.DatosDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DatosDataSetBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button1 = New System.Windows.Forms.Button
        Me.LblRS = New System.Windows.Forms.Label
        Me.LblDescripcion = New System.Windows.Forms.Label
        Me.Lblcosto = New System.Windows.Forms.Label
        Me.Aux = New System.Windows.Forms.Label
        Me.ComprasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComprasTableAdapter = New HSKLMWLPST.datosDataSetTableAdapters.comprasTableAdapter
        Me.ComboBox2 = New System.Windows.Forms.ComboBox
        CType(Me.ProveedoresBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArticulosBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProveedoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArticulosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatosDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatosDataSetBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComprasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Folio:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 38)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(135, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Clave Proveedor:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 71)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Razon Social:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 99)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(167, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Codigo del Articulo:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 125)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Descripción:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(17, 151)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Costo:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(17, 177)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Cantidad:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(17, 203)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Fecha:"
        '
        'TxtCantidad
        '
        Me.TxtCantidad.Location = New System.Drawing.Point(179, 172)
        Me.TxtCantidad.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TxtCantidad.Name = "TxtCantidad"
        Me.TxtCantidad.Size = New System.Drawing.Size(167, 21)
        Me.TxtCantidad.TabIndex = 7
        '
        'BtnAgregar
        '
        Me.BtnAgregar.Location = New System.Drawing.Point(21, 233)
        Me.BtnAgregar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(253, 23)
        Me.BtnAgregar.TabIndex = 9
        Me.BtnAgregar.Text = "&Agregar"
        Me.BtnAgregar.UseVisualStyleBackColor = True
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Location = New System.Drawing.Point(274, 2)
        Me.BtnBuscar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(73, 23)
        Me.BtnBuscar.TabIndex = 1
        Me.BtnBuscar.Text = "&Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(179, 199)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(167, 21)
        Me.DateTimePicker1.TabIndex = 8
        '
        'ProveedoresBindingSource1
        '
        Me.ProveedoresBindingSource1.DataMember = "proveedores"
        Me.ProveedoresBindingSource1.DataSource = Me.DatosDataSet
        '
        'DatosDataSet
        '
        Me.DatosDataSet.DataSetName = "datosDataSet"
        Me.DatosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ComboBox3
        '
        Me.ComboBox3.DataSource = Me.ArticulosBindingSource1
        Me.ComboBox3.DisplayMember = "codigo"
        Me.ComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(179, 92)
        Me.ComboBox3.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(167, 21)
        Me.ComboBox3.TabIndex = 4
        '
        'ArticulosBindingSource1
        '
        Me.ArticulosBindingSource1.DataMember = "articulos"
        Me.ArticulosBindingSource1.DataSource = Me.DatosDataSet
        '
        'ProveedoresBindingSource
        '
        Me.ProveedoresBindingSource.DataMember = "proveedores"
        Me.ProveedoresBindingSource.DataSource = Me.DatosDataSet
        '
        'ProveedoresTableAdapter
        '
        Me.ProveedoresTableAdapter.ClearBeforeFill = True
        '
        'ArticulosBindingSource
        '
        Me.ArticulosBindingSource.DataMember = "articulos"
        Me.ArticulosBindingSource.DataSource = Me.DatosDataSet
        '
        'ArticulosTableAdapter
        '
        Me.ArticulosTableAdapter.ClearBeforeFill = True
        '
        'TxtId
        '
        Me.TxtId.Location = New System.Drawing.Point(179, 1)
        Me.TxtId.Name = "TxtId"
        Me.TxtId.Size = New System.Drawing.Size(85, 21)
        Me.TxtId.TabIndex = 0
        '
        'DatosDataSetBindingSource
        '
        Me.DatosDataSetBindingSource.DataSource = Me.DatosDataSet
        Me.DatosDataSetBindingSource.Position = 0
        '
        'DatosDataSetBindingSource1
        '
        Me.DatosDataSetBindingSource1.DataSource = Me.DatosDataSet
        Me.DatosDataSetBindingSource1.Position = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(19, 260)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "&Salir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'LblRS
        '
        Me.LblRS.AutoSize = True
        Me.LblRS.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblRS.Location = New System.Drawing.Point(179, 69)
        Me.LblRS.Name = "LblRS"
        Me.LblRS.Size = New System.Drawing.Size(105, 15)
        Me.LblRS.TabIndex = 3
        Me.LblRS.Text = "Razon Social"
        '
        'LblDescripcion
        '
        Me.LblDescripcion.AutoSize = True
        Me.LblDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblDescripcion.Location = New System.Drawing.Point(179, 125)
        Me.LblDescripcion.Name = "LblDescripcion"
        Me.LblDescripcion.Size = New System.Drawing.Size(169, 15)
        Me.LblDescripcion.TabIndex = 5
        Me.LblDescripcion.Text = "Descripcion Articulo"
        '
        'Lblcosto
        '
        Me.Lblcosto.AutoSize = True
        Me.Lblcosto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lblcosto.Location = New System.Drawing.Point(179, 151)
        Me.Lblcosto.Name = "Lblcosto"
        Me.Lblcosto.Size = New System.Drawing.Size(121, 15)
        Me.Lblcosto.TabIndex = 6
        Me.Lblcosto.Text = "Costo Articulo"
        '
        'Aux
        '
        Me.Aux.AutoSize = True
        Me.Aux.Location = New System.Drawing.Point(293, 270)
        Me.Aux.Name = "Aux"
        Me.Aux.Size = New System.Drawing.Size(31, 13)
        Me.Aux.TabIndex = 27
        Me.Aux.Text = "Aux"
        Me.Aux.Visible = False
        '
        'ComprasBindingSource
        '
        Me.ComprasBindingSource.DataMember = "compras"
        Me.ComprasBindingSource.DataSource = Me.DatosDataSet
        '
        'ComprasTableAdapter
        '
        Me.ComprasTableAdapter.ClearBeforeFill = True
        '
        'ComboBox2
        '
        Me.ComboBox2.DataSource = Me.ProveedoresBindingSource
        Me.ComboBox2.DisplayMember = "id_proveedor"
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(179, 29)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox2.TabIndex = 2
        '
        'Compras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(362, 295)
        Me.ControlBox = False
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.Aux)
        Me.Controls.Add(Me.Lblcosto)
        Me.Controls.Add(Me.LblDescripcion)
        Me.Controls.Add(Me.LblRS)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TxtId)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.BtnAgregar)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.TxtCantidad)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("OCR A Extended", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "Compras"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "| Compras |"
        CType(Me.ProveedoresBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArticulosBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProveedoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArticulosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatosDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatosDataSetBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComprasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TxtCantidad As System.Windows.Forms.TextBox
    Friend WithEvents BtnAgregar As System.Windows.Forms.Button
    Friend WithEvents BtnBuscar As System.Windows.Forms.Button
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents DatosDataSet As HSKLMWLPST.datosDataSet
    Friend WithEvents ProveedoresBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProveedoresTableAdapter As HSKLMWLPST.datosDataSetTableAdapters.proveedoresTableAdapter
    Friend WithEvents ArticulosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ArticulosTableAdapter As HSKLMWLPST.datosDataSetTableAdapters.articulosTableAdapter
    Friend WithEvents TxtId As System.Windows.Forms.TextBox
    Friend WithEvents ProveedoresBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents ArticulosBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents DatosDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DatosDataSetBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents LblRS As System.Windows.Forms.Label
    Friend WithEvents LblDescripcion As System.Windows.Forms.Label
    Friend WithEvents Lblcosto As System.Windows.Forms.Label
    Friend WithEvents Aux As System.Windows.Forms.Label
    Friend WithEvents ComprasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ComprasTableAdapter As HSKLMWLPST.datosDataSetTableAdapters.comprasTableAdapter
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
End Class

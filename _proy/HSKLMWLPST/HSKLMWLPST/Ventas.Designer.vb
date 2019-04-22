<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ventas
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
        Me.ComboBox3 = New System.Windows.Forms.ComboBox
        Me.ArticulosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DatosDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DatosDataSet = New HSKLMWLPST.datosDataSet
        Me.ComboBox2 = New System.Windows.Forms.ComboBox
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.BtnAgregar = New System.Windows.Forms.Button
        Me.BtnBuscar = New System.Windows.Forms.Button
        Me.TxtCantidad = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.TxtId = New System.Windows.Forms.TextBox
        Me.VentasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VentasTableAdapter = New HSKLMWLPST.datosDataSetTableAdapters.ventasTableAdapter
        Me.ClientesTableAdapter = New HSKLMWLPST.datosDataSetTableAdapters.clientesTableAdapter
        Me.ArticulosTableAdapter = New HSKLMWLPST.datosDataSetTableAdapters.articulosTableAdapter
        Me.LblRazon = New System.Windows.Forms.Label
        Me.LblDescripcion = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.Lblcosto = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Existencia = New System.Windows.Forms.Label
        Me.ArticulosBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.ArticulosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatosDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VentasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArticulosBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBox3
        '
        Me.ComboBox3.DataSource = Me.ArticulosBindingSource1
        Me.ComboBox3.DisplayMember = "codigo"
        Me.ComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(196, 100)
        Me.ComboBox3.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(167, 21)
        Me.ComboBox3.TabIndex = 4
        '
        'ArticulosBindingSource
        '
        Me.ArticulosBindingSource.DataMember = "articulos"
        Me.ArticulosBindingSource.DataSource = Me.DatosDataSetBindingSource
        '
        'DatosDataSetBindingSource
        '
        Me.DatosDataSetBindingSource.DataSource = Me.DatosDataSet
        Me.DatosDataSetBindingSource.Position = 0
        '
        'DatosDataSet
        '
        Me.DatosDataSet.DataSetName = "datosDataSet"
        Me.DatosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ComboBox2
        '
        Me.ComboBox2.DataSource = Me.ClientesBindingSource
        Me.ComboBox2.DisplayMember = "clave_cliente"
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(196, 39)
        Me.ComboBox2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(167, 21)
        Me.ComboBox2.TabIndex = 3
        '
        'ClientesBindingSource
        '
        Me.ClientesBindingSource.DataMember = "clientes"
        Me.ClientesBindingSource.DataSource = Me.DatosDataSetBindingSource
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(195, 227)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(167, 21)
        Me.DateTimePicker1.TabIndex = 7
        '
        'BtnAgregar
        '
        Me.BtnAgregar.Location = New System.Drawing.Point(35, 267)
        Me.BtnAgregar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(253, 23)
        Me.BtnAgregar.TabIndex = 8
        Me.BtnAgregar.Text = "&Agregar"
        Me.BtnAgregar.UseVisualStyleBackColor = True
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Location = New System.Drawing.Point(291, 10)
        Me.BtnBuscar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(73, 23)
        Me.BtnBuscar.TabIndex = 2
        Me.BtnBuscar.Text = "&Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'TxtCantidad
        '
        Me.TxtCantidad.Location = New System.Drawing.Point(195, 200)
        Me.TxtCantidad.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TxtCantidad.Name = "TxtCantidad"
        Me.TxtCantidad.Size = New System.Drawing.Size(167, 21)
        Me.TxtCantidad.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(32, 231)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 13)
        Me.Label8.TabIndex = 29
        Me.Label8.Text = "Fecha:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(32, 205)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 13)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "Cantidad:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(33, 159)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 13)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Costo:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(33, 133)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 13)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Descripción:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(32, 107)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(167, 13)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Codigo del Articulo:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(32, 79)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Nombre:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 46)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 13)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Clave Cliente:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 17)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Folio:"
        '
        'TxtId
        '
        Me.TxtId.Location = New System.Drawing.Point(196, 12)
        Me.TxtId.Name = "TxtId"
        Me.TxtId.Size = New System.Drawing.Size(85, 21)
        Me.TxtId.TabIndex = 1
        '
        'VentasBindingSource
        '
        Me.VentasBindingSource.DataMember = "ventas"
        Me.VentasBindingSource.DataSource = Me.DatosDataSet
        '
        'VentasTableAdapter
        '
        Me.VentasTableAdapter.ClearBeforeFill = True
        '
        'ClientesTableAdapter
        '
        Me.ClientesTableAdapter.ClearBeforeFill = True
        '
        'ArticulosTableAdapter
        '
        Me.ArticulosTableAdapter.ClearBeforeFill = True
        '
        'LblRazon
        '
        Me.LblRazon.AutoSize = True
        Me.LblRazon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblRazon.Location = New System.Drawing.Point(196, 77)
        Me.LblRazon.Name = "LblRazon"
        Me.LblRazon.Size = New System.Drawing.Size(105, 15)
        Me.LblRazon.TabIndex = 41
        Me.LblRazon.Text = "Razon Social"
        '
        'LblDescripcion
        '
        Me.LblDescripcion.AutoSize = True
        Me.LblDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblDescripcion.Location = New System.Drawing.Point(196, 133)
        Me.LblDescripcion.Name = "LblDescripcion"
        Me.LblDescripcion.Size = New System.Drawing.Size(169, 15)
        Me.LblDescripcion.TabIndex = 42
        Me.LblDescripcion.Text = "Descripcion articulo"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(35, 296)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "&Salir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Lblcosto
        '
        Me.Lblcosto.AutoSize = True
        Me.Lblcosto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lblcosto.Location = New System.Drawing.Point(196, 159)
        Me.Lblcosto.Name = "Lblcosto"
        Me.Lblcosto.Size = New System.Drawing.Size(121, 15)
        Me.Lblcosto.TabIndex = 43
        Me.Lblcosto.Text = "Costo Articulo"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(33, 183)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(103, 13)
        Me.Label9.TabIndex = 44
        Me.Label9.Text = "Existencias:"
        '
        'Existencia
        '
        Me.Existencia.AutoSize = True
        Me.Existencia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Existencia.Location = New System.Drawing.Point(195, 183)
        Me.Existencia.Name = "Existencia"
        Me.Existencia.Size = New System.Drawing.Size(169, 15)
        Me.Existencia.TabIndex = 45
        Me.Existencia.Text = "Existencia  Producto"
        '
        'ArticulosBindingSource1
        '
        Me.ArticulosBindingSource1.DataMember = "articulos"
        Me.ArticulosBindingSource1.DataSource = Me.DatosDataSetBindingSource
        '
        'Ventas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(375, 331)
        Me.ControlBox = False
        Me.Controls.Add(Me.Existencia)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Lblcosto)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.LblDescripcion)
        Me.Controls.Add(Me.LblRazon)
        Me.Controls.Add(Me.TxtId)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.ComboBox2)
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
        Me.Name = "Ventas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "| Ventas |"
        CType(Me.ArticulosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatosDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VentasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArticulosBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents BtnAgregar As System.Windows.Forms.Button
    Friend WithEvents BtnBuscar As System.Windows.Forms.Button
    Friend WithEvents TxtCantidad As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtId As System.Windows.Forms.TextBox
    Friend WithEvents DatosDataSet As HSKLMWLPST.datosDataSet
    Friend WithEvents VentasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VentasTableAdapter As HSKLMWLPST.datosDataSetTableAdapters.ventasTableAdapter
    Friend WithEvents DatosDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClientesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClientesTableAdapter As HSKLMWLPST.datosDataSetTableAdapters.clientesTableAdapter
    Friend WithEvents ArticulosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ArticulosTableAdapter As HSKLMWLPST.datosDataSetTableAdapters.articulosTableAdapter
    Friend WithEvents LblRazon As System.Windows.Forms.Label
    Friend WithEvents LblDescripcion As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Lblcosto As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Existencia As System.Windows.Forms.Label
    Friend WithEvents ArticulosBindingSource1 As System.Windows.Forms.BindingSource
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Abonos
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
        Me.BtnBuscar = New System.Windows.Forms.Button
        Me.BtnGuardar = New System.Windows.Forms.Button
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.ClientesBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DatosDataSetBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DatosDataSet = New HSKLMWLPST.datosDataSet
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.DatosDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientesTableAdapter = New HSKLMWLPST.datosDataSetTableAdapters.clientesTableAdapter
        Me.lblNombre = New System.Windows.Forms.Label
        Me.BtnSalir = New System.Windows.Forms.Button
        Me.LblPendiente = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.LblSaldo = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        CType(Me.ClientesBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatosDataSetBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatosDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Location = New System.Drawing.Point(262, 12)
        Me.BtnBuscar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(100, 23)
        Me.BtnBuscar.TabIndex = 2
        Me.BtnBuscar.Text = "&Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Location = New System.Drawing.Point(8, 127)
        Me.BtnGuardar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(277, 23)
        Me.BtnGuardar.TabIndex = 5
        Me.BtnGuardar.Text = "&Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.ClientesBindingSource1
        Me.ComboBox1.DisplayMember = "clave_cliente"
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(129, 39)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(233, 21)
        Me.ComboBox1.TabIndex = 3
        '
        'ClientesBindingSource1
        '
        Me.ClientesBindingSource1.DataMember = "clientes"
        Me.ClientesBindingSource1.DataSource = Me.DatosDataSetBindingSource1
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
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(129, 92)
        Me.TextBox4.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(68, 21)
        Me.TextBox4.TabIndex = 4
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.Window
        Me.TextBox1.Location = New System.Drawing.Point(129, 12)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(125, 21)
        Me.TextBox1.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(4, 99)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(119, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Monto abonado:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(4, 72)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Cliente:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 45)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Id Cliente:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 19)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Id Abono:"
        '
        'DatosDataSetBindingSource
        '
        Me.DatosDataSetBindingSource.DataSource = Me.DatosDataSet
        Me.DatosDataSetBindingSource.Position = 0
        '
        'ClientesBindingSource
        '
        Me.ClientesBindingSource.DataMember = "clientes"
        Me.ClientesBindingSource.DataSource = Me.DatosDataSet
        '
        'ClientesTableAdapter
        '
        Me.ClientesTableAdapter.ClearBeforeFill = True
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNombre.Location = New System.Drawing.Point(129, 70)
        Me.lblNombre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(153, 15)
        Me.lblNombre.TabIndex = 21
        Me.lblNombre.Text = "Nombre del Cliente" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'BtnSalir
        '
        Me.BtnSalir.Location = New System.Drawing.Point(7, 184)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(57, 23)
        Me.BtnSalir.TabIndex = 6
        Me.BtnSalir.Text = "&Salir"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'LblPendiente
        '
        Me.LblPendiente.AutoSize = True
        Me.LblPendiente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblPendiente.Location = New System.Drawing.Point(178, 153)
        Me.LblPendiente.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblPendiente.Name = "LblPendiente"
        Me.LblPendiente.Size = New System.Drawing.Size(113, 15)
        Me.LblPendiente.TabIndex = 25
        Me.LblPendiente.Text = "$Saldo Final$"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(4, 153)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(167, 13)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Queda una cuenta de:"
        '
        'LblSaldo
        '
        Me.LblSaldo.AutoSize = True
        Me.LblSaldo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblSaldo.Location = New System.Drawing.Point(297, 93)
        Me.LblSaldo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblSaldo.Name = "LblSaldo"
        Me.LblSaldo.Size = New System.Drawing.Size(65, 15)
        Me.LblSaldo.TabIndex = 23
        Me.LblSaldo.Text = "$saldo$"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(204, 95)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 13)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Usted Debe:"
        '
        'Abonos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(399, 219)
        Me.ControlBox = False
        Me.Controls.Add(Me.LblPendiente)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.LblSaldo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.lblNombre)
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
        Me.Name = "Abonos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "|Abonos|"
        CType(Me.ClientesBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatosDataSetBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatosDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnBuscar As System.Windows.Forms.Button
    Friend WithEvents BtnGuardar As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DatosDataSetBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents DatosDataSet As HSKLMWLPST.datosDataSet
    Friend WithEvents DatosDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClientesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClientesTableAdapter As HSKLMWLPST.datosDataSetTableAdapters.clientesTableAdapter
    Friend WithEvents ClientesBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents BtnSalir As System.Windows.Forms.Button
    Friend WithEvents LblPendiente As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents LblSaldo As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class

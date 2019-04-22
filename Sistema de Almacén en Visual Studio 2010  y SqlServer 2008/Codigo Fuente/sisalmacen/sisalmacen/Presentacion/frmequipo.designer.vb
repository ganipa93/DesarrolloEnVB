<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmequipo
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
        Me.components = New System.ComponentModel.Container()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.inexistente = New System.Windows.Forms.LinkLabel()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.btneliminar = New System.Windows.Forms.Button()
        Me.btndetalles = New System.Windows.Forms.Button()
        Me.cbeliminar = New System.Windows.Forms.CheckBox()
        Me.datalistado = New System.Windows.Forms.DataGridView()
        Me.Eliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.txtbuscar = New System.Windows.Forms.TextBox()
        Me.cbocampo = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txttotalpago = New System.Windows.Forms.TextBox()
        Me.txtfecha_salida = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cboestado_pago = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.cboestadoalmacen = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtproblema = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtserie = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtmodelo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbotipo_doc = New System.Windows.Forms.ComboBox()
        Me.txtreparacion_desc = New System.Windows.Forms.TextBox()
        Me.txtnumdoc = New System.Windows.Forms.TextBox()
        Me.txtfecha_ingreso = New System.Windows.Forms.DateTimePicker()
        Me.btnhorario = New System.Windows.Forms.Button()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.txtnombrecliente = New System.Windows.Forms.TextBox()
        Me.txtidcliente = New System.Windows.Forms.TextBox()
        Me.txtmarca = New System.Windows.Forms.TextBox()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtcodigo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnnuevo = New System.Windows.Forms.Button()
        Me.btneditar = New System.Windows.Forms.Button()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.ttmensaje = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label13 = New System.Windows.Forms.Label()
        Me.erroricono = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.datalistado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.erroricono, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(442, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(715, 573)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btnsalir)
        Me.TabPage1.Controls.Add(Me.Button2)
        Me.TabPage1.Controls.Add(Me.inexistente)
        Me.TabPage1.Controls.Add(Me.lbltotal)
        Me.TabPage1.Controls.Add(Me.btneliminar)
        Me.TabPage1.Controls.Add(Me.btndetalles)
        Me.TabPage1.Controls.Add(Me.cbeliminar)
        Me.TabPage1.Controls.Add(Me.datalistado)
        Me.TabPage1.Controls.Add(Me.txtbuscar)
        Me.TabPage1.Controls.Add(Me.cbocampo)
        Me.TabPage1.Location = New System.Drawing.Point(4, 23)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(707, 546)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Listado de equipos"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btnsalir
        '
        Me.btnsalir.BackColor = System.Drawing.Color.DarkCyan
        Me.btnsalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsalir.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsalir.ForeColor = System.Drawing.Color.White
        Me.btnsalir.Location = New System.Drawing.Point(445, 493)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(110, 22)
        Me.btnsalir.TabIndex = 13
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.DarkCyan
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(317, 493)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(110, 22)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "Consultas"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'inexistente
        '
        Me.inexistente.AutoSize = True
        Me.inexistente.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inexistente.LinkColor = System.Drawing.Color.Red
        Me.inexistente.Location = New System.Drawing.Point(295, 240)
        Me.inexistente.Name = "inexistente"
        Me.inexistente.Size = New System.Drawing.Size(130, 19)
        Me.inexistente.TabIndex = 11
        Me.inexistente.TabStop = True
        Me.inexistente.Text = "Datos Inexistentes"
        '
        'lbltotal
        '
        Me.lbltotal.AutoSize = True
        Me.lbltotal.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotal.ForeColor = System.Drawing.Color.DarkMagenta
        Me.lbltotal.Location = New System.Drawing.Point(578, 497)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(104, 14)
        Me.lbltotal.TabIndex = 10
        Me.lbltotal.Text = "Total Registros: 121"
        '
        'btneliminar
        '
        Me.btneliminar.BackColor = System.Drawing.Color.DarkCyan
        Me.btneliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btneliminar.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btneliminar.ForeColor = System.Drawing.Color.White
        Me.btneliminar.Location = New System.Drawing.Point(45, 493)
        Me.btneliminar.Name = "btneliminar"
        Me.btneliminar.Size = New System.Drawing.Size(110, 22)
        Me.btneliminar.TabIndex = 9
        Me.btneliminar.Text = "Eliminar"
        Me.btneliminar.UseVisualStyleBackColor = False
        '
        'btndetalles
        '
        Me.btndetalles.BackColor = System.Drawing.Color.DarkCyan
        Me.btndetalles.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btndetalles.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndetalles.ForeColor = System.Drawing.Color.White
        Me.btndetalles.Location = New System.Drawing.Point(189, 493)
        Me.btndetalles.Name = "btndetalles"
        Me.btndetalles.Size = New System.Drawing.Size(110, 22)
        Me.btndetalles.TabIndex = 8
        Me.btndetalles.Text = "Ver Detalles"
        Me.btndetalles.UseVisualStyleBackColor = False
        '
        'cbeliminar
        '
        Me.cbeliminar.AutoSize = True
        Me.cbeliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbeliminar.ForeColor = System.Drawing.Color.DarkRed
        Me.cbeliminar.Location = New System.Drawing.Point(26, 46)
        Me.cbeliminar.Name = "cbeliminar"
        Me.cbeliminar.Size = New System.Drawing.Size(70, 17)
        Me.cbeliminar.TabIndex = 3
        Me.cbeliminar.Text = "Eliminar"
        Me.cbeliminar.UseVisualStyleBackColor = True
        '
        'datalistado
        '
        Me.datalistado.AllowUserToAddRows = False
        Me.datalistado.AllowUserToDeleteRows = False
        Me.datalistado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datalistado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Eliminar})
        Me.datalistado.Location = New System.Drawing.Point(25, 70)
        Me.datalistado.Name = "datalistado"
        Me.datalistado.ReadOnly = True
        Me.datalistado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datalistado.Size = New System.Drawing.Size(658, 385)
        Me.datalistado.TabIndex = 2
        '
        'Eliminar
        '
        Me.Eliminar.HeaderText = "Eliminar"
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.ReadOnly = True
        '
        'txtbuscar
        '
        Me.txtbuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbuscar.ForeColor = System.Drawing.Color.DarkCyan
        Me.txtbuscar.Location = New System.Drawing.Point(169, 19)
        Me.txtbuscar.Name = "txtbuscar"
        Me.txtbuscar.Size = New System.Drawing.Size(275, 20)
        Me.txtbuscar.TabIndex = 1
        '
        'cbocampo
        '
        Me.cbocampo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbocampo.ForeColor = System.Drawing.Color.DarkCyan
        Me.cbocampo.FormattingEnabled = True
        Me.cbocampo.Items.AddRange(New Object() {"apellidos", "marca", "serie", "estado_almacen", "estado_pago", "num_doc", "tipo_doc", "fecha_ingreso", "fecha_salida"})
        Me.cbocampo.Location = New System.Drawing.Point(25, 18)
        Me.cbocampo.Name = "cbocampo"
        Me.cbocampo.Size = New System.Drawing.Size(130, 21)
        Me.cbocampo.TabIndex = 0
        Me.cbocampo.Text = "nombre"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txttotalpago)
        Me.GroupBox1.Controls.Add(Me.txtfecha_salida)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.cboestado_pago)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.cboestadoalmacen)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.txtproblema)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.txtserie)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtmodelo)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cbotipo_doc)
        Me.GroupBox1.Controls.Add(Me.txtreparacion_desc)
        Me.GroupBox1.Controls.Add(Me.txtnumdoc)
        Me.GroupBox1.Controls.Add(Me.txtfecha_ingreso)
        Me.GroupBox1.Controls.Add(Me.btnhorario)
        Me.GroupBox1.Controls.Add(Me.btncancelar)
        Me.GroupBox1.Controls.Add(Me.txtnombrecliente)
        Me.GroupBox1.Controls.Add(Me.txtidcliente)
        Me.GroupBox1.Controls.Add(Me.txtmarca)
        Me.GroupBox1.Controls.Add(Me.txtnombre)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtcodigo)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnnuevo)
        Me.GroupBox1.Controls.Add(Me.btneditar)
        Me.GroupBox1.Controls.Add(Me.btnguardar)
        Me.GroupBox1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.DarkMagenta
        Me.GroupBox1.Location = New System.Drawing.Point(9, 86)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(421, 499)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Mantenimiento de trabajadores"
        '
        'txttotalpago
        '
        Me.txttotalpago.ForeColor = System.Drawing.Color.DarkRed
        Me.txttotalpago.Location = New System.Drawing.Point(286, 422)
        Me.txttotalpago.MaxLength = 50
        Me.txttotalpago.Name = "txttotalpago"
        Me.txttotalpago.Size = New System.Drawing.Size(98, 23)
        Me.txttotalpago.TabIndex = 64
        '
        'txtfecha_salida
        '
        Me.txtfecha_salida.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtfecha_salida.Location = New System.Drawing.Point(86, 422)
        Me.txtfecha_salida.Name = "txtfecha_salida"
        Me.txtfecha_salida.Size = New System.Drawing.Size(106, 23)
        Me.txtfecha_salida.TabIndex = 65
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label8.Location = New System.Drawing.Point(26, 423)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 13)
        Me.Label8.TabIndex = 64
        Me.Label8.Text = "Salida:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label6.Location = New System.Drawing.Point(219, 428)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 13)
        Me.Label6.TabIndex = 63
        Me.Label6.Text = "Total Pago:"
        '
        'cboestado_pago
        '
        Me.cboestado_pago.FormattingEnabled = True
        Me.cboestado_pago.Items.AddRange(New Object() {"Pendiente", "Cancelado"})
        Me.cboestado_pago.Location = New System.Drawing.Point(82, 302)
        Me.cboestado_pago.Name = "cboestado_pago"
        Me.cboestado_pago.Size = New System.Drawing.Size(147, 23)
        Me.cboestado_pago.TabIndex = 62
        Me.cboestado_pago.Text = "Pendiente"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label16.Location = New System.Drawing.Point(18, 302)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(41, 13)
        Me.Label16.TabIndex = 61
        Me.Label16.Text = "Pago :"
        '
        'cboestadoalmacen
        '
        Me.cboestadoalmacen.FormattingEnabled = True
        Me.cboestadoalmacen.Items.AddRange(New Object() {"Retirado", "Ingresado", "Pendiente Pago"})
        Me.cboestadoalmacen.Location = New System.Drawing.Point(86, 272)
        Me.cboestadoalmacen.Name = "cboestadoalmacen"
        Me.cboestadoalmacen.Size = New System.Drawing.Size(87, 23)
        Me.cboestadoalmacen.TabIndex = 60
        Me.cboestadoalmacen.Text = "Ingresado"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label15.Location = New System.Drawing.Point(21, 270)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(48, 13)
        Me.Label15.TabIndex = 59
        Me.Label15.Text = "Estado:"
        '
        'txtproblema
        '
        Me.txtproblema.ForeColor = System.Drawing.Color.DarkRed
        Me.txtproblema.Location = New System.Drawing.Point(86, 224)
        Me.txtproblema.MaxLength = 255
        Me.txtproblema.Multiline = True
        Me.txtproblema.Name = "txtproblema"
        Me.txtproblema.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtproblema.Size = New System.Drawing.Size(294, 43)
        Me.txtproblema.TabIndex = 58
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label14.Location = New System.Drawing.Point(6, 224)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(64, 13)
        Me.Label14.TabIndex = 57
        Me.Label14.Text = "Problema:"
        '
        'txtserie
        '
        Me.txtserie.ForeColor = System.Drawing.Color.DarkRed
        Me.txtserie.Location = New System.Drawing.Point(83, 160)
        Me.txtserie.MaxLength = 50
        Me.txtserie.Name = "txtserie"
        Me.txtserie.Size = New System.Drawing.Size(207, 23)
        Me.txtserie.TabIndex = 56
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label7.Location = New System.Drawing.Point(13, 163)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 13)
        Me.Label7.TabIndex = 55
        Me.Label7.Text = "Serie:"
        '
        'txtmodelo
        '
        Me.txtmodelo.ForeColor = System.Drawing.Color.DarkRed
        Me.txtmodelo.Location = New System.Drawing.Point(82, 133)
        Me.txtmodelo.MaxLength = 50
        Me.txtmodelo.Name = "txtmodelo"
        Me.txtmodelo.Size = New System.Drawing.Size(207, 23)
        Me.txtmodelo.TabIndex = 54
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label4.Location = New System.Drawing.Point(12, 136)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 13)
        Me.Label4.TabIndex = 53
        Me.Label4.Text = "Modelo:"
        '
        'cbotipo_doc
        '
        Me.cbotipo_doc.FormattingEnabled = True
        Me.cbotipo_doc.Items.AddRange(New Object() {"Factura", "Boleta", "Otro"})
        Me.cbotipo_doc.Location = New System.Drawing.Point(83, 383)
        Me.cbotipo_doc.Name = "cbotipo_doc"
        Me.cbotipo_doc.Size = New System.Drawing.Size(109, 23)
        Me.cbotipo_doc.TabIndex = 52
        Me.cbotipo_doc.Text = "Factura"
        '
        'txtreparacion_desc
        '
        Me.txtreparacion_desc.ForeColor = System.Drawing.Color.DarkRed
        Me.txtreparacion_desc.Location = New System.Drawing.Point(84, 331)
        Me.txtreparacion_desc.MaxLength = 255
        Me.txtreparacion_desc.Multiline = True
        Me.txtreparacion_desc.Name = "txtreparacion_desc"
        Me.txtreparacion_desc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtreparacion_desc.Size = New System.Drawing.Size(294, 43)
        Me.txtreparacion_desc.TabIndex = 51
        '
        'txtnumdoc
        '
        Me.txtnumdoc.ForeColor = System.Drawing.Color.DarkRed
        Me.txtnumdoc.Location = New System.Drawing.Point(286, 383)
        Me.txtnumdoc.MaxLength = 50
        Me.txtnumdoc.Name = "txtnumdoc"
        Me.txtnumdoc.Size = New System.Drawing.Size(98, 23)
        Me.txtnumdoc.TabIndex = 49
        '
        'txtfecha_ingreso
        '
        Me.txtfecha_ingreso.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtfecha_ingreso.Location = New System.Drawing.Point(262, 273)
        Me.txtfecha_ingreso.Name = "txtfecha_ingreso"
        Me.txtfecha_ingreso.Size = New System.Drawing.Size(150, 23)
        Me.txtfecha_ingreso.TabIndex = 45
        '
        'btnhorario
        '
        Me.btnhorario.BackColor = System.Drawing.Color.DarkCyan
        Me.btnhorario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnhorario.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnhorario.ForeColor = System.Drawing.Color.White
        Me.btnhorario.Location = New System.Drawing.Point(329, 190)
        Me.btnhorario.Name = "btnhorario"
        Me.btnhorario.Size = New System.Drawing.Size(50, 22)
        Me.btnhorario.TabIndex = 43
        Me.btnhorario.Text = "..."
        Me.btnhorario.UseVisualStyleBackColor = False
        '
        'btncancelar
        '
        Me.btncancelar.BackColor = System.Drawing.Color.DarkCyan
        Me.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncancelar.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancelar.ForeColor = System.Drawing.Color.White
        Me.btncancelar.Location = New System.Drawing.Point(267, 464)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(110, 22)
        Me.btncancelar.TabIndex = 13
        Me.btncancelar.Text = "Cancelar"
        Me.btncancelar.UseVisualStyleBackColor = False
        '
        'txtnombrecliente
        '
        Me.txtnombrecliente.Enabled = False
        Me.txtnombrecliente.ForeColor = System.Drawing.Color.DarkRed
        Me.txtnombrecliente.Location = New System.Drawing.Point(164, 189)
        Me.txtnombrecliente.Name = "txtnombrecliente"
        Me.txtnombrecliente.Size = New System.Drawing.Size(159, 23)
        Me.txtnombrecliente.TabIndex = 42
        '
        'txtidcliente
        '
        Me.txtidcliente.Enabled = False
        Me.txtidcliente.ForeColor = System.Drawing.Color.DarkRed
        Me.txtidcliente.Location = New System.Drawing.Point(85, 189)
        Me.txtidcliente.Name = "txtidcliente"
        Me.txtidcliente.Size = New System.Drawing.Size(52, 23)
        Me.txtidcliente.TabIndex = 41
        '
        'txtmarca
        '
        Me.txtmarca.ForeColor = System.Drawing.Color.DarkRed
        Me.txtmarca.Location = New System.Drawing.Point(83, 103)
        Me.txtmarca.MaxLength = 50
        Me.txtmarca.Name = "txtmarca"
        Me.txtmarca.Size = New System.Drawing.Size(207, 23)
        Me.txtmarca.TabIndex = 40
        '
        'txtnombre
        '
        Me.txtnombre.ForeColor = System.Drawing.Color.DarkRed
        Me.txtnombre.Location = New System.Drawing.Point(83, 69)
        Me.txtnombre.MaxLength = 50
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(207, 23)
        Me.txtnombre.TabIndex = 39
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label12.Location = New System.Drawing.Point(4, 335)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(74, 13)
        Me.Label12.TabIndex = 38
        Me.Label12.Text = "Reparación:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label11.Location = New System.Drawing.Point(193, 280)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(54, 13)
        Me.Label11.TabIndex = 36
        Me.Label11.Text = "Ingreso:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label10.Location = New System.Drawing.Point(18, 381)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(58, 13)
        Me.Label10.TabIndex = 35
        Me.Label10.Text = "Tipo Doc:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label9.Location = New System.Drawing.Point(222, 387)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 13)
        Me.Label9.TabIndex = 33
        Me.Label9.Text = "Num doc:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label5.Location = New System.Drawing.Point(15, 189)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 13)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "cliente: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label3.Location = New System.Drawing.Point(13, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Marca:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label2.Location = New System.Drawing.Point(13, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Nombre:"
        '
        'txtcodigo
        '
        Me.txtcodigo.Enabled = False
        Me.txtcodigo.ForeColor = System.Drawing.Color.DarkRed
        Me.txtcodigo.Location = New System.Drawing.Point(83, 38)
        Me.txtcodigo.Name = "txtcodigo"
        Me.txtcodigo.Size = New System.Drawing.Size(129, 23)
        Me.txtcodigo.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label1.Location = New System.Drawing.Point(13, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Código:"
        '
        'btnnuevo
        '
        Me.btnnuevo.BackColor = System.Drawing.Color.DarkCyan
        Me.btnnuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnnuevo.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnuevo.ForeColor = System.Drawing.Color.White
        Me.btnnuevo.Location = New System.Drawing.Point(6, 464)
        Me.btnnuevo.Name = "btnnuevo"
        Me.btnnuevo.Size = New System.Drawing.Size(110, 22)
        Me.btnnuevo.TabIndex = 10
        Me.btnnuevo.Text = "Nuevo"
        Me.btnnuevo.UseVisualStyleBackColor = False
        '
        'btneditar
        '
        Me.btneditar.BackColor = System.Drawing.Color.DarkCyan
        Me.btneditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btneditar.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btneditar.ForeColor = System.Drawing.Color.White
        Me.btneditar.Location = New System.Drawing.Point(137, 464)
        Me.btneditar.Name = "btneditar"
        Me.btneditar.Size = New System.Drawing.Size(110, 22)
        Me.btneditar.TabIndex = 12
        Me.btneditar.Text = "Editar"
        Me.btneditar.UseVisualStyleBackColor = False
        '
        'btnguardar
        '
        Me.btnguardar.BackColor = System.Drawing.Color.DarkCyan
        Me.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnguardar.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnguardar.ForeColor = System.Drawing.Color.White
        Me.btnguardar.Location = New System.Drawing.Point(137, 464)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(110, 22)
        Me.btnguardar.TabIndex = 11
        Me.btnguardar.Text = "Guardar"
        Me.btnguardar.UseVisualStyleBackColor = False
        '
        'ttmensaje
        '
        Me.ttmensaje.IsBalloon = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.DarkCyan
        Me.Label13.Location = New System.Drawing.Point(156, 22)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(265, 29)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "Ingreso Equipos Almacén"
        '
        'erroricono
        '
        Me.erroricono.ContainerControl = Me
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.sisalmacen.My.Resources.Resources.Vista__6_
        Me.PictureBox1.Location = New System.Drawing.Point(25, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(104, 62)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'frmequipo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1169, 595)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "frmequipo"
        Me.Text = ".:.  Listado y Mantenimiento de Ingreso de equipos a Almacén .:."
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.datalistado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.erroricono, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents lbltotal As System.Windows.Forms.Label
    Friend WithEvents btneliminar As System.Windows.Forms.Button
    Friend WithEvents btndetalles As System.Windows.Forms.Button
    Friend WithEvents cbeliminar As System.Windows.Forms.CheckBox
    Friend WithEvents datalistado As System.Windows.Forms.DataGridView
    Friend WithEvents Eliminar As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents txtbuscar As System.Windows.Forms.TextBox
    Friend WithEvents cbocampo As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btncancelar As System.Windows.Forms.Button
    Friend WithEvents btneditar As System.Windows.Forms.Button
    Friend WithEvents btnguardar As System.Windows.Forms.Button
    Friend WithEvents btnnuevo As System.Windows.Forms.Button
    Friend WithEvents inexistente As System.Windows.Forms.LinkLabel
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtcodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtreparacion_desc As System.Windows.Forms.TextBox
    Friend WithEvents txtnumdoc As System.Windows.Forms.TextBox
    Friend WithEvents txtfecha_ingreso As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnhorario As System.Windows.Forms.Button
    Friend WithEvents txtnombrecliente As System.Windows.Forms.TextBox
    Friend WithEvents txtidcliente As System.Windows.Forms.TextBox
    Friend WithEvents txtmarca As System.Windows.Forms.TextBox
    Friend WithEvents txtnombre As System.Windows.Forms.TextBox
    Friend WithEvents ttmensaje As System.Windows.Forms.ToolTip
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents btnsalir As System.Windows.Forms.Button
    Friend WithEvents erroricono As System.Windows.Forms.ErrorProvider
    Friend WithEvents cbotipo_doc As System.Windows.Forms.ComboBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtserie As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtmodelo As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cboestadoalmacen As System.Windows.Forms.ComboBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtproblema As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cboestado_pago As System.Windows.Forms.ComboBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtfecha_salida As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txttotalpago As System.Windows.Forms.TextBox
End Class

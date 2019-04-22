Public Class frmequipo
    Private dt As New DataTable 'creamos una variable para representar una tabla en memoria
   
    Private Sub mostrar()
        Try
            'instanciamos la clase ftrabajador y llamamos a la funcion mostrar trabajadores
            Dim func As New fequipo
            dt = func.mostrar
            'ocultamos la columna donde aparece el check de eliminacion
            datalistado.Columns.Item("Eliminar").Visible = False

            'si hay registros entonces llenamos la lista con los registros, mostramos las columas del datagridview datalistado
            If dt.Rows.Count <> 0 Then
                datalistado.DataSource = dt
                txtbuscar.Enabled = True
                datalistado.ColumnHeadersVisible = True
                inexistente.Visible = False

            Else
                'si no hay registros entonces no mostramos nada y mostramos el mensaje de datos inexistentes y ocultamos las columas
                datalistado.DataSource = Nothing
                datalistado.ColumnHeadersVisible = False
                cbeliminar.CheckState = CheckState.Unchecked
                inexistente.Visible = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        'ocultamos y mostramos los botones correspondientes
        btnnuevo.Visible = True
        btnguardar.Visible = False
        btneditar.Visible = False
        cbeliminar.Checked = False
        'llamamos al procedimiento buscar
        buscar()
    End Sub
    Private Sub buscar()
        Try
            'creamos un objeto dataset que me permite recoger los datos de la fuente de datos y traerlos a nuestra aplicacion
            Dim ds As New DataSet
            'copiamos a la variable ds todo los registros que contiene la variable dt que es datatable
            ds.Tables.Add(dt.Copy)
            Dim dv As New DataView(ds.Tables(0))
            'filtramos los datos por el campo elegido el combobox cbocampo y que inicien con la cadena escrita en el txtbusccar
            dv.RowFilter = cbocampo.Text & " like '" & txtbuscar.Text & "%'"
            'si la cantidad de registros es mayor que cero entonces mostramos los registros filtrados
            If dv.Count <> 0 Then
                inexistente.Visible = False
                datalistado.DataSource = dv
                ocultar_columnas()
                'en caso no obtengamos registros no mostramos nada y mostramos el mensaje del label inexistente "datos inexistentes"
            Else
                inexistente.Visible = True
                datalistado.DataSource = Nothing
            End If
            'mostramos en el label el total de resgistros filtrados
            lbltotal.Text = "Total Registros: " & dv.Count
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub limpiar()
        'procedimiento para limpiar los registros
        txtcodigo.Text = ""
        txtidcliente.Text = ""
        txtnombrecliente.Text = ""
        txtnombre.Text = ""
        txtmarca.Text = ""
        txtnumdoc.Text = ""
        txtfecha_ingreso.Text = ""
        txtreparacion_desc.Text = ""
        txtproblema.Text = ""
        txtnumdoc.Text = ""
        txtreparacion_desc.Text = ""
        'ocultamos los botones
        btnguardar.Visible = False
        btneditar.Visible = False
    End Sub
    Private Sub ocultar_columnas()
        'ocultamos las columas que no queremos que se muestren, podremos ocultar las llaves primarias o las observaciones
        datalistado.Columns(1).Visible = False
        datalistado.Columns(2).Visible = False
        datalistado.Columns(6).Visible = False
        datalistado.Columns(7).Visible = False
        datalistado.Columns(12).Visible = False
    End Sub



    Private Sub btneliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btneliminar.Click
        Dim result As DialogResult 'declaramos la variable que recogera el valor resultante(true o false) de la pregunta de confirmacion de eliminar o no registros?
        'creamos la pregunta de confirmacion antes de eliminar registros
        result = MessageBox.Show("Realmente desea eliminar los Equipos?", "Eliminando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If result = DialogResult.OK Then 'si hace click en ok entonces eliminamos
            Try
                'creamos un bucle que inicia desde 1 hasta la cantidad de registros que quiere eliminar
                For Each row As DataGridViewRow In datalistado.Rows
                    Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Eliminar").Value) 'marcado es la variable que guarda la fila que se selecciono
                    If marcado Then
                        Dim oneKey As Integer = Convert.ToInt32(row.Cells("idequipo").Value) 'enviamos el campo de la llave principal para eliminarlo
                        Dim vbd As New vequipo 'instanciamos la clase de las variables
                        Dim func As New fequipo 'instanciamos la clase de las funciones
                        vbd.gidequipo = oneKey
                        'llamamos a la funcion eliminar del objeto func
                        If func.eliminar(vbd) Then
                        Else
                            'mostramos un mensaje si hay un error y no se puede eliminar 
                            MessageBox.Show("Error al eliminar los equipos", "Eliminando registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    End If
                Next
                'llamamos a mostrar
                Call mostrar()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        Else
            MessageBox.Show("Cancelando eliminacion de registros", "Eliminando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call mostrar()
        End If
        limpiar()
    End Sub

    Private Sub txtbuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbuscar.TextChanged
        buscar()
    End Sub

    Private Sub datalistado_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles datalistado.CellClick
        'mostramos todos los datos del datagridview en las cajas de texto
        txtcodigo.Text = datalistado.SelectedCells.Item(1).Value
        txtnombre.Text = datalistado.SelectedCells.Item(2).Value
        txtmarca.Text = datalistado.SelectedCells.Item(3).Value
        txtmodelo.Text = datalistado.SelectedCells.Item(4).Value
        txtserie.Text = datalistado.SelectedCells.Item(5).Value
        txtidcliente.Text = datalistado.SelectedCells.Item(6).Value
        txtnombrecliente.Text = datalistado.SelectedCells.Item(7).Value
        txtproblema.Text = datalistado.SelectedCells.Item(8).Value
        cboestadoalmacen.Text = datalistado.SelectedCells.Item(9).Value
        txtfecha_ingreso.Text = datalistado.SelectedCells.Item(10).Value
        cboestado_pago.Text = datalistado.SelectedCells.Item(11).Value
        txtreparacion_desc.Text = datalistado.SelectedCells.Item(12).Value
        cbotipo_doc.Text = datalistado.SelectedCells.Item(13).Value
        txtnumdoc.Text = datalistado.SelectedCells.Item(14).Value
        txttotalpago.Text = datalistado.SelectedCells.Item(15).Value
        txtfecha_salida.Text = datalistado.SelectedCells.Item(16).Value


        btnguardar.Visible = False
        btneditar.Visible = True
    End Sub

    Private Sub datalistado_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles datalistado.CellContentClick
        'controlamos los checkbox de todas las filas de los registros mostramos en el datagridview
        If e.ColumnIndex = Me.datalistado.Columns.Item("Eliminar").Index Then
            Dim chkCell As DataGridViewCheckBoxCell = Me.datalistado.Rows(e.RowIndex).Cells("Eliminar")
            chkCell.Value = Not chkCell.Value
        End If
    End Sub

    Private Sub cbeliminar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbeliminar.CheckedChanged
        'mostramos u ocultamos la columna del check de eliminacion
        If cbeliminar.CheckState = CheckState.Checked Then
            datalistado.Columns.Item("Eliminar").Visible = True
        Else
            datalistado.Columns.Item("Eliminar").Visible = False
        End If
    End Sub



   

    Private Sub btnnuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnuevo.Click
        limpiar()
        btnguardar.Visible = True
    End Sub



    Private Sub btneditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btneditar.Click
        Dim result As DialogResult
        'preguntamos si esta seguro de editar o no los datos
        result = MessageBox.Show("Realmente desea modificar los datos del equipo?", "MOdificando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If result = DialogResult.OK Then 'si esta seguro de modificar
            'verficamos que todos los campos no esten vacios
            If Me.ValidateChildren = True And txtcodigo.Text <> "" And txtnombre.Text <> "" And txtmarca.Text <> "" And txtserie.Text <> "" And txtmodelo.Text <> "" And txtidcliente.Text <> "" And txtproblema.Text <> "" And txtreparacion_desc.Text <> "" And txtnumdoc.Text <> "" And txttotalpago.Text <> "" Then
                Try
                    Dim dts As New vequipo 'instanciamos a la clase de variables de la tabla trabajador
                    Dim func As New fequipo 'instanciamos a la clase de funciones de la tabla trabajador

                    'enviamos los datos 
                    dts.gidequipo = txtcodigo.Text
                    dts.gnombre = txtnombre.Text
                    dts.gmarca = txtmarca.Text
                    dts.gmodelo = txtmodelo.Text
                    dts.gserie = txtserie.Text
                    dts.gidcliente = txtidcliente.Text
                    dts.gproblema_desc = txtproblema.Text
                    dts.gestado_almacen = cboestadoalmacen.Text
                    dts.gfecha_ingreso = txtfecha_ingreso.Text
                    dts.gestado_pago = cboestado_pago.Text
                    dts.greparacion_desc = txtreparacion_desc.Text
                    dts.gtipo_doc = cbotipo_doc.Text
                    dts.gnum_doc = txtnumdoc.Text
                    dts.gtotal_pago = txttotalpago.Text
                    dts.gfecha_salida = txtfecha_salida.Text


                    'llamamos a la funcion mostrar del objeto func
                    If func.editar(dts) Then
                        MessageBox.Show("Equipo Modificado Correctamente", "Modificando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        mostrar()
                        limpiar()
                    Else

                        MessageBox.Show("Error al intentar Modificar el Equipo", "MOdificanco registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If


                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Else
                'mostramos el mensaje en caso algunos de los campos esten vacios
                MessageBox.Show("Falta ingresar algunos datos", "Modificando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            'mostramos un mensaje en caso se cancele la modificacion
            MessageBox.Show("NO se ha modificado el equipo", "MOdificando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call mostrar()
        End If

    End Sub

    Private Sub btnguardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnguardar.Click
        'validamos que todos los datos esten ingresados
        If Me.ValidateChildren = True And txtnombre.Text <> "" And txtmarca.Text <> "" And txtserie.Text <> "" And txtmodelo.Text <> "" And txtidcliente.Text <> "" And txtproblema.Text <> "" And txtreparacion_desc.Text <> "" And txtnumdoc.Text <> "" And txttotalpago.Text <> "" Then
            Try
                Dim dts As New vequipo 'instanciamos a la clase atributos de la tabla trabajador
                Dim func As New fequipo 'instanciamos a la clase funciones de la tabla trabajador

                'enviamos los datos
                
                dts.gnombre = txtnombre.Text
                dts.gmarca = txtmarca.Text
                dts.gmodelo = txtmodelo.Text
                dts.gserie = txtserie.Text
                dts.gidcliente = txtidcliente.Text
                dts.gproblema_desc = txtproblema.Text
                dts.gestado_almacen = cboestadoalmacen.Text
                dts.gfecha_ingreso = txtfecha_ingreso.Text
                dts.gestado_pago = cboestado_pago.Text
                dts.greparacion_desc = txtreparacion_desc.Text
                dts.gtipo_doc = cbotipo_doc.Text
                dts.gnum_doc = txtnumdoc.Text
                dts.gtotal_pago = txttotalpago.Text
                dts.gfecha_salida = txtfecha_salida.Text

                If func.insertar(dts) Then
                    MessageBox.Show("equipo Guardado Correctamente", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    mostrar()
                    limpiar()
                Else
                    MessageBox.Show("Error al intentar Guardar equipo", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    mostrar()
                    limpiar()


                End If


            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            'mostramos un mensaje en caso falten datos
            MessageBox.Show("Falta ingresar algunos datos", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub




    Private Sub btncancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelar.Click
        limpiar()
    End Sub

    Private Sub btnsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsalir.Click
        Me.Close() 'cerramos el formulario
    End Sub



   

    


   



    Private Sub frmequipo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'llamamos al procedimiento mostrar al cargar el formulario, para mostrar la lista de registros
        mostrar()
    End Sub

    Private Sub txttotalpago_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txttotalpago.KeyPress
        
    End Sub


 

    Private Sub txtproblema_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtproblema.MouseHover
        'mostramos un mensaje informativo
        ttmensaje.SetToolTip(txtproblema, "Ingrese los problemas que presenta el equipo")
        ttmensaje.ToolTipTitle = "Fallas del equipo"
        ttmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub

   
    Private Sub txtnombre_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnombre.TextChanged

    End Sub

    Private Sub txtnombre_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtnombre.Validating
        'mostramos el globo informativo de error
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese el nombre del equipo, este dato es obligatorio")

        End If
    End Sub

    Private Sub txtmarca_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtmarca.TextChanged

    End Sub

    Private Sub txtmarca_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtmarca.Validating
        'mostramos el globo informativo de error
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese la marca del equipo, este dato es obligatorio")

        End If
    End Sub

    Private Sub txtmodelo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtmodelo.TextChanged

    End Sub

    Private Sub txtmodelo_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtmodelo.Validating
        'mostramos el globo informativo de error
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese el modelo del equipo, este dato es obligatorio")

        End If
    End Sub

    Private Sub txtserie_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtserie.TextChanged

    End Sub

    Private Sub txtserie_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtserie.Validating
        'mostramos el globo informativo de error
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese la serie del equipo, este dato es obligatorio")

        End If
    End Sub

    Private Sub txtidcliente_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtidcliente.TextChanged

    End Sub

    Private Sub txtidcliente_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtidcliente.Validating
        'mostramos el globo informativo de error
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Seleccione un cliente, este dato es obligatorio")

        End If
    End Sub

    Private Sub txtproblema_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtproblema.TextChanged

    End Sub

    Private Sub txtproblema_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtproblema.Validating
        'mostramos el globo informativo de error
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese la problematica del equipo, este dato es obligatorio")

        End If
    End Sub

    Private Sub cboestadoalmacen_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboestadoalmacen.MouseHover
        'mostramos un mensaje informativo
        ttmensaje.SetToolTip(cboestadoalmacen, "Seleccione el estado del equipo, si esta o no en almacen")
        ttmensaje.ToolTipTitle = "Estado en Almacen"
        ttmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub cboestadoalmacen_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboestadoalmacen.SelectedIndexChanged

    End Sub

    Private Sub cboestadoalmacen_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cboestadoalmacen.Validating
        'mostramos el globo informativo de error
        If DirectCast(sender, ComboBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Seleccione el estado del equipo en almacen, este dato es obligatorio")

        End If
    End Sub

    Private Sub txtfecha_ingreso_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtfecha_ingreso.Validating
        'mostramos el globo informativo de error
        If DirectCast(sender, DateTimePicker).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese la fecha de ingreso a almacen, este dato es obligatorio")

        End If
    End Sub

    Private Sub txtfecha_ingreso_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtfecha_ingreso.ValueChanged

    End Sub

    Private Sub txtreparacion_desc_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtreparacion_desc.MouseHover
        'mostramos un mensaje informativo
        ttmensaje.SetToolTip(txtreparacion_desc, "Ingrese la reparacion que se ha realizado con el equipo")
        ttmensaje.ToolTipTitle = "Detalle de reparacion"
        ttmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtreparacion_desc_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtreparacion_desc.TextChanged

    End Sub

    Private Sub txtreparacion_desc_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtreparacion_desc.Validating
        'mostramos el globo informativo de error
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese la descripcion de la reparacion, este dato es obligatorio")

        End If
    End Sub

    Private Sub txtnumdoc_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnumdoc.TextChanged

    End Sub

    Private Sub txtnumdoc_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtnumdoc.Validating
        'mostramos el globo informativo de error
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese el numero de documento de ingreso de caja, este dato es obligatorio")

        End If
    End Sub

    Private Sub txttotalpago_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txttotalpago.TextChanged

    End Sub

    Private Sub txttotalpago_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txttotalpago.Validating
        'mostramos el globo informativo de error
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese el total a cancelar, este dato es obligatorio")

        End If
    End Sub

    Private Sub btnhorario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnhorario.Click
        frmvistacliente.ShowDialog()
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub
End Class
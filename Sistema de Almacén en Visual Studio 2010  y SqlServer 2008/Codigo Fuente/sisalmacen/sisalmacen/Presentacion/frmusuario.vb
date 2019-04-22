Public Class frmusuario
    Private dt As New DataTable 'creamos una variable para representar una tabla en memoria
    
    Private Sub mostrar()
        Try
            'instanciamos la clase ftrabajador y llamamos a la funcion mostrar trabajadores
            Dim func As New fusuario
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
        txtidusuario.Text = ""
        txtnombres.Text = ""
        txtapellidos.Text = ""
        txtdni.Text = ""
        txtfecha_nac.Text = ""
        txtdireccion.Text = ""
        txttelefono.Text = ""
        txtemail.Text = ""
        txtlogin.Text = ""
        txtpassword.Text = ""
        'ocultamos los botones
        btnguardar.Visible = False
        btneditar.Visible = False
    End Sub
    Private Sub ocultar_columnas()
        'ocultamos las columas que no queremos que se muestren, podremos ocultar las llaves primarias o las observaciones
        datalistado.Columns(1).Visible = False
    End Sub
    


    Private Sub btneliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btneliminar.Click
        Dim result As DialogResult 'declaramos la variable que recogera el valor resultante(true o false) de la pregunta de confirmacion de eliminar o no registros?
        'creamos la pregunta de confirmacion antes de eliminar registros
        result = MessageBox.Show("Realmente desea eliminar los Usuarios?", "Eliminando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If result = DialogResult.OK Then 'si hace click en ok entonces eliminamos
            Try
                'creamos un bucle que inicia desde 1 hasta la cantidad de registros que quiere eliminar
                For Each row As DataGridViewRow In datalistado.Rows
                    Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Eliminar").Value) 'marcado es la variable que guarda la fila que se selecciono
                    If marcado Then
                        Dim oneKey As Integer = Convert.ToInt32(row.Cells("idusuario").Value) 'enviamos el campo de la llave principal para eliminarlo
                        Dim vbd As New vusuario 'instanciamos la clase de las variables
                        Dim func As New fusuario 'instanciamos la clase de las funciones
                        vbd.gidusuario = oneKey
                        'llamamos a la funcion eliminar del objeto func
                        If func.eliminar(vbd) Then
                        Else
                            'mostramos un mensaje si hay un error y no se puede eliminar 
                            MessageBox.Show("Error al eliminar los Usuario", "Eliminando registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
        txtidusuario.Text = datalistado.SelectedCells.Item(1).Value
        txtnombres.Text = datalistado.SelectedCells.Item(2).Value
        txtapellidos.Text = datalistado.SelectedCells.Item(3).Value
        txtdni.Text = datalistado.SelectedCells.Item(4).Value
        txtfecha_nac.Text = datalistado.SelectedCells.Item(5).Value
        cbosexo.Text = datalistado.SelectedCells.Item(6).Value
        txttelefono.Text = datalistado.SelectedCells.Item(7).Value
        txtdireccion.Text = datalistado.SelectedCells.Item(8).Value
        txtemail.Text = datalistado.SelectedCells.Item(9).Value
        txtlogin.Text = datalistado.SelectedCells.Item(10).Value
        txtpassword.Text = datalistado.SelectedCells.Item(11).Value
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



    Private Sub txtdni_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtdni.KeyPress
        'validamos que se ingresen solo numeros
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txttelefono_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txttelefono.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub btnnuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnuevo.Click
        limpiar()
        btnguardar.Visible = True
    End Sub



    Private Sub btneditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btneditar.Click
        Dim result As DialogResult
        'preguntamos si esta seguro de editar o no los datos
        result = MessageBox.Show("Realmente desea modificar los datos del usuario?", "MOdificando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If result = DialogResult.OK Then 'si esta seguro de modificar
            'verficamos que todos los campos no esten vacios
            If Me.ValidateChildren = True And txtidusuario.Text <> "" And txtnombres.Text <> "" And txtapellidos.Text <> "" And txtdni.Text <> "" And txtfecha_nac.Text <> "" And txttelefono.Text <> "" And txtdireccion.Text <> "" And cbosexo.Text <> "" And txtemail.Text <> "" And txtlogin.Text <> "" And txtpassword.Text <> "" Then
                Try
                    Dim dts As New vusuario 'instanciamos a la clase de variables de la tabla trabajador
                    Dim func As New fusuario 'instanciamos a la clase de funciones de la tabla trabajador

                    'enviamos los datos 
                    dts.gidusuario = txtidusuario.Text
                    dts.gnombres = StrConv((txtnombres.Text), VbStrConv.ProperCase) 'convertimos la primera letra a mayusculas
                    dts.gapellidos = StrConv((txtapellidos.Text), VbStrConv.ProperCase)
                    dts.gdni = txtdni.Text
                    dts.gfecha_nac = txtfecha_nac.Text
                    dts.gdireccion = txtdireccion.Text
                    dts.gtelefono = txttelefono.Text
                    dts.gsexo = cbosexo.Text
                    dts.gemail = StrConv((txtemail.Text), VbStrConv.ProperCase)
                    dts.glogin = txtlogin.Text
                    dts.gpassword = txtpassword.Text

                    'llamamos a la funcion mostrar del objeto func
                    If func.editar(dts) Then
                        MessageBox.Show("Usuario Modificado Correctamente", "Modificando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        mostrar()
                        limpiar()
                    Else

                        MessageBox.Show("Error al intentar Modificar Usuario", "MOdificanco registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
            MessageBox.Show("NO se ha modificado el Usuario", "MOdificando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call mostrar()
        End If

    End Sub

    Private Sub btnguardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnguardar.Click
        'validamos que todos los datos esten ingresados
        If Me.ValidateChildren = True And txtnombres.Text <> "" And txtapellidos.Text <> "" And txtdni.Text <> "" And txtfecha_nac.Text <> "" And txttelefono.Text <> "" And txtdireccion.Text <> "" And cbosexo.Text <> "" And txtemail.Text <> "" And txtlogin.Text <> "" And txtpassword.Text <> "" Then
            Try
                Dim dts As New vusuario 'instanciamos a la clase atributos de la tabla trabajador
                Dim func As New fusuario 'instanciamos a la clase funciones de la tabla trabajador

                'enviamos los datos
                dts.gnombres = StrConv((txtnombres.Text), VbStrConv.ProperCase) 'convertimos la primera letra a mayusculas
                dts.gapellidos = StrConv((txtapellidos.Text), VbStrConv.ProperCase)
                dts.gdni = txtdni.Text
                dts.gfecha_nac = txtfecha_nac.Text
                dts.gdireccion = txtdireccion.Text
                dts.gtelefono = txttelefono.Text
                dts.gsexo = cbosexo.Text
                dts.gemail = StrConv((txtemail.Text), VbStrConv.ProperCase)
                dts.glogin = txtlogin.Text
                dts.gpassword = txtpassword.Text

                If func.insertar(dts) Then
                    MessageBox.Show("Usuario Guardado Correctamente", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    mostrar()
                    limpiar()
                Else
                    MessageBox.Show("Error al intentar Guardar Usuario", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
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


    Private Sub txtnombres_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtnombres.Validating
        'mostramos el globo informativo de error
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese el nombre del Usuario, este dato es obligatorio")

        End If
    End Sub

    Private Sub txtapellidos_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtapellidos.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese los Apellidos del Usuario, este dato es obligatorio")

        End If
    End Sub


    Private Sub txtdni_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtdni.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese el Dni del Usuario, este dato es obligatorio")

        End If
    End Sub



    Private Sub txtdireccion_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtdireccion.MouseHover
        'mostramos un mensaje informativo
        ttmensaje.SetToolTip(txtdireccion, "Ingrese la dirección del Usuario, calle y numero-distrito-provincicia-region")
        ttmensaje.ToolTipTitle = "Dirección"
        ttmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub


    Private Sub txtdireccion_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtdireccion.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese la dirección del Usuario, este dato es obligatorio")

        End If
    End Sub



    Private Sub Label1_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label1.MouseHover
        'mostramos un mensaje informativo
        ttmensaje.SetToolTip(Label1, "Este código es autogenerado por el sistema")
        ttmensaje.ToolTipTitle = "Código Usuario"
        ttmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub




    Private Sub cbosexo_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cbosexo.Validating
        'mostramos el globo informativo de error
        If DirectCast(sender, ComboBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Seleccione el sexo del Usuario, este dato es obligatorio")

        End If
    End Sub




    Private Sub txttelefono_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txttelefono.Validating
        'mostramos el globo informativo de error
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese el teléfono del Usuario, este dato es obligatorio")

        End If
    End Sub

    Private Sub frmusuario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'llamamos al procedimiento mostrar al cargar el formulario, para mostrar la lista de registros
        mostrar()
    End Sub

    Private Sub txtlogin_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtlogin.TextChanged

    End Sub

    Private Sub txtlogin_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtlogin.Validating
        'mostramos el globo informativo de error
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese el login del usuario, este dato es obligatorio")

        End If
    End Sub

    Private Sub txtpassword_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpassword.TextChanged

    End Sub

    Private Sub txtpassword_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtpassword.Validating
        'mostramos el globo informativo de error
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese el password del Usuario, este dato es obligatorio")

        End If
    End Sub

    Private Sub txtemail_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtemail.TextChanged

    End Sub

    Private Sub txtemail_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtemail.Validating
        'mostramos el globo informativo de error
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese el email del usuario, este dato es obligatorio")

        End If
    End Sub
End Class
Public Class frmvistacliente
    Private dt As New DataTable
   
    Private Sub frmvistacliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mostrar()
    End Sub
    Private Sub mostrar()
        Try
            'instanciamos la clase fhorario y llamamos a la funcion mostrar
            Dim func As New fcliente
            dt = func.mostrar

            'si hay registros entonces llenamos la lista con los registros, mostramos las columas del datagridview datalistado
            If dt.Rows.Count <> 0 Then
                datalistado.DataSource = dt
                txtbuscar.Enabled = True
                datalistado.ColumnHeadersVisible = True
                inexistente.Visible = False
                'si no hay registros entonces no mostramos nada y mostramos el mensaje de datos inexistentes y ocultamos las columas
            Else
                datalistado.DataSource = Nothing
                datalistado.ColumnHeadersVisible = False
                inexistente.Visible = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

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
            lbltotal.Text = "Total Registros: " & dv.Count
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub ocultar_columnas()
        'ocultamos las columnas
        datalistado.Columns(0).Visible = False
    End Sub

    Private Sub datalistado_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles datalistado.CellContentClick

    End Sub

    Private Sub datalistado_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles datalistado.CellContentDoubleClick
        'devolvemos los valores al formulario trabajador
        frmequipo.txtidcliente.Text = datalistado.SelectedCells.Item(0).Value
        frmequipo.txtnombrecliente.Text = datalistado.SelectedCells.Item(2).Value
        Me.Close()
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub txtbuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbuscar.TextChanged
        buscar()
    End Sub
End Class
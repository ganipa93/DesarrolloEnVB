Imports System.Data.OleDb
Public Class Ventas
#Region "Validacion de campos"
    Private Sub LimpiarCajas()
        For Each cajas As Control In Me.Controls
            If TypeOf cajas Is TextBox Then
                cajas.Text = ""
                If cajas.TabIndex = 1 Then
                    cajas.Focus()
                End If

            End If
        Next
    End Sub
    Private Sub Ventas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        BtnAgregar.Enabled = False 'TODO: esta línea de código carga datos en la tabla 'DatosDataSet.articulos' Puede moverla o quitarla según sea necesario.
        Me.ArticulosTableAdapter.Fill(Me.DatosDataSet.articulos)
        'TODO: esta línea de código carga datos en la tabla 'DatosDataSet.clientes' Puede moverla o quitarla según sea necesario.
        Me.ClientesTableAdapter.Fill(Me.DatosDataSet.clientes)
        'TODO: esta línea de código carga datos en la tabla 'DatosDataSet.ventas' Puede moverla o quitarla según sea necesario.
        Me.VentasTableAdapter.Fill(Me.DatosDataSet.ventas)
        TxtCantidad.Enabled = False
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        LimpiarCajas()
        Me.Close()
        menuh.BtnVentas.Enabled = True
        menuh.VentasToolStripMenuItem.Enabled = True
    End Sub

    Private Sub TxtId_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtId.LostFocus
        TxtId.BackColor = Color.White
        TxtId.ForeColor = Color.Black
    End Sub

    Private Sub TxtId_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtId.TextChanged
        TxtId.BackColor = Color.Yellow
        TxtId.ForeColor = Color.Red
    End Sub
    Private Sub TxtCantidad_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtCantidad.LostFocus
        TxtCantidad.BackColor = Color.White
        TxtCantidad.ForeColor = Color.Black
    End Sub

    Private Sub TxtCantidad_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCantidad.TextChanged
        TxtCantidad.BackColor = Color.Yellow
        TxtCantidad.ForeColor = Color.Red
    End Sub

    Private Sub TxtCosto_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub TxtCantidad_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCantidad.KeyPress
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub TxtId_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtId.KeyPress
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub
#End Region
    Private Sub ComboBox2_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.Leave
        If ComboBox2.Text = "" Then
            MessageBox.Show("Faltan Datos, inserte Id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        Dim cnx As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=c:\_proy\BD\datos.mdb")
        Dim SQLbuscar As String
        SQLbuscar = "Select * from clientes where clave_cliente Like '" + ComboBox2.Text + "%';"
        Dim cmd As New OleDbCommand(SQLbuscar, cnx)
        cmd.CommandType = CommandType.Text
        cnx.Open()
        Dim lectura As OleDbDataReader = cmd.ExecuteReader()
        If lectura.Read = True Then
            LblRazon.Text = lectura(1).ToString
        Else
            MessageBox.Show("El dato no existe!!", "Adelante...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub ComboBox3_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox3.Leave
        If ComboBox3.Text = "" Then
            MessageBox.Show("Faltan Datos, inserte Id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        Dim cnx As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=c:\_proy\BD\datos.mdb")
        Dim SQLbuscar As String
        SQLbuscar = "Select * from articulos where codigo Like '" + ComboBox3.Text + "%';"
        Dim cmd As New OleDbCommand(SQLbuscar, cnx)
        cmd.CommandType = CommandType.Text
        cnx.Open()
        Dim lectura As OleDbDataReader = cmd.ExecuteReader()
        If lectura.Read = True Then
            LblDescripcion.Text = lectura(1).ToString
            Lblcosto.Text = lectura(2).ToString
            Existencia.Text = lectura(3).ToString
        Else
            MessageBox.Show("El dato no existe!!", "Adelante...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub BtnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAgregar.Click
        Dim cnx As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=c:\_proy\BD\datos.mdb")
        Dim SQLGuardar As String
        SQLGuardar = "insert into ventas values(@id,@cliente,@articulo,@cantidad,@fecha)"
        Dim cmd As New OleDbCommand(SQLGuardar, cnx)
        cmd.CommandType = CommandType.Text
        cmd.Parameters.AddWithValue("@id", TxtId.Text)
        cmd.Parameters.AddWithValue("@cliente", ComboBox2.Text)
        cmd.Parameters.AddWithValue("@articulo", ComboBox3.Text)
        cmd.Parameters.AddWithValue("@cantidad", TxtCantidad.Text)
        cmd.Parameters.AddWithValue("@fecha", DateTimePicker1.Value)
        cmd.CommandType = CommandType.Text
        'Update adeudo
        Dim resulta As Double
        resulta = Lblcosto.Text * TxtCantidad.Text
        Dim SQLUpdate As String
        SQLUpdate = "update clientes set clave_cliente=@folio, saldo=@importe where clave_cliente=@folio"
        Dim comUp As New OleDbCommand(SQLUpdate, cnx)
        comUp.CommandType = CommandType.Text
        comUp.Parameters.AddWithValue("@folio", ComboBox2.Text)
        comUp.Parameters.AddWithValue("@importe", resulta.ToString())
        'end; update adeudo
        'Begin Update Stock
        Dim bajastock As Integer
        bajastock = CInt(Existencia.Text) - CInt(TxtCantidad.Text)
        Dim SQLStock As String
        SQLStock = "update articulos set codigo=@folio, stock=@stock where codigo=@folio"
        Dim comSt As New OleDbCommand(SQLStock, cnx)
        comSt.CommandType = CommandType.Text
        comSt.Parameters.AddWithValue("@folio", Me.ComboBox3.Text)
        comSt.Parameters.AddWithValue("@stock", bajastock.ToString())
        'End; Update Stock
        cnx.Open()
        cmd.ExecuteNonQuery()
        MessageBox.Show("Se Insertó el Cliente " + TxtId.Text, "Agregado", MessageBoxButtons.OK, MessageBoxIcon.Information)
        comUp.ExecuteNonQuery()
        MessageBox.Show("Se Actualizó la deuda del Cliente " + ComboBox2.Text, "Agregado", MessageBoxButtons.OK, MessageBoxIcon.Information)
        comSt.ExecuteNonQuery()
        MessageBox.Show("Se Actualizó El Stock del Producto " + ComboBox3.Text, "Agregado", MessageBoxButtons.OK, MessageBoxIcon.Information)

        cnx.Close()
        LimpiarCajas()
        TxtId.Enabled = True
        BtnAgregar.Enabled = False
        ComboBox2.Enabled = False
        ComboBox3.Enabled = False
        TxtCantidad.Enabled = False
        DateTimePicker1.Enabled = False
        Lblcosto.Text = "Costo Articulo"
        LblDescripcion.Text = "Descripcion articulo"
        LblRazon.Text = "Razón Social"
        BtnBuscar.Enabled = True
        TxtCantidad.Enabled = False
        TxtId.Focus()
        BtnBuscar.Enabled = True
    End Sub

    Private Sub BtnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBuscar.Click
        If TxtId.Text = "" Then
            MessageBox.Show("Faltan Datos, inserte Id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtId.Focus()
        Else
            Dim cnx As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=c:\_proy\BD\datos.mdb")
            Dim SQLbuscar As String
            SQLbuscar = "Select * from ventas where folio Like '" + TxtId.Text + "%';"
            Dim cmd As New OleDbCommand(SQLbuscar, cnx)
            cmd.CommandType = CommandType.Text
            cnx.Open()
            Dim lectura As OleDbDataReader = cmd.ExecuteReader()
            If lectura.Read = True Then

                TxtId.Text = lectura(0).ToString
                ComboBox2.Text = lectura(1).ToString
                ComboBox3.Text = lectura(2).ToString
                TxtCantidad.Text = lectura(3).ToString
                DateTimePicker1.Value = lectura(4).ToString
                TxtId.Focus()
                ComboBox2.Enabled = False
                ComboBox3.Enabled = False
                TxtCantidad.Enabled = False
                DateTimePicker1.Enabled = False
                lectura.Close()
                'Inicio hijos ---->>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

                'Primer Hijo, Raiz(B1)
                Dim cnxB1 As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=c:\_proy\BD\datos.mdb")
                Dim SQLbuscarB1 As String
                SQLbuscarB1 = "Select * from clientes where clave_cliente Like '" + ComboBox2.Text + "%';"
                Dim cmdB1 As New OleDbCommand(SQLbuscarB1, cnx)
                cmdB1.CommandType = CommandType.Text
                cnxB1.Open()
                Dim lecturaB1 As OleDbDataReader = cmdB1.ExecuteReader()
                If lecturaB1.Read = True Then
                    LblRazon.Text = lecturaB1(1).ToString
                    lecturaB1.Close()
                End If
                'Fin Primer hijo, Raiz(B1)
                'Segundo Hijo, Raiz(C1)
                Dim cnxC1 As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=c:\_proy\BD\datos.mdb")
                Dim SQLbuscarC1 As String
                SQLbuscarC1 = "Select * from articulos where codigo Like '" + ComboBox3.Text + "%';"
                Dim cmdC1 As New OleDbCommand(SQLbuscarC1, cnx)
                cmdC1.CommandType = CommandType.Text
                cnxC1.Open()
                Dim lecturaC1 As OleDbDataReader = cmdC1.ExecuteReader()
                If lecturaC1.Read = True Then
                    LblDescripcion.Text = lecturaC1(1).ToString
                    Lblcosto.Text = lecturaC1(2).ToString
                    lecturaC1.Close()
                End If
                'Fin Segundo hijo, Raiz(C1)
                'Fin Hijos ----<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
            Else
                MessageBox.Show("El dato no existe!!", "Adelante...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                BtnAgregar.Enabled = True
                ComboBox2.Focus()
                ComboBox2.Enabled = True
                ComboBox3.Enabled = True
                TxtCantidad.Enabled = True
                DateTimePicker1.Enabled = True
                BtnBuscar.Enabled = False
                TxtId.Enabled = False
            End If
        End If
    End Sub

    Private Sub TxtCantidad_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCantidad.Leave
        Dim valor1 As Double
        valor1 = Existencia.Text
        If TxtCantidad.Text > valor1 Then
            MessageBox.Show("Es imposible comprar mas articulos de los existentes", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TxtCantidad.Text = ""
            TxtCantidad.Focus()
        End If
    End Sub
End Class
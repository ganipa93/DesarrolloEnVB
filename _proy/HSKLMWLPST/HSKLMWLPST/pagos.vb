Imports System.Data.OleDb
Public Class pagos
#Region "validacion de campos"
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
    Private Sub pagos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DatosDataSet.proveedores' Puede moverla o quitarla según sea necesario.
        Me.ProveedoresTableAdapter.Fill(Me.DatosDataSet.proveedores)
        BtnGuardar.Enabled = False
        TextBox4.Enabled = False
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        LimpiarCajas()
        Me.Close()
        menuh.BtnPagos.Enabled = True
        menuh.PagosToolStripMenuItem.Enabled = True
    End Sub

    Private Sub TextBox1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.LostFocus
        TextBox1.BackColor = Color.White
        TextBox1.ForeColor = Color.Black
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        TextBox1.BackColor = Color.Yellow
        TextBox1.ForeColor = Color.Red
    End Sub

    Private Sub TextBox4_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox4.LostFocus
        TextBox4.BackColor = Color.White
        TextBox4.ForeColor = Color.Black
    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged
        TextBox4.BackColor = Color.Yellow
        TextBox4.ForeColor = Color.Red
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub TextBox4_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox4.KeyPress
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub
#End Region
    Private Sub ComboBox1_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.Leave
        If ComboBox1.Text = "" Then
            MessageBox.Show("Faltan Datos, inserte Id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        Dim cnx As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=c:\_proy\BD\datos.mdb")
        Dim SQLbuscar As String
        SQLbuscar = "Select * from proveedores where id_proveedor Like '" + ComboBox1.Text + "%';"
        Dim cmd As New OleDbCommand(SQLbuscar, cnx)
        cmd.CommandType = CommandType.Text
        cnx.Open()
        Dim lectura As OleDbDataReader = cmd.ExecuteReader()
        If lectura.Read = True Then
            LblRS.Text = lectura(1).ToString
            'Hijo1 Rama A1, Ramificacion de datos "JOIN"
            Dim cnxA1 As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=c:\_proy\BD\datos.mdb")
            Dim SQLbuscarA1 As String
            SQLbuscarA1 = "Select * from proveedores where id_proveedor Like '" + ComboBox1.Text + "%';"
            Dim cmdA1 As New OleDbCommand(SQLbuscarA1, cnx)
            cmdA1.CommandType = CommandType.Text
            cnxA1.Open()
            Dim lecturaA1 As OleDbDataReader = cmdA1.ExecuteReader()
            If lecturaA1.Read = True Then
                LblSaldo.Text = lecturaA1(2).ToString
            End If
        Else
            MessageBox.Show("El dato no existe!!", "Adelante...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub BtnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBuscar.Click
        If TextBox1.Text = "" Then
            MessageBox.Show("Faltan Datos, inserte Id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TextBox1.Focus()
        Else
            Dim cnx As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=c:\_proy\BD\datos.mdb")
            Dim SQLbuscar As String
            SQLbuscar = "Select * from pagos where id_pago Like '" + TextBox1.Text + "%';"
            Dim cmd As New OleDbCommand(SQLbuscar, cnx)
            cmd.CommandType = CommandType.Text
            cnx.Open()
            Dim lectura As OleDbDataReader = cmd.ExecuteReader()
            If lectura.Read = True Then
                TextBox1.Text = lectura(0).ToString
                ComboBox1.Text = lectura(1).ToString

                'Dim valora As Double
                'valora = lectura(2).ToString
                'Busqueda leave con Z1
                Dim cnxZ1 As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=c:\_proy\BD\datos.mdb")
                Dim SQLbuscarZ1 As String
                SQLbuscarZ1 = "Select * from proveedores where id_proveedor Like '" + ComboBox1.Text + "%';"
                Dim cmdZ1 As New OleDbCommand(SQLbuscarZ1, cnx)
                cmdZ1.CommandType = CommandType.Text
                cnxZ1.Open()
                Dim lecturaZ1 As OleDbDataReader = cmdZ1.ExecuteReader()
                If lecturaZ1.Read = True Then
                    LblRS.Text = lecturaZ1(1).ToString
                    'el Hijo
                    Dim cnxA1 As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=c:\_proy\BD\datos.mdb")
                    Dim SQLbuscarA1 As String
                    SQLbuscarA1 = "Select * from proveedores where id_proveedor Like '" + ComboBox1.Text + "%';"
                    Dim cmdA1 As New OleDbCommand(SQLbuscarA1, cnx)
                    cmdA1.CommandType = CommandType.Text
                    cnxA1.Open()
                    Dim lecturaA1 As OleDbDataReader = cmdA1.ExecuteReader()
                    If lecturaA1.Read = True Then
                        LblSaldo.Text = lecturaA1(2).ToString

                    End If
                    'Finaliza busqueda
                    TextBox1.Focus()
                    TextBox4.Enabled = False
                End If
            Else
                MessageBox.Show("El dato no existe!!", "Adelante...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                TextBox1.Enabled = False
                TextBox4.Text = ""
                TextBox4.Enabled = True
                BtnGuardar.Enabled = True
                BtnBuscar.Enabled = False
            End If
        End If
    End Sub

    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click
        Dim cnx As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=c:\_proy\BD\datos.mdb")
        Dim SQLAdd As String
        SQLAdd = "Insert into pagos  values (@idpago,@id_provedor,@monto)"
        Dim comAdd As New OleDbCommand(SQLAdd, cnx)
        comAdd.CommandType = CommandType.Text
        comAdd.Parameters.AddWithValue("@idpago", TextBox1.Text)
        comAdd.Parameters.AddWithValue("@id_proveedor", ComboBox1.Text)
        comAdd.Parameters.AddWithValue("@monto", TextBox4.Text)
        Dim valor1 As Double
        Dim valor2 As Double
        Dim totala As String
        valor1 = LblSaldo.Text
        valor2 = TextBox4.Text
        totala = valor1 - valor2
        LblPendiente.Text = totala.ToString()
        'Dim cnx2 As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=c:\_proy\BD\datos.mdb")
        Dim SQLUpdate As String
        SQLUpdate = "update proveedores set id_proveedor=@folio, adeudo=@importe where id_proveedor=@folio"
        Dim comUp As New OleDbCommand(SQLUpdate, cnx)
        comUp.CommandType = CommandType.Text
        comUp.Parameters.AddWithValue("@folio", Me.ComboBox1.Text)
        comUp.Parameters.AddWithValue("@importe", Me.LblPendiente.Text)
        cnx.Open()
        comAdd.ExecuteNonQuery()
        MessageBox.Show("Se agrego el pago", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information)
        comUp.ExecuteNonQuery()
        cnx.Close()
        MessageBox.Show("Al usuario " + TextBox1.Text + " solo debe la cantidad de " + LblPendiente.Text, "Actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information)
        BtnGuardar.Enabled = False
        TextBox1.Text = ""
        TextBox1.Focus()
        TextBox1.Enabled = True
        TextBox4.Enabled = False
        BtnBuscar.Enabled = True
        TextBox1.Focus()
    End Sub

    Private Sub TextBox4_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.Leave
        If TextBox4.Text = "" Then
            MessageBox.Show("No campos nulos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TextBox4.Focus()
        Else
            Dim valor1 As Double
            valor1 = LblSaldo.Text
            'MessageBox.Show(valor1, "Valor", MessageBoxButtons.OK)
            If TextBox4.Text > valor1 Then
                MessageBox.Show("No puedes abonar más de lo que debes", "alerta", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TextBox4.Text = ""
                TextBox4.Focus()
            End If
        End If
    End Sub
End Class
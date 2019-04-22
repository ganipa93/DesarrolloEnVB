Imports System.Data.OleDb
Public Class FmrAddClientes
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
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DatosDataSet.clientes' Puede moverla o quitarla según sea necesario.
        Me.ClientesTableAdapter.Fill(Me.DatosDataSet.clientes)
        BtnAgregar.Enabled = False
        TxtNombre.Enabled = False
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        LimpiarCajas()

        Me.Close()
        menuh.BtnClient.Enabled = True
        menuh.ClientesToolStripMenuItem.Enabled = True
    End Sub
    Private Sub TxtClave_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtClave.KeyPress
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub
    Private Sub TxtClave_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtClave.LostFocus
        TxtClave.BackColor = Color.White
        TxtClave.ForeColor = Color.Black
    End Sub
    Private Sub TxtClave_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtClave.TextChanged
        TxtClave.BackColor = Color.Yellow
        TxtClave.ForeColor = Color.Red
    End Sub
    Private Sub TxtNombre_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtNombre.LostFocus
        TxtNombre.BackColor = Color.White
        TxtNombre.ForeColor = Color.Black
    End Sub
    Private Sub TxtNombre_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtNombre.TextChanged
        TxtNombre.BackColor = Color.Yellow
        TxtNombre.ForeColor = Color.Red
    End Sub
    Private Sub BtnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBuscar.Click
        If TxtClave.Text = "" Then
            MessageBox.Show("Faltan Datos, inserte Id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtClave.Focus()
        Else
            Dim cnx As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=c:\_proy\BD\datos.mdb")
            Dim SQLbuscar As String
            SQLbuscar = "Select * from clientes where clave_cliente Like '" + TxtClave.Text + "%';"
            Dim cmd As New OleDbCommand(SQLbuscar, cnx)
            cmd.CommandType = CommandType.Text
            cnx.Open()
            Dim lectura As OleDbDataReader = cmd.ExecuteReader()
            If lectura.Read = True Then
                Dim temp As String
                TxtClave.Text = lectura(0).ToString
                TxtNombre.Text = lectura(1).ToString
                temp = lectura(2).ToString
                TxtClave.Enabled = True
                TxtNombre.Enabled = False
                TxtClave.Focus()
                lectura.Close()
            Else
                MessageBox.Show("El dato no existe!!", "Adelante...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                TxtClave.Enabled = False
                TxtNombre.Enabled = True
                TxtNombre.Focus()
                TxtNombre.Text = ""
                BtnAgregar.Enabled = True
                BtnBuscar.Enabled = False
            End If
        End If
    End Sub

    Private Sub BtnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAgregar.Click
        Dim cnx As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=c:\_proy\BD\datos.mdb")
        Dim SQLGuardar As String
        SQLGuardar = "insert into clientes values(@id,@nombre,@saldo)"
        Dim cmd As New OleDbCommand(SQLGuardar, cnx)
        cmd.CommandType = CommandType.Text
        cmd.Parameters.AddWithValue("@id", TxtClave.Text)
        cmd.Parameters.AddWithValue("@nombre", TxtNombre.Text)
        cmd.Parameters.AddWithValue("@saldo", 0)
        cmd.CommandType = CommandType.Text
        cnx.Open()
        cmd.ExecuteNonQuery()
        cnx.Close()
        MessageBox.Show("Se Insertó el Cliente " + TxtClave.Text, "Agregado", MessageBoxButtons.OK, MessageBoxIcon.Information)
        LimpiarCajas()
        TxtClave.Enabled = True
        BtnAgregar.Enabled = False
        BtnBuscar.Enabled = True
        TxtNombre.Enabled = False
        TxtClave.Focus()
        Me.ClientesTableAdapter.Fill(Me.DatosDataSet.clientes)
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Me.ClientesTableAdapter.Fill(Me.DatosDataSet.clientes)
    End Sub
End Class

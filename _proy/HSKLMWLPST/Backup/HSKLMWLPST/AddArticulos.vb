Imports System.Data.OleDb
Public Class AddArticulos
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
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        LimpiarCajas()
        Me.Close()
        menuh.BtnArt.Enabled = True
        menuh.AbonosToolStripMenuItem.Enabled = True

    End Sub

    Private Sub TxtCodigo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtCodigo.LostFocus
        TxtCodigo.BackColor = Color.White
        TxtCodigo.ForeColor = Color.Black
    End Sub

    Private Sub TxtCodigo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCodigo.TextChanged
        TxtCodigo.BackColor = Color.Yellow
        TxtCodigo.ForeColor = Color.Red
    End Sub

    Private Sub TxtDescripcion_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtDescripcion.LostFocus
        TxtDescripcion.BackColor = Color.White
        TxtDescripcion.ForeColor = Color.Black
    End Sub

    Private Sub TxtDescripcion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtDescripcion.TextChanged
        TxtDescripcion.BackColor = Color.Yellow
        TxtDescripcion.ForeColor = Color.Red
    End Sub

    Private Sub TxtCosto_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtCosto.LostFocus
        TxtCosto.BackColor = Color.White
        TxtCosto.ForeColor = Color.Black
    End Sub

    Private Sub TxtCosto_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCosto.TextChanged
        TxtCosto.BackColor = Color.Yellow
        TxtCosto.ForeColor = Color.Red
    End Sub

    Private Sub TxtCodigo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCodigo.KeyPress
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub TxtCosto_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCosto.KeyPress
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub
#End Region
    Private Sub AddArticulos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DatosDataSet.articulos' Puede moverla o quitarla según sea necesario.
        Me.ArticulosTableAdapter.Fill(Me.DatosDataSet.articulos)
        BtnAgregar.Enabled = False
        TxtDescripcion.Enabled = False
        TxtCosto.Enabled = False
    End Sub
    Private Sub BtnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBuscar.Click
        If TxtCodigo.Text = "" Then
            MessageBox.Show("Faltan Datos, inserte Id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtCodigo.Focus()
        Else

            Dim cnx As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=c:\_proy\BD\datos.mdb")
            Dim SQLbuscar As String
            SQLbuscar = "Select * from articulos where codigo Like '" + TxtCodigo.Text + "%';"
            Dim cmd As New OleDbCommand(SQLbuscar, cnx)
            cmd.CommandType = CommandType.Text
            cnx.Open()
            Dim lectura As OleDbDataReader = cmd.ExecuteReader()
            If lectura.Read = True Then
                Dim temp As String
                TxtCodigo.Text = lectura(0).ToString
                TxtCosto.Text = lectura(1).ToString
                TxtDescripcion.Text = lectura(2).ToString
                temp = lectura(3).ToString
                TxtCosto.Enabled = False
                TxtDescripcion.Enabled = False
                lectura.Close()
            Else
                MessageBox.Show("El dato no existe!!", "Adelante...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                TxtCodigo.Enabled = False
                TxtCosto.Enabled = True
                TxtDescripcion.Enabled = True
                TxtCodigo.Enabled = False
                TxtDescripcion.Focus()
                TxtCosto.Text = ""
                TxtDescripcion.Text = ""
                BtnAgregar.Enabled = True
                BtnBuscar.Enabled = False
            End If
        End If
    End Sub

    Private Sub BtnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAgregar.Click
        Dim cnx As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=c:\_proy\BD\datos.mdb")
        Dim SQLGuardar As String
        SQLGuardar = "insert into articulos values(@id,@descripcion,@costo,@stock)"
        Dim cmd As New OleDbCommand(SQLGuardar, cnx)
        cmd.CommandType = CommandType.Text
        cmd.Parameters.AddWithValue("@id", TxtCodigo.Text)
        cmd.Parameters.AddWithValue("@descripcion", TxtDescripcion.Text)
        cmd.Parameters.AddWithValue("@costo", TxtCosto.Text)
        cmd.Parameters.AddWithValue("@stock", 0)
        cmd.CommandType = CommandType.Text
        cnx.Open()
        cmd.ExecuteNonQuery()
        cnx.Close()
        MessageBox.Show("Se Insertó el Cliente " + TxtCodigo.Text, "Agregado", MessageBoxButtons.OK, MessageBoxIcon.Information)
        LimpiarCajas()
        TxtCodigo.Enabled = True
        BtnAgregar.Enabled = False
        BtnBuscar.Enabled = True
        TxtCosto.Enabled = False
        TxtDescripcion.Enabled = False
        Me.ArticulosTableAdapter.Fill(Me.DatosDataSet.articulos)
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Me.ArticulosTableAdapter.Fill(Me.DatosDataSet.articulos)
    End Sub
End Class
Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'cargo la lista de opciones del Cseleccion
        CSeleccion.Items.Add("Paises")
        CSeleccion.Items.Add("Animales")
        CSeleccion.Items.Add("Frutas")
        ' Form1.MaximizeBox = False
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'llamo a mi form2 k es el k contiene el juego
        ' Form2.Show()
        ' Form1.Visible = False
        Form2.Show()

    End Sub
    Private Sub ButtonCredito_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCredito.Click
        'llamo a mi form3 de los creditos
        Form3.Show()
    End Sub
    Private Sub Cseleccion_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CSeleccion.SelectedIndexChanged
        'mediante if abilito el button1 ya k tiene por default el Enabled =false
        'y a LCategoria le paso el valos de Paises Frutas y animales Segun Corresponda
        If CSeleccion.Text = "Paises" Then
            Button1.Enabled = True
            LCategoria.Text = "Paises"
            'Button2.Enabled = True
        End If
        If CSeleccion.Text = "Frutas" Then
            Button1.Enabled = True
            LCategoria.Text = "Frutas"
            'Button2.Enabled = True
        End If
        If CSeleccion.Text = "Animales" Then
            Button1.Enabled = True
            LCategoria.Text = "Animales"
            'Button2.Enabled = True
        End If
    End Sub
    Private Sub ButtonSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSalir.Click
        'boton salir cierra el formulario
        Me.Close()
    End Sub
End Class

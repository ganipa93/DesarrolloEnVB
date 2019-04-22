
Public Class frmusuariologin

    Private Sub btningresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btningresar.Click
        Try
            Dim dts As New vusuario
            Dim func As New fusuario
            dts.glogin = txtlogin.Text
            dts.gpassword = txtpassword.Text
            If func.validarusuario(dts) = True Then
                Dim forinicio As New frminicio
                forinicio.Show()
                Me.Hide()
            Else
                MessageBox.Show("Login o Password incorrecto, Usted no tiene acceso", "Acceso denegado - Sistema de Almacén", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtpassword.Clear()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub Btncancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btncancelar.Click
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lbltime.Text = TimeOfDay
    End Sub

    Private Sub frmusuariologin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lbltime.Text = TimeOfDay

    End Sub
    

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click

    End Sub

    Private Sub PictureBox3_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox3.MouseHover
        'mostramos un mensaje informativo
        ttmensaje.SetToolTip(PictureBox3, "Usted debe tener una cuenta de usuario y un password para acceder al sistema")
        ttmensaje.ToolTipTitle = "Ingreso Al Sistema"
        ttmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub
End Class
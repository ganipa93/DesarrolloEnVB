Public Class frmsuma
    Private Sub btncalcular_Click(sender As Object, e As EventArgs) Handles btncalcular.Click
        Dim num1, num2, res As Double
        num1 = Val(txtnum1.Text)
        num2 = Val(txtnum2.Text)
        res = num1 + num2
        txtres.Text = res
    End Sub
    Private Sub btnlimpiar_Click(sender As Object, e As EventArgs) Handles btnlimpiar.Click
        txtres.Clear()
        txtnum1.Clear()
        txtnum2.Clear()
    End Sub
    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        End
    End Sub
End Class
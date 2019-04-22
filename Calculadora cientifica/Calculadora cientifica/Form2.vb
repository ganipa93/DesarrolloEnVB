Public Class Form2
    Dim num1 As Double
    Dim num2 As Double
    Dim Ope As String
    Dim res As Double
    'Numeros 0 - 9'
    Private Sub N1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles N1.Click
        Txtr.Text = Txtr.Text & 1
    End Sub
    Private Sub N2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles N2.Click
        Txtr.Text = Txtr.Text & 2
    End Sub
    Private Sub N3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles N3.Click
        Txtr.Text = Txtr.Text & 3
    End Sub
    Private Sub N4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles N4.Click
        Txtr.Text = Txtr.Text & 4
    End Sub
    Private Sub N5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles N5.Click
        Txtr.Text = Txtr.Text & 5
    End Sub
    Private Sub N6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles N6.Click
        Txtr.Text = Txtr.Text & 6
    End Sub
    Private Sub N7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles N7.Click
        Txtr.Text = Txtr.Text & 7
    End Sub
    Private Sub N8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles N8.Click
        Txtr.Text = Txtr.Text & 8
    End Sub
    Private Sub N9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles N9.Click
        Txtr.Text = Txtr.Text & 9
    End Sub
    Private Sub N0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles N0.Click
        Txtr.Text = Txtr.Text & 0
    End Sub
    'Borrar todo'
    Private Sub Btnb1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnb1.Click
        Txtr.Clear()
    End Sub
    'operaciones basicas'
    Private Sub S_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S.Click
        num1 = Val(Txtr.Text)
        Txtr.Text = ""
        Ope = "+"
        Txtr.Clear()
    End Sub
    Private Sub RE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RE.Click
        num1 = Val(Txtr.Text)
        Txtr.Text = ""
        Ope = "-"
        Txtr.Clear()
    End Sub
    Private Sub MU_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MU.Click
        num1 = Val(Txtr.Text)
        Txtr.Text = ""
        Ope = "*"
        Txtr.Clear()
    End Sub
    Private Sub DI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DI.Click
        num1 = Val(Txtr.Text)
        Txtr.Text = ""
        Ope = "/"
        Txtr.Clear()
    End Sub

    Private Sub IG_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IG.Click
        num2 = Val(Txtr.Text)
        Select Case [Ope]
            Case "+"
                res = num1 + num2
                Txtr.Text = res
            Case "-"
                res = num1 - num2
                Txtr.Text = res
            Case "*"
                res = num1 - num2
                Txtr.Text = res
            Case "/"
                If (num2 = 0) Then
                    Txtr.Text = "No se puede dividir entre cero"
                Else
                    res = num1 / num2
                    Txtr.Text = res
                End If
            Case "SEN"
                res = Math.Sin(num1)
                Txtr.Text = res
            Case "COS"
                res = Math.Cos(num1)
                Txtr.Text = res
            Case "TNG"
                res = Math.Tan(num1)
                Txtr.Text = res
            Case "CTG"
                res = Math.Tanh(num1)
                Txtr.Text = res
            Case "CSC"
                res = Math.Cosh(num1)
                Txtr.Text = res
            Case "CSN"
                res = Math.Sinh(num1)
                Txtr.Text = res
            Case "LOG"
                res = Math.Log(num1)
                Txtr.Text = res
            Case "LGN"
                res = Math.Log10(num1)
                Txtr.Text = res
            Case "PTN"
                res = num1 ^ num2
                Txtr.Text = res
            Case "PTD"
                res = num1 ^ 2
                Txtr.Text = res
            Case "PTC"
                res = num1 ^ 2
                Txtr.Text = res
            Case "RC"
                res = num1 ^ 0.5
                Txtr.Text = res
            Case "RT"
                res = num1 ^ (1 / 3)
                Txtr.Text = res
            Case "RN"
                res = num1 ^ (1 / num2)
                Txtr.Text = res
            Case "RN"
                res = num1 * 2.71828182846
                Txtr.Text = res
            Case "PI"
                res = num1 * 3.14159265359
                Txtr.Text = res
            Case "Po"
                res = num1 * (num2 / 100)
        End Select

    End Sub


    Private Sub SEN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SEN.Click
        num1 = Val(Txtr.Text)
        Ope = "SEN"
    End Sub

    Private Sub COS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles COS.Click
        num1 = Val(Txtr.Text)
        Ope = "COS"
    End Sub

    Private Sub TNG_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TNG.Click
        num1 = Val(Txtr.Text)
        Ope = "TNG"
    End Sub

    Private Sub CSN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CSN.Click
        num1 = Val(Txtr.Text)
        Ope = "CSN"
    End Sub

    Private Sub CSC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CSC.Click
        num1 = Val(Txtr.Text)
        Ope = "CSC"
    End Sub

    Private Sub CTG_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CTG.Click
        num1 = Val(Txtr.Text)
        Ope = "CTG"
    End Sub
    Private Sub LOG_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LOG.Click
        num1 = Val(Txtr.Text)
        Ope = "LOG"
    End Sub
    Private Sub LGN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LGN.Click
        num1 = Val(Txtr.Text)
        Ope = "LGN"
    End Sub

    Private Sub POTEN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles POTEN.Click
        num1 = Val(Txtr.Text)
        Txtr.Text = ""
        Ope = "PTN"
        Txtr.Clear()
    End Sub

    Private Sub CUADR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CUADR.Click
        num1 = Val(Txtr.Text)
        Txtr.Text = ""
        Ope = "PTD"
        Txtr.Clear()
    End Sub

    Private Sub CUBI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CUBI.Click
        num1 = Val(Txtr.Text)
        Txtr.Text = ""
        Ope = "PTC"
        Txtr.Clear()
    End Sub

    Private Sub RC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RC.Click
        num1 = Val(Txtr.Text)
        Txtr.Text = ""
        Ope = "RC"
        Txtr.Clear()
    End Sub

    Private Sub RTR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RTR.Click
        num1 = Val(Txtr.Text)
        Txtr.Text = ""
        Ope = "RT"
        Txtr.Clear()
    End Sub

    Private Sub R_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles R.Click
        num1 = Val(Txtr.Text)
        Txtr.Text = ""
        Ope = "RN"
        Txtr.Clear()
    End Sub

    Private Sub E_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles E.Click
        num1 = Val(Txtr.Text)
        Txtr.Text = ""
        Ope = "e"
        Txtr.Clear()
    End Sub

    Private Sub PI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PI.Click
        num1 = Val(Txtr.Text)
        Txtr.Text = ""
        Ope = "PI"
        Txtr.Clear()
    End Sub

    Private Sub POR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles POR.Click
        num1 = Val(Txtr.Text)
        Txtr.Text = ""
        Ope = "Po"
        Txtr.Clear()
    End Sub

    Private Sub P_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles P.Click

    End Sub
End Class

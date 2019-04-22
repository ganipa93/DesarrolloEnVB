Public Class frm_morse
    ' programado por skskynet,    skskynet@gmail.com  octubre 2007
    Dim desglose As String = ""


    Public Function morse(ByVal caracter As String)

        Dim carac(0 To 37, 0 To 1) As String
        Dim resultado As String
        Dim cont = 0





        'NUMEROS

        carac(0, 0) = "0"
        carac(0, 1) = "-----"
        carac(1, 0) = "1"
        carac(1, 1) = ".----"
        carac(2, 0) = "2"
        carac(2, 1) = "..---"
        carac(3, 0) = "3"
        carac(3, 1) = "...--"
        carac(4, 0) = "4"
        carac(4, 1) = "....-"
        carac(5, 0) = "5"
        carac(5, 1) = "....."
        carac(6, 0) = "6"
        carac(6, 1) = "-...."
        carac(7, 0) = "7"
        carac(7, 1) = "--..."
        carac(8, 0) = "8"
        carac(8, 1) = "---.."
        carac(9, 0) = "9"
        carac(9, 1) = "----."


        'LETRAS



        carac(10, 0) = "A"
        carac(10, 1) = ".-"
        carac(11, 0) = "B"
        carac(11, 1) = "-..."
        carac(12, 0) = "C"
        carac(12, 1) = "-.-."
        carac(13, 0) = "D"
        carac(13, 1) = "-.."
        carac(14, 0) = "E"
        carac(14, 1) = "."
        carac(15, 0) = "F"
        carac(15, 1) = "..-."
        carac(16, 0) = "G"
        carac(16, 1) = "--."
        carac(17, 0) = "H"
        carac(17, 1) = "...."
        carac(18, 0) = "I"
        carac(18, 1) = ".."
        carac(19, 0) = "J"
        carac(19, 1) = ".---"
        carac(20, 0) = "K"
        carac(20, 1) = "-.-"
        carac(21, 0) = "L"
        carac(21, 1) = ".-.."
        carac(22, 0) = "M"
        carac(22, 1) = "--"
        carac(23, 0) = "N"
        carac(23, 1) = ".-"
        carac(24, 0) = "O"
        carac(24, 1) = "---"
        carac(25, 0) = "P"
        carac(25, 1) = ".--."
        carac(26, 0) = "Q"
        carac(26, 1) = "--.-"
        carac(27, 0) = "R"
        carac(27, 1) = ".-."
        carac(28, 0) = "S"
        carac(28, 1) = "..."
        carac(29, 0) = "T"
        carac(29, 1) = "-"
        carac(30, 0) = "U"
        carac(30, 1) = "..-"
        carac(31, 0) = "V"
        carac(31, 1) = "...-"
        carac(32, 0) = "W"
        carac(32, 1) = ".--"
        carac(33, 0) = "X"
        carac(33, 1) = "-..-"
        carac(34, 0) = "Y"
        carac(34, 1) = "-.--"
        carac(35, 0) = "Z"
        carac(35, 1) = "--.."
        carac(36, 0) = "Ñ"
        carac(36, 1) = "--.--"
        carac(37, 0) = " "
        carac(37, 1) = "    "

        resultado = "No hay resultado"
        For cont = 0 To 37
            If caracter = carac(cont, 0) Then
                resultado = carac(cont, 1)

            End If

        Next
        Return resultado

    End Function

    Private Sub cmd_calcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_calcular.Click
        Dim tamaño As Integer
        Dim cont2 As Integer = 0
        txt_original.Text = txt_original.Text.ToUpper

        tamaño = Len(Trim(txt_original.Text))

        For cont2 = 0 To tamaño - 1
            If cont2 >= 1 Then
                txt_resultado.Text = txt_resultado.Text + "  " + morse(txt_original.Text().Substring(cont2, 1))

            Else
                txt_resultado.Text = morse(txt_original.Text().Substring(cont2, 1))
            End If


        Next





    End Sub

    Private Sub frm_morse_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load


    End Sub
End Class

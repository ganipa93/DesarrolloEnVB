Public Class Form2
    Public opcionpais(5) As String   '
    Public opcionanimal(5) As String 'Muy Claro
    Public opcionfrutas(5) As String '
    Public i As Integer
    Public secreta As String
    Public adivina As String
    Public cont1 As Integer
    Public fallos As Integer
    Public termino As String
    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'aka muy importante a Lcategoria2 y tiene la Propiedad de Invisible
        'Le paso el valos de LCategoria de mi Form1 esto es muy importante puesto k
        'nesecito saber k opcion eligio de mi CSelceccion para poder trabajar
        Form1.Visible = False
        LCategoria2.Text = Form1.LCategoria.Text

        opcionpais(0) = "chile"
        opcionpais(1) = "uruguay"
        opcionpais(2) = "paraguay"    'Asigno 5 valores a opcionpais
        opcionpais(3) = "brazil"
        opcionpais(4) = "argentina"

        opcionanimal(0) = "zorro"
        opcionanimal(1) = "jirafa"
        opcionanimal(2) = "bufalo"    ' Lo mismo a opcionanimal
        opcionanimal(3) = "cocodrilo"
        opcionanimal(4) = "aguila"

        opcionfrutas(0) = "maracuya"
        opcionfrutas(1) = "kiwi"
        opcionfrutas(2) = "mango"     '= a opcionfrutas
        opcionfrutas(3) = "banana"
        opcionfrutas(4) = "sandia"

        'Al momento de cargar el formulario muestro la imagen inicial PictureBox1 komo Verdadera
        PictureBox6.Visible = False
        PictureBox5.Visible = False
        PictureBox4.Visible = False
        PictureBox3.Visible = False
        PictureBox2.Visible = False
        PictureBox1.Visible = True
     
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'tamaño variable k se okupara para imprimir en pantalla el largo de la cadena --> Len(opcion....(i))
        Dim tamaño As Integer
        'Si LCategoria2, k no olvidemos tiene el valor de LCategoria del Form1
        'es == a Paises se generara una palabra al azar entre las 5 opciones de opcionpais
        If LCategoria2.Text = "Paises" Then
            Randomize() 'funcion k genera palabra al azar
            Do                          ' hacemos
                i = CInt(Rnd() * 10)    ' convertir a i a entero(CInt) ya k Rnd nos devuevle un decimal 
            Loop While (i > 4)          ' mientras i(=0) sea menor a 4
            secreta = (opcionpais(i))   ' le asignamos a secreta el resultado de la palabra al zar
            tamaño = Len(opcionpais(i)) ' asignamos a tamaño un valor entero k sera el largo de la cadena
            Label3.Text = secreta       ' imprimimos la palabra secreta
            Button2.Enabled = True      ' abilitamos el botton1 ya k inicialmente esta desabilitado
            Label2.Text = "Pais"        ' Imprimimos pais
            Label6.Text = tamaño & " " & "Letras" 'imprimimos el tamaño
        End If
        'Lo mismo kon animales
        If LCategoria2.Text = "Animales" Then
            Randomize()
            Do
                i = CInt(Rnd() * 10)
            Loop While (i > 4)
            secreta = (opcionanimal(i))
            tamaño = Len(opcionanimal(i))
            Label3.Text = secreta
            Button2.Enabled = True
            Label2.Text = "Animal"
            Label6.Text = tamaño & " " & "Letras"
        End If
        'Lo mismo kon animales
        If LCategoria2.Text = "Frutas" Then
            Randomize()
            Do
                i = CInt(Rnd() * 10)
            Loop While (i > 4)
            secreta = (opcionfrutas(i))
            tamaño = Len(opcionfrutas(i))
            'Mid(opciones(i), 1, 1) = i
            Label3.Text = secreta
            Button2.Enabled = True
            Label2.Text = "Fruta"
            Label6.Text = tamaño & " " & "Letras"
        End If


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim c As Integer 'kontador
        Dim letra As String 'letra
        Dim ContFallos As Integer ' kontador de intentos fallidos
        'aka empezamos la letra k ingresamos desde teklado (TextBox)

        For c = 1 To Len(secreta) 'desde la primera hasta la ultima letra de la cadena
            letra = Mid(secreta, c, 1) 'extraemos la primera de la cadena de nuestras opcionealogo (secreta)

            If letra = LCase(TextBox1.Text) Or letra = " " Then 'si la la letra es = a la k ingresamos en Texbox1 
                adivina = gestor(c, letra, Len(secreta)) 'le pasamos nuestra letra al Gestor
                cont1 = cont1 + 1 'aumentamos 1 a este kontador pera terminar el juego en caso de ganar
            Else
                adivina = adivina & " " 'si no espacio
                ContFallos = ContFallos + 1 ' si no lo encuentra se aumenta ContFallos
            End If

        Next
        If ContFallos = Len(secreta) Then ' aqui si el ContFallos es igual al tamaño de la palabra quiere decir que no estaba en ninguno

            fallos = fallos + 1 'decalro ahora fallos como publico y en el guardo los fallos globales
            ' MsgBox("lleva " & fallos & " fallos") 'le aviso cuantos fallos lleva

            'estas son las secuencias de fotografias que se mostaran segun los fallos+ xD
            If fallos = 1 Then
                PictureBox6.Visible = False
                PictureBox5.Visible = False
                PictureBox4.Visible = False
                PictureBox3.Visible = False
                PictureBox2.Visible = False
                PictureBox1.Visible = True
            End If
            If fallos = 2 Then
                PictureBox6.Visible = False
                PictureBox5.Visible = False
                PictureBox4.Visible = False
                PictureBox3.Visible = False
                PictureBox2.Visible = True
                PictureBox1.Visible = False
            End If
            If fallos = 3 Then
                PictureBox6.Visible = False
                PictureBox5.Visible = False
                PictureBox4.Visible = False
                PictureBox3.Visible = True
                PictureBox2.Visible = False
                PictureBox1.Visible = False
            End If
            If fallos = 4 Then
                PictureBox6.Visible = False
                PictureBox5.Visible = False
                PictureBox4.Visible = True
                PictureBox3.Visible = False
                PictureBox2.Visible = False
                PictureBox1.Visible = False
            End If
            If fallos = 5 Then
                PictureBox6.Visible = False
                PictureBox5.Visible = True
                PictureBox4.Visible = False
                PictureBox3.Visible = False
                PictureBox2.Visible = False
                PictureBox1.Visible = False
            End If
            If fallos = 6 Then
                PictureBox6.Visible = True
                PictureBox5.Visible = False
                PictureBox4.Visible = False
                PictureBox3.Visible = False
                PictureBox2.Visible = False
                PictureBox1.Visible = False
            End If

        End If
        'si el cont1 es == al largo de la secreta kiere decir k ganamos y se despliega el Msg
        If cont1 = Len(secreta) Then
            If MsgBox(("GANASTE... deseas volver a jugar ??"), MsgBoxStyle.YesNo, "FELICITACIONES") = MsgBoxResult.Yes Then
                'si es Yes cerramos el Form2 y al Form1 le damos la propiedad visible = True para k se muestre
                ' ya k no olvidemos lo abiamos okultado al cargar el Form2 
                Me.Close()
                Form1.Visible = True
            Else
                Form1.Close() 'Si no kiere seguir jugando cerramos el Form1 y el actual (Form2)
                Me.Close()
            End If
        End If
        'Lo mismo en el caso de Perder
        If fallos = 6 Then
            Button1.Enabled = False
            If MsgBox("La Palabra Era " & secreta & " " & "Deseas Volver a jugar??", MsgBoxStyle.YesNo, "Perdiste") = MsgBoxResult.Yes Then
                Me.Close()
                Form1.Visible = True
            Else : Me.Close()
                Form1.Close()
            End If
        End If
        Label4.Text = adivina
        TextBox1.Text = ""
        LabelErrores.Text = fallos
    End Sub
    Private Function gestor(ByVal pos As String, ByVal letra As String, ByVal largo As Integer)
        'Nuestra funcion gestor que akomodara las letras
        'k utilizamos en el Button1
        Dim texto As String
        Dim x As Integer
        texto = ""
        For x = 1 To largo
            If x = pos Then
                texto = texto & letra
            Else
                texto = texto & Mid(adivina, x, 1)
            End If
        Next
        Return texto
    End Function

    Private Sub ButtonSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSalir.Click
        Me.Close()
        Form1.Close()
    End Sub
End Class
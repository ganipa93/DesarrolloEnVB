Public Class vusuario
    Dim idusuario As Integer
    Dim nombres, apellidos, dni, telefono, sexo, direccion, email, login, password As String
    Dim fecha_nac As Date

    Public Property gidusuario
        Get
            Return idusuario
        End Get
        Set(ByVal value)
            idusuario = value
        End Set
    End Property
    Public Property gnombres
        Get
            Return nombres
        End Get
        Set(ByVal value)
            nombres = value
        End Set
    End Property
    Public Property gapellidos
        Get
            Return apellidos

        End Get
        Set(ByVal value)
            apellidos = value
        End Set
    End Property
    Public Property gdni
        Get
            Return dni
        End Get
        Set(ByVal value)
            dni = value
        End Set
    End Property
    Public Property gfecha_nac
        Get
            Return fecha_nac
        End Get
        Set(ByVal value)
            fecha_nac = value
        End Set
    End Property
    Public Property gtelefono
        Get
            Return telefono
        End Get
        Set(ByVal value)
            telefono = value
        End Set
    End Property
    Public Property gsexo
        Get
            Return sexo
        End Get
        Set(ByVal value)
            sexo = value
        End Set
    End Property
    Public Property gdireccion
        Get
            Return direccion
        End Get
        Set(ByVal value)
            direccion = value
        End Set
    End Property
    Public Property gemail
        Get
            Return email
        End Get
        Set(ByVal value)
            email = value
        End Set
    End Property

    Public Property glogin
        Get
            Return login
        End Get
        Set(ByVal value)
            login = value
        End Set
    End Property

    Public Property gpassword
        Get
            Return password
        End Get
        Set(ByVal value)
            password = value
        End Set
    End Property


    Public Sub New()

    End Sub

    Public Sub New(ByVal idusuario As Integer, ByVal nombres As String, ByVal apellidos As String, ByVal dni As String, ByVal telefono As String, ByVal sexo As String, ByVal fecha_nac As Date, ByVal direccion As String, ByVal email As String, ByVal login As String, ByVal password As String)
        gidusuario = idusuario
        gnombres = nombres
        gapellidos = apellidos
        gdni = dni
        gtelefono = telefono
        gsexo = sexo
        gfecha_nac = fecha_nac
        gdireccion = direccion
        gemail = email
        glogin = login
        gpassword = password
    End Sub
End Class

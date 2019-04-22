Public Class vequipo
    Dim idequipo, idcliente, idusuario As Integer
    Dim nombre, marca, modelo, serie, problema_desc, estado_almacen, estado_pago, reparacion_desc, tipo_doc, num_doc As String
    Dim fecha_ingreso, fecha_salida As Date
    Dim total_pago As Double

    Public Property gidequipo
        Get
            Return idequipo
        End Get
        Set(ByVal value)
            idequipo = value
        End Set
    End Property
    Public Property gidcliente
        Get
            Return idcliente
        End Get
        Set(ByVal value)
            idcliente = value
        End Set
    End Property


    Public Property gidusuario
        Get
            Return idusuario
        End Get
        Set(ByVal value)
            idusuario = value
        End Set
    End Property
    Public Property gnombre
        Get
            Return nombre
        End Get
        Set(ByVal value)
            nombre = value
        End Set
    End Property
    Public Property gmarca
        Get
            Return marca

        End Get
        Set(ByVal value)
            marca = value
        End Set
    End Property
    Public Property gmodelo
        Get
            Return modelo
        End Get
        Set(ByVal value)
            modelo = value
        End Set
    End Property
    Public Property gserie
        Get
            Return serie
        End Get
        Set(ByVal value)
            serie = value
        End Set
    End Property
    Public Property gproblema_desc
        Get
            Return problema_desc
        End Get
        Set(ByVal value)
            problema_desc = value
        End Set
    End Property
    Public Property gestado_almacen
        Get
            Return estado_almacen
        End Get
        Set(ByVal value)
            estado_almacen = value
        End Set
    End Property
    Public Property gfecha_ingreso
        Get
            Return fecha_ingreso
        End Get
        Set(ByVal value)
            fecha_ingreso = value
        End Set
    End Property
    Public Property gestado_pago
        Get
            Return estado_pago
        End Get
        Set(ByVal value)
            estado_pago = value
        End Set
    End Property

    Public Property greparacion_desc
        Get
            Return reparacion_desc
        End Get
        Set(ByVal value)
            reparacion_desc = value
        End Set
    End Property

    Public Property gtipo_doc
        Get
            Return tipo_doc
        End Get
        Set(ByVal value)
            tipo_doc = value
        End Set
    End Property

    Public Property gnum_doc
        Get
            Return num_doc
        End Get
        Set(ByVal value)
            num_doc = value
        End Set
    End Property
    Public Property gtotal_pago
        Get
            Return total_pago
        End Get
        Set(ByVal value)
            total_pago = value
        End Set
    End Property
    Public Property gfecha_salida
        Get
            Return fecha_salida
        End Get
        Set(ByVal value)
            fecha_salida = value
        End Set
    End Property
    Public Sub New()

    End Sub

    Public Sub New(ByVal idequipo As Integer, ByVal idcliente As Integer, ByVal idusuario As Integer, ByVal nombre As String, ByVal marca As String, ByVal serie As String, ByVal modelo As String, ByVal problema_desc As String, ByVal estado_almacen As String, ByVal fecha_ingreso As Date, ByVal estado_pago As String, ByVal reparacion_desc As String, ByVal tipo_doc As String, ByVal num_doc As String, ByVal total_pago As Double, ByVal fecha_salida As Date)
        gidcliente = idcliente
        gidequipo = idequipo
        gidusuario = idusuario
        gnombre = nombre
        gmarca = marca
        gmodelo = modelo
        gserie = serie
        gproblema_desc = problema_desc
        gestado_almacen = estado_almacen
        gfecha_ingreso = fecha_ingreso
        gestado_pago = estado_pago
        greparacion_desc = reparacion_desc
        gtipo_doc = tipo_doc
        gnum_doc = num_doc
        gtotal_pago = total_pago
        gfecha_salida = fecha_salida
    End Sub
End Class

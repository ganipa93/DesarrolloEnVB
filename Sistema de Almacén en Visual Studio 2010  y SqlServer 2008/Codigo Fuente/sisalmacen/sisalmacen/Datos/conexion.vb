Imports System.Data.SqlClient
Public Class conexion
    Protected cnn As New SqlConnection 'creamos una variable para establecer la conexion con la base de datos
    'creamos la funcion para conectar con la base de datos
    Public idusuario As Integer
    Protected Function conectado()
        Try
            'creamos la cadena de conexion
            cnn = New SqlConnection("data source=(local);initial catalog=sisalmacen;integrated security=true")
            'abrimos la conexion
            cnn.Open()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
    'creamos la funcion para desconectar con la base de datos
    Protected Function desconectado()
        Try
            'si la conexion esta abierta entonces la cerramos
            If cnn.State = ConnectionState.Open Then
                cnn.Close()
                Return True
            Else
                'en caso contrario esta cerrada entonces no hacemos nada
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
End Class


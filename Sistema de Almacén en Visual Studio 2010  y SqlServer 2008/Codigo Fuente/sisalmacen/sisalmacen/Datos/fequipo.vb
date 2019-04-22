Imports System.Data.SqlClient
Public Class fequipo
    Inherits conexion
    Dim cmd As New SqlCommand
    Public Function mostrar() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("mostrar_equipo")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            desconectado()
        End Try
    End Function

    Public Function insertar(ByVal dts As vequipo) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("insertar_equipo")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@nombre", dts.gnombre)
            cmd.Parameters.AddWithValue("@marca", dts.gmarca)
            cmd.Parameters.AddWithValue("@modelo", dts.gmodelo)
            cmd.Parameters.AddWithValue("@serie", dts.gserie)
            cmd.Parameters.AddWithValue("@idcliente", dts.gidcliente)
            cmd.Parameters.AddWithValue("@problema_desc", dts.gproblema_desc)
            cmd.Parameters.AddWithValue("@estado_almacen", dts.gestado_almacen)
            cmd.Parameters.AddWithValue("@fecha_ingreso", dts.gfecha_ingreso)
            cmd.Parameters.AddWithValue("@estado_pago", dts.gestado_pago)
            cmd.Parameters.AddWithValue("@reparacion_desc", dts.greparacion_desc)
            cmd.Parameters.AddWithValue("@tipo_doc", dts.gtipo_doc)
            cmd.Parameters.AddWithValue("@num_doc", dts.gnum_doc)
            cmd.Parameters.AddWithValue("@total_pago", dts.gtotal_pago)
            cmd.Parameters.AddWithValue("@fecha_salida", dts.gfecha_salida)




            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()
        End Try
    End Function

    Public Function editar(ByVal dts As vequipo) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("editar_equipo")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@idequipo", dts.gidequipo)
            cmd.Parameters.AddWithValue("@nombre", dts.gnombre)
            cmd.Parameters.AddWithValue("@marca", dts.gmarca)
            cmd.Parameters.AddWithValue("@modelo", dts.gmodelo)
            cmd.Parameters.AddWithValue("@serie", dts.gserie)
            cmd.Parameters.AddWithValue("@idcliente", dts.gidcliente)
            cmd.Parameters.AddWithValue("@problema_desc", dts.gproblema_desc)
            cmd.Parameters.AddWithValue("@estado_almacen", dts.gestado_almacen)
            cmd.Parameters.AddWithValue("@fecha_ingreso", dts.gfecha_ingreso)
            cmd.Parameters.AddWithValue("@estado_pago", dts.gestado_pago)
            cmd.Parameters.AddWithValue("@reparacion_desc", dts.greparacion_desc)
            cmd.Parameters.AddWithValue("@tipo_doc", dts.gtipo_doc)
            cmd.Parameters.AddWithValue("@num_doc", dts.gnum_doc)
            cmd.Parameters.AddWithValue("@total_pago", dts.gtotal_pago)
            cmd.Parameters.AddWithValue("@fecha_salida", dts.gfecha_salida)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()
        End Try
    End Function

    Public Function eliminar(ByVal dts As vequipo) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("eliminar_equipo")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.Add("@idequipo", SqlDbType.NVarChar, 50).Value = dts.gidequipo
            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()
        End Try

    End Function
End Class

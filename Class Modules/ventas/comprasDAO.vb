Imports MySql.Data.MySqlClient

Public Class comprasDAO
    Implements ComprasInterfaces

    Private myConnection As MySqlConnection

    Public Sub New(myConnection As MySqlConnection)
        Me.myConnection = myConnection

    End Sub

    Public Function RealizarCompra(fecha As DateTime, cantidad As Integer, idProducto As Integer, idCliente As Integer) As Integer Implements ComprasInterfaces.RealizarCompra
        Try
            Using glCommand As New MySqlCommand("SP_RealizarCompra", myConnection)
                glCommand.Parameters.AddWithValue("@fecha_param", fecha)
                glCommand.Parameters.AddWithValue("@cantidad_param", cantidad)
                glCommand.Parameters.AddWithValue("@producto_param", idProducto)
                glCommand.Parameters.AddWithValue("@cliente_param", idCliente)

                glCommand.Parameters.Add("@id_compra", MySqlDbType.Int32)
                glCommand.Parameters("@id_compra").Direction = ParameterDirection.Output


                glCommand.CommandType = CommandType.StoredProcedure

                myConnection.Open()
                glCommand.ExecuteNonQuery()

                ' Obtener el valor de salida (id_compra)
                Dim idCompra As Integer = Convert.ToInt32(glCommand.Parameters("@id_compra").Value)

                Return idCompra
            End Using
        Catch ex As Exception
            Throw New Exception($"Error al realizar la compra. Procedimiento: SP_RealizarCompra. Detalles: {ex.Message}", ex)
        Finally
            If myConnection.State = ConnectionState.Open Then
                myConnection.Close()
            End If
        End Try
    End Function



    Public Function ObtenerProductos() As DataTable Implements ComprasInterfaces.ObtenerProductos
        Try
            Using glCommand As New MySqlCommand("SELECT p.id_producto, p.nombre as NombreProducto, p.precio_unit as Precio, m.nombre as Marca, c.nombre as Categoria FROM producto p JOIN marca m ON p.marca_id = m.id_marca JOIN categoria c ON p.categoria_id = c.id_categoria", myConnection)
                glCommand.CommandType = CommandType.Text

                Using adapter As New MySqlDataAdapter(glCommand)
                    Dim dataTable As New DataTable()
                    adapter.Fill(dataTable)
                    Return dataTable
                End Using
            End Using
        Catch ex As Exception
            Throw New Exception("Error al obtener los productos", ex)
        End Try
    End Function




    Public Function ObtenerClientes() As DataTable Implements ComprasInterfaces.ObtenerClientes
        Try
            Using glCommand As New MySqlCommand("SELECT id_cliente, nombre, apellido, cedula, empresa_id, genero, tipo, foto, telefono, detalles FROM cliente", myConnection)
                glCommand.CommandType = CommandType.Text

                Using adapter As New MySqlDataAdapter(glCommand)
                    Dim dataTable As New DataTable()
                    adapter.Fill(dataTable)
                    Return dataTable
                End Using
            End Using
        Catch ex As Exception
            Throw New Exception("Error al obtener los clientes", ex)
        End Try
    End Function

    Public Function ObtenerPedidos() As DataTable
        Try
            Using glCommand As New MySqlCommand("SP_ObtenerPedidos", myConnection)
                glCommand.CommandType = CommandType.StoredProcedure

                Using adapter As New MySqlDataAdapter(glCommand)
                    Dim dataTable As New DataTable()
                    adapter.Fill(dataTable)
                    Return dataTable
                End Using
            End Using
        Catch ex As Exception
            Throw New Exception("Error al obtener los pedidos", ex)
        End Try
    End Function

    Public Function ObtenerDetalleVenta(pedidoId As Integer) As DataTable
        Try
            Using glCommand As New MySqlCommand("SP_ObtenerDetalleVenta", myConnection)
                glCommand.CommandType = CommandType.StoredProcedure
                glCommand.Parameters.AddWithValue("@pedidoIdParam", pedidoId)

                Using adapter As New MySqlDataAdapter(glCommand)
                    Dim dataTable As New DataTable()
                    adapter.Fill(dataTable)
                    Return dataTable
                End Using
            End Using
        Catch ex As Exception
            Throw New Exception($"Error al obtener detalles del pedido. Procedimiento: SP_ObtenerDetalleVenta. Detalles: {ex.Message}", ex)
        End Try
    End Function
    Public Function ObtenerEstadosPedido() As DataTable
        Try
            Using glCommand As New MySqlCommand("SELECT * FROM pedido_estado", myConnection)
                glCommand.CommandType = CommandType.Text

                Using adapter As New MySqlDataAdapter(glCommand)
                    Dim dataTable As New DataTable()
                    adapter.Fill(dataTable)
                    Return dataTable
                End Using
            End Using
        Catch ex As Exception
            Throw New Exception("Error al obtener los estados del pedido", ex)
        End Try
    End Function

    Public Sub ActualizarEstadoPedido(idPedido As Integer, nuevoEstado As String)
        Try
            ' Obtener la fecha actual
            Dim fechaCambioEstado As DateTime = DateTime.Now

            Using glCommand As New MySqlCommand("UPDATE pedido SET estado_id = (SELECT id_pedido_estado FROM pedido_estado WHERE estado = @nuevoEstado), fecha_cambio_estado = @fechaCambioEstado WHERE id_pedido = @idPedido", myConnection)
                glCommand.Parameters.AddWithValue("@nuevoEstado", nuevoEstado)
                glCommand.Parameters.AddWithValue("@idPedido", idPedido)
                glCommand.Parameters.AddWithValue("@fechaCambioEstado", fechaCambioEstado)

                glCommand.CommandType = CommandType.Text

                myConnection.Open()
                glCommand.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            Throw New Exception($"Error al actualizar el estado del pedido. Detalles: {ex.Message}", ex)
        Finally
            If myConnection.State = ConnectionState.Open Then
                myConnection.Close()
            End If
        End Try
    End Sub
    Public Function ObtenerIdCliente(pedidoId As Integer) As Integer
        Try
            Using glCommand As New MySqlCommand("SELECT cliente_id FROM pedido WHERE id_pedido = @pedidoId", myConnection)
                glCommand.Parameters.AddWithValue("@pedidoId", pedidoId)

                Dim result As Object = glCommand.ExecuteScalar()

                If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
                    Return Convert.ToInt32(result)
                Else
                    ' Manejar el caso donde no se encuentra el ID del cliente
                    Return 0
                End If
            End Using
        Catch ex As Exception
            Throw New Exception($"Error al obtener el ID del cliente. Detalles: {ex.Message}", ex)
        End Try
    End Function
    Public Function ObtenerFormasPago() As DataTable
        Try
            Using glCommand As New MySqlCommand("SELECT id_forma_pago, nombre FROM forma_pago", myConnection)
                glCommand.CommandType = CommandType.Text

                Using adapter As New MySqlDataAdapter(glCommand)
                    Dim dataTable As New DataTable()
                    adapter.Fill(dataTable)
                    Return dataTable
                End Using
            End Using
        Catch ex As MySqlException
            ' Captura específicamente excepciones relacionadas con MySQL
            Throw New Exception("Error al obtener las formas de pago de la base de datos.", ex)
        Catch ex As Exception
            ' Captura otras excepciones no relacionadas con MySQL
            Throw New Exception("Error general al obtener las formas de pago.", ex)
        End Try
    End Function



    Public Function ObtenerDeudaActual(pedidoId As Integer) As Decimal
        Dim query As String = "SELECT SUM(monto) FROM pago WHERE pedido_id = @pedidoId"
        Try
            Using cmd As New MySqlCommand(query, myConnection)
                cmd.Parameters.AddWithValue("@pedidoId", pedidoId)
                myConnection.Open()
                Dim result As Object = cmd.ExecuteScalar()

                ' Verificar si el resultado no es nulo o DBNull.Value antes de convertirlo
                If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
                    Return Convert.ToDecimal(result)
                Else
                    ' Devolver 0 si el resultado es nulo o DBNull.Value
                    Return 0
                End If
            End Using
        Catch ex As MySqlException
            ' Captura específicamente excepciones relacionadas con MySQL
            Throw New Exception("Error al obtener la deuda actual de la base de datos.", ex)
        Catch ex As Exception
            ' Captura otras excepciones no relacionadas con MySQL
            Throw New Exception("Error general al obtener la deuda actual.", ex)
        Finally
            If myConnection.State = ConnectionState.Open Then
                myConnection.Close()
            End If
        End Try
    End Function


    Public Function RegistrarPago(pedidoId As Integer, monto As Decimal, fecha As DateTime, formaPagoId As Integer) As Integer
        Dim query As String = "INSERT INTO pago (pedido_id, monto, fecha, forma_pago_id) VALUES (@pedidoId, @monto, @fecha, @formaPagoId); SELECT LAST_INSERT_ID();"
        Try
            Using cmd As New MySqlCommand(query, myConnection)
                cmd.Parameters.AddWithValue("@pedidoId", pedidoId)
                cmd.Parameters.AddWithValue("@monto", monto)
                cmd.Parameters.AddWithValue("@fecha", fecha)
                cmd.Parameters.AddWithValue("@formaPagoId", formaPagoId)
                myConnection.Open()
                Return Convert.ToInt32(cmd.ExecuteScalar())
            End Using
        Catch ex As MySqlException
            ' Captura específicamente excepciones relacionadas con MySQL
            Throw New Exception("Error al registrar el pago en la base de datos.", ex)
        Catch ex As Exception
            ' Captura otras excepciones no relacionadas con MySQL
            Throw New Exception("Error general al registrar el pago.", ex)
        Finally
            If myConnection.State = ConnectionState.Open Then
                myConnection.Close()
            End If
        End Try
    End Function

    Public Function ObtenerPagos(pedidoId As Integer) As DataTable
        Dim query As String = "SELECT monto, fecha, nombre AS forma_pago FROM pago INNER JOIN forma_pago ON pago.forma_pago_id = forma_pago.id_forma_pago WHERE pedido_id = @pedidoId"
        Try
            Using cmd As New MySqlCommand(query, myConnection)
                cmd.Parameters.AddWithValue("@pedidoId", pedidoId)
                Using adapter As New MySqlDataAdapter(cmd)
                    Dim dataTable As New DataTable()
                    adapter.Fill(dataTable)
                    Return dataTable
                End Using
            End Using
        Catch ex As MySqlException
            ' Captura específicamente excepciones relacionadas con MySQL
            Throw New Exception("Error al obtener los pagos de la base de datos.", ex)
        Catch ex As Exception
            ' Captura otras excepciones no relacionadas con MySQL
            Throw New Exception("Error general al obtener los pagos.", ex)
        End Try
    End Function

    Public Sub EliminarPedido(idPedido As Integer)
        Try
            Using glCommand As New MySqlCommand("DELETE FROM pedido WHERE id_pedido = @idPedido", myConnection)
                glCommand.Parameters.AddWithValue("@idPedido", idPedido)
                glCommand.CommandType = CommandType.Text

                myConnection.Open()
                glCommand.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            Throw New Exception($"Error al eliminar el pedido. Detalles: {ex.Message}", ex)
        Finally
            If myConnection.State = ConnectionState.Open Then
                myConnection.Close()
            End If
        End Try
    End Sub


End Class

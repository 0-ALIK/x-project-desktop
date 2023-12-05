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

                glCommand.CommandType = CommandType.StoredProcedure

                myConnection.Open()
                Return Convert.ToInt32(glCommand.ExecuteScalar())
            End Using
        Catch ex As Exception
            Throw New Exception("Error al realizar la compra", ex)
        Finally
            myConnection.Close()
        End Try
    End Function

    Public Function ObtenerProductos() As DataTable Implements ComprasInterfaces.ObtenerProductos
        Try
            Using glCommand As New MySqlCommand("SP_ObtenerProductos", myConnection)
                glCommand.CommandType = CommandType.StoredProcedure

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
            Using glCommand As New MySqlCommand("SP_ObtenerClientes", myConnection)
                glCommand.CommandType = CommandType.StoredProcedure

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
End Class

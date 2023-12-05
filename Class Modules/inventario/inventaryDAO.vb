Imports System.Data.SqlClient
Imports System.IO
Imports MySql.Data.MySqlClient
Public Class inventaryDAO
    Implements inventaryInterfaces

    Private myConecctionDB As MySqlConnection

    Public Sub New(myConnection As MySqlConnection)
        Me.myConecctionDB = myConnection
    End Sub

    'Select que despliega todos los productos del inventario

    Public Function VerInventario() As DataTable Implements inventaryInterfaces.VerInventario
        Try
            Using glCommand As New MySqlCommand("SP_VerInventario", myConnectionDB)
                glCommand.CommandTimeout = 0
                glCommand.CommandType = CommandType.StoredProcedure

                Using adapter As New MySqlDataAdapter(glCommand)
                    Dim datatable As New DataTable()
                    adapter.Fill(datatable)
                    Return datatable
                End Using
            End Using
        Catch ex As Exception
            Throw New Exception("Error al procesar la operacion:", ex)
        End Try
    End Function

    'Select -> Productos

    Public Function VerProductos() As DataTable Implements inventaryInterfaces.VerProductos
        Try
            Using glCommand As New MySqlCommand("SP_VerProductos", myConnectionDB)
                glCommand.CommandTimeout = 0
                glCommand.CommandType = CommandType.StoredProcedure


            End Using
        Catch ex As Exception
            Throw New Exception("Error al procesar la operacion:", ex)
        End Try
    End Function

    'Insert -> Productos

    Public Function InsertarProducto(nombre As String, precioUnitario As Decimal, cantidadPorCajas As Integer?, puntoReorden As Integer?, cantidadCajas As Integer?, marcaId As Integer, categoriaId As Integer, imagen As Image) As Boolean Implements inventaryInterfaces.InsertarProducto
        Try
            myConnectionDB.Open()

            Using glCommand As New MySqlCommand("SP_InsertarProductos", myConnectionDB)
                glCommand.CommandType = CommandType.StoredProcedure

                glCommand.Parameters.AddWithValue("@p_nombre", nombre)
                glCommand.Parameters.AddWithValue("@p_precio_unit", precioUnitario)
                glCommand.Parameters.AddWithValue("@p_cantidad_por_cajas", If(cantidadPorCajas.HasValue, cantidadPorCajas.Value, DBNull.Value))
                glCommand.Parameters.AddWithValue("@p_punto_reorden", If(puntoReorden.HasValue, puntoReorden.Value, DBNull.Value))
                glCommand.Parameters.AddWithValue("@p_cantidad_cajas", If(cantidadCajas.HasValue, cantidadCajas.Value, DBNull.Value))
                glCommand.Parameters.AddWithValue("@p_marca_id", marcaId)
                glCommand.Parameters.AddWithValue("@p_categoria_id", categoriaId)

                ' Convertir la imagen a un arreglo de bytes
                Dim photoBytes As Byte() = Nothing
                If imagen IsNot Nothing Then
                    Using ms As New MemoryStream()
                        imagen.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
                        photoBytes = ms.ToArray()
                    End Using
                End If

                ' Agregar el parámetro para la imagen
                glCommand.Parameters.AddWithValue("@p_imagen", If(photoBytes IsNot Nothing, photoBytes, DBNull.Value))

                ' Ejecutar el procedimiento almacenado
                glCommand.ExecuteNonQuery()

                Return True
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al agregar el producto: " & ex.Message)
            Return False
        Finally
            ' Cerrar la conexión a la base de datos
            myConnectionDB.Close()
        End Try
    End Function

    'Update -> Productos

    Public Function ActualizarProducto() As Integer Implements inventaryInterfaces.ActualizarProducto
        Try
            Using glCommand As New MySqlCommand("SP_ActualizarProducto", myConnectionDB)
                glCommand.CommandTimeout = 0
                glCommand.CommandType = CommandType.StoredProcedure


            End Using
        Catch ex As Exception
            Throw New Exception("Error al procesar la operacion:", ex)
        End Try
    End Function

    'Delete -> Productos

    Public Function EliminarProducto(idProducto As Integer) As Integer Implements inventaryInterfaces.EliminarProducto
        Try
            Using glCommand As New MySqlCommand("SP_EliminarProducto", myConecctionDB)
                glCommand.CommandType = CommandType.StoredProcedure
                glCommand.Parameters.AddWithValue("@id", idProducto)
                Return glCommand.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            Throw New Exception("Error al procesar la operacion:", ex)
        End Try
    End Function


    'Select -> Marcas

    Public Function VerMarcas() As DataTable Implements inventaryInterfaces.VerMarcas
        Try
            Using glCommand As New MySqlCommand("SP_VerMarcas", myConnectionDB)
                glCommand.CommandTimeout = 0
                glCommand.CommandType = CommandType.StoredProcedure

                Using adapter As New MySqlDataAdapter(glCommand)
                    Dim datatable As New DataTable()
                    adapter.Fill(datatable)
                    Return datatable
                End Using
            End Using
        Catch ex As Exception
            Throw New Exception("Error al procesar la operacion:", ex)
        End Try
    End Function

    'Insert -> Marcas

    Public Function InsertarMarca(ByVal nombre As String, ByVal descripcion As String, ByVal logo As String) As Integer Implements inventaryInterfaces.InsertarMarca
        Dim resultado As Integer = 0

        Try
            Using glCommand As New MySqlCommand("SP_InsertarMarcas", myConecctionDB)
                glCommand.CommandTimeout = 0
                glCommand.CommandType = CommandType.StoredProcedure
                glCommand.Parameters.AddWithValue("nombre", nombre)
                glCommand.Parameters.AddWithValue("descripcion", descripcion)
                glCommand.Parameters.AddWithValue("logo", logo)
                'glCommand.Parameters.AddWithValue("resultado", MySqlDbType.Int32)

                myConecctionDB.Open()

                resultado = glCommand.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            Throw New Exception("Error al insertar la marca: " & ex.Message)
        Finally
            If myConecctionDB.State <> ConnectionState.Closed Then myConecctionDB.Close()
        End Try
    End Function

    'Update -> Marcas

    Public Function ActualizarMarca() As Integer Implements inventaryInterfaces.ActualizarMarca
        Try
            Using glCommand As New MySqlCommand("SP_ActualizarMarca", myConnectionDB)
                glCommand.CommandTimeout = 0
                glCommand.CommandType = CommandType.StoredProcedure


            End Using
        Catch ex As Exception
            Throw New Exception("Error al procesar la operacion:", ex)
        End Try
    End Function

    'Delete -> Marcas

    Public Function EliminarMarca() As Integer Implements inventaryInterfaces.EliminarMarca
        Try
            Using glCommand As New MySqlCommand("SP_EliminarMarca", myConnectionDB)
                glCommand.CommandTimeout = 0
                glCommand.CommandType = CommandType.StoredProcedure


            End Using
        Catch ex As Exception
            Throw New Exception("Error al procesar la operacion:", ex)
        End Try
    End Function

    'Select -> Categorias

    Public Function VerCategorias() As DataTable Implements inventaryInterfaces.VerCategorias
        Try
            Using glCommand As New MySqlCommand("SP_VerCategorias", myConnectionDB)
                glCommand.CommandTimeout = 0
                glCommand.CommandType = CommandType.StoredProcedure


            End Using
        Catch ex As Exception
            Throw New Exception("Error al procesar la operacion:", ex)
        End Try
    End Function

    'Insert -> Categorias

    Public Function InsertaCategorias() As Integer Implements inventaryInterfaces.InsertaCategorias
        Try
            Using glCommand As New MySqlCommand("SP_InsertaCategorias", myConnectionDB)
                glCommand.CommandTimeout = 0
                glCommand.CommandType = CommandType.StoredProcedure


            End Using
        Catch ex As Exception
            Throw New Exception("Error al procesar la operacion:", ex)
        End Try
    End Function

    'Update -> Categorias

    Public Function ActualizarCategorias() As Integer Implements inventaryInterfaces.ActualizarCategorias
        Try
            Using glCommand As New MySqlCommand("SP_ActualizarCategorias", myConnectionDB)
                glCommand.CommandTimeout = 0
                glCommand.CommandType = CommandType.StoredProcedure


            End Using
        Catch ex As Exception
            Throw New Exception("Error al procesar la operacion:", ex)
        End Try
    End Function

    'Delete -> Categorias

    Public Function EliminarCategorias(idCategoria As Integer) As Integer Implements inventaryInterfaces.EliminarCategorias
        Try
            Using glCommand As New MySqlCommand("SP_EliminarCategorias", myConecctionDB)
                glCommand.CommandType = CommandType.StoredProcedure
                glCommand.Parameters.AddWithValue("@id", idCategoria)
                Return glCommand.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            Throw New Exception("Error al procesar la operacion:", ex)
        End Try
    End Function

End Class
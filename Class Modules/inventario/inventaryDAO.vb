﻿Imports System.IO
Imports Microsoft.VisualBasic.Logging
Imports MySql.Data.MySqlClient
Public Class inventaryDAO
    Implements inventaryInterfaces

    Private myConecctionDB As MySqlConnection

    Public Sub New(myConnection As MySqlConnection)
        Me.myConecctionDB = myConnection
    End Sub

    'Select -> Productos

    Public Function VerProductos() As DataTable Implements inventaryInterfaces.VerProductos
        Try
            Using glCommand As New MySqlCommand("SP_VerProductos", myConnectionDB)
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

    'Insert -> Productos

    Public Function InsertarProducto(nombre As String, precioUnitario As Decimal, cantidadPorCajas As Integer?, puntoReorden As Integer?, cantidadCajas As Integer?, marcaId As Integer, categoriaId As Integer, imagen As String) As Boolean Implements inventaryInterfaces.InsertarProducto
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

                ' Agregar el parámetro para la imagen
                glCommand.Parameters.AddWithValue("@p_imagen", If(imagen IsNot Nothing, imagen, DBNull.Value))

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

    ' Select -> marca

    Public Function ObtenerMarca(ByVal id_marca As Integer) As DataTable Implements inventaryInterfaces.ObtenerMarca
        Try
            Using glCommand As New MySqlCommand("SP_ObtenerMarca", myConnectionDB)
                glCommand.CommandTimeout = 0
                glCommand.CommandType = CommandType.StoredProcedure
                glCommand.Parameters.AddWithValue("marca_id", id_marca)

                Using adapter As New MySqlDataAdapter(glCommand)
                    Dim datatable As New DataTable()
                    adapter.Fill(datatable)
                    Return datatable
                End Using
            End Using
        Catch ex As Exception
            Throw New Exception("No se pudo obtener la marca especificada", ex)
        Finally
            If myConecctionDB.State <> ConnectionState.Closed Then myConecctionDB.Close()
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

    Public Function ActualizarMarca(ByVal id As Integer, ByVal nombre As String, ByVal descripcion As String, ByVal logo As String) As Integer Implements inventaryInterfaces.ActualizarMarca
        Dim resultado As Integer = 0

        Try
            Using glCommand As New MySqlCommand("SP_ActualizarMarcas", myConecctionDB)
                glCommand.CommandTimeout = 0
                glCommand.CommandType = CommandType.StoredProcedure
                glCommand.Parameters.AddWithValue("p_id_marca", id)
                glCommand.Parameters.AddWithValue("p_nombre", nombre)
                glCommand.Parameters.AddWithValue("p_descripcion", descripcion)
                glCommand.Parameters.AddWithValue("p_logo", logo)

                myConecctionDB.Open()

                resultado = glCommand.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            Throw New Exception("Error al actualizar la marca: " & ex.Message)
        Finally
            If myConecctionDB.State <> ConnectionState.Closed Then myConecctionDB.Close()
        End Try
    End Function

    'BuscarProductosAsociadosAMarca

    Public Function TieneProductosAsociados(idMarca As Integer) As Boolean Implements inventaryInterfaces.TieneProductosAsociados
        Try
            Using glCommand As New MySqlCommand("SP_TieneProductosAsociados", myConnectionDB)
                glCommand.CommandType = CommandType.StoredProcedure

                ' Agregar parámetros al comando
                glCommand.Parameters.AddWithValue("@idMarca", idMarca)
                glCommand.Parameters.Add("@tieneProductos", MySqlDbType.Bit)
                glCommand.Parameters("@tieneProductos").Direction = ParameterDirection.Output

                ' Abrir la conexión a la base de datos
                myConnectionDB.Open()

                ' Ejecutar el procedimiento almacenado
                glCommand.ExecuteNonQuery()

                ' Obtener el resultado del parámetro de salida
                Dim tieneProductos As Boolean = Convert.ToBoolean(glCommand.Parameters("@tieneProductos").Value)
                Return tieneProductos
            End Using
        Catch ex As Exception
            ' Manejar errores
            Throw New Exception("Error al procesar la operación:", ex)
        Finally
            ' Cerrar la conexión en el bloque Finally
            If myConnectionDB.State <> ConnectionState.Closed Then myConnectionDB.Close()
        End Try
    End Function


    'Delete -> Marcas

    Public Function EliminarMarca(idMarca As Integer) As Integer Implements inventaryInterfaces.EliminarMarca
        Try
            Using glCommand As New MySqlCommand("SP_EliminarMarca", myConecctionDB)
                glCommand.CommandType = CommandType.StoredProcedure
                glCommand.Parameters.AddWithValue("@id", idMarca)
                Return glCommand.ExecuteNonQuery()
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

    'Insert -> Categorias

    Public Function InsertaCategorias(ByVal nombre As String) As Integer Implements inventaryInterfaces.InsertaCategorias
        Dim resultado As Integer = 0
        Try
            Using glCommand As New MySqlCommand("SP_InsertarCategorias", myConecctionDB)
                glCommand.CommandTimeout = 0
                glCommand.CommandType = CommandType.StoredProcedure
                glCommand.Parameters.AddWithValue("nombre", nombre)

                myConecctionDB.Open()

                resultado = glCommand.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            Throw New Exception("Error al insertar la marca: " & ex.Message)
        Finally
            If myConecctionDB.State <> ConnectionState.Closed Then myConecctionDB.Close()
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
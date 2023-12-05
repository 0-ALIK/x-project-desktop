Imports System.IO
Imports Microsoft.VisualBasic.Logging
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

    Public Function InsertarProducto() As Integer Implements inventaryInterfaces.InsertarProducto
        Try
            Using glCommand As New MySqlCommand("SP_InsertarProducto", myConnectionDB)
                glCommand.CommandTimeout = 0
                glCommand.CommandType = CommandType.StoredProcedure


            End Using
        Catch ex As Exception
            Throw New Exception("Error al procesar la operacion:", ex)
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

    Public Function EliminarProducto() As Integer Implements inventaryInterfaces.EliminarProducto
        Try
            Using glCommand As New MySqlCommand("SP_EliminarProducto", myConnectionDB)
                glCommand.CommandTimeout = 0
                glCommand.CommandType = CommandType.StoredProcedure


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


            End Using
        Catch ex As Exception
            Throw New Exception("Error al procesar la operacion:", ex)
        End Try
    End Function

    'Insert -> Marcas

    Public Function InsertarMarca() As Integer Implements inventaryInterfaces.InsertarMarca
        Try
            Using glCommand As New MySqlCommand("SP_InsertarMarca", myConnectionDB)
                glCommand.CommandTimeout = 0
                glCommand.CommandType = CommandType.StoredProcedure


            End Using
        Catch ex As Exception
            Throw New Exception("Error al procesar la operacion:", ex)
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

    Public Function EliminarCategorias() As Integer Implements inventaryInterfaces.EliminarCategorias
        Try
            Using glCommand As New MySqlCommand("SP_VerCategorias", myConnectionDB)
                glCommand.CommandTimeout = 0
                glCommand.CommandType = CommandType.StoredProcedure


            End Using
        Catch ex As Exception
            Throw New Exception("Error al procesar la operacion:", ex)
        End Try
    End Function

End Class
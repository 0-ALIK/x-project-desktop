Imports MySql.Data.MySqlClient

Public Class analiticaReporteInventarioDAO
    Implements analitycReporteInterfaces

    Private myConnection As MySqlConnection

    Public Sub New(myConnection As MySqlConnection)
        Me.myConnection = myConnection
    End Sub
    '
    'Metodos para Reportes de Inventario
    Public Function ObtenerInventarioSegmentado(id_marca As Integer, id_categoria As Integer) As DataTable Implements analitycReporteInterfaces.ObtenerInventarioSegmentado
        Try
            Dim marcaParam As Object = If(id_marca = 0, DBNull.Value, id_marca)
            Dim categoriaParam As Object = If(id_categoria = 0, DBNull.Value, id_categoria)
            Using glCommand As New MySqlCommand("SP_ObtenerReporteInventario", myConnectionDB)
                glCommand.Parameters.AddWithValue("@marca_id_param", marcaParam)
                glCommand.Parameters.AddWithValue("@categoria_id_param", categoriaParam)
                glCommand.CommandTimeout = 0
                glCommand.CommandType = CommandType.StoredProcedure

                Using adapter As New MySqlDataAdapter(glCommand)
                    Dim dataTable As New DataTable()
                    adapter.Fill(dataTable)
                    Return dataTable
                End Using
            End Using
        Catch ex As Exception
            Throw New Exception("Error al Obtener el Inventario", ex)
            Throw New NotImplementedException()
        End Try
    End Function

    Public Function ObtenerMarcas() As DataTable Implements analitycReporteInterfaces.ObtenerMarcas
        Try
            Using glCommand As New MySqlCommand("SP_ObtenerMarcas", myConnectionDB)
                glCommand.CommandTimeout = 0
                glCommand.CommandType = CommandType.StoredProcedure

                Using adapter As New MySqlDataAdapter(glCommand)
                    Dim dataTable As New DataTable()
                    adapter.Fill(dataTable)
                    Return dataTable
                End Using
            End Using
        Catch ex As Exception
            Throw New Exception("Error al obtener las marcas", ex)
        End Try

    End Function

    Public Function ObtenerCategorias() As DataTable Implements analitycReporteInterfaces.ObtenerCategorias
        Try
            Using glCommand As New MySqlCommand("SP_ObtenerCategorias", myConnectionDB)
                glCommand.CommandTimeout = 0
                glCommand.CommandType = CommandType.StoredProcedure

                Using adapter As New MySqlDataAdapter(glCommand)
                    Dim dataTable As New DataTable()
                    adapter.Fill(dataTable)
                    Return dataTable
                End Using
            End Using
        Catch ex As Exception
            Throw New Exception("Error al obtener las categorías", ex)
        End Try
    End Function

    Public Function ExportarExcel(dgv As DataGridView) As Integer Implements analitycReporteInterfaces.ExportarExcel
        Try
            Dim resultado = 0
            ExportarArchivos.ExportarAExcel(dgv)
            Return resultado
        Catch ex As Exception
            Throw New Exception("Algo fallo en la exportación a Excel", ex)
            MsgBox(ex.Message)
        End Try
    End Function
    '
    ' Metodos para Reportes de Cliente
    '
    Public Function ObtenerClientesYCompras(id_provincia As Object, id_producto As Object) As DataTable Implements analitycReporteInterfaces.ObtenerClientesYCompras
        Try
            Dim provinciaParam As Object = If(id_provincia = 0, DBNull.Value, id_provincia)
            Dim productoParam As Object = If(id_producto = 0, DBNull.Value, id_producto)
            Using glCommand As New MySqlCommand("SP_ObtenerClientesYCompras", myConnectionDB)
                glCommand.Parameters.AddWithValue("@provincia_id", provinciaParam)
                glCommand.Parameters.AddWithValue("@producto_id", productoParam)
                glCommand.CommandTimeout = 0
                glCommand.CommandType = CommandType.StoredProcedure

                Using adapter As New MySqlDataAdapter(glCommand)
                    Dim dataTable As New DataTable()
                    adapter.Fill(dataTable)
                    Return dataTable
                End Using
            End Using
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Throw New NotImplementedException()
        End Try
    End Function

    Public Function ObtenerProductos() As DataTable Implements analitycReporteInterfaces.ObtenerProductos
        Try
            Using glCommand As New MySqlCommand("SP_ObtenerProductos", myConnectionDB)
                glCommand.CommandTimeout = 0
                glCommand.CommandType = CommandType.StoredProcedure

                Using adapter As New MySqlDataAdapter(glCommand)
                    Dim dataTable As New DataTable()
                    adapter.Fill(dataTable)
                    Return dataTable
                End Using
            End Using
        Catch ex As Exception
            Throw New Exception("Error al obtener los Productos", ex)
        End Try
    End Function

    Public Function ObtenerProvincias() As DataTable Implements analitycReporteInterfaces.ObtenerProvincias
        Try
            Using glCommand As New MySqlCommand("SP_ObtenerProvincias", myConnectionDB)
                glCommand.CommandTimeout = 0
                glCommand.CommandType = CommandType.StoredProcedure

                Using adapter As New MySqlDataAdapter(glCommand)
                    Dim dataTable As New DataTable()
                    adapter.Fill(dataTable)
                    Return dataTable
                End Using
            End Using
        Catch ex As Exception
            Throw New Exception("Error al obtener las provincias", ex)
        End Try
    End Function
End Class

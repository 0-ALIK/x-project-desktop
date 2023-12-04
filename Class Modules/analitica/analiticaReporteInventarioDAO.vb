Imports MySql.Data.MySqlClient

Public Class analiticaReporteInventarioDAO
    Implements analitycInterfaces

    Private myConnection As MySqlConnection

    Public Sub New(myConnection As MySqlConnection)
        Me.myConnection = myConnection
    End Sub

    Public Function ObtenerInventarioSegmentado(id_marca As Integer, id_categoria As Integer) As DataTable Implements analitycInterfaces.ObtenerInventarioSegmentado
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

    Public Function ObtenerMarcas() As DataTable Implements analitycInterfaces.ObtenerMarcas
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

    Public Function ObtenerCategorias() As DataTable Implements analitycInterfaces.ObtenerCategorias
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



    Public Function ExportarExcel(dgv As DataGridView) As Integer Implements analitycInterfaces.ExportarExcel
        Try
            Dim resultado = 0
            ExportarArchivos.ExportarAExcel(dgv)
            Return resultado
        Catch ex As Exception
            Throw New Exception("Algo fallo en la exportación a Excel", ex)
            MsgBox(ex.Message)
        End Try
    End Function

End Class

﻿Imports MySql.Data.MySqlClient
Imports Mysqlx.XDevAPI.Common
Public Class ticketsDAO
    Implements ticketsInterfaces
    Private myConecctionDB As MySqlConnection
    Public Sub New(myConnection As MySqlConnection)
        Me.myConecctionDB = myConnection
    End Sub
    Public Function ObtenerReclamos() As DataTable Implements ticketsInterfaces.ObtenerReclamos
        Try
            Using glCommand As New MySqlCommand("SP_ObtenerReclamos", myConecctionDB)
                glCommand.CommandTimeout = 0
                glCommand.CommandType = CommandType.StoredProcedure
                Using adapter As New MySqlDataAdapter(glCommand)
                    Dim dtReclamos As New DataTable()
                    adapter.Fill(dtReclamos)
                    Return dtReclamos
                End Using
            End Using
        Catch ex As Exception
            Throw New Exception("Error al procesar la operación", ex)
        Finally
            If myConecctionDB.State <> ConnectionState.Closed Then myConecctionDB.Close()
        End Try
    End Function

    Public Function InsertarTicket(ByVal categoriaId As Integer, ByVal descripcion As String, ByVal prioridadId As Integer, ByVal rutaImagen As String) As Integer Implements ticketsInterfaces.InsertarTicket
        Dim resultado As Integer = 0
        Try
            Using glCommand As New MySqlCommand("SP_InsertarTicket", myConecctionDB)
                glCommand.CommandTimeout = 0
                glCommand.CommandType = CommandType.StoredProcedure
                glCommand.Parameters.AddWithValue("@p_usuario_id", 1) 'de ejemplo, primero crear un cuenta usuario, luego una de admin.
                glCommand.Parameters.AddWithValue("@p_categoria_id", categoriaId)
                glCommand.Parameters.AddWithValue("@p_prioridad_id", prioridadId)
                glCommand.Parameters.AddWithValue("@p_estado_id", 1) 'Por defecto el estado de Espera
                glCommand.Parameters.AddWithValue("@p_descripcion", descripcion)
                glCommand.Parameters.AddWithValue("@p_evidencia", rutaImagen)
                glCommand.Parameters.AddWithValue("@p_resultado", MySqlDbType.Int32)
                glCommand.Parameters("@p_resultado").Direction = ParameterDirection.Output
                myConecctionDB.Open()
                resultado = glCommand.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            Throw New Exception("Error al procesar la operación", ex)
        Finally
            If myConecctionDB.State <> ConnectionState.Closed Then myConecctionDB.Close()
        End Try
        Return resultado
    End Function

    Public Function ObtenerCategorias() As DataTable Implements ticketsInterfaces.ObtenerCategorias
        Try
            Using glCommand As New MySqlCommand("SP_ObtenerCategoriasTickets", myConecctionDB)
                glCommand.CommandTimeout = 0
                glCommand.CommandType = CommandType.StoredProcedure
                Using adapter As New MySqlDataAdapter(glCommand)
                    Dim dtCategorias As New DataTable()
                    adapter.Fill(dtCategorias)
                    Return dtCategorias
                End Using
            End Using
        Catch ex As Exception
            Throw New Exception("Error al procesar la operación", ex)
        Finally
            If myConecctionDB.State <> ConnectionState.Closed Then myConecctionDB.Close()
        End Try
    End Function


    Public Function ObtenerTicketPorUsuario(ByVal idUsuario As Integer, ByVal idTicket As Integer) As String Implements ticketsInterfaces.ObtenerTicketPorUsuario
        Try
            Using cmd As New MySqlCommand("SP_ObtenerDetalleTickets", myConecctionDB)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@p_usuario_id", idUsuario)
                cmd.Parameters.AddWithValue("@p_ticket_id", idTicket)

                myConecctionDB.Open()


                Dim descripcion As Object = cmd.ExecuteScalar()


                If descripcion IsNot Nothing AndAlso Not Convert.IsDBNull(descripcion) Then
                    Return descripcion.ToString()
                Else
                    Return String.Empty
                End If
            End Using
        Catch ex As Exception
            Throw New Exception("Error al procesar la operación", ex)
        Finally
            If myConecctionDB.State <> ConnectionState.Closed Then myConecctionDB.Close()
        End Try
    End Function

End Class
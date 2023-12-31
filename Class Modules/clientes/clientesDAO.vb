﻿Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.Windows.Documents

Public Class clientesDAO
    Implements ClientesInterfaces

    Private myConnection As MySqlConnection

    Public Sub New(myConnection As MySqlConnection)
        Me.myConnection = myConnection
    End Sub


    Public Function ObtenerUsuarios() As DataTable Implements ClientesInterfaces.ObtenerUsuarios
        Dim dtUsuarios As New DataTable()

        Try
            ' Abre la conexión a la base de datos
            DB_Conecction.conexionDB()
            DB_Conecction.myConnectionDB.Open()

            ' Crea el comando para ejecutar el procedimiento almacenado
            Dim cmd As New MySqlCommand("sp_ListarUsuarios", DB_Conecction.myConnectionDB)
            cmd.CommandType = CommandType.StoredProcedure

            ' Ejecuta el comando y llena el DataTable con los resultados
            Dim adapter As New MySqlDataAdapter(cmd)
            adapter.Fill(dtUsuarios)
        Catch ex As Exception
            ' Maneja las excepciones aquí según tu lógica
            MsgBox("Error al obtener usuarios: " & ex.Message)
        Finally
            ' Cierra la conexión
            DB_Conecction.myConnectionDB.Close()
        End Try

        Return dtUsuarios
    End Function

    Public Function ObtenerEmpresas() As DataTable Implements ClientesInterfaces.ObtenerEmpresas
        Dim dtEmpresas As New DataTable()

        Try
            ' Abre la conexión a la base de datos
            DB_Conecction.conexionDB()
            DB_Conecction.myConnectionDB.Open()

            ' Crea el comando para ejecutar el procedimiento almacenado
            Dim cmd As New MySqlCommand("sp_ListarEmpresas", DB_Conecction.myConnectionDB)
            cmd.CommandType = CommandType.StoredProcedure

            ' Ejecuta el comando y llena el DataTable con los resultados
            Dim adapter As New MySqlDataAdapter(cmd)
            adapter.Fill(dtEmpresas)
        Catch ex As Exception
            ' Maneja las excepciones aquí según tu lógica
            MsgBox("Error al obtener empresas: " & ex.Message)
        Finally
            ' Cierra la conexión
            DB_Conecction.myConnectionDB.Close()
        End Try

        Return dtEmpresas
    End Function


    Public Function ObtenerClientes() As DataTable Implements ClientesInterfaces.ObtenerClientes
        Dim dtClientes As New DataTable()

        Try
            ' Abre la conexión a la base de datos
            DB_Conecction.conexionDB()
            DB_Conecction.myConnectionDB.Open()

            ' Crea el comando para ejecutar el procedimiento almacenado
            Dim cmd As New MySqlCommand("sp_ListarClientes", DB_Conecction.myConnectionDB)
            cmd.CommandType = CommandType.StoredProcedure

            ' Ejecuta el comando y llena el DataTable con los resultados
            Dim adapter As New MySqlDataAdapter(cmd)
            adapter.Fill(dtClientes)
        Catch ex As Exception
            ' Maneja las excepciones aquí según tu lógica
            MsgBox("Error al obtener clientes: " & ex.Message)
        Finally
            ' Cierra la conexión
            DB_Conecction.myConnectionDB.Close()
        End Try

        Return dtClientes
    End Function


    Public Sub EliminarUsuarioPorCedula(cedula As String) Implements ClientesInterfaces.EliminarUsuarioPorCedula
        Try
            ' Abre la conexión a la base de datos
            DB_Conecction.conexionDB()
            DB_Conecction.myConnectionDB.Open()

            ' Crea el comando para ejecutar el procedimiento almacenado
            Dim cmd As New MySqlCommand("sp_EliminarUsuario", DB_Conecction.myConnectionDB)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@pCedula", cedula)

            ' Ejecuta el comando
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            ' Maneja las excepciones aquí según tu lógica
            MsgBox("Error al eliminar usuario: " & ex.Message)
        Finally
            ' Cierra la conexión
            DB_Conecction.myConnectionDB.Close()
        End Try
    End Sub

    Public Sub EliminarEmpresaPorRUC(ruc As String) Implements ClientesInterfaces.EliminarEmpresaPorRUC
        Try
            ' Abre la conexión a la base de datos
            DB_Conecction.conexionDB()
            DB_Conecction.myConnectionDB.Open()

            ' Crea el comando para ejecutar el procedimiento almacenado
            Dim cmd As New MySqlCommand("sp_EliminarEmpresa", DB_Conecction.myConnectionDB)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@pRUC", ruc)

            ' Ejecuta el comando
            cmd.ExecuteNonQuery()
        Catch ex As MySql.Data.MySqlClient.MySqlException
            ' Maneja las excepciones aquí según tu lógica
            If ex.Number = 1451 Then ' Número de error para restricción de clave externa
                MsgBox("No se puede eliminar la empresa porque tiene clientes activos.", MsgBoxStyle.Information)
            Else
                MsgBox("Error al eliminar empresa: " & ex.Message)
            End If
        Finally
            ' Cierra la conexión
            DB_Conecction.myConnectionDB.Close()
        End Try
    End Sub

    Public Sub EliminarClientePorCedula(cedula As String) Implements ClientesInterfaces.EliminarClientePorCedula
        Try
            ' Abre la conexión a la base de datos
            DB_Conecction.conexionDB()
            DB_Conecction.myConnectionDB.Open()

            ' Crea el comando para ejecutar el procedimiento almacenado
            Dim cmd As New MySqlCommand("sp_EliminarCliente", DB_Conecction.myConnectionDB)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@pCedula", cedula)

            ' Ejecuta el comando
            cmd.ExecuteNonQuery()
        Catch ex As MySql.Data.MySqlClient.MySqlException
            ' Maneja las excepciones aquí según tu lógica
            If ex.Number = 1451 Then ' Número de error para restricción de clave externa
                MsgBox("No se puede eliminar el cliente porque tiene direcciones a su nombre.", MsgBoxStyle.Information)
            Else
                MsgBox("Error al eliminar cliente: " & ex.Message)
            End If
        Finally
            ' Cierra la conexión
            DB_Conecction.myConnectionDB.Close()
        End Try
    End Sub

    Public Function ObtenerUsuarioPorCedula(cedula As String) As DataRow Implements ClientesInterfaces.ObtenerUsuarioPorCedula
        Dim dtUsuario As DataTable = ObtenerUsuarios()
        Dim filtro As String = $"Cedula = '{cedula}'"
        Dim resultados() As DataRow = dtUsuario.Select(filtro)

        If resultados.Length > 0 Then
            Return resultados(0)
        Else
            Return Nothing
        End If
    End Function

    Public Sub ActualizarUsuario(cedula As String, nuevosDatos As Dictionary(Of String, Object)) Implements ClientesInterfaces.ActualizarUsuario
        Try
            DB_Conecction.conexionDB()
            DB_Conecction.myConnectionDB.Open()

            Dim cmd As New MySqlCommand("sp_ActualizarUsuario", DB_Conecction.myConnectionDB)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@pCedula", cedula)

            For Each kvp As KeyValuePair(Of String, Object) In nuevosDatos
                cmd.Parameters.AddWithValue($"@p{kvp.Key}", kvp.Value)
            Next

            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Error al actualizar usuario: " & ex.Message)
        Finally
            DB_Conecction.myConnectionDB.Close()
        End Try
    End Sub

    Public Function ObtenerEmpresaPorRUC(ruc As String) As DataRow Implements ClientesInterfaces.ObtenerEmpresaPorRUC
        Dim dtEmpresa As DataTable = ObtenerEmpresas()
        Dim filtro As String = $"RUC = '{ruc}'"
        Dim resultados() As DataRow = dtEmpresa.Select(filtro)

        If resultados.Length > 0 Then
            Return resultados(0)
        Else
            Return Nothing
        End If
    End Function

    Public Sub ActualizarEmpresa(ruc As String, nuevosDatos As Dictionary(Of String, Object)) Implements ClientesInterfaces.ActualizarEmpresa
        Try
            DB_Conecction.conexionDB()
            DB_Conecction.myConnectionDB.Open()

            Dim cmd As New MySqlCommand("sp_ActualizarEmpresa", DB_Conecction.myConnectionDB)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@pRUC", ruc)

            For Each kvp As KeyValuePair(Of String, Object) In nuevosDatos
                cmd.Parameters.AddWithValue($"@p{kvp.Key}", kvp.Value)
            Next

            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Error al actualizar empresa: " & ex.Message)
        Finally
            DB_Conecction.myConnectionDB.Close()
        End Try
    End Sub

    Public Sub ActualizarCliente(cedula As String, nuevosDatos As Dictionary(Of String, Object)) Implements ClientesInterfaces.ActualizarCliente
        Try
            DB_Conecction.conexionDB()
            DB_Conecction.myConnectionDB.Open()

            Dim cmd As New MySqlCommand("sp_ActualizarCliente", DB_Conecction.myConnectionDB)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@pCedula", cedula)
            cmd.Parameters.Clear()

            For Each kvp As KeyValuePair(Of String, Object) In nuevosDatos
                cmd.Parameters.AddWithValue($"@p{kvp.Key}", kvp.Value)
            Next

            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Error al actualizar empresa: " & ex.Message)
        Finally
            DB_Conecction.myConnectionDB.Close()
        End Try
    End Sub



    Public Function ObtenerClientePorCedula(cedula As String) As DataRow Implements ClientesInterfaces.ObtenerClientePorCedula
        Dim clienteData As New DataTable()

        Try
            ' Abre la conexión a la base de datos
            DB_Conecction.conexionDB()
            DB_Conecction.myConnectionDB.Open()

            ' Crea el comando para ejecutar el procedimiento almacenado
            Dim cmd As New MySqlCommand("sp_ObtenerClientePorCedula", DB_Conecction.myConnectionDB)
            cmd.CommandType = CommandType.StoredProcedure

            ' Agrega el parámetro al comando
            cmd.Parameters.AddWithValue("@pCedula", cedula)

            ' Ejecuta el comando y llena el DataTable con los resultados
            Dim adapter As New MySqlDataAdapter(cmd)
            adapter.Fill(clienteData)

            ' Verifica si se encontraron resultados y devuelve la primera fila
            If clienteData.Rows.Count > 0 Then
                Return clienteData.Rows(0)
            Else
                Return Nothing
            End If
        Catch ex As Exception
            ' Maneja las excepciones aquí según tu lógica
            MsgBox("Error al obtener cliente por cédula: " & ex.Message)
            Return Nothing
        Finally
            ' Cierra la conexión
            DB_Conecction.myConnectionDB.Close()
        End Try
    End Function


    Public Function Obtener_id_empresaPorRUC(ruc As String) As DataTable Implements ClientesInterfaces.Obtener_id_empresaPorRUC
        Dim dtDireccion As New DataTable()

        Try
            ' Abre la conexión a la base de datos
            DB_Conecction.conexionDB()
            DB_Conecction.myConnectionDB.Open()

            ' Crea el comando para ejecutar el procedimiento almacenado
            Dim cmd As New MySqlCommand("sp_ObtenerDireccionEmpresaPorID", DB_Conecction.myConnectionDB)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@p_ruc", ruc)

            ' Ejecuta el comando y llena el DataTable con los resultados
            Dim adapter As New MySqlDataAdapter(cmd)
            adapter.Fill(dtDireccion)

        Catch ex As Exception
            ' Maneja las excepciones aquí según tu lógica
            MsgBox("Error al obtener el id de la empresa: " & ex.Message)
        Finally
            ' Cierra la conexión
            DB_Conecction.myConnectionDB.Close()
        End Try

        Return dtDireccion
    End Function


    Function InsertarDireccionEmpresa(provincia As String, telefono As String, detalles As String, codigoPostal As String, ruc As String) Implements ClientesInterfaces.InsertarDireccionEmpresa
        Try
            ' Abre la conexión a la base de datos
            DB_Conecction.conexionDB()
            DB_Conecction.myConnectionDB.Open()

            ' Crea el comando para ejecutar el procedimiento almacenado
            Dim cmd As New MySqlCommand("sp_InsertarDireccionConEmpresa", DB_Conecction.myConnectionDB)
            cmd.CommandType = CommandType.StoredProcedure

            ' Agrega los parámetros necesarios para la inserción
            cmd.Parameters.AddWithValue("@pProvinciaId", provincia)
            cmd.Parameters.AddWithValue("@pCodigoPostal", codigoPostal)
            cmd.Parameters.AddWithValue("@pTelefono", telefono)
            cmd.Parameters.AddWithValue("@pDetalles", detalles)
            cmd.Parameters.AddWithValue("@pRucEmpresa", ruc)

            ' Ejecuta el comando
            cmd.ExecuteNonQuery()
            MsgBox("Se hizo la inserción de la dirección")
        Catch ex As Exception
            ' Maneja las excepciones aquí según tu lógica
            MsgBox("Error al insertar la dirección de la empresa")
        Finally
            ' Cierra la conexión
            DB_Conecction.myConnectionDB.Close()
        End Try
    End Function

    Public Sub ActualizarDireccionEmpresa(provincia As String, telefono As String, detalles As String, codigoPostal As String, id As String) Implements ClientesInterfaces.ActualizarDireccionEmpresa
        Try
            DB_Conecction.conexionDB()
            DB_Conecction.myConnectionDB.Open()

            Dim cmd As New MySqlCommand("sp_ActualizarDireccionEmpresa", DB_Conecction.myConnectionDB)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@p_id_direccion", id)
            cmd.Parameters.AddWithValue("@p_provincia", provincia)
            cmd.Parameters.AddWithValue("@p_telefono", telefono)
            cmd.Parameters.AddWithValue("@p_detalles", detalles)
            cmd.Parameters.AddWithValue("@p_codigoPost", codigoPostal)


            If cmd.ExecuteNonQuery() Then
                MsgBox("Se ha actualizado correctamente la dirección de empresa")
            End If

        Catch ex As Exception
            MsgBox("Error al actualizar usuario: " & ex.Message)
        Finally
            DB_Conecction.myConnectionDB.Close()
        End Try
    End Sub

    Public Sub EliminarDireccionEmpresaPorID(id As String) Implements ClientesInterfaces.EliminarDireccionEmpresaPorID
        Try
            ' Abre la conexión a la base de datos
            DB_Conecction.conexionDB()
            DB_Conecction.myConnectionDB.Open()

            ' Crea el comando para ejecutar el procedimiento almacenado
            Dim cmd As New MySqlCommand("sp_EliminarDireccionEmpresa", DB_Conecction.myConnectionDB)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@pDireccionId", id)
            ' Ejecuta el comando
            If cmd.ExecuteNonQuery() Then
                MsgBox("Direccion de Empresa Eliminada Correctamente")
            End If
        Catch ex As MySql.Data.MySqlClient.MySqlException
            ' Maneja las excepciones aquí según tu lógica
            If ex.Number = 1451 Then ' Número de error para restricción de clave externa
                MsgBox("No se puede eliminar la direccion.", MsgBoxStyle.Information)
            Else
                MsgBox("Error al eliminar la direccion: " & ex.Message)
            End If
        Finally
            ' Cierra la conexión
            DB_Conecction.myConnectionDB.Close()
        End Try
    End Sub

    Public Function Obtener_id_clientePorCEDULA(cedula As String) As DataTable Implements ClientesInterfaces.Obtener_id_clientePorCEDULA
        Dim dtDireccion As New DataTable()

        Try
            ' Abre la conexión a la base de datos
            DB_Conecction.conexionDB()
            DB_Conecction.myConnectionDB.Open()

            ' Crea el comando para ejecutar el procedimiento almacenado
            Dim cmd As New MySqlCommand("sp_ObtenerDireccionClientePorCedula", DB_Conecction.myConnectionDB)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@p_cedula", cedula)

            ' Ejecuta el comando y llena el DataTable con los resultados
            Dim adapter As New MySqlDataAdapter(cmd)
            adapter.Fill(dtDireccion)

        Catch ex As Exception
            ' Maneja las excepciones aquí según tu lógica
            MsgBox("Error al obtener el id del cliente: " & ex.Message)
        Finally
            ' Cierra la conexión
            DB_Conecction.myConnectionDB.Close()
        End Try

        Return dtDireccion
    End Function

    Function InsertarDireccionCliente(provincia As String, telefono As String, detalles As String, codigoPostal As String, cedula As String) Implements ClientesInterfaces.InsertarDireccionCliente
        Try
            ' Abre la conexión a la base de datos
            DB_Conecction.conexionDB()
            DB_Conecction.myConnectionDB.Open()

            ' Crea el comando para ejecutar el procedimiento almacenado
            Dim cmd As New MySqlCommand("sp_InsertarDireccionConCliente", DB_Conecction.myConnectionDB)
            cmd.CommandType = CommandType.StoredProcedure

            ' Agrega los parámetros necesarios para la inserción
            cmd.Parameters.AddWithValue("@pProvinciaId", provincia)
            cmd.Parameters.AddWithValue("@pCodigoPostal", codigoPostal)
            cmd.Parameters.AddWithValue("@pTelefono", telefono)
            cmd.Parameters.AddWithValue("@pDetalles", detalles)
            cmd.Parameters.AddWithValue("@pCedulaCliente", cedula)

            ' Ejecuta el comando
            cmd.ExecuteNonQuery()
            MsgBox("Se hizo la inserción de la dirección")
        Catch ex As Exception
            ' Maneja las excepciones aquí según tu lógica
            MsgBox("Error al insertar la dirección de la empresa")
        Finally
            ' Cierra la conexión
            DB_Conecction.myConnectionDB.Close()
        End Try
    End Function

    Public Sub ActualizarDireccionCliente(provincia As String, telefono As String, detalles As String, codigoPostal As String, id As String) Implements ClientesInterfaces.ActualizarDireccionCliente
        Try
            DB_Conecction.conexionDB()
            DB_Conecction.myConnectionDB.Open()

            Dim cmd As New MySqlCommand("sp_ActualizarDireccionEmpresa", DB_Conecction.myConnectionDB)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@p_id_direccion", id)
            cmd.Parameters.AddWithValue("@p_provincia", provincia)
            cmd.Parameters.AddWithValue("@p_telefono", telefono)
            cmd.Parameters.AddWithValue("@p_detalles", detalles)
            cmd.Parameters.AddWithValue("@p_codigoPost", codigoPostal)

            If cmd.ExecuteNonQuery() Then
                MsgBox("Se ha actualizado correctamente la dirección de empresa")
            End If

        Catch ex As Exception
            MsgBox("Error al actualizar usuario: " & ex.Message)
        Finally
            DB_Conecction.myConnectionDB.Close()
        End Try
    End Sub

    Public Sub EliminarDireccionClientePorID(id As String) Implements ClientesInterfaces.EliminarDireccionClientePorID
        Try
            ' Abre la conexión a la base de datos
            DB_Conecction.conexionDB()
            DB_Conecction.myConnectionDB.Open()

            ' Crea el comando para ejecutar el procedimiento almacenado
            Dim cmd As New MySqlCommand("sp_EliminarDireccionCliente", DB_Conecction.myConnectionDB)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@pDireccionId", id)
            ' Ejecuta el comando
            If cmd.ExecuteNonQuery() Then
                MsgBox("Direccion de Cliente Eliminada Correctamente")
            End If
        Catch ex As MySql.Data.MySqlClient.MySqlException
            ' Maneja las excepciones aquí según tu lógica
            If ex.Number = 1451 Then ' Número de error para restricción de clave externa
                MsgBox("No se puede eliminar la direccion.", MsgBoxStyle.Information)
            Else
                MsgBox("Error al eliminar la direccion: " & ex.Message)
            End If
        Finally
            ' Cierra la conexión
            DB_Conecction.myConnectionDB.Close()
        End Try
    End Sub

End Class

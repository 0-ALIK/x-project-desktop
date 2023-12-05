Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Public Class loginDAO
    Implements loginInterface
    Private myConnectionDB As SqlConnection
    Public Sub New(myConnecti As SqlConnection)
        Me.myConnectionDB = myConnecti
    End Sub

    Public Function InsertarUsuario(nombre As String, correo As String, pass As String, rol As String) As Integer Implements loginInterface.InsertarUsuario
        Dim resultado As Integer = 0
        Try
            Using glCommand As New SqlCommand("SP_IngresarUser", myConnectionDB)
                glCommand.CommandTimeout = 0
                glCommand.CommandType = CommandType.StoredProcedure
                glCommand.Parameters.AddWithValue("@p_nombre", nombre)
                glCommand.Parameters.AddWithValue("@p_correo", correo)
                glCommand.Parameters.AddWithValue("@p_pass", pass)
                glCommand.Parameters.AddWithValue("@p_rol", rol)
                myConnectionDB.Open()
                resultado = glCommand.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            Throw New Exception("Error al procesar la operación", ex)
        Finally
            If myConnectionDB.State <> ConnectionState.Closed Then myConnectionDB.Close()
        End Try
        Return resultado
    End Function

    Public Function EncriptarPass(pass As String) As Integer Implements loginInterface.EncriptarPass
        Throw New NotImplementedException()
    End Function
End Class

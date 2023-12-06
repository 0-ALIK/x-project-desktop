Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Runtime.InteropServices.WindowsRuntime
Imports System.Security.Cryptography
Imports System.Text
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
            Dim passEncriptada As String = EncriptarPass(pass)

            Using glCommand As New SqlCommand("SP_IngresarUser", myConnectionDB)
                glCommand.CommandTimeout = 0
                glCommand.CommandType = CommandType.StoredProcedure
                glCommand.Parameters.AddWithValue("@p_nombre", nombre)
                glCommand.Parameters.AddWithValue("@p_correo", correo)
                glCommand.Parameters.AddWithValue("@p_pass", passEncriptada)
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
        Dim key As String = ConfigurationManager.AppSettings("ClaveTripleDES")
        Dim iv As String = "qualityi"

        Using des As New TripleDESCryptoServiceProvider()
            des.Key = Encoding.UTF8.GetBytes(key)
            des.IV = Encoding.UTF8.GetBytes(iv)

            Using transform As ICryptoTransform = des.CreateEncryptor()
                Dim buffer() As Byte = Encoding.UTF8.GetBytes(pass)
                Dim encryptedBytes() As Byte = transform.TransformFinalBlock(buffer, 0, buffer.Length)
                Return Convert.ToBase64String(encryptedBytes)
            End Using

        End Using

    End Function


    Public Function ValidarUsuario(nombre As String, pass As String) As Boolean Implements loginInterface.ValidarUsuario

        Try
            Using glCommand As New SqlCommand("SELECT * FROM usuario WHERE nombre = @p_nombre AND pass = @p_pass")
                glCommand.Parameters.AddWithValue("@p_nombre", nombre)
                glCommand.Parameters.AddWithValue("@p_pass", pass)
                myConnectionDB.Open()
                Dim count As Integer = Convert.ToInt32(glCommand.ExecuteScalar())
                Return count > 0
            End Using

        Catch ex As Exception
            Throw New Exception("Error al iniciar Sesión", ex)

        Finally
            If myConnectionDB.State <> ConnectionState.Closed Then myConnectionDB.Close()

        End Try

    End Function
End Class

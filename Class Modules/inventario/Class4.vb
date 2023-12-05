Imports MySql.Data.MySqlClient
Public Class inventaryDAO
    Implements inventaryInterfaces

    Private myConecctionDB As MySqlConnection

    Public Sub New(myConnection As MySqlConnection)
        Me.myConecctionDB = myConecctionDB
    End Sub

    Public Function LlenarDGVInventario() As DataTable Implements inventaryInterfaces.LlenarDGVInventario
        Try
            Using glCommand As New MySqlCommand("SP_LlenarDGVInventario", myConnectionDB)
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

End Class

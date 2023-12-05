Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Public Class frmInventario

    Dim invenatyDao As New inventaryDAO(myConnectionDB)

    Private Sub frmInventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conexionDB()
            myConnectionDB.Open()
            Dim InventarioDataTable As DataTable = invenatyDao.VerProductos
            dgvInv.DataSource = InventarioDataTable

            dgvInv.Columns("id").Visible = False 'Esta línea es para evitar que se vea la columna id del inventario

        Catch ex As Exception
            MsgBox("Error al realizar la conexión" & vbCrLf & "Error: " & ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            If myConnectionDB.State <> ConnectionState.Closed Then myConnectionDB.Close()
        End Try
    End Sub

    Private Sub tsMarcaInv_Click(sender As Object, e As EventArgs)
        SetPanel(frmAgregarMarca, panelFrmInventario)
    End Sub

    Private Sub tsProductoInv_Click(sender As Object, e As EventArgs) Handles tsProductoInv.Click
        SetPanel(frmAgregarProducto, panelFrmInventario)
    End Sub

    Private Sub tsCategoriaInv_Click(sender As Object, e As EventArgs) Handles tsCategoriaInv.Click
        SetPanel(frmAgregarMarca, panelFrmInventario)
    End Sub

    Private Sub dgvInv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvInv.CellContentClick
        Try
            If e.RowIndex >= 0 AndAlso dgvInv.Columns(e.ColumnIndex).Name = "Eliminar" Then
                Dim idProducto As Integer = Convert.ToInt32(dgvInv.SelectedRows(0).Cells("id").Value)

                ' Abrir la conexión a la base de datos
                conexionDB()
                myConnectionDB.Open()

                Dim command As New MySqlCommand("SP_EliminarProductos", myConnectionDB)
                command.CommandType = CommandType.StoredProcedure

                ' Agregar el parámetro @id al comando
                command.Parameters.AddWithValue("@id", idProducto)
                command.ExecuteNonQuery()

            End If
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If myConnectionDB.State <> ConnectionState.Closed Then myConnectionDB.Close()
        End Try
    End Sub
End Class
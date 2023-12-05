Imports MySql.Data.MySqlClient

Public Class frmAgregarCategoria
    Dim invenatyDao As New inventaryDAO(myConnectionDB)
    Private Sub frmAgregarCategoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conexionDB()
            myConnectionDB.Open()
            Dim CategoriaDataTable As DataTable = invenatyDao.VerCategorias
            For Each rows As DataRow In CategoriaDataTable.Rows
                dgvCategoria.Rows.Add(rows("id_categoria"), rows("nombre"))
            Next

        Catch ex As Exception
            MsgBox("Error al realizar la conexión" & vbCrLf & "Error: " & ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            If myConnectionDB.State <> ConnectionState.Closed Then myConnectionDB.Close()
        End Try
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        conexionDB()
        myConnectionDB.Open()
        Dim result As Integer
        Try
            result = invenatyDao.InsertaCategorias(txtCategoria.Text)

            If result <> 0 Then
                MessageBox.Show("Error al insertar la categoria.")
            Else
                MessageBox.Show("La categoria ha sido insertada.")
                ' Refresca la pantalla (actualiza el DataGridView)
                dgvCategoria.Rows.Clear()
                Dim CategoriaDataTable As DataTable = invenatyDao.VerCategorias
                For Each rows As DataRow In CategoriaDataTable.Rows
                    dgvCategoria.Rows.Add(rows("id_categoria"), rows("nombre"))
                Next
                txtCategoria.Clear()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dgvCategoria_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCategoria.CellContentClick
        Try
            If e.RowIndex >= 0 AndAlso dgvCategoria.Columns(e.ColumnIndex).Name = "Eliminar" Then
                ' Pregunta al usuario si realmente quiere eliminar el producto
                Dim confirmacion As DialogResult = MessageBox.Show("¿Estás seguro de que quieres eliminar esta categoria?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If confirmacion = DialogResult.Yes Then
                    ' Obtiene el ID del producto seleccionado
                    Dim idCategoria As Integer = dgvCategoria.Rows(dgvCategoria.CurrentRow.Index).Cells("id_categoria").Value

                    ' Abrir la conexión a la base de datos
                    conexionDB()
                    myConnectionDB.Open()

                    ' Crea el comando SQL para ejecutar el procedimiento almacenado
                    Dim command As New MySqlCommand("SP_EliminarCategorias", myConnectionDB)
                    command.CommandType = CommandType.StoredProcedure

                    ' Agrega el parámetro @id al comando
                    command.Parameters.AddWithValue("@id", idCategoria)
                    command.ExecuteNonQuery()

                    ' Refresca la pantalla (actualiza el DataGridView)
                    dgvCategoria.Rows.Clear()
                    Dim CategoriaDataTable As DataTable = invenatyDao.VerCategorias
                    For Each rows As DataRow In CategoriaDataTable.Rows
                        dgvCategoria.Rows.Add(rows("id_categoria"), rows("nombre"))
                    Next
                End If
            End If
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If myConnectionDB.State <> ConnectionState.Closed Then myConnectionDB.Close()
        End Try
    End Sub
End Class
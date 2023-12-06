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

            For Each rows As DataRow In InventarioDataTable.Rows
                dgvInv.Rows.Add(rows("id"), rows("Producto"), rows("Categoria"), rows("Marca"), rows("Precio Unit"), rows("Stock"), rows("foto"), rows("P.reorden"))
            Next
            dgvInv.ClearSelection()

            'Centrado de celdas especificas
            dgvInv.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvInv.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvInv.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
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
        frmAgregarCategoria.Show()
    End Sub

    Private Sub dgvInv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvInv.CellContentClick
        Try
            If e.RowIndex >= 0 AndAlso dgvInv.Columns(e.ColumnIndex).Name = "acciones" Then
                ' Pregunta al usuario si realmente quiere eliminar el producto
                Dim confirmacion As DialogResult = MessageBox.Show("¿Estás seguro de que quieres eliminar esta categoria?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If confirmacion = DialogResult.Yes Then
                    ' Obtiene el ID del producto seleccionado
                    Dim idProducto As Integer = Convert.ToInt32(dgvInv.SelectedRows(0).Cells("id_producto").Value)

                    ' Abrir la conexión a la base de datos
                    conexionDB()
                    myConnectionDB.Open()

                    ' Crea el comando SQL para ejecutar el procedimiento almacenado
                    Dim command As New MySqlCommand("SP_EliminarProductos", myConnectionDB)
                    command.CommandType = CommandType.StoredProcedure

                    ' Agrega el parámetro @id al comando
                    command.Parameters.AddWithValue("@id", idProducto)
                    command.ExecuteNonQuery()

                    ' Refresca la pantalla (actualiza el DataGridView)
                    dgvInv.Rows.Clear()
                    Dim InventarioDataTable As DataTable = invenatyDao.VerProductos
                    For Each rows As DataRow In InventarioDataTable.Rows
                        dgvInv.Rows.Add(rows("id"), rows("Producto"), rows("Categoria"), rows("Marca"), rows("Precio Unit"), rows("Stock"), rows("foto"), rows("P.reorden"))
                    Next
                    dgvInv.ClearSelection()

                    'Centrado de celdas especificas
                    dgvInv.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    dgvInv.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    dgvInv.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                End If
            End If
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If myConnectionDB.State <> ConnectionState.Closed Then myConnectionDB.Close()
        End Try
    End Sub

    Private Sub dgvInv_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvInv.CellFormatting
        If e.ColumnIndex = 7 Then
            If e.Value.ToString() = "Aplica" Then
                e.CellStyle.BackColor = Color.IndianRed
            Else
                e.CellStyle.BackColor = Color.LightGreen
            End If
        End If
    End Sub
End Class
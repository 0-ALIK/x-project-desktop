Imports System.Windows.Media
Imports MySql.Data.MySqlClient

Public Class frmInventario

    Dim invenatyDao As New inventaryDAO(myConnectionDB)

    Private Sub frmInventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conexionDB()
            myConnectionDB.Open()
            Dim InventarioDataTable As DataTable = invenatyDao.VerProductos

            For Each row As DataRow In InventarioDataTable.Rows
                Dim imagen As Image = If(row("foto") IsNot DBNull.Value, DecodificarImagen(row("foto")), Nothing)

                If imagen IsNot Nothing Then
                    ' Crear una nueva imagen redimensionada con un ancho de 100 píxeles
                    Dim nuevoAncho As Integer = 100
                    Dim nuevoAlto As Integer = CInt(imagen.Height * (nuevoAncho / imagen.Width))
                    Dim imagenRedimensionada As New Bitmap(imagen, nuevoAncho, nuevoAlto)

                    ' Agregar una nueva fila al DataGridView con la imagen redimensionada y otros valores de las columnas
                    dgvInv.Rows.Add(row("id"), row("Producto"), row("Categoria"), row("Marca"), row("Precio Unit"), row("Stock"), imagenRedimensionada, row("P.reorden"))
                Else
                    ' Agregar una nueva fila al DataGridView con los valores de las columnas (la imagen es Nothing)
                    dgvInv.Rows.Add(row("id"), row("Producto"), row("Categoria"), row("Marca"), row("Precio Unit"), row("Stock"), Nothing, row("P.reorden"))
                End If

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
                Dim nombreProducto As String = dgvInv.SelectedRows(0).Cells("Producto").Value.ToString()
                Dim confirmacion As DialogResult = MessageBox.Show("¿Desea eliminar el producto '" & nombreProducto & "'?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

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


                    For Each row As DataRow In InventarioDataTable.Rows
                        Dim imagen As Image = If(row("foto") IsNot DBNull.Value, DecodificarImagen(row("foto")), Nothing)

                        If imagen IsNot Nothing Then
                            ' Crear una nueva imagen redimensionada con un ancho de 100 píxeles
                            Dim nuevoAncho As Integer = 100
                            Dim nuevoAlto As Integer = CInt(imagen.Height * (nuevoAncho / imagen.Width))
                            Dim imagenRedimensionada As New Bitmap(imagen, nuevoAncho, nuevoAlto)

                            ' Agregar una nueva fila al DataGridView con la imagen redimensionada y otros valores de las columnas
                            dgvInv.Rows.Add(row("id"), row("Producto"), row("Categoria"), row("Marca"), row("Precio Unit"), row("Stock"), imagenRedimensionada, row("P.reorden"))
                        Else
                            ' Agregar una nueva fila al DataGridView con los valores de las columnas (la imagen es Nothing)
                            dgvInv.Rows.Add(row("id"), row("Producto"), row("Categoria"), row("Marca"), row("Precio Unit"), row("Stock"), Nothing, row("P.reorden"))
                        End If

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
                e.CellStyle.ForeColor = System.Drawing.Color.LightGreen
            Else
                e.CellStyle.ForeColor = System.Drawing.Color.IndianRed
            End If
        End If
    End Sub

    Private Sub dgvInv_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvInv.CellContentDoubleClick
        If e.RowIndex >= 0 Then ' Verifica que se haya hecho doble clic en una fila válida
            If dgvInv.SelectedCells.Count > 0 Then
                ' Obtiene el valor de la celda en la columna "Producto" de la fila seleccionada
                Dim nombreProducto As String = dgvInv.Rows(e.RowIndex).Cells("Producto").Value.ToString()

                ' Muestra un MsgBox con el nombre del producto
                MsgBox("Producto seleccionado: " & nombreProducto)
            End If
        End If
    End Sub


End Class
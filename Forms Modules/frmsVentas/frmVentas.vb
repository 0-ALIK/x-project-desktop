Public Class frmVentas

    Private comprasDAO As comprasDAO ' Asegúrate de tener una instancia válida de ComprasDAO

    Private Sub frmVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            DB_Conecction.conexionDB()

            ' Crear una instancia de ComprasDAO con la conexión existente
            comprasDAO = New comprasDAO(DB_Conecction.myConnectionDB)
            Dim PedidosDataTable As DataTable = comprasDAO.ObtenerPedidos()

            ' Asignar la fuente de datos al DataGridView
            dgvPedidos.DataSource = PedidosDataTable
        Catch ex As Exception
            MsgBox("Error al obtener los pedidos" & vbCrLf & "Error: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub dgvPedidos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPedidos.CellDoubleClick
        ' Verificar si el índice de la celda es válido y si hay al menos una fila en el DataGridView
        If e.RowIndex >= 0 AndAlso dgvPedidos.Rows.Count > 0 Then
            ' Obtener el valor de la celda en la primera columna (suponiendo que es el IdPedido)
            Dim idPedido As Integer = Convert.ToInt32(dgvPedidos.Rows(e.RowIndex).Cells("IdPedido").Value)

            ' Crear una instancia de frmDetalleVentas y pasar la conexión y el IdPedido como parámetros
            Dim frmDetallePedido As New frmDetalleVentas(DB_Conecction.myConnectionDB, idPedido)
            frmDetallePedido.ShowDialog()
        End If
    End Sub
    Private Sub btnEliminarPedido_Click(sender As Object, e As EventArgs) Handles btnEliminarPedido.Click
        ' Verificar si se seleccionó una fila en el DataGridView
        If dgvPedidos.SelectedRows.Count > 0 Then
            ' Obtener el valor de la celda en la primera columna (suponiendo que es el IdPedido)
            Dim idPedido As Integer = Convert.ToInt32(dgvPedidos.SelectedRows(0).Cells("IdPedido").Value)

            ' Preguntar al usuario si realmente desea eliminar el pedido
            Dim confirmacion As DialogResult = MessageBox.Show("¿Seguro que desea eliminar este pedido?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If confirmacion = DialogResult.Yes Then
                ' Llamar al método en el DAO para eliminar el pedido
                Try
                    comprasDAO.EliminarPedido(idPedido)
                    ' Actualizar el DataGridView después de la eliminación
                    ActualizarDataGridView()
                    MessageBox.Show("Pedido eliminado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MessageBox.Show($"Error al eliminar el pedido. Detalles: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        Else
            MessageBox.Show("Seleccione un pedido para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
    Private Sub ActualizarDataGridView()
        Try
            ' Obtener los pedidos actualizados desde el DAO
            Dim PedidosDataTable As DataTable = comprasDAO.ObtenerPedidos()

            ' Asignar la fuente de datos al DataGridView
            dgvPedidos.DataSource = PedidosDataTable
        Catch ex As Exception
            MessageBox.Show($"Error al obtener los pedidos actualizados. Detalles: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class

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


End Class

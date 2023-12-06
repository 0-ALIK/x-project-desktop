Imports MySql.Data.MySqlClient

Public Class frmInventario

    Dim invenatyDao As New inventaryDAO(myConnectionDB)

    Private Sub frmInventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conexionDB()
            myConnectionDB.Open()
            Dim InventarioDataTable As DataTable = invenatyDao.VerProductos
            For Each rows As DataRow In InventarioDataTable.Rows
                dgvInv.Rows.Add(rows("id"), rows("Producto"), rows("Categoria"), rows("Marca"), rows("Precio Unit"), rows("Stock"), rows("foto"), rows("P.reorden"))
            Next

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

    Private Sub tsAgregarInv_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub dgvInv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvInv.CellContentClick

    End Sub
End Class
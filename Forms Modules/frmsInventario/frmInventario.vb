Imports MySql.Data.MySqlClient

Public Class frmInventario

    Dim invenatyDao As New inventaryDAO(myConnectionDB)
    Private comprasDAO As comprasDAO
    Private Sub frmInventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conexionDB()
            myConnectionDB.Open()
            Dim InventarioDataTable As DataTable = invenatyDao.LlenarDGVInventario
            dgvInv.DataSource = InventarioDataTable
        Catch ex As Exception
            MsgBox("Error al realizar la conexión" & vbCrLf & "Error: " & ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            If myConnectionDB.State <> ConnectionState.Closed Then myConnectionDB.Close()
        End Try
    End Sub

    Private Sub tsMarcaInv_Click(sender As Object, e As EventArgs)
        '  SetPanel(frmAgregarMarca, panelFrmInventario)
    End Sub

    Private Sub tsProductoInv_Click(sender As Object, e As EventArgs) Handles tsProductoInv.Click
        '   SetPanel(frmAgregarProducto, panelFrmInventario)
    End Sub

    Private Sub tsCategoriaInv_Click(sender As Object, e As EventArgs) Handles tsCategoriaInv.Click
        Dim userInput As String
        userInput = InputBox("Introduzca el nombre de la categoria que desee agregar:", "Agregar Categoria")
    End Sub

    Private Sub tsRealizarCompraInv_Click(sender As Object, e As EventArgs) Handles tsRealizarCompraInv.Click
        ' Abrir el formulario de realizar compra
        Dim frmAgregarCompra As New frmAgregarPedido()
        frmAgregarCompra.ShowDialog()
    End Sub

    'Private Sub tsMarcaEnt_Click(sender As Object, e As EventArgs)
    '    SetPanel(frmAgregarMarca, panelFrmInventario)
    'End Sub

    'Private Sub tsProductoEnt_Click(sender As Object, e As EventArgs) Handles tsProductoEnt.Click
    '    SetPanel(frmAgregarProducto, panelFrmInventario)
    'End Sub

    Private Sub tsCategoriaEnt_Click(sender As Object, e As EventArgs) Handles tsCategoriaEnt.Click
        Dim userInput As String
        userInput = InputBox("Introduzca el nombre de la categoria que desee agregar:", "Agregar Categoria")
    End Sub


    Private Sub tsAgregarInv_Click(sender As Object, e As EventArgs)

    End Sub

End Class
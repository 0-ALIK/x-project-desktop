

Public Class frmAgregarPedido
    Private comprasDAO As comprasDAO

    Private Sub frmAgregarCompra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Inicializar la conexión a la base de datos utilizando la clase DB_Connection
        DB_Conecction.conexionDB()


        ' Crear una instancia de ComprasDAO con la conexión existente
        comprasDAO = New comprasDAO(DB_Conecction.myConnectionDB)

        ' Cargar datos en los ComboBox
        cboProductos.DataSource = comprasDAO.ObtenerProductos()
        cboProductos.DisplayMember = "NombreProducto"
        cboProductos.ValueMember = "id_producto"

        cboClientes.DataSource = comprasDAO.ObtenerClientes()
        cboClientes.DisplayMember = "nombre"
        cboClientes.ValueMember = "id_cliente"
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        ' Obtener valores del formulario
        Dim fecha As DateTime = dtpFechaC.Value
        Dim cantidad As Integer = Convert.ToInt32(txtCantidad.Text)
        Dim idProducto As Integer = Convert.ToInt32(cboProductos.SelectedValue)
        Dim idCliente As Integer = Convert.ToInt32(cboClientes.SelectedValue)

        ' Realizar la compra
        Dim resultado As Integer = comprasDAO.RealizarCompra(fecha, cantidad, idProducto, idCliente)

        ' Verificar el resultado y realizar acciones necesarias
        If resultado > 0 Then
            MessageBox.Show("Compra realizada con éxito")
            ' Puedes realizar otras acciones, como limpiar los controles, etc.
        Else
            MessageBox.Show("Error al realizar la compra")
        End If
    End Sub
End Class
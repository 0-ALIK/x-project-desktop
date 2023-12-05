Imports MySql.Data.MySqlClient

Public Class frmAgregarCompra
    Private comprasDAO As comprasDAO

    Private Sub frmAgregarCompra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Inicializar la conexión a la base de datos utilizando la clase DB_Connection
        StandardModules.DB_Conecction.conexionDB()

        ' Crear una instancia de ComprasDAO con la conexión existente
        comprasDAO = New comprasDAO(StandardModules.DB_Conecction.myConnectionDB)

        ' Cargar datos en los ComboBox
        cboProductos.DataSource = comprasDAO.ObtenerProductos()
        cboProductos.DisplayMember = "NombreProducto"
        cboProductos.ValueMember = "IdProducto"

        cboClientes.DataSource = comprasDAO.ObtenerClientes()
        cboClientes.DisplayMember = "NombreCliente"
        cboClientes.ValueMember = "IdCliente"
    End Sub

    Private Sub btnRealizarCompra_Click(sender As Object, e As EventArgs) Handles btnRealizarCompra.Click
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

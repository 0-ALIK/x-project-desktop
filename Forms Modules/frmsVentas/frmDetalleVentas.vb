Imports MySql.Data.MySqlClient

Public Class frmDetalleVentas

    Dim myConnection As MySqlConnection
    Dim comprasDAO As comprasDAO
    Dim pedidoId As Integer
    Dim deudaActual As Decimal
    Public Sub New(connection As MySqlConnection, pedidoId As Integer)
        InitializeComponent()
        Me.myConnection = connection
        Me.pedidoId = pedidoId
        Me.comprasDAO = New comprasDAO(myConnection)
    End Sub

    Private Sub frmDetalleVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            myConnection.Open()

            ' Obtener detalles del pedido desde el DAO
            CargarDetallesPedido()
            ' Obtener deuda actual y mostrarla en el textbox
            deudaActual = comprasDAO.ObtenerDeudaActual(pedidoId)
            txtDeuda.Text = deudaActual.ToString()

            ' Cargar historial de pagos en el DataGridView
            CargarHistorialPagos()
        Catch ex As Exception
            MessageBox.Show($"Error al cargar los detalles del pedido. Detalles: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If myConnection.State = ConnectionState.Open Then
                myConnection.Close()
            End If
        End Try
    End Sub

    ' Función para cargar los detalles del pedido
    Private Sub CargarDetallesPedido()
        Try
            Dim detallesPedido As DataTable = comprasDAO.ObtenerDetalleVenta(pedidoId)

            If detallesPedido.Rows.Count > 0 Then
                ' Llenar los controles del formulario con los datos de la tabla
                txtIdPedido.Text = detallesPedido.Rows(0)("IdPedido").ToString()
                txtNombreCliente.Text = detallesPedido.Rows(0)("NombreCliente").ToString()
                txtCedula.Text = detallesPedido.Rows(0)("CedulaCliente").ToString()
                txtRazonSocial.Text = detallesPedido.Rows(0)("NombreEmpresa").ToString()
                txtRuc.Text = detallesPedido.Rows(0)("RucEmpresa").ToString()
                txtEmpresaDetalleDireccion.Text = detallesPedido.Rows(0)("DetallesDireccion").ToString()
                txtProvincia.Text = detallesPedido.Rows(0)("NombreProvincia").ToString()
                txtTelefono.Text = detallesPedido.Rows(0)("TelefonoCliente").ToString()
                txtDetallesCliente.Text = detallesPedido.Rows(0)("DetallesCliente").ToString()

                Dim estadoPedido As String = detallesPedido.Rows(0)("EstadoPedido").ToString()
                CargarEstadosPedido()
                cboEstadoPedido.Text = estadoPedido


                ' Llenar el importe total
                txtImporteTotal.Text = detallesPedido.Rows(0)("ImporteTotal").ToString()

                ' Aquí puedes seguir llenando los demás controles
            Else
                MessageBox.Show("No se encontraron detalles para el pedido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Close()
            End If
        Catch ex As Exception
            MessageBox.Show($"Error al cargar los detalles del pedido. Detalles: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    ' Función para cargar los estados posibles del pedido en el ComboBox
    Private Sub CargarEstadosPedido()
        Try
            Dim estadosPedido As DataTable = comprasDAO.ObtenerEstadosPedido()

            If estadosPedido.Rows.Count > 0 Then
                cboEstadoPedido.DataSource = estadosPedido
                cboEstadoPedido.DisplayMember = "Estado"
            End If
        Catch ex As Exception
            MessageBox.Show($"Error al cargar los estados del pedido. Detalles: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCambiarEstado_Click(sender As Object, e As EventArgs) Handles btnCambiarEstado.Click
        Try
            ' Obtener el nuevo estado seleccionado en el ComboBox
            Dim nuevoEstado As String = cboEstadoPedido.Text

            ' Actualizar el estado del pedido en la base de datos
            ActualizarEstadoPedido(pedidoId, nuevoEstado)

            ' Volver a cargar los detalles del pedido para reflejar el cambio
            CargarDetallesPedido()

            ' Mostrar un mensaje de éxito
            MessageBox.Show("Estado cambiado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show($"Error al cambiar el estado del pedido. Detalles: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    ' Función para actualizar el estado del pedido en la base de datos
    Private Sub ActualizarEstadoPedido(idPedido As Integer, nuevoEstado As String)
        Try
            ' Llamada a la función en el DAO para actualizar el estado del pedido
            comprasDAO.ActualizarEstadoPedido(idPedido, nuevoEstado)
        Catch ex As Exception
            ' Manejar excepciones
            MessageBox.Show($"Error al actualizar el estado del pedido en la base de datos. Detalles: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnPagar_Click(sender As Object, e As EventArgs) Handles btnPagar.Click
        Try
            ' Abrir el formulario de pago y pasarle la conexión y el ID del pedido
            Using frmPago As New frmAgregarPago(myConnection, pedidoId)
                ' Suscribirse al evento de pago completado
                AddHandler frmPago.PagoRealizado, AddressOf PagoRealizadoEventHandler

                ' Mostrar el formulario de pago
                frmPago.ShowDialog()
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error al abrir el formulario de pago. Detalles: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub PagoRealizadoEventHandler(montoPagado As Decimal)
        ' Actualizar la deuda actual restando el monto pagado
        deudaActual -= montoPagado
        txtDeuda.Text = deudaActual.ToString()

        ' Volver a cargar el historial de pagos
        CargarHistorialPagos()
    End Sub



    Private Sub CargarHistorialPagos()
        ' Obtener los pagos desde el DAO y cargarlos en el DataGridView
        Dim pagosTable As DataTable = comprasDAO.ObtenerPagos(pedidoId)
        dgvPagos.DataSource = pagosTable
    End Sub



End Class

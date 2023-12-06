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
            'myConnection.Open()

            ' Obtener detalles del pedido desde el DAO
            CargarDetallesPedido()
            ' Obtener deuda actual y mostrarla en el textbox
            deudaActual = comprasDAO.ObtenerDeudaActual(pedidoId)
            txtDeuda.Text = deudaActual.ToString()

            ' Cargar historial de pagos en el DataGridView
            'CargarHistorialPagos()
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
            ' Abrir el formulario frmAgregarPago para ingresar detalles del pago
            Using frmAgregarPago As New frmAgregarPago(myConnection, pedidoId)
                ' Suscribirse al evento PagoRealizado
                AddHandler frmAgregarPago.PagoRealizado, AddressOf ManejarPagoRealizado

                ' Mostrar el formulario en modo de diálogo
                If frmAgregarPago.ShowDialog() = DialogResult.OK Then
                    ' No es necesario realizar acciones adicionales aquí
                End If

                ' Desuscribirse del evento PagoRealizado para evitar posibles fugas de memoria
                RemoveHandler frmAgregarPago.PagoRealizado, AddressOf ManejarPagoRealizado
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error al realizar el pago. Detalles: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Manejar el evento PagoRealizado
    Private Sub ManejarPagoRealizado(cantidad As Decimal)
        ' Actualizar el historial de pagos en el DataGridView
        CargarHistorialPagos()

        ' Mostrar un mensaje de éxito (opcional)
        MessageBox.Show($"Pago registrado con éxito. Cantidad: {cantidad}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    ' Función para cargar el historial de pagos en el DataGridView
    Private Sub CargarHistorialPagos()
        Try
            ' Obtener el historial de pagos desde el DAO
            Dim historialPagos As DataTable = comprasDAO.ObtenerPagos(pedidoId)

            ' Llenar el DataGridView con los datos del historial de pagos
            dgvHistorialPagos.DataSource = historialPagos
        Catch ex As Exception
            MessageBox.Show($"Error al cargar el historial de pagos. Detalles: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnGenerarFactura_Click(sender As Object, e As EventArgs) Handles btnGenerarFactura.Click
        MessageBox.Show("Esta funcionalidad estará disponible en futuras versiones.", "Funcionalidad a Futuro", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub



End Class
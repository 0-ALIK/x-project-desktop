Imports MySql.Data.MySqlClient

Public Class frmAgregarPago
    Private myConnection As MySqlConnection
    Private comprasDAO As comprasDAO
    Private pedidoId As Integer
    Public Event PagoRealizado As Action(Of Decimal)

    Public Sub New(connection As MySqlConnection, pedidoId As Integer)
        InitializeComponent()
        Me.myConnection = connection
        Me.pedidoId = pedidoId
        Me.comprasDAO = New comprasDAO(myConnection)

        ' Cargar formas de pago en el ComboBox
        CargarFormasPago()
    End Sub

    Private Sub CargarFormasPago()
        Try
            Dim formasPago As DataTable = comprasDAO.ObtenerFormasPago()

            If formasPago.Rows.Count > 0 Then
                cboMetodoPago.DataSource = formasPago
                cboMetodoPago.DisplayMember = "NombreFormaPago"
                cboMetodoPago.ValueMember = "IdFormaPago"
            Else
                MessageBox.Show("No se encontraron formas de pago.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Close()
            End If
        Catch ex As Exception
            MessageBox.Show($"Error al cargar las formas de pago. Detalles: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnRegistrarPago_Click(sender As Object, e As EventArgs) Handles btnRegistrarPago.Click
        Try
            ' Obtener los valores del formulario
            Dim montoPagado As Decimal = Convert.ToDecimal(txtCantidadP.Text)
            Dim formaPagoId As Integer = Convert.ToInt32(cboMetodoPago.SelectedValue)

            ' Llamar a la función del DAO para registrar el pago
            Dim pagoId As Integer = comprasDAO.RegistrarPago(pedidoId, montoPagado, DateTime.Now, formaPagoId)

            ' Notificar al formulario principal que el pago se ha realizado
            RaiseEvent PagoRealizado(montoPagado)

            ' Cerrar el formulario de pago
            Close()
        Catch ex As Exception
            MessageBox.Show($"Error al registrar el pago. Detalles: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


End Class

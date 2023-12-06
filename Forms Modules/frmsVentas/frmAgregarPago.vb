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
                cboMetodoPago.DisplayMember = "nombre"
                cboMetodoPago.ValueMember = "id_forma_pago"
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
            ' Obtener la cantidad ingresada por el usuario
            Dim cantidad As Decimal
            If Not Decimal.TryParse(txtCantidad.Text, cantidad) Then
                MessageBox.Show("Por favor, ingrese una cantidad válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            ' Obtener la fecha actual
            Dim fecha As DateTime = DateTime.Now

            ' Obtener el id del método de pago seleccionado en el ComboBox
            Dim metodoPagoId As Integer = Convert.ToInt32(cboMetodoPago.SelectedValue)

            ' Llamar al método del DAO para registrar el pago
            Dim idPago As Integer = comprasDAO.RegistrarPago(pedidoId, cantidad, fecha, metodoPagoId)

            ' Notificar al formulario principal sobre el pago realizado
            RaiseEvent PagoRealizado(cantidad)

            ' Cerrar el formulario después de registrar el pago
            Close()
        Catch ex As Exception
            MessageBox.Show($"Error al registrar el pago. Detalles: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
Public Class frmEditarCliente
    Private Property CedulaCliente As String
    Private ClientesDao As ClientesInterfaces

    Public Sub New(cedula As String, ClientesDao As ClientesInterfaces)
        InitializeComponent()
        CedulaCliente = cedula
        Me.ClientesDao = ClientesDao
    End Sub

    Private Sub frmEditarCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarOpcionesComboBox()
        CargarDatosCliente()
    End Sub

    Private Sub CargarOpcionesComboBox()
        ' Agrega las opciones para el ComboBox de Rol
        cboTipo.Items.Add("minorisra")
        cboTipo.Items.Add("distribuidor")

        ' Agrega las opciones para el ComboBox de Género
        cboGenero.Items.Add("Masculino")
        cboGenero.Items.Add("Femenino")

    End Sub

    Private Sub CargarDatosCliente()
        Try
            ' Llama a la función del módulo para obtener los datos del cliente por cédula
            Dim datosCliente As DataRow = ClientesDao.ObtenerClientePorCedula(CedulaCliente)

            If datosCliente IsNot Nothing Then
                ' Llena los controles del formulario con los datos obtenidos
                txtNombre.Text = datosCliente("Nombre").ToString()
                txtApellido.Text = datosCliente("Apellido").ToString()
                txtCedula.Text = datosCliente("Cedula").ToString()
                txtEmpresa.Text = datosCliente("Empresa_id").ToString()
                cboGenero.Text = datosCliente("Genero").ToString()
                txtFoto.Text = datosCliente("Foto").ToString()
                txtTelefono.Text = datosCliente("Telefono").ToString()
                txtDetalles.Text = datosCliente("Detalles").ToString()
                cboTipo.Text = datosCliente("Tipo").ToString()
                ' ... (continúa con los demás campos)
            Else
                MsgBox("No se encontraron datos para el cliente.", MsgBoxStyle.Information)
                Me.Close()
            End If
        Catch ex As Exception
            ' Maneja las excepciones aquí según tu lógica
            MsgBox("Error al cargar datos del cliente: " & ex.Message)
        End Try
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        ' Actualiza los datos del cliente utilizando la función en ClientesModule
        Dim nuevosDatos As New Dictionary(Of String, Object) From {
            {"nombre", txtNombre.Text},
            {"apellido", txtApellido.Text},
            {"cedula", txtCedula.Text},
            {"empresa_id", txtEmpresa.Text},
            {"genero", cboGenero.Text},
            {"foto", txtFoto.Text},
            {"telefono", txtTelefono.Text},
            {"detalles", txtDetalles.Text},
            {"tipo", cboTipo.Text}
        }

        ClientesDao.ActualizarCliente(CedulaCliente, nuevosDatos)
        MsgBox("Cliente actualizado correctamente.", MsgBoxStyle.Information)

        ' Cierra el formulario de edición después de la actualización
        Me.Close()
        Dim frmClientes As New frmClientes(New clientesDAO(myConnectionDB))
        SetPanel(frmClientes, frmMenu.PanelContent)
    End Sub
End Class
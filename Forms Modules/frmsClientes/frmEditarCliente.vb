Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports System.Drawing.Imaging
Imports System.IO
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
                txtTelefono.Text = datosCliente("Telefono").ToString()
                txtDetalles.Text = datosCliente("Detalles").ToString()
                cboTipo.Text = datosCliente("Tipo").ToString()

                'Load the image data from the database And set it to pbPreview
                Dim fotoBase64 As String = datosCliente("Foto").ToString()
                If Not String.IsNullOrEmpty(fotoBase64) Then
                    pbPreview.Image = DecodificarImagen(fotoBase64)
                    pbPreview.SizeMode = PictureBoxSizeMode.StretchImage
                Else
                    ' Handle the case where the image data is empty
                    pbPreview.Image = Nothing
                End If
            Else
                MsgBox("No se encontraron datos para el cliente.", MsgBoxStyle.Information)
                Me.Close()
                Dim frmClientes As New frmClientes(New clientesDAO(myConnectionDB))
                SetPanel(frmClientes, frmMenu.PanelContent)
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
            {"telefono", txtTelefono.Text},
            {"detalles", txtDetalles.Text},
            {"tipo", cboTipo.Text}
        }

        ' Agrega la codificación de la imagen antes de actualizar los datos del cliente
        If VerificarImagen(pbPreview) Then
            ' Codifica la imagen y agrega el resultado al diccionario de nuevos datos
            Dim base64Imagen As String = CodificarImagen(pbPreview.Image, pbPreview)
            nuevosDatos.Add("foto", base64Imagen)
        End If

        ClientesDao.ActualizarCliente(CedulaCliente, nuevosDatos)
        MsgBox("Cliente actualizado correctamente.", MsgBoxStyle.Information)

        ' Cierra el formulario de edición después de la actualización
        Me.Close()
        Dim frmClientes As New frmClientes(New clientesDAO(myConnectionDB))
        SetPanel(frmClientes, frmMenu.PanelContent)
    End Sub

    Private Sub btnSeleccionar_Click(sender As Object, e As EventArgs) Handles btnSeleccionar.Click
        DialogoArchivo(pbPreview)
    End Sub

End Class
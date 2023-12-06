Public Class frmEditarUsuario
    Private ClientesDao As ClientesInterfaces
    Private Property CedulaUsuario As String



    Public Sub New(ClientesDao As ClientesInterfaces, cedula As String)
        InitializeComponent()
        CedulaUsuario = cedula
        Me.ClientesDao = ClientesDao
    End Sub

    Private Sub frmEditarUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Cargar las opciones del ComboBox antes de cargar los datos del usuario
        CargarOpcionesComboBox()

        CargarDatosUsuario()
    End Sub

    Private Sub CargarOpcionesComboBox()
        ' Agrega las opciones para el ComboBox de Rol
        cboRol.Items.Add("SAdmin")
        cboRol.Items.Add("Admin")
        cboRol.Items.Add("Colaborador")
        ' Agrega las opciones para el ComboBox de Género
        cboGenero.Items.Add("Masculino")
        cboGenero.Items.Add("Femenino")

    End Sub


    Private Sub CargarDatosUsuario()
        Dim datosUsuario As DataRow = ClientesDao.ObtenerUsuarioPorCedula(CedulaUsuario)
        Try
            ' Verifica si se encontraron datos para la cédula proporcionada
            If datosUsuario IsNot Nothing Then
                ' Llena los controles del formulario con los datos obtenidos
                txtNombre.Text = datosUsuario("nombre").ToString()
                txtApellido.Text = datosUsuario("apellido").ToString()
                txtCorreo.Text = datosUsuario("correo").ToString()
                txtPass.Text = datosUsuario("pass").ToString()
                cboRol.SelectedItem = datosUsuario("rol").ToString()
                cboGenero.SelectedItem = datosUsuario("genero").ToString()
                txtTelefono.Text = datosUsuario("telefono").ToString()
                txtDetalles.Text = datosUsuario("detalles").ToString()
                'Load the image data from the database And set it to pbPreview
                Dim fotoBase64 As String = datosUsuario("Foto").ToString()
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
        ' Actualiza los datos del usuario utilizando la función en ClientesModule
        Dim nuevosDatos As New Dictionary(Of String, Object) From {
            {"nombre", txtNombre.Text},
            {"apellido", txtApellido.Text},
            {"correo", txtCorreo.Text},
            {"pass", txtPass.Text},
            {"rol", cboRol.SelectedItem.ToString()},
            {"genero", cboGenero.SelectedItem.ToString()},
            {"telefono", txtTelefono.Text},
            {"detalles", txtDetalles.Text}
        }

        ' Agrega la codificación de la imagen antes de actualizar los datos del cliente
        If VerificarImagen(pbPreview) Then
            ' Codifica la imagen y agrega el resultado al diccionario de nuevos datos
            Dim base64Imagen As String = CodificarImagen(pbPreview.Image, pbPreview)
            nuevosDatos.Add("foto", base64Imagen)
        End If


        ClientesDao.ActualizarUsuario(CedulaUsuario, nuevosDatos)
        MsgBox("Usuario actualizado correctamente.", MsgBoxStyle.Information)

        ' Cierra el formulario de edición después de la actualización
        Me.Close()
        Dim frmClientes As New frmClientes(New clientesDAO(myConnectionDB))
        SetPanel(frmClientes, frmMenu.PanelContent)
    End Sub

    Private Sub btnSeleccionar_Click(sender As Object, e As EventArgs) Handles btnSeleccionar.Click
        DialogoArchivo(pbPreview)
    End Sub
End Class
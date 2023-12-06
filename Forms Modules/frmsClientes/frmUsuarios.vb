Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class frmUsuarios

    Private Property CedulaUsuario As String
    Private ClientesDao As ClientesInterfaces

    Public Sub New(cedula As String, ClientesDao As ClientesInterfaces)
        InitializeComponent()
        CedulaUsuario = cedula

        Me.ClientesDao = ClientesDao
    End Sub


    Private Sub frmEditarUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Cargar las opciones del ComboBox antes de cargar los datos del usuario

        CargarDatosUsuario()
    End Sub

    Private Sub CargarDatosUsuario()
        Dim datosUsuario As DataRow = ClientesDao.ObtenerUsuarioPorCedula(CedulaUsuario)

        ' Verifica si se encontraron datos para la cédula proporcionada
        If datosUsuario IsNot Nothing Then
            ' Llena los controles del formulario con los datos obtenidos
            lblNombre.Text = datosUsuario("nombre").ToString()
            lblApellido.Text = datosUsuario("apellido").ToString()
            lblCorreo.Text = datosUsuario("correo").ToString()
            lblGenero.Text = datosUsuario("genero").ToString()
            lblTelefono2.Text = datosUsuario("telefono").ToString()
            txtDetalles.Text = datosUsuario("detalles").ToString()
            lblCedula.Text = datosUsuario("cedula").ToString()
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
    End Sub

End Class
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
            lblTelefono.Text = datosUsuario("telefono").ToString()
            txtDetalles.Text = datosUsuario("detalles").ToString()
            lblCedula.Text = datosUsuario("cedula").ToString()
        Else
            MsgBox("No se encontraron datos para el usuario.", MsgBoxStyle.Information)
            Me.Close()
        End If
    End Sub

End Class
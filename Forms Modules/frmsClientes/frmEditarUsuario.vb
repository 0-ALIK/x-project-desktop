Public Class frmEditarUsuario


    Private Property CedulaUsuario As String

    Public Sub New(cedula As String)
        InitializeComponent()
        CedulaUsuario = cedula
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
        Dim datosUsuario As DataRow = ClientesModule.ObtenerUsuarioPorCedula(CedulaUsuario)

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
        Else
            MsgBox("No se encontraron datos para el usuario.", MsgBoxStyle.Information)
            Me.Close()
        End If
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

        ClientesModule.ActualizarUsuario(CedulaUsuario, nuevosDatos)
        MsgBox("Usuario actualizado correctamente.", MsgBoxStyle.Information)

        ' Cierra el formulario de edición después de la actualización
        Me.Close()
    End Sub


End Class
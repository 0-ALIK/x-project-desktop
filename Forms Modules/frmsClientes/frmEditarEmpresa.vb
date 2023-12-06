Public Class frmEditarEmpresa
    Private Property RucEmpresa As String
    Private ClientesDao As ClientesInterfaces

    Public Sub New(ruc As String, ClientesDao As ClientesInterfaces)
        InitializeComponent()
        RucEmpresa = ruc
        Me.ClientesDao = ClientesDao
    End Sub

    Private Sub frmEditarEmpresa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Cargar las opciones del ComboBox antes de cargar los datos de la empresa
        CargarDatosEmpresa()
    End Sub

    Private Sub CargarDatosEmpresa()
        Dim datosEmpresa As DataRow = ClientesDao.ObtenerEmpresaPorRUC(RucEmpresa)

        If datosEmpresa IsNot Nothing Then
            ' Llena los controles del formulario con los datos obtenidos
            txtNombreEmpresa.Text = datosEmpresa("Nombre").ToString()
            txtCorreoEmpresa.Text = datosEmpresa("Correo").ToString()
            txtRazonSocial.Text = datosEmpresa("Razon_Social").ToString()
            txtDocumento.Text = datosEmpresa("Documento").ToString()
            txtFotoEmpresa.Text = datosEmpresa("Foto").ToString()
            txtTelefonoEmpresa.Text = datosEmpresa("Telefono").ToString()
            txtDetallesEmpresa.Text = datosEmpresa("Detalles").ToString()
            ' ... (continúa con los demás campos)
        Else
            MsgBox("No se encontraron datos para la empresa.", MsgBoxStyle.Information)
            Me.Close()
        End If
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        ' Actualiza los datos de la empresa utilizando la función en ClientesModule
        Dim nuevosDatos As New Dictionary(Of String, Object) From {
            {"Nombre", txtNombreEmpresa.Text},
            {"Correo", txtCorreoEmpresa.Text},
            {"Razon_Social", txtRazonSocial.Text},
            {"Documento", txtDocumento.Text},
            {"Foto", txtFotoEmpresa.Text},
            {"Telefono", txtTelefonoEmpresa.Text},
            {"Detalles", txtDetallesEmpresa.Text}
        }

        ClientesDao.ActualizarEmpresa(RucEmpresa, nuevosDatos)
        MsgBox("Empresa actualizada correctamente.", MsgBoxStyle.Information)

        ' Cierra el formulario de edición después de la actualización
        Me.Close()
    End Sub
End Class
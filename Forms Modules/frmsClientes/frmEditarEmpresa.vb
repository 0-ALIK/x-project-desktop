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
        Try
            If datosEmpresa IsNot Nothing Then
                ' Llena los controles del formulario con los datos obtenidos
                txtNombreEmpresa.Text = datosEmpresa("Nombre").ToString()
                txtCorreoEmpresa.Text = datosEmpresa("Correo").ToString()
                txtRazonSocial.Text = datosEmpresa("Razon_Social").ToString()
                txtDocumento.Text = datosEmpresa("Documento").ToString()
                txtTelefonoEmpresa.Text = datosEmpresa("Telefono").ToString()
                txtDetallesEmpresa.Text = datosEmpresa("Detalles").ToString()
                'Load the image data from the database And set it to pbPreview
                Dim fotoBase64 As String = datosEmpresa("Foto").ToString()
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
        ' Actualiza los datos de la empresa utilizando la función en ClientesModule
        Dim nuevosDatos As New Dictionary(Of String, Object) From {
            {"Nombre", txtNombreEmpresa.Text},
            {"Correo", txtCorreoEmpresa.Text},
            {"Razon_Social", txtRazonSocial.Text},
            {"Documento", txtDocumento.Text},
            {"Telefono", txtTelefonoEmpresa.Text},
            {"Detalles", txtDetallesEmpresa.Text}
        }

        ' Agrega la codificación de la imagen antes de actualizar los datos del cliente
        If VerificarImagen(pbPreview) Then
            ' Codifica la imagen y agrega el resultado al diccionario de nuevos datos
            Dim base64Imagen As String = CodificarImagen(pbPreview.Image, pbPreview)
            nuevosDatos.Add("foto", base64Imagen)
        End If


        ClientesDao.ActualizarEmpresa(RucEmpresa, nuevosDatos)
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
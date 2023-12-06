
Imports FontAwesome.Sharp
Imports MySql.Data.MySqlClient
Public Class frmDetalleTicket
    Private _idTicket As Integer
    Private _estado As String
    Private _usuario As String
    Private ticketsDAO As ticketsInterfaces

    Public Sub New(ticketsDAO As ticketsInterfaces, idTicket As Integer, estado As String, usuario As String)
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        _idTicket = idTicket
        _estado = estado
        _usuario = usuario

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.ticketsDAO = ticketsDAO
    End Sub

    Public Function ObtenerConexion() As MySqlConnection
        Return DB_Conecction.myConnectionDB
    End Function

    Private Sub CargarDetalleTicket()
        Try
            Dim dao As New ticketsDAO(ObtenerConexion())

            Dim detalle As String = dao.ObtenerTicketPorId(_idTicket)

            lblDetalle.Text = detalle
        Catch ex As Exception

            MessageBox.Show("Error al cargar el detalle del ticket: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CargarEvidenciaTicket()
        Try
            Dim dao As New ticketsDAO(ObtenerConexion())
            Dim evidencia As String = dao.ObtenerEvidenciaPorId(_idTicket)
            If (evidencia.Trim <> "") Then
                pbEvidencia.Image = DecodificarImagen(evidencia)
            End If
        Catch ex As Exception
            MessageBox.Show("Error al cargar la evidencia del ticket: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmDetalleTicket_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarDetalleTicket()
        CargarEvidenciaTicket()
        EstadoCbo()
        pbEvidencia.SizeMode = PictureBoxSizeMode.StretchImage
        CustomButton(btnVolver, IconChar.ArrowLeft, "#0d1117", 22)
        CustomButton(btnCambiarEstado, IconChar.FloppyDisk, "#0d1117", 22)
        MapearDatosUsuario()
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        SetPanel(New frmHomeTicket, frmMenu.PanelContent)
    End Sub

    Private Sub EstadoCbo()
        Dim dtEstado As DataTable = ticketsDAO.ObtenerEstado
        If dtEstado.Rows.Count <> 0 Then
            With cboCambiarEstado
                .DataSource = dtEstado
                .ValueMember = "id_tickets_estado"
                .DisplayMember = "estado"
                .SelectedIndex = 1
            End With
        Else
            cboCambiarEstado.DataSource = Nothing
            cboCambiarEstado.Items.Clear()
            cboCambiarEstado.Items.Add("No existen categorias..")
            cboCambiarEstado.SelectedIndex = 1
        End If
    End Sub

    Private Sub btnCambiarEstado_Click(sender As Object, e As EventArgs) Handles btnCambiarEstado.Click
        Dim idEstado As Integer = CInt(cboCambiarEstado.SelectedValue)
        Try
            Dim result As Integer = ticketsDAO.ActualizarEstadoTicket(_idTicket, idEstado)
            If result <> 0 Then
                MsgBox("ESTADO CAMBIADO EXITOSAMENTE")
                SetPanel(New frmHomeTicket(), frmMenu.PanelContent)
            Else
                MsgBox("Error al cambiar el estado del ticket... Intentelo nuevamente")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MapearDatosUsuario()
        lblNumeroTicket.Text = _idTicket
        lblEstado.Text = _estado
        lblUsuario.Text = _usuario
    End Sub

End Class
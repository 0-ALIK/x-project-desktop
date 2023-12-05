Imports MySql.Data.MySqlClient
Public Class frmDetalleTicket
    Private _idTicket As Integer
    Private ticketsDAO As ticketsInterfaces

    Public Sub New(ticketsDAO As ticketsInterfaces, idTicket As Integer)
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        _idTicket = idTicket

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
            pbEvidencia.Image = DecodificarImagen(evidencia)
        Catch ex As Exception
            MessageBox.Show("Error al cargar la evidencia del ticket: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmDetalleTicket_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarDetalleTicket()
        CargarEvidenciaTicket()
        pbEvidencia.SizeMode = PictureBoxSizeMode.StretchImage
        lblNumeroTicket.Text = _idTicket
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        SetPanel(New frmHomeTicket, frmMenu.PanelContent)
    End Sub

End Class
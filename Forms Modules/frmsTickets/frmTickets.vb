Public Class frmTickets
    Private ticketsDAO As ticketsInterfaces
    Public Sub New(ticketsDAO As ticketsInterfaces)
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.ticketsDAO = ticketsDAO
    End Sub
    Private Sub frmTickets_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim dtReclamos As DataTable = ticketsDAO.ObtenerReclamos()
            dgvReclamos.DataSource = dtReclamos
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dgvReclamos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvReclamos.CellContentClick
        SetPanel(New frmDetalleTicket, frmHomeTicket.panelHomeTicket)
    End Sub

End Class
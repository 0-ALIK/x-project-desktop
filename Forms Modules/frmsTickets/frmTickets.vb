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
            Dim dtReclamos As DataTable = ticketsDAO.ObtenerTickets()
            dgvTickets.DataSource = dtReclamos
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dgvTickets_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTickets.CellContentClick
        If dgvTickets.Columns IsNot Nothing AndAlso e.RowIndex >= 0 AndAlso e.ColumnIndex = dgvTickets.Columns("Accion").Index Then
            Dim id As Integer = CInt(dgvTickets.Rows(e.RowIndex).Cells("ID_ticket").Value)
            SetPanel(New frmDetalleTicket(New ticketsDAO(myConnectionDB), id), frmMenu.PanelContent)
        End If

    End Sub

    Private Sub dgvTickets_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvTickets.CellFormatting
        If e.ColumnIndex = dgvTickets.Columns("Prioridad").Index Then
            If e.Value IsNot Nothing Then
                Dim valor As Integer = Convert.ToInt32(e.Value)
                If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
                    If valor = 1 Then
                        dgvTickets.Rows(e.RowIndex).Cells(e.ColumnIndex).Style.ForeColor = Color.Green
                        dgvTickets.Rows(e.RowIndex).Cells(e.ColumnIndex).Style.BackColor = Color.Green
                    ElseIf valor = 2 Then
                        dgvTickets.Rows(e.RowIndex).Cells(e.ColumnIndex).Style.ForeColor = Color.Yellow
                        dgvTickets.Rows(e.RowIndex).Cells(e.ColumnIndex).Style.BackColor = Color.Yellow
                    ElseIf valor = 3 Then
                        dgvTickets.Rows(e.RowIndex).Cells(e.ColumnIndex).Style.ForeColor = Color.Red
                        dgvTickets.Rows(e.RowIndex).Cells(e.ColumnIndex).Style.BackColor = Color.Red
                    End If
                End If
            End If
        End If
    End Sub
End Class
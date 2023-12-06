Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports System.Windows.Interop

Public Class frmTickets
    Private ticketsDAO As ticketsInterfaces
    Dim id_estado As Integer
    Public Sub New(ticketsDAO As ticketsInterfaces)
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.ticketsDAO = ticketsDAO
    End Sub
    Private Sub frmTickets_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarTickets(id_estado)
        cboFiltrarEstado.SelectedIndex = -1
    End Sub

    Private Sub CargarTickets(id_estado)
        Try
            EstadoCbo()
            If cboFiltrarEstado.SelectedValue = Nothing Then
                id_estado = 0
            End If
            Dim dtReclamos As DataTable = ticketsDAO.ObtenerTickets(id_estado)
            dgvTickets.DataSource = dtReclamos
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dgvTickets_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTickets.CellContentClick
        Dim id As Integer
        If dgvTickets.Columns IsNot Nothing AndAlso e.RowIndex >= 0 AndAlso e.ColumnIndex = dgvTickets.Columns("Accion").Index Then
            Dim _estado As String = dgvTickets.Rows(e.RowIndex).Cells("estado").Value
            Dim _usuario As String = dgvTickets.Rows(e.RowIndex).Cells("nombre").Value
            id = CInt(dgvTickets.Rows(e.RowIndex).Cells("ID_ticket").Value)
            SetPanel(New frmDetalleTicket(New ticketsDAO(myConnectionDB), id, _estado, _usuario), frmMenu.PanelContent)
        End If
        If dgvTickets.Columns IsNot Nothing AndAlso e.RowIndex >= 0 AndAlso e.ColumnIndex = dgvTickets.Columns("Eliminar").Index Then
            id = CInt(dgvTickets.Rows(e.RowIndex).Cells("ID_ticket").Value)
            Dim confirmar As DialogResult = MessageBox.Show($"¿Estás seguro de que deseas eliminar el ticket #{id}?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If confirmar = DialogResult.Yes Then
                Try
                    Dim result As Integer = ticketsDAO.EliminarTicket(id)
                    If result <> 0 Then
                        MsgBox("Ticket eliminado exitosamente")
                    Else
                        MsgBox("Error al eliminar su ticket")
                    End If
                    CargarTickets(id_estado)
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
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

        If e.ColumnIndex = dgvTickets.Columns("Asunto").Index Then
            If e.Value IsNot Nothing Then
                If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
                    e.Value = DefinicionesCategorias(e.Value)
                End If
            End If
        End If
    End Sub

    Private Sub EstadoCbo()
        Dim dtEstado As DataTable = ticketsDAO.ObtenerEstado()
        If dtEstado.Rows.Count <> 0 Then
            With cboFiltrarEstado
                .DataSource = dtEstado
                .ValueMember = "id_tickets_estado"
                .DisplayMember = "estado"
            End With
        End If
    End Sub

    Private Sub btnFiltrar_Click(sender As Object, e As EventArgs) Handles btnFiltrar.Click
        CargarTickets(cboFiltrarEstado.SelectedValue)
    End Sub

    Private Sub btnLimpiarFiltro_Click(sender As Object, e As EventArgs) Handles btnLimpiarFiltro.Click
        CargarTickets(0)
        cboFiltrarEstado.SelectedIndex = -1
    End Sub
End Class
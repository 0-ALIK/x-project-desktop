Public Class frmHomeTicket
    Private Sub TicketsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TicketsToolStripMenuItem.Click
        SetPanel(New frmTickets(New ticketsDAO(myConnectionDB)), panelHomeTicket)
    End Sub

    Private Sub frmHomeTicket_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conexionDB()
            myConnectionDB.Open()
            'MsgBox("Conexion Exitosa")
        Catch ex As Exception
            MsgBox("Error al realizar la conexion", "Error: ", ex)
        Finally
            If myConnectionDB.State <> ConnectionState.Closed Then myConnectionDB.Close()
        End Try
    End Sub

    Private Sub CrearTicketsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CrearTicketsToolStripMenuItem.Click
        SetPanel(New frmCrearTickets(New ticketsDAO(myConnectionDB)), panelHomeTicket)
    End Sub

End Class
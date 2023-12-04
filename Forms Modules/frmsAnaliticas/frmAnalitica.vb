Public Class frmAnalitica
    Private Sub frmAnalitica_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Dock = DockStyle.Fill
        panelModulo5.Dock = DockStyle.Fill
        SetPanel(frmMenuReportes, panelModulo5)
        Try
            conexionDB()
            myConnectionDB.Open()
            'MsgBox("Conexion Exitosa")
        Catch ex As Exception
            MsgBox("Error al realizar la conexion", "Error: ", ex.Message)
        Finally
            If myConnectionDB.State <> ConnectionState.Closed Then myConnectionDB.Close()
        End Try
    End Sub

    Private Sub ReportesToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ReportesToolStripMenuItem1.Click
        SetPanel(frmMenuReportes, panelModulo5)
    End Sub
End Class
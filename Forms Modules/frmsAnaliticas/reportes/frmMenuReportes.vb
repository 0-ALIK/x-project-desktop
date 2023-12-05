Public Class frmMenuReportes
    Private Sub InventarioGlobalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InventarioGlobalToolStripMenuItem.Click
        Dim frmReporteInventario As New frmReporteInventario(New analiticaReporteInventarioDAO(myConnectionDB))
        SetPanel(frmReporteInventario, panelTablaReportes)
    End Sub

    Private Sub ReporteDeClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteDeClientesToolStripMenuItem.Click
        Dim frmReporteClientes As New frmReporteClientes(New analiticaReporteInventarioDAO(myConnectionDB))
        SetPanel(frmReporteClientes, panelTablaReportes)
    End Sub

    Private Sub frmMenuReportes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Dock = DockStyle.Fill
    End Sub



End Class
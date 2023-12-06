Imports FontAwesome.Sharp

Public Class frmAyudaDevolucion

    Private Sub frmAyudaDevolucion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CustomButton(btnVolver, IconChar.ArrowLeft, "#0d1117", 35)
    End Sub
    Private Sub btnAyudaPedidos_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        SetPanel(New frmAyuda(), frmMenu.PanelContent)
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub
End Class
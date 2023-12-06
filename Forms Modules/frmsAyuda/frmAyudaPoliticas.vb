Imports FontAwesome.Sharp

Public Class frmAyudaPoliticas
    Private Sub frmAyudaPoliticas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CustomButton(btnVolver, IconChar.ArrowLeft, "#0d1117", 35)
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        SetPanel(New frmAyuda(), frmMenu.PanelContent)
    End Sub
End Class
Public Class frmMenuCliente
    Private Sub btnAyudaUsuario_Click(sender As Object, e As EventArgs) Handles btnAyudaUsuario.Click
        Dim frmClientes As New frmClientes(New clientesDAO(myConnectionDB))
        SetPanel(frmClientes, frmMenu.PanelContent)


    End Sub
End Class
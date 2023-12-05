Imports System.Windows.Documents

Module PanelModule

    Sub SetPanel(objForm As Object, PanelContent As Panel)
        objForm.TopLevel = False
        objForm.FormBorderStyle = FormBorderStyle.None
        objForm.Dock = DockStyle.Fill
        PanelContent.Controls.Clear()
        PanelContent.Controls.Add(objForm)
        objForm.Show()
    End Sub

End Module

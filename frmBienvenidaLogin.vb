﻿Public Class frmBienvenida
    Public Sub New()
        InitializeComponent()
        'Me.FormBorderStyle = FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized
        Me.Dock = DockStyle.Fill
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmMenu.Show()
        Me.Hide()
    End Sub
End Class
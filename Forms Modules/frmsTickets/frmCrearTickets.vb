﻿Imports System.IO
Imports System.Windows
Imports FontAwesome.Sharp
Imports Mysqlx.XDevAPI.Common

Public Class frmCrearTickets

    Private ticketsDAO As ticketsInterfaces
    Private imagePath As String = ""
    Public Sub New(ticketsDAO As ticketsInterfaces)
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.ticketsDAO = ticketsDAO
    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles btnSeleccionar.Click
        DialogoArchivo(pbPreview)
    End Sub

    Private Sub frmCrearTickets_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CustomButton(btnSeleccionar, IconChar.FileImage, "#0d1117", 10)
        CategoriaCbo()
    End Sub

    Private Sub CategoriaCbo()
        Dim dtCategorias As DataTable = ticketsDAO.ObtenerCategorias
        If dtCategorias.Rows.Count <> 0 Then
            For Each row In dtCategorias.Rows
                row("categoria") = DefinicionesCategorias(row("categoria"))
            Next
            With cboCategoria
                .DataSource = dtCategorias
                .ValueMember = "id_tickets_categoria"
                .DisplayMember = "categoria"
                .SelectedIndex = 0
            End With
        Else
            cboCategoria.DataSource = Nothing
            cboCategoria.Items.Clear()
            cboCategoria.Items.Add("No existen categorias..")
            cboCategoria.SelectedIndex = 0
        End If
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim categoriaId As Integer = Convert.ToInt32(cboCategoria.SelectedValue)
        If txtDescripcion.Text.Trim() <> "" And Not IsNumeric(txtDescripcion.Text) Then
            Dim imagenEnBase64 As String = If(VerificarImagen(pbPreview), CodificarImagen(pbPreview.Image, pbPreview), "")
            Try
                Dim result As Integer = ticketsDAO.InsertarTicket(categoriaId, txtDescripcion.Text, DefinicionesCategoriaPrioridad(categoriaId), imagenEnBase64)
                If result <> 0 Then
                    MsgBox("TICKET CREADO EXITOSAMENTE")
                    txtDescripcion.Clear()
                    pbPreview.Image = Nothing
                Else
                    MsgBox("Error al registrar su ticket... Verifique los datos")
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MsgBox("Favor Verifique sus datos.. ")
        End If
    End Sub

End Class
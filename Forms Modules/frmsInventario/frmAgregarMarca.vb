Imports MySql.Data.MySqlClient
Imports Mysqlx.XDevAPI.Common
Public Class frmAgregarMarca
    Dim invenatyDao As New inventaryDAO(myConnectionDB)
    Public MouseDownPosition
    Private Sub frmAgregarMarca_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conexionDB()
            myConnectionDB.Open()
            Dim marcasDataTable As DataTable = invenatyDao.VerMarcas

            For Each row As DataRow In marcasDataTable.Rows
                dgvVerMarcas.Rows.Add(row("id_marca"), row("nombre"))
            Next

        Catch ex As Exception
            MsgBox("Error al realizar la conexión" & vbCrLf & "Error: " & ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            If myConnectionDB.State <> ConnectionState.Closed Then myConnectionDB.Close()
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Si el datagridview está visible, lo oculta
        If dgvVerMarcas.Visible Then
            dgvVerMarcas.Visible = False
        Else
            ' Si el datagridview no está visible, lo muestra
            dgvVerMarcas.Visible = True
        End If
    End Sub

    Private Sub Form1_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown

        ' Guarda la posición del mouse
        MouseDownPosition = e.Location

    End Sub

    Private Sub Form1_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove

        ' Si el datagridview está visible y el mouse no está sobre el botón y el
        ' mouse no está sobre la posición del click inicial, lo oculta
        If dgvVerMarcas.Visible Then
            If Not dgvVerMarcas.HitTest(e.X, e.Y) Is Button1 And Not dgvVerMarcas.Location = MouseDownPosition Then
                dgvVerMarcas.Visible = False
            End If
        End If

    End Sub

    Private Sub dgvVerMarcas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvVerMarcas.CellContentClick
        If dgvVerMarcas.Columns(e.ColumnIndex).Name = "editar" Then
            'aqui agregas lo el codigo para editar la marca
            MsgBox("Edicicon de productos")
        Else
            'aquí agregas el codigo de eliminar marca
            MsgBox("Elimina un producto")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim result As Integer

        Try
            result = invenatyDao.InsertarMarca(txtNombre.Text, txtDescripcion.Text, "hola")

            If result <> 0 Then
                MsgBox("Error al insertar los datos")
            Else
                MsgBox("La marca ha sido insertada")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
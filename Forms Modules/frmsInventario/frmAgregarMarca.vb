Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports MySql.Data.MySqlClient
Imports Mysqlx.XDevAPI.Common
Public Class frmAgregarMarca
    Dim invenatyDao As New inventaryDAO(myConnectionDB)
    Dim idMarca As Integer
    Public MouseDownPosition

    Private Sub btnVerMarcas_Click(sender As Object, e As EventArgs) Handles btnVerMarcas.Click
        Dim marcasDataTable As DataTable
        Try
            dgvVerMarcas.Rows.Clear()

            conexionDB()
            myConnectionDB.Open()
            marcasDataTable = invenatyDao.VerMarcas

            For Each row As DataRow In marcasDataTable.Rows
                dgvVerMarcas.Rows.Add(row("id_marca"), row("nombre"))
            Next

        Catch ex As Exception
            MsgBox("Error al realizar la conexión" & vbCrLf & "Error: " & ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            If myConnectionDB.State <> ConnectionState.Closed Then myConnectionDB.Close()
        End Try

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
            If Not dgvVerMarcas.HitTest(e.X, e.Y) Is btnVerMarcas And Not dgvVerMarcas.Location = MouseDownPosition Then
                dgvVerMarcas.Visible = False
            End If
        End If

    End Sub

    Private Sub dgvVerMarcas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvVerMarcas.CellContentClick

        If dgvVerMarcas.Columns(e.ColumnIndex).Name = "editar" Then
            btnAgregarMarca.Visible = False
            btnActualizarMarca.Visible = True

            If dgvVerMarcas.Visible Then
                dgvVerMarcas.Visible = False
            End If

            Try
                idMarca = Convert.ToInt32(dgvVerMarcas.Rows(e.RowIndex).Cells(0).Value)

                Dim marca As DataTable = invenatyDao.ObtenerMarca(idMarca)

                txtNombre.Text = marca.Rows(0).Item("nombre")
                txtDescripcion.Text = marca.Rows(0).Item("descripcion")

                Dim imagen As Image = If(marca.Rows(0).Item("logo") IsNot DBNull.Value, DecodificarImagen(marca.Rows(0).Item("logo")), Nothing)

                ' Asignar la imagen al PictureBox
                pbMarca.Image = imagen

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        ElseIf e.RowIndex >= 0 AndAlso dgvVerMarcas.Columns(e.ColumnIndex).Name = "eliminar" Then
            ' Aquí agregas el código para eliminar la marca
            idMarca = Convert.ToInt32(dgvVerMarcas.Rows(e.RowIndex).Cells(0).Value) ' Suponiendo que el id_marca es la primera columna

            ' Consultar si hay productos asociados a la marca
            Dim productosAsociados As Boolean = invenatyDao.TieneProductosAsociados(idMarca)

            If productosAsociados Then
                ' Mostrar un mensaje indicando que no se puede eliminar la marca debido a productos asociados
                MessageBox.Show("No puedes eliminar esta marca porque tiene productos asociados. Primero, elimina o cambia la marca de los productos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                ' Abrir la conexión a la base de datos
                conexionDB()
                myConnectionDB.Open()

                Try
                    ' Crear y ejecutar el comando SQL para eliminar la marca
                    Dim command As New MySqlCommand("SP_EliminarMarca", myConnectionDB)
                    command.CommandType = CommandType.StoredProcedure
                    command.Parameters.AddWithValue("@id", idMarca)
                    command.ExecuteNonQuery()

                    ' Actualizar el DataGridView después de la eliminación
                    Dim marcasDataTable As DataTable = invenatyDao.VerMarcas
                    dgvVerMarcas.Rows.Clear()
                    For Each row As DataRow In marcasDataTable.Rows
                        dgvVerMarcas.Rows.Add(row("id_marca"), row("nombre"))
                    Next
                Catch ex As MySqlException
                    ' Otro tipo de error
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    If myConnectionDB.State <> ConnectionState.Closed Then myConnectionDB.Close()
                End Try
            End If
        End If
    End Sub

    Private Sub btnAgregarMarca_Click(sender As Object, e As EventArgs) Handles btnAgregarMarca.Click
        Dim imagenEnBase64 As String = If(VerificarImagen(pbMarca), CodificarImagen(pbMarca.Image, pbMarca), "")

        Try
            Dim result As Integer = invenatyDao.InsertarMarca(txtNombre.Text, txtDescripcion.Text, imagenEnBase64)
            If result <> 0 Then
                MsgBox("Error al insertar los datos")
            Else
                MsgBox("La marca ha sido insertada")
                txtNombre.Clear()
                txtDescripcion.Clear()
                pbMarca.Image = Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btnActualizarMarca_Click(sender As Object, e As EventArgs) Handles btnActualizarMarca.Click
        Dim result As Integer

        Try
            result = invenatyDao.ActualizarMarca(idMarca, txtNombre.Text, txtDescripcion.Text, CodificarImagen(pbMarca.Image, pbMarca))

            If result <> 0 Then
                MsgBox("No se puso actualizar la marca")
                btnActualizarMarca.Visible = True
                btnAgregarMarca.Visible = False
            Else
                MsgBox("La marca ha sido actualizada")
                btnActualizarMarca.Visible = False
                btnAgregarMarca.Visible = True
                txtNombre.Clear()
                txtDescripcion.Clear()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
        DialogoArchivo(pbMarca)
    End Sub

    Private Sub btnCancelUpload_Click(sender As Object, e As EventArgs) Handles btnCancelUpload.Click
        pbMarca.Image = Nothing
    End Sub
End Class
Imports System.IO
Imports FontAwesome.Sharp
Imports MySql.Data.MySqlClient
Imports ZstdSharp.Unsafe

Public Class frmAgregarProducto
    Dim myConnectionDB As MySqlConnection
    Dim productoDao As New inventaryDAO(myConnectionDB)

    Private categoriasCargadas As Boolean = False
    Private marcasCargadas As Boolean = False

    Public Sub New()
        DB_Conecction.conexionDB()

        myConnectionDB = DB_Conecction.myConnectionDB

        InitializeComponent()
    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        If String.IsNullOrEmpty(txtNomProducto.Text) Or String.IsNullOrEmpty(txtPrecioU.Text) Then
            MessageBox.Show("Porfavor llene todos los campos solicitados", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If Not System.Text.RegularExpressions.Regex.IsMatch(txtNomProducto.Text, "^[a-zA-Z\s\-_.,'()]+$") Then
            MessageBox.Show("El nombre no puede contener números.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If Not Decimal.TryParse(txtPrecioU.Text, Nothing) Then
            MessageBox.Show("Ingrese un precio válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If Not Integer.TryParse(txtCantidad.Text, Nothing) Then
            MessageBox.Show("Ingrese una cantidad válida para las cajas.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If Not Integer.TryParse(txtCantPCajas.Text, Nothing) Then
            MessageBox.Show("Ingrese una cantidad válida para las cajas por cantidad.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If Not Integer.TryParse(txtReorden.Text, Nothing) Then
            MessageBox.Show("Ingrese una cantidad válida para el punto de reorden.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Dim selectedImage As String = CodificarImagen(BoxPicture.Image, BoxPicture)

            ' Llamar a la función de la clase productoDao
            If productoDao.InsertarProducto(
                txtNomProducto.Text,
                Decimal.Parse(txtPrecioU.Text),
                If(String.IsNullOrEmpty(txtCantPCajas.Text), Nothing, CInt(txtCantPCajas.Text)),
                If(String.IsNullOrEmpty(txtReorden.Text), Nothing, CInt(txtReorden.Text)),
                If(String.IsNullOrEmpty(txtCantidad.Text), Nothing, CInt(txtCantidad.Text)),
                CInt(BoxMarca.SelectedValue),
                CInt(BoxCategoria.SelectedValue),
                selectedImage
            ) Then
                MessageBox.Show("El producto fue agregado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("Error al agregar el producto: " & ex.Message)
        Finally
        End Try
    End Sub


    Private Sub BoxMarca_DropDown(sender As Object, e As EventArgs) Handles BoxMarca.DropDown
        ' Cargar las marcas solo si aún no se han cargado
        If Not marcasCargadas Then
            ComboBoxMarca()
            marcasCargadas = True
        End If
    End Sub

    Private Sub BoxCategoria_DropDown(sender As Object, e As EventArgs) Handles BoxCategoria.DropDown
        ' Cargar las categorías solo si aún no se han cargado
        If Not categoriasCargadas Then
            ComboBoxCategoria()
            categoriasCargadas = True
        End If
    End Sub


    Private Sub ComboBoxMarca()
        Dim marcaQuery As String = "SELECT id_marca, nombre FROM Marca"
        Dim marcaDataAdapter As New MySqlDataAdapter(marcaQuery, myConnectionDB)
        Dim marcaDataTable As New DataTable()
        marcaDataAdapter.Fill(marcaDataTable)
        BoxMarca.DataSource = marcaDataTable
        BoxMarca.DisplayMember = "nombre"
        BoxMarca.ValueMember = "id_marca"
    End Sub

    Private Sub ComboBoxCategoria()
        Dim categoriaQuery As String = "SELECT id_categoria, nombre FROM Categoria"
        Dim categoriaDataAdapter As New MySqlDataAdapter(categoriaQuery, myConnectionDB)
        Dim categoriaDataTable As New DataTable()
        categoriaDataAdapter.Fill(categoriaDataTable)
        BoxCategoria.DataSource = categoriaDataTable
        BoxCategoria.DisplayMember = "nombre"
        BoxCategoria.ValueMember = "id_categoria"
    End Sub

    Private Sub BtnChoose_Click(sender As Object, e As EventArgs) Handles BtnChoose.Click
        DialogoArchivo(BoxPicture)
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        BoxPicture.Image = Nothing
    End Sub
End Class

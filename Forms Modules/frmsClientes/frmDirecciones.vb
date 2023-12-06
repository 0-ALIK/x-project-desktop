Imports Mysqlx.XDevAPI.Relational

Public Class frmDirecciones
    Private ClientesDao As ClientesInterfaces
    Private Property RUC As String

    Dim direccionSeleccionada As String
    Public Sub New(empresa As String, ClientesDao As ClientesInterfaces)
        InitializeComponent()
        RUC = empresa
        Me.ClientesDao = ClientesDao
    End Sub
    Dim rucEmpresaSeleccionada As String = RUC
    Private Sub frmDirecciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarDireccionesEnDataGridView()
        CargarProvinciasEnComboBox()
    End Sub

    Private Sub CargarProvinciasEnComboBox()
        ' Array o lista con los nombres de las provincias
        Dim provinciasPanama() As String = {"Bocas del Toro", "Coclé", "Colón", "Chiriquí", "Darién", "Herrera", "Los Santos", "Panamá", "Veraguas", "Panamá Oeste"}

        ' Asigna la lista de provincias al DataSource del ComboBox
        cmbProvinciaEDIT.DataSource = provinciasPanama
        cmbProvincia.DataSource = provinciasPanama
    End Sub

    Private Sub CargarDireccionesEnDataGridView()
        Try
            ' Llama a la función del módulo para obtener las empresas
            Dim datosDireccion As DataTable = ClientesDao.Obtener_id_empresaPorRUC(RUC)
            rucEmpresaSeleccionada = RUC

            ' Limpia las filas existentes en el DataGridView de Empresas
            dtgDireccionEmpresas.Rows.Clear()

            ' Itera sobre las filas del DataTable y llena las filas correspondientes en el DataGridView de Empresas
            For Each row As DataRow In datosDireccion.Rows
                ' Asegúrate de que las columnas en el DataGridView tengan los mismos nombres que en el DataTable de Empresas
                Dim provincia As String = row("nombre").ToString()
                Dim codigo_postal As String = row("codigo_postal").ToString()
                Dim telefono As String = row("telefono").ToString()
                Dim detalles As String = row("detalles").ToString()
                Dim id_direccion As String = row("id_direccion").ToString()

                ' Agrega una nueva fila al DataGridView de Empresas y asigna los valores
                dtgDireccionEmpresas.Rows.Add(provincia, codigo_postal, telefono, detalles, id_direccion)
            Next
        Catch ex As Exception
            ' Maneja las excepciones aquí según tu lógica
            MsgBox("Error al cargar datos: " & ex.Message)
        End Try
    End Sub


    Private Sub CambioSeleccionDGV(sender As Object, e As EventArgs) Handles dtgDireccionEmpresas.SelectionChanged
        ' Verifica si hay alguna fila seleccionada
        If dtgDireccionEmpresas.SelectedRows.Count > 0 Then
            ' Obtiene la fila seleccionada
            Dim filaSeleccionada As DataGridViewRow = dtgDireccionEmpresas.SelectedRows(0)

            ' Obtiene los valores de las celdas de la fila seleccionada
            Dim provincia As String = filaSeleccionada.Cells("nombre").Value.ToString()
            Dim codigoPostal As String = filaSeleccionada.Cells("codigo_postal").Value.ToString()
            Dim telefono As String = filaSeleccionada.Cells("telefono").Value.ToString()
            Dim detalles As String = filaSeleccionada.Cells("detalles").Value.ToString()
            Dim id_direccion As String = filaSeleccionada.Cells("idDireccion").Value.ToString()

            direccionSeleccionada = id_direccion
            ' Asigna los valores a los TextBox
            txtCodigoPostEDIT.Text = codigoPostal
            txtTelefonoEDIT.Text = telefono
            txtDetallesEDIT.Text = detalles
        End If
    End Sub

    Private Sub rdbEditar_CheckedChanged(sender As Object, e As EventArgs) Handles rdbEditar.CheckedChanged, rdbAddDireccion.CheckedChanged
        If rdbEditar.Checked = True Then
            gboEditar.Visible = True
            gboAddDireccion.Visible = False
        Else
            gboEditar.Visible = False
            gboAddDireccion.Visible = True
        End If
    End Sub

    Private Sub btnGuardarCambios_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        ' Obtén los valores del formulario
        Dim provincia As String = cmbProvincia.SelectedIndex + 1
        Dim telefono As String = txtTelefono.Text
        Dim detalles As String = txtDetalles.Text
        Dim codigoPostal As String = txtCodigoPost.Text
        Dim ruc As String = rucEmpresaSeleccionada

        ' Llama a la función para insertar la dirección con los valores del formulario
        ClientesDao.InsertarDireccionEmpresa(provincia, telefono, detalles, codigoPostal, ruc)
    End Sub

    Private Sub RealizarActualizacion(sender As Object, e As EventArgs) Handles btnActualizar.Click
        ' Actualiza los datos del cliente utilizando la función en ClientesModule
        Dim provincia As String = cmbProvinciaEDIT.SelectedIndex + 1
        Dim telefono As String = txtTelefonoEDIT.Text
        Dim detalles As String = txtDetallesEDIT.Text
        Dim codigoPostal As String = txtCodigoPostEDIT.Text


        ClientesDao.ActualizarDireccionEmpresa(provincia, telefono, detalles, codigoPostal, direccionSeleccionada)
        Me.Close()
        Dim frmClientes As New frmClientes(New clientesDAO(myConnectionDB))
        SetPanel(frmClientes, frmMenu.PanelContent)
    End Sub

    Private Sub EliminarDireccion(sender As Object, e As EventArgs) Handles btnEliminarDireccion.Click
        If dtgDireccionEmpresas.SelectedRows.Count > 0 Then
            Dim respuesta As DialogResult = MessageBox.Show("¿Está seguro de eliminar esta direccion?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If respuesta = DialogResult.Yes Then
                ClientesDao.EliminarDireccionEmpresaPorID(direccionSeleccionada)
                CargarDireccionesEnDataGridView()
            End If
        Else
            MsgBox("Seleccione una fila para eliminar.", MsgBoxStyle.Information)
        End If
    End Sub


End Class
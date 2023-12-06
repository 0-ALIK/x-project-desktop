Imports System.Runtime.ConstrainedExecution
Imports Mysqlx.XDevAPI.Relational

Public Class frmDireccionesClientes
    Private ClientesDao As ClientesInterfaces
    Private Property ced As String

    Dim direccionSeleccionada As String
    Public Sub New(cedula As String, ClientesDAO As ClientesInterfaces)
        InitializeComponent()
        ced = cedula
        Me.ClientesDao = ClientesDAO
    End Sub
    Dim cedClienteSeleccionado As String = ced
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
            ' Llama a la función del módulo para obtener las de clientes
            Dim datosDireccion As DataTable = ClientesDao.Obtener_id_clientePorCEDULA(ced)
            cedClienteSeleccionado = ced

            ' Limpia las filas existentes en el DataGridView de clientes
            dgvClienteDir.Rows.Clear()

            ' Itera sobre las filas del DataTable y llena las filas correspondientes en el DataGridView de clientes
            For Each row As DataRow In datosDireccion.Rows
                ' Asegúrate de que las columnas en el DataGridView tengan los mismos nombres que en el DataTable de clientes
                Dim provincia As String = row("nombre").ToString()
                Dim codigo_postal As String = row("codigo_postal").ToString()
                Dim telefono As String = row("telefono").ToString()
                Dim detalles As String = row("detalles").ToString()
                Dim cedula As String = row("cedula").ToString()
                Dim id As String = row("idDireccion").ToString()


                ' Agrega una nueva fila al DataGridView de clientes y asigna los valores
                dgvClienteDir.Rows.Add(provincia, codigo_postal, telefono, detalles, cedula, id)
            Next
        Catch ex As Exception
            ' Maneja las excepciones aquí según tu lógica
            MsgBox("Error al cargar datos: " & ex.Message)
        End Try
    End Sub


    Private Sub CambioSeleccionDGV(sender As Object, e As EventArgs) Handles dgvClienteDir.SelectionChanged
        ' Verifica si hay alguna fila seleccionada
        If dgvClienteDir.SelectedRows.Count > 0 Then
            ' Obtiene la fila seleccionada
            Dim filaSeleccionada As DataGridViewRow = dgvClienteDir.SelectedRows(0)

            ' Obtiene los valores de las celdas de la fila seleccionada
            Dim provincia As String = filaSeleccionada.Cells("nombre").Value.ToString()
            Dim codigoPostal As String = filaSeleccionada.Cells("codigo_postal").Value.ToString()
            Dim telefono As String = filaSeleccionada.Cells("telefono").Value.ToString()
            Dim detalles As String = filaSeleccionada.Cells("detalles").Value.ToString()
            Dim cedula As String = filaSeleccionada.Cells("cedula").Value.ToString()
            Dim id As String = filaSeleccionada.Cells("idDireccion").Value.ToString()

            direccionSeleccionada = id
            ' Asigna los valores a los TextBox
            txtCodigoPEDIT.Text = codigoPostal
            txtTelefonoEDIT.Text = telefono
            txtDetallesEDIT.Text = detalles
        End If
    End Sub

    Private Sub rdbEditar_CheckedChanged(sender As Object, e As EventArgs) Handles rdbEditar.CheckedChanged, rdbAnadir.CheckedChanged
        If rdbEditar.Checked = True Then
            gboEditar.Visible = True
            gboAnadir.Visible = False
        Else
            gboEditar.Visible = False
            gboAnadir.Visible = True
        End If
    End Sub

    Private Sub btnGuardarCambios_Click(sender As Object, e As EventArgs) Handles btnAnadir.Click
        ' Obtén los valores del formulario
        Dim provincia As String = cmbProvincia.SelectedIndex + 1
        Dim telefono As String = txtTelefono.Text
        Dim detalles As String = txtDetalle.Text
        Dim codigoPostal As String = txtCodigoP.Text
        Dim cedula As String = cedClienteSeleccionado

        ' Llama a la función para insertar la dirección con los valores del formulario
        ClientesDao.InsertarDireccionCliente(provincia, telefono, detalles, codigoPostal, cedula)
    End Sub

    Private Sub RealizarActualizacion(sender As Object, e As EventArgs) Handles btnActualzar.Click
        ' Actualiza los datos del cliente utilizando la función en ClientesModule
        Dim provincia As String = cmbProvinciaEDIT.SelectedIndex + 1
        Dim telefono As String = txtTelefonoEDIT.Text
        Dim detalles As String = txtDetallesEDIT.Text
        Dim codigoPostal As String = txtCodigoPEDIT.Text


        ClientesDao.ActualizarDireccionCliente(provincia, telefono, detalles, codigoPostal, direccionSeleccionada)
        Me.Close()
        Dim frmClientes As New frmClientes(New clientesDAO(myConnectionDB))
        SetPanel(frmClientes, frmMenu.PanelContent)
    End Sub

    Private Sub EliminarDireccion(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If dgvClienteDir.SelectedRows.Count > 0 Then
            Dim respuesta As DialogResult = MessageBox.Show("¿Está seguro de eliminar esta direccion?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If respuesta = DialogResult.Yes Then
                MsgBox(direccionSeleccionada)
                ClientesDao.EliminarDireccionClientePorID(direccionSeleccionada)
                CargarDireccionesEnDataGridView()
            End If
        Else
            MsgBox("Seleccione una fila para eliminar.", MsgBoxStyle.Information)
        End If
    End Sub
End Class
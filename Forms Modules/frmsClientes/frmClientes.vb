Imports MySql.Data.MySqlClient
Imports System.Data

Public Class frmClientes
    Private ClientesDao As ClientesInterfaces

    Public Sub New(ClientesDao As ClientesInterfaces)
        InitializeComponent()

        Me.ClientesDao = ClientesDao
    End Sub
    Private Sub frmClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Llama a la función del módulo para obtener los usuarios y llenar el DataGridView
        CargarUsuariosEnDataGridView()

        ' Llama a la función del módulo para obtener las empresas y llenar el DataGridView de Empresas
        CargarEmpresasEnDataGridView()

        ' Llama a la función del módulo para obtener los clientes y llenar el DataGridView
        CargarClientesEnDataGridView()
    End Sub

    Private Sub CargarUsuariosEnDataGridView()
        Try
            ' Llama a la función del módulo para obtener los usuarios
            Dim dtUsuarios As DataTable = ClientesDao.ObtenerUsuarios()

            ' Limpia las filas existentes en el DataGridView
            dtgUsuarios.Rows.Clear()

            ' Itera sobre las filas del DataTable y llena las filas correspondientes en el DataGridView
            For Each row As DataRow In dtUsuarios.Rows
                ' Asegúrate de que las columnas en el DataGridView tengan los mismos nombres que en el DataTable
                Dim cedula As String = row("cedula").ToString()
                Dim nombre As String = row("nombre").ToString()
                Dim apellido As String = row("apellido").ToString()
                Dim correo As String = row("correo").ToString()
                Dim pass As String = row("pass").ToString()
                Dim rol As String = row("rol").ToString()
                Dim genero As String = row("genero").ToString()
                Dim foto As String = row("foto").ToString()
                Dim telefono As String = row("telefono").ToString()
                Dim detalles As String = row("detalles").ToString()

                ' Agrega una nueva fila al DataGridView y asigna los valores
                dtgUsuarios.Rows.Add(cedula, nombre, apellido, correo, pass, rol, genero, foto, telefono, detalles)
            Next
        Catch ex As Exception
            ' Maneja las excepciones aquí según tu lógica
            MsgBox("Error al cargar usuarios en el DataGridView: " & ex.Message)
        End Try
    End Sub


    Private Sub CargarEmpresasEnDataGridView()
        Try
            ' Llama a la función del módulo para obtener las empresas
            Dim dtEmpresas As DataTable = ClientesDao.ObtenerEmpresas()

            ' Limpia las filas existentes en el DataGridView de Empresas
            dtgEmpresas.Rows.Clear()

            ' Itera sobre las filas del DataTable y llena las filas correspondientes en el DataGridView de Empresas
            For Each row As DataRow In dtEmpresas.Rows
                ' Asegúrate de que las columnas en el DataGridView tengan los mismos nombres que en el DataTable de Empresas
                Dim ruc As String = row("RUC").ToString()
                Dim nombreEmpresa As String = row("Nombre").ToString()
                Dim correoEmpresa As String = row("Correo").ToString()
                Dim razonSocial As String = row("Razon_Social").ToString()
                Dim documento As String = row("Documento").ToString()
                Dim fotoEmpresa As String = row("Foto").ToString()
                Dim telefonoEmpresa As String = row("Telefono").ToString()
                Dim detallesEmpresa As String = row("Detalles").ToString()

                ' Agrega una nueva fila al DataGridView de Empresas y asigna los valores
                dtgEmpresas.Rows.Add(ruc, nombreEmpresa, correoEmpresa, razonSocial, documento, fotoEmpresa, telefonoEmpresa, detallesEmpresa)
            Next
        Catch ex As Exception
            ' Maneja las excepciones aquí según tu lógica
            MsgBox("Error al cargar empresas en el DataGridView de Empresas: " & ex.Message)
        End Try
    End Sub


    Private Sub CargarClientesEnDataGridView()
        Try
            ' Llama a la función del módulo para obtener los clientes
            Dim dtClientes As DataTable = ClientesDao.ObtenerClientes()

            ' Limpia las filas existentes en el DataGridView de Clientes
            dtgClientes.Rows.Clear()

            ' Itera sobre las filas del DataTable y llena las filas correspondientes en el DataGridView de Clientes
            For Each row As DataRow In dtClientes.Rows
                ' Asegúrate de que las columnas en el DataGridView tengan los mismos nombres que en el DataTable de Clientes
                Dim nombre As String = row("Nombre").ToString()
                Dim apellido As String = row("Apellido").ToString()
                Dim cedula As String = row("Cedula").ToString()
                Dim empresaId As String = row("Empresa_id").ToString()
                Dim genero As String = row("Genero").ToString()
                Dim foto As String = row("Foto").ToString()
                Dim telefono As String = row("Telefono").ToString()
                Dim detalles As String = row("Detalles").ToString()
                Dim tipo As String = row("Tipo").ToString()

                ' Agrega una nueva fila al DataGridView de Clientes y asigna los valores
                dtgClientes.Rows.Add(nombre, apellido, cedula, empresaId, genero, foto, telefono, detalles, tipo)
            Next
        Catch ex As Exception
            ' Maneja las excepciones aquí según tu lógica
            MsgBox("Error al cargar clientes en el DataGridView: " & ex.Message)
        End Try
    End Sub


    Private Sub btnEliminarUsuario_Click(sender As Object, e As EventArgs) Handles btnEliminarUsuario.Click
        If dtgUsuarios.SelectedRows.Count > 0 Then
            Dim cedula As String = dtgUsuarios.SelectedRows(0).Cells("Cedula").Value.ToString()
            Dim respuesta As DialogResult = MessageBox.Show("¿Está seguro de eliminar este usuario?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If respuesta = DialogResult.Yes Then
                ClientesDao.EliminarUsuarioPorCedula(cedula)
                CargarUsuariosEnDataGridView()
            End If
        Else
            MsgBox("Seleccione una fila para eliminar.", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub btnEliminarEmpresa_Click(sender As Object, e As EventArgs) Handles btnEliminarEmpresa.Click
        If dtgEmpresas.SelectedRows.Count > 0 Then
            Dim ruc As String = dtgEmpresas.SelectedRows(0).Cells("RUC").Value.ToString()
            Dim respuesta As DialogResult = MessageBox.Show("¿Está seguro de eliminar esta empresa?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If respuesta = DialogResult.Yes Then
                ClientesDao.EliminarEmpresaPorRUC(ruc)
                CargarEmpresasEnDataGridView()
            End If
        Else
            MsgBox("Seleccione una fila para eliminar.", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub btnEliminarCliente_Click(sender As Object, e As EventArgs) Handles btnEliminarCliente.Click
        If dtgClientes.SelectedRows.Count > 0 Then
            Dim cedula As String = dtgClientes.SelectedRows(0).Cells("Cedulacl").Value.ToString()
            Dim respuesta As DialogResult = MessageBox.Show("¿Está seguro de eliminar este cliente?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If respuesta = DialogResult.Yes Then
                ClientesDao.EliminarClientePorCedula(cedula)
                CargarClientesEnDataGridView()
            End If
        Else
            MsgBox("Seleccione una fila para eliminar.", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub btnEditarUsuario_Click(sender As Object, e As EventArgs) Handles btnEditarUsuario.Click
        ' Verifica que se haya seleccionado una fila
        If dtgUsuarios.SelectedRows.Count > 0 Then
            ' Obtiene la cédula del usuario seleccionado
            Dim cedula As String = dtgUsuarios.SelectedRows(0).Cells("Cedula").Value.ToString()

            Dim frmEditarUsuario As New frmEditarUsuario(New clientesDAO, cedula)
            SetPanel(frmEditarUsuario, PanelClientes)

            CargarUsuariosEnDataGridView()
        Else
            MsgBox("Seleccione una fila para editar.", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub btnEditarEmpresa_Click(sender As Object, e As EventArgs) Handles btnEditarEmpresa.Click
        If dtgEmpresas.SelectedRows.Count > 0 Then
            Dim ruc As String = dtgEmpresas.SelectedRows(0).Cells("RUC").Value.ToString()
            Dim frmEditarEmpresa As New frmEditarEmpresa(ruc)
            Dim frmEditarUsuario As New frmEditarEmpresa(New analiticaReporteInventarioDAO(myConnectionDB), Cedula)
            SetPanel(frmEditarUsuario, PanelClientes)

            CargarEmpresasEnDataGridView()
        Else
            MsgBox("Seleccione una fila para editar.", MsgBoxStyle.Information)
        End If
    End Sub


    Private Sub btnEditarCliente_Click(sender As Object, e As EventArgs) Handles btnEditarCliente.Click
        ' Verifica si se ha seleccionado una fila en el DataGridView de Clientes
        If dtgClientes.SelectedRows.Count > 0 Then
            ' Obtiene la cédula del cliente seleccionado
            Dim cedula As String = dtgClientes.SelectedRows(0).Cells("Cedulacl").Value.ToString()

            ' Abre el formulario de edición pasando la cédula como parámetro
            Dim frmEditarCliente As New frmEditarCliente(cedula)
            frmEditarCliente.MdiParent = Me.MdiParent
            frmEditarCliente.WindowState = FormWindowState.Maximized
            frmEditarCliente.Show()

            ' Vuelve a cargar los clientes en el DataGridView después de la edición
            CargarClientesEnDataGridView()
        Else
            MsgBox("Seleccione una fila para editar.", MsgBoxStyle.Information)
        End If
    End Sub
End Class

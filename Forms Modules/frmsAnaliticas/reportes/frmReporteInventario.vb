Imports FontAwesome.Sharp
Imports MySql.Data.MySqlClient

Public Class frmReporteInventario
    Private analiticaReporteInventarioDao As analitycInterfaces
    Dim id_marca As Integer
    Dim id_categoria As Integer

    Public Sub New(analiticaReporteInventarioDAO As analitycInterfaces)
        InitializeComponent()
        Me.analiticaReporteInventarioDao = analiticaReporteInventarioDAO
    End Sub

    Private Sub frmReporteInventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Dock = DockStyle.Fill
        cargarInventario(id_marca, id_categoria)
        cboxMarcas.SelectedIndex = -1
        cboxCategorias.SelectedIndex = -1

    End Sub

    Private Sub cargarInventario(id_marca, id_categoria)
        cargarCategorias()
        cargarMarcas()
        If cboxCategorias.SelectedValue = Nothing Then
            id_categoria = 0
        End If

        If cboxMarcas.SelectedValue = Nothing Then
            id_marca = 0
        End If

        Dim inventarioDataTable As DataTable = analiticaReporteInventarioDao.ObtenerInventarioSegmentado(id_marca, id_categoria)
        Me.Dock = DockStyle.Fill
        dgvInventarioReporte.DataSource = inventarioDataTable
        dgvInventarioReporte.Columns("precio_unit").HeaderText = "Precio Unitario"
        dgvInventarioReporte.Columns("cantidad_por_cajas").HeaderText = "Cant. por Cajas"
        dgvInventarioReporte.Columns("punto_reorden").HeaderText = "Punto de reorden"
        dgvInventarioReporte.Columns("cantidad_cajas").HeaderText = "Cant. de Cajas"
        dgvInventarioReporte.Columns("nombre_marca").HeaderText = "Marca"
        dgvInventarioReporte.Columns("nombre_categoria").HeaderText = "Categoría"

        lblCantProductos.Text = contabilizar("nombre", inventarioDataTable)
        lblCantCategorias.Text = contabilizar("nombre_categoria", inventarioDataTable)
        lblCantMarcas.Text = contabilizar("nombre_marca", inventarioDataTable)
    End Sub

    Private Sub cargarMarcas()

        Dim categoriasDataTable As DataTable = analiticaReporteInventarioDao.ObtenerCategorias
        With cboxCategorias
            .DataSource = categoriasDataTable
            .ValueMember = "id_categoria"
            .DisplayMember = "nombre"
        End With

    End Sub

    Private Sub cargarCategorias()
        Dim marcasDataTable As DataTable = analiticaReporteInventarioDao.ObtenerMarcas()
        With cboxMarcas
            .DataSource = marcasDataTable
            .ValueMember = "id_marca"
            .DisplayMember = "nombre"
        End With

    End Sub

    Function contabilizar(columna As String, inventario As DataTable)
        Dim cantidad As Integer = inventario.AsEnumerable().
                                 Select(Function(row) row.Field(Of String)(columna)).
                                 Distinct().
                                 Count()
        Return cantidad
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        cargarInventario(cboxMarcas.SelectedValue, cboxCategorias.SelectedValue)
        cboxMarcas.SelectedIndex = -1
        cboxCategorias.SelectedIndex = -1
    End Sub

    Private Sub btnExportarExcel_Click(sender As Object, e As EventArgs) Handles btnExportarExcel.Click
        analiticaReporteInventarioDao.ExportarExcel(dgvInventarioReporte)
    End Sub

End Class
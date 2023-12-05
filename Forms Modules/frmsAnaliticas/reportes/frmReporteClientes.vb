Public Class frmReporteClientes
    Private analiticaReporteClientesDAO As analitycReporteInterfaces
    Dim id_provincia As Integer = 0
    Dim id_producto As Integer = 0

    Public Sub New(analiticaReporteClientesDAO As analitycReporteInterfaces)
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.analiticaReporteClientesDAO = analiticaReporteClientesDAO
    End Sub

    Private Sub frmReporteClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Dock = DockStyle.Fill
        cargarClientesYCompras(id_provincia, id_producto)
        cboxProvincias.SelectedIndex = -1
        cboxProductos.SelectedIndex = -1
    End Sub

    Private Sub cargarClientesYCompras(id_provincia, id_producto)
        cargarProvincias()
        cargarProductos()
        If cboxProvincias.SelectedValue = Nothing Then
            id_provincia = 0
        End If
        If cboxProductos.SelectedValue = Nothing Then
            id_producto = 0
        End If

        Dim clientesYComprasDataTable As DataTable = analiticaReporteClientesDAO.ObtenerClientesYCompras(id_provincia, id_producto)
        dgvReporteClientes.DataSource = clientesYComprasDataTable
        dgvReporteClientes.Columns("pedido_id").HeaderText = "Identificador de Pedido"
        dgvReporteClientes.Columns("fecha_pedido").HeaderText = "Fecha del Pedido"
        dgvReporteClientes.Columns("cliente_id").HeaderText = "Identificador del Cliente"
        dgvReporteClientes.Columns("cliente_nombre").HeaderText = "Cliente"
        dgvReporteClientes.Columns("empresa_nombre").HeaderText = "Empresa"
        dgvReporteClientes.Columns("provincia_nombre").HeaderText = "Provincia"
        dgvReporteClientes.Columns("producto_nombre").HeaderText = "Producto"
        dgvReporteClientes.Columns("estado_pedido").HeaderText = "Estado del Pedido"
        dgvReporteClientes.Columns("total_compras").HeaderText = "Compras totales"
    End Sub

    Private Sub cargarProvincias()
        Dim provinciasDataTable As DataTable = analiticaReporteClientesDAO.ObtenerProvincias
        With cboxProvincias
            .DataSource = provinciasDataTable
            .ValueMember = "id_provincia"
            .DisplayMember = "nombre"
        End With
    End Sub

    Private Sub cargarProductos()
        Dim productosDataTable As DataTable = analiticaReporteClientesDAO.ObtenerProductos
        With cboxProductos
            .DataSource = productosDataTable
            .ValueMember = "id_producto"
            .DisplayMember = "nombre"
        End With
    End Sub

    Private Sub btnAplicarFiltros_Click(sender As Object, e As EventArgs) Handles btnAplicarFiltros.Click

        cargarClientesYCompras(cboxProvincias.SelectedValue, cboxProductos.SelectedValue)
    End Sub

    Private Sub btnEliminarFiltros_Click(sender As Object, e As EventArgs) Handles btnEliminarFiltros.Click
        cargarClientesYCompras(0, 0)
        cboxProductos.SelectedIndex = -1
        cboxProvincias.SelectedIndex = -1
    End Sub

    Private Sub btnDescargarReporte_Click(sender As Object, e As EventArgs) Handles btnDescargarReporte.Click
        ExportarArchivos.ExportarAExcel(dgvReporteClientes)
    End Sub
End Class
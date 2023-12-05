Public Interface analitycReporteInterfaces
    '
    'Reportes de inventario
    '
    Function ObtenerInventarioSegmentado(id_marca As Integer, id_categoria As Integer) As DataTable
    Function ObtenerMarcas() As DataTable
    Function ObtenerCategorias() As DataTable
    Function ExportarExcel(ByVal dgv As DataGridView) As Integer
    '
    'Reportes de clientes
    '
    Function ObtenerClientesYCompras(id_provincia, id_producto) As DataTable
    Function ObtenerProductos() As DataTable
    Function ObtenerProvincias() As DataTable
    '
    'Reporte de finanzas
    '
End Interface

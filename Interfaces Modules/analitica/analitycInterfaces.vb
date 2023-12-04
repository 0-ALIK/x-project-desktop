Public Interface analitycInterfaces
    Function ObtenerInventarioSegmentado(id_marca As Integer, id_categoria As Integer) As DataTable
    Function ObtenerMarcas() As DataTable
    Function ObtenerCategorias() As DataTable
    Function ExportarExcel(ByVal dgv As DataGridView) As Integer
End Interface

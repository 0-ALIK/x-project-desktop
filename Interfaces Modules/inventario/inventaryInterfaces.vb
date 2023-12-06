Public Interface inventaryInterfaces

    'Select que despliega todos los productos del inventario en el datagridview
    Function VerInventario() As DataTable

    'Select - Insert - Update - Delete -> Productos
    Function VerProductos() As DataTable
    Function InsertarProducto(nombre As String, precioUnitario As Decimal, cantidadPorCajas As Integer?, puntoReorden As Integer?, cantidadCajas As Integer?, marcaId As Integer, categoriaId As Integer, imagen As Image) As Boolean
    Function ActualizarProducto() As Integer
    Function EliminarProducto(idProducto As Integer) As Integer

    'Select - Insert - Update - Delete -> Marcas
    Function VerMarcas() As DataTable
    Function ObtenerMarca(ByVal id_marca As Integer) As DataTable
    Function InsertarMarca(ByVal nombre As String, ByVal descripcion As String, ByVal logo As String) As Integer
    Function ActualizarMarca(ByVal id As Integer, ByVal nombre As String, ByVal descripcion As String, ByVal logo As String) As Integer
    Function EliminarMarca() As Integer

    'Select - Insert - Update - Delete -> Categorias
    Function VerCategorias() As DataTable
    Function InsertaCategorias() As Integer
    Function ActualizarCategorias() As Integer
    Function EliminarCategorias(idCategoria As Integer) As Integer

End Interface
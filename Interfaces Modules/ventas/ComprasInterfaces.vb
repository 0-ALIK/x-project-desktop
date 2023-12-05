Public Interface ComprasInterfaces
    Function RealizarCompra(fecha As DateTime, cantidad As Integer, idProducto As Integer, idCliente As Integer) As Integer
    Function ObtenerProductos() As DataTable
    Function ObtenerClientes() As DataTable
End Interface
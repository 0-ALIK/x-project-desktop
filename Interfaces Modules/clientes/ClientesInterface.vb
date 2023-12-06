Public Interface ClientesInterfaces
    Function ObtenerUsuarios() As DataTable
    Function ObtenerEmpresas() As DataTable
    Function ObtenerClientes() As DataTable

    Sub EliminarUsuarioPorCedula(cedula As String)
    Sub EliminarEmpresaPorRUC(ruc As String)
    Sub EliminarClientePorCedula(cedula As String)

    Function ObtenerUsuarioPorCedula(cedula As String) As DataRow
    Sub ActualizarUsuario(cedula As String, nuevosDatos As Dictionary(Of String, Object))

    Function ObtenerEmpresaPorRUC(ruc As String) As DataRow
    Sub ActualizarEmpresa(ruc As String, nuevosDatos As Dictionary(Of String, Object))

    Sub ActualizarCliente(cedula As String, nuevosDatos As Dictionary(Of String, Object))
    Function ObtenerClientePorCedula(cedula As String) As DataRow

    Function Obtener_id_empresaPorRUC(ruc As String) As DataTable

    Function InsertarDireccionEmpresa(provincia As String, telefono As String, detalles As String, codigoPostal As String, ruc As String)

    Sub ActualizarDireccionEmpresa(provincia As String, telefono As String, detalles As String, codigoPostal As String, id As String)

    Sub EliminarDireccionEmpresaPorID(id As String)

    Function Obtener_id_clientePorCEDULA(cedula As String) As DataTable

    Function InsertarDireccionCliente(provincia As String, telefono As String, detalles As String, codigoPostal As String, cedula As String)

    Sub ActualizarDireccionCliente(provincia As String, telefono As String, detalles As String, codigoPostal As String, id As String)

    Sub EliminarDireccionClientePorID(id As String)



End Interface


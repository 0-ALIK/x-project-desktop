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
End Interface

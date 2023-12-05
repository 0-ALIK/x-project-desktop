Public Interface loginInterface
    Function InsertarUsuario(ByVal nombre As String, ByVal correo As String, ByVal pass As String, ByVal rol As String) As Integer
    Function EncriptarPass(pass As String) As Integer

End Interface

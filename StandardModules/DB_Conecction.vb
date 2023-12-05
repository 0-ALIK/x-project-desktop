Imports MySql.Data.MySqlClient
Imports System.Xml
Module DB_Conecction
    Public myConnectionDB As MySqlConnection

    Sub conexionDB()
        Dim cadenaConec As String
        Dim servidorDb As String = "", nameDb As String = "", usuario As String = "", pass As String = ""
        lecturaXML(servidorDb, nameDb, usuario, pass)
        cadenaConec = "server=" & servidorDb & ";database=" & nameDb & ";userid=" & usuario & ";password=" & pass
        myConnectionDB = New MySqlConnection(cadenaConec)
    End Sub

    Public Function decobeBase64(ByVal mensaje As String) As String
        Return System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(mensaje))
    End Function

    Sub lecturaXML(ByRef servidorDb As String, ByRef nameDb As String, ByRef usuario As String, ByRef pass As String)
        Dim mxml As XmlTextReader
        mxml = New XmlTextReader("../../Resources/dataConfig.xml")
        mxml.Read()
        While Not mxml.EOF
            mxml.Read()
            If Not mxml.IsStartElement Then
                Exit While
            End If
            mxml.Read()
            servidorDb = decobeBase64(mxml.ReadElementString("serverDb"))
            nameDb = decobeBase64(mxml.ReadElementString("dbName"))
            usuario = decobeBase64(mxml.ReadElementString("user"))
            pass = decobeBase64(mxml.ReadElementString("password"))
        End While
        mxml.Close()
        'MsgBox(servidorDb + " " + nameDb + " " + usuario + " " + pass)
    End Sub

End Module

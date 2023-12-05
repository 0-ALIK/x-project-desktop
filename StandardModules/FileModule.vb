Imports System.IO

Module FileModule

    Function ManejoDeArchivos(ByVal imagePath As String) As String
        Dim documentsFolder As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
        Dim destinationFolder As String = Path.Combine(documentsFolder, "x-project-desktop", "Resources", "img")
        If Not Directory.Exists(destinationFolder) Then
            Directory.CreateDirectory(destinationFolder)
        End If
        Dim destinationPath As String = Path.Combine(destinationFolder, Path.GetFileName(imagePath))
        Try
            File.Copy(imagePath, destinationPath, True)
            MsgBox("Imagen almacenada en: " & destinationPath)
        Catch ex As Exception

            MsgBox("Error al guardar la imagen: " & ex.Message, MsgBoxStyle.Critical)
        End Try
        Return destinationPath
    End Function
End Module

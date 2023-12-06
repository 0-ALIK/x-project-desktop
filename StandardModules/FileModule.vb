
Imports System.Drawing.Imaging
Imports System.IO

Module FileModule

    Sub DialogoArchivo(ByRef pbPreview As PictureBox)
        Dim openFileDialog As New OpenFileDialog With {
           .Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.bmp",
           .Title = "Seleccionar imagen"
       }
        If openFileDialog.ShowDialog() = DialogResult.OK Then
            pbPreview.ImageLocation = openFileDialog.FileName
            pbPreview.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub

    Function VerificarImagen(ByRef pbPreview As PictureBox) As Boolean
        Return If(pbPreview.Image Is Nothing, False, True)
    End Function

    Function CodificarImagen(ByVal image As Image, ByRef pbox As PictureBox) As String
        Using ms As New MemoryStream()
            image.Save(ms, EncodeType(pbox))
            Dim imageBytes As Byte() = ms.ToArray()
            Dim base64String As String = Convert.ToBase64String(imageBytes)
            Return base64String
        End Using
    End Function

    Function DecodificarImagen(ByVal base64Image As String) As Image
        Dim imageBytes As Byte() = Convert.FromBase64String(base64Image)
        Dim ms As New MemoryStream(imageBytes, 0, imageBytes.Length)
        Dim normalImage As Image = Image.FromStream(ms, True)
        Return normalImage
    End Function

    Private Function EncodeType(ByVal picbox As PictureBox) As ImageFormat
        Dim encode As ImageFormat = ImageFormat.Jpeg
        If picbox.ImageLocation.ToLower.EndsWith(".jpg") Then
            encode = ImageFormat.Jpeg
        ElseIf picbox.ImageLocation.ToLower.EndsWith(".png") Then
            encode = ImageFormat.Png
        ElseIf picbox.ImageLocation.ToLower.EndsWith(".bmp") Then
            encode = ImageFormat.Bmp
        End If
        Return encode
    End Function

End Module
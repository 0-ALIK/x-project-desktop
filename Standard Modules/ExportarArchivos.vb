Imports Excel = Microsoft.Office.Interop.Excel
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO
Imports System.Windows.Documents
Module ExportarArchivos
    Public Sub ExportarAExcel(ByVal dgv As DataGridView)
        ' Crear una aplicación de Excel
        Dim excelApp As New Excel.Application()
        excelApp.Workbooks.Add()

        ' Agregar encabezados de columnas
        For col As Integer = 0 To dgv.ColumnCount - 1
            excelApp.Cells(1, col + 1) = dgv.Columns(col).HeaderText
        Next

        ' Agregar datos
        For row As Integer = 0 To dgv.RowCount - 1
            For col As Integer = 0 To dgv.ColumnCount - 1
                excelApp.Cells(row + 2, col + 1) = dgv.Rows(row).Cells(col).Value
            Next
        Next

        ' Guardar el archivo Excel
        Dim saveDialog As New SaveFileDialog()
        saveDialog.Filter = "Archivos de Excel (*.xlsx)|*.xlsx"
        If saveDialog.ShowDialog() = DialogResult.OK Then
            excelApp.ActiveWorkbook.SaveAs(saveDialog.FileName)
            excelApp.Quit()
            MsgBox("Datos exportados correctamente a Excel.")
        End If
    End Sub


End Module

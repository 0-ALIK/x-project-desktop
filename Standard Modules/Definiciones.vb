﻿Module Definiciones

    Function DefinicionesCategorias(ByVal categoria As Object) As String
        Select Case categoria.ToString
            Case "PA"
                DefinicionesCategorias = "Problemas de Acceso"
            Case "PF"
                DefinicionesCategorias = "Problemas de Funcionalidad"
            Case "PR"
                DefinicionesCategorias = "Problemas de Rendimiento"
            Case "PRA"
                DefinicionesCategorias = "Problemas de Reporte y Analisis"
            Case "O"
                DefinicionesCategorias = "Otros"
            Case Else
                DefinicionesCategorias = "Ninguno"
        End Select
    End Function

    Function DefinicionesCategoriaPrioridad(ByVal categoria As Integer) As Integer
        Select Case categoria
            Case 1
                DefinicionesCategoriaPrioridad = 3
            Case 2
                DefinicionesCategoriaPrioridad = 2
            Case 3
                DefinicionesCategoriaPrioridad = 1
            Case 4
                DefinicionesCategoriaPrioridad = 3
            Case 5
                DefinicionesCategoriaPrioridad = 1
            Case Else
                DefinicionesCategoriaPrioridad = 0
        End Select
    End Function



End Module

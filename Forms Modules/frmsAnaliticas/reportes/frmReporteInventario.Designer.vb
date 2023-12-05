Imports FontAwesome.Sharp

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmReporteInventario
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReporteInventario))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboxMarcas = New System.Windows.Forms.ComboBox()
        Me.cboxCategorias = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnAplicarFiltros = New System.Windows.Forms.Button()
        Me.btnExportarExcel = New System.Windows.Forms.Button()
        Me.dgvInventarioReporte = New System.Windows.Forms.DataGridView()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblCantCategorias = New System.Windows.Forms.Label()
        Me.lblCantMarcas = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblCantProductos = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnEliminarFiltros = New System.Windows.Forms.Button()
        Me.AnaliticaReporteInventarioDAOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.dgvInventarioReporte, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AnaliticaReporteInventarioDAOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'cboxMarcas
        '
        resources.ApplyResources(Me.cboxMarcas, "cboxMarcas")
        Me.cboxMarcas.FormattingEnabled = True
        Me.cboxMarcas.Name = "cboxMarcas"
        '
        'cboxCategorias
        '
        resources.ApplyResources(Me.cboxCategorias, "cboxCategorias")
        Me.cboxCategorias.FormattingEnabled = True
        Me.cboxCategorias.Name = "cboxCategorias"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'btnAplicarFiltros
        '
        resources.ApplyResources(Me.btnAplicarFiltros, "btnAplicarFiltros")
        Me.btnAplicarFiltros.Name = "btnAplicarFiltros"
        Me.btnAplicarFiltros.UseVisualStyleBackColor = True
        '
        'btnExportarExcel
        '
        resources.ApplyResources(Me.btnExportarExcel, "btnExportarExcel")
        Me.btnExportarExcel.Name = "btnExportarExcel"
        Me.btnExportarExcel.UseVisualStyleBackColor = True
        '
        'dgvInventarioReporte
        '
        Me.dgvInventarioReporte.AllowUserToAddRows = False
        Me.dgvInventarioReporte.AllowUserToDeleteRows = False
        Me.dgvInventarioReporte.AllowUserToResizeColumns = False
        Me.dgvInventarioReporte.AllowUserToResizeRows = False
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvInventarioReporte.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvInventarioReporte.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvInventarioReporte.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgvInventarioReporte.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.dgvInventarioReporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        resources.ApplyResources(Me.dgvInventarioReporte, "dgvInventarioReporte")
        Me.dgvInventarioReporte.Name = "dgvInventarioReporte"
        Me.dgvInventarioReporte.ReadOnly = True
        Me.dgvInventarioReporte.TabStop = False
        '
        'Label8
        '
        resources.ApplyResources(Me.Label8, "Label8")
        Me.Label8.Name = "Label8"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'lblCantCategorias
        '
        resources.ApplyResources(Me.lblCantCategorias, "lblCantCategorias")
        Me.lblCantCategorias.Name = "lblCantCategorias"
        '
        'lblCantMarcas
        '
        resources.ApplyResources(Me.lblCantMarcas, "lblCantMarcas")
        Me.lblCantMarcas.Name = "lblCantMarcas"
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.Name = "Label4"
        '
        'lblCantProductos
        '
        resources.ApplyResources(Me.lblCantProductos, "lblCantProductos")
        Me.lblCantProductos.Name = "lblCantProductos"
        '
        'Label6
        '
        resources.ApplyResources(Me.Label6, "Label6")
        Me.Label6.Name = "Label6"
        '
        'btnEliminarFiltros
        '
        resources.ApplyResources(Me.btnEliminarFiltros, "btnEliminarFiltros")
        Me.btnEliminarFiltros.Name = "btnEliminarFiltros"
        Me.btnEliminarFiltros.UseVisualStyleBackColor = True
        '
        'AnaliticaReporteInventarioDAOBindingSource
        '
        Me.AnaliticaReporteInventarioDAOBindingSource.DataSource = GetType(x_project_desktop.analiticaReporteInventarioDAO)
        '
        'frmReporteInventario
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        resources.ApplyResources(Me, "$this")
        Me.Controls.Add(Me.btnEliminarFiltros)
        Me.Controls.Add(Me.btnAplicarFiltros)
        Me.Controls.Add(Me.btnExportarExcel)
        Me.Controls.Add(Me.lblCantCategorias)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblCantMarcas)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblCantProductos)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dgvInventarioReporte)
        Me.Controls.Add(Me.cboxCategorias)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cboxMarcas)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmReporteInventario"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgvInventarioReporte, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AnaliticaReporteInventarioDAOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents cboxMarcas As ComboBox
    Friend WithEvents cboxCategorias As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnAplicarFiltros As Button
    Friend WithEvents btnExportarExcel As Button
    Friend WithEvents AnaliticaReporteInventarioDAOBindingSource As BindingSource
    Friend WithEvents dgvInventarioReporte As DataGridView
    Friend WithEvents Label8 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblCantCategorias As Label
    Friend WithEvents lblCantMarcas As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblCantProductos As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnEliminarFiltros As Button
End Class

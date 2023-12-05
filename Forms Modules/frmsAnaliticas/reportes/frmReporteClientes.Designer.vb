<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReporteClientes
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnDescargarReporte = New System.Windows.Forms.Button()
        Me.btnAplicarFiltros = New System.Windows.Forms.Button()
        Me.cboxProductos = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboxProvincias = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvReporteClientes = New System.Windows.Forms.DataGridView()
        Me.lblCantCategorias = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblCantProductos = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnEliminarFiltros = New System.Windows.Forms.Button()
        CType(Me.dgvReporteClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnDescargarReporte
        '
        Me.btnDescargarReporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDescargarReporte.Location = New System.Drawing.Point(563, 108)
        Me.btnDescargarReporte.Name = "btnDescargarReporte"
        Me.btnDescargarReporte.Size = New System.Drawing.Size(157, 28)
        Me.btnDescargarReporte.TabIndex = 13
        Me.btnDescargarReporte.Text = "Descargar Reporte"
        Me.btnDescargarReporte.UseVisualStyleBackColor = True
        '
        'btnAplicarFiltros
        '
        Me.btnAplicarFiltros.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAplicarFiltros.Location = New System.Drawing.Point(419, 86)
        Me.btnAplicarFiltros.Name = "btnAplicarFiltros"
        Me.btnAplicarFiltros.Size = New System.Drawing.Size(127, 27)
        Me.btnAplicarFiltros.TabIndex = 12
        Me.btnAplicarFiltros.Text = "Aplicar Filtros"
        Me.btnAplicarFiltros.UseVisualStyleBackColor = True
        '
        'cboxProductos
        '
        Me.cboxProductos.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cboxProductos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboxProductos.FormattingEnabled = True
        Me.cboxProductos.Location = New System.Drawing.Point(215, 109)
        Me.cboxProductos.Name = "cboxProductos"
        Me.cboxProductos.Size = New System.Drawing.Size(185, 28)
        Me.cboxProductos.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(262, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 20)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Producto"
        '
        'cboxProvincias
        '
        Me.cboxProvincias.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cboxProvincias.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboxProvincias.FormattingEnabled = True
        Me.cboxProvincias.Location = New System.Drawing.Point(11, 109)
        Me.cboxProvincias.Name = "cboxProvincias"
        Me.cboxProvincias.Size = New System.Drawing.Size(185, 28)
        Me.cboxProvincias.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(70, 86)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 20)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Provincia"
        '
        'dgvReporteClientes
        '
        Me.dgvReporteClientes.AllowUserToAddRows = False
        Me.dgvReporteClientes.AllowUserToDeleteRows = False
        Me.dgvReporteClientes.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.dgvReporteClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvReporteClientes.Location = New System.Drawing.Point(12, 156)
        Me.dgvReporteClientes.Name = "dgvReporteClientes"
        Me.dgvReporteClientes.ReadOnly = True
        Me.dgvReporteClientes.Size = New System.Drawing.Size(1299, 543)
        Me.dgvReporteClientes.TabIndex = 7
        '
        'lblCantCategorias
        '
        Me.lblCantCategorias.AutoSize = True
        Me.lblCantCategorias.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold)
        Me.lblCantCategorias.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCantCategorias.Location = New System.Drawing.Point(107, 44)
        Me.lblCantCategorias.Name = "lblCantCategorias"
        Me.lblCantCategorias.Size = New System.Drawing.Size(83, 25)
        Me.lblCantCategorias.TabIndex = 22
        Me.lblCantCategorias.Text = "Label5"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label8.Location = New System.Drawing.Point(107, 21)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(90, 20)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Provincias"
        '
        'lblCantProductos
        '
        Me.lblCantProductos.AutoSize = True
        Me.lblCantProductos.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold)
        Me.lblCantProductos.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCantProductos.Location = New System.Drawing.Point(12, 44)
        Me.lblCantProductos.Name = "lblCantProductos"
        Me.lblCantProductos.Size = New System.Drawing.Size(83, 25)
        Me.lblCantProductos.TabIndex = 18
        Me.lblCantProductos.Text = "Label5"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(20, 44)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 25)
        Me.Label4.TabIndex = 17
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(12, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 20)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Empresas"
        '
        'btnEliminarFiltros
        '
        Me.btnEliminarFiltros.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarFiltros.Location = New System.Drawing.Point(419, 123)
        Me.btnEliminarFiltros.Name = "btnEliminarFiltros"
        Me.btnEliminarFiltros.Size = New System.Drawing.Size(127, 27)
        Me.btnEliminarFiltros.TabIndex = 23
        Me.btnEliminarFiltros.Text = "Eliminar Filtros"
        Me.btnEliminarFiltros.UseVisualStyleBackColor = True
        '
        'frmReporteClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1323, 711)
        Me.Controls.Add(Me.btnEliminarFiltros)
        Me.Controls.Add(Me.lblCantCategorias)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblCantProductos)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnDescargarReporte)
        Me.Controls.Add(Me.btnAplicarFiltros)
        Me.Controls.Add(Me.cboxProductos)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cboxProvincias)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvReporteClientes)
        Me.Name = "frmReporteClientes"
        Me.Text = "frmReporteClientes"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgvReporteClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnDescargarReporte As Button
    Friend WithEvents btnAplicarFiltros As Button
    Friend WithEvents cboxProductos As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cboxProvincias As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvReporteClientes As DataGridView
    Friend WithEvents lblCantCategorias As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblCantProductos As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnEliminarFiltros As Button
End Class

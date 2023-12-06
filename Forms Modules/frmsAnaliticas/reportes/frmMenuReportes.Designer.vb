<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMenuReportes
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.InventarioGlobalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporteDeClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.panelTablaReportes = New System.Windows.Forms.Panel()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InventarioGlobalToolStripMenuItem, Me.ReporteDeClientesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip1.Size = New System.Drawing.Size(1299, 29)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'InventarioGlobalToolStripMenuItem
        '
        Me.InventarioGlobalToolStripMenuItem.Name = "InventarioGlobalToolStripMenuItem"
        Me.InventarioGlobalToolStripMenuItem.Size = New System.Drawing.Size(101, 25)
        Me.InventarioGlobalToolStripMenuItem.Text = "Inventario"
        '
        'ReporteDeClientesToolStripMenuItem
        '
        Me.ReporteDeClientesToolStripMenuItem.Name = "ReporteDeClientesToolStripMenuItem"
        Me.ReporteDeClientesToolStripMenuItem.Size = New System.Drawing.Size(83, 25)
        Me.ReporteDeClientesToolStripMenuItem.Text = "Clientes"
        '
        'panelTablaReportes
        '
        Me.panelTablaReportes.Location = New System.Drawing.Point(0, 32)
        Me.panelTablaReportes.Name = "panelTablaReportes"
        Me.panelTablaReportes.Size = New System.Drawing.Size(1299, 590)
        Me.panelTablaReportes.TabIndex = 2
        '
        'frmMenuReportes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1299, 621)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.panelTablaReportes)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMenuReportes"
        Me.Text = "frmReportes"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents InventarioGlobalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReporteDeClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents panelTablaReportes As Panel
End Class

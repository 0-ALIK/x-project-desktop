<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDashboard
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DashboardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GraficosDeInventarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GraficosDeVentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GraficosDeComprasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GraficosDePedidosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GraficosDeClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DashboardToolStripMenuItem, Me.GraficosDeInventarioToolStripMenuItem, Me.ToolStripMenuItem1, Me.GraficosDeVentasToolStripMenuItem, Me.GraficosDeComprasToolStripMenuItem, Me.GraficosDePedidosToolStripMenuItem, Me.GraficosDeClientesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DashboardToolStripMenuItem
        '
        Me.DashboardToolStripMenuItem.Name = "DashboardToolStripMenuItem"
        Me.DashboardToolStripMenuItem.Size = New System.Drawing.Size(76, 20)
        Me.DashboardToolStripMenuItem.Text = "Dashboard"
        '
        'GraficosDeInventarioToolStripMenuItem
        '
        Me.GraficosDeInventarioToolStripMenuItem.Name = "GraficosDeInventarioToolStripMenuItem"
        Me.GraficosDeInventarioToolStripMenuItem.Size = New System.Drawing.Size(134, 20)
        Me.GraficosDeInventarioToolStripMenuItem.Text = "Graficos de inventario"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(12, 20)
        '
        'GraficosDeVentasToolStripMenuItem
        '
        Me.GraficosDeVentasToolStripMenuItem.Name = "GraficosDeVentasToolStripMenuItem"
        Me.GraficosDeVentasToolStripMenuItem.Size = New System.Drawing.Size(115, 20)
        Me.GraficosDeVentasToolStripMenuItem.Text = "Graficos de Ventas"
        '
        'GraficosDeComprasToolStripMenuItem
        '
        Me.GraficosDeComprasToolStripMenuItem.Name = "GraficosDeComprasToolStripMenuItem"
        Me.GraficosDeComprasToolStripMenuItem.Size = New System.Drawing.Size(129, 20)
        Me.GraficosDeComprasToolStripMenuItem.Text = "Graficos de Compras"
        '
        'GraficosDePedidosToolStripMenuItem
        '
        Me.GraficosDePedidosToolStripMenuItem.Name = "GraficosDePedidosToolStripMenuItem"
        Me.GraficosDePedidosToolStripMenuItem.Size = New System.Drawing.Size(123, 20)
        Me.GraficosDePedidosToolStripMenuItem.Text = "Graficos de Pedidos"
        '
        'GraficosDeClientesToolStripMenuItem
        '
        Me.GraficosDeClientesToolStripMenuItem.Name = "GraficosDeClientesToolStripMenuItem"
        Me.GraficosDeClientesToolStripMenuItem.Size = New System.Drawing.Size(121, 20)
        Me.GraficosDeClientesToolStripMenuItem.Text = "Graficos de clientes"
        '
        'frmDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmDashboard"
        Me.Text = "frmDashboard"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents DashboardToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GraficosDeInventarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents GraficosDeVentasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GraficosDeComprasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GraficosDePedidosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GraficosDeClientesToolStripMenuItem As ToolStripMenuItem
End Class

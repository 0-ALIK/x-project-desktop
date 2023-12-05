<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHomeTicket
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
        Me.TicketsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CrearTicketsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.panelHomeTicket = New System.Windows.Forms.Panel()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TicketsToolStripMenuItem, Me.CrearTicketsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1067, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'TicketsToolStripMenuItem
        '
        Me.TicketsToolStripMenuItem.Name = "TicketsToolStripMenuItem"
        Me.TicketsToolStripMenuItem.Size = New System.Drawing.Size(93, 24)
        Me.TicketsToolStripMenuItem.Text = "Ver Tickets"
        '
        'CrearTicketsToolStripMenuItem
        '
        Me.CrearTicketsToolStripMenuItem.Name = "CrearTicketsToolStripMenuItem"
        Me.CrearTicketsToolStripMenuItem.Size = New System.Drawing.Size(107, 24)
        Me.CrearTicketsToolStripMenuItem.Text = "Crear Tickets"
        '
        'panelHomeTicket
        '
        Me.panelHomeTicket.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelHomeTicket.Location = New System.Drawing.Point(0, 28)
        Me.panelHomeTicket.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.panelHomeTicket.Name = "panelHomeTicket"
        Me.panelHomeTicket.Size = New System.Drawing.Size(1067, 526)
        Me.panelHomeTicket.TabIndex = 3
        '
        'frmHomeTicket
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 554)
        Me.Controls.Add(Me.panelHomeTicket)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmHomeTicket"
        Me.Text = "frmHomeTicket"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents TicketsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents panelHomeTicket As Panel
    Friend WithEvents CrearTicketsToolStripMenuItem As ToolStripMenuItem
End Class

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
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TicketsToolStripMenuItem, Me.CrearTicketsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'TicketsToolStripMenuItem
        '
        Me.TicketsToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.TicketsToolStripMenuItem.Name = "TicketsToolStripMenuItem"
        Me.TicketsToolStripMenuItem.Size = New System.Drawing.Size(74, 20)
        Me.TicketsToolStripMenuItem.Text = "Ver Tickets"
        '
        'CrearTicketsToolStripMenuItem
        '
        Me.CrearTicketsToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.CrearTicketsToolStripMenuItem.Name = "CrearTicketsToolStripMenuItem"
        Me.CrearTicketsToolStripMenuItem.Size = New System.Drawing.Size(86, 20)
        Me.CrearTicketsToolStripMenuItem.Text = "Crear Tickets"
        '
        'panelHomeTicket
        '
        Me.panelHomeTicket.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.panelHomeTicket.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelHomeTicket.Location = New System.Drawing.Point(0, 24)
        Me.panelHomeTicket.Name = "panelHomeTicket"
        Me.panelHomeTicket.Size = New System.Drawing.Size(800, 426)
        Me.panelHomeTicket.TabIndex = 3
        '
        'frmHomeTicket
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.panelHomeTicket)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
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

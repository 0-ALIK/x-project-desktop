<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAgregarPedido
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
        Me.panelFrmInventario = New System.Windows.Forms.Panel()
        Me.btnAgregar = New FontAwesome.Sharp.IconButton()
        Me.dtpFechaC = New System.Windows.Forms.DateTimePicker()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.cboProductos = New System.Windows.Forms.ComboBox()
        Me.cboClientes = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.panelFrmInventario.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelFrmInventario
        '
        Me.panelFrmInventario.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.panelFrmInventario.Controls.Add(Me.btnAgregar)
        Me.panelFrmInventario.Controls.Add(Me.dtpFechaC)
        Me.panelFrmInventario.Controls.Add(Me.txtCantidad)
        Me.panelFrmInventario.Controls.Add(Me.cboProductos)
        Me.panelFrmInventario.Controls.Add(Me.cboClientes)
        Me.panelFrmInventario.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelFrmInventario.Location = New System.Drawing.Point(0, 0)
        Me.panelFrmInventario.Margin = New System.Windows.Forms.Padding(75, 77, 75, 77)
        Me.panelFrmInventario.Name = "panelFrmInventario"
        Me.panelFrmInventario.Padding = New System.Windows.Forms.Padding(20)
        Me.panelFrmInventario.Size = New System.Drawing.Size(800, 450)
        Me.panelFrmInventario.TabIndex = 7
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.btnAgregar.IconChar = FontAwesome.Sharp.IconChar.Upload
        Me.btnAgregar.IconColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.btnAgregar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnAgregar.IconSize = 35
        Me.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAgregar.Location = New System.Drawing.Point(294, 382)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(140, 45)
        Me.btnAgregar.TabIndex = 64
        Me.btnAgregar.Text = "Agregar pedido"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'dtpFechaC
        '
        Me.dtpFechaC.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaC.Location = New System.Drawing.Point(173, 56)
        Me.dtpFechaC.Margin = New System.Windows.Forms.Padding(2)
        Me.dtpFechaC.Name = "dtpFechaC"
        Me.dtpFechaC.Size = New System.Drawing.Size(420, 32)
        Me.dtpFechaC.TabIndex = 63
        '
        'txtCantidad
        '
        Me.txtCantidad.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.txtCantidad.ForeColor = System.Drawing.Color.White
        Me.txtCantidad.Location = New System.Drawing.Point(217, 138)
        Me.txtCantidad.Multiline = True
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(303, 32)
        Me.txtCantidad.TabIndex = 62
        '
        'cboProductos
        '
        Me.cboProductos.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboProductos.FormattingEnabled = True
        Me.cboProductos.Location = New System.Drawing.Point(217, 316)
        Me.cboProductos.Margin = New System.Windows.Forms.Padding(2)
        Me.cboProductos.Name = "cboProductos"
        Me.cboProductos.Size = New System.Drawing.Size(303, 38)
        Me.cboProductos.TabIndex = 61
        '
        'cboClientes
        '
        Me.cboClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboClientes.FormattingEnabled = True
        Me.cboClientes.Location = New System.Drawing.Point(217, 222)
        Me.cboClientes.Margin = New System.Windows.Forms.Padding(2)
        Me.cboClientes.Name = "cboClientes"
        Me.cboClientes.Size = New System.Drawing.Size(303, 38)
        Me.cboClientes.TabIndex = 60
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(364, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Inventario"
        '
        'frmAgregarPedido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.panelFrmInventario)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmAgregarPedido"
        Me.Text = "frmAgregarPedido"
        Me.panelFrmInventario.ResumeLayout(False)
        Me.panelFrmInventario.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents panelFrmInventario As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents cboProductos As ComboBox
    Friend WithEvents cboClientes As ComboBox
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents dtpFechaC As DateTimePicker
    Friend WithEvents btnAgregar As FontAwesome.Sharp.IconButton
End Class

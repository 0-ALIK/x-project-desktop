<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAgregarCompra
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnRealizarCompra = New FontAwesome.Sharp.IconButton()
        Me.cboProductos = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.MySqlCommand1 = New MySqlConnector.MySqlCommand()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboClientes = New System.Windows.Forms.ComboBox()
        Me.dtpFechaC = New System.Windows.Forms.DateTimePicker()
        Me.panelFrmInventario.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelFrmInventario
        '
        Me.panelFrmInventario.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.panelFrmInventario.Controls.Add(Me.Panel1)
        Me.panelFrmInventario.Controls.Add(Me.Label11)
        Me.panelFrmInventario.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelFrmInventario.Location = New System.Drawing.Point(0, 0)
        Me.panelFrmInventario.Margin = New System.Windows.Forms.Padding(75, 77, 75, 77)
        Me.panelFrmInventario.Name = "panelFrmInventario"
        Me.panelFrmInventario.Padding = New System.Windows.Forms.Padding(20)
        Me.panelFrmInventario.Size = New System.Drawing.Size(545, 680)
        Me.panelFrmInventario.TabIndex = 19
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.dtpFechaC)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.cboClientes)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtCantidad)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btnRealizarCompra)
        Me.Panel1.Controls.Add(Me.cboProductos)
        Me.Panel1.Location = New System.Drawing.Point(62, 63)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(421, 488)
        Me.Panel1.TabIndex = 53
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 14.0!)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(152, 180)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 22)
        Me.Label3.TabIndex = 63
        Me.Label3.Text = "Producto"
        '
        'txtCantidad
        '
        Me.txtCantidad.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.txtCantidad.ForeColor = System.Drawing.Color.White
        Me.txtCantidad.Location = New System.Drawing.Point(16, 124)
        Me.txtCantidad.Multiline = True
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(387, 32)
        Me.txtCantidad.TabIndex = 62
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 14.0!)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(152, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 22)
        Me.Label2.TabIndex = 61
        Me.Label2.Text = "Cantidad"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 14.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(162, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 22)
        Me.Label1.TabIndex = 60
        Me.Label1.Text = "Fecha"
        '
        'btnRealizarCompra
        '
        Me.btnRealizarCompra.BackColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.btnRealizarCompra.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.btnRealizarCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRealizarCompra.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.btnRealizarCompra.IconChar = FontAwesome.Sharp.IconChar.Upload
        Me.btnRealizarCompra.IconColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.btnRealizarCompra.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnRealizarCompra.IconSize = 35
        Me.btnRealizarCompra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRealizarCompra.Location = New System.Drawing.Point(110, 420)
        Me.btnRealizarCompra.Name = "btnRealizarCompra"
        Me.btnRealizarCompra.Size = New System.Drawing.Size(167, 44)
        Me.btnRealizarCompra.TabIndex = 59
        Me.btnRealizarCompra.Text = "Realizar compra"
        Me.btnRealizarCompra.UseVisualStyleBackColor = False
        '
        'cboProductos
        '
        Me.cboProductos.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboProductos.FormattingEnabled = True
        Me.cboProductos.Location = New System.Drawing.Point(16, 204)
        Me.cboProductos.Margin = New System.Windows.Forms.Padding(2)
        Me.cboProductos.Name = "cboProductos"
        Me.cboProductos.Size = New System.Drawing.Size(387, 38)
        Me.cboProductos.TabIndex = 20
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 14.0!)
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(183, 38)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(147, 22)
        Me.Label11.TabIndex = 53
        Me.Label11.Text = "Realizar compra"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Padding = New System.Windows.Forms.Padding(15, 0, 15, 15)
        Me.Panel5.Size = New System.Drawing.Size(545, 680)
        Me.Panel5.TabIndex = 16
        '
        'MySqlCommand1
        '
        Me.MySqlCommand1.CommandTimeout = 0
        Me.MySqlCommand1.Connection = Nothing
        Me.MySqlCommand1.Transaction = Nothing
        Me.MySqlCommand1.UpdatedRowSource = System.Data.UpdateRowSource.None
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 14.0!)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(152, 274)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 22)
        Me.Label4.TabIndex = 65
        Me.Label4.Text = "Cliente"
        '
        'cboClientes
        '
        Me.cboClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboClientes.FormattingEnabled = True
        Me.cboClientes.Location = New System.Drawing.Point(16, 298)
        Me.cboClientes.Margin = New System.Windows.Forms.Padding(2)
        Me.cboClientes.Name = "cboClientes"
        Me.cboClientes.Size = New System.Drawing.Size(387, 38)
        Me.cboClientes.TabIndex = 64
        '
        'dtpFechaC
        '
        Me.dtpFechaC.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaC.Location = New System.Drawing.Point(1, 34)
        Me.dtpFechaC.Margin = New System.Windows.Forms.Padding(2)
        Me.dtpFechaC.Name = "dtpFechaC"
        Me.dtpFechaC.Size = New System.Drawing.Size(420, 32)
        Me.dtpFechaC.TabIndex = 66
        '
        'frmAgregarCompra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(545, 680)
        Me.Controls.Add(Me.panelFrmInventario)
        Me.Controls.Add(Me.Panel5)
        Me.Name = "frmAgregarCompra"
        Me.Text = "frmAgregarCompra"
        Me.panelFrmInventario.ResumeLayout(False)
        Me.panelFrmInventario.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents panelFrmInventario As Panel
    Friend WithEvents Label11 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnRealizarCompra As FontAwesome.Sharp.IconButton
    Friend WithEvents cboProductos As ComboBox
    Friend WithEvents MySqlCommand1 As MySqlConnector.MySqlCommand
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cboClientes As ComboBox
    Friend WithEvents dtpFechaC As DateTimePicker
End Class

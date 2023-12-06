<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAgregarPago
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnRegistrarPago = New FontAwesome.Sharp.IconButton()
        Me.dtpFechaP = New System.Windows.Forms.DateTimePicker()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.cboMetodoPago = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.panelFrmInventario.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelFrmInventario
        '
        Me.panelFrmInventario.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.panelFrmInventario.Controls.Add(Me.Label5)
        Me.panelFrmInventario.Controls.Add(Me.Label3)
        Me.panelFrmInventario.Controls.Add(Me.Label2)
        Me.panelFrmInventario.Controls.Add(Me.btnRegistrarPago)
        Me.panelFrmInventario.Controls.Add(Me.dtpFechaP)
        Me.panelFrmInventario.Controls.Add(Me.txtCantidad)
        Me.panelFrmInventario.Controls.Add(Me.cboMetodoPago)
        Me.panelFrmInventario.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelFrmInventario.Location = New System.Drawing.Point(0, 0)
        Me.panelFrmInventario.Margin = New System.Windows.Forms.Padding(75, 77, 75, 77)
        Me.panelFrmInventario.Name = "panelFrmInventario"
        Me.panelFrmInventario.Padding = New System.Windows.Forms.Padding(20)
        Me.panelFrmInventario.Size = New System.Drawing.Size(800, 450)
        Me.panelFrmInventario.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Label5.Location = New System.Drawing.Point(260, 245)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(222, 31)
        Me.Label5.TabIndex = 68
        Me.Label5.Text = "Metodo de pago"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Label3.Location = New System.Drawing.Point(303, 130)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(131, 31)
        Me.Label3.TabIndex = 66
        Me.Label3.Text = "Cantidad"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Label2.Location = New System.Drawing.Point(268, 20)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(214, 31)
        Me.Label2.TabIndex = 65
        Me.Label2.Text = "Fecha del pago"
        '
        'btnRegistrarPago
        '
        Me.btnRegistrarPago.BackColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.btnRegistrarPago.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.btnRegistrarPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegistrarPago.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.btnRegistrarPago.IconChar = FontAwesome.Sharp.IconChar.Upload
        Me.btnRegistrarPago.IconColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.btnRegistrarPago.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnRegistrarPago.IconSize = 35
        Me.btnRegistrarPago.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRegistrarPago.Location = New System.Drawing.Point(294, 382)
        Me.btnRegistrarPago.Name = "btnRegistrarPago"
        Me.btnRegistrarPago.Size = New System.Drawing.Size(140, 45)
        Me.btnRegistrarPago.TabIndex = 64
        Me.btnRegistrarPago.Text = "Agregar pago"
        Me.btnRegistrarPago.UseVisualStyleBackColor = False
        '
        'dtpFechaP
        '
        Me.dtpFechaP.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaP.Location = New System.Drawing.Point(173, 56)
        Me.dtpFechaP.Margin = New System.Windows.Forms.Padding(2)
        Me.dtpFechaP.Name = "dtpFechaP"
        Me.dtpFechaP.Size = New System.Drawing.Size(420, 32)
        Me.dtpFechaP.TabIndex = 63
        '
        'txtCantidad
        '
        Me.txtCantidad.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.txtCantidad.ForeColor = System.Drawing.Color.White
        Me.txtCantidad.Location = New System.Drawing.Point(217, 164)
        Me.txtCantidad.Multiline = True
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(303, 32)
        Me.txtCantidad.TabIndex = 62
        '
        'cboMetodoPago
        '
        Me.cboMetodoPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMetodoPago.FormattingEnabled = True
        Me.cboMetodoPago.Location = New System.Drawing.Point(217, 278)
        Me.cboMetodoPago.Margin = New System.Windows.Forms.Padding(2)
        Me.cboMetodoPago.Name = "cboMetodoPago"
        Me.cboMetodoPago.Size = New System.Drawing.Size(303, 38)
        Me.cboMetodoPago.TabIndex = 61
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(364, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Inventario"
        '
        'frmAgregarPago
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.panelFrmInventario)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmAgregarPago"
        Me.Text = "frmAgregarPago"
        Me.panelFrmInventario.ResumeLayout(False)
        Me.panelFrmInventario.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents panelFrmInventario As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnRegistrarPago As FontAwesome.Sharp.IconButton
    Friend WithEvents dtpFechaP As DateTimePicker
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents cboMetodoPago As ComboBox
    Friend WithEvents Label1 As Label
End Class

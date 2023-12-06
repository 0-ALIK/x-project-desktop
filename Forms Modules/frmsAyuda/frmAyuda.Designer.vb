<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAyuda
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gbAyuda = New System.Windows.Forms.GroupBox()
        Me.btnAyudaPoliticas = New FontAwesome.Sharp.IconButton()
        Me.btnAyudaUsuario = New FontAwesome.Sharp.IconButton()
        Me.btnAyudaPedidos = New FontAwesome.Sharp.IconButton()
        Me.btnAyudaEntrega = New FontAwesome.Sharp.IconButton()
        Me.btnAyudaDevo = New FontAwesome.Sharp.IconButton()
        Me.btnAyudaPago = New FontAwesome.Sharp.IconButton()
        Me.gbAyuda.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Black", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label1.Location = New System.Drawing.Point(793, 151)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(243, 27)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Preguntas Frecuentes"
        '
        'gbAyuda
        '
        Me.gbAyuda.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.gbAyuda.Controls.Add(Me.btnAyudaPoliticas)
        Me.gbAyuda.Controls.Add(Me.btnAyudaUsuario)
        Me.gbAyuda.Controls.Add(Me.btnAyudaPedidos)
        Me.gbAyuda.Controls.Add(Me.btnAyudaEntrega)
        Me.gbAyuda.Controls.Add(Me.btnAyudaDevo)
        Me.gbAyuda.Controls.Add(Me.btnAyudaPago)
        Me.gbAyuda.ForeColor = System.Drawing.Color.Black
        Me.gbAyuda.Location = New System.Drawing.Point(165, 123)
        Me.gbAyuda.Name = "gbAyuda"
        Me.gbAyuda.Size = New System.Drawing.Size(871, 438)
        Me.gbAyuda.TabIndex = 5
        Me.gbAyuda.TabStop = False
        '
        'btnAyudaPoliticas
        '
        Me.btnAyudaPoliticas.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAyudaPoliticas.IconChar = FontAwesome.Sharp.IconChar.Passport
        Me.btnAyudaPoliticas.IconColor = System.Drawing.Color.Black
        Me.btnAyudaPoliticas.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnAyudaPoliticas.IconSize = 90
        Me.btnAyudaPoliticas.Location = New System.Drawing.Point(608, 222)
        Me.btnAyudaPoliticas.Name = "btnAyudaPoliticas"
        Me.btnAyudaPoliticas.Size = New System.Drawing.Size(170, 144)
        Me.btnAyudaPoliticas.TabIndex = 6
        Me.btnAyudaPoliticas.Text = "Politicas"
        Me.btnAyudaPoliticas.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAyudaPoliticas.UseVisualStyleBackColor = True
        '
        'btnAyudaUsuario
        '
        Me.btnAyudaUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAyudaUsuario.IconChar = FontAwesome.Sharp.IconChar.UserAlt
        Me.btnAyudaUsuario.IconColor = System.Drawing.Color.Black
        Me.btnAyudaUsuario.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnAyudaUsuario.IconSize = 90
        Me.btnAyudaUsuario.Location = New System.Drawing.Point(340, 222)
        Me.btnAyudaUsuario.Name = "btnAyudaUsuario"
        Me.btnAyudaUsuario.Size = New System.Drawing.Size(170, 144)
        Me.btnAyudaUsuario.TabIndex = 5
        Me.btnAyudaUsuario.Text = "Usuario"
        Me.btnAyudaUsuario.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAyudaUsuario.UseVisualStyleBackColor = True
        '
        'btnAyudaPedidos
        '
        Me.btnAyudaPedidos.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAyudaPedidos.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart
        Me.btnAyudaPedidos.IconColor = System.Drawing.Color.Black
        Me.btnAyudaPedidos.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnAyudaPedidos.IconSize = 90
        Me.btnAyudaPedidos.Location = New System.Drawing.Point(77, 36)
        Me.btnAyudaPedidos.Name = "btnAyudaPedidos"
        Me.btnAyudaPedidos.Size = New System.Drawing.Size(170, 144)
        Me.btnAyudaPedidos.TabIndex = 1
        Me.btnAyudaPedidos.Text = "Pedidos"
        Me.btnAyudaPedidos.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAyudaPedidos.UseVisualStyleBackColor = True
        '
        'btnAyudaEntrega
        '
        Me.btnAyudaEntrega.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAyudaEntrega.IconChar = FontAwesome.Sharp.IconChar.BoxOpen
        Me.btnAyudaEntrega.IconColor = System.Drawing.Color.Black
        Me.btnAyudaEntrega.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnAyudaEntrega.IconSize = 90
        Me.btnAyudaEntrega.Location = New System.Drawing.Point(77, 222)
        Me.btnAyudaEntrega.Name = "btnAyudaEntrega"
        Me.btnAyudaEntrega.Size = New System.Drawing.Size(170, 144)
        Me.btnAyudaEntrega.TabIndex = 4
        Me.btnAyudaEntrega.Text = "Entrega"
        Me.btnAyudaEntrega.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAyudaEntrega.UseVisualStyleBackColor = True
        '
        'btnAyudaDevo
        '
        Me.btnAyudaDevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAyudaDevo.IconChar = FontAwesome.Sharp.IconChar.Ticket
        Me.btnAyudaDevo.IconColor = System.Drawing.Color.Black
        Me.btnAyudaDevo.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnAyudaDevo.IconSize = 90
        Me.btnAyudaDevo.Location = New System.Drawing.Point(340, 36)
        Me.btnAyudaDevo.Name = "btnAyudaDevo"
        Me.btnAyudaDevo.Size = New System.Drawing.Size(170, 144)
        Me.btnAyudaDevo.TabIndex = 2
        Me.btnAyudaDevo.Text = "Devolución y Reembolso"
        Me.btnAyudaDevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAyudaDevo.UseVisualStyleBackColor = True
        '
        'btnAyudaPago
        '
        Me.btnAyudaPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAyudaPago.IconChar = FontAwesome.Sharp.IconChar.MoneyCheckDollar
        Me.btnAyudaPago.IconColor = System.Drawing.Color.Black
        Me.btnAyudaPago.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnAyudaPago.IconSize = 90
        Me.btnAyudaPago.Location = New System.Drawing.Point(608, 36)
        Me.btnAyudaPago.Name = "btnAyudaPago"
        Me.btnAyudaPago.Size = New System.Drawing.Size(170, 144)
        Me.btnAyudaPago.TabIndex = 3
        Me.btnAyudaPago.Text = "Pago y Promociones"
        Me.btnAyudaPago.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAyudaPago.UseVisualStyleBackColor = True
        '
        'frmAyuda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1028, 609)
        Me.Controls.Add(Me.gbAyuda)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmAyuda"
        Me.Text = "frmAyuda"
        Me.gbAyuda.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnAyudaPedidos As FontAwesome.Sharp.IconButton
    Friend WithEvents btnAyudaDevo As FontAwesome.Sharp.IconButton
    Friend WithEvents btnAyudaPago As FontAwesome.Sharp.IconButton
    Friend WithEvents btnAyudaEntrega As FontAwesome.Sharp.IconButton
    Friend WithEvents gbAyuda As GroupBox
    Friend WithEvents btnAyudaPoliticas As FontAwesome.Sharp.IconButton
    Friend WithEvents btnAyudaUsuario As FontAwesome.Sharp.IconButton
End Class

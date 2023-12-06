<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAyudaPagoPromociones
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
        Me.btnVolver = New FontAwesome.Sharp.IconButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label1.Location = New System.Drawing.Point(859, 135)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(650, 32)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Preguntas Frecuentes sobre Pago y Promociones" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'btnVolver
        '
        Me.btnVolver.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolver.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft
        Me.btnVolver.IconColor = System.Drawing.Color.Black
        Me.btnVolver.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnVolver.IconSize = 30
        Me.btnVolver.Location = New System.Drawing.Point(13, 13)
        Me.btnVolver.Margin = New System.Windows.Forms.Padding(4)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(180, 59)
        Me.btnVolver.TabIndex = 2
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnVolver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label2.Location = New System.Drawing.Point(364, 319)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(474, 200)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "¿Puedo solicitar un reembolso si cambio de opinión después de realizar un pedido?" &
    ""
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label3.Location = New System.Drawing.Point(948, 319)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(492, 192)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "¿Cómo puedo aplicar un código de descuento a mi compra?"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label4.Location = New System.Drawing.Point(1481, 346)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(511, 119)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "¿Ofrecen programas de lealtad o puntos de recompensa para clientes frecuentes?"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label8.Location = New System.Drawing.Point(1496, 500)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(518, 260)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Respuesta: Sí, contamos con un programa de lealtad que recompensa a nuestros clie" &
    "ntes frecuentes. Por cada compra, acumulas puntos que pueden canjearse por descu" &
    "entos." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label5.Location = New System.Drawing.Point(994, 494)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(427, 260)
        Me.Label5.TabIndex = 15
        Me.Label5.Tag = ""
        Me.Label5.Text = "Respuesta: Durante el proceso de pago, encontrarás un campo para ingresar códigos" &
    " de descuento. Introduce tu código y haz clic en ""Aplicar"" para disfrutar de des" &
    "cuentos especiales en tu pedido. "
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label6.Location = New System.Drawing.Point(352, 494)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(507, 260)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Respuesta: Lamentablemente, no aceptamos reembolsos por cambios de opinión. Te re" &
    "comendamos revisar cuidadosamente tu pedido antes de confirmarlo."
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmAyudaPagoPromociones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1833, 763)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmAyudaPagoPromociones"
        Me.Text = "frmAyudaDevolucion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnVolver As FontAwesome.Sharp.IconButton
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAgregarProducto
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
        Me.ButtonChoose = New FontAwesome.Sharp.IconButton()
        Me.ButtonCancel = New FontAwesome.Sharp.IconButton()
        Me.panelFrmAgregarProducto = New System.Windows.Forms.Panel()
        Me.BtnCancel = New FontAwesome.Sharp.IconButton()
        Me.BtnChoose = New FontAwesome.Sharp.IconButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtCantPCajas = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.txtReorden = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BoxMarca = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BoxCategoria = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPrecioU = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNomProducto = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BoxPicture = New FontAwesome.Sharp.IconPictureBox()
        Me.panelFrmAgregarProducto.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.BoxPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonChoose
        '
        Me.ButtonChoose.Cursor = System.Windows.Forms.Cursors.Default
        Me.ButtonChoose.IconChar = FontAwesome.Sharp.IconChar.PlusSquare
        Me.ButtonChoose.IconColor = System.Drawing.Color.Black
        Me.ButtonChoose.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.ButtonChoose.IconSize = 35
        Me.ButtonChoose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonChoose.Location = New System.Drawing.Point(-172, 214)
        Me.ButtonChoose.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonChoose.Name = "ButtonChoose"
        Me.ButtonChoose.Size = New System.Drawing.Size(101, 38)
        Me.ButtonChoose.TabIndex = 2
        Me.ButtonChoose.Text = "Choose"
        Me.ButtonChoose.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonChoose.UseVisualStyleBackColor = True
        '
        'ButtonCancel
        '
        Me.ButtonCancel.IconChar = FontAwesome.Sharp.IconChar.X
        Me.ButtonCancel.IconColor = System.Drawing.Color.Black
        Me.ButtonCancel.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.ButtonCancel.IconSize = 25
        Me.ButtonCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonCancel.Location = New System.Drawing.Point(-132, 257)
        Me.ButtonCancel.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(101, 38)
        Me.ButtonCancel.TabIndex = 4
        Me.ButtonCancel.Text = "Cancel"
        Me.ButtonCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonCancel.UseVisualStyleBackColor = True
        '
        'panelFrmAgregarProducto
        '
        Me.panelFrmAgregarProducto.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.panelFrmAgregarProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.panelFrmAgregarProducto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.panelFrmAgregarProducto.Controls.Add(Me.BtnCancel)
        Me.panelFrmAgregarProducto.Controls.Add(Me.BtnChoose)
        Me.panelFrmAgregarProducto.Controls.Add(Me.Panel1)
        Me.panelFrmAgregarProducto.Controls.Add(Me.Label2)
        Me.panelFrmAgregarProducto.Controls.Add(Me.Label1)
        Me.panelFrmAgregarProducto.Controls.Add(Me.BoxPicture)
        Me.panelFrmAgregarProducto.Controls.Add(Me.ButtonCancel)
        Me.panelFrmAgregarProducto.Controls.Add(Me.ButtonChoose)
        Me.panelFrmAgregarProducto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelFrmAgregarProducto.Location = New System.Drawing.Point(0, 0)
        Me.panelFrmAgregarProducto.Name = "panelFrmAgregarProducto"
        Me.panelFrmAgregarProducto.Size = New System.Drawing.Size(1056, 648)
        Me.panelFrmAgregarProducto.TabIndex = 7
        '
        'BtnCancel
        '
        Me.BtnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancel.ForeColor = System.Drawing.Color.Black
        Me.BtnCancel.IconChar = FontAwesome.Sharp.IconChar.Xmark
        Me.BtnCancel.IconColor = System.Drawing.Color.Black
        Me.BtnCancel.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BtnCancel.IconSize = 30
        Me.BtnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCancel.Location = New System.Drawing.Point(195, 373)
        Me.BtnCancel.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(101, 38)
        Me.BtnCancel.TabIndex = 8
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCancel.UseVisualStyleBackColor = False
        '
        'BtnChoose
        '
        Me.BtnChoose.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.BtnChoose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnChoose.IconChar = FontAwesome.Sharp.IconChar.PlusSquare
        Me.BtnChoose.IconColor = System.Drawing.Color.Black
        Me.BtnChoose.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BtnChoose.IconSize = 30
        Me.BtnChoose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnChoose.Location = New System.Drawing.Point(91, 373)
        Me.BtnChoose.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnChoose.Name = "BtnChoose"
        Me.BtnChoose.Size = New System.Drawing.Size(101, 38)
        Me.BtnChoose.TabIndex = 7
        Me.BtnChoose.Text = "Choose"
        Me.BtnChoose.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnChoose.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txtCantPCajas)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.BtnAgregar)
        Me.Panel1.Controls.Add(Me.txtReorden)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.BoxMarca)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.BoxCategoria)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.txtCantidad)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtPrecioU)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtNomProducto)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(369, 159)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(584, 352)
        Me.Panel1.TabIndex = 5
        '
        'txtCantPCajas
        '
        Me.txtCantPCajas.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.txtCantPCajas.Font = New System.Drawing.Font("Arial", 16.0!)
        Me.txtCantPCajas.ForeColor = System.Drawing.Color.White
        Me.txtCantPCajas.Location = New System.Drawing.Point(15, 232)
        Me.txtCantPCajas.Name = "txtCantPCajas"
        Me.txtCantPCajas.Size = New System.Drawing.Size(289, 32)
        Me.txtCantPCajas.TabIndex = 4
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(12, 211)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(144, 18)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Cantidad por Cajas"
        '
        'BtnAgregar
        '
        Me.BtnAgregar.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.BtnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.BtnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAgregar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAgregar.Location = New System.Drawing.Point(422, 232)
        Me.BtnAgregar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(121, 40)
        Me.BtnAgregar.TabIndex = 8
        Me.BtnAgregar.Text = "Agregar"
        Me.BtnAgregar.UseVisualStyleBackColor = False
        '
        'txtReorden
        '
        Me.txtReorden.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.txtReorden.Font = New System.Drawing.Font("Arial", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReorden.ForeColor = System.Drawing.Color.White
        Me.txtReorden.Location = New System.Drawing.Point(360, 165)
        Me.txtReorden.Margin = New System.Windows.Forms.Padding(2)
        Me.txtReorden.Name = "txtReorden"
        Me.txtReorden.Size = New System.Drawing.Size(183, 32)
        Me.txtReorden.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(359, 142)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 18)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "P.Reorden"
        '
        'BoxMarca
        '
        Me.BoxMarca.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.BoxMarca.Font = New System.Drawing.Font("Arial", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BoxMarca.ForeColor = System.Drawing.Color.White
        Me.BoxMarca.FormattingEnabled = True
        Me.BoxMarca.Location = New System.Drawing.Point(362, 99)
        Me.BoxMarca.Margin = New System.Windows.Forms.Padding(2)
        Me.BoxMarca.Name = "BoxMarca"
        Me.BoxMarca.Size = New System.Drawing.Size(181, 32)
        Me.BoxMarca.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(357, 76)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 18)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Marca"
        '
        'BoxCategoria
        '
        Me.BoxCategoria.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.BoxCategoria.Font = New System.Drawing.Font("Arial", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BoxCategoria.ForeColor = System.Drawing.Color.White
        Me.BoxCategoria.FormattingEnabled = True
        Me.BoxCategoria.Location = New System.Drawing.Point(362, 29)
        Me.BoxCategoria.Margin = New System.Windows.Forms.Padding(2)
        Me.BoxCategoria.Name = "BoxCategoria"
        Me.BoxCategoria.Size = New System.Drawing.Size(181, 32)
        Me.BoxCategoria.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(357, 7)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 18)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Categoría"
        '
        'txtCantidad
        '
        Me.txtCantidad.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.txtCantidad.Font = New System.Drawing.Font("Arial", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidad.ForeColor = System.Drawing.Color.White
        Me.txtCantidad.Location = New System.Drawing.Point(15, 165)
        Me.txtCantidad.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(289, 32)
        Me.txtCantidad.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(12, 142)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(139, 18)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Cantidad de Cajas"
        '
        'txtPrecioU
        '
        Me.txtPrecioU.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.txtPrecioU.Font = New System.Drawing.Font("Arial", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecioU.ForeColor = System.Drawing.Color.White
        Me.txtPrecioU.Location = New System.Drawing.Point(15, 96)
        Me.txtPrecioU.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPrecioU.Name = "txtPrecioU"
        Me.txtPrecioU.Size = New System.Drawing.Size(289, 32)
        Me.txtPrecioU.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(10, 73)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 18)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Precio Unitario"
        '
        'txtNomProducto
        '
        Me.txtNomProducto.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.txtNomProducto.Font = New System.Drawing.Font("Arial", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomProducto.ForeColor = System.Drawing.Color.White
        Me.txtNomProducto.Location = New System.Drawing.Point(15, 30)
        Me.txtNomProducto.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNomProducto.Name = "txtNomProducto"
        Me.txtNomProducto.Size = New System.Drawing.Size(289, 32)
        Me.txtNomProducto.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(10, 7)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 18)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(364, 117)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(334, 25)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Información General del Producto"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(104, 117)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(183, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Agregar Producto"
        '
        'BoxPicture
        '
        Me.BoxPicture.BackColor = System.Drawing.Color.FromArgb(CType(CType(110, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.BoxPicture.ForeColor = System.Drawing.SystemColors.Control
        Me.BoxPicture.IconChar = FontAwesome.Sharp.IconChar.Image
        Me.BoxPicture.IconColor = System.Drawing.SystemColors.Control
        Me.BoxPicture.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BoxPicture.IconSize = 187
        Me.BoxPicture.Location = New System.Drawing.Point(100, 159)
        Me.BoxPicture.Margin = New System.Windows.Forms.Padding(2)
        Me.BoxPicture.Name = "BoxPicture"
        Me.BoxPicture.Size = New System.Drawing.Size(187, 187)
        Me.BoxPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.BoxPicture.TabIndex = 1
        Me.BoxPicture.TabStop = False
        '
        'frmAgregarProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(1056, 648)
        Me.Controls.Add(Me.panelFrmAgregarProducto)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmAgregarProducto"
        Me.Text = "frmAgregarProducto"
        Me.panelFrmAgregarProducto.ResumeLayout(False)
        Me.panelFrmAgregarProducto.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.BoxPicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ButtonChoose As FontAwesome.Sharp.IconButton
    Friend WithEvents ButtonCancel As FontAwesome.Sharp.IconButton
    Friend WithEvents panelFrmAgregarProducto As Panel
    Friend WithEvents BtnCancel As FontAwesome.Sharp.IconButton
    Friend WithEvents BtnChoose As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnAgregar As Button
    Friend WithEvents txtReorden As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents BoxMarca As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents BoxCategoria As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtPrecioU As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtNomProducto As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BoxPicture As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtCantPCajas As TextBox
End Class
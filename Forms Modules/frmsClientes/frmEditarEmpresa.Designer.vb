<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditarEmpresa
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNombreEmpresa = New System.Windows.Forms.TextBox()
        Me.txtCorreoEmpresa = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtRazonSocial = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDocumento = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtDetallesEmpresa = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtTelefonoEmpresa = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.pbPreview = New System.Windows.Forms.PictureBox()
        Me.btnSeleccionar = New FontAwesome.Sharp.IconButton()
        Me.Label10 = New System.Windows.Forms.Label()
        CType(Me.pbPreview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(263, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(251, 39)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Editar Empresa"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(36, 114)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre:"
        '
        'txtNombreEmpresa
        '
        Me.txtNombreEmpresa.Location = New System.Drawing.Point(153, 116)
        Me.txtNombreEmpresa.Name = "txtNombreEmpresa"
        Me.txtNombreEmpresa.Size = New System.Drawing.Size(100, 20)
        Me.txtNombreEmpresa.TabIndex = 2
        '
        'txtCorreoEmpresa
        '
        Me.txtCorreoEmpresa.Location = New System.Drawing.Point(153, 168)
        Me.txtCorreoEmpresa.Name = "txtCorreoEmpresa"
        Me.txtCorreoEmpresa.Size = New System.Drawing.Size(100, 20)
        Me.txtCorreoEmpresa.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(36, 166)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Correo:"
        '
        'txtRazonSocial
        '
        Me.txtRazonSocial.Location = New System.Drawing.Point(153, 213)
        Me.txtRazonSocial.Name = "txtRazonSocial"
        Me.txtRazonSocial.Size = New System.Drawing.Size(100, 20)
        Me.txtRazonSocial.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(36, 211)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 20)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Razon Social:"
        '
        'txtDocumento
        '
        Me.txtDocumento.Location = New System.Drawing.Point(153, 259)
        Me.txtDocumento.Name = "txtDocumento"
        Me.txtDocumento.Size = New System.Drawing.Size(100, 20)
        Me.txtDocumento.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(36, 257)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 20)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Documento:"
        '
        'txtDetallesEmpresa
        '
        Me.txtDetallesEmpresa.Location = New System.Drawing.Point(449, 330)
        Me.txtDetallesEmpresa.Name = "txtDetallesEmpresa"
        Me.txtDetallesEmpresa.Size = New System.Drawing.Size(100, 20)
        Me.txtDetallesEmpresa.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(357, 328)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 20)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Detalles:"
        '
        'txtTelefonoEmpresa
        '
        Me.txtTelefonoEmpresa.Location = New System.Drawing.Point(449, 285)
        Me.txtTelefonoEmpresa.Name = "txtTelefonoEmpresa"
        Me.txtTelefonoEmpresa.Size = New System.Drawing.Size(100, 20)
        Me.txtTelefonoEmpresa.TabIndex = 12
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(357, 283)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 20)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Telefono:"
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(304, 396)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 15
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'pbPreview
        '
        Me.pbPreview.Location = New System.Drawing.Point(408, 104)
        Me.pbPreview.Name = "pbPreview"
        Me.pbPreview.Size = New System.Drawing.Size(156, 117)
        Me.pbPreview.TabIndex = 34
        Me.pbPreview.TabStop = False
        '
        'btnSeleccionar
        '
        Me.btnSeleccionar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSeleccionar.IconChar = FontAwesome.Sharp.IconChar.FileImage
        Me.btnSeleccionar.IconColor = System.Drawing.Color.Black
        Me.btnSeleccionar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnSeleccionar.IconSize = 30
        Me.btnSeleccionar.Location = New System.Drawing.Point(435, 227)
        Me.btnSeleccionar.Name = "btnSeleccionar"
        Me.btnSeleccionar.Size = New System.Drawing.Size(114, 42)
        Me.btnSeleccionar.TabIndex = 33
        Me.btnSeleccionar.Text = "Seleccionar Archivo"
        Me.btnSeleccionar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSeleccionar.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(360, 113)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(42, 20)
        Me.Label10.TabIndex = 32
        Me.Label10.Text = "Foto"
        '
        'frmEditarEmpresa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.pbPreview)
        Me.Controls.Add(Me.btnSeleccionar)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.txtDetallesEmpresa)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtTelefonoEmpresa)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtDocumento)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtRazonSocial)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtCorreoEmpresa)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNombreEmpresa)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmEditarEmpresa"
        Me.Text = "EditarEmpresa"
        CType(Me.pbPreview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNombreEmpresa As TextBox
    Friend WithEvents txtCorreoEmpresa As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtRazonSocial As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtDocumento As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtDetallesEmpresa As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtTelefonoEmpresa As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents btnAceptar As Button
    Friend WithEvents pbPreview As PictureBox
    Friend WithEvents btnSeleccionar As FontAwesome.Sharp.IconButton
    Friend WithEvents Label10 As Label
End Class

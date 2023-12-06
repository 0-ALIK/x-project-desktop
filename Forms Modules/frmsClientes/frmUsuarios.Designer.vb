<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUsuarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUsuarios))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.ptblogo = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblCedula = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ptblogo2 = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblCedula2 = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblApellido = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblCorreo = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblTelefono2 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lblGenero = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtDetalles = New System.Windows.Forms.TextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1.SuspendLayout()
        CType(Me.ptblogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptblogo2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(266, 39)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Perfil del Cliente"
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.txtDetalles)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.lblGenero)
        Me.TabPage1.Controls.Add(Me.Label15)
        Me.TabPage1.Controls.Add(Me.lblTelefono2)
        Me.TabPage1.Controls.Add(Me.Label13)
        Me.TabPage1.Controls.Add(Me.lblCorreo)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.lblApellido)
        Me.TabPage1.Controls.Add(Me.lblNombre)
        Me.TabPage1.Controls.Add(Me.lblCedula2)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.ptblogo2)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.lblTelefono)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.lblCedula)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.ptblogo)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(748, 339)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Información"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'ptblogo
        '
        Me.ptblogo.Image = CType(resources.GetObject("ptblogo.Image"), System.Drawing.Image)
        Me.ptblogo.Location = New System.Drawing.Point(6, 6)
        Me.ptblogo.Name = "ptblogo"
        Me.ptblogo.Size = New System.Drawing.Size(58, 46)
        Me.ptblogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptblogo.TabIndex = 0
        Me.ptblogo.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(70, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 17)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Empresa"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(187, 17)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "RUC:"
        '
        'lblCedula
        '
        Me.lblCedula.AutoSize = True
        Me.lblCedula.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCedula.Location = New System.Drawing.Point(263, 17)
        Me.lblCedula.Name = "lblCedula"
        Me.lblCedula.Size = New System.Drawing.Size(74, 17)
        Me.lblCedula.TabIndex = 4
        Me.lblCedula.Text = "8-888-888"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(428, 17)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 17)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Teléfono:"
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefono.Location = New System.Drawing.Point(529, 17)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(97, 17)
        Me.lblTelefono.TabIndex = 6
        Me.lblTelefono.Text = "507 651-5482"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(74, 60)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(178, 17)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Información general cliente"
        '
        'ptblogo2
        '
        Me.ptblogo2.Image = CType(resources.GetObject("ptblogo2.Image"), System.Drawing.Image)
        Me.ptblogo2.Location = New System.Drawing.Point(81, 88)
        Me.ptblogo2.Name = "ptblogo2"
        Me.ptblogo2.Size = New System.Drawing.Size(155, 91)
        Me.ptblogo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptblogo2.TabIndex = 8
        Me.ptblogo2.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(266, 112)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(25, 17)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "ID:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(266, 154)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 17)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Nombre:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(266, 198)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(62, 17)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Apellido:"
        '
        'lblCedula2
        '
        Me.lblCedula2.AutoSize = True
        Me.lblCedula2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCedula2.Location = New System.Drawing.Point(309, 112)
        Me.lblCedula2.Name = "lblCedula2"
        Me.lblCedula2.Size = New System.Drawing.Size(74, 17)
        Me.lblCedula2.TabIndex = 12
        Me.lblCedula2.Text = "8-888-888"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(349, 154)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(41, 17)
        Me.lblNombre.TabIndex = 13
        Me.lblNombre.Text = "Ryan"
        '
        'lblApellido
        '
        Me.lblApellido.AutoSize = True
        Me.lblApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellido.Location = New System.Drawing.Point(355, 198)
        Me.lblApellido.Name = "lblApellido"
        Me.lblApellido.Size = New System.Drawing.Size(56, 17)
        Me.lblApellido.TabIndex = 14
        Me.lblApellido.Text = "Gosling"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(511, 112)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(55, 17)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "Correo:"
        '
        'lblCorreo
        '
        Me.lblCorreo.AutoSize = True
        Me.lblCorreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCorreo.Location = New System.Drawing.Point(586, 112)
        Me.lblCorreo.Name = "lblCorreo"
        Me.lblCorreo.Size = New System.Drawing.Size(119, 17)
        Me.lblCorreo.TabIndex = 16
        Me.lblCorreo.Text = "idrive@gmail.com"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(511, 154)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(68, 17)
        Me.Label13.TabIndex = 17
        Me.Label13.Text = "Teléfono:"
        '
        'lblTelefono2
        '
        Me.lblTelefono2.AutoSize = True
        Me.lblTelefono2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefono2.Location = New System.Drawing.Point(600, 154)
        Me.lblTelefono2.Name = "lblTelefono2"
        Me.lblTelefono2.Size = New System.Drawing.Size(97, 17)
        Me.lblTelefono2.TabIndex = 18
        Me.lblTelefono2.Text = "507 651-5482"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(511, 198)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(60, 17)
        Me.Label15.TabIndex = 19
        Me.Label15.Text = "Género:"
        '
        'lblGenero
        '
        Me.lblGenero.AutoSize = True
        Me.lblGenero.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGenero.Location = New System.Drawing.Point(600, 198)
        Me.lblGenero.Name = "lblGenero"
        Me.lblGenero.Size = New System.Drawing.Size(73, 17)
        Me.lblGenero.TabIndex = 20
        Me.lblGenero.Text = "Conductor"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(76, 219)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(82, 25)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Detalles"
        '
        'txtDetalles
        '
        Me.txtDetalles.Location = New System.Drawing.Point(6, 247)
        Me.txtDetalles.Multiline = True
        Me.txtDetalles.Name = "txtDetalles"
        Me.txtDetalles.ReadOnly = True
        Me.txtDetalles.Size = New System.Drawing.Size(727, 86)
        Me.txtDetalles.TabIndex = 22
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(19, 73)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(756, 365)
        Me.TabControl1.TabIndex = 3
        '
        'frmUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmUsuarios"
        Me.Text = "Usuario"
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.ptblogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptblogo2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents txtDetalles As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents lblGenero As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents lblTelefono2 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents lblCorreo As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lblApellido As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblCedula2 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents ptblogo2 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents lblTelefono As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblCedula As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ptblogo As PictureBox
    Friend WithEvents TabControl1 As TabControl
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDirecciones
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
        Me.gboEditar = New System.Windows.Forms.GroupBox()
        Me.cmbProvinciaEDIT = New System.Windows.Forms.ComboBox()
        Me.txtDetallesEDIT = New System.Windows.Forms.TextBox()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtTelefonoEDIT = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtCodigoPostEDIT = New System.Windows.Forms.TextBox()
        Me.btnEliminarDireccion = New System.Windows.Forms.Button()
        Me.rdbAddDireccion = New System.Windows.Forms.RadioButton()
        Me.rdbEditar = New System.Windows.Forms.RadioButton()
        Me.gboAddDireccion = New System.Windows.Forms.GroupBox()
        Me.cmbProvincia = New System.Windows.Forms.ComboBox()
        Me.txtDetalles = New System.Windows.Forms.TextBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCodigoPost = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtgDireccionEmpresas = New System.Windows.Forms.DataGridView()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.codigo_postal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.detalles = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idDireccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gboEditar.SuspendLayout()
        Me.gboAddDireccion.SuspendLayout()
        CType(Me.dtgDireccionEmpresas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gboEditar
        '
        Me.gboEditar.Controls.Add(Me.cmbProvinciaEDIT)
        Me.gboEditar.Controls.Add(Me.txtDetallesEDIT)
        Me.gboEditar.Controls.Add(Me.btnActualizar)
        Me.gboEditar.Controls.Add(Me.Label6)
        Me.gboEditar.Controls.Add(Me.Label7)
        Me.gboEditar.Controls.Add(Me.txtTelefonoEDIT)
        Me.gboEditar.Controls.Add(Me.Label8)
        Me.gboEditar.Controls.Add(Me.Label9)
        Me.gboEditar.Controls.Add(Me.txtCodigoPostEDIT)
        Me.gboEditar.ForeColor = System.Drawing.Color.White
        Me.gboEditar.Location = New System.Drawing.Point(0, 2)
        Me.gboEditar.Name = "gboEditar"
        Me.gboEditar.Size = New System.Drawing.Size(800, 150)
        Me.gboEditar.TabIndex = 26
        Me.gboEditar.TabStop = False
        Me.gboEditar.Text = "Editar Dirección"
        '
        'cmbProvinciaEDIT
        '
        Me.cmbProvinciaEDIT.FormattingEnabled = True
        Me.cmbProvinciaEDIT.Location = New System.Drawing.Point(94, 30)
        Me.cmbProvinciaEDIT.Name = "cmbProvinciaEDIT"
        Me.cmbProvinciaEDIT.Size = New System.Drawing.Size(139, 21)
        Me.cmbProvinciaEDIT.TabIndex = 18
        '
        'txtDetallesEDIT
        '
        Me.txtDetallesEDIT.Location = New System.Drawing.Point(563, 31)
        Me.txtDetallesEDIT.Name = "txtDetallesEDIT"
        Me.txtDetallesEDIT.Size = New System.Drawing.Size(163, 20)
        Me.txtDetallesEDIT.TabIndex = 17
        '
        'btnActualizar
        '
        Me.btnActualizar.AllowDrop = True
        Me.btnActualizar.Location = New System.Drawing.Point(285, 118)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(157, 23)
        Me.btnActualizar.TabIndex = 16
        Me.btnActualizar.Text = "Actualizar Campos"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(504, 31)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Detalles"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(249, 31)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Telefono"
        '
        'txtTelefonoEDIT
        '
        Me.txtTelefonoEDIT.Location = New System.Drawing.Point(318, 31)
        Me.txtTelefonoEDIT.Name = "txtTelefonoEDIT"
        Me.txtTelefonoEDIT.Size = New System.Drawing.Size(163, 20)
        Me.txtTelefonoEDIT.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(15, 77)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 13)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Codigo Postal"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(15, 31)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(51, 13)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Provincia"
        '
        'txtCodigoPostEDIT
        '
        Me.txtCodigoPostEDIT.Location = New System.Drawing.Point(94, 70)
        Me.txtCodigoPostEDIT.Name = "txtCodigoPostEDIT"
        Me.txtCodigoPostEDIT.Size = New System.Drawing.Size(139, 20)
        Me.txtCodigoPostEDIT.TabIndex = 7
        '
        'btnEliminarDireccion
        '
        Me.btnEliminarDireccion.Location = New System.Drawing.Point(653, 48)
        Me.btnEliminarDireccion.Name = "btnEliminarDireccion"
        Me.btnEliminarDireccion.Size = New System.Drawing.Size(118, 23)
        Me.btnEliminarDireccion.TabIndex = 25
        Me.btnEliminarDireccion.Text = "Eliminar Dirección"
        Me.btnEliminarDireccion.UseVisualStyleBackColor = True
        '
        'rdbAddDireccion
        '
        Me.rdbAddDireccion.AutoSize = True
        Me.rdbAddDireccion.ForeColor = System.Drawing.Color.White
        Me.rdbAddDireccion.Location = New System.Drawing.Point(549, 380)
        Me.rdbAddDireccion.Name = "rdbAddDireccion"
        Me.rdbAddDireccion.Size = New System.Drawing.Size(124, 17)
        Me.rdbAddDireccion.TabIndex = 24
        Me.rdbAddDireccion.Text = "Añadir una Dirección"
        Me.rdbAddDireccion.UseVisualStyleBackColor = True
        '
        'rdbEditar
        '
        Me.rdbEditar.AutoSize = True
        Me.rdbEditar.Checked = True
        Me.rdbEditar.ForeColor = System.Drawing.Color.White
        Me.rdbEditar.Location = New System.Drawing.Point(187, 380)
        Me.rdbEditar.Name = "rdbEditar"
        Me.rdbEditar.Size = New System.Drawing.Size(103, 17)
        Me.rdbEditar.TabIndex = 23
        Me.rdbEditar.TabStop = True
        Me.rdbEditar.Text = "Editar  Dirección"
        Me.rdbEditar.UseVisualStyleBackColor = True
        '
        'gboAddDireccion
        '
        Me.gboAddDireccion.Controls.Add(Me.gboEditar)
        Me.gboAddDireccion.Controls.Add(Me.cmbProvincia)
        Me.gboAddDireccion.Controls.Add(Me.txtDetalles)
        Me.gboAddDireccion.Controls.Add(Me.btnGuardar)
        Me.gboAddDireccion.Controls.Add(Me.Label4)
        Me.gboAddDireccion.Controls.Add(Me.Label5)
        Me.gboAddDireccion.Controls.Add(Me.txtTelefono)
        Me.gboAddDireccion.Controls.Add(Me.Label3)
        Me.gboAddDireccion.Controls.Add(Me.Label1)
        Me.gboAddDireccion.Controls.Add(Me.txtCodigoPost)
        Me.gboAddDireccion.ForeColor = System.Drawing.Color.White
        Me.gboAddDireccion.Location = New System.Drawing.Point(0, 407)
        Me.gboAddDireccion.Name = "gboAddDireccion"
        Me.gboAddDireccion.Size = New System.Drawing.Size(800, 150)
        Me.gboAddDireccion.TabIndex = 22
        Me.gboAddDireccion.TabStop = False
        Me.gboAddDireccion.Text = "Añadir Dirección"
        Me.gboAddDireccion.Visible = False
        '
        'cmbProvincia
        '
        Me.cmbProvincia.FormattingEnabled = True
        Me.cmbProvincia.Location = New System.Drawing.Point(94, 30)
        Me.cmbProvincia.Name = "cmbProvincia"
        Me.cmbProvincia.Size = New System.Drawing.Size(139, 21)
        Me.cmbProvincia.TabIndex = 18
        '
        'txtDetalles
        '
        Me.txtDetalles.Location = New System.Drawing.Point(563, 31)
        Me.txtDetalles.Name = "txtDetalles"
        Me.txtDetalles.Size = New System.Drawing.Size(163, 20)
        Me.txtDetalles.TabIndex = 17
        '
        'btnGuardar
        '
        Me.btnGuardar.AllowDrop = True
        Me.btnGuardar.Location = New System.Drawing.Point(285, 105)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(157, 23)
        Me.btnGuardar.TabIndex = 16
        Me.btnGuardar.Text = "Añadir Dirección"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(504, 31)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Detalles"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(249, 31)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Telefono"
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(318, 31)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(163, 20)
        Me.txtTelefono.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Codigo Postal"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Provincia"
        '
        'txtCodigoPost
        '
        Me.txtCodigoPost.Location = New System.Drawing.Point(94, 70)
        Me.txtCodigoPost.Name = "txtCodigoPost"
        Me.txtCodigoPost.Size = New System.Drawing.Size(139, 20)
        Me.txtCodigoPost.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(22, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(512, 39)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Lista de Direcciones de empresa"
        '
        'dtgDireccionEmpresas
        '
        Me.dtgDireccionEmpresas.AllowUserToAddRows = False
        Me.dtgDireccionEmpresas.AllowUserToOrderColumns = True
        Me.dtgDireccionEmpresas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtgDireccionEmpresas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nombre, Me.codigo_postal, Me.telefono, Me.detalles, Me.idDireccion})
        Me.dtgDireccionEmpresas.Location = New System.Drawing.Point(29, 77)
        Me.dtgDireccionEmpresas.Name = "dtgDireccionEmpresas"
        Me.dtgDireccionEmpresas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgDireccionEmpresas.Size = New System.Drawing.Size(742, 288)
        Me.dtgDireccionEmpresas.TabIndex = 20
        '
        'nombre
        '
        Me.nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.nombre.Frozen = True
        Me.nombre.HeaderText = "Provincia"
        Me.nombre.Name = "nombre"
        Me.nombre.Width = 175
        '
        'codigo_postal
        '
        Me.codigo_postal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.codigo_postal.Frozen = True
        Me.codigo_postal.HeaderText = "Codigo Postal"
        Me.codigo_postal.Name = "codigo_postal"
        Me.codigo_postal.Width = 141
        '
        'telefono
        '
        Me.telefono.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.telefono.Frozen = True
        Me.telefono.HeaderText = "Telefono"
        Me.telefono.Name = "telefono"
        Me.telefono.Width = 142
        '
        'detalles
        '
        Me.detalles.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.detalles.Frozen = True
        Me.detalles.HeaderText = "Detalles"
        Me.detalles.Name = "detalles"
        Me.detalles.Width = 260
        '
        'idDireccion
        '
        Me.idDireccion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.idDireccion.HeaderText = "ID Direccion"
        Me.idDireccion.Name = "idDireccion"
        Me.idDireccion.Visible = False
        Me.idDireccion.Width = 5
        '
        'frmDirecciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 715)
        Me.Controls.Add(Me.btnEliminarDireccion)
        Me.Controls.Add(Me.rdbAddDireccion)
        Me.Controls.Add(Me.rdbEditar)
        Me.Controls.Add(Me.gboAddDireccion)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtgDireccionEmpresas)
        Me.Name = "frmDirecciones"
        Me.Text = "frmDirecciones"
        Me.gboEditar.ResumeLayout(False)
        Me.gboEditar.PerformLayout()
        Me.gboAddDireccion.ResumeLayout(False)
        Me.gboAddDireccion.PerformLayout()
        CType(Me.dtgDireccionEmpresas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gboEditar As GroupBox
    Friend WithEvents cmbProvinciaEDIT As ComboBox
    Friend WithEvents txtDetallesEDIT As TextBox
    Friend WithEvents btnActualizar As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtTelefonoEDIT As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtCodigoPostEDIT As TextBox
    Friend WithEvents btnEliminarDireccion As Button
    Friend WithEvents rdbAddDireccion As RadioButton
    Friend WithEvents rdbEditar As RadioButton
    Friend WithEvents gboAddDireccion As GroupBox
    Friend WithEvents cmbProvincia As ComboBox
    Friend WithEvents txtDetalles As TextBox
    Friend WithEvents btnGuardar As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCodigoPost As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents dtgDireccionEmpresas As DataGridView
    Friend WithEvents nombre As DataGridViewTextBoxColumn
    Friend WithEvents codigo_postal As DataGridViewTextBoxColumn
    Friend WithEvents telefono As DataGridViewTextBoxColumn
    Friend WithEvents detalles As DataGridViewTextBoxColumn
    Friend WithEvents idDireccion As DataGridViewTextBoxColumn
End Class

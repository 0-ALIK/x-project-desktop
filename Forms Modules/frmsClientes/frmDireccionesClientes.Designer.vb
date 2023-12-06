<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDireccionesClientes
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
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.gboAnadir = New System.Windows.Forms.GroupBox()
        Me.txtDetalle = New System.Windows.Forms.TextBox()
        Me.btnAnadir = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.cmbProvincia = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtCodigoP = New System.Windows.Forms.TextBox()
        Me.gboEditar = New System.Windows.Forms.GroupBox()
        Me.btnActualzar = New System.Windows.Forms.Button()
        Me.txtDetallesEDIT = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTelefonoEDIT = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCodigoPEDIT = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbProvinciaEDIT = New System.Windows.Forms.ComboBox()
        Me.rdbAnadir = New System.Windows.Forms.RadioButton()
        Me.rdbEditar = New System.Windows.Forms.RadioButton()
        Me.dgvClienteDir = New System.Windows.Forms.DataGridView()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.codigo_postal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.detalles = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cedula = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idDireccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gboAnadir.SuspendLayout()
        Me.gboEditar.SuspendLayout()
        CType(Me.dgvClienteDir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(681, 62)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(107, 23)
        Me.btnEliminar.TabIndex = 13
        Me.btnEliminar.Text = "Eliminar Dirección"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'gboAnadir
        '
        Me.gboAnadir.Controls.Add(Me.txtDetalle)
        Me.gboAnadir.Controls.Add(Me.btnAnadir)
        Me.gboAnadir.Controls.Add(Me.Label6)
        Me.gboAnadir.Controls.Add(Me.Label9)
        Me.gboAnadir.Controls.Add(Me.txtTelefono)
        Me.gboAnadir.Controls.Add(Me.cmbProvincia)
        Me.gboAnadir.Controls.Add(Me.Label7)
        Me.gboAnadir.Controls.Add(Me.Label8)
        Me.gboAnadir.Controls.Add(Me.txtCodigoP)
        Me.gboAnadir.ForeColor = System.Drawing.Color.White
        Me.gboAnadir.Location = New System.Drawing.Point(12, 314)
        Me.gboAnadir.Name = "gboAnadir"
        Me.gboAnadir.Size = New System.Drawing.Size(776, 138)
        Me.gboAnadir.TabIndex = 12
        Me.gboAnadir.TabStop = False
        Me.gboAnadir.Text = "Añadir Dirección"
        Me.gboAnadir.Visible = False
        '
        'txtDetalle
        '
        Me.txtDetalle.Location = New System.Drawing.Point(609, 32)
        Me.txtDetalle.Name = "txtDetalle"
        Me.txtDetalle.Size = New System.Drawing.Size(148, 20)
        Me.txtDetalle.TabIndex = 16
        '
        'btnAnadir
        '
        Me.btnAnadir.Location = New System.Drawing.Point(330, 109)
        Me.btnAnadir.Name = "btnAnadir"
        Me.btnAnadir.Size = New System.Drawing.Size(126, 23)
        Me.btnAnadir.TabIndex = 9
        Me.btnAnadir.Text = "Añadir Dirección"
        Me.btnAnadir.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(558, 39)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Detalles"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(25, 35)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(51, 13)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Provincia"
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(355, 33)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(148, 20)
        Me.txtTelefono.TabIndex = 14
        '
        'cmbProvincia
        '
        Me.cmbProvincia.FormattingEnabled = True
        Me.cmbProvincia.Location = New System.Drawing.Point(110, 32)
        Me.cmbProvincia.Name = "cmbProvincia"
        Me.cmbProvincia.Size = New System.Drawing.Size(121, 21)
        Me.cmbProvincia.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(270, 40)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Teléfono" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(25, 84)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 13)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Código Postal"
        '
        'txtCodigoP
        '
        Me.txtCodigoP.Location = New System.Drawing.Point(110, 77)
        Me.txtCodigoP.Name = "txtCodigoP"
        Me.txtCodigoP.Size = New System.Drawing.Size(121, 20)
        Me.txtCodigoP.TabIndex = 12
        '
        'gboEditar
        '
        Me.gboEditar.Controls.Add(Me.btnActualzar)
        Me.gboEditar.Controls.Add(Me.txtDetallesEDIT)
        Me.gboEditar.Controls.Add(Me.Label5)
        Me.gboEditar.Controls.Add(Me.txtTelefonoEDIT)
        Me.gboEditar.Controls.Add(Me.Label4)
        Me.gboEditar.Controls.Add(Me.txtCodigoPEDIT)
        Me.gboEditar.Controls.Add(Me.Label3)
        Me.gboEditar.Controls.Add(Me.Label2)
        Me.gboEditar.Controls.Add(Me.cmbProvinciaEDIT)
        Me.gboEditar.ForeColor = System.Drawing.Color.White
        Me.gboEditar.Location = New System.Drawing.Point(12, 301)
        Me.gboEditar.Name = "gboEditar"
        Me.gboEditar.Size = New System.Drawing.Size(776, 156)
        Me.gboEditar.TabIndex = 11
        Me.gboEditar.TabStop = False
        Me.gboEditar.Text = "Editar Dirección"
        '
        'btnActualzar
        '
        Me.btnActualzar.Location = New System.Drawing.Point(330, 122)
        Me.btnActualzar.Name = "btnActualzar"
        Me.btnActualzar.Size = New System.Drawing.Size(126, 23)
        Me.btnActualzar.TabIndex = 8
        Me.btnActualzar.Text = "Actualizar Campos"
        Me.btnActualzar.UseVisualStyleBackColor = True
        '
        'txtDetallesEDIT
        '
        Me.txtDetallesEDIT.Location = New System.Drawing.Point(609, 32)
        Me.txtDetallesEDIT.Name = "txtDetallesEDIT"
        Me.txtDetallesEDIT.Size = New System.Drawing.Size(148, 20)
        Me.txtDetallesEDIT.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(558, 39)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Detalles"
        '
        'txtTelefonoEDIT
        '
        Me.txtTelefonoEDIT.Location = New System.Drawing.Point(355, 33)
        Me.txtTelefonoEDIT.Name = "txtTelefonoEDIT"
        Me.txtTelefonoEDIT.Size = New System.Drawing.Size(148, 20)
        Me.txtTelefonoEDIT.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(270, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Teléfono" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txtCodigoPEDIT
        '
        Me.txtCodigoPEDIT.Location = New System.Drawing.Point(110, 77)
        Me.txtCodigoPEDIT.Name = "txtCodigoPEDIT"
        Me.txtCodigoPEDIT.Size = New System.Drawing.Size(121, 20)
        Me.txtCodigoPEDIT.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Código Postal"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Provincia"
        '
        'cmbProvinciaEDIT
        '
        Me.cmbProvinciaEDIT.FormattingEnabled = True
        Me.cmbProvinciaEDIT.Location = New System.Drawing.Point(110, 32)
        Me.cmbProvinciaEDIT.Name = "cmbProvinciaEDIT"
        Me.cmbProvinciaEDIT.Size = New System.Drawing.Size(121, 21)
        Me.cmbProvinciaEDIT.TabIndex = 0
        '
        'rdbAnadir
        '
        Me.rdbAnadir.AutoSize = True
        Me.rdbAnadir.ForeColor = System.Drawing.Color.White
        Me.rdbAnadir.Location = New System.Drawing.Point(532, 275)
        Me.rdbAnadir.Name = "rdbAnadir"
        Me.rdbAnadir.Size = New System.Drawing.Size(124, 17)
        Me.rdbAnadir.TabIndex = 10
        Me.rdbAnadir.TabStop = True
        Me.rdbAnadir.Text = "Añadir una Direccion"
        Me.rdbAnadir.UseVisualStyleBackColor = True
        '
        'rdbEditar
        '
        Me.rdbEditar.AutoSize = True
        Me.rdbEditar.ForeColor = System.Drawing.Color.White
        Me.rdbEditar.Location = New System.Drawing.Point(167, 275)
        Me.rdbEditar.Name = "rdbEditar"
        Me.rdbEditar.Size = New System.Drawing.Size(100, 17)
        Me.rdbEditar.TabIndex = 9
        Me.rdbEditar.TabStop = True
        Me.rdbEditar.Text = "Editar Dirección"
        Me.rdbEditar.UseVisualStyleBackColor = True
        '
        'dgvClienteDir
        '
        Me.dgvClienteDir.AllowUserToAddRows = False
        Me.dgvClienteDir.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvClienteDir.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvClienteDir.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nombre, Me.codigo_postal, Me.telefono, Me.detalles, Me.cedula, Me.idDireccion})
        Me.dgvClienteDir.Location = New System.Drawing.Point(12, 91)
        Me.dgvClienteDir.Name = "dgvClienteDir"
        Me.dgvClienteDir.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvClienteDir.Size = New System.Drawing.Size(776, 150)
        Me.dgvClienteDir.TabIndex = 8
        '
        'nombre
        '
        Me.nombre.HeaderText = "Provincia"
        Me.nombre.Name = "nombre"
        '
        'codigo_postal
        '
        Me.codigo_postal.HeaderText = "Codigo Postal"
        Me.codigo_postal.Name = "codigo_postal"
        '
        'telefono
        '
        Me.telefono.HeaderText = "Telefono"
        Me.telefono.Name = "telefono"
        '
        'detalles
        '
        Me.detalles.HeaderText = "Detalles"
        Me.detalles.Name = "detalles"
        '
        'cedula
        '
        Me.cedula.HeaderText = "Cedula"
        Me.cedula.Name = "cedula"
        '
        'idDireccion
        '
        Me.idDireccion.HeaderText = "idDireccion"
        Me.idDireccion.Name = "idDireccion"
        Me.idDireccion.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(479, 39)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Lista de Direcciones de cliente"
        '
        'frmDireccionesClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 739)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.gboAnadir)
        Me.Controls.Add(Me.gboEditar)
        Me.Controls.Add(Me.rdbAnadir)
        Me.Controls.Add(Me.rdbEditar)
        Me.Controls.Add(Me.dgvClienteDir)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmDireccionesClientes"
        Me.Text = "frmDireccionesClientes"
        Me.gboAnadir.ResumeLayout(False)
        Me.gboAnadir.PerformLayout()
        Me.gboEditar.ResumeLayout(False)
        Me.gboEditar.PerformLayout()
        CType(Me.dgvClienteDir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnEliminar As Button
    Friend WithEvents gboAnadir As GroupBox
    Friend WithEvents txtDetalle As TextBox
    Friend WithEvents btnAnadir As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents cmbProvincia As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtCodigoP As TextBox
    Friend WithEvents gboEditar As GroupBox
    Friend WithEvents btnActualzar As Button
    Friend WithEvents txtDetallesEDIT As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtTelefonoEDIT As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCodigoPEDIT As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbProvinciaEDIT As ComboBox
    Friend WithEvents rdbAnadir As RadioButton
    Friend WithEvents rdbEditar As RadioButton
    Friend WithEvents dgvClienteDir As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents nombre As DataGridViewTextBoxColumn
    Friend WithEvents codigo_postal As DataGridViewTextBoxColumn
    Friend WithEvents telefono As DataGridViewTextBoxColumn
    Friend WithEvents detalles As DataGridViewTextBoxColumn
    Friend WithEvents cedula As DataGridViewTextBoxColumn
    Friend WithEvents idDireccion As DataGridViewTextBoxColumn
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmClientes
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btnEditarUsuario = New System.Windows.Forms.Button()
        Me.btnEliminarUsuario = New System.Windows.Forms.Button()
        Me.dtgUsuarios = New System.Windows.Forms.DataGridView()
        Me.Cedula = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btnDireccionEmpresa = New System.Windows.Forms.Button()
        Me.btnEditarEmpresa = New System.Windows.Forms.Button()
        Me.btnEliminarEmpresa = New System.Windows.Forms.Button()
        Me.dtgEmpresas = New System.Windows.Forms.DataGridView()
        Me.RUC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.btnDireccionClientes = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnEditarCliente = New System.Windows.Forms.Button()
        Me.btnEliminarCliente = New System.Windows.Forms.Button()
        Me.dtgClientes = New System.Windows.Forms.DataGridView()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cedulacl = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dtgUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.dtgEmpresas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.dtgClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(7, 3)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1125, 444)
        Me.TabControl1.TabIndex = 4
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.btnEditarUsuario)
        Me.TabPage1.Controls.Add(Me.btnEliminarUsuario)
        Me.TabPage1.Controls.Add(Me.dtgUsuarios)
        Me.TabPage1.Location = New System.Drawing.Point(4, 29)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1117, 411)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Usuarios"
        '
        'btnEditarUsuario
        '
        Me.btnEditarUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.btnEditarUsuario.Font = New System.Drawing.Font("Segoe UI Semibold", 14.5!, System.Drawing.FontStyle.Bold)
        Me.btnEditarUsuario.Location = New System.Drawing.Point(687, 11)
        Me.btnEditarUsuario.Name = "btnEditarUsuario"
        Me.btnEditarUsuario.Size = New System.Drawing.Size(87, 34)
        Me.btnEditarUsuario.TabIndex = 2
        Me.btnEditarUsuario.Text = "Editar"
        Me.btnEditarUsuario.UseVisualStyleBackColor = False
        '
        'btnEliminarUsuario
        '
        Me.btnEliminarUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.btnEliminarUsuario.Font = New System.Drawing.Font("Segoe UI Semibold", 14.5!, System.Drawing.FontStyle.Bold)
        Me.btnEliminarUsuario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.btnEliminarUsuario.Location = New System.Drawing.Point(529, 11)
        Me.btnEliminarUsuario.Name = "btnEliminarUsuario"
        Me.btnEliminarUsuario.Size = New System.Drawing.Size(100, 34)
        Me.btnEliminarUsuario.TabIndex = 1
        Me.btnEliminarUsuario.Text = "Eliminar"
        Me.btnEliminarUsuario.UseVisualStyleBackColor = False
        '
        'dtgUsuarios
        '
        Me.dtgUsuarios.AllowDrop = True
        Me.dtgUsuarios.AllowUserToAddRows = False
        Me.dtgUsuarios.AllowUserToOrderColumns = True
        Me.dtgUsuarios.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtgUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtgUsuarios.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.dtgUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dtgUsuarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(47, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(86, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgUsuarios.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dtgUsuarios.ColumnHeadersHeight = 50
        Me.dtgUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dtgUsuarios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Cedula, Me.Column1, Me.Column4, Me.Column2, Me.Column3, Me.Column10, Me.Column5, Me.Column8, Me.Column6, Me.Column7})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(47, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(230, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtgUsuarios.DefaultCellStyle = DataGridViewCellStyle2
        Me.dtgUsuarios.EnableHeadersVisualStyles = False
        Me.dtgUsuarios.GridColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.dtgUsuarios.Location = New System.Drawing.Point(-2, 52)
        Me.dtgUsuarios.Name = "dtgUsuarios"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(193, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(230, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgUsuarios.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dtgUsuarios.RowHeadersVisible = False
        Me.dtgUsuarios.RowHeadersWidth = 51
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(47, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(230, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        Me.dtgUsuarios.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dtgUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgUsuarios.Size = New System.Drawing.Size(1116, 366)
        Me.dtgUsuarios.TabIndex = 0
        '
        'Cedula
        '
        Me.Cedula.HeaderText = "Cédula"
        Me.Cedula.MinimumWidth = 6
        Me.Cedula.Name = "Cedula"
        '
        'Column1
        '
        Me.Column1.HeaderText = "Nombre"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Apellido"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Correo"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Password"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        '
        'Column10
        '
        Me.Column10.HeaderText = "Rol"
        Me.Column10.MinimumWidth = 6
        Me.Column10.Name = "Column10"
        '
        'Column5
        '
        Me.Column5.HeaderText = "Género"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        '
        'Column8
        '
        Me.Column8.HeaderText = "Foto"
        Me.Column8.MinimumWidth = 6
        Me.Column8.Name = "Column8"
        '
        'Column6
        '
        Me.Column6.HeaderText = "Teléfono"
        Me.Column6.MinimumWidth = 6
        Me.Column6.Name = "Column6"
        '
        'Column7
        '
        Me.Column7.HeaderText = "Detalles"
        Me.Column7.MinimumWidth = 6
        Me.Column7.Name = "Column7"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.TabPage2.Controls.Add(Me.btnDireccionEmpresa)
        Me.TabPage2.Controls.Add(Me.btnEditarEmpresa)
        Me.TabPage2.Controls.Add(Me.btnEliminarEmpresa)
        Me.TabPage2.Controls.Add(Me.dtgEmpresas)
        Me.TabPage2.Location = New System.Drawing.Point(4, 29)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1117, 411)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Empresas"
        '
        'btnDireccionEmpresa
        '
        Me.btnDireccionEmpresa.BackColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.btnDireccionEmpresa.Font = New System.Drawing.Font("Segoe UI Semibold", 14.5!, System.Drawing.FontStyle.Bold)
        Me.btnDireccionEmpresa.Location = New System.Drawing.Point(765, 10)
        Me.btnDireccionEmpresa.Name = "btnDireccionEmpresa"
        Me.btnDireccionEmpresa.Size = New System.Drawing.Size(104, 37)
        Me.btnDireccionEmpresa.TabIndex = 8
        Me.btnDireccionEmpresa.Text = "Dirección"
        Me.btnDireccionEmpresa.UseVisualStyleBackColor = False
        '
        'btnEditarEmpresa
        '
        Me.btnEditarEmpresa.BackColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.btnEditarEmpresa.Font = New System.Drawing.Font("Segoe UI Semibold", 14.5!, System.Drawing.FontStyle.Bold)
        Me.btnEditarEmpresa.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.btnEditarEmpresa.Location = New System.Drawing.Point(647, 11)
        Me.btnEditarEmpresa.Name = "btnEditarEmpresa"
        Me.btnEditarEmpresa.Size = New System.Drawing.Size(87, 34)
        Me.btnEditarEmpresa.TabIndex = 6
        Me.btnEditarEmpresa.Text = "Editar"
        Me.btnEditarEmpresa.UseVisualStyleBackColor = False
        '
        'btnEliminarEmpresa
        '
        Me.btnEliminarEmpresa.BackColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.btnEliminarEmpresa.Font = New System.Drawing.Font("Segoe UI Semibold", 14.5!, System.Drawing.FontStyle.Bold)
        Me.btnEliminarEmpresa.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.btnEliminarEmpresa.Location = New System.Drawing.Point(529, 11)
        Me.btnEliminarEmpresa.Name = "btnEliminarEmpresa"
        Me.btnEliminarEmpresa.Size = New System.Drawing.Size(100, 34)
        Me.btnEliminarEmpresa.TabIndex = 5
        Me.btnEliminarEmpresa.Text = "Eliminar"
        Me.btnEliminarEmpresa.UseVisualStyleBackColor = False
        '
        'dtgEmpresas
        '
        Me.dtgEmpresas.AllowUserToAddRows = False
        Me.dtgEmpresas.AllowUserToOrderColumns = True
        Me.dtgEmpresas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtgEmpresas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtgEmpresas.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.dtgEmpresas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dtgEmpresas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(47, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(86, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgEmpresas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dtgEmpresas.ColumnHeadersHeight = 50
        Me.dtgEmpresas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RUC, Me.Nombre, Me.Column16, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.Column17, Me.Column18, Me.Column19})
        Me.dtgEmpresas.EnableHeadersVisualStyles = False
        Me.dtgEmpresas.GridColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.dtgEmpresas.Location = New System.Drawing.Point(-4, 54)
        Me.dtgEmpresas.Name = "dtgEmpresas"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(193, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgEmpresas.RowHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dtgEmpresas.RowHeadersVisible = False
        Me.dtgEmpresas.RowHeadersWidth = 51
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(47, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(230, Byte), Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White
        Me.dtgEmpresas.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.dtgEmpresas.Size = New System.Drawing.Size(1050, 368)
        Me.dtgEmpresas.TabIndex = 4
        '
        'RUC
        '
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.Red
        Me.RUC.DefaultCellStyle = DataGridViewCellStyle6
        Me.RUC.HeaderText = "RUC"
        Me.RUC.MinimumWidth = 6
        Me.RUC.Name = "RUC"
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.MinimumWidth = 6
        Me.Nombre.Name = "Nombre"
        '
        'Column16
        '
        Me.Column16.HeaderText = "Correo"
        Me.Column16.MinimumWidth = 6
        Me.Column16.Name = "Column16"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Razón Social"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Documento"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'Column17
        '
        Me.Column17.HeaderText = "Foto"
        Me.Column17.MinimumWidth = 6
        Me.Column17.Name = "Column17"
        '
        'Column18
        '
        Me.Column18.HeaderText = "Teléfono"
        Me.Column18.MinimumWidth = 6
        Me.Column18.Name = "Column18"
        '
        'Column19
        '
        Me.Column19.HeaderText = "Detalles"
        Me.Column19.MinimumWidth = 6
        Me.Column19.Name = "Column19"
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.TabPage3.Controls.Add(Me.btnDireccionClientes)
        Me.TabPage3.Controls.Add(Me.Button1)
        Me.TabPage3.Controls.Add(Me.btnEditarCliente)
        Me.TabPage3.Controls.Add(Me.btnEliminarCliente)
        Me.TabPage3.Controls.Add(Me.dtgClientes)
        Me.TabPage3.Location = New System.Drawing.Point(4, 29)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(1117, 411)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Clientes"
        '
        'btnDireccionClientes
        '
        Me.btnDireccionClientes.BackColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.btnDireccionClientes.Font = New System.Drawing.Font("Segoe UI Semibold", 14.5!, System.Drawing.FontStyle.Bold)
        Me.btnDireccionClientes.Location = New System.Drawing.Point(736, 8)
        Me.btnDireccionClientes.Name = "btnDireccionClientes"
        Me.btnDireccionClientes.Size = New System.Drawing.Size(111, 40)
        Me.btnDireccionClientes.TabIndex = 12
        Me.btnDireccionClientes.Text = "Dirección"
        Me.btnDireccionClientes.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Segoe UI Semibold", 14.5!, System.Drawing.FontStyle.Bold)
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(402, 16)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(0, 0)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Eliminar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnEditarCliente
        '
        Me.btnEditarCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.btnEditarCliente.Font = New System.Drawing.Font("Segoe UI Semibold", 14.5!, System.Drawing.FontStyle.Bold)
        Me.btnEditarCliente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.btnEditarCliente.Location = New System.Drawing.Point(628, 11)
        Me.btnEditarCliente.Name = "btnEditarCliente"
        Me.btnEditarCliente.Size = New System.Drawing.Size(87, 34)
        Me.btnEditarCliente.TabIndex = 10
        Me.btnEditarCliente.Text = "Editar"
        Me.btnEditarCliente.UseVisualStyleBackColor = False
        '
        'btnEliminarCliente
        '
        Me.btnEliminarCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.btnEliminarCliente.Font = New System.Drawing.Font("Segoe UI Semibold", 14.5!, System.Drawing.FontStyle.Bold)
        Me.btnEliminarCliente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.btnEliminarCliente.Location = New System.Drawing.Point(508, 11)
        Me.btnEliminarCliente.Name = "btnEliminarCliente"
        Me.btnEliminarCliente.Size = New System.Drawing.Size(100, 34)
        Me.btnEliminarCliente.TabIndex = 9
        Me.btnEliminarCliente.Text = "Eliminar"
        Me.btnEliminarCliente.UseVisualStyleBackColor = False
        '
        'dtgClientes
        '
        Me.dtgClientes.AllowDrop = True
        Me.dtgClientes.AllowUserToAddRows = False
        Me.dtgClientes.AllowUserToOrderColumns = True
        Me.dtgClientes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtgClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtgClientes.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.dtgClientes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dtgClientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(47, Byte), Integer))
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(86, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgClientes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.dtgClientes.ColumnHeadersHeight = 50
        Me.dtgClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dtgClientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column11, Me.DataGridViewTextBoxColumn7, Me.Cedulacl, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.Column12, Me.Column13, Me.Column14, Me.DataGridViewTextBoxColumn13})
        Me.dtgClientes.EnableHeadersVisualStyles = False
        Me.dtgClientes.GridColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.dtgClientes.Location = New System.Drawing.Point(-4, 57)
        Me.dtgClientes.Name = "dtgClientes"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(193, Byte), Integer))
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgClientes.RowHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.dtgClientes.RowHeadersVisible = False
        Me.dtgClientes.RowHeadersWidth = 51
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(47, Byte), Integer))
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.dtgClientes.RowsDefaultCellStyle = DataGridViewCellStyle11
        Me.dtgClientes.Size = New System.Drawing.Size(1050, 365)
        Me.dtgClientes.TabIndex = 8
        '
        'Column11
        '
        Me.Column11.HeaderText = "Nombre"
        Me.Column11.MinimumWidth = 6
        Me.Column11.Name = "Column11"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.HeaderText = "Apellido"
        Me.DataGridViewTextBoxColumn7.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'Cedulacl
        '
        Me.Cedulacl.HeaderText = "Cédula"
        Me.Cedulacl.MinimumWidth = 6
        Me.Cedulacl.Name = "Cedulacl"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.HeaderText = "Empresa_id"
        Me.DataGridViewTextBoxColumn10.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.HeaderText = "Género"
        Me.DataGridViewTextBoxColumn11.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'Column12
        '
        Me.Column12.HeaderText = "Foto"
        Me.Column12.MinimumWidth = 6
        Me.Column12.Name = "Column12"
        '
        'Column13
        '
        Me.Column13.HeaderText = "Teléfono"
        Me.Column13.MinimumWidth = 6
        Me.Column13.Name = "Column13"
        '
        'Column14
        '
        Me.Column14.HeaderText = "Detalles"
        Me.Column14.MinimumWidth = 6
        Me.Column14.Name = "Column14"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.HeaderText = "Tipo"
        Me.DataGridViewTextBoxColumn13.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'frmClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1144, 450)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "frmClientes"
        Me.Text = "Clientes"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.dtgUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.dtgEmpresas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        CType(Me.dtgClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents btnEditarUsuario As Button
    Friend WithEvents btnEliminarUsuario As Button
    Friend WithEvents dtgUsuarios As DataGridView
    Friend WithEvents Cedula As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents btnDireccionEmpresa As Button
    Friend WithEvents btnEditarEmpresa As Button
    Friend WithEvents btnEliminarEmpresa As Button
    Friend WithEvents dtgEmpresas As DataGridView
    Friend WithEvents RUC As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Column16 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents Column17 As DataGridViewTextBoxColumn
    Friend WithEvents Column18 As DataGridViewTextBoxColumn
    Friend WithEvents Column19 As DataGridViewTextBoxColumn
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents btnDireccionClientes As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents btnEditarCliente As Button
    Friend WithEvents btnEliminarCliente As Button
    Friend WithEvents dtgClientes As DataGridView
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents Cedulacl As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents Column12 As DataGridViewTextBoxColumn
    Friend WithEvents Column13 As DataGridViewTextBoxColumn
    Friend WithEvents Column14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
End Class

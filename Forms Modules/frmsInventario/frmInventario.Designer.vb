<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmInventario
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
        Dim tsMarcaInv As System.Windows.Forms.ToolStripMenuItem
        Dim tsAgregarInv As System.Windows.Forms.ToolStripDropDownButton
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInventario))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.tsProductoInv = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsCategoriaInv = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsRealizarCompraInv = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.dgvInv = New System.Windows.Forms.DataGridView()
        Me.Eliminar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.pan = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.btnBuscarInv = New FontAwesome.Sharp.IconButton()
        Me.txtBuscarInv = New System.Windows.Forms.TextBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.btnReporteInv = New FontAwesome.Sharp.IconButton()
        Me.btnLimpiarInv = New FontAwesome.Sharp.IconButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.panelFrmInventario = New System.Windows.Forms.Panel()
        tsMarcaInv = New System.Windows.Forms.ToolStripMenuItem()
        tsAgregarInv = New System.Windows.Forms.ToolStripDropDownButton()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.dgvInv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pan.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.panelFrmInventario.SuspendLayout()
        Me.SuspendLayout()
        '
        'tsMarcaInv
        '
        tsMarcaInv.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(33, Byte), Integer))
        tsMarcaInv.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        tsMarcaInv.ForeColor = System.Drawing.Color.White
        tsMarcaInv.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        tsMarcaInv.ImageTransparentColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        tsMarcaInv.Name = "tsMarcaInv"
        tsMarcaInv.Padding = New System.Windows.Forms.Padding(0, 0, 0, 2)
        tsMarcaInv.ShowShortcutKeys = False
        tsMarcaInv.Size = New System.Drawing.Size(224, 30)
        tsMarcaInv.Text = "Marca"
        AddHandler tsMarcaInv.Click, AddressOf Me.tsMarcaInv_Click
        '
        'tsAgregarInv
        '
        tsAgregarInv.BackColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(230, Byte), Integer))
        tsAgregarInv.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        tsAgregarInv.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {tsMarcaInv, Me.tsProductoInv, Me.tsCategoriaInv, Me.tsRealizarCompraInv})
        tsAgregarInv.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        tsAgregarInv.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(33, Byte), Integer))
        tsAgregarInv.Image = CType(resources.GetObject("tsAgregarInv.Image"), System.Drawing.Image)
        tsAgregarInv.ImageTransparentColor = System.Drawing.Color.BlueViolet
        tsAgregarInv.Margin = New System.Windows.Forms.Padding(0)
        tsAgregarInv.MergeAction = System.Windows.Forms.MergeAction.MatchOnly
        tsAgregarInv.Name = "tsAgregarInv"
        tsAgregarInv.Padding = New System.Windows.Forms.Padding(2, 2, 12, 2)
        tsAgregarInv.Size = New System.Drawing.Size(108, 33)
        tsAgregarInv.Text = "Agregar"
        tsAgregarInv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        tsAgregarInv.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        tsAgregarInv.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
        tsAgregarInv.ToolTipText = "Agregar"
        AddHandler tsAgregarInv.Click, AddressOf Me.tsAgregarInv_Click
        '
        'tsProductoInv
        '
        Me.tsProductoInv.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.tsProductoInv.ForeColor = System.Drawing.Color.White
        Me.tsProductoInv.Name = "tsProductoInv"
        Me.tsProductoInv.Padding = New System.Windows.Forms.Padding(0, 0, 0, 2)
        Me.tsProductoInv.Size = New System.Drawing.Size(224, 30)
        Me.tsProductoInv.Text = "Producto"
        '
        'tsCategoriaInv
        '
        Me.tsCategoriaInv.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.tsCategoriaInv.ForeColor = System.Drawing.Color.White
        Me.tsCategoriaInv.Name = "tsCategoriaInv"
        Me.tsCategoriaInv.Padding = New System.Windows.Forms.Padding(0, 0, 0, 2)
        Me.tsCategoriaInv.Size = New System.Drawing.Size(224, 30)
        Me.tsCategoriaInv.Text = "Categoria"
        '
        'tsRealizarCompraInv
        '
        Me.tsRealizarCompraInv.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.tsRealizarCompraInv.ForeColor = System.Drawing.Color.White
        Me.tsRealizarCompraInv.Name = "tsRealizarCompraInv"
        Me.tsRealizarCompraInv.Padding = New System.Windows.Forms.Padding(0, 0, 0, 2)
        Me.tsRealizarCompraInv.Size = New System.Drawing.Size(224, 30)
        Me.tsRealizarCompraInv.Text = "Realizar Compra"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Label1.Location = New System.Drawing.Point(30, 14)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Inventario"
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(20, 20)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.Padding = New System.Drawing.Point(15, 3)
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(945, 529)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TabPage1.CausesValidation = False
        Me.TabPage1.Controls.Add(Me.Panel2)
        Me.TabPage1.Controls.Add(Me.Panel1)
        Me.TabPage1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage1.Location = New System.Drawing.Point(4, 29)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(0)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(937, 496)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Inventario"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel5)
        Me.Panel2.Controls.Add(Me.pan)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 53)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(937, 443)
        Me.Panel2.TabIndex = 7
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.Panel5.Controls.Add(Me.dgvInv)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(0, 67)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Padding = New System.Windows.Forms.Padding(15, 0, 15, 15)
        Me.Panel5.Size = New System.Drawing.Size(937, 376)
        Me.Panel5.TabIndex = 5
        '
        'dgvInv
        '
        Me.dgvInv.AllowDrop = True
        Me.dgvInv.AllowUserToAddRows = False
        Me.dgvInv.AllowUserToDeleteRows = False
        Me.dgvInv.AllowUserToOrderColumns = True
        Me.dgvInv.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvInv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvInv.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.dgvInv.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvInv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(47, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(86, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvInv.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvInv.ColumnHeadersHeight = 50
        Me.dgvInv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvInv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Eliminar})
        Me.dgvInv.EnableHeadersVisualStyles = False
        Me.dgvInv.GridColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.dgvInv.Location = New System.Drawing.Point(20, 5)
        Me.dgvInv.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dgvInv.Name = "dgvInv"
        Me.dgvInv.ReadOnly = True
        Me.dgvInv.RowHeadersVisible = False
        Me.dgvInv.RowHeadersWidth = 100
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(47, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(47, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        Me.dgvInv.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvInv.RowTemplate.Height = 50
        Me.dgvInv.RowTemplate.ReadOnly = True
        Me.dgvInv.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvInv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvInv.Size = New System.Drawing.Size(897, 288)
        Me.dgvInv.TabIndex = 2
        '
        'Eliminar
        '
        Me.Eliminar.HeaderText = "Eliminar"
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.ReadOnly = True
        Me.Eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Eliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Eliminar.Text = "Eliminar"
        Me.Eliminar.ToolTipText = "Eliminar"
        Me.Eliminar.UseColumnTextForButtonValue = True
        Me.Eliminar.Width = 89
        '
        'pan
        '
        Me.pan.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.pan.Controls.Add(Me.Panel7)
        Me.pan.Controls.Add(Me.Panel6)
        Me.pan.Dock = System.Windows.Forms.DockStyle.Top
        Me.pan.Location = New System.Drawing.Point(0, 0)
        Me.pan.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pan.Name = "pan"
        Me.pan.Size = New System.Drawing.Size(937, 67)
        Me.pan.TabIndex = 4
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.Panel7.Controls.Add(Me.btnBuscarInv)
        Me.Panel7.Controls.Add(Me.txtBuscarInv)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel7.Location = New System.Drawing.Point(637, 0)
        Me.Panel7.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(300, 67)
        Me.Panel7.TabIndex = 8
        '
        'btnBuscarInv
        '
        Me.btnBuscarInv.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.btnBuscarInv.FlatAppearance.BorderSize = 0
        Me.btnBuscarInv.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscarInv.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass
        Me.btnBuscarInv.IconColor = System.Drawing.Color.White
        Me.btnBuscarInv.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnBuscarInv.IconSize = 30
        Me.btnBuscarInv.Location = New System.Drawing.Point(238, 15)
        Me.btnBuscarInv.Name = "btnBuscarInv"
        Me.btnBuscarInv.Size = New System.Drawing.Size(42, 41)
        Me.btnBuscarInv.TabIndex = 9
        Me.btnBuscarInv.UseVisualStyleBackColor = False
        '
        'txtBuscarInv
        '
        Me.txtBuscarInv.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.txtBuscarInv.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBuscarInv.ForeColor = System.Drawing.Color.White
        Me.txtBuscarInv.Location = New System.Drawing.Point(54, 15)
        Me.txtBuscarInv.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtBuscarInv.Multiline = True
        Me.txtBuscarInv.Name = "txtBuscarInv"
        Me.txtBuscarInv.Size = New System.Drawing.Size(226, 41)
        Me.txtBuscarInv.TabIndex = 4
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.Panel6.Controls.Add(Me.btnReporteInv)
        Me.Panel6.Controls.Add(Me.btnLimpiarInv)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(30, 5, 4, 5)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Padding = New System.Windows.Forms.Padding(30, 31, 30, 31)
        Me.Panel6.Size = New System.Drawing.Size(325, 67)
        Me.Panel6.TabIndex = 6
        '
        'btnReporteInv
        '
        Me.btnReporteInv.BackColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.btnReporteInv.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.btnReporteInv.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReporteInv.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.btnReporteInv.IconChar = FontAwesome.Sharp.IconChar.FileImport
        Me.btnReporteInv.IconColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.btnReporteInv.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnReporteInv.IconSize = 35
        Me.btnReporteInv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReporteInv.Location = New System.Drawing.Point(134, 14)
        Me.btnReporteInv.Name = "btnReporteInv"
        Me.btnReporteInv.Size = New System.Drawing.Size(114, 44)
        Me.btnReporteInv.TabIndex = 5
        Me.btnReporteInv.Text = "       Reporte"
        Me.btnReporteInv.UseVisualStyleBackColor = False
        '
        'btnLimpiarInv
        '
        Me.btnLimpiarInv.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.btnLimpiarInv.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLimpiarInv.ForeColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.btnLimpiarInv.IconChar = FontAwesome.Sharp.IconChar.FilterCircleXmark
        Me.btnLimpiarInv.IconColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.btnLimpiarInv.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnLimpiarInv.IconSize = 35
        Me.btnLimpiarInv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLimpiarInv.Location = New System.Drawing.Point(20, 14)
        Me.btnLimpiarInv.Name = "btnLimpiarInv"
        Me.btnLimpiarInv.Size = New System.Drawing.Size(114, 44)
        Me.btnLimpiarInv.TabIndex = 4
        Me.btnLimpiarInv.Text = "      Limpiar"
        Me.btnLimpiarInv.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(937, 53)
        Me.Panel1.TabIndex = 6
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.ToolStrip1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(676, 0)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Padding = New System.Windows.Forms.Padding(30, 10, 10, 10)
        Me.Panel4.Size = New System.Drawing.Size(261, 53)
        Me.Panel4.TabIndex = 1
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {tsAgregarInv})
        Me.ToolStrip1.Location = New System.Drawing.Point(137, 11)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip1.Size = New System.Drawing.Size(142, 33)
        Me.ToolStrip1.Stretch = True
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(300, 53)
        Me.Panel3.TabIndex = 0
        '
        'panelFrmInventario
        '
        Me.panelFrmInventario.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.panelFrmInventario.Controls.Add(Me.TabControl1)
        Me.panelFrmInventario.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelFrmInventario.Location = New System.Drawing.Point(0, 0)
        Me.panelFrmInventario.Margin = New System.Windows.Forms.Padding(75, 77, 75, 77)
        Me.panelFrmInventario.Name = "panelFrmInventario"
        Me.panelFrmInventario.Padding = New System.Windows.Forms.Padding(20)
        Me.panelFrmInventario.Size = New System.Drawing.Size(984, 569)
        Me.panelFrmInventario.TabIndex = 4
        '
        'frmInventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(984, 569)
        Me.ControlBox = False
        Me.Controls.Add(Me.panelFrmInventario)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmInventario"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inventario"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        CType(Me.dgvInv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pan.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.panelFrmInventario.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents dgvInv As DataGridView
    Friend WithEvents btnAgregarInventario As Button
    Friend WithEvents txtBuscarInv As TextBox
    Friend WithEvents pan As Panel
    Friend WithEvents panelFrmInventario As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents btnLimpiarInv As FontAwesome.Sharp.IconButton
    Friend WithEvents btnReporteInv As FontAwesome.Sharp.IconButton
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents tsProductoInv As ToolStripMenuItem
    Friend WithEvents tsCategoriaInv As ToolStripMenuItem
    Friend WithEvents tsRealizarCompraInv As ToolStripMenuItem
    Friend WithEvents btnBuscarInv As FontAwesome.Sharp.IconButton
    Friend WithEvents Eliminar As DataGridViewButtonColumn
End Class

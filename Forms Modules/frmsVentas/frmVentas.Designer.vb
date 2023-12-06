<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmVentas
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.panelFrmInventario = New System.Windows.Forms.Panel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.dgvPedidos = New System.Windows.Forms.DataGridView()
        Me.pan = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.btnBuscarInv = New FontAwesome.Sharp.IconButton()
        Me.txtBuscarInv = New System.Windows.Forms.TextBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.btnReporteInv = New FontAwesome.Sharp.IconButton()
        Me.btnLimpiarInv = New FontAwesome.Sharp.IconButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.panelFrmInventario.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.dgvPedidos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pan.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(372, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ventas"
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
        Me.panelFrmInventario.Size = New System.Drawing.Size(800, 450)
        Me.panelFrmInventario.TabIndex = 5
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
        Me.TabControl1.Size = New System.Drawing.Size(761, 410)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TabPage1.CausesValidation = False
        Me.TabPage1.Controls.Add(Me.Panel2)
        Me.TabPage1.Controls.Add(Me.Panel1)
        Me.TabPage1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(0)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(753, 384)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Ventas"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel5)
        Me.Panel2.Controls.Add(Me.pan)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 53)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(753, 331)
        Me.Panel2.TabIndex = 7
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.Panel5.Controls.Add(Me.dgvPedidos)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(0, 67)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Padding = New System.Windows.Forms.Padding(15, 0, 15, 15)
        Me.Panel5.Size = New System.Drawing.Size(753, 264)
        Me.Panel5.TabIndex = 5
        '
        'dgvPedidos
        '
        Me.dgvPedidos.AllowDrop = True
        Me.dgvPedidos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvPedidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvPedidos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.dgvPedidos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvPedidos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(47, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(86, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPedidos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvPedidos.ColumnHeadersHeight = 50
        Me.dgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvPedidos.EnableHeadersVisualStyles = False
        Me.dgvPedidos.GridColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.dgvPedidos.Location = New System.Drawing.Point(20, 5)
        Me.dgvPedidos.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dgvPedidos.Name = "dgvPedidos"
        Me.dgvPedidos.ReadOnly = True
        Me.dgvPedidos.RowHeadersVisible = False
        Me.dgvPedidos.RowHeadersWidth = 100
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(47, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(86, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        Me.dgvPedidos.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvPedidos.RowTemplate.Height = 50
        Me.dgvPedidos.RowTemplate.ReadOnly = True
        Me.dgvPedidos.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPedidos.Size = New System.Drawing.Size(713, 176)
        Me.dgvPedidos.TabIndex = 2
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
        Me.pan.Size = New System.Drawing.Size(753, 67)
        Me.pan.TabIndex = 4
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.Panel7.Controls.Add(Me.btnBuscarInv)
        Me.Panel7.Controls.Add(Me.txtBuscarInv)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel7.Location = New System.Drawing.Point(453, 0)
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
        Me.Panel1.Size = New System.Drawing.Size(753, 53)
        Me.Panel1.TabIndex = 6
        '
        'Panel4
        '
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(492, 0)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Padding = New System.Windows.Forms.Padding(30, 10, 10, 10)
        Me.Panel4.Size = New System.Drawing.Size(261, 53)
        Me.Panel4.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(300, 53)
        Me.Panel3.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Label2.Location = New System.Drawing.Point(30, 14)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 31)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Ventas"
        '
        'frmVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.panelFrmInventario)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmVentas"
        Me.Text = "Ventas"
        Me.panelFrmInventario.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        CType(Me.dgvPedidos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pan.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents panelFrmInventario As Panel
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents dgvPedidos As DataGridView
    Friend WithEvents pan As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents btnBuscarInv As FontAwesome.Sharp.IconButton
    Friend WithEvents txtBuscarInv As TextBox
    Friend WithEvents Panel6 As Panel
    Friend WithEvents btnReporteInv As FontAwesome.Sharp.IconButton
    Friend WithEvents btnLimpiarInv As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label2 As Label
End Class

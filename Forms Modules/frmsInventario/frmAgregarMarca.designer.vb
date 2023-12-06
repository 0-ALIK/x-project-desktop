<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAgregarMarca
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnActualizarMarca = New System.Windows.Forms.Button()
        Me.dgvVerMarcas = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.editar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.eliminar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.edit = New System.Windows.Forms.DataGridViewImageColumn()
        Me.delet = New System.Windows.Forms.DataGridViewImageColumn()
        Me.btnAgregarMarca = New System.Windows.Forms.Button()
        Me.btnVerMarcas = New System.Windows.Forms.Button()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pbMarca = New FontAwesome.Sharp.IconPictureBox()
        Me.btnCancelUpload = New FontAwesome.Sharp.IconButton()
        Me.btnUpload = New FontAwesome.Sharp.IconButton()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvVerMarcas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbMarca, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 14.0!)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(273, 73)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(284, 22)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Información General de la Marca"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnActualizarMarca)
        Me.Panel1.Controls.Add(Me.dgvVerMarcas)
        Me.Panel1.Controls.Add(Me.btnAgregarMarca)
        Me.Panel1.Controls.Add(Me.btnVerMarcas)
        Me.Panel1.Controls.Add(Me.txtDescripcion)
        Me.Panel1.Controls.Add(Me.txtNombre)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(277, 98)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(401, 226)
        Me.Panel1.TabIndex = 28
        '
        'btnActualizarMarca
        '
        Me.btnActualizarMarca.BackColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.btnActualizarMarca.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActualizarMarca.Location = New System.Drawing.Point(231, 179)
        Me.btnActualizarMarca.Name = "btnActualizarMarca"
        Me.btnActualizarMarca.Size = New System.Drawing.Size(135, 40)
        Me.btnActualizarMarca.TabIndex = 41
        Me.btnActualizarMarca.Text = "Actualizar"
        Me.btnActualizarMarca.UseVisualStyleBackColor = False
        Me.btnActualizarMarca.Visible = False
        '
        'dgvVerMarcas
        '
        Me.dgvVerMarcas.AllowDrop = True
        Me.dgvVerMarcas.AllowUserToAddRows = False
        Me.dgvVerMarcas.AllowUserToDeleteRows = False
        Me.dgvVerMarcas.AllowUserToResizeColumns = False
        Me.dgvVerMarcas.AllowUserToResizeRows = False
        Me.dgvVerMarcas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvVerMarcas.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.dgvVerMarcas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvVerMarcas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgvVerMarcas.ColumnHeadersHeight = 25
        Me.dgvVerMarcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvVerMarcas.ColumnHeadersVisible = False
        Me.dgvVerMarcas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.nombre, Me.editar, Me.eliminar, Me.edit, Me.delet})
        Me.dgvVerMarcas.EnableHeadersVisualStyles = False
        Me.dgvVerMarcas.GridColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.dgvVerMarcas.Location = New System.Drawing.Point(13, 15)
        Me.dgvVerMarcas.Name = "dgvVerMarcas"
        Me.dgvVerMarcas.ReadOnly = True
        Me.dgvVerMarcas.RowHeadersVisible = False
        Me.dgvVerMarcas.RowHeadersWidth = 21
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(47, Byte), Integer))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(47, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        Me.dgvVerMarcas.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvVerMarcas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvVerMarcas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvVerMarcas.Size = New System.Drawing.Size(174, 164)
        Me.dgvVerMarcas.TabIndex = 41
        Me.dgvVerMarcas.Visible = False
        '
        'id
        '
        Me.id.HeaderText = "id"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.id.Visible = False
        '
        'nombre
        '
        Me.nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.nombre.HeaderText = "marca"
        Me.nombre.Name = "nombre"
        Me.nombre.ReadOnly = True
        Me.nombre.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'editar
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(86, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.editar.DefaultCellStyle = DataGridViewCellStyle1
        Me.editar.HeaderText = "editar"
        Me.editar.Name = "editar"
        Me.editar.ReadOnly = True
        Me.editar.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.editar.Text = "editar"
        Me.editar.UseColumnTextForButtonValue = True
        Me.editar.Width = 60
        '
        'eliminar
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(86, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        Me.eliminar.DefaultCellStyle = DataGridViewCellStyle2
        Me.eliminar.HeaderText = "eliminar"
        Me.eliminar.Name = "eliminar"
        Me.eliminar.ReadOnly = True
        Me.eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.eliminar.Text = "eliminar"
        Me.eliminar.UseColumnTextForButtonValue = True
        Me.eliminar.Width = 70
        '
        'edit
        '
        Me.edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.edit.HeaderText = ""
        Me.edit.Name = "edit"
        Me.edit.ReadOnly = True
        Me.edit.Visible = False
        Me.edit.Width = 5
        '
        'delet
        '
        Me.delet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.delet.HeaderText = ""
        Me.delet.Name = "delet"
        Me.delet.ReadOnly = True
        Me.delet.Visible = False
        Me.delet.Width = 5
        '
        'btnAgregarMarca
        '
        Me.btnAgregarMarca.BackColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.btnAgregarMarca.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarMarca.Location = New System.Drawing.Point(231, 179)
        Me.btnAgregarMarca.Name = "btnAgregarMarca"
        Me.btnAgregarMarca.Size = New System.Drawing.Size(135, 40)
        Me.btnAgregarMarca.TabIndex = 5
        Me.btnAgregarMarca.Text = "Agregar Marca"
        Me.btnAgregarMarca.UseVisualStyleBackColor = False
        '
        'btnVerMarcas
        '
        Me.btnVerMarcas.BackColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.btnVerMarcas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVerMarcas.Location = New System.Drawing.Point(33, 179)
        Me.btnVerMarcas.Name = "btnVerMarcas"
        Me.btnVerMarcas.Size = New System.Drawing.Size(135, 40)
        Me.btnVerMarcas.TabIndex = 4
        Me.btnVerMarcas.Text = "Ver Marcas"
        Me.btnVerMarcas.UseVisualStyleBackColor = False
        '
        'txtDescripcion
        '
        Me.txtDescripcion.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.txtDescripcion.ForeColor = System.Drawing.Color.White
        Me.txtDescripcion.Location = New System.Drawing.Point(15, 118)
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(369, 34)
        Me.txtDescripcion.TabIndex = 3
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.txtNombre.ForeColor = System.Drawing.Color.White
        Me.txtNombre.Location = New System.Drawing.Point(17, 41)
        Me.txtNombre.Multiline = True
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(367, 33)
        Me.txtNombre.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 14.0!)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(13, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 23)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Descripcion"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 14.0!)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(15, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 23)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nombre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 14.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(96, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 22)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Agregar Marca"
        '
        'pbMarca
        '
        Me.pbMarca.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.pbMarca.ForeColor = System.Drawing.SystemColors.Control
        Me.pbMarca.IconChar = FontAwesome.Sharp.IconChar.Image
        Me.pbMarca.IconColor = System.Drawing.SystemColors.Control
        Me.pbMarca.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.pbMarca.IconSize = 162
        Me.pbMarca.Location = New System.Drawing.Point(75, 98)
        Me.pbMarca.Margin = New System.Windows.Forms.Padding(2)
        Me.pbMarca.Name = "pbMarca"
        Me.pbMarca.Size = New System.Drawing.Size(164, 162)
        Me.pbMarca.TabIndex = 34
        Me.pbMarca.TabStop = False
        '
        'btnCancelUpload
        '
        Me.btnCancelUpload.BackColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.btnCancelUpload.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.btnCancelUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelUpload.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.btnCancelUpload.IconChar = FontAwesome.Sharp.IconChar.Xmark
        Me.btnCancelUpload.IconColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.btnCancelUpload.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnCancelUpload.IconSize = 35
        Me.btnCancelUpload.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelUpload.Location = New System.Drawing.Point(66, 280)
        Me.btnCancelUpload.Name = "btnCancelUpload"
        Me.btnCancelUpload.Size = New System.Drawing.Size(91, 44)
        Me.btnCancelUpload.TabIndex = 39
        Me.btnCancelUpload.Text = "       Cancel"
        Me.btnCancelUpload.UseVisualStyleBackColor = False
        '
        'btnUpload
        '
        Me.btnUpload.BackColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.btnUpload.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.btnUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpload.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.btnUpload.IconChar = FontAwesome.Sharp.IconChar.Upload
        Me.btnUpload.IconColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.btnUpload.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnUpload.IconSize = 35
        Me.btnUpload.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUpload.Location = New System.Drawing.Point(163, 280)
        Me.btnUpload.Name = "btnUpload"
        Me.btnUpload.Size = New System.Drawing.Size(91, 44)
        Me.btnUpload.TabIndex = 40
        Me.btnUpload.Text = "      Upload"
        Me.btnUpload.UseVisualStyleBackColor = False
        '
        'frmAgregarMarca
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(919, 455)
        Me.Controls.Add(Me.btnUpload)
        Me.Controls.Add(Me.btnCancelUpload)
        Me.Controls.Add(Me.pbMarca)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmAgregarMarca"
        Me.Text = "frmAgregarMarca"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvVerMarcas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbMarca, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnVerMarcas As Button
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents pbMarca As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents btnCancelUpload As FontAwesome.Sharp.IconButton
    Friend WithEvents btnUpload As FontAwesome.Sharp.IconButton
    Friend WithEvents btnAgregarMarca As Button
    Friend WithEvents dgvVerMarcas As DataGridView
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents nombre As DataGridViewTextBoxColumn
    Friend WithEvents editar As DataGridViewButtonColumn
    Friend WithEvents eliminar As DataGridViewButtonColumn
    Friend WithEvents edit As DataGridViewImageColumn
    Friend WithEvents delet As DataGridViewImageColumn
    Friend WithEvents btnActualizarMarca As Button
End Class

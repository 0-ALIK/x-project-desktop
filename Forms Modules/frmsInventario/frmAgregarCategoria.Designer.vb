<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAgregarCategoria
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCategoria = New System.Windows.Forms.TextBox()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.dgvCategoria = New System.Windows.Forms.DataGridView()
        Me.id_categoria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Eliminar = New System.Windows.Forms.DataGridViewButtonColumn()
        CType(Me.dgvCategoria, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(18, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(227, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Agregar Categoria"
        '
        'txtCategoria
        '
        Me.txtCategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCategoria.Location = New System.Drawing.Point(23, 70)
        Me.txtCategoria.Name = "txtCategoria"
        Me.txtCategoria.Size = New System.Drawing.Size(259, 29)
        Me.txtCategoria.TabIndex = 1
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.Location = New System.Drawing.Point(302, 68)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(91, 33)
        Me.btnAgregar.TabIndex = 2
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'dgvCategoria
        '
        Me.dgvCategoria.AllowUserToAddRows = False
        Me.dgvCategoria.AllowUserToDeleteRows = False
        Me.dgvCategoria.AllowUserToResizeColumns = False
        Me.dgvCategoria.AllowUserToResizeRows = False
        Me.dgvCategoria.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvCategoria.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvCategoria.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgvCategoria.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.dgvCategoria.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCategoria.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvCategoria.ColumnHeadersVisible = False
        Me.dgvCategoria.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_categoria, Me.Nombre, Me.Eliminar})
        Me.dgvCategoria.EnableHeadersVisualStyles = False
        Me.dgvCategoria.GridColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.dgvCategoria.Location = New System.Drawing.Point(23, 121)
        Me.dgvCategoria.Name = "dgvCategoria"
        Me.dgvCategoria.ReadOnly = True
        Me.dgvCategoria.RowHeadersVisible = False
        Me.dgvCategoria.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(47, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(47, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        Me.dgvCategoria.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvCategoria.Size = New System.Drawing.Size(370, 296)
        Me.dgvCategoria.TabIndex = 3
        '
        'id_categoria
        '
        Me.id_categoria.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.id_categoria.HeaderText = "id_categoria"
        Me.id_categoria.Name = "id_categoria"
        Me.id_categoria.ReadOnly = True
        Me.id_categoria.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.id_categoria.Visible = False
        '
        'Nombre
        '
        Me.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Nombre.FillWeight = 187.4488!
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        Me.Nombre.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'Eliminar
        '
        Me.Eliminar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Eliminar.FillWeight = 82.09435!
        Me.Eliminar.HeaderText = "Eliminar"
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.ReadOnly = True
        Me.Eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Eliminar.Text = "Eliminar"
        Me.Eliminar.UseColumnTextForButtonValue = True
        '
        'frmAgregarCategoria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(416, 450)
        Me.Controls.Add(Me.dgvCategoria)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.txtCategoria)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmAgregarCategoria"
        CType(Me.dgvCategoria, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtCategoria As TextBox
    Friend WithEvents btnAgregar As Button
    Friend WithEvents dgvCategoria As DataGridView
    Friend WithEvents id_categoria As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Eliminar As DataGridViewButtonColumn
End Class

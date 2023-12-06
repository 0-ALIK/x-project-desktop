<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmTickets
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvTickets = New System.Windows.Forms.DataGridView()
        Me.cboFiltrarEstado = New System.Windows.Forms.ComboBox()
        Me.btnFiltrar = New FontAwesome.Sharp.IconButton()
        Me.btnLimpiarFiltro = New FontAwesome.Sharp.IconButton()
        Me.ID_ticket = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Asunto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Prioridad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Accion = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Eliminar = New System.Windows.Forms.DataGridViewButtonColumn()
        CType(Me.dgvTickets, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(60, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tickets"
        '
        'dgvTickets
        '
        Me.dgvTickets.AllowUserToAddRows = False
        Me.dgvTickets.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvTickets.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgvTickets.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.dgvTickets.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvTickets.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvTickets.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(71, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvTickets.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvTickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTickets.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID_ticket, Me.Nombre, Me.Asunto, Me.Prioridad, Me.Estado, Me.Fecha, Me.Accion, Me.Eliminar})
        Me.dgvTickets.EnableHeadersVisualStyles = False
        Me.dgvTickets.GridColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.dgvTickets.Location = New System.Drawing.Point(16, 110)
        Me.dgvTickets.Name = "dgvTickets"
        Me.dgvTickets.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(33, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(44, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvTickets.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(33, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(44, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        Me.dgvTickets.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvTickets.Size = New System.Drawing.Size(1160, 499)
        Me.dgvTickets.TabIndex = 1
        '
        'cboFiltrarEstado
        '
        Me.cboFiltrarEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFiltrarEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboFiltrarEstado.FormattingEnabled = True
        Me.cboFiltrarEstado.Location = New System.Drawing.Point(443, 45)
        Me.cboFiltrarEstado.Name = "cboFiltrarEstado"
        Me.cboFiltrarEstado.Size = New System.Drawing.Size(154, 28)
        Me.cboFiltrarEstado.TabIndex = 2
        '
        'btnFiltrar
        '
        Me.btnFiltrar.IconChar = FontAwesome.Sharp.IconChar.Filter
        Me.btnFiltrar.IconColor = System.Drawing.Color.Black
        Me.btnFiltrar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnFiltrar.Location = New System.Drawing.Point(620, 40)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Size = New System.Drawing.Size(46, 31)
        Me.btnFiltrar.TabIndex = 4
        Me.btnFiltrar.UseVisualStyleBackColor = True
        '
        'btnLimpiarFiltro
        '
        Me.btnLimpiarFiltro.IconChar = FontAwesome.Sharp.IconChar.FilterCircleXmark
        Me.btnLimpiarFiltro.IconColor = System.Drawing.Color.Black
        Me.btnLimpiarFiltro.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnLimpiarFiltro.Location = New System.Drawing.Point(672, 40)
        Me.btnLimpiarFiltro.Name = "btnLimpiarFiltro"
        Me.btnLimpiarFiltro.Size = New System.Drawing.Size(49, 31)
        Me.btnLimpiarFiltro.TabIndex = 5
        Me.btnLimpiarFiltro.UseVisualStyleBackColor = True
        '
        'ID_ticket
        '
        Me.ID_ticket.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ID_ticket.DataPropertyName = "id_tickets"
        Me.ID_ticket.HeaderText = "ID"
        Me.ID_ticket.Name = "ID_ticket"
        Me.ID_ticket.ReadOnly = True
        '
        'Nombre
        '
        Me.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Nombre.DataPropertyName = "nombre"
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        '
        'Asunto
        '
        Me.Asunto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Asunto.DataPropertyName = "categoria"
        Me.Asunto.HeaderText = "Asunto"
        Me.Asunto.Name = "Asunto"
        Me.Asunto.ReadOnly = True
        '
        'Prioridad
        '
        Me.Prioridad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Prioridad.DataPropertyName = "prioridad"
        Me.Prioridad.HeaderText = "Prioridad"
        Me.Prioridad.Name = "Prioridad"
        Me.Prioridad.ReadOnly = True
        '
        'Estado
        '
        Me.Estado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Estado.DataPropertyName = "estado"
        Me.Estado.HeaderText = "Estado"
        Me.Estado.Name = "Estado"
        Me.Estado.ReadOnly = True
        '
        'Fecha
        '
        Me.Fecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Fecha.DataPropertyName = "fecha_cambio_estado"
        Me.Fecha.HeaderText = "Ultima Modificación"
        Me.Fecha.Name = "Fecha"
        Me.Fecha.ReadOnly = True
        '
        'Accion
        '
        Me.Accion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Accion.HeaderText = "Detalles"
        Me.Accion.Name = "Accion"
        Me.Accion.ReadOnly = True
        Me.Accion.Text = "----->"
        Me.Accion.UseColumnTextForButtonValue = True
        '
        'Eliminar
        '
        Me.Eliminar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Eliminar.HeaderText = "Eliminar"
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.ReadOnly = True
        Me.Eliminar.Text = "Eliminar"
        Me.Eliminar.UseColumnTextForButtonValue = True
        '
        'frmTickets
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(879, 450)
        Me.Controls.Add(Me.btnLimpiarFiltro)
        Me.Controls.Add(Me.btnFiltrar)
        Me.Controls.Add(Me.cboFiltrarEstado)
        Me.Controls.Add(Me.dgvTickets)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmTickets"
        Me.Text = "Tickets"
        CType(Me.dgvTickets, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents dgvTickets As DataGridView
    Friend WithEvents cboFiltrarEstado As ComboBox
    Friend WithEvents btnFiltrar As FontAwesome.Sharp.IconButton
    Friend WithEvents btnLimpiarFiltro As FontAwesome.Sharp.IconButton
    Friend WithEvents ID_ticket As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Asunto As DataGridViewTextBoxColumn
    Friend WithEvents Prioridad As DataGridViewTextBoxColumn
    Friend WithEvents Estado As DataGridViewTextBoxColumn
    Friend WithEvents Fecha As DataGridViewTextBoxColumn
    Friend WithEvents Accion As DataGridViewButtonColumn
    Friend WithEvents Eliminar As DataGridViewButtonColumn
End Class

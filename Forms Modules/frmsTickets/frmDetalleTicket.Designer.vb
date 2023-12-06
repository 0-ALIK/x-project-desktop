<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDetalleTicket
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDetalleTicket))
        Me.lblTicket = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblNumeroTicket = New System.Windows.Forms.Label()
        Me.lblDetalle = New System.Windows.Forms.Label()
        Me.btnVolver = New FontAwesome.Sharp.IconButton()
        Me.pbEvidencia = New System.Windows.Forms.PictureBox()
        Me.cboCambiarEstado = New System.Windows.Forms.ComboBox()
        Me.btnCambiarEstado = New FontAwesome.Sharp.IconButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblUsuario = New System.Windows.Forms.Label()
        CType(Me.pbEvidencia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTicket
        '
        Me.lblTicket.AutoSize = True
        Me.lblTicket.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTicket.Location = New System.Drawing.Point(875, 165)
        Me.lblTicket.Name = "lblTicket"
        Me.lblTicket.Size = New System.Drawing.Size(0, 20)
        Me.lblTicket.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(272, 165)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(185, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Descripción del Ticket"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(272, 64)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Ticket #"
        '
        'lblNumeroTicket
        '
        Me.lblNumeroTicket.AutoSize = True
        Me.lblNumeroTicket.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumeroTicket.ForeColor = System.Drawing.Color.Cyan
        Me.lblNumeroTicket.Location = New System.Drawing.Point(348, 64)
        Me.lblNumeroTicket.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNumeroTicket.Name = "lblNumeroTicket"
        Me.lblNumeroTicket.Size = New System.Drawing.Size(101, 20)
        Me.lblNumeroTicket.TabIndex = 4
        Me.lblNumeroTicket.Text = "# Num Ticket"
        '
        'lblDetalle
        '
        Me.lblDetalle.BackColor = System.Drawing.SystemColors.ControlDark
        Me.lblDetalle.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDetalle.ForeColor = System.Drawing.Color.Black
        Me.lblDetalle.Location = New System.Drawing.Point(251, 207)
        Me.lblDetalle.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDetalle.Name = "lblDetalle"
        Me.lblDetalle.Size = New System.Drawing.Size(357, 307)
        Me.lblDetalle.TabIndex = 7
        Me.lblDetalle.Text = "Lorem Ipsum"
        '
        'btnVolver
        '
        Me.btnVolver.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolver.ForeColor = System.Drawing.Color.Black
        Me.btnVolver.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft
        Me.btnVolver.IconColor = System.Drawing.Color.Black
        Me.btnVolver.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnVolver.IconSize = 22
        Me.btnVolver.Location = New System.Drawing.Point(64, 37)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(83, 31)
        Me.btnVolver.TabIndex = 7
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnVolver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'pbEvidencia
        '
        Me.pbEvidencia.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.pbEvidencia.Image = CType(resources.GetObject("pbEvidencia.Image"), System.Drawing.Image)
        Me.pbEvidencia.Location = New System.Drawing.Point(642, 207)
        Me.pbEvidencia.Name = "pbEvidencia"
        Me.pbEvidencia.Size = New System.Drawing.Size(310, 307)
        Me.pbEvidencia.TabIndex = 8
        Me.pbEvidencia.TabStop = False
        '
        'cboCambiarEstado
        '
        Me.cboCambiarEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCambiarEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCambiarEstado.FormattingEnabled = True
        Me.cboCambiarEstado.Location = New System.Drawing.Point(344, 524)
        Me.cboCambiarEstado.Name = "cboCambiarEstado"
        Me.cboCambiarEstado.Size = New System.Drawing.Size(264, 28)
        Me.cboCambiarEstado.TabIndex = 9
        '
        'btnCambiarEstado
        '
        Me.btnCambiarEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCambiarEstado.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk
        Me.btnCambiarEstado.IconColor = System.Drawing.Color.Black
        Me.btnCambiarEstado.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnCambiarEstado.IconSize = 25
        Me.btnCambiarEstado.Location = New System.Drawing.Point(642, 524)
        Me.btnCambiarEstado.Name = "btnCambiarEstado"
        Me.btnCambiarEstado.Size = New System.Drawing.Size(126, 33)
        Me.btnCambiarEstado.TabIndex = 10
        Me.btnCambiarEstado.Text = "Cambiar Estado"
        Me.btnCambiarEstado.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCambiarEstado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCambiarEstado.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(638, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 20)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Estado Actual:"
        '
        'lblEstado
        '
        Me.lblEstado.AutoSize = True
        Me.lblEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstado.ForeColor = System.Drawing.Color.Cyan
        Me.lblEstado.Location = New System.Drawing.Point(770, 111)
        Me.lblEstado.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(73, 20)
        Me.lblEstado.TabIndex = 12
        Me.lblEstado.Text = "# Estado"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(272, 111)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(163, 20)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Usuario solicitante:"
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuario.ForeColor = System.Drawing.Color.Cyan
        Me.lblUsuario.Location = New System.Drawing.Point(439, 111)
        Me.lblUsuario.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(64, 20)
        Me.lblUsuario.TabIndex = 14
        Me.lblUsuario.Text = "Usuario"
        '
        'frmDetalleTicket
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblUsuario)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblEstado)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnCambiarEstado)
        Me.Controls.Add(Me.cboCambiarEstado)
        Me.Controls.Add(Me.pbEvidencia)
        Me.Controls.Add(Me.lblDetalle)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.lblNumeroTicket)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblTicket)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "frmDetalleTicket"
        Me.Text = "frmDetalleTicket"
        CType(Me.pbEvidencia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTicket As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblNumeroTicket As Label
    Friend WithEvents lblDetalle As Label
    Friend WithEvents btnVolver As FontAwesome.Sharp.IconButton
    Friend WithEvents pbEvidencia As PictureBox
    Friend WithEvents cboCambiarEstado As ComboBox
    Friend WithEvents btnCambiarEstado As FontAwesome.Sharp.IconButton
    Friend WithEvents Label2 As Label
    Friend WithEvents lblEstado As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblUsuario As Label
End Class


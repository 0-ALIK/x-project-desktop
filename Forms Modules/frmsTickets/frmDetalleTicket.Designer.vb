﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        CType(Me.pbEvidencia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTicket
        '
        Me.lblTicket.AutoSize = True
        Me.lblTicket.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTicket.Location = New System.Drawing.Point(649, 46)
        Me.lblTicket.Name = "lblTicket"
        Me.lblTicket.Size = New System.Drawing.Size(0, 20)
        Me.lblTicket.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 46)
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
        Me.Label3.Location = New System.Drawing.Point(549, 46)
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
        Me.lblNumeroTicket.Location = New System.Drawing.Point(625, 46)
        Me.lblNumeroTicket.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNumeroTicket.Name = "lblNumeroTicket"
        Me.lblNumeroTicket.Size = New System.Drawing.Size(101, 20)
        Me.lblNumeroTicket.TabIndex = 4
        Me.lblNumeroTicket.Text = "# Num Ticket"
        '
        'lblDetalle
        '
        Me.lblDetalle.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblDetalle.Location = New System.Drawing.Point(25, 88)
        Me.lblDetalle.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDetalle.Name = "lblDetalle"
        Me.lblDetalle.Size = New System.Drawing.Size(357, 307)
        Me.lblDetalle.TabIndex = 7
        Me.lblDetalle.Text = "Lorem Ipsum"
        '
        'btnVolver
        '
        Me.btnVolver.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolver.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft
        Me.btnVolver.IconColor = System.Drawing.Color.Black
        Me.btnVolver.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnVolver.IconSize = 22
        Me.btnVolver.Location = New System.Drawing.Point(19, 12)
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
        Me.pbEvidencia.Location = New System.Drawing.Point(416, 88)
        Me.pbEvidencia.Name = "pbEvidencia"
        Me.pbEvidencia.Size = New System.Drawing.Size(310, 307)
        Me.pbEvidencia.TabIndex = 8
        Me.pbEvidencia.TabStop = False
        '
        'cboCambiarEstado
        '
        Me.cboCambiarEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCambiarEstado.FormattingEnabled = True
        Me.cboCambiarEstado.Location = New System.Drawing.Point(118, 405)
        Me.cboCambiarEstado.Name = "cboCambiarEstado"
        Me.cboCambiarEstado.Size = New System.Drawing.Size(264, 21)
        Me.cboCambiarEstado.TabIndex = 9
        '
        'btnCambiarEstado
        '
        Me.btnCambiarEstado.IconChar = FontAwesome.Sharp.IconChar.None
        Me.btnCambiarEstado.IconColor = System.Drawing.Color.Black
        Me.btnCambiarEstado.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnCambiarEstado.Location = New System.Drawing.Point(416, 405)
        Me.btnCambiarEstado.Name = "btnCambiarEstado"
        Me.btnCambiarEstado.Size = New System.Drawing.Size(94, 23)
        Me.btnCambiarEstado.TabIndex = 10
        Me.btnCambiarEstado.Text = "Cambiar Estado"
        Me.btnCambiarEstado.UseVisualStyleBackColor = True
        '
        'frmDetalleTicket
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnCambiarEstado)
        Me.Controls.Add(Me.cboCambiarEstado)
        Me.Controls.Add(Me.pbEvidencia)
        Me.Controls.Add(Me.lblDetalle)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.lblNumeroTicket)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblTicket)
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

End Class


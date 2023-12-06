<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenuCliente
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
        Me.gbAyuda = New System.Windows.Forms.GroupBox()
        Me.btnAyudaUsuario = New FontAwesome.Sharp.IconButton()
        Me.gbAyuda.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbAyuda
        '
        Me.gbAyuda.Controls.Add(Me.btnAyudaUsuario)
        Me.gbAyuda.ForeColor = System.Drawing.Color.Black
        Me.gbAyuda.Location = New System.Drawing.Point(27, 32)
        Me.gbAyuda.Name = "gbAyuda"
        Me.gbAyuda.Size = New System.Drawing.Size(746, 387)
        Me.gbAyuda.TabIndex = 6
        Me.gbAyuda.TabStop = False
        '
        'btnAyudaUsuario
        '
        Me.btnAyudaUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAyudaUsuario.IconChar = FontAwesome.Sharp.IconChar.UserAlt
        Me.btnAyudaUsuario.IconColor = System.Drawing.Color.Black
        Me.btnAyudaUsuario.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnAyudaUsuario.IconSize = 90
        Me.btnAyudaUsuario.Location = New System.Drawing.Point(280, 100)
        Me.btnAyudaUsuario.Name = "btnAyudaUsuario"
        Me.btnAyudaUsuario.Size = New System.Drawing.Size(170, 144)
        Me.btnAyudaUsuario.TabIndex = 5
        Me.btnAyudaUsuario.Text = "Usuario"
        Me.btnAyudaUsuario.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAyudaUsuario.UseVisualStyleBackColor = True
        '
        'frmMenuCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.gbAyuda)
        Me.Name = "frmMenuCliente"
        Me.Text = "frmMenuCliente"
        Me.gbAyuda.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbAyuda As GroupBox
    Friend WithEvents btnAyudaUsuario As FontAwesome.Sharp.IconButton
End Class

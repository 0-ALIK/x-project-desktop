<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMenu
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
    Private WithEvents contextMenuStrip1 As New ContextMenuStrip()
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.PanelTitleBar = New System.Windows.Forms.Panel()
        Me.lblFormTitle = New System.Windows.Forms.Label()
        Me.IconCurrentForm = New FontAwesome.Sharp.IconPictureBox()
        Me.btnInventory = New FontAwesome.Sharp.IconButton()
        Me.btnSales = New FontAwesome.Sharp.IconButton()
        Me.btnCustomers = New FontAwesome.Sharp.IconButton()
        Me.btnTickets = New FontAwesome.Sharp.IconButton()
        Me.btnUsers = New FontAwesome.Sharp.IconButton()
        Me.btnHelp = New FontAwesome.Sharp.IconButton()
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.PanelLogo = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PanelContent = New System.Windows.Forms.Panel()
        Me.IconDropDownButton1 = New FontAwesome.Sharp.IconDropDownButton()
        Me.PanelTitleBar.SuspendLayout()
        CType(Me.IconCurrentForm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelMenu.SuspendLayout()
        Me.PanelLogo.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelTitleBar
        '
        Me.PanelTitleBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.PanelTitleBar.Controls.Add(Me.lblFormTitle)
        Me.PanelTitleBar.Controls.Add(Me.IconCurrentForm)
        Me.PanelTitleBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTitleBar.Location = New System.Drawing.Point(220, 0)
        Me.PanelTitleBar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PanelTitleBar.Name = "PanelTitleBar"
        Me.PanelTitleBar.Size = New System.Drawing.Size(953, 75)
        Me.PanelTitleBar.TabIndex = 1
        '
        'lblFormTitle
        '
        Me.lblFormTitle.AutoSize = True
        Me.lblFormTitle.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblFormTitle.Location = New System.Drawing.Point(59, 34)
        Me.lblFormTitle.Name = "lblFormTitle"
        Me.lblFormTitle.Size = New System.Drawing.Size(44, 16)
        Me.lblFormTitle.TabIndex = 1
        Me.lblFormTitle.Text = "Home"
        '
        'IconCurrentForm
        '
        Me.IconCurrentForm.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.IconCurrentForm.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.IconCurrentForm.IconChar = FontAwesome.Sharp.IconChar.HomeLg
        Me.IconCurrentForm.IconColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.IconCurrentForm.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconCurrentForm.Location = New System.Drawing.Point(19, 27)
        Me.IconCurrentForm.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.IconCurrentForm.Name = "IconCurrentForm"
        Me.IconCurrentForm.Size = New System.Drawing.Size(32, 32)
        Me.IconCurrentForm.TabIndex = 0
        Me.IconCurrentForm.TabStop = False
        '
        'btnInventory
        '
        Me.btnInventory.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.btnInventory.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnInventory.FlatAppearance.BorderSize = 0
        Me.btnInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInventory.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnInventory.IconChar = FontAwesome.Sharp.IconChar.Cube
        Me.btnInventory.IconColor = System.Drawing.Color.Gainsboro
        Me.btnInventory.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnInventory.IconSize = 32
        Me.btnInventory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnInventory.Location = New System.Drawing.Point(0, 140)
        Me.btnInventory.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnInventory.Name = "btnInventory"
        Me.btnInventory.Padding = New System.Windows.Forms.Padding(11, 0, 20, 0)
        Me.btnInventory.Size = New System.Drawing.Size(220, 60)
        Me.btnInventory.TabIndex = 2
        Me.btnInventory.Text = "Inventario"
        Me.btnInventory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnInventory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnInventory.UseVisualStyleBackColor = False
        '
        'btnSales
        '
        Me.btnSales.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnSales.FlatAppearance.BorderSize = 0
        Me.btnSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSales.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnSales.IconChar = FontAwesome.Sharp.IconChar.Wallet
        Me.btnSales.IconColor = System.Drawing.Color.Gainsboro
        Me.btnSales.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnSales.IconSize = 32
        Me.btnSales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSales.Location = New System.Drawing.Point(0, 200)
        Me.btnSales.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSales.Name = "btnSales"
        Me.btnSales.Padding = New System.Windows.Forms.Padding(11, 0, 20, 0)
        Me.btnSales.Size = New System.Drawing.Size(220, 60)
        Me.btnSales.TabIndex = 3
        Me.btnSales.Text = "Ventas"
        Me.btnSales.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSales.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSales.UseVisualStyleBackColor = True
        '
        'btnCustomers
        '
        Me.btnCustomers.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCustomers.FlatAppearance.BorderSize = 0
        Me.btnCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCustomers.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnCustomers.IconChar = FontAwesome.Sharp.IconChar.Users
        Me.btnCustomers.IconColor = System.Drawing.Color.Gainsboro
        Me.btnCustomers.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnCustomers.IconSize = 32
        Me.btnCustomers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCustomers.Location = New System.Drawing.Point(0, 260)
        Me.btnCustomers.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCustomers.Name = "btnCustomers"
        Me.btnCustomers.Padding = New System.Windows.Forms.Padding(11, 0, 20, 0)
        Me.btnCustomers.Size = New System.Drawing.Size(220, 60)
        Me.btnCustomers.TabIndex = 4
        Me.btnCustomers.Text = "Clientes"
        Me.btnCustomers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCustomers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCustomers.UseVisualStyleBackColor = True
        '
        'btnTickets
        '
        Me.btnTickets.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnTickets.FlatAppearance.BorderSize = 0
        Me.btnTickets.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTickets.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnTickets.IconChar = FontAwesome.Sharp.IconChar.Ticket
        Me.btnTickets.IconColor = System.Drawing.Color.Gainsboro
        Me.btnTickets.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnTickets.IconSize = 32
        Me.btnTickets.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTickets.Location = New System.Drawing.Point(0, 320)
        Me.btnTickets.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnTickets.Name = "btnTickets"
        Me.btnTickets.Padding = New System.Windows.Forms.Padding(11, 0, 20, 0)
        Me.btnTickets.Size = New System.Drawing.Size(220, 60)
        Me.btnTickets.TabIndex = 5
        Me.btnTickets.Text = "Tickets"
        Me.btnTickets.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTickets.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnTickets.UseVisualStyleBackColor = True
        '
        'btnUsers
        '
        Me.btnUsers.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnUsers.FlatAppearance.BorderSize = 0
        Me.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUsers.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnUsers.IconChar = FontAwesome.Sharp.IconChar.UserEdit
        Me.btnUsers.IconColor = System.Drawing.Color.Gainsboro
        Me.btnUsers.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnUsers.IconSize = 32
        Me.btnUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUsers.Location = New System.Drawing.Point(0, 380)
        Me.btnUsers.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnUsers.Name = "btnUsers"
        Me.btnUsers.Padding = New System.Windows.Forms.Padding(11, 0, 20, 0)
        Me.btnUsers.Size = New System.Drawing.Size(220, 60)
        Me.btnUsers.TabIndex = 8
        Me.btnUsers.Text = "Usuarios"
        Me.btnUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUsers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnUsers.UseVisualStyleBackColor = True
        '
        'btnHelp
        '
        Me.btnHelp.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnHelp.FlatAppearance.BorderSize = 0
        Me.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHelp.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnHelp.IconChar = FontAwesome.Sharp.IconChar.QuestionCircle
        Me.btnHelp.IconColor = System.Drawing.Color.Gainsboro
        Me.btnHelp.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnHelp.IconSize = 32
        Me.btnHelp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHelp.Location = New System.Drawing.Point(0, 643)
        Me.btnHelp.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Padding = New System.Windows.Forms.Padding(11, 0, 20, 0)
        Me.btnHelp.Size = New System.Drawing.Size(220, 60)
        Me.btnHelp.TabIndex = 9
        Me.btnHelp.Text = "Ayuda"
        Me.btnHelp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHelp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnHelp.UseVisualStyleBackColor = True
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.PanelMenu.Controls.Add(Me.IconButton1)
        Me.PanelMenu.Controls.Add(Me.btnHelp)
        Me.PanelMenu.Controls.Add(Me.btnUsers)
        Me.PanelMenu.Controls.Add(Me.btnTickets)
        Me.PanelMenu.Controls.Add(Me.btnCustomers)
        Me.PanelMenu.Controls.Add(Me.btnSales)
        Me.PanelMenu.Controls.Add(Me.btnInventory)
        Me.PanelMenu.Controls.Add(Me.PanelLogo)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.Location = New System.Drawing.Point(0, 0)
        Me.PanelMenu.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(220, 703)
        Me.PanelMenu.TabIndex = 0
        '
        'IconButton1
        '
        Me.IconButton1.Dock = System.Windows.Forms.DockStyle.Top
        Me.IconButton1.FlatAppearance.BorderSize = 0
        Me.IconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton1.ForeColor = System.Drawing.Color.Gainsboro
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.LineChart
        Me.IconButton1.IconColor = System.Drawing.Color.Gainsboro
        Me.IconButton1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton1.IconSize = 32
        Me.IconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton1.Location = New System.Drawing.Point(0, 440)
        Me.IconButton1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Padding = New System.Windows.Forms.Padding(11, 0, 20, 0)
        Me.IconButton1.Size = New System.Drawing.Size(220, 60)
        Me.IconButton1.TabIndex = 10
        Me.IconButton1.Text = "Analíticas y Reportes"
        Me.IconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton1.UseVisualStyleBackColor = True
        '
        'PanelLogo
        '
        Me.PanelLogo.Controls.Add(Me.PictureBox1)
        Me.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelLogo.Location = New System.Drawing.Point(0, 0)
        Me.PanelLogo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PanelLogo.Name = "PanelLogo"
        Me.PanelLogo.Size = New System.Drawing.Size(220, 140)
        Me.PanelLogo.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.x_project_desktop.My.Resources.Resources.logo
        Me.PictureBox1.Location = New System.Drawing.Point(13, 14)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(195, 119)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PanelContent
        '
        Me.PanelContent.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PanelContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContent.Location = New System.Drawing.Point(220, 75)
        Me.PanelContent.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PanelContent.Name = "PanelContent"
        Me.PanelContent.Size = New System.Drawing.Size(953, 628)
        Me.PanelContent.TabIndex = 3
        '
        'IconDropDownButton1
        '
        Me.IconDropDownButton1.IconChar = FontAwesome.Sharp.IconChar.None
        Me.IconDropDownButton1.IconColor = System.Drawing.Color.Black
        Me.IconDropDownButton1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconDropDownButton1.Name = "IconDropDownButton1"
        Me.IconDropDownButton1.Size = New System.Drawing.Size(23, 23)
        Me.IconDropDownButton1.Text = "IconDropDownButton1"
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1173, 703)
        Me.Controls.Add(Me.PanelContent)
        Me.Controls.Add(Me.PanelTitleBar)
        Me.Controls.Add(Me.PanelMenu)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frmMenu"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        Me.PanelTitleBar.ResumeLayout(False)
        Me.PanelTitleBar.PerformLayout()
        CType(Me.IconCurrentForm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelMenu.ResumeLayout(False)
        Me.PanelLogo.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelTitleBar As Panel
    Friend WithEvents IconCurrentForm As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents lblFormTitle As Label
    Friend WithEvents btnInventory As FontAwesome.Sharp.IconButton
    Friend WithEvents btnSales As FontAwesome.Sharp.IconButton
    Friend WithEvents btnCustomers As FontAwesome.Sharp.IconButton
    Friend WithEvents btnTickets As FontAwesome.Sharp.IconButton
    Friend WithEvents btnUsers As FontAwesome.Sharp.IconButton
    Friend WithEvents btnHelp As FontAwesome.Sharp.IconButton
    Friend WithEvents PanelMenu As Panel
    Friend WithEvents PanelLogo As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PanelContent As Panel
    Friend WithEvents IconDropDownButton1 As FontAwesome.Sharp.IconDropDownButton

    Private Sub Opcion1_Click(sender As Object, e As EventArgs)
        ' Lógica para la Opción 1
    End Sub

    Private Sub Opcion2_Click(sender As Object, e As EventArgs)
        ' Lógica para la Opción 2
    End Sub

    Private Sub IconPictureBox1_Click(sender As Object, e As EventArgs) Handles IconPictureBox1.Click
        ' Mostrar el menú desplegable cuando se hace clic en el IconPictureBox
        Me.contextMenuStrip1.Show(Me.IconPictureBox1, New Point(0, Me.IconPictureBox1.Height))
    End Sub

    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
End Class
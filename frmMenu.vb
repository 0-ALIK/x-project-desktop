Imports System.Windows.Documents
Imports FontAwesome.Sharp
Public Class frmMenu

    Private leftBorderBtn As Panel

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Me.FormBorderStyle = FormBorderStyle.Sizable
        Me.Bounds = Screen.PrimaryScreen.Bounds

        ActivateButton(btnInventory, RGBColors.Purple, "Inventario", leftBorderBtn, IconCurrentForm, lblFormTitle)
        SetPanel(New frmInventario(), PanelContent)

    End Sub

    Public Sub New()

        InitializeComponent()
        leftBorderBtn = New Panel()
        leftBorderBtn.Size = New Size(7, 60)
        PanelMenu.Controls.Add(leftBorderBtn)
        Me.BackColor = Color.Black
        Me.IsMdiContainer = True

    End Sub

    Private Sub btnInventory_Click(sender As Object, e As EventArgs) Handles btnInventory.Click

        ActivateButton(sender, RGBColors.Pink, "Inventario", leftBorderBtn, IconCurrentForm, lblFormTitle)
        SetPanel(New frmInventario(), PanelContent)

    End Sub

    Private Sub btnSales_Click(sender As Object, e As EventArgs) Handles btnSales.Click

        ActivateButton(sender, RGBColors.PalePink, "Ventas", leftBorderBtn, IconCurrentForm, lblFormTitle)
        SetPanel(New frmVentas(), PanelContent)

    End Sub

    Private Sub btnCustomers_Click(sender As Object, e As EventArgs) Handles btnCustomers.Click

        ActivateButton(sender, RGBColors.ShadeBlue, "Clientes", leftBorderBtn, IconCurrentForm, lblFormTitle)
        Dim frmClientes As New frmClientes(New clientesDAO(myConnectionDB))
        SetPanel(frmClientes, PanelContent)

    End Sub

    Private Sub btnTickets_Click(sender As Object, e As EventArgs) Handles btnTickets.Click

        ActivateButton(sender, RGBColors.ShadePink, "Tickets", leftBorderBtn, IconCurrentForm, lblFormTitle)
        SetPanel(New frmHomeTicket(), PanelContent)
    End Sub

    Private Sub btnUsers_Click(sender As Object, e As EventArgs) Handles btnUsers.Click

        ActivateButton(sender, RGBColors.Ambar, "Usuarios", leftBorderBtn, IconCurrentForm, lblFormTitle)
        Dim cedula As String = "123456789"
        Dim frmUsuarios As New frmUsuarios(cedula, New clientesDAO(myConnectionDB))
        SetPanel(frmUsuarios, PanelContent)

    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        ActivateButton(sender, RGBColors.LimeGreen, "Ayuda", leftBorderBtn, IconCurrentForm, lblFormTitle)
        SetPanel(New frmAyuda(), PanelContent)
    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        ActivateButton(sender, RGBColors.RedAlert, "Analiticas y Reportes", leftBorderBtn, IconCurrentForm, lblFormTitle)
        SetPanel(New frmAnalitica(), PanelContent)
    End Sub
End Class
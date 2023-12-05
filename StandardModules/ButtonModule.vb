Imports System.Windows.Documents
Imports FontAwesome.Sharp

Module ButtonModule

    Private currentBtn As IconButton

    Sub ActivateButton(senderBtn As Object, customColor As Color, formTitle As String, leftb As Panel, IconCurrentForm As IconPictureBox, lblFormTitle As Label)
        If senderBtn IsNot Nothing Then
            DisableButton()

            currentBtn = CType(senderBtn, IconButton)
            currentBtn.BackColor = Color.FromArgb(43, 52, 65)
            currentBtn.ForeColor = customColor
            currentBtn.IconColor = customColor
            currentBtn.TextAlign = ContentAlignment.MiddleCenter
            currentBtn.ImageAlign = ContentAlignment.MiddleRight
            currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage

            leftb.BackColor = customColor
            leftb.Location = New Point(0, currentBtn.Location.Y)
            leftb.Visible = True
            leftb.BringToFront()

            IconCurrentForm.IconChar = currentBtn.IconChar
            IconCurrentForm.IconColor = customColor
            lblFormTitle.Text = formTitle
        End If
    End Sub

    Private Sub DisableButton()
        If currentBtn IsNot Nothing Then
            currentBtn.BackColor = Color.FromArgb(22, 29, 33)
            currentBtn.ForeColor = Color.Gainsboro
            currentBtn.IconColor = Color.Gainsboro
            currentBtn.TextAlign = ContentAlignment.MiddleLeft
            currentBtn.ImageAlign = ContentAlignment.MiddleLeft
            currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        End If
    End Sub

    Public Sub CustomButton(ByRef button As IconButton, ByVal iconType As IconChar, ByVal buttonColor As String, ByVal buttonCorner As Decimal)
        button.FlatStyle = FlatStyle.Flat
        button.FlatAppearance.BorderSize = 0
        button.BackColor = ColorTranslator.FromHtml(buttonColor)
        button.ForeColor = Color.FromArgb(207, 207, 207)
        button.Cursor = Cursors.Hand

        button.IconChar = iconType
        button.IconColor = Color.FromArgb(207, 207, 207)

        Dim rad As New Drawing2D.GraphicsPath
        rad.StartFigure()
        'buttonCorner determina el valor de la cantidad de bordes del boton en valor decimal

        'Borde superior izquierdo
        rad.AddArc(New Rectangle(0, 0, buttonCorner, buttonCorner), 180, 90)
        rad.AddLine(10, 0, button.Width - 20, 0)

        'Borde superior derecho
        rad.AddArc(New Rectangle(button.Width - buttonCorner, 0, buttonCorner, buttonCorner), -90, 90)
        rad.AddLine(button.Width, 20, button.Width, button.Height - 10)

        'right corner bottom
        rad.AddArc(New Rectangle(button.Width - (buttonCorner + 10), button.Height - (buttonCorner + 10), buttonCorner + 10, buttonCorner + 10), 0, 90)

        'left corner bottom
        rad.AddLine(button.Width - 10, button.Width, 20, button.Height)
        rad.AddArc(New Rectangle(0, button.Height - buttonCorner, buttonCorner, buttonCorner), 90, 90)
        rad.CloseFigure()
        button.Region = New Region(rad)

    End Sub

    Public Sub CustomTextBox(ByRef textbox As TextBox, ByVal buttonColor As String, ByVal buttonCorner As Decimal)

        textbox.BackColor = ColorTranslator.FromHtml(buttonColor)
        textbox.ForeColor = Color.Black
        textbox.Font = New Font("Century Gothic", 12, FontStyle.Regular)
        textbox.BorderStyle = BorderStyle.None

        Dim rad As New Drawing2D.GraphicsPath
        rad.StartFigure()
        'buttonCorner determina el valor de la cantidad de bordes del textbox en valor decimal

        'Borde superior izquierdo
        rad.AddArc(New Rectangle(0, 0, buttonCorner, buttonCorner), 180, 90)
        rad.AddLine(10, 0, textbox.Width - 20, 0)

        'Borde superior derecho
        rad.AddArc(New Rectangle(textbox.Width - buttonCorner, 0, buttonCorner, buttonCorner), -90, 90)
        rad.AddLine(textbox.Width, 20, textbox.Width, textbox.Height - 10)

        'right corner bottom
        rad.AddArc(New Rectangle(textbox.Width - (buttonCorner + 10), textbox.Height - (buttonCorner + 10), buttonCorner + 10, buttonCorner + 10), 0, 90)

        'left corner bottom
        rad.AddLine(textbox.Width - 10, textbox.Width, 20, textbox.Height)
        rad.AddArc(New Rectangle(0, textbox.Height - buttonCorner, buttonCorner, buttonCorner), 90, 90)
        rad.CloseFigure()
        textbox.Region = New Region(rad)

    End Sub
End Module

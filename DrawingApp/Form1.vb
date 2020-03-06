Imports System.Drawing
Imports System.Drawing.Drawing2D

Public Class WordDraw
    Dim xEnd, yEnd As Integer
    Dim Draw As Boolean
    Dim DrawColor As Color = Color.Black
    Dim DrawSize As Byte = 4
    Dim myPen As New Pen(Color.Black, 4)






    Dim bmp As Bitmap

    Private Sub PaintBrush(X As Integer, Y As Integer)
        Using g As Graphics = Graphics.FromImage(pbDraw.Image)
            g.SmoothingMode = SmoothingMode.HighQuality
            g.InterpolationMode = InterpolationMode.HighQualityBicubic
            g.PixelOffsetMode = PixelOffsetMode.HighQuality
            g.DrawLine(myPen, X, Y, xEnd, yEnd)
        End Using

        pbDraw.Refresh()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set initial brush size

        cbSize.SelectedIndex = 2

        ' Populate picturebox image property
        bmp = New Bitmap(pbDraw.Width, pbDraw.Height)

        myPen = New Pen(DrawColor, DrawSize)

        pbDraw.Image = bmp

    End Sub

    Private Sub pbDraw_MouseDown(sender As Object, e As MouseEventArgs) Handles pbDraw.MouseDown
        Draw = True

        'first pixel
        PaintBrush(e.X, e.Y)
        myPen = New Pen(DrawColor, DrawSize)
    End Sub

    Private Sub pbDraw_MouseMove(sender As Object, e As MouseEventArgs) Handles pbDraw.MouseMove
        If Draw Then
            PaintBrush(e.X, e.Y)
        End If
        xEnd = e.X
        yEnd = e.Y

    End Sub

    Private Sub pbDraw_MouseUp(sender As Object, e As MouseEventArgs) Handles pbDraw.MouseUp
        Draw = False
    End Sub

    Private Sub clearBtn_Click(sender As Object, e As EventArgs) Handles clearBtn.Click
        bmp = New Bitmap(pbDraw.Width, pbDraw.Height)

        pbDraw.Image = bmp
    End Sub

    Private Sub cbSize_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbSize.SelectedIndexChanged
        DrawSize = cbSize.SelectedItem
    End Sub

    Private Sub pbBlack_Click(sender As Object, e As EventArgs) Handles pbBlack.Click
        unSelectAll()
        pbBlack.BackgroundImage = My.Resources.black_selected
        DrawColor = ColorTranslator.FromHtml("#000000")
    End Sub

    Private Sub pbGray_Click(sender As Object, e As EventArgs) Handles pbGray.Click
        unSelectAll()
        pbGray.BackgroundImage = My.Resources.gray_selected
        DrawColor = ColorTranslator.FromHtml("#818181")
    End Sub

    Private Sub pbBrown_Click(sender As Object, e As EventArgs) Handles pbBrown.Click
        unSelectAll()
        pbBrown.BackgroundImage = My.Resources.brown_selected
        DrawColor = ColorTranslator.FromHtml("#582f10")
    End Sub

    Private Sub pbRed_Click(sender As Object, e As EventArgs) Handles pbRed.Click
        unSelectAll()
        pbRed.BackgroundImage = My.Resources.red_selected
        DrawColor = ColorTranslator.FromHtml("#e71717")
    End Sub
    Private Sub pbPink_Click(sender As Object, e As EventArgs) Handles pbPink.Click
        unSelectAll()
        pbPink.BackgroundImage = My.Resources.pink_selected
        DrawColor = ColorTranslator.FromHtml("#e54c70")
    End Sub
    Private Sub pbOrange_Click(sender As Object, e As EventArgs) Handles pbOrange.Click
        unSelectAll()
        pbOrange.BackgroundImage = My.Resources.orange_selected
        DrawColor = ColorTranslator.FromHtml("#f99e33")
    End Sub
    Private Sub pbPeach_Click(sender As Object, e As EventArgs) Handles pbPeach.Click
        unSelectAll()
        pbPeach.BackgroundImage = My.Resources.peach_selected
        DrawColor = ColorTranslator.FromHtml("#f0c58e")
    End Sub
    Private Sub pbYellow_Click(sender As Object, e As EventArgs) Handles pbYellow.Click
        unSelectAll()
        pbYellow.BackgroundImage = My.Resources.yellow_selected
        DrawColor = ColorTranslator.FromHtml("#fffd5a")
    End Sub
    Private Sub pbGreen_Click(sender As Object, e As EventArgs) Handles pbGreen.Click
        unSelectAll()
        pbGreen.BackgroundImage = My.Resources.green_selected
        DrawColor = ColorTranslator.FromHtml("#56e031")
    End Sub
    Private Sub pbDgreen_Click(sender As Object, e As EventArgs) Handles pbDgreen.Click
        unSelectAll()
        pbDgreen.BackgroundImage = My.Resources.dgreen_selected
        DrawColor = ColorTranslator.FromHtml("#24820a")
    End Sub
    Private Sub pbBlue_Click(sender As Object, e As EventArgs) Handles pbBlue.Click
        unSelectAll()
        pbBlue.BackgroundImage = My.Resources.blue_selected
        DrawColor = ColorTranslator.FromHtml("#3190e0")
    End Sub
    Private Sub pbDblue_Click(sender As Object, e As EventArgs) Handles pbDblue.Click
        unSelectAll()
        pbDblue.BackgroundImage = My.Resources.dblue_selected
        DrawColor = ColorTranslator.FromHtml("#252864")
    End Sub

    Private Sub pbViolet_Click(sender As Object, e As EventArgs) Handles pbViolet.Click
        unSelectAll()
        pbViolet.BackgroundImage = My.Resources.violet_selected
        DrawColor = ColorTranslator.FromHtml("#992af7")
    End Sub
    Private Sub pbDviolet_Click(sender As Object, e As EventArgs) Handles pbDviolet.Click
        unSelectAll()
        pbDviolet.BackgroundImage = My.Resources.dviolet_selected
        DrawColor = ColorTranslator.FromHtml("#451165")
    End Sub
    Private Sub pbEraser_Click(sender As Object, e As EventArgs) Handles pbEraser.Click
        unSelectAll()
        pbEraser.BackgroundImage = My.Resources.eraser_selected
        DrawColor = ColorTranslator.FromHtml("#ffffff")
    End Sub

    Private Sub unSelectAll()
        pbBlack.BackgroundImage = My.Resources.black_unselected
        pbGray.BackgroundImage = My.Resources.gray_unselected
        pbBrown.BackgroundImage = My.Resources.brown_unselected
        pbRed.BackgroundImage = My.Resources.red_unselected
        pbPink.BackgroundImage = My.Resources.pink_unselected
        pbOrange.BackgroundImage = My.Resources.orange_unselected
        pbPeach.BackgroundImage = My.Resources.peach_unselected
        pbYellow.BackgroundImage = My.Resources.yellow_unselected
        pbGreen.BackgroundImage = My.Resources.green_selected1
        pbDgreen.BackgroundImage = My.Resources.dgreen_selected1
        pbBlue.BackgroundImage = My.Resources.blue_unselected
        pbDblue.BackgroundImage = My.Resources.dblue_unselected
        pbViolet.BackgroundImage = My.Resources.violet_unselected
        pbDviolet.BackgroundImage = My.Resources.dviolet_unselected
        pbEraser.BackgroundImage = My.Resources.eraser_unselcted
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        drawingControls.Visible = False
        guesserInput.Visible = True
    End Sub

    Private Sub meDraw_Click(sender As Object, e As EventArgs) Handles meDraw.Click
        drawingControls.Visible = True
        guesserInput.Visible = False
    End Sub

    Private Sub SUBMIT_Click(sender As Object, e As EventArgs) Handles SUBMIT.Click

    End Sub


    Private Sub saveBtn_Click(sender As Object, e As EventArgs)
        pbDraw.DrawToBitmap(bmp, New Rectangle(0, 0, pbDraw.Width, pbDraw.Height))
        bmp.Save("Test.png", Imaging.ImageFormat.Png)

        bmp = New Bitmap(pbDraw.Width, pbDraw.Height)
    End Sub
End Class

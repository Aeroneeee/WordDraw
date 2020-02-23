Imports System.Drawing
Imports System.Drawing.Drawing2D

Public Class Form1
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

    Private Sub colorBtn_Click(sender As Object, e As EventArgs) Handles colorBtn.Click
        If ColorDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            DrawColor = ColorDialog1.Color
        End If
    End Sub

    Private Sub saveBtn_Click(sender As Object, e As EventArgs) Handles saveBtn.Click
        pbDraw.DrawToBitmap(bmp, New Rectangle(0, 0, pbDraw.Width, pbDraw.Height))
        bmp.Save("Test.png", Imaging.ImageFormat.Png)

        bmp = New Bitmap(pbDraw.Width, pbDraw.Height)
    End Sub
End Class

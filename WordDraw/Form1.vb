Imports System.Drawing

Public Class Form1
    Dim Draw As Boolean
    Dim DrawColor As Color = Color.Black
    Dim DrawSize As Byte = 6

    Dim bmp As Bitmap

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set initial brush size

        cbSize.SelectedIndex = 2

        ' Populate picturebox image property
        bmp = New Bitmap(pbDraw.Width, pbDraw.Height)

        pbDraw.Image = bmp

    End Sub

    Private Sub PaintBrush(X As Integer, Y As Integer)
        Using g As Graphics = Graphics.FromImage(pbDraw.Image)
            g.FillEllipse(New SolidBrush(DrawColor), New Rectangle(X, Y, DrawSize, DrawSize))
        End Using

        pbDraw.Refresh()
    End Sub

    Private Sub pbDraw_MouseDown(sender As Object, e As MouseEventArgs) Handles pbDraw.MouseDown
        Draw = True

        'first pixel
        PaintBrush(e.X, e.Y)
    End Sub

    Private Sub pbDraw_MouseMove(sender As Object, e As MouseEventArgs) Handles pbDraw.MouseMove
        If Draw Then
            PaintBrush(e.X, e.Y)
        End If
    End Sub

    Private Sub pbDraw_MouseUp(sender As Object, e As MouseEventArgs) Handles pbDraw.MouseUp
        Draw = False
    End Sub
End Class

Public Class GraphGenerator

    Public Shared Function PlotPoints(ByVal pnts As List(Of Tuple(Of Double, Double)), ByVal axColor As Color, ByVal pntColor As Color) As Bitmap
        Dim HalfSize As Integer = 500
        Dim HalfSizePlusOne As Integer = HalfSize + 1
        Dim FullSize As Integer = HalfSize + HalfSizePlusOne
        Dim bmp As New Bitmap(FullSize, FullSize)
        Dim g As Graphics = Graphics.FromImage(bmp)

        g.FillRectangle(Brushes.White, 0, 0, bmp.Width, bmp.Height)

        DrawAxes(bmp, axColor, HalfSizePlusOne, HalfSizePlusOne)

        For Each t As Tuple(Of Double, Double) In pnts
            Dim x As Integer = HalfSizePlusOne + HalfSize * t.Item1
            Dim y As Integer = HalfSizePlusOne + HalfSize * t.Item2
            If (x >= 0 AndAlso y >= 0) AndAlso (x <= bmp.Width - 1 AndAlso y <= bmp.Width - 1) Then
                bmp.SetPixel(x, y, pntColor)
            End If
        Next

        Return bmp
    End Function

    Public Shared Function DrawWalk(ByVal bmp As Bitmap, ByVal pnts As List(Of Tuple(Of Double, Double)), ByVal startColor As Color, ByVal finishColor As Color, ByVal lineColor As Color, ByVal radius As Double) As Bitmap
        Dim w As Integer = bmp.Width
        Dim h As Integer = bmp.Height
        Dim g As Graphics = Graphics.FromImage(bmp)
        Dim p As New Pen(lineColor)
        p.Width = 1

        If pnts.Count > 1 Then
            For i As Integer = 0 To pnts.Count - 2
                Dim FirstPoint As Tuple(Of Double, Double) = pnts(i)
                Dim SecondPoint As Tuple(Of Double, Double) = pnts(i + 1)

                g.DrawLine(p, CInt(500 + 501 * FirstPoint.Item1), CInt(500 + 501 * FirstPoint.Item2), CInt(500 + 501 * SecondPoint.Item1), CInt(500 + 501 * SecondPoint.Item2))
            Next
        End If

        ' Draw the start point
        Dim start As Tuple(Of Double, Double) = pnts.First
        Dim x As Integer = CInt(500 + 501 * start.Item1)
        Dim y As Integer = CInt(500 + 501 * start.Item2)

        For i As Integer = x - 3 To x + 3
            For j As Integer = y - 3 To y + 3
                bmp.SetPixel(i, j, startColor)
            Next
        Next

        'Draw the finish point
        Dim finish As Tuple(Of Double, Double) = pnts.Last
        x = CInt(500 + 501 * finish.Item1)
        y = CInt(500 + 501 * finish.Item2)
        For i As Integer = x - 3 To x + 3
            For j As Integer = y - 3 To y + 3
                bmp.SetPixel(i, j, finishColor)
            Next
        Next

        bmp = DrawCircle(bmp, radius)

        Return bmp
    End Function

    Private Shared Function DrawCircle(ByRef bmp As Bitmap, ByVal radius As Double) As Bitmap
        Dim g As Graphics = Graphics.FromImage(bmp)
        Dim p As New Pen(Brushes.Black)

        g.DrawEllipse(p, CInt(radius * 501 - 500), CInt(radius * 501 - 500), CInt(2 * radius), CInt(2 * radius))

        Return bmp
    End Function

    Private Shared Sub DrawAxes(ByRef bmp As Bitmap, ByVal axColor As Color, ByVal x_center As Integer, ByVal y_center As Integer)
        For y As Integer = 0 To (bmp.Height - 1)
            bmp.SetPixel(x_center, y, axColor)
        Next

        For x As Integer = 0 To (bmp.Width - 1)
            bmp.SetPixel(x, y_center, axColor)
        Next
    End Sub
End Class

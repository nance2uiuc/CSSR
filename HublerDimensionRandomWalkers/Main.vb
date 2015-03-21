Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Threading.Tasks

Public Class Main

    Private _pg As New PointGenerator

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        numDimensions.Value = 2
        numNumberOfPoints.Value = 3000

        If Not IO.Directory.Exists("c:\temp") Then
            IO.Directory.CreateDirectory("C:\Temp")
        End If
    End Sub

    Private Sub btnGeneratePoints_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGeneratePoints.Click
        Dim CustomPoints As New List(Of Tuple(Of Double, Double))

        Cursor = Cursors.WaitCursor
        picWalker.Image = Nothing
        lblElapsedTime.Text = "Elapsed Time:"

        _pg.GeneratePoints(numDimensions.Value, numNumberOfPoints.Value)
        Dim bmp As Bitmap = GraphGenerator.PlotPoints(_pg.Points, Color.LightGray, Color.LimeGreen)
        Dim Points As List(Of Tuple(Of Double, Double)) = _pg.Points

        If chkStartinPointOnRadius.Checked Then
            Dim BaseAngle As Double = (2 * Math.PI) / numNumberOfWalkers.Value

            For i As Integer = 0 To numNumberOfWalkers.Value - 1
                CustomPoints.Add(Tuple.Create(numStartingRadius.Value * Math.Cos(i * BaseAngle), numStartingRadius.Value * Math.Sin(i * BaseAngle)))
            Next
        End If
        ' Save the point plot
        bmp.Save("c:\temp\points.bmp")

        Dim start As DateTime = Now
        For i As Integer = 1 To numNumberOfWalkers.Value
            Dim wkr As New Walker(Points, numStartingRadius.Value, numEpsilonValue.Value, numMaximumSteps.Value, chkSelfAvoidingWalkers.Checked)
            Dim walk As List(Of Tuple(Of Double, Double))
            If chkStartinPointOnRadius.Checked Then
                walk = wkr.StartWalking(CustomPoints(i - 1))
            Else
                walk = wkr.StartWalking()
            End If

            bmp = GraphGenerator.DrawWalk(bmp, walk, Color.Green, Color.Red, Color.Blue, numStartingRadius.Value)

            Dim sw As New IO.StreamWriter(String.Format("C:\Temp\data_walker_{0:00}.txt", i))
            sw.WriteLine(String.Format("Dimension: {0}", _pg.Dimension))
            For j As Integer = 0 To walk.Count - 1
                Dim t As Tuple(Of Double, Double) = walk(j)
                sw.WriteLine(String.Format("{{{0},{1}}},", t.Item1, t.Item2))
            Next

            sw.Close()
        Next
        Dim finish As DateTime = Now

        picWalker.Image = bmp.Clone
        bmp.Save("c:\temp\walk.bmp")


        ' Save the walk data
        bmp.Dispose()

        Dim ts As TimeSpan = finish - start
        lblElapsedTime.Text = String.Format("Elapsed Time: {0:#0.00#} ms", ts.TotalMilliseconds)

        Cursor = Cursors.Default
    End Sub
End Class

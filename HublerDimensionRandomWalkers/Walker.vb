Public Class Walker

    Private _Epsilon As Double = 0
    Private _StartingRadius As Double = 0
    Private _MaximumStep As Integer = 0
    Private _Points As List(Of Tuple(Of Double, Double))
    Private _StartingPoint As Tuple(Of Double, Double)
    Private _WalkerPoints As New List(Of Tuple(Of Double, Double))
    Private _SelfAvoiding As Boolean = False
    Private _CustomStartingPoint As Boolean = False

    Public ReadOnly Property WalkerPoints As List(Of Tuple(Of Double, Double))
        Get
            Return _WalkerPoints
        End Get
    End Property

    Public Sub New(ByRef pnts As List(Of Tuple(Of Double, Double)), ByVal startRadius As Double, ByVal eps As Double, ByVal maxSteps As Integer, ByVal selfAvoiding As Boolean)
        MyBase.New()

        _StartingRadius = startRadius
        _Points = pnts
        _Epsilon = eps
        _MaximumStep = maxSteps
        _SelfAvoiding = selfAvoiding
    End Sub
    Public Function StartWalking(ByVal customStart As Tuple(Of Double, Double)) As List(Of Tuple(Of Double, Double))
        _StartingPoint = customStart
        _CustomStartingPoint = True

        Return StartWalking()
    End Function

    Public Function StartWalking(ByRef pnts As List(Of Tuple(Of Double, Double))) As List(Of Tuple(Of Double, Double))
        _Points = pnts

        Return StartWalking()
    End Function

    Public Function StartWalking() As List(Of Tuple(Of Double, Double))
        'Dim PointsCopy As List(Of Tuple(Of Double, Double)) = New List(Of Tuple(Of Double, Double))(_Points)
        Dim WalkPoints As New List(Of Tuple(Of Double, Double))

        If Not _CustomStartingPoint Then
            _StartingPoint = GetRandomStartPoint(_Points, _StartingRadius)
        End If
        ' Add the starting point to the walk list
        WalkPoints.Add(_StartingPoint)
        'Remove the starting point from the PointsCopy list
        _Points.Remove(_StartingPoint)

        For i As Integer = 0 To (_MaximumStep - 1)
            ' Get all of the points within the epsilon radius of the current point
            Dim pts As List(Of Tuple(Of Double, Double)) = GetPointsWithinRadius(_Points, WalkPoints.Last, _Epsilon).ToList

            ' Get a random point from the list
            Dim pt As Tuple(Of Double, Double) = GetRandomPoint(pts)

            If pt Is Nothing Then
                Exit For
            Else
                'Add the point to the walk list
                WalkPoints.Add(pt)
                If _SelfAvoiding Then
                    'Remove the point from the PointsCopy list
                    _Points.Remove(pt)
                End If
            End If
        Next

        _WalkerPoints = WalkPoints

        Return WalkPoints
    End Function

    Private Shared Function GetPointsWithinRadius(ByRef pnts As List(Of Tuple(Of Double, Double)), ByVal startPoint As Tuple(Of Double, Double), ByVal rad As Double) As IEnumerable(Of Tuple(Of Double, Double))
        Dim pts As IEnumerable(Of Tuple(Of Double, Double)) = pnts.AsParallel.Where(Function(t) Math.Sqrt(Math.Pow(Math.Abs(t.Item1 - startPoint.Item1), 2) + Math.Pow(Math.Abs(t.Item2 - startPoint.Item2), 2)) <= rad)

        Return pts
    End Function

    Private Shared Function GetRandomStartPoint(ByRef pnts As List(Of Tuple(Of Double, Double)), ByVal rad As Double) As Tuple(Of Double, Double)
        ' Get a list of all points within the starting radius from point (0,0)
        Dim pts As IEnumerable(Of Tuple(Of Double, Double)) = GetPointsWithinRadius(pnts, Tuple.Create(CDbl(0), CDbl(0)), rad)

        Return GetRandomPoint(pts)
    End Function

    Private Shared Function GetRandomPoint(ByRef pnts As IEnumerable(Of Tuple(Of Double, Double))) As Tuple(Of Double, Double)
        Dim pntlist As List(Of Tuple(Of Double, Double)) = pnts.ToList
        Dim PointCount As Integer = pntlist.Count

        If PointCount > 0 Then
            Dim rnd As New Random
            Dim rndnumber As Integer = rnd.Next(0, PointCount - 1)
            rnd = Nothing

            Return pntlist(rndnumber)
        Else
            Return Nothing
        End If
    End Function
End Class

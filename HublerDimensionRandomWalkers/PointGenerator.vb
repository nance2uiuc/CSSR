Imports System.Windows.Forms.DataVisualization.Charting

Public Class PointGenerator

#Region " Private Fields "
    Private _Dimension As Double = 1
    Private _PointCount As Integer = 0
    Private _Points As New List(Of Tuple(Of Double, Double))
#End Region

#Region " Public Properties "
    Public ReadOnly Property Dimension As Double
        Get
            Return _Dimension
        End Get
    End Property

    Public ReadOnly Property PointCount As Integer
        Get
            Return _PointCount
        End Get
    End Property

    Public ReadOnly Property Points As List(Of Tuple(Of Double, Double))
        Get
            Return _Points
        End Get
    End Property
#End Region

#Region " Constructors "
    Public Sub New()
        MyBase.New()
    End Sub

    Public Sub New(ByVal dmsn As Double, ByVal pntCount As Integer)
        Me.New()

        GeneratePoints(dmsn, pntCount)
    End Sub
#End Region

#Region " Public Methods "
    Public Sub GeneratePoints(ByVal dmsn As Double, ByVal pntCount As Integer)
        _Dimension = dmsn
        _PointCount = pntCount
        _Points.Clear()

        Dim InverseDimension As Double = 1 / _Dimension
        Dim rnd As New Random

        For i As Integer = 0 To (_PointCount - 1)
            Dim RandomAngle As Double = 2 * Math.PI * rnd.NextDouble
            Dim RandomRadius As Double = rnd.NextDouble
            Dim x_value As Double = Math.Pow(RandomRadius, InverseDimension) * Math.Cos(RandomAngle)
            Dim y_value As Double = Math.Pow(RandomRadius, InverseDimension) * Math.Sin(RandomAngle)

            _Points.Add(Tuple.Create(x_value, y_value))
        Next
    End Sub
#End Region

End Class

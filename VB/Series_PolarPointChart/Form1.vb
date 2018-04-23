Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraCharts
' ...

Namespace Series_PolarPointChart
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			' Create a new chart.
			Dim polarPointChart As New ChartControl()

			' Add a polar series to it.
			Dim series1 As New Series("Series 1", ViewType.PolarPoint)

			' Populate the series with points.
			series1.Points.Add(New SeriesPoint(0, 90))
			series1.Points.Add(New SeriesPoint(45, 70))
			series1.Points.Add(New SeriesPoint(90, 50))
			series1.Points.Add(New SeriesPoint(135, 100))
			series1.Points.Add(New SeriesPoint(180, 90))
			series1.Points.Add(New SeriesPoint(225, 70))
			series1.Points.Add(New SeriesPoint(270, 50))

			' Add the series to the chart.
			polarPointChart.Series.Add(series1)

			' Hide the series labels.
			series1.Label.Visible = False

			' Adjust the view-type specific properties of the series.
			Dim myView As PolarPointSeriesView = CType(series1.View, PolarPointSeriesView)

			myView.PointMarkerOptions.Kind = MarkerKind.Star
			myView.PointMarkerOptions.StarPointCount = 5
			myView.PointMarkerOptions.Size = 20

			' Flip the diagram (if necessary).
			CType(polarPointChart.Diagram, PolarDiagram).StartAngleInDegrees = 180
			CType(polarPointChart.Diagram, PolarDiagram).RotationDirection = RadarDiagramRotationDirection.Counterclockwise

			' Add a title to the chart, and hide the legend.
			polarPointChart.Titles.Add(New ChartTitle())
			polarPointChart.Titles(0).Text = "A Polar Point Chart"
			polarPointChart.Legend.Visible = False

			' Add the chart to the form.
			polarPointChart.Dock = DockStyle.Fill
			Me.Controls.Add(polarPointChart)
		End Sub
	End Class
End Namespace
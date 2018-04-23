using System;
using System.Windows.Forms;
using DevExpress.XtraCharts;
// ...

namespace Series_PolarPointChart {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            // Create a new chart.
            ChartControl polarPointChart = new ChartControl();

            // Add a polar series to it.
            Series series1 = new Series("Series 1", ViewType.PolarPoint);

            // Populate the series with points.
            series1.Points.Add(new SeriesPoint(0, 90));
            series1.Points.Add(new SeriesPoint(45, 70));
            series1.Points.Add(new SeriesPoint(90, 50));
            series1.Points.Add(new SeriesPoint(135, 100));
            series1.Points.Add(new SeriesPoint(180, 90));
            series1.Points.Add(new SeriesPoint(225, 70));
            series1.Points.Add(new SeriesPoint(270, 50));

            // Add the series to the chart.
            polarPointChart.Series.Add(series1);

            // Adjust the view-type specific properties of the series.
            PolarPointSeriesView myView = (PolarPointSeriesView)series1.View;

            myView.PointMarkerOptions.Kind = MarkerKind.Star;
            myView.PointMarkerOptions.StarPointCount = 5;
            myView.PointMarkerOptions.Size = 20;

            // Flip the diagram (if necessary).
            ((PolarDiagram)polarPointChart.Diagram).StartAngleInDegrees = 180;
            ((PolarDiagram)polarPointChart.Diagram).RotationDirection =
                RadarDiagramRotationDirection.Counterclockwise;

            // Add a title to the chart, and hide the legend.
            polarPointChart.Titles.Add(new ChartTitle());
            polarPointChart.Titles[0].Text = "A Polar Point Chart";
            polarPointChart.Legend.Visibility =  DevExpress.Utils.DefaultBoolean.False;

            // Add the chart to the form.
            polarPointChart.Dock = DockStyle.Fill;
            this.Controls.Add(polarPointChart);
        }
    }
}
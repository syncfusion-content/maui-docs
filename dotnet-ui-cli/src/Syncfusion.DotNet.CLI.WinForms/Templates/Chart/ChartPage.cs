#nullable disable
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Chart;

namespace __ROOT_NAMESPACE__.__CONTROL_NAME__
{
    public partial class __VIEW_NAME__ : UserControl
    {
        public __VIEW_NAME__()
        {
            var viewModel = new __VIEW_MODEL_NAME__();
            var lineChart = new ChartControl(true);
            var lineSeries = new ChartSeries("Series1", ChartSeriesType.Line);
            var lineSeries2 = new ChartSeries("Series2", ChartSeriesType.Line);

            // Title
            var title = new ChartTitle
            {
                Text = "Electricity-Production",
            };
            lineChart.Titles.Add(title);

            // Axis
            lineChart.PrimaryXAxis.ValueType = ChartValueType.Category;
            lineChart.PrimaryXAxis.Title = "Years";
            lineChart.PrimaryYAxis.ValueType = ChartValueType.Double;
            lineChart.PrimaryYAxis.Title = "Production Percentage";

            // Series 1
            var dataSeriesModel = new CategoryAxisDataBindModel(viewModel.CanadaData)
            {
                CategoryName = nameof(ChartModel.Year),
                YNames = new[] { nameof(ChartModel.Value) },
            };
            lineSeries.CategoryModel = dataSeriesModel;
            lineSeries.Type = ChartSeriesType.Line;
            lineSeries.Text = "Canada";

            // DataLabel
            lineSeries.Style.DisplayText = true;
            lineSeries.Style.TextOrientation = ChartTextOrientation.Up;
            lineChart.Series.Add(lineSeries);

            // Series 2
            var dataSeriesModel2 = new CategoryAxisDataBindModel(viewModel.FranceData)
            {
                CategoryName = nameof(ChartModel.Year),
                YNames = new[] { nameof(ChartModel.Value) },
            };
            lineSeries2.CategoryModel = dataSeriesModel2;
            lineSeries2.Type = ChartSeriesType.Line;
            lineSeries2.Text = "France";

            // DataLabel
            lineSeries2.Style.DisplayText = true;
            lineSeries2.Style.TextOrientation = ChartTextOrientation.Up;
            lineChart.Series.Add(lineSeries2);

            // Legend
            lineChart.Legend.Visible = true;

            // Tooltip
            lineChart.ShowToolTips = true;

            // Zooming and Scrolling
            lineChart.EnableXZooming = true;
            lineChart.EnableYZooming = true;

            Dock = System.Windows.Forms.DockStyle.Fill;
            lineChart.Dock = System.Windows.Forms.DockStyle.Fill;
            Controls.Add(lineChart);
        }
    }
}

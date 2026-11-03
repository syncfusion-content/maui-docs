
Imports System.Windows.Forms
Imports Syncfusion.Windows.Forms.Chart

Namespace __ROOT_NAMESPACE__.Chart
    Public Partial Class ChartPage
        Inherits UserControl
        Public Sub New()
            Dim viewModel = New ChartViewModel()
            Dim lineChart = New ChartControl(True)
            Dim lineSeries = New ChartSeries("Series1", ChartSeriesType.Line)
            Dim lineSeries2 = New ChartSeries("Series2", ChartSeriesType.Line)

            ' Title
            Dim title = New ChartTitle With {
    .Text = "Electricity-Production"
}
            lineChart.Titles.Add(title)

            ' Axis
            lineChart.PrimaryXAxis.ValueType = ChartValueType.Category
            lineChart.PrimaryXAxis.Title = "Years"
            lineChart.PrimaryYAxis.ValueType = ChartValueType.Double
            lineChart.PrimaryYAxis.Title = "Production Percentage"

            ' Series 1
            Dim dataSeriesModel = New CategoryAxisDataBindModel(viewModel.CanadaData) With {
    .CategoryName = NameOf(ChartModel.Year),
    .YNames = {NameOf(ChartModel.Value)}
}
            lineSeries.CategoryModel = dataSeriesModel
            lineSeries.Type = ChartSeriesType.Line
            lineSeries.Text = "Canada"

            ' DataLabel
            lineSeries.Style.DisplayText = True
            lineSeries.Style.TextOrientation = ChartTextOrientation.Up
            lineChart.Series.Add(lineSeries)

            ' Series 2
            Dim dataSeriesModel2 = New CategoryAxisDataBindModel(viewModel.FranceData) With {
    .CategoryName = NameOf(ChartModel.Year),
    .YNames = {NameOf(ChartModel.Value)}
}
            lineSeries2.CategoryModel = dataSeriesModel2
            lineSeries2.Type = ChartSeriesType.Line
            lineSeries2.Text = "France"

            ' DataLabel
            lineSeries2.Style.DisplayText = True
            lineSeries2.Style.TextOrientation = ChartTextOrientation.Up
            lineChart.Series.Add(lineSeries2)

            ' Legend
            lineChart.Legend.Visible = True

            ' Tooltip
            lineChart.ShowToolTips = True

            ' Zooming and Scrolling
            lineChart.EnableXZooming = True
            lineChart.EnableYZooming = True

            MyBase.Dock = DockStyle.Fill
            lineChart.Dock = DockStyle.Fill
            Controls.Add(lineChart)
        End Sub
    End Class
End Namespace

---
layout: post
title: Axis label tapped event in .NET MAUI Chart control | Syncfusion
description: Learn here all about handling axis label tapped event in Syncfusion® .NET MAUI Chart (SfCartesianChart) control.
platform: maui
control: SfCartesianChart
documentation: ug
keywords: .net maui chart axis label tap, axislabeltapped event maui chart, syncfusion maui chart axis interaction, cartesian chart axis label click maui, maui chart axis tap event.
---

# Axis label tapped event in .NET MAUI Chart

The `SfCartesianChart` provides support to handle user interaction with axis labels using the `AxisLabelTapped` event. This event is triggered when a user taps on an axis label, enabling scenarios such as drill-down, filtering, and navigation based on the selected category.

## Define AxisLabelTapped event

You can handle the `AxisLabelTapped` event by assigning a handler to the `SfCartesianChart`.

{% tabs %}

{% highlight xaml %}

<chart:SfCartesianChart AxisLabelTapped="OnAxisLabelTapped">

    <chart:SfCartesianChart.XAxes>
        <chart:CategoryAxis />
    </chart:SfCartesianChart.XAxes>

    <chart:SfCartesianChart.YAxes>
        <chart:NumericalAxis />
    </chart:SfCartesianChart.YAxes>

    <chart:ColumnSeries ItemsSource="{Binding Data}"
                        XBindingPath="Category"
                        YBindingPath="Value"/>
</chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

private void OnAxisLabelTapped(object sender, AxisLabelTappedEventArgs e)
{
            var axis = e.Axis;
            var axisLabel = e.AxisLabel;
            var tapPosition = e.Position;

            string title = "Axis Label Details";
            string message = $"Label: {axisLabel.Content}\n" +
                            $"Position: {axisLabel.Position:F2}\n" +
                            $"Axis Type: {axis.GetType().Name}\n" +
                            $"Axis Name: {axis.Name ?? "Default"}\n" +
                            $"Tap Location: ({tapPosition.X:F0},{tapPosition.Y:F0})";

            // Display popup alert
            await DisplayAlert(title, message, "OK");
}

{% endhighlight %}

{% endtabs %}

## Event arguments

The `AxisLabelTappedEventArgs` provides information about the tapped axis label.

* `Axis` - Gets the associated axis where the label was tapped.
* `AxisLabel` - Gets the `ChartAxisLabel` object that contains details about the tapped label.
* `Position` - Gets the screen coordinates (X, Y) of the tap location in device-independent pixels.

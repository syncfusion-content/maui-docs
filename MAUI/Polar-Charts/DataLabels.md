---
layout: post
title: Data labels in .NET MAUI Chart control | Syncfusion
description: Learn here all about how to configure the data labels and their features in Syncfusion .NET MAUI Chart (SfPolarChart).
platform: maui
control: SfPolarChart
documentation: ug
---

# Data Labels in .NET MAUI Chart

Data labels are used to display values related to a chart segment. Values from a data point(x, y) or other custom properties from a data source can be displayed. 

Each data label can be represented by the following:

* Label - displays the segment label content at the (X, Y) point.

## Enable Data Label 

The [ShowDataLabels]() property of a series is used to enable the data labels.

{% tabs %}

{% highlight xaml %}

<chart:SfPolarChart>
    . . .
    <chart:PolarLineSeries ItemsSource="{Binding PlantDetails}" 
                        XBindingPath="Direction"
                        YBindingPath="Tree" ShowDataLabels="True">
        </chart:PolarLineSeries>
</chart:SfPolarChart>

{% endhighlight %}

{% highlight c# %}

SfPolarChart chart = new SfPolarChart();
. . .
PolarLineSeries series = new PolarLineSeries()
{
    ItemsSource = viewModel.PlantDetails,
    XBindingPath = "Direction",
    YBindingPath = "Tree",
    ShowDataLabels = true
};

chart.Series.Add(series);

{% endhighlight %}

{% endtabs %}

![Data label in MAUI chart](DataLabel_images/MAUI_polar_line_datalabel.png)

Data labels can be customized by using the [DataLabelSettings]() property of chart series. To customize them, you need to create an instance of [PolarDataLabelSettings]() and set it to the [DataLabelSettings]() property. The following properties available in [PolarDataLabelSettings]() can be used to customize the data labels.

* [BarAlignment]() - Gets or sets the data label alignment top, middle or bottom.
* [LabelPlacement]() - Gets or sets the data label position inside, outside or default.
* [LabelStyle]() - Gets or sets the options for customizing the data labels. 
* [UseSeriesPalette]() - Gets or sets a value indicating whether the data label should reflect the series interior.

## Data Label Alignment

The alignment of data labels inside the series is defined by using the [BarAlignment]() property. 

* [Top]() - Positions the data label at the top edge point of a chart segment.
* [Middle]() - Positions the data label at the center point of a chart segment.
* [Bottom]() - Positions the data label at the bottom edge point of a chart segment.

N> This behavior varies based on the chart series type.

{% tabs %}

{% highlight xaml %}

<chart:SfPolarChart>
    . . .
    <chart:PolarLineSeries ShowDataLabels="True">
        <chart:PolarLineSeries.DataLabelSettings>
            <chart:PolarDataLabelSettings BarAlignment="Middle"/>
        </chart:PolarLineSeries.DataLabelSettings>
    </chart:PolarLineSeries>
</chart:SfPolarChart>

{% endhighlight %}

{% highlight c# %}

SfPolarChart chart = new SfPolarChart();
PolarLineSeries series = new PolarLineSeries();
. . .
series.DataLabelSettings = new PolarDataLabelSettings()
{
    BarAlignment = DataLabelAlignment.Middle,
};

chart.Series.Add(series);

{% endhighlight %}

{% endtabs %}

## LabelPlacement

In addition to the alignment options mentioned above, the Chart provides additional customization options for positioning the data labels.

The [LabelPlacement]() property is used to position the data labels at [Center](), [Inner]() and [Outer]() positions relative to the actual data point position. By default, labels are positioned based on the series types for better readability.

## Applying Series Brush

The [UseSeriesPalette]() property is used to set the interior of the series to the data marker background.

{% tabs %}

{% highlight xaml %}

<chart:SfPolarChart>
    . . .
    <chart:PolarLineSeries ShowDataLabels="True">
        <chart:PolarLineSeries.DataLabelSettings>
            <chart:PolarDataLabelSettings  UseSeriesPalette="False"/>
        </chart:PolarLineSeries.DataLabelSettings>
    </chart:PolarLineSeries>
</chart:SfPolarChart>

{% endhighlight %}

{% highlight c# %}

SfPolarChart chart = new SfPolarChart();
PolarLineSeries series = new PolarLineSeries();
. . .
series.DataLabelSettings = new PolarDataLabelSettings()
{
    UseSeriesPalette = false,
};

chart.Series.Add(series);

{% endhighlight %}

{% endtabs %}

## Formatting Label Context

The content of the label can be customized using the [LabelContext]() property. Following are the two options that are supported now,

* [Percentage]() - This will show the percentage value of corresponding data point Y value

* [YValue]() - This will show the corresponding Y value.

{% tabs %}

{% highlight xaml %}

    <chart:SfPolarChart>
        . . .
        <chart:PolarAreaSeries ItemsSource="{Binding PlantDetails}" 
                            ShowDataLabels="True"
                            XBindingPath="Direction"
                            YBindingPath="Tree" 
                            LabelContext="Percentage"/>

    </chart:SfPolarChart>

{% endhighlight %}

{% highlight c# %}

    SfPolarChart chart = new SfPolarChart();
    . . .
    PolarAreaSeries series = new PolarAreaSeries()
    {
        ItemsSource = new ViewModel().PlantDetails,
        XBindingPath = "Direction",
        YBindingPath = "Tree",
        ShowDataLabels = true,
        LabelContext = LabelContext.Percentage
    };

    chart.Series.Add(series);
    this.Content = chart;
        
{% endhighlight %}

{% endtabs %}

## LabelTemplate

The [SfPolarChart]() provides support to customize the appearance of the datalabel by using the [LabelTemplate]() property.

{% tabs %}

{% highlight xaml %}

    <chart:SfPolarChart >
        <chart:SfPolarChart.Resources>
            <DataTemplate x:Key="labelTemplate">
                <HorizontalStackLayout Spacing="5">
                    <Label Text="{Binding Item.Tree}" VerticalOptions="Center" FontSize = "15"/>
                    <Image Source="arrow.png" WidthRequest="15" HeightRequest="15"/>
                </HorizontalStackLayout>
            </DataTemplate>
        </chart:SfPolarChart.Resources>
        . . .
        <chart:PolarAreaSeries ItemsSource="{Binding PlantDetails}" 
                            LabelTemplate="{StaticResource labelTemplate}"
                            XBindingPath="Direction"
                            YBindingPath="Tree" 
                            ShowDataLabels="True"/>

    </chart:SfPolarChart>

{% endhighlight %}

{% highlight c# %}

    SfPolarChart chart = new SfPolarChart();
    . . .
    PolarAreaSeries series = new PolarAreaSeries();
    series.ShowDataLabels = true;
    series.ItemsSource = new ViewModel().PlantDetails;
    series.XBindingPath = "Direction";
    series.YBindingPath = "Tree";

    DataTemplate labelTemplate = new DataTemplate(() =>
    {
        HorizontalStackLayout horizontalStackLayout = new HorizontalStackLayout { Spacing = 5 };

        var label = new Label
        {
            VerticalOptions = LayoutOptions.Center,
            FontSize = 15
        };
        label.SetBinding(Label.TextProperty, new Binding("Item.Tree"));

        var image = new Image
        {
            Source = "arrow.png",
            WidthRequest = 15,
            HeightRequest = 15
        };
        
        horizontalStackLayout.Children.Add(label);
        horizontalStackLayout.Children.Add(image);
        
        return horizontalStackLayout;
    });

    series.LabelTemplate = labelTemplate;
    chart.Series.Add(series);
    this.Content = chart;
        
{% endhighlight %}

{% endtabs %}
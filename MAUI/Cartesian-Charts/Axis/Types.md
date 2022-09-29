---
layout: post
title: Axis types in .NET MAUI Chart control | Syncfusion
description: Learn here all about axis types and its features in Syncfusion .NET MAUI Chart (SfCartesianChart) control and more.
platform: maui
control: SfCartesianChart
documentation: ug
---

# Types of Axis in .NET MAUI Chart

Cartesian chart supports the following types of chart axis.

* NumericalAxis
* CategoryAxis
* DateTimeAxis
* LogarithmicAxis

## Numerical Axis

[NumericalAxis](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.NumericalAxis.html) is used to plot numerical values to the chart. [NumericalAxis](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.NumericalAxis.html) can be defined for both [XAxes](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html#Syncfusion_Maui_Charts_SfCartesianChart_XAxes) and [YAxes](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html#Syncfusion_Maui_Charts_SfCartesianChart_YAxes).

{% tabs %}

{% highlight xaml %}

<chart:SfCartesianChart>
    . . .
    <chart:SfCartesianChart.XAxes>
        <chart:NumericalAxis/>
    </chart:SfCartesianChart.XAxes>
    <chart:SfCartesianChart.YAxes>
        <chart:NumericalAxis/>
    </chart:SfCartesianChart.YAxes>

</chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

SfCartesianChart chart = new SfCartesianChart();
. . .
NumericalAxis primaryAxis = new NumericalAxis();
chart.XAxes.Add(primaryAxis);

NumericalAxis secondaryAxis = new NumericalAxis();
chart.YAxes.Add(secondaryAxis);

{% endhighlight %}

{% endtabs %}

![NumericalAxis interval support in MAUI Chart](Axis_Images/maui_chart_axis_types.jpg)

### Interval

Axis interval can be customized by using the [Interval](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.CategoryAxis.html#Syncfusion_Maui_Charts_CategoryAxis_Interval) property. By default, interval will be calculated based on the minimum and maximum value of the provided data.

{% tabs %}

{% highlight xaml %}

<chart:SfCartesianChart>
. . .
<chart:SfCartesianChart.XAxes>
    <chart:NumericalAxis Interval="10" />
</chart:SfCartesianChart.XAxes>
<chart:SfCartesianChart.YAxes>
    <chart:NumericalAxis/>
</chart:SfCartesianChart.YAxes>

</chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

SfCartesianChart chart = new SfCartesianChart();
. . .
NumericalAxis primaryAxis = new NumericalAxis()
{
    Interval = 10, 
};
chart.XAxes.Add(primaryAxis);

NumericalAxis secondaryAxis = new NumericalAxis();
chart.YAxes.Add(secondaryAxis);

{% endhighlight %}

{% endtabs %}

![NumericalAxis interval support in MAUI Chart](Axis_Images/maui_chart_numeric_axis_interval.jpg)

### Customizing the Range

[Maximum](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.NumericalAxis.html#Syncfusion_Maui_Charts_NumericalAxis_Maximum) and [Minimum](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.NumericalAxis.html#Syncfusion_Maui_Charts_NumericalAxis_Minimum) properties of axis is used for setting the maximum and minimum value of the axis range respectively.

N> If  minimum or maximum value is set, the other value is calculated by default internally.

{% tabs %}

{% highlight xaml %}

<chart:SfCartesianChart.YAxes>
    <chart:NumericalAxis Maximum="2750" Minimum="250" Interval="250"/>
</chart:SfCartesianChart.YAxes>

{% endhighlight %}

{% highlight c# %}

NumericalAxis secondaryAxis = new NumericalAxis()
{
    Maximum = 2750,
    Minimum = 250,
    Interval = 250
};
chart.YAxes.Add(secondaryAxis);

{% endhighlight %}

{% endtabs %}

## Category Axis

The [CategoryAxis](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.CategoryAxis.html) is an indexed based axis that plots values based on the index of the data point collection. The points are equally spaced here.

{% tabs %}

{% highlight xaml %}

<chart:SfCartesianChart>
. . .
<chart:SfCartesianChart.XAxes>
    <chart:CategoryAxis/>
</chart:SfCartesianChart.XAxes>

</chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

SfCartesianChart chart = new SfCartesianChart();
. . .
CategoryAxis primaryAxis = new CategoryAxis();
chart.XAxes.Add(primaryAxis);

{% endhighlight %}

{% endtabs %}

![CategoryAxis support in MAUI Chart](Axis_Images/maui_chart_category_axis.jpg)

### Label placement

The [LabelPlacement](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.CategoryAxis.html#Syncfusion_Maui_Charts_CategoryAxis_LabelPlacement) property in [CategoryAxis](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.CategoryAxis.html) is used to placed the axis labels based on ticks and between ticks. The default value of [LabelPlacement](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.CategoryAxis.html#Syncfusion_Maui_Charts_CategoryAxis_LabelPlacement) is [OnTicks](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.LabelPlacement.html#Syncfusion_Maui_Charts_LabelPlacement_OnTicks).

{% tabs %}

{% highlight xaml %}

<chart:SfCartesianChart>
    . . .
    <chart:SfCartesianChart.XAxes>
        <chart:CategoryAxis LabelPlacement="BetweenTicks"/>
    </chart:SfCartesianChart.XAxes>

</chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

SfCartesianChart chart = new SfCartesianChart();
. . .
CategoryAxis primaryAxis = new CategoryAxis()
{
    LabelPlacement = LabelPlacement.BetweenTicks
};
chart.XAxes.Add(primaryAxis);

{% endhighlight %}

{% endtabs %}

![Axis label placement support in MAUI Chart](Axis_Images/maui_chart_category_axis_labelPlacement.jpg)

### Interval

By default, the [CategoryAxis](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.CategoryAxis.html) axis labels are display with fixed interval 1. It can customized by using the [Interval](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.CategoryAxis.html#Syncfusion_Maui_Charts_CategoryAxis_Interval) property of axis.

{% tabs %}

{% highlight xaml %}

<chart:SfCartesianChart>
    . . .
    <chart:SfCartesianChart.XAxes>
        <chart:CategoryAxis Interval="2" />
    </chart:SfCartesianChart.XAxes>
    <chart:SfCartesianChart.YAxes>
        <chart:NumericalAxis/>
    </chart:SfCartesianChart.YAxes>

</chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

SfCartesianChart chart = new SfCartesianChart();
. . .
CategoryAxis primaryAxis = new CategoryAxis()
{
    Interval = 2, 
};
chart.XAxes.Add(primaryAxis);

NumericalAxis secondaryAxis = new NumericalAxis();
chart.YAxes.Add(secondaryAxis);

{% endhighlight %}

{% endtabs %}

![CategoryAxis interval support in MAUI Chart](Axis_Images/maui_chart_category_axis_interval.jpg)

## DateTime Axis

[DateTimeAxis](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DateTimeAxis.html) is used to plot `DateTime` values. The [DateTimeAxis](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DateTimeAxis.html) is widely used to make financial charts in places like the Stock Market, where index plotting is done every day.

{% tabs %}

{% highlight xaml %}

<chart:SfCartesianChart>
    . . .
    <chart:SfCartesianChart.XAxes>
        <chart:DateTimeAxis/>
    </chart:SfCartesianChart.XAxes>

</chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

SfCartesianChart chart = new SfCartesianChart();
. . .
DateTimeAxis primaryAxis = new DateTimeAxis();
chart.XAxes.Add(primaryAxis);

{% endhighlight %}

{% endtabs %}

![DateTimeCategoryAxis support in MAUI Chart](Axis_Images/maui_chart_datetime_axis.jpg)

### Interval

In [DateTimeAxis](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DateTimeAxis.html), intervals can be customized by using the [Interval](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.CategoryAxis.html#Syncfusion_Maui_Charts_CategoryAxis_Interval) and [IntervalType](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DateTimeAxis.html#Syncfusion_Maui_Charts_DateTimeAxis_IntervalType) properties. For example, setting [Interval](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.CategoryAxis.html#Syncfusion_Maui_Charts_CategoryAxis_Interval) as 6 and [IntervalType](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DateTimeAxis.html#Syncfusion_Maui_Charts_DateTimeAxis_IntervalType) as [Months](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DateTimeIntervalType.html#Syncfusion_Maui_Charts_DateTimeIntervalType_Months) will consider 6 months as interval.

{% tabs %}

{% highlight xaml %}

<chart:SfCartesianChart>
    ...
    <chart:SfCartesianChart.XAxes>
        <chart:DateTimeAxis Interval="6" IntervalType="Months"/>
    </chart:SfCartesianChart.XAxes>
    <chart:SfCartesianChart.YAxes>
        <chart:NumericalAxis/>
    </chart:SfCartesianChart.YAxes>

</chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

SfCartesianChart chart = new SfCartesianChart();
. . .
DateTimeAxis primaryAxis = new DateTimeAxis()
{
    Interval = 6, 
    IntervalType = DateTimeIntervalType.Months
};
chart.XAxes.Add(primaryAxis);

NumericalAxis secondaryAxis = new NumericalAxis();
chart.YAxes.Add(secondaryAxis);

{% endhighlight %}

{% endtabs %}

![DateTimeAxis interval support in MAUI Chart](Axis_Images/maui_chart_datetime_axis_interval.jpg)

### Customizing the Range

[Minimum](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DateTimeAxis.html#Syncfusion_Maui_Charts_DateTimeAxis_Minimum) and [Maximum](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DateTimeAxis.html#Syncfusion_Maui_Charts_DateTimeAxis_Maximum) properties behavior is same as in [NumericalAxis](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.NumericalAxis.html) instead of setting numerical value, have to set date time values.

{% tabs %}

{% highlight xaml %}

<chart:SfCartesianChart>
    . . .
    <chart:SfCartesianChart.XAxes>
        <chart:DateTimeAxis Minimum="2021/05/10" Maximum="2021/11/01"/>
    </chart:SfCartesianChart.XAxes>

</chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

SfCartesianChart chart = new SfCartesianChart();
. . .
DateTimeAxis primaryAxis = new DateTimeAxis()
{
    Minimum = new DateTime(2021,05,10),
    Maximum = new DateTime(2021,11,01),
};
chart.XAxes.Add(primaryAxis);

{% endhighlight %}

{% endtabs %}

![DateTimeAxis range customization support in MAUI Chart](Axis_Images/maui_chart_datetime_axis_range.jpg)

## Logarithmic Axis

The [LogarithmicAxis]() uses a logarithmic scale, and it is very useful in visualising data when the given data range has a big difference. It can be used either on the x-axis or the chart's y-axis. The following code example demonstrates how to set the logarithmic axis in the chart.

{% tabs %}

{% highlight xaml %}

<chart:SfCartesianChart>

    <chart:SfCartesianChart.XAxes>
        <chart:LogarithmicAxis/>
    </chart:SfCartesianChart.XAxes>
    <chart:SfCartesianChart.YAxes>
        <chart:LogarithmicAxis/>
    </chart:SfCartesianChart.YAxes>
    
</chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

SfCartesianChart chart = new SfCartesianChart();

LogarithmicAxis primaryAxis = new LogarithmicAxis();
chart.XAxes.Add(primaryAxis);

LogarithmicAxis secondaryAxis = new LogarithmicAxis();
chart.YAxes.Add(secondaryAxis);

{% endhighlight %}

{% endtabs %}

![LogarithmicAxis support in MAUI Chart](Axis_Images/maui_chart_logarithmic_axis.jpg)

### Range customization

To customize the range of the log axis, you can use the [Minimum](), [Maximum]() and [Interval]() properties of the [LogarithmicAxis](). By default, an excellent range will be calculated automatically based on the provided data. The following code example demonstrates the range customization of the axis.

{% tabs %}

{% highlight xaml %}

<chart:SfCartesianChart.YAxes>

    <chart:LogarithmicAxis Minimum="100" Maximum="10000"/>

</chart:SfCartesianChart.YAxes>


{% endhighlight %}

{% highlight c# %}

chart.YAxes.Add(new LogarithmicAxis() { 
	Minimum = 100, 
	Maximum = 10000 
});

{% endhighlight %}

{% endtabs %}

![LogarithmicAxis range customization in MAUI Chart](Axis_Images/maui_chart_logarithmic_axis_range.jpg)

### Base customization

The logarithmic axis base can be customized using the [LogarithmicBase]() property of the axis. By default, the base value is 10. The following code example demonstrates how to customize the base value.

{% tabs %}

{% highlight xaml %}

<chart:SfCartesianChart.YAxes>

    <chart:LogarithmicAxis LogarithmicBase="2"/>

</chart:SfCartesianChart.YAxes>

{% endhighlight %}

{% highlight c# %}

chart.YAxes.Add(new LogarithmicAxis( ) { LogarithmicBase = 2 });

{% endhighlight %}

{% endtabs %}

![LogarithmicAxis base customization in MAUI Chart](Axis_Images/maui_chart_logarithmic_axis_base.jpg)

### Interval customization

Axis interval can be customized using the [Interval]() property of the axis. By default, interval will be calculated based on the minimum and maximum value of the provided data. And the default value of the interval is 1. The following code example demonstrates the interval customization of the axis.

{% tabs %}

{% highlight xaml %}

<chart:SfCartesianChart.YAxes>

    <chart:LogarithmicAxis Interval="2"/>

</chart:SfCartesianChart.YAxes>

{% endhighlight %}

{% highlight c# %}

chart.YAxes.Add(new LogarithmicAxis( ) { Interval = 2 });

{% endhighlight %}

{% endtabs %}

![LogarithmicAxis interval in MAUI Chart](Axis_Images/maui_chart_logarithmic_axis_interval.jpg)

### Actual minimum & maximum

The ActualMinimum and ActualMaximum of the LogarithmicAxis used to get actual range of the axis. The following code example demonstrates how to get the actual minimum and maximum.

{% tabs %}

{% highlight xaml %}

<VerticalStackLayout>

     <chart:SfCartesianChart>
        
         <chart:SfCartesianChart.XAxes>
                       <chart:LogarithmicAxis x:Name="xAxis"/>
         </chart:SfCartesianChart.XAxes>
        
         <chart:SfCartesianChart.YAxes>
                       <chart:LogarithmicAxis x:Name="yAxis"/>
         </chart:SfCartesianChart.YAxes>
         . . .
     </chart:SfCartesianChart>

    <Label HorizontalOptions="Center" Text="{Binding Source= {x:Reference yAxis}, Path=ActualMinimum,   
    StringFormat='Actual minimum is: {0}'}" />
    <Label HorizontalOptions="Center" Text="{Binding Source= {x:Reference yAxis}, Path=ActualMaximum,    StringFormat='Actual maximum is: {0}'}" />

</VerticalStackLayout>

{% endhighlight %}

{% highlight c# %}

VerticalStackLayout layout = new VerticalStackLayout( );

SfCartesianChart chart = new SfCartesianChart( );

chart.XAxes.Add(new LogarithmicAxis( ));

LogarithmicAxis yAxis = new LogarithmicAxis( );

chart.YAxes.Add(yAxis);

. . . 

Label firstLabel = new Label( );
Label secondLabel = new Label( );

firstLabel.SetBinding(Label.TextProperty, new Binding("ActualMinimum", source: yAxis, stringFormat: "Actual minimum is: {0}"));
secondLabel.SetBinding(Label.TextProperty, new Binding("ActualMaximum", source: yAxis, stringFormat: "Actual maximum is: {0}"));  

{% endhighlight %}

{% endtabs %}

![LogarithmicAxis actual minimum and actual maximum in MAUI Chart](Axis_Images/maui_chart_logarithmic_axis_actual_minimum_actual_maximum.jpg)


## Inversed

Axis can be inverted by using the [IsInversed](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxis.html#Syncfusion_Maui_Charts_ChartAxis_IsInversed) property. The default value of this property is `False`.

{% tabs %}

{% highlight xaml %}

<chart:SfCartesianChart>
    . . .
    <chart:SfCartesianChart.YAxes>
        <chart:NumericalAxis IsInversed="True"/>
    </chart:SfCartesianChart.YAxes>

</chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

SfCartesianChart chart = new SfCartesianChart();
. . .
NumericalAxis secondaryAxis = new NumericalAxis();
secondaryAxis.IsInversed = true;
chart.YAxes.Add(secondaryAxis);

{% endhighlight %}

{% endtabs %}

![Inversed axis support in MAUI Chart](Axis_Images/maui_chart_axis_isInversed.jpg)

## Axis Visibility

Axis visibility can be controlled using the [IsVisible](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxis.html#Syncfusion_Maui_Charts_ChartAxis_IsVisible) property of axis. Default value of [IsVisible](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxis.html#Syncfusion_Maui_Charts_ChartAxis_IsVisible) property is `True`.

{% tabs %}

{% highlight xaml %}

<chart:SfCartesianChart.YAxes>
    <chart:NumericalAxis IsVisible="False"/>
</chart:SfCartesianChart.YAxes>

{% endhighlight %}

{% highlight c# %}

SfCartesianChart chart = new SfCartesianChart();
. . .
NumericalAxis secondaryAxis = new NumericalAxis() { IsVisible = false };
chart.YAxes.Add(secondaryAxis);

{% endhighlight %}

{% endtabs %}

## Multiple Axes

Cartesian charts provides support to arrange the multiple series inside the same chart area with specified x-axis and y-axis. There are two properties [XAxisName](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.CartesianSeries.html#Syncfusion_Maui_Charts_CartesianSeries_XAxisName) and [YAxisName](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.CartesianSeries.html#Syncfusion_Maui_Charts_CartesianSeries_YAxisName) in all the Cartesian series type, which is used to provide multiple axes support. These axes can be arranged in a stacking order or in a side by side pattern.

By default, The 0th index value of XAxes and YAxes is used to plot all of the series.

{% tabs %}

{% highlight xaml %}

<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:sys="clr-namespace:System;assembly=mscorlib"
             xmlns:chart="clr-namespace:Syncfusion.Maui.Charts;assembly=Syncfusion.Maui.Charts">

<chart:SfCartesianChart>
    . . .
	<chart:SfCartesianChart.XAxes>
		<chart:DateTimeAxis ShowMajorGridLines="False" />
	</chart:SfCartesianChart.XAxes>
	<chart:SfCartesianChart.YAxes>
		<chart:NumericalAxis ShowMajorGridLines="False" />
		<chart:NumericalAxis Name="series_YAxis" CrossesAt="{Static x:Double.MaxValue}" ShowMajorGridLines="False" />
	</chart:SfCartesianChart.YAxes>
        <chart:ColumnSeries ItemsSource="{Binding Data1}" 
            XBindingPath="Date"
            YBindingPath="Value"
			YAxisName="series_YAxis"/>
        <chart:SplineSeries ItemsSource="{Binding Data}" 
                XBindingPath="Date"
                YBindingPath="Value"/>
</chart:SfCartesianChart>

</ContentPage>

{% endhighlight %}

{% highlight c# %}

SfCartesianChart chart = new SfCartesianChart();
. . .

ColumnSeries series1 = new ColumnSeries()
{
    ItemsSource = new ViewModel().Demands,
    XBindingPath = "Demand",
    YBindingPath = "Year2011"
};

SplineSeries series2 = new SplineSeries()
{
    ItemsSource = new ViewModel().Demands,
    XBindingPath = "Date",
    YBindingPath = "Year2011",
};

DateTimeAxis primaryAxis = new DateTimeAxis()
{
    ShowMajorGridLines = false
};
chart.XAxes.Add(primaryAxis);

NumericalAxis secondaryAxis = new NumericalAxis()
{
    CrossesAt = double.MaxValue,
    ShowMajorGridLines = false
};
secondaryAxis.Name = "series_YAxis";
chart.YAxes.Add(secondaryAxis);
NumericalAxis secondaryAxis1 = new NumericalAxis();
chart.YAxes.Add(secondaryAxis1);
series1.YAxisName = "series_YAxis";


chart.Series.Add(series1);
chart.Series.Add(series2);

{% endhighlight %}

{% endtabs %}

In the above image, the [ColumnSeries](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ColumnSeries.html?tabs=tabid-1) is plotted based on additional axes of [YAxes](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html#Syncfusion_Maui_Charts_SfCartesianChart_YAxes) collection, and [SplineSeries](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SplineSeries.html?tabs=tabid-1) is plotted based on axis of the collection's 0th index.

## Axis Crossing

The chart allows you to customize the origin, by default the axis will be rendered with (0,0) as the origin in x and y-axes. An axis can be positioned anywhere in the chart area by using the [CrossesAt](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxis.html#Syncfusion_Maui_Charts_ChartAxis_CrossesAt) property. his property specifies where the horizontal axis intersects or crosses the vertical axis, and vice versa. The default value of the CrossesAt property is `double.NaN`.

{% tabs %}

{% highlight xaml %}

<chart:SfCartesianChart>
    
    <chart:SfCartesianChart.XAxes>
            <chart:NumericalAxis CrossesAt="0" Minimum="-8" Maximum="8" ShowMajorGridLines="False" />
    </chart:SfCartesianChart.XAxes>

    <chart:SfCartesianChart.YAxes>
            <chart:NumericalAxis CrossesAt="0" Minimum="-8" Maximum="8"  ShowMajorGridLines="False" />
    </chart:SfCartesianChart.YAxes>

</chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

SfCartesianChart chart = new SfCartesianChart();
NumericalAxis primaryAxis = new NumericalAxis();
primaryAxis.CrossesAt = 0;
primaryAxis.Minimum = -8;
primaryAxis.Maximum = 8;
primaryAxis.ShowMajorGridLines = false;
chart.XAxes.Add(primaryAxis);
NumericalAxis secondaryAxis = new NumericalAxis();
secondaryAxis.CrossesAt = 0;
secondaryAxis.Minimum = -8;
secondaryAxis.Maximum = 8;
secondaryAxis.ShowMajorGridLines = false;
chart.YAxes.Add(secondaryAxis);

{% endhighlight %}

{% endtabs %}

![Axis crossing support in MAUI Chart](Axis_Images/maui_chart_axis_crossing.png)

### Positioning the axis elements while crossing

The [RenderNextToCrossingValue](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxis.html#Syncfusion_Maui_Charts_ChartAxis_RenderNextToCrossingValue) property is used to determine whether the crossing axis should be placed at crossing position or not. The default value of [RenderNextToCrossingValue](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxis.html#Syncfusion_Maui_Charts_ChartAxis_RenderNextToCrossingValue) property is true.

{% tabs %}

{% highlight xaml %}

<chart:SfCartesianChart>
    
    <chart:SfCartesianChart.XAxes>
            <chart:NumericalAxis CrossesAt="0" RenderNextToCrossingValue="False" />
    </chart:SfCartesianChart.XAxes>

    <chart:SfCartesianChart.YAxes>
            <chart:NumericalAxis CrossesAt="0" />
    </chart:SfCartesianChart.YAxes>

</chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

SfCartesianChart chart = new SfCartesianChart();
NumericalAxis primaryAxis = new NumericalAxis();
primaryAxis.CrossesAt = 0;
primaryAxis.RenderNextToCrossingValue = false;
chart.XAxes.Add(primaryAxis);
NumericalAxis secondaryAxis = new NumericalAxis();
secondaryAxis.CrossesAt = 0;
chart.YAxes.Add(secondaryAxis);

{% endhighlight %}

{% endtabs %}

![RenderNextToCrossingValue support in MAUI Chart](Axis_Images/maui_chart_axis_rendernexttocrossingvalue.png)

### Crossing the date-time axis

For the crossing in date time horizontal axis, date object should be provided as value for CrossesAt property of vertical axis.

{% tabs %}

{% highlight xaml %}

<chart:SfCartesianChart>
    
    <chart:SfCartesianChart.XAxes>
            <chart:DateTimeAxis />
    </chart:SfCartesianChart.XAxes>

    <chart:SfCartesianChart.yAxes>
            <chart:NumericalAxis />
    </chart:SfCartesianChart.yAxes>

</chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

SfCartesianChart chart = new SfCartesianChart();
NumericalAxis primaryAxis = new NumericalAxis();
chart.XAxes.Add(primaryAxis);
NumericalAxis secondaryAxis = new NumericalAxis();
secondaryAxis.CrossesAt = new DateTime(2021, 01, 01);;
chart.YAxes.Add(secondaryAxis);

{% endhighlight %}

{% endtabs %}

![DateTimeAxis crossing support in MAUI Chart](Axis_Images/maui_chart_datetime_axis_crossing.png)

## Events

### ActualRangeChanged

The [ActualRangeChanged](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ActualRangeChangedEventArgs.html) event is triggered when the actual range of the axis is changed. The argument contains the following information:

* [ActualMinimum](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ActualRangeChangedEventArgs.html#Syncfusion_Maui_Charts_ActualRangeChangedEventArgs_ActualMinimum) - used to get or set the actual minimum value of the axis.
* [ActualMaximum](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ActualRangeChangedEventArgs.html#Syncfusion_Maui_Charts_ActualRangeChangedEventArgs_ActualMaximum) - used to get or set the actual maximum value of the axis.
* [VisibleMinimum](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ActualRangeChangedEventArgs.html#Syncfusion_Maui_Charts_ActualRangeChangedEventArgs_VisibleMinimum) - used to get or set the visible minimum value of the axis.
* [VisibleMaximum](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ActualRangeChangedEventArgs.html#Syncfusion_Maui_Charts_ActualRangeChangedEventArgs_VisibleMaximum) - used to get or set the visible maximum value of the axis.

N> The actual range and visible range are similar unless the range is changed by specifying the [ZoomPosition](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxis.html#Syncfusion_Maui_Charts_ChartAxis_ZoomPosition) and [ZoomFactor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxis.html#Syncfusion_Maui_Charts_ChartAxis_ZoomFactor) properties or zooming the chart interactively. The visible range is always the range that you can see visually on the screen.

### LabelCreated

The [LabelCreated](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxis.html#Syncfusion_Maui_Charts_ChartAxis_LabelCreated) event is triggered when the axis label is created. The argument contains the following information:

* [LabelContent](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxisLabelEventArgs.html#Syncfusion_Maui_Charts_ChartAxisLabelEventArgs_LabelContent) - Used to get or set the text of axis label.
* [Position](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxisLabelEventArgs.html#Syncfusion_Maui_Charts_ChartAxisLabelEventArgs_Position) - Used to get the position of label.
* [LabelStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxisLabelEventArgs.html#Syncfusion_Maui_Charts_ChartAxisLabelEventArgs_LabelStyle) - Used to customize the appearance of axis labels.

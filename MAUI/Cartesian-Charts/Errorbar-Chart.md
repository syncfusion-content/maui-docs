---
layout: post
title: Error Bar Series Chart in .NET MAUI Chart Control | Syncfusion
description: Learn about Error Bar chart support in Syncfusion .NET MAUI Chart (SfCartesianChart) control here.
platform: maui
control: SfCartesianChart
documentation: ug
---

# Error Bar Series in .NET MAUI Chart

[ErrorBarSeries]() indicates the errors or uncertainty in reported values. This will find the possible variations in measurements, and in Chart control these values are displayed as data points.
The [HorizontalErrorValue]() and the [VerticalErrorValue]() is used to set the error value(variation) to the series.

N> The Error Bar Series Chart is not an individual Chart, it associate with a main Chart. Here, we use Scatter Series Chart as Main Chart with the Error Bar Series Chart Support

The following code examples illustrates how to create error bar series:
{% tabs %}

{% highlight xaml %}

    <chart:SfCartesianChart>

    <chart:SfCartesianChart.XAxes>
        <chart:CategoryAxis />
    </chart:SfCartesianChart.XAxes>

    <chart:SfCartesianChart.YAxes>
        <chart:NumericalAxis />
    </chart:SfCartesianChart.YAxes>   

     </chart:SfCartesianChart.YAxes>
            <chart:ScatterSeries ItemsSource="{Binding EnergyProductions}" 
                                 XBindingPath="ID" 
                                 YBindingPath="Coal"
                                 PointHeight="20"
                                 PointWidth="20">
            </chart:ScatterSeries>
            <chart:ErrorBarSeries ItemsSource="{Binding EnergyProductions}"
                                  XBindingPath="ID"
                                  YBindingPath="Coal"
                                  VerticalErrorValue="50"
                                  HorizontalErrorValue="0.5">
            </chart:ErrorBarSeries>

    </chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}


    ScatterSeries series = new ScatterSeries()
    {
        ItemsSource = new ViewModel().EnergyProductions,
        XBindingPath = "ID",
        YBindingPath = "Coal",
        PointWidth = 20,
        PointHeight = 20
    };

    ErrorBarSeries errorBar = new ErrorBarSeries()
    {
        ItemsSource = new ViewModel().EnergyProductions,
        XBindingPath = "ID",
        YBindingPath = "Coal",
        HorizontalErrorValue = 0.5,
        VerticalErrorValue = 50
    };

    chart.Series.Add(series);
    chart.Series.Add(errorBar);


{% endhighlight %}

{% endtabs %}

![Error Bar Series in MAUI Chart](Chart-types_images/BasicRenderingErrorBar.png)

## Mode 
This [Mode]() property defines whether to identify a horizontal error or vertical error. By default, the Mode value is [Both](), which will display both horizontal and vertical error values.

### Horizontal

To view horizontal error value, you can set the Mode as Horizontal as shown in the following code example.

{% tabs %}

{% highlight xaml %}

    <chart:ErrorBarSeries ItemsSource="{Binding EnergyProductions}"
                          XBindingPath="ID"
                          YBindingPath="Coal"
                          VerticalErrorValue="50"
                          HorizontalErrorValue="0.5"
                          Mode="Horizontal">
    </chart:ErrorBarSeries>

{% endhighlight %}

{% highlight c# %}

    ErrorBarSeries errorBar = new ErrorBarSeries()
    {
        ItemsSource = new ViewModel().EnergyProductions,
        XBindingPath = "ID",
        YBindingPath = "Coal",
        HorizontalErrorValue = 0.5,
        VerticalErrorValue = 50,
        Mode= Horizontal
    };
    chart.Series.Add(series);
    chart.Series.Add(errorBar);


{% endhighlight %}

{% endtabs %}

![Horizontal Mode Support in Error Bar Series](Chart-types_images/ModeHorizontal.png)


### Vertical

To view vertical error value, you can set the Mode as Vertical, as shown in the below code example.

{% tabs %}

{% highlight xaml %}

    <chart:ErrorBarSeries ItemsSource="{Binding EnergyProductions}"
                          XBindingPath="ID"
                          YBindingPath="Coal"
                          VerticalErrorValue="50"
                          HorizontalErrorValue="0.5"
                          Mode="Vertical">              
    </chart:ErrorBarSeries>

{% endhighlight %}

{% highlight c# %}

    ErrorBarSeries errorBar = new ErrorBarSeries()
    {
        ItemsSource = new ViewModel().EnergyProductions,
        XBindingPath = "ID",
        YBindingPath = "Coal",
        HorizontalErrorValue = 0.5,
        VerticalErrorValue = 50,
        Mode= Vertical
    };
    chart.Series.Add(series);
    chart.Series.Add(errorBar);



{% endhighlight %}

{% endtabs %}

![Vertical Mode Support in Error Bar Series](Chart-types_images/ModeVertical.png)


## Direction 

[ErrorBar]() series allows you to view the horizontal and vertical error values in both positive and negative directions.

### Horizontal Direction

[HorizontalDirection]() property of the [ErrorBarSeries]() allows you to view the horizontal error value in the following type of directions:

*`Both` -  It indicates the actual data point value along with specific amount of positive and negative error values.

*`Plus` -  It indicates the actual data point value along with specific amount of positive error value.

*`Minus`-  It indicates the actual data point value along with specific amount of negative error value.

#### Both

The following code illustrates how to set the [HorizontalDirection]() value as both.

{% tabs %}

{% highlight xaml %}

    <chart:ErrorBarSeries ItemsSource="{Binding EnergyProductions}"
                          XBindingPath="ID"
                          YBindingPath="Coal"
                          VerticalErrorValue="50"
                          HorizontalErrorValue="0.5"
                          HorizontalDirection="Both">
    </chart:ErrorBarSeries>

{% endhighlight %}

{% highlight c# %}

    ErrorBarSeries errorBar = new ErrorBarSeries()
    {
        ItemsSource = new ViewModel().EnergyProductions,
        XBindingPath = "ID",
        YBindingPath = "Coal",
        HorizontalErrorValue = 0.5,
        VerticalErrorValue = 50,
        HorizontalDirection="Both"
    };
    chart.Series.Add(series);
    chart.Series.Add(errorBar);


{% endhighlight %}

{% endtabs %}

![Horizontal Direction as Both in Error Bar Series](Chart-types_images/BasicRenderingErrorBar.png)

#### Plus

The following code illustrates how to set the [HorizontalDirection]() value as Plus.

{% tabs %}

{% highlight xaml %}

    <chart:ErrorBarSeries ItemsSource="{Binding EnergyProductions}"
                          XBindingPath="ID"
                          YBindingPath="Coal"
                          VerticalErrorValue="50"
                          HorizontalErrorValue="0.5"
                          HorizontalDirection="Plus">
    </chart:ErrorBarSeries>

{% endhighlight %}

{% highlight c# %}

    ErrorBarSeries errorBar = new ErrorBarSeries()
    {
        ItemsSource = new ViewModel().EnergyProductions,
        XBindingPath = "ID",
        YBindingPath = "Coal",
        HorizontalErrorValue = 0.5,
        VerticalErrorValue = 50,
        HorizontalDirection="Plus"
    };
    chart.Series.Add(series);
    chart.Series.Add(errorBar);


{% endhighlight %}

{% endtabs %}

![Horizontal Direction as Plus in Error Bar Series](Chart-types_images/HorDirectionPlus.png)

#### Minus

The following code illustrates how to set the [HorizontalDirection]() value as Minus.

{% tabs %}

{% highlight xaml %}

    <chart:ErrorBarSeries ItemsSource="{Binding EnergyProductions}"
                          XBindingPath="ID"
                          YBindingPath="Coal"
                          VerticalErrorValue="50"
                          HorizontalErrorValue="0.5"
                          HorizontalDirection="Minus">
    </chart:ErrorBarSeries>

{% endhighlight %}

{% highlight c# %}

    ErrorBarSeries errorBar = new ErrorBarSeries()
    {
        ItemsSource = new ViewModel().EnergyProductions,
        XBindingPath = "ID",
        YBindingPath = "Coal",
        HorizontalErrorValue = 0.5,
        VerticalErrorValue = 50,
        HorizontalDirection="Minus"
    };
    chart.Series.Add(series);
    chart.Series.Add(errorBar);


{% endhighlight %}

{% endtabs %}

![Horizontal Direction as Minus in Error Bar Series](Chart-types_images/HorDirectionMinus.png)

### Vertical Direction

[VerticalDirection]() property of the [ErrorBarSeries]() allows you to view the Vertical error value in the following type of directions:

*`Both` -  It indicates the actual data point value along with a specific amount of positive and negative error values.

*`Plus` -  It indicates the actual data point value along with a specific amount of positive error value.

*`Minus`-  It indicates the actual data point value along with a specific amount of negative error value.

#### Both

The following code illustrates how to set the [VerticalDirection]() value as both.

{% tabs %}

{% highlight xaml %}

    <chart:ErrorBarSeries ItemsSource="{Binding EnergyProductions}"
                          XBindingPath="ID"
                          YBindingPath="Coal"
                          VerticalErrorValue="50"
                          HorizontalErrorValue="0.5"
                          VerticalDirection="Both">  
    </chart:ErrorBarSeries>

{% endhighlight %}

{% highlight c# %}

    ErrorBarSeries errorBar = new ErrorBarSeries()
    {
        ItemsSource = new ViewModel().EnergyProductions,
        XBindingPath = "ID",
        YBindingPath = "Coal",
        HorizontalErrorValue = 0.5,
        VerticalErrorValue = 50,
        VerticalDirection="Both"
    };
    chart.Series.Add(series);
    chart.Series.Add(errorBar);



{% endhighlight %}

{% endtabs %}

![Vertical Direction as Both in Error Bar Series](Chart-types_images/BasicRenderingErrorBar.png)

#### Plus

The following code illustrates how to set the [VerticalDirection]() value as Plus.

{% tabs %}

{% highlight xaml %}

    <chart:ErrorBarSeries ItemsSource="{Binding EnergyProductions}"
                          XBindingPath="ID"
                          YBindingPath="Coal"
                          VerticalErrorValue="50"
                          HorizontalErrorValue="0.5"
                          VerticalDirection="Plus">    
    </chart:ErrorBarSeries>

{% endhighlight %}

{% highlight c# %}

    ErrorBarSeries errorBar = new ErrorBarSeries()
    {
        ItemsSource = new ViewModel().EnergyProductions,
        XBindingPath = "ID",
        YBindingPath = "Coal",
        HorizontalErrorValue = 0.5,
        VerticalErrorValue = 50,
        VerticalDirection="Plus"
    };
    chart.Series.Add(series);
    chart.Series.Add(errorBar);



{% endhighlight %}

{% endtabs %}

![Vertical Direction as Plus in Error Bar Series](Chart-types_images/VerDirectionPlus.png)

#### Minus

The following code illustrates how to set the [VerticalDirection]() value as Minus.

{% tabs %}

{% highlight xaml %}

    <chart:ErrorBarSeries ItemsSource="{Binding EnergyProductions}"
                          XBindingPath="ID"
                          YBindingPath="Coal"
                          VerticalErrorValue="50"
                          HorizontalErrorValue="0.5"
                          VerticalDirection="Minus">
    </chart:ErrorBarSeries>

{% endhighlight %}

{% highlight c# %}

    ErrorBarSeries errorBar = new ErrorBarSeries()
    {
        ItemsSource = new ViewModel().EnergyProductions,
        XBindingPath = "ID",
        YBindingPath = "Coal",
        HorizontalErrorValue = 0.5,
        VerticalErrorValue = 50,
        VerticalDirection="Minus"
    };
    chart.Series.Add(series);
    chart.Series.Add(errorBar);



{% endhighlight %}

{% endtabs %}

![Vertical Direction as Minus in Error Bar Series](Chart-types_images/VerDirectionMinus.png)


## Type

SfCartesianChart supports the following type of error bar series.

*`Fixed`

*`Percentage`

*`Standard Error`

*`Standard Percentage`

N> The default error bar series Type is Fixed.

### Fixed

{% tabs %}

{% highlight xaml %}


    <chart:ErrorBarSeries ItemsSource="{Binding EnergyProductions}"
                          XBindingPath="ID"
                          YBindingPath="Coal"
                          VerticalErrorValue="50"
                          HorizontalErrorValue="0.5"
                          Type="Fixed">                             
    </chart:ErrorBarSeries>

{% endhighlight %}

{% highlight c# %}

ErrorBarSeries errorBar = new ErrorBarSeries()
{
    ItemsSource = new ViewModel().EnergyProductions,
    XBindingPath = "ID",
    YBindingPath = "Coal",
    HorizontalErrorValue = 0.5,
    VerticalErrorValue = 50,
    Type="Fixed"
};
chart.Series.Add(series);
chart.Series.Add(errorBar);


{% endhighlight %}

{% endtabs %}

![Fixed Type in Error Bar Series](Chart-types_images/BasicRenderingErrorBar.png)

### Percentage

{% tabs %}

{% highlight xaml %}

        <chart:ErrorBarSeries ItemsSource="{Binding EnergyProductions}"
                              XBindingPath="ID"
                              YBindingPath="Coal"
                              VerticalErrorValue="50"
                              HorizontalErrorValue="0.5"
                              Type="Percentage">
        </chart:ErrorBarSeries>

{% endhighlight %}

{% highlight c# %}

    ErrorBarSeries errorBar = new ErrorBarSeries()
    {
        ItemsSource = new ViewModel().EnergyProductions,
        XBindingPath = "ID",
        YBindingPath = "Coal",
        HorizontalErrorValue = 0.5,
        VerticalErrorValue = 50,
        Type="Percentage"
    };
    chart.Series.Add(series);
    chart.Series.Add(errorBar);


{% endhighlight %}

{% endtabs %}

![Percentage Type in Error Bar Series](Chart-types_images/TypePercentage.png)


### Standard Error

{% tabs %}

{% highlight xaml %}

    <chart:ErrorBarSeries ItemsSource="{Binding EnergyProductions}"
                          XBindingPath="ID"
                          YBindingPath="Coal"
                          VerticalErrorValue="50"
                          HorizontalErrorValue="0.5"
                          Type="StandardError">
    </chart:ErrorBarSeries>

{% endhighlight %}

{% highlight c# %}

    ErrorBarSeries errorBar = new ErrorBarSeries()
    {
        ItemsSource = new ViewModel().EnergyProductions,
        XBindingPath = "ID",
        YBindingPath = "Coal",
        HorizontalErrorValue = 0.5,
        VerticalErrorValue = 50,
        Type="StandardError"
    };
    chart.Series.Add(series);
    chart.Series.Add(errorBar);


{% endhighlight %}

{% endtabs %}

![Standard Error Type in Error Bar Series](Chart-types_images/TypeStandardError.png)

### Standard Deviation

{% tabs %}

{% highlight xaml %}

    <chart:ErrorBarSeries ItemsSource="{Binding EnergyProductions}"
                          XBindingPath="ID"
                          YBindingPath="Coal"
                          VerticalErrorValue="50"
                          HorizontalErrorValue="0.5"
                          Type="StandardDeviation">
    </chart:ErrorBarSeries>

{% endhighlight %}

{% highlight c# %}

    ErrorBarSeries errorBar = new ErrorBarSeries()
    {
        ItemsSource = new ViewModel().EnergyProductions,
        XBindingPath = "ID",
        YBindingPath = "Coal",
        HorizontalErrorValue = 0.5,
        VerticalErrorValue = 50,
        Type="StandardDeviation"
    };
    chart.Series.Add(series);
    chart.Series.Add(errorBar);


{% endhighlight %}

{% endtabs %}

![Standard Deviation Type in Error Bar Series](Chart-types_images/TypeStandardDeviation.png)

## Custom

If the Type is Custom, you have to bind the [HorizontalErrorPath]() and the [VerticalErrorPath]() as shown in the following code sample.

{% tabs %}

{% highlight xaml %}

    <chart:ErrorBarSeries ItemsSource="{Binding EnergyProductions}"
                          XBindingPath="ID"
                          YBindingPath="Coal"
                          VerticalErrorValue="50"
                          HorizontalErrorValue="0.5"
                          Type="Custom"
                          HorizontalErrorPath="HorizontalErrorValue"
                          VerticalErrorPath="VerticalErrorValue">
    </chart:ErrorBarSeries>

{% endhighlight %}

{% highlight c# %}

    ErrorBarSeries errorBar = new ErrorBarSeries()
    {
        ItemsSource = new ViewModel().EnergyProductions,
        XBindingPath = "ID",
        YBindingPath = "Coal",
        HorizontalErrorValue = 0.5,
        VerticalErrorValue = 50,
        Type="Custom",
        HorizontalErrorPath="HorizontalErrorValue",
        VerticalErrorPath="VerticalErrorValue"
    };
    
    chart.Series.Add(series);
    chart.Series.Add(errorBar);


{% endhighlight %}

{% endtabs %}

![Custom Type in Error Bar Series](Chart-types_images/TypeCustom.png)

## Customization

### Line Style

You can define the LineStyle for the error bar lines using the [HorizontalLineStyle]() and the [VerticalLineStyle]() properties as in the following code examples.

#### Horizontal Line Style

{% tabs %}

{% highlight xaml %}

    <chart:ErrorBarSeries.HorizontalLineStyle>
        <chart:ErrorBarLineStyle Stroke="Black"  StrokeThickness="2"  >
        </chart:ErrorBarLineStyle>
    </chart:ErrorBarSeries.HorizontalLineStyle>

{% endhighlight %}

{% highlight c# %}

    errorBarSeries.HorizontalLineStyle = new ErrorBarLineStyle()
    {
        Stroke = new SolidColorBrush(Colors.Red),
        StrokeThickness = 2
    };


{% endhighlight %}

{% endtabs %}

![Horizontal Line Style in Error Bar Series](Chart-types_images/HorLine.png)

#### Vertical Line Style

{% tabs %}

{% highlight xaml %}

    <chart:ErrorBarSeries.VerticalLineStyle>
        <chart:ErrorBarLineStyle Stroke="Black"  StrokeThickness="2"  >
        </chart:ErrorBarLineStyle>
    </chart:ErrorBarSeries.VerticalLineStyle>

{% endhighlight %}

{% highlight c# %}

    errorBarSeries.VerticalLineStyle = new ErrorBarLineStyle()
    {
        Stroke = new SolidColorBrush(Colors.Red),
        StrokeThickness = 2
    };


{% endhighlight %}

{% endtabs %}

![Vertical Line Style in Error Bar Series](Chart-types_images/VerLine.png)

### Cap Line Style

You can define the CapLineStyle for the error bar lines using the [HorizontalCapLineStyle]() and the[VerticalCapLineStyle]() properties as in the following code examples.

#### Horizontal Cap Line Style

{% tabs %}

{% highlight xaml %}

    <chart:ErrorBarSeries.HorizontalCapLineStyle>
        <chart:ErrorBarCapLineStyle Stroke="Black"  
                                    StrokeThickness="2"
                                    CapLineSize="1" >
         
        </chart:ErrorBarCapLineStyle>
    </chart:ErrorBarSeries.HorizontalCapLineStyle>

{% endhighlight %}

{% highlight c# %}

    errorBarSeries.HorizontalCapLineStyle = new ErrorBarCapLineStyle()
    {
        Stroke = new SolidColorBrush(Colors.Red),
        StrokeThickness = 2,
        CapLineSize= 1
    };


{% endhighlight %}

{% endtabs %}

![Horizontal Cap Line Style in Error Bar Series](Chart-types_images/HorCap.png)

#### Vertical Cap Line Style

{% tabs %}

{% highlight xaml %}

    <chart:ErrorBarSeries.VerticalCapLineStyle>
    <chart:ErrorBarCapLineStyle Stroke="Black"  
                                StrokeThickness="2" 
                                CapLineSize="1" >
    </chart:ErrorBarCapLineStyle>
    </chart:ErrorBarSeries.VerticalCapLineStyle>

{% endhighlight %}

{% highlight c# %}

    errorBarSeries.VerticalCapLineStyle = new ErrorBarCapLineStyle()
    {
        Stroke = new SolidColorBrush(Colors.Red),
        StrokeThickness = 2,
        CapLineSize= 1
    };


{% endhighlight %}

{% endtabs %}

![Vertical Cap Line Style in Error Bar Series](Chart-types_images/VerCap.png)

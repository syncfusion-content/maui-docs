---
layout: post
title: Plot band in .NET MAUI Chart control | Syncfusion
description: Learn here all about plot band and its features in Syncfusion .NET MAUI Chart (SfCartesianChart) control and more.
platform: maui
control: SfCartesianChart
documentation: ug
---

# Plot band in .NET MAUI Chart
A plot band, also known as a stripline, allows for shading specific regions or ranges in the plot area background at regular or custom intervals. It also provides options to customize the size of these bands. Text can be added to plot band and indicate the significance of each particular region.

## Plot band in category axis

Plot bands can be added to the category axis by specifying index values for the [Start]() parameter, which determines the beginning of the plot band, along with the specified [Size]().

{% tabs %}

{% highlight xaml %}

    <chart:SfCartesianChart>
        . . .
        <chart:SfCartesianChart.XAxes>
            <chart:CategoryAxis >
                <chart:CategoryAxis.PlotBands>
                    <chart:NumericalPlotBandCollection>
                        <chart:NumericalPlotBand Start="2" 
                                                 Size="2" 
                                                 Fill="Gray"/>
                    </chart:NumericalPlotBandCollection>
                </chart:CategoryAxis.PlotBands>
            </chart:CategoryAxis>
        </chart:SfCartesianChart.XAxes>

        <chart:SfCartesianChart.YAxes>
            <chart:NumericalAxis/>
        </chart:SfCartesianChart.YAxes>
        . . .
    </chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

    SfCartesianChart chart = new SfCartesianChart();
    . . .
    CategoryAxis categoryAxis = new CategoryAxis();
    NumericalPlotBandCollection numericalPlotBandCollection = new NumericalPlotBandCollection();
    NumericalPlotBand plotBand = new NumericalPlotBand
    {
        Start = 2,
        Size = 2,
        Fill = Color.Orange
    };
    numericalPlotBandCollection.Add(plotBand);
    categoryAxis.PlotBands= numericalPlotBandCollection;
    chart.XAxes.Add(categoryAxis);

    NumericalAxis secondaryAxis = new NumericalAxis();
    chart.YAxes.Add(secondaryAxis);
    ...

{% endhighlight %}

{% endtabs %}

![Plot band with category axis in MAUI Cartesian chart](Plotband_images/Category.png)


## Plot Band in Numerical axis

A plot band can be added to the numerical axis by specifying numerical values for the [Start]() parameter, determining the beginning of the plot band, along with the specified [Size]().

{% tabs %}

{% highlight xaml %}

    <chart:SfCartesianChart>
        . . .
        <chart:SfCartesianChart.XAxes>
            <chart:CategoryAxis/>
        </chart:SfCartesianChart.XAxes>

        <chart:SfCartesianChart.YAxes>
            <chart:NumericalAxis>
                <chart:NumericalPlotBandCollection>
                    <chart:NumericalAxis.PlotBands>
                        <chart:NumericalPlotBand Start="28" 
                                                 Size="10" 
                                            Fill="Orange"/>
                    </chart:NumericalAxis.PlotBands>
                </chart:NumericalPlotBandCollection>
            </chart:NumericalAxis>
        </chart:SfCartesianChart.YAxes>
        . . .
    </chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

    SfCartesianChart chart = new SfCartesianChart();
    . . .
    CategoryAxis primaryAxis = new CategoryAxis();
    chart.XAxes.Add(primaryAxis);

    NumericalAxis numericalAxis = new NumericalAxis();
    NumericalPlotBandCollection numericalPlotBandCollection = new NumericalPlotBandCollection();
    NumericalPlotBand plotBand = new NumericalPlotBand
    {
        Start = 28,
        Size = 10,
        Fill = Colors.Orange
    };

    numericalPlotBandCollection.Add(plotBand);
    numericalAxis.PlotBands = numericalPlotBandCollection;
    chart.YAxes.Add(numericalAxis);
    ...

{% endhighlight %}

{% endtabs %}

![Plot band with numerical axis in MAUI Cartesian chart](Plotband_images/Numerical.png)

## Plot band in DateTime axis

A plot band can be applied to a date-time axis by specifying the [Start]() date and [Size]() values. The start value determines the beginning of the plot band, along with the specified size. The [SizeType]() parameter determines which unit of measurement to use on the date-time axis.

{% tabs %}

{% highlight xaml %}

    <chart:SfCartesianChart>
        . . .
     <chart:SfCartesianChart.XAxes>
         <chart:DateTimeAxis>
          <chart:DateTimeAxis.PlotBands>
             <chart:DateTimePlotBandCollection >
                 <chart:DateTimePlotBand Start="2024-01-24"
                                         Size="2"
                                         SizeType="Days"
                                         Fill="Orange"/>
                    </chart:DateTimePlotBandCollection >
                </chart:DateTimeAxis.PlotBands>
            </chart:DateTimeAxis>
        </chart:SfCartesianChart.XAxes>

        <chart:SfCartesianChart.YAxes>
            <chart:NumericalAxis/>
        </chart:SfCartesianChart.YAxes>
    </chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

    SfCartesianChart chart = new SfCartesianChart();
    . . .
    DateTimeAxis dateTimeAxis = new DateTimeAxis();
    DateTimePlotBandCollection dateTimePlotBandCollection = new DateTimePlotBandCollection();
    DateTimePlotBand plotBand = new DateTimePlotBand
    {
        Start = new DateTime(2024, 1, 24),
        Size = 2,
        WidthType = DateTimeUnits.Days,
        Fill = Color.Orange
    };

    dateTimePlotBandCollection.Add(plotBand);
    dateTimeAxis.PlotBands = dateTimePlotBandCollection;
    chart.XAxes.Add(dateTimeAxis);

    NumericalAxis secondaryAxis = new NumericalAxis();
    chart.YAxes.Add(secondaryAxis);
    ...

{% endhighlight %}

{% endtabs %}

![Plot band with numerical axis in MAUI Cartesian chart](Plotband_images/)

## Plot Band Recurrence

The Plot band recurrence feature enables plot bands to be drawn repeatedly at regular intervals. This functionality is particularly useful when you need to mark events that occur recursively along the timeline of the chart.

* [`RepeatEvery`]() - Specifies the frequency at which the plot band is repeated.
* [`RepeatUntil`]() - Specifies the end value at which the strip line stops repeating.

{% tabs %}

{% highlight xaml %}

    <chart:SfCartesianChart>
        . . .
        <chart:SfCartesianChart.XAxes>
            <chart:CategoryAxis/>
        </chart:SfCartesianChart.XAxes>

        <chart:SfCartesianChart.YAxes>
          <chart:NumericalAxis>
           <chart:NumericalAxis.PlotBands>
               <chart:NumericalPlotBandCollection>
                   <chart:NumericalPlotBand Start="28"  
                                            Size="2" 
                                            Fill="Orange"
                                            RepeatEvery="10" 
                                            RepeatUntil="55"/>
                    </chart:NumericalPlotBandCollection>
                </chart:NumericalAxis.PlotBands>
            </chart:NumericalAxis>
        </chart:SfCartesianChart.YAxes>
    </chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

    SfCartesianChart chart = new SfCartesianChart();
    . . .
    CategoryAxis primaryAxis = new CategoryAxis();
    chart.XAxes.Add(primaryAxis);

    NumericalAxis numericalAxis = new NumericalAxis();
    NumericalPlotBandCollection numericalPlotBandCollection = new NumericalPlotBandCollection();
    NumericalPlotBand plotBand = new NumericalPlotBand
    {
        Start = 28,
        Size = 2,
        Fill = Color.Orange,
        RepeatEvery = 10,
        RepeatUntil = 55
    };

    numericalPlotBandCollection.Add(plotBand);
    numericalAxis.PlotBands = numericalPlotBandCollection;
    chart.YAxes.Add(numericalAxis);
    ...

{% endhighlight %}

{% endtabs %}

![Visualize plot band recurrence in .NET MAUI](StripLines_Images/Reaccurence.png)

## Segmented Plot Band

To create a plot band that doesn't stretch along its associated axis, set the [AssociatedAxisStart]() and [AssociatedAxisEnd]() properties. Then, based on these values,the plot band should be drawn as a segment and set the [IsSegmented]() property to `true`.


{% tabs %}

{% highlight xaml %}

    <chart:SfCartesianChart>
        . . .
    <chart:SfCartesianChart.XAxes>
       <chart:CategoryAxis/>
     </chart:SfCartesianChart.XAxes>

    <chart:SfCartesianChart.YAxes>
      <chart:NumericalAxis>
         <chart:NumericalAxis.PlotBands>
             <chart:NumericalPlotBandCollection>
                  <chart:NumericalPlotBand Start="28" 
                                           Size="2"
                                           RepeatEvery="10" 
                                           RepeatUntil="55" 
                                           Fill="Orange"
                                           IsSegmented="True" 
                                     AssociatedAxisStart="0"
                                     AssociatedAxisEnd="1"/>
                    </chart:NumericalPlotBandCollection>
                </chart:NumericalAxis.PlotBands>
            </chart:NumericalAxis>
        </chart:SfCartesianChart.YAxes>
        . . .
    </chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

    SfCartesianChart chart = new SfCartesianChart();
    . . .
    CategoryAxis primaryAxis = new CategoryAxis();
    chart.XAxes.Add(primaryAxis);

    NumericalAxis numericalAxis = new NumericalAxis();
    NumericalPlotBandCollection numericalPlotBandCollection =  new NumericalPlotBandCollection();
    NumericalPlotBand plotBand = new NumericalPlotBand
    {
        Start = 28,
        Size = 2,
        RepeatEvery = 10,
        RepeatUntil = 55,
        Fill = Color.Orange,
        IsSegmented = true,
        AssociatedAxisStart = 0,
        AssociatedAxisEnd = 1
    };

    numericalPlotBandCollection.Add(plotBand);
    numericalAxis.PlotBands = numericalPlotBandCollection;
    chart.YAxes.Add(numericalAxis);
    ...

{% endhighlight %}

{% endtabs %}

![Visualize segmented plot band in .NET MAUI](StripLines_Images/segmented.png)

## Customized Text

[Text]() can be added to plot bands to indicate the significance of each particular region. The [LabelStyle]() property provides options to customize plot band text.

{% tabs %}

{% highlight xaml %}

    <chart:SfCartesianChart>
        . . .
     <chart:SfCartesianChart.XAxes>
       <chart:CategoryAxis/>
      </chart:SfCartesianChart.XAxes>

      <chart:SfCartesianChart.YAxes>
        <chart:NumericalAxis>
          <chart:NumericalAxis.PlotBands>
            <chart:NumericalPlotBandCollection>
             <chart:NumericalPlotBand Start="28" 
                                      Size="10" 
                                      Fill="Orange"
                                      Text="Plot Band">
              <chart:NumericalPlotBand.LabelStyle>
               <chart:ChartPlotBandLabelStyle TextColor="Blue"
                                              FontSize="12" 
                                     FontAttributes="Bold"/>
              </chart:NumericalPlotBand.LabelStyle>
           </chart:NumericalPlotBandCollection>
         </chart:NumericalAxis.PlotBands>
       </chart:NumericalAxis>
     </chart:SfCartesianChart.YAxes>
        . . .
    </chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

    SfCartesianChart chart = new SfCartesianChart();
    . . .
    CategoryAxis primaryAxis = new CategoryAxis();
    chart.XAxes.Add(primaryAxis);

    NumericalAxis numericalAxis = new NumericalAxis();
    NumericalPlotBandCollection numericalPlotBandCollection = new NumericalPlotBandCollection();
    NumericalPlotBand plotBand = new NumericalPlotBand
    {
        Start = 28,
        Width = 10,
        Fill = Color.Orange,
        Text = "Plot Band"
    };

    ChartPlotBandLabelStyle labelStyle = new ChartPlotBandLabelStyle
    {
        TextColor = Color.Blue,
        FontSize = 12,
        FontAttributes = FontAttributes.Bold
    };

    plotBand.LabelStyle = labelStyle;
    numericalPlotBandCollection.Add(plotBand);
    numericalAxis.PlotBands= numericalPlotBandCollection;
    chart.YAxes.Add(numericalAxis);
    ...

{% endhighlight %}

{% endtabs %}
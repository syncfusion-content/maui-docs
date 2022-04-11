---
layout: post
title: Migration from Xamarin to .NET MAUI Chart control | Syncfusion
description: Learn here all about migration from Syncfusion Xamarin SfChart to .NET MAUI Chart (SfCartesianChart) control.
platform: maui
control: SfCartesianChart
documentation: ug
---

# Migrating from SfChart to SfCartesianChart

This section explains how to migrate the Xamarin SfChart to MAUI SfCartesianChart control. and this section helps you to identify equivalent Chart features/ APIs in SfCartesianChart.

## Adding Reference

SfChart assembly Name: Syncfusion.SfChart.XForms assembly

SfCartesianChart assembly Name: Syncfusion.Maui.Charts assembly

To initialize the control, import the Chart namespace and Initialize [SfCartesianChart](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html?tabs=tabid-1) as per the following code snippet. 

{% tabs %} 

{% highlight xaml %}

<ContentPage
    . . .    
    xmlns:chart="clr-namespace:Syncfusion.Maui.Charts;assembly=Syncfusion.Maui.Charts">
    <Grid>
        <chart:SfCartesianChart/>
    </Grid>
</ContentPage>
 
{% endhighlight %}

{% highlight C# %}

using Syncfusion.Maui.Charts;
namespace ChartGettingStarted
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();           
            SfCartesianChart chart = new SfCartesianChart(); 
        }
    }   
}

{% endhighlight %}

{% endtabs %}

## Code snippet

### SfChart

Following code example illustrates the initialization of SfChart.

{% tabs %} 

{% highlight xaml %}

<ContentPage xmlns:chart="clr-namespace:Syncfusion.SfChart.XForms;assembly=Syncfusion.SfChart.XForms"
             xmlns="http://xamarin.com/schemas/2014/forms"
             xmlns:local="clr-namespace: ChartGettingStarted;assembly=ChartGettingStarted"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             x:Class="ChartGettingStarted.ChartSample">

  <chart:SfChart x:Name="Chart" HorizontalOptions="FillAndExpand" VerticalOptions="FillAndExpand">

    <chart:SfChart.BindingContext>
      <local:ViewModel/>
    </chart:SfChart.BindingContext>

    <chart:SfChart.Legend>
      <chart:ChartLegend />
    </chart:SfChart.Legend>

    <chart:SfChart.Title>
      <chart:ChartTitle Text="Chart"/>
    </chart:SfChart.Title>

    <chart:SfChart.PrimaryAxis>
      <chart:CategoryAxis>
        <chart:CategoryAxis.Title>
          <chart:ChartAxisTitle Text="Name"/>
        </chart:CategoryAxis.Title>
      </chart:CategoryAxis>
    </chart:SfChart.PrimaryAxis>

    <chart:SfChart.SecondaryAxis>
      <chart:NumericalAxis>
        <chart:NumericalAxis.Title>
          <chart:ChartAxisTitle Text="Height (in cm)"/>
        </chart:NumericalAxis.Title>
      </chart:NumericalAxis>
    </chart:SfChart.SecondaryAxis>

    <chart:SfChart.Series>
      <chart:ColumnSeries ItemsSource="{Binding Data}" Label="Heights" XBindingPath="Name" YBindingPath="Height" EnableTooltip="True">
        <chart:ColumnSeries.DataMarker>
          <chart:ChartDataMarker/>
        </chart:ColumnSeries.DataMarker>
      </chart:ColumnSeries>
    </chart:SfChart.Series>
  </chart:SfChart>

</ContentPage>

{% endhighlight %}

{% highlight C# %}


using Syncfusion.SfChart.XForms;

namespace ChartGettingStarted
{
    public partial class ChartSample : ContentPage
    {
        public ChartSample()
        {
            InitializeComponent();
            SfChart chart = new SfChart();
            chart.Title.Text = "Chart";

            ViewModel viewmodel = new ViewModel()
            chart.BindingContext = viewmodel;

            //Initializing primary axis
            CategoryAxis primaryAxis = new CategoryAxis();
            primaryAxis.Title.Text = "Name";
            chart.PrimaryAxis = primaryAxis;

            //Initializing secondary Axis
            NumericalAxis secondaryAxis = new NumericalAxis();
            secondaryAxis.Title.Text = "Height (in cm)";
            chart.SecondaryAxis = secondaryAxis;

            //Initializing column series
            ColumnSeries series = new ColumnSeries();
            series.ItemsSource = viewModel.Data;
            series.XBindingPath = "Name";
            series.YBindingPath = "Height";
            series.Label = "Heights";

            series.DataMarker = new ChartDataMarker();
            series.EnableTooltip = true;
            chart.Legend = new ChartLegend();

            chart.Series.Add(series);
            this.Content = chart;

        }
    }
}

{% endhighlight %}

{% endtabs %}

### SfCartesianChart

Following code example illustrates the initialization of SfCartesianChart that is equivalent to the above SfChart code example.

{% tabs %} 

{% highlight xaml %}

<ContentPage
    xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
    xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
    x:Class="ChartGettingStarted.MainPage"
    xmlns:chart="clr-namespace:Syncfusion.Maui.Charts;assembly=Syncfusion.Maui.Charts"
    xmlns:local="clr-namespace:ChartGettingStarted">

    <ContentPage.BindingContext>
    <local:ViewModel></local:ViewModel>
    </ContentPage.BindingContext>

    <ContentPage.Content>
        <Grid>
            <chart:SfCartesianChart>
                <chart:SfCartesianChart.Title>
                    <Label Text="Height Comparison"/>
                </chart:SfCartesianChart.Title>

                <chart:SfCartesianChart.Legend>
                    <chart:ChartLegend/>
                </chart:SfCartesianChart.Legend>
    
                <chart:SfCartesianChart.XAxes>
                    <chart:CategoryAxis>
                        <chart:CategoryAxis.Title>
                            <chart:ChartAxisTitle Text="Name"/>
                        </chart:CategoryAxis.Title>
                    </chart:CategoryAxis>
                </chart:SfCartesianChart.XAxes>

                <chart:SfCartesianChart.YAxes>
                    <chart:NumericalAxis>
                        <chart:NumericalAxis.Title>
                            <chart:ChartAxisTitle Text="Height(in cm)"/>
                        </chart:NumericalAxis.Title>
                    </chart:NumericalAxis>
                </chart:SfCartesianChart.YAxes>

            <!--Initialize the series for chart-->
                <chart:SfCartesianChart.Series>
                    <chart:ColumnSeries Label="Height" 
                            EnableTooltip="True"
                            ShowDataLabels="True"
                            ItemsSource="{Binding Data}"
                            XBindingPath="Name" 
                            YBindingPath="Height">
                        <chart:ColumnSeries.DataLabelSettings>
                            <chart:CartesianDataLabelSettings LabelPlacement="Inner"/>
                        </chart:ColumnSeries.DataLabelSettings>
                    </chart:ColumnSeries>
                </chart:SfCartesianChart.Series>
            </chart:SfCartesianChart>
        </Grid>
    </ContentPage.Content>
</ContentPage>
 
{% endhighlight %}

{% highlight C# %}

using Syncfusion.Maui.Charts;
namespace ChartGettingStarted
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();            
            SfCartesianChart chart = new SfCartesianChart();
            ViewModel viewmodel = new ViewModel()
            chart.BindingContext = viewmodel;

            chart.Title = new Label
            {
                Text = "Height Comparison"
            };

            // Initializing primary axis
            CategoryAxis primaryAxis = new CategoryAxis();
            primaryAxis.Title.Text = "Name";
            chart.XAxes.Add(primaryAxis);

            //Initializing secondary Axis
            NumericalAxis secondaryAxis = new NumericalAxis();
            secondaryAxis.Title.Text = "Height(in cm)";
            chart.YAxes.Add(secondaryAxis);

            //Initialize the series for Chart
            ColumnSeries series = new ColumnSeries()
            {
                Label = "Height",
                ShowDataLabels = true,
                ItemsSource = viewmodel.Data,
                XBindingPath = "Name",
                YBindingPath = "Height",
                DataLabelSettings = new CartesianDataLabelSettings
                {
                    LabelPlacement = DataLabelPlacement.Inner
                }              
            };  

            //Adding Series to the Chart Series Collection
            chart.Series.Add(series);
            this.Content = chart;
        }
    }   
}

{% endhighlight %}

{% endtabs %}


### Register the handler

You must register the handler to deploy the SfCartesianChart, otherwise application throws exception. Syncfusion.Maui.Core nuget is a dependent package for all Syncfusion controls of .NET MAUI. In the MauiProgram.cs file, register the handler for Syncfusion core.

{% highlight C# %}

using Microsoft.Maui;
using Microsoft.Maui.Hosting;
using Microsoft.Maui.Controls.Compatibility;
using Microsoft.Maui.Controls.Hosting;
using Microsoft.Maui.Controls.Xaml;
using Syncfusion.Maui.Core.Hosting;

namespace ChartGettingStarted
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
            .UseMauiApp<App>()
            .ConfigureSyncfusionCore()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
            });

            return builder.Build();
        }
    }
}


{% endhighlight %} 

The following table illustrates the API comparison for chart,

<table>
<tr>
<th>Xamarin</th>
<th>MAUI</th>
</tr>
<tr>
<td>Title</td>
<td>Title</td>
</tr>
<tr>
<td>Legend</td>
<td>Legend</td>
</tr>

<tr>
<td>Series</td>
<td>Series</td>
</tr>
<tr>
<td>PrimaryAxis</td>
<td>XAxes</td>
</tr>
<tr>
<td>SecondaryAxis</td>
<td>YAxes</td>
</tr>
<tr>
<td>SideBySideSeriesPlacement</td>
<td>EnableSideBySideSeriesPlacement</td>
</tr>
<tr>
<td>-</td>
<td>IsTransposed</td>
</tr>
<tr>
<td>EnableTooltip</td>
<td>EnableTooltip</td>
</tr>
<tr>
<td>ColorModel</td>
<td>PaletteBrushes</td>
</tr>
<tr>
<td>ChartBehaviors</td>
<td>TooltipBehavior, SelectionBehavior, ZoomPanBehavior</td>
</tr>
</table>

## Series

Mostly the same code are used to initialize the chart series in both SfChart and SfCartesianChart. You can create the instance of required series in SfChart as in the following code example.

<table>
<tr>
<th>Xamarin</th>
<th>MAUI</th>
</tr>
<tr>
<td>
<chart:SfChart>
   <chart:SfChart.PrimaryAxis>
        <chart:CategoryAxis>
            <chart:CategoryAxis.Title>
                  <chart:ChartAxisTitle Text="Name" />
            </chart:CategoryAxis.Title>
         </chart:CategoryAxis>
   </chart:SfChart.PrimaryAxis>

   <chart:SfChart.SecondaryAxis>
       <chart:NumericalAxis>
           <chart:NumericalAxis.Title>
                 <chart:ChartAxisTitle Text="Height (in cm)"/>
          </chart:NumericalAxis.Title>      
      </chart:NumericalAxis>   
     </chart:SfChart.SecondaryAxis>
    
    <chart:SfChart.Series>
         <chart:ColumnSeries ItemsSource="{Binding Data}" XBindingPath="Name" YBindingPath="Height">
		 </chart:ColumnSeries>
    </chart:SfChart.Series>
 </chart:SfChart>

</td>

<td>
<chart:SfCartesianChart>
    <chart:SfCartesianChart.XAxes>
        <chart:CategoryAxis>
            <chart:CategoryAxis.Title>
                <chart:ChartAxisTitle Text="Name" />
            </chart:CategoryAxis.Title>
        </chart:CategoryAxis>
    </chart:SfCartesianChart.XAxes>

    <chart:SfCartesianChart.YAxes>
        <chart:NumericalAxis>
            <chart:NumericalAxis.Title>
                <chart:ChartAxisTitle Text="Height(in cm)" />
            </chart:NumericalAxis.Title>
        </chart:NumericalAxis>
    </chart:SfCartesianChart.YAxes>

    <chart:SfCartesianChart.Series>
        <chart:ColumnSeries ItemsSource="{Binding Data}" 
                            XBindingPath="Name" 
                            YBindingPath="Height">
        </chart:ColumnSeries>
    </chart:SfCartesianChart.Series>
</chart:SfCartesianChart>
</td>
</tr>
</table>

The following table illustrates the API comparison for series,

<table>
<tr>
<th>Xamarin</th>
<th>MAUI</th>
</tr>
<tr>
<td>ItemsSource</td>
<td>ItemsSource</td>
</tr>
<tr>
<td>XBindingPath</td>
<td>XBindingPath</td>
</tr>
<tr>
<td>Color</td>
<td>Fill</td>
</tr>
<tr>
<td>ColorModel</td>
<td>PaletteBrushes</td>
</tr>
<tr>
<td>IsVisible</td>
<td>IsVisible</td>
</tr>
<tr>
<td>Opacity</td>
<td>Opacity</td>
</tr>
<tr>
<td>EnableAnimation</td>
<td>EnableAnimation</td>
</tr>
<tr>
<td>EnableTooltip</td>
<td>EnableTooltip</td>
</tr>
<tr>
<td>TooltipTemplate</td>
<td>TooltipTemplate</td>
</tr>
<tr>
<td>SelectedDataPointColor</td>
<td>SelectionBrush</td>
</tr>
<tr>
<td>SelectedIndex</td>
<td>SelectedIndex</td>
</tr>
<tr>
<td>DataMarker</td>
<td>ShowDataLabels, DataLabelSettings</td>
</tr>
<tr>
<td>LegendIcon</td>
<td>LegendIcon</td>
</tr>
<tr>
<td>IsVisibleOnLegend</td>
<td>IsVisibleOnLegend</td>
</tr>
<tr>
<td>-</td>
<td>XRange</td>
</tr>
<tr>
<td>-</td>
<td>YRange</td>
</tr>
</table>


## Axis

<table>
<tr>
<th>Xamarin</th>
<th>MAUI</th>
</tr>
<tr>
<td>
<chart:SfChart>  
    <chart:SfChart.PrimaryAxis>
	     <chart:NumericalAxis/>
    </chart:SfChart.PrimaryAxis>

    <chart:SfChart.SecondaryAxis>
	     <chart:NumericalAxis/>
    </chart:SfChart.SecondaryAxis>
</chart:SfChart>
</td>
<td>
<chart:SfCartesianChart>                            
    <chart:SfCartesianChart.XAxes>
        <chart:NumericalAxis/>
    </chart:SfCartesianChart.XAxes>
    
    <chart:SfCartesianChart.YAxes>
        <chart:NumericalAxis/>
    </chart:SfCartesianChart.YAxes>                       
</chart:SfCartesianChart>
</td>
</tr>
</table>

The following table illustrates the API comparison for `ChartAxis` class,

<table>
<tr>
<th>Xamarin</th>
<th>MAUI</th>
</tr>
<tr>
<td>IsVisible</td>
<td>IsVisible</td>
</tr>
<tr>
<td>PlotOffsetStart</td>
<td>PlotOffsetStart</td>
</tr>
<tr>
<td>PlotOffsetEnd</td>
<td>PlotOffsetEnd</td>
</tr>
<tr>
<td>AxisLineOffset</td>
<td>AxisLineOffset</td>
</tr>
<tr>
<td>LabelRotationAngle</td>
<td>LabelRotation</td>
</tr>
<tr>
<td>LabelStyle</td>
<td>LabelStyle</td>
</tr>
<tr>
<td>AxisLineStyle</td>
<td>AxisLineStyle</td>
</tr>
<tr>
<td>CrossesAt</td>
<td>CrossesAt</td>
</tr>
<tr>
<td>RenderNextToCrossingValue</td>
<td>RenderNextToCrossingValue</td>
</tr>
<tr>
<td>-</td>
<td>CrossAxisName</td>
</tr>
<tr>
<td>Name</td>
<td>Name</td>
</tr>
<tr>
<td>Title</td>
<td>Title</td>
</tr>
<tr>
<td>IsInversed</td>
<td>IsInversed</td>
</tr>
<tr>
<td>EdgeLabelsDrawingMode</td>
<td>EdgeLabelsDrawingMode</td>
</tr>
<tr>
<td>MajorGridLineStyle</td>
<td>MajorGridLineStyle</td>
</tr>
<tr>
<td>MajorTickStyle</td>
<td>MajorTickStyle</td>
</tr>
<tr>
<td>ZoomPosition</td>
<td>ZoomPosition</td>
</tr>
<tr>
<td>ZoomFactor</td>
<td>ZoomFactor</td>
</tr>
<tr>
<td>ShowMajorGridLines</td>
<td>ShowMajorGridLines</td>
</tr>
<tr>
<td>EnableAutoIntervalOnZooming</td>
<td>EnableAutoIntervalOnZooming</td>
</tr>
<tr>
<td>LabelCreated</td>
<td>LabelCreated</td>
</tr>
<tr>
<td>ActualRangeChanged</td>
<td>ActualRangeChanged</td>
</tr>
<tr>
<td>LabelClicked</td>
<td>-</td>
</tr>
<tr>
<td>VisibleMinimum</td>
<td>-</td>
</tr>
<tr>
<td>VisibleMaximum</td>
<td>-</td>
</tr>
<tr>
<td>VisibleLabels</td>
<td>-</td>
</tr>
<tr>
<td>TickPosition</td>
<td>-</td>
</tr>
<tr>
<td>MaximumLabels</td>
<td>-</td>
</tr>
<tr>
<td>PlotOffset</td>
<td>-</td>
</tr>
<tr>
<td>LabelsIntersectAction</td>
<td>-</td>
</tr>
<tr>
<td>AutoScrollingMode</td>
<td>-</td>
</tr>
<tr>
<td>LabelExtent</td>
<td>-</td>
</tr>
<tr>
<td>RangeStyles</td>
<td>-</td>
</tr>
<tr>
<td>OpposedPosition</td>
<td>CrossesAt</td>
</tr>
<tr>
<td>IsVertical</td>
<td>-</td>
</tr>
<tr>
<td>ShowTrackballInfo</td>
<td>-</td>
</tr>
<tr>
<td>TrackballLabelStyle</td>
<td>-</td>
</tr>
<tr>
<td>AutoScrollingDelta</td>
<td>-</td>
</tr>
<tr>
<td>TrackballLabelTemplate</td>
<td>-</td>
</tr>
</table>

The following table illustrates the API comparison for `CategoryAxis` class,

<table>
<tr>
<th>Xamarin</th>
<th>MAUI</th>
</tr>
<tr>
<td>LabelPlacement</td>
<td>LabelPlacement</td>
</tr>
<tr>
<td>Interval</td>
<td>Interval</td>
</tr>
<tr>
<td>StripLines</td>
<td>-</td>
</tr>
<tr>
<td>ArrangeByIndex</td>
<td>-</td>
</tr>
</table>

The following table illustrates the API comparison for `NumericalAxis` class,

<table>
<tr>
<th>Xamarin</th>
<th>MAUI</th>
</tr>
<tr>
<td>Interval</td>
<td>Interval</td>
</tr>
<tr>
<td>Minimum</td>
<td>Minimum</td>
</tr>
<tr>
<td>Maximum</td>
<td>Maximum</td>
</tr>
<tr>
<td>RangePadding</td>
<td>RangePadding</td>
</tr>
<tr>
<td>StripLines</td>
<td>-</td>
</tr>
</table>

The following table illustrates the API comparison for `DateTimeAxis` class,

<table>
<tr>
<th>Xamarin</th>
<th>MAUI</th>
</tr>
<tr>
<td>Interval</td>
<td>Interval</td>
</tr>
<tr>
<td>IntervalType</td>
<td>IntervalType</td>
</tr>
<tr>
<td>Minimum</td>
<td>Minimum</td>
</tr>
<tr>
<td>Maximum</td>
<td>Maximum</td>
</tr>
<tr>
<td>RangePadding</td>
<td>RangePadding</td>
</tr>
<tr>
<td>StripLines</td>
<td>-</td>
</tr>
<tr>
<td>AutoScrollingDeltaType</td>
<td>-</td>
</tr>
</table>

## Legend

The following code example shows how to enable legend in chart.

<table>
<tr>
<th>Xamarin</th>
<th>MAUI</th>
</tr>
<tr>
<td>
<chart:SfChart>
    <chart:SfChart.Legend>
		<chart:ChartLegend/>
	</chart:SfChart.Legend>
</chart:SfChart>
</td>
<td>
<chart:SfCartesianChart>
    <chart:SfCartesianChart.Legend>
		<chart:ChartLegend/>
	</chart:SfCartesianChart.Legend>
</chart:SfCartesianChart>
</td>
</tr>
</table>

The following table illustrates the API comparison between SfChart and SfCartesianChart.

<table>
<tr>
<th>Xamarin</th>
<th>MAUI</th>
</tr>
<tr>
<td>ToggleSeriesVisibility</td>
<td>ToggleSeriesVisibility</td>
</tr>
<tr>
<td>DockPosition</td>
<td>Placement</td>
</tr>
<tr>
<td>IsVisible</td>
<td>IsVisible</td>
</tr>
<tr>
<td>Title</td>
<td>-</td>
</tr>
<tr>
<td>Series</td>
<td>-</td>
</tr>
<tr>
<td>BackgroundColor</td>
<td>-</td>
</tr>
<tr>
<td>StrokeColor</td>
<td>-</td>
</tr>
<tr>
<td>StrokeWidth</td>
<td>-</td>
</tr>
<tr>
<td>StrokeDashArray</td>
<td>-</td>
</tr>
<tr>
<td>CornerRadius</td>
<td>-</td>
</tr>
<tr>
<td>Margin</td>
<td>-</td>
</tr>
<tr>
<td>LabelStyle</td>
<td>-</td>
</tr>
<tr>
<td>ItemTemplate</td>
<td>-</td>
</tr>
<tr>
<td>OverflowMode</td>
<td>-</td>
</tr>
<tr>
<td>MaxWidth</td>
<td>-</td>
</tr>
<tr>
<td>Orientation</td>
<td>-</td>
</tr>
<tr>
<td>IsIconVisible</td>
<td>-</td>
</tr>
<tr>
<td>ItemMargin</td>
<td>-</td>
</tr>
<tr>
<td>IconWidth</td>
<td>-</td>
</tr>
<tr>
<td>IconHeight</td>
<td>-</td>
</tr>
<tr>
<td>OffsetX</td>
<td>-</td>
</tr>
tr>
<td>OffsetY</td>
<td>-</td>
</tr>
</table>

## Data Label

<table>
<tr>
<th>Xamarin</th>
<th>MAUI</th>
</tr>
<tr>
<td>
<chart:SfChart>  
     . . .
    <chart:ColumnSeries>
	    <chart:ColumnSeries.DataMarker>
	        <chart:ChartDataMarker/>
	    </chart:ColumnSeries.DataMarker>
    </chart:ColumnSeries>
</chart:SfChart>
</td>
<td>
<chart:SfCartesianChart>
    . . .
    <chart:SfCartesianChart.Series>
        <chart:ColumnSeries ItemsSource="{Binding Data}" 
                        XBindingPath="Category"
                        YBindingPath="Value" ShowDataLabels="True">
        </chart:ColumnSeries>
    </chart:SfCartesianChart.Series>
</chart:SfCartesianChart>
</td>
</tr>
</table>

## Interactive features

### Tooltip

<table>
<tr>
<th>Xamarin</th>
<th>MAUI</th>
</tr>
<tr>
<td>
<chart:SfChart>
. . . 
    <chart:SfChart.ChartBehaviors>
	      <chart:ChartTooltipBehavior BackgroundColor="Blue" TextColor="White" 
               Margin="5" FontSize="15"/>
    </chart:SfChart.ChartBehaviors>
    
    <chart:ColumnSeries ItemsSource="{Binding Data}" 
                        XBindingPath="Demand"
                        YBindingPath="Year2010"
                        EnableTooltip="True"/>
</chart:SfChart>
</td>
<td>
<chart:SfCartesianChart>
. . .
   <chart:SfCartesianChart.TooltipBehavior>
        <chart:ChartTooltipBehavior Background="Blue" TextColor="White" 
              Margin="5" FontSize="15"/>
   </chart:SfCartesianChart.TooltipBehavior>

   <chart:ColumnSeries ItemsSource="{Binding Data}" 
                        XBindingPath="Demand"
                        YBindingPath="Year2010"
                        EnableTooltip="True"/>
</chart:SfCartesianChart>
</td>
</tr>
</table>

To Customize the tooltip appearance, create an instance of the `ChartTooltipBehavior` class and add it to the  `ChartBehaviors` collection of `SfChart`. For `SfCartesianChart`, you can directly set the `ChartTooltipBehavior` instance to the [TooltipBehavior](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartBase.html#Syncfusion_Maui_Charts_ChartBase_TooltipBehavior) property as per the above code snippet.

### Selection

<table>
<tr>
<th>Xamarin</th>
<th>MAUI</th>
</tr>
<tr>
<td>
<chart:SfChart>
...
	<chart:SfChart.ChartBehaviors>
            <local:ChartSelectionBehavior/>
    </chart:SfChart.ChartBehaviors>

    <chart:ColumnSeries EnableDataPointSelection="True" SelectedDataPointIndex="2" SelectedDataPointColor="Red" ItemsSource ="{Binding Data}" />
</chart:SfChart>
</td>
<td>
<chart:SfCartesianChart>
. . .
    <chart:SfCartesianChart.SelectionBehavior>
        <chart:ChartSelectionBehavior />
    </chart:SfCartesianChart.SelectionBehavior>

    <chart:ColumnSeries SelectionBrush="Green" ItemsSource="{Binding Data}" XBindingPath="Demand" YBindingPath="Year2010" />
</chart:SfCartesianChart>
</td>
</tr>
</table>

Create an instance of the `ChartSelectionBehavior` class and add it to the  `ChartBehaviors` collection of `SfChart`. For `SfCartesianChart`, you can directly set the `ChartSelectionBehavior` instance to the [SelectionBehavior](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartBase.html#Syncfusion_Maui_Charts_ChartBase_SelectionBehaviorr) property as per the above code snippet.


### Zooming and Panning

<table>
<tr>
<th>Xamarin Zooming</th>
<th>MAUI Zooming</th>
</tr>
<tr>
<td>
<chart:SfChart>
	<chart:SfChart.ChartBehaviors>
		<chart:ChartZoomPanBehavior EnableZooming="True"/>
	</chart:SfChart.ChartBehaviors>
</chart:SfChart>
</td>
<td>
<chart:SfCartesianChart>
    <chart:SfCartesianChart.ZoomPanBehavior>
        <chart:ChartZoomPanBehavior EnablePinchZooming="True"/>
    </chart:SfCartesianChart.ZoomPanBehavior>
</chart:SfCartesianChart>
</td>
</tr>
</table>

The zooming and panning are achieved using the `ChartZoomPanBehavior` in SfChart and SfCartesianChart as per the above code example.

### Support and feedback

If you are unable to find the information that you are looking for in the self-help resources mentioned above, please contact us by creating a [support ticket](https://www.syncfusion.com/support/directtrac/incidents).
Do not see what you need? Please request it in our [feedback portal](https://www.syncfusion.com/feedback/maui).
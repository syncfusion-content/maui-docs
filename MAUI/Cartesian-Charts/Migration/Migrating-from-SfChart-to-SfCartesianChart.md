---
layout: post
title: Migration from Xamarin to .NET MAUI Chart control | Syncfusion
description: Learn here all about migration from Syncfusion Xamarin SfChart to .NET MAUI Chart (SfCartesianChart) control.
platform: maui
control: SfCartesianChart
documentation: ug
---

## Migrating from SfChart to SfCartesianChart

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
<th>SfChart</th>
<th>SfCartesianChart</th>
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
<td>- </td>
</tr>
<tr>
<td>-</td>
<td>TooltipBehavior</td>
</tr>
<tr>
<td>-</td>
<td>SelectionBehavior</td>
</tr>
<tr>
<td>-</td>
<td>ZoomPanBehavior</td>
</tr>
</table>

## Series

Mostly the same code are used to initialize the chart series in both SfChart and SfCartesianChart. You can create the instance of required series in SfChart as in the following code example.


### SfChart

{% tabs %} 

{% highlight xaml %}

<chart:SfChart>
   
   <chart:SfChart.PrimaryAxis>
    
        <chart:CategoryAxis>

            <chart:CategoryAxis.Title>

                  <chart:ChartAxisTitle Text="Name"> </chart:ChartAxisTitle>

            </chart:CategoryAxis.Title>

         </chart:CategoryAxis>
   
   </chart:SfChart.PrimaryAxis>

   <chart:SfChart.SecondaryAxis>
  
       <chart:NumericalAxis>
            
           <chart:NumericalAxis.Title>
           
                 <chart:ChartAxisTitle Text="Height (in cm)"></chart:ChartAxisTitle>
           
          </chart:NumericalAxis.Title>      
       
      </chart:NumericalAxis>   

     </chart:SfChart.SecondaryAxis>
    
      <chart:SfChart.Series>
              
         <chart:ColumnSeries ItemsSource="{Binding Data}" XBindingPath="Name" YBindingPath="Height">
		 
		 </chart:ColumnSeries>
    
      </chart:SfChart.Series>

 </chart:SfChart>

{% endhighlight %}

{% highlight C# %}

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

series.SetBinding(ChartSeries.ItemsSourceProperty, "Data");

series.XBindingPath = "Name";

series.YBindingPath = "Height";

chart.Series.Add(series);

{% endhighlight %}

{% endtabs %}


### SfCartesianChart

Following code example illustrates the initialization of Series that is equivalent to the above code example. 

{% tabs %} 

{% highlight xaml %}

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

{% endhighlight %}

{% highlight C# %}

SfCartesianChart chart = new SfCartesianChart();

// Initializing primary axis
CategoryAxis primaryAxis = new CategoryAxis();
primaryAxis.Title.Text = "Name";
chart.XAxes.Add(primaryAxis);

//Initializing secondary Axis
NumericalAxis secondaryAxis = new NumericalAxis();
secondaryAxis.Title.Text = "Height(in cm)";
chart.YAxes.Add(secondaryAxis);

//Initialize the two series for SfChart
ColumnSeries series = new ColumnSeries();
series.Label = "Height";
series.ItemsSource = (new ViewModel()).Data;
series.XBindingPath = "Name";
series.YBindingPath = "Height";

//Adding Series to the Chart Series Collection
chart.Series.Add(series);

{% endhighlight %}

{% endtabs %}


The following table illustrates the API comparison for series,

<table>
<tr>
<th>SfChart's Series</th>
<th>SfCartesianChart's Series</th>
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
<td>-</td>
<td>ShowDataLabels</td>
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

### SfChart

You can create the instance of required axis class and assign to the `PrimaryAxis` and `SecondaryAxis` properties in SfChart as in the following code example.


{% tabs %} 

{% highlight xaml %}

<chart:SfChart.PrimaryAxis>
	<chart:NumericalAxis/>
</chart:SfChart.PrimaryAxis>

<chart:SfChart.SecondaryAxis>
	<chart:NumericalAxis/>
</chart:SfChart.SecondaryAxis>

{% endhighlight %}

{% highlight C# %}

chart.PrimaryAxis = new NumericalAxis();
chart.SecondaryAxis = new NumericalAxis();

{% endhighlight %}

{% endtabs %}


### SfCartesianChart

For SfCartesianChart, you can create the instance of required axis class and need to add x and y axis in the [XAxes](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html#Syncfusion_Maui_Charts_SfCartesianChart_XAxes) and [YAxes](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html#Syncfusion_Maui_Charts_SfCartesianChart_YAxes) collections, respectively, in the SfCartesianChart as in the following code example.

{% tabs %} 

{% highlight xaml %}

<chart:SfCartesianChart>                            
    <chart:SfCartesianChart.XAxes>
        <chart:NumericalAxis/>
    </chart:SfCartesianChart.XAxes>
    
    <chart:SfCartesianChart.YAxes>
        <chart:NumericalAxis/>
    </chart:SfCartesianChart.YAxes>                       
</chart:SfCartesianChart>

{% endhighlight %}

{% highlight C# %}

SfCartesianChart chart = new SfCartesianChart();
NumericalAxis primaryAxis = new NumericalAxis();
chart.XAxes.Add(primaryAxis);
NumericalAxis secondaryAxis = new NumericalAxis();
chart.YAxes.Add(secondaryAxis);

{% endhighlight %}

{% endtabs %}

## Data Label

### SfChart

You need to create an instance of the `ChartDataMarker` class and assign it to the `DataMarker` property of ChartSeries class to enable the data labels in SfChart as per the following code snippet. 

{% tabs %} 

{% highlight xaml %}

<chart:ColumnSeries>

	<chart:ColumnSeries.DataMarker>

		<chart:ChartDataMarker/>

	</chart:ColumnSeries.DataMarker>

</chart:ColumnSeries>

{% endhighlight %}

{% highlight C# %}

ColumnSeries series = new ColumnSeries();

series.DataMarker = new ChartDataMarker();

{% endhighlight %}

{% endtabs %}

### SfCartesianChart

You can render the data labels by enabling the [ShowDataLabels](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSeries.html?tabs=tabid-1#Syncfusion_Maui_Charts_ChartSeries_ShowDataLabels) property in ChartSeries class as per the following code snippet.

{% tabs %} 

{% highlight xaml %}

<chart:SfCartesianChart>
    . . .
    <chart:SfCartesianChart.Series>
        <chart:ColumnSeries ItemsSource="{Binding Data}" 
                        XBindingPath="Category"
                        YBindingPath="Value" ShowDataLabels="True">
        </chart:ColumnSeries>
    </chart:SfCartesianChart.Series>
</chart:SfCartesianChart>

{% endhighlight %}

{% highlight C# %}

SfCartesianChart chart = new SfCartesianChart();
. . .
ColumnSeries series = new ColumnSeries()
{
    ItemsSource = viewModel.Data,
    XBindingPath = "Category",
    YBindingPath = "Value",
    ShowDataLabels = true
};

chart.Series.Add(series);

{% endhighlight %}

{% endtabs %}

## Interactive features

### Tooltip

To Customize the tooltip appearance, create an instance of the `ChartTooltipBehavior` class and add it to the  `ChartBehaviors` collection of `SfChart`. For `SfCartesianChart`, you can directly set the `ChartTooltipBehavior` instance to the [TooltipBehavior](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartBase.html#Syncfusion_Maui_Charts_ChartBase_TooltipBehavior) property as per the following code snippet.


### SfChart

{% tabs %} 

{% highlight xaml %}

<chart:SfChart.ChartBehaviors>

	<chart:ChartTooltipBehavior BackgroundColor="Blue" TextColor="White" Margin="5" FontSize="15"/>

	</chart:ChartTooltipBehavior>

</chart:SfChart.ChartBehaviors>

{% endhighlight %}

{% highlight C# %}

SfChart chart = new SfChart();
...

ChartTooltipBehavior tooltipBehavior = new ChartTooltipBehavior()
{
    BackgroundColor = Color.Blue;
    TextColor = Color.White;
    Margin = new Thickness(5, 5, 5, 5);
    FontSize = 15;	
};
chart.ChartBehaviors.Add(tooltip);

{% endhighlight %}

{% endtabs %}


### SfCartesianChart

{% tabs %} 

{% highlight xaml %}

<chart:SfCartesianChart>
. . .

<chart:SfCartesianChart.TooltipBehavior>
    <chart:ChartTooltipBehavior Background="Blue" TextColor="White" Margin="5" FontSize="15"/>
</chart:SfCartesianChart.TooltipBehavior>

<chart:ColumnSeries ItemsSource="{Binding Data}" 
                        XBindingPath="Demand"
                        YBindingPath="Year2010"
                        EnableTooltip="True"/>

</chart:SfCartesianChart>

{% endhighlight %}

{% highlight C# %}

SfCartesianChart chart = new SfCartesianChart();
chart.TooltipBehavior = new ChartTooltipBehavior()
{
    Background = Brush.Blue;
    TextColor = Colors.White;
    Margin = new Thickness(5, 5, 5, 5);
    FontSize = 15;	
};

ColumnSeries series = new ColumnSeries()
{
    ItemsSource = new ViewModel().Data,
    XBindingPath = "Demand",
    YBindingPath = "Year2010",
    EnableTooltip = True
};
chart.Series.Add(series);

{% endhighlight %}

{% endtabs %}


### Selection

Create an instance of the `ChartSelectionBehavior` class and add it to the  `ChartBehaviors` collection of `SfChart`. For `SfCartesianChart`, you can directly set the `ChartSelectionBehavior` instance to the [SelectionBehavior](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartBase.html#Syncfusion_Maui_Charts_ChartBase_SelectionBehaviorr) property as per the following code snippet.

### SfChart

{% tabs %} 

{% highlight xaml %}


{% endhighlight %}

{% highlight C# %}

{% endhighlight %}

{% endtabs %}

### SfCartesianChart

{% tabs %} 

{% highlight xaml %}

<chart:SfCartesianChart>
. . .
    <chart:SfCartesianChart.SelectionBehavior>
        <chart:ChartSelectionBehavior />
    </chart:SfCartesianChart.SelectionBehavior>

    <chart:ColumnSeries ItemsSource="{Binding Data}" 
                        XBindingPath="Demand"
                        YBindingPath="Year2010"
                        SelectionBrush="Green"/>
</chart:SfCartesianChart>

{% endhighlight %}

{% highlight C# %}

SfCartesianChart chart = new SfCartesianChart();
. . .
ChartSelectionBehavior selection = new ChartSelectionBehavior();
chart.SelectionBehavior = selection;

ColumnSeries series = new ColumnSeries()
{
    ItemsSource = new ViewModel().Data,
    XBindingPath = "Demand",
    YBindingPath = "Year2010",
    SelectionBrush = Brush.Green
};

chart.Series.Add(series);
this.Content = chart;

{% endhighlight %}

{% endtabs %}

### Zooming and Panning

The zooming and panning are achieved using the ChartZoomPanBehavior in SfChart as in the following code example.

### SfChart

{% tabs %} 

{% highlight xaml %}

<chart:SfChart>
	<chart:SfChart.ChartBehaviors>
		<chart:ChartZoomPanBehavior EnableZooming="True"/>
	</chart:SfChart.ChartBehaviors>
</chart:SfChart>

{% endhighlight %}

{% highlight C# %}

SfChart chart = new SfChart();

ChartZoomPanBehavior zoomPanBehavior = new ChartZoomPanBehavior()
{  
    EnableZooming = true 
};

chart.ChartBehaviors.Add(zoomPanBehavior);

{% endhighlight %}

{% endtabs %}

### SfCartesianChart

{% tabs %} 

{% highlight xaml %}

<chart:SfCartesianChart>
    <chart:SfCartesianChart.ZoomPanBehavior>
        <chart:ChartZoomPanBehavior EnablePinchZooming="True"/>
    </chart:SfCartesianChart.ZoomPanBehavior>
    ...
</chart:SfCartesianChart>

{% endhighlight %}

{% highlight C# %}

SfCartesianChart chart = new SfCartesianChart();
...
ChartZoomPanBehavior zooming = new ChartZoomPanBehavior()
{
    EnablePinchZooming = true
};

chart.ZoomPanBehavior = zooming;
...

{% endhighlight %}

{% endtabs %}


### Support and feedback

If you are unable to find the information that you are looking for in the self-help resources mentioned above, please contact us by creating a [support ticket](https://www.syncfusion.com/support/directtrac/incidents).
Do not see what you need? Please request it in our [feedback portal](https://www.syncfusion.com/feedback/maui).

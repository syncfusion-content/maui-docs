---
layout: post
title: Migration from Xamarin to .NET MAUI Sunburst Chart control | Syncfusion
description: This section explains the features available in the .NET MAUI Sunburst control over Xamarin SfSunburstChart.
platform: MAUI
control: SfSunburstChart
documentation: ug
---

# Migrate from Xamarin.Forms SfSunburstChart to .NET MAUI SfSunburstChart

The SfSunburstChart was created from the scratch using the upgraded APIs and performance of the .NET MAUI graphics library and framework layouts. However, to maintain the consistency of the API naming in MAUI SfSunburstChart, we renamed some of the APIs. The APIs changed in MAUI SfSunburstChart from Xamarin SfSunburstChart are detailed as follows:

## Namespaces

<table>
<tr>
<th>Xamarin</th>
<th>.NET MAUI</th>
</tr>
<tr>
<td>
Syncfusion.SfSunburstChart.XForms
</td>
<td>
<div> Syncfusion.Maui.SunburstChart </div>
</td>
</tr>
</table>

To make the migration easier, the majority of the APIs from the Xamarin [SfSunburstChart](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSunburstChart.XForms.SfSunburstChart.html) were kept in the .NET MAUI [SfSunburstChart](). Currently, most of the features have been added in the [SfSunburstChart](), but only a few are pending in the .NET MAUI along with some limitations. Please refer to the following details and the API migration information available below.

## Initialize control

To initialize the control, import the sunburst chart namespace and Initialize [SfSunburstChart]() as shown in the following code sample. 

<table>
<tr>
<th>Xamarin</th>
</tr>
<tr>
<td>

{% tabs %} 

{% highlight xaml %}

    <ContentPage
            . . .
            xmlns:sunburst="clr-namespace:Syncfusion.SfSunburstChart.XForms;assembly=Syncfusion.SfSunburstChart.XForms">

        <chart:SfSunburstChart/>

    </ContentPage>
{% endhighlight %}
{% highlight C# %}

    using Syncfusion.SfSunburstChart.XForms;
    ...

    SfSunburstChart chart = new SfSunburstChart(); 
    this.Content = chart;

{% endhighlight %}

{% endtabs %}
</td>
</tr>
<tr>
<th>.NET MAUI</th>
</tr>
<tr>
<td>
{% tabs %} 

{% highlight xaml %}

    <ContentPage
    . . .    
     xmlns:sunburst="clr-namespace:Syncfusion.Maui.SunburstChart;assembly=Syncfusion.Maui.SunburstChart">
   
        <sunburst:SfSunburstChart/>
   
    </ContentPage>
 
{% endhighlight %}
{% highlight C# %}

    using Syncfusion.Maui.SunburstChart;
    . . .
    SfSunburstChart chart = new SfSunburstChart(); 
    this.Content = chart;

{% endhighlight %}

{% endtabs %}
</td>
</tr>
</table>

## API Migration
The following table illustrates the API migration for the sunburst chart.

### SunburstChart

<table>
<tr>
<th>Xamarin</th>
<th>.NET MAUI</th>
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
<td>Levels</td>
<td>Levels</td>
</tr>
<tr>
<td>StrokeColor</td>
<td>Stroke</td>
</tr>
<tr>
<td>DataLabel</td>
<td>DataLabelSettings</td>
</tr>
<tr>
<td>TooltipSettings</td>
<td>TooltipSettings</td>
</tr>
<tr>
<td>ColorModel, CustomBrushes, Palette</td>
<td>PaletteBrushes</td>
</tr>
</table>

The following code example explains how to migrate Xamarin SfSunburstChart to the .NET MAUI SfSunburstChart.

<table>
<tr>
<th>Xamarin</th>
</tr>
<tr>
<td>

{% tabs %} 

{% highlight xaml %}

    <ContentPage
            . . .
            xmlns:sunburst="clr-namespace:Syncfusion.SfSunburstChart.XForms;assembly=Syncfusion.SfSunburstChart.XForms">

        <chart:SfSunburstChart/>

    </ContentPage>
{% endhighlight %}

{% highlight C# %}

    using Syncfusion.SfSunburstChart.XForms;
    ...

    SfSunburstChart chart = new SfSunburstChart(); 
    this.Content = chart;

{% endhighlight %}

{% endtabs %}
</td>
</tr>
<tr>
<th>.NET MAUI</th>
</tr>
<tr>
<td>
{% tabs %} 

{% highlight xaml %}

     <ContentPage
            . . .
           xmlns:sunburst="clr-namespace:Syncfusion.Maui.SunburstChart;assembly=Syncfusion.Maui.SunburstChart" >

        <sunburst:SfSunburstChart ItemsSource="{Binding DataSource}"
            ValueMemberPath="EmployeesCount">
             <sunburst:SfSunburstChart.Levels>

          <sunburst:SunburstHierarchicalLevel GroupMemberPath="Country"/>
          <sunburst:SunburstHierarchicalLevel GroupMemberPath="JobDescription"/>
          <sunburst:SunburstHierarchicalLevel GroupMemberPath="JobGroup"/>
          <sunburst:SunburstHierarchicalLevel GroupMemberPath="JobRole"/>
        </sunburst:SfSunburstChart.Levels>

        </sunburst:SfSunburstChart>
     </ContentPage>
 
{% endhighlight %}

{% highlight C# %}

    using Syncfusion.Maui.SunburstChart;
    
        SfSunburstChart sunburstChart = new SfSunburstChart();

        sunburstChart.SetBinding(SfSunburstChart.ItemsSourceProperty, "DataSource");
        sunburstChart.ValueMemberPath = "EmployeesCount";
        sunburstChart.Levels.Add(new SunburstHierarchicalLevel() { GroupMemberPath = "Country" });
        sunburstChart.Levels.Add(new SunburstHierarchicalLevel() { GroupMemberPath = "JobDescription" });
        sunburstChart.Levels.Add(new SunburstHierarchicalLevel() { GroupMemberPath = "JobGroup" });
        sunburstChart.Levels.Add(new SunburstHierarchicalLevel() { GroupMemberPath = "JobRole" });

        this.Content = sunburstChart;
                       

{% endhighlight %}

{% endtabs %}
</td>
</tr>
</table>

### Legend

<table>
<tr>
<th>Xamarin</th>
<th>.NET MAUI</th>
</tr>
<tr>
<td>IsVisible</td>
<td>IsVisible</td>
</tr>
<tr>
<td>LegendPosition</td>
<td>Placement</td>
</tr>
<tr>
<td>LabelStyle</td>
<td>Upcoming</td>
</tr>
<tr>
<td>IconType</td>
<td>Upcoming</td>
</tr>
<tr>
<td>ItemMargin</td>
<td>Upcoming</td>
</tr>
<tr>
<td>IconHeight</td>
<td>Upcoming</td>
</tr>
<tr>
<td>ItemWidth</td>
<td>Upcoming</td>
</tr>
</table>

The following code example shows how to enable legend in the sunburst chart.

<table>
<tr>
<th>Xamarin</th>
</tr>
<tr>
<td>

{% tabs %} 

{% highlight xaml %}

    <ContentPage
            . . .
            xmlns:sunburst="clr-namespace:Syncfusion.SfSunburstChart.XForms;assembly=Syncfusion.SfSunburstChart.XForms">

        <sunburst:SfSunburstChart.Legend>
            <sunburst:SunburstChartLegend x:Name="legend" IsVisible="True"  
                      LegendPosition="Left" >
        </sunburst:SunburstChartLegend>
    </sunburst:SfSunburstChart.Legend>

    </ContentPage>
{% endhighlight %}

{% highlight C# %}

    using Syncfusion.SfSunburstChart.XForms;
    ...
        SfSunburstChart sunburstChart = new SfSunburstChart();

        SunburstChartLegend legend = new SunburstChartLegend();
        legend.IsVisible = true;
        legend.LegendPosition = SunburstDockPosition.Left;
        sunburstChart.Legend = legend;

        this.Content = sunburstChart;

{% endhighlight %}

{% endtabs %}
</td>
</tr>
<tr>
<th>.NET MAUI</th>
</tr>
<tr>
<td>
{% tabs %} 

{% highlight xaml %}

     <ContentPage
            . . .
           xmlns:sunburst="clr-namespace:Syncfusion.Maui.SunburstChart;assembly=Syncfusion.Maui.SunburstChart" >

        <sunburst:SfSunburstChart.Legend>
            <sunburst:SunburstLegend Placement="Top" IsVisible="True" />
        </sunburst:SfSunburstChart.Legend>
           
     </ContentPage>
 
{% endhighlight %}
{% highlight C# %}

    using Syncfusion.Maui.SunburstChart;
    
         SfSunburstChart sunburstChart = new SfSunburstChart();

         sunburstChart.Legend = new SunburstLegend()
         {
            Placement = LegendPlacement.Top,
            IsVisible = true
         };

        this.Content = sunburstChart;
                       

{% endhighlight %}

{% endtabs %}
</td>
</tr>
</table>

### Data Label

To customize the data label appearance, create an instance of the [SunburstDataLabelSettings]() class and add it to the [DataLabelSettings]() of [SfSunburstChart](). The following code explains how to initialize data labels. 

<table>
<tr>
<th>Xamarin</th>
</tr>
<tr>
<td>

{% tabs %} 
{% highlight xaml %}

    <ContentPage
            . . .
            xmlns:sunburst="clr-namespace:Syncfusion.SfSunburstChart.XForms;assembly=Syncfusion.SfSunburstChart.XForms">

        <sunburst:SfSunburstChart.DataLabel>
            <sunburst:SunburstChartDataLabel  ShowLabel="True" FontAttributes="Bold" 
                        FontSize="10" TextColor="Red" >
            </sunburst:SunburstChartDataLabel>
        </sunburst:SfSunburstChart.DataLabel>

    </ContentPage>
{% endhighlight %}
{% highlight C# %}

    using Syncfusion.SfSunburstChart.XForms;
    ...
        SfSunburstChart sunburstChart = new SfSunburstChart();
        SunburstChartDataLabel label = new SunburstChartDataLabel();
        label.ShowLabel = true;
        label.TextColor = Color.Red;
        label.FontSize = 10;
        label.FontAttributes = FontAttributes.Bold;
        label.FontFamily = "ArialMT";
        sunburstChart.DataLabel = label;

        this.Content = sunburstChart;

{% endhighlight %}
{% endtabs %}
</td>
</tr>
<tr>
<th>.NET MAUI</th>
</tr>
<tr>
<td>
{% tabs %} 
{% highlight xaml %}

     <ContentPage
            . . .
           xmlns:sunburst="clr-namespace:Syncfusion.Maui.SunburstChart;assembly=Syncfusion.Maui.SunburstChart" >
        
        <sunburst:SfSunburstChart ItemsSource="{Binding DataSource}" ShowLabels="True" 
            ValueMemberPath="EmployeesCount">
             <sunburst:SfSunburstChart.Levels>

            <sunburst:SfSunburstChart.DataLabelSettings>
               <sunburst:SunburstDataLabelSettings FontSize="13" FontAttributes="Italic"
                       RotationMode="Angle" OverFlowMode="Trim" />
            </sunburst:SfSunburstChart.DataLabelSettings>

          <sunburst:SunburstHierarchicalLevel GroupMemberPath="Country"/>
          <sunburst:SunburstHierarchicalLevel GroupMemberPath="JobDescription"/>
          <sunburst:SunburstHierarchicalLevel GroupMemberPath="JobGroup"/>
          <sunburst:SunburstHierarchicalLevel GroupMemberPath="JobRole"/>
        </sunburst:SfSunburstChart.Levels>

       ShowLabels="True"
           
     </ContentPage>
 
{% endhighlight %}
{% highlight C# %}

    using Syncfusion.Maui.SunburstChart;
    
       sunburstChart.ShowLabels = true;
       sunburstChart.DataLabelSettings = new SunburstDataLabelSettings()
       {
            OverFlowMode = SunburstLabelOverflowMode.Trim,
            RotationMode = SunburstLabelRotationMode.Angle,
            FontAttributes = FontAttributes.Italic,
            FontSize = 13
       };

       sunburstChart.SetBinding(SfSunburstChart.ItemsSourceProperty, "DataSource");
       sunburstChart.ValueMemberPath = "EmployeesCount";
       sunburstChart.Levels.Add(new SunburstHierarchicalLevel() { GroupMemberPath = "Country" });
       sunburstChart.Levels.Add(new SunburstHierarchicalLevel() { GroupMemberPath = "JobDescription" });
       sunburstChart.Levels.Add(new SunburstHierarchicalLevel() { GroupMemberPath = "JobGroup" });
       sunburstChart.Levels.Add(new SunburstHierarchicalLevel() { GroupMemberPath = "JobRole" });

        this.Content = sunburstChart;
                       

{% endhighlight %}

{% endtabs %}
</td>
</tr>
</table>

### Tooltip

To customize the tooltip appearance, create an instance of the SunburstTooltipSettings class and add it to the TooltipSettings of SfSunburstChart. 

<table>
<tr>
<th>Xamarin</th>
</tr>
<tr>
<td>

{% tabs %} 
{% highlight xaml %}

    <ContentPage
            . . .
            xmlns:sunburst="clr-namespace:Syncfusion.SfSunburstChart.XForms;assembly=Syncfusion.SfSunburstChart.XForms">

    <sunburst:SfSunburstChart.TooltipSettings>
       <sunburst:SunburstTooltipSettings  ShowTooltip="True"    TextColor="White"
             BackgroundColor="Green"  BorderColor="Black" BorderWidth="1" 
             Duration="2000" >
       </sunburst:SunburstTooltipSettings>
    </sunburst:SfSunburstChart.TooltipSettings>

    </ContentPage>
{% endhighlight %}
{% highlight C# %}

    using Syncfusion.SfSunburstChart.XForms;
    ...
        SfSunburstChart sunburstChart = new SfSunburstChart();

        SunburstTooltipSettings tooltipSettings = new SunburstTooltipSettings();
        tooltipSettings.ShowTooltip = true;
        tooltipSettings.TextColor = Color.White;
        tooltipSettings.BackgroundColor = Color.Green;
        tooltipSettings.BorderColor = Color.Black;
        tooltipSettings.BorderWidth = 1;
        tooltipSettings.Duration = 2000;
        sunburstChart.TooltipSettings = tooltipSettings;

        this.Content = sunburstChart;

{% endhighlight %}
{% endtabs %}
</td>
</tr>
<tr>
<th>.NET MAUI</th>
</tr>
<tr>
<td>
{% tabs %} 
{% highlight xaml %}

    <ContentPage
            . . .
           xmlns:sunburst="clr-namespace:Syncfusion.Maui.SunburstChart;assembly=Syncfusion.Maui.SunburstChart" >
        
        <sunburst:SfSunburstChart ItemsSource="{Binding DataSource}"  EnableTooltip="True" 
            ValueMemberPath="EmployeesCount">

            <sunburst:SfSunburstChart.TooltipSettings>
              <sunburst:SunburstTooltipSettings  TextColor="Black"
                    FontSize="14" Duration="4"
                    Background="Gray" />
            </sunburst:SfSunburstChart.TooltipSettings>

            <sunburst:SfSunburstChart.Levels>
              <sunburst:SunburstHierarchicalLevel GroupMemberPath="Country"/>
              <sunburst:SunburstHierarchicalLevel GroupMemberPath="JobDescription"/>
              <sunburst:SunburstHierarchicalLevel GroupMemberPath="JobGroup"/>
              <sunburst:SunburstHierarchicalLevel GroupMemberPath="JobRole"/>
            </sunburst:SfSunburstChart.Levels>
           
    </ContentPage>
 
{% endhighlight %}
{% highlight C# %}

    using Syncfusion.Maui.SunburstChart;
    
        sunburstChart.EnableTooltip = true;
        sunburstChart.TooltipSettings = new SunburstTooltipSettings()
        {
            Background = Brush.Gray,
            TextColor = Colors.Black,
            Duration = 4,
            FontSize = 14
        };

       sunburstChart.SetBinding(SfSunburstChart.ItemsSourceProperty, "DataSource");
       sunburstChart.ValueMemberPath = "EmployeesCount";
       sunburstChart.Levels.Add(new SunburstHierarchicalLevel() { GroupMemberPath = "Country" });
       sunburstChart.Levels.Add(new SunburstHierarchicalLevel() { GroupMemberPath = "JobDescription" });
       sunburstChart.Levels.Add(new SunburstHierarchicalLevel() { GroupMemberPath = "JobGroup" });
       sunburstChart.Levels.Add(new SunburstHierarchicalLevel() { GroupMemberPath = "JobRole" });

        this.Content = sunburstChart;
                       

{% endhighlight %}

{% endtabs %}
</td>
</tr>
</table>

## Upcoming features in .NET MAUI Sunburst chart

* Drill Down support.
* Selection support.

## Support and feedback

If you are unable to find the migration information you require in the self-help resources listed above, please contact us by creating a [support ticket](https://internalsupport.bolddesk.com/agent/tickets/create). Do not see what you need? Please request it in our [feedback portal](https://www.syncfusion.com/feedback/maui). 

---
layout: post
title: Xamarin to .NET MAUI Sunburst Chart Migration | Syncfusion
description: This section explains the .NET MAUI SfSunburstChart features relative to the Xamarin SfSunburstChart control.
platform: MAUI
control: SfSunburstChart
documentation: ug
---

# Migrate from Xamarin.Forms SunburstChart to .NET MAUI SunburstChart

The SfSunburstChart was created from scratch using the upgraded APIs and performance of the .NET MAUI graphics library and framework layouts. However, to maintain API naming consistency in .NET MAUI SfSunburstChart, we renamed some of the APIs. The changes in APIs from Xamarin SfSunburstChart to .NET MAUI SfSunburstChart are detailed below.


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
Syncfusion.Maui.SunburstChart
</td>
</tr>
</table>

To make migration easier, most of the APIs from the Xamarin [SfSunburstChart](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSunburstChart.XForms.SfSunburstChart.html) were kept in the .NET MAUI [SfSunburstChart](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SunburstChart.SfSunburstChart.html). Currently, most features have been added to the [SfSunburstChart](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SunburstChart.SfSunburstChart.html), but a few are still pending in .NET MAUI along with some limitations. Please refer to the following details and API migration information.

## Initialize the control

To initialize the control, import the sunburst chart namespace and initialize [SfSunburstChart](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SunburstChart.SfSunburstChart.html) as shown in the following code sample:

<table>
<tr>
<th>Xamarin</th>
</tr>
<tr>
<td>

{% tabs %} 

{% highlight xaml %}

<ContentPage
    xmlns:sunburst="clr-namespace:Syncfusion.SfSunburstChart.XForms;assembly=Syncfusion.SfSunburstChart.XForms">

    <sunburst:SfSunburstChart/>

</ContentPage>

{% endhighlight %}
{% highlight c# %}

using Syncfusion.SfSunburstChart.XForms;
// code omitted for brevity

SfSunburstChart sunburstChart = new SfSunburstChart(); 
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
    xmlns:sunburst="clr-namespace:Syncfusion.Maui.SunburstChart;assembly=Syncfusion.Maui.SunburstChart">

    <sunburst:SfSunburstChart/>

</ContentPage>

{% endhighlight %}
{% highlight c# %}

using Syncfusion.Maui.SunburstChart;
// code omitted for brevity
SfSunburstChart sunburstChart = new SfSunburstChart(); 
this.Content = sunburstChart;

{% endhighlight %}

{% endtabs %}
</td>
</tr>
</table>

## API migration
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
<td>SunburstChartDataLabel.ShowLabel</td>
<td>SfSunburstChart.ShowLabels</td>
</tr>
<tr>
<td>SunburstTooltipSettings.ShowTooltip</td>
<td>SfSunburstChart.EnableTooltip</td>
</tr>
<tr>
<td>SunburstTooltipSettings.TooltipTemplate</td>
<td>SfSunburstChart.TooltipTemplate</td>
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

The following code example explains how to migrate from Xamarin SfSunburstChart to .NET MAUI SfSunburstChart:

<table>
<tr>
<th>Xamarin</th>
</tr>
<tr>
<td>

{% tabs %} 

{% highlight xaml %}

<ContentPage
    xmlns:sunburst="clr-namespace:Syncfusion.SfSunburstChart.XForms;assembly=Syncfusion.SfSunburstChart.XForms">

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

{% highlight c# %}

using Syncfusion.SfSunburstChart.XForms;
// code omitted for brevity

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
<tr>
<th>.NET MAUI</th>
</tr>
<tr>
<td>
{% tabs %} 

{% highlight xaml %}

<ContentPage
    xmlns:sunburst="clr-namespace:Syncfusion.Maui.SunburstChart;assembly=Syncfusion.Maui.SunburstChart">

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

{% highlight c# %}

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

The following code example shows how to enable the legend in the sunburst chart:

<table>
<tr>
<th>Xamarin</th>
</tr>
<tr>
<td>

{% tabs %} 

{% highlight xaml %}

<ContentPage
    xmlns:sunburst="clr-namespace:Syncfusion.SfSunburstChart.XForms;assembly=Syncfusion.SfSunburstChart.XForms">

    <sunburst:SfSunburstChart.Legend>
        <sunburst:SunburstChartLegend x:Name="legend"
                                      IsVisible="True"
                                      LegendPosition="Left">
        </sunburst:SunburstChartLegend>
    </sunburst:SfSunburstChart.Legend>
    <!-- code omitted for brevity -->
</ContentPage>
{% endhighlight %}

{% highlight c# %}

using Syncfusion.SfSunburstChart.XForms;
// code omitted for brevity
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
    xmlns:sunburst="clr-namespace:Syncfusion.Maui.SunburstChart;assembly=Syncfusion.Maui.SunburstChart">

    <sunburst:SfSunburstChart.Legend>
        <sunburst:SunburstLegend Placement="Left" IsVisible="True"/>
    </sunburst:SfSunburstChart.Legend>
    <!-- code omitted for brevity -->
</ContentPage>

{% endhighlight %}
{% highlight c# %}

using Syncfusion.Maui.SunburstChart;

SfSunburstChart sunburstChart = new SfSunburstChart();

sunburstChart.Legend = new SunburstLegend()
{
    Placement = LegendPlacement.Left,
    IsVisible = true
};

this.Content = sunburstChart;

{% endhighlight %}

{% endtabs %}
</td>
</tr>
</table>

### Data label
To enable data labels, use the [ShowLabel](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSunburstChart.XForms.SunburstChartDataLabel.html#Syncfusion_SfSunburstChart_XForms_SunburstChartDataLabel_ShowLabel) property in the [SunburstChartDataLabel](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSunburstChart.XForms.SunburstChartDataLabel.html) class in Xamarin and the [ShowLabels](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SunburstChart.SfSunburstChart.html#Syncfusion_Maui_SunburstChart_SfSunburstChart_ShowLabels) property in the [SfSunburstChart](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SunburstChart.SfSunburstChart.html) class in .NET MAUI.

To customize the data label appearance, create an instance of the [SunburstDataLabelSettings](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SunburstChart.SunburstDataLabelSettings.html) class and add it to the [DataLabelSettings](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SunburstChart.SfSunburstChart.html#Syncfusion_Maui_SunburstChart_SfSunburstChart_DataLabelSettings) of [SfSunburstChart](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SunburstChart.SfSunburstChart.html). The following code shows how to initialize data labels:

<table>
<tr>
<th>Xamarin</th>
</tr>
<tr>
<td>

{% tabs %} 
{% highlight xaml %}

<ContentPage
    xmlns:sunburst="clr-namespace:Syncfusion.SfSunburstChart.XForms;assembly=Syncfusion.SfSunburstChart.XForms">

    <sunburst:SfSunburstChart.DataLabel>
        <sunburst:SunburstChartDataLabel ShowLabel="True" FontAttributes="Bold" 
                                         FontSize="10" TextColor="Red">
        </sunburst:SunburstChartDataLabel>
    </sunburst:SfSunburstChart.DataLabel>

</ContentPage>
{% endhighlight %}
{% highlight c# %}

using Syncfusion.SfSunburstChart.XForms;
// code omitted for brevity
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
    xmlns:sunburst="clr-namespace:Syncfusion.Maui.SunburstChart;assembly=Syncfusion.Maui.SunburstChart">

    <sunburst:SfSunburstChart ItemsSource="{Binding DataSource}" ShowLabels="True" 
                              ValueMemberPath="EmployeesCount">

        <sunburst:SfSunburstChart.DataLabelSettings>
            <sunburst:SunburstDataLabelSettings FontSize="13" FontAttributes="Italic"
                                                RotationMode="Angle" OverFlowMode="Trim" />
        </sunburst:SfSunburstChart.DataLabelSettings>

        <sunburst:SfSunburstChart.Levels>
            <sunburst:SunburstHierarchicalLevel GroupMemberPath="Country"/>
            <sunburst:SunburstHierarchicalLevel GroupMemberPath="JobDescription"/>
            <sunburst:SunburstHierarchicalLevel GroupMemberPath="JobGroup"/>
            <sunburst:SunburstHierarchicalLevel GroupMemberPath="JobRole"/>
        </sunburst:SfSunburstChart.Levels>
    </sunburst:SfSunburstChart>

</ContentPage>

{% endhighlight %}
{% highlight c# %}

using Syncfusion.Maui.SunburstChart;

SfSunburstChart sunburstChart = new SfSunburstChart();

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
To enable the tooltip, use the [ShowTooltip](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSunburstChart.XForms.SunburstTooltipSettings.html#Syncfusion_SfSunburstChart_XForms_SunburstTooltipSettings_ShowTooltip) property in the [SunburstTooltipSettings](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSunburstChart.XForms.SunburstTooltipSettings.html) class in Xamarin and the [EnableTooltip](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SunburstChart.SfSunburstChart.html#Syncfusion_Maui_SunburstChart_SfSunburstChart_EnableTooltip) property in the [SfSunburstChart](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SunburstChart.SfSunburstChart.html) class in .NET MAUI.

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
    xmlns:sunburst="clr-namespace:Syncfusion.SfSunburstChart.XForms;assembly=Syncfusion.SfSunburstChart.XForms">

    <sunburst:SfSunburstChart.TooltipSettings>
        <sunburst:SunburstTooltipSettings ShowTooltip="True" TextColor="White" Duration="2000"
                                          BackgroundColor="Green" BorderColor="Black" BorderWidth="1">
        </sunburst:SunburstTooltipSettings>
    </sunburst:SfSunburstChart.TooltipSettings>

</ContentPage>
{% endhighlight %}
{% highlight c# %}

using Syncfusion.SfSunburstChart.XForms;
// code omitted for brevity
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
    xmlns:sunburst="clr-namespace:Syncfusion.Maui.SunburstChart;assembly=Syncfusion.Maui.SunburstChart">

    <sunburst:SfSunburstChart ItemsSource="{Binding DataSource}" EnableTooltip="True" 
                              ValueMemberPath="EmployeesCount">

        <sunburst:SfSunburstChart.TooltipSettings>
            <sunburst:SunburstTooltipSettings TextColor="Black"
                                              FontSize="14" Duration="2"
                                              Background="Gray"
                                              Stroke="Black" StrokeWidth="1"/>
        </sunburst:SfSunburstChart.TooltipSettings>

        <sunburst:SfSunburstChart.Levels>
            <sunburst:SunburstHierarchicalLevel GroupMemberPath="Country"/>
            <sunburst:SunburstHierarchicalLevel GroupMemberPath="JobDescription"/>
            <sunburst:SunburstHierarchicalLevel GroupMemberPath="JobGroup"/>
            <sunburst:SunburstHierarchicalLevel GroupMemberPath="JobRole"/>
        </sunburst:SfSunburstChart.Levels>
    </sunburst:SfSunburstChart>

</ContentPage>

{% endhighlight %}
{% highlight c# %}

using Syncfusion.Maui.SunburstChart;

SfSunburstChart sunburstChart = new SfSunburstChart();

sunburstChart.EnableTooltip = true;
sunburstChart.TooltipSettings = new SunburstTooltipSettings()
{
    Background = Colors.Gray,
    TextColor = Colors.Black,
    Stroke = Colors.Black,
    StrokeWidth = 1,
    Duration = 2,
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

### Selection
Selection in Xamarin was enabled by assigning a [SunburstSelectionSettings](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSunburstChart.XForms.SunburstSelectionSettings.html) instance to the chart. In .NET MAUI, the [SelectionSettings](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SunburstChart.SfSunburstChart.html#Syncfusion_Maui_SunburstChart_SfSunburstChart_SelectionSettings) property of [SfSunburstChart](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SunburstChart.SfSunburstChart.html) accepts the [SunburstSelectionSettings](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SunburstChart.SunburstSelectionSettings.html) class. The [SelectionType](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSunburstChart.XForms.SunburstSelectionSettings.html) property in Xamarin is renamed to [Type](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SunburstChart.SunburstSelectionSettings.html#Syncfusion_Maui_SunburstChart_SunburstSelectionSettings_Type), and the [SelectionMode](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSunburstChart.XForms.SunburstSelectionSettings.html) property is renamed to [DisplayMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SunburstChart.SunburstSelectionSettings.html#Syncfusion_Maui_SunburstChart_SunburstSelectionSettings_DisplayMode). For the full list of selection APIs, refer to the [Selection](https://help.syncfusion.com/maui/sunburstchart/selection) topic.

<table>
<tr>
<th>Xamarin</th>
<th>.NET MAUI</th>
</tr>
<tr>
<td>SelectionType</td>
<td>[Type](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SunburstChart.SunburstSelectionSettings.html#Syncfusion_Maui_SunburstChart_SunburstSelectionSettings_Type)</td>
</tr>
<tr>
<td>SelectionMode</td>
<td>[DisplayMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SunburstChart.SunburstSelectionSettings.html#Syncfusion_Maui_SunburstChart_SunburstSelectionSettings_DisplayMode)</td>
</tr>
<tr>
<td>SelectionBrush</td>
<td>[Fill](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SunburstChart.SunburstSelectionSettings.html#Syncfusion_Maui_SunburstChart_SunburstSelectionSettings_Fill)</td>
</tr>
<tr>
<td>StrokeColor</td>
<td>[Stroke](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SunburstChart.SunburstSelectionSettings.html#Syncfusion_Maui_SunburstChart_SunburstSelectionSettings_Stroke) / [StrokeWidth](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SunburstChart.SunburstSelectionSettings.html#Syncfusion_Maui_SunburstChart_SunburstSelectionSettings_StrokeWidth)</td>
</tr>
<tr>
<td>Opacity</td>
<td>[Opacity](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SunburstChart.SunburstSelectionSettings.html#Syncfusion_Maui_SunburstChart_SunburstSelectionSettings_Opacity)</td>
</tr>
</table>

The following code example shows how to enable selection in the sunburst chart:

<table>
<tr>
<th>Xamarin</th>
</tr>
<tr>
<td>

{% tabs %} 
{% highlight xaml %}

<ContentPage
    xmlns:sunburst="clr-namespace:Syncfusion.SfSunburstChart.XForms;assembly=Syncfusion.SfSunburstChart.XForms">

    <sunburst:SfSunburstChart.SelectionSettings>
        <sunburst:SunburstSelectionSettings SelectionType="Child"
                                            SelectionMode="HighlightByBrush"
                                            SelectionBrush="DarkRed"/>
    </sunburst:SfSunburstChart.SelectionSettings>
    <!-- code omitted for brevity -->
</ContentPage>
{% endhighlight %}
{% highlight c# %}

using Syncfusion.SfSunburstChart.XForms;
// code omitted for brevity
SfSunburstChart sunburstChart = new SfSunburstChart();

SunburstSelectionSettings selectionSettings = new SunburstSelectionSettings();
selectionSettings.SelectionType = SunburstSelectionType.Child;
selectionSettings.SelectionMode = SunburstSelectionMode.HighlightByBrush;
selectionSettings.SelectionBrush = Color.DarkRed;
sunburstChart.SelectionSettings = selectionSettings;

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
    xmlns:sunburst="clr-namespace:Syncfusion.Maui.SunburstChart;assembly=Syncfusion.Maui.SunburstChart">

    <sunburst:SfSunburstChart.SelectionSettings>
        <sunburst:SunburstSelectionSettings Type="Child"
                                             DisplayMode="HighlightByBrush"
                                             Fill="DarkRed"/>
    </sunburst:SfSunburstChart.SelectionSettings>
    <!-- code omitted for brevity -->
</ContentPage>

{% endhighlight %}
{% highlight c# %}

using Syncfusion.Maui.SunburstChart;

SfSunburstChart sunburstChart = new SfSunburstChart();

SunburstSelectionSettings selectionSettings = new SunburstSelectionSettings
{
    Type = SunburstSelectionType.Child,
    DisplayMode = SunburstSelectionDisplayMode.HighlightByBrush,
    Fill = Colors.DarkRed
};
sunburstChart.SelectionSettings = selectionSettings;

this.Content = sunburstChart;

{% endhighlight %}

{% endtabs %}
</td>
</tr>
</table>

### Drill down
Drill down in Xamarin was enabled by setting the `EnableDrillDown` property. In .NET MAUI, the [EnableDrillDown](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SunburstChart.SfSunburstChart.html#Syncfusion_Maui_SunburstChart_SfSunburstChart_EnableDrillDown) property enables the same feature, and the drill-down toolbar appearance and position can be customized using the [ToolbarSettings](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SunburstChart.SfSunburstChart.html#Syncfusion_Maui_SunburstChart_SfSunburstChart_ToolbarSettings) property of [SfSunburstChart](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SunburstChart.SfSunburstChart.html). For the full list of drill-down APIs, refer to the [Drill Down](https://help.syncfusion.com/maui/sunburstchart/drilldown) topic.

<table>
<tr>
<th>Xamarin</th>
<th>.NET MAUI</th>
</tr>
<tr>
<td>EnableDrillDown</td>
<td>[EnableDrillDown](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SunburstChart.SfSunburstChart.html#Syncfusion_Maui_SunburstChart_SfSunburstChart_EnableDrillDown)</td>
</tr>
<tr>
<td>ToolbarSettings</td>
<td>[ToolbarSettings](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SunburstChart.SfSunburstChart.html#Syncfusion_Maui_SunburstChart_SfSunburstChart_ToolbarSettings)</td>
</tr>
</table>

The following code example shows how to enable drill down in the sunburst chart:

<table>
<tr>
<th>Xamarin</th>
</tr>
<tr>
<td>

{% tabs %} 
{% highlight xaml %}

<ContentPage
    xmlns:sunburst="clr-namespace:Syncfusion.SfSunburstChart.XForms;assembly=Syncfusion.SfSunburstChart.XForms">

    <sunburst:SfSunburstChart EnableDrillDown="True"/>
    <!-- code omitted for brevity -->
</ContentPage>
{% endhighlight %}
{% highlight c# %}

using Syncfusion.SfSunburstChart.XForms;
// code omitted for brevity
SfSunburstChart sunburstChart = new SfSunburstChart();
sunburstChart.EnableDrillDown = true;
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
    xmlns:sunburst="clr-namespace:Syncfusion.Maui.SunburstChart;assembly=Syncfusion.Maui.SunburstChart">

    <sunburst:SfSunburstChart EnableDrillDown="True">
        <sunburst:SfSunburstChart.ToolbarSettings>
            <sunburst:SunburstToolbarSettings HorizontalAlignment="End"
                                              VerticalAlignment="End"/>
        </sunburst:SfSunburstChart.ToolbarSettings>
        <!-- code omitted for brevity -->
    </sunburst:SfSunburstChart>

</ContentPage>

{% endhighlight %}
{% highlight c# %}

using Syncfusion.Maui.SunburstChart;

SfSunburstChart sunburstChart = new SfSunburstChart();
sunburstChart.EnableDrillDown = true;
sunburstChart.ToolbarSettings = new SunburstToolbarSettings
{
    HorizontalAlignment = SunburstToolbarAlignment.End,
    VerticalAlignment = SunburstToolbarAlignment.End
};
// code omitted for brevity
this.Content = sunburstChart;

{% endhighlight %}

{% endtabs %}
</td>
</tr>
</table>

## Upcoming features in .NET MAUI Sunburst Chart

The following Xamarin features are not yet supported in the .NET MAUI SfSunburstChart:

* Legend item customization (`LabelStyle`, `IconType`, `ItemMargin`, `IconHeight`, `ItemWidth`).

## Support and feedback

If you are unable to find the migration information you require in the self-help resources listed above, please contact us by creating a [support ticket](https://internalsupport.bolddesk.com/agent/tickets/create). If you do not see what you need, please request it in our [feedback portal](https://www.syncfusion.com/feedback/maui).
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

    using Syncfusion.Maui.SfSunburstChart;
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
<td>ColorModel, CustomBrushes</td>
<td>PaletteBrushes</td>
</tr>
</table>



## Support and feedback

If you are unable to find the migration information you require in the self-help resources listed above, please contact us by creating a [support ticket](https://internalsupport.bolddesk.com/agent/tickets/create). Do not see what you need? Please request it in our [feedback portal](https://www.syncfusion.com/feedback/maui). 

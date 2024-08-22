---
layout: post
title: Migration from Xamarin to .NET MAUI Kanban Board control | Syncfusion
description: This section explains the features available in the NET MAUI Kanban Board (SfKanban) control over Xamarin SfKanban.
platform: maui
control: SfKanban
documentation: ug
keywords: migrate from xamarin.Forms SfKanban to .net maui SfKanban, transitioning from xamarin.Forms SfKanban to .net maui SfKanban, move from xamarin.Forms SfKanban to .net maui SfKanban, upgrading xamarin.Forms to .net maui SfKanban.
---

# Migrate from Xamarin.Forms SfKanban to .NET MAUI SfKanban

The Kanban Board was created from the scratch using the upgraded APIs and performance of the .NET MAUI graphics library and framework layouts. However, to maintain the consistency of the API naming in MAUI [SfKanban](), we renamed some of the APIs. The APIs changed in MAUI [SfKanban]() from Xamarin [SfKanban]() are detailed as follows:

## API migration

To initialize the control, import the Chart namespace and Initialize [SfKanban]() as shown in the following code sample. 

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
    xmlns:kanban="clr-namespace:Syncfusion.SfKanban.XForms;assembly=Syncfusion.SfKanban.XForms">

    <kanban:SfKanban/>
</ContentPage>
{% endhighlight %}

{% highlight C# %}
using Syncfusion.SfKanban.XForms;
...

SfKanban kanban = new SfKanban();
this.Content = kanban;

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
    xmlns:kanban="clr-namespace:Syncfusion.Maui.Kanban;assembly=Syncfusion.Maui.Kanban">
   
    <kanban:SfKanban/>
</ContentPage>
 
{% endhighlight %}

{% highlight C# %}

using Syncfusion.Maui.Kanban;
. . .
SfKanban kanban = new SfKanban();
this.Content = kanban;

{% endhighlight %}

{% endtabs %}
</td>
</tr>
</table>

The following table illustrates the API migration for the kanban.

### KanbanModel

<table>
<tr>
<th>Xamarin</th>
<th>.NET MAUI</th>
</tr>
<tr>
<td>ColorKey</td>
<td>IndicatorFill</td>
</tr>
</table>

### KanbanErrorBarSettings

<table>
<tr>
<th>Xamarin</th>
<th>.NET MAUI</th>
</tr>
<tr>
<td>Color</td>
<td>Fill</td>
</tr>
<tr>
<td>MaxValidationColor</td>
<td>MaxValidationFill</td>
</tr>
<tr>
<td>MinValidationColor</td>
<td>MinValidationFill</td>
</tr>
</table>

### KanbanPlaceholderStyle

<table>
<tr>
<tr>
<th>Xamarin</th>
<th>.NET MAUI</th></tr>
</tr>
<tr>
<td>BackgroundColor</td>
<td>Fill</td>
</tr>
<tr>
<td>BorderColor</td>
<td>Stroke</td>
</tr>
<tr>
<td>BorderThickness</td>
<td>StrokeWidth</td>
</tr>
<tr>
<td>SelectedBackgroundColor</td>
<td>SelectedFill</td>
</tr>
<tr>
<td>SelectedBorderColor</td>
<td>SelectedStroke</td>
</tr>
<tr>
<td>SelectedBorderThickness</td>
<td>SelectedStrokeWidth</td>
</tr>
</table>

## Support and feedback

If you are unable to find the migration information you require in the self-help resources listed above, please contact us by creating a [support ticket](https://internalsupport.bolddesk.com/agent/tickets/create). Do not see what you need? Please request it in our [feedback portal](https://www.syncfusion.com/feedback/maui). 

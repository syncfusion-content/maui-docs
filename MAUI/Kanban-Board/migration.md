---
layout: post
title: Migration from Xamarin to .NET MAUI Kanban Board control | Syncfusion®
description: This section explains the features available in the NET MAUI Kanban Board (SfKanban) control over Xamarin SfKanban.
platform: maui
control: SfKanban
documentation: ug
keywords: migrate from xamarin.Forms SfKanban to .net maui SfKanban, transitioning from xamarin.Forms SfKanban to .net maui SfKanban, move from xamarin.Forms SfKanban to .net maui SfKanban, upgrading xamarin.Forms to .net maui SfKanban.
---

# Migrate from Xamarin.Forms SfKanban to .NET MAUI SfKanban

The Kanban Board was created from the scratch using the upgraded APIs and performance of the .NET MAUI graphics library and framework layouts. However, to maintain the consistency of the API naming in MAUI [SfKanban](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.SfKanban.html), we renamed some of the APIs. The APIs changed in MAUI [SfKanban](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.SfKanban.html) from Xamarin [SfKanban](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.SfKanban.html) are detailed as follows:

## API migration

To initialize the control, import the Kanban namespace and Initialize [SfKanban](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.SfKanban.html) as shown in the following code sample. 

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

## Known issue

* **Smooth Drag Transition:** Drag transitions will be smoother on mobile devices.
* **Memory Optimization:** Control loading will be optimized for mobile devices.

## Upcoming features

* **Keep Card Support:** Retain specific cards in a column regardless of status changes.
* **Placeholder Customization:** Customize the placeholder displayed during drag-and-drop.
* **Multiple Category Support:** Assign cards to multiple categories for better organization.
* **Custom Empty Column Template:** Define a custom template for columns with no cards.

## Upcoming improvements

* **Drag UI Enhancements:** The drag UI and invalidation indicator will be improved.

## Support and feedback

If you are unable to find the migration information you require in the self-help resources listed above, please contact us by creating a [support ticket](https://internalsupport.bolddesk.com/agent/tickets/create). Do not see what you need? Please request it in our [feedback portal](https://www.syncfusion.com/feedback/maui). 
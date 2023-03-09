---
layout: post
title: Scrolling in .NET MAUI DataGrid control | Syncfusion
description: Learn here all about Scrolling support in Syncfusion .NET MAUI DataGrid (SfDataGrid) control and more.
platform: MAUI
control: SfDataGrid
documentation: UG
---

# Scrolling in MAUI DataGrid (SfDataGrid)

## Programmatic scrolling

The [SfDataGrid](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html) allows scrolling to a particular row and column index programmatically. It also enables and disables the scrolling animation when changing the view. By default, the scrolling will be animated.

You can set position of item in view while scrolling by passing ScrollToPosition to ScrollToRowIndex, ScrollToColumnIndex and ScrollToRowColumnIndex method. Below are four different types of positions:

* `MakeVisible`: Scrolls a specific item to make visible in the view. If the item is already in view, scrolling will not occur.
* `Start`: Scrolls a specific item to be positioned at the begin of the view.
* `End`: Scrolls a specific item to be positioned at the end of the view.
* `Center`: Scrolls a specific item to be positioned at the center of the view.

### Scrolling to the row and column index

You can scroll programmatically to a particular row and column using the `SfDataGrid.ScrollToRowColumnIndex` method by passing the row and column index.

{% tabs %}
{% highlight C# %}
dataGrid.ScrollToRowColumnIndex(int rowIndex, int columnIndex);

//For example 
dataGrid.ScrollToRowColumnIndex(20, 6);
{% endhighlight %}
{% endtabs %}

### Scrolling to the row index

You can scroll programmatically to a particular row using the `SfDataGrid.ScrollToRowIndex` method by passing the row index.

{% tabs %}
{% highlight C# %}
dataGrid.ScrollToRowIndex(int rowIndex);

//For example 
dataGrid.ScrollToRowIndex(20);
{% endhighlight %}
{% endtabs %}

### Scrolling to the column index

You can scroll programmatically to a particular column using the `SfDataGrid.ScrollToColumnIndex` method by passing the column index.

{% tabs %}
{% highlight C# %}
dataGrid.ScrollToColumnIndex(int columnIndex);

//For example
dataGrid.ScrollToColumnIndex(7);
{% endhighlight %}
{% endtabs %}
---
layout: post
title: Freeze Panes in .NET MAUI Tree Grid | Syncfusion®
description: Learn how to freeze columns in Syncfusion® .NET MAUI Tree Grid to keep specific columns visible while scrolling horizontally through large datasets.
platform: MAUI
control: STreeGrid
documentation: UG
keywords : maui tree grid, maui treegrid, maui grid, grid maui, maui gridview, grid in maui, .net maui treegrid, .net maui grid, .net grid maui, freeze panes, freeze columns
---

# Freeze Panes in .NET MAUI Tree Grid

## Overview

Freezing panes allows you to keep specific columns visible while scrolling horizontally through large datasets, similar to Excel. This is useful when you have identifier columns that should remain visible during navigation.

The .NET MAUI TreeGrid (`SfTreeGrid`) control supports freezing columns independently at the left and right edges of the grid.

---

## Freeze Panes Properties

You can freeze columns by setting the following properties on the [SfTreeGrid]():

| Property Name | Type | Default | Description |
|--------------|------|---------|-------------|
| `FrozenColumnCount` | `int` | `0` | Sets the number of columns to freeze at the left side of the TreeGrid. |
| `FooterFrozenColumnCount` | `int` | `0` | Sets the number of columns to freeze at the right side of the TreeGrid. |

## Freeze Columns

You can freeze columns by setting the [FrozenColumnCount]() property to a non-negative value. Frozen columns remain visible when scrolling horizontally and are useful for identifier columns that should always be visible.

{% tabs %}
{% highlight xaml %}

<ContentPage.BindingContext>
    <local:EmployeeViewModel />
</ContentPage.BindingContext>

<syncfusion:SfTreeGrid
    x:Name = "treeGrid"
    ItemsSource = "{Binding Employees}"
    ChildPropertyName = "ReportingPeople"
    FrozenColumnCount = "1" />

{% endhighlight %}
{% highlight c# %}

// Freezes the first column.
treeGrid.FrozenColumnCount = 1;

{% endhighlight %}
{% endtabs %}

<img alt="Tree Grid with Freeze pane UI" src="Images\freeze-panes\maui-treegrid-freezepane-frozencolumn-count.gif" width="404"/>

The frozen column remains visible at the left edge while scrolling horizontally through the remaining columns.

> **Note:** FrozenColumnCount must be less than the total number of columns in the TreeGrid. When FrozenColumnCount is set to `0`, no columns are frozen on the left side.

## Freeze Footer Columns

You can freeze footer (rightmost) columns by setting the [FooterFrozenColumnCount]() property to a non-negative value. Footer frozen columns remain visible when scrolling horizontally and are useful for summary or action columns.

{% tabs %}
{% highlight xaml %}

<ContentPage.BindingContext>
    <local:EmployeeViewModel />
</ContentPage.BindingContext>

<syncfusion:SfTreeGrid
    x:Name = "treeGrid"
    ItemsSource = "{Binding Employees}"
    ChildPropertyName = "ReportingPeople"
    FooterFrozenColumnCount = "1" />

{% endhighlight %}
{% highlight c# %}

// Freezes the last column.
treeGrid.FooterFrozenColumnCount = 1;

{% endhighlight %}
{% endtabs %}

<img alt="Tree Grid with Freeze pane UI" src="Images\freeze-panes\maui-treegrid-freezepane-footerfrozencolumn-count.gif" width="404"/>

The frozen footer column remains visible at the right edge while scrolling horizontally through the remaining columns.

> **Note:** FooterFrozenColumnCount must be less than the total number of columns in the TreeGrid. The combined count of `FrozenColumnCount` and `FooterFrozenColumnCount` must not exceed the total number of columns.

## Appearance

You can customize the visual appearance of freeze panes using [TreeGridStyle](). Apply this style through the `SfTreeGrid.DefaultStyle` property.

### Freeze Pane Line Color

Customize the color of the line that divides frozen and non-frozen regions using the [TreeGridStyle.FreezePaneLineColor]() property.

{% tabs %}
{% highlight xaml %}

<ContentPage.BindingContext>
    <local:EmployeeViewModel />
</ContentPage.BindingContext>

<syncfusion:SfTreeGrid
    x:Name = "treeGrid"
    ItemsSource = "{Binding Employees}"
    ChildPropertyName = "ReportingPeople"
    FrozenColumnCount = "1">

    <syncfusion:SfTreeGrid.DefaultStyle>
        <syncfusion:TreeGridStyle
            FreezePaneLineColor = "Orange" />
    </syncfusion:SfTreeGrid.DefaultStyle>

</syncfusion:SfTreeGrid>

{% endhighlight %}
{% endtabs %}

<img alt="Tree Grid with Freeze pane UI" src="Images\freeze-panes\maui-treegrid-freezepane-linecolor.png" width="404"/>

### Freeze Pane Line Thickness

Customize the thickness of the freeze pane line using the [TreeGridStyle.FreezePaneLineStrokeThickness]() property. This affects all frozen columns in both left and right regions.

**Default Value:** `1.0`

{% tabs %}
{% highlight xaml %}

<ContentPage.BindingContext>
    <local:EmployeeViewModel />
</ContentPage.BindingContext>

<syncfusion:SfTreeGrid
    x:Name = "treeGrid"
    ItemsSource = "{Binding Employees}"
    ChildPropertyName = "ReportingPeople"
    FrozenColumnCount = "1">

    <syncfusion:SfTreeGrid.DefaultStyle>
        <syncfusion:TreeGridStyle
            FreezePaneLineStrokeThickness = "2" />
    </syncfusion:SfTreeGrid.DefaultStyle>

</syncfusion:SfTreeGrid>

{% endhighlight %}
{% endtabs %}

<img alt="Tree Grid with Freeze pane UI" src="Images\freeze-panes\maui-treegrid-freezepane-stroke-thickness.png" width="404"/>
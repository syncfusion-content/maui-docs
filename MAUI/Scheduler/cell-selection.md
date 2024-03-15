---
layout: post
title: Cell selection in the .NET MAUI Scheduler | Syncfusion
description: Learn how to customize the cell selection in Syncfusion .NET MAUI Scheduler (SfScheduler) control here.
platform: maui
control: SfScheduler
documentation: ug
---

# Cell Selection View in .NET MAUI Event Scheduler (SfScheduler).

The Scheduler provides the capability to customize the selection of month and timeslot cells using the `cellselectionview`.

## Stroke

The cell selection border color can be customized by using the `Stroke` property in the `CellSelectionView`.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="3" %}

<scheduler:SfScheduler x:Name="Scheduler">
    <scheduler:SfScheduler.CellSelectionView>
            <scheduler:SchedulerCellSelectionView Stroke="Red"/>
    </scheduler:SfScheduler.CellSelectionView>
</scheduler:SfScheduler>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="2" %}
this.Scheduler.CellSelectionView.Stroke = Brush.Green;
{% endhighlight %}
{% endtabs %}

![customize-border-color-in-cell-selection-in-maui-scheduler](images/cell-selection/border-color-in-maui-scheduler.jpeg)

## Background

The cell selection background color can be customized by using the `Background` property in the `CellSelectionView`.
The default value is Brush.Transparent.

Note: As default, `stroke` will have value; if background alone is required, you can set the stroke property to transparent.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="3" %}

<scheduler:SfScheduler x:Name="Scheduler">
    <scheduler:SfScheduler.CellSelectionView>
            <scheduler:SchedulerCellSelectionView Background="Red" Stroke="Transparent"/>
    </scheduler:SfScheduler.CellSelectionView>
</scheduler:SfScheduler>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="2" %}
this.Scheduler.CellSelectionView.Background = Brush.Green;
{% endhighlight %}
{% endtabs %}

![customize-background-color-in-cell-selection-in-maui-scheduler](images/cell-selection/background-color-in-maui-scheduler.jpeg)

## Corner Radius

The corner radius of cell selection view can be customized by using the `CornerRadius` property in the `CellSelectionView`.  

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="3" %}

<scheduler:SfScheduler x:Name="Scheduler">
    <scheduler:SfScheduler.CellSelectionView>
            <scheduler:SchedulerCellSelectionView  Background="Red" CornerRadius="2"/>
    </scheduler:SfScheduler.CellSelectionView>
</scheduler:SfScheduler>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="2" %}
this.Scheduler.CellSelectionView.Stroke = Brush.Green;
this.Scheduler.CellSelectionView.CornerRadius = 2;
{% endhighlight %}
{% endtabs %}

![customize-corner-radius-in-cell-selection-in-maui-scheduler](images/cell-selection/corner-radius-in-maui-scheduler.jpeg)

## Stroke Thickness

The thickness of the `Stroke` of Scheduler can be customized by using the `StrokeWidth` property in the `CellSelectionView`.  

Note: The `StrokeWidth` is only applicable for `Stroke` property.


{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="3" %}

<scheduler:SfScheduler x:Name="Scheduler">
    <scheduler:SfScheduler.CellSelectionView>
            <scheduler:SchedulerCellSelectionView  Stroke="Red" StrokeWidth="2"/>
    </scheduler:SfScheduler.CellSelectionView>
</scheduler:SfScheduler>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="2" %}
this.Scheduler.CellSelectionView.Stroke = Brush.Green;
this.Scheduler.CellSelectionView.StrokeWidth = 2;
{% endhighlight %}
{% endtabs %}

![customize-stroke-thickness-in-cell-selection-in-maui-scheduler](images/cell-selection/stroke-thickness-in-maui-scheduler.jpeg)

## Template

The scheduler allows you to use the custom view as a selection view by using the `Template` property in the `CellSelectionView`.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="3" %}

<scheduler:SfScheduler.CellSelectionView>
    <scheduler:SchedulerCellSelectionView>
        <scheduler:SchedulerCellSelectionView.Template>
            <DataTemplate>
                <Button BackgroundColor = "#FF9800"
                        Text="+ Add event"
                        TextColor="White"/>
            </DataTemplate>
        </scheduler:SchedulerCellSelectionView.Template>
    </scheduler:SchedulerCellSelectionView>
</scheduler:SfScheduler.CellSelectionView>

{% endhighlight %}
{% endtabs %}

![customize-template-in-cell-selection-in-maui-scheduler](images/cell-selection/template-in-maui-scheduler.jpeg)

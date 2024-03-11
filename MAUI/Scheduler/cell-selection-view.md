---
layout: cell-selection
title: Cell selection in the .NET MAUI Scheduler | Syncfusion
description: Learn here all about how to customize the cell selection in Syncfusion .NET MAUI Scheduler (SfScheduler) control.
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

## Background

The cell selection background color can be customized by using the `Background` property in the `CellSelectionView`.
The default value is Brush.Transparent.

Note: As default `stroke` will have value, if background alone required, you can set stroke property to Transparent.

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
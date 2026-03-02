---
layout: post
title: Cell selection in the .NET MAUI Scheduler | Syncfusion
description: Learn how to customize the cell selection in Syncfusion<sup>&reg;</sup> .NET MAUI Scheduler (SfScheduler) control here.
platform: maui
control: SfScheduler
documentation: ug
---

# Cell Selection View in .NET MAUI Event Scheduler (SfScheduler).

The Scheduler provides the capability to customize the selection of month and timeslot cells using the [Cellselectionview](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SfScheduler.html#Syncfusion_Maui_Scheduler_SfScheduler_CellSelectionView).

## Stroke

The cell selection border color can be customized by using the [Stroke](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerCellSelectionView.html#Syncfusion_Maui_Scheduler_SchedulerCellSelectionView_Stroke) property in the [Cellselectionview](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerCellSelectionView.html).

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

The cell selection background color can be customized by using the [Background](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerCellSelectionView.html#Syncfusion_Maui_Scheduler_SchedulerCellSelectionView_Background) property in the [Cellselectionview](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerCellSelectionView.html).
The default value is `Brush.Transparent`.

N> As default, [Stroke](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerCellSelectionView.html#Syncfusion_Maui_Scheduler_SchedulerCellSelectionView_Stroke) will have value; if [Background](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerCellSelectionView.html#Syncfusion_Maui_Scheduler_SchedulerCellSelectionView_Background) alone is required, you can set the  [Stroke](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerCellSelectionView.html#Syncfusion_Maui_Scheduler_SchedulerCellSelectionView_Stroke) property to `Brush.Transparent`.

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

The corner radius of cell selection view can be customized by using the [CornerRadius](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerCellSelectionView.html#Syncfusion_Maui_Scheduler_SchedulerCellSelectionView_CornerRadius) property in the [Cellselectionview](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerCellSelectionView.html). 

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

The thickness of the selection view [Stroke](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerCellSelectionView.html#Syncfusion_Maui_Scheduler_SchedulerCellSelectionView_Stroke) can be customized by using the [StrokeWidth](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerCellSelectionView.html#Syncfusion_Maui_Scheduler_SchedulerCellSelectionView_StrokeWidth) property in the [Cellselectionview](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerCellSelectionView.html).

N> The [StrokeWidth](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerCellSelectionView.html#Syncfusion_Maui_Scheduler_SchedulerCellSelectionView_StrokeWidth) is only applicable for the [Stroke](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerCellSelectionView.html#Syncfusion_Maui_Scheduler_SchedulerCellSelectionView_Stroke) property.

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

The scheduler allows you to use the custom view as a selection view by using the [Template](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerCellSelectionView.html#Syncfusion_Maui_Scheduler_SchedulerCellSelectionView_Template) property in the [Cellselectionview](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerCellSelectionView.html).

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

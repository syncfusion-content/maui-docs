---
layout: post
title: Cell selection view in .NET MAUI Scheduler | Syncfusion
description: Learn here all about how to customize the cell selection in Syncfusion .NET MAUI Scheduler (SfScheduler) control, its elements, and more.
platform: maui
control: SfScheduler
documentation: ug
---

# Cell Selection View in .NET MAUI Event Scheduler (SfScheduler).

The Scheduler provides the capability to customize the selection of cell in all views using the cellselectionview.


## Cell selection using Stroke

The selection view of Scheduler can be customized by using the `Stroke` property in the `CellSelectionView`.  

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

## Cell selection using Background

The selection view of Scheduler can be customized by using the `Background` property in the `CellSelectionView`.  

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

## Cell selection using Background and stroke

The selection view of Scheduler can be customized by using the `Background` and `Stroke` properties in the `CellSelectionView`.  

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="3" %}

<scheduler:SfScheduler x:Name="Scheduler">
    <scheduler:SfScheduler.CellSelectionView>
            <scheduler:SchedulerCellSelectionView Background="Red" Stroke="Black"/>
    </scheduler:SfScheduler.CellSelectionView>
</scheduler:SfScheduler>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="2" %}
this.Scheduler.CellSelectionView.Background = Brush.Green;
this.Scheduler.CellSelectionView.Stroke = Brush.Black;
{% endhighlight %}
{% endtabs %}

## Cell selection using Template

The selection view of Scheduler can be customized by using the `Template` property in the `CellSelectionView` can be used to add data template on the selected cell.  

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
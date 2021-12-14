---
layout: post
title: Date Navigations in .NET MAUI Scheduler control | Syncfusion
description: Learn here all about Date Navigations feature of Syncfusion .NET MAUI Scheduler (SfScheduler) control and more.
platform: maui
control: SfScheduler
documentation: ug
---

# Date Navigations in .NET MAUI Scheduler 

## Programmatic date navigation

By using the `DisplayDate` property of SfScheduler, programmatically navigate dates in scheduler.

{% tabs %}
{% highlight xaml %}

<scheduler:SfScheduler x:Name="Scheduler" 
                       View="Week">
</scheduler:SfScheduler>

{% endhighlight %}
{% highlight c# %}

this.Scheduler.DisplayDate = DateTime.Today.AddMonths(-1).AddHours(9);

{% endhighlight %}
{% endtabs %}

N> 
When navigating before a minimum date, the date will be reset to the scheduler minimum date, and when navigating beyond a maximum date, the date will be reset to the scheduler maximum date.

## Programmatic date selection

You can programmatically select the dates in scheduler by using the `SelectedDate` property of SfScheduler.

{% tabs %}
{% highlight xaml %}

<scheduler:SfScheduler x:Name="Scheduler" 
                       View="Week">
</scheduler:SfScheduler>

{% endhighlight %}
{% highlight c# %}

this.Scheduler.SelectedDate = DateTime.Today.AddHours(9);

{% endhighlight %}
{% endtabs %}

N> It is not possible to use the `SelectedDate` to select before minimum display date time and beyond maximum display date time.

## Programmatically change to adjacent dates

The next and previous views can be accessed through swiping the control from right to left and left to right. With SfScheduler, the view can be changed programmatically as well.

### Forward

The Scheduler allows you to view the next immediate date using the `Forward` method. If the scheduler view is month, it moves on to the next month, similarly for week and day views it moves on to the next day.

{% tabs %}
{% highlight xaml %}

<Grid>
    <Grid.RowDefinitions>
        <RowDefinition />
        <RowDefinition Height="30" />
    </Grid.RowDefinitions>
    <scheduler:SfScheduler x:Name="Scheduler" 
                           View="Week" >
    </scheduler:SfScheduler>
    <Button x:Name="button" Text="Forward" Clicked="OnButtonClicked" GridLayout.Row="1" HorizontalOptions="FillAndExpand" VerticalOptions="FillAndExpand" />
</Grid>

{% endhighlight %}
{% highlight c# %}

this.button.Clicked += OnButtonClicked;

private void OnButtonClicked(object sender, EventArgs e)
{
    this.Scheduler.Forward();
}

{% endhighlight %}
{% endtabs %}

### Backward

The Scheduler allows you to view the previous immediate date using the `Backward` method. If the scheduler view is month, it moves on to the previous month, similarly for week and day views it moves on to the previous day.

{% tabs %}
{% highlight xaml %}

<Grid>
    <Grid.RowDefinitions>
        <RowDefinition />
        <RowDefinition Height="30" />
    </Grid.RowDefinitions>
    <scheduler:SfScheduler x:Name="Scheduler" 
                           View="Week" >
    </scheduler:SfScheduler>
    <Button x:Name="button" Text="Backward" Clicked="OnButtonClicked" GridLayout.Row="1" HorizontalOptions="FillAndExpand" VerticalOptions="FillAndExpand" />
</Grid>

{% endhighlight %}
{% highlight c# %}

this.button.Clicked += OnButtonClicked;

private void OnButtonClicked(object sender, EventArgs e)
{
    this.Scheduler.Backward();
}

{% endhighlight %}
{% endtabs %}

## Allowed views

The SfScheduler allows you to quickly switch between the different scheduler views using the `AllowedViews` property. These views will display as a button in the scheduler header.
There will be more icons available for all platforms as this UI will be responsive.

The default value of `AllowedViews` property is `SchedulerViews.Default.`

{% tabs %}
{% highlight xaml %}

<scheduler:SfScheduler x:Name="Scheduler" 
                       AllowedViews="Day,Week,WorkWeek,Month,TimelineDay,TimelineWeek,TimelineWorkWeek,TimelineMonth" >
</scheduler:SfScheduler>

{% endhighlight %}
{% highlight c#%}

this.Scheduler.AllowedViews = SchedulerViews.Day | SchedulerViews.Week | SchedulerViews.WorkWeek | SchedulerViews.Month | SchedulerViews.TimelineDay | SchedulerViews.TimelineWeek | SchedulerViews.TimelineWorkWeek | SchedulerViews.TimelineMonth;

{% endhighlight %}
{% endtabs %}

N>
The SfScheduler `view` will be restricted based on the  `AllowedViews.` For example, the `AllowedViews` given as `Day,` `Week,` `WorkWeek,` and if the `View` given as `Month,` this will be reset to AllowedViews first value.
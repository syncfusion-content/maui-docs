---
layout: post
title: Date navigations in .NET MAUI Scheduler control | Syncfusion
description: Learn here all about date navigations and restriction feature of Syncfusion .NET MAUI Scheduler (SfScheduler) control and more.
platform: maui
control: SfScheduler
documentation: ug
---

# Date navigation and restriction in .NET MAUI Scheduler

## Date navigation

The `.NET MAUI Scheduler` control allows to navigate through dates either programmatically or by using the `forward` and `backward` buttons, and it is applicable to all the Scheduler views.

N> 
Touch gesture is not working, as framework is facing an [issue](https://github.com/dotnet/maui/issues/3561) 

### Programmatic date navigation

The `DisplayDate` property of `SfScheduler` programmatically navigates the dates in scheduler.

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

### Programmatic date selection

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

### Programmatically change to adjacent dates

The next and previous views can be accessed through swiping the control from right to left and left to right. With SfScheduler, the view can be changed programmatically as well.

#### Forward

The Scheduler allows to view the next immediate date using the `Forward` method. If the scheduler view is month, it moves on to the next month, similarly for week and day views it moves on to the next day.

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

#### Backward

The Scheduler allows to view the previous immediate date using the `Backward` method. If the scheduler view is month, it moves on to the previous month, similarly for week and day views it moves on to the previous day.

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

### Allowed views

The SfScheduler allows to quickly switch between the different scheduler views using the `AllowedViews` property. These views will display as a button in the scheduler header.
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

## Date restrictions

In .NET MAUI Scheduler, you can restrict the available dates to a range of dates using the properties `MinimumDateTime,` `MaximumDateTime` and `SelectableDayPredicate.` It is applicable to all the Scheduler views.

### Change minimum display date and time

The minimum date time will restrict backward navigation of date selections as well as the ability to swipe the views beyond the minimum date range. Any dates that appear before the minimum date will be disabled. The default value of `MinimumDateTime` is `DateTime.MinValue.`

{% tabs %}
{% highlight xaml %}

<scheduler:SfScheduler x:Name="Scheduler" 
                       View="Week">
</scheduler:SfScheduler>

{% endhighlight %}
{% highlight c# %}

this.Scheduler.MinimumDateTime = DateTime.Today.AddMonths(-3).AddHours(9);

{% endhighlight %}
{% endtabs %}

### Change maximum display date and time

The maximum date time will restrict forward navigation of date selections as well as the ability to swipe the views beyond the maximum date range. Any dates that appear after the maximum date will be disabled. The default value of `MaximumDateTime` is `DateTime.MaxValue .`

{% tabs %}
{% highlight xaml %}

<scheduler:SfScheduler x:Name="Scheduler" 
                       View="Week">
</scheduler:SfScheduler>

{% endhighlight %}
{% highlight c# %}

this.Scheduler.MaximumDateTime = DateTime.Today.AddMonths(3).AddHours(12);

{% endhighlight %}
{% endtabs %}

### Selectable day predicate (Blackout dates)

The `SelectableDayPredicate` functions allows certain days for selection. Only the days that `SelectableDayPredicate` returns true will be selectable in the Scheduler.

{% tabs %}
{% highlight xaml %}

<scheduler:SfScheduler x:Name="Scheduler" 
                       View="Week">
</scheduler:SfScheduler>

{% endhighlight %}
{% highlight c# %}

this.Scheduler.SelectableDayPredicate = (date) =>
{
    if (date.DayOfWeek == DayOfWeek.Sunday || date.DayOfWeek == DayOfWeek.Saturday)
    {
        return false;
    }

    return true;
};

{% endhighlight %}
{% endtabs %}

#### Customizing the disabled date and time appearance

You can customize the background color and text style for the minimum date time, maximum date time, and selectable day predicate, by setting the `Background,` and `DisabledDateTextStyle` properties of `SfScheduler.`

{% tabs %}
{% highlight xaml %}

<scheduler:SfScheduler x:Name="Scheduler" 
                       View="Week">
</scheduler:SfScheduler>

{% endhighlight %}
{% highlight c# %}

var disabledDateTextStyle = new SchedulerTextStyle()
{
    TextColor = Colors.Red,
    FontSize = 12,
};

this.Scheduler.DisabledDateTextStyle = disabledDateTextStyle;
this.Scheduler.DisabledDateBackground = Brush.LightSkyBlue;

{% endhighlight %}
{% endtabs %}

N>
* The `DisabledDateTextStyle` and `DisabledDateBackground` properties will be applicable for the following properties such as `MinimumDateTime,` `MaximumDateTime,` and `SelectableDayPredicate` of the `SfScheduler.`
* The `DisabledDateBackground` property is not applicable for month cells and view header cells.
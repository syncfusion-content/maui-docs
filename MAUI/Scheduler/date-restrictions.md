---
layout: post
title: Date Restriction in .NET MAUI Scheduler control | Syncfusion
description: Learn here all about Date restrictions feature of Syncfusion .NET MAUI Scheduler (SfScheduler) control and more.
platform: maui
control: SfScheduler
documentation: ug
---

# Date Restrictions in .NET MAUI Scheduler (SfScheduler)

## Range for visible dates

In .NET MAUI Scheduler, you can restrict the available dates to a range of dates using the properties `MinimumDateTime` and `MaximumDateTime.` It is applicable to the all Scheduler views.

## Change minimum display date and time

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

## Change maximum display date and time

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

## Selectable day predicate(Blackout dates)

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

### Customize the minimum date time, maximum date time and selectable day predicate appearance

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
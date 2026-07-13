---
layout: post
title: Date Restriction in .NET MAUI Date Picker Control | Syncfusion®
description: Learn about date restriction support in Syncfusion<sup>&reg;</sup> .NET MAUI Date Picker (SfDatePicker) control and its basic features.
platform: maui
control: SfDatePicker
documentation: ug
---

# Date Restriction in .NET MAUI Date Picker (SfDatePicker)

## Minimum Date

The Date Picker provides an option to restrict the selection of date items by using the [MinimumDate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDatePicker.html#Syncfusion_Maui_Picker_SfDatePicker_MinimumDate) property in [SfDatePicker](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDatePicker.html). You cannot select dates before the minimum date. The MinimumDate value must be less than the MaximumDate value.

{% tabs %}
{% highlight xaml tabtitle="XAML" hl_lines="5" %}

<ContentPage
             . . .
             xmlns:picker="clr-namespace:Syncfusion.Maui.Picker;assembly=Syncfusion.Maui.Picker">
    <picker:SfDatePicker x:Name="picker"
                         MinimumDate="2000/05/15">
    </picker:SfDatePicker>
</ContentPage>

{% endhighlight %}
{% highlight c# tabtitle="C#" hl_lines="5" %}

using Syncfusion.Maui.Picker;

. . .
SfDatePicker picker = new SfDatePicker();
picker.MinimumDate = new DateTime(2000, 05, 15);
this.Content = picker;

{% endhighlight %}  
{% endtabs %}

![Minimum date in .NET MAUI Date Picker.](images/date-restrictions/maui-date-picker-minimum-date.png)

## Maximum Date

The Date Picker provides an option to restrict the selection of date items by using the [MaximumDate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDatePicker.html#Syncfusion_Maui_Picker_SfDatePicker_MaximumDate) property in [SfDatePicker](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDatePicker.html). You cannot select dates after the maximum date.

{% tabs %}
{% highlight xaml tabtitle="XAML" hl_lines="5" %}

<ContentPage
             . . .
             xmlns:picker="clr-namespace:Syncfusion.Maui.Picker;assembly=Syncfusion.Maui.Picker">
    <picker:SfDatePicker x:Name="picker"
                         MaximumDate="2042/10/10">
    </picker:SfDatePicker>
</ContentPage>

{% endhighlight %}
{% highlight c# tabtitle="C#" hl_lines="5" %}

using Syncfusion.Maui.Picker;

. . .
SfDatePicker picker = new SfDatePicker();
picker.MaximumDate = new DateTime(2042, 10, 10);
this.Content = picker;

{% endhighlight %}  
{% endtabs %}

![Maximum date in .NET MAUI Date Picker.](images/date-restrictions/maui-date-picker-maximum-date.png)

## Blackout Dates

The [BlackoutDates](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDatePicker.html#Syncfusion_Maui_Picker_SfDatePicker_BlackoutDates) property in the [SfDatePicker](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDatePicker.html) lets you restrict the selection of specific dates by providing a list of dates to disable.

{% tabs %}
{% highlight xaml tabtitle="XAML" %}

<ContentPage
             . . .
             xmlns:picker="clr-namespace:Syncfusion.Maui.Picker;assembly=Syncfusion.Maui.Picker">
    <picker:SfDatePicker x:Name="picker">
        <picker:SfDatePicker.BlackoutDates>
            <date:DateTime>2001-08-03</date:DateTime>
            <date:DateTime>2001-08-10</date:DateTime>
            <date:DateTime>2001-08-12</date:DateTime>
            <date:DateTime>2001-08-14</date:DateTime>
            <date:DateTime>2001-08-17</date:DateTime>
            <date:DateTime>2001-08-18</date:DateTime>
            <date:DateTime>2001-08-20</date:DateTime>
            <date:DateTime>2001-08-23</date:DateTime>
            <date:DateTime>2001-08-27</date:DateTime>
        </picker:SfDatePicker.BlackoutDates>
    </picker:SfDatePicker>
</ContentPage>

{% endhighlight %}
{% highlight c# tabtitle="C#" %}

using Syncfusion.Maui.Picker;

. . .
SfDatePicker picker = new SfDatePicker();
picker.BlackoutDates.Add(new DateTime(2001, 8, 3));
picker.BlackoutDates.Add(new DateTime(2001, 8, 10));
picker.BlackoutDates.Add(new DateTime(2001, 8, 12));
picker.BlackoutDates.Add(new DateTime(2001, 8, 14));
picker.BlackoutDates.Add(new DateTime(2001, 8, 17));
picker.BlackoutDates.Add(new DateTime(2001, 8, 18));
picker.BlackoutDates.Add(new DateTime(2001, 8, 20));
picker.BlackoutDates.Add(new DateTime(2001, 8, 23));
picker.BlackoutDates.Add(new DateTime(2001, 8, 27));
this.Content = picker;

{% endhighlight %}  
{% endtabs %}

![Blackout dates in .NET MAUI Date Picker.](images/date-restrictions/maui-date-picker-blackout-dates.png)

N> The `Selection View` will not be applicable when setting `BlackoutDates`.
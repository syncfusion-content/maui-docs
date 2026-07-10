---
layout: post
title: Date Time intervals in Date Time Picker Control | Syncfusion®
description: Learn about date time intervals in Syncfusion<sup>&reg;</sup> .NET MAUI Date Time Picker (SfDateTimePicker) control and its basic features.
platform: maui
control: SfDateTimePicker
documentation: ug
---

# Date Time intervals in .NET MAUI Date Time Picker (SfDateTimePicker)
The `SfDateTimePicker` provides seven intervals in [.NET MAUI Date Time Picker](https://www.syncfusion.com/maui-controls/maui-datetimepicker). Use these to control the step size shown for each date or time column.

 * [`DayInterval`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDateTimePicker.html#Syncfusion_Maui_Picker_SfDateTimePicker_DayInterval)
 * [`MonthInterval`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDateTimePicker.html#Syncfusion_Maui_Picker_SfDateTimePicker_MonthInterval)
 * [`YearInterval`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDateTimePicker.html#Syncfusion_Maui_Picker_SfDateTimePicker_YearInterval)
 * [`HourInterval`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDateTimePicker.html#Syncfusion_Maui_Picker_SfDateTimePicker_HourInterval)
 * [`MinuteInterval`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDateTimePicker.html#Syncfusion_Maui_Picker_SfDateTimePicker_MinuteInterval)
 * [`SecondInterval`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDateTimePicker.html#Syncfusion_Maui_Picker_SfDateTimePicker_SecondInterval)
 * [`MilliSecondInterval`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDateTimePicker.html#Syncfusion_Maui_Picker_SfDateTimePicker_MilliSecondInterval)

## Day interval
Sets the interval between days using the [DayInterval](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDateTimePicker.html#Syncfusion_Maui_Picker_SfDateTimePicker_DayInterval) property of [SfDateTimePicker](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDateTimePicker.html).

{% tabs %}
{% highlight xaml tabtitle="XAML" hl_lines="2" %}

<ContentPage
    . . .
    xmlns:picker="clr-namespace:Syncfusion.Maui.Picker;assembly=Syncfusion.Maui.Picker">
    <picker:SfDateTimePicker x:Name="picker"
                             DayInterval="2"/>
</ContentPage>

{% endhighlight %}
{% highlight c# tabtitle="C#" hl_lines="2" %}

using Syncfusion.Maui.Picker;
. . .
public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        SfDateTimePicker picker = new SfDateTimePicker();
        picker.DayInterval = 2;
        this.Content = picker;
    }
}

{% endhighlight %}
{% endtabs %}

   ![Day interval in .NET MAUI Date Time picker.](images/intervals/maui-date-time-picker-day-interval.png)

## Month interval
Sets the interval between months using the [MonthInterval](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDateTimePicker.html#Syncfusion_Maui_Picker_SfDateTimePicker_MonthInterval) property of [SfDateTimePicker](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDateTimePicker.html).

{% tabs %}
{% highlight xaml tabtitle="XAML" hl_lines="2" %}

<ContentPage
    . . .
    xmlns:picker="clr-namespace:Syncfusion.Maui.Picker;assembly=Syncfusion.Maui.Picker">
    <picker:SfDateTimePicker x:Name="picker"
                             MonthInterval="2"/>
</ContentPage>

{% endhighlight %}
{% highlight c# tabtitle="C#" hl_lines="2" %}

using Syncfusion.Maui.Picker;
. . .
public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        SfDateTimePicker picker = new SfDateTimePicker();
        picker.MonthInterval = 2;
        this.Content = picker;
    }
}

{% endhighlight %}
{% endtabs %}

   ![Month interval in .NET MAUI Date Time Picker.](images/intervals/maui-date-time-picker-month-interval.png)

## Year interval
Sets the interval between years using the [YearInterval](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDateTimePicker.html#Syncfusion_Maui_Picker_SfDateTimePicker_YearInterval) property of [SfDateTimePicker](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDateTimePicker.html).

{% tabs %}
{% highlight xaml tabtitle="XAML" hl_lines="2" %}

<ContentPage
    . . .
    xmlns:picker="clr-namespace:Syncfusion.Maui.Picker;assembly=Syncfusion.Maui.Picker">
    <picker:SfDateTimePicker x:Name="picker"
                             YearInterval="2"/>
</ContentPage>

{% endhighlight %}
{% highlight c# tabtitle="C#" hl_lines="2" %}

using Syncfusion.Maui.Picker;
. . .
public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        SfDateTimePicker picker = new SfDateTimePicker();
        picker.YearInterval = 2;
        this.Content = picker;
    }
}

{% endhighlight %}
{% endtabs %}

   ![Year interval in .NET MAUI Date Time picker.](images/intervals/maui-date-time-picker-year-interval.png)

## Hour interval
Sets the interval between hours using the [HourInterval](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDateTimePicker.html#Syncfusion_Maui_Picker_SfDateTimePicker_HourInterval) property of [SfDateTimePicker](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDateTimePicker.html).

{% tabs %}
{% highlight xaml tabtitle="XAML" hl_lines="2" %}

<ContentPage
    . . .
    xmlns:picker="clr-namespace:Syncfusion.Maui.Picker;assembly=Syncfusion.Maui.Picker">
    <picker:SfDateTimePicker x:Name="picker"
                             HourInterval="2"/>
</ContentPage>

{% endhighlight %}
{% highlight c# tabtitle="C#" hl_lines="2" %}  

using Syncfusion.Maui.Picker;
. . .
public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        SfDateTimePicker picker = new SfDateTimePicker();
        picker.HourInterval = 2;
        this.Content = picker;
    }
}

{% endhighlight %}
{% endtabs %}

   ![Hour interval in .NET MAUI Date Time picker.](images/intervals/maui-date-time-picker-hour-interval.png)

## Minute interval
Sets the interval between minutes using the [MinuteInterval](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDateTimePicker.html#Syncfusion_Maui_Picker_SfDateTimePicker_MinuteInterval) property of [SfDateTimePicker](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDateTimePicker.html).

{% tabs %}
{% highlight xaml tabtitle="XAML" hl_lines="2" %}

<ContentPage
    . . .
    xmlns:picker="clr-namespace:Syncfusion.Maui.Picker;assembly=Syncfusion.Maui.Picker">
    <picker:SfDateTimePicker x:Name="picker"
                             MinuteInterval="2"/>
</ContentPage>

{% endhighlight %}
{% highlight c# tabtitle="C#" hl_lines="2" %}  

using Syncfusion.Maui.Picker;
. . .
public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        SfDateTimePicker picker = new SfDateTimePicker();
        picker.MinuteInterval = 2;
        this.Content = picker;
    }
}

{% endhighlight %}
{% endtabs %}

   ![Minute interval in .NET MAUI Date Time picker.](images/intervals/maui-date-time-picker-minute-interval.png)

## Second interval
Sets the interval between seconds using the [SecondInterval](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDateTimePicker.html#Syncfusion_Maui_Picker_SfDateTimePicker_SecondInterval) property of [SfDateTimePicker](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDateTimePicker.html).

{% tabs %}
{% highlight xaml tabtitle="XAML" hl_lines="2" %}

<ContentPage
    . . .
    xmlns:picker="clr-namespace:Syncfusion.Maui.Picker;assembly=Syncfusion.Maui.Picker">
    <picker:SfDateTimePicker x:Name="picker"
                             SecondInterval="2"/>
</ContentPage>

{% endhighlight %}
{% highlight c# tabtitle="C#" hl_lines="2" %}  

using Syncfusion.Maui.Picker;
. . .
public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        SfDateTimePicker picker = new SfDateTimePicker();
        picker.SecondInterval = 2;
        this.Content = picker;
    }
}

{% endhighlight %}
{% endtabs %}

   ![Second interval in .NET MAUI Date Time picker.](images/intervals/maui-date-time-picker-second-interval.png)

## Millisecond interval
Sets the interval between milliseconds using the [MilliSecondInterval](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDateTimePicker.html#Syncfusion_Maui_Picker_SfDateTimePicker_MilliSecondInterval) property of [SfDateTimePicker](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDateTimePicker.html). To display milliseconds, the `TimeFormat` must include a fractional component such as `fff`.

{% tabs %}
{% highlight xaml tabtitle="XAML" hl_lines="2" %}

<ContentPage
    . . .
    xmlns:picker="clr-namespace:Syncfusion.Maui.Picker;assembly=Syncfusion.Maui.Picker">
    <picker:SfDateTimePicker x:Name="picker"
                             TimeFormat="hh_mm_ss_fff_tt"
                             MilliSecondInterval="2"/>
</ContentPage>

{% endhighlight %}
{% highlight c# tabtitle="C#" hl_lines="2" %}  

using Syncfusion.Maui.Picker;
. . .
public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        SfDateTimePicker picker = new SfDateTimePicker();
        picker.TimeFormat = "hh_mm_ss_fff_tt";
        picker.MilliSecondInterval = 2;
        this.Content = picker;
    }
}

{% endhighlight %}
{% endtabs %}

   ![MilliSecond interval in .NET MAUI Date Time picker.](images/intervals/maui-date-time-picker-millisecond-interval.png)
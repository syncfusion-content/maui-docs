---
layout: post
platform: maui
title: Intervals in .NET MAUI Date Time Picker control | Syncfusion®
description: Learn about intervals in Syncfusion® .NET MAUI Date Time Picker control for day, month, year, and time step configuration.
control: SfDateTimePicker
documentation: ug
---

# Intervals in .NET MAUI Date Time Picker control
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
{% highlight xaml tabtitle="XAML" hl_lines="5" %}

<ContentPage
    . . .
    xmlns:picker="clr-namespace:Syncfusion.Maui.Picker;assembly=Syncfusion.Maui.Picker">
    <picker:SfDateTimePicker x:Name="picker"
                             DayInterval="2"/>
</ContentPage>

{% endhighlight %}
{% highlight c# tabtitle="C#" hl_lines="9" %}

using Syncfusion.Maui.Picker;
. . .
public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        SfDateTimePicker dateTimePicker = new SfDateTimePicker();
        dateTimePicker.DayInterval = 2;
        this.Content = dateTimePicker;
    }
}

{% endhighlight %}
{% endtabs %}

   ![Day interval in .NET MAUI Date Time picker.](images/intervals/maui-date-time-picker-day-interval.png)

## Month interval
Sets the interval between months using the [MonthInterval](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDateTimePicker.html#Syncfusion_Maui_Picker_SfDateTimePicker_MonthInterval) property of [SfDateTimePicker](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDateTimePicker.html).

{% tabs %}
{% highlight xaml tabtitle="XAML" hl_lines="5" %}

<ContentPage
    . . .
    xmlns:picker="clr-namespace:Syncfusion.Maui.Picker;assembly=Syncfusion.Maui.Picker">
    <picker:SfDateTimePicker x:Name="picker"
                             MonthInterval="2"/>
</ContentPage>

{% endhighlight %}
{% highlight c# tabtitle="C#" hl_lines="9" %}

using Syncfusion.Maui.Picker;
. . .
public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        SfDateTimePicker dateTimePicker = new SfDateTimePicker();
        dateTimePicker.MonthInterval = 2;
        this.Content = dateTimePicker;
    }
}

{% endhighlight %}
{% endtabs %}

   ![Month interval in .NET MAUI Date Time Picker.](images/intervals/maui-date-time-picker-month-interval.png)

## Year interval
Sets the interval between years using the [YearInterval](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDateTimePicker.html#Syncfusion_Maui_Picker_SfDateTimePicker_YearInterval) property of [SfDateTimePicker](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDateTimePicker.html).

{% tabs %}
{% highlight xaml tabtitle="XAML" hl_lines="5" %}

<ContentPage
    . . .
    xmlns:picker="clr-namespace:Syncfusion.Maui.Picker;assembly=Syncfusion.Maui.Picker">
    <picker:SfDateTimePicker x:Name="picker"
                             YearInterval="2"/>
</ContentPage>

{% endhighlight %}
{% highlight c# tabtitle="C#" hl_lines="9" %}

using Syncfusion.Maui.Picker;
. . .
public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        SfDateTimePicker dateTimePicker = new SfDateTimePicker();
        dateTimePicker.YearInterval = 2;
        this.Content = dateTimePicker;
    }
}

{% endhighlight %}
{% endtabs %}

   ![Year interval in .NET MAUI Date Time picker.](images/intervals/maui-date-time-picker-year-interval.png)

## Hour interval
Sets the interval between hours using the [HourInterval](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDateTimePicker.html#Syncfusion_Maui_Picker_SfDateTimePicker_HourInterval) property of [SfDateTimePicker](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDateTimePicker.html).

{% tabs %}
{% highlight xaml tabtitle="XAML" hl_lines="5" %}

<ContentPage
    . . .
    xmlns:picker="clr-namespace:Syncfusion.Maui.Picker;assembly=Syncfusion.Maui.Picker">
    <picker:SfDateTimePicker x:Name="picker"
                             HourInterval="2"/>
</ContentPage>

{% endhighlight %}
{% highlight c# tabtitle="C#" hl_lines="9" %}  

using Syncfusion.Maui.Picker;
. . .
public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        SfDateTimePicker dateTimePicker = new SfDateTimePicker();
        dateTimePicker.HourInterval = 2;
        this.Content = dateTimePicker;
    }
}

{% endhighlight %}
{% endtabs %}

   ![Hour interval in .NET MAUI Date Time picker.](images/intervals/maui-date-time-picker-hour-interval.png)

## Minute interval
Sets the interval between minutes using the [MinuteInterval](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDateTimePicker.html#Syncfusion_Maui_Picker_SfDateTimePicker_MinuteInterval) property of [SfDateTimePicker](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDateTimePicker.html).

{% tabs %}
{% highlight xaml tabtitle="XAML" hl_lines="5" %}

<ContentPage
    . . .
    xmlns:picker="clr-namespace:Syncfusion.Maui.Picker;assembly=Syncfusion.Maui.Picker">
    <picker:SfDateTimePicker x:Name="picker"
                             MinuteInterval="2"/>
</ContentPage>

{% endhighlight %}
{% highlight c# tabtitle="C#" hl_lines="9" %}  

using Syncfusion.Maui.Picker;
. . .
public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        SfDateTimePicker dateTimePicker = new SfDateTimePicker();
        dateTimePicker.MinuteInterval = 2;
        this.Content = dateTimePicker;
    }
}

{% endhighlight %}
{% endtabs %}

   ![Minute interval in .NET MAUI Date Time picker.](images/intervals/maui-date-time-picker-minute-interval.png)

## Second interval
Sets the interval between seconds using the [SecondInterval](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDateTimePicker.html#Syncfusion_Maui_Picker_SfDateTimePicker_SecondInterval) property of [SfDateTimePicker](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDateTimePicker.html).

{% tabs %}
{% highlight xaml tabtitle="XAML" hl_lines="5" %}

<ContentPage
    . . .
    xmlns:picker="clr-namespace:Syncfusion.Maui.Picker;assembly=Syncfusion.Maui.Picker">
    <picker:SfDateTimePicker x:Name="picker"
                             SecondInterval="2"/>
</ContentPage>

{% endhighlight %}
{% highlight c# tabtitle="C#" hl_lines="9" %}  

using Syncfusion.Maui.Picker;
. . .
public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        SfDateTimePicker dateTimePicker = new SfDateTimePicker();
        dateTimePicker.SecondInterval = 2;
        this.Content = dateTimePicker;
    }
}

{% endhighlight %}
{% endtabs %}

   ![Second interval in .NET MAUI Date Time picker.](images/intervals/maui-date-time-picker-second-interval.png)

## Millisecond interval
Sets the interval between milliseconds using the [MilliSecondInterval](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDateTimePicker.html#Syncfusion_Maui_Picker_SfDateTimePicker_MilliSecondInterval) property of [SfDateTimePicker](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDateTimePicker.html). To display milliseconds, the `TimeFormat` must include a fractional component such as `fff`.

{% tabs %}
{% highlight xaml tabtitle="XAML" hl_lines="6" %}

<ContentPage
    . . .
    xmlns:picker="clr-namespace:Syncfusion.Maui.Picker;assembly=Syncfusion.Maui.Picker">
    <picker:SfDateTimePicker x:Name="picker"
                             TimeFormat="hh_mm_ss_fff_tt"
                             MilliSecondInterval="2"/>
</ContentPage>

{% endhighlight %}
{% highlight c# tabtitle="C#" hl_lines="10" %}  

using Syncfusion.Maui.Picker;
. . .
public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        SfDateTimePicker dateTimePicker = new SfDateTimePicker();
        dateTimePicker.TimeFormat = "hh_mm_ss_fff_tt";
        dateTimePicker.MilliSecondInterval = 2;
        this.Content = dateTimePicker;
    }
}

{% endhighlight %}
{% endtabs %}

   ![MilliSecond interval in .NET MAUI Date Time picker.](images/intervals/maui-date-time-picker-millisecond-interval.png)
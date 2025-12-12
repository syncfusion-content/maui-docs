---
layout: post
title: Liquid Glass Support for .NET MAUI Calendar | Syncfusion®
description: Learn how to enable liquid glass  support for the Syncfusion® .NET MAUI Calendar using SfGlassEffectsView.
platform: MAUI
control: SfCalendar
documentation: ug
---

# Liquid Glass Support

The [SfCalendar](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.SfCalendar.html) supports a liquid glass  appearance by hosting the control inside the Syncfusion [SfGlassEffectsView](). You can customize the effect using properties such as [EffectType](), [EnableShadowEffect](), and round the corners using [CornerRadius](). This approach improves visual depth and readability when the calendar is placed over images or colorful layouts.

Additionally, when the calendar is shown in [Dialog](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarMode.html#Syncfusion_Maui_Calendar_CalendarMode_Dialog) mode, you can apply the glass effect to the pop-up by enabling the [EnableLiquidGlassEffect]() property on the calendar.

## Platform and Version Support

1. This feature is supported on .NET 10 or greater.
2. This feature is supported on macOS 26 and iOS 26 or later.
3. On platforms or versions below these requirements, the control renders without the acrylic blur effect and falls back to a standard background.

## Prerequisites

- Add the [Syncfusion.Maui.Core](https://www.nuget.org/packages/Syncfusion.Maui.Core/) package (for SfGlassEffectsView).
- Add the [Syncfusion.Maui.Calendar](https://www.nuget.org/packages/Syncfusion.Maui.Calendar/) package (for SfCalendar).

## Apply Liquid Glass Effect to SfCalendar

Wrap the [SfCalendar](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.SfCalendar.html) inside an [SfGlassEffectsView]() to give the calendar surface a glass (blurred or clear) appearance.

{% tabs %}
{% highlight xaml %}

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage
    xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
    xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
    xmlns:calendar="clr-namespace:Syncfusion.Maui.Calendar;assembly=Syncfusion.Maui.Calendar"
    xmlns:core="clr-namespace:Syncfusion.Maui.Core;assembly=Syncfusion.Maui.Core"
    x:Class="AcrylicCalendarPage">

    <Grid>
        <!-- Background to make acrylic blur visible -->
        <Image Source="wallpaper.jpg" Aspect="AspectFill" />

        <core:SfGlassEffectsView
            CornerRadius="20"
            Padding="12"
            EffectType="Regular"
            EnableShadowEffect="True">

            <calendar:SfCalendar />
        </core:SfGlassEffectsView>
    </Grid>
</ContentPage>

{% endhighlight %}
{% highlight c# %}

using Syncfusion.Maui.Core;
using Syncfusion.Maui.Calendar;

var glassView = new SfGlassEffectsView
{
    CornerRadius = 20,
    Padding = new Thickness(12),
    EffectType = LiquidGlassEffectType.Regular,
    EnableShadowEffect = true
};

var calendar = new SfCalendar();

glassView.Content = calendar;

{% endhighlight %}
{% endtabs %}

N>
* Liquid Glass effects are most visible over images or colorful backgrounds.
* Use EffectType="Regular" for a blurrier look and "Clear" for a glassy look.

## Enable Glass Effect in Dialog Mode

When the calendar is displayed in [Dialog](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarMode.html#Syncfusion_Maui_Calendar_CalendarMode_Dialog) mode, enable the liquid glass effect by setting [EnableLiquidGlassEffect]() to true.

{% tabs %}
{% highlight xaml %}

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage
    xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
    xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
    xmlns:calendar="clr-namespace:Syncfusion.Maui.Calendar;assembly=Syncfusion.Maui.Calendar"
    xmlns:core="clr-namespace:Syncfusion.Maui.Core;assembly=Syncfusion.Maui.Core"
    x:Class="CalendarDialogGlassPage">

    <Grid>
        <Image Source="wallpaper.jpg" Aspect="AspectFill" />

        <!-- Optional: host the launcher/control within a glass view as well -->
        <core:SfGlassEffectsView
            CornerRadius="16"
            Padding="10"
            EffectType="Clear"
            EnableShadowEffect="True">

            <calendar:SfCalendar
                Mode="Dialog"
                EnableLiquidGlassEffect="True" />
        </core:SfGlassEffectsView>
    </Grid>
</ContentPage>

{% endhighlight %}
{% highlight c# %}

using Syncfusion.Maui.Core;
using Syncfusion.Maui.Calendar;

var calendar = new SfCalendar
{
    // Shows the calendar in a dialog surface when invoked
    Mode = CalendarMode.Dialog,

    // Applies acrylic/glass effect to the dialog surface
    EnableLiquidGlassEffect = true
};

{% endhighlight %}
{% endtabs %}

N>
* The dialog gains the glass effect only when EnableLiquidGlassEffect is true.

## Key Properties

- [EffectType](): Choose between Regular (blurry) and Clear (glassy) effects.
- [EnableShadowEffect](): Enables a soft shadow around the acrylic container.
- [CornerRadius](): Rounds the corners of the acrylic container.
- Padding/Height/Width: Adjust layout around the embedded calendar.
- [EnableLiquidGlassEffect]() (dialog): Enables the glass effect for the calendar’s dialog mode.

## Best Practices and Tips

- Hosting the calendar inside [SfGlassEffectsView]() gives the calendar body an acrylic look.
- In dialog mode, the dialog surface applies the glass effect only when [EnableLiquidGlassEffect]() is true.
- For the most noticeable effect, place the control over images or vibrant backgrounds.

The following screenshot illustrates [SfCalendar](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.SfCalendar.html) hosted within an acrylic container, and the dialog mode using the glass effect.
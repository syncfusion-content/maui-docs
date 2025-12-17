---
layout: post
title: Liquid Glass Support for .NET MAUI Scheduler | Syncfusion®
description: Learn how to enable liquid glass support for the Syncfusion® .NET MAUI Scheduler (SfScheduler) control.
platform: MAUI
control: SfScheduler
documentation: ug
---

# Liquid Glass Effect in .NET MAUI Scheduler

The Liquid Glass Effect introduces a modern, translucent design with adaptive color tinting and light refraction, creating a sleek, glass like user experience that remains clear and accessible. This section explains how to enable and customize the effect in the Syncfusion® [.NET MAUI Scheduler](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SfScheduler.html) control.

## Apply liquid glass effect

Follow these steps to enable and configure the Liquid Glass Effect in the Scheduler control:

### Step 1: Wrap the control inside glass effect view

To apply the Liquid Glass Effect to the Syncfusion® [.NET MAUI Scheduler](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SfScheduler.html) control, wrap the control inside the [SfGlassEffectView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfGlassEffectView.html) class.

For more details, refer to the [Liquid Glass Getting Started documentation](https://help.syncfusion.com/maui/liquid-glass-ui/getting-started).

### Step 2: Enable the liquid glass effect on Scheduler

Set the [EnableLiquidGlassEffect](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerHeaderView.html#Syncfusion_Maui_Scheduler_SchedulerHeaderView_EnableLiquidGlassEffect) property to `true` in the [HeaderView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerHeaderView.html) control to apply the Liquid Glass Effect. When enabled, the effect is also applied to its dependent controls and provides responsive interaction for a smooth and engaging user experience.

### Step 3: Customize the background

To achieve a glass like background in the Scheduler control, set the `Background` property to `Transparent`. The background will then be treated as a tinted color, ensuring a consistent glass effect across the controls.

The following code snippet demonstrates how to apply the Liquid Glass Effect to the [SfScheduler](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SfScheduler.html) control:

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<core:SfGlassEffectView CornerRadius="9"
                        EffectType="Clear">
    <scheduler:SfScheduler x:Name="scheduler"
                           Background="Transparent">
        <scheduler:SfScheduler.HeaderView>
            <scheduler:SchedulerHeaderView EnableLiquidGlassEffect="True" Background="Transparent"/>
        </scheduler:SfScheduler.HeaderView>
    </scheduler:SfScheduler>
</core:SfGlassEffectView>
{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}
var glassView = new SfGlassEffectView
{
    CornerRadius = 9,
    EffectType = LiquidGlassEffectType.Clear
};

var scheduler = new SfScheduler
{
    Background = Colors.Transparent,
    HeaderView = new SchedulerHeaderView()
    {
        EnableLiquidGlassEffect = true,
        Background = Colors.Transparent
    }
};

glassView.Content = scheduler;
this.Content = glassView;
{% endhighlight %}
{% endtabs %}

N>
* Supported on `macOS 26 or higher` and `iOS 26 or higher`.
* This feature is available only in `.NET 10.`
---
layout: post
title: Styles support .NET MAUI Smart Scheduler control | Syncfusion
description: Learn here all about Styles support in Syncfusion<sup>&reg;</sup> .NET MAUI Smart Scheduler(SfSmartScheduler) control.
platform: MAUI
control: SfSmartScheduler
documentation: ug
---

# Styles in .NET MAUI Smart Scheduler (SfSmartScheduler)

You can style the elements of the `.NET MAUI Smart Scheduler` assist view using the `PlaceholderColor`, `AssistViewHeaderTextColor`, `AssistViewHeaderBackground`, `AssistViewHeaderFontSize`,`AssistViewHeaderFontFamily`, `AssistViewHeaderFontAttributes` and `AssistViewHeaderFontAutoScalingEnabled` properties of the `AssistStyle`.

{% tabs %}
{% highlight XAML hl_lines="5 14" %}

<smartScheduler:SfSmartScheduler x:Name="smartScheduler">
    <smartScheduler:SfSmartScheduler.AssistViewSettings>
        <smartScheduler:SchedulerAssistViewSettings>
            <smartScheduler:SchedulerAssistViewSettings.AssistStyle>
                <smartScheduler:SmartSchedulerAssistStyle PlaceholderColor="#6750A4" 
                                                          AssistViewHeaderBackground="#6750A4"
                                                          AssistViewHeaderTextColor="#FFFFFF"
                                                          AssistViewHeaderFontSize="24" />
            </smartScheduler:SchedulerAssistViewSettings.AssistStyle>
        </smartScheduler:SchedulerAssistViewSettings>
    </smartScheduler:SfSmartScheduler.AssistViewSettings>
</smartScheduler:SfSmartScheduler>

{% endhighlight %}
{% highlight C# hl_lines="3" %}

SfSmartScheduler smartScheduler = new SfSmartScheduler();
smartScheduler.AssistViewSettings.AssistStyle = new SmartSchedulerAssistStyle()
{
    PlaceholderColor = Color.FromArgb("#6750A4"),
    AssistViewHeaderBackground = Color.FromArgb("#6750A4"),
    AssistViewHeaderTextColor = Color.FromArgb("#FFFFFF"),
    AssistViewHeaderFontSize = 24,
};
this.Content = smartScheduler;

{% endhighlight %}
{% endtabs %}
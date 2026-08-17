---
layout: post
title: Events in .NET MAUI Step Progress Bar | Syncfusion®
description: Learn about events in Syncfusion® .NET MAUI Step Progress Bar (SfStepProgressBar) control for responsive user interactions.
platform: maui
control: SfStepProgressBar
documentation: ug
---

# Events in .NET MAUI Step Progress Bar

## StepTapped

The [`StepTapped`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.SfStepProgressBar.html#Syncfusion_Maui_ProgressBar_SfStepProgressBar_StepTapped) event is triggered when any step view is tapped. The associated arguments contain the following information.

* `sender` - Contains the sender details.
* [`StepTappedEventArgs`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.StepTappedEventArgs.html) - Holds the step tapped event arguments.

{% tabs %}
{% highlight XAML hl_lines="2" %}

<progressBar:SfStepProgressBar ItemsSource="{Binding StepProgressItem}"
                               StepTapped="SfStepProgressBar_StepTapped">
</progressBar:SfStepProgressBar>

{% endhighlight %}
{% highlight C# %}

private void SfStepProgressBar_StepTapped(object sender, Syncfusion.Maui.ProgressBar.StepTappedEventArgs e)
{
// Handle event action
}

{% endhighlight %}
{% endtabs %}

## StepStatusChanged

The [`StepStatusChanged`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.SfStepProgressBar.html#Syncfusion_Maui_ProgressBar_SfStepProgressBar_StepStatusChanged) event is triggered when the step view status is changed. The associated arguments contain the following information.

* `sender` - Contains the sender details.
* [`StepStatusChangedEventArgs`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.StepStatusChangedEventArgs.html) - Holds the step status changed event arguments.

{% tabs %}
{% highlight XAML hl_lines="2" %}

<progressBar:SfStepProgressBar ItemsSource="{Binding StepProgressItem}"
                               ActiveStepIndex="1"
                               StepStatusChanged="SfStepProgressBar_StepStatusChanged">
</progressBar:SfStepProgressBar>

{% endhighlight %}
{% highlight C# %}

private void SfStepProgressBar_StepStatusChanged(object sender, Syncfusion.Maui.ProgressBar.StepStatusChangedEventArgs e)
{
// Handle event action
}

{% endhighlight %}
{% endtabs %}
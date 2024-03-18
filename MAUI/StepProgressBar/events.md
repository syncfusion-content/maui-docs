---
layout: post
title: Events with .NET MAUI Step ProgressBar control | Syncfusion
description: Learn here all about Events support with Syncfusion .NET MAUI Step Progress Bar control(SfStepProgressBar).
platform: maui
control: SfStepProgressBar
documentation: ug
---

# Events in MAUI StepProgressBar

## StepTapped

The [`StepTapped`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.SfStepProgressBar.html#Syncfusion_Maui_ProgressBar_SfStepProgressBar_StepTapped) event is triggered when any step view is tapped. The associated argument contains the following information.

* `sender` - Gets the details of a sender.
* [`StepTappedEventArgs`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.StepTappedEventArgs.html) - Hold the step tapped event arguments.

{% tabs %}
{% highlight xaml hl_lines="2" %}

<progressBar:SfStepProgressBar ItemsSource="{Binding StepProgressItem}"
                               StepTapped="SfStepProgressBar_StepTapped">
</progressBar:SfStepProgressBar>

{% endhighlight %}

{% highlight c# %}

private void SfStepProgressBar_StepTapped(object sender, Syncfusion.Maui.ProgressBar.StepTappedEventArgs e)
{
// Handle event action
}

{% endhighlight %}
{% endtabs %}

## StepChanged

The [`StepStatusChanged`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.SfStepProgressBar.html#Syncfusion_Maui_ProgressBar_SfStepProgressBar_StepStatusChanged) event is triggered when the step view status is changed. The associated argument contains the following information.

* `sender` - Gets the details of a sender.
* [`StepStatusChangedEventArgs`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.StepTappedEventArgs.html) - Hold the step status changed event arguments.

{% tabs %}
{% highlight xaml hl_lines="2" %}

<progressBar:SfStepProgressBar ItemsSource="{Binding StepProgressItem}"
                                ActiveStepIndex="1"
                                StepStatusChanged="SfStepProgressBar_StepStatusChanged">
</progressBar:SfStepProgressBar>

{% endhighlight %}

{% highlight c# %}

private void SfStepProgressBar_StepStatusChanged(object sender, Syncfusion.Maui.ProgressBar.StepStatusChangedEventArgs e)
{
// Handle event action
}

{% endhighlight %}
{% endtabs %}
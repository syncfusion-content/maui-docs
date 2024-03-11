---
layout: post
title: Events with .NET MAUI Step ProgressBar control | Syncfusion
description: Learns about Events support with Syncfusion .NET MAUI Step ProgressBar (SfStepProgressBar)
platform: maui
control: SfStepProgressBar
documentation: ug
---

# Events in MAUI StepProgressBar

## StepTapped

The [`StepTapped`]() event is triggered when any step view is tapped. The associated argument contains the following information.

* [`sender`]() - Gets the details of a sender.
* [`StepTappedEventArgs`]() - Hold the step tapped event arguments.

{% tabs %}
{% highlight xaml hl_lines="1" %}

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

The [`StepStatusChanged`]() event is triggered when changing the step view status. The associated argument contains the following information.

* [`sender`]() - Gets the details of a sender.
* [`StepStatusChangedEventArgs`]() - Hold the step status changed event arguments.

{% tabs %}
{% highlight xaml hl_lines="1" %}

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
---
layout: post
title: Orientation in .NET MAUI Step ProgressBar control | Syncfusion
description: Learn here all about Orientation support in Syncfusion .NET MAUI Step ProgressBar (SfStepProgressBar) control and more.
platform: maui
control: SfStepProgressBar
documentation: ug
---

# Orientation in .NET MAUI StepProgressBar (Step Progress Bar)
The StepProgressBar control provides options to change the default orientation, so a multi-step process can be visualized in horizontal or vertical orientation.

## Horizontal
By default, StepProgressBar step views are displayed horizontally. You can also define the orientation as demonstrated in the following code example.

{% tabs %}
{% highlight xaml tabtitle="XAML" %}

<stepProgressBar:SfStepProgressBar 
                    Orientation="Horizontal">
</stepProgressBar:SfStepProgressBar>

{% endhighlight %}
{% highlight c# tabtitle="C#" %}

SfStepProgressBar stepProgressBar = new SfStepProgressBar();
stepProgressBar.Orientation = StepOrientation.Horizontal;

{% endhighlight %}
{% endtabs %}

## Vertical
To view the step progress bar control vertically, you can define the vertical orientation as demonstrated in the following code example.

{% tabs %}
{% highlight xaml tabtitle="XAML" %}

<stepProgressBar:SfStepProgressBar 
                    Orientation="Vertical">
</stepProgressBar:SfStepProgressBar>

{% endhighlight %}
{% highlight c# tabtitle="C#" %}

SfStepProgressBar stepProgressBar = new SfStepProgressBar();
stepProgressBar.Orientation = StepOrientation.Vertical;

{% endhighlight %}
{% endtabs %}
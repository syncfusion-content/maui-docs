---
layout: post
title: Orientation in .NET MAUI Step Progress Bar | Syncfusion®
description: Learn about horizontal and vertical orientation in Syncfusion® .NET MAUI Step Progress Bar (SfStepProgressBar) control.
platform: maui
control: SfStepProgressBar
documentation: ug
---

# Orientation in .NET MAUI Step Progress Bar

The StepProgressBar control provides options to change the default orientation, so a multi-step process can be visualized in horizontal or vertical orientation.

## Horizontal

By default, StepProgressBar step views are displayed in [Horizontal](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.StepProgressBarOrientation.html#Syncfusion_Maui_ProgressBar_StepProgressBarOrientation_Horizontal) orientation.

{% tabs %}
{% highlight XAML tabtitle="XAML" hl_lines="2" %}

<stepProgressBar:SfStepProgressBar  Orientation="Horizontal">
</stepProgressBar:SfStepProgressBar>

{% endhighlight %}
{% highlight C# tabtitle="C#" hl_lines="2" %}

SfStepProgressBar stepProgressBar = new SfStepProgressBar();
stepProgressBar.Orientation = StepProgressBarOrientation.Horizontal;

{% endhighlight %}
{% endtabs %}

![Horizontal orientation in .NET MAUI SfStepProgressBar.](images/orientation/maui-stepprogressbar-orientation-horizontal.png)

## Vertical

To view the Step Progress Bar control in [Vertical](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.StepProgressBarOrientation.html#Syncfusion_Maui_ProgressBar_StepProgressBarOrientation_Vertical) orientation, define the vertical orientation as demonstrated in the following code example.

{% tabs %}
{% highlight XAML tabtitle="XAML" hl_lines="2" %}

<stepProgressBar:SfStepProgressBar  Orientation="Vertical">
</stepProgressBar:SfStepProgressBar>

{% endhighlight %}
{% highlight C# tabtitle="C#" hl_lines="2" %}

SfStepProgressBar stepProgressBar = new SfStepProgressBar();
stepProgressBar.Orientation = StepProgressBarOrientation.Vertical;

{% endhighlight %}
{% endtabs %}

![Vertical orientation in .NET MAUI SfStepProgressBar.](images/orientation/maui-stepprogressbar-orientation-vertical.png)
---
layout: post
title: Orientation in .NET MAUI Step ProgressBar Control | Syncfusion
description: Learn here all about Orientation support in Syncfusion<sup>&reg;</sup> .NET MAUI Step ProgressBar (SfStepProgressBar) control and more.
platform: maui
control: SfStepProgressBar
documentation: ug
---

# Orientation in .NET MAUI StepProgressBar (Step Progress Bar)
The StepProgressBar control provides options to change the default orientation, so a multi-step process can be visualized in horizontal or vertical orientation.

## Horizontal
By default, StepProgressBar step views are displayed [Horizontal](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.StepProgressBarOrientation.html#Syncfusion_Maui_ProgressBar_StepProgressBarOrientation_Horizontal). You can also define the orientation as demonstrated in the following code example.

{% tabs %}
{% highlight xaml tabtitle="XAML" hl_lines="2" %}

<stepProgressBar:SfStepProgressBar 
                    Orientation="Horizontal">
</stepProgressBar:SfStepProgressBar>

{% endhighlight %}
{% highlight c# tabtitle="C#" hl_lines="2" %}

SfStepProgressBar stepProgressBar = new SfStepProgressBar();
stepProgressBar.Orientation = StepOrientation.Horizontal;

{% endhighlight %}
{% endtabs %}

 ![Orientation in .NET MAUI SfStepProgressBar.](images/orientation/maui-stepprogressbar-orientation-horizontal.png)

## Vertical
To view the step progress bar control in [Vertical](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.StepProgressBarOrientation.html#Syncfusion_Maui_ProgressBar_StepProgressBarOrientation_Vertical), you can define the vertical orientation as demonstrated in the following code example.

{% tabs %}
{% highlight xaml tabtitle="XAML" hl_lines="2" %}

<stepProgressBar:SfStepProgressBar 
                    Orientation="Vertical">
</stepProgressBar:SfStepProgressBar>

{% endhighlight %}
{% highlight c# tabtitle="C#" hl_lines="2" %}

SfStepProgressBar stepProgressBar = new SfStepProgressBar();
stepProgressBar.Orientation = StepOrientation.Vertical;

{% endhighlight %}
{% endtabs %}

 ![Orientation in .NET MAUI SfStepProgressBar.](images/orientation/maui-stepprogressbar-orientation-vertical.png)
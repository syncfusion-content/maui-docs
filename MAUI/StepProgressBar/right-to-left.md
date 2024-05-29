---
layout: post
title: Flow Direction in .NET MAUI Step ProgressBar Control | Syncfusion
description: Learn about Right To Left support in Syncfusion .NET MAUI Step ProgressBar (SfStepProgressBar) control and more.
platform: maui
control: SfStepProgressBar
documentation: ug
---
 
# RightToLeft Flow Direction in MAUI StepProgressBar (SfStepProgressBar)

The [SfStepProgressBar](https://www.syncfusion.com/maui-controls/maui-stepprogressbar) supports changing the flow direction of items rendering in the right-to-left order by setting the `FlowDirection` to `RightToLeft`.

{% tabs %}

{% highlight XAML %}
  <ContentPage 
            . . .
            <stepProgressBar:SfStepProgressBar FlowDirection="RightToLeft"/>

   </ContentPage>
     
{% endhighlight %}

{% highlight C# %}
   
     SfStepProgressBar stepProgressBar = new SfStepProgressBar();
     stepProgressBar.FlowDirection = RightToLeft;
     this.content = stepProgressBar;

{% endhighlight %}

{% endtabs %}

![Right to left in .NET MAUI Step Progress Bar](images/right-to-left/maui-stepprogressbar-right-to-left.gif)

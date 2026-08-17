---
layout: post
title: RTL Support in .NET MAUI Step Progress Bar | Syncfusion®
description: Learn about right-to-left support in Syncfusion® .NET MAUI Step Progress Bar (SfStepProgressBar) control for RTL languages.
platform: maui
control: SfStepProgressBar
documentation: ug
---
 
# Right-to-Left in .NET MAUI Step Progress Bar

The [SfStepProgressBar](https://www.syncfusion.com/maui-controls/maui-stepprogressbar) supports changing the flow direction of items rendering in the right-to-left order by setting the `FlowDirection` to `RightToLeft`.

{% tabs %}

{% highlight XAML %}
<ContentPage
            ...
            <stepProgressBar:SfStepProgressBar FlowDirection="RightToLeft"/>

</ContentPage>

{% endhighlight %}

{% highlight C# %}

SfStepProgressBar stepProgressBar = new SfStepProgressBar();
stepProgressBar.FlowDirection = FlowDirection.RightToLeft;
this.Content = stepProgressBar;

{% endhighlight %}

{% endtabs %}

![Right-to-left in .NET MAUI Step Progress Bar](images/right-to-left/maui-stepprogressbar-right-to-left.gif)

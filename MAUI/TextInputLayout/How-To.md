---
layout: post
title: How to | SfTextInputLayout |.NET MAUI | Syncfusion
description: Explains the text input layout customization
platform: maui
control: SfTextInputLayout
documentation: ug
--- 
# How to 

## Customize the thickness of stroke 

The stroke width (for `Outlined`) and line thickness (for `Filled` and `None`) can be customized based on the focus state of the input view by setting the `FocusedStrokeThickness` and `UnfocusedStrokeThickness` properties.

{% tabs %}

{% highlight xaml %}

<inputLayout:SfTextInputLayout  Hint="Name" 
                                ContainerType="Outlined"
                                FocusedStrokeThickness="4"
                                UnfocusedStrokeThickness="2">
    <Entry />
</inputLayout:SfTextInputLayout>
		
{% endhighlight %}

{% highlight c# %}

var inputLayout = new SfTextInputLayout();
inputLayout.Hint = "Name";
inputLayout.ContainerType = ContainerType.Outlined;
inputLayout.FocusedStrokeThickness = 4;
inputLayout.UnfocusedStrokeThickness = 2;
inputLayout.InputView = new Entry(); 

{% endhighlight %}

{% endtabs %}

![StrokeThickness img](images/HowTo/StrokeThickness.png)

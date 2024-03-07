---
layout: post
title: Right To Left in .NET MAUI Button Control | Syncfusion
description: Learn here all about Right To Left support in Syncfusion .NET MAUI Button (SfButton) control, and more.
platform: maui
control: SfButton
documentation: ug
---

# Right To Left in .NET MAUI Button (SfButton)

`SfButton` supports changing the layout direction of the control in the right-to-left direction by setting the FlowDirection to `RightToLeft` or by changing the device language.

{% tabs %}
{% highlight xaml %}

<buttons:SfButton x:Name="button"
                FlowDirection="RightToLeft"
                ImageSource="add_to_card.png"
                ShowIcon="True" 
                Text="Add to cart"/>
{% endhighlight %}

{% highlight c# %}
SfButton button = new SfButton()
{
    FlowDirection = FlowDirection.RightToLeft,
    Text = "Add to cart",
    ImageSource = "add_to_card.png",
    ShowIcon = true,
};

{% endhighlight %}
{% endtabs %}

The following image illustrates the result of the above code:

![.NET MAUI RTL support](images/right-to-left/RTL.png)
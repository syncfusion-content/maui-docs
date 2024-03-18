---
layout: post
title: Right To Left in .NET MAUI Button Control | Syncfusion
description: Learn about the comprehensive support for right-to-left (RTL) directionality within the Syncfusion .NET MAUI Button, also known as the SfButton control.
platform: maui
control: SfButton
documentation: ug
---

# Right To Left in .NET MAUI Button (SfButton)

[SfButton](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfButton.html) supports changing the layout direction of the control in the right-to-left direction by setting the [FlowDirection](https://learn.microsoft.com/en-us/dotnet/api/microsoft.maui.controls.device.flowdirection?view=net-maui-7.0) to `RightToLeft` or by changing the device language.

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
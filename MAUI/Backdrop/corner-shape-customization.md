---
layout: post
title: Corner shape customization of Syncfusion Backdrop Page | Syncfusion
description: This section explains how to customize the corners of the front layer of the backdrop to flat and curve shapes. 
platform: MAUI
control: SfBackdropPage
documentation: ug
---

# Corner Shape Customization in .NET MAUI Backdrop Page (SfBackdropPage)

Backdrop allows to customize the shapes on the top corners of the front layer. Curved and cut (flat) shape options are available , it can be switched by setting `EdgeShape` property of the front layer.

![CornerType image](CornerShape_images/CornerType.png)

N> The backdrop can only be shaped on the top left and top right corners.

N> If you need to set background color for the back layer, set the `BackgroundColor` property to the content of the BackdropBackLayer instead of BackdropBackLayer itself.

Both the side of the corner radius can be customized separately by setting `LeftCornerRadius` and `RightCornerRadius` properties of `BackdropFrontLayer`.

{% tabs %} 

{% highlight xaml %} 

<backdrop:SfBackdropPage.FrontLayer>
        <backdrop:BackdropFrontLayer LeftCornerRadius="30" RightCornerRadius="0" EdgeShape="Flat">
            <Grid />
        </backdrop:BackdropFrontLayer>
</backdrop:SfBackdropPage.FrontLayer> 


{% endhighlight %}

{% highlight C# %} 

this.FrontLayer = new BackdropFrontLayer()
{
	Content = new Grid(),
	LeftCornerRadius = 30,
	RightCornerRadius = 0,
	EdgeShape = EdgeShape.Flat
};

{% endhighlight %}

{% endtabs %}
---
layout: post
title: Popup Animations in .NET MAUI Popup Control | Syncfusion®
description: Learn here all about Popup Animations support in the Syncfusion® .NET MAUI Popup (SfPopup) control and more.
platform: MAUI
control: SfPopup
documentation: ug
--- 

# Popup Animations in .NET MAUI Popup (SfPopup)

## Animation Modes

Built-in animations are available in SfPopup, which is applied when the PopupView opens and closes in the screen. By default, the animation mode is set to `Fade`. The following animation modes are available in SfPopup:

* [Zoom](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Popup.PopupAnimationMode.html#Syncfusion_Maui_Popup_PopupAnimationMode_Zoom)
* [Fade](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Popup.PopupAnimationMode.html#Syncfusion_Maui_Popup_PopupAnimationMode_Fade)
* [SlideOnLeft](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Popup.PopupAnimationMode.html#Syncfusion_Maui_Popup_PopupAnimationMode_SlideOnLeft)
* [SlideOnRight](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Popup.PopupAnimationMode.html#Syncfusion_Maui_Popup_PopupAnimationMode_SlideOnRight)
* [SlideOnTop](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Popup.PopupAnimationMode.html#Syncfusion_Maui_Popup_PopupAnimationMode_SlideOnTop)
* [SlideOnBottom](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Popup.PopupAnimationMode.html#Syncfusion_Maui_Popup_PopupAnimationMode_SlideOnBottom)
* [None](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Popup.PopupAnimationMode.html#Syncfusion_Maui_Popup_PopupAnimationMode_None)

N> The AnimationMode setting applies to both `Displaying popup when the SfPopup is set as root view` and `Displaying popup on the go`. 

### Zoom

Zoom-out animation will be applied when the PopupView opens and Zoom-in animation will be applied when the PopupView closes.

{% tabs %}

{% highlight xaml %}

<sfPopup:SfPopup x:Name="popup" 
                 AnimationMode="Zoom" />

{% endhighlight %}

{% highlight c# %}

using Syncfusion.Maui.Popup;

public MainPage()
{
    InitializeComponent();
    popup.AnimationMode = PopupAnimationMode.Zoom;
}

{% endhighlight %}

{% endtabs %}

![Syncfusion .NET MAUI Popup with zoom animation](Images/popup-animation/maui-popup-zoom-animation.gif)

### Fade

Fade-out animation will be applied when the PopupView opens and Fade-in animation will be applied when the PopupView closes.

{% tabs %}

{% highlight xaml %}

<sfPopup:SfPopup x:Name="popup"
                 AnimationMode="Fade" />

{% endhighlight %}

{% highlight c# %}

using Syncfusion.Maui.Popup;

public MainPage()
{
    InitializeComponent();
    popup.AnimationMode = PopupAnimationMode.Fade;
}

{% endhighlight %}

{% endtabs %}

![Syncfusion .NET MAUI Popup with fade animation](Images/popup-animation/maui-popup-fade-animation.gif)

### SlideOnLeft

PopupView will be animated from left-to-right when it opens and from right-to-left when it closes.

{% tabs %}

{% highlight xaml %}

<sfPopup:SfPopup x:Name="popup"
                 AnimationMode="SlideOnLeft" />

{% endhighlight %}

{% highlight c# %}

using Syncfusion.Maui.Popup;

public MainPage()
{
    InitializeComponent();
    popup.AnimationMode = PopupAnimationMode.SlideOnLeft;
}

{% endhighlight %}

{% endtabs %}

![Syncfusion .NET MAUI Popup with SlideOnLeft animation](Images/popup-animation/maui-popup-slideonleft-animation.gif)

### SlideOnRight

PopupView will be animated from right-to-left when it opens and from left-to-right when it closes.

{% tabs %}

{% highlight xaml %}

<sfPopup:SfPopup x:Name="popup"
                 AnimationMode="SlideOnRight" />

{% endhighlight %}

{% highlight c# %}

using Syncfusion.Maui.Popup;

public MainPage()
{
    InitializeComponent();
    popup.AnimationMode = PopupAnimationMode.SlideOnRight;
}

{% endhighlight %}

{% endtabs %}

![Syncfusion .NET MAUI Popup with SlideOnRight animation](Images/popup-animation/maui-popup-slideonright-animation.gif)

### SlideOnTop

PopupView will be animated from top-to-bottom when it opens and from bottom-to-top when it closes.

{% tabs %}

{% highlight xaml %}

<sfPopup:SfPopup x:Name="popup"
                 AnimationMode="SlideOnTop" />

{% endhighlight %}

{% highlight c# %}

using Syncfusion.Maui.Popup;

public MainPage()
{
    InitializeComponent();
    popup.AnimationMode = PopupAnimationMode.SlideOnTop;
}

{% endhighlight %}

{% endtabs %}


![Syncfusion .NET MAUI Popup with SlideOnTop animation](Images/popup-animation/maui-popup-slideontop-animation.gif)

### SlideOnBottom

PopupView will be animated from bottom-to-top when it opens and from top-to-bottom when it closes.

{% tabs %}

{% highlight xaml %}

<sfPopup:SfPopup x:Name="popup"
                 AnimationMode="SlideOnBottom" />

{% endhighlight %}

{% highlight c# %}

using Syncfusion.Maui.Popup;

public MainPage()
{
    InitializeComponent();
    popup.AnimationMode = PopupAnimationMode.SlideOnBottom;
}

{% endhighlight %}

{% endtabs %}

![Syncfusion .NET MAUI Popup with SlideOnBottom animation](Images/popup-animation/maui-popup-slideonbottom-animation.gif)

### None

Animation will not be applied.

{% tabs %}

{% highlight xaml %}

<sfPopup:SfPopup x:Name="popup"
                 AnimationMode="None" />

{% endhighlight %}

{% highlight c# %}

using Syncfusion.Maui.Popup;

public MainPage()
{
    InitializeComponent();
    popup.AnimationMode = PopupAnimationMode.None;
}

{% endhighlight %}

{% endtabs %}

## Animation duration

The `SfPopup` allows you to customize the opening and closing animation duration of the PopupView by using the `AnimationDuration` property. The duration is specified in milliseconds (ms), and the value must be greater than or equal to `0`. The default value is `300 ms`.

{% tabs %}
{% highlight xaml %}

<sfPopup:SfPopup x:Name="popup"
                 AnimationDuration="150" />

{% endhighlight %}

{% highlight c# %}

using Syncfusion.Maui.Popup;

public MainPage()
{
    InitializeComponent();
    popup.AnimationDuration = 150d;
    popup.Show();
}

{% endhighlight %}
{% endtabs %}

## Animation easing

The `SfPopup` allows you to show the PopupView with various easing effects for all the available `SfPopup.AnimationMode` using the [SfPopup.AnimationEasing](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Popup.PopupAnimationEasing.html) property.

{% tabs %}

{% highlight xaml %}

<sfPopup:SfPopup x:Name="popup"
                 AnimationEasing="SinIn" />

{% endhighlight %}

{% highlight c# %}

using Syncfusion.Maui.Popup;

public MainPage()
{
    InitializeComponent();
    popup.AnimationEasing = PopupAnimationEasing.SinIn;
    popup.Show();
}

{% endhighlight %}

{% endtabs %}

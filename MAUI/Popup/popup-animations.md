---
layout: post
title: Popup Animations in .NET MAUI Popup Control | Syncfusion
description: Learn here all about Popup Animations support in the Syncfusion .NET MAUI Popup (SfPopup) control and more.
platform: MAUI
control: SfPopup
documentation: ug
--- 

# Popup Animations in .NET MAUI Popup (SfPopup)

## Animation Modes

Built-in animations are available in SfPopup, which is applied when the Popup view opens and closes in the screen. By default, the animation mode is set to `Fade`
The SfPopup has different animation modes as listed below:

* Zoom
* Fade
* SlideOnLeft
* SlideOnRight
* SlideOnTop
* SlideOnBottom
* None

N> Setting of the AnimationMode is same for both `Displaying popup when the SfPopup is set as root view` and `Displaying popup on the go`. 

### Zoom 

Zoom-out animation will be applied when the Popup view opens and Zoom-in animation will be applied when the Popup view closes.

{% tabs %}

{% highlight xaml %}

<sfPopup:SfPopup x:Name="popup" 
                 AnimationMode="Zoom" />

{% endhighlight %}

{% highlight c# %}

public MainPage()
{
    InitializeComponent();
    popup.AnimationMode = AnimationMode.Zoom;
}

{% endhighlight %}

{% endtabs %}

![.NET MAUI Popup with zoom animation](Images/popup-animation//zoom-animation.gif)

### Fade 

Fade-out animation will be applied when the Popup view opens and Fade-in animation will be applied when the Popup view closes.

{% tabs %}

{% highlight xaml %}

<sfPopup:SfPopup x:Name="popup"
                 AnimationMode="Fade" />

{% endhighlight %}

{% highlight c# %}

public MainPage()
{
    InitializeComponent();
    popup.AnimationMode = AnimationMode.Fade;
}

{% endhighlight %}

{% endtabs %}

![.NET MAUI Popup with fade animation](Images/popup-animation//fade-animation.gif)

### SlideOnLeft 

Popup view will be animated from left-to-right when it opens and from right-to-left when it closes.

{% tabs %}

{% highlight xaml %}

<sfPopup:SfPopup x:Name="popup"
                 AnimationMode="SlideOnLeft" />

{% endhighlight %}

{% highlight c# %}

public MainPage()
{
    InitializeComponent();
    popup.AnimationMode = AnimationMode.SlideOnLeft;
}

{% endhighlight %}

{% endtabs %}

![.NET MAUI Popup with slide on left animation](Images/popup-animation//slideonleft-animation.gif)

### SlideOnRight

Popup view will be animated from right-to-left when it opens and from left-to-right when it closes.

{% tabs %}

{% highlight xaml %}

<sfPopup:SfPopup x:Name="popup"
                 AnimationMode="SlideOnRight" />

{% endhighlight %}

{% highlight c# %}

public MainPage()
{
    InitializeComponent();
    popup.AnimationMode = AnimationMode.SlideOnRight;
}

{% endhighlight %}

{% endtabs %}

![.NET MAUI Popup with slide on right animation](Images/popup-animation//slideonright-animation.gif)

### SlideOnTop 

Popup view will be animated from top-to-bottom when it opens and from bottom-to-top when it closes.

{% tabs %}

{% highlight xaml %}

<sfPopup:SfPopup x:Name="popup"
                 AnimationMode="SlideOnTop" />

{% endhighlight %}

{% highlight c# %}

public MainPage()
{
    InitializeComponent();
    popup.AnimationMode = AnimationMode.SlideOnTop;
}

{% endhighlight %}

{% endtabs %}


![.NET MAUI Popup with slide on top animation](Images/popup-animation//slideontop-animation.gif)

### SlideOnBottom

Popup view will be animated from bottom-to-top when it opens and from top-to-bottom when it closes.

{% tabs %}

{% highlight xaml %}

<sfPopup:SfPopup x:Name="popup"
                 AnimationMode="SlideOnBottom" />

{% endhighlight %}

{% highlight c# %}

public MainPage()
{
    InitializeComponent();
    popup.AnimationMode = AnimationMode.SlideOnBottom;
}

{% endhighlight %}

{% endtabs %}

![.NET MAUI Popup with slide on bottom animation](Images/popup-animation//slideonbottom-animation.gif)

### None

Animation will not be applied.

{% tabs %}

{% highlight xaml %}

<sfPopup:SfPopup x:Name="popup"
                 AnimationMode="None" />

{% endhighlight %}

{% highlight c# %}

public MainPage()
{
    InitializeComponent();
    popup.AnimationMode = AnimationMode.None;
}

{% endhighlight %}

{% endtabs %}

## Animation duration

The `SfPopup` allows you to customize the opening and closing animation duration of Popup view by using the `AnimationDuration` property. By default, the animation duration is set to `300 milliseconds`. 

{% tabs %}
{% highlight xaml}

<sfPopup:SfPopup x:Name="popup"
                 AnimationDuration="150" />

{% endhighlight %}

{% highlight c# %}

public MainPage()
{
    InitializeComponent();
    popup.AnimationDuration = 150;
}

{% endhighlight %}
{% endtabs %}

## Animation easing

The `SfPopup` allows to show the Popup view with various easing effects for all the available `SfPopup.AnimationMode` using the `SfPopup.AnimationEasing` property.

{% tabs %}

{% highlight xaml %}

<sfPopup:SfPopup x:Name="popup"
                 AnimationEasing="SinIn" />

{% endhighlight %}

{% highlight c# %}

public MainPage()
{
    InitializeComponent();
    popup.AnimationEasing = PopupAnimationEasing.SinIn;
}

{% endhighlight %}

{% endtabs %}

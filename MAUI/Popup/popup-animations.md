---
layout: post
title: Popup Animations in .NET MAUI Popup control | Syncfusion
description: Learn here all about Popup Animations support in Syncfusion .NET MAUI Popup (SfPopup) control and more.
platform: MAUI
control: SfPopup
documentation: ug
--- 

# Popup Animations in .NET MAUI Popup (SfPopup)

## Animation Modes

Built-in animations are available in SfPopup, which is applied when the PopupView opens and closes in the screen.
The SfPopup has different animation modes as listed below:

* `Zoom`
* `Fade`
* `SlideOnLeft`
* `SlideOnRight`
* `SlideOnTop`
* `SlideOnBottom`
* `None`

N> Setting of AnimationMode is same for both `Displaying popup when the SfPopup is set as root view` and `Displaying popup on the go`. 

### Zoom 

Zoom-out animation will be applied when the PopupView opens and Zoom-in animation will be applied when the PopupView closes.

{% tabs %}

{% highlight xaml %}

<sfPopup:SfPopup x:Name="popup" AnimationMode="Zoom" />

{% endhighlight %}

{% highlight c# %}

//MainPage.cs

public MainPage()
{
    ....
    InitializeComponent();
    popup.AnimationMode = AnimationMode.Zoom;
    ....
}

{% endhighlight %}

{% endtabs %}

![Popup with zoom animation](Images/popup-animation//zoom-animation.gif)

### Fade 

Fade-out animation will be applied when the PopupView opens and Fade-in animation will be applied when the PopupView closes.

{% tabs %}

{% highlight xaml %}

<sfPopup:SfPopup x:Name="popup" AnimationMode="Fade" />

{% endhighlight %}

{% highlight c# %}

//MainPage.cs

public MainPage()
{
    ....
    InitializeComponent();
    popup.AnimationMode = AnimationMode.Fade;
    ....
}

{% endhighlight %}

{% endtabs %}

![Popup with fade animation](Images/popup-animation//fade-animation.gif)

### SlideOnLeft 

PopupView will be animated from left-to-right when it opens and from right-to-left when it closes.

{% tabs %}

{% highlight xaml %}

<sfPopup:SfPopup x:Name="popup" AnimationMode="SlideOnLeft" />

{% endhighlight %}

{% highlight c# %}

//MainPage.cs

public MainPage()
{
    ....
    InitializeComponent();
    popup.AnimationMode = AnimationMode.SlideOnLeft;
    ....
}

{% endhighlight %}

{% endtabs %}

![Popup with slide on left animation](Images/popup-animation//slideonleft-animation.gif)

### SlideOnRight

PopupView will be animated from right-to-left when it opens and from left-to-right when it closes.

{% tabs %}

{% highlight xaml %}

<sfPopup:SfPopup x:Name="popup" AnimationMode="SlideOnRight" />

{% endhighlight %}

{% highlight c# %}

//MainPage.cs

public MainPage()
{
    ....
    InitializeComponent();
    popup.AnimationMode = AnimationMode.SlideOnRight;
    ....
}

{% endhighlight %}

{% endtabs %}

![Popup with slide on right animation](Images/popup-animation//slideonright-animation.gif)

### SlideOnTop 

PopupView will be animated from top-to-bottom when it opens and from bottom-to-top when it closes.

{% tabs %}

{% highlight xaml %}

<sfPopup:SfPopup x:Name="popup" AnimationMode="SlideOnTop" />

{% endhighlight %}

{% highlight c# %}

//MainPage.cs

public MainPage()
{
    ....
    InitializeComponent();
    popup.AnimationMode = AnimationMode.SlideOnTop;
    ....
}

{% endhighlight %}

{% endtabs %}


![Popup with slide on top animation](Images/popup-animation//slideontop-animation.gif)

### SlideOnBottom

PopupView will be animated from bottom-to-top when it opens and from top-to-bottom when it closes.

{% tabs %}

{% highlight xaml %}

<sfPopup:SfPopup x:Name="popup" AnimationMode="SlideOnBottom" />

{% endhighlight %}

{% highlight c# %}

//MainPage.cs

public MainPage()
{
    ....
    InitializeComponent();
    popup.AnimationMode = AnimationMode.SlideOnBottom;
    ....
}

{% endhighlight %}

{% endtabs %}

![Popup with slide on bottom animation](Images/popup-animation//slideonbottom-animation.gif)

### None

Animation will not be applied.

{% tabs %}

{% highlight xaml %}

<sfPopup:SfPopup x:Name="popup" AnimationMode="None" />

{% endhighlight %}

{% highlight c# %}

//MainPage.cs

public MainPage()
{
    ....
    InitializeComponent();
    popup.AnimationMode = AnimationMode.None;
    ....
}

{% endhighlight %}

{% endtabs %}

## Animation Easing Effects

The `SfPopup` allows to show the `PopupView` with various easing effects for all available `SfPopup.AnimationMode` using the `SfPopup.AnimationEasing` property .

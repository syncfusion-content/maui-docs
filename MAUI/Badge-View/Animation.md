---

layout: post
title: Badge animation with Syncfusion® Badge View control for .NET MAUI
description: Learn here all about Animation support in Syncfusion® .NET MAUI Badge View (SfBadgeView) control and more.
platform: maui
control: Badge View
documentation: ug

---

# Animation in .NET MAUI Badge View (SfBadgeView)

## Enable animation

You can enable or disable the animation of the badge text using [Scale](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.BadgeAnimation.html#Syncfusion_Maui_Core_BadgeAnimation_Scale) or [None](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.BadgeAnimation.html#Syncfusion_Maui_Core_BadgeAnimation_None) enum values of the BadgeAnimation property. You can see the animation when you change the badge text.

{% tabs %}

{% highlight xaml %}

<badge:SfBadgeView HorizontalOptions="Center"  WidthRequest="70" HeightRequest="70" BadgeText="6" 
                               VerticalOptions="Center">
        <badge:SfBadgeView.Content>
            <Image Source="BadgeFacebook.png" HeightRequest="70" WidthRequest="70"  />
        </badge:SfBadgeView.Content>
        <badge:SfBadgeView.BadgeSettings>
            <badge:BadgeSettings Type="Error" Animation="Scale" Offset="-12,6" Position="TopRight" />
        </badge:SfBadgeView.BadgeSettings>
</badge:SfBadgeView>

{% endhighlight %}

{% highlight c# %}

SfBadgeView sfBadgeView = new SfBadgeView();
sfBadgeView.HeightRequest = 70;
sfBadgeView.WidthRequest = 70;
sfBadgeView.HorizontalOptions = LayoutOptions.Center;
sfBadgeView.VerticalOptions = LayoutOptions.Center;
sfBadgeView.BadgeText = "6";
Image image = new Image();
image.Source = "BadgeFacebook.png";
image.HeightRequest = 70;
image.WidthRequest = 70;
sfBadgeView.Content = image;
BadgeSettings badgeSetting = new BadgeSettings();
badgeSetting.Type = BadgeType.Error;
badgeSetting.Animation = BadgeAnimation.Scale;
badgeSetting.Offset = new Point(-12, 6);
badgeSetting.Position = BadgePosition.TopRight;
sfBadgeView.BadgeSettings = badgeSetting;
Content = sfBadgeView;
    
{% endhighlight %}

{% endtabs %}

![.NET Maui Badge View Animation](animation_images/net_maui_badge_view_animation.gif)

## Animation duration

The `AnimationDuration` property of the [Badge Settings](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfBadgeView.html#Syncfusion_Maui_Core_SfBadgeView_BadgeSettings) in the [Badge View](https://www.syncfusion.com/maui-controls/maui-badge-view) can be used to set the animation speed based on the given value. Setting a smaller duration value accelerates the animation speed. Its default value is 250.

{% tabs %}

{% highlight xaml %}

<badge:SfBadgeView BadgeText="6">
        <badge:SfBadgeView.Content>
            <Image Source="BadgeFacebook.png" HeightRequest="70" WidthRequest="70"  />
        </badge:SfBadgeView.Content>
        <badge:SfBadgeView.BadgeSettings>
            <badge:BadgeSettings AnimationDuration="600" Animation="Scale"/>
        </badge:SfBadgeView.BadgeSettings>
</badge:SfBadgeView>

{% endhighlight %}

{% highlight c# %}

SfBadgeView sfBadgeView = new SfBadgeView();
sfBadgeView.BadgeText = "6";
Image image = new Image();
image.Source = "BadgeFacebook.png";
image.HeightRequest = 70;
image.WidthRequest = 70;
sfBadgeView.Content = image;
BadgeSettings badgeSetting = new BadgeSettings();
badgeSetting.Animation = BadgeAnimation.Scale;
badgeSetting.AnimationDuration = 600;
sfBadgeView.BadgeSettings = badgeSetting;
Content = sfBadgeView;
    
{% endhighlight %}

{% endtabs %}

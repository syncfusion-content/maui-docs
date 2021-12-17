---

layout: post
title: Badge animation with Syncfusion Badge View control for .NET MAUI
description: Learn here all about Animation support in Syncfusion .NET MAUI Badge View (SfBadgeView) control and more.
platform: maui
control: Badge View
documentation: ug

---

# Animation in .NET MAUI Badge View (SfBadgeView)

You can enable or disable the animation of the badge text using `Scale` or `None` enum values of the BadgeAnimation property. You can see the animation when you change the badge text.

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

![.NET Maui Badge View Font Customization](animation_images/maui-badge-view-animation.gif)
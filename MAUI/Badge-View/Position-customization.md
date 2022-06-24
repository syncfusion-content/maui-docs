---
layout: post
title: Position customization of Syncfusion Badge view for .NET MAUI
description: Learn here all about position customization in Syncfusion .NET MAUI Badge View (SfBadgeView) control and more.
platform: maui
control: Badge View
documentation: ug
---

# Position customization

The default position of notification is [`TopRight`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.BadgePosition.html#Syncfusion_Maui_Core_BadgePosition_TopRight). The position can be customized as [`TopLeft`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.BadgePosition.html#Syncfusion_Maui_Core_BadgePosition_TopLeft),  [`BottomLeft`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.BadgePosition.html#Syncfusion_Maui_Core_BadgePosition_BottomLeft),  [`BottomRight`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.BadgePosition.html#Syncfusion_Maui_Core_BadgePosition_BottomRight), `Left`,`Top`, `Right`, and `Bottom` using the [`Position`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.BadgeSettings.html#Syncfusion_Maui_Core_BadgeSettings_Position) property. 

{% tabs %}

{% highlight xaml hl_lines="6" %}

 {% include_relative code-snippet/badge-position.xaml %}

{% endhighlight %}

{% highlight c# hl_lines="15" %}

{% include_relative code-snippet/badge-position.cs %}
    
{% endhighlight %}

{% endtabs %}

![.NET MAUI Badge View Badge Position](badge-position_images/net_maui_badge_view_position.png)

## Setting a badge offset

The badge view x,y position can be adjusted using the [Offset](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.BadgeSettings.html#Syncfusion_Maui_Core_BadgeSettings_Offset) property.

{% tabs %}

{% highlight xaml %}

  <badge:SfBadgeView BadgeText="8" HeightRequest="70" WidthRequest="60" HorizontalOptions="Center" VerticalOptions="Center">
        <badge:SfBadgeView.Content>
            <Image Source="BadgeImage9.png" HeightRequest="70" WidthRequest="60"/>
        </badge:SfBadgeView.Content>
        <badge:SfBadgeView.BadgeSettings>
            <badge:BadgeSettings Type="Success" Offset="-5,-10" Position="BottomRight"/>
        </badge:SfBadgeView.BadgeSettings>
</badge:SfBadgeView>

{% endhighlight %}

{% highlight c# %}

SfBadgeView sfBadgeView = new SfBadgeView();
sfBadgeView.WidthRequest = 70;
sfBadgeView.HeightRequest = 60;
sfBadgeView.HorizontalOptions = LayoutOptions.Center;
sfBadgeView.VerticalOptions = LayoutOptions.Center;
sfBadgeView.BadgeText = "8";
Image image = new Image();
image.Source = "BadgeImage9.png";
image.HeightRequest = 70;
image.WidthRequest = 60;
sfBadgeView.Content = image;
BadgeSettings badgeSetting = new BadgeSettings();
badgeSetting.Type = BadgeType.Success;
badgeSetting.Position = BadgePosition.BottomRight;
badgeSetting.Offset = new Point(-5, -10);
sfBadgeView.BadgeSettings = badgeSetting;
Content = sfBadgeView;

{% endhighlight %}

{% endtabs %}

![.NET MAUI Badge View Badge Offset](badge-position_images/net_maui_badge_view_offset.png)
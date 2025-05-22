---
layout: post
title: States in Syncfusion® .NET MAUI Avatar View
description: Learn how to use the different states available in .NET MAUI Avatar View.
platform: MAUI
control: SfAvatarView
documentation: UG
---

# How to Use Different States

## Set Badge View to Avatar View

The .NET MAUI [SfAvatarView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfAvatarView.html) control supports integrating a [BadgeView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfBadgeView.html?tabs=tabid-1) to notify users of new or unread messages, notifications, or any updates. Below is a demonstration of how to accomplish this setup within your application.

{% tabs %}

{% highlight xaml %}

xmlns:badge="clr-namespace:Syncfusion.Maui.Core;assembly=Syncfusion.Maui.Core"
.......

<badge:SfBadgeView VerticalOptions="Center"
                   HorizontalOptions="Center">
    <badge:SfBadgeView.Content>
        <sfavatar:SfAvatarView HorizontalOptions="Center"
                               ContentType="Custom"
                               ImageSource="alex.png"
                               VerticalOptions="Center"
                               WidthRequest="60"
                               HeightRequest="60"
                               CornerRadius="30"
                               Stroke="Black"
                               StrokeThickness="1">
        </sfavatar:SfAvatarView>
    </badge:SfBadgeView.Content>
    <badge:SfBadgeView.BadgeSettings>
        <badge:BadgeSettings Offset="-10,-10"
                             Animation="Scale"
                             Position="BottomRight" 
                             Type="Success"
                             Icon="Away"/>
    </badge:SfBadgeView.BadgeSettings>
</badge:SfBadgeView>

{% endhighlight %}


{% highlight C# %}

SfBadgeView badge = new SfBadgeView();
badge.HorizontalOptions = LayoutOptions.Center;
badge.VerticalOptions = LayoutOptions.Center;
badge.BadgeSettings = new BadgeSettings();
BadgeSettings badgeSetting = new BadgeSettings();
badgeSetting.Type = BadgeType.Success;
badgeSetting.Icon = BadgeIcon.Away;
badgeSetting.Position = BadgePosition.BottomRight;
badgeSetting.Animation = BadgeAnimation.Scale;
badgeSetting.Offset = new Point(-10, -10);
badge.BadgeSettings = badgeSetting;

Grid mainGrid = new Grid();
SfAvatarView avatarview = new SfAvatarView();
avatarview.HorizontalOptions = LayoutOptions.Center;
avatarview.VerticalOptions = LayoutOptions.Center;
avatarview.WidthRequest = 60;
avatarview.HeightRequest = 60;
avatarview.CornerRadius = 30;
avatarview.ImageSource = "alex.png";
avatarview.ContentType = ContentType.Custom;
avatarview.Stroke = Colors.Black;
avatarview.StrokeThickness = 1;
badge.Content = avatarview;
mainGrid.Children.Add(badge);
this.Content = mainGrid;

{% endhighlight %}

{% endtabs %}

![BadgeView support](HowTo_Images/BadgeView_AvatarView.jpg)

To learn more about the [SfBadgeView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfBadgeView.html?tabs=tabid-1), refer to this [documentation](https://help.syncfusion.com/maui/badge-view/getting-started).

---
layout: post
title: States in Syncfusion Avatar View control for .NET MAUI.
description: This section will explain about how to use the different states that exist in .NET MAUI SfAvatarView.
platform: maui
control: AvatarView
documentation: ug
---

# How to use different states

## Set badge view to avatar

The [SfAvatarView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfAvatarView.html) control provides support for [BadgeView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfBadgeView.html?tabs=tabid-1) to notify users of new or unread messages, notifications, or the status of something.

{% tabs %}

{% highlight xaml %}

xmlns:badge="clr-namespace:Syncfusion.Maui.Core;assembly=Syncfusion.Maui.Core"
.......

         <badge:SfBadgeView VerticalOptions="Center"
                            HorizontalOptions="Center">
			<badge:SfBadgeView.Content>
				<sfavatar:SfAvatarView  HorizontalOptions="Center"
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
            <badge:BadgeSettings 	Offset="-10,-10"
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

To know more about [SfBadgeView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfBadgeView.html?tabs=tabid-1) view, refer to this [documentation](https://help.syncfusion.com/maui/badge-view/getting-started).

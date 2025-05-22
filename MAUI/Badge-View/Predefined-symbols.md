---

layout: post
title: Predefined Symbols of Syncfusion® .NET MAUI Badge View
description: Learn how to set predefined symbols and types of badge icons in Syncfusion® .NET MAUI Badge View.
platform: MAUI
control: SfBadgeView
documentation: UG

---

# Predefined Symbols in .NET MAUI Badge View (SfBadgeView)

The [.NET MAUI Badge View](https://www.syncfusion.com/maui-controls/maui-badge-view) allows you to set badge icons using the `Icon` property. Badge icons will be visible when the badge text is not set. The badge supports the following types of `Icon`:

* Add
* Available
* Away
* Busy
* Delete 
* Dot
* None
* Prohibit1
* Prohibit2

N> When both the `Icon` and `BadgeText` are set for the Badge View, the badge text has higher priority and will be rendered in output.

{% tabs %}

{% highlight xaml %}

<badge:SfBadgeView  HorizontalOptions="Center" VerticalOptions="Center" >
        <badge:SfBadgeView.Content>
            <Image Source="friends.jpg" HeightRequest="70" WidthRequest="60"/>
        </badge:SfBadgeView.Content>
        <badge:SfBadgeView.BadgeSettings>
            <badge:BadgeSettings Type="Warning"  Offset="0, -10" Position="BottomRight" Icon="Away"/>
        </badge:SfBadgeView.BadgeSettings>
</badge:SfBadgeView>

{% endhighlight %}

{% highlight c# %}

 SfBadgeView sfBadgeView = new SfBadgeView();
		sfBadgeView.HorizontalOptions = LayoutOptions.Center;
		sfBadgeView.VerticalOptions = LayoutOptions.Center;
		Image image = new Image();
		image.Source = "friends.jpg";
		image.HeightRequest = 70;
		image.WidthRequest = 60;
		sfBadgeView.Content = image;
		BadgeSettings badgeSetting = new BadgeSettings();
		badgeSetting.Type = BadgeType.Warning;
		badgeSetting.Icon = BadgeIcon.Away;
		badgeSetting.Position = BadgePosition.BottomRight;
		badgeSetting.Offset = new Point(0, -10);
		sfBadgeView.BadgeSettings = badgeSetting;
		Content = sfBadgeView;
    
{% endhighlight %}

{% endtabs %}

![Badge icon](predefined-symbols_images/predefinedsymbols.png)


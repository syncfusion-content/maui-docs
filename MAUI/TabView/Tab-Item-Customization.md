---
layout: post
title: Display Type in .NET MAUI Tab View (SfTabView) control | Syncfusion®
description: Learn here all about color and font customization in Syncfusion® .NET MAUI Tab View (SfTabView) control.
platform: maui
control: Tab View
documentation: ug
---

# Configure the appearance of Tab Item in .NET MAUI Tab View (SfTabView)

A tab item consists of the following elements that can be customized.

## Adding image in tab item

### Header

Holds the text of the tab item that is displayed in the tab bar.

{% tabs %}

{% highlight xaml %}
<tabView:SfTabView>
    <tabView:SfTabItem Header="ITEM 1"/>
</tabView:SfTabView>
{% endhighlight %}

{% highlight C# %}
var tabView = new SfTabView();
var tabItems = new TabItemCollection
{
    new SfTabItem()
    {
        Header = "ITEM 1",
    }
}
{% endhighlight %}

{% endtabs %}

![Tab Item Header](images/Tab-Width-Mode-Default.png) 

### ImageSource 

The image to be displayed in the tab bar representing the tab item.

{% tabs %}

{% highlight xaml %}
<tabView:SfTabView>
    <tabView:SfTabItem Header="ITEM 1" ImageSource="alexandar"/>
</tabView:SfTabView>
{% endhighlight %}

{% highlight C# %}
var tabView = new SfTabView();
var tabItems = new TabItemCollection
{
    new SfTabItem()
    {
        Header = "ITEM 1",
        ImageSource = "alexandar",
    }
}

{% endhighlight %}

{% endtabs %}

![Tab Item ImageSource](images/Image-Position-Left.png) 

### Content 

The assigned view will get displayed in the main area of the tab view.

{% tabs %}

{% highlight xaml %}
<tabView:SfTabView>
    <tabView:SfTabItem Header="ITEM 2">
        <tabView:SfTabItem.Content>
            <ListView>
                ...
            </ListView>
        </tabView:SfTabItem.Content>
        </tabView:SfTabItem>
</tabView>
{% endhighlight %}

{% highlight C# %}
    var tabView = new SfTabView();
    var tabItems = new TabItemCollection
    {
        new SfTabItem()
        {
            Header = "ITEM 2",
            Content = new ListView()
            {
                /// code
            }
        }
    }
{% endhighlight %}

{% endtabs %}

![Tab Item Content](images/TabItem_Content.png) 

## Image position options 

The .NET MAUI Tab View provides four options that determine how the image of the tab aligns relative to the text. The options are left, top, right and bottom. It can be achieved using the [ImagePosition](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TabView.SfTabItem.html#Syncfusion_Maui_TabView_SfTabItem_ImagePosition) property of [SfTabItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TabView.SfTabItem.html) of type [ImagePosition](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TabView.SfTabItem.html#Syncfusion_Maui_TabView_SfTabItem_ImagePosition).

N> Each tab item can be set with different image positions. Visual State Manager can be used to apply same value to all tabs.

### Top

The image will be placed above the text vertically.

{% tabs %}

{% highlight xaml %}
 <tabView:SfTabView>
     <tabView:SfTabItem ImagePosition="Top"/>
 </tabView:SfTabView>
{% endhighlight %}

{% highlight C# %}
var tabView = new SfTabView();
var tabItems = new TabItemCollection
{
    new SfTabItem()
    {
        ImagePosition = TabImagePosition.Top,
    }
}
{% endhighlight %}

{% endtabs %}

![Image Position Top](images/Image-Position-Top.png) 

### Bottom

The image will be placed below the text vertically.

{% tabs %}

{% highlight xaml %}
<tabView:SfTabView>
    <tabView:SfTabItem ImagePosition="Bottom"/>
</tabView:SfTabView>
{% endhighlight %}

{% highlight C# %}
var tabView = new SfTabView();
var tabItems = new TabItemCollection
{
    new SfTabItem()
    {
        ImagePosition = TabImagePosition.Bottom,
    }
}
{% endhighlight %}

{% endtabs %}

![Image Position Bottom](images/Image-Position-Bottom.png) 

### Left

The image will be placed before the text horizontally.

{% tabs %}

{% highlight xaml %}
<tabView:SfTabView>
    <tabView:SfTabItem ImagePosition="Left">
</tabView:SfTabView>
{% endhighlight %}

{% highlight C# %}
var tabView = new SfTabView();
var tabItems = new TabItemCollection
{
    new SfTabItem()
    {
        ImagePosition = TabImagePosition.Left,
    }
}
{% endhighlight %}

{% endtabs %}

![Image Position Left](images/Image-Position-Left.png) 

### Right

The image will be placed to the right side of the text horizontally.

{% tabs %}

{% highlight xaml %}
<tabView:SfTabView>
    <tabView:SfTabItem ImagePosition="Right">
</tabView:SfTabView>
{% endhighlight %}

{% highlight C# %}
var tabView = new SfTabView();
var tabItems = new TabItemCollection
{
    new SfTabItem()
    {
        ImagePosition = TabImagePosition.Right,
    }
}
{% endhighlight %}

{% endtabs %}

![Image Position Right](images/Image-Position-Right.png) 

## Image Text Spacing

The [ImageTextSpacing](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TabView.SfTabItem.html#Syncfusion_Maui_TabView_SfTabItem_ImageTextSpacing) property in SfTabItem allows for the provision of spacing between the image and the text of the tab item.

{% tabs %}

{% highlight xaml %}
<tabView:SfTabView>
    <tabView:SfTabItem ImageTextSpacing="20"/>
</tabView:SfTabView>
{% endhighlight %}

{% highlight C# %}
var tabView = new SfTabView();
var tabItems = new TabItemCollection
{
    new SfTabItem()
    {
        ImageTextSpacing = "20",
    }
}
{% endhighlight %}

{% endtabs %}

![Image Text Spacing](images/Image-Text-Spacing.png)

## Text Color Customization 

The text color of the tab item displayed in the tab bar.

{% tabs %}

{% highlight xaml %}
<tabView:SfTabView>
    <tabView:SfTabItem TextColor="Blue"/>
</tabView:SfTabView>
{% endhighlight %}

{% highlight C# %}
var tabView = new SfTabView();
var tabItems = new TabItemCollection
{
    new SfTabItem()
    {
        TextColor = Color.Blue,
    }
}
{% endhighlight %}

{% endtabs %}

![Tab Image TextColor](images/TextColor.png) 

## Font Customization 

This type of customization involves making changes to the looks of some font elements.

### FontFamily

Font family of the tab item text displayed in the tab bar.

{% tabs %}

{% highlight xaml %}
<tabView:SfTabView>
    <tabView:SfTabItem FontFamily="OpenSansRegular"/>
</tabView:SfTabView>
{% endhighlight %}

{% highlight C# %}
var tabView = new SfTabView();
var tabItems = new TabItemCollection
{
    new SfTabItem()
    {
        FontFamily = "OpenSansRegular",
    }
}
{% endhighlight %}

{% endtabs %}

![TabItem FontFamily](images/FontFamily.png) 

### FontAttribute

The font style of the text of each tab item in the tab bar.

{% tabs %}

{% highlight xaml %}
<tabView:SfTabView>
    <tabView:SfTabItem FontAttributes="Bold"/>
</tabView:SfTabView>
{% endhighlight %}

{% highlight C# %}
var tabView = new SfTabView();
var tabItems = new TabItemCollection
{
    new SfTabItem()
    {
        FontAttributes = FontAttributes.Bold,
    }
}
{% endhighlight %}

{% endtabs %}

![Tab Item FontAttribute](images/FontAttributes.png) 

### FontSize

The size of the text of each tab item in the tab bar.

{% tabs %}

{% highlight xaml %}
<tabView:SfTabView>
    <tabView:SfTabItem FontSize="32"/>
</tabView:SfTabView>
{% endhighlight %}

{% highlight C# %}
var tabView = new SfTabView();
var tabItems = new TabItemCollection
{
    new SfTabItem()
    {
        FontSize = 32,
    }
}
{% endhighlight %}

{% endtabs %}

![Tab Item FontSize](images/FontSize.png)

## Badge Support

In SfTabItem, the badges are used to notify users of new or unread messages, notifications, or the status of something.

### Badge text
By using the [BadgeText](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TabView.SfTabItem.html#Syncfusion_Maui_TabView_SfTabItem_BadgeText) property in the SfTabItem, you can add text to badge view.

{% tabs %}

{% highlight xaml %}
<tabView:SfTabView>
    <tabView:SfTabItem BadgeText="20"/>
</tabView:SfTabView>
{% endhighlight %}

{% highlight C# %}
var tabView = new SfTabView();
var tabItems = new TabItemCollection
{
    new SfTabItem()
    {
        BadgeText = "20",
    }
}
{% endhighlight %}

{% endtabs %}

### Badge settings

The [BadgeSettings](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TabView.SfTabItem.html#Syncfusion_Maui_TabView_SfTabItem_BadgeSettings) property helps you to customize the basic look and feel of the badge view in the SfTabItem. 

[BadgeSettings](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TabView.SfTabItem.html#Syncfusion_Maui_TabView_SfTabItem_BadgeSettings) contains the sub-elements such as badge types, positions, and colors. You can customize the background color, text color, border color, width, offset, and font attributes.

N> To customize the badge beyond predefined styles, set [Type](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.BadgeSettings.html#Syncfusion_Maui_Core_BadgeSettings_Type) property to [None](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.BadgeType.html#Syncfusion_Maui_Core_BadgeType_None) in the [BadgeSettings.](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.BadgeSettings.html#properties)

{% tabs %}

{% highlight xaml %}
<ContentPage
    . . .  
    xmlns:tabView="clr-namespace:Syncfusion.Maui.TabView;assembly=Syncfusion.Maui.TabView  
    xmlns:core="clr-namespace:Syncfusion.Maui.Core;assembly=Syncfusion.Maui.Core">
    <tabView:SfTabView>
        <tabView:SfTabItem Header="RECENTS" BadgeText="20">
            <tabView:SfTabItem.BadgeSettings >
                <core:BadgeSettings FontSize="15" 
                                    FontAttributes="Bold" 
                                    FontFamily="serif"/>
            </tabView:SfTabItem.BadgeSettings>
        </tabView:SfTabItem>
    </tabView:SfTabView>    
</ContentPage>
{% endhighlight %}

{% highlight C# %}

using Syncfusion.Maui.Core;
using Syncfusion.Maui.TabView;
...

var tabView = new SfTabView();
BadgeSettings badgeSetting = new BadgeSettings();
badgeSetting.FontAttributes = FontAttributes.Bold;
badgeSetting.FontSize = 15;
badgeSetting.FontFamily = "serif";

var tabItems = new TabItemCollection()
{
    new SfTabItem()
    {
        Header="TabItem",
        BadgeText = "Inbox",
        BadgeSettings = badgeSetting,
    }
};

tabView.Items = tabItems;
            
{% endhighlight %}

{% endtabs %}

![Tabview BadgeSupport](images/TabItem_badge.png) 

N> View [sample](https://github.com/SyncfusionExamples/maui-tabview-samples/tree/main/TabViewCustomizationSample) in GitHub.

## Tab Header Padding

The [TabHeaderPadding](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TabView.SfTabView.html#Syncfusion_Maui_TabView_SfTabView_TabHeaderPadding) property in [SfTabView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TabView.SfTabView.html?tabs=tabid-1) allows for adding padding to the tab header.

N> The `TabHeaderPadding` property is only applicable when [TabWidthMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TabView.SfTabView.html#Syncfusion_Maui_TabView_SfTabView_TabWidthMode) is set to [SizeToContent](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TabView.TabWidthMode.html#Syncfusion_Maui_TabView_TabWidthMode_SizeToContent).

{% tabs %}

{% highlight xaml %}
<tabView:SfTabView TabWidthMode="SizeToContent" TabHeaderPadding="5,10,5,10">
    <tabView:SfTabItem/>
</tabView:SfTabView>
{% endhighlight %}

{% highlight C# %}
var tabView = new SfTabView();
tabView.TabWidthMode = TabWidthMode.SizeToContent;
tabView.TabHeaderPadding = new Thickness(5, 10, 5, 10);
{% endhighlight %}

{% endtabs %}

![Image Text Spacing](images/TabViewHeaderItem_Padding.png)

## Scroll buttons on Header

Scroll buttons are used to navigate through the items in the header of the tab view by adjusting the [IsScrollButtonEnabled](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TabView.SfTabView.html#Syncfusion_Maui_TabView_SfTabView_IsScrollButtonEnabled) property of [SfTabView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TabView.SfTabView.html?tabs=tabid-1). This functionality additionally indicates the presence of tabs beyond the currently visible area.

{% tabs %}

{% highlight xaml %}
<tabView:SfTabView  IsScrollButtonEnabled="True">
    <tabView:SfTabItem/>
</tabView:SfTabView>
{% endhighlight %}

{% highlight C# %}
var tabView = new SfTabView();
tabView.IsScrollButtonEnabled = true;
{% endhighlight %}

{% endtabs %}

![TabView Scroll Mode](images/TabViewScroll.gif) 

### Scroll button customization

The [ScrollButtonBackground](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TabView.SfTabView.html#Syncfusion_Maui_TabView_SfTabView_ScrollButtonBackground) and [ScrollButtonColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TabView.SfTabView.html#Syncfusion_Maui_TabView_SfTabView_ScrollButtonColor) property of [SfTabView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TabView.SfTabView.html?tabs=tabid-1) allows users to customize the background color and foreground color of scroll button.

{% tabs %}

{% highlight xaml %}
<tabView:SfTabView ScrollButtonBackground="Violet" ScrollButtonColor="Red">
</tabView:SfTabView>
{% endhighlight %}

{% highlight C# %}
StackLayout stackLayout = new StackLayout();
var tabView = new SfTabView();
tabView.ScrollButtonBackground = SolidColorBrush.Violet;
tabView.ScrollButtonColor = Colors.Red;
stackLayout.Children.Add(tabView);
this.Content = stackLayout;
{% endhighlight %}

{% endtabs %}

![ScrollButtonCustomization](images\ScrollButtonCustomization.png)

## Font auto scaling enabled

The [FontAutoScalingEnabled](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TabView.SfTabItem.html#Syncfusion_Maui_TabView_SfTabItem_FontAutoScalingEnabled) property is used to automatically scale the tab header's font size based on the operating system's text size. The default value of the `FontAutoScalingEnabled` property is `false.`

{% tabs %}

{% highlight xaml %}
<tabView:SfTabView FontAutoScalingEnabled="True">
...
</tabView:SfTabView>
{% endhighlight %}

{% highlight C# %}
var tabView = new SfTabView();
tabView.FontAutoScalingEnabled = true;
{% endhighlight %}

{% endtabs %}

## Content transition duration

You can customize the animation duration when changing the [SelectedIndex](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TabView.SfTabView.html#Syncfusion_Maui_TabView_SfTabView_SelectedIndex) of the Tab View by setting the [ContentTransitionDuration](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TabView.SfTabView.html#Syncfusion_Maui_TabView_SfTabView_ContentTransitionDuration) property.

{% tabs %}

{% highlight xaml %}
<tabView:SfTabView  ContentTransitionDuration ="1000">
    <tabView:SfTabItem/>
</tabView:SfTabView>
{% endhighlight %}

{% highlight C# %}
var tabView = new SfTabView();
tabView.ContentTransitionDuration = 1000;
{% endhighlight %}

{% endtabs %}

![ContentTransitionDuration](images/ContentTransition.gif)

## Image size

You can customize the image size in the .NET MAUI TabView control by setting the [ImageSize](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TabView.SfTabItem.html#Syncfusion_Maui_TabView_SfTabItem_ImageSize) property.

{% tabs %}

{% highlight xaml %}
<tabView:SfTabView>
    <tabView:SfTabItem ImageSize="50"/>
</tabView:SfTabView>
{% endhighlight %}

{% highlight C# %}
StackLayout stackLayout = new StackLayout();
var tabView = new SfTabView();
var tabItems = new TabItemCollection
{
    new SfTabItem()
    {
        ImageSize = 50,
    }
};
tabView.Items = tabItems;
stackLayout.Children.Add(tabView);
this.Content = stackLayout;
{% endhighlight %}

{% endtabs %}
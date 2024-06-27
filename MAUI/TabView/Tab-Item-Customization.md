---
layout: post
title: Display Type in .NET MAUI Tab View (SfTabView) control | Syncfusion
description: Learn here all about color and font customization in Syncfusion .NET MAUI Tab View (SfTabView) control.
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
        <tabView:SfTabItem Header="ITEM 1">
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
        <tabView:SfTabItem Header="ITEM 1" ImageSource="alexandar">
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
            Header="ITEM 2",
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

The .NET MAUI Tab View provides four options that determine how the image of the tab aligns relative to the text. The options are left, top, right and bottom. It can be achieved using the [TabImagePosition](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TabView.TabImagePosition.html) property of [SfTabItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TabView.SfTabItem.html) of type [TabImagePosition](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TabView.TabImagePosition.html).

N> Each tab item can be set with different image positions. Visual State Manager can be used to apply same value to all tabs.

### Top

The image will be placed above the text vertically.

{% tabs %}

{% highlight xaml %}
    <tabView:SfTabView>
        <tabView:SfTabItem TabImagePosition="Top">
    </tabView:SfTabView>
{% endhighlight %}

{% highlight C# %}
    var tabView = new SfTabView();
    var tabItems = new TabItemCollection
    {
        new SfTabItem()
        {
            TabImagePosition = TabImagePosition.Top,
        }
    }
{% endhighlight %}

{% endtabs %}

![Tab Image Position Top](images/Image-Position-Top.png) 

### Bottom

The image will be placed below the text vertically.

{% tabs %}

{% highlight xaml %}
    <tabView:SfTabView>
        <tabView:SfTabItem TabImagePosition="Bottom">
    </tabView:SfTabView>
{% endhighlight %}

{% highlight C# %}
    var tabView = new SfTabView();
    var tabItems = new TabItemCollection
    {
        new SfTabItem()
        {
            TabImagePosition = TabImagePosition.Bottom,
        }
    }
{% endhighlight %}

{% endtabs %}

![Tab Image Position Bottom](images/Image-Position-Bottom.png) 

### Left

The image will be placed before the text horizontally.

{% tabs %}

{% highlight xaml %}
    <tabView:SfTabView>
        <tabView:SfTabItem TabImagePosition="Left">
    </tabView:SfTabView>
{% endhighlight %}

{% highlight C# %}
    var tabView = new SfTabView();
    var tabItems = new TabItemCollection
    {
        new SfTabItem()
        {
            TabImagePosition = TabImagePosition.Left,
        }
    }
{% endhighlight %}

{% endtabs %}

![Tab Image Position Left](images/Image-Position-Left.png) 

### Right

The image will be placed to the right side of the text horizontally.

{% tabs %}

{% highlight xaml %}
    <tabView:SfTabView>
        <tabView:SfTabItem TabImagePosition="Right">
    </tabView:SfTabView>
{% endhighlight %}

{% highlight C# %}
    var tabView = new SfTabView();
    var tabItems = new TabItemCollection
    {
        new SfTabItem()
        {
            TabImagePosition = TabImagePosition.Right,
        }
    }
{% endhighlight %}

{% endtabs %}

![Tab Image Position Right](images/Image-Position-Right.png) 

## Image Text Spacing

The [ImageTextSpacing](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TabView.SfTabItem.html#Syncfusion_Maui_TabView_SfTabItem_ImageTextSpacing) property in SfTabItem allows for the provision of spacing between the image and the text of the tab item.

{% tabs %}

{% highlight xaml %}
<tabView:SfTabView>
    <tabView:SfTabItem ImageTextSpacing="20">
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
        <tabView:SfTabItem BadgeText="Inbox"/>
    </tabView:SfTabView>
{% endhighlight %}

{% highlight C# %}
    var tabView = new SfTabView();
    var tabItems = new TabItemCollection
    {
        new SfTabItem()
        {
            BadgeText = "Inbox",
        }
    }
{% endhighlight %}

{% endtabs %}

### Badge settings

The [BadgeSettings](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TabView.SfTabItem.html#Syncfusion_Maui_TabView_SfTabItem_BadgeSettings) property helps you to customize the basic look and feel of the badge view in the SfTabItem. 

[BadgeSettings](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TabView.SfTabItem.html#Syncfusion_Maui_TabView_SfTabItem_BadgeSettings) contains the sub-elements such as badge types, positions, and colors. You can customize the background color, text color, border color, width, offset, and font attributes.

{% tabs %}

{% highlight xaml %}
    <tabView:SfTabView>
        <tabView:SfTabItem Header="RECENTS" BadgeText="20">
            <tabView:SfTabItem.BadgeSettings >
                <core:BadgeSettings FontSize="15" 
                                    FontAttributes="Bold" 
                                    FontFamily="serif"/>
            </tabView:SfTabItem.BadgeSettings>
        </tabView:SfTabItem>
    </tabView:SfTabView>
{% endhighlight %}

{% highlight C# %}

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
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
        <tabView:SfTabItem Header="Item 1">
    </tabView:SfTabView>
{% endhighlight %}

{% highlight C# %}
    var tabView = new SfTabView();
    var tabItems = new TabItemCollection
    {
        new SfTabItem()
        {
            Header = "Item 1",
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
        <tabView:SfTabItem Header="Item 1" ImageSource="alexandar">
    </tabView:SfTabView>
{% endhighlight %}

{% highlight C# %}
    var tabView = new SfTabView();
    var tabItems = new TabItemCollection
    {
        new SfTabItem()
        {
            Header = "Item 1",
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
        <tabView:SfTabItem Header="Calls" ImageSource="alexandar">
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
            Header = "Calls",
            ImageSource = "alexandar",
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

N> View [sample](https://github.com/SyncfusionExamples/maui-tabview-samples/tree/main/TabViewCustomizationSample) in GitHub

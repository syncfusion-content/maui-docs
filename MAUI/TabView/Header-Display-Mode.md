---
layout: post
title: Header display Mode in .NET MAUI Tab View control | Syncfusion®
description: Learn all about header display mode support in the Syncfusion® .NET MAUI Tab View (SfTabView) control and more.
platform: MAUI
control: SfTabView
documentation: UG
---

# Header Display Mode in .NET MAUI Tab View control (SfTabView)

By default, the [.NET MAUI Tab View](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TabView.SfTabView.html) control displays the title of each Tab Item. It can be customized to display in any of the following modes:

* Default
* Image
* Text

![Image for HeaderDisplayMode](images/Header-Display-Mode.png)

The Tab View can be modified by setting the [HeaderDisplayMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TabView.SfTabView.html#Syncfusion_Maui_TabView_SfTabView_HeaderDisplayMode) property of the [.NET MAUI Tab View](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TabView.html).

{% tabs %}

{% highlight xaml %}

<tabView:SfTabView HeaderDisplayMode="Default">
    <tabView:SfTabItem Header="Item1" ImageSource="avatar1.png" />
    <tabView:SfTabItem Header="Item2" ImageSource="avatar2.png" />
    <tabView:SfTabItem Header="Item3" ImageSource="avatar3.png" />
</tabView:SfTabView>

{% endhighlight %}

{% highlight C# %}

SfTabView tabView = new SfTabView
{
    HeaderDisplayMode = TabBarDisplayMode.Default
};
SfTabItem tabItem1 = new SfTabItem
{
    Header = "Item1",
    ImageSource = "avatar1.png"
};
SfTabItem tabItem2 = new SfTabItem
{
    Header = "Item2",
    ImageSource = "avatar2.png"
};
SfTabItem tabItem3 = new SfTabItem
{
    Header = "Item3",
    ImageSource = "avatar3.png"
};
tabView.Items.Add(tabItem1);
tabView.Items.Add(tabItem2);
tabView.Items.Add(tabItem3);

{% endhighlight %}

{% endtabs %}

N> The [HeaderDisplayMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TabView.SfTabView.html#Syncfusion_Maui_TabView_SfTabView_HeaderDisplayMode) will only apply if both a [Header](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TabView.SfTabItem.html#Syncfusion_Maui_TabView_SfTabItem_Header) and an [ImageSource](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TabView.SfTabItem.html#Syncfusion_Maui_TabView_SfTabItem_ImageSource) are provided for the Tab Item. If either is missing, the Tab Item will automatically apply the Default mode.
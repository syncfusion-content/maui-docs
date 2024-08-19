---
layout: post
title: Header Display Mode in Maui Tabbed View control | Syncfusion
description: Learn here all about Header Display Mode support in Syncfusion Maui Tabbed View (SfTabView) control and more.
platform: maui
control: TabView
documentation: ug
---

# Header Display Mode in Maui Tabbed View (SfTabView)

By default, the tab view control displays the title of each tab item. It can be changed to any of the following types:

* Default
* Image
* Text

![Image for HeaderDisplayMode](images/Header-Display-Mode.png)

The tab view can be changed by setting the `HeaderDisplayMode` property of [`SfTabView`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TabView.html).

{% tabs %}

{% highlight xaml %}

    <ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
                xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
                x:Class="TabView.MainPage"
                xmlns:tabView="clr-namespace:Syncfusion.Maui.TabView;assembly=Syncfusion.Maui.TabView">

        <tabView:SfTabView HeaderDisplayMode="Default">
            <tabView:SfTabItem Header="Item1" ImageSource="avatar1.png" />
            <tabView:SfTabItem Header="Item2" ImageSource="avatar2.png" />
            <tabView:SfTabItem Header="Item3" ImageSource="avatar3.png" />
        </tabView:SfTabView>

    </ContentPage>

{% endhighlight %}

{% highlight C# %}

    using Syncfusion.Maui.TabView;
    namespace UGSample
    {
        public partial class MainPage : ContentPage
        {          
            public MainPage()
            {
                InitializeComponent();
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
                this.Content = tabView;
            }
        }
    }

{% endhighlight %}

{% endtabs %}

    N> `Image` appearance in the header can be achieved through font icons.

    N> The `HeaderDisplayMode` will work only when both a header text and an image are available for the TabItem. If either the text or image is missing, the Default mode will be used.


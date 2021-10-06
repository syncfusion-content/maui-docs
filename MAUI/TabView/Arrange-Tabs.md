---
layout: post
title: Tab arrangement in .NET MAUI Tab View | Syncfusion
description: Learn here all about tab view header customization support in Syncfusion .NET MAUI Tab View (SfTabView) control and more.
platform: maui
control: Tab View
documentation: ug
---

# Arrange tabs in .NET MAUI Tab View (SfTabView)

.NET MAUI Tab View provides two modes that determine how the width of the tab is calculated on the tab bar while it gets populated. The options are `Default` and `SizeToContent` and can be achieved using [TabWidthMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TabView.TabWidthMode.html) property.

## Fixed bar

The width of the tab is divided equally based on the available control width. This enables a fixed tab bar that won’t allow tab scrolling even it contains any number of tabs. This can be achieved by setting the `TabWidthMode` as `Default`.

N> This mode is recommended when the tab count is not more than 4. More tabs in this mode may appear with the text being trimmed.

![Tab Width Mode Default](images/Tab-Width-Mode-Default.png)

## Based on the text size

The width of a tab is set to fit the text or image that it contains by setting the `TabWidthMode` as `SizeToContent`. Scroll is enabled in this mode to access the items that are outside the visible area.

![Tab Width Mode Size to fit](images/Tab-Width-Mode-SizeToFit.png) 

{% tabs %}

{% highlight xaml %}

<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             x:Class="TabViewMauiSample.MainPage"
             xmlns:tabView="http://schemas.syncfusion.com/maui"
             BackgroundColor="{DynamicResource SecondaryColor}">
    <ContentPage.Content>
         <tabView:SfTabView TabWidthMode="SizeToContent">
            <tabView:SfTabItem Header="Call">
                <tabView:SfTabItem.Content>
                    <ListView RowHeight="50">
                        ...
                    </ListView>
                </tabView:SfTabItem.Content>
            </tabView:SfTabItem>
            <tabView:SfTabItem Header="Favorites">
                <tabView:SfTabItem.Content>
                    <ListView RowHeight="50">
                       ...
                    </ListView>
                </tabView:SfTabItem.Content>
            </tabView:SfTabItem>
            <tabView:SfTabItem Header="Contacts">
                <tabView:SfTabItem.Content>
                    <ListView RowHeight="50">
                       ...
                    </ListView>
                </tabView:SfTabItem.Content>
            </tabView:SfTabItem>
        </tabView:SfTabView>
    </ContentPage.Content>
</ContentPage>

{% endhighlight %}

{% highlight C# %}

using Syncfusion.Maui.TabView;

namespace TabViewMauiSample
{
	public partial class TabView : ContentPage
	{
        SfTabView tabView;
		public TabView ()
		{
			InitializeComponent ();
            var tabView = new SfTabView();
            var tabItems = new TabItemCollection
            {
                new SfTabItem()
                {
                    Header = "Calls",
                    Content = new ListView()
                    {
                        //// code
                    },
                },
                new SfTabItem()
                {
                    Header = "Favorites",
                    Content = new ListView()
                    {
                        //// code
                    },
                },
                new SfTabItem()
                {
                    Header = "Contacts",
                    Content = new ListView()
                    {
                        //// code
                    },
                }
            };

            tabView.TabWidthMode = TabWidthMode.SizeToContent;
            tabView.Items = tabItems;
            this.Content = tabView;
		}
	}
}

{% endhighlight %}

{% endtabs %}

![Getting_Started](images/Arrange_Tabs.png)

N> View [sample](https://github.com/SyncfusionExamples/maui-tabview-samples/tree/main/TabViewWidthCustomization) in GitHub
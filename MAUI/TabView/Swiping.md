---
layout: post
title: Swiping in .NET MAUI Tab View (SfTabView) | Syncfusion®
description: Learn all about enabling swipe support in Syncfusion® .NET MAUI Tab View (SfTabView) control and more.
platform: MAUI
control: SfTabView
documentation: UG
---

# Swiping in .NET MAUI Tab View (SfTabView)

## Prerequisites

Before using the [SfTabView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TabView.SfTabView.html), ensure the following NuGet package is installed in your .NET MAUI project:

- `Syncfusion.Maui.TabView`

For step-by-step setup, refer to the [Getting Started](https://help.syncfusion.com/maui/tabview/getting-started) documentation.

## Enable swiping

Set the [`EnableSwiping`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TabView.SfTabView.html#Syncfusion_Maui_TabView_SfTabView_EnableSwiping) property of `SfTabView` to allow users to switch between tab contents by swiping horizontally. The property is of type `bool` and defaults to `false`. When enabled, swiping left or right on the tab content moves to the adjacent tab; tapping a tab header or programmatically setting `SelectedIndex` also continues to work.

{% tabs %}

{% highlight xaml %}

<tabView:SfTabView EnableSwiping="true">
    <tabView:SfTabItem Header="ITEM 1">
        <tabView:SfTabItem.Content>
            <Label Text="Tab item content"
                   HorizontalOptions="Center"
                   VerticalOptions="Center" />
        </tabView:SfTabItem.Content>
    </tabView:SfTabItem>
    <tabView:SfTabItem Header="ITEM 2">
        <tabView:SfTabItem.Content>
            <Label Text="Tab item content"
                   HorizontalOptions="Center"
                   VerticalOptions="Center" />
        </tabView:SfTabItem.Content>
    </tabView:SfTabItem>
    <tabView:SfTabItem Header="ITEM 3">
        <tabView:SfTabItem.Content>
            <Label Text="Tab item content"
                   HorizontalOptions="Center"
                   VerticalOptions="Center" />
        </tabView:SfTabItem.Content>
    </tabView:SfTabItem>
</tabView:SfTabView>

{% endhighlight %}
{% highlight C# %}

SfTabView tabView = new SfTabView
{
    EnableSwiping = true,
    Items = new TabItemCollection
    {
        new SfTabItem()
        {
            Header = "ITEM 1",
            Content = new Label
            {
                Text = "Tab item content",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            }
        },
        new SfTabItem()
        {
            Header = "ITEM 2",
            Content = new Label
            {
                Text = "Tab item content",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            }
        },
        new SfTabItem()
        {
            Header = "ITEM 3",
            Content = new Label
            {
                Text = "Tab item content",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            }
        }
    }
};

{% endhighlight %}
{% endtabs %}

![Swiping between tabs in the .NET MAUI Tab View](images/tabview-swiping.gif)

### Limitations

* **Interference between child controls and Tab View swiping:** When a child control within a Tab View supports horizontal swiping or interaction (e.g., a horizontal ScrollView, a custom swipe-enabled control, or a carousel), it can interfere with the Tab View's touch gesture. This may result in unintended behavior, such as the Tab View swiping when the child control is meant to handle the gesture, or vice versa. The overlapping gestures can cause confusion and disrupt the expected user experience, leading to a less intuitive interface.

## See also

* [Events in .NET MAUI Tab View](https://help.syncfusion.com/maui/tabview/events)
* [Tab Item Customization in .NET MAUI Tab View](Thttps://help.syncfusion.com/maui/tabview/tab-item-customization)
* [Nested Tabs in .NET MAUI Tab View](https://help.syncfusion.com/maui/tabview/nested-tabs)
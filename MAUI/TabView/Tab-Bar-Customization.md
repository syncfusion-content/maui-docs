---
layout: post
title: Customize the Tab Bar in .NET MAUI Tab View (SfTabView) | Syncfusion®
description: Learn all about custom header support in the Syncfusion® .NET MAUI Tab View (SfTabView) control and more.
platform: MAUI
control: SfTabView
documentation: UG
---

# Customize the Tab Bar in .NET MAUI Tab View (SfTabView)

The [.NET MAUI Tab View](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TabView.SfTabView.html) control supports customizing the tab bar appearance and layout through the following properties:

- TabBarPlacement
- TabWidthMode
- TabBarHeight
- TabBarSize
- HeaderHorizontalTextAlignment
- HeaderItemSpacing
- AnimationEasing
- TabBarBackground
- TabBarBorderColor
- TabBarBorderThickness
- TabBarCornerRadius.

These properties provide flexibility in configuring the tab bar's position, size, spacing, animation behavior, background, border styling, and text alignment, enabling you to create a customized tab navigation experience.

## Prerequisites

Before using the [SfTabView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TabView.SfTabView.html), ensure the following NuGet package is installed in your .NET MAUI project:

- `Syncfusion.Maui.TabView`

For step-by-step setup, refer to the [Getting Started](https://help.syncfusion.com/maui/tabview/getting-started) documentation.

## TabBarPlacement options

The .NET MAUI Tab View provides four options for determining how the tab bar aligns relative to the tab content. The options are `Top`, `Bottom`, `Left`, and `Right`. This can be achieved using the [TabBarPlacement](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TabView.SfTabView.html#Syncfusion_Maui_TabView_SfTabView_TabBarPlacement) property.

### Top

The tab bar will be placed above the content region of the Tab View control.

{% tabs %}
{% highlight xaml %}

<tabView:SfTabView TabBarPlacement="Top"
                   TabBarSize="60"
                   IndicatorWidthMode="Stretch">
    <tabView:SfTabView.Items>
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
    </tabView:SfTabView.Items>
</tabView:SfTabView>

{% endhighlight %}

{% highlight C# %}

SfTabView tabView = new SfTabView
{
    TabBarPlacement = TabBarPlacement.Top,
    TabBarSize = 60,
    IndicatorWidthMode = IndicatorWidthMode.Stretch,
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

![Tab bar placed at the top of the Tab View](images/Tab-bar-Placement-Top.png)

### Bottom

The tab bar will be placed below the content region of the Tab View control. 

{% tabs %}
{% highlight xaml %}

<tabView:SfTabView TabBarPlacement="Bottom"
                   TabBarSize="60"
                   IndicatorWidthMode="Stretch">
    <tabView:SfTabView.Items>
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
    </tabView:SfTabView.Items>
</tabView:SfTabView>

{% endhighlight %}

{% highlight C# %}

SfTabView tabView = new SfTabView
{
    TabBarPlacement = TabBarPlacement.Bottom,
    TabBarSize = 60,
    IndicatorWidthMode = IndicatorWidthMode.Stretch,
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

![Tab bar placed at the bottom of the Tab View](images/Tab-bar-Placement-Bottom.png)

### Left

The tab bar will be placed to the left of the content region of the Tab View control.

{% tabs %}
{% highlight xaml %}

<tabView:SfTabView TabBarPlacement="Left"
                   TabBarSize="60"
                   IndicatorWidthMode="Stretch">
    <tabView:SfTabView.Items>
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
    </tabView:SfTabView.Items>
</tabView:SfTabView>

{% endhighlight %}

{% highlight C# %}

SfTabView tabView = new SfTabView
{
    TabBarPlacement = TabBarPlacement.Left,
    TabBarSize = 60,
    IndicatorWidthMode = IndicatorWidthMode.Stretch,
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

![Tab bar placed to the left of the Tab View](images/TabBarPlacementLeft.png)

### Right

The tab bar will be placed to the right of the content region of the Tab View control. 

{% tabs %}
{% highlight xaml %}

<tabView:SfTabView TabBarPlacement="Right"
                   TabBarSize="60"
                   IndicatorWidthMode="Stretch">
    <tabView:SfTabView.Items>
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
    </tabView:SfTabView.Items>
</tabView:SfTabView>

{% endhighlight %}

{% highlight C# %}

SfTabView tabView = new SfTabView
{
    TabBarPlacement = TabBarPlacement.Right,
    TabBarSize = 60,
    IndicatorWidthMode = IndicatorWidthMode.Stretch,
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

![Tab bar placed to the right of the Tab View](images/TabBarPlacementRight.png)

## Tab width options

The .NET MAUI Tab View provides two modes that determine how the width of the tab is calculated on the tab bar while it gets populated. The options are [Default](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TabView.TabWidthMode.html#Syncfusion_Maui_TabView_TabWidthMode_Default) and [SizeToContent](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TabView.TabWidthMode.html#Syncfusion_Maui_TabView_TabWidthMode_SizeToContent). These can be achieved using the [TabWidthMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TabView.TabWidthMode.html) property.

### Fixed bar

The width of the tab is divided equally based on the available control width. This enables a fixed tab bar that will not allow tab scrolling, regardless of the number of tabs. Set `TabWidthMode` to `Default` to enable this behavior.

N> This mode is recommended when the tab count is four or fewer. More tabs in this mode may appear with the text being trimmed.

{% tabs %}

{% highlight xaml %}
<tabView:SfTabView TabWidthMode="Default">
    <tabView:SfTabItem Header="Item1" />
    <tabView:SfTabItem Header="Item2" />
    <tabView:SfTabItem Header="Item3" />
</tabView:SfTabView>

{% endhighlight %}
{% highlight C# %}

SfTabView tabView = new SfTabView
{
    TabWidthMode = TabWidthMode.Default,
    Items = new TabItemCollection
    {
        new SfTabItem { Header = "Item1" },
        new SfTabItem { Header = "Item2" },
        new SfTabItem { Header = "Item3" }
    }
};

{% endhighlight %}

{% endtabs %}

![Tab width mode set to default with equal-width tabs](images/Tab-Width-Mode-Default.png)

### Based on the text size

The width of a tab is set to fit the text or image that it contains when `TabWidthMode` is `SizeToContent`. Scroll is enabled in this mode to access the items outside the visible area.

{% tabs %}

{% highlight xaml %}
<tabView:SfTabView TabWidthMode="SizeToContent">
    <tabView:SfTabItem Header="Item1" />
    <tabView:SfTabItem Header="Item2" />
    <tabView:SfTabItem Header="Item3" />
</tabView:SfTabView>

{% endhighlight %}
{% highlight C# %}

SfTabView tabView = new SfTabView
{
    TabWidthMode = TabWidthMode.SizeToContent,
    Items = new TabItemCollection
    {
        new SfTabItem { Header = "Item1" },
        new SfTabItem { Header = "Item2" },
        new SfTabItem { Header = "Item3" }
    }
};

{% endhighlight %}

{% endtabs %}

![Tab width mode set to size-to-content with scrolling enabled](images/Tab-Width-Mode-SizeToFit.png)

## Customize the TabBarSize

The size of the tab bar can be customized by setting the [TabBarSize](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TabView.SfTabView.html#Syncfusion_Maui_TabView_SfTabView_TabBarSize) property. The property is of type `double` and the default size is `48`. The `TabBarSize` property controls the tab bar's height when `TabBarPlacement` is `Top` or `Bottom`, and its width when `TabBarPlacement` is `Left` or `Right`.

{% tabs %}

{% highlight xaml %}
<tabView:SfTabView TabBarSize="100" TabBarPlacement="Left">
    <tabView:SfTabItem Header="Item1" />
    <tabView:SfTabItem Header="Item2" />
    <tabView:SfTabItem Header="Item3" />
</tabView:SfTabView>

{% endhighlight %}
{% highlight C# %}

SfTabView tabView = new SfTabView
{
    TabBarSize = 100,
    TabBarPlacement = TabBarPlacement.Left,
    Items = new TabItemCollection
    {
        new SfTabItem { Header = "Item1" },
        new SfTabItem { Header = "Item2" },
        new SfTabItem { Header = "Item3" }
    }
};

{% endhighlight %}

{% endtabs %}

## Customize the TabBarHeight

The height of the tab bar can be customized by setting the [TabBarHeight](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TabView.SfTabView.html#Syncfusion_Maui_TabView_SfTabView_TabBarHeight) property. The default height is 48.

N> It is recommended to set the `TabBarHeight` to 72 while displaying both the image and text with ImagePosition as either top or bottom.

{% tabs %}

{% highlight xaml %}
<tabView:SfTabView TabBarHeight="100" TabBarPlacement="Top">
    <tabView:SfTabItem Header="Item1" />
    <tabView:SfTabItem Header="Item2" />
    <tabView:SfTabItem Header="Item3" />
</tabView:SfTabView>

{% endhighlight %}
{% highlight C# %}

SfTabView tabView = new SfTabView
{
    TabBarHeight = 100,
    TabBarPlacement = TabBarPlacement.Top,
    Items = new TabItemCollection
    {
        new SfTabItem { Header = "Item1" },
        new SfTabItem { Header = "Item2" },
        new SfTabItem { Header = "Item3" }
    }
};

{% endhighlight %}
{% endtabs %}

N> The `TabBarHeight` property is `obsolete` - use `TabBarSize` instead. When `TabBarPlacement` is Top or Bottom, `TabBarSize` controls the tab bar's height; when `TabBarPlacement` is Left or Right, `TabBarSize` controls the tab bar's width.

## Customize the tab header text alignment

The horizontal text alignment of the tab header can be customized by setting the [HeaderHorizontalTextAlignment](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TabView.SfTabView.html#Syncfusion_Maui_TabView_SfTabView_HeaderHorizontalTextAlignment) property. The property is of type `TextAlignment` and the default value is `Center`. This property accepts the following values:

- `Start` - Places the text at the starting position in the header tab.
- `Center` - Places the text at the center of the header tab.
- `End` - Places the text at the end of the header tab.

{% tabs %}

{% highlight xaml %}
<tabView:SfTabView HeaderHorizontalTextAlignment="Center">
    <tabView:SfTabItem Header="Item1" />
    <tabView:SfTabItem Header="Item2" />
    <tabView:SfTabItem Header="Item3" />
</tabView:SfTabView>

{% endhighlight %}
{% highlight C# %}

SfTabView tabView = new SfTabView
{
    HeaderHorizontalTextAlignment = TextAlignment.Center,
    Items = new TabItemCollection
    {
        new SfTabItem { Header = "Item1" },
        new SfTabItem { Header = "Item2" },
        new SfTabItem { Header = "Item3" }
    }
};

{% endhighlight %}

{% endtabs %}

![Tab header text aligned to the center](images/HorizontalTextAlignmentCenter.png)

## Customize the HeaderItemSpacing

Use the [HeaderItemSpacing](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TabView.SfTabView.html#Syncfusion_Maui_TabView_SfTabView_HeaderItemSpacing) property to set the spacing between tab items. The property is of type `double` and the default spacing is `36`.

> **Note** `HeaderItemSpacing` is effective only when `TabWidthMode` is set to `SizeToContent`.

{% tabs %}

{% highlight xaml %}
<tabView:SfTabView HeaderItemSpacing="100" TabWidthMode="SizeToContent">
    <tabView:SfTabItem Header="Item1" />
    <tabView:SfTabItem Header="Item2" />
    <tabView:SfTabItem Header="Item3" />
</tabView:SfTabView>

{% endhighlight %}
{% highlight C# %}

SfTabView tabView = new SfTabView
{
    HeaderItemSpacing = 100,
    TabWidthMode = TabWidthMode.SizeToContent,
    Items = new TabItemCollection
    {
        new SfTabItem { Header = "Item1" },
        new SfTabItem { Header = "Item2" },
        new SfTabItem { Header = "Item3" }
    }
};

{% endhighlight %}

{% endtabs %}

![Header item spacing set to 100](images/HeaderItemSpacing.png)

## AnimationEasing

The animation of the tab item content and selection indicator can be customized by setting the [AnimationEasing](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TabView.SfTabView.html#Syncfusion_Maui_TabView_SfTabView_AnimationEasing) property. The property is of type `Easing` and the default value is `Easing.Linear`. Common values include `Easing.Linear`, `Easing.CubicInOut`, `Easing.SpringOut`, and `Easing.BounceIn`.

{% tabs %}

{% highlight xaml %}
<tabView:SfTabView AnimationEasing="SpringOut">
    <tabView:SfTabItem Header="Item1" />
    <tabView:SfTabItem Header="Item2" />
    <tabView:SfTabItem Header="Item3" />
</tabView:SfTabView>

{% endhighlight %}
{% highlight C# %}

SfTabView tabView = new SfTabView
{
    AnimationEasing = Easing.SpringOut,
    Items = new TabItemCollection
    {
        new SfTabItem { Header = "Item1" },
        new SfTabItem { Header = "Item2" },
        new SfTabItem { Header = "Item3" }
    }
};

{% endhighlight %}

{% endtabs %}

## TabBarBackground customization

The tab bar background can be customized using the [TabBarBackground](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TabView.SfTabView.html#Syncfusion_Maui_TabView_SfTabView_TabBarBackground) property, which is of type `Brush`.

### Solid color

Use a `Color` or `SolidColorBrush` to set the tab bar's background color.

{% tabs %}

{% highlight xaml %}
<tabView:SfTabView TabBarBackground="LightBlue">
    <tabView:SfTabItem Header="Item1" />
    <tabView:SfTabItem Header="Item2" />
    <tabView:SfTabItem Header="Item3" />
</tabView:SfTabView>

{% endhighlight %}
{% highlight C# %}

SfTabView tabView = new SfTabView
{
    TabBarBackground = new SolidColorBrush(Colors.LightBlue),
    Items = new TabItemCollection
    {
        new SfTabItem { Header = "Item1" },
        new SfTabItem { Header = "Item2" },
        new SfTabItem { Header = "Item3" }
    }
};

{% endhighlight %}

{% endtabs %}

![Tab bar background set to a solid color](images/TabBarSolidColor.png)

### Gradient color

The tab bar background can be customized with a linear gradient, as shown in the example below.

{% tabs %}

{% highlight xaml %}
<tabView:SfTabView>
    <tabView:SfTabView.TabBarBackground>
        <LinearGradientBrush EndPoint="0,1">
            <GradientStop Color="#009FFF" Offset="0.1" />
            <GradientStop Color="#ec2F4B" Offset="1.0" />
        </LinearGradientBrush>
    </tabView:SfTabView.TabBarBackground>
</tabView:SfTabView>

{% endhighlight %}
{% highlight C# %}

SfTabView tabView = new SfTabView
{
    TabBarBackground = new LinearGradientBrush
    {
        EndPoint = new Point(0, 1),
        GradientStops = new GradientStopCollection
        {
            new GradientStop
            {
                Color = Color.FromArgb("#009FFF"),
                Offset = 0.1f
            },
            new GradientStop
            {
                Color = Color.FromArgb("#ec2F4B"),
                Offset = 1.0f
            }
        }
    }
};

{% endhighlight %}

{% endtabs %}

![Tab bar background set to a linear gradient](images/TabBarGradientColor.png)

> **Note** View the [sample](https://github.com/SyncfusionExamples/maui-tabview-samples/tree/main/TabBarCustomization) on GitHub.

## Tab bar border customization

You can customize the border of the tab header area in .NET MAUI Tab View using the following properties:

- [TabBarBorderColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TabView.SfTabView.html#Syncfusion_Maui_TabView_SfTabView_TabBarBorderColor) - Sets the border color.
- [TabBarBorderThickness](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TabView.SfTabView.html#Syncfusion_Maui_TabView_SfTabView_TabBarBorderThickness) - Sets the border thickness.
- [TabBarCornerRadius](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TabView.SfTabView.html#Syncfusion_Maui_TabView_SfTabView_TabBarCornerRadius) - Sets the corner radius of the tab bar's border.

{% tabs %}

{% highlight xaml %}
<tabView:SfTabView TabBarPlacement="Bottom"
                   TabBarBorderColor="#7C3AED"
                   TabBarBorderThickness="2"
                   TabBarCornerRadius="24">
    <tabView:SfTabItem Header="Item1" />
    <tabView:SfTabItem Header="Item2" />
    <tabView:SfTabItem Header="Item3" />
</tabView:SfTabView>

{% endhighlight %}
{% highlight C# %}

SfTabView tabView = new SfTabView
{
    TabBarPlacement = TabBarPlacement.Bottom,
    TabBarBorderColor = Color.FromArgb("#7C3AED"),
    TabBarBorderThickness = 2,
    TabBarCornerRadius = new CornerRadius(24),
    Items = new TabItemCollection
    {
        new SfTabItem { Header = "Item1" },
        new SfTabItem { Header = "Item2" },
        new SfTabItem { Header = "Item3" }
    }
};

{% endhighlight %}

{% endtabs %}

![Tab bar with a custom border](images/Tab-bar-border.png)

## See also

* [Selection Indicator Customization in .NET MAUI Tab View](https://help.syncfusion.com/maui/tabview/selection-indicator-customization)
* [Header Display Mode in .NET MAUI Tab View](https://help.syncfusion.com/maui/tabview/header-display-mode)
* [Tab Item Customization in .NET MAUI Tab View](Thttps://help.syncfusion.com/maui/tabview/tab-item-customization)
* [Populating ItemsSource in .NET MAUI Tab View](https://help.syncfusion.com/maui/tabview/populating-itemssource)
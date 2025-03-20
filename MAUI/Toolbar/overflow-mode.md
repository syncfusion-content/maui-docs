---
layout: post
title: Overflow Mode in MAUI Toolbar Control | Syncfusion®
description: Learn here all about Overflow mode support in Syncfusion® MAUI Toolbar (SfToolbar) control and more.
platform: MAUI
control: Toolbar (SfToolbar)
documentation: ug
---

# Overflow Mode in MAUI Toolbar (SfToolbar)

This section explains the ways about how overflowing items are managed - Scroll for continuous navigation, Navigation Buttons for stepping through items, and More Button to display excess items in a dropdown.

## Scroll Mode

The Toolbar control enables scrolling when its items extend beyond the view. By default, the `OverflowMode` property is set to `Scroll`.

{% tabs %}

{% highlight xaml %}

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:local="clr-namespace:ToolbarSample"
             xmlns:toolbar="clr-namespace:Syncfusion.Maui.Toolbar;assembly=Syncfusion.Maui.Toolbar"
             x:Class="ToolbarSample.MainPage">
    <toolbar:SfToolbar x:Name="Toolbar" HeightRequest="56" WidthRequest="220" OverflowMode="Scroll">
        <toolbar:SfToolbar.Items>
            <toolbar:SfToolbarItem Name="Bold"
                    ToolTipText="Bold">
                <toolbar:SfToolbarItem.Icon>
                    <FontImageSource Glyph="&#xE770;"
                                FontFamily="MauiMaterialAssets" />
                </toolbar:SfToolbarItem.Icon>
            </toolbar:SfToolbarItem>
            <toolbar:SfToolbarItem Name="Underline"
                    ToolTipText="Underline">
                <toolbar:SfToolbarItem.Icon>
                    <FontImageSource Glyph="&#xE762;"
                                FontFamily="MauiMaterialAssets" />
                </toolbar:SfToolbarItem.Icon>
            </toolbar:SfToolbarItem>
            <toolbar:SfToolbarItem Name="Italic"
                    ToolTipText="Italic">
                <toolbar:SfToolbarItem.Icon>
                    <FontImageSource Glyph="&#xE771;"
                                FontFamily="MauiMaterialAssets" />
                </toolbar:SfToolbarItem.Icon>
            </toolbar:SfToolbarItem>
            <toolbar:SfToolbarItem Name="AlignLeft"
                            ToolTipText="Align-Left">
                <toolbar:SfToolbarItem.Icon>
                    <FontImageSource Glyph="&#xE751;"
                                FontFamily="MauiMaterialAssets" />
                </toolbar:SfToolbarItem.Icon>
            </toolbar:SfToolbarItem>
            <toolbar:SfToolbarItem Name="AlignRight"
                            ToolTipText="Align-Right">
                <toolbar:SfToolbarItem.Icon>
                    <FontImageSource Glyph="&#xE753;"
                    FontFamily="MauiMaterialAssets" />
                </toolbar:SfToolbarItem.Icon>
            </toolbar:SfToolbarItem>
            <toolbar:SfToolbarItem Name="AlignCenter"
                            ToolTipText="Align-Center">
                <toolbar:SfToolbarItem.Icon>
                    <FontImageSource Glyph="&#xE752;"
                    FontFamily="MauiMaterialAssets" />
                </toolbar:SfToolbarItem.Icon>
            </toolbar:SfToolbarItem>
            <toolbar:SfToolbarItem Name="AlignJustify"
                            ToolTipText="Align-Justify">
                <toolbar:SfToolbarItem.Icon>
                    <FontImageSource Glyph="&#xE74F;"
                    FontFamily="MauiMaterialAssets" />
                </toolbar:SfToolbarItem.Icon>
            </toolbar:SfToolbarItem>
        </toolbar:SfToolbar.Items>
    </toolbar:SfToolbar>
</ContentPage>

{% endhighlight %}

{% highlight c# %}

using Syncfusion.Maui.Toolbar;

namespace ToolbarSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            SfToolbar toolbar = new SfToolbar();
            toolbar.HeightRequest = 56;
            toolbar.WidthRequest = 220;
            toolbar.OverflowMode = ToolbarItemOverflowMode.Scroll;
            ObservableCollection<BaseToolbarItem> itemCollection = new ObservableCollection<BaseToolbarItem>
            {
                new SfToolbarItem
                {
                    Name = "Bold",
                    ToolTipText = "Bold",
                    Icon = new FontImageSource { Glyph = "\uE770", FontFamily = "MauiMaterialAssets" }
                },
                new SfToolbarItem
                {
                    Name = "Underline",
                    ToolTipText = "Underline",
                    Icon = new FontImageSource { Glyph = "\uE762", FontFamily = "MauiMaterialAssets" }
                },
                new SfToolbarItem
                {
                    Name = "Italic",
                    ToolTipText = "Italic",
                    Icon = new FontImageSource { Glyph = "\uE771", FontFamily = "MauiMaterialAssets" }
                },
                new SfToolbarItem
                {
                    Name = "AlignLeft",
                    ToolTipText = "Align-Left",
                    Icon = new FontImageSource { Glyph = "\uE751", FontFamily = "MauiMaterialAssets" }
                },
                new SfToolbarItem
                {
                    Name = "AlignRight",
                    ToolTipText = "Align-Right",
                    Icon = new FontImageSource { Glyph = "\uE753", FontFamily = "MauiMaterialAssets" }
                },
                new SfToolbarItem
                {
                    Name = "AlignCenter",
                    ToolTipText = "Align-Center",
                    Icon = new FontImageSource { Glyph = "\uE752", FontFamily = "MauiMaterialAssets" }
                },
                new SfToolbarItem
                {
                    Name = "AlignJustify",
                    ToolTipText = "Align-Justify",
                    Icon = new FontImageSource { Glyph = "\uE74F", FontFamily = "MauiMaterialAssets" }
                }
            };
            toolbar.Items = itemCollection;
            this.Content = toolbar;
        }
    }
}

{% endhighlight %}

{% endtabs %}

### Navigation Buttons

The Toolbar control provides support for navigating buttons to display the overflow items by setting the OverflowMode property to `NavigationButtons`.

{% tabs %}

{% highlight xaml %}

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:local="clr-namespace:ToolbarSample"
             xmlns:syncfusion="clr-namespace:Syncfusion.Maui.Toolbar;assembly=Syncfusion.Maui.Toolbar"
             x:Class="ToolbarSample.MainPage">
    <toolbar:SfToolbar x:Name="Toolbar" HeightRequest="56" WidthRequest="220" OverflowMode="NavigationButtons">
        <toolbar:SfToolbar.Items>
            <toolbar:SfToolbarItem Name="Bold"
                Text="Bold"
                TextPosition="Right"
                ToolTipText="Bold"
                Size="60,40">
            </toolbar:SfToolbarItem>
            <toolbar:SfToolbarItem Name="Underline"
                Text="Underline"
                TextPosition="Right"
                ToolTipText="Underline"
                Size="90,40">
            </toolbar:SfToolbarItem>
            <toolbar:SfToolbarItem Name="Italic"
                Text="Italic"
                TextPosition="Right"
                ToolTipText="Italic"
                Size="60,40">
            </toolbar:SfToolbarItem>
            <toolbar:SfToolbarItem Name="AlignLeft"
                        Text="Align-Left"
                        TextPosition="Right"
                        ToolTipText="Align-Left"
                        Size="100,40">
            </toolbar:SfToolbarItem>
            <toolbar:SfToolbarItem Name="AlignRight"
                        ToolTipText="Align-Right"
                        Text="Align-Right"
                        TextPosition="Right"
                        Size="100,40">
            </toolbar:SfToolbarItem>
            <toolbar:SfToolbarItem Name="AlignCenter"
                        ToolTipText="Align-Center"
                        Text="Align-Center"
                        TextPosition="Right"
                        Size="100,40">
            </toolbar:SfToolbarItem>
            <toolbar:SfToolbarItem Name="AlignJustify"
                        ToolTipText="Align-Justify"
                        Text="Align-Justify"
                        TextPosition="Right"
                        Size="100,40">
            </toolbar:SfToolbarItem>
        </toolbar:SfToolbar.Items>
    </toolbar:SfToolbar>
</ContentPage>

{% endhighlight %}

{% highlight c# %}

using Syncfusion.Maui.Toolbar;

namespace ToolbarSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            SfToolbar toolbar = new SfToolbar();
            toolbar.HeightRequest = 56;
            toolbar.WidthRequest = 220;
            toolbar.OverflowMode = ToolbarItemOverflowMode.NavigationButtons;
            
            ObservableCollection<BaseToolbarItem> itemCollection = new ObservableCollection<BaseToolbarItem>
            {
                new SfToolbarItem
                {
                    Name = "Bold",
                    Text = "Bold",
                    TextPosition = ToolbarItemTextPosition.Right,
                    ToolTipText = "Bold",
                    Size = new Size(60, 40),
                },
                new SfToolbarItem
                {
                    Name = "Underline",
                    Text = "Underline",
                    TextPosition = ToolbarItemTextPosition.Right,
                    ToolTipText = "Underline",
                    Size = new Size(90, 40),
                },
                new SfToolbarItem
                {
                    Name = "Italic",
                    Text = "Italic",
                    TextPosition = ToolbarItemTextPosition.Right,
                    ToolTipText = "Italic",
                    Size = new Size(60, 40),
                },
                new SfToolbarItem
                {
                    Name = "AlignLeft",
                    Text = "Align-Left",
                    TextPosition = ToolbarItemTextPosition.Right,
                    ToolTipText = "Align-Left",
                    Size = new Size(90, 40),
                },
                new SfToolbarItem
                {
                    Name = "AlignRight",
                    Text = "Align-Right",
                    TextPosition = ToolbarItemTextPosition.Right,
                    ToolTipText = "Align-Right",
                    Size = new Size(100, 40),
                },
                new SfToolbarItem
                {
                    Name = "AlignCenter",
                    Text = "Align-Center",
                    TextPosition = ToolbarItemTextPosition.Right,
                    ToolTipText = "Align-Center",
                    Size = new Size(100, 40),
                },
                new SfToolbarItem
                {
                    Name = "AlignJustify",
                    Text = "Align-Justify",
                    TextPosition = ToolbarItemTextPosition.Right,
                    ToolTipText = "Align-Justify",
                    Size = new Size(100, 40),
                }
            };

            toolbar.Items = itemCollection;
            this.Content = toolbar;
        }
    }
}

{% endhighlight %}

{% endtabs %}

## More Item Menu

The Toolbar control displays additional items in a dropdown menu when they extend beyond the view. This can be enabled by setting the `OverflowMode` property to `MoreButton`.

The following code sample demonstrates how to display more items in the overflow menu.

{% tabs %}

{% highlight xaml %}

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:local="clr-namespace:ToolbarSample"
             xmlns:syncfusion="clr-namespace:Syncfusion.Maui.Toolbar;assembly=Syncfusion.Maui.Toolbar"
             x:Class="ToolbarSample.MainPage">
    <toolbar:SfToolbar x:Name="Toolbar" HeightRequest="56" WidthRequest="220" OverflowMode="MoreButton">
        <toolbar:SfToolbar.Items>
            <toolbar:SfToolbarItem Name="Bold"
                Text="Bold"
                TextPosition="Right"
                ToolTipText="Bold"
                Size="60,40">
                <toolbar:SfToolbarItem.Icon>
                    <FontImageSource Glyph="&#xE770;"
                            FontFamily="MauiMaterialAssets" />
                </toolbar:SfToolbarItem.Icon>
            </toolbar:SfToolbarItem>
            <toolbar:SfToolbarItem Name="Underline"
                Text="Underline"
                TextPosition="Right"
                ToolTipText="Underline"
                Size="90,40">
                <toolbar:SfToolbarItem.Icon>
                    <FontImageSource Glyph="&#xE762;"
                            FontFamily="MauiMaterialAssets" />
                </toolbar:SfToolbarItem.Icon>
            </toolbar:SfToolbarItem>
            <toolbar:SfToolbarItem Name="Italic"
                Text="Italic"
                TextPosition="Right"
                ToolTipText="Italic"
                Size="60,40">
                <toolbar:SfToolbarItem.Icon>
                    <FontImageSource Glyph="&#xE771;"
                            FontFamily="MauiMaterialAssets" />
                </toolbar:SfToolbarItem.Icon>
            </toolbar:SfToolbarItem>
            <toolbar:SfToolbarItem Name="AlignLeft"
                        Text="Align-Left"
                        TextPosition="Right"
                        ToolTipText="Align-Left"
                        Size="90,40">
                <toolbar:SfToolbarItem.Icon>
                    <FontImageSource Glyph="&#xE751;"
                            FontFamily="MauiMaterialAssets" />
                </toolbar:SfToolbarItem.Icon>
            </toolbar:SfToolbarItem>
            <toolbar:SfToolbarItem Name="AlignRight"
                        ToolTipText="Align-Right"
                        Text="Align-Right"
                        TextPosition="Right"
                        Size="100,40">
                <toolbar:SfToolbarItem.Icon>
                    <FontImageSource Glyph="&#xE753;"
                FontFamily="MauiMaterialAssets" />
                </toolbar:SfToolbarItem.Icon>
            </toolbar:SfToolbarItem>
            <toolbar:SfToolbarItem Name="AlignCenter"
                        ToolTipText="Align-Center"
                        Text="Align-Center"
                        TextPosition="Right"
                        Size="100,40">
                <toolbar:SfToolbarItem.Icon>
                    <FontImageSource Glyph="&#xE752;"
                FontFamily="MauiMaterialAssets" />
                </toolbar:SfToolbarItem.Icon>
            </toolbar:SfToolbarItem>
            <toolbar:SfToolbarItem Name="AlignJustify"
                        ToolTipText="Align-Justify"
                        Text="Align-Justify"
                        TextPosition="Right"
                        Size="100,40">
                <toolbar:SfToolbarItem.Icon>
                    <FontImageSource Glyph="&#xE74F;"
                FontFamily="MauiMaterialAssets" />
                </toolbar:SfToolbarItem.Icon>
            </toolbar:SfToolbarItem>
        </toolbar:SfToolbar.Items>
    </toolbar:SfToolbar>
</ContentPage>

{% endhighlight %}

{% highlight c# %}

using Syncfusion.Maui.Toolbar;

namespace ToolbarSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            SfToolbar toolbar = new SfToolbar();
            toolbar.HeightRequest = 56;
            toolbar.WidthRequest = 220;
            toolbar.OverflowMode = ToolbarItemOverflowMode.MoreButton;

            ObservableCollection<BaseToolbarItem> itemCollection = new ObservableCollection<BaseToolbarItem>
            {
                new SfToolbarItem
                {
                    Name = "Bold",
                    Text = "Bold",
                    TextPosition = ToolbarItemTextPosition.Right,
                    ToolTipText = "Bold",
                    Size = new Size(60, 40),
                    Icon = new FontImageSource { Glyph = "\uE770", FontFamily = "MauiMaterialAssets" }
                },
                new SfToolbarItem
                {
                    Name = "Underline",
                    Text = "Underline",
                    TextPosition = ToolbarItemTextPosition.Right,
                    ToolTipText = "Underline",
                    Size = new Size(90, 40),
                    Icon = new FontImageSource { Glyph = "\uE762", FontFamily = "MauiMaterialAssets" }
                },
                new SfToolbarItem
                {
                    Name = "Italic",
                    Text = "Italic",
                    TextPosition = ToolbarItemTextPosition.Right,
                    ToolTipText = "Italic",
                    Size = new Size(60, 40),
                    Icon = new FontImageSource { Glyph = "\uE771", FontFamily = "MauiMaterialAssets" }
                },
                new SfToolbarItem
                {
                    Name = "AlignLeft",
                    Text = "Align-Left",
                    TextPosition = ToolbarItemTextPosition.Right,
                    ToolTipText = "Align-Left",
                    Size = new Size(90, 40),
                    Icon = new FontImageSource { Glyph = "\uE751", FontFamily = "MauiMaterialAssets" }
                },
                new SfToolbarItem
                {
                    Name = "AlignRight",
                    Text = "Align-Right",
                    TextPosition = ToolbarItemTextPosition.Right,
                    ToolTipText = "Align-Right",
                    Size = new Size(100, 40),
                    Icon = new FontImageSource { Glyph = "\uE753", FontFamily = "MauiMaterialAssets" }
                },
                new SfToolbarItem
                {
                    Name = "AlignCenter",
                    Text = "Align-Center",
                    TextPosition = ToolbarItemTextPosition.Right,
                    ToolTipText = "Align-Center",
                    Size = new Size(100, 40),
                    Icon = new FontImageSource { Glyph = "\uE752", FontFamily = "MauiMaterialAssets" }
                },
                new SfToolbarItem
                {
                    Name = "AlignJustify",
                    Text = "Align-Justify",
                    TextPosition = ToolbarItemTextPosition.Right,
                    ToolTipText = "Align-Justify",
                    Size = new Size(100, 40),
                    Icon = new FontImageSource { Glyph = "\uE74F", FontFamily = "MauiMaterialAssets" }
                }
            };

            toolbar.Items = itemCollection;
            this.Content = toolbar;
        }
    }
}

{% endhighlight %}

{% endtabs %}

### MoreItemPosition

The Toolbar control provides support for customizing the position of the More button using the `MoreItemsRelativePosition` property. The default value of this property is `Auto`. You can change the position of the More button by setting the `MoreItemsRelativePosition` property to `Left`, `Right`, `Top`, or `Bottom`.

{% tabs %}

{% highlight xaml %}

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:local="clr-namespace:ToolbarSample"
             xmlns:syncfusion="clr-namespace:Syncfusion.Maui.Toolbar;assembly=Syncfusion.Maui.Toolbar"
             x:Class="ToolbarSample.MainPage">
    <toolbar:SfToolbar x:Name="Toolbar" HeightRequest="56" WidthRequest="220" OverflowMode="MoreButton" MoreItemsRelativePosition="Right">
        <toolbar:SfToolbar.Items>
            <toolbar:SfToolbarItem Name="Bold"
                Text="Bold"
                TextPosition="Right"
                ToolTipText="Bold"
                Size="60,40">
                <toolbar:SfToolbarItem.Icon>
                    <FontImageSource Glyph="&#xE770;"
                            FontFamily="MauiMaterialAssets" />
                </toolbar:SfToolbarItem.Icon>
            </toolbar:SfToolbarItem>
            <toolbar:SfToolbarItem Name="Underline"
                Text="Underline"
                TextPosition="Right"
                ToolTipText="Underline"
                Size="90,40">
                <toolbar:SfToolbarItem.Icon>
                    <FontImageSource Glyph="&#xE762;"
                            FontFamily="MauiMaterialAssets" />
                </toolbar:SfToolbarItem.Icon>
            </toolbar:SfToolbarItem>
            <toolbar:SfToolbarItem Name="Italic"
                Text="Italic"
                TextPosition="Right"
                ToolTipText="Italic"
                Size="60,40">
                <toolbar:SfToolbarItem.Icon>
                    <FontImageSource Glyph="&#xE771;"
                            FontFamily="MauiMaterialAssets" />
                </toolbar:SfToolbarItem.Icon>
            </toolbar:SfToolbarItem>
            <toolbar:SfToolbarItem Name="AlignLeft"
                        Text="Align-Left"
                        TextPosition="Right"
                        ToolTipText="Align-Left"
                        Size="90,40">
                <toolbar:SfToolbarItem.Icon>
                    <FontImageSource Glyph="&#xE751;"
                            FontFamily="MauiMaterialAssets" />
                </toolbar:SfToolbarItem.Icon>
            </toolbar:SfToolbarItem>
            <toolbar:SfToolbarItem Name="AlignRight"
                        ToolTipText="Align-Right"
                        Text="Align-Right"
                        TextPosition="Right"
                        Size="100,40">
                <toolbar:SfToolbarItem.Icon>
                    <FontImageSource Glyph="&#xE753;"
                FontFamily="MauiMaterialAssets" />
                </toolbar:SfToolbarItem.Icon>
            </toolbar:SfToolbarItem>
            <toolbar:SfToolbarItem Name="AlignCenter"
                        ToolTipText="Align-Center"
                        Text="Align-Center"
                        TextPosition="Right"
                        Size="100,40">
                <toolbar:SfToolbarItem.Icon>
                    <FontImageSource Glyph="&#xE752;"
                FontFamily="MauiMaterialAssets" />
                </toolbar:SfToolbarItem.Icon>
            </toolbar:SfToolbarItem>
            <toolbar:SfToolbarItem Name="AlignJustify"
                        ToolTipText="Align-Justify"
                        Text="Align-Justify"
                        TextPosition="Right"
                        Size="100,40">
                <toolbar:SfToolbarItem.Icon>
                    <FontImageSource Glyph="&#xE74F;"
                FontFamily="MauiMaterialAssets" />
                </toolbar:SfToolbarItem.Icon>
            </toolbar:SfToolbarItem>
        </toolbar:SfToolbar.Items>
    </toolbar:SfToolbar>
</ContentPage>

{% endhighlight %}

{% highlight c# %}

using Syncfusion.Maui.Toolbar;

namespace ToolbarSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            SfToolbar toolbar = new SfToolbar();
            toolbar.HeightRequest = 56;
            toolbar.WidthRequest = 220;
            toolbar.OverflowMode = ToolbarItemOverflowMode.MoreButton;
            toolbar.MoreItemsRelativePosition = ToolbarRelativePosition.Right;

            ObservableCollection<BaseToolbarItem> itemCollection = new ObservableCollection<BaseToolbarItem>
            {
                new SfToolbarItem
                {
                    Name = "Bold",
                    Text = "Bold",
                    TextPosition = ToolbarItemTextPosition.Right,
                    ToolTipText = "Bold",
                    Size = new Size(60, 40),
                    Icon = new FontImageSource { Glyph = "\uE770", FontFamily = "MauiMaterialAssets" }
                },
                new SfToolbarItem
                {
                    Name = "Underline",
                    Text = "Underline",
                    TextPosition = ToolbarItemTextPosition.Right,
                    ToolTipText = "Underline",
                    Size = new Size(90, 40),
                    Icon = new FontImageSource { Glyph = "\uE762", FontFamily = "MauiMaterialAssets" }
                },
                new SfToolbarItem
                {
                    Name = "Italic",
                    Text = "Italic",
                    TextPosition = ToolbarItemTextPosition.Right,
                    ToolTipText = "Italic",
                    Size = new Size(60, 40),
                    Icon = new FontImageSource { Glyph = "\uE771", FontFamily = "MauiMaterialAssets" }
                },
                new SfToolbarItem
                {
                    Name = "AlignLeft",
                    Text = "Align-Left",
                    TextPosition = ToolbarItemTextPosition.Right,
                    ToolTipText = "Align-Left",
                    Size = new Size(90, 40),
                    Icon = new FontImageSource { Glyph = "\uE751", FontFamily = "MauiMaterialAssets" }
                },
                new SfToolbarItem
                {
                    Name = "AlignRight",
                    Text = "Align-Right",
                    TextPosition = ToolbarItemTextPosition.Right,
                    ToolTipText = "Align-Right",
                    Size = new Size(100, 40),
                    Icon = new FontImageSource { Glyph = "\uE753", FontFamily = "MauiMaterialAssets" }
                },
                new SfToolbarItem
                {
                    Name = "AlignCenter",
                    Text = "Align-Center",
                    TextPosition = ToolbarItemTextPosition.Right,
                    ToolTipText = "Align-Center",
                    Size = new Size(100, 40),
                    Icon = new FontImageSource { Glyph = "\uE752", FontFamily = "MauiMaterialAssets" }
                },
                new SfToolbarItem
                {
                    Name = "AlignJustify",
                    Text = "Align-Justify",
                    TextPosition = ToolbarItemTextPosition.Right,
                    ToolTipText = "Align-Justify",
                    Size = new Size(100, 40),
                    Icon = new FontImageSource { Glyph = "\uE74F", FontFamily = "MauiMaterialAssets" }
                }
            };

            toolbar.Items = itemCollection;
            this.Content = toolbar;
        }
    }
}

{% endhighlight %}

{% endtabs %}
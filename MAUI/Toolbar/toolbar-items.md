---
layout: post
title: Toolbar Items in MAUI Toolbar Control | Syncfusion®
description: Learn here all about Toolbar Items support in Syncfusion® MAUI Toolbar (SfToolbar) control and more.
platform: MAUI
control: Toolbar (SfToolbar)
documentation: ug
---

# Toolbar Items in MAUI Toolbar (SfToolbar)

This section explains the ways about populating items through BaseToolbarItem and item source.

## Default View

By passing a collection of `SfToolbarItem`, you can get the view of `SfToolbar` control. The SfToolbarItem class provides various options to customize the items by giving custom views, font icons, and images.

### Icons

The control provides support to add icons to the toolbar items. You can add icons to the toolbar items by using the `Icon` property of `SfToolbarItem`.

The following code sample demonstrates how to Create a Toolbar control with Items having the icons.

{% tabs %}

{% highlight xaml %}

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:local="clr-namespace:ToolbarSample"
             xmlns:toolbar="clr-namespace:Syncfusion.Maui.Toolbar;assembly=Syncfusion.Maui.Toolbar"
             x:Class="ToolbarSample.MainPage">
    <toolbar:SfToolbar x:Name="Toolbar" HeightRequest="56">
        <toolbar:SfToolbar.Items>
            <toolbar:SfToolbarItem Name="Bold">
                <toolbar:SfToolbarItem.Icon>
                    <FontImageSource Glyph="&#xE770;"
                                FontFamily="MauiMaterialAssets" />
                </toolbar:SfToolbarItem.Icon>
            </toolbar:SfToolbarItem>
            <toolbar:SfToolbarItem Name="Underline">
                <toolbar:SfToolbarItem.Icon>
                    <FontImageSource Glyph="&#xE762;"
                                FontFamily="MauiMaterialAssets" />
                </toolbar:SfToolbarItem.Icon>
            </toolbar:SfToolbarItem>
            <toolbar:SfToolbarItem Name="Italic">
                <toolbar:SfToolbarItem.Icon>
                    <FontImageSource Glyph="&#xE771;"
                                FontFamily="MauiMaterialAssets" />
                </toolbar:SfToolbarItem.Icon>
            </toolbar:SfToolbarItem>
            <toolbar:SfToolbarItem Name="AlignLeft">
                <toolbar:SfToolbarItem.Icon>
                    <FontImageSource Glyph="&#xE751;"
                                FontFamily="MauiMaterialAssets" />
                </toolbar:SfToolbarItem.Icon>
            </toolbar:SfToolbarItem>
            <toolbar:SfToolbarItem Name="AlignRight">
                <toolbar:SfToolbarItem.Icon>
                    <FontImageSource Glyph="&#xE753;"
                    FontFamily="MauiMaterialAssets" />
                </toolbar:SfToolbarItem.Icon>
            </toolbar:SfToolbarItem>
            <toolbar:SfToolbarItem Name="AlignCenter">
                <toolbar:SfToolbarItem.Icon>
                    <FontImageSource Glyph="&#xE752;"
                    FontFamily="MauiMaterialAssets" />
                </toolbar:SfToolbarItem.Icon>
            </toolbar:SfToolbarItem>
            <toolbar:SfToolbarItem Name="AlignJustify">
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
            ObservableCollection<BaseToolbarItem> itemCollection = new ObservableCollection<BaseToolbarItem>
            {
                new SfToolbarItem
                {
                    Name = "Bold",
                    Icon = new FontImageSource { Glyph = "\uE770", FontFamily = "MauiMaterialAssets" }
                },
                new SfToolbarItem
                {
                    Name = "Underline",
                    Icon = new FontImageSource { Glyph = "\uE762", FontFamily = "MauiMaterialAssets" }
                },
                new SfToolbarItem
                {
                    Name = "Italic",
                    Icon = new FontImageSource { Glyph = "\uE771", FontFamily = "MauiMaterialAssets" }
                },
                new SfToolbarItem
                {
                    Name = "AlignLeft",
                    Icon = new FontImageSource { Glyph = "\uE751", FontFamily = "MauiMaterialAssets" }
                },
                new SfToolbarItem
                {
                    Name = "AlignRight",
                    Icon = new FontImageSource { Glyph = "\uE753", FontFamily = "MauiMaterialAssets" }
                },
                new SfToolbarItem
                {
                    Name = "AlignCenter",
                    Icon = new FontImageSource { Glyph = "\uE752", FontFamily = "MauiMaterialAssets" }
                },
                new SfToolbarItem
                {
                    Name = "AlignJustify",
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

#### Icon Size

The control provides an option to set the icon size for the toolbar items. You can set the icon size for the toolbar items using the `IconSize` property.

{% tabs %}

{% highlight xaml %}

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:local="clr-namespace:ToolbarSample"
             xmlns:toolbar="clr-namespace:Syncfusion.Maui.Toolbar;assembly=Syncfusion.Maui.Toolbar"
             x:Class="ToolbarSample.MainPage">
    <toolbar:SfToolbar x:Name="Toolbar" HeightRequest="56">
        <toolbar:SfToolbar.Items>
            <toolbar:SfToolbarItem Name="Bold" IconSize="20">
                <toolbar:SfToolbarItem.Icon>
                    <FontImageSource Glyph="&#xE770;"
                                FontFamily="MauiMaterialAssets" />
                </toolbar:SfToolbarItem.Icon>
            </toolbar:SfToolbarItem>
            <toolbar:SfToolbarItem Name="Underline" IconSize="20">
                <toolbar:SfToolbarItem.Icon>
                    <FontImageSource Glyph="&#xE762;"
                                FontFamily="MauiMaterialAssets" />
                </toolbar:SfToolbarItem.Icon>
            </toolbar:SfToolbarItem>
            <toolbar:SfToolbarItem Name="Italic" IconSize="20">
                <toolbar:SfToolbarItem.Icon>
                    <FontImageSource Glyph="&#xE771;"
                                FontFamily="MauiMaterialAssets" />
                </toolbar:SfToolbarItem.Icon>
            </toolbar:SfToolbarItem>
            <toolbar:SfToolbarItem Name="AlignLeft" IconSize="20">
                <toolbar:SfToolbarItem.Icon>
                    <FontImageSource Glyph="&#xE751;"
                                FontFamily="MauiMaterialAssets" />
                </toolbar:SfToolbarItem.Icon>
            </toolbar:SfToolbarItem>
            <toolbar:SfToolbarItem Name="AlignRight" IconSize="20">
                <toolbar:SfToolbarItem.Icon>
                    <FontImageSource Glyph="&#xE753;"
                    FontFamily="MauiMaterialAssets" />
                </toolbar:SfToolbarItem.Icon>
            </toolbar:SfToolbarItem>
            <toolbar:SfToolbarItem Name="AlignCenter" IconSize="20">
                <toolbar:SfToolbarItem.Icon>
                    <FontImageSource Glyph="&#xE752;"
                    FontFamily="MauiMaterialAssets" />
                </toolbar:SfToolbarItem.Icon>
            </toolbar:SfToolbarItem>
            <toolbar:SfToolbarItem Name="AlignJustify" IconSize="20">
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
            ObservableCollection<BaseToolbarItem> itemCollection = new ObservableCollection<BaseToolbarItem>
            {
                new SfToolbarItem
                {
                    Name = "Bold",
                    IconSize="20",
                    Icon = new FontImageSource { Glyph = "\uE770", FontFamily = "MauiMaterialAssets" }
                },
                new SfToolbarItem
                {
                    Name = "Underline",
                    IconSize="20",
                    Icon = new FontImageSource { Glyph = "\uE762", FontFamily = "MauiMaterialAssets" }
                },
                new SfToolbarItem
                {
                    Name = "Italic",
                    IconSize="20",
                    Icon = new FontImageSource { Glyph = "\uE771", FontFamily = "MauiMaterialAssets" }
                },
                new SfToolbarItem
                {
                    Name = "AlignLeft",
                    IconSize="20",
                    Icon = new FontImageSource { Glyph = "\uE751", FontFamily = "MauiMaterialAssets" }
                },
                new SfToolbarItem
                {
                    Name = "AlignRight",
                    IconSize="20",
                    Icon = new FontImageSource { Glyph = "\uE753", FontFamily = "MauiMaterialAssets" }
                },
                new SfToolbarItem
                {
                    Name = "AlignCenter",
                    IconSize="20",
                    Icon = new FontImageSource { Glyph = "\uE752", FontFamily = "MauiMaterialAssets" }
                },
                new SfToolbarItem
                {
                    Name = "AlignJustify",
                    IconSize="20",
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

### Text

The control allows you to display text in the toolbar items. You can set the text for the toolbar items using the `Text` property.

The following code sample demonstrates how to Display Text in the Toolbar items of the control.

{% tabs %}

{% highlight xaml %}

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:local="clr-namespace:ToolbarSample"
             xmlns:syncfusion="clr-namespace:Syncfusion.Maui.Toolbar;assembly=Syncfusion.Maui.Toolbar"
             x:Class="ToolbarSample.MainPage">
    <toolbar:SfToolbar x:Name="Toolbar" HeightRequest="56">
        <toolbar:SfToolbar.Items>
            <toolbar:SfToolbarItem Name="Bold"
                Text="Bold"
                Size="60,40">
            </toolbar:SfToolbarItem>
            <toolbar:SfToolbarItem Name="Underline"
                Text="Underline"
                Size="90,40">
            </toolbar:SfToolbarItem>
            <toolbar:SfToolbarItem Name="Italic"
                Text="Italic"
                Size="60,40">
            </toolbar:SfToolbarItem>
            <toolbar:SfToolbarItem Name="AlignLeft"
                        TextPosition="Right"
                        Size="100,40">
            </toolbar:SfToolbarItem>
            <toolbar:SfToolbarItem Name="AlignRight"
                        Text="Align-Right"
                        Size="100,40">
            </toolbar:SfToolbarItem>
            <toolbar:SfToolbarItem Name="AlignCenter"
                        Text="Align-Center"
                        Size="100,40">
            </toolbar:SfToolbarItem>
            <toolbar:SfToolbarItem Name="AlignJustify"
                        Text="Align-Justify"
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

            ObservableCollection<BaseToolbarItem> itemCollection = new ObservableCollection<BaseToolbarItem>
            {
                new SfToolbarItem
                {
                    Name = "Bold",
                    Text = "Bold",
                    Size = new Size(60, 40),
                },
                new SfToolbarItem
                {
                    Name = "Underline",
                    Text = "Underline",
                    Size = new Size(90, 40),
                },
                new SfToolbarItem
                {
                    Name = "Italic",
                    Text = "Italic",
                    Size = new Size(60, 40),
                },
                new SfToolbarItem
                {
                    Name = "AlignLeft",
                    Text = "Align-Left",
                    Size = new Size(90, 40),
                },
                new SfToolbarItem
                {
                    Name = "AlignRight",
                    Text = "Align-Right",
                    Size = new Size(100, 40),
                },
                new SfToolbarItem
                {
                    Name = "AlignCenter",
                    Text = "Align-Center",
                    Size = new Size(100, 40),
                },
                new SfToolbarItem
                {
                    Name = "AlignJustify",
                    Text = "Align-Justify",
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

### Icons With Text

The control provides support to add icons and text to the toolbar items.

The following code sample demonstrates how to Display Icons and text in the Toolbar items of the control.

{% tabs %}

{% highlight xaml %}

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:local="clr-namespace:ToolbarSample"
             xmlns:syncfusion="clr-namespace:Syncfusion.Maui.Toolbar;assembly=Syncfusion.Maui.Toolbar"
             x:Class="ToolbarSample.MainPage">
    <toolbar:SfToolbar x:Name="Toolbar" HeightRequest="56">
        <toolbar:SfToolbar.Items>
            <toolbar:SfToolbarItem Name="Bold"
                Text="Bold"
                TextPosition="Right"
                Size="60,40">
                <toolbar:SfToolbarItem.Icon>
                    <FontImageSource Glyph="&#xE770;"
                            FontFamily="MauiMaterialAssets" />
                </toolbar:SfToolbarItem.Icon>
            </toolbar:SfToolbarItem>
            <toolbar:SfToolbarItem Name="Underline"
                Text="Underline"
                TextPosition="Right"
                Size="90,40">
                <toolbar:SfToolbarItem.Icon>
                    <FontImageSource Glyph="&#xE762;"
                            FontFamily="MauiMaterialAssets" />
                </toolbar:SfToolbarItem.Icon>
            </toolbar:SfToolbarItem>
            <toolbar:SfToolbarItem Name="Italic"
                Text="Italic"
                TextPosition="Right"
                Size="60,40">
                <toolbar:SfToolbarItem.Icon>
                    <FontImageSource Glyph="&#xE771;"
                            FontFamily="MauiMaterialAssets" />
                </toolbar:SfToolbarItem.Icon>
            </toolbar:SfToolbarItem>
            <toolbar:SfToolbarItem Name="AlignLeft"
                        Text="Align-Left"
                        TextPosition="Right"
                        Size="90,40">
                <toolbar:SfToolbarItem.Icon>
                    <FontImageSource Glyph="&#xE751;"
                            FontFamily="MauiMaterialAssets" />
                </toolbar:SfToolbarItem.Icon>
            </toolbar:SfToolbarItem>
            <toolbar:SfToolbarItem Name="AlignRight"
                        Text="Align-Right"
                        TextPosition="Right"
                        Size="100,40">
                <toolbar:SfToolbarItem.Icon>
                    <FontImageSource Glyph="&#xE753;"
                FontFamily="MauiMaterialAssets" />
                </toolbar:SfToolbarItem.Icon>
            </toolbar:SfToolbarItem>
            <toolbar:SfToolbarItem Name="AlignCenter"
                        Text="Align-Center"
                        TextPosition="Right"
                        Size="100,40">
                <toolbar:SfToolbarItem.Icon>
                    <FontImageSource Glyph="&#xE752;"
                FontFamily="MauiMaterialAssets" />
                </toolbar:SfToolbarItem.Icon>
            </toolbar:SfToolbarItem>
            <toolbar:SfToolbarItem Name="AlignJustify"
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

            ObservableCollection<BaseToolbarItem> itemCollection = new ObservableCollection<BaseToolbarItem>
            {
                new SfToolbarItem
                {
                    Name = "Bold",
                    Text = "Bold",
                    TextPosition = ToolbarItemTextPosition.Right,
                    Size = new Size(60, 40),
                    Icon = new FontImageSource { Glyph = "\uE770", FontFamily = "MauiMaterialAssets" }
                },
                new SfToolbarItem
                {
                    Name = "Underline",
                    Text = "Underline",
                    TextPosition = ToolbarItemTextPosition.Right,
                    Size = new Size(90, 40),
                    Icon = new FontImageSource { Glyph = "\uE762", FontFamily = "MauiMaterialAssets" }
                },
                new SfToolbarItem
                {
                    Name = "Italic",
                    Text = "Italic",
                    TextPosition = ToolbarItemTextPosition.Right,
                    Size = new Size(60, 40),
                    Icon = new FontImageSource { Glyph = "\uE771", FontFamily = "MauiMaterialAssets" }
                },
                new SfToolbarItem
                {
                    Name = "AlignLeft",
                    Text = "Align-Left",
                    TextPosition = ToolbarItemTextPosition.Right,
                    Size = new Size(90, 40),
                    Icon = new FontImageSource { Glyph = "\uE751", FontFamily = "MauiMaterialAssets" }
                },
                new SfToolbarItem
                {
                    Name = "AlignRight",
                    Text = "Align-Right",
                    TextPosition = ToolbarItemTextPosition.Right,
                    Size = new Size(100, 40),
                    Icon = new FontImageSource { Glyph = "\uE753", FontFamily = "MauiMaterialAssets" }
                },
                new SfToolbarItem
                {
                    Name = "AlignCenter",
                    Text = "Align-Center",
                    TextPosition = ToolbarItemTextPosition.Right,
                    Size = new Size(100, 40),
                    Icon = new FontImageSource { Glyph = "\uE752", FontFamily = "MauiMaterialAssets" }
                },
                new SfToolbarItem
                {
                    Name = "AlignJustify",
                    Text = "Align-Justify",
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

#### Text Placement

The control provides an option to place the text in the toolbar items using the `TextPosition` property. The text can be placed on the left, right, top, and bottom of the toolbar items.

The following code sample demonstrates how to Display Toolbar items with seperator item of the control.

{% tabs %}

{% highlight xaml %}

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:local="clr-namespace:ToolbarSample"
             xmlns:syncfusion="clr-namespace:Syncfusion.Maui.RadialMenu;assembly=Syncfusion.Maui.RadialMenu"
             x:Class="ToolbarSample.MainPage">
        <toolbar:SfToolbar x:Name="Toolbar" HeightRequest="56">
            <toolbar:SfToolbar.Items>
                <toolbar:SfToolbarItem Name="AlignLeft"
                            Text="Align-Left"
                            TextPosition="Right"
                            Size="90,40">
                    <toolbar:SfToolbarItem.Icon>
                        <FontImageSource Glyph="&#xE751;"
                                FontFamily="MauiMaterialAssets" />
                    </toolbar:SfToolbarItem.Icon>
                </toolbar:SfToolbarItem>
                <toolbar:SfToolbarItem Name="AlignRight"
                            Text="Align-Right"
                            TextPosition="Right"
                            Size="100,40">
                    <toolbar:SfToolbarItem.Icon>
                        <FontImageSource Glyph="&#xE753;"
                    FontFamily="MauiMaterialAssets" />
                    </toolbar:SfToolbarItem.Icon>
                </toolbar:SfToolbarItem>
                <toolbar:SfToolbarItem Name="AlignCenter"
                            Text="Align-Center"
                            TextPosition="Right"
                            Size="100,40">
                    <toolbar:SfToolbarItem.Icon>
                        <FontImageSource Glyph="&#xE752;"
                    FontFamily="MauiMaterialAssets" />
                    </toolbar:SfToolbarItem.Icon>
                </toolbar:SfToolbarItem>
                <toolbar:SfToolbarItem Name="AlignJustify"
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

            ObservableCollection<BaseToolbarItem> toolbarItems = new ObservableCollection<BaseToolbarItem>
            {
                new SfToolbarItem
                {
                    Name = "AlignLeft",
                    Text = "Align-Left",
                    TextPosition = ToolbarItemTextPosition.Right,
                    Size = new Size(90, 40),
                    Icon = new FontImageSource { Glyph = "\uE751", FontFamily = "MauiMaterialAssets" }
                },
                new SfToolbarItem
                {
                    Name = "AlignRight",
                    Text = "Align-Right",
                    TextPosition = ToolbarItemTextPosition.Right,
                    Size = new Size(100, 40),
                    Icon = new FontImageSource { Glyph = "\uE753", FontFamily = "MauiMaterialAssets" }
                },
                new SfToolbarItem
                {
                    Name = "AlignCenter",
                    Text = "Align-Center",
                    TextPosition = ToolbarItemTextPosition.Right,
                    Size = new Size(100, 40),
                    Icon = new FontImageSource { Glyph = "\uE752", FontFamily = "MauiMaterialAssets" }
                },
                new SfToolbarItem
                {
                    Name = "AlignJustify",
                    Text = "Align-Justify",
                    TextPosition = ToolbarItemTextPosition.Right,
                    Size = new Size(100, 40),
                    Icon = new FontImageSource { Glyph = "\uE74F", FontFamily = "MauiMaterialAssets" }
                }
            };

            toolbar.Items = toolbarItems;
            this.Content = toolbar;
        }
    }
}

{% endhighlight %}

{% endtabs %}

## Seperator View

The control provides an option to add a separator view between the toolbar items using the `SeparatorView` property.

The following code sample demonstrates how to Display Toolbar items with seperator item of the control.

{% tabs %}

{% highlight xaml %}

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:local="clr-namespace:ToolbarSample"
             xmlns:syncfusion="clr-namespace:Syncfusion.Maui.RadialMenu;assembly=Syncfusion.Maui.RadialMenu"
             x:Class="ToolbarSample.MainPage">
        <toolbar:SfToolbar x:Name="Toolbar" HeightRequest="56">
            <toolbar:SfToolbar.Items>
                <toolbar:SfToolbarItem Name="Bold"
                    Size="60,40">
                    <toolbar:SfToolbarItem.Icon>
                        <FontImageSource Glyph="&#xE770;"
                                FontFamily="MauiMaterialAssets" />
                    </toolbar:SfToolbarItem.Icon>
                </toolbar:SfToolbarItem>
                <toolbar:SfToolbarItem Name="Underline"
                    Size="90,40">
                    <toolbar:SfToolbarItem.Icon>
                        <FontImageSource Glyph="&#xE762;"
                                FontFamily="MauiMaterialAssets" />
                    </toolbar:SfToolbarItem.Icon>
                </toolbar:SfToolbarItem>
                <toolbar:SfToolbarItem Name="Italic"
                    Size="60,40">
                    <toolbar:SfToolbarItem.Icon>
                        <FontImageSource Glyph="&#xE771;"
                                FontFamily="MauiMaterialAssets" />
                    </toolbar:SfToolbarItem.Icon>
                </toolbar:SfToolbarItem>
                <toolbar:SeparatorToolbarItem Stroke="Black" StrokeThickness="5"/>
                <toolbar:SfToolbarItem Name="AlignLeft"
                            Size="90,40">
                    <toolbar:SfToolbarItem.Icon>
                        <FontImageSource Glyph="&#xE751;"
                                FontFamily="MauiMaterialAssets" />
                    </toolbar:SfToolbarItem.Icon>
                </toolbar:SfToolbarItem>
                <toolbar:SfToolbarItem Name="AlignRight"
                            Size="100,40">
                    <toolbar:SfToolbarItem.Icon>
                        <FontImageSource Glyph="&#xE753;"
                    FontFamily="MauiMaterialAssets" />
                    </toolbar:SfToolbarItem.Icon>
                </toolbar:SfToolbarItem>
                <toolbar:SfToolbarItem Name="AlignCenter"
                            Size="100,40">
                    <toolbar:SfToolbarItem.Icon>
                        <FontImageSource Glyph="&#xE752;"
                    FontFamily="MauiMaterialAssets" />
                    </toolbar:SfToolbarItem.Icon>
                </toolbar:SfToolbarItem>
                <toolbar:SfToolbarItem Name="AlignJustify"
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

            ObservableCollection<BaseToolbarItem> toolbarItems = new ObservableCollection<BaseToolbarItem>
            {
                new SfToolbarItem
                {
                    Name = "Bold",
                    Size = new Size(60, 40),
                    Icon = new FontImageSource { Glyph = "\uE770", FontFamily = "MauiMaterialAssets" }
                },
                new SfToolbarItem
                {
                    Name = "Underline",
                    Size = new Size(90, 40),
                    Icon = new FontImageSource { Glyph = "\uE762", FontFamily = "MauiMaterialAssets" }
                },
                new SfToolbarItem
                {
                    Name = "Italic",
                    Size = new Size(60, 40),
                    Icon = new FontImageSource { Glyph = "\uE771", FontFamily = "MauiMaterialAssets" }
                },
                new SeparatorToolbarItem
                {
                    Stroke = Colors.Black,
                    StrokeThickness = 5
                },
                new SfToolbarItem
                {
                    Name = "AlignLeft",
                    Size = new Size(90, 40),
                    Icon = new FontImageSource { Glyph = "\uE751", FontFamily = "MauiMaterialAssets" }
                },
                new SfToolbarItem
                {
                    Name = "AlignRight",
                    Size = new Size(100, 40),
                    Icon = new FontImageSource { Glyph = "\uE753", FontFamily = "MauiMaterialAssets" }
                },
                new SfToolbarItem
                {
                    Name = "AlignCenter",
                    Size = new Size(100, 40),
                    Icon = new FontImageSource { Glyph = "\uE752", FontFamily = "MauiMaterialAssets" }
                },
                new SfToolbarItem
                {
                    Name = "AlignJustify",
                    Size = new Size(100, 40),
                    Icon = new FontImageSource { Glyph = "\uE74F", FontFamily = "MauiMaterialAssets" }
                }
            };

            toolbar.Items = toolbarItems;
            this.Content = toolbar;
        }
    }
}

{% endhighlight %}

{% endtabs %}

## Custom View

The Toolbar control provides support to customize the items of the toolbar with any type of views. You can add the views to the toolbar using the `View` property.

The following code sample demonstrates how to Create a Toolbar control with Custom view.

{% tabs %}

{% highlight xaml %}

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:local="clr-namespace:ToolbarSample"
             xmlns:toolbar="clr-namespace:Syncfusion.Maui.Toolbar;assembly=Syncfusion.Maui.Toolbar"
             x:Class="ToolbarSample.MainPage">
    <toolbar:SfToolbar x:Name="Toolbar" HeightRequest="56">
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
            <toolbar:SfToolbarItem Name="AlignJustify"
                                ToolTipText="Align-Justify">
            <toolbar:SfToolbarItem.Icon>
            <FontImageSource Glyph="&#xE74F;"
                        FontFamily="MauiMaterialAssets" />
            </toolbar:SfToolbarItem.Icon>
            </toolbar:SfToolbarItem>
            <toolbar:SfToolbarItem Name="Search">
                <toolbar:SfToolbarItem.View>
                    <Entry Text="Search Text"
                                        BackgroundColor="White"
                                        InputTransparent="False">
                    </Entry>
                </toolbar:SfToolbarItem.View>
            </toolbar:SfToolbarItem>
            <toolbar:SfToolbarItem Name="Disable Button">
                <toolbar:SfToolbarItem.View>
                    <Button Text="Disable Items"
                                            Clicked="OnButtonClicked"
                                            BackgroundColor="Red"
                                            TextColor="White"/>
                </toolbar:SfToolbarItem.View>
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
        }
    }

    private void OnButtonClicked(object sender, EventArgs e)
    {
        foreach (var item in this.Toolbar.Items)
        {
            if (item is SfToolbarItem toolbarItem)
            {
                if (toolbarItem.Name == "Bold" || toolbarItem.Name == "Underline" || toolbarItem.Name == "Italic" || toolbarItem.Name == "AlignJustify")
                {
                    if (toolbarItem.IsEnabled)
                    {
                        toolbarItem.IsEnabled = false;
                    }
                    else
                    {
                        toolbarItem.IsEnabled = true;
                    }
                }
            }
        }
    }
}

{% endhighlight %}

{% endtabs %}

## Overlay Toolbar

The Toolbar control provides support for nested tool bars. You can add the toolbar as a child of another toolbar using the `OverlayToolbar` property. When overlay toolbar is set, the back button will be displayed in the overlay toolbar.


The following code sample demonstrates how to Create a Toolbar control with Overlay Toolbar.

{% tabs %}

{% highlight xaml %}

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:local="clr-namespace:ToolbarSample"
             xmlns:toolbar="clr-namespace:Syncfusion.Maui.Toolbar;assembly=Syncfusion.Maui.Toolbar"
             x:Class="ToolbarSample.MainPage">
    <Grid x:Name="layout">
        <toolbar:SfToolbar x:Name="Toolbar" 
                                HeightRequest="56" 
                                WidthRequest="300"
                                Tapped="Toolbar_Tapped">
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
                <toolbar:SfToolbarItem Name="Alignment"
                                    Text="Alignment"
                                    ToolTipText="Tap to view the overlay toolbar"
                                    Size="70,40">
                <toolbar:SfToolbarItem.OverlayToolbar>
                    <toolbar:SfOverlayToolbar x:Name="overlaytoolbar"
                                                    Orientation="Horizontal"
                                                    HeightRequest="56"
                                                    WidthRequest="300"
                                                    OverflowMode="Scroll">
                        <toolbar:SfOverlayToolbar.Items>
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
                        </toolbar:SfOverlayToolbar.Items>
                    </toolbar:SfOverlayToolbar>
                </toolbar:SfToolbarItem.OverlayToolbar>
                </toolbar:SfToolbarItem>
            </toolbar:SfToolbar.Items>
        </toolbar:SfToolbar>
    </Grid>
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
        }
    }

    private async void Toolbar_Tapped(object sender, Syncfusion.Maui.Toolbar.ToolbarTappedEventArgs e)
    {
        if (e.NewToolbarItem != null)
        {
            if (e.NewToolbarItem.Name == "Alignment")
            {
                var item = e.NewToolbarItem?.OverlayToolbar;
    
                if (!this.layout.Children.Contains(item))
                {
                    this.layout.Children.Add(item);
                }
    
                await Task.Delay(1000);
                (sender as SfToolbar)?.ClearSelection();
            }
        }
    }
}

{% endhighlight %}

{% endtabs %}

## Item Spacing

The Toolbar control provides support for customizing the space between the toolbar items using the `ItemSpacing` property. 

The following code sample demonstrates how to Create a Toolbar control with Item Spacing.

{% tabs %}
{% highlight XAML hl_lines="7 8 9" %}

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:local="clr-namespace:ToolbarSample"
             xmlns:toolbar="clr-namespace:Syncfusion.Maui.Toolbar;assembly=Syncfusion.Maui.Toolbar"
             x:Class="ToolbarSample.MainPage">
    <ContentPage.BindingContext>
        <local:ToolbarViewModel/>
    </ContentPage.BindingContext>

<toolbar:SfToolbar x:Name="Toolbar"
                   Items="{Binding ToolbarItems}"
                   ItemSpacing="10"
                   HeightRequest="56"/>
</ContentPage>

{% endhighlight %}
{% highlight C# hl_lines="5"  %}

using Syncfusion.Maui.Toolbar;

namespace ToolbarSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            SfToolbar toolbar = new SfToolbar();
            ToolbarViewModel viewModel = new ToolbarViewModel();
            toolbar.HeightRequest = 56;
            toolbar.Items = viewModel.ToolbarItems;
            toolbar.Orientation = ToolbarOrientation.Horizontal;
            toolbar.ItemSpacing = 10;
            this.Content = toolbar;
        }
    }
}

{% endhighlight %}

{% highlight C# tabtitle="ToolbarViewModel.cs" %}

public class ToolbarViewModel
{
    private ObservableCollection<BaseToolbarItem> toolbarItems = new ObservableCollection<BaseToolbarItem>();

    public ObservableCollection<BaseToolbarItem> ToolbarItems
    {
        get { return toolbarItems; }
        set { toolbarItems = value; }
    }

    public ToolbarViewModel()
    {
        ToolbarItems.Add(new SfToolbarItem
        {
            Name = "Bold",
            Text = "Bold",
            TextPosition = ToolbarItemTextPosition.Right,
            ToolTipText = "Bold",
            Size = new Size(60, 40),
            Icon = new FontImageSource { Glyph = "\uE770", FontFamily = "MauiMaterialAssets" }
        });

        ToolbarItems.Add(new SfToolbarItem
        {
            Name = "Underline",
            Text = "Underline",
            TextPosition = ToolbarItemTextPosition.Right,
            ToolTipText = "Underline",
            Size = new Size(90, 40),
            Icon = new FontImageSource { Glyph = "\uE762", FontFamily = "MauiMaterialAssets" }
        });

        ToolbarItems.Add(new SfToolbarItem
        {
            Name = "Italic",
            Text = "Italic",
            TextPosition = ToolbarItemTextPosition.Right,
            ToolTipText = "Italic",
            Size = new Size(60, 40),
            Icon = new FontImageSource { Glyph = "\uE771", FontFamily = "MauiMaterialAssets" }
        });

        ToolbarItems.Add(new SfToolbarItem
        {
            Name = "AlignLeft",
            Text = "Align-Left",
            TextPosition = ToolbarItemTextPosition.Right,
            ToolTipText = "Align-Left",
            Size = new Size(90, 40),
            Icon = new FontImageSource { Glyph = "\uE751", FontFamily = "MauiMaterialAssets" }
        });

        ToolbarItems.Add(new SfToolbarItem
        {
            Name = "AlignRight",
            Text = "Align-Right",
            TextPosition = ToolbarItemTextPosition.Right,
            ToolTipText = "Align-Right",
            Size = new Size(100, 40),
            Icon = new FontImageSource { Glyph = "\uE753", FontFamily = "MauiMaterialAssets" }
        });

        ToolbarItems.Add(new SfToolbarItem
        {
            Name = "AlignCenter",
            Text = "Align-Center",
            TextPosition = ToolbarItemTextPosition.Right,
            ToolTipText = "Align-Center",
            Size = new Size(100, 40),
            Icon = new FontImageSource { Glyph = "\uE752", FontFamily = "MauiMaterialAssets" }
        });

        ToolbarItems.Add(new SfToolbarItem
        {
            Name = "AlignJustify",
            Text = "Align-Justify",
            TextPosition = ToolbarItemTextPosition.Right,
            ToolTipText = "Align-Justify",
            Size = new Size(100, 40),
            Icon = new FontImageSource { Glyph = "\uE74F", FontFamily = "MauiMaterialAssets" }
        });
    }
}

{% endhighlight %}

{% endtabs %}

### Equal spacing 

The spacing between the toolbar items is equalized when the `ItemSpacing` property is set to -1.
 
## Item Alignment

The Toolbar control provides support for customizing the alignment of the toolbar items using the `ItemAlignment` property. This property allows you to set the alignment of the toolbar items to `Start`, `Center`, or `End`.

The following code sample demonstrates how to Create a Toolbar control with Item Alignment.

{% tabs %}

{% highlight xaml %}

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:local="clr-namespace:ToolbarSample"
             xmlns:toolbar="clr-namespace:Syncfusion.Maui.Toolbar;assembly=Syncfusion.Maui.Toolbar"
             x:Class="ToolbarSample.MainPage">
        <ContentPage.BindingContext>
            <local:ToolbarViewModel/>
        </ContentPage.BindingContext>
         <toolbar:SfToolbar x:Name="Toolbar"
                        HeightRequest="56"
                        Items="{Binding ToolbarItems}">
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
        }
    }

    public class ToolbarViewModel
    {
        public ObservableCollection<BaseToolbarItem> ToolbarItems { get; set; }
        
        public ToolbarViewModel()
        {
            ToolbarItems = new ObservableCollection<BaseToolbarItem>()
            {
                new SfToolbarItem() { Alignment = ToolbarItemAlignment.Start, Icon = new FontImageSource() { Glyph = "\uE713", FontFamily = "MaterialAssets" }, Text = "Start Item" },
                new SeparatorToolbarItem() { Alignment = ToolbarItemAlignment.Start },
                new SfToolbarItem() { Alignment = ToolbarItemAlignment.Center, Icon = new FontImageSource() { Glyph = "\uE714", FontFamily = "MaterialAssets" }, Text = "Center Item" },
                new SeparatorToolbarItem() { Alignment = ToolbarItemAlignment.Center },
                new SfToolbarItem() { Alignment = ToolbarItemAlignment.End, Icon = new FontImageSource() { Glyph = "\uE715", FontFamily = "MaterialAssets" }, Text = "End Item" },
                new SeparatorToolbarItem() { Alignment = ToolbarItemAlignment.End },
            };
        }
    }
}

{% endhighlight %}

{% endtabs %}
 
## Leading and Trailing Item

The Toolbar control provides support for setting leading and trailing items using the `ItemAlignment` property. The items set with `ItemAlignment` as `Start` will be displayed at the leading position, and the items set with `ItemAlignment` as `End` will be displayed at the trailing position. By default, the items will be displayed in the center position.

The following code sample demonstrates how to Create a Toolbar control with Leading and Trailing Item.

{% tabs %}

{% highlight xaml %}

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:local="clr-namespace:ToolbarSample"
             xmlns:toolbar="clr-namespace:Syncfusion.Maui.Toolbar;assembly=Syncfusion.Maui.Toolbar"
             x:Class="ToolbarSample.MainPage">
        <toolbar:SfToolbar x:Name="Toolbar" HeightRequest="56">
            <toolbar:SfToolbar.Items>
            <toolbar:SfToolbarItem  Name="Bold"
                                            Alignment="Start"
                                            Text="Bold"
                                            TextPosition="Right"
                                            ToolTipText="Bold"
                                            Size="60,40">
                <toolbar:SfToolbarItem.Icon>
                    <FontImageSource Glyph="&#xE770;"
                                                FontFamily="MauiMaterialAssets" />
                </toolbar:SfToolbarItem.Icon>
            </toolbar:SfToolbarItem>
            <toolbar:SfToolbarItem  Name="Underline"
                                            Alignment="Start"
                                            Text="Underline"
                                            TextPosition="Right"
                                            ToolTipText="Underline"
                                            Size="90,40">               
                <toolbar:SfToolbarItem.Icon>
                    <FontImageSource Glyph="&#xE762;"
                                                FontFamily="MauiMaterialAssets" />
                </toolbar:SfToolbarItem.Icon>
            </toolbar:SfToolbarItem>
            <toolbar:SfToolbarItem  Name="Italic"
                                            Alignment="Start"
                                            Text="Italic"
                                            TextPosition="Right"
                                            ToolTipText="Italic"
                                            Size="60,40">
                <toolbar:SfToolbarItem.Icon>
                    <FontImageSource Glyph="&#xE771;"
                                                FontFamily="MauiMaterialAssets" />
                </toolbar:SfToolbarItem.Icon>
            </toolbar:SfToolbarItem>
            <toolbar:SeparatorToolbarItem Alignment="Start"/>
            <toolbar:SfToolbarItem Name="AlignLeft"
                                        Alignment="Center"
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
                                        Alignment="Center"
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
                                        Alignment="Center"
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
                                        Alignment="Center"
                                        ToolTipText="Align-Justify"
                                        Text="Align-Justify"
                                        TextPosition="Right"
                                        Size="100,40">
                <toolbar:SfToolbarItem.Icon>
                    <FontImageSource Glyph="&#xE74F;"
                                                FontFamily="MauiMaterialAssets" />
                </toolbar:SfToolbarItem.Icon>
            </toolbar:SfToolbarItem>
            <toolbar:SeparatorToolbarItem Alignment="Center"/>
            <toolbar:SfToolbarItem Name="Undo"
                                        Alignment="End"
                                        Text="Undo"
                                        TextPosition="Right"
                                        ToolTipText="Undo"
                                        Size="70,40">
                <toolbar:SfToolbarItem.Icon>
                    <FontImageSource Glyph="&#xE744;"
                                                FontFamily="MauiMaterialAssets" />
                </toolbar:SfToolbarItem.Icon>
            </toolbar:SfToolbarItem>
            <toolbar:SfToolbarItem Name="Redo"
                                        Alignment="End"
                                        Text="Redo"
                                        TextPosition="Right"
                                        ToolTipText="Redo"
                                        Size="70,40">
                <toolbar:SfToolbarItem.Icon>
                    <FontImageSource Glyph="&#xE745;"
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
            
            ObservableCollection<BaseToolbarItem> toolbarItems = new ObservableCollection<BaseToolbarItem>
            {
                new SfToolbarItem
                {
                    Name = "Bold",
                    Alignment = ToolbarItemAlignment.Start,
                    Text = "Bold",
                    TextPosition = ToolbarItemTextPosition.Right,
                    ToolTipText = "Bold",
                    Size = new Size(60, 40),
                    Icon = new FontImageSource { Glyph = "\uE770", FontFamily = "MauiMaterialAssets" }
                },
                new SfToolbarItem
                {
                    Name = "Underline",
                    Alignment = ToolbarItemAlignment.Start,
                    Text = "Underline",
                    TextPosition = ToolbarItemTextPosition.Right,
                    ToolTipText = "Underline",
                    Size = new Size(90, 40),
                    Icon = new FontImageSource { Glyph = "\uE762", FontFamily = "MauiMaterialAssets" }
                },
                new SfToolbarItem
                {
                    Name = "Italic",
                    Alignment = ToolbarItemAlignment.Start,
                    Text = "Italic",
                    TextPosition = ToolbarItemTextPosition.Right,
                    ToolTipText = "Italic",
                    Size = new Size(60, 40),
                    Icon = new FontImageSource { Glyph = "\uE771", FontFamily = "MauiMaterialAssets" }
                },
                new SeparatorToolbarItem
                {
                    Alignment = ToolbarItemAlignment.Start
                },
                new SfToolbarItem
                {
                    Name = "AlignLeft",
                    Alignment = ToolbarItemAlignment.Center,
                    Text = "Align-Left",
                    TextPosition = ToolbarItemTextPosition.Right,
                    ToolTipText = "Align-Left",
                    Size = new Size(90, 40),
                    Icon = new FontImageSource { Glyph = "\uE751", FontFamily = "MauiMaterialAssets" }
                },
                new SfToolbarItem
                {
                    Name = "AlignRight",
                    Alignment = ToolbarItemAlignment.Center,
                    Text = "Align-Right",
                    TextPosition = ToolbarItemTextPosition.Right,
                    ToolTipText = "Align-Right",
                    Size = new Size(100, 40),
                    Icon = new FontImageSource { Glyph = "\uE753", FontFamily = "MauiMaterialAssets" }
                },
                new SfToolbarItem
                {
                    Name = "AlignCenter",
                    Alignment = ToolbarItemAlignment.Center,
                    Text = "Align-Center",
                    TextPosition = ToolbarItemTextPosition.Right,
                    ToolTipText = "Align-Center",
                    Size = new Size(100, 40),
                    Icon = new FontImageSource { Glyph = "\uE752", FontFamily = "MauiMaterialAssets" }
                },
                new SfToolbarItem
                {
                    Name = "AlignJustify",
                    Alignment = ToolbarItemAlignment.Center,
                    Text = "Align-Justify",
                    TextPosition = ToolbarItemTextPosition.Right,
                    ToolTipText = "Align-Justify",
                    Size = new Size(100, 40),
                    Icon = new FontImageSource { Glyph = "\uE74F", FontFamily = "MauiMaterialAssets" }
                },
                new SeparatorToolbarItem
                {
                    Alignment = ToolbarItemAlignment.Center
                },
                new SfToolbarItem
                {
                    Name = "Undo",
                    Alignment = ToolbarItemAlignment.End,
                    Text = "Undo",
                    TextPosition = ToolbarItemTextPosition.Right,
                    ToolTipText = "Undo",
                    Size = new Size(70, 40),
                    Icon = new FontImageSource { Glyph = "\uE744", FontFamily = "MauiMaterialAssets" }
                },
                new SfToolbarItem
                {
                    Name = "Redo",
                    Alignment = ToolbarItemAlignment.End,
                    Text = "Redo",
                    TextPosition = ToolbarItemTextPosition.Right,
                    ToolTipText = "Redo",
                    Size = new Size(70, 40),
                    Icon = new FontImageSource { Glyph = "\uE745", FontFamily = "MauiMaterialAssets" }
                }
            };
            
            toolbar.Items = toolbarItems;
            this.Content = toolbar;
        }
    }
}

{% endhighlight %}

{% endtabs %}
---
layout: post
title: Orientation in MAUI Toolbar Control | Syncfusion®
description: Learn here about Orientation support in Syncfusion® MAUI Toolbar (SfToolbar) and more.
platform: MAUI
control: Toolbar (SfToolbar)
documentation: ug
---

# Orientation in MAUI Toolbar (SfToolbar)

This section explains the ways about support for both horizontal and vertical layouts, allowing flexible arrangement based on application needs using `Orientation` property. Default value is `Horizontal`.

## Horizontal Toolbar

To set up a horizontal toolbar using the SfToolbar component in .NET MAUI, you can specify the orientation by setting the `Orientation` property to `Horizontal`. This configuration arranges the toolbar’s items from left to right across the screen.

The following code sample demonstrates how to Create a Toolbar control with Horinzontal layout.

{% tabs %}

{% highlight xaml %}

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:local="clr-namespace:ToolbarSample"
             xmlns:toolbar="clr-namespace:Syncfusion.Maui.Toolbar;assembly=Syncfusion.Maui.Toolbar"
             x:Class="ToolbarSample.MainPage">
    <ContentPage.BindingContext>
        <local:TextFormattingViewModel/>
    </ContentPage.BindingContext>

<toolbar:SfToolbar x:Name="Toolbar"
                   Items="{Binding ToolbarItems}"
                   Orientation="Horizontal"
                   HeightRequest="56"/>
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
            toolbar.Orientation = ToolbarOrientation.Horizontal;
            this.Content = toolbar;
        }
    }

    public class TextFormattingViewModel
    {
        private ObservableCollection<BaseToolbarItem> toolbarItems = new ObservableCollection<BaseToolbarItem>();

        public ObservableCollection<BaseToolbarItem> ToolbarItems
        {
            get { return toolbarItems; }
            set { toolbarItems = value; }
        }

        public TextFormattingViewModel()
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
}

{% endhighlight %}

{% endtabs %}

## Vertical Toolbar

To set up a Vertical toolbar using the SfToolbar component in .NET MAUI, you can specify the orientation by setting the `Orientation` property to `Vertical`. This configuration arranges the toolbar’s items from top to bottom across the screen.

The following code sample demonstrates how to Create a Toolbar control with Horinzontal layout.
{% tabs %}

{% highlight xaml %}

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:local="clr-namespace:ToolbarSample"
             xmlns:toolbar="clr-namespace:Syncfusion.Maui.Toolbar;assembly=Syncfusion.Maui.Toolbar"
             x:Class="ToolbarSample.MainPage">
    <ContentPage.BindingContext>
        <local:TextFormattingViewModel/>
    </ContentPage.BindingContext>

<toolbar:SfToolbar x:Name="Toolbar"
                   Items="{Binding ToolbarItems}"
                   Orientation="Vertical"
                   HeightRequest="56"/>
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
            toolbar.Orientation = ToolbarOrientation.Vertical;
            this.Content = toolbar;
        }
    }

    public class TextFormattingViewModel
    {
        private ObservableCollection<BaseToolbarItem> toolbarItems = new ObservableCollection<BaseToolbarItem>();

        public ObservableCollection<BaseToolbarItem> ToolbarItems
        {
            get { return toolbarItems; }
            set { toolbarItems = value; }
        }

        public TextFormattingViewModel()
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
}

{% endhighlight %}

{% endtabs %}

---
layout: post
title: Tooltip in MAUI Toolbar Control | Syncfusion®
description: Learn about Tooltip support in Syncfusion® MAUI Toolbar (SfToolbar) to view additional details of toolbar items.
platform: MAUI
control: Toolbar (SfToolbar)
documentation: ug
---

# Enable the Tooltip

The tooltip is enabled in the view when the `TooltipText` or `Text` property is set for the ToolbarItems. By default, the tooltip is supported only in the default view.

## Tooltip Text

You can set the tooltip text by setting the `ToolTipText` property.

The following code sample demonstrates how to Create a Toolbar control with tooltip.

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
    <StackLayout>
        <toolbar:SfToolbar x:Name="Toolbar" HeightRequest="56" Items="{Binding ToolbarItems}">
            <toolbar:SfToolbar.ToolTipSettings>
                <toolbar:ToolbarToolTipSettings Background="Red">
                    <toolbar:ToolbarToolTipSettings.TextStyle>
                        <toolbar:ToolbarTextStyle TextColor="Yellow"
                                                  FontSize="18"
                                                  FontAttributes="Italic"
                                                  FontAutoScalingEnabled="True"
                                                  FontFamily="OpenSansSemibold"/>
                    </toolbar:ToolbarToolTipSettings.TextStyle>
                    <toolbar:ToolbarToolTipSettings.ToolTipPosition>Top</toolbar:ToolbarToolTipSettings.ToolTipPosition>
                </toolbar:ToolbarToolTipSettings>
            </toolbar:SfToolbar.ToolTipSettings>
        </toolbar:SfToolbar>
    </StackLayout>
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

            SfToolbar toolbar = new SfToolbar
            {
                HeightRequest = 56
            };

            ObservableCollection<BaseToolbarItem> itemCollection = new ObservableCollection<BaseToolbarItem>
            {
                new SfToolbarItem { Name = "Bold", ToolTipText = "Bold", Icon = new FontImageSource { Glyph = "\uE770", FontFamily = "MauiMaterialAssets" } },
                new SfToolbarItem { Name = "Underline", ToolTipText = "Underline", Icon = new FontImageSource { Glyph = "\uE762", FontFamily = "MauiMaterialAssets" } },
                new SfToolbarItem { Name = "Italic", ToolTipText = "Italic", Icon = new FontImageSource { Glyph = "\uE771", FontFamily = "MauiMaterialAssets" } },
                new SfToolbarItem { Name = "AlignLeft", ToolTipText = "Align-Left", Icon = new FontImageSource { Glyph = "\uE751", FontFamily = "MauiMaterialAssets" } },
                new SfToolbarItem { Name = "AlignRight", ToolTipText = "Align-Right", Icon = new FontImageSource { Glyph = "\uE753", FontFamily = "MauiMaterialAssets" } },
                new SfToolbarItem { Name = "AlignCenter", ToolTipText = "Align-Center", Icon = new FontImageSource { Glyph = "\uE752", FontFamily = "MauiMaterialAssets" } },
                new SfToolbarItem { Name = "AlignJustify", ToolTipText = "Align-Justify", Icon = new FontImageSource { Glyph = "\uE74F", FontFamily = "MauiMaterialAssets" } }
            };

            toolbar.Items = itemCollection;
            ToolbarToolTipSettings toolTipSettings = new ToolbarToolTipSettings
            {
                Background = Colors.Red,
                TextStyle = new ToolbarTextStyle
                {
                    TextColor = Colors.Yellow,
                    FontSize = 18,
                    FontAttributes = FontAttributes.Italic,
                    FontAutoScalingEnabled = true,
                    FontFamily = "OpenSansSemibold"
                },
                ToolTipPosition = ToolbarRelativePosition.Top
            };

            toolbar.ToolTipSettings = toolTipSettings;
            this.Content = toolbar;
        }
    }
}

{% endhighlight %}

{% endtabs %}
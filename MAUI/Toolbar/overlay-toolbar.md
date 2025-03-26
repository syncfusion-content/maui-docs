---
layout: post
title: Overlay Toolbar in .NET MAUI Toolbar Control | Syncfusion®
description: Learn here all about Overlay toolbar support in Syncfusion® .NET MAUI Toolbar (SfToolbar) control and more.
platform: maui
control: Toolbar (SfToolbar)
documentation: ug
---

# Overlay Toolbar in .NET MAUI Toolbar (SfToolbar)

The toolbar control supports displaying an overlay toolbar in the view. You can add the [SfOverlayToolbar](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Toolbar.SfOverlayToolbar.html) to the [OverlayToolbar](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Toolbar.SfToolbarItem.html#Syncfusion_Maui_Toolbar_SfToolbarItem_OverlayToolbar) property of [SfToolbarItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Toolbar.SfToolbarItem.html). The [SfOverlayToolbar](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Toolbar.SfOverlayToolbar.html) includes a built-in back button, which can be used to close the overlay toolbar.

## How to display the overlay toolbar

You can retrieve the overlay toolbar of a toolbar item and add it to the view using the [Tapped](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Toolbar.ToolbarTappedEventArgs.html) event in the [SfToolbar](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Toolbar.SfToolbar.html) control. The following code sample demonstrates how to add an overlay toolbar to the view.

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

![overlay-toolbar](images/overlay-toolbar.gif)
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

## Back icon customization
The toolbar control support customization of back icon using properties BackIconColor[https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Toolbar.SfOverlayToolbar.html#Syncfusion_Maui_Toolbar_SfOverlayToolbar_BackIconColor], BackIconAlignment[https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Toolbar.SfOverlayToolbar.html#Syncfusion_Maui_Toolbar_SfOverlayToolbar_BackIconAlignment], BackIconTemplate[https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Toolbar.SfOverlayToolbar.html#Syncfusion_Maui_Toolbar_SfOverlayToolbar_BackIconTemplate], BackIconToolTipText[https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Toolbar.SfOverlayToolbar.html#Syncfusion_Maui_Toolbar_SfOverlayToolbar_BackIconToolTipText].

*    **BackIconColor** – This property is used to define the color of the back icon displayed in the overlay toolbar.
*    **BackIconAlignment** – This property defines the alignment of the back icon within the overlay toolbar. It supports three alignment options: Start[https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Toolbar.OverlayToolbarBackIconPosition.html#Syncfusion_Maui_Toolbar_OverlayToolbarBackIconPosition_Start], which positions the icon at the leading edge; End[https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Toolbar.OverlayToolbarBackIconPosition.html#Syncfusion_Maui_Toolbar_OverlayToolbarBackIconPosition_End], which places it at the trailing edge. By default, the back icon is displayed at the leading position.
*    **BackIconTemplate** – This property allows customization of the back icon's appearance by enabling the use of various view elements such as buttons, checkboxes, entries, and more.
*    **BackIconToolTipText** – This property is used to define the tooltip text displayed when hovering over the back icon.

N> If TooltipText is provided, tooltip will be displayed on the back icon. If not provided, use must handle the tooltip manually.

{% tabs %}

{% highlight xaml %}

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
                                                OverflowMode="Scroll"
                                              BackIconAlignment="End"
                                              BackIconToolTipText="Back"
                                              BackIconColor="Red">
                        <toolbar:SfOverlayToolbar.BackIconTemplate>
                            <DataTemplate>
                                <ViewCell>
                                    <Grid WidthRequest="47" HeightRequest="33" HorizontalOptions="Start">
                                        <ImageButton Source="close.png" Clicked="ImageButton_Clicked" />
                                    </Grid>
                                </ViewCell>
                            </DataTemplate>
                        </toolbar:SfOverlayToolbar.BackIconTemplate>
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
                            
                        <toolbar:SeparatorToolbarItem/>
   
                        </toolbar:SfOverlayToolbar.Items>
                    </toolbar:SfOverlayToolbar>
                </toolbar:SfToolbarItem.OverlayToolbar>
            </toolbar:SfToolbarItem>
        </toolbar:SfToolbar.Items>
    </toolbar:SfToolbar>
</Grid>

{% endhighlight %}

{% highlight c# %}

namespace ToolbarSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            var backIconTemplate = new DataTemplate(() =>
            {
            var grid = new Grid
            {
                WidthRequest = 47,
                HeightRequest = 33,
                HorizontalOptions = LayoutOptions.Start
            };
            var image = new ImageButton
            {
                Source = "close.png",
                Clicked = "ImageButton_Clicked",
            };

            grid.Children.Add(image);

            var viewCell = new ViewCell
            {
                View = grid
            };

                return viewCell;
            });

            overlaytoolbar.BackIconTemplate = backIconTemplate;
            overlaytoolbar.BackIconColor = Colors.Blue;
            overlaytoolbar.BackIconToolTipText = "Back";
            overlaytoolbar.BackIconAlignment = OverlayToolbarBackIconPosition.End;
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

        private void ImageButton_Clicked(object sender, EventArgs e)
        {
            this.overlaytoolbar.IsVisible = false;
        }
    }
}

{% endhighlight %}

{% endtabs %}

![overlay-toolbar](images/backicon-customization.png)





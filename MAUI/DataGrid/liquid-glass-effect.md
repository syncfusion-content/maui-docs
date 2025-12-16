---
layout: post
title: Liquid Glass Support for .NET MAUI DataGrid | Syncfusion®
description: Learn here about providing liquid glass support for Syncfusion® .NET MAUI DataGrid (SfDataGrid) control and more.
platform: MAUI
control: SfDataGrid
documentation: ug
keywords: maui datagrid, maui grid, .net maui datagrid, liquid glass, glassmorphism, acrylic, blur, sfglasseffectview, datagrid glass effect
---

# Liquid glass support

The [SfDataGrid](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html) supports a `liquid glass` appearance by hosting the control inside the Syncfusion [SfGlassEffectsView](). You can customize the effect using properties such as [EffectType](), [EnableShadowEffect](), and round the corners using [CornerRadius](). This approach improves visual depth and readability when SfDataGrid is placed over images or colorful layouts. Additionally, DataGrid elements such as the row/column dragging view, tooltip, popups, context menu, and editor drop-downs (e.g., ComboBox/Picker) apply the glass effect only when [EnableLiquidGlassEffect]() is set to true and the related surfaces' Background is set to Transparent.

## Availability

1. This feature is supported on .NET 10 or greater.
2. This feature is supported on mac or iOS 26 or greater.
3. On platforms or versions below these requirements, the control renders without the acrylic blur effect and falls back to a standard background.

## Prerequisites

- Add the [Syncfusion.Maui.Core](https://www.nuget.org/packages/Syncfusion.Maui.Core/) package (for SfGlassEffectsView) and [Syncfusion.Maui.DataGrid](https://www.nuget.org/packages/Syncfusion.Maui.DataGrid/) (for SfDataGrid).

XAML example: Wrap the `SfDataGrid` in an `SfGlassEffectsView`, then enable the glass effect with `EnableLiquidGlassEffect`. For surfaces like drag views, tooltip, and context menu, set their Background to Transparent to reveal the glass effect.

{% tabs %}
{% highlight xaml %}
<?xml version="1.0" encoding="utf-8" ?>
<ContentPage
    xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
    xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
    xmlns:syncfusion="clr-namespace:Syncfusion.Maui.DataGrid;assembly=Syncfusion.Maui.DataGrid"
    xmlns:core="clr-namespace:Syncfusion.Maui.Core;assembly=Syncfusion.Maui.Core"
    x:Class="AcrylicDataGridPage">

    <Grid>
        <!-- Background to make acrylic blur visible -->
        <Image Source="wallpaper.jpg" Aspect="AspectFill" />
        <core:SfGlassEffectsView
            CornerRadius="20"
            EffectType="Regular"
            EnableShadowEffect="True">

            <syncfusion:SfDataGrid x:Name="dataGrid"
                                   ItemsSource="{Binding OrderInfoCollection}"
								   EnableLiquidGlassEffect="True">
                <!-- Make specific surfaces transparent to reveal glass -->
                <syncfusion:SfDataGrid.DefaultStyle>
                    <syncfusion:DataGridStyle RowDragViewBackgroundColor="Transparent"
                                              ColumnDragViewBackgroundColor="Transparent"/>
                </syncfusion:SfDataGrid.DefaultStyle>
            </syncfusion:SfDataGrid>
        </core:SfGlassEffectsView>
    </Grid>
</ContentPage>
{% endhighlight %}
{% highlight c# %}
using Syncfusion.Maui.Core;
using Syncfusion.Maui.DataGrid;

var grid = new Grid();
var background = new Image
{
    Source = "wallpaper.jpg",
    Aspect = Aspect.AspectFill
};

grid.Children.Add(background);

var glassEffects = new SfGlassEffectsView
{
    CornerRadius = 20,
    EffectType = LiquidGlassEffectType.Regular,
    EnableShadowEffect = true
};

var dataGrid = new SfDataGrid
{
    ItemsSource = viewModel.OrderInfoCollection,
	EnableLiquidGlassEffect = true
};


dataGrid.DefaultStyle.RowDragViewBackgroundColor = Colors.Transparent;
dataGrid.DefaultStyle.ColumnDragViewBackgroundColor = Colors.Transparent;

glassEffects.Content = dataGrid;
grid.Children.Add(glassView);
Content = grid;

{% endhighlight %}
{% endtabs %}

## SfDataPager

You can also enable the liquid glass effect for the standalone [SfDataPager](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataPager.SfDataPager.html) control by setting `EnableLiquidGlassEffect` to `True`. Wrapping with `SfGlassEffectsView` is optional for additional container styling.

{% tabs %}
{% highlight xaml %}
<?xml version="1.0" encoding="utf-8" ?>
<ContentPage
    xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
    xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
    xmlns:core="clr-namespace:Syncfusion.Maui.Core;assembly=Syncfusion.Maui.Core"
    xmlns:datapager="clr-namespace:Syncfusion.Maui.DataPager;assembly=Syncfusion.Maui.DataPager"
    x:Class="AcrylicDataPagerPage">

    <Grid>
        <Image Source="wallpaper.jpg" Aspect="AspectFill" />
        <core:SfGlassEffectsView
            CornerRadius="16"
            HeightRequest="56"
            EffectType="Regular"
            EnableShadowEffect="True">

            <datapager:SfDataPager
                x:Name="dataPager"
                EnableLiquidGlassEffect="True"
                PageCount="20"
                SelectedPageIndex="0" />
        </core:SfGlassEffectsView>
    </Grid>
</ContentPage>
{% endhighlight %}
{% highlight c# %}
using Syncfusion.Maui.Core;
using Syncfusion.Maui.DataPager;

var pagerGlass = new SfGlassEffectsView
{
    CornerRadius = 16,
    HeightRequest = 56,
    EffectType = LiquidGlassEffectType.Regular,
    EnableShadowEffect = true
};

var dataPager = new SfDataPager
{
    EnableLiquidGlassEffect = true,
    PageCount = 20,
    SelectedPageIndex = 0
};

pagerGlass.Content = dataPager;
this.Content = pagerGlass;
{% endhighlight %}
{% endtabs %}

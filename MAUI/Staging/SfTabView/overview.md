---
title: "SfTabView"
page_title: ".NET MAUI SfTabView: Overview"
description: "Overview, key concepts, and links to guides and API reference for Syncfusion.Maui.TabView SfTabView."
slug: "controls-sftabview-overview"
position: 1
---

# SfTabView: Overview

`SfTabView` (namespace: `Syncfusion.Maui.TabView`) provides a tabbed navigation UI for .NET MAUI apps. It renders a tab bar (headers) and a content region, and supports horizontal (Top/Bottom) and vertical (Left/Right) tab bars.

## Key concepts

- **Tabs** are represented by `SfTabItem` instances.
- You can provide tabs using:
  - **`Items`** (`TabItemCollection`) for explicit `SfTabItem` instances.
  - **`ItemsSource`** (`IList`) with **`HeaderItemTemplate`** and **`ContentItemTemplate`** for data-driven tabs.
- **Selection** is controlled by **`SelectedIndex`** (two-way bindable).

## Key capabilities

- Data-driven tabs with `ItemsSource`, `HeaderItemTemplate`, and `ContentItemTemplate`
- Horizontal/vertical tab bar placement via `TabBarPlacement`
- Tab sizing via `TabWidthMode` (including `SizeToContent`)
- Selection indicator customization (`IndicatorBackground`, `IndicatorPlacement`, `IndicatorWidthMode`, corner radius, stroke thickness)
- Optional swipe navigation (`EnableSwiping`)
- Optional content virtualization (`EnableVirtualization`)

## Example at a glance

### XAML

```xml
<?xml version="1.0" encoding="utf-8" ?>
<ContentPage
    xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
    xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
    xmlns:tabView="http://schemas.syncfusion.com/maui"
    x:Class="MyApp.Views.TabViewPage">

    <tabView:SfTabView TabBarPlacement="Bottom"
                      EnableSwiping="True"
                      SelectionChanged="TabView_SelectionChanged">
        <tabView:SfTabView.Items>
            <tabView:SfTabItem Header="Home">
                <tabView:SfTabItem.Content>
                    <Label Text="Home content" />
                </tabView:SfTabItem.Content>
            </tabView:SfTabItem>

            <tabView:SfTabItem Header="Favorites">
                <tabView:SfTabItem.Content>
                    <Label Text="Favorites content" />
                </tabView:SfTabItem.Content>
            </tabView:SfTabItem>

            <tabView:SfTabItem Header="Settings">
                <tabView:SfTabItem.Content>
                    <Label Text="Settings content" />
                </tabView:SfTabItem.Content>
            </tabView:SfTabItem>
        </tabView:SfTabView.Items>
    </tabView:SfTabView>

</ContentPage>
```

### C#

```csharp
using Syncfusion.Maui.TabView;

var tabView = new SfTabView
{
    TabBarPlacement = TabBarPlacement.Bottom,
    EnableSwiping = true,
    Items = new TabItemCollection
    {
        new SfTabItem { Header = "Home", Content = new Label { Text = "Home content" } },
        new SfTabItem { Header = "Favorites", Content = new Label { Text = "Favorites content" } },
        new SfTabItem { Header = "Settings", Content = new Label { Text = "Settings content" } },
    }
};

tabView.SelectionChanged += (_, e) =>
{
    // e.OldIndex, e.NewIndex
};

Content = tabView;
```

## See also

- Getting Started: `getting-started.md`
- Features: `features/index.md`
- API Reference: `api/api-reference.md`

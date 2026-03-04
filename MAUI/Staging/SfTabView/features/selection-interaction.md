---
layout: post
title: Selection & interaction in .NET MAUI Tab View (SfTabView) | Syncfusion®
description: Learn all about selection & interaction in Syncfusion® .NET MAUI Tab View (SfTabView) control, its elements, and more.
platform: MAUI
control: SfTabView
documentation: UG
---

# Selection and Interaction

This page covers how selection works in `SfTabView`, how to handle selection-related events, and how to enable swipe-based navigation.

## Members involved

| Member | Kind | Type | Default/Mode | Purpose |
|---|---|---|---|---|
| `SfTabView.SelectedIndex` | Bindable property | `double` | Default: `0`; Mode: `TwoWay` | Gets/sets the current selection index. |
| `SfTabView.SelectionChanging` | Event | `EventHandler<SelectionChangingEventArgs>` | — | Cancel or react to an upcoming selection change. |
| `SfTabView.SelectionChanged` | Event | `EventHandler<TabSelectionChangedEventArgs>` | — | React after selection changes. |
| `SfTabView.TabItemTapped` | Event | `EventHandler<TabItemTappedEventArgs>` | — | Observe header taps and optionally cancel them. |
| `SfTabView.EnableSwiping` | Bindable property | `bool` | Default: `false` | Enables swipe-to-change-tab. |
| `SfTabView.ContentTransitionDuration` | Bindable property | `double` | Default: `100` | Controls transition duration when changing content. |
| `SfTabView.AnimationEasing` | Bindable property | `Easing` | Default: `Easing.Linear` | Controls content transition easing. |
| `SfTabView.EnableRippleAnimation` | Bindable property | `bool` | Default: `true` | Enables ripple animation in header interactions. |

## Scenario: Cancel selection for a specific tab

`SelectionChangingEventArgs` inherits from `CancelEventArgs`, so you can set `e.Cancel = true`.

### XAML

```xml
<?xml version="1.0" encoding="utf-8" ?>
<ContentPage
    xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
    xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
    xmlns:tabView="http://schemas.syncfusion.com/maui"
    x:Class="MyApp.Views.GuardedTabsPage">

    <tabView:SfTabView SelectionChanging="TabView_SelectionChanging">
        <tabView:SfTabItem Header="Free">
            <tabView:SfTabItem.Content>
                <Label Padding="16" Text="Free content" />
            </tabView:SfTabItem.Content>
        </tabView:SfTabItem>

        <tabView:SfTabItem Header="Premium">
            <tabView:SfTabItem.Content>
                <Label Padding="16" Text="Premium content" />
            </tabView:SfTabItem.Content>
        </tabView:SfTabItem>
    </tabView:SfTabView>
</ContentPage>
```

### C#

```csharp
using Syncfusion.Maui.TabView;

namespace MyApp.Views;

public partial class GuardedTabsPage : ContentPage
{
    public GuardedTabsPage()
    {
        InitializeComponent();
    }

    void TabView_SelectionChanging(object? sender, SelectionChangingEventArgs e)
    {
        // Example rule: block the second tab.
        if (e.Index == 1)
        {
            e.Cancel = true;
        }
    }
}
```

## Scenario: Track selection changes

### XAML

```xml
<tabView:SfTabView SelectionChanged="TabView_SelectionChanged">
    <!-- items -->
</tabView:SfTabView>
```

### C#

```csharp
using Syncfusion.Maui.TabView;

void TabView_SelectionChanged(object? sender, TabSelectionChangedEventArgs e)
{
    // e.OldIndex, e.NewIndex

    // Optional: set e.Handled = true if you want to mark it handled.
}
```

## Scenario: Handle header taps

### XAML

```xml
<tabView:SfTabView TabItemTapped="TabView_TabItemTapped">
    <!-- items -->
</tabView:SfTabView>
```

### C#

```csharp
using Syncfusion.Maui.TabView;

void TabView_TabItemTapped(object? sender, TabItemTappedEventArgs e)
{
    // e.TabItem

    // Optional: cancel the tap action
    // e.Cancel = true;
}
```

## Scenario: Enable swipe navigation and tune the transition

### XAML

```xml
<tabView:SfTabView EnableSwiping="True"
                  ContentTransitionDuration="200"
                  AnimationEasing="CubicOut" />
```

### C#

```csharp
tabView.EnableSwiping = true;
tabView.ContentTransitionDuration = 200;
tabView.AnimationEasing = Easing.CubicOut;
```

## See also

- Data Binding: `data-binding.md`
- Customization & Theming: `customization-theming.md`
- API reference: `../api/api-reference.md`

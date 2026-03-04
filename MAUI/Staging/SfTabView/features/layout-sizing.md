---
layout: post
title: Layout and sizing in .NET MAUI Tab View (SfTabView) | Syncfusion®
description: Learn all about layout and sizing in Syncfusion® .NET MAUI Tab View (SfTabView) control, its elements, and more.
platform: MAUI
control: SfTabView
documentation: UG
---

# Layout and sizing in .NET MAUI Tab View

This page covers tab-bar placement and common sizing behaviors.

## Members involved

| Member | Kind | Type | Default/Mode | Purpose |
|---|---|---|---|---|
| `SfTabView.TabBarPlacement` | Bindable property | `TabBarPlacement` | Default: `Top` | Places the tab bar on Top/Bottom/Left/Right. |
| `SfTabView.TabBarHeight` | Bindable property | `double` | Default: `48` | Tab bar height for Top/Bottom placement. |
| `SfTabView.TabBarWidth` | Bindable property | `double` | Default: `48` | Tab bar width for Left/Right placement. |
| `SfTabView.TabWidthMode` | Bindable property | `TabWidthMode` | Default: `Default` | Controls tab header sizing. |
| `SfTabView.TabHeaderPadding` | Bindable property | `Thickness` | Default: created by `DefaultTabHeaderPaddingCreator` | Header padding (applies to `SizeToContent`). |
| `SfTabView.HeaderItemSpacing` | Bindable property | `int` | Default: `36` | Spacing between header items. |

## Scenario: Bottom tab bar (typical mobile navigation)

### XAML

```xml
<tabView:SfTabView TabBarPlacement="Bottom"
                  TabBarHeight="75"
                  EnableSwiping="True"
                  IndicatorPlacement="Top">
    <tabView:SfTabItem Header="Favorites" />
    <tabView:SfTabItem Header="Recents" />
    <tabView:SfTabItem Header="Contacts" />
</tabView:SfTabView>
```

### C#

```csharp
using Syncfusion.Maui.TabView;

var tabView = new SfTabView
{
    TabBarPlacement = TabBarPlacement.Bottom,
    TabBarHeight = 75,
    EnableSwiping = true,
    IndicatorPlacement = TabIndicatorPlacement.Top,
    Items = new TabItemCollection
    {
        new SfTabItem { Header = "Favorites" },
        new SfTabItem { Header = "Recents" },
        new SfTabItem { Header = "Contacts" },
    }
};
```

## Scenario: Vertical tab bar (Left/Right placement)

This mirrors the repo sample pattern (`VerticalOrientation.xaml`): set `TabBarPlacement` and `TabBarWidth`.

### XAML

```xml
<tabView:SfTabView TabBarPlacement="Left"
                  TabBarWidth="60"
                  TabWidthMode="SizeToContent"
                  TabHeaderPadding="0">

    <tabView:SfTabItem Header="&#xe75e;" FontFamily="MauiSampleFontIcon" FontSize="25">
        <tabView:SfTabItem.Content>
            <Label Padding="16" Text="Activity" />
        </tabView:SfTabItem.Content>
    </tabView:SfTabItem>

    <tabView:SfTabItem Header="&#xe761;" FontFamily="MauiSampleFontIcon" FontSize="25">
        <tabView:SfTabItem.Content>
            <Label Padding="16" Text="Contacts" />
        </tabView:SfTabItem.Content>
    </tabView:SfTabItem>

</tabView:SfTabView>
```

### C#

```csharp
using Syncfusion.Maui.TabView;

var tabView = new SfTabView
{
    TabBarPlacement = TabBarPlacement.Left,
    TabBarWidth = 60,
    TabWidthMode = TabWidthMode.SizeToContent,
    TabHeaderPadding = new Thickness(0),
    Items = new TabItemCollection
    {
        new SfTabItem { Header = "\ue75e", FontFamily = "MauiSampleFontIcon", FontSize = 25, Content = new Label { Padding = 16, Text = "Activity" } },
        new SfTabItem { Header = "\ue761", FontFamily = "MauiSampleFontIcon", FontSize = 25, Content = new Label { Padding = 16, Text = "Contacts" } },
    }
};

Content = tabView;
```

## Scenario: Size-to-content headers with padding

`TabHeaderPadding` is applied when `TabWidthMode` is `SizeToContent`.

### XAML

```xml
<tabView:SfTabView TabWidthMode="SizeToContent"
                  TabHeaderPadding="12,10">
    <!-- items -->
</tabView:SfTabView>
```

### C#

```csharp
tabView.TabWidthMode = TabWidthMode.SizeToContent;
tabView.TabHeaderPadding = new Thickness(12, 10);
```

## See also

- Data Binding: `data-binding.md`
- Customization & Theming: `customization-theming.md`
- API reference: `../api/api-reference.md`

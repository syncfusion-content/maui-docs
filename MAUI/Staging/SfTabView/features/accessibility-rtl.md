---
layout: post
title: Accessibility and RTL in .NET MAUI Tab View (SfTabView) | Syncfusion®
description: Learn all about accessibility & RTL in Syncfusion® .NET MAUI Tab View (SfTabView) control, its elements, and more.
platform: MAUI
control: SfTabView
documentation: UG
---

# Accessibility & RTL

This page covers Right-to-Left (RTL) layout behavior and practical accessibility guidance when using `SfTabView`.

## Members involved

| Member | Kind | Type | Default/Mode | Purpose |
|---|---|---|---|---|
| `VisualElement.FlowDirection` | MAUI property | `FlowDirection` | Default: inherited | Controls RTL/LTR direction for layout. |
| `SfTabView.TabBarPlacement` | Bindable property | `TabBarPlacement` | Default: `Top` | Placement may be mirrored in RTL scenarios depending on your app layout choices. |
| `SfTabView.HeaderHorizontalTextAlignment` | Bindable property | `TextAlignment` | Default: `Center` | Helps align header text for readability. |
| `SfTabView.HeaderItemTemplate` | Bindable property | `DataTemplate?` | Default: `null` | Lets you provide accessible header content (labels, semantics). |

## Scenario: Enable RTL via `FlowDirection`

### XAML

```xml
<ContentPage
    xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
    xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
    xmlns:tabView="http://schemas.syncfusion.com/maui"
    FlowDirection="RightToLeft">

    <tabView:SfTabView>
        <tabView:SfTabItem Header="منزل">
            <tabView:SfTabItem.Content>
                <Label Padding="16" Text="RTL content" />
            </tabView:SfTabItem.Content>
        </tabView:SfTabItem>
    </tabView:SfTabView>
</ContentPage>
```

### C#

```csharp
using Syncfusion.Maui.TabView;

FlowDirection = FlowDirection.RightToLeft;

Content = new SfTabView
{
    Items = new TabItemCollection
    {
        new SfTabItem { Header = "منزل", Content = new Label { Padding = 16, Text = "RTL content" } },
    }
};
```

> **Note:** `SfTabView` listens for `FlowDirection` changes and updates its internal effective flow direction.

## Scenario: Accessible header content with `HeaderItemTemplate`

If you use `ItemsSource`, prefer a `HeaderItemTemplate` that produces readable text and (when needed) semantic properties.

### XAML

```xml
<tabView:SfTabView ItemsSource="{Binding Tabs}">
    <tabView:SfTabView.HeaderItemTemplate>
        <DataTemplate>
            <Label Text="{Binding Title}"
                   Padding="12,10"
                   SemanticProperties.Description="{Binding Title}" />
        </DataTemplate>
    </tabView:SfTabView.HeaderItemTemplate>
</tabView:SfTabView>
```

### C#

```csharp
tabView.HeaderItemTemplate = new DataTemplate(() =>
{
    var label = new Label { Padding = new Thickness(12, 10) };
    label.SetBinding(Label.TextProperty, "Title");
    label.SetBinding(SemanticProperties.DescriptionProperty, "Title");
    return label;
});
```

## See also

- Data Binding: `data-binding.md`
- Layout & Sizing: `layout-sizing.md`
- API reference: `../api/api-reference.md`

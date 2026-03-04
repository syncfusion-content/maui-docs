---
layout: post
title: Data binding in .NET MAUI Tab View (SfTabView) | Syncfusion®
description: Learn all about data binding in Syncfusion® .NET MAUI Tab View (SfTabView) control, its elements, and more.
platform: MAUI
control: SfTabView
documentation: UG
---

# Data Binding

This page covers data-driven usage of `SfTabView`, including binding `ItemsSource`, templating headers/content, and binding selection.

## Members involved

| Member | Kind | Type | Default/Mode | Purpose |
|---|---|---|---|---|
| `SfTabView.ItemsSource` | Bindable property | `IList?` | Default: `null` | Provides the data collection used to generate tabs. |
| `SfTabView.HeaderItemTemplate` | Bindable property | `DataTemplate?` | Default: `null` | Template for each tab header when using `ItemsSource`. |
| `SfTabView.ContentItemTemplate` | Bindable property | `DataTemplate?` | Default: `null` | Template for each tab content when using `ItemsSource`. |
| `SfTabView.SelectedIndex` | Bindable property | `double` | Default: `0`; Mode: `TwoWay` | Controls the selected tab index. |
| `SfTabView.EnableVirtualization` | Bindable property | `bool` | Default: `false` | Optimizes tab content generation for large tab sets. |
| `SfTabView.Items` | Bindable property | `TabItemCollection` | Default: `null` | Explicit tab items (alternative to `ItemsSource`). |

## Scenario: Bind tabs from a view model (`ItemsSource` + templates)

### ViewModel

```csharp
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MyApp.ViewModels;

public class TabData
{
    public string Title { get; set; } = string.Empty;
    public string Body { get; set; } = string.Empty;
}

public class TabsViewModel : INotifyPropertyChanged
{
    double selectedIndex;

    public ObservableCollection<TabData> Tabs { get; } = new()
    {
        new TabData { Title = "Home", Body = "Home content" },
        new TabData { Title = "Favorites", Body = "Favorites content" },
        new TabData { Title = "Settings", Body = "Settings content" },
    };

    public double SelectedIndex
    {
        get => selectedIndex;
        set
        {
            if (selectedIndex == value) return;
            selectedIndex = value;
            OnPropertyChanged();
        }
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    void OnPropertyChanged([CallerMemberName] string? name = null)
        => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
}
```

### XAML

```xml
<?xml version="1.0" encoding="utf-8" ?>
<ContentPage
    xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
    xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
    xmlns:tabView="http://schemas.syncfusion.com/maui"
    xmlns:vm="clr-namespace:MyApp.ViewModels"
    x:Class="MyApp.Views.TabsPage">

    <ContentPage.BindingContext>
        <vm:TabsViewModel />
    </ContentPage.BindingContext>

    <tabView:SfTabView ItemsSource="{Binding Tabs}"
                      SelectedIndex="{Binding SelectedIndex, Mode=TwoWay}">

        <tabView:SfTabView.HeaderItemTemplate>
            <DataTemplate>
                <Label Padding="12,10" Text="{Binding Title}" />
            </DataTemplate>
        </tabView:SfTabView.HeaderItemTemplate>

        <tabView:SfTabView.ContentItemTemplate>
            <DataTemplate>
                <ScrollView>
                    <Label Padding="16" Text="{Binding Body}" />
                </ScrollView>
            </DataTemplate>
        </tabView:SfTabView.ContentItemTemplate>

    </tabView:SfTabView>
</ContentPage>
```

### C#

```csharp
using MyApp.ViewModels;
using Syncfusion.Maui.TabView;

var viewModel = new TabsViewModel();
BindingContext = viewModel;

var tabView = new SfTabView
{
    ItemsSource = viewModel.Tabs,
};

tabView.SetBinding(SfTabView.SelectedIndexProperty, nameof(TabsViewModel.SelectedIndex), mode: BindingMode.TwoWay);

tabView.HeaderItemTemplate = new DataTemplate(() =>
{
    var title = new Label { Padding = new Thickness(12, 10) };
    title.SetBinding(Label.TextProperty, nameof(TabData.Title));
    return title;
});

tabView.ContentItemTemplate = new DataTemplate(() =>
{
    var body = new Label { Padding = new Thickness(16) };
    body.SetBinding(Label.TextProperty, nameof(TabData.Body));
    return new ScrollView { Content = body };
});

Content = tabView;
```

> **Note:** When you use `ItemsSource`, you typically provide `HeaderItemTemplate` and `ContentItemTemplate` to define what the header/content looks like for each bound item.

## Scenario: Use explicit `SfTabItem` instances (`Items`)

### XAML

```xml
<tabView:SfTabView>
    <tabView:SfTabView.Items>
        <tabView:SfTabItem Header="TAB 1">
            <tabView:SfTabItem.Content>
                <Label Text="Content 1" />
            </tabView:SfTabItem.Content>
        </tabView:SfTabItem>

        <tabView:SfTabItem Header="TAB 2">
            <tabView:SfTabItem.Content>
                <Label Text="Content 2" />
            </tabView:SfTabItem.Content>
        </tabView:SfTabItem>
    </tabView:SfTabView.Items>
</tabView:SfTabView>
```

### C#

```csharp
using Syncfusion.Maui.TabView;

var tabView = new SfTabView
{
    Items = new TabItemCollection
    {
        new SfTabItem { Header = "TAB 1", Content = new Label { Text = "Content 1" } },
        new SfTabItem { Header = "TAB 2", Content = new Label { Text = "Content 2" } },
    }
};

Content = tabView;
```

## Scenario: Large tab sets (virtualization)

If you generate many tabs from data and only a subset are visible/active at a time, enable virtualization:

### XAML

```xml
<tabView:SfTabView ItemsSource="{Binding Tabs}"
                  EnableVirtualization="True"
                  TabWidthMode="SizeToContent" />
```

### C#

```csharp
tabView.EnableVirtualization = true;
```

## See also

- Customization & Theming: `customization-theming.md`
- Selection & Interaction: `selection-interaction.md`
- API reference: `../api/api-reference.md`

# Getting Started: SfTabView

This guide shows the minimal setup to use `SfTabView` in a .NET MAUI app.

## 1) Install

Add the NuGet package(s) required by your app:

- `Syncfusion.Maui.TabView`

> **Note:** This repository also uses `Syncfusion.Maui.Core.Hosting` to register Syncfusion handlers.

## 2) Register Syncfusion in `MauiProgram`

In your `MauiProgram.cs`, register Syncfusion core (pattern used by the included sample app):

```csharp
using Syncfusion.Maui.Core.Hosting;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();

        builder
            .UseMauiApp<App>()
            .ConfigureSyncfusionCore();

        return builder.Build();
    }
}
```

## 3) Add the XAML namespace

Use the Syncfusion MAUI XAML namespace:

```xml
xmlns:tabView="http://schemas.syncfusion.com/maui"
```

## 4) Create your first tab view

### XAML (explicit items)

```xml
<?xml version="1.0" encoding="utf-8" ?>
<ContentPage
    xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
    xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
    xmlns:tabView="http://schemas.syncfusion.com/maui"
    x:Class="MyApp.Views.TabViewPage">

    <tabView:SfTabView x:Name="TabView"
                      TabBarHeight="48"
                      TabBarPlacement="Top"
                      TabWidthMode="Default"
                      EnableSwiping="True"
                      SelectionChanged="TabView_SelectionChanged">

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

            <tabView:SfTabItem Header="TAB 3">
                <tabView:SfTabItem.Content>
                    <Label Text="Content 3" />
                </tabView:SfTabItem.Content>
            </tabView:SfTabItem>
        </tabView:SfTabView.Items>

    </tabView:SfTabView>
</ContentPage>
```

### Code-behind (optional)

```csharp
using Syncfusion.Maui.TabView;

namespace MyApp.Views;

public partial class TabViewPage : ContentPage
{
    public TabViewPage()
    {
        InitializeComponent();
    }

    private void TabView_SelectionChanged(object? sender, TabSelectionChangedEventArgs e)
    {
        // e.OldIndex, e.NewIndex, e.Handled
    }
}
```

### C# (explicit items)

```csharp
using Syncfusion.Maui.TabView;

var tabView = new SfTabView
{
    TabBarHeight = 48,
    TabBarPlacement = TabBarPlacement.Top,
    TabWidthMode = TabWidthMode.Default,
    EnableSwiping = true,
    Items = new TabItemCollection
    {
        new SfTabItem { Header = "TAB 1", Content = new Label { Text = "Content 1" } },
        new SfTabItem { Header = "TAB 2", Content = new Label { Text = "Content 2" } },
        new SfTabItem { Header = "TAB 3", Content = new Label { Text = "Content 3" } },
    }
};

Content = tabView;
```

## Next steps

- Data-driven tabs: `features/data-binding.md`
- Selection events: `features/selection-interaction.md`
- Visual customization: `features/customization-theming.md`
- Full API: `api/api-reference.md`

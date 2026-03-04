# Category: Customization & Theming

This page covers customizing the look and feel of `SfTabView` and `SfTabItem` using properties, styles, and `VisualStateManager`.

## Members involved

| Member | Kind | Type | Default/Mode | Purpose |
|---|---|---|---|---|
| `SfTabView.TabBarBackground` | Bindable property | `Brush` | Default: `null` | Background brush for the tab bar. |
| `SfTabView.TabBarHeight` | Bindable property | `double` | Default: `48` | Height of the tab bar for Top/Bottom placement. |
| `SfTabView.TabBarWidth` | Bindable property | `double` | Default: `48` | Width of the tab bar for Left/Right placement. |
| `SfTabView.IndicatorBackground` | Bindable property | `Brush` | Default: `#6750A4` | Brush used to draw the selection indicator. |
| `SfTabView.IndicatorPlacement` | Bindable property | `TabIndicatorPlacement` | Default: `Bottom` | Placement of the selection indicator. |
| `SfTabView.IndicatorWidthMode` | Bindable property | `IndicatorWidthMode` | Default: `Fit` | Indicator width behavior (not applicable for `Fill`). |
| `SfTabView.IndicatorCornerRadius` | Bindable property | `CornerRadius` | Default: `(-1)` | Corner radius of the selection indicator. |
| `SfTabView.IndicatorStrokeThickness` | Bindable property | `double` | Default: `3` | Thickness of the indicator. |
| `SfTabView.TabBarBorderColor` | Bindable property | `Color?` | Default: `null` | Border color for the tab bar. |
| `SfTabView.TabBarBorderThickness` | Bindable property | `Thickness` | Default: `0` | Border thickness for the tab bar. |
| `SfTabView.TabBarCornerRadius` | Bindable property | `CornerRadius` | Default: `0` | Corner radius for the tab bar container. |
| `SfTabView.HeaderItemSpacing` | Bindable property | `int` | Default: `36` | Spacing between header items. |
| `SfTabView.TabHeaderPadding` | Bindable property | `Thickness` | Default: created by `DefaultTabHeaderPaddingCreator` | Header padding (applies to `TabWidthMode.SizeToContent`). |
| `SfTabItem.TextColor` | Bindable property | `Color` | Default: from theme | Header text color. |
| `SfTabItem.FontFamily` | Bindable property | `string` | Default: MAUI `FontElement` | Header font family. |
| `SfTabItem.FontAttributes` | Bindable property | `FontAttributes` | Default: MAUI `FontElement` | Header font attributes. |

## Scenario: Change indicator and tab bar background on selection

This mirrors the pattern used by the sample (`Customization.xaml.cs`), where selection changes drive indicator color.

### XAML

```xml
<?xml version="1.0" encoding="utf-8" ?>
<ContentPage
    xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
    xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
    xmlns:tabView="http://schemas.syncfusion.com/maui"
    x:Class="MyApp.Views.CustomTabViewPage">

    <tabView:SfTabView x:Name="TabView"
                      TabBarHeight="72"
                      EnableSwiping="True"
                      SelectionChanged="SfTabView_SelectionChanged">

        <tabView:SfTabItem Header="Document">
            <tabView:SfTabItem.Content>
                <Label Padding="16" Text="Document content" />
            </tabView:SfTabItem.Content>
        </tabView:SfTabItem>

        <tabView:SfTabItem Header="Excel">
            <tabView:SfTabItem.Content>
                <Label Padding="16" Text="Excel content" />
            </tabView:SfTabItem.Content>
        </tabView:SfTabItem>

        <tabView:SfTabItem Header="PDF">
            <tabView:SfTabItem.Content>
                <Label Padding="16" Text="PDF content" />
            </tabView:SfTabItem.Content>
        </tabView:SfTabItem>

    </tabView:SfTabView>
</ContentPage>
```

### C# (code-behind)

```csharp
using Syncfusion.Maui.TabView;

namespace MyApp.Views;

public partial class CustomTabViewPage : ContentPage
{
    public CustomTabViewPage()
    {
        InitializeComponent();

        // Optional: initial colors
        TabView.IndicatorBackground = new SolidColorBrush(Colors.RoyalBlue);
        TabView.TabBarBackground = new SolidColorBrush(Color.FromRgba(65, 105, 225, 25));
    }

    void SfTabView_SelectionChanged(object? sender, TabSelectionChangedEventArgs e)
    {
        if (sender is not SfTabView view) return;

        var item = view.Items[(int)e.NewIndex];
        var header = item?.Header;

        view.IndicatorBackground = header switch
        {
            "Document" => new SolidColorBrush(Colors.RoyalBlue),
            "Excel" => new SolidColorBrush(Colors.Green),
            "PDF" => new SolidColorBrush(Colors.DarkRed),
            _ => view.IndicatorBackground
        };

        if (view.IndicatorBackground is SolidColorBrush brush)
        {
            var c = brush.Color;
            var r = (int)(c.Red * 255);
            var g = (int)(c.Green * 255);
            var b = (int)(c.Blue * 255);
            view.TabBarBackground = new SolidColorBrush(Color.FromRgba(r, g, b, 25));
        }
    }
}
```

## Scenario: Style tab headers with `VisualStateManager`

The control theme defines `VisualStateManager` states (see `Themes/SfTabViewStyles.xaml`) like `Normal`, `Selected`, `Hover`, and `Disabled`. You can override these with a style for `SfTabItem`.

### XAML

```xml
<ContentPage
    xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
    xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
    xmlns:tabView="http://schemas.syncfusion.com/maui">

    <ContentPage.Resources>
        <Style TargetType="tabView:SfTabItem">
            <Setter Property="VisualStateManager.VisualStateGroups">
                <VisualStateGroupList>
                    <VisualStateGroup>
                        <VisualState x:Name="Normal">
                            <VisualState.Setters>
                                <Setter Property="TextColor" Value="Black" />
                                <Setter Property="FontFamily" Value="OpenSansRegular" />
                            </VisualState.Setters>
                        </VisualState>
                        <VisualState x:Name="Selected">
                            <VisualState.Setters>
                                <Setter Property="TextColor" Value="Purple" />
                                <Setter Property="FontFamily" Value="OpenSansSemibold" />
                            </VisualState.Setters>
                        </VisualState>
                    </VisualStateGroup>
                </VisualStateGroupList>
            </Setter>
        </Style>
    </ContentPage.Resources>

    <tabView:SfTabView>
        <tabView:SfTabItem Header="One">
            <tabView:SfTabItem.Content>
                <Label Padding="16" Text="One" />
            </tabView:SfTabItem.Content>
        </tabView:SfTabItem>
        <tabView:SfTabItem Header="Two">
            <tabView:SfTabItem.Content>
                <Label Padding="16" Text="Two" />
            </tabView:SfTabItem.Content>
        </tabView:SfTabItem>
    </tabView:SfTabView>
</ContentPage>
```

### C#

```csharp
using Syncfusion.Maui.TabView;

var tabView = new SfTabView
{
    Items = new TabItemCollection
    {
        new SfTabItem { Header = "One", Content = new Label { Padding = 16, Text = "One" } },
        new SfTabItem { Header = "Two", Content = new Label { Padding = 16, Text = "Two" } },
    }
};

Content = tabView;
```

> **Important:** The `VisualState` names you use must match the states that the control triggers (for example `Normal` and `Selected`).

## Scenario: Add border and corner radius to the tab bar

### XAML

```xml
<tabView:SfTabView TabBarBorderThickness="1"
                  TabBarBorderColor="Gray"
                  TabBarCornerRadius="10"
                  TabBarBackground="White">
    <!-- items here -->
</tabView:SfTabView>
```

### C#

```csharp
tabView.TabBarBorderThickness = new Thickness(1);
tabView.TabBarBorderColor = Colors.Gray;
tabView.TabBarCornerRadius = new CornerRadius(10);
tabView.TabBarBackground = new SolidColorBrush(Colors.White);
```

## See also

- Selection & Interaction: `selection-interaction.md`
- Layout & Sizing: `layout-sizing.md`
- API reference: `../api/api-reference.md`

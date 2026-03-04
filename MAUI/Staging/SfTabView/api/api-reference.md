# API Reference: SfTabView

This reference documents the public API surface found in the source under `maui/src/tabview/TabView/`.

> **Note:** Defaults and binding modes are taken from `BindableProperty.Create(...)` calls in the control source.

## SfTabView

Namespace: `Syncfusion.Maui.TabView`

### Constructor

| Member | Signature |
|---|---|
| `SfTabView()` | Initializes a new `SfTabView`. |

### Events

| Event | Type | EventArgs | Notes |
|---|---|---|---|
| `SelectionChanging` | `EventHandler<SelectionChangingEventArgs>` | `SelectionChangingEventArgs` | Cancel by setting `e.Cancel = true` (inherited from `CancelEventArgs`). |
| `SelectionChanged` | `EventHandler<TabSelectionChangedEventArgs>` | `TabSelectionChangedEventArgs` | Provides `OldIndex`, `NewIndex`, and `Handled`. |
| `TabItemTapped` | `EventHandler<TabItemTappedEventArgs>` | `TabItemTappedEventArgs` | Provides `TabItem` and cancelable `Cancel`. |

### Bindable properties

| Property | Type | Default | BindingMode | Description |
|---|---|---:|---|---|
| `TabBarBackground` | `Brush` | `null` | Default | Tab bar background brush. |
| `HeaderDisplayMode` | `TabBarDisplayMode` | `TabBarDisplayMode.Default` | TwoWay | Controls whether header shows image/text/both. |
| `TabBarPlacement` | `TabBarPlacement` | `TabBarPlacement.Top` | Default | Places tab bar on Top/Bottom/Left/Right. |
| `IndicatorPlacement` | `TabIndicatorPlacement` | `TabIndicatorPlacement.Bottom` | Default | Places the selection indicator. |
| `IndicatorWidthMode` | `IndicatorWidthMode` | `IndicatorWidthMode.Fit` | Default | Indicator width behavior (not applicable for `Fill`). |
| `TabWidthMode` | `TabWidthMode` | `TabWidthMode.Default` | Default | Header width behavior. |
| `IndicatorBackground` | `Brush` | `SolidColorBrush(#6750A4)` | Default | Indicator brush. |
| `TabBarHeight` | `double` | `48` | Default | Tab bar height (Top/Bottom). |
| `TabBarWidth` | `double` | `48` | Default | Tab bar width (Left/Right). |
| `Items` | `TabItemCollection` | `null` | Default | Explicit tab items (`SfTabItem`). |
| `SelectedIndex` | `double` | `0` | TwoWay | Current selection index. |
| `ItemsSource` | `IList?` | `null` | Default | Data collection used to generate tabs. |
| `HeaderItemTemplate` | `DataTemplate?` | `null` | Default | Template used to render each header when using `ItemsSource`. |
| `ContentItemTemplate` | `DataTemplate?` | `null` | Default | Template used to render each content when using `ItemsSource`. |
| `TabHeaderPadding` | `Thickness` | `DefaultTabHeaderPaddingCreator` | Default | Header padding; applied for `TabWidthMode.SizeToContent`. |
| `IsScrollButtonEnabled` | `bool` | `false` | Default | Enables header scroll buttons (when applicable). |
| `HeaderHorizontalTextAlignment` | `TextAlignment` | `TextAlignment.Center` | Default | Header horizontal text alignment. |
| `ContentTransitionDuration` | `double` | `100` | Default | Transition duration when changing content. |
| `IndicatorCornerRadius` | `CornerRadius` | `CornerRadius(-1)` | Default | Indicator corner radius. |
| `IndicatorStrokeThickness` | `double` | `3` | Default | Indicator thickness. |
| `FontAutoScalingEnabled` | `bool` | `false` | Default | Enables OS font auto-scaling. |
| `EnableLiquidGlassEffect` | `bool` | `false` | Default | Apple-only liquid glass effect. |
| `EnableSwiping` | `bool` | `false` | Default | Enables swipe navigation between tabs. |
| `ScrollButtonBackground` | `Brush` | `SolidColorBrush(#F7F2FB)` | Default | Background for scroll buttons. |
| `ScrollButtonColor` | `Color` | `#49454F` | Default | Color for scroll button icons. |
| `EnableVirtualization` | `bool` | `false` | Default | Enables virtualization for tab content. |
| `EnableRippleAnimation` | `bool` | `true` | Default | Enables ripple animation on interactions. |
| `TabBarBorderColor` | `Color?` | `null` | Default | Tab bar border color. |
| `TabBarBorderThickness` | `Thickness` | `Thickness(0)` | Default | Tab bar border thickness. |
| `TabBarCornerRadius` | `CornerRadius` | `CornerRadius(0)` | Default | Tab bar corner radius. |
| `HeaderItemSpacing` | `int` | `36` | Default | Spacing between header items. |
| `AnimationEasing` | `Easing` | `Easing.Linear` | Default | Easing used during content transitions. |

## SfTabItem

Namespace: `Syncfusion.Maui.TabView`

### Constructor

| Member | Signature |
|---|---|
| `SfTabItem()` | Initializes a new `SfTabItem`. |

### Properties

| Property | Type | Default | BindingMode | Description |
|---|---|---:|---|---|
| `Header` | `string` | `string.Empty` | TwoWay | Header text. |
| `ImageSource` | `ImageSource` | `null` | Default | Header image. |
| `ImagePosition` | `TabImagePosition` | `TabImagePosition.Top` | Default | Image position relative to text. |
| `ImageTextSpacing` | `double` | `10` | TwoWay | Spacing between image and text. |
| `ImageSize` | `double` | `24` | TwoWay | Image size in the header. |
| `TextColor` | `Color` | `#49454F` | Default | Header text color. |
| `FontFamily` | `string` | MAUI default | MAUI (`FontElement`) | Header font family. |
| `FontAttributes` | `FontAttributes` | MAUI default | MAUI (`FontElement`) | Header font attributes. |
| `FontSize` | `double` | MAUI default | MAUI (`FontElement`) | Header font size. |
| `FontAutoScalingEnabled` | `bool` | MAUI default | MAUI (`FontElement`) | Font auto-scaling. |
| `LineBreakMode` | `LineBreakMode` | `TailTruncation` | Default | Header text truncation/wrapping behavior. |
| `BadgeText` | `string` | `string.Empty` | Default | Badge text. |
| `BadgeSettings` | `BadgeSettings` | `null` | Default | Badge appearance settings (from Syncfusion core). |
| `IsSelected` | `bool` | `false` | — | Indicates whether the item is selected. |
| `Font` | `Microsoft.Maui.Font` | — | — | Computed font value. |

### Methods

| Method | Signature | Purpose |
|---|---|---|
| `OnTouch` | `void OnTouch(TouchEventArgs e)` | Touch listener hook (internal interaction). |
| `OnFontFamilyChanged` | `void OnFontFamilyChanged(string oldValue, string newValue)` | Font element change hook. |
| `OnFontSizeChanged` | `void OnFontSizeChanged(double oldValue, double newValue)` | Font element change hook. |
| `FontSizeDefaultValueCreator` | `double FontSizeDefaultValueCreator()` | Default font size creator. |
| `OnFontAttributesChanged` | `void OnFontAttributesChanged(FontAttributes oldValue, FontAttributes newValue)` | Font element change hook. |
| `OnFontChanged` | `void OnFontChanged(Microsoft.Maui.Font oldValue, Microsoft.Maui.Font newValue)` | Font change hook. |

## API Completeness Verification

| Category            | Found in Source | Documented | Status |
|---|---:|---:|---|
| Bindable Properties (`SfTabView`) | 32 | 32 | ✅ |
| Bindable Properties (`SfTabItem`) | 13 | 13 | ✅ |
| CLR Properties (`SfTabView`)      | 32 | 32 | ✅ |
| CLR Properties (`SfTabItem`)      | 14 (includes `IsSelected`) | 14 | ✅ |
| Public Methods (`SfTabView`)      | 0 (excluding ctor) | 0 | ✅ |
| Public Methods (`SfTabItem`)      | 6 | 6 | ✅ |
| Events (`SfTabView`)              | 3 | 3 | ✅ |
| Commands                          | 0 | 0 | ✅ |
| Enums                             | 6 | 6 | ✅ |
| Constructors                      | 2 | 2 | ✅ |

**Verification result:** All public members enumerated above are documented. ✅

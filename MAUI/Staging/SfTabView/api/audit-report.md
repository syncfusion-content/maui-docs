# API Audit Report: SfTabView

This report summarizes the public API audit performed against the source code in:

- `maui/src/tabview/TabView/Control/SfTabView.cs`
- `maui/src/tabview/TabView/Control/SfTabItem.cs`
- `maui/src/tabview/TabView/Helper/*.cs`

## Scope

Included:

- Public types: classes + enums
- Public constructors
- Public events
- Public bindable properties and their CLR wrappers
- Public methods

Excluded:

- `internal` members (for example `ArrowType` enum and internal bindable properties)
- Implementation-only classes (for example `SfTabBar`)

## Findings

### Public types found

- Controls: `SfTabView`, `SfTabItem`
- Collections: `TabItemCollection`
- Event args: `TabSelectionChangedEventArgs`, `SelectionChangingEventArgs`, `TabItemTappedEventArgs`
- Enums: `TabBarPlacement`, `TabWidthMode`, `TabIndicatorPlacement`, `TabImagePosition`, `TabBarDisplayMode`, `IndicatorWidthMode`

### Public members found

- `SfTabView`
  - Bindable properties: 32
  - CLR properties: 32
  - Events: 3
  - Public methods: 0 (excluding constructor)
  - Constructors: 1

- `SfTabItem`
  - Bindable properties: 13
  - CLR properties: 14 (includes `IsSelected`)
  - Public methods: 6
  - Constructors: 1

## Verification summary

Found 32 `BindableProperty` fields on `SfTabView` and 13 on `SfTabItem` — all are documented in `api-reference.md`.

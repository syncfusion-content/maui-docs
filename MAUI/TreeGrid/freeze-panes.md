# Freeze Panes in .NET MAUI TreeGrid

## Overview

Freezing panes allows you to keep specific columns visible while scrolling horizontally through large datasets, similar to Excel. This is useful when you have identifier columns that should remain visible during navigation.

The .NET MAUI TreeGrid (`SfTreeGrid`) control supports freezing columns independently at the left and right edges of the grid.

---

## Freeze Panes Properties

You can freeze columns by setting the following properties:

| Property Name | Type | Default | Description |
|--------------|------|---------|-------------|
| `FrozenColumnCount` | `int` | `0` | Sets the number of columns to freeze at the left side of the TreeGrid. |
| `FooterFrozenColumnCount` | `int` | `0` | Sets the number of columns to freeze at the right side of the TreeGrid. |

---

# Freeze Columns

You can freeze columns by setting the `FrozenColumnCount` property to a non-negative value. Frozen columns remain visible when scrolling horizontally and are useful for identifier columns that should always be visible.

## Example

### XAML

```xml
<ContentPage.BindingContext>
    <local:EmployeeViewModel />
</ContentPage.BindingContext>

<syncfusion:SfTreeGrid
    x:Name="treeGrid"
    ItemsSource="{Binding Employees}"
    ChildPropertyName="ReportingPeople"
    FrozenColumnCount="1" />
```

### Code Behind (C#)

```csharp
// Freezes the first column.
treeGrid.FrozenColumnCount = 1;
```

<img alt="Tree Grid with Freeze pane UI" src="Images\freeze-panes\maui-treegrid-freezepane-frozencolumn-count.gif" width="404"/>

The frozen column remains visible at the left edge while scrolling horizontally through the remaining columns.

## Limitations

- `FrozenColumnCount` must be less than the total number of columns in the TreeGrid.
- Frozen columns cannot exceed the available grid width on the current platform.
- When `FrozenColumnCount` is set to `0`, no columns are frozen on the left side.

---

# Freeze Footer Columns

You can freeze footer (rightmost) columns by setting the `FooterFrozenColumnCount` property to a non-negative value. Footer frozen columns remain visible when scrolling horizontally and are useful for summary or action columns.

## Example

### XAML

```xml
<ContentPage.BindingContext>
    <local:EmployeeViewModel />
</ContentPage.BindingContext>

<syncfusion:SfTreeGrid
    x:Name="treeGrid"
    ItemsSource="{Binding Employees}"
    ChildPropertyName="ReportingPeople"
    FooterFrozenColumnCount="1" />
```

### Code Behind (C#)

```csharp
// Freezes the last column.
treeGrid.FooterFrozenColumnCount = 1;
```
<img alt="Tree Grid with Freeze pane UI" src="Images\freeze-panes\maui-treegrid-freezepane-footerfrozencolumn-count.gif" width="404"/>

The frozen footer column remains visible at the right edge while scrolling horizontally through the remaining columns.

## Limitations

- `FooterFrozenColumnCount` must be less than the total number of columns in the TreeGrid.
- Footer frozen columns cannot exceed the available grid width on the current platform.
- When `FooterFrozenColumnCount` is set to `0`, no columns are frozen on the right side.
- The combined count of `FrozenColumnCount` and `FooterFrozenColumnCount` must not exceed the total number of columns.

---

# Combining Left and Right Frozen Columns

You can freeze columns on both sides of the TreeGrid by setting both `FrozenColumnCount` and `FooterFrozenColumnCount`.

## Example

```xml
<syncfusion:SfTreeGrid
    x:Name="treeGrid"
    ItemsSource="{Binding Employees}"
    ChildPropertyName="ReportingPeople"
    FrozenColumnCount="1"
    FooterFrozenColumnCount="1" />
```

This configuration freezes the first column on the left side and the last column on the right side, keeping identifier and summary columns visible while scrolling through middle columns.

---

# Appearance

You can customize the visual appearance of freeze panes using `TreeGridStyle`. Apply this style through the `SfTreeGrid.DefaultStyle` property.

## Freeze Pane Line Color

Customize the color of the line that divides frozen and non-frozen regions using the `TreeGridStyle.FreezePaneLineColor` property.

### XAML

```xml
<ContentPage.BindingContext>
    <local:EmployeeViewModel />
</ContentPage.BindingContext>

<syncfusion:SfTreeGrid
    x:Name="treeGrid"
    ItemsSource="{Binding Employees}"
    ChildPropertyName="ReportingPeople"
    FrozenColumnCount="1">

    <syncfusion:SfTreeGrid.DefaultStyle>
        <syncfusion:TreeGridStyle
            FreezePaneLineColor="Orange" />
    </syncfusion:SfTreeGrid.DefaultStyle>

</syncfusion:SfTreeGrid>
```

<img alt="Tree Grid with Freeze pane UI" src="Images\freeze-panes\maui-treegrid-freezepane-linecolor.png" width="404"/>
---

## Freeze Pane Line Thickness

Customize the thickness of the freeze pane line using the `TreeGridStyle.FreezePaneLineStrokeThickness` property. This affects all frozen columns in both left and right regions.

**Default Value:** `1.0`

### XAML

```xml
<ContentPage.BindingContext>
    <local:EmployeeViewModel />
</ContentPage.BindingContext>

<syncfusion:SfTreeGrid
    x:Name="treeGrid"
    ItemsSource="{Binding Employees}"
    ChildPropertyName="ReportingPeople"
    FrozenColumnCount="1">

    <syncfusion:SfTreeGrid.DefaultStyle>
        <syncfusion:TreeGridStyle
            FreezePaneLineStrokeThickness="2" />
    </syncfusion:SfTreeGrid.DefaultStyle>

</syncfusion:SfTreeGrid>
```
<img alt="Tree Grid with Freeze pane UI" src="Images\freeze-panes\maui-treegrid-freezepane-stroke-thickness.png" width="404"/>
---

# Platform Considerations

- **Responsive Design:** Adjust frozen column counts based on available screen space for different device sizes.
- **Cross-platform Behavior:** Freeze pane functionality works consistently across Android, iOS, macOS, and Windows platforms.
- **RTL Support:** Frozen columns are automatically adjusted based on the `FlowDirection` property.

---

# Interaction with Other Features

- Frozen columns work seamlessly with sorting and filtering operations.
- Selection behavior includes frozen columns.
- Expanding and collapsing tree nodes work independently of frozen columns.
- The expand/collapse icon is typically placed in the first column, which can be frozen for better visibility.

---
---
layout: post
title: Accessibility with .NET MAUI Date Picker Control | Syncfusion<sup>&reg;</sup>
description: Learn here about accessibility with Syncfusion<sup>&reg;</sup> .NET MAUI Date Picker (SfDatePicker) control.
platform: maui
control: SfDatePicker
documentation: ug
---

# Accessibility in .NET MAUI Date Picker (SfDatePicker)

The [.NET MAUI Date Picker](https://www.syncfusion.com/maui-controls/maui-datepicker) control has interact with the `Header`, `Column Header`, `Footer`, and `Picker Items`.

## Header Layout

The `SfDatePicker` supports an accessible header through the [Text](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerHeaderView.html#Syncfusion_Maui_Picker_PickerHeaderView_Text) property of `PickerHeaderView`. Localize the text using a `.resx` resource to support different languages.

```xml
<sfDatePicker:SfDatePicker.Header>
    <picker:PickerHeaderView Text="{Binding HeaderText}" />
</sfDatePicker:SfDatePicker.Header>
```

![Header Layout in .NET MAUI Date Picker.](images/accessibility/maui-accessibility-datepicker-header.png)

## Column Header Layout

The `SfDatePicker` exposes accessible column header text through the [DayHeaderText](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.DatePickerColumnHeaderView.html#Syncfusion_Maui_Picker_DatePickerColumnHeaderView_DayHeaderText), [MonthHeaderText](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.DatePickerColumnHeaderView.html#Syncfusion_Maui_Picker_DatePickerColumnHeaderView_MonthHeaderText), and [YearHeaderText](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.DatePickerColumnHeaderView.html#Syncfusion_Maui_Picker_DatePickerColumnHeaderView_YearHeaderText) properties of [DatePickerColumnHeaderView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.DatePickerColumnHeaderView.html). Localize these values to match the user's language.

The default value of the `DayHeaderText` property is "Day", `MonthHeaderText` is "Month", and `YearHeaderText` is "Year".

```xml
<sfDatePicker:SfDatePicker.ColumnHeader>
    <picker:DatePickerColumnHeaderView DayHeaderText="Day"
                                       MonthHeaderText="Month"
                                       YearHeaderText="Year" />
</sfDatePicker:SfDatePicker.ColumnHeader>
```

![Column Header Layout in .NET MAUI Date Picker.](images/accessibility/maui-accessibility-datepicker-columnheader.png)

## Footer Layout

The `SfDatePicker` supports localized OK and Cancel buttons in the footer through the [OkButtonText](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerFooterView.html#Syncfusion_Maui_Picker_PickerFooterView_OkButtonText) and [CancelButtonText](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerFooterView.html#Syncfusion_Maui_Picker_PickerFooterView_CancelButtonText) properties of `PickerFooterView`.

The default value of the `OkButtonText` property is "OK", and `CancelButtonText` is "Cancel".

```xml
<sfDatePicker:SfDatePicker.Footer>
    <picker:PickerFooterView OkButtonText="OK"
                             CancelButtonText="Cancel" />
</sfDatePicker:SfDatePicker.Footer>
```

![Footer Layout in .NET MAUI Date Picker.](images/accessibility/maui-accessibility-datepicker-footer.png)

## Picker Items

The `SfDatePicker` formats picker items using the [DateFormat](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerDateFormat.html) property. The following table shows the supported formats and the resulting display:

<table>
<tr>
<th>Format</th>
<th>Example</th></tr>
<tr>
<td>d, M</td>
<td>1</td>
</tr>
<tr>
<td>dd, MM</td>
<td>01</td>
</tr>
<tr>
<td>MMM</td>
<td>January</td>
</tr>
<tr>
<td>yyyy</td>
<td>2023</td>
</tr>
</table>

```xml
<sfDatePicker:SfDatePicker Format="yyyy-MM-dd" />
```

When the selected value changes, screen readers announce the formatted date, allowing assistive technology users to hear the new value.

![Picker Items in .NET MAUI Date Picker.](images/accessibility/maui-accessibility-datepicker-datepickeritems.png)

## Keyboard Navigation

`SfDatePicker` supports selection using keyboard interactions. Keyboard mappings may vary slightly by platform (Windows, macOS, iOS, Android); the following tables describe the behavior on Windows.

### Focus

<table>
<tr>
<th>Key</th>
<th>Description</th>
</tr>
<tr>
<td>Tab</td>
<td>Focus the picker.</td>
</tr>
<tr>
<td>Enter</td>
<td>Open the focused picker column.</td>
</tr>
<tr>
<td>Esc</td>
<td>Exit and commit the selection.</td>
</tr>
</table>

### Item Selection

<table>
<tr>
<th>Key</th>
<th>Description</th>
</tr>
<tr>
<td>DownArrow</td>
<td>Selects the next item in the focused column.</td>
</tr>
<tr>
<td>UpArrow</td>
<td>Selects the previous item in the focused column.</td>
</tr>
<tr>
<td>RightArrow</td>
<td>Move focus to the next column.</td>
</tr>
<tr>
<td>LeftArrow</td>
<td>Move focus to the previous column.</td>
</tr>
<tr>
<td>Enter (on OK button)</td>
<td>Confirm the current selection.</td>
</tr>
</table>

## Font Scaling and High Contrast

`SfDatePicker` respects the operating system's font scaling settings, so text in the header, column headers, footer, and picker items scales with the user's preferred font size. The control also honors the system high-contrast theme on Windows.

## Troubleshooting

| Issue | Possible Cause | Resolution |
|-------|---------------|------------|
| Screen reader does not announce the picker | Missing `AutomationProperties.Name` | Set `AutomationProperties.Name` on the picker and its header. |
| Tab moves focus away from the picker | Picker is not the focusable root | Wrap the picker in a focusable container or set `IsTabStop="True"`. |
| Localized text is not picked up | Resources not registered | Register the `.resx` file with `IServiceProvider` and set the current `CultureInfo`. |

## See Also

- [Getting Started with .NET MAUI Date Picker](getting-started.md)
- [Localization in .NET MAUI Date Picker](localization.md)
- [Formatting in .NET MAUI Date Picker](formatting.md)
- [.NET MAUI Accessibility Documentation](https://learn.microsoft.com/en-us/dotnet/maui/fundamentals/accessibility)

---
layout: post
title: Properties of .NET MAUI Numeric Entry control | Syncfusion®
description: This section explains the properties, events, and methods with Syncfusion® MAUI Numeric Entry (SfNumericEntry) control.
platform: MAUI
control: SfNumericEntry
documentation: ug
---

# API Reference for .NET MAUI Numeric Entry

## Properties

<table>
    <tr>
        <th>Name</th>
        <th>Type</th>
        <th>Description</th>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfNumericEntry.html#Syncfusion_Maui_Inputs_SfNumericEntry_AllowNull" aria-label="View AllowNull property in API reference">AllowNull</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
        <td>Allows the <code>Numeric Entry</code> to hold <code>null</code> after its input is cleared. When disabled, clearing restores <code>0</code>, or <code>Minimum</code> when the minimum is greater than zero.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfNumericEntry.html#Syncfusion_Maui_Inputs_SfNumericEntry_AutoReverse" aria-label="View AutoReverse property in API reference">AutoReverse</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
        <td>Wraps incrementing from <code>Maximum</code> to <code>Minimum</code> and decrementing from <code>Minimum</code> to <code>Maximum</code>. Applies to changes made with the <code>spin buttons</code>, supported keys, or <code>mouse wheel</code>.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfNumericEntry.html#Syncfusion_Maui_Inputs_SfNumericEntry_ClearButtonColor" aria-label="View ClearButtonColor property in API reference">ClearButtonColor</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.graphics.color" aria-label="View Color type in API reference">Color</a></td>
        <td>Controls the <code>color</code> of the clear button shown when <code>ShowClearButton</code> is enabled.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfNumericEntry.html#Syncfusion_Maui_Inputs_SfNumericEntry_ClearButtonPath" aria-label="View ClearButtonPath property in API reference">ClearButtonPath</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.shapes.path" aria-label="View Path type in API reference">Path</a></td>
        <td>Replaces the default clear-button icon with a custom <code>Path</code>.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfNumericEntry.html#Syncfusion_Maui_Inputs_SfNumericEntry_Culture" aria-label="View Culture property in API reference">Culture</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.globalization.cultureinfo" aria-label="View CultureInfo type in API reference">CultureInfo</a></td>
        <td>Controls how the value is <code>parsed</code> and <code>formatted</code>, including its decimal separator, group separator, currency symbol, and percent symbol.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfNumericEntry.html#Syncfusion_Maui_Inputs_SfNumericEntry_CursorPosition" aria-label="View CursorPosition property in API reference">CursorPosition</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.int32" aria-label="View Int32 type in API reference">int</a></td>
        <td>Controls the insertion cursor's zero-based position within the editable numeric text.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfNumericEntry.html#Syncfusion_Maui_Inputs_SfNumericEntry_CustomFormat" aria-label="View CustomFormat property in API reference">CustomFormat</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.string" aria-label="View String type in API reference">string</a></td>
        <td>Formats the displayed value with a standard or custom <code>.NET</code> numeric format string, such as <code>C2</code>, <code>P2</code>, <code>N2</code>, or <code>#,0.00</code>.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfNumericEntry.html#Syncfusion_Maui_Inputs_SfNumericEntry_DownButtonTemplate" aria-label="View DownButtonTemplate property in API reference">DownButtonTemplate</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.datatemplate" aria-label="View DataTemplate type in API reference">DataTemplate</a></td>
        <td>Defines the <code>content</code> and <code>appearance</code> of the <code>decrement button</code> when the <code>up-down buttons</code> are visible.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfNumericEntry.html#Syncfusion_Maui_Inputs_SfNumericEntry_Font" aria-label="View Font property in API reference">Font</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.font" aria-label="View Font type in API reference">Font</a></td>
        <td>Provides the effective <code>font</code> assembled from the <code>Numeric Entry</code>'s font family, size, and attributes. This property is read-only.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfNumericEntry.html#Syncfusion_Maui_Inputs_SfNumericEntry_FontAttributes" aria-label="View FontAttributes property in API reference">FontAttributes</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.fontattributes" aria-label="View FontAttributes type in API reference">FontAttributes</a></td>
        <td>Applies <code>None</code>, <code>Bold</code>, or <code>Italic</code> styling to the displayed numeric text.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfNumericEntry.html#Syncfusion_Maui_Inputs_SfNumericEntry_FontAutoScalingEnabled" aria-label="View FontAutoScalingEnabled property in API reference">FontAutoScalingEnabled</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
        <td>Allows the displayed text to follow the user's operating-system text-size preference.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfNumericEntry.html#Syncfusion_Maui_Inputs_SfNumericEntry_FontFamily" aria-label="View FontFamily property in API reference">FontFamily</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.string" aria-label="View String type in API reference">string</a></td>
        <td>Controls the <code>font family</code> used for the displayed numeric text.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfNumericEntry.html#Syncfusion_Maui_Inputs_SfNumericEntry_FontSize" aria-label="View FontSize property in API reference">FontSize</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
        <td>Controls the <code>font size</code> of the displayed numeric text.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfNumericEntry.html#Syncfusion_Maui_Inputs_SfNumericEntry_HorizontalTextAlignment" aria-label="View HorizontalTextAlignment property in API reference">HorizontalTextAlignment</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.textalignment" aria-label="View TextAlignment type in API reference">TextAlignment</a></td>
        <td>Aligns the numeric text horizontally at the <code>Start</code>, <code>Center</code>, or <code>End</code> of the input field.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfNumericEntry.html#Syncfusion_Maui_Inputs_SfNumericEntry_IsEditable" aria-label="View IsEditable property in API reference">IsEditable</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
        <td>Prevents direct text editing while still allowing the value to change through visible <code>spin buttons</code>, <code>arrow keys</code>, <code>Page Up</code> and <code>Page Down</code>, and the <code>mouse wheel</code>.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfNumericEntry.html#Syncfusion_Maui_Inputs_SfNumericEntry_LargeChange" aria-label="View LargeChange property in API reference">LargeChange</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
        <td>Controls the amount added or subtracted when the user presses <code>Page Up</code> or <code>Page Down</code>.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfNumericEntry.html#Syncfusion_Maui_Inputs_SfNumericEntry_Maximum" aria-label="View Maximum property in API reference">Maximum</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
        <td>Defines the largest accepted value. User-entered values outside the configured range are rejected and the previous value remains unchanged.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfNumericEntry.html#Syncfusion_Maui_Inputs_SfNumericEntry_MaximumNumberDecimalDigits" aria-label="View MaximumNumberDecimalDigits property in API reference">MaximumNumberDecimalDigits</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.int32" aria-label="View Int32 type in API reference">int</a></td>
        <td>Limits the number of displayed fractional digits when <code>CustomFormat</code> is not set. The setting must be a positive integer and is ignored when a custom format is applied.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfNumericEntry.html#Syncfusion_Maui_Inputs_SfNumericEntry_Minimum" aria-label="View Minimum property in API reference">Minimum</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
        <td>Defines the smallest accepted value. User-entered values outside the configured range are rejected and the previous value remains unchanged.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfNumericEntry.html#Syncfusion_Maui_Inputs_SfNumericEntry_PercentDisplayMode" aria-label="View PercentDisplayMode property in API reference">PercentDisplayMode</a></td>
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.PercentDisplayMode.html" aria-label="View PercentDisplayMode enum in API reference">PercentDisplayMode</a></td>
        <td>Controls percentage formatting when <code>CustomFormat</code> uses <code>P</code> or <code>p</code>: <code>Compute</code> multiplies the stored value by 100 for display, while <code>Value</code> displays the stored value directly with a percent symbol.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfNumericEntry.html#Syncfusion_Maui_Inputs_SfNumericEntry_Placeholder" aria-label="View Placeholder property in API reference">Placeholder</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.string" aria-label="View String type in API reference">string</a></td>
        <td>Displays supporting text when <code>Value</code> is <code>null</code> or <code>NaN</code>, or after the user clears the input while <code>AllowNull</code> is enabled.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfNumericEntry.html#Syncfusion_Maui_Inputs_SfNumericEntry_PlaceholderColor" aria-label="View PlaceholderColor property in API reference">PlaceholderColor</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.graphics.color" aria-label="View Color type in API reference">Color</a></td>
        <td>Controls the <code>color</code> of the placeholder shown when the <code>Numeric Entry</code> has no numeric value.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfNumericEntry.html#Syncfusion_Maui_Inputs_SfNumericEntry_ReturnCommand" aria-label="View ReturnCommand property in API reference">ReturnCommand</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.windows.input.icommand" aria-label="View ICommand type in API reference">ICommand</a></td>
        <td>Runs when the user presses the physical or software keyboard's <code>Return</code> key.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfNumericEntry.html#Syncfusion_Maui_Inputs_SfNumericEntry_ReturnCommandParameter" aria-label="View ReturnCommandParameter property in API reference">ReturnCommandParameter</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.object" aria-label="View Object type in API reference">object</a></td>
        <td>Supplies the value passed to <code>ReturnCommand</code> when <code>Return</code> is pressed.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfNumericEntry.html#Syncfusion_Maui_Inputs_SfNumericEntry_ReturnType" aria-label="View ReturnType property in API reference">ReturnType</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.returntype" aria-label="View ReturnType type in API reference">ReturnType</a></td>
        <td>Changes the action label or icon on the software keyboard's <code>Return</code> key. Supported values are <code>Default</code>, <code>Done</code>, <code>Go</code>, <code>Next</code>, <code>Search</code>, and <code>Send</code>.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfNumericEntry.html#Syncfusion_Maui_Inputs_SfNumericEntry_SelectAllOnFocus" aria-label="View SelectAllOnFocus property in API reference">SelectAllOnFocus</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
        <td>Selects all displayed numeric text when the control receives focus, making the complete value ready to be replaced.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfNumericEntry.html#Syncfusion_Maui_Inputs_SfNumericEntry_SelectionLength" aria-label="View SelectionLength property in API reference">SelectionLength</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.int32" aria-label="View Int32 type in API reference">int</a></td>
        <td>Controls how many characters are selected starting from <code>CursorPosition</code>.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfNumericEntry.html#Syncfusion_Maui_Inputs_SfNumericEntry_ShowBorder" aria-label="View ShowBorder property in API reference">ShowBorder</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
        <td>Shows or hides the border around the <code>Numeric Entry</code>.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfNumericEntry.html#Syncfusion_Maui_Inputs_SfNumericEntry_ShowClearButton" aria-label="View ShowClearButton property in API reference">ShowClearButton</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
        <td>Shows or hides the button that clears the current input. Clearing produces <code>null</code> only when <code>AllowNull</code> is enabled; otherwise, the control restores an allowed numeric value.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfNumericEntry.html#Syncfusion_Maui_Inputs_SfNumericEntry_SmallChange" aria-label="View SmallChange property in API reference">SmallChange</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
        <td>Controls the amount added or subtracted by the <code>spin buttons</code>, <code>arrow keys</code>, or <code>mouse wheel</code>.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfNumericEntry.html#Syncfusion_Maui_Inputs_SfNumericEntry_Stroke" aria-label="View Stroke property in API reference">Stroke</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.brush" aria-label="View Brush type in API reference">Brush</a></td>
        <td>Controls the border <code>brush</code> when <code>ShowBorder</code> is enabled.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfNumericEntry.html#Syncfusion_Maui_Inputs_SfNumericEntry_TextColor" aria-label="View TextColor property in API reference">TextColor</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.graphics.color" aria-label="View Color type in API reference">Color</a></td>
        <td>Controls the <code>color</code> of the displayed numeric text.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfNumericEntry.html#Syncfusion_Maui_Inputs_SfNumericEntry_UpButtonTemplate" aria-label="View UpButtonTemplate property in API reference">UpButtonTemplate</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.datatemplate" aria-label="View DataTemplate type in API reference">DataTemplate</a></td>
        <td>Defines the <code>content</code> and <code>appearance</code> of the <code>increment button</code> when the <code>up-down buttons</code> are visible.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfNumericEntry.html#Syncfusion_Maui_Inputs_SfNumericEntry_UpDownButtonAlignment" aria-label="View UpDownButtonAlignment property in API reference">UpDownButtonAlignment</a></td>
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.UpDownButtonAlignment.html" aria-label="View UpDownButtonAlignment enum in API reference">UpDownButtonAlignment</a></td>
        <td>Positions both <code>spin buttons</code> on the <code>Left</code> or <code>Right</code>, or places them at opposite ends with <code>Both</code>.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfNumericEntry.html#Syncfusion_Maui_Inputs_SfNumericEntry_UpDownButtonColor" aria-label="View UpDownButtonColor property in API reference">UpDownButtonColor</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.graphics.color" aria-label="View Color type in API reference">Color</a></td>
        <td>Controls the <code>color</code> of the default <code>increment</code> and <code>decrement</code> icons. Custom button templates can define their own colors.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfNumericEntry.html#Syncfusion_Maui_Inputs_SfNumericEntry_UpDownOrder" aria-label="View UpDownOrder property in API reference">UpDownOrder</a></td>
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.UpDownOrder.html" aria-label="View UpDownOrder enum in API reference">UpDownOrder</a></td>
        <td>Arranges the <code>increment button</code> before the <code>decrement button</code> with <code>UpThenDown</code>, or reverses them with <code>DownThenUp</code>.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfNumericEntry.html#Syncfusion_Maui_Inputs_SfNumericEntry_UpDownPlacementMode" aria-label="View UpDownPlacementMode property in API reference">UpDownPlacementMode</a></td>
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.UpDownPlacementMode.html" aria-label="View UpDownPlacementMode enum in API reference">UpDownPlacementMode</a></td>
        <td>Hides the <code>spin buttons</code> with <code>Hidden</code>, displays them horizontally with <code>Inline</code>, or stacks them vertically with <code>InlineVertical</code>.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfNumericEntry.html#Syncfusion_Maui_Inputs_SfNumericEntry_Value" aria-label="View Value property in API reference">Value</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.nullable-1" aria-label="View Nullable type in API reference">double?</a></td>
        <td>Contains the <code>nullable</code> numeric value displayed and edited by the control. Changes trigger <code>ValueChanged</code> after the value is evaluated.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfNumericEntry.html#Syncfusion_Maui_Inputs_SfNumericEntry_ValueChangeMode" aria-label="View ValueChangeMode property in API reference">ValueChangeMode</a></td>
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.ValueChangeMode.html" aria-label="View ValueChangeMode enum in API reference">ValueChangeMode</a></td>
        <td>Updates <code>Value</code> while the user types with <code>OnKeyFocus</code>, or waits until the control loses focus with <code>OnLostFocus</code>. Spin-button and other committed changes can update the value independently.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfNumericEntry.html#Syncfusion_Maui_Inputs_SfNumericEntry_VerticalTextAlignment" aria-label="View VerticalTextAlignment property in API reference">VerticalTextAlignment</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.textalignment" aria-label="View TextAlignment type in API reference">TextAlignment</a></td>
        <td>Aligns the numeric text vertically at the <code>Start</code>, <code>Center</code>, or <code>End</code> of the input field.</td>
    </tr>
</table>

## Methods

<table>
    <tr>
        <th>Name</th>
        <th>Type</th>
        <th>Description</th>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfNumericEntry.html#Syncfusion_Maui_Inputs_SfNumericEntry_Focus" aria-label="View Focus method in API reference">Focus()</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.void" aria-label="View Void type in API reference">void</a></td>
        <td>Moves keyboard focus to the <code>Numeric Entry</code> and opens the applicable <code>software keyboard</code> when direct editing is available. If the control cannot receive focus, its state remains unchanged.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfNumericEntry.html#Syncfusion_Maui_Inputs_SfNumericEntry_Unfocus" aria-label="View Unfocus method in API reference">Unfocus()</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.void" aria-label="View Void type in API reference">void</a></td>
        <td>Removes keyboard focus from the <code>Numeric Entry</code> and commits pending text when <code>ValueChangeMode</code> is <code>OnLostFocus</code>.</td>
    </tr>
</table>

## Events

<table>
    <tr>
        <th>Name</th>
        <th>Type</th>
        <th>Description</th>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfNumericEntry.html#Syncfusion_Maui_Inputs_SfNumericEntry_ClearButtonClicked" aria-label="View ClearButtonClicked event in API reference">ClearButtonClicked</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler type in API reference">EventHandler</a></td>
        <td>Triggered when the user activates the clear button after the <code>Numeric Entry</code> processes the clear action.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfNumericEntry.html#Syncfusion_Maui_Inputs_SfNumericEntry_Completed" aria-label="View Completed event in API reference">Completed</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler type in API reference">EventHandler</a></td>
        <td>Triggered when the user presses the physical or software keyboard's <code>Return</code> key to finish entering a value.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfNumericEntry.html#Syncfusion_Maui_Inputs_SfNumericEntry_Focused" aria-label="View Focused event in API reference">Focused</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler type in API reference">EventHandler&lt;<a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.focuseventargs" aria-label="View FocusEventArgs type in API reference">FocusEventArgs&gt;</a></a></td>
        <td>Triggered when the <code>Numeric Entry</code> receives keyboard focus.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfNumericEntry.html#Syncfusion_Maui_Inputs_SfNumericEntry_Unfocused" aria-label="View Unfocused event in API reference">Unfocused</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler type in API reference">EventHandler&lt;<a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.focuseventargs" aria-label="View FocusEventArgs type in API reference">FocusEventArgs&gt;</a></a></td>
        <td>Triggered when the <code>Numeric Entry</code> loses keyboard focus, after any applicable focus-loss value evaluation.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfNumericEntry.html#Syncfusion_Maui_Inputs_SfNumericEntry_ValueChanged" aria-label="View ValueChanged event in API reference">ValueChanged</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.NumericEntryValueChangedEventArgs.html" aria-label="View NumericEntryValueChangedEventArgs type in API reference">NumericEntryValueChangedEventArgs&gt;</a></a></td>
        <td>Triggered after the numeric value changes and provides the previous and new values. User input is evaluated according to <code>ValueChangeMode</code>; <code>Enter</code>, <code>spin-button</code> actions, and <code>focus changes</code> can also commit a value.</td>
    </tr>
</table>
---
layout: post
title: Properties of .NET MAUI Masked Entry control | Syncfusion®
description: This section explains the properties, events, and methods with Syncfusion® MAUI Masked Entry (SfMaskedEntry) control.
platform: MAUI
control: SfMaskedEntry
documentation: ug
---

# API Reference for .NET MAUI Masked Entry

## Properties

<table>
    <tr>
        <th>Name</th>
        <th>Type</th>
        <th>Description</th>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfMaskedEntry.html#Syncfusion_Maui_Inputs_SfMaskedEntry_ClearButtonColor" aria-label="View ClearButtonColor property in API reference">ClearButtonColor</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.graphics.color" aria-label="View Color type in API reference">Color</a></td>
        <td>Controls the <code>color</code> of the clear button shown by <code>ClearButtonVisibility</code>.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfMaskedEntry.html#Syncfusion_Maui_Inputs_SfMaskedEntry_ClearButtonPath" aria-label="View ClearButtonPath property in API reference">ClearButtonPath</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.shapes.path" aria-label="View Path type in API reference">Path</a></td>
        <td>Replaces the default clear-button icon with a custom <code>Path</code>.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfMaskedEntry.html#Syncfusion_Maui_Inputs_SfMaskedEntry_ClearButtonVisibility" aria-label="View ClearButtonVisibility property in API reference">ClearButtonVisibility</a></td>
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.ClearButtonVisibility.html" aria-label="View ClearButtonVisibility enum in API reference">ClearButtonVisibility</a></td>
        <td>Shows the clear button with <code>WhileEditing</code> or keeps it hidden with <code>Never</code>. Activating the button clears the current input.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfMaskedEntry.html#Syncfusion_Maui_Inputs_SfMaskedEntry_Culture" aria-label="View Culture property in API reference">Culture</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.globalization.cultureinfo" aria-label="View CultureInfo type in API reference">CultureInfo</a></td>
        <td>Supplies the <code>culture</code> used when the mask interprets culture-sensitive characters and formats the input.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfMaskedEntry.html#Syncfusion_Maui_Inputs_SfMaskedEntry_CursorPosition" aria-label="View CursorPosition property in API reference">CursorPosition</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.int32" aria-label="View Int32 type in API reference">int</a></td>
        <td>Controls the insertion cursor's zero-based position within the displayed masked text.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfMaskedEntry.html#Syncfusion_Maui_Inputs_SfMaskedEntry_Font" aria-label="View Font property in API reference">Font</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.font" aria-label="View Font type in API reference">Font</a></td>
        <td>Provides the effective <code>font</code> assembled from the <code>Masked Entry</code>'s font family, size, and attributes. This property is read-only.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfMaskedEntry.html#Syncfusion_Maui_Inputs_SfMaskedEntry_FontAttributes" aria-label="View FontAttributes property in API reference">FontAttributes</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.fontattributes" aria-label="View FontAttributes type in API reference">FontAttributes</a></td>
        <td>Applies <code>None</code>, <code>Bold</code>, or <code>Italic</code> styling to the displayed masked text.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfMaskedEntry.html#Syncfusion_Maui_Inputs_SfMaskedEntry_FontAutoScalingEnabled" aria-label="View FontAutoScalingEnabled property in API reference">FontAutoScalingEnabled</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
        <td>Allows the displayed text to follow the user's operating-system text-size preference.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfMaskedEntry.html#Syncfusion_Maui_Inputs_SfMaskedEntry_FontFamily" aria-label="View FontFamily property in API reference">FontFamily</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.string" aria-label="View String type in API reference">string</a></td>
        <td>Controls the <code>font family</code> used for the displayed masked text.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfMaskedEntry.html#Syncfusion_Maui_Inputs_SfMaskedEntry_FontSize" aria-label="View FontSize property in API reference">FontSize</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
        <td>Controls the <code>font size</code> of the displayed masked text.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfMaskedEntry.html#Syncfusion_Maui_Inputs_SfMaskedEntry_HasError" aria-label="View HasError property in API reference">HasError</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
        <td>Reports the result of the most recent mask <code>validation</code>: true when the input is invalid and false when it satisfies the mask. The value is read-only and is updated after <code>ValueChanged</code>.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfMaskedEntry.html#Syncfusion_Maui_Inputs_SfMaskedEntry_HidePromptOnLeave" aria-label="View HidePromptOnLeave property in API reference">HidePromptOnLeave</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
        <td>Hides unfilled <code>prompt characters</code> when the <code>Masked Entry</code> loses focus and displays them again when editing resumes.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfMaskedEntry.html#Syncfusion_Maui_Inputs_SfMaskedEntry_HorizontalTextAlignment" aria-label="View HorizontalTextAlignment property in API reference">HorizontalTextAlignment</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.textalignment" aria-label="View TextAlignment type in API reference">TextAlignment</a></td>
        <td>Aligns the masked text horizontally at the <code>Start</code>, <code>Center</code>, or <code>End</code> of the input field.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfMaskedEntry.html#Syncfusion_Maui_Inputs_SfMaskedEntry_IsReadOnly" aria-label="View IsReadOnly property in API reference">IsReadOnly</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
        <td>Prevents typing, cutting, pasting, and other user edits while keeping the masked value <code>focusable</code>, <code>selectable</code>, and available for copying.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfMaskedEntry.html#Syncfusion_Maui_Inputs_SfMaskedEntry_Keyboard" aria-label="View Keyboard property in API reference">Keyboard</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.keyboard" aria-label="View Keyboard type in API reference">Keyboard</a></td>
        <td>Selects the <code>software keyboard</code> presented for input, such as the default, numeric, telephone, email, or URL keyboard. The keyboard does not replace <code>validation</code> performed by the mask.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfMaskedEntry.html#Syncfusion_Maui_Inputs_SfMaskedEntry_Mask" aria-label="View Mask property in API reference">Mask</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.string" aria-label="View String type in API reference">string</a></td>
        <td>Defines the <code>input pattern</code> that accepted characters must follow. Its syntax is interpreted according to <code>MaskType</code>.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfMaskedEntry.html#Syncfusion_Maui_Inputs_SfMaskedEntry_MaskType" aria-label="View MaskType property in API reference">MaskType</a></td>
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.MaskedEntryMaskType.html" aria-label="View MaskedEntryMaskType enum in API reference">MaskedEntryMaskType</a></td>
        <td>Uses <code>Simple</code> for a fixed-format mask composed of mask symbols and literals, or <code>RegEx</code> for a <code>regular-expression</code> pattern.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfMaskedEntry.html#Syncfusion_Maui_Inputs_SfMaskedEntry_PasswordChar" aria-label="View PasswordChar property in API reference">PasswordChar</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.char" aria-label="View Char type in API reference">char</a></td>
        <td>Replaces entered characters with the specified <code>masking character</code>. When no password character is configured, the entered characters remain visible.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfMaskedEntry.html#Syncfusion_Maui_Inputs_SfMaskedEntry_PasswordDelayDuration" aria-label="View PasswordDelayDuration property in API reference">PasswordDelayDuration</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.int32" aria-label="View Int32 type in API reference">int</a></td>
        <td>Controls how long the most recently entered character remains visible before it is replaced by <code>PasswordChar</code>, in <code>milliseconds</code>.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfMaskedEntry.html#Syncfusion_Maui_Inputs_SfMaskedEntry_Placeholder" aria-label="View Placeholder property in API reference">Placeholder</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.string" aria-label="View String type in API reference">string</a></td>
        <td>Displays supporting text only when both the mask and value are empty; <code>mask prompts</code> take precedence once a mask is displayed.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfMaskedEntry.html#Syncfusion_Maui_Inputs_SfMaskedEntry_PlaceholderColor" aria-label="View PlaceholderColor property in API reference">PlaceholderColor</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.graphics.color" aria-label="View Color type in API reference">Color</a></td>
        <td>Controls the <code>color</code> of the placeholder shown when both the mask and value are empty.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfMaskedEntry.html#Syncfusion_Maui_Inputs_SfMaskedEntry_PromptChar" aria-label="View PromptChar property in API reference">PromptChar</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.char" aria-label="View Char type in API reference">char</a></td>
        <td>Specifies the character displayed for each unfilled editable position in a <code>Simple</code> mask.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfMaskedEntry.html#Syncfusion_Maui_Inputs_SfMaskedEntry_ReturnCommand" aria-label="View ReturnCommand property in API reference">ReturnCommand</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.windows.input.icommand" aria-label="View ICommand type in API reference">ICommand</a></td>
        <td>Runs when the user presses the physical or software keyboard's <code>Return</code> key.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfMaskedEntry.html#Syncfusion_Maui_Inputs_SfMaskedEntry_ReturnCommandParameter" aria-label="View ReturnCommandParameter property in API reference">ReturnCommandParameter</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.object" aria-label="View Object type in API reference">object</a></td>
        <td>Supplies the value passed to <code>ReturnCommand</code> when <code>Return</code> is pressed.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfMaskedEntry.html#Syncfusion_Maui_Inputs_SfMaskedEntry_ReturnType" aria-label="View ReturnType property in API reference">ReturnType</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.returntype" aria-label="View ReturnType type in API reference">ReturnType</a></td>
        <td>Changes the action label or icon on the software keyboard's <code>Return</code> key. Supported values are <code>Default</code>, <code>Done</code>, <code>Go</code>, <code>Next</code>, <code>Search</code>, and <code>Send</code>.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfMaskedEntry.html#Syncfusion_Maui_Inputs_SfMaskedEntry_SelectAllOnFocus" aria-label="View SelectAllOnFocus property in API reference">SelectAllOnFocus</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
        <td>Selects all displayed text when the <code>Masked Entry</code> receives focus, making the complete value ready to be replaced.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfMaskedEntry.html#Syncfusion_Maui_Inputs_SfMaskedEntry_ShowBorder" aria-label="View ShowBorder property in API reference">ShowBorder</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
        <td>Shows or hides the border around the <code>Masked Entry</code>.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfMaskedEntry.html#Syncfusion_Maui_Inputs_SfMaskedEntry_Stroke" aria-label="View Stroke property in API reference">Stroke</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.brush" aria-label="View Brush type in API reference">Brush</a></td>
        <td>Controls the border <code>brush</code> when <code>ShowBorder</code> is enabled.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfMaskedEntry.html#Syncfusion_Maui_Inputs_SfMaskedEntry_Text" aria-label="View Text property in API reference">Text</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.string" aria-label="View String type in API reference">string</a></td>
        <td>Provides the read-only text currently displayed by the control, including mask <code>formatting</code>, <code>literals</code>, and visible prompt characters. Use <code>Value</code> to supply or retrieve the input value.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfMaskedEntry.html#Syncfusion_Maui_Inputs_SfMaskedEntry_TextColor" aria-label="View TextColor property in API reference">TextColor</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.graphics.color" aria-label="View Color type in API reference">Color</a></td>
        <td>Controls the <code>color</code> of the displayed masked text.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfMaskedEntry.html#Syncfusion_Maui_Inputs_SfMaskedEntry_ValidationMode" aria-label="View ValidationMode property in API reference">ValidationMode</a></td>
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.InputValidationMode.html" aria-label="View InputValidationMode enum in API reference">InputValidationMode</a></td>
        <td>Validates the value after every key press with <code>KeyPress</code> or when the control loses focus with <code>LostFocus</code>. Both modes apply to <code>Simple</code> and <code>RegEx</code> masks.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfMaskedEntry.html#Syncfusion_Maui_Inputs_SfMaskedEntry_Value" aria-label="View Value property in API reference">Value</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.object" aria-label="View Object type in API reference">object</a></td>
        <td>Contains the <code>Masked Entry</code>'s input value and can be assigned to populate the control programmatically. Its treatment of prompt characters and literals is controlled by <code>ValueMaskFormat</code> for a <code>Simple</code> mask.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfMaskedEntry.html#Syncfusion_Maui_Inputs_SfMaskedEntry_ValueMaskFormat" aria-label="View ValueMaskFormat property in API reference">ValueMaskFormat</a></td>
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.MaskedEntryMaskFormat.html" aria-label="View MaskedEntryMaskFormat enum in API reference">MaskedEntryMaskFormat</a></td>
        <td>Controls which mask characters are included in <code>Value</code>: <code>ExcludePromptAndLiterals</code> keeps only entered characters, <code>IncludePrompt</code> also keeps prompts, <code>IncludeLiterals</code> also keeps literals, and <code>IncludePromptAndLiterals</code> keeps both. Applies only when <code>MaskType</code> is <code>Simple</code>.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfMaskedEntry.html#Syncfusion_Maui_Inputs_SfMaskedEntry_VerticalTextAlignment" aria-label="View VerticalTextAlignment property in API reference">VerticalTextAlignment</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.textalignment" aria-label="View TextAlignment type in API reference">TextAlignment</a></td>
        <td>Aligns the masked text vertically at the <code>Start</code>, <code>Center</code>, or <code>End</code> of the input field.</td>
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
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfMaskedEntry.html#Syncfusion_Maui_Inputs_SfMaskedEntry_Focus" aria-label="View Focus method in API reference">Focus()</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.void" aria-label="View Void type in API reference">void</a></td>
        <td>Moves keyboard focus to the <code>Masked Entry</code> and opens the applicable <code>software keyboard</code>. If the control cannot receive focus, its focus state remains unchanged.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfMaskedEntry.html#Syncfusion_Maui_Inputs_SfMaskedEntry_Unfocus" aria-label="View Unfocus method in API reference">Unfocus()</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.void" aria-label="View Void type in API reference">void</a></td>
        <td>Removes keyboard focus from the <code>Masked Entry</code>, which can initiate <code>LostFocus</code> validation and hide prompt characters when configured.</td>
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
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfMaskedEntry.html#Syncfusion_Maui_Inputs_SfMaskedEntry_ClearButtonClicked" aria-label="View ClearButtonClicked event in API reference">ClearButtonClicked</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler type in API reference">EventHandler</a></td>
        <td>Triggered when the user activates the clear button after it clears the <code>Masked Entry</code>'s input.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfMaskedEntry.html#Syncfusion_Maui_Inputs_SfMaskedEntry_Completed" aria-label="View Completed event in API reference">Completed</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler type in API reference">EventHandler</a></td>
        <td>Triggered when the user presses the physical or software keyboard's <code>Return</code> key to finish entering a value.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfMaskedEntry.html#Syncfusion_Maui_Inputs_SfMaskedEntry_ValueChanged" aria-label="View ValueChanged event in API reference">ValueChanged</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.MaskedEntryValueChangedEventArgs.html" aria-label="View MaskedEntryValueChangedEventArgs type in API reference">MaskedEntryValueChangedEventArgs&gt;</a></a></td>
        <td>Triggered after the <code>Masked Entry</code>'s value changes and provides the previous value, new value, and whether all required mask positions are filled.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfMaskedEntry.html#Syncfusion_Maui_Inputs_SfMaskedEntry_ValueChanging" aria-label="View ValueChanging event in API reference">ValueChanging</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.MaskedEntryValueChangingEventArgs.html" aria-label="View MaskedEntryValueChangingEventArgs type in API reference">MaskedEntryValueChangingEventArgs&gt;</a></a></td>
        <td>Triggered before the value changes and provides the previous and proposed values. The pending change can be canceled, and its validation result can be supplied through <code>IsValid</code>.</td>
    </tr>
</table>

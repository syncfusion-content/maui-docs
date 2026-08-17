---
layout: post
title: Properties of .NET MAUI Text Input Layout control | Syncfusion®
description: This section explains the properties, events and methods with Syncfusion® MAUI Text Input Layout (SfTextInputLayout) control.
platform: maui
control: SfTextInputLayout
documentation: ug
---

# .NET MAUI Text Input Layout API Reference

## Properties

<table>
<tr>
<th>Name</th>
<th>Type</th>
<th>Description</th>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfTextInputLayout.html#Syncfusion_Maui_Core_SfTextInputLayout_CharMaxLength" aria-label="View CharMaxLength property in API reference">CharMaxLength</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.int32" aria-label="View Int32 type in API reference">int</a></td>
<td>Defines the maximum number of characters allowed in the embedded input view and helps constrain text entry to a fixed length.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfTextInputLayout.html#Syncfusion_Maui_Core_SfTextInputLayout_ContainerBackground" aria-label="View ContainerBackground property in API reference">ContainerBackground</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.brush" aria-label="View Brush type in API reference">Brush</a></td>
<td>Defines the background brush of the text input container and controls how the control blends with the surrounding surface.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfTextInputLayout.html#Syncfusion_Maui_Core_SfTextInputLayout_ContainerType" aria-label="View ContainerType property in API reference">ContainerType</a></td>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.ContainerType.html" aria-label="View ContainerType enum in API reference">ContainerType</a></td>
<td>Defines the visual container style of the text input layout by using the <code>ContainerType</code> enum to control the shape and presentation of the input surface.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfTextInputLayout.html#Syncfusion_Maui_Core_SfTextInputLayout_CurrentActiveColor" aria-label="View CurrentActiveColor property in API reference">CurrentActiveColor</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.graphics.color" aria-label="View Color type in API reference">Color</a></td>
<td>Defines the active accent color applied to focused states, highlighted borders, and other interactive visual cues.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfTextInputLayout.html#Syncfusion_Maui_Core_SfTextInputLayout_EnableFloating" aria-label="View EnableFloating property in API reference">EnableFloating</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
<td>Determines whether the <code>hint</code> moves above the input view when the control is focused or when text is present, keeping the label visible during editing.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfTextInputLayout.html#Syncfusion_Maui_Core_SfTextInputLayout_EnableHintAnimation" aria-label="View EnableHintAnimation property in API reference">EnableHintAnimation</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
<td>Determines whether the <code>hint</code> transition uses animation when it changes position or visibility.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfTextInputLayout.html#Syncfusion_Maui_Core_SfTextInputLayout_EnablePasswordVisibilityToggle" aria-label="View EnablePasswordVisibilityToggle property in API reference">EnablePasswordVisibilityToggle</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
<td>Determines whether a <code>password visibility toggle</code> icon is displayed to allow secure text entry to be shown or hidden.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfTextInputLayout.html#Syncfusion_Maui_Core_SfTextInputLayout_ErrorLabelStyle" aria-label="View ErrorLabelStyle property in API reference">ErrorLabelStyle</a></td>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.LabelStyle.html" aria-label="View LabelStyle type in API reference">LabelStyle</a></td>
<td>Defines the visual styling used for the <code>error text</code>, including font, color, spacing, and other label appearance settings.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfTextInputLayout.html#Syncfusion_Maui_Core_SfTextInputLayout_ErrorText" aria-label="View ErrorText property in API reference">ErrorText</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.string" aria-label="View String type in API reference">string</a></td>
<td>Defines the <code>error message</code> shown below the input view when validation fails or the control enters an error state.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfTextInputLayout.html#Syncfusion_Maui_Core_SfTextInputLayout_FocusedStrokeThickness" aria-label="View FocusedStrokeThickness property in API reference">FocusedStrokeThickness</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
<td>Defines the border thickness used when the control is focused and the active visual state is applied.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfTextInputLayout.html#Syncfusion_Maui_Core_SfTextInputLayout_HasError" aria-label="View HasError property in API reference">HasError</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
<td>Determines whether the control is currently showing an <code>error state</code> and should render validation feedback.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfTextInputLayout.html#Syncfusion_Maui_Core_SfTextInputLayout_HelperLabelStyle" aria-label="View HelperLabelStyle property in API reference">HelperLabelStyle</a></td>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.LabelStyle.html" aria-label="View LabelStyle type in API reference">LabelStyle</a></td>
<td>Defines the styling used for <code>helper text</code>, making it possible to customize the supporting message shown below the input area.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfTextInputLayout.html#Syncfusion_Maui_Core_SfTextInputLayout_HelperText" aria-label="View HelperText property in API reference">HelperText</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.string" aria-label="View String type in API reference">string</a></td>
<td>Defines the <code>helper text</code> displayed below the input view to provide guidance, examples, or contextual support.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfTextInputLayout.html#Syncfusion_Maui_Core_SfTextInputLayout_Hint" aria-label="View Hint property in API reference">Hint</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.string" aria-label="View String type in API reference">string</a></td>
<td>Defines the <code>hint</code> text that identifies the purpose of the input view and helps describe the expected value.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfTextInputLayout.html#Syncfusion_Maui_Core_SfTextInputLayout_HintLabelStyle" aria-label="View HintLabelStyle property in API reference">HintLabelStyle</a></td>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.LabelStyle.html" aria-label="View LabelStyle type in API reference">LabelStyle</a></td>
<td>Defines the appearance of the <code>hint label</code>, including typography and visual treatment for the floating or resting hint text.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfTextInputLayout.html#Syncfusion_Maui_Core_SfTextInputLayout_InputViewPadding" aria-label="View InputViewPadding property in API reference">InputViewPadding</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.thickness" aria-label="View Thickness type in API reference">Thickness</a></td>
<td>Defines the <code>padding</code> applied around the embedded input view so spacing can be tuned for compact or spacious layouts.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfTextInputLayout.html#Syncfusion_Maui_Core_SfTextInputLayout_IsEnabled" aria-label="View IsEnabled property in API reference">IsEnabled</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
<td>Determines whether the text input layout is enabled and can participate in interaction.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfTextInputLayout.html#Syncfusion_Maui_Core_SfTextInputLayout_IsHintAlwaysFloated" aria-label="View IsHintAlwaysFloated property in API reference">IsHintAlwaysFloated</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
<td>Determines whether the <code>hint</code> remains permanently in the floated position instead of returning to the inline state.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfTextInputLayout.html#Syncfusion_Maui_Core_SfTextInputLayout_LeadingView" aria-label="View LeadingView property in API reference">LeadingView</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.view" aria-label="View View type in API reference">View</a></td>
<td>Defines the <code>leading view</code> placed before the input content, such as an icon, label, or custom interactive element.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfTextInputLayout.html#Syncfusion_Maui_Core_SfTextInputLayout_LeadingViewPosition" aria-label="View LeadingViewPosition property in API reference">LeadingViewPosition</a></td>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.ViewPosition.html" aria-label="View tViewPosition enum in API reference">ViewPosition</a></td>
<td>Defines the position of the <code>leading view</code> by using the <code>ViewPosition</code> enum to control where the adornment appears around the input area.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfTextInputLayout.html#Syncfusion_Maui_Core_SfTextInputLayout_OutlineCornerRadius" aria-label="View OutlineCornerRadius property in API reference">OutlineCornerRadius</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.cornerradius" aria-label="View CornerRadius type in API reference">CornerRadius</a></td>
<td>Defines the corner radius of the outlined container and controls how rounded the outer border appears.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfTextInputLayout.html#Syncfusion_Maui_Core_SfTextInputLayout_ReserveSpaceForAssistiveLabels" aria-label="View ReserveSpaceForAssistiveLabels property in API reference">ReserveSpaceForAssistiveLabels</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
<td>Determines whether space is reserved for <code>helper text</code> and <code>error text</code> so the layout remains stable when assistive labels appear.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfTextInputLayout.html#Syncfusion_Maui_Core_SfTextInputLayout_ShowCharCount" aria-label="View ShowCharCount property in API reference">ShowCharCount</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
<td>Determines whether the <code>character count</code> is displayed for the embedded input view.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfTextInputLayout.html#Syncfusion_Maui_Core_SfTextInputLayout_ShowHelperText" aria-label="View ShowHelperText property in API reference">ShowHelperText</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
<td>Determines whether <code>helper text</code> is shown below the input view.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfTextInputLayout.html#Syncfusion_Maui_Core_SfTextInputLayout_ShowHint" aria-label="View ShowHint property in API reference">ShowHint</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
<td>Determines whether the <code>hint</code> is visible in the layout.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfTextInputLayout.html#Syncfusion_Maui_Core_SfTextInputLayout_ShowLeadingView" aria-label="View ShowLeadingView property in API reference">ShowLeadingView</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
<td>Determines whether the <code>leading view</code> is visible beside the input content.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfTextInputLayout.html#Syncfusion_Maui_Core_SfTextInputLayout_ShowTrailingView" aria-label="View ShowTrailingView property in API reference">ShowTrailingView</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
<td>Determines whether the <code>trailing view</code> is visible beside the input content.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfTextInputLayout.html#Syncfusion_Maui_Core_SfTextInputLayout_Stroke" aria-label="View Stroke property in API reference">Stroke</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.brush" aria-label="View Brush type in API reference">Brush</a></td>
<td>Defines the border brush of the text input layout and controls the appearance of the outer stroke.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfTextInputLayout.html#Syncfusion_Maui_Core_SfTextInputLayout_Text" aria-label="View Text property in API reference">Text</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.string" aria-label="View String type in API reference">string</a></td>
<td>Defines the text value displayed in the input view and represents the current editable content.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfTextInputLayout.html#Syncfusion_Maui_Core_SfTextInputLayout_TrailingView" aria-label="View TrailingView property in API reference">TrailingView</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.view" aria-label="View View type in API reference">View</a></td>
<td>Defines the <code>trailing view</code> placed after the input content, such as an icon, action button, or custom accessory element.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfTextInputLayout.html#Syncfusion_Maui_Core_SfTextInputLayout_TrailingViewPosition" aria-label="View TrailingViewPosition property in API reference">TrailingViewPosition</a></td>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.AdornmentViewPosition.html" aria-label="View AdornmentViewPosition enum in API reference">AdornmentViewPosition</a></td>
<td>Defines the position of the <code>trailing view</code> by using the <code>AdornmentViewPosition</code> enum to control the accessory placement around the input area.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfTextInputLayout.html#Syncfusion_Maui_Core_SfTextInputLayout_UnfocusedStrokeThickness" aria-label="View UnfocusedStrokeThickness property in API reference">UnfocusedStrokeThickness</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
<td>Defines the border thickness used when the control is not focused and the inactive visual state is rendered.</td>
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
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfTextInputLayout.html#Syncfusion_Maui_Core_SfTextInputLayout_Focus" aria-label="View Focus method in API reference">Focus()</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
<td>Sets focus to the embedded input view and returns whether focus was applied successfully.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfTextInputLayout.html#Syncfusion_Maui_Core_SfTextInputLayout_Unfocus" aria-label="View Unfocus method in API reference">Unfocus()</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.void" aria-label="View Void type in API reference">void</a></td>
<td>Removes focus from the embedded input view and returns the control to an inactive state.</td>
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
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfTextInputLayout.html#Syncfusion_Maui_Core_SfTextInputLayout_PasswordVisibilityToggled" aria-label="View PasswordVisibilityToggled event in API reference">PasswordVisibilityToggled</a></td>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.PasswordVisibilityToggledEventArgs.html" aria-label="View PasswordVisibilityToggledEventArgs type in API reference">PasswordVisibilityToggledEventArgs</a></td>
<td>Raised when the <code>password visibility toggle</code> is activated and the secure text display state changes.</td>
</tr>

</table>

---
layout: post
title: Properties of .NET MAUI Effects View control | Syncfusion®
description: This section explains the properties, events and methods with Syncfusion® MAUI Effects View (SfEffectsView) control.
platform: maui
control: SfEffectsView
documentation: ug
---

# API Reference for .NET MAUI Effects View

## Properties

<table>
<tr>
<th>Name</th>
<th>Type</th>
<th>Description</th>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffectsView.html#Syncfusion_Maui_Core_SfEffectsView_Angle" aria-label="View Angle property in API reference">Angle</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.int32" aria-label="View Int32 type in API reference">int</a></td>
<td>Defines the rotation angle applied to the effects view and controls the degree of visual tilt used during interaction.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffectsView.html#Syncfusion_Maui_Core_SfEffectsView_AutoResetEffects" aria-label="View AutoResetEffects property in API reference">AutoResetEffects</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
<td>Determines whether applied visual effects are automatically restored after an interaction ends, keeping the control state clean without requiring manual reset logic.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffectsView.html#Syncfusion_Maui_Core_SfEffectsView_FadeOutRipple" aria-label="View FadeOutRipple property in API reference">FadeOutRipple</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
<td>Determines whether the <code>ripple</code> effect fades out after completion and controls how the touch feedback disappears from the surface.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffectsView.html#Syncfusion_Maui_Core_SfEffectsView_HighlightBackground" aria-label="View HighlightBackground property in API reference">HighlightBackground</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.brush" aria-label="View Brush type in API reference">Brush</a></td>
<td>Defines the background brush used when the view is highlighted and provides the visual fill shown during emphasis or feedback states.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffectsView.html#Syncfusion_Maui_Core_SfEffectsView_InitialRippleFactor" aria-label="View InitialRippleFactor property in API reference">InitialRippleFactor</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
<td>Defines the initial size factor of the <code>ripple</code> effect and controls the starting scale used when the animation begins.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffectsView.html#Syncfusion_Maui_Core_SfEffectsView_IsSelected" aria-label="View IsSelected property in API reference">IsSelected</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
<td>Determines whether the effects view is in the selected state and controls the active selection appearance of the control.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffectsView.html#Syncfusion_Maui_Core_SfEffectsView_LongPressedCommand" aria-label="View LongPressedCommand property in API reference">LongPressedCommand</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.windows.input.icommand" aria-label="View ICommand type in API reference">ICommand</a></td>
<td>Defines the command executed when a <code>long press</code> interaction occurs and connects the gesture to application command logic.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffectsView.html#Syncfusion_Maui_Core_SfEffectsView_LongPressedCommandParameter" aria-label="View LongPressedCommandParameter property in API reference">LongPressedCommandParameter</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.object" aria-label="View Object type in API reference">object</a></td>
<td>Defines the parameter passed to the <code>long press</code> command and supplies contextual data to the bound command handler.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffectsView.html#Syncfusion_Maui_Core_SfEffectsView_LongPressEffects" aria-label="View LongPressEffects property in API reference">LongPressEffects</a></td>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffects.html" aria-label="View SfEffects enum in API reference">SfEffects</a></td>
<td>Defines the visual effects applied during a <code>long press</code> interaction by using the <code>SfEffects</code> enum to control the effect behavior.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffectsView.html#Syncfusion_Maui_Core_SfEffectsView_RippleAnimationDuration" aria-label="View RippleAnimationDuration property in API reference">RippleAnimationDuration</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
<td>Defines the duration of the <code>ripple</code> animation and controls how long the visual expansion and fade sequence takes.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffectsView.html#Syncfusion_Maui_Core_SfEffectsView_RippleBackground" aria-label="View RippleBackground property in API reference">RippleBackground</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.brush" aria-label="View Brush type in API reference">Brush</a></td>
<td>Defines the background brush used for the <code>ripple</code> effect and controls the fill color or gradient shown behind the animation.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffectsView.html#Syncfusion_Maui_Core_SfEffectsView_RotationAnimationDuration" aria-label="View RotationAnimationDuration property in API reference">RotationAnimationDuration</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
<td>Defines the duration of the <code>rotation</code> animation and controls the pacing of rotational motion during interaction.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffectsView.html#Syncfusion_Maui_Core_SfEffectsView_ScaleAnimationDuration" aria-label="View ScaleAnimationDuration property in API reference">ScaleAnimationDuration</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
<td>Defines the duration of the <code>scale</code> animation and controls how quickly the view grows or shrinks during feedback.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffectsView.html#Syncfusion_Maui_Core_SfEffectsView_ScaleFactor" aria-label="View ScaleFactor property in API reference">ScaleFactor</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
<td>Defines the scale factor applied during interaction and controls the amount of visual enlargement or reduction.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffectsView.html#Syncfusion_Maui_Core_SfEffectsView_SelectionBackground" aria-label="View SelectionBackground property in API reference">SelectionBackground</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.brush" aria-label="View Brush type in API reference">Brush</a></td>
<td>Defines the background brush used when the view is selected and provides the visual surface shown for the active state.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffectsView.html#Syncfusion_Maui_Core_SfEffectsView_ShouldIgnoreTouches" aria-label="View ShouldIgnoreTouches property in API reference">ShouldIgnoreTouches</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
<td>Determines whether touch input is ignored and controls whether the control participates in gesture handling.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffectsView.html#Syncfusion_Maui_Core_SfEffectsView_TouchDownCommand" aria-label="View TouchDownCommand property in API reference">TouchDownCommand</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.windows.input.icommand" aria-label="View ICommand type in API reference">ICommand</a></td>
<td>Defines the command executed when a <code>touch down</code> action occurs and binds the interaction to application logic.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffectsView.html#Syncfusion_Maui_Core_SfEffectsView_TouchDownCommandParameter" aria-label="View TouchDownCommandParameter property in API reference">TouchDownCommandParameter</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.object" aria-label="View Object type in API reference">object</a></td>
<td>Defines the parameter passed to the <code>touch down</code> command and provides the associated input context.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffectsView.html#Syncfusion_Maui_Core_SfEffectsView_TouchDownEffects" aria-label="View TouchDownEffects property in API reference">TouchDownEffects</a></td>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffects.html" aria-label="View SfEffects enum in API reference">SfEffects</a></td>
<td>Defines the visual effects applied during <code>touch down</code> by using the <code>SfEffects</code> enum to control the active feedback behavior.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffectsView.html#Syncfusion_Maui_Core_SfEffectsView_TouchUpCommand" aria-label="View TouchUpCommand property in API reference">TouchUpCommand</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.windows.input.icommand" aria-label="View ICommand type in API reference">ICommand</a></td>
<td>Defines the command executed when a <code>touch up</code> action occurs and connects gesture completion to command execution.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffectsView.html#Syncfusion_Maui_Core_SfEffectsView_TouchUpCommandParameter" aria-label="View TouchUpCommandParameter property in API reference">TouchUpCommandParameter</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.object" aria-label="View Object type in API reference">object</a></td>
<td>Defines the parameter passed to the <code>touch up</code> command and supplies the data used when the gesture completes.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffectsView.html#Syncfusion_Maui_Core_SfEffectsView_TouchUpEffects" aria-label="View TouchUpEffects property in API reference">TouchUpEffects</a></td>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffects.html" aria-label="View SfEffects enum in API reference">SfEffects</a></td>
<td>Defines the visual effects applied during <code>touch up</code> by using the <code>SfEffects</code> enum to control the finishing feedback behavior.</td>
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
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffectsView.html#Syncfusion_Maui_Core_SfEffectsView_ApplyEffects_Syncfusion_Maui_Core_SfEffects_Syncfusion_Maui_Core_RippleStartPosition_Microsoft_Maui_Graphics_Point_System_Boolean_" aria-label="View ApplyEffects(SfEffects, RippleStartPosition, Nullable&lt;Point&gt;, Boolean) method in API reference">ApplyEffects(SfEffects, RippleStartPosition, Nullable&lt;Point&gt;, Boolean)</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.void" aria-label="View Void type in API reference">void</a></td>
<td>Applies the specified visual effects to the effects view, including the configured <code>SfEffects</code>, ripple start position, optional point-based origin, and animation behavior.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffectsView.html#Syncfusion_Maui_Core_SfEffectsView_Reset" aria-label="View Reset() method in API reference">Reset()</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.void" aria-label="View Void type in API reference">void</a></td>
<td>Resets all applied visual effects and restores the control to its default visual state.</td>
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
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffectsView.html#Syncfusion_Maui_Core_SfEffectsView_AnimationCompleted" aria-label="View AnimationCompleted event in API reference">AnimationCompleted</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.eventargs" aria-label="View EventArgs type in API reference">EventArgs</a></td>
<td>Raised when the visual effect animation completes and signals that the current transition has finished.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffectsView.html#Syncfusion_Maui_Core_SfEffectsView_LongPressed" aria-label="View LongPressed event in API reference">LongPressed</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.eventargs" aria-label="View EventArgs type in API reference">EventArgs</a></td>
<td>Raised when a <code>long press</code> interaction occurs and indicates that the press gesture has been recognized.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffectsView.html#Syncfusion_Maui_Core_SfEffectsView_SelectionChanged" aria-label="View SelectionChanged event in API reference">SelectionChanged</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.eventargs" aria-label="View EventArgs type in API reference">EventArgs</a></td>
<td>Raised when the selection state changes and reflects transitions between selected and unselected states.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffectsView.html#Syncfusion_Maui_Core_SfEffectsView_TouchDown" aria-label="View TouchDown event in API reference">TouchDown</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.eventargs" aria-label="View EventArgs type in API reference">EventArgs</a></td>
<td>Raised when a <code>touch down</code> action occurs and marks the beginning of pointer contact with the control.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffectsView.html#Syncfusion_Maui_Core_SfEffectsView_TouchUp" aria-label="View TouchUp event in API reference">TouchUp</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.eventargs" aria-label="View EventArgs type in API reference">EventArgs</a></td>
<td>Raised when a <code>touch up</code> action occurs and marks the end of pointer contact with the control.</td>
</tr>

</table>


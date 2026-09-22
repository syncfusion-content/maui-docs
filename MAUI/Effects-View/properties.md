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
    <td><code>Rotation angle</code> applied to the <code>content</code> while an <code>effect</code> is <code>active</code>, measured in <code>degrees</code>. Larger values produce a more pronounced <code>tilt</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffectsView.html#Syncfusion_Maui_Core_SfEffectsView_AutoResetEffects" aria-label="View AutoResetEffects property in API reference">AutoResetEffects</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
    <td>Controls whether applied <code>effects</code> clear <code>automatically</code> when the <code>gesture ends</code>. Set to <code>false</code> to keep the <code>effect</code> in its <code>final state</code> until <code>Reset()</code> is called.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffectsView.html#Syncfusion_Maui_Core_SfEffectsView_FadeOutRipple" aria-label="View FadeOutRipple property in API reference">FadeOutRipple</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
    <td>Controls whether the <code>ripple</code> animation <code>fades out</code> as it <code>expands</code>. Set to <code>false</code> to keep the <code>ripple</code> fully <code>visible</code> until the <code>animation ends</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffectsView.html#Syncfusion_Maui_Core_SfEffectsView_HighlightBackground" aria-label="View HighlightBackground property in API reference">HighlightBackground</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.brush" aria-label="View Brush type in API reference">Brush</a></td>
    <td><code>Brush</code> applied to the <code>surface</code> while the <code>highlight effect</code> is <code>active</code>. Use it to define the <code>background color</code> shown during the <code>emphasis state</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffectsView.html#Syncfusion_Maui_Core_SfEffectsView_InitialRippleFactor" aria-label="View InitialRippleFactor property in API reference">InitialRippleFactor</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
    <td><code>Starting size</code> of the <code>ripple effect</code>, expressed as a <code>scale factor</code> of the <code>final size</code>. Larger values begin the <code>ripple</code> with a <code>larger radius</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffectsView.html#Syncfusion_Maui_Core_SfEffectsView_IsSelected" aria-label="View IsSelected property in API reference">IsSelected</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
    <td>Controls the <code>selected state</code> of the <code>view</code>. When <code>true</code>, the <code>SelectionBackground</code> is applied to indicate <code>active selection</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffectsView.html#Syncfusion_Maui_Core_SfEffectsView_LongPressedCommand" aria-label="View LongPressedCommand property in API reference">LongPressedCommand</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.windows.input.icommand" aria-label="View ICommand type in API reference">ICommand</a></td>
    <td><code>Command</code> executed when a <code>long press</code> is <code>recognized</code> on the <code>view</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffectsView.html#Syncfusion_Maui_Core_SfEffectsView_LongPressedCommandParameter" aria-label="View LongPressedCommandParameter property in API reference">LongPressedCommandParameter</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.object" aria-label="View Object type in API reference">object</a></td>
    <td><code>Parameter</code> passed to the <code>LongPressedCommand</code> when the <code>gesture fires</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffectsView.html#Syncfusion_Maui_Core_SfEffectsView_LongPressEffects" aria-label="View LongPressEffects property in API reference">LongPressEffects</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffects.html" aria-label="View SfEffects enum in API reference">SfEffects</a></td>
    <td><code>Visual effect</code> applied during a <code>long press</code>. Choose a supported <code>SfEffects</code> value such as <code>Ripple</code>, <code>Highlight</code>, <code>Scale</code>, <code>Rotation</code>, or <code>None</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffectsView.html#Syncfusion_Maui_Core_SfEffectsView_RippleAnimationDuration" aria-label="View RippleAnimationDuration property in API reference">RippleAnimationDuration</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
    <td><code>Duration</code> of the <code>ripple expand-and-fade animation</code>, in <code>milliseconds</code>. Larger values produce <code>slower ripples</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffectsView.html#Syncfusion_Maui_Core_SfEffectsView_RippleBackground" aria-label="View RippleBackground property in API reference">RippleBackground</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.brush" aria-label="View Brush type in API reference">Brush</a></td>
    <td><code>Brush</code> used to fill the <code>ripple wave</code> as it <code>expands</code> across the <code>surface</code>. Use it to customize the <code>ripple color</code> or <code>gradient</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffectsView.html#Syncfusion_Maui_Core_SfEffectsView_RotationAnimationDuration" aria-label="View RotationAnimationDuration property in API reference">RotationAnimationDuration</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
    <td><code>Duration</code> of the <code>rotation animation</code>, in <code>milliseconds</code>. Larger values produce <code>slower rotation transitions</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffectsView.html#Syncfusion_Maui_Core_SfEffectsView_ScaleAnimationDuration" aria-label="View ScaleAnimationDuration property in API reference">ScaleAnimationDuration</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
    <td><code>Duration</code> of the <code>scale animation</code>, in <code>milliseconds</code>. Larger values produce <code>slower grow or shrink transitions</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffectsView.html#Syncfusion_Maui_Core_SfEffectsView_ScaleFactor" aria-label="View ScaleFactor property in API reference">ScaleFactor</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
    <td><code>Target scale factor</code> applied during the <code>scale effect</code>. Values greater than <code>1</code> <code>enlarge</code> the <code>content</code>; values less than <code>1</code> <code>shrink</code> it.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffectsView.html#Syncfusion_Maui_Core_SfEffectsView_SelectionBackground" aria-label="View SelectionBackground property in API reference">SelectionBackground</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.brush" aria-label="View Brush type in API reference">Brush</a></td>
    <td><code>Brush</code> applied to the <code>surface</code> when <code>IsSelected</code> is <code>true</code>. Use it to define the <code>selection appearance</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffectsView.html#Syncfusion_Maui_Core_SfEffectsView_ShouldIgnoreTouches" aria-label="View ShouldIgnoreTouches property in API reference">ShouldIgnoreTouches</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
    <td>Controls whether <code>touch interactions</code> on the <code>view</code> are <code>ignored</code>. Set to <code>true</code> to let <code>touch events</code> pass through to <code>underlying elements</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffectsView.html#Syncfusion_Maui_Core_SfEffectsView_TouchDownCommand" aria-label="View TouchDownCommand property in API reference">TouchDownCommand</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.windows.input.icommand" aria-label="View ICommand type in API reference">ICommand</a></td>
    <td><code>Command</code> executed when a <code>finger</code> or <code>pointer</code> first <code>contacts</code> the <code>view</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffectsView.html#Syncfusion_Maui_Core_SfEffectsView_TouchDownCommandParameter" aria-label="View TouchDownCommandParameter property in API reference">TouchDownCommandParameter</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.object" aria-label="View Object type in API reference">object</a></td>
    <td><code>Parameter</code> passed to the <code>TouchDownCommand</code> when the <code>gesture begins</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffectsView.html#Syncfusion_Maui_Core_SfEffectsView_TouchDownEffects" aria-label="View TouchDownEffects property in API reference">TouchDownEffects</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffects.html" aria-label="View SfEffects enum in API reference">SfEffects</a></td>
    <td><code>Visual effect</code> triggered when a <code>touch begins</code>. Choose a supported <code>SfEffects</code> value such as <code>Ripple</code>, <code>Highlight</code>, <code>Scale</code>, <code>Rotation</code>, or <code>None</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffectsView.html#Syncfusion_Maui_Core_SfEffectsView_TouchUpCommand" aria-label="View TouchUpCommand property in API reference">TouchUpCommand</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.windows.input.icommand" aria-label="View ICommand type in API reference">ICommand</a></td>
    <td><code>Command</code> executed when <code>contact</code> with the <code>view</code> <code>ends</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffectsView.html#Syncfusion_Maui_Core_SfEffectsView_TouchUpCommandParameter" aria-label="View TouchUpCommandParameter property in API reference">TouchUpCommandParameter</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.object" aria-label="View Object type in API reference">object</a></td>
    <td><code>Parameter</code> passed to the <code>TouchUpCommand</code> when the <code>gesture ends</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffectsView.html#Syncfusion_Maui_Core_SfEffectsView_TouchUpEffects" aria-label="View TouchUpEffects property in API reference">TouchUpEffects</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffects.html" aria-label="View SfEffects enum in API reference">SfEffects</a></td>
    <td><code>Visual effect</code> triggered when the <code>touch ends</code>. Choose a supported <code>SfEffects</code> value such as <code>None</code> (to <code>clear</code>) or another supported <code>transition</code>.</td>
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
    <td>Applies the specified <code>effect</code>, controls the <code>ripple start position</code> using a supported <code>RippleStartPosition</code> value such as <code>Default</code>, <code>TouchCenter</code>, <code>TopLeft</code>, <code>TopRight</code>, <code>BottomLeft</code>, or <code>BottomRight</code>, optionally overrides the <code>touch origin</code> with a specific <code>point</code>, and configures whether the <code>effect animates</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffectsView.html#Syncfusion_Maui_Core_SfEffectsView_Reset" aria-label="View Reset() method in API reference">Reset()</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.void" aria-label="View Void type in API reference">void</a></td>
    <td>Clears all <code>active effects</code> and restores the <code>view</code> to its <code>default visual state</code>.</td>
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
    <td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler" aria-label="View EventHandler type in API reference">EventHandler</a></td>
    <td>Triggered when the <code>current effect animation</code> finishes, signaling that the <code>transition</code> has <code>completed</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffectsView.html#Syncfusion_Maui_Core_SfEffectsView_LongPressed" aria-label="View LongPressed event in API reference">LongPressed</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler" aria-label="View EventHandler type in API reference">EventHandler</a></td>
    <td>Triggered when the <code>view</code> recognizes a <code>long press gesture</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffectsView.html#Syncfusion_Maui_Core_SfEffectsView_SelectionChanged" aria-label="View SelectionChanged event in API reference">SelectionChanged</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler" aria-label="View EventHandler type in API reference">EventHandler</a></td>
    <td>Triggered when the <code>selection state</code> changes between <code>selected</code> and <code>unselected</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffectsView.html#Syncfusion_Maui_Core_SfEffectsView_TouchDown" aria-label="View TouchDown event in API reference">TouchDown</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler" aria-label="View EventHandler type in API reference">EventHandler</a></td>
    <td>Triggered when a <code>finger</code> or <code>pointer</code> first makes <code>contact</code> with the <code>view</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffectsView.html#Syncfusion_Maui_Core_SfEffectsView_TouchUp" aria-label="View TouchUp event in API reference">TouchUp</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler" aria-label="View EventHandler type in API reference">EventHandler</a></td>
    <td>Triggered when <code>contact</code> with the <code>view</code> <code>ends</code>.</td>
</tr>
</table>

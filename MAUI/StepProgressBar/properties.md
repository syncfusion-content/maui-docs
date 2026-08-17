---
layout: post
title: Properties of .NET MAUI Step ProgressBar control | Syncfusion®
description: This section explains the properties, events and methods with Syncfusion® MAUI Step ProgressBar (SfStepProgressBar) control.
platform: maui
control: SfStepProgressBar
documentation: ug
---

# .NET MAUI Step ProgressBar API Reference

## Properties

<table>
<tr>
    <th>Name</th>
    <th>Type</th>
    <th>Description</th>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.SfStepProgressBar.html#Syncfusion_Maui_ProgressBar_SfStepProgressBar_ActiveStepIndex" aria-label="View ActiveStepIndex property in API reference">ActiveStepIndex</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.int32" aria-label="View Int32 type in API reference">int</a></td>
    <td>Defines the zero-based index of the currently active step and is used to control which step is highlighted as the current point in the workflow.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.SfStepProgressBar.html#Syncfusion_Maui_ProgressBar_SfStepProgressBar_ActiveStepProgressValue" aria-label="View ActiveStepProgressValue property in API reference">ActiveStepProgressValue</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
    <td>Defines the progress value for the active step and represents how much of the current step has been completed.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.SfStepProgressBar.html#Syncfusion_Maui_ProgressBar_SfStepProgressBar_CompletedStepSettings" aria-label="View CompletedStepSettings property in API reference">CompletedStepSettings</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.StepSettings.html" aria-label="View StepSettings type in API reference">StepSettings</a></td>
    <td>Defines the appearance settings applied to completed steps, including the visual treatment used to distinguish finished progress from the remaining steps.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.SfStepProgressBar.html#Syncfusion_Maui_ProgressBar_SfStepProgressBar_EnableLiquidGlassEffect" aria-label="View EnableLiquidGlassEffect property in API reference">EnableLiquidGlassEffect</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
    <td>Determines whether the <code>liquid glass</code> visual treatment is applied to the control for a more refined and modern surface appearance.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.SfStepProgressBar.html#Syncfusion_Maui_ProgressBar_SfStepProgressBar_InProgressStepSettings" aria-label="View InProgressStepSettings property in API reference">InProgressStepSettings</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.StepSettings.html" aria-label="View StepSettings type in API reference">StepSettings</a></td>
    <td>Defines the appearance settings applied to steps that are currently in progress and provides a distinct visual state for active progression.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.SfStepProgressBar.html#Syncfusion_Maui_ProgressBar_SfStepProgressBar_ItemsSource" aria-label="View ItemsSource property in API reference">ItemsSource</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.collections.ienumerable" aria-label="View IEnumerable type in API reference">IEnumerable</a></td>
    <td>Defines the collection used to generate the steps displayed in the progress bar and serves as the data source for step creation.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.SfStepProgressBar.html#Syncfusion_Maui_ProgressBar_SfStepProgressBar_LabelPosition" aria-label="View LabelPosition property in API reference">LabelPosition</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.LabelPosition.html" aria-label="View LabelPosition enum in API reference">LabelPosition</a></td>
    <td>Defines the position of step labels by using the <code>LabelPosition</code> enum, which controls how labels are arranged relative to the step indicators.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.SfStepProgressBar.html#Syncfusion_Maui_ProgressBar_SfStepProgressBar_LabelSpacing" aria-label="View LabelSpacing property in API reference">LabelSpacing</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
    <td>Defines the spacing between the step indicators and their labels and helps control the visual balance of the layout.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.SfStepProgressBar.html#Syncfusion_Maui_ProgressBar_SfStepProgressBar_NotStartedStepSettings" aria-label="View NotStartedStepSettings property in API reference">NotStartedStepSettings</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.StepSettings.html" aria-label="View StepSettings type in API reference">StepSettings</a></td>
    <td>Defines the appearance settings applied to steps that have not started and provides the initial visual state for pending progress.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.SfStepProgressBar.html#Syncfusion_Maui_ProgressBar_SfStepProgressBar_Orientation" aria-label="View Orientation property in API reference">Orientation</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.StepProgressBarOrientation.html" aria-label="View StepProgressBarOrientation enum in API reference">StepProgressBarOrientation</a></td>
    <td>Defines whether the control is arranged horizontally or vertically by using the <code>StepProgressBarOrientation</code> enum.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.SfStepProgressBar.html#Syncfusion_Maui_ProgressBar_SfStepProgressBar_PrimaryTextTemplate" aria-label="View PrimaryTextTemplate property in API reference">PrimaryTextTemplate</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.datatemplate" aria-label="View DataTemplate type in API reference">DataTemplate</a></td>
    <td>Defines the template used to render the primary text for each step and allows the main step label content to be fully customized.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.SfStepProgressBar.html#Syncfusion_Maui_ProgressBar_SfStepProgressBar_ProgressAnimationDuration" aria-label="View ProgressAnimationDuration property in API reference">ProgressAnimationDuration</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
    <td>Defines the duration, in milliseconds, used for progress animation when step states or progress values change.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.SfStepProgressBar.html#Syncfusion_Maui_ProgressBar_SfStepProgressBar_ProgressBarBackground" aria-label="View ProgressBarBackground property in API reference">ProgressBarBackground</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.brush" aria-label="View Brush type in API reference">Brush</a></td>
    <td>Defines the background brush of the progress track and controls the visual appearance of the inactive bar surface.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.SfStepProgressBar.html#Syncfusion_Maui_ProgressBar_SfStepProgressBar_SecondaryTextTemplate" aria-label="View SecondaryTextTemplate property in API reference">SecondaryTextTemplate</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.datatemplate" aria-label="View DataTemplate type in API reference">DataTemplate</a></td>
    <td>Defines the template used to render the secondary text for each step and supports supplementary descriptions or status details.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.SfStepProgressBar.html#Syncfusion_Maui_ProgressBar_SfStepProgressBar_ShowToolTip" aria-label="View ShowToolTip property in API reference">ShowToolTip</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
    <td>Determines whether tooltips are displayed for step indicators when additional contextual information needs to be shown.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.SfStepProgressBar.html#Syncfusion_Maui_ProgressBar_SfStepProgressBar_StepContentSize" aria-label="View StepContentSize property in API reference">StepContentSize</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
    <td>Defines the size of the content area inside each step and helps control how much space is reserved for text or custom templates.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.SfStepProgressBar.html#Syncfusion_Maui_ProgressBar_SfStepProgressBar_StepSize" aria-label="View StepSize property in API reference">StepSize</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
    <td>Defines the size of each step indicator and controls the overall prominence of the progress markers.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.SfStepProgressBar.html#Syncfusion_Maui_ProgressBar_SfStepProgressBar_StepStrokeWidth" aria-label="View StepStrokeWidth property in API reference">StepStrokeWidth</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
    <td>Defines the stroke width of step indicators and controls how strongly the step outline is rendered.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.SfStepProgressBar.html#Syncfusion_Maui_ProgressBar_SfStepProgressBar_StepTemplate" aria-label="View StepTemplate property in API reference">StepTemplate</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.datatemplate" aria-label="View DataTemplate type in API reference">DataTemplate</a></td>
    <td>Defines the template used to render each step indicator and enables custom visual layouts for the step surface.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.SfStepProgressBar.html#Syncfusion_Maui_ProgressBar_SfStepProgressBar_ToolTipSettings" aria-label="View ToolTipSettings property in API reference">ToolTipSettings</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.StepProgressBarToolTipSettings.html" aria-label="View StepProgressBarToolTipSettings type in API reference">StepProgressBarToolTipSettings</a></td>
    <td>Defines the appearance settings of step tooltips and controls the visual presentation of tooltip content.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.SfStepProgressBar.html#Syncfusion_Maui_ProgressBar_SfStepProgressBar_ToolTipTemplate" aria-label="View ToolTipTemplate property in API reference">ToolTipTemplate</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.datatemplate" aria-label="View DataTemplate type in API reference">DataTemplate</a></td>
    <td>Defines the template used to render tooltip content and allows the tooltip surface to be customized with structured information.</td>
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
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.SfStepProgressBar.html#Syncfusion_Maui_ProgressBar_SfStepProgressBar_StepStatusChanged" aria-label="View StepStatusChanged event in API reference">StepStatusChanged</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.StepStatusChangedEventArgs.html" aria-label="View StepStatusChangedEventArgs type in API reference">StepStatusChangedEventArgs</a></td>
    <td>Raised when a step changes status, such as moving from <code>not started</code> to <code>in progress</code> or from <code>in progress</code> to <code>completed</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.SfStepProgressBar.html#Syncfusion_Maui_ProgressBar_SfStepProgressBar_StepTapped" aria-label="View StepTapped event in API reference">StepTapped</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.StepTappedEventArgs.html" aria-label="View StepTappedEventArgs type in API reference">StepTappedEventArgs</a></td>
    <td>Raised when a step is tapped and can be used to respond to step selection or interaction logic.</td>
</tr>

</table>

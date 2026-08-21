---
layout: post
title: Properties of .NET MAUI DateTime Range Selector control | Syncfusion®
description: This section explains about the properties and events with Syncfusion® .NET MAUI DateTime Range Selector control and more.
platform: maui
control: SfDateTimeRangeSelector
documentation: ug
---

# API Reference for .NET MAUI DateTime Range Selector

## Properties

<table>
	<tr>
		<th>
			Name<br/>
		</th>
		<th>
			Type<br/>
		</th>
		<th>
			Description<br/>
		</th>
	</tr>
	<tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.IDateTimeElement.html#Syncfusion_Maui_Sliders_IDateTimeElement_DateFormat" aria-label="View DateFormat property in API reference">DateFormat</a> <br/>
		</td>
		<td>
			<a href="https://learn.microsoft.com/dotnet/api/system.string" aria-label="View string type in API reference">string</a>
		</td>
		<td>Formats the displayed date text.</td>
	</tr>
	<tr valign="top">		
		<td>
		  <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.IDateTimeElement.html#Syncfusion_Maui_Sliders_IDateTimeElement_IntervalType" aria-label="View IntervalType property in API reference">IntervalType</a><br/>
		</td>
		<td>
			<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderDateIntervalType.html" aria-label="View SliderDateIntervalType type in API reference">SliderDateIntervalType</a>
		</td>
		<td>Defines the date interval used for the selector. Values include <code>Auto</code>, <code>Years</code>, <code>Months</code>, <code>Days</code>, and similar date-based options.</td>
	</tr>
	<tr valign="top">		
		<td>
		  <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.IDateTimeElement.html#Syncfusion_Maui_Sliders_IDateTimeElement_StepDuration" aria-label="View StepDuration property in API reference">StepDuration</a><br/>
		</td>
		<td>
			<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderStepDuration.html" aria-label="View SliderStepDuration type in API reference">SliderStepDuration</a>
		</td>
		<td>Specifies the discrete date step used when the selector moves by fixed date intervals.</td>
	</tr>
	<tr valign="top">		
		<td>
		  <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeSliderBase-1.html#Syncfusion_Maui_Sliders_RangeSliderBase_1_DragBehavior" aria-label="View DragBehavior property in API reference">DragBehavior</a><br/>
		</td>
		<td>
			<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderDragBehavior.html" aria-label="View SliderDragBehavior type in API reference">SliderDragBehavior</a>
		</td>
		<td>Controls how the start and end thumbs can be dragged. Values include <code>Free</code> and <code>BetweenThumbs</code>.</td>
		</td>
	</tr>
	<tr valign="top">		
		<td>
		  <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeSliderBase-1.html#Syncfusion_Maui_Sliders_RangeSliderBase_1_EnableIntervalSelection" aria-label="View EnableIntervalSelection property in API reference">EnableIntervalSelection</a><br/>
		</td>
		<td>
			<a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a>
		</td>
		<td>Determines whether thumb movement snaps to interval steps.</td>
	</tr>
	<tr valign="top">		
		<td>
		  <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeSliderBase-1.html#Syncfusion_Maui_Sliders_RangeSliderBase_1_EndThumbIcon" aria-label="View EndThumbIcon property in API reference">EndThumbIcon</a><br/>
		</td>
		<td>
			<a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.imagesource" aria-label="View ImageSource type in API reference">ImageSource</a>
		</td>
		<td>Defines the image displayed on the end thumb.</td>
	</tr>
	<tr valign="top">		
		<td>
		  <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeSliderBase-1.html#Syncfusion_Maui_Sliders_RangeSliderBase_1_RangeEnd" aria-label="View RangeEnd property in API reference">RangeEnd</a><br/>
		</td>
		<td>
			<a href="https://learn.microsoft.com/dotnet/api/system.datetime" aria-label="View DateTime type in API reference">DateTime</a>
		</td>
		<td>Specifies the end date of the currently selected date range.</td>
	</tr>
	<tr valign="top">		
		<td>
		  <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeSliderBase-1.html#Syncfusion_Maui_Sliders_RangeSliderBase_1_RangeStart" aria-label="View RangeStart property in API reference">RangeStart</a><br/>
		</td>
		<td>
			<a href="https://learn.microsoft.com/dotnet/api/system.datetime" aria-label="View DateTime type in API reference">DateTime</a>
		</td>
		<td>Specifies the start date of the currently selected date range.</td>
	</tr>
	<tr valign="top">		
		<td>
		  <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeSliderBase-1.html#Syncfusion_Maui_Sliders_RangeSliderBase_1_StartThumbIcon" aria-label="View StartThumbIcon property in API reference">StartThumbIcon</a><br/>
		</td>
		<td>
			<a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.imagesource" aria-label="View ImageSource type in API reference">ImageSource</a>
		</td>
		<td>Customizes the icon displayed on the range selector thumb that represents the start date.</td>
	</tr>
	<tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_DeferredUpdateDelay" aria-label="View DeferredUpdateDelay property in API reference">DeferredUpdateDelay</a> <br/>
		</td>
		<td>
			<a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View double type in API reference">double</a>
		</td>
		<td>Specifies the delay, in milliseconds, before deferred updates are applied.</td>
	</tr>
    <tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_DividerStyle" aria-label="View DividerStyle property in API reference">DividerStyle</a> <br/>
		</td>
		<td>
			<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderDividerStyle.html" aria-label="View SliderDividerStyle type in API reference">SliderDividerStyle</a>
		</td>
		<td>Customizes the appearance of the dividers between range elements.</td>
	</tr>
    <tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_DragCompletedCommand" aria-label="View DragCompletedCommand property in API reference">DragCompletedCommand</a> <br/>
		</td>
		<td>
			<a href="https://learn.microsoft.com/dotnet/api/system.windows.input.icommand" aria-label="View ICommand type in API reference">ICommand</a>
		</td>
		<td>Executes an action when thumb dragging finishes.</td>
	</tr>
    <tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_DragCompletedCommandParameter" aria-label="View DragCompletedCommandParameter property in API reference">DragCompletedCommandParameter</a> <br/>
		</td>
		<td>
			<a href="https://learn.microsoft.com/dotnet/api/system.object" aria-label="View object type in API reference">object</a>
		</td>
		<td>Supplies the parameter passed to <code>DragCompletedCommand</code>.</td>
	</tr>
    <tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_DragStartedCommand" aria-label="View DragStartedCommand property in API reference">DragStartedCommand</a> <br/>
		</td>
		<td>
			<a href="https://learn.microsoft.com/dotnet/api/system.windows.input.icommand" aria-label="View ICommand type in API reference">ICommand</a>
		</td>
		<td>Executes when thumb dragging starts.</td>
	</tr>
    <tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_DragStartedCommandParameter" aria-label="View DragStartedCommandParameter property in API reference">DragStartedCommandParameter</a> <br/>
		</td>
		<td>
			<a href="https://learn.microsoft.com/dotnet/api/system.object" aria-label="View object type in API reference">object</a>
		</td>
		<td>Supplies the parameter passed to <code>DragStartedCommand</code>.</td>
	</tr>
    <tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_EdgeLabelsPlacement" aria-label="View EdgeLabelsPlacement property in API reference">EdgeLabelsPlacement</a> <br/>
		</td>
		<td>
			<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderEdgeLabelsPlacement.html" aria-label="View SliderEdgeLabelsPlacement type in API reference">SliderEdgeLabelsPlacement</a>
		</td>
		<td>Controls where edge labels appear. Values include <code>Start</code>, <code>End</code>, and related placement options.</td>
	</tr>
    <tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_EnableDeferredUpdate" aria-label="View EnableDeferredUpdate property in API reference">EnableDeferredUpdate</a> <br/>
		</td>
		<td>
			<a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a>
		</td>
		<td>Determines whether selection updates are deferred until interaction ends.</td>
	</tr>
    <tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_EnableLiquidGlassEffect" aria-label="View EnableLiquidGlassEffect property in API reference">EnableLiquidGlassEffect</a> <br/>
		</td>
		<td>
			<a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a>
		</td>
		<td>Determines whether the liquid glass effect is enabled.</td>
	</tr>
    <tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_Interval" aria-label="View Interval property in API reference">Interval</a> <br/>
		</td>
		<td>
			<a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View double type in API reference">double</a>
		</td>
		<td>Defines the spacing between major date or time intervals displayed on the track.</td>
	</tr>
    <tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_IsInversed" aria-label="View IsInversed property in API reference">IsInversed</a> <br/>
		</td>
		<td>
			<a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a>
		</td>
		<td>Reverses the date or time direction so later values appear toward the minimum side and earlier values appear toward the maximum side.</td>
	</tr>
    <tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_LabelsPlacement" aria-label="View LabelsPlacement property in API reference">LabelsPlacement</a> <br/>
		</td>
		<td>
			<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderLabelsPlacement.html" aria-label="View SliderLabelsPlacement type in API reference">SliderLabelsPlacement</a>
		</td>
		<td>Controls where labels appear relative to the ticks. Values include <code>Inside</code> and <code>Outside</code>.</td>
	</tr>
    <tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_LabelStyle" aria-label="View LabelStyle property in API reference">LabelStyle</a> <br/>
		</td>
		<td>
			<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderLabelStyle.html" aria-label="View SliderLabelStyle type in API reference">SliderLabelStyle</a>
		</td>
		<td>Customizes the appearance of the displayed labels.</td>
	</tr>
    <tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_MajorTickStyle" aria-label="View MajorTickStyle property in API reference">MajorTickStyle</a> <br/>
		</td>
		<td>
			<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderTickStyle.html" aria-label="View SliderTickStyle type in API reference">SliderTickStyle</a>
		</td>
		<td>Customizes the appearance of the major ticks.</td>
	</tr>
    <tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_Maximum" aria-label="View Maximum property in API reference">Maximum</a> <br/>
		</td>
		<td>
			<a href="https://learn.microsoft.com/dotnet/api/system.datetime" aria-label="View DateTime type in API reference">DateTime</a>
		</td>
		<td>Limits the latest date that can be selected in the range selector.</td>
	</tr>
    <tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_Minimum" aria-label="View Minimum property in API reference">Minimum</a> <br/>
		</td>
		<td>
			<a href="https://learn.microsoft.com/dotnet/api/system.datetime" aria-label="View DateTime type in API reference">DateTime</a>
		</td>
		<td>Limits the earliest date that can be selected in the range selector.</td>
	</tr>
    <tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_MinorTicksPerInterval" aria-label="View MinorTicksPerInterval property in API reference">MinorTicksPerInterval</a> <br/>
		</td>
		<td>
			<a href="https://learn.microsoft.com/dotnet/api/system.int32" aria-label="View int type in API reference">int</a>
		</td>
		<td>Defines the number of minor ticks displayed between two major ticks.</td>
	</tr>
    <tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_MinorTickStyle" aria-label="View MinorTickStyle property in API reference">MinorTickStyle</a> <br/>
		</td>
		<td>
			<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderTickStyle.html" aria-label="View SliderTickStyle type in API reference">SliderTickStyle</a>
		</td>
		<td>Customizes the appearance of the minor ticks.</td>
	</tr>
    <tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_ShowDividers" aria-label="View ShowDividers property in API reference">ShowDividers</a> <br/>
		</td>
		<td>
			<a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a>
		</td>
		<td>Determines whether dividers are visible.</td>
	</tr>
    <tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_ShowLabels" aria-label="View ShowLabels property in API reference">ShowLabels</a> <br/>
		</td>
		<td>
			<a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a>
		</td>
		<td>Determines whether the date labels are visible.</td>
	</tr>
    <tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_ShowTicks" aria-label="View ShowTicks property in API reference">ShowTicks</a> <br/>
		</td>
		<td>
			<a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a>
		</td>
		<td>Determines whether the tick marks are visible.</td>
	</tr>
    <tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_ThumbOverlayStyle" aria-label="View ThumbOverlayStyle property in API reference">ThumbOverlayStyle</a> <br/>
		</td>
		<td>
			<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderThumbOverlayStyle.html" aria-label="View SliderThumbOverlayStyle type in API reference">SliderThumbOverlayStyle</a>
		</td>
		<td>Customizes the appearance of the thumb overlay.</td>
	</tr>
    <tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_ThumbStyle" aria-label="View ThumbStyle property in API reference">ThumbStyle</a> <br/>
		</td>
		<td>
			<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderThumbStyle.html" aria-label="View SliderThumbStyle type in API reference">SliderThumbStyle</a>
		</td>
		<td>Customizes the appearance of the start and end thumbs.</td>
	</tr>
    <tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_Tooltip" aria-label="View Tooltip property in API reference">Tooltip</a> <br/>
		</td>
		<td>
			<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderTooltip.html" aria-label="View SliderTooltip type in API reference">SliderTooltip</a>
		</td>
		<td>Customizes the tooltip shown during dragging.</td>
	</tr>
    <tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_TrackExtent" aria-label="View TrackExtent property in API reference">TrackExtent</a> <br/>
		</td>
		<td>
			<a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View double type in API reference">double</a>
		</td>
		<td>Controls how far the track extends beyond the thumb on each side, in device-independent units. Larger values increase the visible length of the track.</td>
	</tr>
    <tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_TrackStyle" aria-label="View TrackStyle property in API reference">TrackStyle</a> <br/>
		</td>
		<td>
			<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderTrackStyle.html" aria-label="View SliderTrackStyle type in API reference">SliderTrackStyle</a>
		</td>
		<td>Customizes the appearance of the selector track.</td>
	</tr>
</table>

### Events

<table>
	<tr>
		<th>
			Name<br/>
		</th>
		<th>
			Type<br/>
		</th>
		<th>
			Description<br/>
		</th>
	</tr>
	<tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SfDateTimeRangeSelector.html#Syncfusion_Maui_Sliders_SfDateTimeRangeSelector_ValueChanged" aria-label="View ValueChanged event in API reference">ValueChanged</a>  <br/>
		</td>
		<td>
			<a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View DateTimeRangeSelectorValueChangedEventArgs type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.DateTimeRangeSelectorValueChangedEventArgs.html" aria-label="View SliderLabelCreatedEventArgs type in API reference">DateTimeRangeSelectorValueChangedEventArgs&gt;</a>
		</td>
		<td>Triggered after the selected date or time range changes and the current range-selection operation is completed.</td>
	</tr>
	<tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SfDateTimeRangeSelector.html#Syncfusion_Maui_Sliders_SfDateTimeRangeSelector_ValueChanging" aria-label="View ValueChanging event in API reference">ValueChanging</a>  <br/>
		</td>
		<td>
			<a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View DateTimeRangeSelectorValueChangingEventArgs type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.DateTimeRangeSelectorValueChangingEventArgs.html" aria-label="View SliderLabelCreatedEventArgs type in API reference">DateTimeRangeSelectorValueChangingEventArgs&gt;</a>
		</td>
		<td>Triggered while a thumb is being dragged and the selected date or time range is actively changing.</td>
	</tr>
	<tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_LabelCreated" aria-label="View LabelCreated event in API reference">LabelCreated</a>  <br/>
		</td>
		<td>
			<a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View SliderLabelCreatedEventArgs type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_LabelCreated" aria-label="View SliderLabelCreatedEventArgs type in API reference">SliderLabelCreatedEventArgs&gt;</a>
		</td>
		<td>Triggered when a date or time label is generated, allowing the displayed label text to be customized.</td>
	</tr>
</table>

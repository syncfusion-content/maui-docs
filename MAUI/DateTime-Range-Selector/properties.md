---
layout: post
title: Properties of .NET MAUI DateTime Range Selector control | Syncfusion®
description: This section explains about the properties and events with Syncfusion® .NET MAUI DateTime Range Selector control and more.
platform: maui
control: SfDateTimeRangeSelector
documentation: ug
---

# Properties in .NET MAUI DateTime Range Selector

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
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.IDateTimeElement.html#Syncfusion_Maui_Sliders_IDateTimeElement_DateFormat">DateFormat</a> <br/>
		</td>
		<td>
			<a href="https://learn.microsoft.com/dotnet/api/system.string">string</a>
		</td>
		<td>Formats the displayed date text.</td>
	</tr>
	<tr valign="top">		
		<td>
		  <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.IDateTimeElement.html#Syncfusion_Maui_Sliders_IDateTimeElement_IntervalType">IntervalType</a><br/>
		</td>
		<td>
			<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderDateIntervalType.html">SliderDateIntervalType</a>
		</td>
		<td>Defines the date interval used for the selector. Values include <code>Auto</code>, <code>Years</code>, <code>Months</code>, <code>Days</code>, and similar date-based options.</td>
	</tr>
	<tr valign="top">		
		<td>
		  <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.IDateTimeElement.html#Syncfusion_Maui_Sliders_IDateTimeElement_StepDuration">StepDuration</a><br/>
		</td>
		<td>
			<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderStepDuration.html">SliderStepDuration</a>
		</td>
		<td>Specifies the discrete date step used when the selector moves by fixed date intervals.</td>
	</tr>
	<tr valign="top">		
		<td>
		  <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeSliderBase-1.html#Syncfusion_Maui_Sliders_RangeSliderBase_1_DragBehavior">DragBehavior</a><br/>
		</td>
		<td>
			<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderDragBehavior.html">SliderDragBehavior</a>
		</td>
		<td>Controls how the start and end thumbs can be dragged. Values include <code>Free</code> and <code>BetweenThumbs</code>.</td>
		</td>
	</tr>
	<tr valign="top">		
		<td>
		  <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeSliderBase-1.html#Syncfusion_Maui_Sliders_RangeSliderBase_1_EnableIntervalSelection">EnableIntervalSelection</a><br/>
		</td>
		<td>
			<a href="https://learn.microsoft.com/dotnet/api/system.boolean">bool</a>
		</td>
		<td>Determines whether thumb movement snaps to interval steps.</td>
	</tr>
	<tr valign="top">		
		<td>
		  <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeSliderBase-1.html#Syncfusion_Maui_Sliders_RangeSliderBase_1_EndThumbIcon">EndThumbIcon</a><br/>
		</td>
		<td>
			<a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.imagesource">ImageSource</a>
		</td>
		<td>Sets the image displayed on the end thumb.</td>
	</tr>
	<tr valign="top">		
		<td>
		  <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeSliderBase-1.html#Syncfusion_Maui_Sliders_RangeSliderBase_1_RangeEnd">RangeEnd</a><br/>
		</td>
		<td>
			<a href="https://learn.microsoft.com/dotnet/api/system.datetime">DateTime</a>
		</td>
		<td>Sets the end value of the selected date range.</td>
	</tr>
	<tr valign="top">		
		<td>
		  <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeSliderBase-1.html#Syncfusion_Maui_Sliders_RangeSliderBase_1_RangeStart">RangeStart</a><br/>
		</td>
		<td>
			<a href="https://learn.microsoft.com/dotnet/api/system.datetime">DateTime</a>
		</td>
		<td>Sets the start value of the selected date range.</td>
	</tr>
	<tr valign="top">		
		<td>
		  <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeSliderBase-1.html#Syncfusion_Maui_Sliders_RangeSliderBase_1_StartThumbIcon">StartThumbIcon</a><br/>
		</td>
		<td>
			<a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.imagesource">ImageSource</a>
		</td>
		<td>Sets the image displayed on the start thumb.</td>
	</tr>
	<tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_DeferredUpdateDelay">DeferredUpdateDelay</a> <br/>
		</td>
		<td>
			<a href="https://learn.microsoft.com/dotnet/api/system.double">double</a>
		</td>
		<td>Specifies the delay, in milliseconds, before deferred updates are applied.</td>
	</tr>
    <tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_DividerStyle">DividerStyle</a> <br/>
		</td>
		<td>
			<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderDividerStyle.html">SliderDividerStyle</a>
		</td>
		<td>Customizes the appearance of the dividers between range elements.</td>
	</tr>
    <tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_DragCompletedCommand">DragCompletedCommand</a> <br/>
		</td>
		<td>
			<a href="https://learn.microsoft.com/dotnet/api/system.windows.input.icommand">ICommand</a>
		</td>
		<td>Executes when thumb dragging completes.</td>
	</tr>
    <tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_DragCompletedCommandParameter">DragCompletedCommandParameter</a> <br/>
		</td>
		<td>
			<a href="https://learn.microsoft.com/dotnet/api/system.object">object</a>
		</td>
		<td>Supplies the parameter passed to <code>DragCompletedCommand</code>.</td>
	</tr>
    <tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_DragStartedCommand">DragStartedCommand</a> <br/>
		</td>
		<td>
			<a href="https://learn.microsoft.com/dotnet/api/system.windows.input.icommand">ICommand</a>
		</td>
		<td>Executes when thumb dragging starts.</td>
	</tr>
    <tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_DragStartedCommandParameter">DragStartedCommandParameter</a> <br/>
		</td>
		<td>
			<a href="https://learn.microsoft.com/dotnet/api/system.object">object</a>
		</td>
		<td>Supplies the parameter passed to <code>DragStartedCommand</code>.</td>
	</tr>
    <tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_EdgeLabelsPlacement">EdgeLabelsPlacement</a> <br/>
		</td>
		<td>
			<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderEdgeLabelsPlacement.html">SliderEdgeLabelsPlacement</a>
		</td>
		<td>Controls where edge labels appear. Values include <code>Start</code>, <code>End</code>, and related placement options.</td>
	</tr>
    <tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_EnableDeferredUpdate">EnableDeferredUpdate</a> <br/>
		</td>
		<td>
			<a href="https://learn.microsoft.com/dotnet/api/system.boolean">bool</a>
		</td>
		<td>Determines whether selection updates are deferred until interaction ends.</td>
	</tr>
    <tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_EnableLiquidGlassEffect">EnableLiquidGlassEffect</a> <br/>
		</td>
		<td>
			<a href="https://learn.microsoft.com/dotnet/api/system.boolean">bool</a>
		</td>
		<td>Determines whether the liquid glass effect is enabled.</td>
	</tr>
    <tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_Interval">Interval</a> <br/>
		</td>
		<td>
			<a href="https://learn.microsoft.com/dotnet/api/system.double">double</a>
		</td>
		<td>Sets the interval between consecutive date positions on the selector.</td>
	</tr>
    <tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_IsInversed">IsInversed</a> <br/>
		</td>
		<td>
			<a href="https://learn.microsoft.com/dotnet/api/system.boolean">bool</a>
		</td>
		<td>Determines whether the date range direction is reversed.</td>
	</tr>
    <tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_LabelsPlacement">LabelsPlacement</a> <br/>
		</td>
		<td>
			<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderLabelsPlacement.html">SliderLabelsPlacement</a>
		</td>
		<td>Controls where labels appear relative to the ticks. Values include <code>Inside</code> and <code>Outside</code>.</td>
	</tr>
    <tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_LabelStyle">LabelStyle</a> <br/>
		</td>
		<td>
			<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderLabelStyle.html">SliderLabelStyle</a>
		</td>
		<td>Customizes the appearance of the displayed labels.</td>
	</tr>
    <tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_MajorTickStyle">MajorTickStyle</a> <br/>
		</td>
		<td>
			<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderTickStyle.html">SliderTickStyle</a>
		</td>
		<td>Customizes the appearance of the major ticks.</td>
	</tr>
    <tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_Maximum">Maximum</a> <br/>
		</td>
		<td>
			<a href="https://learn.microsoft.com/dotnet/api/system.datetime">DateTime</a>
		</td>
		<td>Sets the upper date boundary of the selector.</td>
	</tr>
    <tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_Minimum">Minimum</a> <br/>
		</td>
		<td>
			<a href="https://learn.microsoft.com/dotnet/api/system.datetime">DateTime</a>
		</td>
		<td>Sets the lower date boundary of the selector.</td>
	</tr>
    <tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_MinorTicksPerInterval">MinorTicksPerInterval</a> <br/>
		</td>
		<td>
			<a href="https://learn.microsoft.com/dotnet/api/system.int32">int</a>
		</td>
		<td>Sets the number of minor ticks displayed between two major ticks.</td>
	</tr>
    <tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_MinorTickStyle">MinorTickStyle</a> <br/>
		</td>
		<td>
			<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderTickStyle.html">SliderTickStyle</a>
		</td>
		<td>Customizes the appearance of the minor ticks.</td>
	</tr>
    <tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_ShowDividers">ShowDividers</a> <br/>
		</td>
		<td>
			<a href="https://learn.microsoft.com/dotnet/api/system.boolean">bool</a>
		</td>
		<td>Determines whether dividers are visible.</td>
	</tr>
    <tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_ShowLabels">ShowLabels</a> <br/>
		</td>
		<td>
			<a href="https://learn.microsoft.com/dotnet/api/system.boolean">bool</a>
		</td>
		<td>Determines whether the date labels are visible.</td>
	</tr>
    <tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_ShowTicks">ShowTicks</a> <br/>
		</td>
		<td>
			<a href="https://learn.microsoft.com/dotnet/api/system.boolean">bool</a>
		</td>
		<td>Determines whether the tick marks are visible.</td>
	</tr>
    <tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_ThumbOverlayStyle">ThumbOverlayStyle</a> <br/>
		</td>
		<td>
			<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderThumbOverlayStyle.html">SliderThumbOverlayStyle</a>
		</td>
		<td>Customizes the appearance of the thumb overlay.</td>
	</tr>
    <tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_ThumbStyle">ThumbStyle</a> <br/>
		</td>
		<td>
			<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderThumbStyle.html">SliderThumbStyle</a>
		</td>
		<td>Customizes the appearance of the start and end thumbs.</td>
	</tr>
    <tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_Tooltip">Tooltip</a> <br/>
		</td>
		<td>
			<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderTooltip.html">SliderTooltip</a>
		</td>
		<td>Customizes the tooltip shown during dragging.</td>
	</tr>
    <tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_TrackExtent">TrackExtent</a> <br/>
		</td>
		<td>
			<a href="https://learn.microsoft.com/dotnet/api/system.double">double</a>
		</td>
		<td>Sets the track edge extension in device-independent units.</td>
	</tr>
    <tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_TrackStyle">TrackStyle</a> <br/>
		</td>
		<td>
			<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderTrackStyle.html">SliderTrackStyle</a>
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
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SfDateTimeRangeSelector.html#Syncfusion_Maui_Sliders_SfDateTimeRangeSelector_ValueChanged">ValueChanged</a>  <br/>
		</td>
		<td>
			<a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1">EventHandler&lt;DateTimeRangeSelectorValueChangedEventArgs&gt;</a>
		</td>
		<td>Occurs when the selected date range changes after the interaction ends.</td>
	</tr>
	<tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SfDateTimeRangeSelector.html#Syncfusion_Maui_Sliders_SfDateTimeRangeSelector_ValueChanging">ValueChanging</a>  <br/>
		</td>
		<td>
			<a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1">EventHandler&lt;DateTimeRangeSelectorValueChangingEventArgs&gt;</a>
		</td>
		<td>Occurs while the user is dragging a thumb to a new date range value.</td>
	</tr>
	<tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_LabelCreated">LabelCreated</a>  <br/>
		</td>
		<td>
			<a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1">EventHandler&lt;SliderLabelCreatedEventArgs&gt;</a>
		</td>
		<td>Occurs when a label is created so the text can be formatted or updated.</td>
	</tr>
    <tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_ValueChangeEnd">ValueChangeEnd</a>  <br/>
		</td>
		<td>
			<a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1">EventHandler&lt;DateTimeRangeSelectorValueChangedEventArgs&gt;</a>
		</td>
		<td>Occurs when the range selection interaction ends.</td>
	</tr>
    <tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_ValueChangeStart">ValueChangeStart</a>  <br/>
		</td>
		<td>
			<a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1">EventHandler&lt;DateTimeRangeSelectorValueChangedEventArgs&gt;</a>
		</td>
		<td>Occurs when range selection starts.</td>
	</tr>
</table>

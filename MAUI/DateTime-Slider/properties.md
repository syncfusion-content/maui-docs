---
layout: post
title: Properties in .NET MAUI DateTime Slider | Syncfusion®
description: Learn about the properties and events available in the Syncfusion® .NET MAUI DateTime Slider control.
platform: maui
control: SfDateTimeSlider
documentation: ug
---

# API Reference for .NET MAUI DateTime Slider

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
		<td>Formats the label text shown for each date value on the slider.</td>
	</tr>
	<tr valign="top">		
		<td>
		  <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.IDateTimeElement.html#Syncfusion_Maui_Sliders_IDateTimeElement_IntervalType" aria-label="View IntervalType property in API reference">IntervalType</a><br/>
		</td>
		<td>
			<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderDateIntervalType.html" aria-label="View SliderDateIntervalType type in API reference">SliderDateIntervalType</a>
		</td>
		<td>Defines how the slider groups dates along the track, such as <code>Auto</code>, <code>Days</code>, <code>Months</code>, or <code>Years</code>.</td>
	</tr>
	<tr valign="top">		
		<td>
		  <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.IDateTimeElement.html#Syncfusion_Maui_Sliders_IDateTimeElement_StepDuration" aria-label="View StepDuration property in API reference">StepDuration</a><br/>
		</td>
		<td>
			<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderStepDuration.html" aria-label="View SliderStepDuration type in API reference">SliderStepDuration</a>
		</td>
		<td>Specifies the step used for discrete date selection when the thumb moves between valid date values.</td>
	</tr>
	<tr valign="top">	
		<td>
		<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderBase-1.html#Syncfusion_Maui_Sliders_SliderBase_1_Orientation" aria-label="View Orientation property in API reference">Orientation</a> <br/>
		</td>
		<td>
			<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderOrientation.html" aria-label="View SliderOrientation type in API reference">SliderOrientation</a>
		</td>
		<td>Sets the layout direction of the slider to <code>Horizontal</code> or <code>Vertical</code>.</td>
	</tr>
    <tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderBase-1.html#Syncfusion_Maui_Sliders_SliderBase_1_ThumbIcon" aria-label="View ThumbIcon property in API reference">ThumbIcon</a> <br/>
		</td>
		<td>
			<a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.imagesource" aria-label="View ImageSource type in API reference">ImageSource</a>
		</td>
		<td>Sets the image displayed inside the thumb.</td>
	</tr>
    <tr valign="top">		
		<td>
		  <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderBase-1.html#Syncfusion_Maui_Sliders_SliderBase_1_Value" aria-label="View Value property in API reference">Value</a><br/>
		</td>
		<td>
			<a href="https://learn.microsoft.com/dotnet/api/system.datetime" aria-label="View DateTime type in API reference">DateTime</a>
		</td>
		<td>Controls the currently selected date or time represented by the thumb position.</td>
	</tr>
	<tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_DeferredUpdateDelay" aria-label="View DeferredUpdateDelay property in API reference">DeferredUpdateDelay</a> <br/>
		</td>
		<td>
			<a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View double type in API reference">double</a>
		</td>
		<td>Controls how long the control waits before applying deferred value updates when deferred update mode is enabled. The value is specified in milliseconds.</td>
	</tr>
    <tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_DividerStyle" aria-label="View DividerStyle property in API reference">DividerStyle</a> <br/>
		</td>
		<td>
			<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderDividerStyle.html" aria-label="View SliderDividerStyle type in API reference">SliderDividerStyle</a>
		</td>
		<td>Customizes the divider appearance between the selected range and the unselected track.</td>
	</tr>
    <tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_DragCompletedCommand" aria-label="View DragCompletedCommand property in API reference">DragCompletedCommand</a> <br/>
		</td>
		<td>
			<a href="https://learn.microsoft.com/dotnet/api/system.windows.input.icommand" aria-label="View ICommand type in API reference">ICommand</a>
		</td>
		<td>Runs when thumb dragging ends.</td>
	</tr>
    <tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_DragCompletedCommandParameter" aria-label="View DragCompletedCommandParameter property in API reference">DragCompletedCommandParameter</a> <br/>
		</td>
		<td>
			<a href="https://learn.microsoft.com/dotnet/api/system.object" aria-label="View object type in API reference">object</a>
		</td>
		<td>Provides the parameter passed to <code>DragCompletedCommand</code>.</td>
	</tr>
    <tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_DragStartedCommand" aria-label="View DragStartedCommand property in API reference">DragStartedCommand</a> <br/>
		</td>
		<td>
			<a href="https://learn.microsoft.com/dotnet/api/system.windows.input.icommand" aria-label="View ICommand type in API reference">ICommand</a>
		</td>
		<td>Runs when thumb dragging begins.</td>
	</tr>
    <tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_DragStartedCommandParameter" aria-label="View DragStartedCommandParameter property in API reference">DragStartedCommandParameter</a> <br/>
		</td>
		<td>
			<a href="https://learn.microsoft.com/dotnet/api/system.object" aria-label="View object type in API reference">object</a>
		</td>
		<td>Provides the parameter passed to <code>DragStartedCommand</code>.</td>
	</tr>
    <tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_EdgeLabelsPlacement" aria-label="View EdgeLabelsPlacement property in API reference">EdgeLabelsPlacement</a> <br/>
		</td>
		<td>
			<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderEdgeLabelsPlacement.html" aria-label="View SliderEdgeLabelsPlacement type in API reference">SliderEdgeLabelsPlacement</a>
		</td>
		<td>Controls where the first and last labels appear on the slider track, such as <code>Inside</code> or <code>Outside</code>.</td>
	</tr>
    <tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_EnableDeferredUpdate" aria-label="View EnableDeferredUpdate property in API reference">EnableDeferredUpdate</a> <br/>
		</td>
		<td>
			<a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a>
		</td>
		<td>Defines whether value updates are deferred until interaction completes.</td>
	</tr>
    <tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_EnableLiquidGlassEffect" aria-label="View EnableLiquidGlassEffect property in API reference">EnableLiquidGlassEffect</a> <br/>
		</td>
		<td>
			<a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a>
		</td>
		<td>Determines whether the liquid glass visual effect is shown.</td>
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
		<td>Controls where labels appear relative to the ticks, such as <code>None</code>, <code>Inside</code>, or <code>Outside</code>.</td>
	</tr>
    <tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_LabelStyle" aria-label="View LabelStyle property in API reference">LabelStyle</a> <br/>
		</td>
		<td>
			<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderLabelStyle.html" aria-label="View SliderLabelStyle type in API reference">SliderLabelStyle</a>
		</td>
		<td>Customizes the appearance of the slider labels.</td>
	</tr>
    <tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_MajorTickStyle" aria-label="View MajorTickStyle property in API reference">MajorTickStyle</a> <br/>
		</td>
		<td>
			<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderTickStyle.html" aria-label="View SliderTickStyle type in API reference">SliderTickStyle</a>
		</td>
		<td>Customizes the appearance of the major ticks on the track.</td>
	</tr>
    <tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_Maximum" aria-label="View Maximum property in API reference">Maximum</a> <br/>
		</td>
		<td>
			<a href="https://learn.microsoft.com/dotnet/api/system.datetime" aria-label="View DateTime type in API reference">DateTime</a>
		</td>
		<td>Defines the latest date or time that can be selected on the track.</td>
	</tr>
    <tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_Minimum" aria-label="View Minimum property in API reference">Minimum</a> <br/>
		</td>
		<td>
			<a href="https://learn.microsoft.com/dotnet/api/system.datetime" aria-label="View DateTime type in API reference">DateTime</a>
		</td>
		<td>Defines the earliest date or time that can be selected on the track.</td>
	</tr>
    <tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_MinorTicksPerInterval" aria-label="View MinorTicksPerInterval property in API reference">MinorTicksPerInterval</a> <br/>
		</td>
		<td>
			<a href="https://learn.microsoft.com/dotnet/api/system.int32" aria-label="View int type in API reference">int</a>
		</td>
		<td>Controls the number of minor tick marks displayed between adjacent major tick marks. Higher values show more intermediate tick marks along the slider track.</td>
	</tr>
    <tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_MinorTickStyle" aria-label="View MinorTickStyle property in API reference">MinorTickStyle</a> <br/>
		</td>
		<td>
			<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderTickStyle.html" aria-label="View SliderTickStyle type in API reference">SliderTickStyle</a>
		</td>
		<td>Customizes the appearance of the minor ticks on the track.</td>
	</tr>
    <tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_ShowDividers" aria-label="View ShowDividers property in API reference">ShowDividers</a> <br/>
		</td>
		<td>
			<a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a>
		</td>
		<td>Defines whether dividers are shown between the selected range and the remaining track.</td>
	</tr>
    <tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_ShowLabels" aria-label="View ShowLabels property in API reference">ShowLabels</a> <br/>
		</td>
		<td>
			<a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a>
		</td>
		<td>Determines whether date labels are visible on the slider.</td>
	</tr>
    <tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_ShowTicks" aria-label="View ShowTicks property in API reference">ShowTicks</a> <br/>
		</td>
		<td>
			<a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a>
		</td>
		<td>Determines whether ticks are visible on the slider track.</td>
	</tr>
    <tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_ThumbOverlayStyle" aria-label="View ThumbOverlayStyle property in API reference">ThumbOverlayStyle</a> <br/>
		</td>
		<td>
			<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderThumbOverlayStyle.html" aria-label="View SliderThumbOverlayStyle type in API reference">SliderThumbOverlayStyle</a>
		</td>
		<td>Customizes the appearance of the overlay displayed around the thumb during interaction.</td>
	</tr>
    <tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_ThumbStyle" aria-label="View ThumbStyle property in API reference">ThumbStyle</a> <br/>
		</td>
		<td>
			<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderThumbStyle.html" aria-label="View SliderThumbStyle type in API reference">SliderThumbStyle</a>
		</td>
		<td>Customizes the appearance of the slider thumb.</td>
	</tr>
    <tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_Tooltip" aria-label="View Tooltip property in API reference">Tooltip</a> <br/>
		</td>
		<td>
			<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderTooltip.html" aria-label="View SliderTooltip type in API reference">SliderTooltip</a>
		</td>
		<td>Customizes the appearance of the date or time tooltip displayed for the thumb.</td>
	</tr>
    <tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_TrackExtent" aria-label="View TrackExtent property in API reference">TrackExtent</a> <br/>
		</td>
		<td>
			<a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View double type in API reference">double</a>
		</td>
		<td>Extends the track beyond its normal start and end edges by the specified number of pixels.</td>
	</tr>
    <tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_TrackStyle" aria-label="View TrackStyle property in API reference">TrackStyle</a> <br/>
		</td>
		<td>
			<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderTrackStyle.html" aria-label="View SliderTrackStyle type in API reference">SliderTrackStyle</a>
		</td>
		<td>Customizes the appearance of the track, including the selected and unselected portions.</td>
	</tr>
</table>

## Events

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
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SfDateTimeSlider.html#Syncfusion_Maui_Sliders_SfDateTimeSlider_ValueChanged" aria-label="View ValueChanged event in API reference">ValueChanged</a>  <br/>
		</td>
		<td>
			<a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler type in API reference">EventHandler&lt;DateTimeSliderValueChangedEventArgs&gt;</a>
		</td>
		<td>Triggered after the selected date or time changes and the current selection operation is completed.</td>
	</tr>
	<tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SfDateTimeSlider.html#Syncfusion_Maui_Sliders_SfDateTimeSlider_ValueChanging" aria-label="View ValueChanging event in API reference">ValueChanging</a>  <br/>
		</td>
		<td>
			<a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler type in API reference">EventHandler&lt;DateTimeSliderValueChangingEventArgs&gt;</a>
		</td>
		<td>Triggered while the thumb is being dragged and the selected date or time is actively changing.</td>
	</tr>
</table>


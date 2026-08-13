---
layout: post
title: Properties in .NET MAUI DateTime Slider | Syncfusion®
description: Learn about the properties and events available in the Syncfusion® .NET MAUI DateTime Slider control.
platform: maui
control: SfDateTimeSlider
documentation: ug
---

# Properties in .NET MAUI DateTime Slider

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
		<td>Formats the label text shown for each date value on the slider.</td>
	</tr>
	<tr valign="top">		
		<td>
		  <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.IDateTimeElement.html#Syncfusion_Maui_Sliders_IDateTimeElement_IntervalType">IntervalType</a><br/>
		</td>
		<td>
			<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderDateIntervalType.html">SliderDateIntervalType</a>
		</td>
		<td>Defines how the slider groups dates along the track, such as <code>Auto</code>, <code>Days</code>, <code>Months</code>, or <code>Years</code>.</td>
	</tr>
	<tr valign="top">		
		<td>
		  <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.IDateTimeElement.html#Syncfusion_Maui_Sliders_IDateTimeElement_StepDuration">StepDuration</a><br/>
		</td>
		<td>
			<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderStepDuration.html">SliderStepDuration</a>
		</td>
		<td>Specifies the step used for discrete date selection when the thumb moves between valid date values.</td>
	</tr>
	<tr valign="top">	
		<td>
		<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderBase-1.html#Syncfusion_Maui_Sliders_SliderBase_1_Orientation">Orientation</a> <br/>
		</td>
		<td>
			<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderOrientation.html">SliderOrientation</a>
		</td>
		<td>Sets the layout direction of the slider to <code>Horizontal</code> or <code>Vertical</code>.</td>
	</tr>
    <tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderBase-1.html#Syncfusion_Maui_Sliders_SliderBase_1_ThumbIcon">ThumbIcon</a> <br/>
		</td>
		<td>
			<a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.imagesource">ImageSource</a>
		</td>
		<td>Sets the image displayed inside the thumb.</td>
	</tr>
    <tr valign="top">		
		<td>
		  <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderBase-1.html#Syncfusion_Maui_Sliders_SliderBase_1_Value">Value</a><br/>
		</td>
		<td>
			<a href="https://learn.microsoft.com/dotnet/api/system.datetime">DateTime</a>
		</td>
		<td>Gets or sets the currently selected date value on the slider.</td>
	</tr>
	<tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_DeferredUpdateDelay">DeferredUpdateDelay</a> <br/>
		</td>
		<td>
			<a href="https://learn.microsoft.com/dotnet/api/system.double">double</a>
		</td>
		<td>Sets the delay, in milliseconds, before deferred updates are applied.</td>
	</tr>
    <tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_DividerStyle">DividerStyle</a> <br/>
		</td>
		<td>
			<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderDividerStyle.html">SliderDividerStyle</a>
		</td>
		<td>Customizes the divider appearance between the selected range and the unselected track.</td>
	</tr>
    <tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_DragCompletedCommand">DragCompletedCommand</a> <br/>
		</td>
		<td>
			<a href="https://learn.microsoft.com/dotnet/api/system.windows.input.icommand">ICommand</a>
		</td>
		<td>Runs when thumb dragging ends.</td>
	</tr>
    <tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_DragCompletedCommandParameter">DragCompletedCommandParameter</a> <br/>
		</td>
		<td>
			<a href="https://learn.microsoft.com/dotnet/api/system.object">object</a>
		</td>
		<td>Provides the parameter passed to <code>DragCompletedCommand</code>.</td>
	</tr>
    <tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_DragStartedCommand">DragStartedCommand</a> <br/>
		</td>
		<td>
			<a href="https://learn.microsoft.com/dotnet/api/system.windows.input.icommand">ICommand</a>
		</td>
		<td>Runs when thumb dragging begins.</td>
	</tr>
    <tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_DragStartedCommandParameter">DragStartedCommandParameter</a> <br/>
		</td>
		<td>
			<a href="https://learn.microsoft.com/dotnet/api/system.object">object</a>
		</td>
		<td>Provides the parameter passed to <code>DragStartedCommand</code>.</td>
	</tr>
    <tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_EdgeLabelsPlacement">EdgeLabelsPlacement</a> <br/>
		</td>
		<td>
			<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderEdgeLabelsPlacement.html">SliderEdgeLabelsPlacement</a>
		</td>
		<td>Controls where the first and last labels appear on the slider track, such as <code>Inside</code> or <code>Outside</code>.</td>
	</tr>
    <tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_EnableDeferredUpdate">EnableDeferredUpdate</a> <br/>
		</td>
		<td>
			<a href="https://learn.microsoft.com/dotnet/api/system.boolean">bool</a>
		</td>
		<td>Determines whether value updates are deferred until interaction completes.</td>
	</tr>
    <tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_EnableLiquidGlassEffect">EnableLiquidGlassEffect</a> <br/>
		</td>
		<td>
			<a href="https://learn.microsoft.com/dotnet/api/system.boolean">bool</a>
		</td>
		<td>Determines whether the liquid glass visual effect is shown.</td>
	</tr>
    <tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_Interval">Interval</a> <br/>
		</td>
		<td>
			<a href="https://learn.microsoft.com/dotnet/api/system.double">double</a>
		</td>
		<td>Sets the interval between major positions on the track.</td>
	</tr>
    <tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_IsInversed">IsInversed</a> <br/>
		</td>
		<td>
			<a href="https://learn.microsoft.com/dotnet/api/system.boolean">bool</a>
		</td>
		<td>Reverses the slider direction so values increase in the opposite direction.</td>
	</tr>
    <tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_LabelsPlacement">LabelsPlacement</a> <br/>
		</td>
		<td>
			<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderLabelsPlacement.html">SliderLabelsPlacement</a>
		</td>
		<td>Controls where labels appear relative to the ticks, such as <code>None</code>, <code>Inside</code>, or <code>Outside</code>.</td>
	</tr>
    <tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_LabelStyle">LabelStyle</a> <br/>
		</td>
		<td>
			<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderLabelStyle.html">SliderLabelStyle</a>
		</td>
		<td>Customizes the appearance of the slider labels.</td>
	</tr>
    <tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_MajorTickStyle">MajorTickStyle</a> <br/>
		</td>
		<td>
			<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderTickStyle.html">SliderTickStyle</a>
		</td>
		<td>Customizes the appearance of the major ticks on the track.</td>
	</tr>
    <tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_Maximum">Maximum</a> <br/>
		</td>
		<td>
			<a href="https://learn.microsoft.com/dotnet/api/system.datetime">DateTime</a>
		</td>
		<td>Sets the latest date that can be selected on the slider.</td>
	</tr>
    <tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_Minimum">Minimum</a> <br/>
		</td>
		<td>
			<a href="https://learn.microsoft.com/dotnet/api/system.datetime">DateTime</a>
		</td>
		<td>Sets the earliest date that can be selected on the slider.</td>
	</tr>
    <tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_MinorTicksPerInterval">MinorTicksPerInterval</a> <br/>
		</td>
		<td>
			<a href="https://learn.microsoft.com/dotnet/api/system.int32">int</a>
		</td>
		<td>Sets the number of minor ticks shown between major ticks.</td>
	</tr>
    <tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_MinorTickStyle">MinorTickStyle</a> <br/>
		</td>
		<td>
			<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderTickStyle.html">SliderTickStyle</a>
		</td>
		<td>Customizes the appearance of the minor ticks on the track.</td>
	</tr>
    <tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_ShowDividers">ShowDividers</a> <br/>
		</td>
		<td>
			<a href="https://learn.microsoft.com/dotnet/api/system.boolean">bool</a>
		</td>
		<td>Determines whether dividers are shown between the selected range and the remaining track.</td>
	</tr>
    <tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_ShowLabels">ShowLabels</a> <br/>
		</td>
		<td>
			<a href="https://learn.microsoft.com/dotnet/api/system.boolean">bool</a>
		</td>
		<td>Determines whether date labels are visible on the slider.</td>
	</tr>
    <tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_ShowTicks">ShowTicks</a> <br/>
		</td>
		<td>
			<a href="https://learn.microsoft.com/dotnet/api/system.boolean">bool</a>
		</td>
		<td>Determines whether ticks are visible on the slider track.</td>
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
		<td>Customizes the appearance of the slider thumb.</td>
	</tr>
    <tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_Tooltip">Tooltip</a> <br/>
		</td>
		<td>
			<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderTooltip.html">SliderTooltip</a>
		</td>
		<td>Customizes the tooltip shown while the thumb is being dragged.</td>
	</tr>
    <tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_TrackExtent">TrackExtent</a> <br/>
		</td>
		<td>
			<a href="https://learn.microsoft.com/dotnet/api/system.double">double</a>
		</td>
		<td>Sets how far the track extends beyond the thumb bounds in device-independent units.</td>
	</tr>
    <tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_TrackStyle">TrackStyle</a> <br/>
		</td>
		<td>
			<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderTrackStyle.html">SliderTrackStyle</a>
		</td>
		<td>Customizes the appearance of the slider track.</td>
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
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SfDateTimeSlider.html#Syncfusion_Maui_Sliders_SfDateTimeSlider_ValueChanged">ValueChanged</a>  <br/>
		</td>
		<td>
			<a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1">EventHandler&lt;DateTimeSliderValueChangedEventArgs&gt;</a>
		</td>
		<td>Occurs when the user completes a value selection.</td>
	</tr>
	<tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SfDateTimeSlider.html#Syncfusion_Maui_Sliders_SfDateTimeSlider_ValueChanging">ValueChanging</a>  <br/>
		</td>
		<td>
			<a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1">EventHandler&lt;DateTimeSliderValueChangingEventArgs&gt;</a>
		</td>
		<td>Occurs while the thumb is being dragged to a new date value.</td>
	</tr>
</table>


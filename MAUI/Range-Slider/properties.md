---
layout: post
title: Properties of .NET MAUI Range Slider control | Syncfusion®
description: This section explains about the properties and events with Syncfusion® MAUI Range Slider (SfRangeSlider) control and more.
platform: maui
control: SfRangeSlider
documentation: ug
---

# .NET MAUI Range Slider API Reference

## Properties

<table>
	<tr>
		<th>Name<br/></th>
		<th>Type<br/></th>
		<th>Description<br/></th>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeSliderBase-1.html#Syncfusion_Maui_Sliders_RangeSliderBase_1_DragBehavior">DragBehavior</a></td>
		<td>SliderDragBehavior</td>
		<td>Gets or sets the value which indicates the behavior of the thumb dragging.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeSliderBase-1.html#Syncfusion_Maui_Sliders_RangeSliderBase_1_EnableIntervalSelection">EnableIntervalSelection</a></td>
		<td>bool</td>
		<td>Gets or sets a value indicating whether to drag the thumbs in intervals.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeSliderBase-1.html#Syncfusion_Maui_Sliders_RangeSliderBase_1_EndThumbIcon">EndThumbIcon</a></td>
		<td>string</td>
		<td>Gets or sets the value for the end thumb.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeSliderBase-1.html#Syncfusion_Maui_Sliders_RangeSliderBase_1_RangeEnd">RangeEnd</a></td>
		<td>double</td>
		<td>Gets or sets the range end value of the track.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeSliderBase-1.html#Syncfusion_Maui_Sliders_RangeSliderBase_1_RangeStart">RangeStart</a></td>
		<td>double</td>
		<td>Gets or sets the thumb start value of the track.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeSliderBase-1.html#Syncfusion_Maui_Sliders_RangeSliderBase_1_StartThumbIcon">StartThumbIcon</a></td>
		<td>string</td>
		<td>Gets or sets the value for the start thumb.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_DeferredUpdateDelay">DeferredUpdateDelay</a></td>
		<td>double</td>
		<td>Gets or sets the DeferredUpdateDelay, expressed in milliseconds, at which to update the deferred values.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_DividerStyle">DividerStyle</a></td>
		<td>SliderDividerStyle</td>
		<td>Gets or sets a value to customize the appearance of the divider shape.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_DragCompletedCommand">DragCompletedCommand</a></td>
		<td>ICommand</td>
		<td>Gets or sets the command that will be executed when the thumb movement is completed.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_DragCompletedCommandParameter">DragCompletedCommandParameter</a></td>
		<td>object</td>
		<td>Gets or sets the parameter for the DragCompletedCommand.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_DragStartedCommand">DragStartedCommand</a></td>
		<td>ICommand</td>
		<td>Gets or sets the command that will be executed when thumb movement starts.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_DragStartedCommandParameter">DragStartedCommandParameter</a></td>
		<td>object</td>
		<td>Gets or sets the parameter for the DragStartedCommand.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_EdgeLabelsPlacement">EdgeLabelsPlacement</a></td>
		<td>SliderEdgeLabelsPlacement</td>
		<td>Gets or sets the first and last label either inside the track bounds or on the intervals.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_EnableDeferredUpdate">EnableDeferredUpdate</a></td>
		<td>bool</td>
		<td>Gets or sets a value indicating whether to defer a selection.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_EnableLiquidGlassEffect">EnableLiquidGlassEffect</a></td>
		<td>bool</td>
		<td>Gets or sets a value indicating whether the liquid glass visual effect is enabled for the control.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_Interval">Interval</a></td>
		<td>double</td>
		<td>Gets or sets a value indicating the interval between the slider elements in the track.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_IsInversed">IsInversed</a></td>
		<td>bool</td>
		<td>Gets or sets a value indicating whether to inverse the slider.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_LabelsPlacement">LabelsPlacement</a></td>
		<td>SliderLabelsPlacement</td>
		<td>Gets or sets the value indicating whether to place the labels either between the major ticks or on the major ticks.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_LabelStyle">LabelStyle</a></td>
		<td>SliderLabelStyle</td>
		<td>Gets or sets a value to customize the appearance of the labels.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_MajorTickStyle">MajorTickStyle</a></td>
		<td>SliderTickStyle</td>
		<td>Gets or sets a value to customize the appearance of the major tick shape.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_Maximum">Maximum</a></td>
		<td>double</td>
		<td>Gets or sets the maximum value of the track. The track ends at this value.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_Minimum">Minimum</a></td>
		<td>double</td>
		<td>Gets or sets the minimum value of the track. The track starts from this value.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_MinorTicksPerInterval">MinorTicksPerInterval</a></td>
		<td>int</td>
		<td>Gets or sets the value indicating the number of smaller ticks between two major ticks.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_MinorTickStyle">MinorTickStyle</a></td>
		<td>SliderTickStyle</td>
		<td>Gets or sets a value to customize the appearance of the minor tick shape.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_ShowDividers">ShowDividers</a></td>
		<td>bool</td>
		<td>Gets or sets a value indicating whether to show or hide the dividers.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_ShowLabels">ShowLabels</a></td>
		<td>bool</td>
		<td>Gets or sets a value indicating whether to show or hide the labels.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_ShowTicks">ShowTicks</a></td>
		<td>bool</td>
		<td>Gets or sets a value indicating whether to show or hide the ticks.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_ThumbOverlayStyle">ThumbOverlayStyle</a></td>
		<td>SliderThumbOverlayStyle</td>
		<td>Gets or sets a value to customize the appearance of the thumb overlay shape.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_ThumbStyle">ThumbStyle</a></td>
		<td>SliderThumbStyle</td>
		<td>Gets or sets a value to customize the appearance of the thumb shape.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_Tooltip">Tooltip</a></td>
		<td>SliderTooltip</td>
		<td>Gets or sets a value to customize the appearance of the tooltip shape.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_TrackExtent">TrackExtent</a></td>
		<td>double</td>
		<td>Gets or sets the value in pixel for extending track edges.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_TrackStyle">TrackStyle</a></td>
		<td>SliderTrackStyle</td>
		<td>Gets or sets a value to customize the appearance of the track shape.</td>
	</tr>
</table>

## Methods

<table>
	<tr>
		<th>Name<br/></th>
		<th>Type<br/></th>
		<th>Description<br/></th>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_ValueChangeStart">ValueChangeStart()</a></td>
		<td>void</td>
		<td>Represents the ValueChangeStart event, which occurs when the user starts selecting a new range value.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_ValueChangeEnd">ValueChangeEnd()</a></td>
		<td>void</td>
		<td>Represents the ValueChangeEnd event, which occurs when the user completes selecting a new range value.</td>
	</tr>
</table>

## Events

<table>
	<tr>
		<th>Name<br/></th>
		<th>Type<br/></th>
		<th>Description<br/></th>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_ValueChangeStart">ValueChangeStart</a></td>
		<td>EventHandler&lt;RangeSliderValueChangingEventArgs&gt;</td>
		<td>Occurs when the user starts selecting a new range value.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_ValueChangeEnd">ValueChangeEnd</a></td>
		<td>EventHandler&lt;RangeSliderValueChangedEventArgs&gt;</td>
		<td>Occurs when the user completes selecting a new range value.</td>
	</tr>
</table>

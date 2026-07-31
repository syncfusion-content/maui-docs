---
layout: post
title: Properties of .NET MAUI DateTime Range Selector control | Syncfusion®
description: This section explains about the properties and events with Syncfusion® MAUI DateTime Range Selector (SfDateTimeRangeSelector) control and more.
platform: maui
control: SfDateTimeRangeSelector
documentation: ug
---

# .NET MAUI DateTime Range Selector API Reference

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
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SfDateTimeSlider.html#Syncfusion_Maui_Sliders_SfDateTimeSlider_DateFormat">DateFormat</a> <br/>
		</td>
		<td>
			string
		</td>
		<td>
        Gets or sets the value to format the date.
		</td>
	</tr>
	<tr valign="top">		
		<td>
		  <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SfDateTimeSlider.html#Syncfusion_Maui_Sliders_SfDateTimeSlider_IntervalType">IntervalType</a><br/>
		</td>
		<td>
			SliderDateIntervalType
		</td>
		<td>
		 Gets or sets the type of the date interval.
		</td>
	</tr>
	<tr valign="top">		
		<td>
		  <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SfDateTimeSlider.html#Syncfusion_Maui_Sliders_SfDateTimeSlider_StepDuration">StepDuration</a><br/>
		</td>
		<td>
			SliderStepDuration
		</td>
		<td>
		 Gets or set the value indication whether to select the discrete date value.
		</td>
	</tr>
	<tr valign="top">		
		<td>
		  <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeSliderBase-1.html#Syncfusion_Maui_Sliders_RangeSliderBase_1_DragBehavior">DragBehavior</a><br/>
		</td>
		<td>
			SliderDragBehavior
		</td>
		<td>
		 Gets or sets the value which indicates the behavior of the thumb dragging.
		</td>
	</tr>
	<tr valign="top">		
		<td>
		  <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeSliderBase-1.html#Syncfusion_Maui_Sliders_RangeSliderBase_1_EnableIntervalSelection">EnableIntervalSelection</a><br/>
		</td>
		<td>
			bool
		</td>
		<td>
		 Gets or set a value indicating whether to drag the thumbs in intervals.
		</td>
	</tr>
	<tr valign="top">		
		<td>
		  <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeSliderBase-1.html#Syncfusion_Maui_Sliders_RangeSliderBase_1_EndThumbIcon">EndThumbIcon</a><br/>
		</td>
		<td>
			ImageSource
		</td>
		<td>
		 Gets or sets the value for the end thumb.
		</td>
	</tr>
	<tr valign="top">		
		<td>
		  <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeSliderBase-1.html#Syncfusion_Maui_Sliders_RangeSliderBase_1_RangeEnd">RangeEnd</a><br/>
		</td>
		<td>
			DateTime
		</td>
		<td>
		 Gets or sets the range end value of the track.
		</td>
	</tr>
	<tr valign="top">		
		<td>
		  <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeSliderBase-1.html#Syncfusion_Maui_Sliders_RangeSliderBase_1_RangeStart">RangeStart</a><br/>
		</td>
		<td>
			DateTime
		</td>
		<td>
		 Gets or sets the thumb start value of the track.
		</td>
	</tr>
	<tr valign="top">		
		<td>
		  <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeSliderBase-1.html#Syncfusion_Maui_Sliders_RangeSliderBase_1_StartThumbIcon">StartThumbIcon</a><br/>
		</td>
		<td>
			ImageSource
		</td>
		<td>
		 Gets or sets the value for the start thumb.
		</td>
	</tr>
	<tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_DeferredUpdateDelay">DeferredUpdateDelay</a> <br/>
		</td>
		<td>
			double
		</td>
		<td>
		 Gets or sets the DeferredUpdateDelay, expressed in milliseconds, at which to update the deferred values.
		</td>
	</tr>
    <tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_DividerStyle">DividerStyle</a> <br/>
		</td>
		<td>
			SliderDividerStyle
		</td>
		<td>
		 Gets or sets a value to customize the appearance of the divider shape.
		</td>
	</tr>
    <tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_DragCompletedCommand">DragCompletedCommand</a> <br/>
		</td>
		<td>
			ICommand
		</td>
		<td>
		 Gets or sets the command that will be executed when we completed moving the thumb.
		</td>
	</tr>
    <tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_DragCompletedCommandParameter">DragCompletedCommandParameter</a> <br/>
		</td>
		<td>
			object
		</td>
		<td>
		 Gets or sets the parameter for the DragCompletedCommandParameter.
		</td>
	</tr>
    <tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_DragStartedCommand">DragStartedCommand</a> <br/>
		</td>
		<td>
			ICommand
		</td>
		<td>
		 Gets or sets the command that will be executed when we start moving the thumb.
		</td>
	</tr>
    <tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_DragStartedCommandParameter">DragStartedCommandParameter</a> <br/>
		</td>
		<td>
			object
		</td>
		<td>
		 Gets or sets the parameter for the DragStartedCommandParameter.
		</td>
	</tr>
    <tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_EdgeLabelsPlacement">EdgeLabelsPlacement</a> <br/>
		</td>
		<td>
			SliderEdgeLabelsPlacement
		</td>
		<td>
		 Gets or sets the first and last label either inside the track bounds or on the intervals.
		</td>
	</tr>
    <tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_EnableDeferredUpdate">EnableDeferredUpdate</a> <br/>
		</td>
		<td>
			bool
		</td>
		<td>
		 Gets or sets a value indicating whether to defer a selection.
		</td>
	</tr>
    <tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_EnableLiquidGlassEffect">EnableLiquidGlassEffect</a> <br/>
		</td>
		<td>
			bool
		</td>
		<td>
		 Gets or sets a value indicating whether the liquid glass visual effect is enabled for the control.
		</td>
	</tr>
    <tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_Interval">Interval</a> <br/>
		</td>
		<td>
			double
		</td>
		<td>
		 Gets or sets a value indicating the interval between the slider elements in the track.
		</td>
	</tr>
    <tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_IsInversed">IsInversed</a> <br/>
		</td>
		<td>
			bool
		</td>
		<td>
		 Gets or sets a value indicating whether to inverse the slider.
		</td>
	</tr>
    <tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_LabelsPlacement">LabelsPlacement</a> <br/>
		</td>
		<td>
			SliderLabelsPlacement
		</td>
		<td>
		 Gets or sets the value indicating whether to place the labels either between the major ticks or on the major ticks.
		</td>
	</tr>
    <tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_LabelStyle">LabelStyle</a> <br/>
		</td>
		<td>
			SliderLabelStyle
		</td>
		<td>
		Gets or sets a value to customize the appearance of the labels.
		</td>
	</tr>
    <tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_MajorTickStyle">MajorTickStyle</a> <br/>
		</td>
		<td>
			SliderTickStyle
		</td>
		<td>
		 Gets or sets a value to customize the appearance of the major tick shape.
		</td>
	</tr>
    <tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_Maximum">Maximum</a> <br/>
		</td>
		<td>
			DateTime
		</td>
		<td>
		 Gets or sets the maximum value of the track. The track ends at this value.
		</td>
	</tr>
    <tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_Minimum">Minimum</a> <br/>
		</td>
		<td>
			DateTime
		</td>
		<td>
		 Gets or sets the minimum value of the track. The track starts from this value.
		</td>
	</tr>
    <tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_MinorTicksPerInterval">MinorTicksPerInterval</a> <br/>
		</td>
		<td>
			int
		</td>
		<td>
		 Gets or sets the value indicating the number of smaller ticks between two major ticks.
		</td>
	</tr>
    <tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_MinorTickStyle">MinorTickStyle</a> <br/>
		</td>
		<td>
			SliderTickStyle
		</td>
		<td>
		 Gets or sets a value to customize the appearance of the minor tick shape.
		</td>
	</tr>
    <tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_ShowDividers">ShowDividers</a> <br/>
		</td>
		<td>
			bool
		</td>
		<td>
		 Gets or sets a value indicating whether to show or hide the dividers.
		</td>
	</tr>
    <tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_ShowLabels">ShowLabels</a> <br/>
		</td>
		<td>
			bool
		</td>
		<td>
		 Gets or sets a value indicating whether to show or hide the labels.
		</td>
	</tr>
    <tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_ShowTicks">ShowTicks</a> <br/>
		</td>
		<td>
			bool
		</td>
		<td>
		 Gets or sets a value indicating whether to show or hide the ticks.
		</td>
	</tr>
    <tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_ThumbOverlayStyle">ThumbOverlayStyle</a> <br/>
		</td>
		<td>
			SliderThumbOverlayStyle
		</td>
		<td>
		 Gets or sets a value to customize the appearance of the thumb overlay shape.
		</td>
	</tr>
    <tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_ThumbStyle">ThumbStyle</a> <br/>
		</td>
		<td>
			SliderThumbStyle
		</td>
		<td>
		Gets or sets a value to customize the appearance of the thumb shape.
		</td>
	</tr>
    <tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_Tooltip">Tooltip</a> <br/>
		</td>
		<td>
			SliderTooltip
		</td>
		<td>
		 Gets or sets a value to customize the appearance of the tooltip shape.
		</td>
	</tr>
    <tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_TrackExtent">TrackExtent</a> <br/>
		</td>
		<td>
			double
		</td>
		<td>
		 Gets or sets the value in pixel for extending track edges.
		</td>
	</tr>
    <tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_TrackStyle">TrackStyle</a> <br/>
		</td>
		<td>
			SliderTrackStyle
		</td>
		<td>
		 Gets or sets a value to customize the appearance of the track shape.
		</td>
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
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SfSlider.html#Syncfusion_Maui_Sliders_SfSlider_ValueChanged">ValueChanged</a>  <br/>
		</td>
		<td>
			EventHandler<DateTimeRangeSelectorValueChangedEventArgs>
		</td>
		<td>
        Represents the ValueChanged event, which occurs when the user is done selecting a new value for the slider.
		</td>
	</tr>
	<tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SfSlider.html#Syncfusion_Maui_Sliders_SfSlider_ValueChanging">ValueChanging</a>  <br/>
		</td>
		<td>
			EventHandler<DateTimeRangeSelectorValueChangingEventArgs>
		</td>
		<td>
		 Represents the ValueChanging event, which occurs when the user is selecting a new value for the Slider by dragging the thumb.
		</td>
	</tr>
	<tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_LabelCreated">LabelCreated</a>  <br/>
		</td>
		<td>
			EventHandler<SliderLabelCreatedEventArgs>
		</td>
		<td>
		 Represents the LabelCreated event, which occurs when a slider label is created. It is used to format or change the label text.
		</td>
	</tr>
    <tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_ValueChangeEnd">ValueChangeEnd</a>  <br/>
		</td>
		<td>
			EventHandler<DateTimeRangeSelectorValueChangedEventArgs>
		</td>
		<td>
		 Represents the ValueChangeEnd event, which occurs when the user completed selecting a new value by tap/mouse up in the thumb.
		</td>
	</tr>
    <tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_ValueChangeStart">ValueChangeStart</a>  <br/>
		</td>
		<td>
			EventHandler<DateTimeRangeSelectorValueChangingEventArgs>
		</td>
		<td>
		 Represents the ValueChangeStart event, which occurs when the user is selecting a new value by tap/mouse down in the thumb.
		</td>
	</tr>
</table>

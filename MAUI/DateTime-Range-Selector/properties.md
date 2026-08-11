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
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SfDateTimeSlider.html#Syncfusion_Maui_Sliders_SfDateTimeSlider_DateFormat">DateFormat</a> <br/>
		</td>
		<td>
			string
		</td>
		<td>Formats the date text.</td>
	</tr>
	<tr valign="top">		
		<td>
		  <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SfDateTimeSlider.html#Syncfusion_Maui_Sliders_SfDateTimeSlider_IntervalType">IntervalType</a><br/>
		</td>
		<td>
			SliderDateIntervalType
		</td>
		<td>Sets the date interval type.</td>
	</tr>
	<tr valign="top">		
		<td>
		  <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SfDateTimeSlider.html#Syncfusion_Maui_Sliders_SfDateTimeSlider_StepDuration">StepDuration</a><br/>
		</td>
		<td>
			SliderStepDuration
		</td>
		<td>Defines the step used for discrete date selection.</td>
	</tr>
	<tr valign="top">		
		<td>
		  <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeSliderBase-1.html#Syncfusion_Maui_Sliders_RangeSliderBase_1_DragBehavior">DragBehavior</a><br/>
		<td>Controls thumb dragging behavior.</td>
		<td>Enables interval-based thumb dragging.</td>
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
		<td>Sets the end thumb icon.</td>
	</tr>
	<tr valign="top">		
		<td>
		  <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeSliderBase-1.html#Syncfusion_Maui_Sliders_RangeSliderBase_1_RangeEnd">RangeEnd</a><br/>
		</td>
		<td>
			DateTime
		</td>
		<td>Sets the range end value.</td>
	</tr>
	<tr valign="top">		
		<td>
		  <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeSliderBase-1.html#Syncfusion_Maui_Sliders_RangeSliderBase_1_RangeStart">RangeStart</a><br/>
		</td>
		<td>
			DateTime
		</td>
		<td>Sets the range start value.</td>
	</tr>
	<tr valign="top">		
		<td>
		  <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeSliderBase-1.html#Syncfusion_Maui_Sliders_RangeSliderBase_1_StartThumbIcon">StartThumbIcon</a><br/>
		</td>
		<td>
			ImageSource
		</td>
		<td>Sets the start thumb icon.</td>
	</tr>
	<tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_DeferredUpdateDelay">DeferredUpdateDelay</a> <br/>
		</td>
		<td>
			double
		</td>
		<td>Sets the deferred update delay in milliseconds.</td>
	</tr>
    <tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_DividerStyle">DividerStyle</a> <br/>
		</td>
		<td>
			SliderDividerStyle
		</td>
		<td>Customizes the divider appearance.</td>
	</tr>
    <tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_DragCompletedCommand">DragCompletedCommand</a> <br/>
		</td>
		<td>
			ICommand
		</td>
		<td>Runs when thumb movement completes.</td>
	</tr>
    <tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_DragCompletedCommandParameter">DragCompletedCommandParameter</a> <br/>
		</td>
		<td>
			object
		</td>
		<td>Supplies the drag completed command parameter.</td>
	</tr>
    <tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_DragStartedCommand">DragStartedCommand</a> <br/>
		</td>
		<td>
			ICommand
		</td>
		<td>Runs when thumb movement starts.</td>
	</tr>
    <tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_DragStartedCommandParameter">DragStartedCommandParameter</a> <br/>
		</td>
		<td>
			object
		</td>
		<td>Supplies the drag started command parameter.</td>
	</tr>
    <tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_EdgeLabelsPlacement">EdgeLabelsPlacement</a> <br/>
		</td>
		<td>
			SliderEdgeLabelsPlacement
		</td>
		<td>Controls the placement of edge labels.</td>
	</tr>
    <tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_EnableDeferredUpdate">EnableDeferredUpdate</a> <br/>
		</td>
		<td>
			bool
		</td>
		<td>Enables deferred selection updates.</td>
	</tr>
    <tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_EnableLiquidGlassEffect">EnableLiquidGlassEffect</a> <br/>
		</td>
		<td>
			bool
		</td>
		<td>Enables the liquid glass effect.</td>
	</tr>
    <tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_Interval">Interval</a> <br/>
		</td>
		<td>
			double
		</td>
		<td>Sets the interval between track elements.</td>
	</tr>
    <tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_IsInversed">IsInversed</a> <br/>
		</td>
		<td>
			bool
		</td>
		<td>Reverses the slider direction.</td>
	</tr>
    <tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_LabelsPlacement">LabelsPlacement</a> <br/>
		</td>
		<td>
			SliderLabelsPlacement
		</td>
		<td>Controls where labels appear relative to ticks.</td>
	</tr>
    <tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_LabelStyle">LabelStyle</a> <br/>
		</td>
		<td>
			SliderLabelStyle
		</td>
		<td>Customizes the label appearance.</td>
	</tr>
    <tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_MajorTickStyle">MajorTickStyle</a> <br/>
		</td>
		<td>
			SliderTickStyle
		</td>
		<td>Customizes the major tick appearance.</td>
	</tr>
    <tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_Maximum">Maximum</a> <br/>
		</td>
		<td>
			DateTime
		</td>
		<td>Sets the upper limit of the track.</td>
	</tr>
    <tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_Minimum">Minimum</a> <br/>
		</td>
		<td>
			DateTime
		</td>
		<td>Sets the lower limit of the track.</td>
	</tr>
    <tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_MinorTicksPerInterval">MinorTicksPerInterval</a> <br/>
		</td>
		<td>
			int
		</td>
		<td>Sets the number of minor ticks between major ticks.</td>
	</tr>
    <tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_MinorTickStyle">MinorTickStyle</a> <br/>
		</td>
		<td>
			SliderTickStyle
		</td>
		<td>Customizes the minor tick appearance.</td>
	</tr>
    <tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_ShowDividers">ShowDividers</a> <br/>
		</td>
		<td>
			bool
		</td>
		<td>Shows or hides dividers.</td>
	</tr>
    <tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_ShowLabels">ShowLabels</a> <br/>
		</td>
		<td>
			bool
		</td>
		<td>Shows or hides labels.</td>
	</tr>
    <tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_ShowTicks">ShowTicks</a> <br/>
		</td>
		<td>
			bool
		</td>
		<td>Shows or hides ticks.</td>
	</tr>
    <tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_ThumbOverlayStyle">ThumbOverlayStyle</a> <br/>
		</td>
		<td>
			SliderThumbOverlayStyle
		</td>
		<td>Customizes the thumb overlay appearance.</td>
	</tr>
    <tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_ThumbStyle">ThumbStyle</a> <br/>
		</td>
		<td>
			SliderThumbStyle
		</td>
		<td>Customizes the thumb appearance.</td>
	</tr>
    <tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_Tooltip">Tooltip</a> <br/>
		</td>
		<td>
			SliderTooltip
		</td>
		<td>Customizes the tooltip appearance.</td>
	</tr>
    <tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_TrackExtent">TrackExtent</a> <br/>
		</td>
		<td>
			double
		</td>
		<td>Sets the track edge extension in pixels.</td>
	</tr>
    <tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_TrackStyle">TrackStyle</a> <br/>
		</td>
		<td>
			SliderTrackStyle
		</td>
		<td>Customizes the track appearance.</td>
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
		<td>Fires when value selection ends.</td>
	</tr>
	<tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SfSlider.html#Syncfusion_Maui_Sliders_SfSlider_ValueChanging">ValueChanging</a>  <br/>
		</td>
		<td>
			EventHandler<DateTimeRangeSelectorValueChangingEventArgs>
		</td>
		<td>Fires while the thumb is dragged to a new value.</td>
	</tr>
	<tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_LabelCreated">LabelCreated</a>  <br/>
		</td>
		<td>
			EventHandler<SliderLabelCreatedEventArgs>
		</td>
		<td>Fires when a slider label is created for formatting or text changes.</td>
	</tr>
    <tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_ValueChangeEnd">ValueChangeEnd</a>  <br/>
		</td>
		<td>
			EventHandler<DateTimeRangeSelectorValueChangedEventArgs>
		</td>
		<td>Fires when range selection ends.</td>
	</tr>
    <tr valign="top">		
		<td>
		 <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_ValueChangeStart">ValueChangeStart</a>  <br/>
		<td>Fires when range selection starts.</td>
		</td>
		<td>
		 Represents the ValueChangeStart event, which occurs when the user is selecting a new value by tap/mouse down in the thumb.
		</td>
	</tr>
</table>

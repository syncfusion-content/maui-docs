---
layout: post
title: Properties in .NET MAUI Range Slider | Syncfusion®
description: Learn about the key properties of the .NET MAUI Range Slider control and how to configure its behavior and appearance.
platform: maui
control: SfRangeSlider
documentation: ug
---

# Properties in .NET MAUI Range Slider

## Properties

<table>
	<tr>
		<th>Name<br/></th>
		<th>Type<br/></th>
		<th>Description<br/></th>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeSliderBase-1.html#Syncfusion_Maui_Sliders_RangeSliderBase_1_DragBehavior">DragBehavior</a></td>
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderDragBehavior.html">SliderDragBehavior</a></td>
		<td>Specifies how the two thumbs move when dragged: <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderDragBehavior.html#Syncfusion_Maui_Sliders_SliderDragBehavior_OnThumb">OnThumb</a>, <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderDragBehavior.html#Syncfusion_Maui_Sliders_SliderDragBehavior_BetweenThumbs">BetweenThumbs</a>, or <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderDragBehavior.html#Syncfusion_Maui_Sliders_SliderDragBehavior_Both">Both</a>.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeSliderBase-1.html#Syncfusion_Maui_Sliders_RangeSliderBase_1_EnableIntervalSelection">EnableIntervalSelection</a></td>
		<td><a href="https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool">bool</a></td>
		<td>Enables thumb movement only at the configured interval positions.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeSliderBase-1.html#Syncfusion_Maui_Sliders_RangeSliderBase_1_EndThumbIcon">EndThumbIcon</a></td>
		<td><a href="https://learn.microsoft.com/en-us/dotnet/api/microsoft.maui.controls.view">View</a></td>
		<td>Sets the visual content displayed inside the end thumb.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeSliderBase-1.html#Syncfusion_Maui_Sliders_RangeSliderBase_1_RangeEnd">RangeEnd</a></td>
		<td><a href="https://learn.microsoft.com/en-us/dotnet/api/system.double">double</a></td>
		<td>Specifies the current end value of the selected range.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeSliderBase-1.html#Syncfusion_Maui_Sliders_RangeSliderBase_1_RangeStart">RangeStart</a></td>
		<td><a href="https://learn.microsoft.com/en-us/dotnet/api/system.double">double</a></td>
		<td>Specifies the current start value of the selected range.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeSliderBase-1.html#Syncfusion_Maui_Sliders_RangeSliderBase_1_StartThumbIcon">StartThumbIcon</a></td>
		<td><a href="https://learn.microsoft.com/en-us/dotnet/api/microsoft.maui.controls.view">View</a></td>
		<td>Sets the visual content displayed inside the start thumb.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_DeferredUpdateDelay">DeferredUpdateDelay</a></td>
		<td><a href="https://learn.microsoft.com/en-us/dotnet/api/system.int32">int</a></td>
		<td>Specifies the delay, in milliseconds, before deferred values are updated.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_DividerStyle">DividerStyle</a></td>
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderDividerStyle.html">SliderDividerStyle</a></td>
		<td>Customizes the appearance of dividers between track positions.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_DragCompletedCommand">DragCompletedCommand</a></td>
		<td><a href="https://learn.microsoft.com/en-us/dotnet/api/system.windows.input.icommand">ICommand</a></td>
		<td>Executes when thumb dragging ends.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_DragCompletedCommandParameter">DragCompletedCommandParameter</a></td>
		<td><a href="https://learn.microsoft.com/en-us/dotnet/api/system.object">object</a></td>
		<td>Provides the parameter passed to <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_DragCompletedCommand">DragCompletedCommand</a>.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_DragStartedCommand">DragStartedCommand</a></td>
		<td><a href="https://learn.microsoft.com/en-us/dotnet/api/system.windows.input.icommand">ICommand</a></td>
		<td>Executes when thumb dragging starts.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_DragStartedCommandParameter">DragStartedCommandParameter</a></td>
		<td><a href="https://learn.microsoft.com/en-us/dotnet/api/system.object">object</a></td>
		<td>Provides the parameter passed to <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_DragStartedCommand">DragStartedCommand</a>.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_EdgeLabelsPlacement">EdgeLabelsPlacement</a></td>
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderEdgeLabelsPlacement.html">SliderEdgeLabelsPlacement</a></td>
		<td>Places the first and last labels either inside the track bounds or on the intervals.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_EnableDeferredUpdate">EnableDeferredUpdate</a></td>
		<td><a href="https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool">bool</a></td>
		<td>Enables delayed value updates while the thumb is dragged.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_EnableLiquidGlassEffect">EnableLiquidGlassEffect</a></td>
		<td><a href="https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool">bool</a></td>
		<td>Enables the liquid glass visual effect for the slider.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_Interval">Interval</a></td>
		<td><a href="https://learn.microsoft.com/en-us/dotnet/api/system.double">double</a></td>
		<td>Specifies the interval used to place labels, ticks, and dividers along the track.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_IsInversed">IsInversed</a></td>
		<td><a href="https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool">bool</a></td>
		<td>Reverses the direction of the slider value flow.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_LabelsPlacement">LabelsPlacement</a></td>
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderLabelsPlacement.html">SliderLabelsPlacement</a></td>
		<td>Places labels on the ticks or between the ticks.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_LabelStyle">LabelStyle</a></td>
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderLabelStyle.html">SliderLabelStyle</a></td>
		<td>Customizes the appearance of slider labels.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_MajorTickStyle">MajorTickStyle</a></td>
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderTickStyle.html">SliderTickStyle</a></td>
		<td>Customizes the appearance of major ticks.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_Maximum">Maximum</a></td>
		<td><a href="https://learn.microsoft.com/en-us/dotnet/api/system.double">double</a></td>
		<td>Specifies the upper bound of the selectable range.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_Minimum">Minimum</a></td>
		<td><a href="https://learn.microsoft.com/en-us/dotnet/api/system.double">double</a></td>
		<td>Specifies the lower bound of the selectable range.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_MinorTicksPerInterval">MinorTicksPerInterval</a></td>
		<td><a href="https://learn.microsoft.com/en-us/dotnet/api/system.int32">int</a></td>
		<td>Specifies how many minor ticks appear between two major ticks.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_MinorTickStyle">MinorTickStyle</a></td>
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderTickStyle.html">SliderTickStyle</a></td>
		<td>Customizes the appearance of minor ticks.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_ShowDividers">ShowDividers</a></td>
		<td><a href="https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool">bool</a></td>
		<td>Shows or hides the divider markers on the track.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_ShowLabels">ShowLabels</a></td>
		<td><a href="https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool">bool</a></td>
		<td>Shows or hides the value labels on the track.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_ShowTicks">ShowTicks</a></td>
		<td><a href="https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool">bool</a></td>
		<td>Shows or hides the tick markers on the track.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_ThumbOverlayStyle">ThumbOverlayStyle</a></td>
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderThumbOverlayStyle.html">SliderThumbOverlayStyle</a></td>
		<td>Customizes the appearance of the thumb overlay.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_ThumbStyle">ThumbStyle</a></td>
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderThumbStyle.html">SliderThumbStyle</a></td>
		<td>Customizes the appearance of the thumb.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_Tooltip">Tooltip</a></td>
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderTooltip.html">SliderTooltip</a></td>
		<td>Customizes the appearance of the tooltip.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_TrackExtent">TrackExtent</a></td>
		<td><a href="https://learn.microsoft.com/en-us/dotnet/api/system.double">double</a></td>
		<td>Specifies the amount of extra space, in pixels, added to each end of the track.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_TrackStyle">TrackStyle</a></td>
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderTrackStyle.html">SliderTrackStyle</a></td>
		<td>Customizes the appearance of the track.</td>
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
		<td><a href="https://learn.microsoft.com/en-us/dotnet/api/system.void">void</a></td>
		<td>Starts a range value change.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_ValueChangeEnd">ValueChangeEnd()</a></td>
		<td><a href="https://learn.microsoft.com/en-us/dotnet/api/system.void">void</a></td>
		<td>Ends a range value change.</td>
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
		<td><a href="https://learn.microsoft.com/en-us/dotnet/api/system.eventhandler-1">EventHandler&lt;RangeSliderValueChangingEventArgs&gt;</a></td>
		<td>Fires when range selection starts.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_ValueChangeEnd">ValueChangeEnd</a></td>
		<td><a href="https://learn.microsoft.com/en-us/dotnet/api/system.eventhandler-1">EventHandler&lt;RangeSliderValueChangedEventArgs&gt;</a></td>
		<td>Fires when range selection ends.</td>
	</tr>
</table>

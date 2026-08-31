---
layout: post
title: Properties in .NET MAUI Range Slider | Syncfusion®
description: Learn about the key properties of the .NET MAUI Range Slider control and how to configure its behavior and appearance.
platform: maui
control: SfRangeSlider
documentation: ug
---

# API Reference for .NET MAUI Range Slider

## Properties

<table>
	<tr>
		<th>Name<br/></th>
		<th>Type<br/></th>
		<th>Description<br/></th>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeSliderBase-1.html#Syncfusion_Maui_Sliders_RangeSliderBase_1_DragBehavior" aria-label="View DragBehavior property in API reference">DragBehavior</a></td>
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderDragBehavior.html" aria-label="View SliderDragBehavior type in API reference">SliderDragBehavior</a></td>
		<td>Specifies how the two thumbs move when dragged: <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderDragBehavior.html#Syncfusion_Maui_Sliders_SliderDragBehavior_OnThumb" aria-label="View OnThumb property in API reference">OnThumb</a>, <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderDragBehavior.html#Syncfusion_Maui_Sliders_SliderDragBehavior_BetweenThumbs" aria-label="View BetweenThumbs property in API reference">BetweenThumbs</a>, or <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderDragBehavior.html#Syncfusion_Maui_Sliders_SliderDragBehavior_Both" aria-label="View Both property in API reference">Both</a>.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeSliderBase-1.html#Syncfusion_Maui_Sliders_RangeSliderBase_1_EnableIntervalSelection" aria-label="View EnableIntervalSelection property in API reference">EnableIntervalSelection</a></td>
		<td><a href="https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool" aria-label="View bool type in API reference">bool</a></td>
		<td>Snaps thumb movement to interval positions, allowing values to be selected only at defined intervals.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeSliderBase-1.html#Syncfusion_Maui_Sliders_RangeSliderBase_1_EndThumbIcon" aria-label="View EndThumbIcon property in API reference">EndThumbIcon</a></td>
		<td><a href="https://learn.microsoft.com/en-us/dotnet/api/microsoft.maui.controls.view" aria-label="View View type in API reference">View</a></td>
		<td>Displays a custom icon inside the thumb that represents the end of the selected range.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeSliderBase-1.html#Syncfusion_Maui_Sliders_RangeSliderBase_1_RangeEnd" aria-label="View RangeEnd property in API reference">RangeEnd</a></td>
		<td><a href="https://learn.microsoft.com/en-us/dotnet/api/system.double" aria-label="View double type in API reference">double</a></td>
		<td>Defines the value represented by the end thumb and the end of the selected range.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeSliderBase-1.html#Syncfusion_Maui_Sliders_RangeSliderBase_1_RangeStart" aria-label="View RangeStart property in API reference">RangeStart</a></td>
		<td><a href="https://learn.microsoft.com/en-us/dotnet/api/system.double" aria-label="View double type in API reference">double</a></td>
		<td>Defines the value represented by the start thumb and the beginning of the selected range.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeSliderBase-1.html#Syncfusion_Maui_Sliders_RangeSliderBase_1_StartThumbIcon" aria-label="View StartThumbIcon property in API reference">StartThumbIcon</a></td>
		<td><a href="https://learn.microsoft.com/en-us/dotnet/api/microsoft.maui.controls.view" aria-label="View View type in API reference">View</a></td>
		<td>Displays a custom icon inside the thumb that represents the start of the selected range.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_DeferredUpdateDelay" aria-label="View DeferredUpdateDelay property in API reference">DeferredUpdateDelay</a></td>
		<td><a href="https://learn.microsoft.com/en-us/dotnet/api/system.int32" aria-label="View int type in API reference">int</a></td>
		<td>Controls how long the control waits before applying deferred value updates when deferred update mode is enabled. The value is specified in milliseconds.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_DividerStyle" aria-label="View DividerStyle property in API reference">DividerStyle</a></td>
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderDividerStyle.html" aria-label="View SliderDividerStyle type in API reference">SliderDividerStyle</a></td>
		<td>Customizes the appearance of the divider markers displayed on the track.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_DragCompletedCommand" aria-label="View DragCompletedCommand property in API reference">DragCompletedCommand</a></td>
		<td><a href="https://learn.microsoft.com/en-us/dotnet/api/system.windows.input.icommand" aria-label="View ICommand type in API reference">ICommand</a></td>
		<td>Executes when thumb dragging ends.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_DragCompletedCommandParameter" aria-label="View DragCompletedCommandParameter property in API reference">DragCompletedCommandParameter</a></td>
		<td><a href="https://learn.microsoft.com/en-us/dotnet/api/system.object" aria-label="View object type in API reference">object</a></td>
		<td>Provides the parameter passed to <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_DragCompletedCommand" aria-label="View DragCompletedCommand method in API reference">DragCompletedCommand</a>.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_DragStartedCommand" aria-label="View DragStartedCommand property in API reference">DragStartedCommand</a></td>
		<td><a href="https://learn.microsoft.com/en-us/dotnet/api/system.windows.input.icommand" aria-label="View ICommand type in API reference">ICommand</a></td>
		<td>Executes when thumb dragging starts.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_DragStartedCommandParameter" aria-label="View DragStartedCommandParameter property in API reference">DragStartedCommandParameter</a></td>
		<td><a href="https://learn.microsoft.com/en-us/dotnet/api/system.object" aria-label="View object type in API reference">object</a></td>
		<td>Provides the parameter passed to <a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_DragStartedCommand" aria-label="View DragStartedCommand method in API reference">DragStartedCommand</a>.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_EdgeLabelsPlacement" aria-label="View EdgeLabelsPlacement property in API reference">EdgeLabelsPlacement</a></td>
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderEdgeLabelsPlacement.html" aria-label="View SliderEdgeLabelsPlacement type in API reference">SliderEdgeLabelsPlacement</a></td>
		<td>Controls whether the first and last labels appear inside the track bounds or align with the interval positions at the track edges.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_EnableDeferredUpdate" aria-label="View EnableDeferredUpdate property in API reference">EnableDeferredUpdate</a></td>
		<td><a href="https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool" aria-label="View bool type in API reference">bool</a></td>
		<td>Delays value updates until user interaction completes, reducing the frequency of range-change updates during dragging.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_EnableLiquidGlassEffect" aria-label="View EnableLiquidGlassEffect property in API reference">EnableLiquidGlassEffect</a></td>
		<td><a href="https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool" aria-label="View bool type in API reference">bool</a></td>
		<td>Applies the Liquid Glass visual effect to the range slider when supported by the platform and configuration. Platform requirements should be verified from the feature documentation.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_Interval" aria-label="View Interval property in API reference">Interval</a></td>
		<td><a href="https://learn.microsoft.com/en-us/dotnet/api/system.double" aria-label="View double type in API reference">double</a></td>
		<td>Defines the spacing between major intervals used for labels, ticks, and interval-based selection.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_IsInversed" aria-label="View IsInversed property in API reference">IsInversed</a></td>
		<td><a href="https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool" aria-label="View bool type in API reference">bool</a></td>
		<td>Reverses the value direction so larger values appear toward the minimum side and smaller values toward the maximum side.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_LabelsPlacement" aria-label="View LabelsPlacement property in API reference">LabelsPlacement</a></td>
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderLabelsPlacement.html" aria-label="View SliderLabelsPlacement type in API reference">SliderLabelsPlacement</a></td>
		<td>Places labels on the ticks or between the ticks.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_LabelStyle" aria-label="View LabelStyle property in API reference">LabelStyle</a></td>
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderLabelStyle.html" aria-label="View SliderLabelStyle type in API reference">SliderLabelStyle</a></td>
		<td>Customizes the appearance of slider labels.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_MajorTickStyle" aria-label="View MajorTickStyle property in API reference">MajorTickStyle</a></td>
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderTickStyle.html" aria-label="View SliderTickStyle type in API reference">SliderTickStyle</a></td>
		<td>Customizes the appearance of major ticks.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_Maximum" aria-label="View Maximum property in API reference">Maximum</a></td>
		<td><a href="https://learn.microsoft.com/en-us/dotnet/api/system.double" aria-label="View double type in API reference">double</a></td>
		<td>Specifies the upper bound of the selectable range.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_Minimum" aria-label="View Minimum property in API reference">Minimum</a></td>
		<td><a href="https://learn.microsoft.com/en-us/dotnet/api/system.double" aria-label="View double type in API reference">double</a></td>
		<td>Specifies the lower bound of the selectable range.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_MinorTicksPerInterval" aria-label="View MinorTicksPerInterval property in API reference">MinorTicksPerInterval</a></td>
		<td><a href="https://learn.microsoft.com/en-us/dotnet/api/system.int32" aria-label="View int type in API reference">int</a></td>
		<td>Specifies how many minor ticks appear between two major ticks.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_MinorTickStyle" aria-label="View MinorTickStyle property in API reference">MinorTickStyle</a></td>
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderTickStyle.html" aria-label="View SliderTickStyle type in API reference">SliderTickStyle</a></td>
		<td>Customizes the appearance of minor ticks.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_ShowDividers" aria-label="View ShowDividers property in API reference">ShowDividers</a></td>
		<td><a href="https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool" aria-label="View bool type in API reference">bool</a></td>
		<td>Shows or hides the divider markers on the track.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_ShowLabels" aria-label="View ShowLabels property in API reference">ShowLabels</a></td>
		<td><a href="https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool" aria-label="View bool type in API reference">bool</a></td>
		<td>Shows or hides the value labels on the track.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_ShowTicks" aria-label="View ShowTicks property in API reference">ShowTicks</a></td>
		<td><a href="https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool" aria-label="View bool type in API reference">bool</a></td>
		<td>Shows or hides the tick markers on the track.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_ThumbOverlayStyle" aria-label="View ThumbOverlayStyle property in API reference">ThumbOverlayStyle</a></td>
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderThumbOverlayStyle.html" aria-label="View SliderThumbOverlayStyle type in API reference">SliderThumbOverlayStyle</a></td>
		<td>Customizes the appearance of the thumb overlay.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_ThumbStyle" aria-label="View ThumbStyle property in API reference">ThumbStyle</a></td>
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderThumbStyle.html" aria-label="View SliderThumbStyle type in API reference">SliderThumbStyle</a></td>
		<td>Customizes the appearance of the thumb.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_Tooltip" aria-label="View Tooltip property in API reference">Tooltip</a></td>
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderTooltip.html" aria-label="View SliderTooltip type in API reference">SliderTooltip</a></td>
		<td>Customizes the appearance of the tooltip.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_TrackExtent" aria-label="View TrackExtent property in API reference">TrackExtent</a></td>
		<td><a href="https://learn.microsoft.com/en-us/dotnet/api/system.double" aria-label="View double type in API reference">double</a></td>
		<td>Extends the track beyond its normal start and end edges by the specified number of pixels.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_TrackStyle" aria-label="View TrackStyle property in API reference">TrackStyle</a></td>
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderTrackStyle.html" aria-label="View SliderTrackStyle type in API reference">SliderTrackStyle</a></td>
		<td>Customizes the appearance of the slider track, including selected and unselected track regions.</td>
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
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_ValueChangeStart" aria-label="View ValueChangeStart event in API reference">ValueChangeStart</a></td>
		<td><a href="https://learn.microsoft.com/en-us/dotnet/api/system.eventhandler-1" aria-label="View RangeSliderValueChangingEventArgs type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeSliderValueChangingEventArgs.html" aria-label="View EventHandler type in API reference">RangeSliderValueChangingEventArgs&gt;</a></a></td>
		<td>Triggered when range selection begins, such as when the user presses or picks up a thumb to start dragging.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_ValueChangeEnd" aria-label="View ValueChangeEnd event in API reference">ValueChangeEnd</a></td>
		<td><a href="https://learn.microsoft.com/en-us/dotnet/api/system.eventhandler-1" aria-label="View RangeSliderValueChangedEventArgs type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeSliderValueChangedEventArgs.html" aria-label="View EventHandler type in API reference">RangeSliderValueChangedEventArgs&gt;</a></a></td>
		<td>Triggered when range selection ends, such as when the user releases a thumb after dragging.</td>
	</tr>
</table>

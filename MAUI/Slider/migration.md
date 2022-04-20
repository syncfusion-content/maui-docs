---
layout: post
title: Migrate from Xamarin SfRangeSlider to .NET MAUI SfSlider | Syncfusion 
description: Learn here all about Migrating from Syncfusion Xamarin RangeSlider to Syncfusion .NET MAUI Slider control and more.
platform: MAUI
control: SfSlider
documentation: ug
---  

# Migrate from Xamarin.Forms SfRangeSlider to .NET MAUI SfSlider 

To migrate easier from [Xamarin SfRangeSlider](https://www.syncfusion.com/xamarin-ui-controls/xamarin-range-slider) to [.NET MAUI SfSlider](https://www.syncfusion.com/maui-controls/maui-slider), we kept most of the APIs from Xamarin SfRangeSlider in MAUI SfSlider. However, to maintain the consistency of API naming in MAUI SfSlider, we renamed some of the APIs. The APIs that have been changed in MAUI SfSlider from Xamarin SfRangeSlider are detailed as follows.

## Assembly Name 

<table>
<tr>
<th>Xamarin SfRangeSlider</th>
<th>.NET MAUI SfSlider</th></tr>
<tr>
<td>Syncfusion.SfRangeSlider.XForms</td>
<td>Syncfusion.Maui.Sliders</td></tr>
</table>

## Namespaces 

<table>
<tr>
<th>Xamarin SfRangeSlider</th>
<th>.NET MAUI SfSlider</th></tr>
<tr>
<td>Syncfusion.ListView.XForms</td>
<td>Syncfusion.Maui.Sliders</td></tr>
</table>

## Properties

### Track

<table> 
<tr>
<th>Xamarin SfRangeSlider</th>
<th>.NET MAUI SfSlider</th>
<th>Description</th></tr>
<tr>
<td>{{'[TrackColor](Pastethehttplinkhere)'| markdownify }}</td>
<td>{{'[SliderTrackStyle.InactiveFill](Pastethehttplinkhere)'| markdownify }}</td>
<td>Gets or sets the brush for the inactive track in the SfSlider.</td></tr>
<tr>
<td>{{'[TrackSelectionColor](Pastethehttplinkhere)'| markdownify }}</td>
<td>{{'[SliderTrackStyle.ActiveFill](Pastethehttplinkhere)'| markdownify }}</td>
<td>Gets or sets the brush for the active track in the SfSlider.</td></tr>
<tr>
<td>{{'[TrackThickness](Pastethehttplinkhere)'| markdownify }}</td>
<td>{{'[SliderTrackStyle.InactiveSize](Pastethehttplinkhere)'| markdownify }}</td>
<td>Gets or sets the size for the inactive track in the SfSlider.</td></tr>
<tr>
<td>{{'[TrackSelectionThickness](Pastethehttplinkhere)'| markdownify }}</td>
<td>{{'[SliderTrackStyle.ActiveSize](Pastethehttplinkhere)'| markdownify }}</td>
<td>Gets or sets the size for the active track in the SfSlider.</td></tr>
</table> 

### Thumb

<table> 
<tr>
<th>Xamarin SfRangeSlider</th>
<th>.NET MAUI SfSlider</th>
<th>Description</th></tr>
<tr>
<td>{{'[ThumbSize](Pastethehttplinkhere)'| markdownify }}</td>
<td>{{'[SliderThumbStyle.Radius](Pastethehttplinkhere)'| markdownify }}</td>
<td>Gets or sets the radius for the thumb in the SfSlider.</td></tr>
<tr>
<td>{{'[KnobColor](Pastethehttplinkhere)'| markdownify }}</td>
<td>{{'[SliderThumbStyle.Fill](Pastethehttplinkhere)'| markdownify }}</td>
<td>Gets or sets the color for the thumb in the SfSlider.</td></tr>
<tr>
<td>{{'[ThumbBorderColor](Pastethehttplinkhere)'| markdownify }}</td>
<td>{{'[SliderThumbStyle.Stroke](Pastethehttplinkhere)'| markdownify }}</td>
<td>Gets or sets the stroke color for the thumb in the SfSlider.</td></tr>
<tr>
<td>{{'[ThumbBorderThickness](Pastethehttplinkhere)'| markdownify }}</td>
<td>{{'[SliderThumbStyle.StrokeThickness](Pastethehttplinkhere)'| markdownify }}</td>
<td>Gets or sets the stroke value for the thumb in the SfSlider.</td></tr>
</table> 

### Ticks

<table> 
<tr>
<th>Xamarin SfRangeSlider</th>
<th>.NET MAUI SfSlider</th>
<th>Description</th></tr>
<tr>
<td>{{'[TickColor](Pastethehttplinkhere)'| markdownify }}</td>
<td>{{'[SliderTickStyle.Fill](Pastethehttplinkhere)'| markdownify }}</td>
<td>Gets or sets the color for the thumb in the SfSlider.</td></tr>
</table> 

### Labels

<table> 
<tr>
<th>Xamarin SfRangeSlider</th>
<th>.NET MAUI SfSlider</th>
<th>Description</th></tr>
<tr>
<td>{{'[AllowDragRange](Pastethehttplinkhere)'| markdownify }}</td>
<td>{{'[ShowLabels](Pastethehttplinkhere)'| markdownify }}</td>
<td>Gets or sets a value indicating whether to show or hide the labels.</td></tr>
<tr>
<td rowspan="2" valign="center">
			{{'[LabelColor](Pastethehttplinkhere)'| markdownify }}<br/>
		</td>
<td>{{'[SliderLabelStyle.ActiveTextColor](Pastethehttplinkhere)'| markdownify }}</td>
<td>Gets or sets the color for the active labels in the SfSlider.</td></tr>
<tr>
<td>{{'[SliderLabelStyle.InactiveTextColor](Pastethehttplinkhere)'| markdownify }}</td>
<td>Gets or sets the color for the inactive labels in the SfSlider.</td></tr>
<tr>
<tr>
<td rowspan="2" valign="center">
			{{'[FontFamily](Pastethehttplinkhere)'| markdownify }}<br/>
		</td>
<td>{{'[SliderLabelStyle.InactiveFontFamily](Pastethehttplinkhere)'| markdownify }}</td>
<td>Gets or sets the font family for the inactive labels in the SfSlider.</td></tr>
<tr>
<td>{{'[SliderLabelStyle.ActiveFontFamily](Pastethehttplinkhere)'| markdownify }}</td>
<td>Gets or sets the font family for the active labels in the SfSlider.</td></tr>
<tr>
<tr>
<td rowspan="2" valign="center">
			{{'[FontAttribute](Pastethehttplinkhere)'| markdownify }}<br/>
		</td>
<td>{{'[SliderLabelStyle.InactiveFontAttributes](Pastethehttplinkhere)'| markdownify }}</td>
<td>Gets or sets the font attributes for the inactive labels in the SfSlider.</td></tr>
<tr>
<td>{{'[SliderLabelStyle.ActiveFontAttributes](Pastethehttplinkhere)'| markdownify }}</td>
<td>Gets or sets the font attributes for the active labels in the SfSlider.</td></tr>
<tr>
<tr>
<td rowspan="2" valign="center">
			{{'[FontSize](Pastethehttplinkhere)'| markdownify }}<br/>
		</td>
<td>{{'[SliderLabelStyle.InactiveFontSize](Pastethehttplinkhere)'| markdownify }}</td>
<td>Gets or sets the size for the inactive fonts in the SfSlider.</td></tr>
<tr>
<td>{{'[SliderLabelStyle.ActiveFontSize](Pastethehttplinkhere)'| markdownify }}</td>
<td>Gets or sets the size for the active fonts in the SfSlider.</td></tr>
<tr>
<td>{{'[LabelFormat](Pastethehttplinkhere)'| markdownify }}</td>
<td>{{'[NumberFormat](Pastethehttplinkhere)'| markdownify }}</td>
<td>Gets or sets the value to format the label text.</td></tr>
</table> 

### Tooltip

<table> 
<tr>
<th>Xamarin SfRangeSlider</th>
<th>.NET MAUI SfSlider</th>
<th>Description</th></tr>
<tr>
<td>{{'[TooltipBackgroundColor](Pastethehttplinkhere)'| markdownify }}</td>
<td>{{'[SliderTooltip.Fill](Pastethehttplinkhere)'| markdownify }}</td>
<td>Gets or sets the brush for the tooltip in the SfSlider.</td></tr>
<tr>
<td>{{'[TooltipTextColor](Pastethehttplinkhere)'| markdownify }}</td>
<td>{{'[SliderTooltip.TextColor](Pastethehttplinkhere)'| markdownify }}</td>
<td>Gets or sets the color for the tooltip text in the SfSlider.</td></tr>
<tr>
<td>{{'[TooltipPrecision](Pastethehttplinkhere)'| markdownify }}</td>
<td>{{'[SliderTooltip.NumberFormat](Pastethehttplinkhere)'| markdownify }}</td>
<td>Gets or sets the value to format the label text in the SfSlider.</td></tr>
</table> 

## Events

<table>
<tr>
<th>Xamarin SfRangeSlider</th>
<th>.NET MAUI SfSlider</th>
<th>Description</th></tr>
<tr>
<td>{{'[DragStarted](Pastethehttplinkhere)'| markdownify }}</td>
<td>{{'[ValueChangeStart](Pastethehttplinkhere)'| markdownify }}</td>
<td>Occurs when the user is selecting a new value for the Slider by tap/mouse down in the thumb.</td></tr>
<tr>
<td>{{'[DragCompleted](Pastethehttplinkhere)'| markdownify }}</td>
<td>{{'[ValueChangeEnd](Pastethehttplinkhere)'| markdownify }}</td>
<td>Occurs when the user completed selecting a new value for the Slider by tap/mouse down in the thumb.</td></tr>
</table> 
---
layout: post
title: Migrate Xamarin SfRangeSlider to .NET MAUI SfRangeSlider | Syncfusion<sup>®</sup> 
description: Learn here all about Migrating from Syncfusion<sup>®</sup> Xamarin RangeSlider to Syncfusion<sup>®</sup> .NET MAUI RangeSlider control and more.
platform: MAUI
control: SfRangeSlider
documentation: ug
---  

# Migrate from Xamarin.Forms SfRangeSlider to .NET MAUI SfRangeSlider 

To migrate from the [Xamarin Range Slider](https://www.syncfusion.com/xamarin-ui-controls/xamarin-range-slider) control to MAUI, use the following two controls.

1. SfDateTimeRangeSlider – For date-time scale.
2. SfRangeSlider – For numeric scale.

One more thing is, in .NET MAUI SfRangeSlider, you do not have an API name [ShowRange](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfRangeSlider.XForms.SfRangeSlider.html#Syncfusion_SfRangeSlider_XForms_SfRangeSlider_AllowDragRange) in MAUI. Both the MAUI SfDateTimeRangeSlider and SfRangeSlider controls will show two thumbs by default. If you wish to use the single thumb, check the [Migration from Xamarin.Forms SfRangeSlider to .NET MAUI SfSlider](https://help.syncfusion.com/maui/slider/migration).

## Namespaces 

<table>
<tr>
<th>Xamarin SfRangeSlider</th>
<th>.NET MAUI SfRangeSlider</th></tr>
<tr>
<td>Syncfusion.SfRangeSlider.XForms</td>
<td>Syncfusion.Maui.Sliders</td></tr>
</table>

## Properties

### Track

<table> 
<tr>
<th>Xamarin SfRangeSlider</th>
<th>.NET MAUI SfRangeSlider</th>
<th>Description</th></tr>
<tr>
<td>{{'[TrackColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfRangeSlider.XForms.SfRangeSlider.html#Syncfusion_SfRangeSlider_XForms_SfRangeSlider_TrackColor)'| markdownify }}</td>
<td>{{'[SliderTrackStyle.InactiveFill](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderTrackStyle.html#Syncfusion_Maui_Sliders_SliderTrackStyle_InactiveFill)'| markdownify }}</td>
<td>Gets or sets the brush for the inactive track in the SfSlider.</td></tr>
<tr>
<td>{{'[TrackSelectionColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfRangeSlider.XForms.SfRangeSlider.html#Syncfusion_SfRangeSlider_XForms_SfRangeSlider_TrackSelectionColor)'| markdownify }}</td>
<td>{{'[SliderTrackStyle.ActiveFill](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderTrackStyle.html#Syncfusion_Maui_Sliders_SliderTrackStyle_ActiveFill)'| markdownify }}</td>
<td>Gets or sets the brush for the active track in the SfSlider.</td></tr>
<tr>
<td>{{'[TrackThickness](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfRangeSlider.XForms.SfRangeSlider.html#Syncfusion_SfRangeSlider_XForms_SfRangeSlider_TrackThickness)'| markdownify }}</td>
<td>{{'[SliderTrackStyle.InactiveSize](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderTrackStyle.html#Syncfusion_Maui_Sliders_SliderTrackStyle_InactiveSize)'| markdownify }}</td>
<td>Gets or sets the size for the inactive track in the SfSlider.</td></tr>
<tr>
<td>{{'[TrackSelectionThickness](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfRangeSlider.XForms.SfRangeSlider.html#Syncfusion_SfRangeSlider_XForms_SfRangeSlider_TrackSelectionThickness)'| markdownify }}</td>
<td>{{'[SliderTrackStyle.ActiveSize](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderTrackStyle.html#Syncfusion_Maui_Sliders_SliderTrackStyle_ActiveSize)'| markdownify }}</td>
<td>Gets or sets the size for the active track in the SfSlider.</td></tr>
</table> 

### Thumb

<table> 
<tr>
<th>Xamarin SfRangeSlider</th>
<th>.NET MAUI SfRangeSlider</th>
<th>Description</th></tr>
<tr>
<td>{{'[ThumbSize](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfRangeSlider.XForms.SfRangeSlider.html#Syncfusion_SfRangeSlider_XForms_SfRangeSlider_ThumbSize)'| markdownify }}</td>
<td>{{'[SliderThumbStyle.Radius](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderThumbStyle.html#Syncfusion_Maui_Sliders_SliderThumbStyle_Radius)'| markdownify }}</td>
<td>Gets or sets the radius for the thumb in the SfSlider.</td></tr>
<tr>
<td>{{'[KnobColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfRangeSlider.XForms.SfRangeSlider.html#Syncfusion_SfRangeSlider_XForms_SfRangeSlider_KnobColor)'| markdownify }}</td>
<td>{{'[SliderThumbStyle.Fill](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderThumbStyle.html#Syncfusion_Maui_Sliders_SliderThumbStyle_Fill)'| markdownify }}</td>
<td>Gets or sets the color for the thumb in the SfSlider.</td></tr>
<tr>
<td>{{'[ThumbBorderColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfRangeSlider.XForms.SfRangeSlider.html#Syncfusion_SfRangeSlider_XForms_SfRangeSlider_ThumbBorderColor)'| markdownify }}</td>
<td>{{'[SliderThumbStyle.Stroke](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderThumbStyle.html#Syncfusion_Maui_Sliders_SliderThumbStyle_Stroke)'| markdownify }}</td>
<td>Gets or sets the stroke color for the thumb in the SfSlider.</td></tr>
<tr>
<td>{{'[ThumbBorderThickness](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfRangeSlider.XForms.SfRangeSlider.html#Syncfusion_SfRangeSlider_XForms_SfRangeSlider_ThumbBorderThickness)'| markdownify }}</td>
<td>{{'[SliderThumbStyle.StrokeThickness](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderThumbStyle.html#Syncfusion_Maui_Sliders_SliderThumbStyle_StrokeThickness)'| markdownify }}</td>
<td>Gets or sets the stroke value for the thumb in the SfSlider.</td></tr>
</table> 

### Ticks

<table> 
<tr>
<th>Xamarin SfRangeSlider</th>
<th>.NET MAUI SfRangeSlider</th>
<th>Description</th></tr>
<tr>
<td rowspan="2" valign="center">
			{{'[TickColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfRangeSlider.XForms.SfRangeSlider.html#Syncfusion_SfRangeSlider_XForms_SfRangeSlider_TickColor)'| markdownify }}<br/>
		</td>
<td>{{'[SliderTickStyle.InactiveFill](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderTickStyle.html#Syncfusion_Maui_Sliders_SliderTickStyle_InactiveFill)'| markdownify }}</td>
<td>Gets or sets the brush for the inactive ticks in the SfSlider.</td></tr>
<tr>
<td>{{'[SliderTickStyle.ActiveFill](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderTickStyle.html#Syncfusion_Maui_Sliders_SliderTickStyle_ActiveFill)'| markdownify }}</td>
<td>Gets or sets the brush for the active ticks in the SfSlider.</td></tr>
</table> 

### Labels

<table> 
<tr>
<th>Xamarin SfRangeSlider</th>
<th>.NET MAUI SfRangeSlider</th>
<th>Description</th></tr>
<tr>
<td>{{'[AllowDragRange](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfRangeSlider.XForms.SfRangeSlider.html#Syncfusion_SfRangeSlider_XForms_SfRangeSlider_AllowDragRange)'| markdownify }}</td>
<td>{{'[ShowLabels](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_ShowLabels)'| markdownify }}</td>
<td>Gets or sets a value indicating whether to show or hide the labels.</td></tr>
<tr>
<td rowspan="2" valign="center">
			{{'[LabelColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfRangeSlider.XForms.SfRangeSlider.html#Syncfusion_SfRangeSlider_XForms_SfRangeSlider_LabelColor)'| markdownify }}<br/>
		</td>
<td>{{'[SliderLabelStyle.InactiveTextColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderLabelStyle.html#Syncfusion_Maui_Sliders_SliderLabelStyle_InactiveTextColor)'| markdownify }}</td>
<td>Gets or sets the color for the inactive labels in the SfSlider.</td></tr>
<tr>
<td>{{'[SliderLabelStyle.ActiveTextColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderLabelStyle.html#Syncfusion_Maui_Sliders_SliderLabelStyle_ActiveTextColor)'| markdownify }}</td>
<td>Gets or sets the color for the active labels in the SfSlider.</td></tr>
<tr>
<td rowspan="2" valign="center">
			{{'[FontFamily](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfRangeSlider.XForms.SfRangeSlider.html#Syncfusion_SfRangeSlider_XForms_SfRangeSlider_FontFamily)'| markdownify }}<br/>
		</td>
<td>{{'[SliderLabelStyle.InactiveFontFamily](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderLabelStyle.html#Syncfusion_Maui_Sliders_SliderLabelStyle_InactiveFontFamily)'| markdownify }}</td>
<td>Gets or sets the font family for the inactive labels in the SfSlider.</td></tr>
<tr>
<td>{{'[SliderLabelStyle.ActiveFontFamily](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderLabelStyle.html#Syncfusion_Maui_Sliders_SliderLabelStyle_ActiveFontFamily)'| markdownify }}</td>
<td>Gets or sets the font family for the active labels in the SfSlider.</td></tr>
<tr>
<td rowspan="2" valign="center">
			{{'[FontAttribute](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfRangeSlider.XForms.SfRangeSlider.html#Syncfusion_SfRangeSlider_XForms_SfRangeSlider_FontAttribute)'| markdownify }}<br/>
		</td>
<td>{{'[SliderLabelStyle.InactiveFontAttributes](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderLabelStyle.html#Syncfusion_Maui_Sliders_SliderLabelStyle_InactiveFontAttributes)'| markdownify }}</td>
<td>Gets or sets the font attributes for the inactive labels in the SfSlider.</td></tr>
<tr>
<td>{{'[SliderLabelStyle.ActiveFontAttributes](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderLabelStyle.html#Syncfusion_Maui_Sliders_SliderLabelStyle_ActiveFontAttributes)'| markdownify }}</td>
<td>Gets or sets the font attributes for the active labels in the SfSlider.</td></tr>
<tr>
<td rowspan="2" valign="center">
			{{'[FontSize](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfRangeSlider.XForms.SfRangeSlider.html#Syncfusion_SfRangeSlider_XForms_SfRangeSlider_FontSize)'| markdownify }}<br/>
		</td>
<td>{{'[SliderLabelStyle.InactiveFontSize](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderLabelStyle.html#Syncfusion_Maui_Sliders_SliderLabelStyle_InactiveFontSize)'| markdownify }}</td>
<td>Gets or sets the size for the inactive fonts in the SfSlider.</td></tr>
<tr>
<td>{{'[SliderLabelStyle.ActiveFontSize](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderLabelStyle.html#Syncfusion_Maui_Sliders_SliderLabelStyle_ActiveFontSize)'| markdownify }}</td>
<td>Gets or sets the size for the active fonts in the SfSlider.</td></tr>
<tr>
<td>{{'[LabelFormat](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfRangeSlider.XForms.SfRangeSlider.html#Syncfusion_SfRangeSlider_XForms_SfRangeSlider_LabelFormat)'| markdownify }}</td>
<td>{{'[NumberFormat](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.INumericElement.html#Syncfusion_Maui_Sliders_INumericElement_NumberFormat)'| markdownify }}</td>
<td>Gets or sets the value to format the label text.</td></tr>
</table> 

### Tooltip

<table> 
<tr>
<th>Xamarin SfRangeSlider</th>
<th>.NET MAUI SfRangeSlider</th>
<th>Description</th></tr>
<tr>
<td>{{'[TooltipBackgroundColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfRangeSlider.XForms.SfRangeSlider.html#Syncfusion_SfRangeSlider_XForms_SfRangeSlider_ToolTipBackgroundColor)'| markdownify }}</td>
<td>{{'[SliderTooltip.Fill](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderTooltip.html#Syncfusion_Maui_Sliders_SliderTooltip_Fill)'| markdownify }}</td>
<td>Gets or sets the brush for the tooltip in the SfSlider.</td></tr>
<tr>
<td>{{'[TooltipTextColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfRangeSlider.XForms.SfRangeSlider.html#Syncfusion_SfRangeSlider_XForms_SfRangeSlider_ToolTipTextColor)'| markdownify }}</td>
<td>{{'[SliderTooltip.TextColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderTooltip.html#Syncfusion_Maui_Sliders_SliderTooltip_TextColor)'| markdownify }}</td>
<td>Gets or sets the color for the tooltip text in the SfSlider.</td></tr>
<tr>
<td>{{'[TooltipPrecision](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfRangeSlider.XForms.SfRangeSlider.html#Syncfusion_SfRangeSlider_XForms_SfRangeSlider_ToolTipPrecision)'| markdownify }}</td>
<td>{{'[SliderTooltip.NumberFormat](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderTooltip.html#Syncfusion_Maui_Sliders_SliderTooltip_NumberFormat)'| markdownify }}</td>
<td>Gets or sets the value to format the label text in the SfSlider.</td></tr>
</table> 

### DragMode

<table> 
<tr>
<th>Xamarin SfRangeSlider</th>
<th>.NET MAUI SfRangeSlider</th>
<th>Description</th></tr>
<tr>
<td>{{'[AllowDragRange](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfRangeSlider.XForms.SfRangeSlider.html#Syncfusion_SfRangeSlider_XForms_SfRangeSlider_AllowDragRange)'| markdownify }}</td>
<td>{{'[DragBehavior](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeSliderBase-1.html#Syncfusion_Maui_Sliders_RangeSliderBase_1_DragBehavior)'| markdownify }}</td>
<td>Gets or sets the value which indicates the behavior of the thumb dragging.</td></tr>
</table> 

### Step

<table> 
<tr>
<th>Xamarin SfRangeSlider</th>
<th>.NET MAUI SfRangeSlider</th>
<th>Description</th></tr>
<tr>
<td>{{'[SnapsTo](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfRangeSlider.XForms.SfRangeSlider.html#Syncfusion_SfRangeSlider_XForms_SfRangeSlider_SnapsTo)'| markdownify }}</td>
<td>{{'[StepSize](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.INumericElement.html#Syncfusion_Maui_Sliders_INumericElement_StepSize)'| markdownify }}</td>
<td>Gets or sets the value indicating whether to select the discrete value.</td></tr>
</table> 

## Events

<table>
<tr>
<th>Xamarin SfRangeSlider</th>
<th>.NET MAUI SfRangeSlider</th>
<th>Description</th></tr>
<tr>
<td>{{'[DragStarted](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfRangeSlider.XForms.SfRangeSlider.html#Syncfusion_SfRangeSlider_XForms_SfRangeSlider_DragStarted)'| markdownify }}</td>
<td>{{'[ValueChangeStart](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_ValueChangeStart)'| markdownify }}</td>
<td>Occurs when the user selects a new value for the Slider by tapping/mouse down on the thumb.</td></tr>
<tr>
<td>{{'[RangeChanging](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfRangeSlider.XForms.SfRangeSlider.html#Syncfusion_SfRangeSlider_XForms_SfRangeSlider_RangeChanging)'| markdownify }}</td>
<td>{{'[ValueChanging](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SfRangeSlider.html#Syncfusion_Maui_Sliders_SfRangeSlider_ValueChanging)'| markdownify }}</td>
<td>Occurs when the user selects a new value for the Range Slider by dragging any one of the thumbs.</td></tr>
<tr>
<td>{{'[DragCompleted](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfRangeSlider.XForms.SfRangeSlider.html#Syncfusion_SfRangeSlider_XForms_SfRangeSlider_DragCompleted)'| markdownify }}</td>
<td>{{'[ValueChangeEnd](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_ValueChangeEnd)'| markdownify }}</td>
<td>Occurs when the user completes selecting a new value for the Slider by tapping/mouse down on the thumb.</td></tr>
</table> 
---
layout: post
title: Migrate from Xamarin to .NET MAUI SfDateTimeRangeSelector | Syncfusion<sup>®</sup> 
description: Learn here all about Migrating from Syncfusion<sup>®</sup> Xamarin DateTimeRangeNavigator to Syncfusion<sup>®</sup> .NET MAUI DateTimeRangeSelector control and more.
platform: MAUI
control: SfDateTimeRangeSelector
documentation: ug
---  

# Migrate from Xamarin SfDateTimeRangeNavigator to MAUI Range Selector

In the Xamarin.Forms, [SfDateTimeRangeNavigator](https://help.syncfusion.com/cr/xamarin/Syncfusion.RangeNavigator.XForms.SfDateTimeRangeNavigator.html) control supports only the date-time scale. But in MAUI, separate controls for this date-time scale and numeric scale. Also, in the Xamarin.Forms, the control comes along with the [Syncfusion.Xamarin.SfChart](https://www.nuget.org/packages/Syncfusion.Xamarin.SfChart/) package, but in MAUI the controls comes with the [Syncfusion.Maui.Sliders](https://www.nuget.org/packages/Syncfusion.Maui.Sliders/) package. The following are the new MAUI controls for migrating from the Xamarin.Forms SfDateTimeRangeNavigator to MAUI.

1. SfDateTimeRangeSelector  - For date-time scale.
2. SfRangeSelector – For numeric scale.

## Namespaces 

<table>
<tr>
<th>Xamarin SfDateTimeRangeNavigator</th>
<th>.NET MAUI SfDateTimeRangeSelector</th></tr>
<tr>
<td>Syncfusion.RangeNavigator.XForms</td>
<td>Syncfusion.Maui.Sliders</td></tr>
</table>

## Properties

### General

<table> 
<tr>
<th>Xamarin SfDateTimeRangeNavigator</th>
<th>.NET MAUI SfDateTimeRangeSelector</th>
<th>Description</th></tr>
<tr>
<td>{{'[ViewRangeStart](https://help.syncfusion.com/cr/xamarin/Syncfusion.RangeNavigator.XForms.SfDateTimeRangeNavigator.html#Syncfusion_RangeNavigator_XForms_SfDateTimeRangeNavigator_ViewRangeStart)'| markdownify }}</td>
<td>{{'[RangeStart](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeSliderBase-1.html#Syncfusion_Maui_Sliders_RangeSliderBase_1_RangeStart)'| markdownify }}</td>
<td>Gets or sets the thumb start value of the track. The thumb starts from this value.</td></tr>
<tr>
<td>{{'[ViewRangeEnd](https://help.syncfusion.com/cr/xamarin/Syncfusion.RangeNavigator.XForms.SfDateTimeRangeNavigator.html#Syncfusion_RangeNavigator_XForms_SfDateTimeRangeNavigator_ViewRangeEnd)'| markdownify }}</td>
<td>{{'[RangeEnd](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeSliderBase-1.html#Syncfusion_Maui_Sliders_RangeSliderBase_1_RangeEnd)'| markdownify }}</td>
<td>Gets or sets the thumb end value of the track. The thumb ends in this value.</td></tr>
<tr>
<td>{{'[Intervals](https://help.syncfusion.com/cr/xamarin/Syncfusion.RangeNavigator.XForms.SfDateTimeRangeNavigator.html#Syncfusion_RangeNavigator_XForms_SfDateTimeRangeNavigator_Intervals)'| markdownify }}</td>
<td>{{'[IntervalType](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.IDateTimeElement.html#Syncfusion_Maui_Sliders_IDateTimeElement_IntervalType)'| markdownify }}</td>
<td>Gets or sets the type of the date interval. By default, it will be Years.</td></tr>
<tr>
<td>{{'[OverlayColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.RangeNavigator.XForms.SfDateTimeRangeNavigator.html#Syncfusion_RangeNavigator_XForms_SfDateTimeRangeNavigator_OverlayColor)'| markdownify }}</td>
<td>{{'[InactiveRegionFill](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeSelectorBase-1.html#Syncfusion_Maui_Sliders_RangeSelectorBase_1_InactiveRegionFill)'| markdownify }}</td>
<td>Gets or sets the color to the InactiveRegionColor.</td></tr>
<tr>
<td>{{'[LeftThumbStyle](https://help.syncfusion.com/cr/xamarin/Syncfusion.RangeNavigator.XForms.SfDateTimeRangeNavigator.html#Syncfusion_RangeNavigator_XForms_SfDateTimeRangeNavigator_LeftThumbStyle)'| markdownify }}</td>
<td rowspan="2" valign="center">
			{{'[ThumbStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_ThumbStyle)'| markdownify }}<br/>
		</td>
<td rowspan="2" valign="center">
			Gets or sets a value to customize the appearance of the thumb shape.<br/>
		</td></tr>
<tr>
<td>{{'[RightThumbStyle](https://help.syncfusion.com/cr/xamarin/Syncfusion.RangeNavigator.XForms.SfDateTimeRangeNavigator.html#Syncfusion_RangeNavigator_XForms_SfDateTimeRangeNavigator_RightThumbStyle)'| markdownify }}</td></tr>
<tr>
<td>{{'[LeftTooltipStyle](https://help.syncfusion.com/cr/xamarin/Syncfusion.RangeNavigator.XForms.SfDateTimeRangeNavigator.html#Syncfusion_RangeNavigator_XForms_SfDateTimeRangeNavigator_LeftTooltipStyle)'| markdownify }}</td>
<td rowspan="2" valign="center">
			{{'[Tooltip](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_Tooltip)'| markdownify }}<br/>
		</td>
<td rowspan="2" valign="center">
			Gets or sets a value to customize the appearance of the tooltip shape.<br/>
		</td></tr>
<tr>
<td>{{'[RightTooltipStyle](https://help.syncfusion.com/cr/xamarin/Syncfusion.RangeNavigator.XForms.SfDateTimeRangeNavigator.html#Syncfusion_RangeNavigator_XForms_SfDateTimeRangeNavigator_RightTooltipStyle)'| markdownify }}</td></tr>
</table> 

### Thumb

<table> 
<tr>
<th>Xamarin SfDateTimeRangeNavigator</th>
<th>.NET MAUI SfDateTimeRangeSelector</th>
<th>Description</th></tr>
<tr>
<td>{{'[ThumbStyle.Width](https://help.syncfusion.com/cr/xamarin/Syncfusion.RangeNavigator.XForms.ThumbStyle.html#Syncfusion_RangeNavigator_XForms_ThumbStyle_Width)'| markdownify }}</td>
<td rowspan="2" valign="center">
			{{'[SliderThumbStyle.Radius](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderThumbStyle.html#Syncfusion_Maui_Sliders_SliderThumbStyle_Radius)'| markdownify }}<br/>
		</td>
<td rowspan="2" valign="center">
			Gets or sets the radius for the thumb.<br/>
		</td></tr>
<tr>
<td>{{'[ThumbStyle.Height](https://help.syncfusion.com/cr/xamarin/Syncfusion.RangeNavigator.XForms.ThumbStyle.html#Syncfusion_RangeNavigator_XForms_ThumbStyle_Height)'| markdownify }}</td></tr>
<tr>
<td>{{'[ThumbStyle.BackgroundColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.RangeNavigator.XForms.ThumbStyle.html#Syncfusion_RangeNavigator_XForms_ThumbStyle_BackgroundColor)'| markdownify }}</td>
<td>{{'[SliderThumbStyle.Fill](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderThumbStyle.html#Syncfusion_Maui_Sliders_SliderThumbStyle_Fill)'| markdownify }}</td>
<td>Gets or sets the color for the thumb.</td></tr>
<tr>
<td>{{'[ThumbStyle.BorderColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.RangeNavigator.XForms.ThumbStyle.html#Syncfusion_RangeNavigator_XForms_ThumbStyle_BorderColor)'| markdownify }}</td>
<td>{{'[SliderThumbStyle.Stroke](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderThumbStyle.html#Syncfusion_Maui_Sliders_SliderThumbStyle_Stroke)'| markdownify }}</td>
<td>Gets or sets the stroke color for the thumb.</td></tr>
<tr>
<td>{{'[ThumbStyle.BorderWidth](https://help.syncfusion.com/cr/xamarin/Syncfusion.RangeNavigator.XForms.ThumbStyle.html#Syncfusion_RangeNavigator_XForms_ThumbStyle_BorderWidth)'| markdownify }}</td>
<td>{{'[SliderThumbStyle.StrokeThickness](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderThumbStyle.html#Syncfusion_Maui_Sliders_SliderThumbStyle_StrokeThickness)'| markdownify }}</td>
<td>Gets or sets the stroke value for the thumb.</td></tr>
</table> 

### Ticks

<table> 
<tr>
<th>Xamarin SfDateTimeRangeNavigator</th>
<th>.NET MAUI SfDateTimeRangeSelector</th>
<th>Description</th></tr>
<tr>
<td rowspan="2" valign="center">
			{{'[ScaleStyle.TickLineColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.RangeNavigator.XForms.ScaleStyle.html#Syncfusion_RangeNavigator_XForms_ScaleStyle_TickLineColor)'| markdownify }}<br/>
		</td>
<td>{{'[SliderTickStyle.ActiveFill](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderTickStyle.html#Syncfusion_Maui_Sliders_SliderTickStyle_ActiveFill)'| markdownify }}</td>
<td>Gets or sets the brush for the active ticks.</td></tr>
<tr>
<td>{{'[SliderTickStyle.InactiveFill](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderTickStyle.html#Syncfusion_Maui_Sliders_SliderTickStyle_InactiveFill)'| markdownify }}</td>
<td>Gets or sets the brush for the inactive ticks.</td></tr>
<tr>
<td rowspan="2" valign="center">
			{{'[ScaleStyle.TickLineWidth](https://help.syncfusion.com/cr/xamarin/Syncfusion.RangeNavigator.XForms.ScaleStyle.html#Syncfusion_RangeNavigator_XForms_ScaleStyle_TickLineWidth)'| markdownify }}<br/>
		</td>
<td>{{'[SliderTickStyle.ActiveSize](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderTickStyle.html#Syncfusion_Maui_Sliders_SliderTickStyle_ActiveSize)'| markdownify }}</td>
<td>Gets or sets the size for the active ticks.</td></tr>
<tr>
<td>{{'[SliderTickStyle.InactiveSize](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderTickStyle.html#Syncfusion_Maui_Sliders_SliderTickStyle_InactiveSize)'| markdownify }}</td>
<td>Gets or sets the size for the inactive ticks.</td></tr>
</table> 

### Labels

<table> 
<tr>
<th>Xamarin SfDateTimeRangeNavigator</th>
<th>.NET MAUI SfDateTimeRangeSelector</th>
<th>Description</th></tr>
<tr>
<td>{{'[ScaleStyle.IsVisible](https://help.syncfusion.com/cr/xamarin/Syncfusion.RangeNavigator.XForms.ScaleStyle.html#Syncfusion_RangeNavigator_XForms_ScaleStyle_IsVisible)'| markdownify }}</td>
<td>{{'[ShowLabels](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_ShowLabels)'| markdownify }}</td>
<td>Gets or sets a value indicating whether to show or hide the labels.</td></tr>
<tr>
<td>{{'[ScaleStyle.LabelTextColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.RangeNavigator.XForms.ScaleStyle.html#Syncfusion_RangeNavigator_XForms_ScaleStyle_LabelTextColor)'| markdownify }}</td>
<td>{{'[SliderLabelStyle.InactiveTextColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderLabelStyle.html#Syncfusion_Maui_Sliders_SliderLabelStyle_InactiveTextColor)'| markdownify }}</td>
<td>Gets or sets the color for the inactive labels. </td></tr>
<tr>
<td>{{'[ScaleStyle.SelectedLabelTextColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.RangeNavigator.XForms.ScaleStyle.html#Syncfusion_RangeNavigator_XForms_ScaleStyle_SelectedLabelTextColor)'| markdownify }}</td>
<td>{{'[SliderLabelStyle.ActiveTextColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderLabelStyle.html#Syncfusion_Maui_Sliders_SliderLabelStyle_ActiveTextColor)'| markdownify }}</td>
<td>Gets or sets the color for the active labels.</td></tr>
<tr>
<td>{{'[ScaleStyle.LabelFontFamily](https://help.syncfusion.com/cr/xamarin/Syncfusion.RangeNavigator.XForms.ScaleStyle.html#Syncfusion_RangeNavigator_XForms_ScaleStyle_LabelFontFamily)'| markdownify }}</td>
<td>{{'[SliderLabelStyle.InactiveFontFamily](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderLabelStyle.html#Syncfusion_Maui_Sliders_SliderLabelStyle_InactiveFontFamily)'| markdownify }}</td>
<td>Gets or sets the font family for the inactive labels.</td></tr>
<tr>
<td>{{'[ScaleStyle.SelectedLabelFontFamily](https://help.syncfusion.com/cr/xamarin/Syncfusion.RangeNavigator.XForms.ScaleStyle.html#Syncfusion_RangeNavigator_XForms_ScaleStyle_SelectedLabelFontFamily)'| markdownify }}</td>
<td>{{'[SliderLabelStyle.ActiveFontFamily](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderLabelStyle.html#Syncfusion_Maui_Sliders_SliderLabelStyle_ActiveFontFamily)'| markdownify }}</td>
<td>Gets or sets the font family for the active labels.</td></tr>
<tr>
<td>{{'[ScaleStyle.LabelFontAttribute](https://help.syncfusion.com/cr/xamarin/Syncfusion.RangeNavigator.XForms.ScaleStyle.html#Syncfusion_RangeNavigator_XForms_ScaleStyle_LabelFontAttributes)'| markdownify }}</td>
<td>{{'[SliderLabelStyle.InactiveFontAttributes](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderLabelStyle.html#Syncfusion_Maui_Sliders_SliderLabelStyle_InactiveFontAttributes)'| markdownify }}</td>
<td>Gets or sets the font attributes for the inactive labels.</td></tr>
<tr>
<td>{{'[ScaleStyle.SelectedLabelFontAttribute](https://help.syncfusion.com/cr/xamarin/Syncfusion.RangeNavigator.XForms.ScaleStyle.html#Syncfusion_RangeNavigator_XForms_ScaleStyle_SelectedLabelFontAttributes)'| markdownify }}</td>
<td>{{'[SliderLabelStyle.ActiveFontAttributes](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderLabelStyle.html#Syncfusion_Maui_Sliders_SliderLabelStyle_ActiveFontAttributes)'| markdownify }}</td>
<td>Gets or sets the font attributes for the active labels.</td></tr>
<tr>
<td>{{'[ScaleStyle.LabelFontSize](https://help.syncfusion.com/cr/xamarin/Syncfusion.RangeNavigator.XForms.ScaleStyle.html#Syncfusion_RangeNavigator_XForms_ScaleStyle_LabelFontSize)'| markdownify }}</td>
<td>{{'[SliderLabelStyle.InactiveFontSize](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderLabelStyle.html#Syncfusion_Maui_Sliders_SliderLabelStyle_InactiveFontSize)'| markdownify }}</td>
<td>Gets or sets the size for the inactive font. </td></tr>
<tr>
<td>{{'[ScaleStyle.SelectedLabelFontSize](https://help.syncfusion.com/cr/xamarin/Syncfusion.RangeNavigator.XForms.ScaleStyle.html#Syncfusion_RangeNavigator_XForms_ScaleStyle_SelectedLabelFontSize)'| markdownify }}</td>
<td>{{'[SliderLabelStyle.ActiveFontSize](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderLabelStyle.html#Syncfusion_Maui_Sliders_SliderLabelStyle_ActiveFontSize)'| markdownify }}</td>
<td>Gets or sets the size for the active font.</td></tr>
</table> 

### Tooltip

<table> 
<tr>
<th>Xamarin SfDateTimeRangeNavigator</th>
<th>.NET MAUI SfDateTimeRangeSelector</th>
<th>Description</th></tr>
<tr>
<td>{{'[TooltipStyle.BackgroundColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.RangeNavigator.XForms.TooltipStyle.html#Syncfusion_RangeNavigator_XForms_TooltipStyle_BackgroundColor)'| markdownify }}</td>
<td>{{'[SliderTooltip.Fill](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderTooltip.html#Syncfusion_Maui_Sliders_SliderTooltip_Fill)'| markdownify }}</td>
<td>Gets or sets the brush for the tooltip.</td></tr>
<tr>
<td>{{'[TooltipStyle.TextColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.RangeNavigator.XForms.TooltipStyle.html#Syncfusion_RangeNavigator_XForms_TooltipStyle_TextColor)'| markdownify }}</td>
<td>{{'[SliderTooltip.TextColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderTooltip.html#Syncfusion_Maui_Sliders_SliderTooltip_TextColor)'| markdownify }}</td>
<td>Gets or sets the color for the tooltip text.</td></tr>
<tr>
<td>{{'[TooltipStyle.BorderColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.RangeNavigator.XForms.TooltipStyle.html#Syncfusion_RangeNavigator_XForms_TooltipStyle_BorderColor)'| markdownify }}</td>
<td>{{'[SliderTooltip.Stroke](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderTooltip.html#Syncfusion_Maui_Sliders_SliderTooltip_Stroke)'| markdownify }}</td>
<td>Gets or sets the brush for the tooltip stroke.</td></tr>
<tr>
<td>{{'[TooltipStyle.BorderWidth](https://help.syncfusion.com/cr/xamarin/Syncfusion.RangeNavigator.XForms.TooltipStyle.html#Syncfusion_RangeNavigator_XForms_TooltipStyle_BorderWidth)'| markdownify }}</td>
<td>{{'[SliderTooltip.StrokeThickness](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderTooltip.html#Syncfusion_Maui_Sliders_SliderTooltip_StrokeThickness)'| markdownify }}</td>
<td>Gets or sets the stroke size for the tooltip.</td></tr>
<tr>
<td>{{'[TooltipStyle.FontSize](https://help.syncfusion.com/cr/xamarin/Syncfusion.RangeNavigator.XForms.TooltipStyle.html#Syncfusion_RangeNavigator_XForms_TooltipStyle_FontSize)'| markdownify }}</td>
<td>{{'[SliderTooltip.FontSize](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderTooltip.html#Syncfusion_Maui_Sliders_SliderTooltip_FontSize)'| markdownify }}</td>
<td>Gets or sets the font size for the tooltip text.</td></tr>
<tr>
<td>{{'[TooltipStyle.FontFamily](https://help.syncfusion.com/cr/xamarin/Syncfusion.RangeNavigator.XForms.TooltipStyle.html#Syncfusion_RangeNavigator_XForms_TooltipStyle_FontFamily)'| markdownify }}</td>
<td>{{'[SliderTooltip.FontFamily](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderTooltip.html#Syncfusion_Maui_Sliders_SliderTooltip_FontFamily)'| markdownify }}</td>
<td>Gets or sets the font family for the tooltip text.</td></tr>
<tr>
<td>{{'[TooltipStyle.FontAttributes](https://help.syncfusion.com/cr/xamarin/Syncfusion.RangeNavigator.XForms.TooltipStyle.html#Syncfusion_RangeNavigator_XForms_TooltipStyle_FontAttributes)'| markdownify }}</td>
<td>{{'[SliderTooltip.FontAttributes](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderTooltip.html#Syncfusion_Maui_Sliders_SliderTooltip_FontAttributes)'| markdownify }}</td>
<td>Gets or sets the font attributes for the tooltip text.</td></tr>
</table> 

## Events

<table>
<tr>
<th>Xamarin SfDateTimeRangeNavigator</th>
<th>.NET MAUI SfDateTimeRangeSelector</th>
<th>Description</th></tr>
<tr>
<td>{{'[MinorScaleLabelsCreated](https://help.syncfusion.com/cr/xamarin/Syncfusion.RangeNavigator.XForms.SfDateTimeRangeNavigator.html#Syncfusion_RangeNavigator_XForms_SfDateTimeRangeNavigator_MinorScaleLabelsCreated)'| markdownify }}</td>
<td>{{'[LabelCreated](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_LabelCreated)'| markdownify }}</td>
<td>It occurs when a label is created. It is used to format or change the label text.</td></tr>
<tr>
<td>{{'[RangeChanged](https://help.syncfusion.com/cr/xamarin/Syncfusion.RangeNavigator.XForms.SfDateTimeRangeNavigator.html#Syncfusion_RangeNavigator_XForms_SfDateTimeRangeNavigator_RangeChanged)'| markdownify }}</td>
<td>{{'[ValueChanged](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SfDateTimeRangeSelector.html#Syncfusion_Maui_Sliders_SfDateTimeRangeSelector_ValueChanged)'| markdownify }}</td>
<td>It occurs when the user is done selecting a new value for the DateTime Range Selector.</td></tr>
</table> 
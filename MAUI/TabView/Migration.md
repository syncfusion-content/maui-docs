---
layout: post
title: Migrating from Xamarin SfTabView to .NET MAUI SfTabView | Syncfusion®
description: Learn here all about Migrating from Syncfusion® Xamarin TabView to Syncfusion® .NET MAUI TabView control and more.
platform: MAUI
control: SfTabView
documentation: ug
---  

# Migrating from Xamarin SfTabView to .NET MAUI SfTabView 

To migrate easier from Xamarin SfTabView to .NET MAUI SfTabView, we kept most of the APIs from Xamarin SfTabView in MAUI SfTabView. However, to maintain the consistency of API naming in MAUI SfTabView, we renamed some of the APIs. The APIs that have been changed in MAUI SfTabView from Xamarin SfTabView are detailed as follows.

## Namespaces 

<table>
<tr>
<th>Xamarin SfTabView</th>
<th>.NET MAUI SfTabView</th></tr>
<tr>
<td>Syncfusion.XForms.TabView</td>
<td>Syncfusion.Maui.TabView</td></tr>
</table>

## Properties

<table> 
<tr>
<th>Xamarin SfTabView</th>
<th>.NET MAUI SfTabView</th>
<th>Description</th></tr>
<tr>
<td>{{'[Color](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.TabView.SelectionIndicatorSettings.html#Syncfusion_XForms_TabView_SelectionIndicatorSettings_Color)'| markdownify}}</td>
<td>{{'[IndicatorBackground](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TabView.SfTabView.html#Syncfusion_Maui_TabView_SfTabView_IndicatorBackground)'| markdownify}}</td>
<td>Gets or sets a brush that describes the selection indicator's background.</td></tr>
<tr>
<td>{{'[Position](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.TabView.SelectionIndicatorSettings.html#Syncfusion_XForms_TabView_SelectionIndicatorSettings_Position)'| markdownify}}</td>
<td>{{'[IndicatorPlacement](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TabView.SfTabView.html#Syncfusion_Maui_TabView_SfTabView_IndicatorPlacement)'| markdownify}}</td>
<td>Gets or sets the placement of the selection indicator.</td></tr>
<tr>
<td>{{'[TabHeaderBackgroundColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.TabView.SfTabView.html#Syncfusion_XForms_TabView_SfTabView_TabHeaderBackgroundColor)'| markdownify}}</td>
<td>{{'[TabBarBackground](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TabView.SfTabView.html#Syncfusion_Maui_TabView_SfTabView_TabBarBackground)'| markdownify}}</td>
<td>Gets or sets a brush that describes the tab header's background.</td></tr>
<tr>
<td>{{'[TabHeight](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.TabView.SfTabView.html#Syncfusion_XForms_TabView_SfTabView_TabHeight)'| markdownify}}</td>
<td>{{'[TabBarHeight](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TabView.SfTabView.html#Syncfusion_Maui_TabView_SfTabView_TabBarHeight)'| markdownify}}</td>
<td>Gets or sets the height of the tab header.</td></tr>
<tr>
<td>{{'[TabHeaderPosition](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.TabView.SfTabView.html#Syncfusion_XForms_TabView_SfTabView_TabHeaderPosition)'| markdownify}}</td>
<td>{{'[TabBarPlacement](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TabView.SfTabView.html#Syncfusion_Maui_TabView_SfTabView_TabBarPlacement)'| markdownify}}</td>
<td>Gets or sets whether the tab header should be at the bottom or at the top of the tab content.</td></tr>
<tr>
<td>{{'[TitleFontAttributes](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.TabView.SfTabItem.html#Syncfusion_XForms_TabView_SfTabItem_TitleFontAttributes)'| markdownify}}</td>
<td>{{'[FontAttributes](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TabView.SfTabItem.html#Syncfusion_Maui_TabView_SfTabItem_FontAttributes)'| markdownify}}</td>
<td>Gets or sets the value that defines the font attributes of the tab header.</td></tr>
<tr>
<td>{{'[TitleFontFamily](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.TabView.SfTabItem.html#Syncfusion_XForms_TabView_SfTabItem_TitleFontFamily)'| markdownify }}</td>
<td>{{'[FontFamily](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TabView.SfTabItem.html#Syncfusion_Maui_TabView_SfTabItem_FontFamily)'| markdownify }}</td>
<td>Gets or sets the value that defines the font family of the header.</td></tr>
<tr>
<td>{{'[TitleFontSize](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.TabView.SfTabItem.html#Syncfusion_XForms_TabView_SfTabItem_TitleFontSize)' | markdownify }}</td>
<td>{{'[FontSize](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TabView.SfTabItem.html#Syncfusion_Maui_TabView_SfTabItem_FontSize)'| markdownify }}</td>
<td>Gets or sets the value that defines the font size of the tab header.</td></tr>
<tr>
<td>{{'[TitleFontColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.TabView.SfTabItem.html#Syncfusion_XForms_TabView_SfTabItem_TitleFontColor)' | markdownify }}</td>
<td>{{'[TextColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TabView.SfTabItem.html#Syncfusion_Maui_TabView_SfTabItem_TextColor)'| markdownify }}</td>
<td>Gets or sets the value that defines the text color of the tab header.</td></tr>
<tr>
<td>{{'[Title](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.TabView.SfTabItem.html#Syncfusion_XForms_TabView_SfTabItem_Title)' | markdownify }}</td>
<td>{{'[Header](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TabView.SfTabItem.html#Syncfusion_Maui_TabView_SfTabItem_Header)'| markdownify }}</td>
<td>Gets or sets the text for the tab header.</td></tr>
<tr>
<td>{{'[HeaderContent](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.TabView.SfTabItem.html#Syncfusion_XForms_TabView_SfTabItem_HeaderContent)' | markdownify }}</td>
<td>{{'[HeaderItemTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TabView.SfTabView.html#Syncfusion_Maui_TabView_SfTabView_HeaderItemTemplate)'| markdownify }}</td>
<td>Gets or sets the template that is used to display the header.</td></tr>
</table> 

## Enums

<table>
<tr>
<th>Enum</th>
<th>Xamarin SfTabView</th>
<th>.NET MAUI SfTabView</th>
<th>Description</th></tr>
<tr>
<td>TabWidthMode</td>
<td>BasedOnText,<br/>Default</td>
<td>Default,<br/>SizeToContent</td>
<td>Defines the width of each tab.</td></tr>
</table>

## Classes 

<table>
<tr>
<th>Xamarin SfTabView</th>
<th>.NET MAUI SfTabView</th>
<th>Description</th></tr>
<tr>
<td>{{'[TabHeaderPosition](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.TabView.TabHeaderPosition.html)'| markdownify}}</td>
<td>{{'[TabBarPlacement](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TabView.TabBarPlacement.html)'| markdownify }}</td>
<td>Describes the possible values for the position of header layout in SfTabView control.</td></tr>
<tr> 
<td>{{'[SelectionIndicatorPosition](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.TabView.SelectionIndicatorPosition.html)'| markdownify }}</td>
<td>{{'[TabIndicatorPlacement](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TabView.TabIndicatorPlacement.html)'| markdownify }}</td>
<td>Describes the possible values for selection indicator placement.</td></tr> 
<tr>
<td>{{'[SelectionChangedEventArgs](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.TabView.SelectionChangedEventArgs.html)'| markdownify}}</td>
<td>{{'[TabSelectionChangedEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TabView.TabSelectionChangedEventArgs.html)'| markdownify }}</td>
<td>This class serves as an event data for the SelectionChanged event.</td></tr>
</table>

## Upcoming features

  * Center button support.
  * Drop-down mode.
  * Visible header count.

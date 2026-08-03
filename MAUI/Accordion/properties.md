---
layout: post
title: Properties of .NET MAUI Accordion control | Syncfusion®
description: This section explains the properties, events, and methods with Syncfusion® MAUI Accordion (SfAccordion) control.
platform: MAUI
control: SfAccordion
documentation: ug
---

# .NET MAUI Accordion API Reference

## Properties

<table>
	<tr>
		<th>Name</th>
		<th>Type</th>
		<th>Description</th>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.SfAccordion.html#Syncfusion_Maui_Accordion_SfAccordion_AnimationDuration">AnimationDuration</a></td>
		<td>double</td>
		<td>Defines the animation duration.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.SfAccordion.html#Syncfusion_Maui_Accordion_SfAccordion_AnimationEasing">AnimationEasing</a></td>
		<td>ExpanderAnimationEasing</td>
		<td>Defines the easing used for expand and collapse animation.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.SfAccordion.html#Syncfusion_Maui_Accordion_SfAccordion_AutoScrollPosition">AutoScrollPosition</a></td>
		<td>AccordionAutoScrollPosition</td>
		<td>Defines the auto scroll position.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.SfAccordion.html#Syncfusion_Maui_Accordion_SfAccordion_ExpandMode">ExpandMode</a></td>
		<td>AccordionExpandMode</td>
		<td>Defines the expand mode.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.SfAccordion.html#Syncfusion_Maui_Accordion_SfAccordion_HeaderIconPosition">HeaderIconPosition</a></td>
		<td>ExpanderIconPosition</td>
		<td>Defines the header icon position.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.SfAccordion.html#Syncfusion_Maui_Accordion_SfAccordion_ItemSpacing">ItemSpacing</a></td>
		<td>double</td>
		<td>Defines the spacing between accordion items.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.SfAccordion.html#Syncfusion_Maui_Accordion_SfAccordion_Items">Items</a></td>
		<td>ObservableCollection&lt;AccordionItem&gt;</td>
		<td>Defines the collection of accordion items.</td>
	</tr>
</table>

## Events

<table>
	<tr>
		<th>Name</th>
		<th>Type</th>
		<th>Description</th>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.SfAccordion.html#Syncfusion_Maui_Accordion_SfAccordion_Collapsed">Collapsed</a></td>
		<td>ExpandedAndCollapsedEventArgs</td>
		<td>Raised after an accordion item collapses.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.SfAccordion.html#Syncfusion_Maui_Accordion_SfAccordion_Collapsing">Collapsing</a></td>
		<td>ExpandingAndCollapsingEventArgs</td>
		<td>Raised before an accordion item collapses.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.SfAccordion.html#Syncfusion_Maui_Accordion_SfAccordion_Expanded">Expanded</a></td>
		<td>ExpandedAndCollapsedEventArgs</td>
		<td>Raised after an accordion item expands.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.SfAccordion.html#Syncfusion_Maui_Accordion_SfAccordion_Expanding">Expanding</a></td>
		<td>ExpandingAndCollapsingEventArgs</td>
		<td>Raised before an accordion item expands.</td>
	</tr>
</table>

## Methods

<table>
	<tr>
		<th>Name</th>
		<th>Type</th>
		<th>Description</th>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.SfAccordion.html#Syncfusion_Maui_Accordion_SfAccordion_BringIntoView_Syncfusion_Maui_Accordion_AccordionItem_">BringIntoView(AccordionItem)</a></td>
		<td>void</td>
		<td>Scrolls the specified accordion item into view.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.SfAccordion.html#Syncfusion_Maui_Accordion_SfAccordion_OnCommonThemeChanged_System_String_System_String_">OnCommonThemeChanged(string, string)</a></td>
		<td>void</td>
		<td>Invoked when the common theme changes.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.SfAccordion.html#Syncfusion_Maui_Accordion_SfAccordion_OnControlThemeChanged_System_String_System_String_">OnControlThemeChanged(string, string)</a></td>
		<td>void</td>
		<td>Invoked when the control theme changes.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.SfAccordion.html#Syncfusion_Maui_Accordion_SfAccordion_RaiseCollapsedEvent_System_Int32_">RaiseCollapsedEvent(int)</a></td>
		<td>void</td>
		<td>Raises the Collapsed event for the specified accordion item index.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.SfAccordion.html#Syncfusion_Maui_Accordion_SfAccordion_RaiseCollapsingEvent_System_Int32_">RaiseCollapsingEvent(int)</a></td>
		<td>bool</td>
		<td>Raises the Collapsing event for the specified accordion item index.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.SfAccordion.html#Syncfusion_Maui_Accordion_SfAccordion_RaiseExpandedEvent_System_Int32_">RaiseExpandedEvent(int)</a></td>
		<td>void</td>
		<td>Raises the Expanded event for the specified accordion item index.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.SfAccordion.html#Syncfusion_Maui_Accordion_SfAccordion_RaiseExpandingEvent_System_Int32_">RaiseExpandingEvent(int)</a></td>
		<td>bool</td>
		<td>Raises the Expanding event for the specified accordion item index.</td>
	</tr>
</table>

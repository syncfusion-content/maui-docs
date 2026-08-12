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
        <td>Defines the duration of the expand and collapse animation.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.SfAccordion.html#Syncfusion_Maui_Accordion_SfAccordion_AnimationEasing">AnimationEasing</a></td>
        <td>ExpanderAnimationEasing</td>
        <td>Defines the easing applied to expand and collapse animations.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.SfAccordion.html#Syncfusion_Maui_Accordion_SfAccordion_AutoScrollPosition">AutoScrollPosition</a></td>
        <td>AccordionAutoScrollPosition</td>
        <td>Defines the position used when scrolling an item into view.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.SfAccordion.html#Syncfusion_Maui_Accordion_SfAccordion_ExpandMode">ExpandMode</a></td>
        <td>AccordionExpandMode</td>
        <td>Defines how accordion items expand and collapse.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.SfAccordion.html#Syncfusion_Maui_Accordion_SfAccordion_HeaderIconPosition">HeaderIconPosition</a></td>
        <td>ExpanderIconPosition</td>
        <td>Defines the position of the header icon in each accordion item.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.SfAccordion.html#Syncfusion_Maui_Accordion_SfAccordion_ItemSpacing">ItemSpacing</a></td>
        <td>double</td>
        <td>Defines the spacing between adjacent accordion items.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.SfAccordion.html#Syncfusion_Maui_Accordion_SfAccordion_Items">Items</a></td>
        <td>ObservableCollection&lt;AccordionItem&gt;</td>
        <td>Defines the collection of items displayed in the accordion.</td>
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
        <td>Scrolls the specified item into view.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.SfAccordion.html#Syncfusion_Maui_Accordion_SfAccordion_OnCommonThemeChanged_System_String_System_String_">OnCommonThemeChanged(string, string)</a></td>
        <td>void</td>
        <td>Called when the common theme changes.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.SfAccordion.html#Syncfusion_Maui_Accordion_SfAccordion_OnControlThemeChanged_System_String_System_String_">OnControlThemeChanged(string, string)</a></td>
        <td>void</td>
        <td>Called when the control theme changes.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.SfAccordion.html#Syncfusion_Maui_Accordion_SfAccordion_RaiseCollapsedEvent_System_Int32_">RaiseCollapsedEvent(int)</a></td>
        <td>void</td>
        <td>Raises the collapsed event for the specified item index.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.SfAccordion.html#Syncfusion_Maui_Accordion_SfAccordion_RaiseCollapsingEvent_System_Int32_">RaiseCollapsingEvent(int)</a></td>
        <td>bool</td>
        <td>Raises the collapsing event for the specified item index.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.SfAccordion.html#Syncfusion_Maui_Accordion_SfAccordion_RaiseExpandedEvent_System_Int32_">RaiseExpandedEvent(int)</a></td>
        <td>void</td>
        <td>Raises the expanded event for the specified item index.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.SfAccordion.html#Syncfusion_Maui_Accordion_SfAccordion_RaiseExpandingEvent_System_Int32_">RaiseExpandingEvent(int)</a></td>
        <td>bool</td>
        <td>Raises the expanding event for the specified item index.</td>
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
        <td>Raised after an accordion item finishes collapsing.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.SfAccordion.html#Syncfusion_Maui_Accordion_SfAccordion_Collapsing">Collapsing</a></td>
        <td>ExpandingAndCollapsingEventArgs</td>
        <td>Raised before an accordion item starts collapsing.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.SfAccordion.html#Syncfusion_Maui_Accordion_SfAccordion_Expanded">Expanded</a></td>
        <td>ExpandedAndCollapsedEventArgs</td>
        <td>Raised after an accordion item finishes expanding.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.SfAccordion.html#Syncfusion_Maui_Accordion_SfAccordion_Expanding">Expanding</a></td>
        <td>ExpandingAndCollapsingEventArgs</td>
        <td>Raised before an accordion item starts expanding.</td>
    </tr>
</table>

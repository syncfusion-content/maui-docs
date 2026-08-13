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
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.SfAccordion.html#Syncfusion_Maui_Accordion_SfAccordion_AnimationDuration" aria-label="View AnimationDuration property in API reference">AnimationDuration</a></td>
        <td>double</td>
        <td>Defines the duration of the expand and collapse animation.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.SfAccordion.html#Syncfusion_Maui_Accordion_SfAccordion_AnimationEasing" aria-label="View AnimationEasing property in API reference">AnimationEasing</a></td>
        <td>ExpanderAnimationEasing</td>
        <td>Defines the easing applied to expand and collapse animations.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.SfAccordion.html#Syncfusion_Maui_Accordion_SfAccordion_AutoScrollPosition" aria-label="View AutoScrollPosition property in API reference">AutoScrollPosition</a></td>
        <td>AccordionAutoScrollPosition</td>
        <td>Defines the position used when scrolling an item into view.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.SfAccordion.html#Syncfusion_Maui_Accordion_SfAccordion_ExpandMode" aria-label="View ExpandMode property in API reference">ExpandMode</a></td>
        <td>AccordionExpandMode</td>
        <td>Defines how accordion items expand and collapse.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.SfAccordion.html#Syncfusion_Maui_Accordion_SfAccordion_HeaderIconPosition" aria-label="View HeaderIconPosition property in API reference">HeaderIconPosition</a></td>
        <td>ExpanderIconPosition</td>
        <td>Defines the position of the header icon in each accordion item.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.SfAccordion.html#Syncfusion_Maui_Accordion_SfAccordion_ItemSpacing" aria-label="View ItemSpacing property in API reference">ItemSpacing</a></td>
        <td>double</td>
        <td>Defines the spacing between adjacent accordion items.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.SfAccordion.html#Syncfusion_Maui_Accordion_SfAccordion_Items" aria-label="View Items property in API reference">Items</a></td>
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
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.SfAccordion.html#Syncfusion_Maui_Accordion_SfAccordion_BringIntoView_Syncfusion_Maui_Accordion_AccordionItem_" aria-label="View BringIntoView method in API reference">BringIntoView(AccordionItem)</a></td>
        <td>void</td>
        <td>Scrolls the specified item into view.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.SfAccordion.html#Syncfusion_Maui_Accordion_SfAccordion_RaiseCollapsedEvent_System_Int32_" aria-label="View RaiseCollapsedEvent method in API reference">RaiseCollapsedEvent(int)</a></td>
        <td>void</td>
        <td>Raises the collapsed event for the specified item index.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.SfAccordion.html#Syncfusion_Maui_Accordion_SfAccordion_RaiseCollapsingEvent_System_Int32_" aria-label="View RaiseCollapsingEvent method in API reference">RaiseCollapsingEvent(int)</a></td>
        <td>bool</td>
        <td>Raises the collapsing event for the specified item index.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.SfAccordion.html#Syncfusion_Maui_Accordion_SfAccordion_RaiseExpandedEvent_System_Int32_" aria-label="View RaiseExpandedEvent method in API reference">RaiseExpandedEvent(int)</a></td>
        <td>void</td>
        <td>Raises the expanded event for the specified item index.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.SfAccordion.html#Syncfusion_Maui_Accordion_SfAccordion_RaiseExpandingEvent_System_Int32_" aria-label="View RaiseExpandingEvent method in API reference">RaiseExpandingEvent(int)</a></td>
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
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.SfAccordion.html#Syncfusion_Maui_Accordion_SfAccordion_Collapsed" aria-label="View Collapsed event in API reference">Collapsed</a></td>
        <td>ExpandedAndCollapsedEventArgs</td>
        <td>Raised after an accordion item finishes collapsing.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.SfAccordion.html#Syncfusion_Maui_Accordion_SfAccordion_Collapsing" aria-label="View Collapsing event in API reference">Collapsing</a></td>
        <td>ExpandingAndCollapsingEventArgs</td>
        <td>Raised before an accordion item starts collapsing.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.SfAccordion.html#Syncfusion_Maui_Accordion_SfAccordion_Expanded" aria-label="View Expanded event in API reference">Expanded</a></td>
        <td>ExpandedAndCollapsedEventArgs</td>
        <td>Raised after an accordion item finishes expanding.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.SfAccordion.html#Syncfusion_Maui_Accordion_SfAccordion_Expanding" aria-label="View Expanding event in API reference">Expanding</a></td>
        <td>ExpandingAndCollapsingEventArgs</td>
        <td>Raised before an accordion item starts expanding.</td>
    </tr>
</table>
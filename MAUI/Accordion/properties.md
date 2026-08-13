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
        <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
        <td>Sets how long the expand and collapse animation takes. A higher value makes the motion slower and smoother.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.SfAccordion.html#Syncfusion_Maui_Accordion_SfAccordion_AnimationEasing" aria-label="View AnimationEasing property in API reference">AnimationEasing</a></td>
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.ExpanderAnimationEasing.html" aria-label="View ExpanderAnimationEasing type in API reference">ExpanderAnimationEasing</a></td>
        <td>Controls the easing style used during expand and collapse animations. This changes how the motion starts and ends.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.SfAccordion.html#Syncfusion_Maui_Accordion_SfAccordion_AutoScrollPosition" aria-label="View AutoScrollPosition property in API reference">AutoScrollPosition</a></td>
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.AccordionAutoScrollPosition.html" aria-label="View AccordionAutoScrollPosition type in API reference">AccordionAutoScrollPosition</a></td>
        <td>Chooses where the item is placed when it is brought into view. Use this to control the final scroll position.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.SfAccordion.html#Syncfusion_Maui_Accordion_SfAccordion_ExpandMode" aria-label="View ExpandMode property in API reference">ExpandMode</a></td>
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.AccordionExpandMode.html" aria-label="View AccordionExpandMode type in API reference">AccordionExpandMode</a></td>
        <td>Controls how accordion items expand and collapse. Use it to allow one or multiple items to stay open.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.SfAccordion.html#Syncfusion_Maui_Accordion_SfAccordion_HeaderIconPosition" aria-label="View HeaderIconPosition property in API reference">HeaderIconPosition</a></td>
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.ExpanderIconPosition.html" aria-label="View ExpanderIconPosition type in API reference">ExpanderIconPosition</a></td>
        <td>Sets where the header icon appears in each item. This helps align the icon with your layout.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.SfAccordion.html#Syncfusion_Maui_Accordion_SfAccordion_ItemSpacing" aria-label="View ItemSpacing property in API reference">ItemSpacing</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
        <td>Defines the space between accordion items. Increase this to add more breathing room between sections.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.SfAccordion.html#Syncfusion_Maui_Accordion_SfAccordion_Items" aria-label="View Items property in API reference">Items</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.collections.objectmodel.observablecollection-1" aria-label="View ObservableCollection type in API reference">ObservableCollection&lt;</a><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.AccordionItem.html" aria-label="View AccordionItem type in API reference">AccordionItem</a><a href="https://learn.microsoft.com/dotnet/api/system.collections.objectmodel.observablecollection-1" aria-label="View ObservableCollection type in API reference">&gt;</a></td>
        <td>Holds the collection of accordion items shown in the control. Add or remove items here to update the UI.</td>
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
        <td><a href="https://learn.microsoft.com/dotnet/api/system.void" aria-label="View void type in API reference">void</a></td>
        <td>Scrolls the specified item into view. Use this when you want to focus on a particular section.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.SfAccordion.html#Syncfusion_Maui_Accordion_SfAccordion_RaiseCollapsedEvent_System_Int32_" aria-label="View RaiseCollapsedEvent method in API reference">RaiseCollapsedEvent(int)</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.void" aria-label="View void type in API reference">void</a></td>
        <td>Raises the collapsed event for the specified item index. Use this after an item finishes collapsing.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.SfAccordion.html#Syncfusion_Maui_Accordion_SfAccordion_RaiseCollapsingEvent_System_Int32_" aria-label="View RaiseCollapsingEvent method in API reference">RaiseCollapsingEvent(int)</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a></td>
        <td>Raises the collapsing event for the specified item index. Use this before collapse begins.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.SfAccordion.html#Syncfusion_Maui_Accordion_SfAccordion_RaiseExpandedEvent_System_Int32_" aria-label="View RaiseExpandedEvent method in API reference">RaiseExpandedEvent(int)</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.void" aria-label="View void type in API reference">void</a></td>
        <td>Raises the expanded event for the specified item index. Use this after an item finishes expanding.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.SfAccordion.html#Syncfusion_Maui_Accordion_SfAccordion_RaiseExpandingEvent_System_Int32_" aria-label="View RaiseExpandingEvent method in API reference">RaiseExpandingEvent(int)</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a></td>
        <td>Raises the expanding event for the specified item index. Use this before expansion begins.</td>
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
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.ExpandedAndCollapsedEventArgs.html" aria-label="View ExpandedAndCollapsedEventArgs type in API reference">ExpandedAndCollapsedEventArgs</a></td>
        <td>Occurs after an accordion item has finished collapsing. Use this to react to the closed state.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.SfAccordion.html#Syncfusion_Maui_Accordion_SfAccordion_Collapsing" aria-label="View Collapsing event in API reference">Collapsing</a></td>
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.ExpandingAndCollapsingEventArgs.html" aria-label="View ExpandingAndCollapsingEventArgs type in API reference">ExpandingAndCollapsingEventArgs</a></td>
        <td>Occurs just before an accordion item starts collapsing. Use this to cancel or adjust the action.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.SfAccordion.html#Syncfusion_Maui_Accordion_SfAccordion_Expanded" aria-label="View Expanded event in API reference">Expanded</a></td>
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.ExpandedAndCollapsedEventArgs.html" aria-label="View ExpandedAndCollapsedEventArgs type in API reference">ExpandedAndCollapsedEventArgs</a></td>
        <td>Occurs after an accordion item has finished expanding. Use this to update the UI or load content.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.SfAccordion.html#Syncfusion_Maui_Accordion_SfAccordion_Expanding" aria-label="View Expanding event in API reference">Expanding</a></td>
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.ExpandingAndCollapsingEventArgs.html" aria-label="View ExpandingAndCollapsingEventArgs type in API reference">ExpandingAndCollapsingEventArgs</a></td>
        <td>Occurs just before an accordion item starts expanding. Use this to prepare content or stop the action.</td>
    </tr>
</table>
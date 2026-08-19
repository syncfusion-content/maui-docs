---
layout: post
title: Properties of .NET MAUI Accordion control | Syncfusion®
description: This section explains the properties, events, and methods with Syncfusion® MAUI Accordion (SfAccordion) control.
platform: MAUI
control: SfAccordion
documentation: ug
---

# API Reference for .NET MAUI Accordion

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
        <td>Time taken by the expand and collapse transition in milliseconds. Larger values slow down the animation.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.SfAccordion.html#Syncfusion_Maui_Accordion_SfAccordion_AnimationEasing" aria-label="View AnimationEasing property in API reference">AnimationEasing</a></td>
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Expander.ExpanderAnimationEasing.html" aria-label="View ExpanderAnimationEasing type in API reference">ExpanderAnimationEasing</a></td>
        <td>Easing curve for the animation. Choose <code>Linear</code>, <code>EaseIn</code>, <code>EaseOut</code>, or <code>EaseInOut</code> to control motion feel.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.SfAccordion.html#Syncfusion_Maui_Accordion_SfAccordion_EnableLiquidGlassEffect" aria-label="View EnableLiquidGlassEffect property in API reference">EnableLiquidGlassEffect</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
        <td>Toggles the liquid glass visual effect. Turn it on for a glassy surface or off for a flat one.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.SfAccordion.html#Syncfusion_Maui_Accordion_SfAccordion_AutoScrollPosition" aria-label="View AutoScrollPosition property in API reference">AutoScrollPosition</a></td>
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.AccordionAutoScrollPosition.html" aria-label="View AccordionAutoScrollPosition type in API reference">AccordionAutoScrollPosition</a></td>
        <td>Where the expanded item aligns after opening. Use <code>None</code>, <code>Top</code>, or <code>Bottom</code> to control viewport position.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.SfAccordion.html#Syncfusion_Maui_Accordion_SfAccordion_ExpandMode" aria-label="View ExpandMode property in API reference">ExpandMode</a></td>
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.AccordionExpandMode.html" aria-label="View AccordionExpandMode type in API reference">AccordionExpandMode</a></td>
        <td>How many items stay open at once. Pick <code>Single</code>, <code>SingleOrNone</code>, or <code>Multiple</code> to set the open behavior.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.SfAccordion.html#Syncfusion_Maui_Accordion_SfAccordion_HeaderIconPosition" aria-label="View HeaderIconPosition property in API reference">HeaderIconPosition</a></td>
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Expander.ExpanderIconPosition.html" aria-label="View ExpanderIconPosition type in API reference">ExpanderIconPosition</a></td>
        <td>Edge of the header that holds the chevron. Use <code>Start</code> or <code>End</code> to place the icon.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.SfAccordion.html#Syncfusion_Maui_Accordion_SfAccordion_ItemSpacing" aria-label="View ItemSpacing property in API reference">ItemSpacing</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
        <td>Gap between items in device independent units. Larger values add more visual separation.</td>
    </tr>
   <tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.SfAccordion.html#Syncfusion_Maui_Accordion_SfAccordion_Items" aria-label="View Items property in API reference">Items</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.collections.objectmodel.observablecollection-1" aria-label="View ObservableCollection type in API reference">ObservableCollection&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.AccordionItem.html" aria-label="View AccordionItem type in API reference">AccordionItem&gt;</a></a></td>
    <td>Defines the collection of accordion items displayed in the control and controls the set of panels rendered in the accordion layout.</td>
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
        <td>Scrolls the item into view. It repositions the viewport without expanding the item.</td>
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
        <td>Fires after an item finishes collapsing. Use it for cleanup or state updates.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.SfAccordion.html#Syncfusion_Maui_Accordion_SfAccordion_Collapsing" aria-label="View Collapsing event in API reference">Collapsing</a></td>
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.ExpandingAndCollapsingEventArgs.html" aria-label="View ExpandingAndCollapsingEventArgs type in API reference">ExpandingAndCollapsingEventArgs</a></td>
        <td>Fires before an item begins collapsing. Cancel the event to keep the section open.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.SfAccordion.html#Syncfusion_Maui_Accordion_SfAccordion_Expanded" aria-label="View Expanded event in API reference">Expanded</a></td>
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.ExpandedAndCollapsedEventArgs.html" aria-label="View ExpandedAndCollapsedEventArgs type in API reference">ExpandedAndCollapsedEventArgs</a></td>
        <td>Fires after an item finishes expanding. Use it to load content or update state.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.SfAccordion.html#Syncfusion_Maui_Accordion_SfAccordion_Expanding" aria-label="View Expanding event in API reference">Expanding</a></td>
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.ExpandingAndCollapsingEventArgs.html" aria-label="View ExpandingAndCollapsingEventArgs type in API reference">ExpandingAndCollapsingEventArgs</a></td>
        <td>Fires before an item begins expanding. Cancel the event to block the section from opening.</td>
    </tr>
</table>
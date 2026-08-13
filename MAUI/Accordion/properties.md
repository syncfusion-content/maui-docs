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
        <td>Defines how long the expand and collapse animations take. Higher values make the transition slower and smoother.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.SfAccordion.html#Syncfusion_Maui_Accordion_SfAccordion_AnimationEasing" aria-label="View AnimationEasing property in API reference">AnimationEasing</a></td>
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.ExpanderAnimationEasing.html" aria-label="View ExpanderAnimationEasing type in API reference">ExpanderAnimationEasing</a></td>
        <td>Determines the easing style used during expand and collapse animations. This changes how the motion begins and ends.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.SfAccordion.html#Syncfusion_Maui_Accordion_SfAccordion_EnableLiquidGlassEffect" aria-label="View EnableLiquidGlassEffect property in API reference">EnableLiquidGlassEffect</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
        <td>Defines whether the liquid glass visual effect is applied to the accordion. This changes the overall appearance of the control.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.SfAccordion.html#Syncfusion_Maui_Accordion_SfAccordion_AutoScrollPosition" aria-label="View AutoScrollPosition property in API reference">AutoScrollPosition</a></td>
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.AccordionAutoScrollPosition.html" aria-label="View AccordionAutoScrollPosition type in API reference">AccordionAutoScrollPosition</a></td>
        <td>Determines where the item appears after it is brought into view. This helps keep the focused item in the preferred position.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.SfAccordion.html#Syncfusion_Maui_Accordion_SfAccordion_ExpandMode" aria-label="View ExpandMode property in API reference">ExpandMode</a></td>
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.AccordionExpandMode.html" aria-label="View AccordionExpandMode type in API reference">AccordionExpandMode</a></td>
        <td>Determines whether one item or multiple items can stay open at the same time. This defines the accordion expansion behavior.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.SfAccordion.html#Syncfusion_Maui_Accordion_SfAccordion_HeaderIconPosition" aria-label="View HeaderIconPosition property in API reference">HeaderIconPosition</a></td>
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.ExpanderIconPosition.html" aria-label="View ExpanderIconPosition type in API reference">ExpanderIconPosition</a></td>
        <td>Determines where the header icon appears in each item. This helps match the icon with the layout.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.SfAccordion.html#Syncfusion_Maui_Accordion_SfAccordion_ItemSpacing" aria-label="View ItemSpacing property in API reference">ItemSpacing</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
        <td>Defines the space between accordion items. Larger values create more separation between sections.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.SfAccordion.html#Syncfusion_Maui_Accordion_SfAccordion_Items" aria-label="View Items property in API reference">Items</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.collections.objectmodel.observablecollection-1" aria-label="View ObservableCollection type in API reference">ObservableCollection&lt;</a><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.AccordionItem.html" aria-label="View AccordionItem type in API reference">AccordionItem</a><a href="https://learn.microsoft.com/dotnet/api/system.collections.objectmodel.observablecollection-1" aria-label="View ObservableCollection type in API reference">&gt;</a></td>
        <td>Defines the collection of accordion items shown in the control. Changes to this collection are reflected in the UI.</td>
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
        <td>Defines a way to scroll the specified item into view. This helps focus on a specific section.</td>
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
        <td>Occurs after an accordion item finishes collapsing. This can be used to update the UI after the item closes.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.SfAccordion.html#Syncfusion_Maui_Accordion_SfAccordion_Collapsing" aria-label="View Collapsing event in API reference">Collapsing</a></td>
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.ExpandingAndCollapsingEventArgs.html" aria-label="View ExpandingAndCollapsingEventArgs type in API reference">ExpandingAndCollapsingEventArgs</a></td>
        <td>Occurs before an accordion item begins collapsing. This can be used to adjust or cancel the action.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.SfAccordion.html#Syncfusion_Maui_Accordion_SfAccordion_Expanded" aria-label="View Expanded event in API reference">Expanded</a></td>
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.ExpandedAndCollapsedEventArgs.html" aria-label="View ExpandedAndCollapsedEventArgs type in API reference">ExpandedAndCollapsedEventArgs</a></td>
        <td>Occurs after an accordion item finishes expanding. This can be used to load follow-up content or update state.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.SfAccordion.html#Syncfusion_Maui_Accordion_SfAccordion_Expanding" aria-label="View Expanding event in API reference">Expanding</a></td>
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.ExpandingAndCollapsingEventArgs.html" aria-label="View ExpandingAndCollapsingEventArgs type in API reference">ExpandingAndCollapsingEventArgs</a></td>
        <td>Occurs before an accordion item begins expanding. This can be used to prepare content or stop the action.</td>
    </tr>
</table>
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
        <td>Controls how long the expand and collapse animations run, in <code>milliseconds</code>. Higher values produce slower transitions.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.SfAccordion.html#Syncfusion_Maui_Accordion_SfAccordion_AnimationEasing" aria-label="View AnimationEasing property in API reference">AnimationEasing</a></td>
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Expander.ExpanderAnimationEasing.html" aria-label="View ExpanderAnimationEasing type in API reference">ExpanderAnimationEasing</a></td>
        <td>Controls the acceleration and deceleration of the expand and collapse animations using <code>Linear</code>, <code>None</code>, <code>SinIn</code>, <code>SinOut</code>, or <code>SinInOut</code> easing.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.SfAccordion.html#Syncfusion_Maui_Accordion_SfAccordion_EnableLiquidGlassEffect" aria-label="View EnableLiquidGlassEffect property in API reference">EnableLiquidGlassEffect</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
        <td>Applies the <code>Liquid Glass</code> effect to all accordion items when the Accordion is placed inside an <code>SfGlassEffectView</code>. Supported on <code>iOS 13.0+</code> or later and <code>macOS 10.15+</code> or later with <code>.NET 8</code> or later.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.SfAccordion.html#Syncfusion_Maui_Accordion_SfAccordion_AutoScrollPosition" aria-label="View AutoScrollPosition property in API reference">AutoScrollPosition</a></td>
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.AccordionAutoScrollPosition.html" aria-label="View AccordionAutoScrollPosition type in API reference">AccordionAutoScrollPosition</a></td>
        <td>Controls how an item is scrolled after it expands: <code>Top</code> aligns it with the top of the view, <code>MakeVisible</code> scrolls only when it is not fully visible, and <code>None</code> leaves the scroll position unchanged.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.SfAccordion.html#Syncfusion_Maui_Accordion_SfAccordion_ExpandMode" aria-label="View ExpandMode property in API reference">ExpandMode</a></td>
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.AccordionExpandMode.html" aria-label="View AccordionExpandMode type in API reference">AccordionExpandMode</a></td>
        <td>Controls how many accordion items can remain expanded. <code>Single</code> and <code>Multiple</code> require at least one expanded item, while <code>SingleOrNone</code> and <code>MultipleOrNone</code> allow all items to be collapsed.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.SfAccordion.html#Syncfusion_Maui_Accordion_SfAccordion_HeaderIconPosition" aria-label="View HeaderIconPosition property in API reference">HeaderIconPosition</a></td>
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Expander.ExpanderIconPosition.html" aria-label="View ExpanderIconPosition type in API reference">ExpanderIconPosition</a></td>
        <td>Places the expand and collapse icon at the <code>start</code> or <code>end</code> of each accordion item header.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.SfAccordion.html#Syncfusion_Maui_Accordion_SfAccordion_ItemSpacing" aria-label="View ItemSpacing property in API reference">ItemSpacing</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
        <td>Controls the vertical spacing between <code>adjacent accordion items</code>.</td>
    </tr>
   <tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.SfAccordion.html#Syncfusion_Maui_Accordion_SfAccordion_Items" aria-label="View Items property in API reference">Items</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.collections.objectmodel.observablecollection-1" aria-label="View ObservableCollection type in API reference">ObservableCollection&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.AccordionItem.html" aria-label="View AccordionItem type in API reference">AccordionItem&gt;</a></a></td>
    <td>Defines the <code>vertically arranged items</code> displayed in the Accordion. Adding, removing, or replacing items in the collection updates the displayed content.</td>
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
        <td>Brings the specified <code>accordion item</code> into the <code>visible area</code> without changing its expanded state. If the item is already visible, the scroll position remains unchanged.</td>
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
        <td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.ExpandedAndCollapsedEventArgs.html" aria-label="View ExpandedAndCollapsedEventArgs type in API reference">ExpandedAndCollapsedEventArgs&gt;</a></a></td>
        <td>Triggered after an accordion item finishes collapsing, providing the <code>index</code> of the collapsed item.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.SfAccordion.html#Syncfusion_Maui_Accordion_SfAccordion_Collapsing" aria-label="View Collapsing event in API reference">Collapsing</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.ExpandingAndCollapsingEventArgs.html" aria-label="View ExpandingAndCollapsingEventArgs type in API reference">ExpandingAndCollapsingEventArgs&gt;</a></a></td>
        <td>Triggered before an accordion item collapses, allowing the <code>collapse action</code> to be canceled.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.SfAccordion.html#Syncfusion_Maui_Accordion_SfAccordion_Expanded" aria-label="View Expanded event in API reference">Expanded</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.ExpandedAndCollapsedEventArgs.html" aria-label="View ExpandedAndCollapsedEventArgs type in API reference">ExpandedAndCollapsedEventArgs&gt;</a></a></td>
        <td>Triggered after an accordion item finishes expanding, providing the <code>index</code> of the expanded item.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.SfAccordion.html#Syncfusion_Maui_Accordion_SfAccordion_Expanding" aria-label="View Expanding event in API reference">Expanding</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.ExpandingAndCollapsingEventArgs.html" aria-label="View ExpandingAndCollapsingEventArgs type in API reference">ExpandingAndCollapsingEventArgs&gt;</a></a></td>
        <td>Triggered before an accordion item expands, allowing the <code>expand action</code> to be canceled.</td>
    </tr>
</table>
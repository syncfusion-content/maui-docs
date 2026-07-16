---
layout: post
title: Migrate from Xamarin to .NET MAUI SfAccordion | Syncfusion® 
description: Learn here all about Migrating from Syncfusion® Xamarin Accordion to Syncfusion® .NET MAUI Accordion control and more.
platform: MAUI
control: SfAccordion
documentation: ug
---

# Migrate from Xamarin.Forms SfAccordion to .NET MAUI SfAccordion

To make migration easier from Xamarin.Forms SfAccordion to .NET MAUI SfAccordion, we kept most of the APIs from Xamarin SfAccordion in MAUI SfAccordion. However, to maintain the consistency of API naming in MAUI SfAccordion, we renamed some of the APIs. This guide applies to migrating from Xamarin SfAccordion v5.0+ to MAUI SfAccordion v1.0+. The APIs that have been changed in MAUI SfAccordion from Xamarin SfAccordion are detailed as follows.

## Namespaces

<table>
<tr>
<th>Xamarin SfAccordion </th>
<th>.NET MAUI SfAccordion</th></tr>
<tr>
<td>Syncfusion.XForms.Accordion</td>
<td>Syncfusion.Maui.Accordion</td></tr>
</table>

## Properties

N> `DynamicSizeMode` property from the Xamarin SfAccordion is not moved to the MAUI SfAccordion.

The following code samples show how to migrate property usage from Xamarin to MAUI:

**Xamarin SfAccordion:**
```xml
<syncfusion:SfAccordion>
    <syncfusion:AccordionItem HeaderBackgroundColor="Blue" IconColor="White" />
</syncfusion:SfAccordion>
```

**MAUI SfAccordion:**
```xml
<syncfusion:SfAccordion>
    <syncfusion:AccordionItem HeaderBackground="Blue" HeaderIconColor="White" />
</syncfusion:SfAccordion>
```

<table> 
<tr>
<th>Xamarin SfAccordion</th>
<th>.NET MAUI SfAccordion</th>
<th>Description</th>
</tr>

<tr>
<td>[HeaderBackgroundColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Accordion.AccordionItem.html#Syncfusion_XForms_Accordion_AccordionItem_HeaderBackgroundColor)</td>
<td>[HeaderBackground](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.AccordionItem.html#Syncfusion_Maui_Accordion_AccordionItem_HeaderBackground)</td>
<td>Gets or sets the background color of the header in the Accordion control.</td>
</tr>

<tr>
<td>[IconColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Accordion.AccordionItem.html#Syncfusion_XForms_Accordion_AccordionItem_IconColor)</td>
<td>[HeaderIconColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.AccordionItem.html#Syncfusion_Maui_Accordion_AccordionItem_HeaderIconColor)</td>
<td>Gets or sets the color of the header icon in the Accordion control.</td>
</tr>
</table>

## Enums

The following code samples show how to migrate enum usage from Xamarin to MAUI:

**Xamarin SfAccordion:**
```csharp
accordion.AutoScrollPosition = AutoScrollPosition.Start;
accordion.ExpandMode = ExpandMode.Single;
```

**MAUI SfAccordion:**
```csharp
accordion.AutoScrollPosition = AccordionAutoScrollPosition.Start;
accordion.ExpandMode = AccordionExpandMode.Single;
```

<table>
<tr>
<th>Xamarin SfAccordion</th>
<th>.NET MAUI SfAccordion</th>
<th>Description</th>
</tr>

<tr>
<td>[AutoScrollPosition](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Accordion.AutoScrollPosition.html)</td>
<td>[AccordionAutoScrollPosition](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.AccordionAutoScrollPosition.html)</td>
<td>Specifies the auto-scroll positions for the Accordion control.</td>
</tr>

<tr>
<td>[ExpandMode](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Accordion.ExpandMode.html)</td>
<td>[AccordionExpandMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.AccordionExpandMode.html)</td>
<td>Specifies the expand mode for the items in the Accordion control.</td>
</tr>
</table>
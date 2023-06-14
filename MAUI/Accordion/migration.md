---
layout: post
title: Migrate from Xamarin  to .NET MAUI SfAccordion | Syncfusion 
description: Learn here all about Migrating from Syncfusion Xamarin Accordion to Syncfusion .NET MAUI Accordion control and more.
platform: MAUI
control: SfAccordion
documentation: ug
---

# Migrate from Xamarin.Forms SfAccordion to .NET MAUI SfAccordion

To migrate easier from Xamarin.Forms SfAccordion to .NET MAUI SfAccordion, we kept most of the APIs from Xamarin SfAccordion in MAUI SfAccordion. However, to maintain the consistency of API naming in MAUI SfAccordion, we renamed some of the APIs. The APIs that have been changed in MAUI SfAccordion from Xamarin SfAccordion are detailed as follows.

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

<table> 
<tr>
<th>Xamarin SfAccordion</th>
<th>.NET MAUI SfAccordion</th>
<th>Description</th></tr>
<tr>
<td>HeaderBackgroundColor</td>
<td>HeaderBackground</td>
<td>Gets or sets the background color of the header in the Accordion control.</td></tr>
<tr>
<td>IconColor</td>
<td>HeaderIconColor</td>
<td>Gets or sets the color of the header icon in the Accordion control.</td></tr>
</table>

## Enums

<table>
<tr>
<th>Xamarin SfAccordion</th>
<th>.NET MAUI SfAccordion</th>
<th>Description</th></tr>
<tr>
<td>AutoScrollPosition</td>
<td>AccordionAutoScrollPosition</td>
<td>Specifies the auto-scroll positions for the Accordion control.</td></tr>
<tr>
<td>ExpandMode</td>
<td>AccordionExpandMode</td>
<td>Specifies the expand mode for the items in the Accordion control.</td></tr>
</table>
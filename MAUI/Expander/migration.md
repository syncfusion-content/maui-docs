---
layout: post
title: Migrate from Xamarin SfExpander to .NET MAUI SfExpander | Syncfusion 
description: Learn here all about Migrating from Syncfusion Xamarin Expander to Syncfusion .NET MAUI Expander control and more.
platform: MAUI
control: SfExpander
documentation: ug
---

# Migrate from Xamarin.Forms SfExpander to .NET MAUI SfExpander

To migrate easier from Xamarin.Forms SfExpander to .NET MAUI SfExpander, we kept most of the APIs from Xamarin SfExpander in MAUI SfExpander. However, to maintain the consistency of API naming in MAUI SfExpander, we renamed some of the APIs. The APIs that have been changed in MAUI SfExpander from Xamarin SfExpander are detailed as follows.

## Namespaces

<table>
<tr>
<th>Xamarin SfExpander </th>
<th>.NET MAUI SfExpander</th></tr>
<tr>
<td>Syncfusion.XForms.Expander</td>
<td>Syncfusion.Maui.Expander</td></tr>
</table>

## Properties

N> `DynamicSizeMode` property from the Xamarin SfExpander is not moved to the MAUI SfExpander.

<table> 
<tr>
<th>Xamarin SfExpander</th>
<th>.NET MAUI SfExpander</th>
<th>Description</th></tr>
<tr>
<td>HeaderBackgroundColor</td>
<td>HeaderBackground</td>
<td>Gets or sets the background color of the header area in the Expander control.</td></tr>
<tr>
<td>IconColor</td>
<td>HeaderIconColor</td>
<td>Gets or sets the color of the header icon in the Expander control.</td></tr>
</table>

## Enums

<table>
<tr>
<th>Xamarin SfExpander</th>
<th>.NET MAUI SfExpander</th>
<th>Description</th></tr>
<tr>
<td>IconPosition</td>
<td>ExpanderIconPosition</td>
<td>Specifies the position of the expander icon within an Expander control.</td></tr>
<tr>
<td>AnimationEasing</td>
<td>ExpanderAnimationEasing</td>
<td>Specifies the easing function for the animation of Expander control.</td></tr>
</table>
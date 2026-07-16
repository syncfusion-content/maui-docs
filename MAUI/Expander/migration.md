---
layout: post
title: Migrate from Xamarin SfExpander to .NET MAUI SfExpander | Syncfusion®
description: Learn about migrating from the Syncfusion® Xamarin.Forms SfExpander control to the Syncfusion® .NET MAUI SfExpander control.
platform: MAUI
control: SfExpander
documentation: ug
---

# Migrate from Xamarin.Forms SfExpander to .NET MAUI SfExpander

Migrating from Xamarin.Forms SfExpander to .NET MAUI SfExpander is straightforward because many APIs remain familiar. However, to align with .NET MAUI naming conventions and API consistency, some namespaces, properties, and enums have been renamed.

This topic documents the API changes currently identified for SfExpander migration. If an API is not listed here, it is either unchanged or not currently documented as changed.

## Namespaces

<table>
<tr>
<th>Xamarin.Forms SfExpander</th>
<th>.NET MAUI SfExpander</th>
</tr>
<tr>
<td>Syncfusion.XForms.Expander</td>
<td>Syncfusion.Maui.Expander</td>
</tr>
</table>

## Properties

> **Note:** The `DynamicSizeMode` property available in Xamarin.Forms SfExpander is not supported in .NET MAUI SfExpander. Use the default layout and sizing behavior provided by the MAUI control.

> **Important:** Before migrating your code, ensure that the Syncfusion .NET MAUI Expander package is installed and that your application targets a supported .NET MAUI version.

<table>
<tr>
<th>Xamarin.Forms SfExpander</th>
<th>.NET MAUI SfExpander</th>
<th>Description</th>
</tr>

<tr>
<td>{{'[HeaderBackgroundColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Expander.SfExpander.html#Syncfusion_XForms_Expander_SfExpander_HeaderBackgroundColor)'| markdownify }}</td>
<td>{{'[HeaderBackground](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Expander.SfExpander.html#Syncfusion_Maui_Expander_SfExpander_HeaderBackground)'| markdownify }}</td>
<td>Gets or sets the background appearance of the expander header.</td>
</tr>

<tr>
<td>{{'[IconColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Expander.SfExpander.html#Syncfusion_XForms_Expander_SfExpander_IconColor)'| markdownify }}</td>
<td>{{'[HeaderIconColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Expander.SfExpander.html#Syncfusion_Maui_Expander_SfExpander_HeaderIconColor)'| markdownify }}</td>
<td>Gets or sets the color of the expander header icon.</td>
</tr>

</table>

## Enums

<table>
<tr>
<th>Xamarin.Forms SfExpander</th>
<th>.NET MAUI SfExpander</th>
<th>Description</th>
</tr>

<tr>
<td>{{'[IconPosition](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Expander.IconPosition.html)'| markdownify }}</td>
<td>{{'[ExpanderIconPosition](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Expander.ExpanderIconPosition.html)'| markdownify }}</td>
<td>Specifies the position of the expander icon within an SfExpander control.</td>
</tr>

<tr>
<td>{{'[AnimationEasing](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Expander.AnimationEasing.html)'| markdownify }}</td>
<td>{{'[ExpanderAnimationEasing](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Expander.ExpanderAnimationEasing.html)'| markdownify }}</td>
<td>Specifies the easing function used for expander animations.</td>
</tr>

</table>

> **Migration Note:** The enum types have been renamed in .NET MAUI. When migrating, verify the enum member names used in your application and update them if required. Refer to the API reference documentation for the complete list of available enum members.

## Events and methods

At the time of writing, no additional events or methods renames are documented for SfExpander migration. If your application uses events, commands, behaviors, or custom styling, verify those APIs against the corresponding .NET MAUI documentation during migration.

## Example: property and enum renaming

### Xamarin.Forms

```xml
<sfexpander:SfExpander
    HeaderBackgroundColor="Red"
    IconColor="White"
    IconPosition="Left" />
```

### .NET MAUI

```xml
<sfexpander:SfExpander
    HeaderBackground="Red"
    HeaderIconColor="White"
    HeaderIconPosition="Start" />
```

## Summary

The primary migration changes for SfExpander involve:

- Namespace change from `Syncfusion.XForms.Expander` to `Syncfusion.Maui.Expander`.
- Property rename:
  - `HeaderBackgroundColor` → `HeaderBackground`
  - `IconColor` → `HeaderIconColor`
- Enum rename:
  - `IconPosition` → `ExpanderIconPosition`
  - `AnimationEasing` → `ExpanderAnimationEasing`
- Removal of the `DynamicSizeMode` property.

Review and update these APIs during migration to ensure a smooth transition to .NET MAUI SfExpander.
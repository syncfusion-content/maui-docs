---
layout: post
title: Migrating from Xamarin to .NET MAUI SfNavigationDrawer | Syncfusion® 
description: Learn all about migrating from Syncfusion® Xamarin NavigationDrawer to Syncfusion® .NET MAUI NavigationDrawer control and more.
platform: MAUI
control: SfNavigationDrawer
documentation: UG
---  

# Migrate from Xamarin NavigationDrawer to .NET MAUI NavigationDrawer 

To simplify the migration process from Xamarin SfNavigationDrawer to .NET MAUI SfNavigationDrawer, most of the APIs from Xamarin SfNavigationDrawer have been retained in MAUI SfNavigationDrawer. However, some APIs have been renamed to ensure consistency in API naming within MAUI SfNavigationDrawer. The changes to APIs between Xamarin SfNavigationDrawer and .NET MAUI SfNavigationDrawer are as follows:

## Namespaces 

<table>
<tr>
<th>Xamarin SfNavigationDrawer</th>
<th>.NET MAUI SfNavigationDrawer</th></tr>
<tr>
<td>Syncfusion.SfNavigationDrawer.XForms</td>
<td>Syncfusion.Maui.NavigationDrawer</td></tr>
</table>

## Properties

<table> 
<tr>
<th>Xamarin SfNavigationDrawer</th>
<th>.NET MAUI SfNavigationDrawer</th>
<th>Description</th></tr>
<tr>
<td>{{'[DefaultDrawerSettings](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfNavigationDrawer.XForms.SfNavigationDrawer.html#Syncfusion_SfNavigationDrawer_XForms_SfNavigationDrawer_DefaultDrawerSettings)'| markdownify }}</td>
<td>{{'[DrawerSettings](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.SfNavigationDrawer.html#Syncfusion_Maui_NavigationDrawer_SfNavigationDrawer_DrawerSettings)'| markdownify}}</td>
<td>Gets or sets the DrawerSettings, which is a container for various customization options, allowing the appearance of the navigation drawer to be customized.</td></tr>
</table>

N> In Xamarin Forms SfNavigationDrawer, the obsolete properties have been removed in .NET MAUI, and can be exclusively set using the [DrawerSettings](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.SfNavigationDrawer.html#Syncfusion_Maui_NavigationDrawer_SfNavigationDrawer_DrawerSettings) properties.

## Events

<table>
<tr>
<th>Xamarin SfNavigationDrawer</th>
<th>.NET MAUI SfNavigationDrawer</th>
<th>Description</th>
</tr>
<tr>
<td>{{'[Closed](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfNavigationDrawer.XForms.SfNavigationDrawer.html#Syncfusion_SfNavigationDrawer_XForms_SfNavigationDrawer_Closed)'| markdownify }}</td>
<td>{{'[DrawerClosed](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.SfNavigationDrawer.html#Syncfusion_Maui_NavigationDrawer_SfNavigationDrawer_DrawerClosed)'| markdownify }}</td>
<td>Occurs whenever the drawer is closed.</td>
</tr>
<tr>
<td>{{'[Closing](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfNavigationDrawer.XForms.SfNavigationDrawer.html#Syncfusion_SfNavigationDrawer_XForms_SfNavigationDrawer_Closing)'| markdownify }}</td>
<td>{{'[DrawerClosing](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.SfNavigationDrawer.html#Syncfusion_Maui_NavigationDrawer_SfNavigationDrawer_DrawerClosing)'| markdownify }}</td>
<td>Occurs before whenever the drawer is closing.</td>
</tr>
<tr>
<td>{{'[Opening](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfNavigationDrawer.XForms.SfNavigationDrawer.html#Syncfusion_SfNavigationDrawer_XForms_SfNavigationDrawer_Opening)'| markdownify }}</td>
<td>{{'[DrawerOpening](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.SfNavigationDrawer.html#Syncfusion_Maui_NavigationDrawer_SfNavigationDrawer_DrawerOpening)'| markdownify }}</td>
<td>Occurs before whenever the drawer is opening.</td>
</tr>
<tr>
<td>{{'[Toggled](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfNavigationDrawer.XForms.SfNavigationDrawer.html#Syncfusion_SfNavigationDrawer_XForms_SfNavigationDrawer_Toggled)'| markdownify }}</td>
<td>{{'[DrawerToggled](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.SfNavigationDrawer.html#Syncfusion_Maui_NavigationDrawer_SfNavigationDrawer_DrawerToggled)'| markdownify }}</td>
<td>Occurs whenever the drawer is opened or closed.</td>
</tr>
</table>
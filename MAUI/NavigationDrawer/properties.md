---
layout: post
title: Properties of .NET MAUI Navigation Drawer control | Syncfusion®
description: This section explains the properties, events, and methods with Syncfusion® MAUI Navigation Drawer (SfNavigationDrawer) control.
platform: MAUI
control: SfNavigationDrawer
documentation: ug
---

# .NET MAUI Navigation Drawer API Reference

## Properties

<table>
    <tr>
        <th>Name</th>
        <th>Type</th>
        <th>Description</th>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.SfNavigationDrawer.html#Syncfusion_Maui_NavigationDrawer_SfNavigationDrawer_ContentView">ContentView</a></td>
        <td>View</td>
        <td>Defines the main content view displayed when the drawer is closed or collapsed.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.SfNavigationDrawer.html#Syncfusion_Maui_NavigationDrawer_SfNavigationDrawer_DrawerSettings">DrawerSettings</a></td>
        <td>DrawerSettings</td>
        <td>Defines the settings used to configure the primary navigation drawer.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.SfNavigationDrawer.html#Syncfusion_Maui_NavigationDrawer_SfNavigationDrawer_EnableLiquidGlassEffect">EnableLiquidGlassEffect</a></td>
        <td>bool</td>
        <td>Defines whether the liquid glass visual effect is enabled for the drawer.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.SfNavigationDrawer.html#Syncfusion_Maui_NavigationDrawer_SfNavigationDrawer_FlowDirection">FlowDirection</a></td>
        <td>FlowDirection</td>
        <td>Defines the reading and layout direction used by the drawer content.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.SfNavigationDrawer.html#Syncfusion_Maui_NavigationDrawer_SfNavigationDrawer_SecondaryDrawerSettings">SecondaryDrawerSettings</a></td>
        <td>DrawerSettings</td>
        <td>Defines the settings used to configure the secondary drawer.</td>
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
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.SfNavigationDrawer.html#Syncfusion_Maui_NavigationDrawer_SfNavigationDrawer_ToggleDrawer">ToggleDrawer()</a></td>
        <td>void</td>
        <td>Opens or closes the primary drawer based on its current state.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.SfNavigationDrawer.html#Syncfusion_Maui_NavigationDrawer_SfNavigationDrawer_ToggleSecondaryDrawer">ToggleSecondaryDrawer()</a></td>
        <td>void</td>
        <td>Opens or closes the secondary drawer based on its current state.</td>
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
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.SfNavigationDrawer.html#Syncfusion_Maui_NavigationDrawer_SfNavigationDrawer_DrawerClosed">DrawerClosed</a></td>
        <td>EventHandler&lt;DrawerEventArgs&gt;</td>
        <td>Raised after the drawer has fully closed.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.SfNavigationDrawer.html#Syncfusion_Maui_NavigationDrawer_SfNavigationDrawer_DrawerClosing">DrawerClosing</a></td>
        <td>EventHandler&lt;DrawerCancelEventArgs&gt;</td>
        <td>Raised before the drawer starts closing and can be canceled.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.SfNavigationDrawer.html#Syncfusion_Maui_NavigationDrawer_SfNavigationDrawer_DrawerOpened">DrawerOpened</a></td>
        <td>EventHandler&lt;DrawerEventArgs&gt;</td>
        <td>Raised after the drawer has fully opened.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.SfNavigationDrawer.html#Syncfusion_Maui_NavigationDrawer_SfNavigationDrawer_DrawerOpening">DrawerOpening</a></td>
        <td>EventHandler&lt;DrawerCancelEventArgs&gt;</td>
        <td>Raised before the drawer starts opening and can be canceled.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.SfNavigationDrawer.html#Syncfusion_Maui_NavigationDrawer_SfNavigationDrawer_DrawerToggled">DrawerToggled</a></td>
        <td>EventHandler&lt;ToggledEventArgs&gt;</td>
        <td>Raised when the drawer open or close state changes.</td>
    </tr>
</table>


## DrawerSettings Properties

<table>
    <tr>
        <th>Name</th>
        <th>Type</th>
        <th>Description</th>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.DrawerSettings.html#Syncfusion_Maui_NavigationDrawer_DrawerSettings_AnimationEasing">AnimationEasing</a></td>
        <td>Easing</td>
        <td>Defines the easing function applied to drawer open and close animations.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.DrawerSettings.html#Syncfusion_Maui_NavigationDrawer_DrawerSettings_ContentBackground">ContentBackground</a></td>
        <td>Color</td>
        <td>Defines the background color of the drawer content area.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.DrawerSettings.html#Syncfusion_Maui_NavigationDrawer_DrawerSettings_DrawerContentView">DrawerContentView</a></td>
        <td>View</td>
        <td>Defines the view displayed inside the drawer body.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.DrawerSettings.html#Syncfusion_Maui_NavigationDrawer_DrawerSettings_DrawerFooterHeight">DrawerFooterHeight</a></td>
        <td>double</td>
        <td>Defines the height of the drawer footer area.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.DrawerSettings.html#Syncfusion_Maui_NavigationDrawer_DrawerSettings_DrawerFooterView">DrawerFooterView</a></td>
        <td>View</td>
        <td>Defines the view displayed in the drawer footer section.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.DrawerSettings.html#Syncfusion_Maui_NavigationDrawer_DrawerSettings_DrawerHeaderHeight">DrawerHeaderHeight</a></td>
        <td>double</td>
        <td>Defines the height of the drawer header area.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.DrawerSettings.html#Syncfusion_Maui_NavigationDrawer_DrawerSettings_DrawerHeaderView">DrawerHeaderView</a></td>
        <td>View</td>
        <td>Defines the view displayed in the drawer header section.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.DrawerSettings.html#Syncfusion_Maui_NavigationDrawer_DrawerSettings_DrawerHeight">DrawerHeight</a></td>
        <td>double</td>
        <td>Defines the total height of the drawer.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.DrawerSettings.html#Syncfusion_Maui_NavigationDrawer_DrawerSettings_DrawerWidth">DrawerWidth</a></td>
        <td>double</td>
        <td>Defines the width of the drawer panel.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.DrawerSettings.html#Syncfusion_Maui_NavigationDrawer_DrawerSettings_Duration">Duration</a></td>
        <td>double</td>
        <td>Defines the duration of the drawer animation.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.DrawerSettings.html#Syncfusion_Maui_NavigationDrawer_DrawerSettings_EnableSwipeGesture">EnableSwipeGesture</a></td>
        <td>bool</td>
        <td>Defines whether swipe gestures can be used to open or close the drawer.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.DrawerSettings.html#Syncfusion_Maui_NavigationDrawer_DrawerSettings_IsOpen">IsOpen</a></td>
        <td>bool</td>
        <td>Defines whether the drawer is currently open.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.DrawerSettings.html#Syncfusion_Maui_NavigationDrawer_DrawerSettings_Position">Position</a></td>
        <td>Position</td>
        <td>Defines the position of the drawer relative to the content area.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.DrawerSettings.html#Syncfusion_Maui_NavigationDrawer_DrawerSettings_TouchThreshold">TouchThreshold</a></td>
        <td>double</td>
        <td>Defines the touch threshold required to trigger drawer interaction.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.DrawerSettings.html#Syncfusion_Maui_NavigationDrawer_DrawerSettings_Transition">Transition</a></td>
        <td>Transition</td>
        <td>Defines the transition effect applied when the drawer opens or closes.</td>
    </tr>
</table>
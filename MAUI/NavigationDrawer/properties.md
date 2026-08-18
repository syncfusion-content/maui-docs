---
layout: post
title: Properties of .NET MAUI Navigation Drawer control | Syncfusion®
description: This section explains the properties, events, and methods with Syncfusion® MAUI Navigation Drawer (SfNavigationDrawer) control.
platform: MAUI
control: SfNavigationDrawer
documentation: ug
---

# API Reference for .NET MAUI Navigation Drawer

## Properties

<table>
    <tr>
        <th>Name</th>
        <th>Type</th>
        <th>Description</th>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.SfNavigationDrawer.html#Syncfusion_Maui_NavigationDrawer_SfNavigationDrawer_ContentView" aria-label="View ContentView property in API reference">ContentView</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.view" aria-label="View View type in API reference">View</a></td>
        <td>Defines the main <code>View</code> shown when the drawer is closed or collapsed.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.SfNavigationDrawer.html#Syncfusion_Maui_NavigationDrawer_SfNavigationDrawer_DrawerSettings" aria-label="View DrawerSettings property in API reference">DrawerSettings</a></td>
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.DrawerSettings.html" aria-label="View DrawerSettings type in API reference">DrawerSettings</a></td>
        <td>Defines the <code>DrawerSettings</code> used to configure the primary navigation drawer.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.SfNavigationDrawer.html#Syncfusion_Maui_NavigationDrawer_SfNavigationDrawer_EnableLiquidGlassEffect" aria-label="View EnableLiquidGlassEffect property in API reference">EnableLiquidGlassEffect</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
        <td>Determines whether the <code>liquid glass</code> visual effect is applied to the drawer.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.SfNavigationDrawer.html#Syncfusion_Maui_NavigationDrawer_SfNavigationDrawer_FlowDirection" aria-label="View FlowDirection property in API reference">FlowDirection</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.flowdirection" aria-label="View FlowDirection enum in API reference">FlowDirection</a></td>
        <td>Defines the reading flow using <code>LeftToRight</code> or <code>RightToLeft</code>.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.SfNavigationDrawer.html#Syncfusion_Maui_NavigationDrawer_SfNavigationDrawer_SecondaryDrawerSettings" aria-label="View SecondaryDrawerSettings property in API reference">SecondaryDrawerSettings</a></td>
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.DrawerSettings.html" aria-label="View DrawerSettings type in API reference">DrawerSettings</a></td>
        <td>Defines the <code>DrawerSettings</code> used to configure the secondary drawer.</td>
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
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.SfNavigationDrawer.html#Syncfusion_Maui_NavigationDrawer_SfNavigationDrawer_DrawerClosed" aria-label="View DrawerClosed event in API reference">DrawerClosed</a></td>
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.DrawerEventArgs.html" aria-label="View DrawerEventArgs type in API reference">DrawerEventArgs</a></td>
        <td>Raised after the drawer has fully closed, providing state details through <code>DrawerEventArgs</code>.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.SfNavigationDrawer.html#Syncfusion_Maui_NavigationDrawer_SfNavigationDrawer_DrawerClosing" aria-label="View DrawerClosing event in API reference">DrawerClosing</a></td>
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.DrawerCancelEventArgs.html" aria-label="View DrawerCancelEventArgs type in API reference">DrawerCancelEventArgs</a></td>
        <td>Raised before closing starts and can be canceled using <code>DrawerCancelEventArgs</code>.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.SfNavigationDrawer.html#Syncfusion_Maui_NavigationDrawer_SfNavigationDrawer_DrawerOpened" aria-label="View DrawerOpened event in API reference">DrawerOpened</a></td>
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.DrawerEventArgs.html" aria-label="View DrawerEventArgs type in API reference">DrawerEventArgs</a></td>
        <td>Raised after the drawer has fully opened, exposing state through <code>DrawerEventArgs</code>.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.SfNavigationDrawer.html#Syncfusion_Maui_NavigationDrawer_SfNavigationDrawer_DrawerOpening" aria-label="View DrawerOpening event in API reference">DrawerOpening</a></td>
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.DrawerCancelEventArgs.html" aria-label="View DrawerCancelEventArgs type in API reference">DrawerCancelEventArgs</a></td>
        <td>Raised before opening starts and can be canceled through <code>DrawerCancelEventArgs</code>.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.SfNavigationDrawer.html#Syncfusion_Maui_NavigationDrawer_SfNavigationDrawer_DrawerToggled" aria-label="View DrawerToggled event in API reference">DrawerToggled</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.toggledeventargs" aria-label="View ToggledEventArgs type in API reference">ToggledEventArgs</a></td>
        <td>Raised when the drawer state changes between <code>opened</code> and <code>closed</code>.</td>
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
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.SfNavigationDrawer.html#Syncfusion_Maui_NavigationDrawer_SfNavigationDrawer_ToggleDrawer" aria-label="View ToggleDrawer method in API reference">ToggleDrawer()</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.void" aria-label="View Void type in API reference">void</a></td>
        <td>Opens or closes the primary drawer based on its current state.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.SfNavigationDrawer.html#Syncfusion_Maui_NavigationDrawer_SfNavigationDrawer_ToggleSecondaryDrawer" aria-label="View ToggleSecondaryDrawer method in API reference">ToggleSecondaryDrawer()</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.void" aria-label="View Void type in API reference">void</a></td>
        <td>Opens or closes the secondary drawer based on its current state.</td>
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
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.DrawerSettings.html#Syncfusion_Maui_NavigationDrawer_DrawerSettings_AnimationEasing" aria-label="View AnimationEasing property in API reference">AnimationEasing</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.easing" aria-label="View Easing type in API reference">Easing</a></td>
        <td>Easing curve applied to drawer animations such as <code>Linear</code>, <code>EaseIn</code>, <code>EaseOut</code>, and <code>EaseInOut</code>.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.DrawerSettings.html#Syncfusion_Maui_NavigationDrawer_DrawerSettings_ContentBackground" aria-label="View ContentBackground property in API reference">ContentBackground</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.graphics.color" aria-label="View Color type in API reference">Color</a></td>
        <td>Defines the background <code>Color</code> applied to the drawer content area.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.DrawerSettings.html#Syncfusion_Maui_NavigationDrawer_DrawerSettings_DrawerContentView" aria-label="View DrawerContentView property in API reference">DrawerContentView</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.view" aria-label="View View type in API reference">View</a></td>
        <td>Defines the <code>View</code> displayed inside the drawer body.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.DrawerSettings.html#Syncfusion_Maui_NavigationDrawer_DrawerSettings_DrawerFooterHeight" aria-label="View DrawerFooterHeight property in API reference">DrawerFooterHeight</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
        <td>Height of the footer section in the drawer, typically smaller than <code>DrawerHeight</code>.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.DrawerSettings.html#Syncfusion_Maui_NavigationDrawer_DrawerSettings_DrawerFooterView" aria-label="View DrawerFooterView property in API reference">DrawerFooterView</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.view" aria-label="View View type in API reference">View</a></td>
        <td><code>View</code> displayed in the drawer footer, placed at the bottom of the panel.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.DrawerSettings.html#Syncfusion_Maui_NavigationDrawer_DrawerSettings_DrawerHeaderHeight" aria-label="View DrawerHeaderHeight property in API reference">DrawerHeaderHeight</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
        <td>Height of the header section in the drawer, controlling its vertical allocation.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.DrawerSettings.html#Syncfusion_Maui_NavigationDrawer_DrawerSettings_DrawerHeaderView" aria-label="View DrawerHeaderView property in API reference">DrawerHeaderView</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.view" aria-label="View View type in API reference">View</a></td>
        <td><code>View</code> displayed in the drawer header, placed at the top of the panel.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.DrawerSettings.html#Syncfusion_Maui_NavigationDrawer_DrawerSettings_DrawerHeight" aria-label="View DrawerHeight property in API reference">DrawerHeight</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
        <td>Defines the total vertical <code>double</code> size of the drawer panel.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.DrawerSettings.html#Syncfusion_Maui_NavigationDrawer_DrawerSettings_DrawerWidth" aria-label="View DrawerWidth property in API reference">DrawerWidth</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
        <td>Defines the horizontal <code>double</code> width of the drawer panel.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.DrawerSettings.html#Syncfusion_Maui_NavigationDrawer_DrawerSettings_Duration" aria-label="View Duration property in API reference">Duration</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
        <td>Time in milliseconds used by the drawer animation; larger values create slower motion.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.DrawerSettings.html#Syncfusion_Maui_NavigationDrawer_DrawerSettings_EnableSwipeGesture" aria-label="View EnableSwipeGesture property in API reference">EnableSwipeGesture</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
        <td>Determines whether swipe gestures trigger drawer open and close interactions.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.DrawerSettings.html#Syncfusion_Maui_NavigationDrawer_DrawerSettings_IsOpen" aria-label="View IsOpen property in API reference">IsOpen</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
        <td>Indicates whether the drawer is currently <code>open</code> or <code>closed</code>.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.DrawerSettings.html#Syncfusion_Maui_NavigationDrawer_DrawerSettings_Position" aria-label="View Position property in API reference">Position</a></td>
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.DrawerPosition.html" aria-label="View DrawerPosition enum in API reference">DrawerPosition</a></td>
        <td>Defines the drawer placement using <code>Left</code>, <code>Right</code>, <code>Top</code>, or <code>Bottom</code>.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.DrawerSettings.html#Syncfusion_Maui_NavigationDrawer_DrawerSettings_TouchThreshold" aria-label="View TouchThreshold property in API reference">TouchThreshold</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
        <td>Minimum touch distance in pixels required to start drawer interaction.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.DrawerSettings.html#Syncfusion_Maui_NavigationDrawer_DrawerSettings_Transition" aria-label="View Transition property in API reference">Transition</a></td>
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.Transition.html" aria-label="View Transition enum in API reference">Transition</a></td>
        <td>Defines the animation transition with options such as <code>Slide</code>, <code>Push</code>, or <code>Reveal</code>.</td>
    </tr>
</table>
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
        <td>Provides the main page content displayed behind or beside the drawer. This <code>View</code> must be configured for the <code>Navigation Drawer</code> to display its primary content.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.SfNavigationDrawer.html#Syncfusion_Maui_NavigationDrawer_SfNavigationDrawer_DrawerSettings" aria-label="View DrawerSettings property in API reference">DrawerSettings</a></td>
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.DrawerSettings.html" aria-label="View DrawerSettings type in API reference">DrawerSettings</a></td>
        <td>Configures the primary drawer's <code>content</code>, <code>position</code>, <code>dimensions</code>, <code>animation</code>, <code>swipe interaction</code>, and <code>open state</code>.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.SfNavigationDrawer.html#Syncfusion_Maui_NavigationDrawer_SfNavigationDrawer_EnableLiquidGlassEffect" aria-label="View EnableLiquidGlassEffect property in API reference">EnableLiquidGlassEffect</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
        <td>Applies the <code>Liquid Glass</code> appearance to the <code>Navigation Drawer</code> on <code>iOS</code> and <code>macOS</code>. Exact supported OS and <code>.NET</code> versions are not stated in the current Navigation Drawer API reference and should be verified before documenting version requirements.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.SfNavigationDrawer.html#Syncfusion_Maui_NavigationDrawer_SfNavigationDrawer_FlowDirection" aria-label="View FlowDirection property in API reference">FlowDirection</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.flowdirection" aria-label="View FlowDirection enum in API reference">FlowDirection</a></td>
        <td>Controls whether the <code>Navigation Drawer</code> and its content use <code>LeftToRight</code> or <code>RightToLeft</code> layout.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.SfNavigationDrawer.html#Syncfusion_Maui_NavigationDrawer_SfNavigationDrawer_SecondaryDrawerSettings" aria-label="View SecondaryDrawerSettings property in API reference">SecondaryDrawerSettings</a></td>
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.DrawerSettings.html" aria-label="View DrawerSettings type in API reference">DrawerSettings</a></td>
        <td>Configures an optional secondary drawer using the same <code>content</code>, <code>position</code>, <code>animation</code>, and <code>interaction</code> settings as the primary drawer. Only one drawer can be open at a time.</td>
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
        <td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.DrawerEventArgs.html" aria-label="View DrawerEventArgs type in API reference">DrawerEventArgs&gt;</a></a></td>
        <td>Triggered after the primary or secondary drawer finishes closing and identifies which drawer changed.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.SfNavigationDrawer.html#Syncfusion_Maui_NavigationDrawer_SfNavigationDrawer_DrawerClosing" aria-label="View DrawerClosing event in API reference">DrawerClosing</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.DrawerCancelEventArgs.html" aria-label="View DrawerCancelEventArgs type in API reference">DrawerCancelEventArgs&gt;</a></a></td>
        <td>Triggered before the primary or secondary drawer closes, allowing the close action to be canceled and identifying which drawer initiated it.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.SfNavigationDrawer.html#Syncfusion_Maui_NavigationDrawer_SfNavigationDrawer_DrawerOpened" aria-label="View DrawerOpened event in API reference">DrawerOpened</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.DrawerEventArgs.html" aria-label="View DrawerEventArgs type in API reference">DrawerEventArgs&gt;</a></a></td>
        <td>Triggered after the primary or secondary drawer finishes opening and identifies which drawer changed.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.SfNavigationDrawer.html#Syncfusion_Maui_NavigationDrawer_SfNavigationDrawer_DrawerOpening" aria-label="View DrawerOpening event in API reference">DrawerOpening</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.DrawerCancelEventArgs.html" aria-label="View DrawerCancelEventArgs type in API reference">DrawerCancelEventArgs&gt;</a></a></td>
        <td>Triggered before the primary or secondary drawer opens, allowing the open action to be canceled and identifying which drawer initiated it.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.SfNavigationDrawer.html#Syncfusion_Maui_NavigationDrawer_SfNavigationDrawer_DrawerToggled" aria-label="View DrawerToggled event in API reference">DrawerToggled</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler type in API reference">EventHandler&lt;<a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.toggledeventargs" aria-label="View ToggledEventArgs type in API reference">ToggledEventArgs&gt;</a></a></td>
        <td>Triggered when either drawer's open state changes and reports whether it is now <code>open</code> and whether the change belongs to the <code>primary drawer</code>.</td>
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
        <td>Opens the primary drawer when it is closed and closes it when it is open.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.SfNavigationDrawer.html#Syncfusion_Maui_NavigationDrawer_SfNavigationDrawer_ToggleSecondaryDrawer" aria-label="View ToggleSecondaryDrawer method in API reference">ToggleSecondaryDrawer()</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.void" aria-label="View Void type in API reference">void</a></td>
        <td>Opens the secondary drawer when it is closed and closes it when it is open. A <code>SecondaryDrawerSettings</code> configuration is required.</td>
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
        <td>Controls how the drawer accelerates and decelerates during its opening and closing animations.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.DrawerSettings.html#Syncfusion_Maui_NavigationDrawer_DrawerSettings_ContentBackground" aria-label="View ContentBackground property in API reference">ContentBackground</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.graphics.color" aria-label="View Color type in API reference">Color</a></td>
        <td>Controls the background color of the drawer pane, behind its <code>header</code>, <code>content</code>, and <code>footer</code>.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.DrawerSettings.html#Syncfusion_Maui_NavigationDrawer_DrawerSettings_DrawerContentView" aria-label="View DrawerContentView property in API reference">DrawerContentView</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.view" aria-label="View View type in API reference">View</a></td>
        <td>Provides the main content displayed inside the drawer, between its optional <code>header</code> and <code>footer</code>. A content view is required to allocate the drawer's content area.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.DrawerSettings.html#Syncfusion_Maui_NavigationDrawer_DrawerSettings_DrawerFooterHeight" aria-label="View DrawerFooterHeight property in API reference">DrawerFooterHeight</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
        <td>Controls the vertical height reserved for <code>DrawerFooterView</code>. Set it to <code>0</code> to remove the footer area.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.DrawerSettings.html#Syncfusion_Maui_NavigationDrawer_DrawerSettings_DrawerFooterView" aria-label="View DrawerFooterView property in API reference">DrawerFooterView</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.view" aria-label="View View type in API reference">View</a></td>
        <td>Provides custom content for the bottom section of the drawer. Its visible height is controlled by <code>DrawerFooterHeight</code>.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.DrawerSettings.html#Syncfusion_Maui_NavigationDrawer_DrawerSettings_DrawerHeaderHeight" aria-label="View DrawerHeaderHeight property in API reference">DrawerHeaderHeight</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
        <td>Controls the vertical height reserved for <code>DrawerHeaderView</code>. Set it to <code>0</code> to remove the header area.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.DrawerSettings.html#Syncfusion_Maui_NavigationDrawer_DrawerSettings_DrawerHeaderView" aria-label="View DrawerHeaderView property in API reference">DrawerHeaderView</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.view" aria-label="View View type in API reference">View</a></td>
        <td>Provides custom content for the top section of the drawer. Its visible height is controlled by <code>DrawerHeaderHeight</code>.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.DrawerSettings.html#Syncfusion_Maui_NavigationDrawer_DrawerSettings_DrawerHeight" aria-label="View DrawerHeight property in API reference">DrawerHeight</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
        <td>Controls the drawer's vertical size. This is the primary pane dimension when <code>Position</code> is <code>Top</code> or <code>Bottom</code>.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.DrawerSettings.html#Syncfusion_Maui_NavigationDrawer_DrawerSettings_DrawerWidth" aria-label="View DrawerWidth property in API reference">DrawerWidth</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
        <td>Controls the drawer's horizontal size. This is the primary pane dimension when <code>Position</code> is <code>Left</code> or <code>Right</code>.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.DrawerSettings.html#Syncfusion_Maui_NavigationDrawer_DrawerSettings_Duration" aria-label="View Duration property in API reference">Duration</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
        <td>Controls how long the drawer's opening and closing animations run, in <code>milliseconds</code>. Lower values produce faster transitions.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.DrawerSettings.html#Syncfusion_Maui_NavigationDrawer_DrawerSettings_EnableSwipeGesture" aria-label="View EnableSwipeGesture property in API reference">EnableSwipeGesture</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
        <td>Allows the drawer to be opened and closed with a swipe gesture. Programmatic changes through <code>IsOpen</code> or a toggle method remain available when swipe gestures are disabled.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.DrawerSettings.html#Syncfusion_Maui_NavigationDrawer_DrawerSettings_IsOpen" aria-label="View IsOpen property in API reference">IsOpen</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
        <td>Opens or closes the associated primary or secondary drawer programmatically. Opening one drawer closes or prevents simultaneous display of the other because only one drawer can be open at a time.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.DrawerSettings.html#Syncfusion_Maui_NavigationDrawer_DrawerSettings_Position" aria-label="View Position property in API reference">Position</a></td>
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.DrawerPosition.html" aria-label="View DrawerPosition enum in API reference">DrawerPosition</a></td>
        <td>Places the drawer at the <code>Left</code>, <code>Right</code>, <code>Top</code>, or <code>Bottom</code> edge of the <code>Navigation Drawer</code>.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.DrawerSettings.html#Syncfusion_Maui_NavigationDrawer_DrawerSettings_TouchThreshold" aria-label="View TouchThreshold property in API reference">TouchThreshold</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
        <td>Controls the size of the edge region from which an opening swipe can begin. Higher values allow the gesture to start farther from the drawer's edge.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.DrawerSettings.html#Syncfusion_Maui_NavigationDrawer_DrawerSettings_Transition" aria-label="View Transition property in API reference">Transition</a></td>
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.Transition.html" aria-label="View Transition enum in API reference">Transition</a></td>
        <td>Controls how the drawer interacts with the main content while opening and closing: <code>SlideOnTop</code> moves the drawer over the content, <code>Push</code> moves the content with the drawer, and <code>Reveal</code> moves the content to uncover the drawer beneath it.</td>
    </tr>
</table>

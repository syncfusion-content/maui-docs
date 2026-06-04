---
layout: post
title: Context Menu in .NET MAUI Scheduler | Syncfusion
description: Learn how to use the built-in context menu in the Syncfusion .NET MAUI Scheduler to perform actions on appointments, scheduler cells, and other scheduler elements through an interactive menu.
platform: maui
control: SfScheduler
documentation: ug
keywords : .net maui scheduler, .net maui scheduler context menu, .net maui scheduler right click menu, .net maui scheduler appointment context menu, .net maui scheduler cell context menu, .net maui scheduler menu actions, maui scheduler context menu.
---

# Context Menu in .NET MAUI Scheduler (SfScheduler)

The .NET MAUI Scheduler allows you to display customizable context menus for timeslot cells, month cells, all-day panels, and appointments.. Context menus provide quick access to common actions such as creating, editing, or deleting appointments without navigating away from the scheduler view. Context menus are displayed using the Scheduler's built-in context menu support and can be customized with user-defined or built-in commands.

The Scheduler displays context menus through the following interactions:
 
* **Long press** on touch devices (Android and iOS)
* **Right-click** on desktop platforms (Windows and macOS)
 
When a context menu is configured, the Scheduler automatically displays the menu at the interaction location.

## Built-in Scheduler Commands to use in context menu
 
The Scheduler includes built-in commands that can be used directly in context menus.

* **Add** - Creates a new appointment for the selected cell.
* **Edit** - Opens the selected appointment for editing.
* **Delete** - Deletes the selected appointment.
 
Appointment creation or editing through built-in commands is performed only when AppointmentEditorMode is set to Add or Edit.

## Context Menu for Timeslot Cells

The CellContextMenu property of the Scheduler allows users to define a set of context menu items that appear when the user performs a right tap or long press on a timeslot cell, month cell, or the all-day panel.

{% tabs %}
{% highlight xaml tabtitle="XAML" hl_lines="2 4 5 6 7 8 9 10 11" %}
<schedule:SfScheduler x:Name="scheduler"
                      AppointmentEditorMode="Add,Edit"
                      View="Week">
    <schedule:SfScheduler.CellContextMenu>
        <schedule:MenuItemCollection>
            <schedule:MenuItem Text="Add"
                               Command="{x:Static schedule:SchedulerCommands.Add}"
                               CommandParameter="{Binding}">
            </schedule:MenuItem>
        </schedule:MenuItemCollection>
    </schedule:SfScheduler.CellContextMenu>
</schedule:SfScheduler>
{% endhighlight %}
{% highlight c# tabtitle="C#" hl_lines="3 4 6 8 9 10" %}
SfScheduler scheduler = new SfScheduler();
scheduler.View = SchedulerView.Week;
scheduler.AppointmentEditorMode = AppointmentEditorMode.Add | AppointmentEditorMode.Edit;
scheduler.CellContextMenu = new MenuItemCollection()
{
    new Syncfusion.Maui.Scheduler.MenuItem
    {
        Text = "Add",
        Command = SchedulerCommands.Add,
        CommandParameter = new Binding("."),
    },
};
{% endhighlight %}
{% endtabs %}

## Context Menu for Appointments

The AppointmentContextMenu property of the Scheduler enables users to define a set of context menu items that appear when the user performs a right tap or long press on an appointment.

{% tabs %}
{% highlight xaml tabtitle="XAML" hl_lines="" %}
        <schedule:SfScheduler x:Name="scheduler"
                              AppointmentEditorMode="Edit"
                              View="Week">
            <schedule:SfScheduler.AppointmentContextMenu>
                <schedule:MenuItemCollection>
                    <schedule:MenuItem Text="Edit"
                                       Command="{x:Static schedule:SchedulerCommands.Edit}"
                                       CommandParameter="{Binding}">
                        <schedule:MenuItem.Icon>
                            <FontImageSource Glyph="&#xE710;"
                                             FontFamily="MauiMaterialAssets"
                                             Color="Blue" 
                                             Size="16"/>
                        </schedule:MenuItem.Icon>
                    </schedule:MenuItem>
                    <schedule:MenuItem Text="Delete"
                                       Command="{x:Static schedule:SchedulerCommands.Delete}"
                                       CommandParameter="{Binding}">
                        <schedule:MenuItem.Icon>
                            <FontImageSource Glyph="&#xE70F;"
                                             FontFamily="MauiMaterialAssets"
                                             Color="Blue" 
                                             Size="16"/>
                        </schedule:MenuItem.Icon>
                    </schedule:MenuItem>
                </schedule:MenuItemCollection>
            </schedule:SfScheduler.AppointmentContextMenu>
        </schedule:SfScheduler>
{% endhighlight %}
{% highlight c# tabtitle="C#" hl_lines="6" %}
SfScheduler scheduler = new SfScheduler();
scheduler.View = SchedulerView.Week;
scheduler.AppointmentEditorMode = AppointmentEditorMode.Add | AppointmentEditorMode.Edit;
scheduler.AppointmentContextMenu = new MenuItemCollection()
{
    new Syncfusion.Maui.Scheduler.MenuItem
    {
        Text = "Edit",
        Command = SchedulerCommands.Edit,
        CommandParameter = new Binding("."),
        Icon = new FontImageSource
        {
            FontFamily = "MauiMaterialAssets",
            Glyph = "&#xE710;",
            Color = Colors.Blue,
            Size = 16

        }
    },

    new Syncfusion.Maui.Scheduler.MenuItem
    {
        Text = "Delete",
        Command = SchedulerCommands.Delete,
        CommandParameter = new Binding("."),
        Icon = new FontImageSource
        {
            FontFamily = "MauiMaterialAssets",
            Glyph = "&#xE70F;",
            Color = Colors.Blue,
            Size = 16
            
        }
    },
};
{% endhighlight %}
{% endtabs %}

N> The `SchedulerContextMenuInfo` object is set as the BindingContext for menu items.

## Handle Context Menu Opening

The Scheduler raises the `ContextMenuOpening` event when a context menu is about to be displayed. This event allows you to access the menu information or cancel the menu opening operation.

The `SchedulerContextMenuOpeningEventArgs` class provides information about the context menu being opened.

- **ContextMenu** – Gets the collection of menu items that will be displayed.
- **MenuInfo** – Gets information about the scheduler element that invoked the context menu. Provides the following details - selected appointment, cell date and time, associated resource and scheduler instance.
- **MenuType** – Gets the type of scheduler element (Appointment, SchedulerCell or AllDay) for which the context menu is opened.
- **Cancel** – Specifies whether the context menu opening operation should be canceled. 

{% tabs %}
{% highlight xaml tabtitle="XAML" hl_lines="2 4 5 6 7 8 9 10 11" %}
<schedule:SfScheduler x:Name="scheduler"
                      AppointmentEditorMode="Edit"
                      View="Week"
                      ContextMenuOpening="scheduler_ContextMenuOpening">
    <schedule:SfScheduler.AppointmentContextMenu>
        <schedule:MenuItemCollection>
            <schedule:MenuItem Text="Edit"
                               Command="{x:Static schedule:SchedulerCommands.Edit}"
                               CommandParameter="{Binding}">
                <schedule:MenuItem.Icon>
                    <FontImageSource Glyph="&#xE710;"
                                     FontFamily="MauiMaterialAssets"/>
                </schedule:MenuItem.Icon>
            </schedule:MenuItem>
            <schedule:MenuItem Text="Delete"
                               Command="{x:Static schedule:SchedulerCommands.Delete}"
                               CommandParameter="{Binding}">
                <schedule:MenuItem.Icon>
                    <FontImageSource Glyph="&#xE70F;"
                                     FontFamily="MauiMaterialAssets"/>
                </schedule:MenuItem.Icon>
            </schedule:MenuItem>
        </schedule:MenuItemCollection>
    </schedule:SfScheduler.AppointmentContextMenu>
</schedule:SfScheduler>
{% endhighlight %}
{% highlight c# tabtitle="C#" hl_lines="3 4 6 8 9 10" %}
SfScheduler scheduler = new SfScheduler();
scheduler.View = SchedulerView.Week;
scheduler.AppointmentEditorMode = AppointmentEditorMode.Add | AppointmentEditorMode.Edit;
scheduler.AppointmentContextMenu = new MenuItemCollection()
{
    new Syncfusion.Maui.Scheduler.MenuItem
    {
        Text = "Edit",
        Command = SchedulerCommands.Edit,
        CommandParameter = new Binding("."),
        Icon = new FontImageSource
        {
            FontFamily = "MauiMaterialAssets",
            Glyph = "&#xE710;",
            Color = Colors.Blue,
            Size = 16

        }
    },

    new Syncfusion.Maui.Scheduler.MenuItem
    {
        Text = "Delete",
        Command = SchedulerCommands.Delete,
        CommandParameter = new Binding("."),
        Icon = new FontImageSource
        {
            FontFamily = "MauiMaterialAssets",
            Glyph = "&#xE70F;",
            Color = Colors.Blue,
            Size = 16
            
        }
    },
};

private void scheduler_ContextMenuOpening(object sender, SchedulerContextMenuOpeningEventArgs e)
{
    var contextMenu = e.ContextMenu;
    var menuType = e.MenuType;
    var menuInfo = e.MenuInfo;
    var appointment = menuInfo?.Appointment;
    var dateTime = menuInfo?.DateTime;
    var resource = menuInfo?.Resource;
    var scheduler = menuInfo?.Scheduler;
}
{% endhighlight %}
{% endtabs %}

## Customize context menu appearance

The scheduler allows you to customize the visual appearance of context menus to match the application's design.You can modify the background and text appearance of the context menu displayed for scheduler cells and appointment using the ContextMenuBackground and ContextMenuTextStyle properties.

{% tabs %}
{% highlight xaml tabtitle="XAML" hl_lines="2 4 5 6 7" %}
<schedule:SfScheduler x:Name="scheduler"
                      ContextMenuBackground="LightGreen"
                      View="Week">
    <schedule:SfScheduler.ContextMenuTextStyle>
        <schedule:SchedulerTextStyle TextColor="Red"
                                     FontSize="20"/>
    </schedule:SfScheduler.ContextMenuTextStyle>
</schedule:SfScheduler>
{% endhighlight %}
{% highlight c# tabtitle="C#" hl_lines="3 4 6 7" %}
SfScheduler scheduler = new SfScheduler();
scheduler.View = SchedulerView.Week;
scheduler.ContextMenuBackground = new SolidColorBrush(Colors.LightGreen);
scheduler.ContextMenuTextStyle = new SchedulerTextStyle()
{
    TextColor = Colors.Black,
    FontSize = 14,
};
{% endhighlight %}
{% endtabs %}
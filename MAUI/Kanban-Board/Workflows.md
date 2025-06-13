---
layout: post
title: Workflows in .NET MAUI Kanban Board control | Syncfusion
description: Learn here all about Workflows support in Syncfusion® .NET MAUI Kanban Board (SfKanban) control and more.
platform: maui
control: Kanban
documentation: ug
---

# Workflows in .NET MAUI Kanban Board (SfKanban)

This feature is used to define the flow of the card transitions from one state to another state. You need to create an instance of [`KanbanWorkflow`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.KanbanWorkflow.html) class and add it to [`Workflows`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.SfKanban.html#Syncfusion_Maui_Kanban_SfKanban_Workflows) property of [`SfKanban`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.SfKanban.html) to define the workflow for each column.  The [`KanbanWorkflow`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.KanbanWorkflow.html) contains the following properties to define the source category and target categories.

* [`Category`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.KanbanWorkflow.html#Syncfusion_Maui_Kanban_KanbanWorkflow_Category) - Used to define the source category/state.
* [`AllowedTransitions`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.KanbanWorkflow.html#Syncfusion_Maui_Kanban_KanbanWorkflow_AllowedTransitions) - Used to define the list of categories/states, the card with the state specified in KanbanWorkflow. Category is allowed to transit.

The following code example describes the workflow functionality.

{% highlight C# %}

var workflows = new List<KanbanWorkflow>();

//Define the category and list of categories which accepts the cards from “Open” state.
var openWorkflow = new KanbanWorkflow("Open", new List<object> { "In Progress" });
workflows.Add(openWorkflow);

//Define the category and list of categories which accepts the cards from “In Progress” state.
var progressWorkflow = new KanbanWorkflow("In Progress", new List<object> { "Code Review", "Postponed" });
workflows.Add(progressWorkflow);

kanban.Workflows = workflows;

{% endhighlight %}

![workflow-in-maui-kanban](images/workflow/workflow-in-maui-kanban.gif)

By following the code snippet, you will notice that the card picked from the `In Progress` state is not allowed to be dropped in the `Open` state because we have defined that the card can only move from the `In Progress` state to the `Code Review`, and `Postponed` states, and not to any other states.
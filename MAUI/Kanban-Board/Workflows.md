---
layout: post
title: Workflows in .NET MAUI Kanban Board control | Syncfusion
description: Learn here all about Workflows support in Syncfusion .NET MAUI Kanban Board (SfKanban) control and more.
platform: maui
control: Kanban
documentation: ug
---

# Workflows in .NET MAUI Kanban Board (SfKanban)

This feature is used to define the flow of the card transitions from one state to another state. You need to create an instance of [`KanbanWorkflow`]() class and add it to [`Workflows`]() property of [`SfKanban`]() to define the workflow for each column.  The [`KanbanWorkflow`]() contains the following properties to define the source category and target categories.

* [`Category`]() - Used to define the source category/state.
* [`AllowedTransitions`]() - Used to define the list of categories/states, the card with the state specified in KanbanWorkflow. Category is allowed to transit.

The following code example describes the workflow functionality.

{% highlight C# %}

var workflows = new List<KanbanWorkflow>();

//Define the category and list of categories which accepts the cards from “Open” state.
var openWorkflow = new KanbanWorkflow("Open", new List<object> { "In Progress" });
workflows.Add(openWorkflow);

//Define the category and list of categories which accepts the cards from “In Progress” state.
var progressWorkflow = new KanbanWorkflow("In Progress", new List<object> { "Open", "Code Review" });
workflows.Add(progressWorkflow);

kanban.Workflows = workflows;

{% endhighlight %}

By following the code snippet, you will notice that the card picked from the "Open" state is not allowed to be dropped in the "Code Review" or "Done" states because we have defined that the card can only move from the "Open" state to the "In Progress" state and not to any other states.
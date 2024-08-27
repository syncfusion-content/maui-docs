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

    var openWorkflow = new KanbanWorkflow();  
    openWorkflow.Category = "Open"; 
    //Define the list of categories which accepts the cards from Open state.
    openWorkflow.AllowedTransitions = new List<object> { "In Progress" }; 
    workflows.Add(openWorkflow); 

    var progressWorkflow = new KanbanWorkflow(); 
    progressWorkflow.Category = "In Progress"; 
    //Define the list of categories which accepts the cards from “In Progress” state.
    progressWorkflow.AllowedTransitions = new List<object> { "Open", "Code Review", "Closed-No Code Changes" }; 
    workflows.Add(progressWorkflow); 

    kanban.Workflows = workflows;

{% endhighlight %}


In the below output, you can see the card which was picked from Open state is not allowed to drop on “Code Review” and "Done" state, because we have defined to move the card from Open to “In Progress” state only and not to any other states.
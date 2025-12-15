---
layout: post
title: Liquid Glass Effect for .NET MAUI Kanban control | Syncfusion®
description: Learn how to enable and customize the Liquid Glass Effect in the Syncfusion® .NET MAUI Kanban Board (SfKanban) control.
platform: MAUI
control: Kanban (SfKanban)
documentation: ug
---

# Liquid Glass Effect in SfKanban

The Liquid Glass Effect introduces a modern, translucent design with adaptive color tinting and light refraction, creating a sleek, glass like user experience that remains clear and accessible. This section explains how to enable and customize the effect in the Syncfusion® .NET MAUI Kanban Board (SfKanban) control.

## Apply liquid glass effect

Follow these steps to enable and configure the Liquid Glass Effect in the Kanban control:

### Step 1: Enable the liquid glass effect on Kanban

Set the `EnableLiquidGlassEffect` property to `true` in the `SfKanban` control to apply the Liquid Glass Effect. When enabled, the effect is also applied to its dependent controls and provides responsive interaction for a smooth and engaging user experience.

### Step 2: Customize the background

To achieve a glass like background in Kanban, set the `Background` property to `Transparent` and use theme keys to style it, ensuring a consistent look and feel across your application.

For more details, refer to the `Liquid Glass Getting Started documentation`.

The following code snippet demonstrates how to apply the Liquid Glass Effect to the `Kanban` control:

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="18" %}

<Grid>
    <Grid.Background>
        <LinearGradientBrush StartPoint="0,0" 
                             EndPoint="0,1">
            <GradientStop Color="#0F4C75" 
                          Offset="0.0"/>
            <GradientStop Color="#3282B8" 
                          Offset="0.5"/>
            <GradientStop Color="#1B262C" 
                          Offset="1.0"/>
        </LinearGradientBrush>
    </Grid.Background>

    <kanban:SfKanban x:Name="kanban"
                     Background="Transparent"
                     AutoGenerateColumns="False"
                     ItemsSource="{Binding Cards}"
                     EnableLiquidGlassEffect="True">
        <kanban:SfKanban.Columns>
            <kanban:KanbanColumn Title="To Do"
                                 Categories="Open"/>
            <kanban:KanbanColumn Title="In Progress"
                                 Categories="In Progress"/>
            <kanban:KanbanColumn Title="Code Review"
                                 Categories="Code Review"/>
            <kanban:KanbanColumn Title="Done"
                                 Categories="Done"/>
        </kanban:SfKanban.Columns>
        <kanban:SfKanban.BindingContext>
            <local:KanbanViewModel/>
        </kanban:SfKanban.BindingContext>
    </kanban:SfKanban>
</Grid>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="19" %}

using Syncfusion.Maui.Core;
using Syncfusion.Maui.ImageEditor;

var gradientBrush = new LinearGradientBrush
{
    StartPoint = new Point(0, 0),
    EndPoint = new Point(0, 1),
    GradientStops = new GradientStopCollection
    {
        new GradientStop { Color = Color.FromArgb("#0F4C75"), Offset = 0.0f },
        new GradientStop { Color = Color.FromArgb("#3282B8"), Offset = 0.5f },
        new GradientStop { Color = Color.FromArgb("#1B262C"), Offset = 1.0f }
    }
};

var grid = new Grid
{
    Background = gradientBrush
};

this.kanban.EnableLiquidGlassEffect = true;
grid.Children.Add(this.kanban);
this.Content = grid;

{% endhighlight %}
{% endtabs %}

N>
* Supported on `macOS 26 or higher` and `iOS 16 or higher`.
* This feature is available only in `.NET 10.`
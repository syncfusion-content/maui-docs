---
layout: post
title: Hierarchical Tree in MAUI Diagram | Syncfusion®
description: Render .NET MAUI Diagram hierarchical trees from nodes and connectors or a DataSource with auto parent-child layout.
platform: maui
control: SfDiagram 
documentation: ug
appliesto: UI Component Suite, Diagram SDK
---

# Hierarchical Tree in .NET MAUI Diagram

The hierarchical tree layout arranges nodes in a tree-like structure, where the nodes in the hierarchical layout may have multiple parents. There is no need to specify the layout root.

## Prerequisites

Refer to the [Getting started](https://help.syncfusion.com/maui/diagram/getting-started) page to create a project, install the package, and register the handler.

---

## Hierarchical tree layout with nodes and connectors

To arrange the nodes in a hierarchical structure, specify the layout [`Type`]() as **HierarchicalTree**. The following example shows how to arrange the nodes in a hierarchical structure.

{% tabs %}
{% highlight xaml %}
    <diagram:SfDiagram x:Name="Diagram">
        <diagram:SfDiagram.Layout>
            <diagram:DiagramLayout Type="OrganizationalChart"
                                   VerticalSpacing="50" />
        </diagram:SfDiagram.Layout>
    </diagram:SfDiagram>
{% endhighlight %}
{% highlight c# tabtitle="C#" %}
using Syncfusion.Maui.Diagram;
namespace Diagram;

public partial class Controlpage : ContentPage
{
	public Controlpage()
	{
		InitializeComponent();

        foreach (var label in new[]
        {
            "Steve-Ceo", "Kevin-Manager", "Peter-Manager", "John-Manager",
            "Mary-CSE", "Jim-CSE", "Martin-CSE"
        })
        {
            var node = new Node
            {
                Id = label, Width = 100, Height = 40,
                Shape = new BasicShape { Shape = NodeBasicShapes.Rectangle },
                Style = new ShapeStyle
                {
                    Fill = Color.FromArgb("#6BA5D7"),
                    StrokeColor = Colors.CornflowerBlue
                }
            };
            node.Annotations.Add(new ShapeAnnotation
            {
                Content = label,
                Style = new TextStyle
                {
                    Color = Colors.White
                }
            });
            Diagram.Nodes.Add(node);
        }

        AddConnection("Steve-Ceo", "Kevin-Manager");
        AddConnection("Steve-Ceo", "Peter-Manager");
        AddConnection("Peter-Manager", "John-Manager");
        AddConnection("Peter-Manager", "Mary-CSE");
        AddConnection("Kevin-Manager", "Jim-CSE");
        AddConnection("Kevin-Manager", "Martin-CSE");
    }

    private void AddConnection(string source, string target) => Diagram.Connectors.Add(new Connector
    {
        Id = $"{source}-{target}", 
        SourceID = source, 
        TargetID = target,
        Style = new ShapeStyle
        {
            StrokeColor = Colors.CornflowerBlue
        },
        TargetDecorator = new DecoratorSettings
        {
            Shape = DecoratorShape.Arrow,
            Style = new ShapeStyle
            {
                Fill = Colors.CornflowerBlue,
                StrokeColor = Colors.CornflowerBlue
            }
        }
    });
}
{% endhighlight %}
{% endtabs %}

## Hierarchical layout with DataSource

You can create a hierarchical layout with data Source. The following code demonstrates how to render a Hierarchical layout using DataSource.

{% tabs %}
{% highlight xaml %}
    <diagram:SfDiagram x:Name="Diagram">
        <diagram:SfDiagram.Layout>
            <diagram:DiagramLayout Type="OrganizationalChart"
                                   VerticalSpacing="50" />
        </diagram:SfDiagram.Layout>
    </diagram:SfDiagram>
{% endhighlight %}
{% highlight c# tabtitle="C#" %}
using System.Collections.ObjectModel;
using Syncfusion.Maui.Diagram;
namespace Diagram;

public partial class Controlpage : ContentPage
{

    private sealed record Employee(string Name, string? ReportingPerson);

	public Controlpage()
	{
		InitializeComponent();

		 Diagram.DataSourceSettings = new DataSourceSettings
        {
            DataSource = new[]
            {
                new Employee("Steve-Ceo", null),
                new Employee("Kevin-Manager", "Steve-Ceo"),
                new Employee("Peter-Manager", "Steve-Ceo"),
                new Employee("John-Manager", "Peter-Manager"),
                new Employee("Mary-CSE", "Peter-Manager"),
                new Employee("Jim-CSE", "Kevin-Manager"),
                new Employee("Martin-CSE", "Kevin-Manager")
            },
            Id = "Name", ParentId = "ReportingPerson",
        };

		Diagram.NodeDefaults = new NodeDefaults
        {
            Width = 120,
            Height = 40,
            Shape = NodeBasicShapes.Rectangle,
            Stroke = Colors.Black,
            StrokeThickness = 2,
            Fill = Colors.CornflowerBlue,
			ExpandIcon = new ExpandIcon()
            {
                Shape = IconShapeModel.None
            },
            CollapseIcon = new ExpandIcon()
            {
                Shape = IconShapeModel.None
            },
            Annotations = new ObservableCollection<AnnotationMapping>
            {
                new()
                {
                    TextPath = nameof(Employee.Name),
                    TextColor = Colors.White,
                    FontAttributes = FontAttributes.Bold
                },
            },
        };

        Diagram.ConnectorDefaults = new ConnectorDefaults
        {
            Type = ConnectorSegmentType.Orthogonal,
            Stroke = Colors.CornflowerBlue,
            StrokeThickness = 2,
            ShowTargetArrow = true,
        };
    }
}
{% endhighlight %}
{% endtabs %}

![Hierarchical tree](../images//hierarchicalTree.png)
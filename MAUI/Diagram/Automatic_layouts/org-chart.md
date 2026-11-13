---
layout: post
title: Organizational Chart in MAUI Diagram | Syncfusion®
description: Render .NET MAUI Diagram organizational charts from a DataSource or explicit nodes, with assistant and getLayoutInfo.
platform: maui
control: SfDiagram 
documentation: ug
appliesto: UI Component Suite, Diagram SDK
---

# Organizational Chart in .NET MAUI Diagram

An organizational chart is a diagram that displays the structure of an organization and relationships. To create an organizational chart, the [`Type`]() of layout should be set as an `OrganizationalChart`.

## Prerequisites

Refer to the [Getting started](https://help.syncfusion.com/maui/diagram/getting-started) page to create a project, install the package, and register the handler.

---

## Organizational chart with DataSource

The following code example illustrates how to create an organizational chart with DataSource.

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

public partial class MainPage : ContentPage
{
	private sealed record Employee(string Id, string? Team, string Role);
	public MainPage()
	{
		InitializeComponent();
		Diagram.DataSourceSettings = new DataSourceSettings
        {
            DataSource = new[]
            {
                new Employee("parent", null, "Project Management"),
                new Employee("1", "parent", "R&D Team"),
                new Employee("3", "1", "Philosophy"),
                new Employee("4", "1", "Organization"),
                new Employee("5", "1", "Technology"),
                new Employee("6", "1", "Funding"),
                new Employee("7", "1", "Resource Allocation"),
                new Employee("8", "1", "Targeting"),
                new Employee("9", "1", "Evaluation"),
                new Employee("156", "parent", "HR Team"),
                new Employee("13", "156", "Recruitment"),
                new Employee("112", "156", "Employee Relation"),
                new Employee("17", "parent", "Production & Sales Team"),
                new Employee("18", "17", "Design"),
                new Employee("19", "17", "Operation"),
                new Employee("20", "17", "Support"),
                new Employee("21", "17", "Quality Assurance"),
                new Employee("22", "17", "Customer Interaction"),
                new Employee("23", "17", "Support and Maintenance"),
                new Employee("24", "17", "Task Coordination"),
            },
            Id = "Id",
            ParentId = "Team",
        };

        Diagram.NodeDefaults = new NodeDefaults
        {
            Width = 100,
            Height = 40,
            Shape = NodeBasicShapes.Rectangle,
            Stroke = Colors.Black,
            StrokeThickness = 2,
            Fill = Colors.DarkCyan,
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
                    TextPath = nameof(Employee.Role),
                    TextColor = Colors.White,
                    FontAttributes = FontAttributes.Bold
                },
            },
        };

        Diagram.ConnectorDefaults = new ConnectorDefaults
        {
            Type = ConnectorSegmentType.Orthogonal,
            Stroke = Colors.SkyBlue,
            StrokeThickness = 2,
            ShowTargetArrow = true,
        };
	}
}
{% endhighlight %}
{% endtabs %}

## Organizational chart with nodes and connectors

You can render an org-chart layout without using DataSource. The following code demonstrates how to render an org-chart layout without using data source.

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

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();

        var labels = new[] { "Project Management", "R&D Team", "Philosophy", "Organization", "Technology", "Funding", "Resource Allocation", "Targeting", "Evaluation", "HR Team", "Recruitment", "Employee Relation", "Production & Sales Team", "Design", "Operation", "Support", "Quality Assurance", "Customer Interaction", "Support and Maintenance", "Task Coordination" };
        foreach (var label in labels)
            Diagram.Nodes.Add(CreateAnnotatedNode(label));

        AddConnection("Project Management", "R&D Team");
        AddConnection("Project Management", "HR Team");
        AddConnection("Project Management", "Production & Sales Team");
        AddConnection("R&D Team", "Philosophy");
        AddConnection("R&D Team", "Organization");
        AddConnection("R&D Team", "Technology");
        AddConnection("R&D Team", "Funding");
        AddConnection("R&D Team", "Resource Allocation");
        AddConnection("R&D Team", "Targeting");
        AddConnection("R&D Team", "Evaluation");
        AddConnection("HR Team", "Recruitment");
        AddConnection("HR Team", "Employee Relation");
        AddConnection("Production & Sales Team", "Design");
        AddConnection("Production & Sales Team", "Operation");
        AddConnection("Production & Sales Team", "Support");
        AddConnection("Production & Sales Team", "Quality Assurance");
        AddConnection("Production & Sales Team", "Customer Interaction");
        AddConnection("Production & Sales Team", "Support and Maintenance");
        AddConnection("Production & Sales Team", "Task Coordination");
	}

    private Node CreateNode(string id) => new()
    {
        Id = id,
        Width = 100,
        Height = 50,
        Shape = new BasicShape { Shape = NodeBasicShapes.Rectangle },
        Style = new ShapeStyle { Fill = Colors.DarkCyan, StrokeColor = Colors.Black }
    };

    private Node CreateAnnotatedNode(string id)
    {
        var node = CreateNode(id);
        node.Annotations.Add(new ShapeAnnotation { Content = id, Style = new TextStyle { Color = Colors.White, Bold = true } });
        return node;
    }

    private void AddConnection(string source, string target) => Diagram.Connectors.Add(new Connector
    {
        Id = $"{source}-{target}", 
        SourceID = source, 
        TargetID = target, 
        Style = new ShapeStyle { StrokeColor = Colors.SkyBlue, StrokeWidth = 2 }, 
        TargetDecorator = new DecoratorSettings { Shape = DecoratorShape.Arrow, Style = new ShapeStyle { Fill = Colors.SkyBlue, StrokeColor = Colors.SkyBlue } }
    });
}
{% endhighlight %}
{% endtabs %}

![Organizational chart](../images//org-chart.png)

## GetLayout info

Organizational chart layout starts parsing from root and iterate through all its child elements. The [`GetLayoutInfo`]() method provides necessary information of a node’s children and the way to arrange (direction, orientation, offsets, etc.) them. The arrangements can be customized by overriding this function as explained.

Set chart orientations, chart types, and offset to be left between parent and child nodes by overriding the `GetLayoutInfo` method. The `GetLayoutInfo` method is called to configure every subtree of the organizational chart. It takes the following arguments.

    * node: Parent node to that options are to be customized.
    * options: Object to set the customizable properties.


The following table illustrates the properties that `options` argument takes.

| Property | Description | Default Value |
| -------- | ----------- | ------------- |
|options.assistants|By default, the collection is empty. When any of the child nodes have to be set as **Assistant**, you can remove from children collection and have to insert into assistants collection.|Empty array|
|options.orientation|Gets or sets the organizational chart orientation.|SubTreeOrientation.Vertical|
|options.type|Gets or sets the chart organizational chart type.|For horizontal chart orientation:SubTreeAlignments.Center and for vertical chart orientation:SubTreeAlignments.Alternate|
|options.offset|Offset is the horizontal space to be left between parent and child nodes.|20 pixels applicable only for vertical chart orientations.|
|options.hasSubTree|Gets whether the node contains subtrees.|Boolean|
|options.level|Gets the depth of the node from layout root.|Number|
|options.enableRouting|By default, connections are routed based on the chart type and orientations. This property gets or sets whether default routing is to be enabled or disabled.|true|
|options.rows|Sets the number of rows on which the child nodes will be arranged. Applicable only for balanced type horizontal tree.|Number|

The following table illustrates the different chart orientations and chart types.

|Orientation|Type|Description|Example|
| -------- | ----------- | ------------- |------|
|Horizontal|Left|Arranges the child nodes horizontally at the left side of the parent.|![Horizontal Left](../images//hleft.JPG)|
|Horizontal|Right|Arranges the child nodes horizontally at the right side of the parent.|![Horizontal Right](../images//hright.JPG)|
|Horizontal|Center|Arranges the children like standard tree layout orientation.|![Horizontal Center](../images//hcenter.JPG)|
|Horizontal|Balanced|Arranges the leaf level child nodes in multiple rows.|![Horizontal Balanced](../images//hbalanced.JPG)|
|Vertical|Left|Arranges the children vertically at the left side of the parent.|![Vertical Left](../images//vleft.JPG)|
|Vertical|Right|Arranges the children vertically at the right side of the parent.|![Vertical Right](../images//vright.JPG)|
|Vertical|Alternate|Arranges the children vertically at both left and right sides of the parent.|![Vertical Alternate](../images//vAlternate.JPG)|

### SubTree horizontal orientation

The following example shows how to utilize the `GetLayoutInfo` function to customize the sub tree alignment in horizontal orientation.

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

public partial class MainPage : ContentPage
{
	private sealed record Employee(int Id, int? Team, string Role);
	public MainPage()
	{
		InitializeComponent();

        Diagram.Layout.GetLayoutInfo = (node, info) => new TreeInfo
        {
            Orientation = SubTreeOrientation.Horizontal,
            Type = SubTreeAlignments.Center
        };

        Diagram.DataSourceSettings = new DataSourceSettings
        {
            DataSource = new[]
            {
                new Employee(1, null, "General Manager"),
                new Employee(2, 1, "Assistant Manager"),
                new Employee(3, 1, "Human Resource Manager"),
                new Employee(4, 1, "Design Manager"),
                new Employee(5, 1, "Operation Manager"),
                new Employee(6, 1, "Marketing Manager")
            },
            Id = "Id", ParentId = "Team",
        };

		Diagram.NodeDefaults = new NodeDefaults
        {
            Width = 120,
            Height = 40,
            Shape = NodeBasicShapes.Rectangle,
            Stroke = Colors.Black,
            StrokeThickness = 2,
            Fill = Colors.DarkCyan,
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
                    TextPath = nameof(Employee.Role),
                    TextColor = Colors.White,
                    FontAttributes = FontAttributes.Bold
                },
            },
        };

        Diagram.ConnectorDefaults = new ConnectorDefaults
        {
            Type = ConnectorSegmentType.Orthogonal,
            Stroke = Colors.SkyBlue,
            StrokeThickness = 2,
        };
    }
}
{% endhighlight %}
{% endtabs %}

### SubTree vertical orientation 

The following code example illustrates how to set the vertical arrangement to the leaf level trees.

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

public partial class MainPage : ContentPage
{
	private sealed record Employee(int Id, int? Team, string Role);
	public MainPage()
	{
		InitializeComponent();

        Diagram.Layout.GetLayoutInfo = (node, info) => new TreeInfo
        {
            Orientation = SubTreeOrientation.Vertical,
            Type = SubTreeAlignments.Left
        };

        Diagram.DataSourceSettings = new DataSourceSettings
        {
            DataSource = new[]
            {
                new Employee(1, null, "General Manager"),
                new Employee(2, 1, "Assistant Manager"),
                new Employee(3, 1, "Human Resource Manager"),
                new Employee(4, 1, "Design Manager"),
                new Employee(5, 1, "Operation Manager"),
                new Employee(6, 1, "Marketing Manager")
            },
            Id = "Id", ParentId = "Team",
        };

		Diagram.NodeDefaults = new NodeDefaults
        {
            Width = 120,
            Height = 40,
            Shape = NodeBasicShapes.Rectangle,
            Stroke = Colors.Black,
            StrokeThickness = 2,
            Fill = Colors.DarkCyan,
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
                    TextPath = nameof(Employee.Role),
                    TextColor = Colors.White,
                    FontAttributes = FontAttributes.Bold
                },
            },
        };

        Diagram.ConnectorDefaults = new ConnectorDefaults
        {
            Type = ConnectorSegmentType.Orthogonal,
            Stroke = Colors.SkyBlue,
            StrokeThickness = 2,
        };
    }
}
{% endhighlight %}
{% endtabs %}


### Assistant

Assistants are child item that have a different relationship with the parent node. They are laid out in a dedicated part of the tree. A node can be specified as an assistant of its parent by adding it to the `assistants` property of the argument `options`.

The following code example illustrates how to add assistants to layout.

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

public partial class MainPage : ContentPage
{
	private sealed record Employee(int Id, int? Team, string Role, OrganizationalRole RoleInChart = OrganizationalRole.Normal);
	public MainPage()
	{
		InitializeComponent();

		var employees = new[]
        {
            new Employee(1, null, "General Manager"),
            new Employee(2, 1, "Assistant Manager", OrganizationalRole.Assistant),
            new Employee(3, 1, "Human Resource Manager"),
            new Employee(4, 1, "Design Manager"),
            new Employee(5, 1, "Operation Manager"),
            new Employee(6, 1, "Marketing Manager")
        };

        Diagram.DataSourceSettings = new DataSourceSettings
        {
            DataSource = employees,
            Id = "Id", ParentId = "Team",
        };

		Diagram.Layout.GetLayoutInfo = (node, info) => new TreeInfo
        {
            Orientation = SubTreeOrientation.Horizontal,
            Type = SubTreeAlignments.Center,
			Role = node.Data is Employee employee ? employee.RoleInChart : OrganizationalRole.Normal
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
                    TextPath = nameof(Employee.Role),
                    TextColor = Colors.White,
                },
            },
        };

        Diagram.ConnectorDefaults = new ConnectorDefaults
        {
            Type = ConnectorSegmentType.Orthogonal,
            Stroke = Colors.CornflowerBlue,
            StrokeThickness = 2,
        };
    }
}
{% endhighlight %}
{% endtabs %}

![Assistant](../images//assistant.png)

N> An Assistant node cannot have any child nodes

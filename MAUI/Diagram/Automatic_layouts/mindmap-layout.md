---
layout: post
title: Mind Map in MAUI Diagram | Syncfusion®
description: Build a Mind Map in the Syncfusion® .NET MAUI Diagram by setting the layout type to MindMap, with Horizontal or Vertical orientation options.
platform: maui
control: SfDiagram
documentation: ug
appliesto: UI Component Suite, Diagram SDK
---

# Mind Map in .NET MAUI Diagram

A mind map is a diagram that displays the nodes as a spider diagram organizes information around a central concept. To create mind map, the [`Type`]() of layout should be set as `MindMap`.

## Mind Map Orientation

An [`Orientation`]() of a `MindMapTreeLayout` is used to arrange the tree layout according to a specific direction. By default, the orientation is set to Horizontal. 

The following code example illustrates how to create an mind map layout.

{% tabs %}
{% highlight xaml %}
     <diagram:SfDiagram x:Name="diagram" />
{% endhighlight %}
{% highlight c# tabtitle="C#" %}
using System.Collections.ObjectModel;
using Syncfusion.Maui.Diagram;

namespace MindMap;

public partial class MainPage : ContentPage
{
	private sealed record MindMapNode(string Id, string? ParentId, string Label)
	{
		public BranchTypes? Branch { get; init; }
	}

	public MainPage()
	{
		InitializeComponent();
		CreateDiagram();
	}

	private void CreateDiagram()
	{	
		diagram.Layout = new DiagramLayout
		{
			Type = DiagramLayoutType.MindMap,
			Orientation = LayoutOrientation.Horizontal,
		};
		diagram.NodeDefaults = CreateNodeDefaults();
		diagram.ConnectorDefaults = CreateConnectorDefaults();
		diagram.GetConnectorDefaults = (connector, source, target) =>
		{
			connector.TargetDecorator.Style = new ShapeStyle { Fill = Color.FromArgb("#6BA5D7"), StrokeColor = Color.FromArgb("#6BA5D7") };
		};
		
		diagram.DataSourceSettings = CreateDataSourceSettings(CreateItems());
		diagram.Created += diagram_Created;
	}

	private static ObservableCollection<MindMapNode> CreateItems() =>
	[
		new("1", null, "StackPanel"),
		new("2", "1", "Label"),
		new("3", "1", "ListBox"),
		new("4", "2", "StackPanel"),
		new("5", "2", "Border"),
		new("6", "4", "Border"),
		new("7", "4", "Button"),
		new("8", "5", "ContentPresenter"),
		new("9", "5", "Text Block"),
	];

	private static NodeDefaults CreateNodeDefaults() => new()
	{
		Width = 140,
		Height = 60,
		Shape = NodeBasicShapes.Rectangle,
		Fill = Color.FromArgb("#6BA5D7"),
		Stroke = Colors.White,
		StrokeThickness = 1,
		CollapseIcon = new ExpandIcon(),
		ExpandIcon = new ExpandIcon(),
		Annotations =
		[
			new AnnotationMapping
			{
				TextPath = nameof(MindMapNode.Label),
				TextColor = Colors.White,
				FontSize = 14,
			},
		],
	};

	private static ConnectorDefaults CreateConnectorDefaults() => new()
	{
		Type = ConnectorSegmentType.Orthogonal,
		ShowTargetArrow = true,
		Stroke = Color.FromArgb("#6BA5D7"),
		StrokeThickness = 2,
	};

	private static DataSourceSettings CreateDataSourceSettings(
		ObservableCollection<MindMapNode> items) => new()
	{
		DataSource = items,
		Id = nameof(MindMapNode.Id),
		ParentId = nameof(MindMapNode.ParentId),
		Root = "1",
		LayoutInfoMapping = new LayoutInfoMapping { Branch = nameof(MindMapNode.Branch) },
	};

	private async void diagram_Created(object? sender, EventArgs e)
	{
		if (sender is SfDiagram diagram)
		{
			await diagram.DoLayoutAsync();
		}
	}
}

{% endhighlight %}
{% endtabs %}


The following table outlines the various orientation types available:

|Orientation Type |Description|
| -------- | ----------- |
|Horizontal|Aligns the tree layout from left to right|
|Vertical|Aligns the tree layout from top to bottom|

## Mind Map branch

You can also decide the branch for mind map using [`GetBranch`]() method. The following code demonstrates how to set all branches on the right side for mind map layout using `GetBranch` method.

{% tabs %}
{% highlight xaml %}
     <diagram:SfDiagram x:Name="diagram" />
{% endhighlight %}
{% highlight c# tabtitle="C#" %}
using System.Collections.ObjectModel;
using Syncfusion.Maui.Diagram;

namespace MindMap;

public partial class MainPage : ContentPage
{
	private sealed record MindMapNode(string Id, string? ParentId, string Label)
	{
		public BranchTypes? Branch { get; init; }
	}

	public MainPage()
	{
		InitializeComponent();
		CreateDiagram();
	}

	private void CreateDiagram()
	{
		var layout = new DiagramLayout
		{
			Type = DiagramLayoutType.MindMap,
			Orientation = LayoutOrientation.Horizontal,
			GetBranch = node => BranchTypes.Left
		};

		diagram.Layout = layout;
		diagram.NodeDefaults = CreateNodeDefaults();
		diagram.ConnectorDefaults = CreateConnectorDefaults();
		diagram.GetConnectorDefaults = (connector, source, target) =>
		{
			connector.TargetDecorator.Style = new ShapeStyle { Fill = Color.FromArgb("#6BA5D7"), StrokeColor = Color.FromArgb("#6BA5D7") };
		};

		diagram.DataSourceSettings = CreateDataSourceSettings(CreateItems());
		diagram.Created += diagram_Created;
	}

	private static ObservableCollection<MindMapNode> CreateItems() =>
	[
		new("1", null, "StackPanel"),
		new("2", "1", "Label"),
		new("3", "1", "ListBox"),
		new("4", "2", "StackPanel"),
		new("5", "2", "Border"),
		new("6", "4", "Border"),
		new("7", "4", "Button"),
		new("8", "5", "ContentPresenter"),
		new("9", "5", "Text Block"),
	];

	private static NodeDefaults CreateNodeDefaults() => new()
	{
		Width = 140,
		Height = 60,
		Shape = NodeBasicShapes.Rectangle,
		Fill = Color.FromArgb("#6BA5D7"),
		Stroke = Colors.White,
		StrokeThickness = 1,
		CollapseIcon = new ExpandIcon(),
		ExpandIcon = new ExpandIcon(),
		Annotations =
		[
			new AnnotationMapping
			{
				TextPath = nameof(MindMapNode.Label),
				TextColor = Colors.White,
				FontSize = 14,
			},
		],
	};

	private static ConnectorDefaults CreateConnectorDefaults() => new()
	{
		Type = ConnectorSegmentType.Orthogonal,
		ShowTargetArrow = true,
		Stroke = Color.FromArgb("#6BA5D7"),
		StrokeThickness = 2,
	};

	private static DataSourceSettings CreateDataSourceSettings(
		ObservableCollection<MindMapNode> items) => new()
	{
		DataSource = items,
		Id = nameof(MindMapNode.Id),
		ParentId = nameof(MindMapNode.ParentId),
		Root = "1",
		LayoutInfoMapping = new LayoutInfoMapping { Branch = nameof(MindMapNode.Branch) },
	};

	private async void diagram_Created(object? sender, EventArgs e)
	{
		if (sender is SfDiagram diagram)
		{
			await diagram.DoLayoutAsync();
		}
	}
}

{% endhighlight %}
{% endtabs %}

![Mind map layout](../images/mindmap.png)
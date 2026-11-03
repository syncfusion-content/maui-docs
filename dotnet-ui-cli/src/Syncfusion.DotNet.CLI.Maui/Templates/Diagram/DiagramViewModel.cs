using System.Collections.Generic;
using Syncfusion.Maui.Diagram;

namespace __ROOT_NAMESPACE__.__CONTROL_NAME__;

public sealed class __VIEW_MODEL_NAME__
{
    public List<Node> Nodes { get; } = [];
    public List<Connector> Connectors { get; } = [];

    public __VIEW_MODEL_NAME__()
    {
		
        // Create a shape style for the nodes
        ShapeStyle shapeStyle = new ShapeStyle()
        {
            Fill = Color.FromArgb("#E8F4FF"),
            StrokeColor = Color.FromArgb("#357BD2"),
            StrokeWidth = 1,
        };		
		
		// Create a shape style for the decorators
        ShapeStyle decoratorStyle = new ShapeStyle()
        {
            Fill = Color.FromArgb("#000000"),
            StrokeColor = Color.FromArgb("#000000"),
            StrokeWidth = 1,
        };
		
        // Keep the initial workflow within a phone-sized viewport. The diagram
        // retains its built-in pan and zoom behavior for larger diagrams.
        string[] steps = ["Start", "Plan", "Build", "Test", "Release"];
        for (var index = 0; index < steps.Length; index++)
        {
            var node = new Node
            {
                Id = $"step{index}",
                OffsetX = 150,
                OffsetY = 50 + index * 90,
                Width = 120,
                Height = 50,
                Shape = new BasicShape { Shape = index == 0 || index == steps.Length - 1 ? NodeBasicShapes.Ellipse : NodeBasicShapes.Rectangle },
				Style = shapeStyle,
            };
            node.Annotations.Add(new ShapeAnnotation { Id = $"label{index}", Content = steps[index] });
            Nodes.Add(node);
            if (index > 0)
                Connectors.Add(new Connector { Id = $"flow{index}", SourceID = $"step{index - 1}", TargetID = node.Id, TargetDecorator = new DecoratorSettings() { Shape = DecoratorShape.Arrow, Style = decoratorStyle }});
        }
    }
}

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.JSInterop;
using System.Collections.ObjectModel;
using Syncfusion.Blazor.Inputs;
using Syncfusion.Blazor.Diagram;

namespace __PAGE_NAMESPACE__;

public partial class DiagramDemo
{
    private const string selecteditem = "image-pattern-style  e-selected-orientation-style";
    private const string unselecteditem = "image-pattern-style";
    private const string selectedPattenitem = "image-pattern-style  e-selected-pattern-style";
    ScrollLimitMode scrollLimit { get; set; } = ScrollLimitMode.Diagram;
    private Orientation subTreeOrientation = Orientation.Vertical;
    private SubTreeAlignmentType subTreeAlignment = SubTreeAlignmentType.Right;
    private int rows = 0;
    private string? pattern;
    private double offset = 20;
    private Dictionary<string, string>? dict = new Dictionary<string, string>() {
        { "topToBottom", selecteditem },
        { "bottomToTop", unselecteditem },
        { "leftToRight", unselecteditem },
        { "rightToLeft", unselecteditem }
    };
    private Dictionary<string, string>? PatternDictionary = new Dictionary<string, string>() {
       { "pattern1", unselecteditem },
       { "pattern2", unselecteditem },
       { "pattern3", unselecteditem },
       { "pattern4", unselecteditem },
       { "pattern5", selectedPattenitem },
       { "pattern6", unselecteditem },
       { "pattern7", unselecteditem },
       { "pattern8", unselecteditem },
       { "pattern9", unselecteditem }
    };

    public SfDiagramComponent? Diagram;
    public LayoutOrientation OrientationType = LayoutOrientation.TopToBottom;
    public int? HorizontalValue { get; set; } = 30;
    public int? VerticalValue { get; set; } = 30;
    public LayoutType Type = LayoutType.OrganizationalChart;
    public HorizontalAlignment HorizontalAlignment = HorizontalAlignment.Auto;
    public VerticalAlignment VerticalAlignment = VerticalAlignment.Auto;
    public int HorizontalSpacing = 30;
    public int VerticalSpacing = 30;
    public double Top = 50;
    public double Bottom = 50;
    public double Right = 50;
    public double Left = 50;


    // Defines default values for Node object
    private void OnNodeCreating(IDiagramObject obj)
    {
        Node? node = obj as Node;
        if (node!.Data is System.Text.Json.JsonElement)
        {
            node.Data = System.Text.Json.JsonSerializer.Deserialize<OrganizationalDetails>(node.Data.ToString()!);
        }
        OrganizationalDetails? organizationData = node.Data as OrganizationalDetails;
        node.Width = 150;
        node.Height = 54;

        node.Shape = new Shape()
        {
            Type = Syncfusion.Blazor.Diagram.NodeShapes.HTML,
        };

    }
    // Defines default values for Connector object
    private void OnConnectorCreating(IDiagramObject connector1)
    {
        Connector? connector = (connector1 as Connector);
        connector!.Type = ConnectorSegmentType.Orthogonal;
        connector.CornerRadius = 10;
        connector.Style = new ShapeStyle()
        {
            StrokeWidth = 1,
            StrokeDashArray = "1,1"
        };
        connector.TargetDecorator!.Shape = DecoratorShape.None;
        connector.SourceDecorator!.Shape = DecoratorShape.None;
    }

    public class OrganizationalDetails
    {
        public string? Id { get; set; }
        public string? Role { get; set; }
        public string? Color { get; set; }
        public string? Manager { get; set; }
        public string? ChartType { get; set; }
        public string? Name { get; set; }
        public string? Imageurl { get; set; }
    }
    //DataSource Items.
    public List<OrganizationalDetails> DataSource = new List<OrganizationalDetails>()
    {
        new OrganizationalDetails() { Id= "parent", Role= "CEO", Color = "#71AF17", Manager = "", ChartType = "", Name="Liam James"},
        new OrganizationalDetails() { Id = "2", Role= "Product Manager", Color = "#1859B7", Manager =  "parent", ChartType = "right", Name="Maria Andres"},
        new OrganizationalDetails() { Id = "3", Role= "Software Engineer", Color = "#2E95D8", Manager = "2", ChartType ="", Name="John Steel"},
        new OrganizationalDetails() { Id = "4", Role= "Software Engineer", Color =  "#2E95D8", Manager =  "2",ChartType = "", Name="Carlos Nagy"},
        new OrganizationalDetails() { Id = "5", Role= "Software Engineer", Color = "#2E95D8", Manager =  "2", ChartType ="", Name="Yoshi Wilson"},
        new OrganizationalDetails() { Id = "6", Role= "Software Engineer", Color = "#2E95D8", Manager =  "2", ChartType ="", Name="Thomas Hardy"},
        new OrganizationalDetails() { Id = "7", Role= "Software Engineer", Color = "#2E95D8", Manager =  "2", ChartType ="", Name="Peter Citeaux"},
        new OrganizationalDetails() { Id = "8", Role= "Product Manager", Color = "#1859B7", Manager =  "parent", ChartType ="right", Name="Pedro Afonso"},
        new OrganizationalDetails() { Id = "9", Role= "Software Engineer",Color =  "#2E95D8",  Manager = "8", ChartType ="", Name="Roland Mendel"},
        new OrganizationalDetails() { Id = "10", Role= "Software Engineer",Color =  "#2E95D8", Manager =  "8", ChartType = "", Name="Diego Roel"},
        new OrganizationalDetails() { Id = "11", Role= "Software Engineer", Color = "#2E95D8",  Manager = "8", ChartType = "", Name="Martine Rancé"},
        new OrganizationalDetails() { Id = "12", Role= "Software Engineer", Color = "#2E95D8",  Manager = "8", ChartType = "", Name="Maria Larsson"},
        new OrganizationalDetails() { Id = "13", Role= "Software Engineer", Color = "#2E95D8",  Manager = "8", ChartType = "", Name="Paolo Accorti"},
        new OrganizationalDetails() { Id = "14", Role= "Product manager", Color =  "#1859B7", Manager =  "parent", ChartType ="right", Name="Helen Bennett"},
        new OrganizationalDetails() { Id = "15", Role= "Software Engineer", Color =  "#2E95D8",  Manager = "14", ChartType = "", Name="Renate Jose"},
        new OrganizationalDetails() { Id = "16", Role= "Software Engineer", Color =  "#2E95D8", Manager =  "14", ChartType ="", Name="Jaime Yorres"},
        new OrganizationalDetails() { Id = "17", Role= "Software Engineer", Color =  "#2E95D8", Manager =  "14", ChartType ="", Name="Alex Feuer"},
        new OrganizationalDetails() { Id = "18", Role= "Software Engineer", Color =  "#2E95D8", Manager =  "14", ChartType ="", Name="Helen Marie"},
        new OrganizationalDetails() { Id = "19", Role= "Software Engineer", Color =  "#2E95D8", Manager =  "14", ChartType ="", Name="Yoshi Kenna"},
        new OrganizationalDetails() { Id = "20", Role= "Product Manager", Color = "#1859B7", Manager =  "parent", ChartType ="right", Name="Joseph Kaff"},
        new OrganizationalDetails() { Id = "21", Role= "Software Engineer", Color =  "#2E95D8", Manager =  "20", ChartType ="", Name="Sergio roel"},
        new OrganizationalDetails() { Id = "22", Role= "Software Engineer", Color = "#2E95D8",  Manager = "20", ChartType ="", Name="Paula Wilson"},
        new OrganizationalDetails() { Id = "23", Role= "Software Engineer", Color =  "#2E95D8",  Manager = "20",ChartType = "", Name="Mauri Moroni"},
        new OrganizationalDetails() { Id = "24", Role= "Software Engineer", Color = "#2E95D8",  Manager = "20", ChartType ="", Name="Janete Limeira"},
        new OrganizationalDetails() { Id = "25", Role= "Software Engineer", Color = "#2E95D8",  Manager = "20", ChartType ="", Name="Michael Holz"}
    };
    private TreeInfo GetLayoutInfo(IDiagramObject obj, TreeInfo options)
    {
        if (rows == 0)
        {
            if (rows == 0 && options.Rows != null)
                options.Rows = null;
            Node? node = obj as Node;
            if (pattern == "LeftOrientationVertical50" || pattern == "RightOrientationVertical50")
            {
                options.Offset = -50;
            }

            if (!options.HasSubTree)
            {
                options.AlignmentType = subTreeAlignment;
                options.Orientation = subTreeOrientation;
                options.AlignmentType = subTreeAlignment;
            }
        }
        else
        {
            if (!options.HasSubTree)
            {
                options.AlignmentType = subTreeAlignment;
                options.Orientation = subTreeOrientation;
                options.Offset = offset;
            }
        }
        return options;
    }

    public void LeftToRight()
    {
        OrientationType = LayoutOrientation.LeftToRight;
    }

    public class ImageFields
    {
        public string? Text { get; set; }
    }

    private void HSpacingChange(Syncfusion.Blazor.Inputs.ChangeEventArgs<int?> args)
    {
        HorizontalValue = (int)args.Value!;
        HorizontalSpacing = int.Parse(args.Value.ToString()!);

    }
    private void VSpacingChange(Syncfusion.Blazor.Inputs.ChangeEventArgs<int?> args)
    {
        VerticalValue = (int)args.Value!;
        VerticalSpacing = int.Parse(args.Value.ToString()!);
    }

    private void ToptoBottomClick()
    {
        OrientationType = LayoutOrientation.TopToBottom;
        UpdateSelection("topToBottom");
    }
    private void LefttoRightClick()
    {
        OrientationType = LayoutOrientation.LeftToRight;
        UpdateSelection("leftToRight");
    }
    private void RighttoLeftClick()
    {
        OrientationType = LayoutOrientation.RightToLeft;
        UpdateSelection("rightToLeft");
    }
    private void BottomtoTopClick()
    {
        OrientationType = LayoutOrientation.BottomToTop;
        UpdateSelection("bottomToTop");
    }
    private async Task AlternateOrientationVertical20()
    {
        pattern = "AlternateOrientationVertical20";
        Diagram!.BeginUpdate();
        subTreeAlignment = SubTreeAlignmentType.Alternate;
        subTreeOrientation = Orientation.Vertical;
        offset = 20;
        UpdatePatternSelection("pattern1");
        _ = Diagram.EndUpdateAsync();
        await Diagram.DoLayoutAsync();
    }
    private async Task LeftOrientationVertical20()
    {
        pattern = "LeftOrientationVertical20";
        Diagram!.BeginUpdate();
        subTreeAlignment = SubTreeAlignmentType.Left;
        subTreeOrientation = Orientation.Vertical;
        offset = 20;
        UpdatePatternSelection("pattern2");
        _ = Diagram.EndUpdateAsync();
        await Diagram.DoLayoutAsync();
    }
    private async Task LeftOrientationVertical50()
    {
        pattern = "LeftOrientationVertical50";
        Diagram!.BeginUpdate();
        subTreeAlignment = SubTreeAlignmentType.Left;
        subTreeOrientation = Orientation.Vertical;
        offset = -50;
        UpdatePatternSelection("pattern3");
        _ = Diagram.EndUpdateAsync();
        await Diagram.DoLayoutAsync();
    }
    private async Task RightOrientationVertical50()
    {
        pattern = "RightOrientationVertical50";
        Diagram!.BeginUpdate();
        subTreeAlignment = SubTreeAlignmentType.Right;
        subTreeOrientation = Orientation.Vertical;
        offset = -50;
        UpdatePatternSelection("pattern4");
        _ = Diagram.EndUpdateAsync();
        await Diagram.DoLayoutAsync();
    }
    private async Task RightOrientationVertical20()
    {
        pattern = "RightOrientationVertical20";
        Diagram!.BeginUpdate();
        subTreeAlignment = SubTreeAlignmentType.Right;
        subTreeOrientation = Orientation.Vertical;
        offset = 20;
        UpdatePatternSelection("pattern5");
        _ = Diagram.EndUpdateAsync();
        await Diagram.DoLayoutAsync();
    }
    private async Task BalancedOrientationHorizontal20()
    {
        pattern = "BalancedOrientationHorizontal20";
        Diagram!.BeginUpdate();
        subTreeAlignment = SubTreeAlignmentType.Balanced;
        subTreeOrientation = Orientation.Horizontal;
        offset = 20;
        UpdatePatternSelection("pattern6");
        _ = Diagram.EndUpdateAsync();
        await Diagram.DoLayoutAsync();
    }
    private async Task CenterOrientationHorizontal50()
    {
        pattern = "CenterOrientationHorizontal50";
        Diagram!.BeginUpdate();
        subTreeAlignment = SubTreeAlignmentType.Center;
        subTreeOrientation = Orientation.Horizontal;
        offset = -50;
        UpdatePatternSelection("pattern7");
        _ = Diagram.EndUpdateAsync();
        await Diagram.DoLayoutAsync();
    }
    private async Task LeftOrientationHorizontal20()
    {
        pattern = "LeftOrientationHorizontal20";
        Diagram!.BeginUpdate();
        subTreeAlignment = SubTreeAlignmentType.Left;
        subTreeOrientation = Orientation.Horizontal;
        offset = 20;
        UpdatePatternSelection("pattern8");
        _ = Diagram.EndUpdateAsync();
        await Diagram.DoLayoutAsync();
    }
    private async Task RightOrientationHorizontal20()
    {
        pattern = "RightOrientationHorizontal20";
        Diagram!.BeginUpdate();
        subTreeAlignment = SubTreeAlignmentType.Right;
        subTreeOrientation = Orientation.Horizontal;
        offset = 20;
        UpdatePatternSelection("pattern9");
        await Diagram.EndUpdateAsync();
        await Diagram.DoLayoutAsync();
    }
    private void UpdatePatternSelection(string id)
    {
        for (int i = 0; i < PatternDictionary!.Count; i++)
        {
            var value = PatternDictionary.Values.ElementAt(i);
            var key = PatternDictionary.Keys.ElementAt(i);
            if (PatternDictionary.ContainsKey(id) && key == id)
            {
                value = selectedPattenitem;
            }
            else
            {
                value = unselecteditem;
            }
            PatternDictionary.Remove(key);
            PatternDictionary.Add(key, value);
        }
    }
    // Method is used to apply the selection to the prroperty panel.
    private void UpdateSelection(string id)
    {
        for (int i = 0; i < dict!.Count; i++)
        {
            var value = dict.Values.ElementAt(i);
            var key = dict.Keys.ElementAt(i);
            if (dict.ContainsKey(id) && key == id)
            {
                value = selectedPattenitem;
            }
            else
            {
                value = unselecteditem;
            }
            dict.Remove(key);
            dict.Add(key, value);
        }
    }


    public void Dispose()
    {
        if (dict != null)
        {
            dict.Clear();
            dict = null;
        }
        if (PatternDictionary != null)
        {
            PatternDictionary.Clear();
            PatternDictionary = null;
        }
        Diagram = null;
        pattern = null;
    }

}

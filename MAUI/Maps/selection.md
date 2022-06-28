---
layout: post
title: Shape Selection in MAUI Maps control | Syncfusion
description: Learn here all about the Shape Selection feature of Syncfusion MAUI Maps (SfMaps) control and more.
platform: MAUI
control: SfMaps
documentation: ug
---

# Shape Selection in MAUI Maps (SfMaps)

You can select a shape in order to highlight that area on a map. You can use the event for performing any action during shape selection.

## Enable shape selection

You can enable shape selection on a map using the [`EnableSelection`]() property.Selection allows you select only one shape at a time. You can select a shape by tapping it. By default, the selection is enabled when the EnableSelection property is set to true.

The [`ShapeSelected`]() event is used to perform any action on shape selected shape when the user is selecting a shape by tapping or clicking or by programmatically.

{% tabs %}

{% highlight xaml %}

     <map:SfMaps>
        <map:SfMaps.Layer>
            <map:MapShapeLayer  x:Name="layer"
                ShapesSource="https://cdn.syncfusion.com/maps/map-data/australia.json" 
                SelectedShapeFill="Aqua"
                ShapeSelected="MapShapeLayer_ShapeSelected" 
                EnableSelection="True">
            
            </map:MapShapeLayer>
        </map:SfMaps.Layer>
    </map:SfMaps>

{% endhighlight %}

{% highlight c# %}

private void MapShapeLayer_ShapeSelected(object sender, ShapeSelectedEventArgs e)
{
    
}

{% endhighlight %}

{% endtabs %}

![Enable shape selection](images/selection/enable-shape-selection.png)

## Appearance customization

You can customize the below appearance of the selected shape.

* **SelectedShapeFill** - Change the background color of the selected shape using the [`SelectedShapeFill`]() property.If SelectedShapeFill is null then the saturated color of the shape will be applied. If SelectedShapeFill is Transparent, then the UI changes will not occur.
* **SelectedShapeStrokeThickness** - Change the stroke width of the selected shape using the [`SelectedShapeStrokeThickness`]() property.
* **SelectedShapeStroke** - Change the stroke color of the selected shape using the [`SelectedShapeStroke`]() property.

{% tabs %}

{% highlight xaml %}

     <map:SfMaps>
        <map:SfMaps.Layer>
            <map:MapShapeLayer ShapesSource="https://cdn.syncfusion.com/maps/map-data/australia.json" 
            DataSource="{Binding Data}" 
            PrimaryValuePath="Country"
             ShapeDataField="STATE_NAME" 
             ShapeColorValuePath = "Color" 
             SelectedShapeFill="Green"
             SelectedShapeStroke="DarkGreen" 
             SelectedShapeStrokeThickness="2" 
             EnableSelection="True">
            
            </map:MapShapeLayer>
        </map:SfMaps.Layer>
    </map:SfMaps>

{% endhighlight %}

{% highlight c# %}

public MainPage()
    {
        InitializeComponent();
        ViewModel viewModel = new ViewModel();
        this.BindingContext = viewModel;

        SfMaps maps = new SfMaps();
        MapShapeLayer layer = new MapShapeLayer();
        layer.ShapesSource = MapSource.FromUri(new Uri("https://cdn.syncfusion.com/maps/map-data/australia.json"));
        layer.DataSource = viewModel.Data;
        layer.PrimaryValuePath = "Country";
        layer.ShapeDataField = "STATE_NAME";
        layer.SelectedShapeFill = Colors.Green;
        layer.SelectedShapeStroke = Colors.DarkGreen;
        layer.SelectedShapeStrokeThickness = 2;
        layer.EnableSelection = true;
        layer.ShapeColorValuePath = "Color";

        maps.Layer = layer;
        this.Content = maps;
    }
public class ViewModel
{
    public ObservableCollection<Model> Data { get; set; }
    public ViewModel()
    {
        Data = new ObservableCollection<Model>();
        Data.Add(new Model("New South Wales", Colors.LightGreen));
        Data.Add(new Model("Northern Territory",Colors.LightGreen));
        Data.Add(new Model("Victoria", Colors.LightGreen));
        Data.Add(new Model("Tasmania", Colors.LightGray));
        Data.Add(new Model("Queensland", Colors.LightGreen));
        Data.Add(new Model("Western Australia", Colors.LightGreen));
        Data.Add(new Model("South Australia", Colors.LightGreen));
    }
}
public class Model
{
    public Model(string country, Color color)
    {
        Country = country;
        Color = color;
    }
    public String Country { get; set; }
    public Color Color { get; set; }
}

{% endhighlight %}

{% endtabs %}

![Selection customization](images/selection/selection-customization.png)

N> You can refer to our [MAUI Maps]() feature tour page for its groundbreaking feature representations. You can also explore our [MAUI Maps Selection example]() that shows how to configure a Maps in MAUI.
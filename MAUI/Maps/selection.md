---
layout: post
title: Shape Selection in MAUI Maps widget | Syncfusion
description: Learn here all about the Shape Selection feature of Syncfusion MAUI Maps (SfMaps) widget and more.
platform: MAUI
control: SfMaps
documentation: ug
---

# Shape Selection in MAUI Maps (SfMaps)

You can select a shape in order to highlight that area on a map. You can use the callback for performing any action during shape selection.

## Enable shape selection

You can enable shape selection on a map using the [`MapShapeLayer.EnableSelection`](https://pub.dev/documentation/syncfusion_flutter_maps/latest/maps/MapShapeLayer/onSelectionChanged.html) property.Selection allows you select only one shape at a time. You can select a shape by tapping it. By default, the selection is enabled when the EnableSelection property is set to true.

The [`ShapeSelected`](https://pub.dev/documentation/syncfusion_flutter_maps/latest/maps/MapShapeLayer/onSelectionChanged.html) callback is used to pass the index of the selected shape when the user is selecting a shape by tapping or clicking or by programmatically.

{% tabs %}

{% highlight xaml %}

     <map:SfMaps>
        <map:SfMaps.Layer>
            <map:MapShapeLayer  x:Name="layer" ShapesSource="https://cdn.syncfusion.com/maps/map-data/australia.json"  ShapeSelected="MapShapeLayer_ShapeSelected"  EnableSelection="True">
            
            </map:MapShapeLayer>
        </map:SfMaps.Layer>
    </map:SfMaps>

{% endhighlight %}

{% highlight c# %}

private void MapShapeLayer_ShapeSelected(object sender, ShapeSelectedEventArgs e)
{
     layer.SelectedShapeFill = Colors.Aqua;
}

{% endhighlight %}

{% endtabs %}

![Enable shape selection](images/selection/enable-shape-selection.png)

## Appearance customization

You can customize the below appearance of the selected shape.

* **SelectedShapeFill** - Change the background color of the selected shape using the [`MapShapeLayer.SelectedShapeFill`](https://pub.dev/documentation/syncfusion_flutter_maps/latest/maps/MapSelectionSettings/color.html) property.
* **SelectedShapeStrokeThickness** - Change the stroke width of the selected shape using the [`MapShapeLayer.SelectedShapeStrokeThickness`](https://pub.dev/documentation/syncfusion_flutter_maps/latest/maps/MapSelectionSettings/strokeWidth.html) property.
* **SelectedShapeStroker** - Change the stroke color of the selected shape using the [`MapShapeLayer.SelectedShapeStroke`](https://pub.dev/documentation/syncfusion_flutter_maps/latest/maps/MapSelectionSettings/strokeColor.html) property.

{% tabs %}

{% highlight xaml %}

     <map:SfMaps>
        <map:SfMaps.Layer>
            <map:MapShapeLayer ShapesSource="https://cdn.syncfusion.com/maps/map-data/australia.json" DataSource="{Binding Data}" PrimaryValuePath="Country" ShapeDataField="STATE_NAME" ShapeColorValuePath = "Color" SelectedShapeFill="Green"
                          SelectedShapeStroke="DarkGreen" SelectedShapeStrokeThickness="2" EnableSelection="True">
            
            </map:MapShapeLayer>
        </map:SfMaps.Layer>
    </map:SfMaps>

{% endhighlight %}

{% highlight c# %}

public MainPage()
    {
        InitializeComponent();
        ObservableCollection<Model> Data = new ObservableCollection<Model>();
        Data.Add(new Model("New South Wales", Colors.LightGreen));
        Data.Add(new Model("Northern Territory",Colors.LightGreen));
        Data.Add(new Model("Victoria", Colors.LightGreen));
        Data.Add(new Model("Tasmania", Colors.LightGray));
        Data.Add(new Model("Queensland", Colors.LightGreen));
        Data.Add(new Model("Western Australia", Colors.LightGreen));
        Data.Add(new Model("South Australia", Colors.LightGreen));

        SfMaps maps = new SfMaps();
        MapShapeLayer layer = new MapShapeLayer();

        layer.ShapesSource = MapSource.FromUri(new Uri("https://cdn.syncfusion.com/maps/map-data/australia.json"));
        layer.DataSource = Data;
        layer.PrimaryValuePath = "Country";
        layer.ShapeDataField = "STATE_NAME";
        layer.ShapeStroke =  Colors.Red;
        layer.SelectedShapeFill = Colors.Green;
        layer.SelectedShapeStroke = Colors.DarkGreen;
        layer.SelectedShapeStrokeThickness = 2;
        layer.EnableSelection = true;
        layer.ShapeColorValuePath = "Color";

        maps.Layer = layer;
        this.Content = maps;
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

N> You can refer to our [MAUI Maps](https://www.syncfusion.com/flutter-widgets/flutter-maps) feature tour page for its groundbreaking feature representations. You can also explore our [MAUI Maps Selection example](https://flutter.syncfusion.com/#/maps/shape-layer/selection) that shows how to configure a Maps in MAUI.
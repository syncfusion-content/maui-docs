---
layout: post
title: Custom Shapes in .NET MAUI Maps Control | Syncfusion<sup>&reg;</sup> 
description: Learn here all about the custom shapes feature of Syncfusion<sup>&reg;</sup> .NET MAUI Maps (SfMaps) control, its features, and more.
platform: MAUI
control: SfMaps
documentation: ug
keywords: .net maui maps, .net maui shape maps.
---

# Custom shapes in .NET MAUI Maps (SfMaps)

The [.NET MAUI Maps](https://www.syncfusion.com/maui-controls/maui-maps) control allows you to render any custom shape to make a map look like building infrastructure, a sports stadium, plane or bus seat arrangements, and more using the [`Geometry`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_Geometry) property.
{% tabs %}

{% highlight XAML %}

<maps:SfMaps>
    <maps:SfMaps.Layer>
        <maps:MapShapeLayer x:Name="layer"
                            ShapeFill="DarkGray"
                            ShapeStroke="DarkGray"
                            Geometry="Points">
        </maps:MapShapeLayer>
    </maps:SfMaps.Layer>
</maps:SfMaps>

{% endhighlight %}

{% highlight c# %}

public MainPage()
{
    InitializeComponent();
    SfMaps map = new SfMaps();
    MapShapeLayer layer = new MapShapeLayer();
    layer.ShapesSource = MapSource.FromResource("MyProject.floor_planning.json");
    layer.ShapeFill = Brush.DarkGray;
    layer.ShapeStroke = Brush.DarkGray;
    layer.Geometry = MapGeometryType.Points;
    map.Layer = layer;
    this.Content = map;
}

{% endhighlight %}

{% endtabs %}

![.NET MAUI Maps with custom shapes](images/custom-shape/maps_cartesian_view.png)
---
layout: post
title: Adding polygons in Maps control | Syncfusion
description: Learn here all about adding the Polygons feature of Syncfusion .NET MAUI Maps (SfMaps) control to customize their appearances and more.
platform: MAUI
control: SfMaps
documentation: ug
---

# Polygons in .NET MAUI Maps (SfMaps)

Polygon layer is a sublayer that renders a group of [`MapPolygon`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapPolygon.html) on the [`MapShapeLayer`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html). This section helps to learn about how to add the polygons and customize them.

## Adding polygons

The [`Polygons`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapPolygonLayer.html#Syncfusion_Maui_Maps_MapPolygonLayer_Polygons) is a collection of [`MapPolygon`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapPolygon.html). Every single [`MapPolygon`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapPolygon.html) connects multiple coordinates through a [`Points`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapPolygon.html#Syncfusion_Maui_Maps_MapPolygon_Points) property.

{% tabs %}

{% highlight xaml %}

<map:SfMaps>
    <map:SfMaps.Layer>
        <map:MapShapeLayer ShapesSource="https://cdn.syncfusion.com/maps/map-data/world-map.json"
                           ShapeStroke="DarkGray">
            <map:MapShapeLayer.Sublayers>
                <map:MapPolygonLayer>
                    <map:MapPolygonLayer.Polygons>
                        <map:MapPolygon>
                            <map:MapPolygon.Points>
                                <map:MapLatLng Latitude="37.6173"
                                               Longitude="55.7558" />
                                <map:MapLatLng Latitude="87.1216"
                                               Longitude="53.7596" />
                                <map:MapLatLng Latitude="105.3188"
                                               Longitude="61.5240" />
                            </map:MapPolygon.Points>
                        </map:MapPolygon>
                        <map:MapPolygon>
                            <map:MapPolygon.Points>
                                <map:MapLatLng Latitude="-135.0000"
                                               Longitude="64.2823" />
                                <map:MapLatLng Latitude="-85.3232"
                                               Longitude="51.2538" />
                                <map:MapLatLng Latitude="-123.3656"
                                               Longitude="48.4284" />
                            </map:MapPolygon.Points>
                        </map:MapPolygon>
                    </map:MapPolygonLayer.Polygons>
                </map:MapPolygonLayer>
            </map:MapShapeLayer.Sublayers>
        </map:MapShapeLayer>
    </map:SfMaps.Layer>
</map:SfMaps>

{% endhighlight %}

{% highlight c# %}

SfMaps maps = new SfMaps();
MapShapeLayer layer = new MapShapeLayer();
layer.ShapesSource = MapSource.FromUri(new Uri("https://cdn.syncfusion.com/maps/map-data/world-map.json"));
layer.ShapeStroke = Brush.DarkGray;
MapPolygonLayer mapPolygonLayer = new MapPolygonLayer();
MapPolygon polygon1 = new MapPolygon();
polygon1.Points = new ObservableCollection<MapLatLng>()
{
new MapLatLng(37.6173, 55.7558),
new MapLatLng(87.1216, 53.7596),
new MapLatLng(105.3188, 61.5240)
};
MapPolygon polygon2 = new MapPolygon();
polygon2.Points = new ObservableCollection<MapLatLng>()
{
new MapLatLng(-135.0000, 64.2823),
new MapLatLng(-85.3232, 51.2538),
new MapLatLng(-123.3656, 48.4284)
};
mapPolygonLayer.Polygons.Add(polygon1);
mapPolygonLayer.Polygons.Add(polygon2);
layer.Sublayers.Add(mapPolygonLayer);
maps.Layer = layer;
this.Content = maps;

{% endhighlight %}

{% endtabs %}

![Default polygon shape](images/polygon-layer/default-polygon-shape.png)

## Fill color

You can apply colors to each [`MapPolygon`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapPolygon.html) in the [`Polygons`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapPolygonLayer.html#Syncfusion_Maui_Maps_MapPolygonLayer_Polygons) collection using the individual [`MapPolygon.Fill`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapPolygon.html#Syncfusion_Maui_Maps_MapPolygon_Fill) property.

{% tabs %}

{% highlight xaml %}

<map:SfMaps>
    <map:SfMaps.Layer>
        <map:MapShapeLayer ShapesSource="https://cdn.syncfusion.com/maps/map-data/world-map.json"
                           ShapeStroke="DarkGray">
            <map:MapShapeLayer.Sublayers>
                <map:MapPolygonLayer>
                    <map:MapPolygonLayer.Polygons>
                        <map:MapPolygon Fill="#6defae">
                            <map:MapPolygon.Points>
                                <map:MapLatLng Latitude="37.6173"
                                               Longitude="55.7558" />
                                <map:MapLatLng Latitude="87.1216"
                                               Longitude="53.7596" />
                                <map:MapLatLng Latitude="105.3188"
                                               Longitude="61.5240" />
                            </map:MapPolygon.Points>
                        </map:MapPolygon>
                        <map:MapPolygon Fill="#ec407f">
                            <map:MapPolygon.Points>
                                <map:MapLatLng Latitude="-135.0000"
                                               Longitude="64.2823" />
                                <map:MapLatLng Latitude="-85.3232"
                                               Longitude="51.2538" />
                                <map:MapLatLng Latitude="-123.3656"
                                               Longitude="48.4284" />
                            </map:MapPolygon.Points>
                        </map:MapPolygon>
                    </map:MapPolygonLayer.Polygons>
                </map:MapPolygonLayer>
            </map:MapShapeLayer.Sublayers>
        </map:MapShapeLayer>
    </map:SfMaps.Layer>
</map:SfMaps>

{% endhighlight %}

{% highlight c# %}

SfMaps maps = new SfMaps();
MapShapeLayer layer = new MapShapeLayer();
layer.ShapesSource = MapSource.FromUri(new Uri("https://cdn.syncfusion.com/maps/map-data/world-map.json"));
layer.ShapeStroke = Brush.DarkGray;
MapPolygonLayer mapPolygonLayer = new MapPolygonLayer();
MapPolygon polygon1 = new MapPolygon();
polygon1.Points = new ObservableCollection<MapLatLng>()
{
new MapLatLng(37.6173, 55.7558),
new MapLatLng(87.1216, 53.7596),
new MapLatLng(105.3188, 61.5240)
};
polygon1.Fill = Color.FromRgb(109, 239, 174);
MapPolygon polygon2 = new MapPolygon();
polygon2.Points = new ObservableCollection<MapLatLng>()
{
new MapLatLng(-135.0000, 64.2823),
new MapLatLng(-85.3232, 51.2538),
new MapLatLng(-123.3656, 48.4284)
};
polygon2.Fill = Color.FromRgb(236, 64, 127);
mapPolygonLayer.Polygons.Add(polygon1);
mapPolygonLayer.Polygons.Add(polygon2);
layer.Sublayers.Add(mapPolygonLayer);
maps.Layer = layer;
this.Content = maps;

{% endhighlight %}

{% endtabs %}

![Polygon fill color](images/polygon-layer/polygon-fill-color.png)

## Stroke and stroke thickness

You can apply stroke thickness to each [`MapPolygon`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapPolygon.html) in the [`Polygons`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapPolygonLayer.html#Syncfusion_Maui_Maps_MapPolygonLayer_Polygons) collection using the individual [`MapPolygon.StrokeThickness`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapPolygon.html#Syncfusion_Maui_Maps_MapPolygon_StrokeThickness) property. The default value of the [`MapPolygon.StrokeThickness`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapPolygon.html#Syncfusion_Maui_Maps_MapPolygon_StrokeThickness) property is `2`.

You can apply stroke color to each [`MapPolygon`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapPolygon.html) in the [`Polygons`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapPolygonLayer.html#Syncfusion_Maui_Maps_MapPolygonLayer_Polygons) collection using the individual [`MapPolygon.Stroke`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapPolygon.html#Syncfusion_Maui_Maps_MapPolygon_Stroke) property.

{% tabs %}

{% highlight xaml %}

<map:SfMaps>
    <map:SfMaps.Layer>
        <map:MapShapeLayer ShapesSource="https://cdn.syncfusion.com/maps/map-data/world-map.json"
                           ShapeStroke="DarkGray">
            <map:MapShapeLayer.Sublayers>
                <map:MapPolygonLayer>
                    <map:MapPolygonLayer.Polygons>
                        <map:MapPolygon Stroke="#ea3b5e"
                                        StrokeThickness="3">
                            <map:MapPolygon.Points>
                                <map:MapLatLng Latitude="37.6173"
                                               Longitude="55.7558" />
                                <map:MapLatLng Latitude="87.1216"
                                               Longitude="53.7596" />
                                <map:MapLatLng Latitude="105.3188"
                                               Longitude="61.5240" />
                            </map:MapPolygon.Points>
                        </map:MapPolygon>
                        <map:MapPolygon Stroke="#ea3b5e"
                                        StrokeThickness="4">
                            <map:MapPolygon.Points>
                                <map:MapLatLng Latitude="-135.0000"
                                               Longitude="64.2823" />
                                <map:MapLatLng Latitude="-85.3232"
                                               Longitude="51.2538" />
                                <map:MapLatLng Latitude="-123.3656"
                                               Longitude="48.4284" />
                            </map:MapPolygon.Points>
                        </map:MapPolygon>
                    </map:MapPolygonLayer.Polygons>
                </map:MapPolygonLayer>
            </map:MapShapeLayer.Sublayers>
        </map:MapShapeLayer>
    </map:SfMaps.Layer>
</map:SfMaps>

{% endhighlight %}

{% highlight c# %}

SfMaps maps = new SfMaps();
MapShapeLayer layer = new MapShapeLayer();
layer.ShapesSource = MapSource.FromUri(new Uri("https://cdn.syncfusion.com/maps/map-data/world-map.json"));
layer.ShapeStroke = Brush.DarkGray;
MapPolygonLayer mapPolygonLayer = new MapPolygonLayer();
MapPolygon polygon1 = new MapPolygon();
polygon1.Points = new ObservableCollection<MapLatLng>()
{
new MapLatLng(37.6173, 55.7558),
new MapLatLng(87.1216, 53.7596),
new MapLatLng(105.3188, 61.5240)
};
polygon1.Fill = Color.FromRgb(234, 59, 94);
polygon1.StrokeThickness = 3;
MapPolygon polygon2 = new MapPolygon();
polygon2.Points = new ObservableCollection<MapLatLng>()
{
new MapLatLng(-135.0000, 64.2823),
new MapLatLng(-85.3232, 51.2538),
new MapLatLng(-123.3656, 48.4284)
};
polygon2.Fill = Color.FromRgb(234, 59, 94);
polygon2.StrokeThickness = 4;
mapPolygonLayer.Polygons.Add(polygon1);
mapPolygonLayer.Polygons.Add(polygon2);
layer.Sublayers.Add(mapPolygonLayer);
maps.Layer = layer;
this.Content = maps;

{% endhighlight %}

{% endtabs %}

![Polygon stroke color](images/polygon-layer/polygon-stroke-color.png)
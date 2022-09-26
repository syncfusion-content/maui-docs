---
layout: post
title: Lines in Maps control | Syncfusion
description: Learn here all about adding the Line Layer feature of Syncfusion .NET MAUI Maps (SfMaps) control to customize their appearances and more.
platform: MAUI
control: SfMaps
documentation: ug
---

# Lines in .NET MAUI Maps (SfMaps)

Line layer is a sublayer that renders a group of `MapLine` on `MapShapeLayer`. This section helps to learn about how to add the lines and customize them.

## Adding lines

The `Lines` is a collection of `MapLine`. Every single `MapLine` connects two location coordinates through a straight line. The start coordinate is set to `MapLine.From` property and the end coordinate is set to `MapLine.To` property.

{% tabs %}

{% highlight xaml %}

<map:SfMaps>
    <map:SfMaps.Layer>
        <map:MapShapeLayer ShapesSource="https://cdn.syncfusion.com/maps/map-data/world-map.json"
                           ShapeStroke="DarkGrey">
            <map:MapShapeLayer.Sublayers>
                <map:MapLineLayer>
                    <map:MapLineLayer.Lines>
                        <map:MapLine>
                            <map:MapLine.From>
                                <map:MapLatLng Latitude="77.1025"
                                               Longitude="28.7041" />
                            </map:MapLine.From>
                            <map:MapLine.To>
                                <map:MapLatLng Latitude="-106.3468"
                                               Longitude="56.1304" />
                            </map:MapLine.To>
                        </map:MapLine>
                        <map:MapLine>
                            <map:MapLine.From>
                                <map:MapLatLng Latitude="77.1025"
                                               Longitude="28.7041" />
                            </map:MapLine.From>
                            <map:MapLine.To>
                                <map:MapLatLng Latitude="-75.0152"
                                               Longitude="-9.1900" />
                            </map:MapLine.To>
                        </map:MapLine>
                        <map:MapLine">
                            <map:MapLine.From>
                                <map:MapLatLng Latitude="77.1025"
                                               Longitude="28.7041" />
                            </map:MapLine.From>
                            <map:MapLine.To>
                                <map:MapLatLng Latitude="105.3188"
                                               Longitude="61.5240" />
                            </map:MapLine.To>
                        </map:MapLine>
                        <map:MapLine>
                            <map:MapLine.From>
                                <map:MapLatLng Latitude="77.1025"
                                               Longitude="28.7041" />
                            </map:MapLine.From>
                            <map:MapLine.To>
                                <map:MapLatLng Latitude="133.7751"
                                               Longitude="-25.2744" />
                            </map:MapLine.To>
                        </map:MapLine>
                    </map:MapLineLayer.Lines>
                </map:MapLineLayer>
            </map:MapShapeLayer.Sublayers>
        </map:MapShapeLayer>
    </map:SfMaps.Layer>
</map:SfMaps>

{% endhighlight %}

{% highlight c# %}

 SfMaps maps = new SfMaps();
 MapShapeLayer layer = new MapShapeLayer();
 layer.ShapesSource = MapSource.FromUri(new Uri("https://cdn.syncfusion.com/maps/map-data/world-map.json"));
 layer.ShapeStroke = Brush.DarkGrey;
 MapLineLayer mapLineLayer = new MapLineLayer();
 MapLine line1 = new MapLine();
 line1.From = new MapLatLng(77.1025, 28.7041);
 line1.To = new MapLatLng(-106.3468, 56.1304);
 line1.Stroke = Color.FromRgb(138, 138, 138);
 MapLine line2 = new MapLine();
 line2.From = new MapLatLng(77.1025, 28.7041);
 line2.To = new MapLatLng(-75.0152, -9.1900);
 line2.Stroke = Color.FromRgb(138, 138, 138);
 MapLine line3 = new MapLine();
 line3.From = new MapLatLng(77.1025, 28.7041);
 line3.To = new MapLatLng(105.3188, 61.5240);
 line3.Stroke = Color.FromRgb(138, 138, 138);
 MapLine line4 = new MapLine();
 line4.From = new MapLatLng(77.1025, 28.7041);
 line4.To = new MapLatLng(133.7751, -25.2744);
 line4.Stroke = Color.FromRgb(138, 138, 138);
 mapLineLayer.Lines.Add(line1);
 mapLineLayer.Lines.Add(line2);
 mapLineLayer.Lines.Add(line3);
 mapLineLayer.Lines.Add(line4);
 layer.Sublayers.Add(mapLineLayer);
 maps.Layer = layer;
 this.Content = maps;

{% endhighlight %}

{% endtabs %}

![Default line shape](images/line-layer/default_line_shape.png)

## Stroke

You can apply stroke colors to each `MapLine` in the `Lines` collection using the individual `MapLine.Stroke` property.

{% tabs %}

{% highlight xaml %}

<map:SfMaps>
    <map:SfMaps.Layer>
        <map:MapShapeLayer ShapesSource="https://cdn.syncfusion.com/maps/map-data/world-map.json"
                           ShapeStroke="DarkGrey">
            <map:MapShapeLayer.Sublayers>
                <map:MapLineLayer>
                    <map:MapLineLayer.Lines>
                        <map:MapLine StrokeThickness="2"
                                     Stroke="#ed4a47">
                            <map:MapLine.From>
                                <map:MapLatLng Latitude="77.1025"
                                               Longitude="28.7041" />
                            </map:MapLine.From>
                            <map:MapLine.To>
                                <map:MapLatLng Latitude="-106.3468"
                                               Longitude="56.1304" />
                            </map:MapLine.To>
                        </map:MapLine>
                        <map:MapLine StrokeThickness="2"
                                     Stroke="#724df6">
                            <map:MapLine.From>
                                <map:MapLatLng Latitude="77.1025"
                                               Longitude="28.7041" />
                            </map:MapLine.From>
                            <map:MapLine.To>
                                <map:MapLatLng Latitude="-75.0152"
                                               Longitude="-9.1900" />
                            </map:MapLine.To>
                        </map:MapLine>
                        <map:MapLine StrokeThickness="2"
                                     Stroke="#3e8af5">
                            <map:MapLine.From>
                                <map:MapLatLng Latitude="77.1025"
                                               Longitude="28.7041" />
                            </map:MapLine.From>
                            <map:MapLine.To>
                                <map:MapLatLng Latitude="105.3188"
                                               Longitude="61.5240" />
                            </map:MapLine.To>
                        </map:MapLine>
                        <map:MapLine StrokeThickness="2"
                                     Stroke="#439386">
                            <map:MapLine.From>
                                <map:MapLatLng Latitude="77.1025"
                                               Longitude="28.7041" />
                            </map:MapLine.From>
                            <map:MapLine.To>
                                <map:MapLatLng Latitude="133.7751"
                                               Longitude="-25.2744" />
                            </map:MapLine.To>
                        </map:MapLine>
                    </map:MapLineLayer.Lines>
                </map:MapLineLayer>
            </map:MapShapeLayer.Sublayers>
        </map:MapShapeLayer>
    </map:SfMaps.Layer>
</map:SfMaps>

{% endhighlight %}

{% highlight c# %}

SfMaps maps = new SfMaps();
MapShapeLayer layer = new MapShapeLayer();
layer.ShapesSource = MapSource.FromUri(new Uri("https://cdn.syncfusion.com/maps/map-data/world-map.json"));
layer.ShapeStroke = Brush.DarkGrey;
MapLineLayer mapLineLayer = new MapLineLayer();
MapLine line1 = new MapLine();
line1.From = new MapLatLng(77.1025, 28.7041);
line1.To = new MapLatLng(-106.3468, 56.1304);
line1.Stroke = Color.FromRgb(237, 74, 71);
MapLine line2 = new MapLine();
line2.From = new MapLatLng(77.1025, 28.7041);
line2.To = new MapLatLng(-75.0152, -9.1900);
line2.Stroke = Color.FromRgb(114, 77, 246);
MapLine line3 = new MapLine();
line3.From = new MapLatLng(77.1025, 28.7041);
line3.To = new MapLatLng(105.3188, 61.5240);
line3.Stroke = Color.FromRgb(62, 138, 245);
MapLine line4 = new MapLine();
line4.From = new MapLatLng(77.1025, 28.7041);
line4.To = new MapLatLng(133.7751, -25.2744);
line4.Stroke = Color.FromRgb(67, 147, 134);
mapLineLayer.Lines.Add(line1);
mapLineLayer.Lines.Add(line2);
mapLineLayer.Lines.Add(line3);
mapLineLayer.Lines.Add(line4);
layer.Sublayers.Add(mapLineLayer);
maps.Layer = layer;
this.Content = maps;

{% endhighlight %}

{% endtabs %}

![Line shape color](images/line-layer/line_shape_color.png)

## Thickness

You can apply thickness to each `MapLine` in the `Lines` collection using the individual `MapLine.StrokeThickness` property. The default value of the `MapLine.StrokeThickness` property is `2`.

{% tabs %}

{% highlight xaml %}

<map:SfMaps>
    <map:SfMaps.Layer>
        <map:MapShapeLayer ShapesSource="https://cdn.syncfusion.com/maps/map-data/world-map.json"
                           ShapeStroke="DarkGrey">
            <map:MapShapeLayer.Sublayers>
                <map:MapLineLayer>
                    <map:MapLineLayer.Lines>
                        <map:MapLine StrokeThickness="2"
                                     Stroke="#8a8a8a">
                            <map:MapLine.From>
                                <map:MapLatLng Latitude="77.1025"
                                               Longitude="28.7041" />
                            </map:MapLine.From>
                            <map:MapLine.To>
                                <map:MapLatLng Latitude="-106.3468"
                                               Longitude="56.1304" />
                            </map:MapLine.To>
                        </map:MapLine>
                        <map:MapLine StrokeThickness="4"
                                     Stroke="#8a8a8a">
                            <map:MapLine.From>
                                <map:MapLatLng Latitude="77.1025"
                                               Longitude="28.7041" />
                            </map:MapLine.From>
                            <map:MapLine.To>
                                <map:MapLatLng Latitude="-75.0152"
                                               Longitude="-9.1900" />
                            </map:MapLine.To>
                        </map:MapLine>
                        <map:MapLine StrokeThickness="5"
                                     Stroke="#8a8a8a">
                            <map:MapLine.From>
                                <map:MapLatLng Latitude="77.1025"
                                               Longitude="28.7041" />
                            </map:MapLine.From>
                            <map:MapLine.To>
                                <map:MapLatLng Latitude="105.3188"
                                               Longitude="61.5240" />
                            </map:MapLine.To>
                        </map:MapLine>
                        <map:MapLine StrokeThickness="6"
                                     Stroke="#8a8a8a">
                            <map:MapLine.From>
                                <map:MapLatLng Latitude="77.1025"
                                               Longitude="28.7041" />
                            </map:MapLine.From>
                            <map:MapLine.To>
                                <map:MapLatLng Latitude="133.7751"
                                               Longitude="-25.2744" />
                            </map:MapLine.To>
                        </map:MapLine>
                    </map:MapLineLayer.Lines>
                </map:MapLineLayer>
            </map:MapShapeLayer.Sublayers>
        </map:MapShapeLayer>
    </map:SfMaps.Layer>
</map:SfMaps>

{% endhighlight %}

{% highlight c# %}

SfMaps maps = new SfMaps();
MapShapeLayer layer = new MapShapeLayer();
layer.ShapesSource = MapSource.FromUri(new Uri("https://cdn.syncfusion.com/maps/map-data/world-map.json"));
layer.ShapeStroke = Brush.DarkGrey;
MapLineLayer mapLineLayer = new MapLineLayer();
MapLine line1 = new MapLine();
line1.From = new MapLatLng(77.1025, 28.7041);
line1.To = new MapLatLng(-106.3468, 56.1304);
line1.Stroke = Color.FromRgb(138, 138, 138);
line1.StrokeThickness = 2;
MapLine line2 = new MapLine();
line2.From = new MapLatLng(77.1025, 28.7041);
line2.To = new MapLatLng(-75.0152, -9.1900);
line2.Stroke = Color.FromRgb(138, 138, 138);
line2.StrokeThickness = 4;
MapLine line3 = new MapLine();
line3.From = new MapLatLng(77.1025, 28.7041);
line3.To = new MapLatLng(105.3188, 61.5240);
line3.Stroke = Color.FromRgb(138, 138, 138);
line3.StrokeThickness = 5;
MapLine line4 = new MapLine();
line4.From = new MapLatLng(77.1025, 28.7041);
line4.To = new MapLatLng(133.7751, -25.2744);
line4.Stroke = Color.FromRgb(138, 138, 138);
line4.StrokeThickness = 6;
mapLineLayer.Lines.Add(line1);
mapLineLayer.Lines.Add(line2);
mapLineLayer.Lines.Add(line3);
mapLineLayer.Lines.Add(line4);
layer.Sublayers.Add(mapLineLayer);
maps.Layer = layer;
this.Content = maps;

{% endhighlight %}

{% endtabs %}

![Line shape thickness](images/line-layer/line_shape_width.png)

## Stroke cap

You can apply stroke cap to each `MapLine` in the `Lines` collection using the individual `MapLine.StrokeLineCap` property. The default value of the `MapLineLayer.StrokeLineCap` property is `StrokeLineCap.Butt`. The available values are `Butt`, `Round`, and `Square`.

{% tabs %}

{% highlight xaml %}

<map:SfMaps>
    <map:SfMaps.Layer>
        <map:MapShapeLayer ShapesSource="https://cdn.syncfusion.com/maps/map-data/world-map.json"
                           ShapeStroke="DarkGrey">
            <map:MapShapeLayer.Sublayers>
                <map:MapLineLayer>
                    <map:MapLineLayer.Lines>
                        <map:MapLine StrokeThickness="2"
                                     Stroke="#8a8a8a" 
                                     StrokeLineCap="Round">
                            <map:MapLine.From>
                                <map:MapLatLng Latitude="77.1025"
                                               Longitude="28.7041" />
                            </map:MapLine.From>
                            <map:MapLine.To>
                                <map:MapLatLng Latitude="-106.3468"
                                               Longitude="56.1304" />
                            </map:MapLine.To>
                        </map:MapLine>
                        <map:MapLine StrokeThickness="4"
                                     Stroke="#8a8a8a"
                                     StrokeLineCap="Round">
                            <map:MapLine.From>
                                <map:MapLatLng Latitude="77.1025"
                                               Longitude="28.7041" />
                            </map:MapLine.From>
                            <map:MapLine.To>
                                <map:MapLatLng Latitude="-75.0152"
                                               Longitude="-9.1900" />
                            </map:MapLine.To>
                        </map:MapLine>
                        <map:MapLine StrokeThickness="5"
                                     Stroke="#8a8a8a"
                                     StrokeLineCap="Round">
                            <map:MapLine.From>
                                <map:MapLatLng Latitude="77.1025"
                                               Longitude="28.7041" />
                            </map:MapLine.From>
                            <map:MapLine.To>
                                <map:MapLatLng Latitude="105.3188"
                                               Longitude="61.5240" />
                            </map:MapLine.To>
                        </map:MapLine>
                        <map:MapLine StrokeThickness="6"
                                     Stroke="#8a8a8a"
                                     StrokeLineCap="Round">
                            <map:MapLine.From>
                                <map:MapLatLng Latitude="77.1025"
                                               Longitude="28.7041" />
                            </map:MapLine.From>
                            <map:MapLine.To>
                                <map:MapLatLng Latitude="133.7751"
                                               Longitude="-25.2744" />
                            </map:MapLine.To>
                        </map:MapLine>
                    </map:MapLineLayer.Lines>
                </map:MapLineLayer>
            </map:MapShapeLayer.Sublayers>
        </map:MapShapeLayer>
    </map:SfMaps.Layer>
</map:SfMaps>

{% endhighlight %}

{% highlight c# %}

SfMaps maps = new SfMaps();
MapShapeLayer layer = new MapShapeLayer();
layer.ShapesSource = MapSource.FromUri(new Uri("https://cdn.syncfusion.com/maps/map-data/world-map.json"));
layer.ShapeStroke = Brush.DarkGrey;
MapLineLayer mapLineLayer = new MapLineLayer();
MapLine line1 = new MapLine();
line1.From = new MapLatLng(77.1025, 28.7041);
line1.To = new MapLatLng(-106.3468, 56.1304);
line1.Stroke = Color.FromRgb(138, 138, 138);
line1.StrokeThickness = 2;
line1.StrokeLineCap = LineCap.Round;
MapLine line2 = new MapLine();
line2.From = new MapLatLng(77.1025, 28.7041);
line2.To = new MapLatLng(-75.0152, -9.1900);
line2.Stroke = Color.FromRgb(138, 138, 138);
line2.StrokeThickness = 4;
line1.StrokeLineCap = LineCap.Round;
MapLine line3 = new MapLine();
line3.From = new MapLatLng(77.1025, 28.7041);
line3.To = new MapLatLng(105.3188, 61.5240);
line3.Stroke = Color.FromRgb(138, 138, 138);
line3.StrokeThickness = 5;
line1.StrokeLineCap = LineCap.Round;
MapLine line4 = new MapLine();
line4.From = new MapLatLng(77.1025, 28.7041);
line4.To = new MapLatLng(133.7751, -25.2744);
line4.Stroke = Color.FromRgb(138, 138, 138);
line4.StrokeThickness = 6;
line1.StrokeLineCap = LineCap.Round;
mapLineLayer.Lines.Add(line1);
mapLineLayer.Lines.Add(line2);
mapLineLayer.Lines.Add(line3);
mapLineLayer.Lines.Add(line4);
layer.Sublayers.Add(mapLineLayer);
maps.Layer = layer;
this.Content = maps;

{% endhighlight %}

{% endtabs %}

![Line stroke cap](images/line-layer/line_stroke_cap.png)

## Dash array

You can apply dash support for the line using the `MapLine.dashArray` property.

A sequence of dash and gap will be rendered based on the values in this list. Once all values of the list is rendered, it will be repeated again till the end of the line.

{% tabs %}

{% highlight xaml %}

<map:SfMaps>
    <map:SfMaps.Layer>
        <map:MapShapeLayer ShapesSource="https://cdn.syncfusion.com/maps/map-data/world-map.json"
                           ShapeStroke="DarkGrey">
            <map:MapShapeLayer.Sublayers>
                <map:MapLineLayer>
                    <map:MapLineLayer.Lines>
                        <map:MapLine Stroke="#3d9bf2" >
                            <map:MapLine.From>
                                <map:MapLatLng Latitude="77.1025"
                                               Longitude="28.7041" />
                            </map:MapLine.From>
                            <map:MapLine.To>
                                <map:MapLatLng Latitude="-106.3468"
                                               Longitude="56.1304" />
                            </map:MapLine.To>
                            <map:MapLine.StrokeDashArray>
                                <DoubleCollection>
                                    <x:Double>8</x:Double>
                                    <x:Double>4</x:Double>
                                    <x:Double>2</x:Double>
                                    <x:Double>4</x:Double>
                                </DoubleCollection>
                            </map:MapLine.StrokeDashArray>
                        </map:MapLine>
                        <map:MapLine Stroke="#3d9bf2">
                            <map:MapLine.From>
                                <map:MapLatLng Latitude="77.1025"
                                               Longitude="28.7041" />
                            </map:MapLine.From>
                            <map:MapLine.To>
                                <map:MapLatLng Latitude="-75.0152"
                                               Longitude="-9.1900" />
                            </map:MapLine.To>
                            <map:MapLine.StrokeDashArray>
                                <DoubleCollection>
                                    <x:Double>8</x:Double>
                                    <x:Double>4</x:Double>
                                    <x:Double>2</x:Double>
                                    <x:Double>4</x:Double>
                                </DoubleCollection>
                            </map:MapLine.StrokeDashArray>
                        </map:MapLine>
                        <map:MapLine Stroke="#3d9bf2">
                            <map:MapLine.From>
                                <map:MapLatLng Latitude="77.1025"
                                               Longitude="28.7041" />
                            </map:MapLine.From>
                            <map:MapLine.To>
                                <map:MapLatLng Latitude="105.3188"
                                               Longitude="61.5240" />
                            </map:MapLine.To>
                            <map:MapLine.StrokeDashArray>
                                <DoubleCollection>
                                    <x:Double>8</x:Double>
                                    <x:Double>4</x:Double>
                                    <x:Double>2</x:Double>
                                    <x:Double>4</x:Double>
                                </DoubleCollection>
                            </map:MapLine.StrokeDashArray>
                        </map:MapLine>
                        <map:MapLine Stroke="#3d9bf2">
                            <map:MapLine.From>
                                <map:MapLatLng Latitude="77.1025"
                                               Longitude="28.7041" />
                            </map:MapLine.From>
                            <map:MapLine.To>
                                <map:MapLatLng Latitude="133.7751"
                                               Longitude="-25.2744" />
                            </map:MapLine.To>
                            <map:MapLine.StrokeDashArray>
                                <DoubleCollection>
                                    <x:Double>8</x:Double>
                                    <x:Double>4</x:Double>
                                    <x:Double>2</x:Double>
                                    <x:Double>4</x:Double>
                                </DoubleCollection>
                            </map:MapLine.StrokeDashArray>
                        </map:MapLine>
                    </map:MapLineLayer.Lines>
                </map:MapLineLayer>
            </map:MapShapeLayer.Sublayers>
        </map:MapShapeLayer>
    </map:SfMaps.Layer>
</map:SfMaps>

{% endhighlight %}

{% highlight c# %}

SfMaps maps = new SfMaps();
MapShapeLayer layer = new MapShapeLayer();
layer.ShapesSource = MapSource.FromUri(new Uri("https://cdn.syncfusion.com/maps/map-data/world-map.json"));
layer.ShapeStroke = Brush.DarkGrey;
MapLineLayer mapLineLayer = new MapLineLayer();
MapLine line1 = new MapLine();
line1.From = new MapLatLng(77.1025, 28.7041);
line1.To = new MapLatLng(-106.3468, 56.1304);
line1.Stroke = Color.FromRgb(61, 155, 242);
line1.StrokeThickness = 2;
line1.StrokeDashArray = new double[] { 8, 4, 2, 4 };
line1.StrokeLineCap = LineCap.Round;
MapLine line2 = new MapLine();
line2.From = new MapLatLng(77.1025, 28.7041);
line2.To = new MapLatLng(-75.0152, -9.1900);
line2.Stroke = Color.FromRgb(61, 155, 242);
line2.StrokeDashArray = new double[] { 8, 4, 2, 4 };
MapLine line3 = new MapLine();
line3.From = new MapLatLng(77.1025, 28.7041);
line3.To = new MapLatLng(105.3188, 61.5240);
line3.Stroke = Color.FromRgb(61, 155, 242);
line3.StrokeDashArray = new double[] { 8, 4, 2, 4 };
MapLine line4 = new MapLine();
line4.From = new MapLatLng(77.1025, 28.7041);
line4.To = new MapLatLng(133.7751, -25.2744);
line4.Stroke = Color.FromRgb(61, 155, 242);
line4.StrokeDashArray = new double[] { 8, 4, 2, 4 };
mapLineLayer.Lines.Add(line1);
mapLineLayer.Lines.Add(line2);
mapLineLayer.Lines.Add(line3);
mapLineLayer.Lines.Add(line4);
layer.Sublayers.Add(mapLineLayer);
maps.Layer = layer;
this.Content = maps;

{% endhighlight %}

{% endtabs %}

![Line shape dash array](images/line-layer/line_shape_dash_array.png)
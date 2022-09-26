---
layout: post
title: Adding Circle Layer in Maps control | Syncfusion
description: Learn here all about adding Circle Layer feature of Syncfusion .NET MAUI Maps (SfMaps) control to customize their appearances and more.
platform: MAUI
control: SfMaps
documentation: ug
---

# Circle Layer in .NET MAUI Maps (SfMaps)

Circle layer is a sublayer that renders a group of `MapCircle` on `MapShapeLayer`. This section helps to learn about how to add the circles and customize them.

## Adding circles

The `Circles` is a collection of `MapCircle`. Every single `MapCircle` renders a circle using the `MapCircle.Center` and `MapCircle.Radius` properties.

{% tabs %}

{% highlight xaml %}

<map:SfMaps>
    <map:SfMaps.Layer>
        <map:MapShapeLayer ShapesSource="https://cdn.syncfusion.com/maps/map-data/india.json"
                           ShapeStroke="DarkGrey">
            <map:MapShapeLayer.Sublayers>
                <map:MapCircleLayer>
                    <map:MapCircleLayer.Circles>
                        <map:MapCircle>
                            <map:MapCircle.Center>
                                <map:MapLatLng Latitude="74.1240"
                                               Longitude="15.2993" />
                            </map:MapCircle.Center>
                        </map:MapCircle>
                        <map:MapCircle>
                            <map:MapCircle.Center>
                                <map:MapLatLng Latitude="80.0499"
                                               Longitude="15.5057" />
                            </map:MapCircle.Center>
                        </map:MapCircle>
                        <map:MapCircle>
                            <map:MapCircle.Center>
                                <map:MapLatLng Latitude="75.7139"
                                               Longitude="19.7515" />
                            </map:MapCircle.Center>
                        </map:MapCircle>
                        <map:MapCircle>
                            <map:MapCircle.Center>
                                <map:MapLatLng Latitude="72.5714"
                                               Longitude="23.0225" />
                            </map:MapCircle.Center>
                        </map:MapCircle>
                        <map:MapCircle>
                            <map:MapCircle.Center>
                                <map:MapLatLng Latitude="74.2179"
                                               Longitude="27.0238" />
                            </map:MapCircle.Center>
                        </map:MapCircle>
                        <map:MapCircle>
                            <map:MapCircle.Center>
                                <map:MapLatLng Latitude="80.9462"
                                               Longitude="26.8467" />
                            </map:MapCircle.Center>
                        </map:MapCircle>
                        <map:MapCircle>
                            <map:MapCircle.Center>
                                <map:MapLatLng Latitude="85.2799"
                                               Longitude="21.2787" />
                            </map:MapCircle.Center>
                        </map:MapCircle>
                    </map:MapCircleLayer.Circles>
                </map:MapCircleLayer>
            </map:MapShapeLayer.Sublayers>
        </map:MapShapeLayer>
    </map:SfMaps.Layer>
</map:SfMaps>

{% endhighlight %}

{% highlight c# %}

SfMaps maps = new SfMaps();
MapShapeLayer layer = new MapShapeLayer();
layer.ShapesSource = MapSource.FromUri(new Uri("https://cdn.syncfusion.com/maps/map-data/india.json"));
layer.ShapeStroke = Brush.DarkGray;
MapCircleLayer circleLayer = new MapCircleLayer();
MapCircle circle1 = new MapCircle();
circle1.Center = new MapLatLng(74.1240, 15.2993);
MapCircle circle2 = new MapCircle();
circle2.Center = new MapLatLng(80.0499, 15.5057);
MapCircle circle3 = new MapCircle();
circle3.Center = new MapLatLng(75.7139, 19.7515);
MapCircle circle4 = new MapCircle();
circle4.Center = new MapLatLng(72.5714, 23.0225);
MapCircle circle5 = new MapCircle();
circle5.Center = new MapLatLng(74.2179, 27.0238);
MapCircle circle6 = new MapCircle();
circle6.Center = new MapLatLng(80.9462, 26.8467);
MapCircle circle7 = new MapCircle();
circle7.Center = new MapLatLng(85.2799, 21.2787);
circleLayer.Circles.Add(circle1);
circleLayer.Circles.Add(circle2);
circleLayer.Circles.Add(circle3);
circleLayer.Circles.Add(circle4);
circleLayer.Circles.Add(circle5);
circleLayer.Circles.Add(circle6);
circleLayer.Circles.Add(circle7);
layer.Sublayers.Add(circleLayer);
maps.Layer = layer;
this.Content = maps;

{% endhighlight %}

{% endtabs %}

![Default circle shape](images/circle-layer/default-circle-shape.png)

## Radius

You can change the size of the circles using the `MapCircle.Radius` property. The default value of the `MapCircle.Radius` property is 5.

{% tabs %}

{% highlight xaml %}

<map:SfMaps>
    <map:SfMaps.Layer>
        <map:MapShapeLayer ShapesSource="https://cdn.syncfusion.com/maps/map-data/india.json"
                           ShapeStroke="DarkGrey">
            <map:MapShapeLayer.Sublayers>
                <map:MapCircleLayer>
                    <map:MapCircleLayer.Circles>
                        <map:MapCircle Radius="10">
                            <map:MapCircle.Center>
                                <map:MapLatLng Latitude="74.1240"
                                               Longitude="15.2993" />
                            </map:MapCircle.Center>
                        </map:MapCircle>
                        <map:MapCircle Radius="10">
                            <map:MapCircle.Center>
                                <map:MapLatLng Latitude="80.0499"
                                               Longitude="15.5057" />
                            </map:MapCircle.Center>
                        </map:MapCircle>
                        <map:MapCircle Radius="10">
                            <map:MapCircle.Center>
                                <map:MapLatLng Latitude="75.7139"
                                               Longitude="19.7515" />
                            </map:MapCircle.Center>
                        </map:MapCircle>
                        <map:MapCircle Radius="10">
                            <map:MapCircle.Center>
                                <map:MapLatLng Latitude="72.5714"
                                               Longitude="23.0225" />
                            </map:MapCircle.Center>
                        </map:MapCircle>
                        <map:MapCircle Radius="10">
                            <map:MapCircle.Center>
                                <map:MapLatLng Latitude="74.2179"
                                               Longitude="27.0238" />
                            </map:MapCircle.Center>
                        </map:MapCircle>
                        <map:MapCircle Radius="10">
                            <map:MapCircle.Center>
                                <map:MapLatLng Latitude="80.9462"
                                               Longitude="26.8467" />
                            </map:MapCircle.Center>
                        </map:MapCircle>
                        <map:MapCircle Radius="10">
                            <map:MapCircle.Center>
                                <map:MapLatLng Latitude="85.2799"
                                               Longitude="21.2787" />
                            </map:MapCircle.Center>
                        </map:MapCircle>
                    </map:MapCircleLayer.Circles>
                </map:MapCircleLayer>
            </map:MapShapeLayer.Sublayers>
        </map:MapShapeLayer>
    </map:SfMaps.Layer>
</map:SfMaps>

{% endhighlight %}

{% highlight c# %}

SfMaps maps = new SfMaps();
MapShapeLayer layer = new MapShapeLayer();
layer.ShapesSource = MapSource.FromUri(new Uri("https://cdn.syncfusion.com/maps/map-data/india.json"));
layer.ShapeStroke = Brush.DarkGray;
MapCircleLayer circleLayer = new MapCircleLayer();
MapCircle circle1 = new MapCircle();
circle1.Center = new MapLatLng(74.1240, 15.2993);
circle1.Radius = 10;
MapCircle circle2 = new MapCircle();
circle2.Center = new MapLatLng(80.0499, 15.5057);
circle2.Radius = 10;
MapCircle circle3 = new MapCircle();
circle3.Center = new MapLatLng(75.7139, 19.7515);
circle3.Radius = 10;
MapCircle circle4 = new MapCircle();
circle4.Center = new MapLatLng(72.5714, 23.0225);
circle4.Radius = 10;
MapCircle circle5 = new MapCircle();
circle5.Center = new MapLatLng(74.2179, 27.0238);
circle5.Radius = 10;
MapCircle circle6 = new MapCircle();
circle6.Center = new MapLatLng(80.9462, 26.8467);
circle6.Radius = 10;
MapCircle circle7 = new MapCircle();
circle7.Center = new MapLatLng(85.2799, 21.2787);
circle7.Radius = 10;
circleLayer.Circles.Add(circle1);
circleLayer.Circles.Add(circle2);
circleLayer.Circles.Add(circle3);
circleLayer.Circles.Add(circle4);
circleLayer.Circles.Add(circle5);
circleLayer.Circles.Add(circle6);
circleLayer.Circles.Add(circle7);
layer.Sublayers.Add(circleLayer);
maps.Layer = layer;
this.Content = maps;

{% endhighlight %}

{% endtabs %}

![Circle radius](images/circle-layer/circle-radius.png)

## Fill color

You can apply colors to each `MapCircle` in the `Circles` collection using the individual `MapCircle.Fill` property.

{% tabs %}

{% highlight xaml %}

<map:SfMaps>
    <map:SfMaps.Layer>
        <map:MapShapeLayer ShapesSource="https://cdn.syncfusion.com/maps/map-data/india.json"
                           ShapeStroke="DarkGrey">
            <map:MapShapeLayer.Sublayers>
                <map:MapCircleLayer>
                    <map:MapCircleLayer.Circles>
                        <map:MapCircle Radius="10"
                                       Fill="#ea3c62">
                            <map:MapCircle.Center>
                                <map:MapLatLng Latitude="74.1240"
                                               Longitude="15.2993" />
                            </map:MapCircle.Center>
                        </map:MapCircle>
                        <map:MapCircle Radius="10"
                                       Fill="Teal">
                            <map:MapCircle.Center>
                                <map:MapLatLng Latitude="80.0499"
                                               Longitude="15.5057" />
                            </map:MapCircle.Center>
                        </map:MapCircle>
                        <map:MapCircle Radius="10"
                                       Fill="#9c3bb0">
                            <map:MapCircle.Center>
                                <map:MapLatLng Latitude="75.7139"
                                               Longitude="19.7515" />
                            </map:MapCircle.Center>
                        </map:MapCircle>
                        <map:MapCircle Radius="10"
                                       Fill="#50af50">
                            <map:MapCircle.Center>
                                <map:MapLatLng Latitude="72.5714"
                                               Longitude="23.0225" />
                            </map:MapCircle.Center>
                        </map:MapCircle>
                        <map:MapCircle Radius="10"
                                       Fill="#3195ec">
                            <map:MapCircle.Center>
                                <map:MapLatLng Latitude="74.2179"
                                               Longitude="27.0238" />
                            </map:MapCircle.Center>
                        </map:MapCircle>
                        <map:MapCircle Radius="10"
                                       Fill="#e157f9">
                            <map:MapCircle.Center>
                                <map:MapLatLng Latitude="80.9462"
                                               Longitude="26.8467" />
                            </map:MapCircle.Center>
                        </map:MapCircle>
                        <map:MapCircle Radius="10"
                                       Fill="#ee4e4e">
                            <map:MapCircle.Center>
                                <map:MapLatLng Latitude="85.2799"
                                               Longitude="21.2787" />
                            </map:MapCircle.Center>
                        </map:MapCircle>
                    </map:MapCircleLayer.Circles>
                </map:MapCircleLayer>
            </map:MapShapeLayer.Sublayers>
        </map:MapShapeLayer>
    </map:SfMaps.Layer>
</map:SfMaps>

{% endhighlight %}

{% highlight c# %}

SfMaps maps = new SfMaps();
MapShapeLayer layer = new MapShapeLayer();
layer.ShapesSource = MapSource.FromUri(new Uri("https://cdn.syncfusion.com/maps/map-data/india.json"));
layer.ShapeStroke = Brush.DarkGray;
MapCircleLayer circleLayer = new MapCircleLayer();
MapCircle circle1 = new MapCircle();
circle1.Center = new MapLatLng(74.1240, 15.2993);
circle1.Radius = 10;
circle1.Fill = Color.FromRgb(234, 60, 98);
MapCircle circle2 = new MapCircle();
circle2.Center = new MapLatLng(80.0499, 15.5057);
circle2.Radius = 10;
circle2.Fill = Colors.Teal;
MapCircle circle3 = new MapCircle();
circle3.Center = new MapLatLng(75.7139, 19.7515);
circle3.Radius = 10;
circle3.Fill = Color.FromRgb(156, 59, 176);
MapCircle circle4 = new MapCircle();
circle4.Center = new MapLatLng(72.5714, 23.0225);
circle4.Radius = 10;
circle4.Fill = Color.FromRgb(80, 175, 80);
MapCircle circle5 = new MapCircle();
circle5.Center = new MapLatLng(74.2179, 27.0238);
circle5.Radius = 10;
circle5.Fill = Color.FromRgb(49, 149, 236);
MapCircle circle6 = new MapCircle();
circle6.Center = new MapLatLng(80.9462, 26.8467);
circle6.Radius = 10;
circle6.Fill = Color.FromRgb(225, 87, 249);
MapCircle circle7 = new MapCircle();
circle7.Center = new MapLatLng(85.2799, 21.2787);
circle7.Radius = 10;
circle7.Fill = Color.FromRgb(238, 78, 78);
circleLayer.Circles.Add(circle1);
circleLayer.Circles.Add(circle2);
circleLayer.Circles.Add(circle3);
circleLayer.Circles.Add(circle4);
circleLayer.Circles.Add(circle5);
circleLayer.Circles.Add(circle6);
circleLayer.Circles.Add(circle7);
layer.Sublayers.Add(circleLayer);
maps.Layer = layer;
this.Content = maps;

{% endhighlight %}

{% endtabs %}

![Circle color](images/circle-layer/circle-color.png)

## Stroke and stroke thickness

You can apply stroke thickness to each `MapCircle` in the `Circles` collection using the individual `MapCircle.StrokeThickness` property. The default value of the `MapCircleLayer.StrokeThickness` property is `2`.

You can apply stroke color to each `MapCircle` in the `Circles` collection using the individual `MapCircle.Stroke` property.

{% tabs %}

{% highlight xaml %}

<map:SfMaps>
    <map:SfMaps.Layer>
        <map:MapShapeLayer ShapesSource="https://cdn.syncfusion.com/maps/map-data/india.json"
                           ShapeStroke="DarkGrey">
            <map:MapShapeLayer.Sublayers>
                <map:MapCircleLayer>
                    <map:MapCircleLayer.Circles>
                        <map:MapCircle Radius="10"
                                       Stroke="#ea3c62"
                                       StrokeThickness="3">
                            <map:MapCircle.Center>
                                <map:MapLatLng Latitude="74.1240"
                                               Longitude="15.2993" />
                            </map:MapCircle.Center>
                        </map:MapCircle>
                        <map:MapCircle Radius="20"
                                       Stroke="Teal"
                                       StrokeThickness="3">
                            <map:MapCircle.Center>
                                <map:MapLatLng Latitude="80.0499"
                                               Longitude="15.5057" />
                            </map:MapCircle.Center>
                        </map:MapCircle>
                        <map:MapCircle Radius="10"
                                       Stroke="#9c3bb0"
                                       StrokeThickness="3">
                            <map:MapCircle.Center>
                                <map:MapLatLng Latitude="75.7139"
                                               Longitude="19.7515" />
                            </map:MapCircle.Center>
                        </map:MapCircle>
                        <map:MapCircle Radius="20"
                                       Stroke="#50af50"
                                       StrokeThickness="3">
                            <map:MapCircle.Center>
                                <map:MapLatLng Latitude="72.5714"
                                               Longitude="23.0225" />
                            </map:MapCircle.Center>
                        </map:MapCircle>
                        <map:MapCircle Radius="20"
                                       Stroke="#3195ec"
                                       StrokeThickness="3">
                            <map:MapCircle.Center>
                                <map:MapLatLng Latitude="74.2179"
                                               Longitude="27.0238" />
                            </map:MapCircle.Center>
                        </map:MapCircle>
                        <map:MapCircle Radius="10"
                                       Stroke="#e157f9"
                                       StrokeThickness="3">
                            <map:MapCircle.Center>
                                <map:MapLatLng Latitude="80.9462"
                                               Longitude="26.8467" />
                            </map:MapCircle.Center>
                        </map:MapCircle>
                        <map:MapCircle Radius="20"
                                       Stroke="#ee4e4e"
                                       StrokeThickness="3">
                            <map:MapCircle.Center>
                                <map:MapLatLng Latitude="85.2799"
                                               Longitude="21.2787" />
                            </map:MapCircle.Center>
                        </map:MapCircle>
                    </map:MapCircleLayer.Circles>
                </map:MapCircleLayer>
            </map:MapShapeLayer.Sublayers>
        </map:MapShapeLayer>
    </map:SfMaps.Layer>
</map:SfMaps>

{% endhighlight %}

{% highlight c# %}
SfMaps maps = new SfMaps();
MapShapeLayer layer = new MapShapeLayer();
layer.ShapesSource = MapSource.FromUri(new Uri("https://cdn.syncfusion.com/maps/map-data/india.json"));
layer.ShapeStroke = Brush.DarkGray;
MapCircleLayer circleLayer = new MapCircleLayer();
MapCircle circle1 = new MapCircle();
circle1.Center = new MapLatLng(74.1240, 15.2993);
circle1.Radius = 10;
circle1.Stroke = Color.FromRgb(234, 60, 98);
circle1.StrokeThickness = 3;
MapCircle circle2 = new MapCircle();
circle2.Center = new MapLatLng(80.0499, 15.5057);
circle2.Radius = 20;
circle2.Stroke = Colors.Teal;
circle2.StrokeThickness = 3;
MapCircle circle3 = new MapCircle();
circle3.Center = new MapLatLng(75.7139, 19.7515);
circle3.Radius = 10;
circle3.Stroke = Color.FromRgb(156, 59, 176);
circle3.StrokeThickness = 3;
MapCircle circle4 = new MapCircle();
circle4.Center = new MapLatLng(72.5714, 23.0225);
circle4.Radius = 20;
circle4.Stroke = Color.FromRgb(80, 175, 80);
circle4.StrokeThickness = 3;
MapCircle circle5 = new MapCircle();
circle5.Center = new MapLatLng(74.2179, 27.0238);
circle5.Radius = 20;
circle5.Stroke = Color.FromRgb(49, 149, 236);
circle5.StrokeThickness = 3;
MapCircle circle6 = new MapCircle();
circle6.Center = new MapLatLng(80.9462, 26.8467);
circle6.Radius = 10;
circle6.Stroke = Color.FromRgb(225, 87, 249);
circle6.StrokeThickness = 3;
MapCircle circle7 = new MapCircle();
circle7.Center = new MapLatLng(85.2799, 21.2787);
circle7.Radius = 20;
circle7.Stroke = Color.FromRgb(238, 78, 78);
circle7.StrokeThickness = 3;
circleLayer.Circles.Add(circle1);
circleLayer.Circles.Add(circle2);
circleLayer.Circles.Add(circle3);
circleLayer.Circles.Add(circle4);
circleLayer.Circles.Add(circle5);
circleLayer.Circles.Add(circle6);
circleLayer.Circles.Add(circle7);
layer.Sublayers.Add(circleLayer);
maps.Layer = layer;
this.Content = maps;

{% endhighlight %}

{% endtabs %}

![Circle stroke color](images/circle-layer/circle-stroke-color.png)
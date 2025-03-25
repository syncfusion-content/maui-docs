---
layout: post
title: Adding Circle Layer in Maps control | Syncfusion
description: Learn here all about adding Circle Layer feature of Syncfusion .NET MAUI Maps (SfMaps) control to customize their appearances and more.
platform: MAUI
control: SfMaps
documentation: ug
---

# Circle Layer in .NET MAUI Maps (SfMaps)

Circle layer is a sublayer that renders a group of [`MapCircle`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapCircle.html) on [`MapShapeLayer`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html). This section helps to learn about how to add the circles and customize them.

## Adding circles

The [`Circles`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapCircleLayer.html#Syncfusion_Maui_Maps_MapCircleLayer_Circles) is a collection of [`MapCircle`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapCircle.html). Every single [`MapCircle`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapCircle.html) renders a circle using the [`MapCircle.Center`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapCircle.html#Syncfusion_Maui_Maps_MapCircle_Center) and [`MapCircle.Radius`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapCircle.html#Syncfusion_Maui_Maps_MapCircle_Radius) properties.

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
                                <map:MapLatLng Latitude="15.2993"
                                               Longitude="74.1240" />
                            </map:MapCircle.Center>
                        </map:MapCircle>
                        <map:MapCircle>
                            <map:MapCircle.Center>
                                <map:MapLatLng Latitude="15.5057"
                                               Longitude="80.0499" />
                            </map:MapCircle.Center>
                        </map:MapCircle>
                        <map:MapCircle>
                            <map:MapCircle.Center>
                                <map:MapLatLng Latitude="19.7515"
                                               Longitude="75.7139" />
                            </map:MapCircle.Center>
                        </map:MapCircle>
                        <map:MapCircle>
                            <map:MapCircle.Center>
                                <map:MapLatLng Latitude="23.0225"
                                               Longitude="72.5714" />
                            </map:MapCircle.Center>
                        </map:MapCircle>
                        <map:MapCircle>
                            <map:MapCircle.Center>
                                <map:MapLatLng Latitude="27.0238"
                                               Longitude="74.2179" />
                            </map:MapCircle.Center>
                        </map:MapCircle>
                        <map:MapCircle>
                            <map:MapCircle.Center>
                                <map:MapLatLng Latitude="26.8467"
                                               Longitude="80.9462" />
                            </map:MapCircle.Center>
                        </map:MapCircle>
                        <map:MapCircle>
                            <map:MapCircle.Center>
                                <map:MapLatLng Latitude="21.2787"
                                               Longitude="85.2799" />
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
circle1.Center = new MapLatLng(15.2993, 74.1240);
MapCircle circle2 = new MapCircle();
circle2.Center = new MapLatLng(15.5057, 80.0499);
MapCircle circle3 = new MapCircle();
circle3.Center = new MapLatLng(19.7515, 75.7139);
MapCircle circle4 = new MapCircle();
circle4.Center = new MapLatLng(23.0225, 72.5714);
MapCircle circle5 = new MapCircle();
circle5.Center = new MapLatLng(27.0238, 74.2179);
MapCircle circle6 = new MapCircle();
circle6.Center = new MapLatLng(26.8467, 80.9462);
MapCircle circle7 = new MapCircle();
circle7.Center = new MapLatLng(21.2787, 85.2799);
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

You can change the size of the circles using the [`MapCircle.Radius`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapCircle.html#Syncfusion_Maui_Maps_MapCircle_Radius) property. The default value of the [`MapCircle.Radius`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapCircle.html#Syncfusion_Maui_Maps_MapCircle_Radius) property is 5.

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
                                       Stroke="#309989"
                                       Fill="#309989">
                            <map:MapCircle.Center>
                                <map:MapLatLng Latitude="15.2993"
                                               Longitude="74.1240" />
                            </map:MapCircle.Center>
                        </map:MapCircle>
                        <map:MapCircle Radius="10"
                                       Stroke="#309989"
                                       Fill="#309989">
                            <map:MapCircle.Center>
                                <map:MapLatLng Latitude="15.5057"
                                               Longitude="80.0499" />
                            </map:MapCircle.Center>
                        </map:MapCircle>
                        <map:MapCircle Radius="10"
                                       Stroke="#309989"
                                       Fill="#309989">
                            <map:MapCircle.Center>
                                <map:MapLatLng Latitude="19.7515"
                                               Longitude="75.7139" />
                            </map:MapCircle.Center>
                        </map:MapCircle>
                        <map:MapCircle Radius="10"
                                       Stroke="#309989"
                                       Fill="#309989">
                            <map:MapCircle.Center>
                                <map:MapLatLng Latitude="23.0225"
                                               Longitude="72.5714" />
                            </map:MapCircle.Center>
                        </map:MapCircle>
                        <map:MapCircle Radius="10"
                                       Stroke="#309989"
                                       Fill="#309989">
                            <map:MapCircle.Center>
                                <map:MapLatLng Latitude="27.0238"
                                               Longitude="74.2179" />
                            </map:MapCircle.Center>
                        </map:MapCircle>
                        <map:MapCircle Radius="10"
                                       Stroke="#309989"
                                       Fill="#309989">
                            <map:MapCircle.Center>
                                <map:MapLatLng Latitude="26.8467"
                                               Longitude="80.9462" />
                            </map:MapCircle.Center>
                        </map:MapCircle>
                        <map:MapCircle Radius="10"
                                       Stroke="#309989"
                                       Fill="#309989">
                            <map:MapCircle.Center>
                                <map:MapLatLng Latitude="21.2787"
                                               Longitude="85.2799" />
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
circle1.Center = new MapLatLng(15.2993, 74.1240);
circle1.Radius = 10;
circle1.Stroke = Color.FromRgb(48, 153, 137);
circle1.Fill = Color.FromRgb(48, 153, 137);
MapCircle circle2 = new MapCircle();
circle2.Center = new MapLatLng(15.5057, 80.0499);
circle2.Radius = 10;
circle2.Stroke = Color.FromRgb(48, 153, 137);
circle2.Fill = Color.FromRgb(48, 153, 137);
MapCircle circle3 = new MapCircle();
circle3.Center = new MapLatLng(19.7515, 75.7139);
circle3.Radius = 10;
circle3.Stroke = Color.FromRgb(48, 153, 137);
circle3.Fill = Color.FromRgb(48, 153, 137);
MapCircle circle4 = new MapCircle();
circle4.Center = new MapLatLng(23.0225, 72.5714);
circle4.Radius = 10;
circle4.Stroke = Color.FromRgb(48, 153, 137);
circle4.Fill = Color.FromRgb(48, 153, 137);
MapCircle circle5 = new MapCircle();
circle5.Center = new MapLatLng(27.0238, 74.2179);
circle5.Radius = 10;
circle5.Stroke = Color.FromRgb(48, 153, 137);
circle5.Fill = Color.FromRgb(48, 153, 137);
MapCircle circle6 = new MapCircle();
circle6.Center = new MapLatLng(26.8467, 80.9462);
circle6.Radius = 10;
circle6.Stroke = Color.FromRgb(48, 153, 137);
circle6.Fill = Color.FromRgb(48, 153, 137);
MapCircle circle7 = new MapCircle();
circle7.Center = new MapLatLng(21.2787, 85.2799);
circle7.Radius = 10;
circle7.Stroke = Color.FromRgb(48, 153, 137);
circle7.Fill = Color.FromRgb(48, 153, 137);
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

You can apply colors to each [`MapCircle`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapCircle.html) in the [`Circles`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapCircleLayer.html#Syncfusion_Maui_Maps_MapCircleLayer_Circles) collection using the individual [`MapCircle.Fill`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapCircle.html#Syncfusion_Maui_Maps_MapCircle_Fill) property.

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
                                <map:MapLatLng Latitude="15.2993"
                                               Longitude="74.1240" />
                            </map:MapCircle.Center>
                        </map:MapCircle>
                        <map:MapCircle Radius="10"
                                       Fill="Teal">
                            <map:MapCircle.Center>
                                <map:MapLatLng Latitude="15.5057"
                                               Longitude="80.0499" />
                            </map:MapCircle.Center>
                        </map:MapCircle>
                        <map:MapCircle Radius="10"
                                       Fill="#9c3bb0">
                            <map:MapCircle.Center>
                                <map:MapLatLng Latitude="19.7515"
                                               Longitude="75.7139" />
                            </map:MapCircle.Center>
                        </map:MapCircle>
                        <map:MapCircle Radius="10"
                                       Fill="#50af50">
                            <map:MapCircle.Center>
                                <map:MapLatLng Latitude="23.0225"
                                               Longitude="72.5714" />
                            </map:MapCircle.Center>
                        </map:MapCircle>
                        <map:MapCircle Radius="10"
                                       Fill="#3195ec">
                            <map:MapCircle.Center>
                                <map:MapLatLng Latitude="27.0238"
                                               Longitude="74.2179" />
                            </map:MapCircle.Center>
                        </map:MapCircle>
                        <map:MapCircle Radius="10"
                                       Fill="#e157f9">
                            <map:MapCircle.Center>
                                <map:MapLatLng Latitude="26.8467"
                                               Longitude="80.9462" />
                            </map:MapCircle.Center>
                        </map:MapCircle>
                        <map:MapCircle Radius="10"
                                       Fill="#ee4e4e">
                            <map:MapCircle.Center>
                                <map:MapLatLng Latitude="21.2787"
                                               Longitude="85.2799" />
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
circle1.Center = new MapLatLng(15.2993, 74.1240);
circle1.Radius = 10;
circle1.Fill = Color.FromRgb(234, 60, 98);
MapCircle circle2 = new MapCircle();
circle2.Center = new MapLatLng(15.5057, 80.0499);
circle2.Radius = 10;
circle2.Fill = Colors.Teal;
MapCircle circle3 = new MapCircle();
circle3.Center = new MapLatLng(19.7515, 75.7139);
circle3.Radius = 10;
circle3.Fill = Color.FromRgb(156, 59, 176);
MapCircle circle4 = new MapCircle();
circle4.Center = new MapLatLng(23.0225, 72.5714);
circle4.Radius = 10;
circle4.Fill = Color.FromRgb(80, 175, 80);
MapCircle circle5 = new MapCircle();
circle5.Center = new MapLatLng(27.0238, 74.2179);
circle5.Radius = 10;
circle5.Fill = Color.FromRgb(49, 149, 236);
MapCircle circle6 = new MapCircle();
circle6.Center = new MapLatLng(26.8467, 80.9462);
circle6.Radius = 10;
circle6.Fill = Color.FromRgb(225, 87, 249);
MapCircle circle7 = new MapCircle();
circle7.Center = new MapLatLng(21.2787, 85.2799);
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

You can apply stroke thickness to each [`MapCircle`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapCircle.html) in the [`Circles`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapCircleLayer.html#Syncfusion_Maui_Maps_MapCircleLayer_Circles) collection using the individual [`MapCircle.StrokeThickness`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapCircle.html#Syncfusion_Maui_Maps_MapCircle_StrokeThickness) property. The default value of the [`MapCircle.StrokeThickness`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapCircle.html#Syncfusion_Maui_Maps_MapCircle_StrokeThickness) property is `2`.

You can apply stroke color to each [`MapCircle`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapCircle.html) in the [`Circles`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapCircleLayer.html#Syncfusion_Maui_Maps_MapCircleLayer_Circles) collection using the individual [`MapCircle.Stroke`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapCircle.html#Syncfusion_Maui_Maps_MapCircle_Stroke) property.

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
                                       Fill="Teal"
                                       Stroke="#ea3c62"
                                       StrokeThickness="3">
                            <map:MapCircle.Center>
                                <map:MapLatLng Latitude="15.2993"
                                               Longitude="74.1240" />
                            </map:MapCircle.Center>
                        </map:MapCircle>
                        <map:MapCircle Radius="20"
                                       Fill="Teal"
                                       Stroke="Teal"
                                       StrokeThickness="3">
                            <map:MapCircle.Center>
                                <map:MapLatLng Latitude="15.5057"
                                               Longitude="80.0499" />
                            </map:MapCircle.Center>
                        </map:MapCircle>
                        <map:MapCircle Radius="10"
                                       Fill="Teal"
                                       Stroke="#9c3bb0"
                                       StrokeThickness="3">
                            <map:MapCircle.Center>
                                <map:MapLatLng Latitude="19.7515"
                                               Longitude="75.7139" />
                            </map:MapCircle.Center>
                        </map:MapCircle>
                        <map:MapCircle Radius="20"
                                       Fill="Teal"
                                       Stroke="#50af50"
                                       StrokeThickness="3">
                            <map:MapCircle.Center>
                                <map:MapLatLng Latitude="23.0225"
                                               Longitude="72.5714" />
                            </map:MapCircle.Center>
                        </map:MapCircle>
                        <map:MapCircle Radius="20"
                                       Fill="Teal"
                                       Stroke="#3195ec"
                                       StrokeThickness="3">
                            <map:MapCircle.Center>
                                <map:MapLatLng Latitude="27.0238"
                                               Longitude="74.2179" />
                            </map:MapCircle.Center>
                        </map:MapCircle>
                        <map:MapCircle Radius="10"
                                       Fill="Teal"
                                       Stroke="#e157f9"
                                       StrokeThickness="3">
                            <map:MapCircle.Center>
                                <map:MapLatLng Latitude="26.8467"
                                               Longitude="80.9462" />
                            </map:MapCircle.Center>
                        </map:MapCircle>
                        <map:MapCircle Radius="20"
                                       Fill="Teal"
                                       Stroke="#ee4e4e"
                                       StrokeThickness="3">
                            <map:MapCircle.Center>
                                <map:MapLatLng Latitude="21.2787"
                                               Longitude="85.2799" />
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
circle1.Center = new MapLatLng(15.2993, 74.1240);
circle1.Radius = 10;
circle1.Stroke = Color.FromRgb(234, 60, 98);
circle1.StrokeThickness = 3;
circle1.Fill = Colors.Teal;
MapCircle circle2 = new MapCircle();
circle2.Center = new MapLatLng(15.5057, 80.0499);
circle2.Radius = 20;
circle2.Stroke = Colors.Teal;
circle2.StrokeThickness = 3;
circle2.Fill = Colors.Teal;
MapCircle circle3 = new MapCircle();
circle3.Center = new MapLatLng(19.7515, 75.7139);
circle3.Radius = 10;
circle3.Stroke = Color.FromRgb(156, 59, 176);
circle3.StrokeThickness = 3;
circle3.Fill = Colors.Teal;
MapCircle circle4 = new MapCircle();
circle4.Center = new MapLatLng(23.0225, 72.5714);
circle4.Radius = 20;
circle4.Stroke = Color.FromRgb(80, 175, 80);
circle4.StrokeThickness = 3;
circle4.Fill = Colors.Teal;
MapCircle circle5 = new MapCircle();
circle5.Center = new MapLatLng(27.0238, 74.2179);
circle5.Radius = 20;
circle5.Stroke = Color.FromRgb(49, 149, 236);
circle5.StrokeThickness = 3;
circle5.Fill = Colors.Teal;
MapCircle circle6 = new MapCircle();
circle6.Center = new MapLatLng(26.8467, 80.9462);
circle6.Radius = 10;
circle6.Stroke = Color.FromRgb(225, 87, 249);
circle6.StrokeThickness = 3;
circle6.Fill = Colors.Teal;
MapCircle circle7 = new MapCircle();
circle7.Center = new MapLatLng(21.2787, 85.2799);
circle7.Radius = 20;
circle7.Stroke = Color.FromRgb(238, 78, 78);
circle7.StrokeThickness = 3;
circle7.Fill = Colors.Teal;
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

## Animation

You can apply animation for the [`MapCircle`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapCircle.html) using the [`MapCircleLayer.AnimationDuration`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapCircleLayer.html#Syncfusion_Maui_Maps_MapCircleLayer_AnimationDuration) and [`MapCircleLayer.AnimationEasing`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapCircleLayer.html#Syncfusion_Maui_Maps_MapCircleLayer_AnimationEasing) properties.

By default, there will be no animation.

>Note: Animation is only applicable for the load time.

{% tabs %}

{% highlight xaml %}

<map:SfMaps>
    <map:SfMaps.Layer>
        <map:MapShapeLayer ShapesSource="https://cdn.syncfusion.com/maps/map-data/india.json"
                           ShapeStroke="DarkGrey">
            <map:MapShapeLayer.Sublayers>
                <map:MapCircleLayer AnimationDuration="3000"
                                    AnimationEasing="{x:Static Easing.Linear}">
                    <map:MapCircleLayer.Circles>
                        <map:MapCircle Radius="10"
                                       Stroke="#309989"
                                       Fill="#309989">
                            <map:MapCircle.Center>
                                <map:MapLatLng Latitude="15.2993"
                                               Longitude="74.1240" />
                            </map:MapCircle.Center>
                        </map:MapCircle>
                        <map:MapCircle Radius="10"
                                       Stroke="#309989"
                                       Fill="#309989">
                            <map:MapCircle.Center>
                                <map:MapLatLng Latitude="15.5057"
                                               Longitude="80.0499" />
                            </map:MapCircle.Center>
                        </map:MapCircle>
                        <map:MapCircle Radius="10"
                                       Stroke="#309989"
                                       Fill="#309989">
                            <map:MapCircle.Center>
                                <map:MapLatLng Latitude="19.7515"
                                               Longitude="75.7139" />
                            </map:MapCircle.Center>
                        </map:MapCircle>
                        <map:MapCircle Radius="10"
                                       Stroke="#309989"
                                       Fill="#309989">
                            <map:MapCircle.Center>
                                <map:MapLatLng Latitude="23.0225"
                                               Longitude="72.5714" />
                            </map:MapCircle.Center>
                        </map:MapCircle>
                        <map:MapCircle Radius="10"
                                       Stroke="#309989"
                                       Fill="#309989">
                            <map:MapCircle.Center>
                                <map:MapLatLng Latitude="27.0238"
                                               Longitude="74.2179" />
                            </map:MapCircle.Center>
                        </map:MapCircle>
                        <map:MapCircle Radius="10"
                                       Stroke="#309989"
                                       Fill="#309989">
                            <map:MapCircle.Center>
                                <map:MapLatLng Latitude="26.8467"
                                               Longitude="80.9462" />
                            </map:MapCircle.Center>
                        </map:MapCircle>
                        <map:MapCircle Radius="10"
                                       Stroke="#309989"
                                       Fill="#309989">
                            <map:MapCircle.Center>
                                <map:MapLatLng Latitude="21.2787"
                                               Longitude="85.2799" />
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
circleLayer.AnimationDuration = 3000;
circleLayer.AnimationEasing = Easing.Linear;
MapCircle circle1 = new MapCircle();
circle1.Center = new MapLatLng(15.2993, 74.1240);
circle1.Radius = 10;
circle1.Stroke = Color.FromRgb(48, 153, 137);
circle1.Fill = Color.FromRgb(48, 153, 137);
MapCircle circle2 = new MapCircle();
circle2.Center = new MapLatLng(15.5057, 80.0499);
circle2.Radius = 10;
circle2.Stroke = Color.FromRgb(48, 153, 137);
circle2.Fill = Color.FromRgb(48, 153, 137);
MapCircle circle3 = new MapCircle();
circle3.Center = new MapLatLng(19.7515, 75.7139);
circle3.Radius = 10;
circle3.Stroke = Color.FromRgb(48, 153, 137);
circle3.Fill = Color.FromRgb(48, 153, 137);
MapCircle circle4 = new MapCircle();
circle4.Center = new MapLatLng(23.0225, 72.5714);
circle4.Radius = 10;
circle4.Stroke = Color.FromRgb(48, 153, 137);
circle4.Fill = Color.FromRgb(48, 153, 137);
MapCircle circle5 = new MapCircle();
circle5.Center = new MapLatLng(27.0238, 74.2179);
circle5.Radius = 10;
circle5.Stroke = Color.FromRgb(48, 153, 137);
circle5.Fill = Color.FromRgb(48, 153, 137);
MapCircle circle6 = new MapCircle();
circle6.Center = new MapLatLng(26.8467, 80.9462);
circle6.Radius = 10;
circle6.Stroke = Color.FromRgb(48, 153, 137);
circle6.Fill = Color.FromRgb(48, 153, 137);
MapCircle circle7 = new MapCircle();
circle7.Center = new MapLatLng(21.2787, 85.2799);
circle7.Radius = 10;
circle7.Stroke = Color.FromRgb(48, 153, 137);
circle7.Fill = Color.FromRgb(48, 153, 137);
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

![Circle animation support](images/circle-layer/circle-animation.gif)
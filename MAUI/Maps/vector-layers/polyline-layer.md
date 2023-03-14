---
layout: post
title: Adding Polylines in Maps control | Syncfusion
description: Learn here all about adding the Polylines feature of Syncfusion .NET MAUI Maps (SfMaps) control to customize their appearances and more.
platform: MAUI
control: SfMaps
documentation: ug
---

# Polylines in .NET MAUI Maps (SfMaps)

Polyline layer is a sublayer that renders a group of [`MapPolyline`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapPolyline.html) on [`MapShapeLayer`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html). This section helps to learn about how to add the polylines and customize them.

## Adding polylines

The [`Polylines`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapPolylineLayer.html#Syncfusion_Maui_Maps_MapPolylineLayer_Polylines) is a collection of [`MapPolyline`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapPolyline.html). Every single [`MapPolyline`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapPolyline.html) connects multiple coordinates through a [`Points`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapPolyline.html#Syncfusion_Maui_Maps_MapPolyline_Points) property.

{% tabs %}

{% highlight xaml %}

<map:SfMaps>
    <map:SfMaps.Layer>
        <map:MapShapeLayer ShapesSource="https://cdn.syncfusion.com/maps/map-data/india.json"
                           ShapeStroke="DarkGray">
            <map:MapShapeLayer.Sublayers>
                <map:MapPolylineLayer>
                    <map:MapPolylineLayer.Polylines>
                        <map:MapPolyline>
                            <map:MapPolyline.Points>
                                <map:MapLatLng Latitude="13.0827"
                                               Longitude="80.2707" />
                                <map:MapLatLng Latitude="13.1746"
                                               Longitude="79.6117" />
                                <map:MapLatLng Latitude="13.6373"
                                               Longitude="79.5037" />
                                <map:MapLatLng Latitude="14.4673"
                                               Longitude="78.8242" />
                                <map:MapLatLng Latitude="14.9091"
                                               Longitude="78.0092" />
                                <map:MapLatLng Latitude="16.2160"
                                               Longitude="77.3566" />
                                <map:MapLatLng Latitude="17.1557"
                                               Longitude="76.8697" />
                                <map:MapLatLng Latitude="18.0975"
                                               Longitude="75.4249" />
                                <map:MapLatLng Latitude="18.5204"
                                               Longitude="73.8567" />
                                <map:MapLatLng Latitude="19.0760"
                                               Longitude="72.8777" />
                            </map:MapPolyline.Points>
                        </map:MapPolyline>
                    </map:MapPolylineLayer.Polylines>
                </map:MapPolylineLayer>
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
MapPolylineLayer mapPolylineLayer = new MapPolylineLayer();
MapPolyline polyline = new MapPolyline();
polyline.Points = new ObservableCollection<MapLatLng>()
{
    new MapLatLng(13.0827, 80.2707),
    new MapLatLng(13.1746, 79.6117),
    new MapLatLng(13.6373, 79.5037),
    new MapLatLng(14.4673, 78.8242),
    new MapLatLng(14.9091, 78.0092),
    new MapLatLng(16.2160, 77.3566),
    new MapLatLng(17.1557, 76.8697),
    new MapLatLng(18.0975, 75.4249),
    new MapLatLng(18.5204, 73.8567),
    new MapLatLng(19.0760, 72.8777),
};
mapPolylineLayer.Polylines.Add(polyline);
layer.Sublayers.Add(mapPolylineLayer);
maps.Layer = layer;
this.Content = maps;

{% endhighlight %}

{% endtabs %}

![Default polyline shape](images/polyline-layer/default-polyline-shape.png)

## Stroke

You can apply colors to each [`MapPolyline`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapPolyline.html) in the [`Polylines`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapPolylineLayer.html#Syncfusion_Maui_Maps_MapPolylineLayer_Polylines) collection using the individual [`MapPolyline.Stroke`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapPolyline.html#Syncfusion_Maui_Maps_MapPolyline_Stroke) property.

{% tabs %}

{% highlight xaml %}

<map:SfMaps>
    <map:SfMaps.Layer>
        <map:MapShapeLayer ShapesSource="https://cdn.syncfusion.com/maps/map-data/india.json"
                           ShapeStroke="DarkGray">
            <map:MapShapeLayer.Sublayers>
                <map:MapPolylineLayer>
                    <map:MapPolylineLayer.Polylines>
                        <map:MapPolyline Stroke="#993fad">
                            <map:MapPolyline.Points>
                                <map:MapLatLng Latitude="13.0827"
                                               Longitude="80.2707" />
                                <map:MapLatLng Latitude="13.1746"
                                               Longitude="79.6117" />
                                <map:MapLatLng Latitude="13.6373"
                                               Longitude="79.5037" />
                                <map:MapLatLng Latitude="14.4673"
                                               Longitude="78.8242" />
                                <map:MapLatLng Latitude="14.9091"
                                               Longitude="78.0092" />
                                <map:MapLatLng Latitude="16.2160"
                                               Longitude="77.3566" />
                                <map:MapLatLng Latitude="17.1557"
                                               Longitude="76.8697" />
                                <map:MapLatLng Latitude="18.0975"
                                               Longitude="75.4249" />
                                <map:MapLatLng Latitude="18.5204"
                                               Longitude="73.8567" />
                                <map:MapLatLng Latitude="19.0760"
                                               Longitude="72.8777" />
                            </map:MapPolyline.Points>
                        </map:MapPolyline>
                    </map:MapPolylineLayer.Polylines>
                </map:MapPolylineLayer>
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
MapPolylineLayer mapPolylineLayer = new MapPolylineLayer();
MapPolyline polyline = new MapPolyline();
polyline.Points = new ObservableCollection<MapLatLng>()
{
    new MapLatLng(13.0827, 80.2707),
    new MapLatLng(13.1746, 79.6117),
    new MapLatLng(13.6373, 79.5037),
    new MapLatLng(14.4673, 78.8242),
    new MapLatLng(14.9091, 78.0092),
    new MapLatLng(16.2160, 77.3566),
    new MapLatLng(17.1557, 76.8697),
    new MapLatLng(18.0975, 75.4249),
    new MapLatLng(18.5204, 73.8567),
    new MapLatLng(19.0760, 72.8777),
};
polyline.Stroke = Color.FromRgb(153, 63, 173);
mapPolylineLayer.Polylines.Add(polyline);
layer.Sublayers.Add(mapPolylineLayer);
maps.Layer = layer;
this.Content = maps;

{% endhighlight %}

{% endtabs %}

![Polyline stroke color](images/polyline-layer/polyline-color.png)

## Stroke thickness

You can apply different stroke thickness to each [`MapPolyline`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapPolyline.html) in the [`Polylines`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapPolylineLayer.html#Syncfusion_Maui_Maps_MapPolylineLayer_Polylines) collection using the individual [`MapPolyline.StrokeThickness`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapPolyline.html#Syncfusion_Maui_Maps_MapPolyline_StrokeThickness) property. The default value of the [`MapPolyline.StrokeThickness`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapPolyline.html#Syncfusion_Maui_Maps_MapPolyline_StrokeThickness) property is `2`.

{% tabs %}

{% highlight xaml %}

<map:SfMaps>
    <map:SfMaps.Layer>
        <map:MapShapeLayer ShapesSource="https://cdn.syncfusion.com/maps/map-data/india.json"
                           ShapeStroke="DarkGray">
            <map:MapShapeLayer.Sublayers>
                <map:MapPolylineLayer>
                    <map:MapPolylineLayer.Polylines>
                        <map:MapPolyline Stroke="DarkGray"
                                         StrokeThickness="3" >
                            <map:MapPolyline.Points>
                                <map:MapLatLng Latitude="13.0827"
                                               Longitude="80.2707" />
                                <map:MapLatLng Latitude="13.1746"
                                               Longitude="79.6117" />
                                <map:MapLatLng Latitude="13.6373"
                                               Longitude="79.5037" />
                                <map:MapLatLng Latitude="14.4673"
                                               Longitude="78.8242" />
                                <map:MapLatLng Latitude="14.9091"
                                               Longitude="78.0092" />
                                <map:MapLatLng Latitude="16.2160"
                                               Longitude="77.3566" />
                                <map:MapLatLng Latitude="17.1557"
                                               Longitude="76.8697" />
                                <map:MapLatLng Latitude="18.0975"
                                               Longitude="75.4249" />
                                <map:MapLatLng Latitude="18.5204"
                                               Longitude="73.8567" />
                                <map:MapLatLng Latitude="19.0760"
                                               Longitude="72.8777" />
                            </map:MapPolyline.Points>
                        </map:MapPolyline>
                    </map:MapPolylineLayer.Polylines>
                </map:MapPolylineLayer>
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
MapPolylineLayer mapPolylineLayer = new MapPolylineLayer();
MapPolyline polyline = new MapPolyline();
polyline.Points = new ObservableCollection<MapLatLng>()
{
    new MapLatLng(13.0827, 80.2707),
    new MapLatLng(13.1746, 79.6117),
    new MapLatLng(13.6373, 79.5037),
    new MapLatLng(14.4673, 78.8242),
    new MapLatLng(14.9091, 78.0092),
    new MapLatLng(16.2160, 77.3566),
    new MapLatLng(17.1557, 76.8697),
    new MapLatLng(18.0975, 75.4249),
    new MapLatLng(18.5204, 73.8567),
    new MapLatLng(19.0760, 72.8777),
};
polyline.Stroke = Brush.DarkGray;
polyline.StrokeThickness = 3;
mapPolylineLayer.Polylines.Add(polyline);
layer.Sublayers.Add(mapPolylineLayer);
maps.Layer = layer;
this.Content = maps;

{% endhighlight %}

{% endtabs %}

![Polyline stroke thickness](images/polyline-layer/polyline-width.png)

## Stroke cap

You can apply different stroke cap to each [`MapPolyline`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapPolyline.html) in the [`Polylines`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapPolylineLayer.html#Syncfusion_Maui_Maps_MapPolylineLayer_Polylines) collection using the individual [`MapPolyline.StrokeLineCap`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapPolyline.html#Syncfusion_Maui_Maps_MapPolyline_StrokeLineCap) property. The default value of the [`MapPolyline.StrokeLineCap`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapPolyline.html#Syncfusion_Maui_Maps_MapPolyline_StrokeLineCap) property is `LineCap.Butt`. The available values are `Butt`, `Round`, and `Square`.

{% tabs %}

{% highlight xaml %}

<map:SfMaps>
    <map:SfMaps.Layer>
        <map:MapShapeLayer ShapesSource="https://cdn.syncfusion.com/maps/map-data/india.json"
                           ShapeStroke="DarkGray">
            <map:MapShapeLayer.Sublayers>
                <map:MapPolylineLayer>
                    <map:MapPolylineLayer.Polylines>
                        <map:MapPolyline Stroke="DarkGray"
                                         StrokeThickness="5"
                                         StrokeLineCap="Round">
                            <map:MapPolyline.Points>
                                <map:MapLatLng Latitude="13.0827"
                                               Longitude="80.2707" />
                                <map:MapLatLng Latitude="13.1746"
                                               Longitude="79.6117" />
                                <map:MapLatLng Latitude="13.6373"
                                               Longitude="79.5037" />
                                <map:MapLatLng Latitude="14.4673"
                                               Longitude="78.8242" />
                                <map:MapLatLng Latitude="14.9091"
                                               Longitude="78.0092" />
                                <map:MapLatLng Latitude="16.2160"
                                               Longitude="77.3566" />
                                <map:MapLatLng Latitude="17.1557"
                                               Longitude="76.8697" />
                                <map:MapLatLng Latitude="18.0975"
                                               Longitude="75.4249" />
                                <map:MapLatLng Latitude="18.5204"
                                               Longitude="73.8567" />
                                <map:MapLatLng Latitude="19.0760"
                                               Longitude="72.8777" />
                            </map:MapPolyline.Points>
                        </map:MapPolyline>
                    </map:MapPolylineLayer.Polylines>
                </map:MapPolylineLayer>
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
MapPolylineLayer mapPolylineLayer = new MapPolylineLayer();
MapPolyline polyline = new MapPolyline();
polyline.Points = new ObservableCollection<MapLatLng>()
{
    new MapLatLng(13.0827, 80.2707),
    new MapLatLng(13.1746, 79.6117),
    new MapLatLng(13.6373, 79.5037),
    new MapLatLng(14.4673, 78.8242),
    new MapLatLng(14.9091, 78.0092),
    new MapLatLng(16.2160, 77.3566),
    new MapLatLng(17.1557, 76.8697),
    new MapLatLng(18.0975, 75.4249),
    new MapLatLng(18.5204, 73.8567),
    new MapLatLng(19.0760, 72.8777),
};
polyline.Stroke = Brush.DarkGray;
polyline.StrokeThickness = 5;
polyline.StrokeLineCap = LineCap.Round;
mapPolylineLayer.Polylines.Add(polyline);
layer.Sublayers.Add(mapPolylineLayer);
maps.Layer = layer;
this.Content = maps;

{% endhighlight %}

{% endtabs %}

![Polyline stroke cap](images/polyline-layer/polyline-stroke-cap.png)

## Dash array

You can apply dash support for the polyline using the [`MapPolyline.StrokeDashArray`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapPolyline.html#Syncfusion_Maui_Maps_MapPolyline_StrokeDashArray) property.

A sequence of dash and gap will be rendered based on the values in this list. Once all values of the list is rendered, it will be repeated again till the end of the polyline.

{% tabs %}

{% highlight xaml %}

<map:SfMaps>
    <map:SfMaps.Layer>
        <map:MapShapeLayer ShapesSource="https://cdn.syncfusion.com/maps/map-data/india.json"
                           ShapeStroke="DarkGray">
            <map:MapShapeLayer.Sublayers>
                <map:MapPolylineLayer>
                    <map:MapPolylineLayer.Polylines>
                        <map:MapPolyline Stroke="#52a8ef">
                            <map:MapPolyline.Points>
                                <map:MapLatLng Latitude="13.0827"
                                               Longitude="80.2707" />
                                <map:MapLatLng Latitude="13.1746"
                                               Longitude="79.6117" />
                                <map:MapLatLng Latitude="13.6373"
                                               Longitude="79.5037" />
                                <map:MapLatLng Latitude="14.4673"
                                               Longitude="78.8242" />
                                <map:MapLatLng Latitude="14.9091"
                                               Longitude="78.0092" />
                                <map:MapLatLng Latitude="16.2160"
                                               Longitude="77.3566" />
                                <map:MapLatLng Latitude="17.1557"
                                               Longitude="76.8697" />
                                <map:MapLatLng Latitude="18.0975"
                                               Longitude="75.4249" />
                                <map:MapLatLng Latitude="18.5204"
                                               Longitude="73.8567" />
                                <map:MapLatLng Latitude="19.0760"
                                               Longitude="72.8777" />
                            </map:MapPolyline.Points>
                            <map:MapPolyline.StrokeDashArray>
                                <DoubleCollection>
                                    <x:Double>4</x:Double>
                                    <x:Double>2</x:Double>
                                    <x:Double>1</x:Double>
                                    <x:Double>2</x:Double>
                                </DoubleCollection>
                            </map:MapPolyline.StrokeDashArray>
                        </map:MapPolyline>
                    </map:MapPolylineLayer.Polylines>
                </map:MapPolylineLayer>
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
MapPolylineLayer mapPolylineLayer = new MapPolylineLayer();
MapPolyline polyline = new MapPolyline();
polyline.Points = new ObservableCollection<MapLatLng>()
{
    new MapLatLng(13.0827, 80.2707),
    new MapLatLng(13.1746, 79.6117),
    new MapLatLng(13.6373, 79.5037),
    new MapLatLng(14.4673, 78.8242),
    new MapLatLng(14.9091, 78.0092),
    new MapLatLng(16.2160, 77.3566),
    new MapLatLng(17.1557, 76.8697),
    new MapLatLng(18.0975, 75.4249),
    new MapLatLng(18.5204, 73.8567),
    new MapLatLng(19.0760, 72.8777),
};
polyline.Stroke = Color.FromRgb(82, 168, 239);
polyline.StrokeDashArray = new double[] { 4, 2, 1, 2 };
mapPolylineLayer.Polylines.Add(polyline);
layer.Sublayers.Add(mapPolylineLayer);
maps.Layer = layer;
this.Content = maps;

{% endhighlight %}

{% endtabs %}

![Polyline dash array](images/polyline-layer/polyline-dash-array.png)

## Animation

You can apply animation for the [`MapPolyline`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapPolyline.html) using the [`MapPolylineLayer.AnimationDuration`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapPolylineLayer.html#Syncfusion_Maui_Maps_MapPolylineLayer_AnimationDuration) and [`MapPolylineLayer.AnimationEasing`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapPolylineLayer.html#Syncfusion_Maui_Maps_MapPolylineLayer_AnimationEasing) properties.

By default, there will be no animation.

{% tabs %}

{% highlight xaml %}

<maps:SfMaps>
    <maps:SfMaps.Layer>
        <maps:MapTileLayer UrlTemplate="https://tile.openstreetmap.org/{z}/{x}/{y}.png">
            <maps:MapTileLayer.Center>
                <maps:MapLatLng>
                    <x:Arguments>
                        <x:Double>51.4700</x:Double>
                        <x:Double>-0.2843</x:Double>
                    </x:Arguments>
                </maps:MapLatLng>
            </maps:MapTileLayer.Center>
            <maps:MapTileLayer.ZoomPanBehavior>
                <maps:MapZoomPanBehavior ZoomLevel="10"
                                         MinZoomLevel="9"
                                         MaxZoomLevel="12" />
            </maps:MapTileLayer.ZoomPanBehavior>
            <maps:MapTileLayer.Sublayers>
                <maps:MapPolylineLayer AnimationDuration="3000"
                                       AnimationEasing="{x:Static Easing.SinInOut}">
                    <maps:MapPolylineLayer.Polylines>
                        <maps:MapPolyline x:Name="polyline"
                                          Stroke="#0066FF"
                                          StrokeThickness="6" />
                    </maps:MapPolylineLayer.Polylines>
                </maps:MapPolylineLayer>
            </maps:MapTileLayer.Sublayers>
            <maps:MapTileLayer.Markers>
                <maps:MapMarkerCollection>
                    <maps:MapMarker Latitude="51.470012664794922"
                                    Longitude="-0.45418000221252441"
                                    IconWidth="14"
                                    IconHeight="14"
                                    IconFill="white"
                                    IconStroke="black" />
                    <maps:MapMarker Latitude="51.520004272460938"
                                    Longitude="-0.12567600607872009"
                                    IconWidth="14"
                                    IconHeight="14"
                                    IconFill="White"
                                    IconStroke="black" />
                </maps:MapMarkerCollection>
            </maps:MapTileLayer.Markers>
        </maps:MapTileLayer>
    </maps:SfMaps.Layer>
</maps:SfMaps>

{% endhighlight %}

{% highlight c# %}

public MainPage()
{
    InitializeComponent();
    
    // Added logic in sample level to get the polygon points.
    polyline.Points = this.GetJsondata("MapDemo.ShapeFiles.london_to_british.json");
}

{% endhighlight %}

{% endtabs %}

![Polyline animation support](images/polyline-layer/polyline_animation.gif)

---
layout: post
title: Migrate from Xamarin SfMaps to .NET MAUI SfMaps | Syncfusion 
description: Learn here all about Migrating from Syncfusion Xamarin SfMaps to Syncfusion .NET MAUI SfMaps control and more.
platform: MAUI
control: SfMaps
documentation: ug
---  

# Migrate from Xamarin.Forms SfMaps to .NET MAUI SfMaps

To make the migration from the [Xamarin SfMaps](https://www.syncfusion.com/xamarin-ui-controls/xamarin-maps) to [.NET MAUI SfMaps](https://www.syncfusion.com/maui-controls/maui-maps) easier, most of the APIs from the Xamarin SfMaps are kept in the.NET MAUI SfMaps. However, some APIs have been renamed to maintain the consistency of API naming in the .NET MAUI SfMaps. Please find the difference in the following topics.

## Initialize control

To initialize the control, import the map namespace and initialize the SfMaps as shown in the following code sample.

<table>
<tr>
<th>Xamarin SfMaps</th>
<th>.NET MAUI SfMaps</th></tr>
<tr>
<td>
{% tabs %}

{% highlight xaml %}

<ContentPage
    . . .
    xmlns:syncfusion="clr-namespace:Syncfusion.SfMaps.XForms;assembly=Syncfusion.SfMaps.XForms">

        <syncfusion:SfMaps/>

</ContentPage>

{% endhighlight %}

{% highlight C# %}

using Syncfusion.SfMaps.XForms;
...

SfMaps map = new SfMaps();
...

{% endhighlight %}

{% endtabs %}

</td>

<td>

{% tabs %}

{% highlight xaml %}

<ContentPage …
xmlns:map="clr-namespace:Syncfusion.Maui.Maps;assembly=Syncfusion.Maui.Maps">

<map:SfMaps />

</ContentPage>

{% endhighlight %}

{% highlight C# %}

using Syncfusion.Maui.Maps;
…

SfMaps map = new SfMaps();
...

{% endhighlight %}

{% endtabs %}
</td></tr>
</table>

<table>
<tr>
   <th>Xamarin SfMaps</th>
   <th>.NET MAUI SfMaps</th>
</tr>
<tr>
   <td>
      {{'[Layers](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.SfMaps.html#Syncfusion_SfMaps_XForms_SfMaps_Layers)'| markdownify }}
   </td>
   <td>
      {{'[*Layer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.SfMaps.html#Syncfusion_Maui_Maps_SfMaps_Layer)'| markdownify }}
   </td>
</tr>
<tr>
   <td>
      {{'[ShapeFileLayer](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.ShapeFileLayer.html)'| markdownify }}
   </td>
   <td>
      {{'[*MapShapeLayer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html)'| markdownify }}
   </td>
</tr>
</table>

N> All the (*) marked APIs are renamed from Xamarin SfMaps to maintain the consistency of API naming in the .NET MAUI SfMaps.

## Adding layer

### Shape layer

<table>
<tr>
   <th>Xamarin SfMaps</th>
   <th>.NET MAUI SfMaps</th>
</tr>
<tr>
   <td>
      {{'[BubbleMarkerSettings](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.ShapeFileLayer.html#Syncfusion_SfMaps_XForms_ShapeFileLayer_BubbleMarkerSettings)'| markdownify }}
   </td>
   <td>
      {{'[*BubbleSettings](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_BubbleSettings)'| markdownify }}
   </td>
</tr>
<tr>
   <td>
      {{'[DataLabelSettings](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.ShapeFileLayer.html#Syncfusion_SfMaps_XForms_ShapeFileLayer_DataLabelSettings)'| markdownify }}
   </td>
   <td>
      {{'[DataLabelSettings](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_DataLabelSettings)'| markdownify }}
   </td>
</tr>
<tr>
   <td>
      {{'[EnableSelection](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.ShapeFileLayer.html#Syncfusion_SfMaps_XForms_ShapeFileLayer_EnableSelection)'| markdownify }}
   </td>
   <td>
      {{'[EnableSelection](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_EnableSelection)'| markdownify }}
   </td>
</tr>
<tr>
   <td>
      {{'[ItemsSource](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.ShapeFileLayer.html#Syncfusion_SfMaps_XForms_ShapeFileLayer_ItemsSource)'| markdownify }}
   </td>
   <td>
      {{'[*DataSource](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_DataSource)'| markdownify }}
   </td>
</tr>
<tr>
   <td>
      {{'[ShapeIDPath](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.ShapeFileLayer.html#Syncfusion_SfMaps_XForms_ShapeFileLayer_ShapeIDPath)'| markdownify }}
   </td>
   <td>
      {{'[*PrimaryValuePath](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_PrimaryValuePath)'| markdownify }}
   </td>
</tr>
<tr>
   <td>
      {{'[ShapeIDTableField](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.ShapeFileLayer.html#Syncfusion_SfMaps_XForms_ShapeFileLayer_ShapeIDTableField)'| markdownify }}
   </td>
   <td>
      {{'[*ShapeDataField](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_ShapeDataField)'| markdownify }}
   </td>
</tr>
<tr>
   <td>
      {{'[Uri](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.ShapeFileLayer.html#Syncfusion_SfMaps_XForms_ShapeFileLayer_Uri)'| markdownify }}
   </td>
   <td>
      {{'[*ShapesSource](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_ShapesSource)'| markdownify }}
   </td>
</tr>
<tr>
   <td>
      {{'[Markers](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.MapLayer.html#Syncfusion_SfMaps_XForms_MapLayer_Markers)'| markdownify }}
   </td>
   <td>
      {{'[Markers](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapLayer.html#Syncfusion_Maui_Maps_MapLayer_Markers)'| markdownify }}
   </td>
</tr>
<tr>
   <td>
      {{'[MarkerTemplate](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.MapLayer.html#Syncfusion_SfMaps_XForms_MapLayer_MarkerTemplate)'| markdownify }}
   </td>
   <td>
      {{'[MarkerTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapLayer.html#Syncfusion_Maui_Maps_MapLayer_MarkerTemplate)'| markdownify }}
   </td>
</tr>
<tr>
   <td>
      {{'[ShapeSelectionChanged](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.ShapeFileLayer.html#Syncfusion_SfMaps_XForms_ShapeFileLayer_ShapeSelectionChanged)'| markdownify }}
   </td>
   <td>
      {{'[*ShapeSelected](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_ShapeSelected)'| markdownify }}
   </td>
</tr>
<tr>
   <td>
      {{'[ColorMappings](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.ShapeSetting.html#Syncfusion_SfMaps_XForms_ShapeSetting_ColorMappings)'| markdownify }} in
       {{'[ShapeSetting](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.ShapeSetting.html)'| markdownify }} class
   </td>
   <td>
      {{'[ColorMappings](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_ColorMappings)'| markdownify }}
   </td>
</tr>
<tr>
   <td>
      {{'[ShapeFill](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.ShapeSetting.html#Syncfusion_SfMaps_XForms_ShapeSetting_ShapeFill)'| markdownify }} in
       {{'[ShapeSetting](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.ShapeSetting.html)'| markdownify }} class
   </td>
   <td>
      {{'[ShapeFill](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_ShapeFill)'| markdownify }}
   </td>
</tr>
<tr>
   <td>
      {{'[ShapeStroke](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.ShapeSetting.html#Syncfusion_SfMaps_XForms_ShapeSetting_ShapeStroke)'| markdownify }} in
       {{'[ShapeSetting](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.ShapeSetting.html)'| markdownify }} class
   </td>
   <td>
      {{'[ShapeStroke](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_ShapeStroke)'| markdownify }}
   </td>
</tr>
<tr>
   <td>
      {{'[ShapeStrokeThickness](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.ShapeSetting.html#Syncfusion_SfMaps_XForms_ShapeSetting_ShapeStrokeThickness)'| markdownify }} in
       {{'[ShapeSetting](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.ShapeSetting.html)'| markdownify }} class
   </td>
   <td>
      {{'[ShapeStrokeThickness](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_ShapeStrokeThickness)'| markdownify }}
   </td>
</tr>
<tr>
   <td>
      {{'[SelectedShapeColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.ShapeSetting.html#Syncfusion_SfMaps_XForms_ShapeSetting_SelectedShapeColor)'| markdownify }} in
       {{'[ShapeSetting](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.ShapeSetting.html)'| markdownify }} class
   </td>
   <td>
      {{'[*SelectedShapeFill](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_SelectedShapeFill)'| markdownify }}
   </td>
</tr>
<tr>
   <td>
      {{'[SelectedShapeStroke](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.ShapeSetting.html#Syncfusion_SfMaps_XForms_ShapeSetting_SelectedShapeStroke)'| markdownify }} in
       {{'[ShapeSetting](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.ShapeSetting.html)'| markdownify }} class
   </td>
   <td>
      {{'[SelectedShapeStroke](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_SelectedShapeStroke)'| markdownify }}
   </td>
</tr>
<tr>
   <td>
      {{'[SelectedShapeStrokeThickness](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.ShapeSetting.html#Syncfusion_SfMaps_XForms_ShapeSetting_SelectedShapeStrokeThickness)'| markdownify }} in
       {{'[ShapeSetting](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.ShapeSetting.html)'| markdownify }} class
   </td>
   <td>
      {{'[SelectedShapeStrokeThickness](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_SelectedShapeStrokeThickness)'| markdownify }}
   </td>
</tr>
<tr>
   <td>
      {{'[ShapeColorValuePath](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.ShapeSetting.html#Syncfusion_SfMaps_XForms_ShapeSetting_ShapeColorValuePath)'| markdownify }} and {{'[ShapeValuePath](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.ShapeSetting.html#Syncfusion_SfMaps_XForms_ShapeSetting_ShapeValuePath)'| markdownify }} in
       {{'[ShapeSetting](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.ShapeSetting.html)'| markdownify }} class
   </td>
   <td>
      {{'[ShapeColorValuePath](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_ShapeColorValuePath)'| markdownify }}
   </td>
</tr>
</table>

N> All the (*) marked APIs are renamed from Xamarin SfMaps to maintain the consistency of API naming in the .NET MAUI SfMaps.

The following code example explains how to intialize the layer and customize the layer in Xamarin SfMaps and .NET MAUI SfMaps.

<table>
<tr>
<th>Xamarin SfMaps</th>
<th>.NET MAUI SfMaps</th></tr>
<tr>
<td>
{% tabs %}

{% highlight xaml %}

<maps:SfMaps>
    <maps:SfMaps.Layers >
        <maps:ShapeFileLayer Uri="world.shp" >
            <maps:ShapeFileLayer.ShapeSettings>
                <maps:ShapeSetting  ShapeFill="#b5dcff"
                                    ShapeStroke="#1585ed">
                </maps:ShapeSetting>
            </maps:ShapeFileLayer.ShapeSettings>
        </maps:ShapeFileLayer>
    </maps:SfMaps.Layers>
</maps:SfMaps>

{% endhighlight %}

{% highlight C# %}

    SfMaps maps = new SfMaps();

    ShapeFileLayer layer = new ShapeFileLayer();
    layer.Uri = "world.shp";           
    
    ShapeSetting shapeSetting = new ShapeSetting(); 
    shapeSetting.ShapeFill = Color.FromRgb(181, 220, 255);
    shapeSetting.ShapeStroke = Color.FromRgb(21, 133, 237);
    layer.ShapeSettings = shapeSetting;

    maps.Layers.Add(layer);

{% endhighlight %}

{% endtabs %}
</td>
<td>
{% tabs %}

{% highlight xaml %}

<map:SfMaps>
    <map:SfMaps.Layer>
        <map:MapShapeLayer ShapesSource="https://cdn.syncfusion.com/maps/map-data/world-map.json"
                           ShapeStroke="#1585ed"
                           ShapeFill="#b5dcff">
        </map:MapShapeLayer>
    </maps:SfMaps.Layer>
</maps:SfMaps>

{% endhighlight %}

{% highlight C# %}

    public MainPage()
    {
        InitializeComponent();

        MapShapeLayer layer = new MapShapeLayer();
        layer.ShapesSource = MapSource.FromUri(new Uri("https://cdn.syncfusion.com/maps/map-data/world-map.json"));
        layer.ShapeFill = Color.FromRgb(181, 220, 255);
        layer.ShapeStroke = Color.FromRgb(21, 133, 237);

        SfMaps maps = new SfMaps();
        maps.Layer = layer;

        this.Content = maps;
    }

{% endhighlight %}

{% endtabs %}
</td></tr>
</table>

### Tile layer

<table>
<tr>
   <th>Xamarin SfMaps</th>
   <th>.NET MAUI SfMaps</th>
</tr>
<tr>
   <td>
      {{'[LayerType](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.ImageryLayer.html#Syncfusion_SfMaps_XForms_ImageryLayer_LayerType)'| markdownify }}, {{'[BingMapKey](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.ImageryLayer.html#Syncfusion_SfMaps_XForms_ImageryLayer_BingMapKey)'| markdownify }}, {{'[BingMapStyle](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.ImageryLayer.html#Syncfusion_SfMaps_XForms_ImageryLayer_BingMapStyle)'| markdownify }}, and {{'[RequestTileUri](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.ImageryLayer.html#Syncfusion_SfMaps_XForms_ImageryLayer_RequestTileUri)'| markdownify }}
   </td>
   <td>
      Can achieve all this using {{'[UrlTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapTileLayer.html#Syncfusion_Maui_Maps_MapTileLayer_UrlTemplate)'| markdownify }} and {{'[GetBingUrl()](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapTileLayer.html#Syncfusion_Maui_Maps_MapTileLayer_GetBingUrl_System_String_)'| markdownify }}
   </td>
</tr>
<tr>
   <td>
      {{'[GeoCoordinates](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.ImageryLayer.html#Syncfusion_SfMaps_XForms_ImageryLayer_GeoCoordinates)'| markdownify }}
   </td>
   <td>
      {{'[*Center](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapTileLayer.html#Syncfusion_Maui_Maps_MapTileLayer_Center)'| markdownify }} 
   </td>
</tr>
<tr>
   <td>
      {{'[CanCacheTiles](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.ImageryLayer.html#Syncfusion_SfMaps_XForms_ImageryLayer_CanCacheTiles)'| markdownify }}
   </td>
   <td>
      {{'[CanCacheTiles](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapTileLayer.html#Syncfusion_Maui_Maps_MapTileLayer_CanCacheTiles)'| markdownify }}
   </td>
</tr>
<tr>
   <td>
      {{'[Radius](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.ImageryLayer.html#Syncfusion_SfMaps_XForms_ImageryLayer_Radius)'| markdownify }} 
   </td>
   <td>
      {{'[Radius](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapTileLayer.html#Syncfusion_Maui_Maps_MapTileLayer_Radius)'| markdownify }} 
   </td>
</tr>
<tr>
   <td>
      {{'[DistanceType](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.ImageryLayer.html#Syncfusion_SfMaps_XForms_ImageryLayer_DistanceType)'| markdownify }} 
   </td>
   <td>
      {{'[DistanceType](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapTileLayer.html#Syncfusion_Maui_Maps_MapTileLayer_DistanceType)'| markdownify }}
   </td>
</tr>
<tr>
   <td>
      {{'[LatLngBounds](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.ImageryLayer.html#Syncfusion_SfMaps_XForms_ImageryLayer_LatLngBounds)'| markdownify }} 
   </td>
   <td>
      {{'[LatLngBounds](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapTileLayer.html#Syncfusion_Maui_Maps_MapTileLayer_MapLatLngBounds)'| markdownify }} 
   </td>
</tr>
<tr>
   <td>
      {{'[Markers](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.MapLayer.html#Syncfusion_SfMaps_XForms_MapLayer_Markers)'| markdownify }}
   </td>
   <td>
      {{'[Markers](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapLayer.html#Syncfusion_Maui_Maps_MapLayer_Markers)'| markdownify }}
   </td>
</tr>
<tr>
   <td>
      {{'[MarkerTemplate](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.MapLayer.html#Syncfusion_SfMaps_XForms_MapLayer_MarkerTemplate)'| markdownify }}
   </td>
   <td>
      {{'[MarkerTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapLayer.html#Syncfusion_Maui_Maps_MapLayer_MarkerTemplate)'| markdownify }}
   </td>
</tr>
</table>

<b>Methods</b>

<table>
<tr>
   <th>Xamarin SfMaps</th>
   <th>.NET MAUI SfMaps</th>
</tr>
<tr>
   <td>
     {{'[DeleteTilesFromCache()](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.ImageryLayer.html#Syncfusion_SfMaps_XForms_ImageryLayer_DeleteTilesFromCache)'| markdownify }} 
   </td>
   <td>
      {{'[DeleteTilesFromCache()](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapTileLayer.html#Syncfusion_Maui_Maps_MapTileLayer_DeleteTilesFromCache)'| markdownify }} 
   </td>
</tr>
</table>

<b>Events</b>

<table>
<tr>
   <th>Xamarin SfMaps</th>
   <th>.NET MAUI SfMaps</th>
</tr>
<tr>
   <td>
     {{'[ZoomLevelChanging](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.ImageryLayer.html#Syncfusion_SfMaps_XForms_ImageryLayer_ZoomLevelChanging)'| markdownify }} 
   </td>
   <td>
      {{'[ZoomLevelChanging](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapLayer.html#Syncfusion_Maui_Maps_MapLayer_ZoomLevelChanging)'| markdownify }} 
   </td>
</tr>
</table>

N> All the (*) marked APIs are renamed from Xamarin SfMaps to maintain the consistency of API naming in the .NET MAUI SfMaps.

The following code example explains how to intialize the tile layer and it's customization in Xamarin SfMaps and .NET MAUI SfMaps.

<b>Adding OSM layer</b>

<table>
<tr>
<th>Xamarin SfMaps</th>
<th>.NET MAUI SfMaps</th></tr>
<tr>
<td>
{% tabs %}

{% highlight xaml %}

<maps:SfMaps>
    <maps:SfMaps.Layers>
        <maps:ImageryLayer GeoCoordinates="38.909804, -77.043442"
                           Radius="5"
                           DistanceType="KiloMeter">
            <maps:ImageryLayer.Markers>
                <maps:MapMarker Latitude="38.909804"
                                Longitude="-77.043442" />
            </maps:ImageryLayer.Markers>
        </maps:ImageryLayer>
    </maps:SfMaps.Layers>

{% endhighlight %}

{% highlight C# %}

SfMaps maps = new SfMaps();
ImageryLayer layer = new ImageryLayer();
layer.GeoCoordinates = new Point(38.909804, -77.043442);
layer.Radius = 5;
layer.DistanceType = DistanceType.KiloMeter;
MapMarker marker = new MapMarker();
marker.Latitude = "38.909804";
marker.Longitude = "-77.043442";
layer.Markers.Add(marker);
maps.Layers.Add(layer);
this.Content = maps;

{% endhighlight %}

{% endtabs %}
</td>
<td>
{% tabs %}

{% highlight xaml %}

<maps:SfMaps>
    <maps:SfMaps.Layer>
        <maps:MapTileLayer Radius="5"
                           DistanceType="Kilometer"
                           UrlTemplate="https://tile.openstreetmap.org/{z}/{x}/{y}.png">
            <maps:MapTileLayer.Center>
                <maps:MapLatLng Latitude="38.909804"
                                Longitude="-77.043442">
                </maps:MapLatLng>
            </maps:MapTileLayer.Center>
            <maps:MapTileLayer.ZoomPanBehavior>
                <maps:MapZoomPanBehavior />
            </maps:MapTileLayer.ZoomPanBehavior>
            <maps:MapTileLayer.Markers>
                <maps:MapMarkerCollection>
                    <maps:MapMarker Latitude="38.909804"
                                    Longitude="-77.043442" />
                </maps:MapMarkerCollection>
            </maps:MapTileLayer.Markers>
        </maps:MapTileLayer>
    </maps:SfMaps.Layer>
</maps:SfMaps>

{% endhighlight %}

{% highlight C# %}

public MainPage()
{
   InitializeComponent();
   SfMaps map = new SfMaps();
   MapTileLayer tileLayer = new MapTileLayer();
   tileLayer.UrlTemplate = "https://tile.openstreetmap.org/{z}/{x}/{y}.png";
   tileLayer.Radius = 5;
   tileLayer.DistanceType = MapDistanceType.Kilometer;
   tileLayer.Center = new MapLatLng(38.909804, -77.043442);
   MapZoomPanBehavior zoomPanBehavior = new MapZoomPanBehavior();
   tileLayer.ZoomPanBehavior = zoomPanBehavior;
   MapMarker mapMarker = new MapMarker();
   mapMarker.Latitude = 38.909804;
   mapMarker.Longitude = -77.043442;
   MapMarkerCollection mapMarkers = new MapMarkerCollection();
   mapMarkers.Add(mapMarker);
   tileLayer.Markers = mapMarkers;
   map.Layer = tileLayer;
   this.Content = map;
}

{% endhighlight %}

{% endtabs %}
</td></tr>
</table>

<b>Adding bing maps</b>

<table>
<tr>
<th>Xamarin SfMaps</th>
<th>.NET MAUI SfMaps</th></tr>
<tr>
<td>
{% tabs %}

{% highlight xaml %}

<maps:SfMaps>
    <maps:SfMaps.Layers>
        <maps:ImageryLayer LayerType="Bing"
                           BingMapKey="Your bing map key" />
    </maps:SfMaps.Layers>
</maps:SfMaps>

{% endhighlight %}

{% highlight C# %}

SfMaps maps = new SfMaps();
ImageryLayer layer = new ImageryLayer();
layer.LayerType = LayerType.Bing;
layer.BingMapKey = "Your bing map key";
maps.Layers.Add(layer);
this.Content = maps;

{% endhighlight %}

{% endtabs %}
</td>
<td>

{% highlight C# %}

public MainPage()
{
	InitializeComponent();
   SfMaps map = new SfMaps();
   MapTileLayer tileLayer = new MapTileLayer();
   this.GenerateBing(tileLayer);
   map.Layer = tileLayer;
   this.Content = map;
}

private async Task GenerateBing(MapTileLayer tileLayer)
{
    tileLayer.UrlTemplate = await MapTileLayer.GetBingUrl("https://dev.virtualearth.net/REST/V1/Imagery/Metadata/RoadOnDemand?output=json&uriScheme=https&include=ImageryProviders&key=subscription_key") + "?name=bingName";
}

{% endhighlight %}

</td></tr>
</table>

## Bubble settings

<table>
<tr>
<th>Xamarin SfMaps</th>
<th>.NET MAUI SfMaps</th>
</tr>
<tr>
   <td>
      {{'[ColorMappings](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.BubbleMarkerSetting.html#Syncfusion_SfMaps_XForms_BubbleMarkerSetting_ColorMappings)'| markdownify }}
   </td>
   <td>
      {{'[ColorMappings](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapBubbleSettings.html#Syncfusion_Maui_Maps_MapBubbleSettings_ColorMappings)'| markdownify }}
   </td>
</tr>
<tr>
   <td>
      {{'[ColorValuePath](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.BubbleMarkerSetting.html#Syncfusion_SfMaps_XForms_BubbleMarkerSetting_ColorValuePath)'| markdownify }}
   </td>
   <td>
      {{'[ColorValuePath](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapBubbleSettings.html#Syncfusion_Maui_Maps_MapBubbleSettings_ColorValuePath)'| markdownify }}
   </td>
</tr>
<tr>
   <td>
      {{'[Fill](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.BubbleMarkerSetting.html#Syncfusion_SfMaps_XForms_BubbleMarkerSetting_Fill)'| markdownify }}
   </td>
   <td>
      {{'[Fill](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapBubbleSettings.html#Syncfusion_Maui_Maps_MapBubbleSettings_Fill)'| markdownify }}
   </td>
</tr>
<tr>
   <td>
      {{'[MaxSize](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.BubbleMarkerSetting.html#Syncfusion_SfMaps_XForms_BubbleMarkerSetting_MaxSize)'| markdownify }}
   </td>
   <td>
      {{'[MaxSize](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapBubbleSettings.html#Syncfusion_Maui_Maps_MapBubbleSettings_MaxSize)'| markdownify }}
   </td>
</tr>
<tr>
   <td>
      {{'[MinSize](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.BubbleMarkerSetting.html#Syncfusion_SfMaps_XForms_BubbleMarkerSetting_MinSize)'| markdownify }}
   </td>
   <td>
      {{'[MinSize](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapBubbleSettings.html#Syncfusion_Maui_Maps_MapBubbleSettings_MinSize)'| markdownify }}
   </td>
</tr>
<tr>
   <td>
      {{'[Opacity](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.BubbleMarkerSetting.html#Syncfusion_SfMaps_XForms_BubbleMarkerSetting_Opacity)'| markdownify }}
   </td>
   <td>
      {{'[Opacity](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapBubbleSettings.html#Syncfusion_Maui_Maps_MapBubbleSettings_Opacity)'| markdownify }}
   </td>
</tr>
<tr>
   <td>
      {{'[ValuePath](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.BubbleMarkerSetting.html#Syncfusion_SfMaps_XForms_BubbleMarkerSetting_ValuePath)'| markdownify }}
   </td>
   <td>
      {{'[*SizeValuePath](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapBubbleSettings.html#Syncfusion_Maui_Maps_MapBubbleSettings_SizeValuePath)'| markdownify }}
   </td>
</tr>
<tr>
   <td>
      {{'[ShowBubbles](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.BubbleMarkerSetting.html#Syncfusion_SfMaps_XForms_BubbleMarkerSetting_ShowBubbles)'| markdownify }}
   </td>
   <td>
      {{'[ShowBubbles](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_ShowBubbles)'| markdownify }} in
      {{'[MapShapeLayer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html)'| markdownify }} class
   </td>
</tr>
</table>

N> All the (*) marked APIs are renamed from Xamarin SfMaps to maintain the consistency of API naming in the .NET MAUI SfMaps.

The following code example explains how to customize the bubble in the Xamarin SfMaps and .NET MAUI SfMaps.

<table>
<tr>
<th>Xamarin SfMaps</th>
<th>.NET MAUI SfMaps</th></tr>
<tr>
<td>
{% tabs %}

{% highlight xaml %}

<maps:SfMaps>
    <maps:SfMaps.Layers >
        <maps:ShapeFileLayer Uri="world.shp"
                             ItemsSource="{Binding Data}"
                             ShapeIDPath="State"
                             ShapeIDTableField="name">
            <maps:ShapeFileLayer.BubbleMarkerSettings>
                <maps:BubbleMarkerSetting ShowBubbles="True"
                                          ColorValuePath="Population"
                                          ValuePath="Population"/>
            </maps:ShapeFileLayer.BubbleMarkerSettings>
        </maps:ShapeFileLayer>
    </maps:SfMaps.Layers>
</maps:SfMaps>

{% endhighlight %}

{% highlight C# %}

    ViewModel viewModel = new ViewModel();
    this.BindingContext = viewModel;
    SfMaps maps = new SfMaps();

    ShapeFileLayer layer = new ShapeFileLayer();
    layer.Uri = "world.shp";           
    layer.ShapeIDPath="State"
    layer.ShapeIDTableField="name"
    layer.DataSource = viewModel.Data;

    BubbleMarkerSetting bubbleSetting = new BubbleMarkerSetting()
    {
        ShowBubbles = true,
        ValuePath = "index",
        ColorValuePath = "Population",
        SizeValuePath = "Population",
    };

    layer.BubbleMarkerSettings = bubbleSetting;

    maps.Layers.Add(layer);

{% endhighlight %}

{% endtabs %}
</td>
<td>
{% tabs %}

{% highlight xaml %}

<map:SfMaps>
    <map:SfMaps.Layer>
        <map:MapShapeLayer ShapesSource="https://cdn.syncfusion.com/maps/map-data/world-map.json"
                           DataSource="{Binding Data}"
                           PrimaryValuePath="State"
                           ShapeDataField="name"
                           ShowBubbles="True"
                           ShowBubbleTooltip="True">

            <map:MapShapeLayer.BubbleSettings>
                <map:MapBubbleSettings ColorValuePath="Population" 
                                       SizeValuePath="Population">
                </map:MapBubbleSettings>
            </map:MapShapeLayer.BubbleSettings>
        </map:MapShapeLayer>
    </map:SfMaps.Layer>
</map:SfMaps>

{% endhighlight %}

{% highlight C# %}

public MainPage()
{
   InitializeComponent();
    ViewModel viewModel = new ViewModel();
    this.BindingContext = viewModel;
    SfMaps maps = new SfMaps();
    MapShapeLayer layer = new MapShapeLayer();
    layer.ShapesSource = MapSource.FromUri(new Uri("https://cdn.syncfusion.com/maps/map-data/world-map.json"));
    layer.DataSource = viewModel.Data;
    layer.PrimaryValuePath = "State";
    layer.ShapeDataField = "name";
    layer.ShowBubbles = true;
    layer.ShowBubbleTooltip = true;

    MapBubbleSettings bubbleSetting = new MapBubbleSettings()
    {
        ColorValuePath = "Population",
        SizeValuePath = "Population",
    };

    layer.BubbleSettings = bubbleSetting;
    maps.Layer = layer;
    this.Content = maps;
}

{% endhighlight %}

{% endtabs %}
</td></tr>
</table>

## Data label settings

<table>
<tr>
<th>Xamarin SfMaps</th>
<th>.NET MAUI SfMaps</th>
</tr>
<tr>
   <td>
      {{'[SmartLabelMode](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.DataLabelSetting.html#Syncfusion_SfMaps_XForms_DataLabelSetting_SmartLabelMode)'| markdownify }}
   </td>
   <td>
      {{'[*OverflowMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapDataLabelSettings.html#Syncfusion_Maui_Maps_MapDataLabelSettings_OverflowMode)'| markdownify }}
   </td>
</tr>
<tr>
   <td>
      {{'[TextColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.DataLabelSetting.html#Syncfusion_SfMaps_XForms_DataLabelSetting_TextColor)'| markdownify }},
      {{'[FontSize](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.DataLabelSetting.html#Syncfusion_SfMaps_XForms_DataLabelSetting_FontSize)'| markdownify }},
      {{'[FontFamily](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.DataLabelSetting.html#Syncfusion_SfMaps_XForms_DataLabelSetting_FontFamily)'| markdownify }}, and
      {{'[FontAttributes](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.DataLabelSetting.html#Syncfusion_SfMaps_XForms_DataLabelSetting_FontAttributes)'| markdownify }}
   </td>
   <td>
      {{'[*DataLabelStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapDataLabelSettings.html#Syncfusion_Maui_Maps_MapDataLabelSettings_DataLabelStyle)'| markdownify }}
   </td>
</tr>
</table>

N> All the (*) marked APIs are renamed from Xamarin SfMaps to maintain the consistency of API naming in the .NET MAUI SfMaps.

The following code example explains how to customize the data label in the Xamarin SfMaps and .NET MAUI SfMaps.

<table>
<tr>
<th>Xamarin SfMaps</th>
<th>.NET MAUI SfMaps</th></tr>
<tr>
<td>
{% tabs %}

{% highlight xaml %}

<maps:SfMaps>
    <maps:SfMaps.Layers >
        <maps:ShapeFileLayer Uri="world.shp"
                             ItemsSource="{Binding Data}"
                             ShapeIDPath="State"
                             ShapeIDTableField="name"
                             ShowMapItems="True">
            <maps:ShapeFileLayer.DataLabelSettings>
                <maps:DataLabelSetting  SmartLabelMode="Trim" />
            </maps:ShapeFileLayer.DataLabelSettings>
        </maps:ShapeFileLayer>
    </maps:SfMaps.Layers>
</maps:SfMaps>

{% endhighlight %}

{% highlight C# %}

    ViewModel viewModel = new ViewModel();
    this.BindingContext = viewModel;
    SfMaps maps = new SfMaps();

    ShapeFileLayer layer = new ShapeFileLayer();
    layer.Uri = "world.shp";           
    layer.ShapeIDPath="State"
    layer.ShapeIDTableField="name"
    layer.DataSource = viewModel.Data;
    layer.ShowMapItems = true;

    DataLabelSetting dataLabelSetting = new DataLabelSetting();
    dataLabelSetting.SmartLabelMode = IntersectAction.Trim;
    
    layer.DataLabelSettings = dataLabelSetting;

    maps.Layers.Add(layer);

{% endhighlight %}

{% endtabs %}
</td>
<td>
{% tabs %}

{% highlight xaml %}

<map:SfMaps>
    <map:SfMaps.Layer>
        <map:MapShapeLayer ShapesSource="https://cdn.syncfusion.com/maps/map-data/world-map.json"
                           DataSource="{Binding Data}"
                           PrimaryValuePath="State" 
                           ShapeDataField="name"
                           ShapeHoverFill = "Transparent" 
                           ShapeHoverStroke="Transparent"
                           ShowDataLabels="True">

            <map:MapShapeLayer.DataLabelSettings>
                <map:MapDataLabelSettings OverflowMode="Trim"
                                          DataLabelPath="State">
                        <map:MapDataLabelSettings.DataLabelStyle>
                                <map:MapLabelStyle FontSize="12"/>
                        </map:MapDataLabelSettings.DataLabelStyle>
                </map:MapDataLabelSettings>
            </map:MapShapeLayer.DataLabelSettings>

        </map:MapShapeLayer>
    </map:SfMaps.Layer>
</map:SfMaps>

{% endhighlight %}

{% highlight C# %}

public MainPage()
{
   InitializeComponent();
    ViewModel viewModel = new ViewModel();
    this.BindingContext = viewModel;
    SfMaps maps = new SfMaps();
    MapShapeLayer layer = new MapShapeLayer();
    layer.ShapesSource = MapSource.FromUri(new Uri("https://cdn.syncfusion.com/maps/map-data/world-map.json"));
    layer.DataSource = viewModel.Data;
    layer.PrimaryValuePath = "State";
    layer.ShapeDataField = "name";
    layer.ShowDataLabels = true;

    layer.DataLabelSettings = new MapDataLabelSettings()
    {
       DataLabelPath = "State",
       OverflowMode = MapLabelOverflowMode.Trim,
       DataLabelStyle = new MapLabelStyle()
       {
           FontSize = 12
       },
    };

    maps.Layer = layer;
    this.Content = maps;
}

{% endhighlight %}

{% endtabs %}
</td></tr>
</table>

## Color mappings

<table>
<tr>
<th>Xamarin SfMaps</th>
<th>.NET MAUI SfMaps</th>
</tr>
<tr>
   <td>
      {{'[Color](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.ColorMapping.html#Syncfusion_SfMaps_XForms_ColorMapping_Color)'| markdownify }}
   </td>
   <td>
      {{'[Color](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.ColorMapping.html#Syncfusion_Maui_Maps_ColorMapping_Color)'| markdownify }}
   </td>
</tr>
<tr>
   <td>
      {{'[LegendLabel](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.ColorMapping.html#Syncfusion_SfMaps_XForms_ColorMapping_LegendLabel)'| markdownify }}
   </td>
   <td>
      {{'[*Text](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.ColorMapping.html#Syncfusion_Maui_Maps_ColorMapping_Text)'| markdownify }}
   </td>
</tr>
<tr>
   <td>
      {{'[EqualColorMapping](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.EqualColorMapping.html)'| markdownify }}
   </td>
   <td>
      {{'[EqualColorMapping](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.EqualColorMapping.html)'| markdownify }}
   </td>
</tr>
<tr>
   <td>
      {{'[RangeColorMapping](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.RangeColorMapping.html)'| markdownify }}
   </td>
   <td>
      {{'[RangeColorMapping](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.RangeColorMapping.html)'| markdownify }}
   </td>
</tr>
</table>

### Equal color mapping

<table>
<tr>
<th>Xamarin SfMaps</th>
<th>.NET MAUI SfMaps</th>
</tr>
<tr>
   <td>
      {{'[Value](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.EqualColorMapping.html#Syncfusion_SfMaps_XForms_EqualColorMapping_Value)'| markdownify }}
   </td>
   <td>
      {{'[Value](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.EqualColorMapping.html#Syncfusion_Maui_Maps_EqualColorMapping_Value)'| markdownify }}
   </td>
</tr>
</table>

### Range color mapping

<table>
<tr>
<th>Xamarin SfMaps</th>
<th>.NET MAUI SfMaps</th>
</tr>
<tr>
   <td>
      {{'[From](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.RangeColorMapping.html#Syncfusion_SfMaps_XForms_RangeColorMapping_From)'| markdownify }}
   </td>
   <td>
      {{'[From](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.RangeColorMapping.html#Syncfusion_Maui_Maps_RangeColorMapping_From)'| markdownify }}
   </td>
</tr>
<tr>
   <td>
      {{'[To](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.RangeColorMapping.html#Syncfusion_SfMaps_XForms_RangeColorMapping_To)'| markdownify }}
   </td>
   <td>
      {{'[To](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.RangeColorMapping.html#Syncfusion_Maui_Maps_RangeColorMapping_To)'| markdownify }}
   </td>
</tr>
</table>

N> All the (*) marked APIs are renamed from Xamarin SfMaps to maintain the consistency of API naming in the .NET MAUI SfMaps.

The following code example explains how to customize the shape color in the Xamarin SfMaps and .NET MAUI SfMaps.

<table>
<tr>
<th>Xamarin SfMaps</th>
<th>.NET MAUI SfMaps</th></tr>
<tr>
<td>
{% tabs %}

{% highlight xaml %}

<maps:SfMaps>
    <maps:SfMaps.Layers >
        <maps:ShapeFileLayer Uri="world.shp"
                             ItemsSource="{Binding Data}"
                             ShapeIDPath="State"
                             ShapeIDTableField="name">
            <maps:ShapeFileLayer.ShapeSettings>
                <maps:ShapeSetting ShapeValuePath="Count" ShapeColorValuePath="Count" >
                    <maps:ShapeSetting.ColorMappings>
                        <maps:EqualColorMapping Color="Blue" Value="100" Text="100"/>
                        <maps:RangeColorMapping Color="Green" From="0" To="99" Text="0-99"/>
                    </maps:ShapeSetting.ColorMappings>
                </maps:ShapeSetting>
            </maps:ShapeFileLayer.ShapeSettings>
        </maps:ShapeFileLayer>
    </maps:SfMaps.Layers>
</maps:SfMaps>

{% endhighlight %}

{% highlight C# %}

    ViewModel viewModel = new ViewModel();
    this.BindingContext = viewModel;
    SfMaps maps = new SfMaps();

    ShapeFileLayer layer = new ShapeFileLayer();
    layer.Uri = "world.shp";           
    layer.ShapeIDPath="State"
    layer.ShapeIDTableField="name"
    layer.DataSource = viewModel.Data;

    EqualColorMapping colorMapping = new EqualColorMapping();
    colorMapping.Color = Colors.Blue;
    colorMapping.Value = "100";
    colorMapping.Text = "100";

    RangeColorMapping colorMapping1 = new RangeColorMapping();
    colorMapping1.Color = Colors.Green;
    colorMapping1.From = 0;
    colorMapping1.To = 99;
    colorMapping1.Text = "0-99";
    
    ShapeSetting shapeSetting = new ShapeSetting();
    shapeSetting.ShapeValuePath = "Count";
    shapeSetting.ShapeColorValuePath = "Count";
    
    shapeSetting.ColorMappings.Add(colorMapping);
    shapeSetting.ColorMappings.Add(colorMapping1);

    layer.ShapeSettings = shapeSetting;

    maps.Layers.Add(layer);

{% endhighlight %}

{% endtabs %}
</td>
<td>
{% tabs %}

{% highlight xaml %}

<map:SfMaps>
    <map:SfMaps.Layer>
        <map:MapShapeLayer ShapesSource="https://cdn.syncfusion.com/maps/map-data/world-map.json"
                           DataSource="{Binding Data}"
                           PrimaryValuePath="State"
                           ShapeDataField="name"
                           ShapeColorValuePath="Count">
            <map:MapShapeLayer.ColorMappings>
                <map:EqualColorMapping Color="Blue" Value="100" Text="100"/>
                <map:RangeColorMapping Color="Green" From="0" To="99" Text="0-99"/>
            </map:MapShapeLayer.ColorMappings>
        </map:MapShapeLayer>
    </map:SfMaps.Layer>
</map:SfMaps>

{% endhighlight %}

{% highlight C# %}

public MainPage()
{
   InitializeComponent();
    ViewModel viewModel = new ViewModel();
    this.BindingContext = viewModel;
    SfMaps maps = new SfMaps();
    MapShapeLayer layer = new MapShapeLayer();
    layer.ShapesSource = MapSource.FromUri(new Uri("https://cdn.syncfusion.com/maps/map-data/world-map.json"));
    layer.DataSource = viewModel.Data;
    layer.PrimaryValuePath = "State";
    layer.ShapeDataField = "name";
    layer.ShapeColorValuePath = "Count";

    EqualColorMapping colorMapping = new EqualColorMapping();
    colorMapping.Color = Colors.Blue;
    colorMapping.Value = "100";
    colorMapping.Text = "100";

    RangeColorMapping colorMapping1 = new RangeColorMapping();
    colorMapping1.Color = Colors.Green;
    colorMapping1.From = 0;
    colorMapping1.To = 99;
    colorMapping1.Text = "0-99";

    layer.ColorMappings.Add(colorMapping);
    layer.ColorMappings.Add(colorMapping1);

    maps.Layer = layer;
    this.Content = maps;
}

{% endhighlight %}

{% endtabs %}
</td></tr>
</table>

## Markers

<table>
<tr>
<th>Xamarin SfMaps</th>
<th>.NET MAUI SfMaps</th>
</tr>
<tr>
   <td>
      {{'[Latitude](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.MapMarker.html#Syncfusion_SfMaps_XForms_MapMarker_Latitude)'| markdownify }}
   </td>
   <td>
      {{'[Latitude](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapMarker.html#Syncfusion_Maui_Maps_MapMarker_Latitude)'| markdownify }}
   </td>
</tr>
<tr>
   <td>
      {{'[Longitude](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.MapMarker.html#Syncfusion_SfMaps_XForms_MapMarker_Longitude)'| markdownify }}
   </td>
   <td>
      {{'[Longitude](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapMarker.html#Syncfusion_Maui_Maps_MapMarker_Longitude)'| markdownify }}
   </td>
</tr>
<tr>
   <td>
      {{'[IconColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.MapMarkerSetting.html#Syncfusion_SfMaps_XForms_MapMarkerSetting_IconColor)'| markdownify }} in
      {{'[MapMarkerSetting](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.MapMarkerSetting.html)'| markdownify }}
   </td>
   <td>
      {{'[*IconFill](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapMarker.html#Syncfusion_Maui_Maps_MapMarker_IconFill)'| markdownify }}
   </td>
</tr>
<tr>
   <td>
      {{'[IconSize](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.MapMarkerSetting.html#Syncfusion_SfMaps_XForms_MapMarkerSetting_IconSize)'| markdownify }} in
      {{'[MapMarkerSetting](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.MapMarkerSetting.html)'| markdownify }}
   </td>
   <td>
      Divided into {{'[*IconHeight](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapMarker.html#Syncfusion_Maui_Maps_MapMarker_IconHeight)'| markdownify }} and
       {{'[*IconWidth](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapMarker.html#Syncfusion_Maui_Maps_MapMarker_IconWidth)'| markdownify }}
   </td>
</tr>
<tr>
   <td>
      {{'[MarkerIcon](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.MapMarkerSetting.html#Syncfusion_SfMaps_XForms_MapMarkerSetting_MarkerIcon)'| markdownify }} in
      {{'[MapMarkerSetting](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.MapMarkerSetting.html)'| markdownify }}
   </td>
   <td>
      {{'[*IconType](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapMarker.html#Syncfusion_Maui_Maps_MapMarker_IconType)'| markdownify }}
   </td>
</tr>
<tr>
   <td>
      {{'[HorizontalAlignment](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.MapMarkerSetting.html#Syncfusion_SfMaps_XForms_MapMarkerSetting_HorizontalAlignment)'| markdownify }} in
      {{'[MapMarkerSetting](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.MapMarkerSetting.html)'| markdownify }}
   </td>
   <td>
      {{'[HorizontalAlignment](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapMarker.html#Syncfusion_Maui_Maps_MapMarker_HorizontalAlignment)'| markdownify }}
   </td>
</tr>
<tr>
   <td>
      {{'[VerticalAlignment](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.MapMarkerSetting.html#Syncfusion_SfMaps_XForms_MapMarkerSetting_VerticalAlignment)'| markdownify }} in
      {{'[MapMarkerSetting](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.MapMarkerSetting.html)'| markdownify }}
   </td>
   <td>
      {{'[VerticalAlignment](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapMarker.html#Syncfusion_Maui_Maps_MapMarker_VerticalAlignment)'| markdownify }}
   </td>
</tr>
</table>

N> All the (*) marked APIs are renamed from Xamarin SfMaps to maintain the consistency of API naming in the .NET MAUI SfMaps.

The following code example explains how to customize marker in the Xamarin SfMaps and .NET MAUI SfMaps.

<table>
<tr>
<th>Xamarin SfMaps</th>
<th>.NET MAUI SfMaps</th></tr>
<tr>
<td>
{% tabs %}

{% highlight xaml %}

<maps:SfMaps>
    <maps:SfMaps.Layers >
        <maps:ShapeFileLayer Uri="world.shp"
                             ShowMapItems="True">
            <maps:ShapeFileLayer.Markers>
                <maps:MapMarker Latitude="20.5595"
                                Longitude="22.9375"/>
            </maps:ShapeFileLayer.Markers>
            <maps:ShapeFileLayer.MarkerSettings>
                <maps:MapMarkerSetting IconColor="Red"/>
            </maps:ShapeFileLayer.MarkerSettings>
        </maps:ShapeFileLayer>
    </maps:SfMaps.Layers>
</maps:SfMaps>

{% endhighlight %}

{% highlight C# %}

    SfMaps maps = new SfMaps();

    ShapeFileLayer layer = new ShapeFileLayer();
    layer.Uri = "world.shp";           

    MapMarker mapMarker = new MapMarker();
    mapMarker.Latitude = 20.5595;
    mapMarker.Longitude = 22.9375;
    layer.Markers.Add(marker);

    MapMarkerSetting mapMarkerSetting = new MapMarkerSetting();
    mapMarkerSetting.IconColor = Colors.Red;
    layer.MarkerSettings = mapMarkerSetting;

    maps.Layers.Add(layer);

{% endhighlight %}

{% endtabs %}
</td>
<td>
{% tabs %}

{% highlight xaml %}

<map:SfMaps>
    <map:SfMaps.Layer>
        <map:MapShapeLayer ShapesSource="https://cdn.syncfusion.com/maps/map-data/world-map.json">
            <map:MapShapeLayer.Markers>
                <map:MapMarkerCollection>
                    <map:MapMarker Latitude="20.5595"
                                   Longitude="22.9375"
                                   IconFill="Red"/>
                </map:MapMarkerCollection>
            </map:MapShapeLayer.Markers>
        </map:MapShapeLayer>
    </map:SfMaps.Layer>
</map:SfMaps>

{% endhighlight %}

{% highlight C# %}

public MainPage()
{
   InitializeComponent();
    SfMaps maps = new SfMaps();
    MapShapeLayer layer = new MapShapeLayer();
    layer.ShapesSource = MapSource.FromUri(new Uri("https://cdn.syncfusion.com/maps/map-data/world-map.json"));

    MapMarker mapMarker = new MapMarker();
    mapMarker.Latitude = 20.5595;
    mapMarker.Longitude = 22.9375;
    mapMarker.IconFill = Colors.Red;

    maps.Layer = layer;
    this.Content = maps;
}

{% endhighlight %}

{% endtabs %}
</td></tr>
</table>

## Legend

<table>
<tr>
<th>Xamarin SfMaps</th>
<th>.NET MAUI SfMaps</th>
</tr>
<tr>
   <td>
      {{'[LegendType](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.MapLegendSetting.html#Syncfusion_SfMaps_XForms_MapLegendSetting_LegendType)'| markdownify }} in
      {{'[MapLegendSetting](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.MapLegendSetting.html)'| markdownify }}
   </td>
   <td>
      {{'[*SourceType](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapLegend.html#Syncfusion_Maui_Maps_MapLegend_SourceType)'| markdownify }}
   </td>
</tr>
<tr>
   <td>
      {{'[TextColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.MapLegendSetting.html#Syncfusion_SfMaps_XForms_MapLegendSetting_TextColor)'| markdownify }},
      {{'[FontSize](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.MapLegendSetting.html#Syncfusion_SfMaps_XForms_MapLegendSetting_FontSize)'| markdownify }},
      {{'[FontFamily](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.MapLegendSetting.html#Syncfusion_SfMaps_XForms_MapLegendSetting_FontFamily)'| markdownify }}, and
      {{'[FontAttributes](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.MapLegendSetting.html#Syncfusion_SfMaps_XForms_MapLegendSetting_FontAttributes)'| markdownify }} in
      {{'[MapLegendSetting](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.MapLegendSetting.html)'| markdownify }}
   </td>
   <td>
      {{'[*TextStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapLegend.html#Syncfusion_Maui_Maps_MapLegend_TextStyle)'| markdownify }}
   </td>
</tr>
<tr>
   <td>
      {{'[IconSize](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.MapLegendSetting.html#Syncfusion_SfMaps_XForms_MapLegendSetting_IconSize)'| markdownify }} in
      {{'[MapLegendSetting](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.MapLegendSetting.html)'| markdownify }}
   </td>
   <td>
      {{'[IconSize](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapLegend.html#Syncfusion_Maui_Maps_MapLegend_IconSize)'| markdownify }}
   </td>
</tr>
<tr>
   <td>
      {{'[LegendIcon](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.MapLegendSetting.html#Syncfusion_SfMaps_XForms_MapLegendSetting_LegendIcon)'| markdownify }} in
      {{'[MapLegendSetting](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.MapLegendSetting.html)'| markdownify }}
   </td>
   <td>
      {{'[*IconType](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapLegend.html#Syncfusion_Maui_Maps_MapLegend_IconType)'| markdownify }}
   </td>
</tr>
</table>

N> All the (*) marked APIs are renamed from Xamarin SfMaps to maintain the consistency of API naming in the .NET MAUI SfMaps.

The following code example explains how to customize legend in the Xamarin SfMaps and .NET MAUI SfMaps.

<table>
<tr>
<th>Xamarin SfMaps</th>
<th>.NET MAUI SfMaps</th></tr>
<tr>
<td>
{% tabs %}

{% highlight xaml %}

<maps:SfMaps>
    <maps:SfMaps.Layers >
        <maps:ShapeFileLayer Uri="world.shp"
                             ItemsSource="{Binding Data}"
                             ShapeIDPath="State"
                             ShapeIDTableField="name">
            <maps:ShapeFileLayer.ShapeSettings>
                <maps:ShapeSetting ShapeValuePath="Count" ShapeColorValuePath="Count" >
                    <maps:ShapeSetting.ColorMappings>
                        <map:EqualColorMapping Color="Blue" Value="100" Text="100"/>
                    </maps:ShapeSetting.ColorMappings>
                </maps:ShapeSetting>
            </maps:ShapeFileLayer.ShapeSettings>
            <maps:ShapeFileLayer.LegendSettings>
                        <maps:MapLegendSetting ShowLegend="True" LegendType="Layers">
                        </maps:MapLegendSetting>
                    </maps:ShapeFileLayer.LegendSettings>
        </maps:ShapeFileLayer>
    </maps:SfMaps.Layers>
</maps:SfMaps>

{% endhighlight %}

{% highlight C# %}

    ViewModel viewModel = new ViewModel();
    this.BindingContext = viewModel;
    SfMaps maps = new SfMaps();

    ShapeFileLayer layer = new ShapeFileLayer();
    layer.Uri = "world.shp";           
    layer.ShapeIDPath="State"
    layer.ShapeIDTableField="name"
    layer.DataSource = viewModel.Data;

    EqualColorMapping colorMapping = new EqualColorMapping();
    colorMapping.Color = Colors.Blue;
    colorMapping.Value = "100";
    colorMapping.Text = "100";
    
    ShapeSetting shapeSetting = new ShapeSetting();
    shapeSetting.ShapeValuePath = "Count";
    shapeSetting.ShapeColorValuePath = "Count";

    MapLegendSetting legendSetting = new MapLegendSetting();
    legendSetting.ShowLegend = true;
    legendSetting.LegendType = LegendType.Layers;
    layer.LegendSettings = legendSetting;

    shapeSetting.ColorMappings.Add(colorMapping);

    layer.ShapeSettings = shapeSetting;

    maps.Layers.Add(layer);

{% endhighlight %}

{% endtabs %}
</td>
<td>
{% tabs %}

{% highlight xaml %}

<map:SfMaps>
    <map:SfMaps.Layer>
        <map:MapShapeLayer ShapesSource="https://cdn.syncfusion.com/maps/map-data/world-map.json"
                           DataSource="{Binding Data}"
                           PrimaryValuePath="State"
                           ShapeDataField="name"
                           ShapeColorValuePath="Count">
            <map:MapShapeLayer.ColorMappings>
                <map:EqualColorMapping Color="Blue" Value="100" Text="100"/>
            </map:MapShapeLayer.ColorMappings>
            <map:MapShapeLayer.Legend>
                <map:MapLegend SourceType="Shape"
                               Placement="Top"
                               IconSize="20, 20"
                               IconType="Diamond">
                    <map:MapLegend.TextStyle>
                        <map:MapLabelStyle FontSize="16"/>
                    </map:MapLegend.TextStyle>
                </map:MapLegend>
            </map:MapShapeLayer.Legend>
        </map:MapShapeLayer>
    </map:SfMaps.Layer>
</map:SfMaps>

{% endhighlight %}

{% highlight C# %}

public MainPage()
{
   InitializeComponent();
    ViewModel viewModel = new ViewModel();
    this.BindingContext = viewModel;
    SfMaps maps = new SfMaps();
    MapShapeLayer layer = new MapShapeLayer();
    layer.ShapesSource = MapSource.FromUri(new Uri("https://cdn.syncfusion.com/maps/map-data/world-map.json"));
    layer.DataSource = viewModel.Data;
    layer.PrimaryValuePath = "State";
    layer.ShapeDataField = "name";
    layer.ShapeColorValuePath = "Count";

    EqualColorMapping colorMapping = new EqualColorMapping();
    colorMapping.Color = Colors.Blue;
    colorMapping.Value = "100";
    colorMapping.Text = "100";

    layer.ColorMappings.Add(colorMapping);

    MapLegend legendSet = new MapLegend();
    legendSet.SourceType = LegendSourceType.Shape;
    legendSet.Placement = Syncfusion.Maui.Core.LegendPlacement.Top;
    legendSet.IconSize = new Size(20, 20);
    legendSet.IconType = Syncfusion.Maui.Core.ShapeType.Diamond;
    MapLabelStyle mapLabelStyle = new MapLabelStyle();
    mapLabelStyle.FontSize = 16;
        
    legendSet.TextStyle = mapLabelStyle;
    layer.Legend = legendSet;

    maps.Layer = layer;
    this.Content = maps;
}

{% endhighlight %}

{% endtabs %}
</td></tr>
</table>

## Tooltip

<table>
<tr>
<th>Xamarin SfMaps</th>
<th>.NET MAUI SfMaps</th>
</tr>
<tr>
   <td>
      {{'[TooltipSetting](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.TooltipSetting.html)'| markdownify }}
   </td>
   <td>
      {{'[*MapTooltipSettings](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapTooltipSettings.html?tabs=tabid-1)'| markdownify }}
   </td>
</tr>
<tr>
   <td>
      {{'[ShowTooltip](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.TooltipSetting.html#Syncfusion_SfMaps_XForms_TooltipSetting_ShowTooltip)'| markdownify }} in 
      {{'[TooltipSetting](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.TooltipSetting.html)'| markdownify }}
   </td>
   <td>
      Divided into {{'[*ShowShapeTooltip](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_ShowShapeTooltip)'| markdownify }}, {{'[*ShowBubbleTooltip](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_ShowBubbleTooltip)'| markdownify }} and {{'[*ShowMarkerTooltip](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapLayer.html#Syncfusion_Maui_Maps_MapLayer_ShowMarkerTooltip)'| markdownify }}
   </td>
</tr>
<tr>
   <td>
      {{'[TooltipSetting](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.ShapeFileLayer.html#Syncfusion_SfMaps_XForms_ShapeFileLayer_TooltipSettings)'| markdownify }} in 
      {{'[ShapeFileLayer](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.ShapeFileLayer.html)'| markdownify }}

   </td>
   <td>
      {{'[*ShapeTooltipSettings](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_ShapeTooltipSettings)'| markdownify }}
   </td>
</tr>
<tr>
   <td>
      {{'[TooltipSetting](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.BubbleMarkerSetting.html#Syncfusion_SfMaps_XForms_BubbleMarkerSetting_TooltipSettings)'| markdownify }} in 
      {{'[BubbleMarkerSetting](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.BubbleMarkerSetting.html)'| markdownify }}

   </td>
   <td>
      {{'[*BubbleTooltipSettings](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_BubbleTooltipSettings)'| markdownify }}
   </td>
</tr>
<tr>
   <td>
      {{'[TooltipSetting](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.MapMarkerSetting.html#Syncfusion_SfMaps_XForms_MapMarkerSetting_TooltipSettings)'| markdownify }} in 
      {{'[MapMarkerSetting](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.MapMarkerSetting.html)'| markdownify }}

   </td>
   <td>
      {{'[*MarkerTooltipSettings](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapLayer.html#Syncfusion_Maui_Maps_MapLayer_MarkerTooltipSettings)'| markdownify }}
   </td>
</tr>
</table>

### Tooltip settings

<table>
<tr>
<th>Xamarin SfMaps</th>
<th>.NET MAUI SfMaps</th>
</tr>
<tr>
   <td>
      {{'[BackgroundColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.TooltipSetting.html#Syncfusion_SfMaps_XForms_TooltipSetting_BackgroundColor)'| markdownify }}
   </td>
   <td>
      {{'[*Background](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapTooltipSettings.html#Syncfusion_Maui_Maps_MapTooltipSettings_Background)'| markdownify }}
   </td>
</tr>
<tr>
   <td>
      {{'[Margin](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.TooltipSetting.html#Syncfusion_SfMaps_XForms_TooltipSetting_Margin)'| markdownify }}
   </td>
   <td>
      {{'[*Padding](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapTooltipSettings.html#Syncfusion_Maui_Maps_MapTooltipSettings_Padding)'| markdownify }}
   </td>
</tr>
<tr>
   <td>
      {{'[TextColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.TooltipSetting.html#Syncfusion_SfMaps_XForms_TooltipSetting_TextColor)'| markdownify }}, 
      {{'[FontSize](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.TooltipSetting.html#Syncfusion_SfMaps_XForms_TooltipSetting_FontSize)'| markdownify }}, 
      {{'[FontFamily](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.TooltipSetting.html#Syncfusion_SfMaps_XForms_TooltipSetting_FontFamily)'| markdownify }} and 
      {{'[FontAttributes](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.TooltipSetting.html#Syncfusion_SfMaps_XForms_TooltipSetting_FontAttributes)'| markdownify }}

   </td>
   <td>
      {{'[*TextStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapTooltipSettings.html#Syncfusion_Maui_Maps_MapTooltipSettings_TextStyle)'| markdownify }}
   </td>
</tr>
</table>

N> All the (*) marked APIs are renamed from Xamarin SfMaps to maintain the consistency of API naming in the .NET MAUI SfMaps.

The following code example explains how to customize tooltip in the Xamarin SfMaps and .NET MAUI SfMaps.

<table>
<tr>
<th>Xamarin SfMaps</th>
<th>.NET MAUI SfMaps</th></tr>
<tr>
<td>
{% tabs %}

{% highlight xaml %}

<maps:SfMaps>
    <maps:SfMaps.Layers >
        <maps:ShapeFileLayer Uri="world.shp"
                             ItemsSource="{Binding Data}"
                             ShapeIDPath="State"
                             ShapeIDTableField="name">
            <maps:ShapeFileLayer.TooltipSettings>
                <maps:TooltipSetting  ShowTooltip="True"
                                      ValuePath="Count"/>
    </maps:ShapeFileLayer.TooltipSettings>
        </maps:ShapeFileLayer>
    </maps:SfMaps.Layers>
</maps:SfMaps>

{% endhighlight %}

{% highlight C# %}

    ViewModel viewModel = new ViewModel();
    this.BindingContext = viewModel;
    SfMaps maps = new SfMaps();

    ShapeFileLayer layer = new ShapeFileLayer();
    layer.Uri = "world.shp";           
    layer.ShapeIDPath="State"
    layer.ShapeIDTableField="name"
    layer.DataSource = viewModel.Data;

    shapeFileLayer.TooltipSettings.ShowTooltip = true;
    shapeFileLayer.TooltipSettings.ValuePath = "Count";

    layer.ShapeSettings = shapeSetting;

    maps.Layers.Add(layer);

{% endhighlight %}

{% endtabs %}
</td>
<td>
{% tabs %}

{% highlight xaml %}

<map:SfMaps>
    <map:SfMaps.Layer>
        <map:MapShapeLayer ShapesSource="https://cdn.syncfusion.com/maps/map-data/world-map.json"
                           DataSource="{Binding Data}"
                           PrimaryValuePath="State"
                           ShapeDataField="name"
                           ShapeColorValuePath="Count"
                           ShowShapeToolTip="True">

                  <map:MapShapeLayer.ShapeTooltipSettings>
                    <map:MapTooltipSettings Background="#002080"
                                            Padding="2">
                        <map:MapTooltipSettings.TextStyle>
                            <map:MapLabelStyle FontSize="14"
                                               TextColor="White"
                                               FontAttributes="Bold">
                            </map:MapLabelStyle>
                        </map:MapTooltipSettings.TextStyle>
                    </map:MapTooltipSettings>
                </map:MapShapeLayer.ShapeTooltipSettings>
        </map:MapShapeLayer>
    </map:SfMaps.Layer>
</map:SfMaps>

{% endhighlight %}

{% highlight C# %}

    public ToolTip()
    {
        InitializeComponent();

        ViewModel viewModel = new ViewModel();
        this.BindingContext = viewModel;  

        MapShapeLayer layer = new MapShapeLayer();
        layer.ShapesSource = MapSource.FromUri(new Uri("https://cdn.syncfusion.com/maps/map-data/world-map.json"));
        layer.PrimaryValuePath = "Continent";
        layer.ShapeDataField = "continent";
        layer.DataSource = viewModel.Data;
        layer.ShowShapeTooltip = true;

        layer.ShapeTooltipSettings = new MapTooltipSettings()
        {
            Background = Color.FromArgb("#002080"),
            Padding = new Thickness(2),
            TextStyle = new MapLabelStyle()
            {
                FontSize = 14,
                TextColor = Colors.White,
                FontAttributes = FontAttributes.Bold
            }
        };

        SfMaps maps = new SfMaps();
        maps.Layer = layer;
        this.Content = maps;
    }

{% endhighlight %}

{% endtabs %}
</td></tr>
</table>

## Shape sublayer

<table>
<tr>
   <th>Xamarin SfMaps</th>
   <th>.NET MAUI SfMaps</th>
</tr>
<tr>
   <td>
      {{'[BubbleMarkerSettings](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.ShapeFileLayer.html#Syncfusion_SfMaps_XForms_ShapeFileLayer_BubbleMarkerSettings)'| markdownify }}
   </td>
   <td>
      {{'[*BubbleSettings](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeSublayer.html#Syncfusion_Maui_Maps_MapShapeSublayer_BubbleSettings)'| markdownify }}
   </td>
</tr>
<tr>
   <td>
      {{'[DataLabelSettings](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.ShapeFileLayer.html#Syncfusion_SfMaps_XForms_ShapeFileLayer_DataLabelSettings)'| markdownify }}
   </td>
   <td>
      {{'[DataLabelSettings](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeSublayer.html#Syncfusion_Maui_Maps_MapShapeSublayer_DataLabelSettings)'| markdownify }}
   </td>
</tr>
<tr>
   <td>
      {{'[ItemsSource](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.ShapeFileLayer.html#Syncfusion_SfMaps_XForms_ShapeFileLayer_ItemsSource)'| markdownify }}
   </td>
   <td>
      {{'[*DataSource](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeSublayer.html#Syncfusion_Maui_Maps_MapShapeSublayer_DataSource)'| markdownify }}
   </td>
</tr>
<tr>
   <td>
      {{'[ShapeIDPath](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.ShapeFileLayer.html#Syncfusion_SfMaps_XForms_ShapeFileLayer_ShapeIDPath)'| markdownify }}
   </td>
   <td>
      {{'[*PrimaryValuePath](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeSublayer.html#Syncfusion_Maui_Maps_MapShapeSublayer_PrimaryValuePath)'| markdownify }}
   </td>
</tr>
<tr>
   <td>
      {{'[ShapeIDTableField](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.ShapeFileLayer.html#Syncfusion_SfMaps_XForms_ShapeFileLayer_ShapeIDTableField)'| markdownify }}
   </td>
   <td>
      {{'[*ShapeDataField](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeSublayer.html#Syncfusion_Maui_Maps_MapShapeSublayer_ShapeDataField)'| markdownify }}
   </td>
</tr>
<tr>
   <td>
      {{'[Uri](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.ShapeFileLayer.html#Syncfusion_SfMaps_XForms_ShapeFileLayer_Uri)'| markdownify }}
   </td>
   <td>
      {{'[*ShapesSource](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeSublayer.html#Syncfusion_Maui_Maps_MapShapeSublayer_ShapesSource)'| markdownify }}
   </td>
</tr>
<tr>
   <td>
      {{'[ColorMappings](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.ShapeSetting.html#Syncfusion_SfMaps_XForms_ShapeSetting_ColorMappings)'| markdownify }} in
       {{'[ShapeSetting](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.ShapeSetting.html)'| markdownify }} class
   </td>
   <td>
      {{'[ColorMappings](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeSublayer.html#Syncfusion_Maui_Maps_MapShapeSublayer_ColorMappings)'| markdownify }}
   </td>
</tr>
<tr>
   <td>
      {{'[ShapeFill](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.ShapeSetting.html#Syncfusion_SfMaps_XForms_ShapeSetting_ShapeFill)'| markdownify }} in
       {{'[ShapeSetting](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.ShapeSetting.html)'| markdownify }} class
   </td>
   <td>
      {{'[ShapeFill](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeSublayer.html#Syncfusion_Maui_Maps_MapShapeSublayer_ShapeFill)'| markdownify }}
   </td>
</tr>
<tr>
   <td>
      {{'[ShapeStroke](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.ShapeSetting.html#Syncfusion_SfMaps_XForms_ShapeSetting_ShapeStroke)'| markdownify }} in
       {{'[ShapeSetting](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.ShapeSetting.html)'| markdownify }} class
   </td>
   <td>
      {{'[ShapeStroke](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeSublayer.html#Syncfusion_Maui_Maps_MapShapeSublayer_ShapeStroke)'| markdownify }}
   </td>
</tr>
<tr>
   <td>
      {{'[ShapeStrokeThickness](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.ShapeSetting.html#Syncfusion_SfMaps_XForms_ShapeSetting_ShapeStrokeThickness)'| markdownify }} in
       {{'[ShapeSetting](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.ShapeSetting.html)'| markdownify }} class
   </td>
   <td>
      {{'[ShapeStrokeThickness](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeSublayer.html#Syncfusion_Maui_Maps_MapShapeSublayer_ShapeStrokeThickness)'| markdownify }}
   </td>
</tr>
<tr>
   <td>
      {{'[ShapeColorValuePath](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.ShapeSetting.html#Syncfusion_SfMaps_XForms_ShapeSetting_ShapeColorValuePath)'| markdownify }} and {{'[ShapeValuePath](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.ShapeSetting.html#Syncfusion_SfMaps_XForms_ShapeSetting_ShapeValuePath)'| markdownify }} in
       {{'[ShapeSetting](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.ShapeSetting.html)'| markdownify }} class
   </td>
   <td>
      {{'[ShapeColorValuePath](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeSublayer.html#Syncfusion_Maui_Maps_MapShapeSublayer_ShapeColorValuePath)'| markdownify }}
   </td>
</tr>
</table>

N> All the (*) marked APIs are renamed from Xamarin SfMaps to maintain the consistency of API naming in the .NET MAUI SfMaps.

The following code example explains how to initialize the shape sublayer and it's customization in the Xamarin SfMaps and .NET MAUI SfMaps.

<table>
<tr>
<th>Xamarin SfMaps</th>
<th>.NET MAUI SfMaps</th></tr>
<tr>
<td>
{% tabs %}

{% highlight xaml %}

<maps:SfMaps>
    <maps:SfMaps.Layers>
        <maps:ShapeFileLayer Uri="world1.shp">
            <maps:ShapeFileLayer.Sublayers>
                <maps:ShapeFileLayer Uri="usa_state.shp">
                    <maps:ShapeFileLayer.ShapeSettings>
                        <maps:ShapeSetting  ShapeFill="#8DCCF4"
                                            ShapeStroke="#B1D8F5"
                                            ShapeStrokeThickness="1">
                        </maps:ShapeSetting>
                    </maps:ShapeFileLayer.ShapeSettings>
                </maps:ShapeFileLayer>
            </maps:ShapeFileLayer.Sublayers>
        </maps:ShapeFileLayer>
    </maps:SfMaps.Layers>
</maps:SfMaps>

{% endhighlight %}

{% highlight C# %}

SfMaps map = new SfMaps();
map.BackgroundColor = Color.White;
ShapeFileLayer layer = new ShapeFileLayer();
layer.Uri = "world1.shp";
ShapeFileLayer subShapeLayer = new ShapeFileLayer();
subShapeLayer.Uri = "usa_state.shp";
ShapeSetting shapeSetting = new ShapeSetting();
shapeSetting.ShapeFill = Color.FromRgb(181, 220, 255);
shapeSetting.ShapeStroke = Color.FromRgb(21, 133, 237);
subShapeLayer.ShapeSettings = shapeSetting;
layer.Sublayers.Add(subShapeLayer);
map.Layers.Add(layer);
this.Content = map;

{% endhighlight %}

{% endtabs %}
</td>
<td>
{% tabs %}

{% highlight xaml %}

<map:SfMaps>
    <map:SfMaps.Layer>
        <map:MapShapeLayer ShapesSource="https://cdn.syncfusion.com/maps/map-data/world-map.json">
            <map:MapShapeLayer.Sublayers>
                <map:MapShapeSublayer ShapeStroke="#B1D8F5"
                                      ShapeFill="#8DCCF4"
                                      ShapeStrokeThickness = "1"
                                      ShapesSource="https://cdn.syncfusion.com/maps/map-data/africa.json">
                </map:MapShapeSublayer>
            </map:MapShapeLayer.Sublayers>
        </map:MapShapeLayer>
    </map:SfMaps.Layer>
</map:SfMaps>

{% endhighlight %}

{% highlight C# %}

public MainPage()
{
    InitializeComponent();
    SfMaps maps = new SfMaps();
    MapShapeLayer layer = new MapShapeLayer();
    layer.ShapesSource = MapSource.FromUri(new Uri("https://cdn.syncfusion.com/maps/map-data/world-map.json"));
    MapShapeSublayer sublayer = new MapShapeSublayer();
    sublayer.ShapesSource = MapSource.FromUri(new Uri("https://cdn.syncfusion.com/maps/map-data/africa.json"));
    sublayer.ShapeFill = Color.FromRgb(81, 220, 255);
    sublayer.ShapeStroke = Color.FromRgb(21, 133, 237);
    sublayer.ShapeStrokeThickness = 1;
    layer.Sublayers.Add(sublayer);
    maps.Layer = layer;
    this.Content = maps;
}

{% endhighlight %}

{% endtabs %}
</td></tr>
</table>

### Bubble settings

<table>
<tr>
<th>Xamarin SfMaps</th>
<th>.NET MAUI SfMaps</th>
</tr>
<tr>
   <td>
      {{'[ColorMappings](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.BubbleMarkerSetting.html#Syncfusion_SfMaps_XForms_BubbleMarkerSetting_ColorMappings)'| markdownify }}
   </td>
   <td>
      {{'[ColorMappings](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapBubbleSettings.html#Syncfusion_Maui_Maps_MapBubbleSettings_ColorMappings)'| markdownify }}
   </td>
</tr>
<tr>
   <td>
      {{'[ColorValuePath](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.BubbleMarkerSetting.html#Syncfusion_SfMaps_XForms_BubbleMarkerSetting_ColorValuePath)'| markdownify }}
   </td>
   <td>
      {{'[ColorValuePath](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapBubbleSettings.html#Syncfusion_Maui_Maps_MapBubbleSettings_ColorValuePath)'| markdownify }}
   </td>
</tr>
<tr>
   <td>
      {{'[Fill](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.BubbleMarkerSetting.html#Syncfusion_SfMaps_XForms_BubbleMarkerSetting_Fill)'| markdownify }}
   </td>
   <td>
      {{'[Fill](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapBubbleSettings.html#Syncfusion_Maui_Maps_MapBubbleSettings_Fill)'| markdownify }}
   </td>
</tr>
<tr>
   <td>
      {{'[MaxSize](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.BubbleMarkerSetting.html#Syncfusion_SfMaps_XForms_BubbleMarkerSetting_MaxSize)'| markdownify }}
   </td>
   <td>
      {{'[MaxSize](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapBubbleSettings.html#Syncfusion_Maui_Maps_MapBubbleSettings_MaxSize)'| markdownify }}
   </td>
</tr>
<tr>
   <td>
      {{'[MinSize](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.BubbleMarkerSetting.html#Syncfusion_SfMaps_XForms_BubbleMarkerSetting_MinSize)'| markdownify }}
   </td>
   <td>
      {{'[MinSize](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapBubbleSettings.html#Syncfusion_Maui_Maps_MapBubbleSettings_MinSize)'| markdownify }}
   </td>
</tr>
<tr>
   <td>
      {{'[Opacity](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.BubbleMarkerSetting.html#Syncfusion_SfMaps_XForms_BubbleMarkerSetting_Opacity)'| markdownify }}
   </td>
   <td>
      {{'[Opacity](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapBubbleSettings.html#Syncfusion_Maui_Maps_MapBubbleSettings_Opacity)'| markdownify }}
   </td>
</tr>
<tr>
   <td>
      {{'[ValuePath](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.BubbleMarkerSetting.html#Syncfusion_SfMaps_XForms_BubbleMarkerSetting_ValuePath)'| markdownify }}
   </td>
   <td>
      {{'[*SizeValuePath](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapBubbleSettings.html#Syncfusion_Maui_Maps_MapBubbleSettings_SizeValuePath)'| markdownify }}
   </td>
</tr>
<tr>
   <td>
      {{'[ShowBubbles](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.BubbleMarkerSetting.html#Syncfusion_SfMaps_XForms_BubbleMarkerSetting_ShowBubbles)'| markdownify }}
   </td>
   <td>
      {{'[ShowBubbles](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeSublayer.html#Syncfusion_Maui_Maps_MapShapeSublayer_ShowBubbles)'| markdownify }}
   </td>
</tr>
</table>

N> All the (*) marked APIs are renamed from Xamarin SfMaps to maintain the consistency of API naming in the .NET MAUI SfMaps.

The following code example explains how to customize the bubble in the Xamarin SfMaps and .NET MAUI SfMaps.

<table>
<tr>
<th>Xamarin SfMaps</th>
<th>.NET MAUI SfMaps</th></tr>
<tr>
<td>
{% tabs %}

{% highlight xaml %}

<maps:SfMaps>
    <maps:SfMaps.Layers>
        <maps:ShapeFileLayer Uri="world1.shp">
            <maps:ShapeFileLayer.Sublayers>
                <maps:ShapeFileLayer Uri="usa_state.shp"
                                     ItemsSource="{Binding DataSource}"
                                     ShapeIDPath="Name"
                                     ShapeIDTableField="STATE_NAME">
                    <maps:ShapeFileLayer.BubbleMarkerSettings>
                        <maps:BubbleMarkerSetting ShowBubbles="True"
                                                  ValuePath="index"
                                                  Fill="Orange"
                                                  Opacity="0.8" />
                    </maps:ShapeFileLayer.BubbleMarkerSettings>
                </maps:ShapeFileLayer>
            </maps:ShapeFileLayer.Sublayers>
        </maps:ShapeFileLayer>
    </maps:SfMaps.Layers>
</maps:SfMaps>

{% endhighlight %}

{% highlight C# %}

 ViewModel viewModel = new ViewModel();
this.BindingContext = viewModel;
SfMaps maps = new SfMaps();
ShapeFileLayer layer = new ShapeFileLayer();
layer.Uri = "world1.shp";
ShapeFileLayer subShapeLayer = new ShapeFileLayer();
subShapeLayer.Uri = "usa_state.shp";
subShapeLayer.ShapeIDTableField = "STATE_NAME";
subShapeLayer.ShapeIDPath = "Name";
subShapeLayer.ItemsSource = viewModel.DataSource;

BubbleMarkerSetting bubbleSetting = new BubbleMarkerSetting()
{
    ShowBubbles = true,
    ValuePath = "index",
    Fill = Color.Orange,
    Opacity = 0.8
};

subShapeLayer.BubbleMarkerSettings = bubbleSetting;
layer.Sublayers.Add(subShapeLayer);
maps.Layers.Add(layer);
this.Content = maps;

{% endhighlight %}

{% endtabs %}
</td>
<td>
{% tabs %}

{% highlight xaml %}

<map:SfMaps>
    <map:SfMaps.Layer>
        <map:MapShapeLayer ShapesSource="https://cdn.syncfusion.com/maps/map-data/world-map.json">
            <map:MapShapeLayer.Sublayers>
                <map:MapShapeSublayer  ShapesSource="https://cdn.syncfusion.com/maps/map-data/africa.json"
                                      ShapeDataField="name"
                                      DataSource="{Binding Data}"
                                      PrimaryValuePath="State"
                                      ShowBubbles="True">
                    <map:MapShapeSublayer.BubbleSettings>
                        <map:MapBubbleSettings ColorValuePath="Size"
                                               SizeValuePath="Size">
                        </map:MapBubbleSettings>
                    </map:MapShapeSublayer.BubbleSettings>
                </map:MapShapeSublayer>
            </map:MapShapeLayer.Sublayers>
        </map:MapShapeLayer>
    </map:SfMaps.Layer>
</map:SfMaps>

{% endhighlight %}

{% highlight C# %}

public MainPage()
{
    InitializeComponent();
    ViewModel viewModel = new ViewModel();
    this.BindingContext = viewModel;
    SfMaps maps = new SfMaps();
    MapShapeLayer layer = new MapShapeLayer();
    layer.ShapesSource = MapSource.FromUri(new Uri("https://cdn.syncfusion.com/maps/map-data/world-map.json"));
    MapShapeSublayer sublayer = new MapShapeSublayer();
    sublayer.ShapesSource = MapSource.FromUri(new Uri("https://cdn.syncfusion.com/maps/map-data/africa.json"));
    sublayer.DataSource = viewModel.Data;
    sublayer.PrimaryValuePath = "State";
    sublayer.ShapeDataField = "name";
    sublayer.ShowBubbles = true;

    MapBubbleSettings bubbleSetting = new MapBubbleSettings()
    {
        ColorValuePath = "Size",
        SizeValuePath = "Size",
    };

    sublayer.BubbleSettings = bubbleSetting;
    layer.Sublayers.Add(sublayer);
    maps.Layer = layer;
    this.Content = maps;
}

{% endhighlight %}

{% endtabs %}
</td></tr>
</table>

### Data label settings

<table>
<tr>
<th>Xamarin SfMaps</th>
<th>.NET MAUI SfMaps</th>
</tr>
<tr>
   <td>
      {{'[SmartLabelMode](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.DataLabelSetting.html#Syncfusion_SfMaps_XForms_DataLabelSetting_SmartLabelMode)'| markdownify }}
   </td>
   <td>
      {{'[*OverflowMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapDataLabelSettings.html#Syncfusion_Maui_Maps_MapDataLabelSettings_OverflowMode)'| markdownify }}
   </td>
</tr>
<tr>
   <td>
      {{'[TextColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.DataLabelSetting.html#Syncfusion_SfMaps_XForms_DataLabelSetting_TextColor)'| markdownify }},
      {{'[FontSize](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.DataLabelSetting.html#Syncfusion_SfMaps_XForms_DataLabelSetting_FontSize)'| markdownify }},
      {{'[FontFamily](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.DataLabelSetting.html#Syncfusion_SfMaps_XForms_DataLabelSetting_FontFamily)'| markdownify }}, and
      {{'[FontAttributes](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.DataLabelSetting.html#Syncfusion_SfMaps_XForms_DataLabelSetting_FontAttributes)'| markdownify }}
   </td>
   <td>
      {{'[*DataLabelStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapDataLabelSettings.html#Syncfusion_Maui_Maps_MapDataLabelSettings_DataLabelStyle)'| markdownify }}
   </td>
</tr>
</table>

N> All the (*) marked APIs are renamed from Xamarin SfMaps to maintain the consistency of API naming in the .NET MAUI SfMaps.

The following code example explains how to customize the data label in the Xamarin SfMaps and .NET MAUI SfMaps.

<table>
<tr>
<th>Xamarin SfMaps</th>
<th>.NET MAUI SfMaps</th></tr>
<tr>
<td>
{% tabs %}

{% highlight xaml %}

<maps:SfMaps>
    <maps:SfMaps.Layers>
        <maps:ShapeFileLayer Uri="world1.shp">
            <maps:ShapeFileLayer.Sublayers>
                <maps:ShapeFileLayer Uri="usa_state.shp"
                                     ItemsSource="{Binding DataSource}"
                                     ShapeIDPath="Name"
                                     ShapeIDTableField="STATE_NAME"
                                     ShowMapItems="True">
                    <maps:ShapeFileLayer.ShapeSettings>
                        <maps:ShapeSetting ShapeValuePath="Name" />
                    </maps:ShapeFileLayer.ShapeSettings>
                    <maps:ShapeFileLayer.DataLabelSettings>
                        <maps:DataLabelSetting  TextColor="Blue"
                                                SmartLabelMode="None" />
                    </maps:ShapeFileLayer.DataLabelSettings>
                </maps:ShapeFileLayer>
            </maps:ShapeFileLayer.Sublayers>
        </maps:ShapeFileLayer>
    </maps:SfMaps.Layers>
</maps:SfMaps>

{% endhighlight %}

{% highlight C# %}

ViewModel viewModel = new ViewModel();
this.BindingContext = viewModel;
SfMaps maps = new SfMaps();

ShapeFileLayer layer = new ShapeFileLayer();
layer.Uri = "world1.shp";

ShapeFileLayer subShapeLayer = new ShapeFileLayer();
subShapeLayer.Uri = "usa_state.shp";
subShapeLayer.ShapeIDTableField = "STATE_NAME";
subShapeLayer.ShapeIDPath = "Name";
subShapeLayer.ItemsSource = viewModel.DataSource;
subShapeLayer.ShapeSettings.ShapeValuePath = "Name";

DataLabelSetting dataLabelSetting = new DataLabelSetting();
dataLabelSetting.SmartLabelMode = IntersectAction.None;
 dataLabelSetting.TextColor = Color.Blue;
subShapeLayer.DataLabelSettings = dataLabelSetting;

layer.Sublayers.Add(subShapeLayer);
maps.Layers.Add(layer);
this.Content = maps;

{% endhighlight %}

{% endtabs %}
</td>
<td>
{% tabs %}

{% highlight xaml %}

<map:SfMaps>
    <map:SfMaps.Layer>
        <map:MapShapeLayer ShapesSource="https://cdn.syncfusion.com/maps/map-data/world-map.json">
            <map:MapShapeLayer.Sublayers>
                <map:MapShapeSublayer ShapesSource="https://cdn.syncfusion.com/maps/map-data/africa.json"
                                      ShapeDataField="name"
                                      DataSource="{Binding Data}"
                                      PrimaryValuePath="State"
                                      ShowDataLabels="True">
                    <map:MapShapeSublayer.DataLabelSettings>
                        <map:MapDataLabelSettings DataLabelPath="State" >
                        <map:MapDataLabelSettings.DataLabelStyle>
                                <map:MapLabelStyle FontSize="6" />
                            </map:MapDataLabelSettings.DataLabelStyle>
                            </map:MapDataLabelSettings>
                    </map:MapShapeSublayer.DataLabelSettings>
                </map:MapShapeSublayer>
            </map:MapShapeLayer.Sublayers>
        </map:MapShapeLayer>
    </map:SfMaps.Layer>
</map:SfMaps>

{% endhighlight %}

{% highlight C# %}

public MainPage()
{
	 InitializeComponent();
    ViewModel viewModel = new ViewModel();
    this.BindingContext = viewModel;
    SfMaps maps = new SfMaps();
    MapShapeLayer layer = new MapShapeLayer();
    layer.ShapesSource = MapSource.FromUri(new Uri("https://cdn.syncfusion.com/maps/map-data/world-map.json"));
    MapShapeSublayer sublayer = new MapShapeSublayer();
    sublayer.ShapesSource = MapSource.FromUri(new Uri("https://cdn.syncfusion.com/maps/map-data/africa.json"));
    sublayer.DataSource = viewModel.Data;
    sublayer.PrimaryValuePath = "State";
    sublayer.ShapeDataField = "name";
    sublayer.ShowDataLabels = true;

    sublayer.DataLabelSettings = new MapDataLabelSettings()
    {
        DataLabelPath = "State",
        DataLabelStyle = new MapLabelStyle()
        {
            FontSize = 6,
        },
    };

    layer.Sublayers.Add(sublayer);
    maps.Layer = layer;
    this.Content = maps;
}

{% endhighlight %}

{% endtabs %}
</td></tr>
</table>

### Color mappings

<table>
<tr>
<th>Xamarin SfMaps</th>
<th>.NET MAUI SfMaps</th>
</tr>
<tr>
   <td>
      {{'[Color](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.ColorMapping.html#Syncfusion_SfMaps_XForms_ColorMapping_Color)'| markdownify }}
   </td>
   <td>
      {{'[Color](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.ColorMapping.html#Syncfusion_Maui_Maps_ColorMapping_Color)'| markdownify }}
   </td>
</tr>
<tr>
   <td>
      {{'[EqualColorMapping](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.EqualColorMapping.html)'| markdownify }}
   </td>
   <td>
      {{'[EqualColorMapping](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.EqualColorMapping.html)'| markdownify }}
   </td>
</tr>
<tr>
   <td>
      {{'[RangeColorMapping](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.RangeColorMapping.html)'| markdownify }}
   </td>
   <td>
      {{'[RangeColorMapping](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.RangeColorMapping.html)'| markdownify }}
   </td>
</tr>
</table>

<b>Equal color mapping</b>

<table>
<tr>
<th>Xamarin SfMaps</th>
<th>.NET MAUI SfMaps</th>
</tr>
<tr>
   <td>
      {{'[Value](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.EqualColorMapping.html#Syncfusion_SfMaps_XForms_EqualColorMapping_Value)'| markdownify }}
   </td>
   <td>
      {{'[Value](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.EqualColorMapping.html#Syncfusion_Maui_Maps_EqualColorMapping_Value)'| markdownify }}
   </td>
</tr>
</table>

<b>Range color mapping</b>

<table>
<tr>
<th>Xamarin SfMaps</th>
<th>.NET MAUI SfMaps</th>
</tr>
<tr>
   <td>
      {{'[From](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.RangeColorMapping.html#Syncfusion_SfMaps_XForms_RangeColorMapping_From)'| markdownify }}
   </td>
   <td>
      {{'[From](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.RangeColorMapping.html#Syncfusion_Maui_Maps_RangeColorMapping_From)'| markdownify }}
   </td>
</tr>
<tr>
   <td>
      {{'[To](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.RangeColorMapping.html#Syncfusion_SfMaps_XForms_RangeColorMapping_To)'| markdownify }}
   </td>
   <td>
      {{'[To](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.RangeColorMapping.html#Syncfusion_Maui_Maps_RangeColorMapping_To)'| markdownify }}
   </td>
</tr>
</table>

The following code example explains how to customize the shape color in the Xamarin SfMaps and .NET MAUI SfMaps.

<table>
<tr>
<th>Xamarin SfMaps</th>
<th>.NET MAUI SfMaps</th></tr>
<tr>
<td>
{% tabs %}

{% highlight xaml %}

<maps:SfMaps>
    <maps:SfMaps.Layers>
        <maps:ShapeFileLayer Uri="world1.shp">
            <maps:ShapeFileLayer.Sublayers>
                <maps:ShapeFileLayer Uri="usa_state.shp"
                                     ItemsSource="{Binding DataSource}"
                                     ShapeIDPath="Name"
                                     ShapeIDTableField="STATE_NAME">
                    <maps:ShapeFileLayer.ShapeSettings>
                        <maps:ShapeSetting ShapeValuePath="index"
                                           ShapeColorValuePath="index">
                            <maps:ShapeSetting.ColorMappings>
                                <maps:EqualColorMapping Color="Blue"
                                                        Value="100"
                                                        LegendLabel="100" />
                                <maps:RangeColorMapping Color="Green"
                                                        From="0"
                                                        To="99"
                                                        LegendLabel="100" />
                            </maps:ShapeSetting.ColorMappings>
                        </maps:ShapeSetting>
                    </maps:ShapeFileLayer.ShapeSettings>
                </maps:ShapeFileLayer>
            </maps:ShapeFileLayer.Sublayers>
        </maps:ShapeFileLayer>
    </maps:SfMaps.Layers>
</maps:SfMaps>

{% endhighlight %}

{% highlight C# %}

    ViewModel viewModel = new ViewModel();
    this.BindingContext = viewModel;
    SfMaps maps = new SfMaps();

    ShapeFileLayer layer = new ShapeFileLayer();
    layer.Uri = "world1.shp";

    ShapeFileLayer subShapeLayer = new ShapeFileLayer();
    subShapeLayer.Uri = "usa_state.shp";           
    subShapeLayer.ShapeIDPath="Name"
    subShapeLayer.ShapeIDTableField="STATE_NAME"
    subShapeLayer.DataSource = viewModel.DataSource;

    EqualColorMapping colorMapping = new EqualColorMapping();
    colorMapping.Color = Colors.Blue;
    colorMapping.Value = "100";
    colorMapping.LegendLabel = "100";

    RangeColorMapping colorMapping1 = new RangeColorMapping();
    colorMapping1.Color = Colors.Green;
    colorMapping1.From = 0;
    colorMapping1.To = 99;
    colorMapping1.LegendLabel = "0-99";
    
    ShapeSetting shapeSetting = new ShapeSetting();
    shapeSetting.ShapeValuePath = "Count";
    shapeSetting.ShapeColorValuePath = "Count";
    
    shapeSetting.ColorMappings.Add(colorMapping);
    shapeSetting.ColorMappings.Add(colorMapping1);

    subShapeLayer.ShapeSettings = shapeSetting;
    layer.Sublayers.Add(subShapeLayer);
    maps.Layers.Add(layer);
    this.Content = maps;

{% endhighlight %}

{% endtabs %}
</td>
<td>
{% tabs %}

{% highlight xaml %}

<map:SfMaps>
    <map:SfMaps.Layer>
        <map:MapShapeLayer ShapesSource="https://cdn.syncfusion.com/maps/map-data/world-map.json">
            <map:MapShapeLayer.Sublayers>
                <map:MapShapeSublayer ShapesSource="https://cdn.syncfusion.com/maps/map-data/africa.json"
                                   DataSource="{Binding Data}"
                                   PrimaryValuePath="State"
                                   ShapeDataField="name"
                                   ShapeColorValuePath="Count">
                    <map:MapShapeSublayer.ColorMappings>
                        <map:EqualColorMapping Color="Blue"
                                               Value="100"
                                               Text="100" />
                        <map:RangeColorMapping Color="Green"
                                               From="0"
                                               To="99"
                                               Text="0-99" />
                    </map:MapShapeSublayer.ColorMappings>
                </map:MapShapeSublayer>
            </map:MapShapeLayer.Sublayers>
        </map:MapShapeLayer>
    </map:SfMaps.Layer>
</map:SfMaps>

{% endhighlight %}

{% highlight C# %}

public MainPage()
{
   InitializeComponent();
    ViewModel viewModel = new ViewModel();
    this.BindingContext = viewModel;
    SfMaps maps = new SfMaps();
    MapShapeLayer layer = new MapShapeLayer();
    layer.ShapesSource = MapSource.FromUri(new Uri("https://cdn.syncfusion.com/maps/map-data/world-map.json"));
    MapShapeSublayer sublayer = new MapShapeSublayer();
    sublayer.ShapesSource = MapSource.FromUri(new Uri("https://cdn.syncfusion.com/maps/map-data/africa.json"));
    sublayer.DataSource = viewModel.Data;
    sublayer.PrimaryValuePath = "State";
    sublayer.ShapeDataField = "name";
    sublayer.ShapeColorValuePath = "Count";

    EqualColorMapping colorMapping = new EqualColorMapping();
    colorMapping.Color = Colors.Blue;
    colorMapping.Value = "100";
    colorMapping.Text = "100";

    RangeColorMapping colorMapping1 = new RangeColorMapping();
    colorMapping1.Color = Colors.Green;
    colorMapping1.From = 0;
    colorMapping1.To = 99;
    colorMapping1.Text = "0-99";

    sublayer.ColorMappings.Add(colorMapping);
    sublayer.ColorMappings.Add(colorMapping1);

    layer.Sublayers.Add(sublayer);
    maps.Layer = layer;
    this.Content = maps;
}

{% endhighlight %}

{% endtabs %}
</td></tr>
</table>

## Vector layer

### Polygon Layer

<table>
<tr>
   <th>Xamarin SfMaps</th>
   <th>.NET MAUI SfMaps</th>
</tr>
<tr>
   <td>
      {{'[ShapeType](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.ShapeFileLayer.html#Syncfusion_SfMaps_XForms_ShapeFileLayer_ShapeTypeProperty)'| markdownify }}
   </td>
   <td>
      {{'[*MapPolygon](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapPolygon.html)'| markdownify }}
   </td>
</tr>
<tr>
   <td>
      {{'[Points](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.ShapeFileLayer.html#Syncfusion_SfMaps_XForms_ShapeFileLayer_PointsProperty)'| markdownify }}
   </td>
   <td>
      {{'[Points](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapPolygon.html#Syncfusion_Maui_Maps_MapPolygon_Points)'| markdownify }}
   </td>
</tr>
<tr>
   <td>
      {{'[ShapeFill](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.ShapeSetting.html#Syncfusion_SfMaps_XForms_ShapeSetting_ShapeFill)'| markdownify }} in
       {{'[ShapeSetting](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.ShapeSetting.html)'| markdownify }} class
   </td>
   <td>
      {{'[*Fill](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapPolygon.html#Syncfusion_Maui_Maps_MapPolygon_Fill)'| markdownify }}
   </td>
</tr>
<tr>
   <td>
      {{'[ShapeStroke](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.ShapeSetting.html#Syncfusion_SfMaps_XForms_ShapeSetting_ShapeStroke)'| markdownify }} in
       {{'[ShapeSetting](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.ShapeSetting.html)'| markdownify }} class
   </td>
   <td>
      {{'[*Stroke](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapPolygon.html#Syncfusion_Maui_Maps_MapPolygon_Stroke)'| markdownify }}
   </td>
</tr>
<tr>
   <td>
      {{'[ShapeStrokeThickness](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.ShapeSetting.html#Syncfusion_SfMaps_XForms_ShapeSetting_ShapeStrokeThickness)'| markdownify }} in
       {{'[ShapeSetting](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.ShapeSetting.html)'| markdownify }} class
   </td>
   <td>
      {{'[*StrokeThickness](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapPolygon.html#Syncfusion_Maui_Maps_MapPolygon_StrokeThickness)'| markdownify }}
   </td>
</tr>
</table>

N> All the (*) marked APIs are renamed from Xamarin SfMaps to maintain the consistency of API naming in the .NET MAUI SfMaps.

The following code example explains how to intialize the polygon layer and it's customization in Xamarin SfMaps and .NET MAUI SfMaps.

<table>
<tr>
<th>Xamarin SfMaps</th>
<th>.NET MAUI SfMaps</th></tr>
<tr>
<td>
{% tabs %}

{% highlight xaml %}

<maps:SfMaps>
    <maps:SfMaps.Layers>
        <maps:ShapeFileLayer Uri="world1.shp">
            <maps:ShapeFileLayer.Sublayers>
                <maps:ShapeFileLayer ShapeType="Polygon">
                    <maps:ShapeFileLayer.Points>
                        <Point>
                            <Point.X>39.6737</Point.X>
                            <Point.Y>-100.5</Point.Y>
                        </Point>
                        <Point>
                            <Point.X>61.35</Point.X>
                            <Point.Y>18.131</Point.Y>
                        </Point>
                        <Point>
                            <Point.X>-32.259</Point.X>
                            <Point.Y>145.4214</Point.Y>
                        </Point>
                    </maps:ShapeFileLayer.Points>
                    <maps:ShapeFileLayer.ShapeSettings>
                        <maps:ShapeSetting  ShapeStrokeThickness="3" ShapeFill="Blue" />
                    </maps:ShapeFileLayer.ShapeSettings>
                </maps:ShapeFileLayer>
            </maps:ShapeFileLayer.Sublayers>
        </maps:ShapeFileLayer>
    </maps:SfMaps.Layers>
</maps:SfMaps>

{% endhighlight %}

{% highlight C# %}

    SfMaps maps = new SfMaps();

    ShapeFileLayer layer = new ShapeFileLayer();
    layer.Uri = "world.shp"; 

    ShapeFileLayer subLayer = new ShapeFileLayer();
    subLayer.ShapeType = ShapeType.Polygon;
    subLayer.Points.Add(new Point(39.6737,-100.5));
    subLayer.Points.Add(new Point(61.35, 18.131));
    subLayer.Points.Add(new Point(-32.259, 145.4214));
    
    ShapeSetting subLayerSetting = new ShapeSetting();
    subLayerSetting.ShapeStrokeThickness = 4;
    subLayerSetting.ShapeFill = Color.Blue;
    subLayerSetting.ShapeStroke = Color.DarkBlue;

    subLayer.ShapeSettings = subLayerSetting;
    layer.Sublayers.Add(subLayer);
    maps.Layers.Add(layer);

{% endhighlight %}

{% endtabs %}
</td>
<td>
{% tabs %}

{% highlight xaml %}

<map:SfMaps>
    <map:SfMaps.Layer>
        <map:MapShapeLayer ShapesSource="https://cdn.syncfusion.com/maps/map-data/world-map.json">
            <map:MapShapeLayer.Sublayers>
                <map:MapPolygonLayer>
                    <map:MapPolygonLayer.Polygons>
                        <map:MapPolygon Stroke="DarkBule" Fill="blue" StrokeThickness="4">
                            <map:MapPolygon.Points>
                                <map:MapLatLng Latitude="37.6173"
                                               Longitude="55.7558" />
                                <map:MapLatLng Latitude="87.1216"
                                               Longitude="53.7596" />
                                <map:MapLatLng Latitude="105.3188"
                                               Longitude="61.5240" />
                            </map:MapPolygon.Points>
                        </map:MapPolygon>
                    </map:MapPolygonLayer.Polygons>
                </map:MapPolygonLayer>
            </map:MapShapeLayer.Sublayers>
        </map:MapShapeLayer>
    </map:SfMaps.Layer>
</map:SfMaps>

{% endhighlight %}

{% highlight C# %}

public MainPage()
{
    InitializeComponent();
    SfMaps maps = new SfMaps();
    MapShapeLayer layer = new MapShapeLayer();
    layer.ShapesSource = MapSource.FromUri(new Uri("https://cdn.syncfusion.com/maps/map-data/world-map.json"));
    MapPolygonLayer mapPolygonLayer = new MapPolygonLayer();
    MapPolygon polygon1 = new MapPolygon();
    polygon1.Points = new ObservableCollection<MapLatLng>()
    {
    new MapLatLng(37.6173, 55.7558),
    new MapLatLng(87.1216, 53.7596),
    new MapLatLng(105.3188, 61.5240)
    };
    polygon1.Fill = Colors.Blue;
    polygon1.Stroke = Colors.DarkBlue;
    polygon1.StrokeThickness = 4;
    mapPolygonLayer.Polygons.Add(polygon1);
    layer.Sublayers.Add(mapPolygonLayer);
    maps.Layer = layer;
    this.Content = maps;
}

{% endhighlight %}

{% endtabs %}
</td></tr>
</table>

### Polyline Layer

<table>
<tr>
   <th>Xamarin SfMaps</th>
   <th>.NET MAUI SfMaps</th>
</tr>
<tr>
   <td>
      {{'[ShapeType](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.ShapeFileLayer.html#Syncfusion_SfMaps_XForms_ShapeFileLayer_ShapeTypeProperty)'| markdownify }}
   </td>
   <td>
      {{'[*MapPolyline](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapPolyline.html)'| markdownify }}
   </td>
</tr>
<tr>
   <td>
      {{'[Points](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.ShapeFileLayer.html#Syncfusion_SfMaps_XForms_ShapeFileLayer_PointsProperty)'| markdownify }}
   </td>
   <td>
      {{'[Points](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapPolyline.html#Syncfusion_Maui_Maps_MapPolyline_Points)'| markdownify }}
   </td>
</tr>
<tr>
   <td>
      {{'[ShapeStroke](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.ShapeSetting.html#Syncfusion_SfMaps_XForms_ShapeSetting_ShapeStroke)'| markdownify }} in
       {{'[ShapeSetting](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.ShapeSetting.html)'| markdownify }} class
   </td>
   <td>
      {{'[*Stroke](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapPolyline.html#Syncfusion_Maui_Maps_MapPolyline_Stroke)'| markdownify }}
   </td>
</tr>
<tr>
   <td>
      {{'[ShapeStrokeThickness](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.ShapeSetting.html#Syncfusion_SfMaps_XForms_ShapeSetting_ShapeStrokeThickness)'| markdownify }} in
       {{'[ShapeSetting](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.ShapeSetting.html)'| markdownify }} class
   </td>
   <td>
      {{'[*StrokeThickness](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapPolyline.html#Syncfusion_Maui_Maps_MapPolyline_StrokeThickness)'| markdownify }}
   </td>
</tr>
<tr>
   <td>
      {{'-'| markdownify }}
   </td>
   <td>
      {{'[StrokeDashArray](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapPolyline.html#Syncfusion_Maui_Maps_MapPolyline_StrokeDashArray)'| markdownify }}
   </td>
</tr>
<tr>
   <td>
      {{'-'| markdownify }}
   </td>
   <td>
      {{'[AnimationEasing](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapPolylineLayer.html#Syncfusion_Maui_Maps_MapPolylineLayer_AnimationEasing)'| markdownify }} in {{'[MapPolylineLayer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapPolylineLayer.html)'| markdownify }} class
   </td>
</tr>
<tr>
   <td>
      {{'-'| markdownify }}
   </td>
   <td>
      {{'[AnimationDuration](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapPolylineLayer.html#Syncfusion_Maui_Maps_MapPolylineLayer_AnimationDuration)'| markdownify }} in {{'[MapPolylineLayer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapPolylineLayer.html)'| markdownify }} class
   </td>
</tr>
</table>

N> All the (*) marked APIs are renamed from Xamarin SfMaps to maintain the consistency of API naming in the .NET MAUI SfMaps.

The following code example explains how to intialize the polyline layer and it's customization in Xamarin SfMaps and .NET MAUI SfMaps.

<table>
<tr>
<th>Xamarin SfMaps</th>
<th>.NET MAUI SfMaps</th></tr>
<tr>
<td>
{% tabs %}

{% highlight xaml %}

 <maps:SfMaps>
     <maps:SfMaps.Layers>
         <maps:ShapeFileLayer Uri="world1.shp">
             <maps:ShapeFileLayer.Sublayers>
                 <maps:ShapeFileLayer ShapeType="Polyline">
                     <maps:ShapeFileLayer.Points>
                         <Point>
                             <Point.X>39.6737</Point.X>
                             <Point.Y>-100.5</Point.Y>
                         </Point>
                         <Point>
                             <Point.X>61.35</Point.X>
                             <Point.Y>18.131</Point.Y>
                         </Point>
                         <Point>
                             <Point.X>-32.259</Point.X>
                             <Point.Y>145.4214</Point.Y>
                         </Point>
                     </maps:ShapeFileLayer.Points>
                     <maps:ShapeFileLayer.ShapeSettings>
                         <maps:ShapeSetting  ShapeStrokeThickness="3" />
                     </maps:ShapeFileLayer.ShapeSettings>
                 </maps:ShapeFileLayer>
             </maps:ShapeFileLayer.Sublayers>
         </maps:ShapeFileLayer>
     </maps:SfMaps.Layers>
 </maps:SfMaps>

{% endhighlight %}

{% highlight C# %}

    SfMaps maps = new SfMaps();

    ShapeFileLayer layer = new ShapeFileLayer();
    layer.Uri = "world.shp"; 

    ShapeFileLayer subLayer = new ShapeFileLayer();
    subLayer.Points.Add(new Point(39.6737,-100.5));
    subLayer.Points.Add(new Point(61.35, 18.131));
    subLayer.Points.Add(new Point(-32.259, 145.4214));
    subLayer.ShapeType = ShapeType.Polyline;
              
    ShapeSetting subLayerSetting = new ShapeSetting();
    subLayerSetting.ShapeStrokeThickness = 3;
    subLayerSetting.ShapeStroke = Color.Blue;
    subLayer.ShapeSettings = subLayerSetting;
    layer.Sublayers.Add(subLayer);
    maps.Layers.Add(layer);

{% endhighlight %}

{% endtabs %}
</td>
<td>
{% tabs %}

{% highlight xaml %}

 <map:SfMaps>
     <map:SfMaps.Layer>
         <map:MapShapeLayer ShapesSource="https://cdn.syncfusion.com/maps/map-data/india.json">
             <map:MapShapeLayer.Sublayers>
                 <map:MapPolylineLayer AnimationDuration="3000"
                                       AnimationEasing="{x:Static Easing.Linear}">
                     <map:MapPolylineLayer.Polylines>
                         <map:MapPolyline StrokeThickness="3" Stroke="Blue">
                             <map:MapPolyline.Points>
                                 <map:MapLatLng Latitude="80.2707"
                                                Longitude="13.0827" />
                                 <map:MapLatLng Latitude="79.6117"
                                                Longitude="13.1746" />
                                 <map:MapLatLng Latitude="79.5037"
                                                Longitude="13.6373" />
                                 <map:MapLatLng Latitude="78.8242"
                                                Longitude="14.4673" />
                             </map:MapPolyline.Points>
                         </map:MapPolyline>
                     </map:MapPolylineLayer.Polylines>
                 </map:MapPolylineLayer>
             </map:MapShapeLayer.Sublayers>
         </map:MapShapeLayer>
     </map:SfMaps.Layer>
 </map:SfMaps>

{% endhighlight %}

{% highlight C# %}

 public MainPage()
 {
     InitializeComponent();
     SfMaps maps = new SfMaps();
     MapShapeLayer layer = new MapShapeLayer();
     layer.ShapesSource = MapSource.FromUri(new Uri("https://cdn.syncfusion.com/maps/map-data/india.json"));
     MapPolylineLayer mapPolylineLayer = new MapPolylineLayer();
     mapPolylineLayer.AnimationDuration = 3000;
     mapPolylineLayer.AnimationEasing = Easing.Linear;
     MapPolyline polyline = new MapPolyline();
     polyline.Points = new ObservableCollection<MapLatLng>()
      {
          new MapLatLng(80.2707, 13.0827),
          new MapLatLng(79.6117, 13.1746),
          new MapLatLng(79.5037, 13.6373),
          new MapLatLng(78.8242, 14.4673),
      };
     polyline.Stroke = Colors.Blue;
     mapPolylineLayer.Polylines.Add(polyline);
     layer.Sublayers.Add(mapPolylineLayer);
     maps.Layer = layer;
     this.Content = maps;
 }

{% endhighlight %}

{% endtabs %}
</td></tr>
</table>

### Line Layer

<table>
<tr>
   <th>Xamarin SfMaps</th>
   <th>.NET MAUI SfMaps</th>
</tr>
<tr>
   <td>
      {{'-'| markdownify }}
   </td>
   <td>
      {{'[MapLine](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapLine.html)'| markdownify }}
   </td>
</tr>
<tr>
   <td>
      {{'-'| markdownify }}
   </td>
   <td>
      {{'[From](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapLine.html#Syncfusion_Maui_Maps_MapLine_From)'| markdownify }}
   </td>
</tr>
<tr>
   <td>
      {{'-'| markdownify }}
   </td>
   <td>
      {{'[To](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapLine.html#Syncfusion_Maui_Maps_MapLine_To)'| markdownify }}
   </td>
</tr>
<tr>
   <td>
      {{'-'| markdownify }}
   </td>
   <td>
      {{'[Stroke](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapLine.html#Syncfusion_Maui_Maps_MapLine_Stroke)'| markdownify }}
   </td>
</tr>
<tr>
   <td>
     {{'-'| markdownify }}
   </td>
   <td>
      {{'[StrokeThickness](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapLine.html#Syncfusion_Maui_Maps_MapLine_StrokeThickness)'| markdownify }}
   </td>
</tr>
<tr>
   <td>
      {{'-'| markdownify }}
   </td>
   <td>
      {{'[StrokeDashArray](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapLine.html#Syncfusion_Maui_Maps_MapLine_StrokeDashArray)'| markdownify }}
   </td>
</tr>
<tr>
   <td>
      {{'-'| markdownify }}
   </td>
   <td>
      {{'[StrokeLineCap](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapLine.html#Syncfusion_Maui_Maps_MapLine_StrokeLineCap)'| markdownify }}
   </td>
</tr>
<tr>
   <td>
      {{'-'| markdownify }}
   </td>
   <td>
      {{'[AnimationEasing](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapLineLayer.html#Syncfusion_Maui_Maps_MapLineLayer_AnimationEasing)'| markdownify }} in {{'[MapLineLayer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapLineLayer.html?tabs=tabid-1)'| markdownify }} class
   </td>
</tr>
<tr>
   <td>
      {{'-'| markdownify }}
   </td>
   <td>
      {{'[AnimationDuration](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapLineLayer.html#Syncfusion_Maui_Maps_MapLineLayer_AnimationDuration)'| markdownify }} in {{'[MapLineLayer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapLineLayer.html?tabs=tabid-1)'| markdownify }} class
   </td>
</tr>
</table>

The following code example explains how to intialize the line layer and it's customization in Xamarin SfMaps and .NET MAUI SfMaps.

<table>
<tr>
<th>Xamarin SfMaps</th>
<th>.NET MAUI SfMaps</th></tr>
<tr>
<td>
{{'-'| markdownify }}
</td>
<td>
{% tabs %}

{% highlight xaml %}

 <map:SfMaps>
    <map:SfMaps.Layer>
        <map:MapShapeLayer ShapesSource="https://cdn.syncfusion.com/maps/map-data/world-map.json">
            <map:MapShapeLayer.Sublayers>
                <map:MapLineLayer AnimationDuration="3000"
                                  AnimationEasing="{x:Static Easing.Linear}">
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
                    </map:MapLineLayer.Lines>
                </map:MapLineLayer>
            </map:MapShapeLayer.Sublayers>
        </map:MapShapeLayer>
    </map:SfMaps.Layer>
</map:SfMaps>

{% endhighlight %}

{% highlight C# %}

 public MainPage()
{
    InitializeComponent();
    SfMaps maps = new SfMaps();
    MapShapeLayer layer = new MapShapeLayer();
    layer.ShapesSource = MapSource.FromUri(new Uri("https://cdn.syncfusion.com/maps/map-data/world-map.json"));
    MapLineLayer mapLineLayer = new MapLineLayer();
    mapLineLayer.AnimationDuration = 3000;
    mapLineLayer.AnimationEasing = Easing.Linear;
    MapLine line1 = new MapLine();
    line1.From = new MapLatLng(77.1025, 28.7041);
    line1.To = new MapLatLng(-106.3468, 56.1304);
    line1.Stroke = Color.FromRgb(61, 155, 242);
    line1.StrokeThickness = 2;
    line1.StrokeLineCap = LineCap.Round;
    layer.Sublayers.Add(mapLineLayer);
    maps.Layer = layer;
    this.Content = maps;
}

{% endhighlight %}

{% endtabs %}
</td></tr>
</table>

### Arc Layer

<table>
<tr>
   <th>Xamarin SfMaps</th>
   <th>.NET MAUI SfMaps</th>
</tr>
<tr>
   <td>
      {{'-'| markdownify }}
   </td>
   <td>
      {{'[MapArc](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapArc.html)'| markdownify }}
   </td>
</tr>
<tr>
   <td>
      {{'-'| markdownify }}
   </td>
   <td>
      {{'[From](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapArc.html#Syncfusion_Maui_Maps_MapArc_From)'| markdownify }}
   </td>
</tr>
<tr>
   <td>
      {{'-'| markdownify }}
   </td>
   <td>
      {{'[To](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapArc.html#Syncfusion_Maui_Maps_MapArc_To)'| markdownify }}
   </td>
</tr>
<tr>
   <td>
      {{'-'| markdownify }}
   </td>
   <td>
      {{'[Stroke](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapArc.html#Syncfusion_Maui_Maps_MapArc_Stroke)'| markdownify }}
   </td>
</tr>
<tr>
   <td>
       {{'-'| markdownify }}
   </td>
   <td>
      {{'[StrokeThickness](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapArc.html#Syncfusion_Maui_Maps_MapArc_StrokeThickness)'| markdownify }}
   </td>
</tr>
<tr>
   <td>
      {{'-'| markdownify }}
   </td>
   <td>
      {{'[StrokeDashArray](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapArc.html#Syncfusion_Maui_Maps_MapArc_StrokeDashArray)'| markdownify }}
   </td>
</tr>
<tr>
   <td>
      {{'-'| markdownify }}
   </td>
   <td>
      {{'[HeightFactor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapArc.html#Syncfusion_Maui_Maps_MapArc_HeightFactor)'| markdownify }}
   </td>
</tr>
<tr>
   <td>
       {{'-'| markdownify }}
   </td>
   <td>
      {{'[ControlPointFactor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapArc.html#Syncfusion_Maui_Maps_MapArc_ControlPointFactor)'| markdownify }}
   </td>
</tr>
</table>

The following code example explains how to intialize the arc layer and it's customization in Xamarin SfMaps and .NET MAUI SfMaps.

<table>
<tr>
<th>Xamarin SfMaps</th>
<th>.NET MAUI SfMaps</th></tr>
<tr>
<td>
{{'-'| markdownify }}
</td>
<td>
{% tabs %}

{% highlight xaml %}

 <map:SfMaps>
    <map:SfMaps.Layer>
        <map:MapShapeLayer ShapesSource="https://cdn.syncfusion.com/maps/map-data/world-map.json">
            <map:MapShapeLayer.Sublayers>
                <map:MapArcLayer>
                    <map:MapArcLayer.Arcs>
                        <map:MapArc StrokeThickness="2"
                                    Stroke="#8a8a8a" 
                                    ControlPointFactor="0.5" 
                                    HeightFactor="0.2">
                            <map:MapArc.From>
                                <map:MapLatLng Latitude="77.1025"
                                               Longitude="28.7041" />
                            </map:MapArc.From>
                            <map:MapArc.To>
                                <map:MapLatLng Latitude="-106.3468"
                                               Longitude="56.1304" />
                            </map:MapArc.To>
                        </map:MapArc>
                    </map:MapArcLayer.Arcs>
                </map:MapArcLayer>
            </map:MapShapeLayer.Sublayers>
        </map:MapShapeLayer>
    </map:SfMaps.Layer>
</map:SfMaps>

{% endhighlight %}

{% highlight C# %}

 public MainPage()
{
    InitializeComponent();
    SfMaps maps = new SfMaps();
    MapShapeLayer layer = new MapShapeLayer();
    layer.ShapesSource = MapSource.FromUri(new Uri("https://cdn.syncfusion.com/maps/map-data/world-map.json"));
    MapArcLayer mapArcLayer = new MapArcLayer();
    MapArc arc = new MapArc();
    arc.From = new MapLatLng(77.1025, 28.7041);
    arc.To = new MapLatLng(-106.3468, 56.1304);
    arc.Stroke = Color.FromRgb(61, 155, 242);
    arc.StrokeThickness = 2;
    arc.ControlPointFactor = 0.5;
    arc.HeightFactor = 0.2;
    layer.Sublayers.Add(mapArcLayer);
    maps.Layer = layer;
    this.Content = maps;
}

{% endhighlight %}

{% endtabs %}
</td></tr>
</table>

### Circle Layer

<table>
<tr>
   <th>Xamarin SfMaps</th>
   <th>.NET MAUI SfMaps</th>
</tr>
<tr>
   <td>
       {{'-'| markdownify }}
   </td>
   <td>
      {{'[MapCircle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapCircle.html)'| markdownify }}
   </td>
</tr>
<tr>
   <td>
       {{'-'| markdownify }}
   </td>
   <td>
      {{'[Center](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapCircle.html#Syncfusion_Maui_Maps_MapCircle_Center)'| markdownify }}
   </td>
</tr>
<tr>
   <td>
      {{'-'| markdownify }}
   </td>
   <td>
      {{'[Radius](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapCircle.html#Syncfusion_Maui_Maps_MapCircle_Radius)'| markdownify }}
   </td>
</tr>
<tr>
   <td>
       {{'-'| markdownify }}
   </td>
   <td>
      {{'[Stroke](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapCircle.html#Syncfusion_Maui_Maps_MapCircle_Stroke)'| markdownify }}
   </td>
</tr>
<tr>
   <td>
      {{'-'| markdownify }}
   </td>
   <td>
      {{'[StrokeThickness](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapCircle.html#Syncfusion_Maui_Maps_MapCircle_StrokeThickness)'| markdownify }}
   </td>
</tr>
<tr>
   <td>
      {{'-'| markdownify }}
   </td>
   <td>
      {{'[Fill](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapCircle.html#Syncfusion_Maui_Maps_MapCircle_Fill)'| markdownify }}
   </td>
</tr>
<tr>
   <td>
      {{'-'| markdownify }}
   </td>
   <td>
      {{'[AnimationEasing](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapCircleLayer.html#Syncfusion_Maui_Maps_MapCircleLayer_AnimationEasing)'| markdownify }} in {{'[MapCircleLayer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapCircleLayer.html?tabs=tabid-1)'| markdownify }} class
   </td>
</tr>
<tr>
   <td>
      {{'-'| markdownify }}
   </td>
   <td>
      {{'[AnimationDuration](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapCircleLayer.html#Syncfusion_Maui_Maps_MapCircleLayer_AnimationDuration)'| markdownify }} in {{'[MapCircleLayer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapCircleLayer.html?tabs=tabid-1)'| markdownify }} class
   </td>
</tr>
</table>

The following code example explains how to intialize the circle layer and it's customization in Xamarin SfMaps and .NET MAUI SfMaps.

<table>
<tr>
<th>Xamarin SfMaps</th>
<th>.NET MAUI SfMaps</th></tr>
<tr>
<td>
{{'-'| markdownify }}
</td>
<td>
{% tabs %}

{% highlight xaml %}

 <map:SfMaps>
    <map:SfMaps.Layer>
        <map:MapShapeLayer ShapesSource="https://cdn.syncfusion.com/maps/map-data/india.json">
            <map:MapShapeLayer.Sublayers>
                <map:MapCircleLayer AnimationDuration="3000"
                                    AnimationEasing="{x:Static Easing.Linear}">
                    <map:MapCircleLayer.Circles>
                        <map:MapCircle Radius="10" 
                                       Fill="LightGreen" 
                                       Stroke="Green" 
                                       StrokeThickness="2">
                            <map:MapCircle.Center>
                                <map:MapLatLng Latitude="74.1240"
                                               Longitude="15.2993"></map:MapLatLng>
                            </map:MapCircle.Center>
                        </map:MapCircle>
                    </map:MapCircleLayer.Circles>
                </map:MapCircleLayer>
            </map:MapShapeLayer.Sublayers>
        </map:MapShapeLayer>
    </map:SfMaps.Layer>
</map:SfMaps>

{% endhighlight %}

{% highlight C# %}

public MainPage()
{
    InitializeComponent();
    SfMaps maps = new SfMaps();
    MapShapeLayer layer = new MapShapeLayer();
    layer.ShapesSource = MapSource.FromUri(new Uri("https://cdn.syncfusion.com/maps/map-data/india.json"));
    MapCircleLayer circleLayer = new MapCircleLayer();
    circleLayer.AnimationDuration = 3000;
    circleLayer.AnimationEasing = Easing.Linear;
    MapCircle circle1 = new MapCircle();
    circle1.Center = new MapLatLng(74.1240, 15.2993);
    circle1.Radius = 10;
    circle1.Fill = Colors.LightGreen;
    circle1.Stroke = Colors.Green;
    circle1.StrokeThickness = 3;
    circleLayer.Circles.Add(circle1);
    maps.Layer = layer;
    this.Content = maps;
}

{% endhighlight %}

{% endtabs %}
</td></tr>
</table>

## Zooming and Panning

<table>
<tr>
   <th>Xamarin SfMaps</th>
   <th>.NET MAUI SfMaps</th>
</tr>
<tr>
   <td>
      {{'[ZoomLevel](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.SfMaps.html#Syncfusion_SfMaps_XForms_SfMaps_ZoomLevel)'| markdownify }}
   </td>
   <td>
      {{'[ZoomLevel](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapZoomPanBehavior.html#Syncfusion_Maui_Maps_MapZoomPanBehavior_ZoomLevel)'| markdownify }} in {{'[MapZoomPanBehavior](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapZoomPanBehavior.html?tabs=tabid-1)'| markdownify }} class
   </td>
</tr>
<tr>
   <td>
      {{'[MinZoom](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.SfMaps.html#Syncfusion_SfMaps_XForms_SfMaps_MinZoom)'| markdownify }}
   </td>
   <td>
      {{'[*MinZoomLevel](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapZoomPanBehavior.html#Syncfusion_Maui_Maps_MapZoomPanBehavior_MinZoomLevel)'| markdownify }} in {{'[MapZoomPanBehavior](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapZoomPanBehavior.html?tabs=tabid-1)'| markdownify }} class
   </td>
</tr>
<tr>
   <td>
      {{'[MaxZoom](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.SfMaps.html#Syncfusion_SfMaps_XForms_SfMaps_MaxZoom)'| markdownify }} 
   </td>
   <td>
      {{'[*MaxZoomLevel](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapZoomPanBehavior.html#Syncfusion_Maui_Maps_MapZoomPanBehavior_MaxZoomLevel)'| markdownify }} in {{'[MapZoomPanBehavior](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapZoomPanBehavior.html?tabs=tabid-1)'| markdownify }} class
   </td>
</tr>
<tr>
   <td>
      {{'[EnableZooming](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.SfMaps.html#Syncfusion_SfMaps_XForms_SfMaps_EnableZooming)'| markdownify }} 
   </td>
   <td>
      {{'[EnableZooming](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapZoomPanBehavior.html#Syncfusion_Maui_Maps_MapZoomPanBehavior_EnableZooming)'| markdownify }} in {{'[MapZoomPanBehavior](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapZoomPanBehavior.html?tabs=tabid-1)'| markdownify }} class
   </td>
</tr>
<tr>
   <td>
      {{'[EnablePanning](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.ShapeSetting.html#Syncfusion_SfMaps_XForms_ShapeSetting_ShapeStrokeThickness)'| markdownify }} 
   </td>
   <td>
      {{'[EnablePanning](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapZoomPanBehavior.html#Syncfusion_Maui_Maps_MapZoomPanBehavior_EnablePanning)'| markdownify }} in {{'[MapZoomPanBehavior](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapZoomPanBehavior.html?tabs=tabid-1)'| markdownify }} class
   </td>
</tr>
<tr>
   <td>
      {{'-'| markdownify }}  
   </td>
   <td>
      {{'[EnableDoubleTapZooming](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapZoomPanBehavior.html#Syncfusion_Maui_Maps_MapZoomPanBehavior_EnableDoubleTapZooming)'| markdownify }} in {{'[MapZoomPanBehavior](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapZoomPanBehavior.html?tabs=tabid-1)'| markdownify }} class
   </td>
</tr>
<tr>
   <td>
      {{'-'| markdownify }} 
   </td>
   <td>
      {{'[EnableCenterAnimation](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapTileLayer.html#Syncfusion_Maui_Maps_MapTileLayer_EnableCenterAnimation)'| markdownify }} in {{'[MapTileLayer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapTileLayer.html?tabs=tabid-1)'| markdownify }} class
   </td>
</tr>
<tr>
   <td>
     {{'-'| markdownify }} 
   </td>
   <td>
      {{'[EnableZoomingAnimation](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapLayer.html#Syncfusion_Maui_Maps_MapLayer_EnableZoomingAnimation)'| markdownify }} in {{'[MapLayer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapLayer.html?tabs=tabid-1)'| markdownify }} class
   </td>
</tr>
</table>

N> All the (*) marked APIs are renamed from Xamarin SfMaps to maintain the consistency of API naming in the .NET MAUI SfMaps.

The following code example explains how to intialize the zooming and it's customization in Xamarin SfMaps and .NET MAUI SfMaps.

<table>
<tr>
<th>Xamarin SfMaps</th>
<th>.NET MAUI SfMaps</th></tr>
<tr>
<td>
{% tabs %}

{% highlight xaml %}

<maps:SfMaps EnablePanning="True"
             EnableZooming="True"
             ZoomLevel="5"
             MinZoom="3"
             MaxZoom="10">
    <maps:SfMaps.Layers>
        <maps:ImageryLayer />
    </maps:SfMaps.Layers>
</maps:SfMaps>

{% endhighlight %}

{% highlight C# %}

SfMaps maps = new SfMaps();
ImageryLayer layer = new ImageryLayer();
maps.Layers.Add(layer);
maps.EnablePanning = true;
maps.EnableZooming = true;
maps.MinZoom = 3;
maps.MaxZoom = 10;
maps.ZoomLevel = 5;

{% endhighlight %}

{% endtabs %}
</td>
<td>
{% tabs %}

{% highlight xaml %}

<map:SfMaps>
    <map:SfMaps.Layer>
        <map:MapTileLayer UrlTemplate="https://tile.openstreetmap.org/{z}/{x}/{y}.png">
            <map:MapTileLayer.ZoomPanBehavior>
                <map:MapZoomPanBehavior ZoomLevel="5"
                                        MinZoomLevel="3"
                                        MaxZoomLevel="10"
                                        EnablePanning="True"
                                        EnableZooming="True" />
            </map:MapTileLayer.ZoomPanBehavior>
        </map:MapTileLayer>
    </map:SfMaps.Layer>
</map:SfMaps>


{% endhighlight %}

{% highlight C# %}

public MainPage()
{
   InitializeComponent();
   SfMaps map = new SfMaps();
   MapTileLayer tileLayer = new MapTileLayer();
   tileLayer.UrlTemplate = "https://tile.openstreetmap.org/{z}/{x}/{y}.png";
   MapZoomPanBehavior zoomPanBehavior = new MapZoomPanBehavior();
   zoomPanBehavior.ZoomLevel = 5;
   zoomPanBehavior.MinZoomLevel = 3;
   zoomPanBehavior.MaxZoomLevel = 10;
   zoomPanBehavior.EnablePanning = true;
   zoomPanBehavior.EnableZooming = true;
   tileLayer.ZoomPanBehavior = zoomPanBehavior;
   map.Layer = tileLayer;
   this.Content = map;
}

{% endhighlight %}

{% endtabs %}
</td></tr>
</table>

## Unsupported features from Xamarin.Forms

* Label support has not been provided in the marker. Instead, you can achieve it using the [MarkerTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapLayer.html#Syncfusion_Maui_Maps_MapLayer_MarkerTemplate).
* In .NET MAUI, IntersectionAction support is not provided for data labels.
* The [ShowLegend](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.MapLegendSetting.html#Syncfusion_SfMaps_XForms_MapLegendSetting_ShowLegend) support is not provided in the .NET MAUI. Instead, set the value for the [Legend](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_Legend) to display map legend in the .NET MAUI platform.
* In Xamarin, [Layers](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.SfMaps.html#Syncfusion_SfMaps_XForms_SfMaps_Layers) are maintained as observable collection. But .NET MAUI supports a single [Layer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.SfMaps.html#Syncfusion_Maui_Maps_SfMaps_Layer).
* The [ResetOnDoubleTap](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.ImageryLayer.html#Syncfusion_SfMaps_XForms_ImageryLayer_ResetOnDoubleTap) support is not provided in the .NET MAUI.

## Support and feedback

If you cannot find the migration information you require in the self-help resources listed above, please contact us by creating a [support ticket](https://internalsupport.bolddesk.com/agent/tickets/create). Do not see what you need? Please request it in our [feedback portal](https://www.syncfusion.com/feedback/maui).

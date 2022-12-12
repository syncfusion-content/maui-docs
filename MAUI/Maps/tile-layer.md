---
layout: post
title: Tile Layer in Maps control | Syncfusion
description: Learn here all about the Tile Layer feature of the Syncfusion .NET MAUI Maps (SfMaps) control to customize their appearances and more.
platform: MAUI
control: SfMaps
documentation: ug
---

# Tile Layer in in .NET MAUI Maps (SfMaps)

The tile layer renders the tiles returned from web map tile services such as Bing Maps, OpenStreetMaps, Google Maps, TomTom, etc.

## Setting URL template

The `MapTileLayer` needs to be added in the `Layer` collection in `SfMaps`. The URL of the providers must be set in the `MapTileLayer.UrlTemplate` property.

The `UrlTemplate` property accepts the URL in [`WMTS`](https://en.wikipedia.org/wiki/Web_Map_Tile_Service) format i.e. {z} — zoom level, {x} and {y} — tile coordinates. This URL might vary slightly depends on the providers. The formats can be,
    https://example_provider/{z}/{x}/{y}.png,
    https://example_provider/z={z}/x={x}/y={y}.png,
    https://example_provider/z={z}/x={x}/y={y}.png?key=subscription_key, etc.

We will replace the {z}, {x}, {y} internally based on the current `Center` and the zoom level.

N> Some of the providers may need subscription key. Please include them in the `UrlTemplate` itself as mentioned in the above example. Please note that the format may vary between each map providers. You can check the exact URL format needed for the providers on their official websites.

## Adding OSM/OpenStreetMap

The OpenStreetMap is one of the tile/image providers which can be used free of cost. It returns map tiles for the requested coordinates for every requests. The url format of the OSM map provider as shown in the below code snippet.

N> Though the OpenStreetMap is free of cost, we recommend you check the licensing terms and conditions once before using it.

{% tabs %}

{% highlight xaml %}

 <maps:SfMaps>
    <maps:SfMaps.Layer>
        <maps:MapTileLayer UrlTemplate="https://tile.openstreetmap.org/{z}/{x}/{y}.png" />
    </maps:SfMaps.Layer>
</maps:SfMaps>

{% endhighlight %}

{% highlight c# %}

SfMaps map = new SfMaps();
MapTileLayer tileLayer = new MapTileLayer();
tileLayer.UrlTemplate = "https://tile.openstreetmap.org/{z}/{x}/{y}.png";
map.Layer = tileLayer;
this.Content = map;

{% endhighlight %}

{% endtabs %}

![OSM default view](images/tile-layer/osm_maps_default.png)

## Adding Bing maps

An additional step is required for the Bing maps. The format of the required URL varies from the other tile services. Hence, we have added a top-level `GetTileUrl` method which returns the URL in the required format. The subscription key is needed for bing maps. You can create an API key by following the steps mentioned in this [`link`](https://docs.microsoft.com/en-us/bingmaps/getting-started/bing-maps-dev-center-help/getting-a-bing-maps-key) and append this key to the bing map url before pass it to the `GetTileUrl` method. You can use the URL returned from this method to pass it to the `UrlTemplate` property.

Some of the providers provide different map types. For example, Bing Maps provide map types like Road, Aerial, AerialWithLabels etc. These types too can be passed in the `UrlTemplate` itself as shown in the below example. You can check the official websites of the tile providers to know about the available types and the code for it.

{% highlight c# %}

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

{% endtabs %}

![Bing maps default view](images/tile-layer/bing_maps_default.png)

## Other map tile providers

Our tile layer is not limited or specific to any of the tile providers mentioned here. It supports requesting tiles from any of the tile providers using the unique URL for respective tile providers and renders them.

For other map providers like TomTom, MapBox etc., you can check the respective official websites and provide the url in the format mentioned in the `Setting URL template` section.

Below is the example of adding TomTom map. You can get the TomTom API key from this [`link`](https://developer.tomtom.com/maps-api).

{% highlight c# %}

SfMaps map = new SfMaps();
MapTileLayer tileLayer = new MapTileLayer();
tileLayer.UrlTemplate = "https://api.tomtom.com/map/1/tile/basic/main/{z}/{x}/{y}.png?key=subscription_key";
map.Layer = tileLayer;
this.Content = map;

{% endhighlight %}

{% endtabs %}

![TomTom maps default view](images/tile-layer/tom_tom_default.png)

## Changing the center latitude and longitude

You can set the center position by setting the `MapTileLayer.Center` property. It represents the center position of the map layer.

Based on the size of the [`SfMaps`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.html) control, `Center` and `ZoomLevel` number of initial tiles needed in the view port alone will be rendered. Refer this section for enabling `zooming and panning`.

Defaults to `MapLatLng(0.0, 0.0)`.

{% tabs %}

{% highlight xaml %}

 <map:SfMaps>
    <map:SfMaps.Layer>
        <map:MapTileLayer UrlTemplate="https://tile.openstreetmap.org/{z}/{x}/{y}.png">
            <map:MapTileLayer.Center>
                <map:MapLatLng Latitude="27.175014"
                               Longitude="78.042152">
                </map:MapLatLng>
            </map:MapTileLayer.Center>
        </map:MapTileLayer>
    </map:SfMaps.Layer>
</map:SfMaps>

{% endhighlight %}

{% highlight c# %}

SfMaps map = new SfMaps();
MapTileLayer tileLayer = new MapTileLayer();
tileLayer.UrlTemplate = "https://tile.openstreetmap.org/{z}/{x}/{y}.png";
tileLayer.Center = new MapLatLng(27.175014, 78.042152);
map.Layer = tileLayer;
this.Content = map;

{% endhighlight %}

{% endtabs %}

![OSM map center](images/tile-layer/osm_center.png)

## Cache a tile images in application memory

The `CanCacheTiles` property used to decide whether the tile images should be cached in application memory or not. The default value of the `CanCacheTiles` is `false`.

While enabling the `CanCacheTiles` as `true` then need to set the tile server name to maintain the folder to store cache tiles in `MapTileLayer.UrlTemplate` property. The default tile server name to store tile cache is OSM. If you want to change server name you can use the below URL format.

https://example_provider/{z}/{x}/{y}.png?name=serverName

Here, you can replace the serverName as per your wish.

{% tabs %}

{% highlight xaml %}

<map:SfMaps>
    <map:SfMaps.Layer>
        <map:MapTileLayer UrlTemplate = "https://tile.openstreetmap.org/{z}/{x}/{y}.png?name=OpenStreetMap"
                          CanCacheTiles= "True">
        </map:MapTileLayer>
    </map:SfMaps.Layer>
</map:SfMaps>

{% endhighlight %}

{% highlight c# %}

SfMaps map = new SfMaps();
MapTileLayer tileLayer = new MapTileLayer();
tileLayer.UrlTemplate = "https://tile.openstreetmap.org/{z}/{x}/{y}.png?name=OpenStreetMap";
tileLayer.CanCacheTiles = true;
map.Layer = tileLayer;
this.Content = map;

{% endhighlight %}

{% endtabs %}

## Clear a cached tile images from application memory

The `DeleteTilesFromCache` method used to clear the cached tile images from  application cache memory.

{% tabs %}

{% highlight xaml %}

<maps:SfMaps>
    <maps:SfMaps.Layer>
        <maps:MapTileLayer x:Name="tileLayer" UrlTemplate="https://tile.openstreetmap.org/{z}/{x}/{y}.png" />
    </maps:SfMaps.Layer>
</maps:SfMaps>

{% endhighlight %}

{% highlight c# %}

tileLayer.DeleteTilesFromCache();

{% endhighlight %}

{% endtabs %}

## Markers

You can add markers in the tile layer. The procedure is very similar to the shape layer. Kindly refer the [markers](https://help.syncfusion.com/maui/maps/markers) section.

N> You can refer to our [.NET MAUI Maps](https://www.syncfusion.com/maui-controls/maui-maps) feature tour page for its groundbreaking feature representations. You can also explore our `.NET MAUI Maps Tile layer example` that shows how to configure a Maps in .NET MAUI.
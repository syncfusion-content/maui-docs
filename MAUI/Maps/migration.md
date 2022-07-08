---
layout: post
title: Migrate from Xamarin SfMaps to .NET MAUI SfMaps | Syncfusion 
description: Learn here all about Migrating from Syncfusion Xamarin SfMaps to Syncfusion .NET MAUI SfMaps control and more.
platform: MAUI
control: SfMaps
documentation: ug
---  

# Migrate from Xamarin.Forms SfMaps to .NET MAUI SfMaps

To make the migration from the [Xamarin SfMaps](https://www.syncfusion.com/xamarin-ui-controls/xamarin-maps) to [.NET MAUI SfMaps](https://www.syncfusion.com/maui-controls/maui-maps) easier, most of the APIs from the Xamarin SfMaps were kept in the.NET MAUI SfMaps. However, to maintain the consistency of API naming in the.NET MAUI SfMaps, some of the APIs have been renamed. Please find the difference in the following topics.

## Initialize control

To initialize the control, import the map namespace and initialize SfMaps as shown in the following code sample.

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
   <th>Description</th>
</tr>
<tr>
   <td>
      {{'[Layers](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.SfMaps.html#Syncfusion_SfMaps_XForms_SfMaps_Layers)'| markdownify }}
   </td>
   <td>
      {{'[Layer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.SfMaps.html#Syncfusion_Maui_Maps_SfMaps_Layer)'| markdownify }}
   </td>
</tr>
<tr>
   <td>
      {{'[ShapeFileLayer](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.ShapeFileLayer.html)'| markdownify }}
   </td>
   <td>
      {{'[MapShapeLayer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html)'| markdownify }}
   </td>
</tr>
</table>

## Adding layer

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
      {{'[BubbleSettings](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_BubbleSettings)'| markdownify }}
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
      {{'[DataSource](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_DataSource)'| markdownify }}
   </td>
</tr>
<tr>
   <td>
      {{'[ShapeIDPath](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.ShapeFileLayer.html#Syncfusion_SfMaps_XForms_ShapeFileLayer_ShapeIDPath)'| markdownify }}
   </td>
   <td>
      {{'[PrimaryValuePath](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_PrimaryValuePath)'| markdownify }}
   </td>
</tr>
<tr>
   <td>
      {{'[ShapeIDTableField](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.ShapeFileLayer.html#Syncfusion_SfMaps_XForms_ShapeFileLayer_ShapeIDTableField)'| markdownify }}
   </td>
   <td>
      {{'[ShapeDataField](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_ShapeDataField)'| markdownify }}
   </td>
</tr>
<tr>
   <td>
      {{'[Uri](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.ShapeFileLayer.html#Syncfusion_SfMaps_XForms_ShapeFileLayer_Uri)'| markdownify }}
   </td>
   <td>
      {{'[ShapesSource](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_ShapesSource)'| markdownify }}
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
      {{'[ShapeSelected](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_ShapeSelected)'| markdownify }}
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
      {{'[SelectedShapeFill](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_SelectedShapeFill)'| markdownify }}
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

The following code example, explains how to intialize layer and customize layer in Xamarin SfMaps and .Net MAUI SfMaps.

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
        <map:MapShapeLayer ShapeStroke="#1585ed"
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
        layer.ShapesSource = MapSource.FromResource("MyProject.world-map.json");
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
      {{'[SizeValuePath](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapBubbleSettings.html#Syncfusion_Maui_Maps_MapBubbleSettings_SizeValuePath)'| markdownify }}
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

The following code example, explains how to customize bubble in Xamarin SfMaps and .Net MAUI SfMaps.

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
        <map:MapShapeLayer DataSource="{Binding Data}"
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
    layer.ShapesSource = MapSource.FromResource("MyProject.world1.shp");
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
      {{'[OverflowMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapDataLabelSettings.html#Syncfusion_Maui_Maps_MapDataLabelSettings_OverflowMode)'| markdownify }}
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
      {{'[DataLabelStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapDataLabelSettings.html#Syncfusion_Maui_Maps_MapDataLabelSettings_DataLabelStyle)'| markdownify }}
   </td>
</tr>
</table>

The following code example, explains how to customize data label in Xamarin SfMaps and .Net MAUI SfMaps.

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
        <map:MapShapeLayer DataSource="{Binding Data}"
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
    layer.ShapesSource = MapSource.FromResource("MyProject.world1.shp");
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
      {{'[Text](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.ColorMapping.html#Syncfusion_Maui_Maps_ColorMapping_Text)'| markdownify }}
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

The following code example, explains how to customize shape color in Xamarin SfMaps and .Net MAUI SfMaps.

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
        <map:MapShapeLayer DataSource="{Binding Data}"
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
    layer.ShapesSource = MapSource.FromResource("MyProject.world1.shp");
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
      {{'[IconFill](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapMarker.html#Syncfusion_Maui_Maps_MapMarker_IconFill)'| markdownify }}
   </td>
</tr>
<tr>
   <td>
      {{'[IconSize](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.MapMarkerSetting.html#Syncfusion_SfMaps_XForms_MapMarkerSetting_IconSize)'| markdownify }} in
      {{'[MapMarkerSetting](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.MapMarkerSetting.html)'| markdownify }}
   </td>
   <td>
      {{'[IconHeight](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapMarker.html#Syncfusion_Maui_Maps_MapMarker_IconHeight)'| markdownify }} and
       {{'[IconWidth](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapMarker.html#Syncfusion_Maui_Maps_MapMarker_IconWidth)'| markdownify }}
   </td>
</tr>
<tr>
   <td>
      {{'[MarkerIcon](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.MapMarkerSetting.html#Syncfusion_SfMaps_XForms_MapMarkerSetting_MarkerIcon)'| markdownify }} in
      {{'[MapMarkerSetting](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.MapMarkerSetting.html)'| markdownify }}
   </td>
   <td>
      {{'[IconType](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapMarker.html#Syncfusion_Maui_Maps_MapMarker_IconType)'| markdownify }}
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

The following code example, explains how to customize marker in Xamarin SfMaps and .Net MAUI SfMaps.

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
        <map:MapShapeLayer>
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
    layer.ShapesSource = MapSource.FromResource("MyProject.world1.shp");

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
      {{'[SourceType](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapLegend.html#Syncfusion_Maui_Maps_MapLegend_SourceType)'| markdownify }}
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
      {{'[TextStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapLegend.html#Syncfusion_Maui_Maps_MapLegend_TextStyle)'| markdownify }}
   </td>
</tr>
<tr>
   <td>
      {{'[IconSize](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.MapLegendSetting.html#Syncfusion_SfMaps_XForms_MapLegendSetting_IconSize)'| markdownify }} in
      {{'[MapLegendSetting](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.MapLegendSetting.html)'| markdownify }}
   </td>
   <td>
      Upcoming
   </td>
</tr>
<tr>
   <td>
      {{'[LegendIcon](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.MapLegendSetting.html#Syncfusion_SfMaps_XForms_MapLegendSetting_LegendIcon)'| markdownify }} in
      {{'[MapLegendSetting](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.MapLegendSetting.html)'| markdownify }}
   </td>
   <td>
      Upcoming
   </td>
</tr>
</table>

The following code example, explains how to customize legend in Xamarin SfMaps and .Net MAUI SfMaps.

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
        <map:MapShapeLayer DataSource="{Binding Data}"
                           PrimaryValuePath="State"
                           ShapeDataField="name"
                           ShapeColorValuePath="Count">
            <map:MapShapeLayer.ColorMappings>
                <map:EqualColorMapping Color="Blue" Value="100" Text="100"/>
            </map:MapShapeLayer.ColorMappings>
            <map:MapShapeLayer.Legend>
                <map:MapLegend SourceType="Shape"
                               Placement="Top">
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
    layer.ShapesSource = MapSource.FromResource("MyProject.world1.shp");
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
      Upcoming
   </td>
</tr>
</table>

The below code example explains how to customize tooltip in Xamarin SfMaps and .Net MAUI SfMaps.

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
        <map:MapShapeLayer DataSource="{Binding Data}"
                           PrimaryValuePath="State"
                           ShapeDataField="name"
                           ShapeColorValuePath="Count"
                           ShowShapeToolTip="True">
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
        layer.ShapesSource = MapSource.FromResource("MyProject.world1.shp");
        layer.PrimaryValuePath = "Continent";
        layer.ShapeDataField = "continent";
        layer.DataSource = viewModel.Data;
        layer.ShowShapeTooltip = true;

        SfMaps maps = new SfMaps();
        maps.Layer = layer;
        this.Content = maps;
    }

{% endhighlight %}

{% endtabs %}
</td></tr>
</table>

## Upcoming features in .NET MAUI

* Support for imagery layer such as Bing Maps, OpenStreetMap, etc.
* Zooming and panning
* Sublayers
* Legend interaction and customization
* Tooltip customization

## Unsupported features from Xamarin.Forms

* Label support have not been provided in the marker.Instead, you can achieve it using the [MarkerTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapLayer.html#Syncfusion_Maui_Maps_MapLayer_MarkerTemplate).
* In .Net MAUI, IntersectionAction support not provided for data labels.
* [ShowLegend](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.MapLegendSetting.html#Syncfusion_SfMaps_XForms_MapLegendSetting_ShowLegend) support is not provided in the .Net MAUI. Instead, set value for the [Legend](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_Legend) to display map legend in the .Net MAUI platform.
* In Xamarin, [Layers](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.SfMaps.html#Syncfusion_SfMaps_XForms_SfMaps_Layers) are maintained as observable collection.But, In .NET MAUI, support single [Layer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.SfMaps.html#Syncfusion_Maui_Maps_SfMaps_Layer).

## Support and feedback

If you are unable to find the migration information you require in the self-help resources listed above, please contact us by creating a [support ticket](https://support.syncfusion.com/). Do not see what you need? Please request it in our [feedback portal](https://www.syncfusion.com/feedback/maui).

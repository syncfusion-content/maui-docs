---
layout: post
title: Migrate from Xamarin SfMaps to .NET MAUI SfMaps | Syncfusion 
description: Learn here all about Migrating from Syncfusion Xamarin SfMaps to Syncfusion .NET MAUI SfMaps control and more.
platform: MAUI
control: SfMaps
documentation: ug
---  

# Migrate from Xamarin.Forms SfMaps to .NET MAUI SfMaps

To migrate easier from [Xamarin SfMaps](https://www.syncfusion.com/xamarin-ui-controls/xamarin-maps) to [.NET MAUI SfMaps](https://www.syncfusion.com/maui-controls/maui-maps), we kept most of the APIs from Xamarin SfMaps in MAUI SfMaps. However, to maintain the consistency of API naming in MAUI SfMaps, we renamed some of the APIs. The APIs that have been changed in MAUI SfMaps from Xamarin SfMaps are detailed as follows.

## Adding Reference

<table>
<tr>
<th>Xamarin SfMaps</th>
<th>.NET MAUI SfMaps</th></tr>
<tr>
<td>Syncfusion.SfMaps.XForms</td>
<td>Syncfusion.Maui.Maps</td></tr>
</table>

To initialize the control, import the map namespace and initialize SfMaps as per the following code snippet.

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
      [Layers](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.SfMaps.html#Syncfusion_SfMaps_XForms_SfMaps_Layers)
   </td>
   <td>
      [Layer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.SfMaps.html#Syncfusion_Maui_Maps_SfMaps_Layer)
   </td>
   <td>
      Gets or sets the MapShapeLayer as a content of map in which geographical rendering is done.
   </td>
</tr>
<tr>
   <td>
      [ShapeFileLayer](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.ShapeFileLayer.html)
   </td>
   <td>
      [MapShapeLayer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html)
   </td>
   <td>
      The shape layer in which geographical rendering is done.
   </td>
</tr>
</table>

## Intialize Layer

<table>
<tr>
   <th>Xamarin SfMaps</th>
   <th>.NET MAUI SfMaps</th>
</tr>
<tr>
   <td>
      [BubbleMarkerSettings](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.ShapeFileLayer.html#Syncfusion_SfMaps_XForms_ShapeFileLayer_BubbleMarkerSettings)
   </td>
   <td>
      [BubbleSettings](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_BubbleSettings)
   </td>
</tr>
<tr>
   <td>
      [DataLabelSettings](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.ShapeFileLayer.html#Syncfusion_SfMaps_XForms_ShapeFileLayer_DataLabelSettings)
   </td>
   <td>
      [DataLabelSettings](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_DataLabelSettings)
   </td>
</tr>
<tr>
   <td>
      [EnableSelection](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.ShapeFileLayer.html#Syncfusion_SfMaps_XForms_ShapeFileLayer_EnableSelection)
   </td>
   <td>
      [EnableSelection](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_EnableSelection)
   </td>
</tr>
<tr>
   <td>
      [ItemsSource](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.ShapeFileLayer.html#Syncfusion_SfMaps_XForms_ShapeFileLayer_ItemsSource)
   </td>
   <td>
      [DataSource](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_DataSource)
   </td>
</tr>
<tr>
   <td>
      [ShapeIDPath](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.ShapeFileLayer.html#Syncfusion_SfMaps_XForms_ShapeFileLayer_ShapeIDPath)
   </td>
   <td>
      [PrimaryValuePath](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_PrimaryValuePath)
   </td>
</tr>
<tr>
   <td>
      [ShapeIDTableField](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.ShapeFileLayer.html#Syncfusion_SfMaps_XForms_ShapeFileLayer_ShapeIDTableField)
   </td>
   <td>
      [ShapeDataField](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_ShapeDataField)
   </td>
</tr>
<tr>
   <td>
      [Uri](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.ShapeFileLayer.html#Syncfusion_SfMaps_XForms_ShapeFileLayer_Uri)
   </td>
   <td>
      [ShapesSource](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_ShapesSource)
   </td>
</tr>
<tr>
   <td>
      [Markers](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.MapLayer.html#Syncfusion_SfMaps_XForms_MapLayer_Markers)
   </td>
   <td>
      [Markers](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapLayer.html#Syncfusion_Maui_Maps_MapLayer_Markers)
   </td>
</tr>
<tr>
   <td>
      [MarkerTemplate](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.MapLayer.html#Syncfusion_SfMaps_XForms_MapLayer_MarkerTemplate)
   </td>
   <td>
      [MarkerTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapLayer.html#Syncfusion_Maui_Maps_MapLayer_MarkerTemplate)
   </td>
</tr>
<tr>
   <td>
      [ShapeSelectionChanged](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.ShapeFileLayer.html#Syncfusion_SfMaps_XForms_ShapeFileLayer_ShapeSelectionChanged)
   </td>
   <td>
      [ShapeSelected](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_ShapeSelected)
   </td>
</tr>
</table>

The below code example, explains how to intialize layer and customize layer in Xamarin SfMaps and .Net MAUI SfMaps.

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
                                    ShapeStroke="#1585ed"
                                    ShapeStrokeThickness="2"
                                    SelectedShapeColor="#1a35db"
                                    SelectedShapeStroke="DarkGrey"
                                    SelectedShapeStrokeThickness="1">
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
    shapeSetting.ShapeStrokeThickness = 2;
    shapeSetting.SelectedShapeColor = Color.FromRgb(26, 53, 219);
    shapeSetting.SelectedShapeStroke = Color.DarkGray;
    shapeSetting.SelectedShapeStrokeThickness = 1;
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
                           ShapeFill="#b5dcff"  
                           ShapeStrokeThickness="2"
                           ShapeHoverStroke="Blue"
                           ShapeHoverFill="LightBlue"  
                           ShapeHoverStrokeThickness="2"
                           SelectedShapeFill="#1a35db"
                           SelectedShapeStroke="DarkGrey"
                           SelectedShapeStrokeThickness="1">
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
        layer.ShapeStrokeThickness = 2;
        layer.ShapeHoverFill = Brush.LightBlue;
        layer.ShapeHoverStroke = Brush.Blue;
        layer.ShapeHoverStrokeThickness = 2;
        layer.SelectedShapeFill = Color.FromRgb(26, 53, 219);
        layer.SelectedShapeStroke = Colors.DarkGray;
        layer.SelectedShapeStrokeThickness = 1;

        SfMaps maps = new SfMaps();
        maps.Layer = layer;

        this.Content = maps;
    }

{% endhighlight %}

{% endtabs %}
</td></tr>
</table>

## BubbleSettings

<table>
<tr>
<th>Xamarin SfMaps</th>
<th>.NET MAUI SfMaps</th>
</tr>
<tr>
   <td>
      [ColorMappings](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.BubbleMarkerSetting.html#Syncfusion_SfMaps_XForms_BubbleMarkerSetting_ColorMappings)
   </td>
   <td>
      [ColorMappings](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapBubbleSettings.html#Syncfusion_Maui_Maps_MapBubbleSettings_ColorMappings)
   </td>
</tr>
<tr>
   <td>
      [ColorValuePath](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.BubbleMarkerSetting.html#Syncfusion_SfMaps_XForms_BubbleMarkerSetting_ColorValuePath)
   </td>
   <td>
      [ColorValuePath](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapBubbleSettings.html#Syncfusion_Maui_Maps_MapBubbleSettings_ColorValuePath)
   </td>
</tr>
<tr>
   <td>
      [Fill](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.BubbleMarkerSetting.html#Syncfusion_SfMaps_XForms_BubbleMarkerSetting_Fill)
   </td>
   <td>
      [Fill](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapBubbleSettings.html#Syncfusion_Maui_Maps_MapBubbleSettings_Fill)
   </td>
</tr>
<tr>
   <td>
      [MaxSize](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.BubbleMarkerSetting.html#Syncfusion_SfMaps_XForms_BubbleMarkerSetting_MaxSize)
   </td>
   <td>
      [MaxSize](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapBubbleSettings.html#Syncfusion_Maui_Maps_MapBubbleSettings_MaxSize)
   </td>
</tr>
<tr>
   <td>
      [MinSize](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.BubbleMarkerSetting.html#Syncfusion_SfMaps_XForms_BubbleMarkerSetting_MinSize)
   </td>
   <td>
      [MinSize](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapBubbleSettings.html#Syncfusion_Maui_Maps_MapBubbleSettings_MinSize)
   </td>
</tr>
<tr>
   <td>
      [Opacity](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.BubbleMarkerSetting.html#Syncfusion_SfMaps_XForms_BubbleMarkerSetting_Opacity)
   </td>
   <td>
      [Opacity](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapBubbleSettings.html#Syncfusion_Maui_Maps_MapBubbleSettings_Opacity)
   </td>
</tr>
<tr>
   <td>
      [ValuePath](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.BubbleMarkerSetting.html#Syncfusion_SfMaps_XForms_BubbleMarkerSetting_ValuePath)
   </td>
   <td>
      [SizeValuePath](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapBubbleSettings.html#Syncfusion_Maui_Maps_MapBubbleSettings_SizeValuePath)
   </td>
</tr>
</table>

The below code example explains how to customize bubble in Xamarin SfMaps and .Net MAUI SfMaps.

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
                                          ValuePath="Population"  
                                          Fill="Green"
                                          Opacity="0.8"
                                          MinSize="30"
                                          MaxSize="80"/>
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
        Opacity = 0.8,
        ColorValuePath = "Population",
        SizeValuePath = "Population",
        Fill = Colors.Green,
        MinSize = 30,
        MaxSize = 80
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
                           ShapeHoverFill = "Transparent" 
                           ShapeHoverStroke="Transparent"
                           ShowBubbles="True"
                           ShowBubbleTooltip="True" >

            <map:MapShapeLayer.BubbleSettings>
                <map:MapBubbleSettings ColorValuePath="Population" 
                                       SizeValuePath="Population" 
                                       Opacity="0.8"
                                       Fill="Green"
                                       Stroke="DarkGreen"
                                       StrokeThickness="2"
                                       HoverFill="Blue"
                                       HoverStroke="DarkBlue"
                                       HoverStrokeThickness="3"
                                       MinSize="30"
                                       MaxSize="80">
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
    layer.ShapeHoverFill = Colors.Transparent;
    layer.ShapeHoverStroke = Colors.Transparent;
    layer.ShowBubbles = true;
    layer.ShowBubbleTooltip = true;

    MapBubbleSettings bubbleSetting = new MapBubbleSettings()
    {
        ColorValuePath = "Population",
        SizeValuePath = "Population",
        Fill = Colors.Green,
        Opacity = 0.8,
        Stroke = Colors.DarkGreen,
        StrokeThickness = 2,
        HoverFill = Colors.Blue,
        HoverStroke = Colors.DarkBlue,
        HoverStrokeThickness = 3,
        MinSize = 30,
        MaxSize = 80
    };

    layer.BubbleSettings = bubbleSetting;
    maps.Layer = layer;
    this.Content = maps;
}

{% endhighlight %}

{% endtabs %}
</td></tr>
</table>

## DataLabelSettings

<table>
<tr>
<th>Xamarin SfMaps</th>
<th>.NET MAUI SfMaps</th>
</tr>
<tr>
   <td>
      [SmartLabelMode](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.DataLabelSetting.html#Syncfusion_SfMaps_XForms_DataLabelSetting_SmartLabelMode)
   </td>
   <td>
      [OverflowMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapDataLabelSettings.html#Syncfusion_Maui_Maps_MapDataLabelSettings_OverflowMode)
   </td>
</tr>
</table>

The below code example explains how to customize data label in Xamarin SfMaps and .Net MAUI SfMaps.

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
                <maps:DataLabelSetting  SmartLabelMode="Trim"
                                        TextColor="#ff4e41"
                                        FontAttributes="Italic"
                                        FontSize="12" />
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
    dataLabelSetting.TextColor = Color.FromRgb(255, 78, 65);
    dataLabelSetting.FontAttributes = FontAttributes.Italic;
    dataLabelSetting.FontSize = 12;
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
                           ShowBubbles="True"
                           ShowBubbleTooltip="True" >

            <map:MapShapeLayer.DataLabelSettings>
                <map:MapDataLabelSettings OverflowMode="Trim"
                                          DataLabelPath="State">
                        <map:MapDataLabelSettings.DataLabelStyle>
                                <map:MapLabelStyle FontSize="12"
                                                   TextColor="#ff4e41"
                                                   FontAttributes="Italic" />
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
           FontSize = 12,
           FontAttributes = FontAttributes.Italic,
           TextColor = Color.FromRgb(255, 78, 65)
       },
    };

    maps.Layer = layer;
    this.Content = maps;
}

{% endhighlight %}

{% endtabs %}
</td></tr>
</table>

## ColorMappings

<table>
<tr>
<th>Xamarin SfMaps</th>
<th>.NET MAUI SfMaps</th>
</tr>
<tr>
   <td>
      [Color](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.ColorMapping.html#Syncfusion_SfMaps_XForms_ColorMapping_Color)
   </td>
   <td>
      [Color](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.ColorMapping.html#Syncfusion_Maui_Maps_ColorMapping_Color)
   </td>
</tr>
<tr>
   <td>
      [LegendLabel](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.ColorMapping.html#Syncfusion_SfMaps_XForms_ColorMapping_LegendLabel)
   </td>
   <td>
      [Text](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.ColorMapping.html#Syncfusion_Maui_Maps_ColorMapping_Text)
   </td>
</tr>
<tr>
   <td>
      [EqualColorMapping](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.EqualColorMapping.html)
   </td>
   <td>
      [EqualColorMapping](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.EqualColorMapping.html)
   </td>
</tr>
<tr>
   <td>
      [RangeColorMapping](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.RangeColorMapping.html)
   </td>
   <td>
      [RangeColorMapping](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.RangeColorMapping.html)
   </td>
</tr>
</table>

### EqualColorMapping

<table>
<tr>
<th>Xamarin SfMaps</th>
<th>.NET MAUI SfMaps</th>
</tr>
<tr>
   <td>
      [Value](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.EqualColorMapping.html#Syncfusion_SfMaps_XForms_EqualColorMapping_Value)
   </td>
   <td>
      [Value](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.EqualColorMapping.html#Syncfusion_Maui_Maps_EqualColorMapping_Value)
   </td>
</tr>
</table>

### RangeColorMapping

<table>
<tr>
<th>Xamarin SfMaps</th>
<th>.NET MAUI SfMaps</th>
</tr>
<tr>
   <td>
      [From](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.RangeColorMapping.html#Syncfusion_SfMaps_XForms_RangeColorMapping_From)
   </td>
   <td>
      [From](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.RangeColorMapping.html#Syncfusion_Maui_Maps_RangeColorMapping_From)
   </td>
</tr>
<tr>
   <td>
      [To](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.RangeColorMapping.html#Syncfusion_SfMaps_XForms_RangeColorMapping_To)
   </td>
   <td>
      [To](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.RangeColorMapping.html#Syncfusion_Maui_Maps_RangeColorMapping_To)
   </td>
</tr>
</table>

The below code example explains how to customize shape color in Xamarin SfMaps and .Net MAUI SfMaps.

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
                        <maps:EqualColorMapping Color="Blue" Value="150" Text="150"/>
                        <maps:RangeColorMapping Color="Green" From="0" To="90" Text="0-90"/>
                        <maps:RangeColorMapping Color="Red" From="100" To="149" Text="100-149"/>
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

    RangeColorMapping colorMapping = new RangeColorMapping();
    colorMapping.Color = Colors.Green;
    colorMapping.From = 0;
    colorMapping.To = 90;
    colorMapping1.Text = "0-90";

    RangeColorMapping colorMapping1 = new RangeColorMapping();
    colorMapping1.Color = Colors.Red;
    colorMapping1.From = 100;
    colorMapping1.To = 149;
    colorMapping1.Text = "100-149";

    EqualColorMapping colorMapping2 = new EqualColorMapping();
    colorMapping2.Color = Colors.Blue;
    colorMapping2.Value = "150";
    colorMapping2.Text = "150";
    
    ShapeSetting shapeSetting = new ShapeSetting();
    shapeSetting.ShapeValuePath = "Count";
    shapeSetting.ShapeColorValuePath = "Count";
    
    shapeSetting.ColorMappings.Add(colorMapping);
    shapeSetting.ColorMappings.Add(colorMapping1);
    shapeSetting.ColorMappings.Add(colorMapping2);

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
                <map:EqualColorMapping Color="Blue" Value="150" Text="150"/>
                <map:RangeColorMapping Color="Green" From="0" To="90" Text="0-90"/>
                <map:RangeColorMapping Color="Red" From="100" To="149" Text="100-149"/>
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

    RangeColorMapping colorMapping = new RangeColorMapping();
    colorMapping.Color = Colors.Green;
    colorMapping.From = 0;
    colorMapping.To = 90;
    colorMapping1.Text = "0-90";

    RangeColorMapping colorMapping1 = new RangeColorMapping();
    colorMapping1.Color = Colors.Red;
    colorMapping1.From = 100;
    colorMapping1.To = 149;
    colorMapping1.Text = "100-149";

    EqualColorMapping colorMapping2 = new EqualColorMapping();
    colorMapping2.Color = Colors.Blue;
    colorMapping2.Value = "150";
    colorMapping2.Text = "150";

    layer.ColorMappings.Add(colorMapping);
    layer.ColorMappings.Add(colorMapping1);
    layer.ColorMappings.Add(colorMapping2);

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
      [Latitude](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.MapMarker.html#Syncfusion_SfMaps_XForms_MapMarker_Latitude)
   </td>
   <td>
      [Latitude](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapMarker.html#Syncfusion_Maui_Maps_MapMarker_Latitude)
   </td>
</tr>
<tr>
   <td>
      [Longitude](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfMaps.XForms.MapMarker.html#Syncfusion_SfMaps_XForms_MapMarker_Longitude)
   </td>
   <td>
      [Longitude](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapMarker.html#Syncfusion_Maui_Maps_MapMarker_Longitude)
   </td>
</tr>
</table>

The below code example explains how to customize marker in Xamarin SfMaps and .Net MAUI SfMaps.

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
            <maps:ShapeFileLayer.Markers>
                <maps:MapMarker Latitude="20.5595"
                                Longitude="22.9375"/>
            </maps:ShapeFileLayer.Markers>
            <maps:ShapeFileLayer.MarkerSettings>
                <maps:MapMarkerSetting x:Name="markerSetting"
                                       VerticalAlignment="Center"
                                       HorizontalAlignment="Center"
                                       IconColor="Red"
                                       IconSize="15"
                                       MarkerIcon="Diamond"/>
            </maps:ShapeFileLayer.MarkerSettings>
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

    MapMarker mapMarker = new MapMarker();
    mapMarker.Latitude = 20.5595;
    mapMarker.Longitude = 22.9375;
    layer.Markers.Add(marker);

    MapMarkerSetting mapMarkerSetting = new MapMarkerSetting();
    mapMarkerSetting.IconSize = 15;
    mapMarkerSetting.IconColor = Colors.Red;
    markerSetting.MarkerIcon = MapMarkerIcon.Diamond;
    mapMarkerSetting.HorizontalAlignment = MarkerAlignment.Center;
    mapMarkerSetting.VerticalAlignment = MarkerAlignment.Center;
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
        <map:MapShapeLayer DataSource="{Binding Data}"
                           PrimaryValuePath="State"
                           ShapeDataField="name"
                           ShapeHoverFill = "Transparent"
                           ShapeHoverStroke="Transparent">
            <map:MapShapeLayer.Markers>
                <map:MapMarkerCollection>
                    <map:MapMarker Latitude="20.5595"
                                   Longitude="22.9375"
                                   IconWidth="15"
                                   IconHeight="15"
                                   IconFill="Red"
                                   IconType="Diamond"
                                   HorizontalAlignment="Center"
                                   VerticalAlignment="Start" />
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
    ViewModel viewModel = new ViewModel();
    this.BindingContext = viewModel;
    SfMaps maps = new SfMaps();
    MapShapeLayer layer = new MapShapeLayer();
    layer.ShapesSource = MapSource.FromResource("MyProject.world1.shp");
    layer.DataSource = viewModel.Data;
    layer.PrimaryValuePath = "State";
    layer.ShapeDataField = "name";

    MapMarker mapMarker = new MapMarker();
    mapMarker.Latitude = 20.5595;
    mapMarker.Longitude = 22.9375;
    mapMarker.HorizontalAlignment = MapAlignment.Center;
    mapMarker.VerticalAlignment = MapAlignment.Center;
    mapMarker.IconHeight = 15;
    mapMarker.IconWidth = 15;
    mapMarker.IconType = MapIconType.Diamond;
    mapMarker.IconFill = Colors.Red;

    maps.Layer = layer;
    this.Content = maps;
}

{% endhighlight %}

{% endtabs %}
</td></tr>
</table>

## Legend

The below code example explains how to customize legend in Xamarin SfMaps and .Net MAUI SfMaps.

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
                        <maps:EqualColorMapping Color="Blue" Value="150" Text="150"/>
                        <maps:RangeColorMapping Color="Green" From="0" To="90" Text="0-90"/>
                        <maps:RangeColorMapping Color="Red" From="100" To="149" Text="100-149"/>
                    </maps:ShapeSetting.ColorMappings>
                </maps:ShapeSetting>
            </maps:ShapeFileLayer.ShapeSettings>
            <maps:ShapeFileLayer.LegendSettings>
                        <maps:MapLegendSetting ItemMargin="30" LegendIcon="Diamond" LegendPosition="50,20"
                                               FontFamily="algerian.ttf" FontSize="14" TextColor="Maroon"
                                               ShowLegend="True">
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

    RangeColorMapping colorMapping = new RangeColorMapping();
    colorMapping.Color = Colors.Green;
    colorMapping.From = 0;
    colorMapping.To = 90;
    colorMapping1.Text = "0-90";

    RangeColorMapping colorMapping1 = new RangeColorMapping();
    colorMapping1.Color = Colors.Red;
    colorMapping1.From = 100;
    colorMapping1.To = 149;
    colorMapping1.Text = "100-149";

    EqualColorMapping colorMapping2 = new EqualColorMapping();
    colorMapping2.Color = Colors.Blue;
    colorMapping2.Value = "150";
    colorMapping2.Text = "150";
    
    ShapeSetting shapeSetting = new ShapeSetting();
    shapeSetting.ShapeValuePath = "Count";
    shapeSetting.ShapeColorValuePath = "Count";

    MapLegendSetting legendSetting = new MapLegendSetting();
    legendSetting.ShowLegend = true;
    legendSetting.LegendPosition = new Point(50, 20);
    legendSetting.LegendType = LegendType.Layers;
    legendSetting.FontFamily ="algerian.ttf";
    legendSetting.TextColor = Color.Maroon;
    legendSetting.ItemMargin = 30;
    legendSetting.LegendIcon = LegendIcon.Diamond;
    layer.LegendSettings = legendSetting;

    shapeSetting.ColorMappings.Add(colorMapping);
    shapeSetting.ColorMappings.Add(colorMapping1);
    shapeSetting.ColorMappings.Add(colorMapping2);

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
                <map:EqualColorMapping Color="Blue" Value="150" Text="150"/>
                <map:RangeColorMapping Color="Green" From="0" To="90" Text="0-90"/>
                <map:RangeColorMapping Color="Red" From="100" To="149" Text="100-149"/>
            </map:MapShapeLayer.ColorMappings>
            <map:MapShapeLayer.Legend>
                <map:MapLegend SourceType="Shape"
                               Placement="Top">
                    <map:MapLegend.TextStyle>
                        <map:MapLabelStyle FontSize="16"
                                           TextColor="Maroon"
                                           FontFamily="Times"
                                           FontAttributes="Italic" />
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

    RangeColorMapping colorMapping = new RangeColorMapping();
    colorMapping.Color = Colors.Green;
    colorMapping.From = 0;
    colorMapping.To = 90;
    colorMapping1.Text = "0-90";

    RangeColorMapping colorMapping1 = new RangeColorMapping();
    colorMapping1.Color = Colors.Red;
    colorMapping1.From = 100;
    colorMapping1.To = 149;
    colorMapping1.Text = "100-149";

    EqualColorMapping colorMapping2 = new EqualColorMapping();
    colorMapping2.Color = Colors.Blue;
    colorMapping2.Value = "150";
    colorMapping2.Text = "150";

    layer.ColorMappings.Add(colorMapping);
    layer.ColorMappings.Add(colorMapping1);
    layer.ColorMappings.Add(colorMapping2);

    MapLegend legendSet = new MapLegend();
    legendSet.SourceType = LegendSourceType.Shape;
    legendSet.Placement = Syncfusion.Maui.Core.LegendPlacement.Top;

    MapLabelStyle mapLabelStyle = new MapLabelStyle();
    mapLabelStyle.TextColor = Colors.Black;
    mapLabelStyle.FontSize = 16;
    mapLabelStyle.FontFamily = "Times";
    mapLabelStyle.FontAttributes = FontAttributes.Italic;
        
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
                                      ValuePath="Count"
                                      TextColor="White"
                                      Margin="10"
                                      BackgroundColor="Green"  
                                      StrokeColor="Black"
                                      StrokeWidth="2"
                                      Duration="2000"/>
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
    shapeFileLayer.TooltipSettings.TextColor = Color.White;
    shapeFileLayer.TooltipSettings.BackgroundColor = Color.Green;
    shapeFileLayer.TooltipSettings.StrokeColor = Color.Black;
    shapeFileLayer.TooltipSettings.StrokeWidth = 2;
    shapeFileLayer.TooltipSettings.Margin = 10;
    shapeFileLayer.TooltipSettings.Duration = 2000;

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
            <map:MapShapeLayer.ShapeTooltipTemplate>
                <DataTemplate>
                    <Grid>
                        <Grid.RowDefinitions>
                            <RowDefinition />
                            <RowDefinition />
                            <RowDefinition />
                        </Grid.RowDefinitions>
                        <Grid.ColumnDefinitions>
                            <ColumnDefinition />
                            <ColumnDefinition />
                        </Grid.ColumnDefinitions>
                        <Image Source="flag.png"
                               Grid.Column="0"
                               Grid.Row="0"
                               WidthRequest="20"
                               HeightRequest="20" />
                        <Label Text="{Binding Continent}"
                               TextColor="White"
                               Grid.Column="1"
                               Grid.Row="0"
                               Padding="10" />
                        <Label Grid.Row="2"
                               Grid.ColumnSpan="2"
                               Text="{Binding Area}"
                               TextColor="White" />
                    </Grid>
                </DataTemplate>
            </map:MapShapeLayer.ShapeTooltipTemplate>
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
        layer.ShapeHoverFill = Colors.Transparent;
        layer.ShapeHoverStroke = Colors.Transparent;
        layer.ShowShapeTooltip = true;
        layer.ShapeTooltipTemplate = CreateDataTemplate();

        SfMaps maps = new SfMaps();
        maps.Layer = layer;
        this.Content = maps;
    }

    private DataTemplate CreateDataTemplate()
    {
        return new DataTemplate(() =>
        {
            var grid = new Grid()
            {
                RowDefinitions =
                {
                  new RowDefinition (),
                  new RowDefinition(),
                  new RowDefinition()
                },
                ColumnDefinitions =
                {
                    new ColumnDefinition(),
                    new ColumnDefinition(),
                }
            };

            var image = new Image
            {
                Source = "flag.png",
                WidthRequest = 20
                , HeightRequest = 20
            };
            grid.SetRow(image, 0);
            grid.SetColumn(image, 0);
            var label = new Label
            {
                FontAttributes = FontAttributes.Bold,
                TextColor = Colors.White,
                Padding = 5
            };
            Binding binding = new Binding();
            binding.Source = grid.BindingContext;
            binding.Path = nameof(Model1.Continent);
            label.SetBinding(Label.TextProperty, binding);
            grid.SetRow(label, 0); grid.SetColumn(label, 1);
            var areaLabel = new Label
            {
                FontAttributes = FontAttributes.Bold,
                TextColor = Colors.White
            };
            grid.SetRow(areaLabel, 2);
            grid.SetColumnSpan(areaLabel, 2);
            Binding binding1 = new Binding();
            binding1.Source = grid.BindingContext;
            binding1.Path = nameof(Model1.Area);
            areaLabel.SetBinding(Label.TextProperty, binding1);

            grid.Children.Add(image);
            grid.Children.Add(label);
           
            grid.Children.Add(areaLabel);
            return new ViewCell { View = grid };
        });
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

## Support and feedback

If you are unable to find the migration information you require in the self-help resources listed above, please contact us by creating a [support ticket](https://www.syncfusion.com/support/directtrac/incidents). Do not see what you need? Please request it in our [feedback portal](https://www.syncfusion.com/feedback/maui).

---
layout: post
title: Bubbles in maximum Maps widget | Syncfusion
description: Learn here all about the Bubbles feature of Syncfusion MAUI Maps (SfMaps) widget to customize their appearances and more.
platform: MAUI
control: SfMaps
documentation: ug
---

# Bubbles in MAUI Maps (SfMaps)

Bubbles can be rendered in different colors and sizes based on the data values of their assigned shape. You can add information to shapes such as population density, number of users, and more. 

## Enable bubbles

You can enable bubbles using the [`MapShapeLayer.ShowBubbles`](https://pub.dev/documentation/syncfusion_flutter_maps/latest/maps/MapShapeSource/bubbleSizeMapper.html). 
You can customize a bubbles using the [`MapShapeLayer.BubbleSettings`](https://pub.dev/documentation/syncfusion_flutter_maps/latest/maps/MapShapeSource/bubbleSizeMapper.html).This property is used to specify the value based on which the bubble's size has to be rendered.

{% tabs %}

{% highlight xaml %}

     <map:SfMaps>
        <map:SfMaps.Layer>
            <map:MapShapeLayer 
                  ShapesSource="https://cdn.syncfusion.com/maps/map-data/world-map.json"
                  DataSource="{Binding Data}" PrimaryValuePath="Continent" ShapeDataField="continent" ShowBubbles="True" >

              <map:MapShapeLayer.BubbleSettings>
                  <map:MapBubbleSettings ColorValuePath="Population" 
                      SizeValuePath="Population" 
                      Fill="DarkViolet"
                      MinSize="30"
                      MaxSize="80">
                  </map:MapBubbleSettings>
              </map:MapShapeLayer.BubbleSettings>
            </map:MapShapeLayer>
        </map:SfMaps.Layer>
    </map:SfMaps>

{% endhighlight %}

{% highlight c# %}

public MainPage()
{
   InitializeComponent();
        ObservableCollection<Model> Data = new ObservableCollection<Model>();
        Data.Add(new Model("Asia", 51));
        Data.Add(new Model("Africa", 58));
        Data.Add(new Model("Europe", 48));
        Data.Add(new Model("North America", 41));
        Data.Add(new Model("South America", 14));
        Data.Add(new Model("Australia", 23));
        
        SfMaps maps = new SfMaps();
        MapShapeLayer layer = new MapShapeLayer();
        layer.ShapesSource = MapSource.FromUri(new Uri("https://cdn.syncfusion.com/maps/map-data/world-map.json"));
        layer.DataSource = Data;
        layer.PrimaryValuePath = "Continent";
        layer.ShapeDataField = "continent";
        layer.ShowBubbles = true;

        MapBubbleSettings bubbleSetting = new MapBubbleSettings()
        {
            ColorValuePath = "Population",
            SizeValuePath = "Population",
            Fill = Colors.DarkViolet,
            MinSize = 30,
            MaxSize =80
            
        };

        layer.BubbleSettings = bubbleSetting;
        maps.Layer = layer;
        this.Content = maps;
    }
    public class Model
    {
        public Model(string continent, int population)
        {
            Continent = continent;
            Population = population;
        }
        public String Continent { get; set; }
        public int Population { get; set; }
    }

{% endhighlight %}

{% endtabs %}

![Bubble support](images/bubble/default-bubble.png)

## Tooltip for the bubbles

You can enable tooltip for the bubbles using the [`MapShapeLayer.ShowBubbleTooltip`](https://pub.dev/documentation/syncfusion_flutter_maps/latest/maps/MapShapeLayer/bubbleTooltipBuilder.html) property. It can be used to indicate clearly the information about the currently interacted bubble.

{% tabs %}

{% highlight xaml %}

     <map:SfMaps>
        <map:SfMaps.Layer>
            <map:MapShapeLayer 
                  ShapesSource="https://cdn.syncfusion.com/maps/map-data/world-map.json"  ShowBubbleTooltip="True"
                  DataSource="{Binding Data}" PrimaryValuePath="Continent" ShapeDataField="continent" ShowBubbles="True" >

                <map:MapShapeLayer.BubbleSettings>
                  <map:MapBubbleSettings ColorValuePath="Population" 
                      SizeValuePath="Population" 
                      Fill="LightGreen"
                      Stroke="Green"
                      StrokeThickness="2"
                      MinSize="30"
                      MaxSize="80">
                  </map:MapBubbleSettings>
                </map:MapShapeLayer.BubbleSettings>
            </map:MapShapeLayer>
        </map:SfMaps.Layer>
    </map:SfMaps>

{% endhighlight %}

{% highlight c# %}

Data = new ObservableCollection<Model>();
        Data.Add(new Model("Asia", 51));
        Data.Add(new Model("Africa", 58));
        Data.Add(new Model("Europe", 48));
        Data.Add(new Model("North America", 41));
        Data.Add(new Model("South America", 14));
        Data.Add(new Model("Australia", 23));
        
        SfMaps maps = new SfMaps();
        MapShapeLayer layer = new MapShapeLayer();
        layer.ShapesSource = MapSource.FromUri(new Uri("https://cdn.syncfusion.com/maps/map-data/world-map.json"));
        layer.DataSource = Data;
        layer.PrimaryValuePath = "Continent";
        layer.ShapeDataField = "continent";
        layer.ShowBubbleTooltip = true;
        layer.ShowBubbles = true;

        MapBubbleSettings bubbleSetting = new MapBubbleSettings()
        {
            ColorValuePath = "Population",
            SizeValuePath = "Population",
            Fill = Colors.LightGreen,
            Stroke = Colors.Green,
            StrokeThickness = 2,
            MinSize = 30,
            MaxSize =80
            
        };

        layer.BubbleSettings = bubbleSetting;
        maps.Layer = layer;
        this.Content = maps;
    }
   public class Model
   {
        public Model(string continent, int population)
        {
            Continent = continent;
            Population = population;
        }
        public String Continent { get; set; }
        public int Population { get; set; }
  }

{% endhighlight %}

{% endtabs %}

![Bubble tooltip](images/bubble/bubble-tooltip.png)

## Color

You can customize the bubble color based on the value returned from the [`MapBubbleSettings.ColorMappings`](https://pub.dev/documentation/syncfusion_flutter_maps/latest/maps/MapShapeSource/bubbleColorValueMapper.html) property. 

If [`ColorMappings`](https://pub.dev/documentation/syncfusion_flutter_maps/latest/maps/MapShapeSource/bubbleColorValueMapper.html) returns a color, then the color will be applied to the bubble straightaway.

 The value returned from the [`ColorMappings`](https://pub.dev/documentation/syncfusion_flutter_maps/latest/maps/MapShapeSource/bubbleColorValueMapper.html) will be used for the comparison in the [`EqualColorMapping.Value`](https://pub.dev/documentation/syncfusion_flutter_maps/latest/maps/MapColorMapper/value.html) or [`RangeColorMapping.From`](https://pub.dev/documentation/syncfusion_flutter_maps/latest/maps/MapColorMapper/from.html) and [`RangeColorMapping.To`](https://pub.dev/documentation/syncfusion_flutter_maps/latest/maps/MapColorMapper/to.html). Then, the [`RangeColorMapping.Color`](https://pub.dev/documentation/syncfusion_flutter_maps/latest/maps/MapColorMapper/color.html) or [`EqualColorMapping.Color`](https://pub.dev/documentation/syncfusion_flutter_maps/latest/maps/MapColorMapper/color.html) will be applied to the respective bubble.

{% tabs %}

{% highlight xaml %}

     <map:SfMaps>
        <map:SfMaps.Layer>
            <map:MapShapeLayer 
                  ShapesSource="https://cdn.syncfusion.com/maps/map-data/world-map.json"  ShowBubbleTooltip="True" 
                  ShapeColorValuePath = "Population" ShowDataLabels="True"
                  DataSource="{Binding Data}" PrimaryValuePath="Continent" ShapeDataField="continent" ShowBubbles="True" >

              <map:MapShapeLayer.BubbleSettings>

                <map:MapBubbleSettings ColorValuePath="Population" 
                      SizeValuePath="Population" 
                      HoverFill="DarkOrange"
                      HoverStroke="Orange"
                      HoverStrokeThickness="2"
                      MinSize="30"
                      MaxSize="80">

                      <map:MapBubbleSettings.ColorMappings>
                           <map:EqualColorMapping  Color="DarkViolet" Value="51"/>
                           <map:EqualColorMapping  Color="Orange" Value="58"/>
                           <map:EqualColorMapping  Color="Yellow" Value="41"/>
                           <map:EqualColorMapping  Color="LightGreen" Value="48"/>
                           <map:EqualColorMapping  Color="Green" Value="14"/>
                           <map:EqualColorMapping  Color="Aqua" Value="23"/>
                      </map:MapBubbleSettings.ColorMappings>
                </map:MapBubbleSettings>
              </map:MapShapeLayer.BubbleSettings>

              <map:MapShapeLayer.DataLabelSettings>
                  <map:MapDataLabelSettings  DataLabelPath="Continent" OverflowMode="None">
                      <map:MapDataLabelSettings.DataLabelStyle>
                         <map:MapLabelStyle FontSize="12" TextColor="Red" FontAttributes="Italic"/>
                      </map:MapDataLabelSettings.DataLabelStyle>
                  </map:MapDataLabelSettings>
              </map:MapShapeLayer.DataLabelSettings>

            </map:MapShapeLayer>
        </map:SfMaps.Layer>
    </map:SfMaps>

{% endhighlight %}

{% highlight c# %}

public MainPage()
    {
        InitializeComponent();
        ObservableCollection<Model> Data = new ObservableCollection<Model>();
        Data.Add(new Model("Asia", 51));
        Data.Add(new Model("Africa", 58));
        Data.Add(new Model("Europe", 48));
        Data.Add(new Model("North America", 41));
        Data.Add(new Model("South America", 14));
        Data.Add(new Model("Australia", 23));

        SfMaps maps = new SfMaps();
        MapShapeLayer layer = new MapShapeLayer();
        layer.ShapesSource = MapSource.FromUri(new Uri("https://cdn.syncfusion.com/maps/map-data/world-map.json"));
        layer.DataSource = Data;
        layer.PrimaryValuePath = "Continent";
        layer.ShapeDataField = "continent";
        layer.ShowBubbles = true;

        MapBubbleSettings bubbleSetting = new MapBubbleSettings()
        {
            ColorValuePath = "Population",
            SizeValuePath = "Population",
            Opacity = 1,
            MinSize = 30,
            MaxSize = 80,
            HoverFill = Colors.DarkOrange,
            HoverStroke = Colors.Orange,
            HoverStrokeThickness = 2,
        };
        bubbleSetting.ColorMappings.Add(new EqualColorMapping() { Color = Colors.DarkViolet, Value = "51" });
        bubbleSetting.ColorMappings.Add(new EqualColorMapping() { Color = Colors.Orange, Value = "58" });
        bubbleSetting.ColorMappings.Add(new EqualColorMapping() { Color = Colors.Yellow, Value = "41" });
        bubbleSetting.ColorMappings.Add(new EqualColorMapping() { Color = Colors.LightGreen, Value = "48" });
        bubbleSetting.ColorMappings.Add(new EqualColorMapping() { Color = Colors.Green, Value = "14" });
        bubbleSetting.ColorMappings.Add(new EqualColorMapping() { Color = Colors.Aqua, Value = "23" });

        layer.BubbleSettings = bubbleSetting;
        layer.ShapeColorValuePath = "Population";
        layer.ShowDataLabels = true;

        layer.DataLabelSettings = new MapDataLabelSettings()
        {
            DataLabelPath = "Continent",
            OverflowMode = MapLabelOverflowMode.None,
            DataLabelStyle = new MapLabelStyle()
            {
                FontSize = 12,
                FontAttributes = FontAttributes.Italic,
                TextColor = Colors.Red
            },
        };

        layer.BubbleSettings = bubbleSetting;
        maps.Layer = layer;
        this.Content = maps;
    }
    public class Model
    {
        public Model(string continent, int population)
        {
            Continent = continent;
            Population = population;
        }
        public String Continent { get; set; }
        public int Population { get; set; }
    }

{% endhighlight %}

{% endtabs %}

![Bubble palette](images/bubble/bubble-palette.png)

## Appearance customization

You can customize the below appearance of the bubbles.

* **MinSize** - Change the minimum radius of the bubbles using the [`MapBubbleSettings.MinSize`](https://pub.dev/documentation/syncfusion_flutter_maps/latest/maps/MapBubbleSettings/minRadius.html) property. The default value of the [`MinSize`](https://pub.dev/documentation/syncfusion_flutter_maps/latest/maps/MapBubbleSettings/minRadius.html) property is `20.0`.
* **MaxSize** - Change the maximum radius of the bubbles using the [`MapBubbleSettings.MaxSize`](https://pub.dev/documentation/syncfusion_flutter_maps/latest/maps/MapBubbleSettings/maxRadius.html) property. The default value of the [`MaxSize`](https://pub.dev/documentation/syncfusion_flutter_maps/latest/maps/MapBubbleSettings/maxRadius.html) property is `50.0`.
* **Fill** - Change the background color of the bubbles using the [`MapBubbleSettings.Fill`](https://pub.dev/documentation/syncfusion_flutter_maps/latest/maps/MapBubbleSettings/color.html) property.
* **Stroke** - Change the stroke color of the bubbles using the [`MapBubbleSettings.Stroke`](https://pub.dev/documentation/syncfusion_flutter_maps/latest/maps/MapBubbleSettings/strokeColor.html) property.
* **StrokeThickness** - Change the stroke width of the bubbles using the [`MapBubbleSettings.StrokeThickness`](https://pub.dev/documentation/syncfusion_flutter_maps/latest/maps/MapBubbleSettings/strokeWidth.html) property.
* **HoverFill** - Change the hover color of the bubbles using the [`MapBubbleSettings.HoverFill`](https://pub.dev/documentation/syncfusion_flutter_core/latest/theme/SfMapsThemeData/bubbleHoverColor.html) property.
* **HoverStroke** - Change the hover stroke color of the bubbles using the [`MapBubbleSettings.HoverStroke`](https://pub.dev/documentation/syncfusion_flutter_core/latest/theme/SfMapsThemeData/bubbleHoverStrokeColor.html) property.
* **HoverStrokeThickness** - Change the hover stroke thickness of the bubbles using the [`MapBubbleSettings.HoverStrokeThickness`](https://pub.dev/documentation/syncfusion_flutter_core/latest/theme/SfMapsThemeData/bubbleHoverStrokeWidth.html) property.

{% tabs %}

{% highlight xaml %}

     <map:SfMaps>
        <map:SfMaps.Layer>
            <map:MapShapeLayer 
                  ShapesSource="https://cdn.syncfusion.com/maps/map-data/world-map.json"  ShowBubbleTooltip="True"
                  DataSource="{Binding Data}" PrimaryValuePath="Continent" ShapeDataField="continent" ShowBubbles="True" >

              <map:MapShapeLayer.BubbleSettings>
                  <map:MapBubbleSettings ColorValuePath="Population" 
                      SizeValuePath="Population" 
                      Fill="LightGreen"
                      Stroke="Green"
                      StrokeThickness="2"
                      HoverFill="LightBlue"
                      HoverStroke="Blue"
                      HoverStrokeThickness="3"
                      MinSize="30"
                      MaxSize="80">
                  </map:MapBubbleSettings>
              </map:MapShapeLayer.BubbleSettings>

            </map:MapShapeLayer>
        </map:SfMaps.Layer>
    </map:SfMaps>

{% endhighlight %}

{% highlight c# %}

public MainPage()
    {
        InitializeComponent();
        ObservableCollection<Model> Data = new ObservableCollection<Model>();
        Data.Add(new Model("Asia", 51));
        Data.Add(new Model("Africa", 58));
        Data.Add(new Model("Europe", 48));
        Data.Add(new Model("North America", 41));
        Data.Add(new Model("South America", 14));
        Data.Add(new Model("Australia", 23));
        
        SfMaps maps = new SfMaps();
        MapShapeLayer layer = new MapShapeLayer();
        layer.ShapesSource = MapSource.FromUri(new Uri("https://cdn.syncfusion.com/maps/map-data/world-map.json"));
        layer.DataSource = Data;
        layer.PrimaryValuePath = "Continent";
        layer.ShapeDataField = "continent";
        layer.ShowBubbleTooltip = true;
        layer.ShowBubbles = true;

        MapBubbleSettings bubbleSetting = new MapBubbleSettings()
        {
            ColorValuePath = "Population",
            SizeValuePath = "Population",
            Fill = Colors.LightGreen,
            Stroke = Colors.Green,
            StrokeThickness = 2,
            HoverFill = Colors.LightBlue,
            HoverStroke = Colors.Blue,
            HoverStrokeThickness = 3,
            MinSize = 30,
            MaxSize =80
        };

        layer.BubbleSettings = bubbleSetting;
        maps.Layer = layer;
        this.Content = maps;
    }
   public class Model
    {
        public Model(string continent, int population)
        {
            Continent = continent;
            Population = population;
        }
        public String Continent { get; set; }
        public int Population { get; set; }
    }

{% endhighlight %}

{% endtabs %}

![Bubble customization](images/bubble/bubble-customization.png)

N> You can refer to our [MAUI Maps](https://www.syncfusion.com/flutter-widgets/flutter-maps) feature tour page for its groundbreaking feature representations. You can also explore our [MAUI Maps Bubble example](https://flutter.syncfusion.com/#/maps/shape-layer/bubble) that shows how to configure a Maps in MAUI.
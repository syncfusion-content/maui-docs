---
layout: post
title: Bubbles in Maps control | Syncfusion
description: Learn here all about the Bubbles feature of Syncfusion MAUI Maps (SfMaps) control to customize their appearances and more.
platform: MAUI
control: SfMaps
documentation: ug
---

# Bubbles in MAUI Maps (SfMaps)

Bubbles can be rendered in different colors and sizes based on the data values of their assigned shape. You can add information to shapes such as population density, number of users, and more. 

## Enable bubbles

You can enable bubbles using the [`ShowBubbles`](). You can customize a bubbles using the [`BubbleSettings`]().This property is used to specify the value based on which the bubble's size has to be rendered.

{% tabs %}

{% highlight xaml %}

     <map:SfMaps>
        <map:SfMaps.Layer>
            <map:MapShapeLayer 
                ShapesSource="https://cdn.syncfusion.com/maps/map-data/world-map.json"
                DataSource="{Binding Data}"
                PrimaryValuePath="State" 
                ShapeDataField="name" 
                ShowBubbles="True" >

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
        ViewModel viewModel = new ViewModel();
        this.BindingContext = viewModel;
        SfMaps maps = new SfMaps();
        MapShapeLayer layer = new MapShapeLayer();
        layer.ShapesSource = MapSource.FromUri(new Uri("https://cdn.syncfusion.com/maps/map-data/world-map.json"));
        layer.DataSource = viewModel.Data;
        layer.PrimaryValuePath = "State";
        layer.ShapeDataField = "name";
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
public class ViewModel
{
    public ObservableCollection<Model> Data { get; set; }
    public ViewModel()
    {
        Data = new ObservableCollection<Model>();
        Data.Add(new Model("India", 21));
        Data.Add(new Model("United States", 58));
        Data.Add(new Model("Kazakhstan", 41));
        Data.Add(new Model("Italy", 48));
        Data.Add(new Model("Korea", 14));
        Data.Add(new Model("China", 23));
    }
}
public class Model
{
    public Model(string state, int population)
    {
        State = state;
        Population = population;
    }
    public String State { get; set; }
    public int Population { get; set; }
}

{% endhighlight %}

{% endtabs %}

![Bubble support](images/bubble/default-bubble.png)

## Tooltip for the bubbles

You can enable tooltip for the bubbles using the [`MapShapeLayer.ShowBubbleTooltip`]() property. It can be used to indicate clearly the information about the currently interacted bubble.

{% tabs %}

{% highlight xaml %}

     <map:SfMaps>
        <map:SfMaps.Layer>
            <map:MapShapeLayer 
                ShapesSource="https://cdn.syncfusion.com/maps/map-data/world-map.json"
                DataSource="{Binding Data}"
                PrimaryValuePath="State" 
                ShapeDataField="name" 
                ShowBubbles="True"
                ShowBubbleTooltip="True" >

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
            Fill = Colors.DarkViolet,
            MinSize = 30,
            MaxSize =80
            
        };

        layer.BubbleSettings = bubbleSetting;
        maps.Layer = layer;
        this.Content = maps;
    }
public class ViewModel
{
    public ObservableCollection<Model> Data { get; set; }
    public ViewModel()
    {
        Data = new ObservableCollection<Model>();
        Data.Add(new Model("India", 21));
        Data.Add(new Model("United States", 58));
        Data.Add(new Model("Kazakhstan", 41));
        Data.Add(new Model("Italy", 48));
        Data.Add(new Model("Korea", 14));
        Data.Add(new Model("China", 23));
    }
}
public class Model
{
    public Model(string state, int population)
    {
        State = state;
        Population = population;
    }
    public String State { get; set; }
    public int Population { get; set; }
}

{% endhighlight %}

{% endtabs %}

![Bubble tooltip](images/bubble/bubble-tooltip.png)

## Color

You can customize the bubble color based on the value returned from the [`MapBubbleSettings.ColorMappings`]() property. 

If [`ColorMappings`]() returns a color, then the color will be applied to the bubble straightaway.

 The value returned from the [`ColorMappings`]() will be used for the comparison in the [`EqualColorMapping.Value`]() or [`RangeColorMapping.From`]() and [`RangeColorMapping.To`](). Then, the [`RangeColorMapping.Color`]() or [`EqualColorMapping.Color`]() will be applied to the respective bubble.

{% tabs %}

{% highlight xaml %}

     <map:SfMaps>
        <map:SfMaps.Layer>
            <map:MapShapeLayer 
                ShapesSource="https://cdn.syncfusion.com/maps/map-data/world-map.json"  
                ShowBubbleTooltip="True" 
                ShapeColorValuePath = "Population" 
                ShowDataLabels="True"
                DataSource="{Binding Data}" 
                PrimaryValuePath="Continent" 
                ShapeDataField="continent" ShowBubbles="True" >

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

* **MinSize** - Change the minimum radius of the bubbles using the [`MapBubbleSettings.MinSize`]() property. The default value of the [`MinSize`]() property is `20.0`.
* **MaxSize** - Change the maximum radius of the bubbles using the [`MapBubbleSettings.MaxSize`]() property. The default value of the [`MaxSize`]() property is `50.0`.
* **Fill** - Change the background color of the bubbles using the [`MapBubbleSettings.Fill`]() property.
* **Stroke** - Change the stroke color of the bubbles using the [`MapBubbleSettings.Stroke`]() property.
* **StrokeThickness** - Change the stroke width of the bubbles using the [`MapBubbleSettings.StrokeThickness`]() property.
* **HoverFill** - Change the hover color of the bubbles using the [`MapBubbleSettings.HoverFill`]() property.
* **HoverStroke** - Change the hover stroke color of the bubbles using the [`MapBubbleSettings.HoverStroke`]() property.
* **HoverStrokeThickness** - Change the hover stroke thickness of the bubbles using the [`MapBubbleSettings.HoverStrokeThickness`]() property.

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

N> You can refer to our [MAUI Maps]() feature tour page for its groundbreaking feature representations. You can also explore our [MAUI Maps Bubble example]() that shows how to configure a Maps in MAUI.
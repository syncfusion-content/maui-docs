---
layout: post
title: Getting started with .NET MAUI Maps control | Syncfusion
description: Learn here about getting started with Syncfusion .NET MAUI Maps (SfMaps) control, its elements, and more. 
platform: MAUI
control: SfMaps
documentation: ug
---

# Getting started with MAUI Maps (SfMaps)

This section explains the steps required to add the maps control with shape layer and its elements such as data labels, tooltip, markers, and legends. This section covers only basic features needed to know to get started with Syncfusion maps.

## Creating an application using the .NET MAUI Maps

* Create a new .NET MAUI application in the Visual Studio.

* Syncfusion .NET MAUI components are available on [nuget.org](https://www.nuget.org/). To add SfMaps to your project, open the NuGet package manager in Visual Studio, search for [Syncfusion.Maui.Maps] then install that.

### Register the handler

Syncfusion.Maui.Core NuGet is a dependent package for all Syncfusion controls of .NET MAUI. In the MauiProgram.cs file, register the handler for Syncfusion core.

{% highlight c# tabtitle="~/MauiProgram.cs" hl_lines="17" %}

using Microsoft.Maui;
using Microsoft.Maui.Hosting;
using Microsoft.Maui.Controls.Compatibility;
using Microsoft.Maui.Controls.Hosting;
using Microsoft.Maui.Controls.Xaml;
using Syncfusion.Maui.Core.Hosting;

namespace MyProject
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
            .UseMauiApp<App>()
            .ConfigureSyncfusionCore()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
            });

            return builder.Build();
        }
    }
}

{% endhighlight %}

## Adding namespace

Add the following namespace.

{% tabs %}

{% highlight xaml %}

xmlns:map="clr-namespace:Syncfusion.Maui.Maps;assembly=Syncfusion.Maui.Maps"

{% endhighlight %}

{% highlight c# %}

using Syncfusion.Maui.Maps;

{% endhighlight %}

{% endtabs %}

## Initializing maps

Create an instance for the maps control, and add it as content.

{% tabs %}

{% highlight xaml %}

<map:SfMaps>
  
</map:SfMaps>

{% endhighlight %}

{% highlight c# %}

SfMaps map = new SfMaps();
	
this.Content = map;

{% endhighlight %}

{% endtabs %}

## Set GeoJSON data or shapefile for shape layer from various source

The [`Layer`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.SfMaps.html#Syncfusion_Maui_Maps_SfMaps_Layer) in [`SfMaps`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.SfMaps.html) holds [`MapShapeLayer`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html). The actual geographical rendering is done in the each [`MapShapeLayer`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html). The [`ShapesSource`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_ShapesSource) property of the [`MapShapeLayer`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html) is of type [`MapSource`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapSource.html). The [`ShapesSource`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_ShapesSource) can be set as the .json source or shapefile.

I> The Mercator projection is the default projection in the maps.

The [`ShapesSource`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_ShapesSource) property is used to load an shapes from different sources:

* [`FromFile`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapSource.html#Syncfusion_Maui_Maps_MapSource_FromFile_System_String_) returns a MapSource that reads an shape source from a local file.
* [`FromUri`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapSource.html#Syncfusion_Maui_Maps_MapSource_FromUri_System_Uri_) returns an MapSource that downloads and reads an shape source from a specified URI.
* `FromResource` returns a MapSource that reads an shape source file embedded in an assembly.
* [`FromStream`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapSource.html#Syncfusion_Maui_Maps_MapSource_FromStream_System_IO_Stream_) returns a MapSource that reads an shape source from a stream that supplies source data.

### Loading a local file

SfMaps provides support to load the json data or shapefile from local path. 

{% tabs %}

{% highlight c# %}

public MainPage()
{
    InitializeComponent();
    SfMaps map = new SfMaps();
    MapShapeLayer layer = new MapShapeLayer();
    layer.ShapesSource = MapSource.FromFile(@"D:\MyProject\usa_state.shp");
    map.Layer = layer;
    this.Content = map;
}

{% endhighlight %}

{% endtabs %}

The [`MapSource.FromFile`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapSource.html#Syncfusion_Maui_Maps_MapSource_FromFile_System_String_) method requires a string argument, and returns a new [`MapSource`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapSource.html) object that reads the data from the shape source file. There's also an implicit conversion operator that enables the filename to be specified as a string argument to the [`ShapesSource`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_ShapesSource) property

{% tabs %}

{% highlight XAML %}

<map:SfMaps>
    <map:SfMaps.Layer>
        <map:MapShapeLayer ShapesSource="D:\MyProject\usa_state.shp" />
    </map:SfMaps.Layer>
</map:SfMaps>

{% endhighlight %}

{% highlight c# %}

public MainPage()
{
    InitializeComponent();
    SfMaps map = new SfMaps();
    MapShapeLayer layer = new MapShapeLayer();
    layer.ShapesSource = MapSource.FromFile(@"D:\MyProject\usa_state.shp");
    map.Layer = layer;
    this.Content = map;
}

{% endhighlight %}

{% endtabs %}

### Load a remote image

SfMaps provides support to load the json data or shapefile from the uri.

{% tabs %}

{% highlight c# %}

public MainPage()
{
    InitializeComponent();
    SfMaps map = new SfMaps();
    MapShapeLayer layer = new MapShapeLayer();
    layer.ShapesSource = MapSource.FromUri(new Uri("https://cdn.syncfusion.com/maps/map-data/world-map.json"));
    map.Layer = layer;
    this.Content = map;
}

{% endhighlight %}

{% endtabs %}

The [`MapSource.FromUri`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapSource.html#Syncfusion_Maui_Maps_MapSource_FromFile_System_String_) method requires a Uri argument, and returns a new [`MapSource`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapSource.html) object that reads the shape source from the Uri. There's also an implicit conversion for string-based URIs.

{% tabs %}

{% highlight XAML %}

<map:SfMaps>
    <map:SfMaps.Layer>
        <map:MapShapeLayer ShapesSource="https://cdn.syncfusion.com/maps/map-data/world-map.json" />
    </map:SfMaps.Layer>
</map:SfMaps>

{% endhighlight %}

{% highlight c# %}

public MainPage()
{
    InitializeComponent();
    SfMaps map = new SfMaps();
    MapShapeLayer layer = new MapShapeLayer();
    layer.ShapesSource = MapSource.FromUri(new Uri("https://cdn.syncfusion.com/maps/map-data/world-map.json"));
    map.Layer = layer;
    this.Content = map;
}

{% endhighlight %}

{% endtabs %}

### Load an embedded file

* Embedded sources are loaded based on their resource ID, which is compromised of the name of the project and its location in the project. 
* You can load both json data and shapefile.
* For example, placing `australia.json` in the root folder of a project named `MyProject` will result in a resource ID of `MyProject.australia.json.` Similarly, placing `world1.shp` in the Assets folder of a project named MyProject will result in a resource ID of `MyProject.Assets.world1.shp`
* Right-click the added shapefile, and navigate to properties.
* Choose the `EmbeddedResource` option under BuildAction of respective shapefile.

N> You can get the [`australia.json`](https://www.syncfusion.com/downloads/support/directtrac/general/ze/australia-json-910278184.zip) file here.

{% tabs %}

{% highlight c# %}

public MainPage()
{
    InitializeComponent();
    SfMaps map = new SfMaps();
    MapShapeLayer layer = new MapShapeLayer();
    layer.ShapesSource = MapSource.FromResource("MyProject.australia.json");
    map.Layer = layer;
    this.Content = map;
}

{% endhighlight %}

{% endtabs %}

### Loading from stream

SfMaps provides support to load the json data or shapefile as bytes from stream.

{% tabs %}

{% highlight C# %}

public MainPage()
{
    InitializeComponent();
    SfMaps map = new SfMaps();
    MapShapeLayer layer = new MapShapeLayer();
    Assembly assembly = Application.Current?.GetType().GetTypeInfo().Assembly;
    var jsonStream = assembly?.GetManifestResourceStream("MyProject.Assets.australia.json");
    layer.ShapesSource = MapSource.FromStream(jsonStream);
    map.Layer = layer;
    this.Content = map;
}

{% endhighlight %}

{% endtabs %}

![maps basic view](images/getting-started/map_basic_view.png)

## Mapping the data source for shape layer

The [`DataSource`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_DataSource) property accepts the collection values as input. The [`PrimaryValuePath`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_PrimaryValuePath) property refers the data ID in [`DataSource`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_DataSource).

The [`ShapeDataField`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_ShapeDataField) property is similar to the [`PrimaryValuePath`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_PrimaryValuePath) property. It refers to the column name in the data property of shape layers to identify the shape. When the values of the [`PrimaryValuePath`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_PrimaryValuePath) property in the [`DataSource`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_DataSource) property and the values of [`ShapeDataField`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_ShapeDataField) in the data property match, the associated object from the dataSource will be bound to the corresponding shape.

{% tabs %}

{% highlight XAML %}

<map:SfMaps>
    <map:SfMaps.Layer>
        <map:MapShapeLayer DataSource="{Binding Data}"        
                           PrimaryValuePath="State" 
                           ShapeDataField="STATE_NAME" />
    </map:SfMaps.Layer>
</map:SfMaps>

{% endhighlight %}

{% highlight c# %}

public MainPage()
{
    InitializeComponent();

    this.BindingContext = this;
    
    ObservableCollection<Model> Data = new ObservableCollection<Model>();
    Data.Add(new Model("New South Wales", "New\nSouth Wales"));
    Data.Add(new Model("Queensland", "Queensland"));
    Data.Add(new Model("Northern Territory", "Northern\nTerritory"));
    Data.Add(new Model("Victoria", "Victoria"));
    Data.Add(new Model("Western Australia", "Western Australia"));
    Data.Add(new Model("Tasmania", "Tasmania"));

    SfMaps maps = new SfMaps();
    MapShapeLayer layer = new MapShapeLayer();
    layer.ShapesSource = MapSource.FromResource("MyProject.australia.json");
    layer.PrimaryValuePath = "State";
    layer.DataSource = Data;
    layer.ShapeDataField = "STATE_NAME";
    maps.Layer = layer;
    this.Content = maps;
}

public class Model
{
    public String State { get; set; }
    public String StateCode { get; set; }

    public Model(string state, string stateCode)
    {
        State = state;
        StateCode = stateCode;
    }
}

{% endhighlight %}

{% endtabs %}

N>
* Refer the [`PrimaryValuePath`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_PrimaryValuePath), for mapping the data of the data source collection with the respective [`ShapeDataField`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_ShapeDataField) in .json source.
* Refer the [`BubbleSettings`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_BubbleSettings), for customizing the bubble.
* Refer the [`DataLabelSettings`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_DataLabelSettings), for customizing the data label.
* Refer the [`ColorMappings`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_ColorMappings), for customizing the shape colors.

## Add shape layer maps elements

Add the basic maps elements such as data labels, legend, and tooltip as shown in the below code snippet.

* **[Data labels](https://help.syncfusion.com/maui/maps/data-labels)** - You can show data labels using the [`ShowDataLabels`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_ShowDataLabels) property and also, customize it using the [`DataLabelSettings`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_DataLabelSettings) property.

* **[Legend](https://help.syncfusion.com/maui/maps/legend)** - You can enable legend using the [`Legend`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_Legend) property. The text of the legend is displayed based on the [`ColorMapping.Text`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.ColorMapping.html#Syncfusion_Maui_Maps_ColorMapping_Text) property. It is possible to customize the legend text using the [`TextStyle`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapLegend.html#Syncfusion_Maui_Maps_MapLegend_TextStyle) property.

* **[Tooltip](https://help.syncfusion.com/maui/maps/tooltip)** - You can enable tooltip for the shapes using the [`ShowShapeTooltip`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_ShowShapeTooltip) property. It will be displayed when you interacts with the shapes i.e., while tapping in touch devices and hover in the mouse enabled devices.

{% tabs %}

{% highlight xaml %}

<map:SfMaps>
    <map:SfMaps.Layer>
        <map:MapShapeLayer DataSource="{Binding Data}" 
                           PrimaryValuePath="State"
                           ShapeStrokeThickness="0"    
                           ShapeDataField="STATE_NAME"
                           ShowShapeTooltip="True"
                           ShapeColorValuePath="Population"
                           ShowDataLabels="True"
                           SelectedShapeStrokeThickness="0"
                           ShapeHoverFill="Transparent">

             <map:MapShapeLayer.ColorMappings>
                <map:EqualColorMapping Color ="#d0b800" Value = "6000" Text="New South Wales" />
                <map:EqualColorMapping Color = "#00d5cf" Value = "8000"  Text="Queensland" />
                <map:EqualColorMapping Color ="#cf4eee" Value = "5000" Text="Victoria" />
                <map:EqualColorMapping Color ="#4f93d8"  Value = "90000" Text="Tasmania" />
                <map:EqualColorMapping Color = "#8b6adf" Value = "7000" Text="Western Australia"  />
                <map:EqualColorMapping Color ="#7bff67"  Value = "3000" Text="South Australia" />
                <map:EqualColorMapping Color ="#ff4e42"  Value = "10000" Text="Northern Territory" />
             </map:MapShapeLayer.ColorMappings>

            <map:MapShapeLayer.Legend>
                <map:MapLegend SourceType="Shape" Placement="Right" />
            </map:MapShapeLayer.Legend>

            <map:MapShapeLayer.DataLabelSettings>
                <map:MapDataLabelSettings DataLabelPath="StateCode">
                        <map:MapDataLabelSettings.DataLabelStyle>
                                <map:MapLabelStyle FontSize="14"
                                                   TextColor="Black"
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
    layer.ShapesSource = MapSource.FromResource("MyProject.australia.json");
    layer.DataSource = viewModel.Data;
    layer.PrimaryValuePath = "State";
    layer.ShapeDataField = "STATE_NAME";
    layer.ShowShapeTooltip = true;
    layer.ShapeColorValuePath = "Population";
    layer.ShowDataLabels = true;
    layer.ShapeStrokeThickness = 0;
    layer.ShapeHoverFill = Colors.Transparent;

    layer.DataLabelSettings = new MapDataLabelSettings()
    {
        DataLabelPath = "StateCode",
        DataLabelStyle = new MapLabelStyle()
        {
            FontSize = 14,
            FontAttributes = FontAttributes.Italic,
            TextColor = Colors.Black
        },

        OverflowMode = MapLabelOverflowMode.None,
    };

    layer.ColorMappings = new ObservableCollection<ColorMapping>()
    {
        new EqualColorMapping { Color = Color.FromRgb(208,183,0), Value = "6000",Text="New South Wales" },
        new EqualColorMapping { Color = Color.FromRgb(0,213,207), Value = "8000" , Text="Queensland" },
        new EqualColorMapping { Color = Color.FromRgb(207,78,238), Value = "5000", Text="Victoria" },
        new EqualColorMapping { Color = Color.FromRgb(79,147,216), Value = "90000", Text="Tasmania" },
        new EqualColorMapping { Color = Color.FromRgb(139,106,223), Value = "7000", Text="Western Australia" },
        new EqualColorMapping { Color = Color.FromRgb(123,255,103), Value = "3000", Text="South Australia" },
        new EqualColorMapping { Color = Color.FromRgb(255,78,66), Value = "10000",Text="Northern Territory" },
    };

    MapLegend legendSet = new MapLegend();
    legendSet.SourceType = LegendSourceType.Shape;
    legendSet.Placement = Syncfusion.Maui.Core.LegendPlacement.Right;
    layer.Legend = legendSet;

    maps.Layer = layer;
    this.Content = maps;
}

public class Model
{
    public string State { get; set; }
    public string StateCode { get; set; }
    public int Population { get; set; }
	
    public Model(string state, string stateCode,int population)
    {
        State = state;
        StateCode = stateCode;
        Population = population;
    }
}

public class ViewModel
{
    public ObservableCollection<Model> Data {get; set;}
	
    public ViewModel()
    {
        Data = new ObservableCollection<Model>();
		Data.Add(new Model("New South Wales", "New\nSouth Wales",6000));
		Data.Add(new Model("Queensland", "Queensland",8000));
		Data.Add(new Model("Northern Territory", "Northern\nTerritory",10000));
		Data.Add(new Model("Victoria", "Victoria",5000));
		Data.Add(new Model("Tasmania", "Tasmania",90000));
		Data.Add(new Model("Western Australia", "Western Australia", 7000));
		Data.Add(new Model("South Australia", "South Australia", 3000));
    }
}

{% endhighlight %}

{% endtabs %}

![Maps getting started](images/getting-started/maps_getting_started.png)

N> You can refer to our [.NET MAUI Maps](https://www.syncfusion.com/maui-controls/maui-maps) feature tour page for its groundbreaking feature representations. You can also explore our [.NET MAUI Maps example](https://github.com/syncfusion/maui-demos/) that shows how to configure a Maps in .NET MAUI.
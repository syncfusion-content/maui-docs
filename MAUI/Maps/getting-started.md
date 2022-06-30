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

The `Layer` in `SfMaps` holds `MapShapeLayer`. The actual geographical rendering is done in the each `MapShapeLayer`. The `ShapesSource` property of the `MapShapeLayer` is of type `MapShapeSource`. The `ShapesSource` can be set as the .json source or shapefile.

I> The Mercator projection is the default projection in the maps.

The `ShapesSource` property is used to load an shapes from different sources:

`FromFile` returns a MapSource that reads an shape source from a local file.
`FromUri` returns an MapSource that downloads and reads an shape source from a specified URI.
`FromResource` returns a MapSource that reads an shape source file embedded in an assembly.
`FromStream` returns a MapSource that reads an shape source from a stream that supplies source data.

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

The MapSource.FromFile method requires a string argument, and returns a new MapShapeSource object that reads the data from the shape source file. There's also an implicit conversion operator that enables the filename to be specified as a string argument to the `ShapeSource` property

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

The MapSource.FromUri method requires a Uri argument, and returns a new `MapShapeSource` object that reads the shape source from the Uri. There's also an implicit conversion for string-based URIs.

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

The `DataSource` property accepts the collection values as input. The `PrimaryValuePath` property refers the data ID in `DataSource`.

The `ShapeDataField` property is similar to the `PrimaryValuePath` property. It refers to the column name in the data property of shape layers to identify the shape. When the values of the `PrimaryValuePath` property in the `DataSource` property and the values of `ShapeDataField` in the data property match, the associated object from the dataSource will be bound to the corresponding shape.

{% tabs %}

{% highlight c# %}

public MainPage()
{
    InitializeComponent();
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
* Refer the `PrimaryValuePath`, for mapping the data of the data source collection with the respective `ShapeDataField` in .json source.
* Refer the `BubbleSettings`, for customizing the bubble.
* Refer the `DataLabelSettings`, for customizing the data label.
* Refer the `ColorMappings`, for customizing the shape colors.

## Add shape layer maps elements

Add the basic maps elements such as data labels, legend, and tooltip as shown in the below code snippet.

* **Data labels** - You can show data labels using the `ShowDataLabels` property and also, customize it using the `DataLabelSettings` property.

* **Legend** - You can enable legend using the `Legend` property. The text of the legend is displayed based on the `ColorMapping.Text` property. It is possible to customize the legend text using the `TextStyle` property.

* **Tooltip** - You can enable tooltip for the shapes using the `ShowShapeTooltip` property. It will be displayed when you interacts with the shapes i.e., while tapping in touch devices and hover in the mouse enabled devices.

{% tabs %}

{% highlight C# %}

public MainPage()
{
    InitializeComponent();
	ViewModel viewModel = new ViewModel();
    SfMaps maps = new SfMaps();
    MapShapeLayer layer = new MapShapeLayer();
    layer.ShapesSource = MapSource.FromResource("MyProject.australia.json");
    layer.DataSource = viewModel.Data;
    layer.PrimaryValuePath = "State";
    layer.ShapeDataField = "STATE_NAME";
    layer.ShowShapeTooltip = true;
    layer.ShapeColorValuePath = "Population";
    layer.ShowDataLabels = true;

    layer.DataLabelSettings = new MapDataLabelSettings()
    {
        DataLabelPath = "StateCode",
        DataLabelStyle = new MapLabelStyle()
        {
            FontSize = 14,
            FontAttributes = FontAttributes.Bold,
            TextColor = Colors.Black
        },

        OverflowMode = MapLabelOverflowMode.None,
    };

    layer.ColorMappings = new ObservableCollection<ColorMapping>()
    {
        new EqualColorMapping { Color = Colors.Yellow, Value = "6000" },
        new EqualColorMapping { Color = Colors.LimeGreen, Value = "8000" },
        new EqualColorMapping { Color = Colors.Violet, Value = "5000" },
        new EqualColorMapping { Color = Colors.Blue, Value = "90000" },
        new EqualColorMapping { Color = Colors.Red, Value = "7000" },
        new EqualColorMapping { Color = Colors.Orange, Value = "3000" },
    };
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

N> You can refer to our `.NET MAUI Maps` feature tour page for its groundbreaking feature representations. You can also explore our `.NET MAUI Maps example`that shows how to configure a Maps in .NET MAUI.
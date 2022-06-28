---
layout: post
title: Data Labels in MAUI Maps control | Syncfusion
description: Learn here all about the Data Labels feature of Syncfusion MAUI Maps (SfMaps) control to add labels to the shapes and more.
platform: MAUI
control: SfMaps
documentation: ug
---

# Data Labels in MAUI Maps (SfMaps)

Data labels provides identification for the shapes by displaying their names. You can trim or hide the labels if they exceed the shape bounds.

## Show data labels

You can show data labels on the map using the [`ShowDataLabels`]() property. The default value is `false`.

{% tabs %}

{% highlight xaml %}

     <map:SfMaps>
        <map:SfMaps.Layer>
            <map:MapShapeLayer ShapesSource="https://cdn.syncfusion.com/maps/map-data/australia.json" 
							   DataSource="{Binding Data}"        
							   PrimaryValuePath="State" 
							   ShapeDataField="STATE_NAME" 
							   ShowDataLabels="True">

                <map:MapShapeLayer.DataLabelSettings>
                    <map:MapDataLabelSettings DataLabelPath="State" />
                </map:MapShapeLayer.DataLabelSettings>
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
	
    MapShapeLayer layer = new MapShapeLayer();
    layer.ShapesSource = MapSource.FromUri(new Uri("https://cdn.syncfusion.com/maps/map-data/australia.json"));
    layer.DataSource = viewModel.Data;
    layer.PrimaryValuePath = "State";
    layer.ShapeDataField = "STATE_NAME";
    layer.ShowDataLabels = true;

    layer.DataLabelSettings = new MapDataLabelSettings()
    {
       DataLabelPath = "State",
    };
	
    SfMaps maps = new SfMaps();
    maps.Layer = layer;
    this.Content = maps;
}

public class ViewModel
{
    public ObservableCollection<Model> Data { get; set; }
    
	public ViewModel()
    {
       Data = new ObservableCollection<Model>();
       Data.Add(new Model("New South Wales", "New\nSouth Wales"));
       Data.Add(new Model("Queensland", "Queensland"));
       Data.Add(new Model("Northern Territory", "Northern\nTerritory"));
       Data.Add(new Model("Victoria", "Victoria"));
       Data.Add(new Model("Tasmania", "Tasmania"));
       Data.Add(new Model("Western Australia", "Western Australia"));
       Data.Add(new Model("South Australia", "South Australia"));
    }
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

![Data labels support](images/data-labels/default-data-labels.png)

## Text customization

You can customize text of the data labels using the [`DataLabelPath`]() property.

{% tabs %}

{% highlight xaml %}

     <map:SfMaps>
        <map:SfMaps.Layer>
            <map:MapShapeLayer ShapesSource="https://cdn.syncfusion.com/maps/map-data/australia.json" 
							   DataSource="{Binding Data}"        
							   PrimaryValuePath="State" 
							   ShapeDataField="STATE_NAME" 
							   ShowDataLabels="True" >

                <map:MapShapeLayer.DataLabelSettings>
                    <map:MapDataLabelSettings DataLabelPath="StateCode" />
                </map:MapShapeLayer.DataLabelSettings>
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
	
    MapShapeLayer layer = new MapShapeLayer();
    layer.ShapesSource = MapSource.FromUri(new Uri("https://cdn.syncfusion.com/maps/map-data/australia.json"));
    layer.DataSource = viewModel.Data;
    layer.PrimaryValuePath = "State";
    layer.ShapeDataField = "STATE_NAME";
    layer.ShowDataLabels = true;

    layer.DataLabelSettings = new MapDataLabelSettings()
    {
       DataLabelPath = "StateCode",
    };
	
    SfMaps maps = new SfMaps();
    maps.Layer = layer;
    this.Content = maps;
}

public class ViewModel
{
    public ObservableCollection<Model> Data { get; set; }
	
    public ViewModel()
    {
       Data = new ObservableCollection<Model>();
       Data.Add(new Model("New South Wales", "New\nSouth Wales"));
       Data.Add(new Model("Queensland", "Queensland"));
       Data.Add(new Model("Northern Territory", "NT"));
       Data.Add(new Model("Victoria", "Victoria"));
       Data.Add(new Model("Tasmania", "Tasmania"));
       Data.Add(new Model("Western Australia", "WA"));
       Data.Add(new Model("South Australia", "SA"));
    }
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

![Data labels support](images/data-labels/data-labels-customization.png)

## Overflow mode

You can trim or remove the data label when it is overflowed from the shape using the [`OverflowMode`]() property. The possible values are `None`, `Trim`, and `Hide`. The default value of the [`OverflowMode`]() property is `MapLabelOverflowMode.None`.

By default, the data labels will render even if it overflows from the shape. 

{% tabs %}

{% highlight xaml %}

     <map:SfMaps>
        <map:SfMaps.Layer>
            <map:MapShapeLayer ShapesSource="https://cdn.syncfusion.com/maps/map-data/australia.json" 
							   DataSource="{Binding Data}"        
							   PrimaryValuePath="State" 
							   ShapeDataField="STATE_NAME" 
							   ShowDataLabels="True">

                <map:MapShapeLayer.DataLabelSettings>
                    <map:MapDataLabelSettings OverflowMode="Trim"
											  DataLabelPath="State" />
                </map:MapShapeLayer.DataLabelSettings>
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
	
    MapShapeLayer layer = new MapShapeLayer();
    layer.ShapesSource = MapSource.FromUri(new Uri("https://cdn.syncfusion.com/maps/map-data/australia.json"));
    layer.DataSource = viewModel.Data;
    layer.PrimaryValuePath = "State";
    layer.ShapeDataField = "STATE_NAME";
    layer.ShowDataLabels = true;

    layer.DataLabelSettings = new MapDataLabelSettings()
    {
       DataLabelPath = "State",
       OverflowMode = MapLabelOverflowMode.Trim,
    };
	
    SfMaps maps = new SfMaps();
    maps.Layer = layer;
    this.Content = maps;
}

public class ViewModel
{
    public ObservableCollection<Model> Data { get; set; }
	
    public ViewModel()
    {
       Data = new ObservableCollection<Model>();
       Data.Add(new Model("New South Wales", "New\nSouth Wales"));
       Data.Add(new Model("Queensland", "Queensland"));
       Data.Add(new Model("Northern Territory", "Northern\nTerritory"));
       Data.Add(new Model("Victoria", "Victoria"));
       Data.Add(new Model("Tasmania", "Tasmania"));
       Data.Add(new Model("Western Australia", "Western Australia"));
       Data.Add(new Model("South Australia", "South Australia"));
    }
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

![Data labels trim support](images/data-labels/data-labels-overflow-mode.png)

## Appearance customization

You can customize the data labels using the [`DataLabelStyle`]() property.

{% tabs %}

{% highlight xaml %}

     <map:SfMaps>
        <map:SfMaps.Layer>
            <map:MapShapeLayer ShapesSource="https://cdn.syncfusion.com/maps/map-data/australia.json"  
							   DataSource="{Binding Data}" 
							   PrimaryValuePath="State" 
							   ShapeDataField="STATE_NAME" 
							   ShowDataLabels="True">

                <map:MapShapeLayer.DataLabelSettings>
                    <map:MapDataLabelSettings OverflowMode="Trim"
											  DataLabelPath="ContinentCode">
                          <map:MapDataLabelSettings.DataLabelStyle>
                                    <map:MapLabelStyle FontSize="12"
                                                       TextColor="Red"
                                                       FontAttributes="Bold" />
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
    ViewModel viewModel = new ViewModel();
    this.BindingContext = viewModel;
	
    MapShapeLayer layer = new MapShapeLayer();
    layer.ShapesSource = MapSource.FromUri(new Uri("https://cdn.syncfusion.com/maps/map-data/australia.json"));
    layer.DataSource = viewModel.Data;
    layer.PrimaryValuePath = "State";
    layer.ShapeDataField = "STATE_NAME";
    layer.ShowDataLabels = true;

    layer.DataLabelSettings = new MapDataLabelSettings()
    {
       DataLabelPath = "State",
       OverflowMode = MapLabelOverflowMode.Trim,
       DataLabelStyle = new MapLabelStyle()
       {
           FontSize = 12,
           FontAttributes = FontAttributes.Bold,
           TextColor = Colors.Red
       },
    };
	
    SfMaps maps = new SfMaps();
    maps.Layer = layer;
    this.Content = maps;
}

public class ViewModel
{
    public ObservableCollection<Model> Data { get; set; }
	
    public ViewModel()
    {
       Data = new ObservableCollection<Model>();
       Data.Add(new Model("New South Wales", "New\nSouth Wales"));
       Data.Add(new Model("Queensland", "Queensland"));
       Data.Add(new Model("Northern Territory", "Northern\nTerritory"));
       Data.Add(new Model("Victoria", "Victoria"));
       Data.Add(new Model("Tasmania", "Tasmania"));
       Data.Add(new Model("Western Australia", "Western Australia"));
       Data.Add(new Model("South Australia", "South Australia"));
    }
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

![Data labels customization](images/data-labels/data-labels-appearance-customization.png)
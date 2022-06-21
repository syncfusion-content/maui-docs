---
layout: post
title: Getting Started with .NET MAUI DataGrid control | Syncfusion
description: Learn here about getting started with Syncfusion .NET MAUI DataGrid (SfDataGrid) control, its elements and more.
platform: MAUI
control: SfDataGrid
documentation: ug
---

# Getting Started with .NET Maui DataGrid (SfDataGrid)

This section provides a quick overview for working with the SfDataGrid for .NET MAUI. Walk through the entire process of creating a real world of this control.

## Creating an application using the .NET MAUI DataGrid
 1. Create a new .NET MAUI application in Visual Studio.
 2. Syncfusion .NET MAUI components are available on [nuget.org](https://www.nuget.org/). To add SfDataGrid to your project, open the NuGet package manager in Visual Studio, search for Syncfusion.Maui.DataGrid and then install it.
 3. Import the control namespace `Syncfusion.Maui.DataGrid` in XAML or C# code.
 4. Initialize the `SfDataGrid` control.

 {% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

<ContentPage   
    . . .
    xmlns:syncfusion="clr-namespace:Syncfusion.Maui.DataGrid;assembly=Syncfusion.Maui.DataGrid">

    <syncfusion:SfDataGrid />
</ContentPage>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

using Syncfusion.Maui.DataGrid;
. . .

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        SfDataGrid dataGrid = new SfDataGrid();
        this.Content = dataGrid;
    }
}

{% endhighlight %}
{% endtabs %}

## Register the handler

To use this control inside an application, you must initialize the `SfDataGrid` handler.

{% tabs %}
{% highlight c# tabtitle="MauiProgram.cs" hl_lines="4 5 22 23" %}

using Microsoft.Maui.Controls.Hosting;
using Microsoft.Maui.Controls.Xaml;
using Microsoft.Maui.Hosting;
using Syncfusion.Maui.Core.Hosting;
using Syncfusion.Maui.DataGrid.Hosting;

namespace GettingStarted
{
    public class MauiProgram 
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                });

           builder.ConfigureSyncfusionCore();
           builder.ConfigureSyncfusionDataGrid();
           return builder.Build();
        }
    }
}
{% endhighlight %} 
{% endtabs %}


## Create DataModel for the SfDataGrid

The SfDataGrid is a data-bound control. Hence, a data model should be created to bind it to the control. 

Create a simple data source as shown in the following code example in a new class file. Save it as OrderInfo.cs file:

{% highlight c# %}
public class OrderInfo
{
    private string orderID;
    private string customerID;
    private string customer;
    private string shipCity;
    private string shipCountry;

    public string OrderID {
        get { return orderID; }
        set { this.orderID = value; }
    }

    public string CustomerID {
        get { return customerID; }
        set { this.customerID = value; }
    }

    public string ShipCountry {
        get { return shipCountry; }
        set { this.shipCountry = value; }
    }

    public string Customer {
        get { return this.customer; }
        set { this.customer = value; }
    }

    public string ShipCity {
        get { return shipCity; }
        set { this.shipCity = value; }
    }

    public OrderInfo (string orderId, string customerId, string country, string customer, string shipCity)
    {
        this.OrderID = orderId;
        this.CustomerID = customerId;
        this.Customer = customer;
        this.ShipCountry = country;
        this.ShipCity = shipCity;
    }
} 
{% endhighlight %}

N> If you want your data model to respond to property changes, implement `INotifyPropertyChanged` interface in your model class.

Create a model repository class with OrderInfo collection property initialized with required number of data objects in a new class file as shown in the following code example and save it as OrderInfoRepository.cs file:

{% highlight c# %}
public class OrderInfoRepository
{
    private ObservableCollection<OrderInfo> orderInfo;
    public ObservableCollection<OrderInfo> OrderInfoCollection {
        get { return orderInfo; }
        set { this.orderInfo = value; }
    }

    public OrderInfoRepository ()
    {
        orderInfo = new ObservableCollection<OrderInfo> ();
        this.GenerateOrders ();
    }

    private void GenerateOrders ()
    {
        orderInfo.Add (new OrderInfo ("1001", "Maria Anders", "Germany", "ALFKI", "Berlin"));
        orderInfo.Add (new OrderInfo ("1002", "Ana Trujillo", "Mexico", "ANATR", "Mexico D.F."));
        orderInfo.Add (new OrderInfo ("1003", "Ant Fuller", "Mexico", "ANTON", "Mexico D.F."));
        orderInfo.Add (new OrderInfo ("1004", "Thomas Hardy", "UK", "AROUT", "London"));
        orderInfo.Add (new OrderInfo ("1005", "Tim Adams", "Sweden", "BERGS", "London"));
        orderInfo.Add (new OrderInfo ("1006", "Hanna Moos", "Germany", "BLAUS", "Mannheim"));
        orderInfo.Add (new OrderInfo ("1007", "Andrew Fuller", "France", "BLONP", "Strasbourg"));
        orderInfo.Add (new OrderInfo ("1008", "Martin King", "Spain", "BOLID", "Madrid"));
        orderInfo.Add (new OrderInfo ("1009", "Lenny Lin", "France", "BONAP", "Marsiella"));
        orderInfo.Add (new OrderInfo ("1010", "John Carter", "Canada", "BOTTM", "Lenny Lin"));
        orderInfo.Add (new OrderInfo ("1011", "Laura King", "UK", "AROUT", "London"));
        orderInfo.Add (new OrderInfo ("1012", "Anne Wilson", "Germany", "BLAUS", "Mannheim"));
        orderInfo.Add (new OrderInfo ("1013", "Martin King", "France", "BLONP", "Strasbourg"));
        orderInfo.Add (new OrderInfo ("1014", "Gina Irene", "UK", "AROUT", "London"));
    }
}
{% endhighlight %}

## Binding data to the SfDataGrid

To bind the data source to the SfDataGrid, set the `SfDataGrid.ItemsSource` property as follows. You can bind the data source of the SfDataGrid either from XAML or in code. 

The following code example binds the collection created in previous step to `SfDataGrid.ItemsSource` property.

{% tabs %}
{% highlight xaml %}
<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:local="clr-namespace:GettingStarted;assembly=GettingStarted"
             xmlns:syncfusion="clr-namespace:Syncfusion.Maui.DataGrid;assembly=Syncfusion.Maui.DataGrid">     

    <ContentPage.BindingContext>
        <local:OrderInfoRepository x:Name="viewModel" />
    </ContentPage.BindingContext>

    <ContentPage.Content>
        <syncfusion:SfDataGrid x:Name="dataGrid"
                               ItemsSource="{Binding OrderInfoCollection}">
        </syncfusion:SfDataGrid>
    </ContentPage.Content>
</ContentPage> 
{% endhighlight %}
{% highlight c# %}
OrderInfoRepository viewModel = new OrderInfoRepository ();
dataGrid.ItemsSource = viewModel.OrderInfoCollection; 
{% endhighlight %}
{% endtabs %}

Run the application to render the following output.

![.Net MAUI DataGrid](Images\getting-started\basic-datagrid.jpg)

## Defining columns

By default, the SfDataGrid automatically creates columns for all the properties in the data source. The type of the column generated depends on the type of data in the column. When the columns are auto-generated, handle the `SfDataGrid.AutoGeneratingColumnMode` mode to customize or cancel the columns before they are added to the columns collection in the SfDataGrid.
 
The columns can be manually defined by setting the`SfDataGrid.AutoGenerateColumnsMode` property to None and by adding the `GridColumn` objects to the `SfDataGrid.Columns` collection. It can be done from both XAML and code. The following code example illustrates this:

{% tabs %}
{% highlight xaml %}
<syncfusion:SfDataGrid x:Name="dataGrid"
            ColumnSizer="Star"
            AutoGenerateColumnsMode="None"
            ItemsSource="{Binding OrderInfoCollection}">

    <syncfusion:SfDataGrid.Columns >
        <syncfusion:DataGridTextColumn HeaderText="ID" 
                                   MappingName="OrderID" />
        <syncfusion:DataGridTextColumn HeaderText="Customer "
                                   MappingName="CustomerID" />
        <syncfusion:DataGridTextColumn MappingName="Customer" />
        <syncfusion:DataGridTextColumn HeaderText="Country"
                                   MappingName="ShipCountry" />
    </syncfusion:SfDataGrid.Columns>
</syncfusion:SfDataGrid>
{% endhighlight %}
{% highlight c# %}
dataGrid.AutoGenerateColumnsMode = AutoGenerateColumnsMode.None;

DataGridTextColumn orderIdColumn = new DataGridTextColumn ();
orderIdColumn.MappingName = "OrderID";
orderIdColumn.HeaderText = "Order ID";

DataGridTextColumn customerIdColumn = new DataGridTextColumn ();
customerIdColumn.MappingName = "CustomerID";
customerIdColumn.HeaderText = "Customer ID";

DataGridTextColumn customerColumn = new DataGridTextColumn ();
customerColumn.MappingName = "Customer";
customerColumn.HeaderText = "Customer";

DataGridTextColumn countryColumn = new DataGridTextColumn();
countryColumn.MappingName = "ShipCountry";
countryColumn.HeaderText = "Ship Country";

dataGrid.Columns.Add (orderIdColumn);
dataGrid.Columns.Add (customerIdColumn);
dataGrid.Columns.Add (customerColumn);
dataGrid.Columns.Add (countryColumn); 
{% endhighlight %}
{% endtabs %}

## Sorting

The SfDataGrid allows sorting on its data by setting the `SfDataGrid.AllowSorting` property to true.
 
{% tabs %}
{% highlight xaml %}
<syncfusion:SfDataGrid AllowSorting="True" />
{% endhighlight %}
{% highlight c# %}
dataGrid.AllowSorting = true; 
{% endhighlight %}
{% endtabs %}

Run the application and touch the header cell to sort the data and the following output will be displayed.
 


Sorting can also be configured by adding the column to the `SfDataGrid.SortColumnDescriptions` collection as follows.

{% tabs %}
{% highlight xaml %}
<syncfusion:SfDataGrid.SortColumnDescriptions>
    <syncfusion:SortColumnDescription ColumnName="CustomerID" />
</syncfusion:SfDataGrid.SortColumnDescriptions> 
{% endhighlight %}
{% highlight c# %}
dataGrid.SortColumnDescriptions.Add (new SortColumnDescription () { ColumnName = "CustomerID" });
{% endhighlight %}
{% endtabs %}

## Selection

The SfDataGrid allows selecting the row or rows by setting the `SfDataGrid.SelectionMode` property. You can set the `SfDataGrid.SelectionMode` property to single, multiple, single deselect, or none. Information about the row or rows selected can be tracked using the `SfDataGrid.SelectedRow` and `SfDataGrid.SelectedRows` properties.

The selection operations can be handled with the help of the `SelectionChanging` and `SelectionChanged` events of the SfDataGrid.

## Loading the SfDataGrid with customized height and width

The SfDataGrid can be load with specific height and width inside different layouts using the `SfDataGrid.HeightRequest` and `SfDataGrid.WidthRequest` properties. 

The following code example illustrates how this can be done.

{% tabs %}
{% highlight xaml %}
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:local="clr-namespace:GettingStarted;assembly=GettingStarted"
             xmlns:syncfusion="clr-namespace:Syncfusion.Maui.DataGrid;assembly=Syncfusion.Maui.DataGrid" >

     <ContentPage.BindingContext>
        <local:OrderInfoRepository x:Name="viewModel" />
    </ContentPage.BindingContext>
    
        <sfgrid:SfDataGrid x:Name="dataGrid"
                           ItemsSource="{Binding OrderInfoCollection}"
                           HeightRequest="290"
                           WidthRequest="200"
                           VerticalOptions="CenterAndExpand"
                           HorizontalOptions="Center"/>
    
</ContentPage>
{% endhighlight %}
{% highlight c# %}
public MainPage()
{
    InitializeComponent();
    OrderInfoRepository = new OrderInfoRepository();
    dataGrid = new SfDataGrid();
    dataGrid.ItemsSource = viewModel.OrdersInfo;
    dataGrid.HeightRequest = 290;
    dataGrid.WidthRequest = 200;
    dataGrid.VerticalOptions = LayoutOptions.CenterAndExpand;
    dataGrid.HorizontalOptions = LayoutOptions.Center;
    this.Content = dataGrid;
}
{% endhighlight %}
{% endtabs %}

The following screenshot shows how the SfDataGrid is loaded with specific height and width with VerticalOptions and HorizontalOptions.

N> Set `HorizontalOptions` and `VerticalOptions` to grid accordingly. When the `SfDataGrid` doesn't obtain finite size from its parent to layout in the View, the predefined `MinimumHeightRequest` and `MinimumWidthRequest`, which is 300, will be acquired.
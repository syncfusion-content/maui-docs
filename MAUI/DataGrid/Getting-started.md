---
layout: post
title: Getting Started with .NET MAUI DataGrid control | Syncfusion
description: Learn about getting started with Syncfusion .NET MAUI DataGrid (SfDataGrid) control, its elements, and more here.
platform: MAUI
control: SfDataGrid
documentation: ug
keywords : maui datagrid, maui grid, grid maui, maui gridview, grid in maui, .net maui datagrid, .net maui grid, .net grid maui
---

# Getting Started with .NET MAUI DataGrid

This section provides a quick overview for working with the [SfDataGrid](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html) for .NET MAUI.  Follow the steps below to add a basic DataGrid to your project.

To quickly get started with the .NET MAUI DataGrid, watch this video:

<style>#MAUIDataGridVideoTutorial{width : 90% !important; height: 400px !important }</style> <iframe id='MAUIDataGridVideoTutorial' src='https://www.youtube.com/embed/xW0a7JlHbz4'></iframe>

{% tabcontents %}
{% tabcontent Visual Studio %}

## Prerequisites
Before proceeding, ensure the following are set up:

1. Install [.NET 9 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/9.0) or later.
2. Set up a .NET MAUI environment with Visual Studio 2026 (v18.0.0 or later).

## Step 1: Create a new .NET MAUI Project

1. Go to **File > New > Project** and choose the **.NET MAUI App** template.
2. Name the project and choose a location. Then, click **Next.**
3. Select the .NET framework version and click **Create.**

## Step 2: Install the Syncfusion<sup>®</sup> MAUI DataGrid NuGet Package

1.  In **Solution Explorer**, right-click the project and choose **Manage NuGet Packages**.
2.  Search for [Syncfusion.Maui.DataGrid](https://www.nuget.org/packages/Syncfusion.Maui.DataGrid/) and install the latest version.
3.  Ensure the necessary dependencies are installed correctly, and the project is restored.

## Step 3: Register the handler

[Syncfusion.Maui.Core](https://www.nuget.org/packages/Syncfusion.Maui.Core/) NuGet is a dependent package for all Syncfusion<sup>®</sup> controls of .NET MAUI. In the MauiProgram.cs file, register the handler for Syncfusion<sup>®</sup> core.

{% highlight c# hl_lines="6 22" %}
using Microsoft.Maui;
using Microsoft.Maui.Hosting;
using Microsoft.Maui.Controls.Compatibility;
using Microsoft.Maui.Controls.Hosting;
using Microsoft.Maui.Controls.Xaml;
using Syncfusion.Maui.Core.Hosting;

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
            return builder.Build();
        }
    }
}
{% endhighlight %} 

## Step 4: Add a Basic DataGrid

1. Import the control namespace `Syncfusion.Maui.DataGrid` in XAML or C# code.
2. Initialize the [SfDataGrid](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html) control.

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
{% endtabcontent %}

{% tabcontent Visual Studio Code %}

## Prerequisites
Before proceeding, ensure the following are set up:

1. Install [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0) or later is installed.
2. Set up a .NET MAUI environment with Visual Studio Code.
3. Ensure that the .NET MAUI extension is installed and configured as described [here.](https://learn.microsoft.com/en-us/dotnet/maui/get-started/installation?view=net-maui-8.0&tabs=visual-studio-code)

## Step 1: Create a new .NET MAUI Project

1. Open the command palette by pressing `Ctrl+Shift+P` and type **.NET:New Project** and enter.
2. Choose the **.NET MAUI App** template.
3. Select the project location, type the project name and press **Enter.**
4. Then choose **Create project.**

## Step 2: Install the Syncfusion<sup>®</sup> MAUI DataGrid NuGet Package

1. Press <kbd>Ctrl</kbd> + <kbd>`</kbd> (backtick) to open the integrated terminal in Visual Studio Code.
2. Ensure you're in the project root directory where your .csproj file is located.
3. Run the command `dotnet add package Syncfusion.Maui.DataGrid` to install the Syncfusion<sup>®</sup> .NET MAUI DataGrid package.
4. To ensure all dependencies are installed, run `dotnet restore`.

## Step 3: Register the handler

[Syncfusion.Maui.Core](https://www.nuget.org/packages/Syncfusion.Maui.Core/) NuGet is a dependent package for all Syncfusion<sup>®</sup> controls of .NET MAUI. In the MauiProgram.cs file, register the handler for Syncfusion<sup>®</sup> core.

{% highlight c# hl_lines="6 17" %}
using Microsoft.Maui;
using Microsoft.Maui.Hosting;
using Microsoft.Maui.Controls.Compatibility;
using Microsoft.Maui.Controls.Hosting;
using Microsoft.Maui.Controls.Xaml;
using Syncfusion.Maui.Core.Hosting;

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
            return builder.Build();
        }
    }
}
{% endhighlight %} 
 
## Step 4: Add a Basic DataGrid

1. Import the control namespace `Syncfusion.Maui.DataGrid` in XAML or C# code.
2. Initialize the [SfDataGrid](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html) control.

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
{% endtabcontent %}

{% tabcontent JetBrains Rider %}

## Prerequisites

Before proceeding, ensure the following are set up:

1. Ensure you have the latest version of JetBrains Rider.
2. Install [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0) or later is installed.
3. Make sure the MAUI workloads are installed and configured as described [here.](https://www.jetbrains.com/help/rider/MAUI.html#before-you-start)

## Step 1: Create a new .NET MAUI Project

1. Go to **File > New Solution,** Select .NET (C#) and choose the .NET MAUI App template.
2. Enter the Project Name, Solution Name, and Location.
3. Select the .NET framework version and click Create.

## Step 2: Install the Syncfusion<sup>®</sup> MAUI DataGrid NuGet Package

1. In **Solution Explorer,** right-click the project and choose **Manage NuGet Packages.**
2. Search for [Syncfusion.Maui.DataGrid](https://www.nuget.org/packages/Syncfusion.Maui.DataGrid/) and install the latest version.
3. Ensure the necessary dependencies are installed correctly, and the project is restored. If not, Open the Terminal in Rider and manually run: `dotnet restore`

## Step 3: Register the handler

[Syncfusion.Maui.Core](https://www.nuget.org/packages/Syncfusion.Maui.Core/) NuGet is a dependent package for all Syncfusion<sup>®</sup> controls of .NET MAUI. In the MauiProgram.cs file, register the handler for Syncfusion<sup>®</sup> core.

{% highlight c# hl_lines="6 17" %}
using Microsoft.Maui;
using Microsoft.Maui.Hosting;
using Microsoft.Maui.Controls.Compatibility;
using Microsoft.Maui.Controls.Hosting;
using Microsoft.Maui.Controls.Xaml;
using Syncfusion.Maui.Core.Hosting;

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
            return builder.Build();
        }
    }
}
{% endhighlight %} 

## Step 4: Add a Basic DataGrid

1. Import the control namespace `Syncfusion.Maui.DataGrid` in XAML or C# code.
2. Initialize the [SfDataGrid](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html) control.

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
{% endtabcontent %}
{% endtabcontents %}

## Step 5: Define the View Model

### Data Model

Create a simple data model as shown in the following code example, and save it as `OrderInfo.cs` file:

{% tabs %}
{% highlight c# %}
public class OrderInfo
{
    private string orderID;
    private string customerID;
    private string customer;
    private string shipCity;
    private string shipCountry;

    public string OrderID
    {
        get { return orderID; }
        set { this.orderID = value; }
    }

    public string CustomerID
    {
        get { return customerID; }
        set { this.customerID = value; }
    }

    public string ShipCountry
    {
        get { return shipCountry; }
        set { this.shipCountry = value; }
    }

    public string Customer
    {
        get { return this.customer; }
        set { this.customer = value; }
    }

    public string ShipCity
    {
        get { return shipCity; }
        set { this.shipCity = value; }
    }

    public OrderInfo(string orderId, string customerId, string country, string customer, string shipCity)
    {
        this.OrderID = orderId;
        this.CustomerID = customerId;
        this.Customer = customer;
        this.ShipCountry = country;
        this.ShipCity = shipCity;
    }
} 
{% endhighlight %}
{% endtabs %}

N> If you want your data model to respond to property changes, implement the `INotifyPropertyChanged` interface in your model class.

### View Model

Create a model repository class with `OrderInfo` collection property initialized with the required number of data objects in a new class file as shown in the following code example, and save it as `OrderInfoRepository.cs` file:

{% tabs %}
{% highlight c# %}
public class OrderInfoRepository
{
    private ObservableCollection<OrderInfo> orderInfo;
    public ObservableCollection<OrderInfo> OrderInfoCollection
    {
        get { return orderInfo; }
        set { this.orderInfo = value; }
    }

    public OrderInfoRepository()
    {
        orderInfo = new ObservableCollection<OrderInfo>();
        this.GenerateOrders();
    }

    public void GenerateOrders()
    {
        orderInfo.Add(new OrderInfo("1001", "Maria Anders", "Germany", "ALFKI", "Berlin"));
        orderInfo.Add(new OrderInfo("1002", "Ana Trujillo", "Mexico", "ANATR", "Mexico D.F."));
        orderInfo.Add(new OrderInfo("1003", "Ant Fuller", "Mexico", "ANTON", "Mexico D.F."));
        orderInfo.Add(new OrderInfo("1004", "Thomas Hardy", "UK", "AROUT", "London"));
        orderInfo.Add(new OrderInfo("1005", "Tim Adams", "Sweden", "BERGS", "London"));
        orderInfo.Add(new OrderInfo("1006", "Hanna Moos", "Germany", "BLAUS", "Mannheim"));
        orderInfo.Add(new OrderInfo("1007", "Andrew Fuller", "France", "BLONP", "Strasbourg"));
        orderInfo.Add(new OrderInfo("1008", "Martin King", "Spain", "BOLID", "Madrid"));
        orderInfo.Add(new OrderInfo("1009", "Lenny Lin", "France", "BONAP", "Marsiella"));
        orderInfo.Add(new OrderInfo("1010", "John Carter", "Canada", "BOTTM", "Lenny Lin"));
        orderInfo.Add(new OrderInfo("1011", "Laura King", "UK", "AROUT", "London"));
        orderInfo.Add(new OrderInfo("1012", "Anne Wilson", "Germany", "BLAUS", "Mannheim"));
        orderInfo.Add(new OrderInfo("1013", "Martin King", "France", "BLONP", "Strasbourg"));
        orderInfo.Add(new OrderInfo("1014", "Gina Irene", "UK", "AROUT", "London"));
    }
}
{% endhighlight %}
{% endtabs %}

### Binding the ViewModel

Create a `ViewModel` instance and set it as the DataGrid's `BindingContext`. This enables property binding from `ViewModel` class.

To populate the `SfDataGrid`, bind the item collection from its `BindingContext` to [SfDataGrid.ItemsSource](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_ItemsSource) property. 

The following code example binds the collection created in the previous step to the `SfDataGrid.ItemsSource` property:

{% tabs %}
{% highlight xaml %}
<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
              xmlns:syncfusion="clr-namespace:Syncfusion.Maui.DataGrid;assembly=Syncfusion.Maui.DataGrid"
              xmlns:local="clr-namespace:GettingStarted"
             x:Class="GettingStarted.MainPage">

    <ContentPage.BindingContext>
        <local:OrderInfoRepository x:Name="viewModel" />
    </ContentPage.BindingContext>

    <ContentPage.Content>
        <syncfusion:SfDataGrid x:Name="dataGrid"
                               ItemsSource="{Binding OrderInfoCollection}">
        <syncfusion:SfDataGrid.Columns>
            <syncfusion:DataGridNumericColumn HeaderText="Order ID" Format="0"
                                            MappingName="OrderID" Width="150"/>
            <syncfusion:DataGridTextColumn  HeaderText="Customer ID"
                                            MappingName="CustomerID"
                                            Width="150" />
            <syncfusion:DataGridTextColumn  HeaderText="Ship Country"
                                            MappingName="ShipCountry"
                                            Width="150" />
        </syncfusion:SfDataGrid.Columns>
        </syncfusion:SfDataGrid>
    </ContentPage.Content>
</ContentPage>
{% endhighlight %}
{% highlight c# %}
OrderInfoRepository viewModel = new OrderInfoRepository();
dataGrid.ItemsSource = viewModel.OrderInfoCollection; 
{% endhighlight %}
{% endtabs %}

## Step 6: Running the Application

Press **F5** to build and run the application. Once compiled, the datagrid will be displayed with the data provided.

Here is the result of the previous codes,

![Getting started with .NET MAUI DataGrid.](Images\getting-started\net-maui-datagrid-getting-started.png)

You can download the complete project of this demo from [GitHub](https://github.com/SyncfusionExamples/simple-.net-maui-datagrid).

## Defining columns

By default, the SfDataGrid automatically creates columns for all the properties in the data source. The type of the column generated depends on the type of data in the column. When the columns are auto-generated, handle the [SfDataGrid.AutoGeneratingColumnMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_AutoGenerateColumnsMode) mode to customize or cancel the columns before they are added to the columns collection in the SfDataGrid.
 
The columns can be manually defined by setting the `SfDataGrid.AutoGenerateColumnsMode` property to 'None' and by adding the [DataGridColumn](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridColumn.html) objects to the [SfDataGrid.Columns](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.ColumnCollection.html) collection. This can be done from both XAML and code. The following code example illustrates this:

{% tabs %}
{% highlight xaml %}
<syncfusion:SfDataGrid x:Name="dataGrid"
            ColumnWidthMode="Fill"
            AutoGenerateColumnsMode="None"
            ItemsSource="{Binding OrderInfoCollection}">

    <syncfusion:SfDataGrid.Columns>
        <syncfusion:DataGridTextColumn HeaderText="ID"
                                   MappingName="OrderID"/>
        <syncfusion:DataGridTextColumn HeaderText="Customer"
                                   MappingName="CustomerID"/>
        <syncfusion:DataGridTextColumn MappingName="Customer"/>
        <syncfusion:DataGridTextColumn HeaderText="Country"
                                   MappingName="ShipCountry"/>
    </syncfusion:SfDataGrid.Columns>
</syncfusion:SfDataGrid>
{% endhighlight %}
{% highlight c# %}
dataGrid.AutoGenerateColumnsMode = AutoGenerateColumnsMode.None;

DataGridTextColumn orderIdColumn = new DataGridTextColumn ();
orderIdColumn.MappingName = "OrderID";
orderIdColumn.HeaderText = "ID";

DataGridTextColumn customerIdColumn = new DataGridTextColumn();
customerIdColumn.MappingName = "CustomerID";
customerIdColumn.HeaderText = "Customer";

DataGridTextColumn countryColumn = new DataGridTextColumn();
countryColumn.MappingName = "ShipCountry";
countryColumn.HeaderText = "Country";

dataGrid.Columns.Add (orderIdColumn);
dataGrid.Columns.Add (customerIdColumn);
dataGrid.Columns.Add (countryColumn); 
{% endhighlight %}
{% endtabs %}

## Sorting

In the SfDataGrid, sorting can be done on its data by setting the [SfDataGrid.SortingMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_SortingMode) property to single, multiple, or none.
 
{% tabs %}
{% highlight xaml %}
<syncfusion:SfDataGrid x:Name="dataGrid"
                       ItemsSource="{Binding OrderInfoCollection}"
                       SortingMode="Single" />
{% endhighlight %}
{% highlight c# %}
dataGrid.SortingMode = DataGridSortingMode.Single;
{% endhighlight %}
{% endtabs %}

Run the application and touch the header cell to sort the data and the following output will be displayed:
 
![Sorting in .NET MAUI DataGrid.](Images\getting-started\net-maui-datagrid-basic-sorting.png)

Sorting can also be configured by adding the column to the [SfDataGrid.SortColumnDescriptions](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_SortColumnDescriptions) collection as follows:

{% tabs %}
{% highlight xaml %}
<syncfusion:SfDataGrid.SortColumnDescriptions>
    <syncfusion:SortColumnDescription ColumnName="CustomerID" />
</syncfusion:SfDataGrid.SortColumnDescriptions> 
{% endhighlight %}
{% highlight c# %}
dataGrid.SortColumnDescriptions.Add(new SortColumnDescription() { ColumnName = "CustomerID" });
{% endhighlight %}
{% endtabs %}

## Selection

The SfDataGrid allows selecting the one row or more rows by setting the [SfDataGrid.SelectionMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_SelectionMode) property. You can set the `SfDataGrid.SelectionMode` property to single, multiple, single deselect, or none. Information about the row or rows selected can be tracked using the [SfDataGrid.SelectedRow](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_SelectedRow) and [SfDataGrid.SelectedRows](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_SelectedRows) properties.

The selection operations can be handled with the help of the [SelectionChanging](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_SelectionChanging) and [SelectionChanged](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_SelectionChanged) events of the SfDataGrid.

## Loading the SfDataGrid with customized height and width

The SfDataGrid can be loaded with specific heights and widths inside different layouts using the `SfDataGrid.HeightRequest` and `SfDataGrid.WidthRequest` properties.

The following code example illustrates how this can be done:

{% tabs %}
{% highlight xaml %}
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
              xmlns:local="clr-namespace:GettingStarted"
             xmlns:syncfusion="clr-namespace:Syncfusion.Maui.DataGrid;assembly=Syncfusion.Maui.DataGrid"
             x:Class="GettingStarted.MainPage">

     <ContentPage.BindingContext>
        <local:OrderInfoRepository x:Name="viewModel" />
    </ContentPage.BindingContext>
    
        <syncfusion:SfDataGrid x:Name="dataGrid"
                           ItemsSource="{Binding OrderInfoCollection}"
                           HeightRequest="290"
                           WidthRequest="200"
                           HorizontalOptions="Center"/>
    
</ContentPage>
{% endhighlight %}

{% highlight c# %}
public MainPage()
{
    InitializeComponent();
    OrderInfoRepository viewModel = new OrderInfoRepository();
    dataGrid = new SfDataGrid();
    dataGrid.ItemsSource = viewModel.OrderInfoCollection;
    dataGrid.HeightRequest = 290;
    dataGrid.WidthRequest = 200;
    dataGrid.VerticalOptions = LayoutOptions.CenterAndExpand;
    dataGrid.HorizontalOptions = LayoutOptions.Center;
    this.Content = dataGrid;
}
{% endhighlight %}
{% endtabs %}

N> Set `HorizontalOptions` and `VerticalOptions` to grid accordingly. When the `SfDataGrid` doesn't obtain finite size from its parent to layout in the View, the predefined `MinimumHeightRequest` and `MinimumWidthRequest`, which is 300, will be acquired.

N> You can refer to our [.NET MAUI DataGrid](https://www.syncfusion.com/maui-controls/maui-datagrid) feature tour page for its groundbreaking feature representations. You can also explore our [.NET MAUI DataGrid Example](https://github.com/syncfusion/maui-demos/tree/master/MAUI/DataGrid) that shows you how to render the DataGrid in .NET MAUI.

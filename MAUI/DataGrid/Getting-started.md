---
layout: post
title: Getting Started with .NET MAUI DataGrid control | Syncfusion
canonical_url: "https://www.syncfusion.com/maui-controls/maui-datagrid"
description: Learn about getting started with Syncfusion .NET MAUI DataGrid (SfDataGrid) control, its elements, and more here.
platform: MAUI
control: SfDataGrid
documentation: ug
keywords : maui datagrid, maui grid, grid maui, maui gridview, grid in maui, .net maui datagrid, .net maui grid, .net grid maui
---

# Getting Started with .NET MAUI DataGrid

This section provides a quick overview for working with the [SfDataGrid](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html) for .NET MAUI.  Follow the steps below to add a basic DataGrid to your project.

To quickly get started with the [.NET MAUI DataGrid](https://www.syncfusion.com/maui-controls/maui-datagrid), watch this video:

<style>#MAUIDataGridVideoTutorial{width : 90% !important; height: 400px !important }</style> <iframe id='MAUIDataGridVideoTutorial' src='https://www.youtube.com/embed/xW0a7JlHbz4'></iframe>

{% tabcontents %}
{% tabcontent Visual Studio %}

## Prerequisites

Before proceeding, ensure the following are set up:

1. Install [.NET 9 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/9.0) or later.
2. Set up a .NET MAUI environment with Visual Studio 2022 v17.12 or later.

## Step 1: Create a new .NET MAUI project

1. Go to **File > New > Project** and choose the **.NET MAUI App** template.
2. Name the project and choose a location. Then, click **Next.**
3. Select the .NET framework version and click **Create.**

## Step 2: Install the Syncfusion<sup>®</sup> MAUI DataGrid NuGet package

1.  In **Solution Explorer**, right-click the project and choose **Manage NuGet Packages**.
2.  Search for [Syncfusion.Maui.DataGrid](https://www.nuget.org/packages/Syncfusion.Maui.DataGrid/) and install the latest version.
3.  Ensure the necessary dependencies are installed correctly, and the project is restored.

{% endtabcontent %}

{% tabcontent Visual Studio Code %}

## Prerequisites

Before proceeding, ensure the following are set up:

1. Install [.NET 9 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/9.0) or later.
2. Set up a .NET MAUI environment with Visual Studio Code.
3. Ensure that the .NET MAUI workloads are installed and configured as described [here](https://learn.microsoft.com/en-us/dotnet/maui/get-started/installation?view=net-maui-9.0&tabs=visual-studio-code).

## Step 1: Create a new .NET MAUI project

1. Open the command palette by pressing `Ctrl+Shift+P` and type **.NET:New Project** and enter.
2. Choose the **.NET MAUI App** template.
3. Select the project location, type the project name and press **Enter.**
4. Then choose **Create project.**

## Step 2: Install the Syncfusion<sup>®</sup> MAUI DataGrid NuGet package

1. Press <kbd>Ctrl</kbd> + <kbd>`</kbd> (backtick) to open the integrated terminal in Visual Studio Code.
2. Ensure you're in the project root directory where your .csproj file is located.
3. Run the command `dotnet add package Syncfusion.Maui.DataGrid` to install the Syncfusion<sup>®</sup> .NET MAUI DataGrid package.
4. To ensure all dependencies are installed, run `dotnet restore`.

{% endtabcontent %}

{% tabcontent JetBrains Rider %}

## Prerequisites

Before proceeding, ensure the following are set up:

1. Install [.NET 9 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/9.0) or later.
2. Set up a .NET MAUI environment with JetBrains Rider 2024.3 or later.
3. Make sure the MAUI workloads are installed and configured as described [here.](https://www.jetbrains.com/help/rider/MAUI.html#before-you-start)

## Step 1: Create a new .NET MAUI project

1. Go to **File > New Solution,** Select .NET (C#) and choose the .NET MAUI App template.
2. Enter the Project Name, Solution Name, and Location.
3. Select the .NET framework version and click Create.

## Step 2: Install the Syncfusion<sup>®</sup> MAUI DataGrid NuGet package

1. In **Solution Explorer,** right-click the project and choose **Manage NuGet Packages.**
2. Search for [Syncfusion.Maui.DataGrid](https://www.nuget.org/packages/Syncfusion.Maui.DataGrid/) and install the latest version.
3. Ensure the necessary dependencies are installed correctly, and the project is restored. If not, Open the Terminal in Rider and manually run: `dotnet restore`

{% endtabcontent %}
{% endtabcontents %}

## Step 3: Register Syncfusion Core Handler
 
To use Syncfusion controls, you must register the Syncfusion core handler in your application's startup configuration.
 
In the `MauiProgram.cs` file (located at the root of your project), add the namespace and register the handler in the `CreateMauiApp` method:

{% tabs %}
{% highlight c# %}
using Syncfusion.Maui.Core.Hosting;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
            })
            .ConfigureSyncfusionCore();  // Add this line
        
        return builder.Build();
    }
}
{% endhighlight %}
{% endtabs %}

## Step 4: Define Model and Data Repository

Create a simple data model as shown in the following code example and save it as `OrderInfo.cs` in the project root or in a `Models` folder:

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

> **Note:** If you want your data model to respond to property changes, implement the [`INotifyPropertyChanged`](https://learn.microsoft.com/en-us/dotnet/api/system.componentmodel.inotifypropertychanged) interface in your model class. This enables the DataGrid to refresh automatically when data properties are updated.

Next, create a data repository class that manages a collection of `OrderInfo` objects. This repository serves as a simple data source for the DataGrid. Create a new class file and save it as `OrderInfoRepository.cs` in the same `Models` folder or project root:

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
        orderInfo.Add(new OrderInfo("1001", "ALFKI", "Germany", "Maria Anders", "Berlin"));
        orderInfo.Add(new OrderInfo("1002", "ANATR", "Mexico", "Ana Trujillo", "Mexico D.F."));
        orderInfo.Add(new OrderInfo("1003", "ANTON", "Mexico", "Ant Fuller", "Mexico D.F."));
        orderInfo.Add(new OrderInfo("1004", "AROUT", "UK", "Thomas Hardy", "London"));
        orderInfo.Add(new OrderInfo("1005", "BERGS", "Sweden", "Tim Adams", "London"));
        orderInfo.Add(new OrderInfo("1006", "BLAUS", "Germany", "Hanna Moos", "Mannheim"));
        orderInfo.Add(new OrderInfo("1007", "BLONP", "France", "Andrew Fuller", "Strasbourg"));
        orderInfo.Add(new OrderInfo("1008", "BOLID", "Spain", "Martin King", "Madrid"));
        orderInfo.Add(new OrderInfo("1009", "BONAP", "France", "Lenny Lin", "Marsiella"));
    }
}
{% endhighlight %}
{% endtabs %}

## Step 5: Import the DataGrid namespace

Add the following namespace in your XAML or C#.

{% tabs %}
{% highlight xaml %}
xmlns:syncfusion="clr-namespace:Syncfusion.Maui.DataGrid;assembly=Syncfusion.Maui.DataGrid"
{% endhighlight %}
{% highlight c# tabtitle="C#" %}
using Syncfusion.Maui.DataGrid;
{% endhighlight %}
{% endtabs %}

## Step 6: Add the DataGrid Component

To populate the `SfDataGrid`, bind the data collection to the [SfDataGrid.ItemsSource](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_ItemsSource) property. 

Choose one of the following approaches to add the DataGrid:

**XAML Approach (Recommended)** — Define the DataGrid declaratively in XAML and bind to data:

{% tabs %}
{% highlight xaml %}
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:syncfusion="clr-namespace:Syncfusion.Maui.DataGrid;assembly=Syncfusion.Maui.DataGrid">
    <syncfusion:SfDataGrid x:Name="dataGrid"
                           ItemsSource="{Binding OrderInfoCollection}"> 
    </syncfusion:SfDataGrid>
</ContentPage>
{% endhighlight %}
{% endtabs %}

Then set the data repository as the page's BindingContext in your code-behind:

{% tabs %}
{% highlight c# tabtitle="DataGridPage.xaml.cs" %}
public partial class DataGridPage : ContentPage
{
    public DataGridPage()
    {
        InitializeComponent();
        // Set the repository as the BindingContext for data binding
        this.BindingContext = new OrderInfoRepository();
    }
}
{% endhighlight %}
{% endtabs %}

**C# Approach** — Create and configure the DataGrid programmatically in your page's code-behind:

{% tabs %}
{% highlight c# tabtitle="DataGridPage.xaml.cs" %}
public partial class DataGridPage : ContentPage
{
    public DataGridPage()
    {
        InitializeComponent();
        
        // Create and configure the DataGrid programmatically
        OrderInfoRepository repository = new OrderInfoRepository();
        SfDataGrid dataGrid = new SfDataGrid();
        dataGrid.ItemsSource = repository.OrderInfoCollection;
        Content = dataGrid;
    }
}
{% endhighlight %}
{% endtabs %}


The following screenshot shows the DataGrid populated with sample data:

<img src="Images\getting-started\net-maui-datagrid-getting-started.png" width="404" alt="Getting started with .NET MAUI DataGrid">

**Next Steps:** You can download the complete Getting Started sample from [GitHub](https://github.com/SyncfusionExamples/simple-.net-maui-datagrid) and explore additional DataGrid features such as columns, sorting, filtering, and grouping.

> **Note:** You can refer to our [.NET MAUI DataGrid](https://www.syncfusion.com/maui-controls/maui-datagrid) feature tour page for more information. You can also explore our [.NET MAUI DataGrid Example](https://github.com/syncfusion/maui-demos/tree/master/MAUI/DataGrid) that shows you how to render the DataGrid in .NET MAUI.

---
layout: post
title: Getting Started with .NET MAUI Smart DataGrid | Syncfusion®
description: Learn about getting started with Syncfusion .NET MAUI Smart DataGrid (SfDataGrid) control, its elements, and more here.
platform: MAUI
control: SfSmartDataGrid
documentation: ug
keywords: maui smart datagrid getting started, ai datagrid maui, .net maui smart datagrid setup, Syncfusion.Maui.SmartDataGrid
---

# Getting Started with .NET MAUI Smart DataGrid

This section provides a quick overview for working with the `SfSmartDataGrid` for .NET MAUI. Follow the steps below to add a basic Smart DataGrid to your project.

N> The Smart DataGrid is distributed as part of the `Syncfusion.Maui.SmartDataGrid` package and supports AI-assisted interactions such as intelligent sorting, filtering, grouping, and highlighting. Ensure your application has the required AI service configuration to enable these features.

{% tabcontents %}
{% tabcontent Visual Studio %}

## Prerequisites
Before proceeding, ensure the following are set up:

1. Install [.NET 9 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/9.0) or later is installed.
2. Set up a .NET MAUI environment with Visual Studio 2026 (v18.0.0 or later).

## Step 1: Create a new .NET MAUI Project

1. Go to **File > New > Project** and choose the **.NET MAUI App** template.
2. Name the project and choose a location. Then, click **Next.**
3. Select the .NET framework version and click **Create.**

## Step 2: Install the Syncfusion<sup>®</sup> MAUI Smart DataGrid NuGet Package

1. In **Solution Explorer**, right-click the project and choose **Manage NuGet Packages**.
2. Search for `Syncfusion.Maui.SmartDataGrid` and install the latest version.
3. Ensure the necessary dependencies are installed correctly, and the project is restored.

{% endtabcontent %}

{% tabcontent Visual Studio Code %}

## Prerequisites
Before proceeding, ensure the following are set up:

1. Install [.NET 9 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/9.0) or later is installed.
2. Set up a .NET MAUI environment with Visual Studio Code.
3. Ensure that the .NET MAUI extension is installed and configured as described [here.](https://learn.microsoft.com/en-us/dotnet/maui/get-started/installation?view=net-maui-9.0&tabs=visual-studio-code)

## Step 1: Create a new .NET MAUI Project

1. Open the command palette by pressing `Ctrl+Shift+P` and type **.NET:New Project** and enter.
2. Choose the **.NET MAUI App** template.
3. Select the project location, type the project name and press **Enter.**
4. Then choose **Create project.**

## Step 2: Install the Syncfusion<sup>®</sup> MAUI Smart DataGrid NuGet Package

1. In **Solution Explorer**, right-click the project and choose **Manage NuGet Packages**.
2. Search for `Syncfusion.Maui.SmartDataGrid` and install the latest version.
3. Ensure the necessary dependencies are installed correctly, and the project is restored.

{% endtabcontent %}

{% tabcontent JetBrains Rider %}

## Prerequisites

Before proceeding, ensure the following are set up:

1. Ensure you have the latest version of JetBrains Rider.
2. Install [.NET 9 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/9.0) or later is installed.
3. Make sure the MAUI workloads are installed and configured as described [here.](https://www.jetbrains.com/help/rider/MAUI.html#before-you-start)

## Step 1: Create a new .NET MAUI Project

1. Go to **File > New Solution,** Select .NET (C#) and choose the .NET MAUI App template.
2. Enter the Project Name, Solution Name, and Location.
3. Select the .NET framework version and click Create.

## Step 2: Install the Syncfusion<sup>®</sup> MAUI Smart DataGrid NuGet Package

1. In **Solution Explorer**, right-click the project and choose **Manage NuGet Packages**.
2. Search for `Syncfusion.Maui.SmartDataGrid` and install the latest version.
3. Ensure the necessary dependencies are installed correctly, and the project is restored.

{% endtabcontent %}
{% endtabcontents %}

## Step 3: Register Syncfusion handler

Make sure to add the namespace.

{% tabs %}
{% highlight c# %}
using Syncfusion.Maui.Core.Hosting;
{% endhighlight %}
{% endtabs %}

Register the Syncfusion core handler in your `CreateMauiApp` method of `MauiProgram.cs` file to use Syncfusion controls.

{% tabs %}
{% highlight c# %}
builder.ConfigureSyncfusionCore();
{% endhighlight %} 
{% endtabs %}

## Step 4: Register the AI Service

Make sure to add the namespace.

{% tabs %}
{% highlight c# %}
using Syncfusion.Maui.SmartComponents.Hosting;
{% endhighlight %}
{% endtabs %}

To configure the AI services, you must call the `ConfigureSyncfusionAIServices()` method in the `MauiProgram.cs` file.

{% tabs %}
{% highlight c# %}
string key = "<MENTION-YOUR-KEY>";
Uri azureEndPoint = new Uri("<MENTION-YOUR-URL>");
string deploymentName = "<MENTION-YOUR-DEPLOYMENT-NAME>";

// Shows how to configure Azure AI service to the Smart Components.
AzureOpenAIClient azureOpenAIClient = new AzureOpenAIClient(azureEndPoint, new AzureKeyCredential(key));
IChatClient azureChatClient = azureOpenAIClient.GetChatClient(deploymentName).AsIChatClient();

builder.Services.AddChatClient(azureChatClient);
builder.ConfigureSyncfusionAIServices();
{% endhighlight %} 
{% endtabs %}

## Step 5: Import the namespace

Add the following namespace in your XAML or C#.

{% tabs %}
{% highlight xaml %}

xmlns:syncfusion="clr-namespace:Syncfusion.Maui.SmartDataGrid;assembly=Syncfusion.Maui.SmartDataGrid"

{% endhighlight %}
{% highlight c# %}

using Syncfusion.Maui.SmartDataGrid;

{% endhighlight %}
{% endtabs %}

## Step 6: Define the Model and View Model

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
        orderInfo.Add(new OrderInfo("1001", "Maria Anders", "Germany", "ALFKI", "Berlin"));
        orderInfo.Add(new OrderInfo("1002", "Ana Trujillo", "Mexico", "ANATR", "Mexico D.F."));
        orderInfo.Add(new OrderInfo("1003", "Ant Fuller", "Mexico", "ANTON", "Mexico D.F."));
        orderInfo.Add(new OrderInfo("1004", "Thomas Hardy", "UK", "AROUT", "London"));
        orderInfo.Add(new OrderInfo("1005", "Tim Adams", "Sweden", "BERGS", "London"));
        orderInfo.Add(new OrderInfo("1006", "Hanna Moos", "Germany", "BLAUS", "Mannheim"));
        orderInfo.Add(new OrderInfo("1007", "Andrew Fuller", "France", "BLONP", "Strasbourg"));
        orderInfo.Add(new OrderInfo("1008", "Martin King", "Spain", "BOLID", "Madrid"));
        orderInfo.Add(new OrderInfo("1009", "Lenny Lin", "France", "BONAP", "Marsiella"));
        orderInfo.Add(new OrderInfo("1010", "John Carter", "Canada", "BOTTM", "Lenny Lin"));
        orderInfo.Add(new OrderInfo("1011", "Laura King", "UK", "AROUT", "London"));
        orderInfo.Add(new OrderInfo("1012", "Anne Wilson", "Germany", "BLAUS", "Mannheim"));
        orderInfo.Add(new OrderInfo("1013", "Martin King", "France", "BLONP", "Strasbourg"));
        orderInfo.Add(new OrderInfo("1014", "Gina Irene", "UK", "AROUT", "London"));
    }
}
{% endhighlight %}
{% endtabs %}

## Step 7: Add the Smart DataGrid component

Create a `ViewModel` instance and set it as the DataGrid's `BindingContext`. This enables property binding from `ViewModel` class.

To populate the `SfSmartDataGrid`, bind the item collection from its `BindingContext` to [SfSmartDataGrid.ItemsSource](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_ItemsSource) property.

The following code example binds the collection created in the previous step to the `SfSmartDataGrid.ItemsSource` property:

{% tabs %}
{% highlight xaml %}
<syncfusion:SfSmartDataGrid x:Name="dataGrid"
                            ItemsSource="{Binding OrderInfoCollection}">
    <syncfusion:SfSmartDataGrid.BindingContext>
        <local:OrderInfoRepository />
    </syncfusion:SfSmartDataGrid.BindingContext>
</syncfusion:SfSmartDataGrid>
{% endhighlight %}
{% highlight c# %}
OrderInfoRepository viewModel = new OrderInfoRepository();
SfSmartDataGrid dataGrid = new SfSmartDataGrid();
dataGrid.ItemsSource = viewModel.OrderInfoCollection;
{% endhighlight %}
{% endtabs %}

Here is the result of the above codes,

<img src="Images\getting-started\maui-smart-datagrid.png" width="600" alt="Getting started with .NET MAUI Smart DataGrid." />

You can download the Smart DataGrid Getting Started sample from [here](https://github.com/SyncfusionExamples/Maui-SmartDataGrid-Sample).

N> You can refer to our [.NET MAUI Smart DataGrid](https://www.syncfusion.com/maui-controls/maui-smart-datagrid) feature tour page for its groundbreaking feature representations. You can also explore our [.NET MAUI Smart DataGrid Example](https://github.com/syncfusion/maui-demos/tree/master/MAUI/SmartComponents) that shows you how to render the Smart DataGrid in .NET MAUI.
---
layout: post
title: Getting Started with .NET MAUI Smart DataGrid | Syncfusion®
description: Learn how to get started with the Syncfusion® .NET MAUI Smart DataGrid control, add the NuGet package, register the license, initialize the control, and bind data.
platform: MAUI
control: SfSmartDataGrid
documentation: ug
keywords: maui smart datagrid getting started, ai datagrid maui, .net maui smart datagrid setup, Syncfusion.Maui.SmartComponents
---

# Getting Started with .NET MAUI Smart DataGrid

This section provides a quick overview for working with the [SfSmartDataGrid](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SmartComponents.SfSmartDataGrid.html) for .NET MAUI. Follow the steps below to add a basic Smart DataGrid to your project.

N> The Smart DataGrid is distributed as part of the `Syncfusion.Maui.SmartComponents` package and supports AI-assisted interactions such as intelligent sorting, filtering, grouping, and highlighting. Ensure your application has the required AI service configuration to enable these features.

{% tabcontents %}
{% tabcontent Visual Studio %}

## Prerequisites
Before proceeding, ensure the following are set up:

1. Install [.NET 9 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/9.0) or later is installed.
2. Set up a .NET MAUI environment with Visual Studio 2022 (v17.3 or later).

## Step 1: Create a new .NET MAUI Project

1. Go to **File > New > Project** and choose the **.NET MAUI App** template.
2. Name the project and choose a location. Then, click **Next.**
3. Select the .NET framework version and click **Create.**

## Step 2: Install the Syncfusion<sup>®</sup> MAUI Smart DataGrid NuGet Package

1. In **Solution Explorer**, right-click the project and choose **Manage NuGet Packages**.
2. Search for [Syncfusion.Maui.SmartComponents](https://www.nuget.org/packages/Syncfusion.Maui.SmartComponents/) and install the latest version.
3. Ensure the necessary dependencies are installed correctly, and the project is restored.

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

## Step 4: Add a Basic Smart DataGrid

1. Import the control namespace `Syncfusion.Maui.SmartComponents` in XAML or C# code.
2. Initialize the [SfSmartDataGrid](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SmartComponents.SfSmartDataGrid.html) control.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

<ContentPage
    . . .
    xmlns:syncfusion="clr-namespace:Syncfusion.Maui.SmartComponents;assembly=Syncfusion.Maui.SmartComponents">

    <syncfusion:SfSmartDataGrid />
</ContentPage>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

using Syncfusion.Maui.SmartComponents;
. . .

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        SfSmartDataGrid dataGrid = new SfSmartDataGrid();
        this.Content = dataGrid;
    }
}

{% endhighlight %}
{% endtabs %}
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

1. Press <kbd>Ctrl</kbd> + <kbd>`</kbd> (backtick) to open the integrated terminal in Visual Studio Code.
2. Ensure you're in the project root directory where your .csproj file is located.
3. Run the command `dotnet add package Syncfusion.Maui.SmartComponents` to install the Syncfusion<sup>®</sup> .NET MAUI Smart Components package.
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

## Step 4: Add a Basic Smart DataGrid

1. Import the control namespace `Syncfusion.Maui.SmartComponents` in XAML or C# code.
2. Initialize the [SfSmartDataGrid](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SmartComponents.SfSmartDataGrid.html) control.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

<ContentPage
    . . .
    xmlns:syncfusion="clr-namespace:Syncfusion.Maui.SmartComponents;assembly=Syncfusion.Maui.SmartComponents">

    <syncfusion:SfSmartDataGrid />
</ContentPage>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

using Syncfusion.Maui.SmartComponents;
. . .

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        SfSmartDataGrid dataGrid = new SfSmartDataGrid();
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
2. Install [.NET 9 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/9.0) or later is installed.
3. Make sure the MAUI workloads are installed and configured as described [here.](https://www.jetbrains.com/help/rider/MAUI.html#before-you-start)

## Step 1: Create a new .NET MAUI Project

1. Go to **File > New Solution,** Select .NET (C#) and choose the .NET MAUI App template.
2. Enter the Project Name, Solution Name, and Location.
3. Select the .NET framework version and click Create.

## Step 2: Install the Syncfusion<sup>®</sup> MAUI Smart DataGrid NuGet Package

1. In **Solution Explorer,** right-click the project and choose **Manage NuGet Packages.**
2. Search for [Syncfusion.Maui.SmartComponents](https://www.nuget.org/packages/Syncfusion.Maui.SmartComponents/) and install the latest version.
3. Ensure the necessary dependencies are installed correctly, and the project is restored. If not, Open the Terminal in Rider and manually run: `dotnet restore`

## Step 3: Register the handler

[Syncfusion.Maui.Core](https://www.nuget.org/packages/Syncfusion.Maui.Core/) NuGet is a dependent package for all Syncfusion<sup>®</sup> controls of .NET MAUI. In the `MauiProgram.cs` file, register the handler for Syncfusion<sup>®</sup> core.

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

## Step 4: Register the AI Service

To configure the AI services, you must call the `ConfigureSyncfusionAIServices()` method in the `MauiProgram.cs` file.

{% highlight c# hl_lines="6 26" %}
using Microsoft.Maui;
using Microsoft.Maui.Hosting;
using Microsoft.Maui.Controls.Compatibility;
using Microsoft.Maui.Controls.Hosting;
using Microsoft.Maui.Controls.Xaml;
using Syncfusion.Maui.SmartComponents.Hosting;

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

            string key = "<MENTION-YOUR-KEY>";
            Uri azureEndPoint = new Uri("<MENTION-YOUR-URL>");
            string deploymentName = "<MENTION-YOUR-DEPLOYMENT-NAME>";

            // Shows how to configure Azure AI service to the Smart Components.
            AzureOpenAIClient azureOpenAIClient = new AzureOpenAIClient(azureEndPoint, new AzureKeyCredential(key));
            IChatClient azureChatClient = azureOpenAIClient.GetChatClient(deploymentName).AsIChatClient();

            builder.Services.AddChatClient(azureChatClient);
            builder.ConfigureSyncfusionAIServices();

            return builder.Build();
        }
    }
}
{% endhighlight %}

## Step 4: Add a Basic Smart DataGrid

1. Import the control namespace `Syncfusion.Maui.SmartComponents` in XAML or C# code.
2. Initialize the [SfSmartDataGrid](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SmartComponents.SfSmartDataGrid.html) control.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

<ContentPage
    . . .
    xmlns:syncfusion="clr-namespace:Syncfusion.Maui.SmartComponents;assembly=Syncfusion.Maui.SmartComponents">

    <syncfusion:SfSmartDataGrid />
</ContentPage>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

using Syncfusion.Maui.SmartComponents;
. . .

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        SfSmartDataGrid dataGrid = new SfSmartDataGrid();
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

### Binding the ViewModel

Create a `ViewModel` instance and set it as the DataGrid's `BindingContext`. This enables property binding from `ViewModel` class.

To populate the `SfSmartDataGrid`, bind the item collection from its `BindingContext` to [SfSmartDataGrid.ItemsSource](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SmartComponents.SfSmartDataGrid.html#Syncfusion_Maui_SmartComponents_SfSmartDataGrid_ItemsSource) property.

The following code example binds the collection created in the previous step to the `SfSmartDataGrid.ItemsSource` property:

{% tabs %}
{% highlight xaml %}
<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
              xmlns:syncfusion="clr-namespace:Syncfusion.Maui.SmartComponents;assembly=Syncfusion.Maui.SmartComponents"
              xmlns:local="clr-namespace:GettingStarted"
             x:Class="GettingStarted.MainPage">

    <ContentPage.BindingContext>
        <local:OrderInfoRepository x:Name="viewModel" />
    </ContentPage.BindingContext>

    <ContentPage.Content>
        <syncfusion:SfSmartDataGrid x:Name="dataGrid"
                               ItemsSource="{Binding OrderInfoCollection}">
        <syncfusion:SfSmartDataGrid.Columns>
            <syncfusion:TextColumn HeaderText="Order ID" Format="0"
                                            MappingName="OrderID" Width="150"/>
            <syncfusion:TextColumn  HeaderText="Customer ID"
                                            MappingName="CustomerID"
                                            Width="150" />
            <syncfusion:TextColumn  HeaderText="Ship Country"
                                            MappingName="ShipCountry"
                                            Width="150" />
        </syncfusion:SfSmartDataGrid.Columns>
        </syncfusion:SfSmartDataGrid>
    </ContentPage.Content>
</ContentPage>
{% endhighlight %}
{% highlight c# %}
OrderInfoRepository viewModel = new OrderInfoRepository();
dataGrid.ItemsSource = viewModel.OrderInfoCollection;
{% endhighlight %}
{% endtabs %}

## Step 6: Enabling AI-Assisted Operations

The Smart DataGrid supports natural language operations for enhanced data interaction. These features require configuring an AI provider in your application.

### Using AI Features

Once configured, leverage AI-assisted features such as:

- **AI Sorting**: Sort data intelligently by entering prompts like “Sort by customer name alphabetically”.
- **Intelligent Filtering**: Apply filters using natural language, e.g., “Show orders from Germany shipped in the last month”.
- **Smart Grouping**: Group data with prompts like “Group by ship country, then by customer”.
- **Row and Cell Highlighting**: Highlight critical information, e.g., “Highlight orders where quantity is greater than 10”.

## Step 7: Running the Application

Press **F5** to build and run the application. Once compiled, the smart datagrid will be displayed with the data provided, and AI features will be available after configuration.

Here is the result of the previous codes,

<img src="Images\getting-started\maui-smart-datagrid.png" width="600" alt="Getting started with .NET MAUI Smart DataGrid." />

N> You can refer to our [.NET MAUI Smart DataGrid](https://www.syncfusion.com/maui-controls/maui-smart-datagrid) feature tour page for its groundbreaking feature representations. You can also explore our [.NET MAUI Smart DataGrid Example](https://github.com/syncfusion/maui-demos/tree/master/MAUI/SmartDataGrid) that shows you how to render the Smart DataGrid in .NET MAUI.
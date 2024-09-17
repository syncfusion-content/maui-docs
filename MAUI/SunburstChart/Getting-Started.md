---
layout: post
title: Getting Started with .NET MAUI Sunburst Chart control | Syncfusion
description: Learn here all about getting started with Syncfusion .NET MAUI Sunburst Chart control, its elements, and more.
platform: maui
control: SfSunburstChart
documentation: ug
---

# Getting Started with .NET MAUI Sunburst Chart

This section explains how to populate the sunburst chart with data, a title, data labels, a legend, and a tooltip, as well as the essential aspects of getting started with the sunburst chart.

## Creating an Application Using the .NET MAUI Sunburst Chart## Prerequisites

Before starting, ensure the following are set up:

1. .NET 7 SDK (https://dotnet.microsoft.com/en-us/download/dotnet/7.0) or later is installed.
2. A .NET MAUI development environment is ready with either Visual Studio 2022 (v17.3 or later) or VS Code. If using VS Code, make sure the .NET MAUI workload is installed and configured as per the instructions provided [here](https://learn.microsoft.com/en-us/dotnet/maui/get-started/installation?view=net-maui-8.0&tabs=visual-studio-code).

## Step 1: Create a New MAUI Project

### Visual Studio

1. Go to File > New > Project and choose the .NET MAUI App template.
2. Name the project and choose a location, then click Next.
3. Select the .NET framework version and click Create.

### Visual Studio Code

1. Open the command palette by pressing `Ctrl+Shift+P`` and type .NET:New Project and enter.
2. Choose the .NET MAUI App template.
3. Select the project location, type the project name and press enter.
4. Then choose Create project

## Step 2: Install the Syncfusion MAUI Sunburst Chart NuGet Package

1. In Solution Explorer, right-click the project and choose Manage NuGet Packages.
2. Search for Syncfusion.Maui.SunburstChart on [nuget.org](https://www.nuget.org/) and install the latest version.
3. Ensure all dependencies are correctly installed, and restore your project.

## Step 3: Add a Basic Sunburst Chart

1. To initialize the control, import the Sunburst Chart namespace into your code.
2. Initialize [SfSunburstChart](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SunburstChart.SfSunburstChart.html).

{% tabs %} 

{% highlight xaml %}

<ContentPage   
    . . .
    xmlns:sunburst="clr-namespace:Syncfusion.Maui.SunburstChart;assembly=Syncfusion.Maui.SunburstChart">

    <sunburst:SfSunburstChart/>
</ContentPage>
 
{% endhighlight %}

{% endtabs %} 

You can also create the chart programmatically in the MainPage.xaml.cs file:

{% tabs %} 

{% highlight C# %}

using Syncfusion.Maui.SunburstChart;

namespace SunburstGettingStarted
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();           
            SfSunburstChart sunburst = new SfSunburstChart();
        }
    }   
}

{% endhighlight %}

{% endtabs %}

## Step 4: Register the handler

[Syncfusion.Maui.Core nuget](https://www.nuget.org/packages/Syncfusion.Maui.Core) is a dependent package for all Syncfusion controls of .NET MAUI. In the **MauiProgram.cs file**, register the handler for Syncfusion core.

{% highlight C# %}

using Microsoft.Maui;
using Microsoft.Maui.Hosting;
using Microsoft.Maui.Controls.Compatibility;
using Microsoft.Maui.Controls.Hosting;
using Microsoft.Maui.Controls.Xaml;
using Syncfusion.Maui.Core.Hosting;

namespace SunburstGettingStarted
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

## Step 5: Define the View Model

### Data Model

Now, let us define a simple data model that represents a data point in the sunburst chart.

{% tabs %}  

{% highlight c# %}

public class SunburstModel
{
    public string JobDescription { get; set; }
    public string JobGroup { get; set; }
    public double EmployeesCount { get; set; }
    public string Country { get; set; }
}

{% endhighlight %} 

{% endtabs %} 

### View Model

Next, create a view model class and initialize a list of `SunburstModel` objects as follows.

{% tabs %}  

{% highlight c# %}

public class SunburstViewModel
{
    public ObservableCollection<SunburstModel> DataSource { get; set; }

    public SunburstViewModel()
    {
        this.DataSource = new ObservableCollection<SunburstModel>
        {
            new SunburstModel ( "USA", "Sales", "Executive",  50 ),
            new SunburstModel ( "USA", "Sales", "Analyst",  40 ),
            new SunburstModel ( "USA", "Marketing",  40 ),
            new SunburstModel ( "USA", "Technical", "Testers",  35 ),
            new SunburstModel ( "USA", "Technical", "Developers",  175 ),
            new SunburstModel ( "USA", "Technical", "Developers",  70 ),
            new SunburstModel ( "USA", "Management",  40 ),
            new SunburstModel ( "USA", "Accounts",  60 ),
            new SunburstModel ( "India", "Technical", "Testers",  33 ),
            new SunburstModel ( "India", "Technical", "Developers",  125 ),
            new SunburstModel ( "India", "Technical", "Developers",  60 ),
            new SunburstModel ( "India", "HR Executives",  70 ),
            new SunburstModel ( "India", "Accounts",  45 ),
            new SunburstModel ( "Germany", "Sales", "Executive",  30 ),
            new SunburstModel ( "Germany", "Sales", "Analyst",  40 ),
            new SunburstModel ( "Germany", "Marketing",  50 ),
            new SunburstModel ( "Germany", "Technical", "Testers",  40 ),
            new SunburstModel ( "Germany", "Technical", "Developers",  60 ),
            new SunburstModel ( "Germany", "Technical", "Developers",  27 ),
            new SunburstModel ( "Germany", "Management",  40 ),
            new SunburstModel ( "Germany", "Accounts",  55 ),
            new SunburstModel ( "UK", "Technical", "Testers",  96 ),
            new SunburstModel ( "UK", "Technical", "Developers",  55 ),
            new SunburstModel ( "UK", "HR Executives",  60 ),
            new SunburstModel ( "UK", "Accounts",  45 )
        };
    }    
}

{% endhighlight %} 

{% endtabs %} 

### Binding the ViewModel

Set the `SunburstViewModel` instance as the `BindingContext` of your page to bind the `SunburstViewModel` properties to the chart.

N> Add the namespace of the `SunburstViewModel` class to your XAML Page, if you prefer to set `BindingContext` in XAML.

{% tabs %} 

{% highlight xaml %} 

<ContentPage
    . . .
    xmlns:sunburst="clr-namespace:Syncfusion.Maui.SunburstChart;assembly=Syncfusion.Maui.SunburstChart"
    xmlns:model="clr-namespace:SunburstGettingStarted">

    <ContentPage.BindingContext>
        <model:SunburstViewModel></model:SunburstViewModel>
    </ContentPage.BindingContext>

</ContentPage>

{% endhighlight %}

{% highlight C# %} 

this.BindingContext = new ViewModel();

{% endhighlight %}

{% endtabs %} 

## Step 6: Add Data Binding to the Chart

 Bind `DataSource` to the Sunburst chart [ItemsSource](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SunburstChart.SfSunburstChart.html#Syncfusion_Maui_SunburstChart_SfSunburstChart_ItemsSource) property from its BindingContext to create your Sunburst chart.
 Then, add the [SunburstHierarchicalLevel](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SunburstChart.SunburstHierarchicalLevel.html) to [Levels](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SunburstChart.SfSunburstChart.html#Syncfusion_Maui_SunburstChart_SfSunburstChart_Levels) collection. Each hierarchy level is formed based on the property specified in the [GroupMemberPath](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SunburstChart.SunburstHierarchicalLevel.html#Syncfusion_Maui_SunburstChart_SunburstHierarchicalLevel_GroupMemberPath) property, and each arc segment size is calculated using the [ValueMemberPath](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SunburstChart.SfSunburstChart.html#Syncfusion_Maui_SunburstChart_SfSunburstChart_ValueMemberPath) property.

{% tabs %}   

{% highlight xaml %}
        
<ContentPage
    . . .
    xmlns:sunburst="clr-namespace:Syncfusion.Maui.SunburstChart;assembly=Syncfusion.Maui.SunburstChart"
    xmlns:model="clr-namespace:SunburstGettingStarted>

    <sunburst:SfSunburstChart x:Name="sunburst" 
        ItemsSource="{Binding DataSource}" 
        ValueMemberPath="EmployeesCount">

        <sunburst:SfSunburstChart.Levels>
            <sunburst:SunburstHierarchicalLevel GroupMemberPath="Country"/>
            <sunburst:SunburstHierarchicalLevel GroupMemberPath="JobDescription"/>
            <sunburst:SunburstHierarchicalLevel GroupMemberPath="JobGroup"/>
        </sunburst:SfSunburstChart.Levels>

    </sunburst:SfSunburstChart>
</ContentPage>

{% endhighlight %}

{% highlight C# %}

SfSunburstChart sunburst = new SfSunburstChart();

sunburst.ItemsSource = (new SunburstViewModel()).DataSource;
sunburst.ValueMemberPath = "EmployeesCount";

sunburst.Levels.Add(new SunburstHierarchicalLevel() { GroupMemberPath = "Country" });
sunburst.Levels.Add(new SunburstHierarchicalLevel() { GroupMemberPath = "Country" });
sunburst.Levels.Add(new SunburstHierarchicalLevel() { GroupMemberPath = "JobDescription" });
sunburst.Levels.Add(new SunburstHierarchicalLevel() { GroupMemberPath = "JobGroup" });

this.Content = sunburst;

{% endhighlight %}

{% endtabs %} 

## Step 7: Customize the Chart

### Add a title
The title of the sunburst chart provides quick information to the user about the data being plotted in the    chart. The [Title](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SunburstChart.SfSunburstChart.html#Syncfusion_Maui_SunburstChart_SfSunburstChart_Title) property is used to set title for the sunburst chart as follows.

{% tabs %} 

{% highlight xaml %}

<sunburst:SfSunburstChart>
    <sunburst:SfSunburstChart.Title>
        <Label Text="Employees Count"/>
    </sunburst:SfSunburstChart.Title>
    . . .
</sunburst:SfSunburstChart>

{% endhighlight %}

{% highlight C# %}

SfSunburstChart sunburst = new SfSunburstChart();
sunburst.Title = new Label
{
    Text = "Employees Count"
};

{% endhighlight %}

{% endtabs %}  

### Enable the data labels

The [ShowLabels](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SunburstChart.SfSunburstChart.html#Syncfusion_Maui_SunburstChart_SfSunburstChart_ShowLabels) property of the chart can be used to enable data labels to improve the readability of the sunburst chart. The label visibility is set to `False` by default.

{% tabs %} 

{% highlight xaml %}

<sunburst:SfSunburstChart ShowLabels="True">
    . . .
</sunburst:SfSunburstChart>

{% endhighlight %}

{% highlight C# %}

SfSunburstChart sunburst = new SfSunburstChart();
. . .
sunburst.ShowLabels = true;

{% endhighlight %}

{% endtabs %} 

### Enable a legend

The legend provides information about the data points displayed in the sunburst chart. The [Legend](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SunburstChart.SfSunburstChart.html#Syncfusion_Maui_SunburstChart_SfSunburstChart_Legend) property of the chart enables the [SunburstLegend](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SunburstChart.SunburstLegend.html).

{% tabs %} 

{% highlight xaml %}

<sunburst:SfSunburstChart>
    . . .
    <sunburst:SfSunburstChart.Legend>
        <sunburst:SunburstLegend/>
    </sunburst:SfSunburstChart.Legend>
</sunburst:SfSunburstChart>

{% endhighlight %}

{% highlight C# %}

SfSunburstChart sunburst = new SfSunburstChart();
. . .
sunburst.Legend = new SunburstLegend();

{% endhighlight %}

{% endtabs %} 

### Enable Tooltip

Tooltips are used to display information about a segment when the mouse hovers over it. Enable the tooltips by setting the chart's [EnableTooltip](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SunburstChart.SfSunburstChart.html#Syncfusion_Maui_SunburstChart_SfSunburstChart_EnableTooltip) property to `True`.

{% tabs %} 

{% highlight xaml %}

<sunburst:SfSunburstChart EnableTooltip="True">
    . . .
</sunburst:SfSunburstChart>

{% endhighlight %}

{% highlight C# %}

SfSunburstChart sunburst = new SfSunburstChart();
. . .
sunburst.EnableTooltip = true;

{% endhighlight %}

{% endtabs %}

The following code example gives you the complete code of above configurations.

{% tabs %} 

{% highlight xaml %}

<ContentPage
    . . .
    xmlns:sunburst="clr-namespace:Syncfusion.Maui.SunburstChart;assembly=Syncfusion.Maui.SunburstChart"
    xmlns:model="clr-namespace:SunburstGettingStarted>

    <sunburst:SfSunburstChart 
                ItemsSource="{Binding DataSource}" 
                ShowLabels="True"  EnableTooltip="True"
                ValueMemberPath="EmployeesCount">

        <sunburst:SfSunburstChart.BindingContext>
            <model:SunburstViewModel/>
        </sunburst:SfSunburstChart.BindingContext>

        <sunburst:SfSunburstChart.Title>
            <Label Text="Employees Count"/>
        </sunburst:SfSunburstChart.Title>

        <sunburst:SfSunburstChart.Legend>
            <sunburst:SunburstLegend/>
        </sunburst:SfSunburstChart.Legend> 

        <sunburst:SfSunburstChart.Levels>
            <sunburst:SunburstHierarchicalLevel GroupMemberPath="Country"/>
            <sunburst:SunburstHierarchicalLevel GroupMemberPath="JobDescription"/>
            <sunburst:SunburstHierarchicalLevel GroupMemberPath="JobGroup"/>
        </sunburst:SfSunburstChart.Levels>
    </sunburst:SfSunburstChart>

</ContentPage>
 
{% endhighlight %}

{% highlight C# %}

using Syncfusion.Maui.SunburstChart;
. . .
public partial class MainPage : ContentPage
{   
    public MainPage()
    {
        SfSunburstChart sunburst = new SfSunburstChart();

        sunburst.ItemsSource = (new SunburstViewModel()).DataSource;
        sunburst.ValueMemberPath = "EmployeesCount";

        sunburst.Title = new Label
        {
            Text = "Employees Count"
        };

        sunburst.Legend = new SunburstLegend();

        sunburst.Levels.Add(new SunburstHierarchicalLevel() { GroupMemberPath = "Country" });
        sunburst.Levels.Add(new SunburstHierarchicalLevel() { GroupMemberPath = "Country" });
        sunburst.Levels.Add(new SunburstHierarchicalLevel() { GroupMemberPath = "JobDescription" });
        sunburst.Levels.Add(new SunburstHierarchicalLevel() { GroupMemberPath = "JobGroup" });

        sunburst.EnableTooltip = true;
        sunburst.ShowLabels = true;
        
        this.Content = sunburst;
    }
}

{% endhighlight %}

{% endtabs %}

## Step 8: Running the Application
Press **F5** to build and run the application. Once compiled, the chart will be displayed with the data provided.

The following chart is created as a result of the previous codes.

![Getting started sample in MAUI Sunburst Chart.](Getting_started_image/maui_getting_started_image.png)

Find the complete getting started sample from this [link](https://github.com/SyncfusionExamples/GettingStarted_SunburstChart_MAUI).
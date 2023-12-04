---
layout: post
title: Getting Started with .NET MAUI Sunburst Chart control | Syncfusion
description: Learn here all about getting started with Syncfusion .NET MAUI Sunburst Chart control, its elements, and more.
platform: maui
control: SfSunburstChart
documentation: ug
---

# Getting Started with .NET MAUI Sunburst Chart

This section explains how to populate the sunburst chart with data, a title, data labels, legend, and tooltip, as well as the essential aspects for getting started with the sunburst chart.

## Creating an application using the .NET MAUI Sunburst Chart

1. Create a new .NET MAUI application in Visual Studio.
2. Syncfusion .NET MAUI components are available in [nuget.org](https://www.nuget.org/). To add SfSunburstChart to your project, open the NuGet package manager in Visual Studio, search for Syncfusion.Maui.SunburstChart and then install it.
3. To initialize the control, import the Sunburst Chart namespace.
4. Initialize [SfSunburstChart]().

{% tabs %} 

{% highlight xaml %}

    <ContentPage   
        . . .
        xmlns:sunburst="clr-namespace:Syncfusion.Maui.SunburstChart;assembly=Syncfusion.Maui.SunburstChart">

        <chart:SfSunburstChart/>
    </ContentPage>
 
{% endhighlight %}

{% highlight C# %}

    using Syncfusion.Maui.SunburstChart;
    namespace ChartGettingStarted
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

## Register the handler

Syncfusion.Maui.Core NuGet is a dependent package for all Syncfusion controls of .NET MAUI. In the MauiProgram.cs file, register the handler for Syncfusion core.

{% highlight C# %}

    using Microsoft.Maui;
    using Microsoft.Maui.Hosting;
    using Microsoft.Maui.Controls.Compatibility;
    using Microsoft.Maui.Controls.Hosting;
    using Microsoft.Maui.Controls.Xaml;
    using Syncfusion.Maui.Core.Hosting;

    namespace ChartGettingStarted
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

## Initialize view model

Now, let us define a simple data model that represents a data point in the chart.

{% tabs %}  

{% highlight c# %}

    public class SunburstModel
    {
        public string JobDescription { get; set; }
        public string JobGroup { get; set; }
        public string JobRole { get; set; }
        public double EmployeesCount { get; set; }
        public string Country { get; set; }
    }

{% endhighlight %} 

{% endtabs %} 

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
                    new SunburstModel { Country = "USA", JobDescription = "Sales", JobGroup="Executive", EmployeesCount = 50 },
                    new SunburstModel { Country = "USA", JobDescription = "Sales", JobGroup = "Analyst", EmployeesCount = 40 },
                    new SunburstModel { Country = "USA", JobDescription = "Marketing", EmployeesCount = 40 },
                    new SunburstModel { Country = "USA", JobDescription = "Technical", JobGroup = "Testers", EmployeesCount = 35 },
                    new SunburstModel { Country = "USA", JobDescription = "Technical", JobGroup = "Developers", JobRole = "Windows", EmployeesCount = 175 },
                    new SunburstModel { Country = "USA", JobDescription = "Technical", JobGroup = "Developers", JobRole = "Web", EmployeesCount = 70 },
                    new SunburstModel { Country = "USA", JobDescription = "Management", EmployeesCount = 40 },
                    new SunburstModel { Country = "USA", JobDescription = "Accounts", EmployeesCount = 60 },

                    new SunburstModel { Country = "India", JobDescription = "Technical", JobGroup = "Testers", EmployeesCount = 33 },
                    new SunburstModel { Country = "India", JobDescription = "Technical", JobGroup = "Developers", JobRole = "Windows", EmployeesCount = 125 },
                    new SunburstModel { Country = "India", JobDescription = "Technical", JobGroup = "Developers", JobRole = "Web", EmployeesCount = 60 },
                    new SunburstModel { Country = "India", JobDescription = "HR Executives", EmployeesCount = 70 },
                    new SunburstModel { Country = "India", JobDescription = "Accounts", EmployeesCount = 45 },

                    new SunburstModel { Country = "Germany", JobDescription = "Sales", JobGroup = "Executive", EmployeesCount = 30 },
                    new SunburstModel { Country = "Germany", JobDescription = "Sales", JobGroup = "Analyst", EmployeesCount = 40 },
                    new SunburstModel { Country = "Germany", JobDescription = "Marketing", EmployeesCount = 50 },
                    new SunburstModel { Country = "Germany", JobDescription = "Technical", JobGroup = "Testers", EmployeesCount = 40 },
                    new SunburstModel { Country = "Germany", JobDescription = "Technical", JobGroup = "Developers", JobRole = "Windows", EmployeesCount = 65 },
                    new SunburstModel { Country = "Germany", JobDescription = "Technical", JobGroup = "Developers", JobRole = "Web", EmployeesCount = 27 },
                    new SunburstModel { Country = "Germany", JobDescription = "Management", EmployeesCount = 33 },
                    new SunburstModel { Country = "Germany", JobDescription = "Accounts", EmployeesCount = 55 },

                    new SunburstModel { Country = "UK", JobDescription = "Technical", JobGroup = "Testers", EmployeesCount = 25 },
                    new SunburstModel { Country = "UK", JobDescription = "Technical", JobGroup = "Developers", JobRole = "Windows", EmployeesCount = 96 },
                    new SunburstModel { Country = "UK", JobDescription = "Technical", JobGroup = "Developers", JobRole = "Web", EmployeesCount = 55 },
                    new SunburstModel { Country = "UK", JobDescription = "HR Executives", EmployeesCount = 60 },
                    new SunburstModel { Country = "UK", JobDescription = "Accounts", EmployeesCount = 30 }
                };
            }    
    }

{% endhighlight %} 

{% endtabs %} 

Set the `SunburstViewModel` instance as the `BindingContext` of your page to bind `SunburstViewModel` properties to the chart.

N> Add the namespace of `SunburstViewModel` class to your XAML Page, if you prefer to set `BindingContext` in XAML.

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

## Populate chart with data

 Binding `DataSource` to the Sunburst chart [ItemsSource]() property from its BindingContext to create our own Sunburst chart.
 Then, add the [SunburstHierarchicalLevel]() to [Levels]() collection. Each hierarchy level is formed based on the property specified in [GroupMemberPath]() property, and each arc segment size is calculated using the [ValueMemberPath]() property.

{% tabs %}   

{% highlight xaml %}

    <sunburst:SfSunburstChart x:Name="sunburst" ItemsSource="{Binding DataSource}" 
                                                ValueMemberPath="EmployeesCount">

        <sunburst:SfSunburstChart.Levels>
            <sunburst:SunburstHierarchicalLevel GroupMemberPath="Country"/>
            <sunburst:SunburstHierarchicalLevel GroupMemberPath="JobDescription"/>
            <sunburst:SunburstHierarchicalLevel GroupMemberPath="JobGroup"/>
            <sunburst:SunburstHierarchicalLevel GroupMemberPath="JobRole"/>
        </chart:SfSunburstChart.Levels>

    </chart:SfSunburstChart>

{% endhighlight %}

{% highlight C# %}

    SfSunburstChart sunburst = new SfSunburstChart();
    sunburst.ItemsSource = (new SunburstViewModel()).DataSource;
    sunburst.ValueMemberPath = "EmployeesCount";
    sunburst.Levels.Add(new SunburstHierarchicalLevel() { GroupMemberPath = "Country" });
    sunburst.Levels.Add(new SunburstHierarchicalLevel() { GroupMemberPath = "Country" });
    sunburst.Levels.Add(new SunburstHierarchicalLevel() { GroupMemberPath = "JobDescription" });
    sunburst.Levels.Add(new SunburstHierarchicalLevel() { GroupMemberPath = "JobGroup" });
    sunburst.Levels.Add(new SunburstHierarchicalLevel() { GroupMemberPath = "JobRole" });
    this.Content = sunburst;

{% endhighlight %}

{% endtabs %} 

## Add a title
The title of the chart provide quick information to the user about the data being plotted in the chart. The [Title]() property is used to set title for the sunburst chart as follows.

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

## Enable the data labels

The [ShowLabels]() property of the chart can be used to enable data labels to improve the readability of the sunburst chart. The label visibility is set to `False` by default.

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

## Enable a legend

The legend provides information about the data point displayed in the sunburst chart. The [Legend]() property of the chart was used to enable it.

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

    SfSunburstChart chsunburstart = new SfSunburstChart();
    . . .
    sunburst.Legend = new SunburstLegend();

{% endhighlight %}

{% endtabs %} 

## Enable Tooltip

Tooltips are used to show information about the segment, when mouse hovers on it. Enable tooltip by setting the chart [EnableTooltip]() property as true.

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

    <sunburst:SfSunburstChart ItemsSource="{Binding DataSource}" 
                              ShowLabels="True" 
                              EnableTooltip="True"
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
                <sunburst:SunburstHierarchicalLevel GroupMemberPath="JobRole"/>
            </sunburst:SfSunburstChart.Levels>

    </sunburst:SfSunburstChart>
 
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
            sunburst.Title = new Label
            {
                Text = "Employees Count"
            };
            sunburst.Legend = new SunburstLegend();
            sunburst.ValueMemberPath = "EmployeesCount";
            sunburst.Levels.Add(new SunburstHierarchicalLevel() { GroupMemberPath = "Country" });
            sunburst.Levels.Add(new SunburstHierarchicalLevel() { GroupMemberPath = "Country" });
            sunburst.Levels.Add(new SunburstHierarchicalLevel() { GroupMemberPath = "JobDescription" });
            sunburst.Levels.Add(new SunburstHierarchicalLevel() { GroupMemberPath = "JobGroup" });
            sunburst.Levels.Add(new SunburstHierarchicalLevel() { GroupMemberPath = "JobRole" });
            sunburst.EnableTooltip = true;
            sunburst.ShowLabels = true;
            this.Content = sunburst;
        }
    }

{% endhighlight %}

{% endtabs %}

You can find the complete getting started sample from this [link]().
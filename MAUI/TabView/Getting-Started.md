---
layout: post
title: Getting started with .NET MAUI Tab View (SfTabView) | Syncfusion
description: Learn here all about getting started with Syncfusion .NET MAUI Tab View (SfTabView) control, its elements and more.
platform: maui
control: Tab View
documentation: ug
---

# Getting Started with .NET MAUI Tab View (SfTabView)

This section explains the steps required to configure the .NET MAUI Tab View control and customize its elements.

## Adding a SfTabView reference

Syncfusion .NET MAUI controls are available in [Nuget.org](https://www.nuget.org/). To add [SfTabView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TabView.SfTabView.html?tabs=tabid-1) to your project, open the NuGet package manager in Visual Studio, search for [Syncfusion.Maui.TabView](https://www.nuget.org/packages/Syncfusion.Maui.TabView/) and then install it.

## Handler registration 

The [Syncfusion.Maui.Core](https://www.nuget.org/packages/Syncfusion.Maui.Core/) NuGet is a dependent package for all Syncfusion controls of .NET MAUI. In the MauiProgram.cs file, register the handler for Syncfusion core.

{% highlight C# %}

using Microsoft.Maui;
using Microsoft.Maui.Hosting;
using Microsoft.Maui.Controls.Compatibility;
using Microsoft.Maui.Controls.Hosting;
using Microsoft.Maui.Controls.Xaml;
`using Syncfusion.Maui.Core.Hosting;`

namespace TabViewMauiSample
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
            .UseMauiApp<App>()
            .`ConfigureSyncfusionCore()`
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
            });

            return builder.Build();
        }
    }
}

{% endhighlight %} 

## Create a simple Tab View

This section explains how to create a Tab View and configure it. The control can be configured entirely in C# code or by the XAML markup.

### Creating the project

Create a new .NET MAUI application in Visual Studio 

### Adding a SfTabView control

Step 1: Add the NuGet to the project as discussed in the above reference section. 

Step 2: Add the namespace as shown in the following code sample.

{% tabs %}

{% highlight xaml %}

xmlns:tabView="clr-namespace:Syncfusion.Maui.TabView;assembly=Syncfusion.Maui.TabView"
	
{% endhighlight %}

{% highlight C# %}

using Syncfusion.Maui.TabView;

{% endhighlight %}

{% endtabs %}

Step 3: Set the control to content in `ContentPage`.

{% tabs %}

{% highlight xaml %}

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
            xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
            x:Class="TabViewMauiSample.MainPage"
            xmlns:tabView="clr-namespace:Syncfusion.Maui.TabView;assembly=Syncfusion.Maui.TabView"
            BackgroundColor="{DynamicResource PageBackgroundColor}">
    <ContentPage.Content> 
        <tabView:SfTabView /> 
    </ContentPage.Content>  
</ContentPage>

{% endhighlight %}

{% highlight c# %}

using Syncfusion.Maui.TabView;

namespace TabViewMauiSample  
{  
    public partial class MainPage : ContentPage                  
    {   
        private SfTabView tabView;   
        public MainPage()   
        {   
            InitializeComponent();       
            tabView = new SfTabView();   
            this.Content = tabView;  
        }  
    }  
}  

{% endhighlight %}

{% endtabs %}

## Populate Tab Items

Tab items can be added to the control using the [Items](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TabView.SfTabView.html#Syncfusion_Maui_TabView_SfTabView_ItemsProperty) property of [SfTabView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TabView.SfTabView.html).

{% tabs %}

{% highlight xaml %}

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
            xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
            x:Class="TabViewMauiSample.MainPage"
            xmlns:tabView="clr-namespace:Syncfusion.Maui.TabView;assembly=Syncfusion.Maui.TabView"
            BackgroundColor="{DynamicResource PageBackgroundColor}">
    <ContentPage.Content> 
        <tabView:SfTabView x:Name="tabView">
            <tabView:SfTabView.Items>
                <tabView:SfTabItem Header="Call">
                    <tabView:SfTabItem.Content>
                        <Grid BackgroundColor="Red" />
                    </tabView:SfTabItem.Content>
                </tabView:SfTabItem>

                <tabView:SfTabItem Header="Favorites">
                    <tabView:SfTabItem.Content>
                        <Grid BackgroundColor="Green"/>
                    </tabView:SfTabItem.Content>
                </tabView:SfTabItem>

                <tabView:SfTabItem Header="Contacts">
                    <tabView:SfTabItem.Content>
                        <Grid BackgroundColor="Blue"/>
                    </tabView:SfTabItem.Content>
                </tabView:SfTabItem>
            </tabView:SfTabView.Items>
        </tabView:SfTabView>
    </ContentPage.Content>  
</ContentPage>


{% endhighlight %}

{% highlight C# %}

using Syncfusion.Maui.TabView;

namespace TabViewMauiSample
{
	public partial class TabView : ContentPage
	{
        SfTabView tabView;
		public TabView ()
		{
			InitializeComponent ();
            var tabView = new SfTabView();
            Grid allContactsGrid = new Grid { BackgroundColor = Color.Red };
            Grid favoritesGrid = new Grid { BackgroundColor = Color.Green };
            Grid contactsGrid = new Grid { BackgroundColor = Color.Blue };
            var tabItems = new TabItemCollection
            {
                new SfTabItem()
                {
                    Header = "Call",
                    Content = allContactsGrid
                },
                new SfTabItem()
                {
                    Header = "Favorites",
                    Content = favoritesGrid
                },
                new SfTabItem()
                {
                    Header = "Contacts",
                    Content = contactsGrid
                }
            };

            tabView.Items = tabItems;
            this.Content = tabView;
		}
	}
}

{% endhighlight %}

{% endtabs %}

![Getting_Started](images/Getting_Started.png)

N> View [sample](https://github.com/SyncfusionExamples/maui-tabview-samples/tree/main/TabViewGettingStarted) in GitHub

## Populate ItemsSource

Items can be added to the control using the `ItemsSource` property of [SfTabView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TabView.SfTabView.html).

Objects of any class can be given as items for `SfTabView` by using `ItemsSource`. The views corresponding to the objects can be set using the `HeaderItemTemplate` for the header items and `ContentItemTemplate` for the content.

Create a model class using the TabItems collection property that is initialized with the required number of data objects, as shown in the following code example.

{% tabs %}

{% highlight C# %}

{% include_relative code-snippet/ItemsSource-model.cs %}

{% endhighlight %}

{% endtabs %}

{% tabs %}

{% highlight C# %}

{% include_relative code-snippet/ItemsSource-view-model.cs %}

{% endhighlight %}

{% endtabs %}

The following code example binds the collection to the `ItemsSource` property of `SfTabView`.

{% tabs %}

{% highlight xaml hl_lines="10" %}

{% include_relative code-snippet/tabview-itemssource.xaml %}
  
{% endhighlight %}

{% highlight C# hl_lines="13" %}

{% include_relative code-snippet/tabview-itemssource.cs %}

{% endhighlight %}

{% endtabs %}

### Header item template

By defining the `HeaderItemTemplate` of the `SfTabView`, a custom user interface(UI) can be achieved to display the tab header data items.

{% tabs %}

{% highlight xaml hl_lines="2 6" %}

{% include_relative code-snippet/header-item-template.xaml %}

{% endhighlight %}

{% highlight C# hl_lines="15" %}

{% include_relative code-snippet/header-item-template.cs %}

{% endhighlight %}

{% endtabs %}

### Content item template

By defining the `ContentItemTemplate` of the `SfTabView`, a custom user interface(UI) can be achieved to display the tab content data items.

{% tabs %}

{% highlight xaml  hl_lines="7 11" %}

{% include_relative code-snippet/tabview-content-item-template.xaml %}
    
{% endhighlight %}

{% highlight C#  hl_lines="21" %}q

{% include_relative code-snippet/tabview-content-item-template.cs %}
    
{% endhighlight %}

{% endtabs %}

![Item Template](images/ItemTemplate.png)


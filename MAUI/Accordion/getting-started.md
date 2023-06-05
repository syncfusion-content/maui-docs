---
layout: post
title: Getting started | SfAccordion | MAUI | Syncfusion
description: This section described about getting started with MAUI Accordion (SfAccordion) control and more details.
platform: MAUI
control: SfAccordion
documentation: ug
---

# Getting Started with MAUI Accordion (SfAccordion)

The Accordion control allows content to be organized in a vertically stacked list of items that is collapsible, and each item can be expanded to reveal its associated content. This section provides a quick overview for working with the `SfAccordion` for Maui.

## Creating an application using the .NET MAUI Accordion

 1. Create a new .NET MAUI application in Visual Studio.
 2. Syncfusion .NET MAUI components are available on [nuget.org](https://www.nuget.org/). To add SfPopup to your project, open the NuGet package manager in Visual Studio, search for Syncfusion.Maui.Accordion and install it.
 3. Import the control namespace `Syncfusion.Maui.Accordion` in XAML or C# code.
 4. Initialize the `SfAccordion` control.
 
{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

<ContentPage   
    . . .
      xmlns:syncfusion="clr-namespace:Syncfusion.Maui.Accordion;assembly=Syncfusion.Maui.Expander">

    <syncfusion:SfAccordion />
</ContentPage>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

using Syncfusion.Maui.Accordion;
. . .

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        SfAccordion accordion = new SfAccordion();
    }
}

{% endhighlight %}
{% endtabs %}

## Register the handler

The `Syncfusion.Maui.Core` NuGet package is a dependency for all Syncfusion controls in .NET MAUI. In the `MauiProgram.cs` file, you need to register the handler for Syncfusion core.

{% tabs %}
{% highlight c# tabtitle="MauiProgram.cs" hl_lines="4 20" %}
using Microsoft.Maui.Controls.Hosting;
using Microsoft.Maui.Controls.Xaml;
using Microsoft.Maui.Hosting;
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
{% endtabs %}

## Creating the accordion 

This section explains how to create a simple Maui application with `SfAccordion`. The control should be configured entirely in C# code or by using XAML markup. 

* Creating the project.
* Adding accordion to MAUI. 
* Defining accordion items.

### Creating the project

Create a new blank (.NET Standard) application in Visual Studio for Maui. 

### Adding accordion in Maui: 

To add the accordion to your application, follow these steps: 

1. Add required assemblies. 
2. Import the control namespace as `xmlns:syncfusion="clr-namespace:Syncfusion.Maui.Accordion;assembly=Syncfusion.Maui.Expander` in XAML Page. 
3. Create an instance of accordion control and add as content. 

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:local="clr-namespace:GettingStarted"
             x:Class="GettingStarted.MainPage"
             xmlns:syncfusion="clr-namespace:Syncfusion.Maui.Accordion;assembly=Syncfusion.Maui.Expander">
             <ContentPage.Content> 
                <syncfusion:SfAccordion x:Name="accordion"/> 
             </ContentPage.Content>
</ContentPage>
{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

using Syncfusion.Maui.Accordion;

namespace GettingStarted
{
    public partial class MainPage : ContentPage
    {
        SfAccordion accordion;
        public MainPage()
        {            
            InitializeComponent();
            accordion = new SfAccordion();
        }
    }
}

{% endhighlight %}
{% endtabs %}

### Defining accordion items 

`SfAccordion` is a layout control with vertically stacked list of accordion `Items` that comprise of `Header` and `Content`. You can load any View in `Header` and `Content`. Users can expand or collapse the Content view by tapping `Header`. 

Here, Grid is loaded in Header and Content of accordion items.

N> When loading Label as direct children of `Header` or `Content` of `AccordionItem`, then it will lead to an exception. So, load `Label` inside `Grid` to overcome the crash.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:local="clr-namespace:GettingStarted"
             x:Class="GettingStarted.MainPage"
             xmlns:syncfusion="clr-namespace:Syncfusion.Maui.Accordion;assembly=Syncfusion.Maui.Expander">
    <ContentPage.Content>
        <syncfusion:SfAccordion >
            <syncfusion:SfAccordion.Items>
                <syncfusion:AccordionItem>
                    <syncfusion:AccordionItem.Header>
                        <Grid>
                            <Label TextColor="#495F6E" Text="Cheese burger" HeightRequest="50" VerticalTextAlignment="Center"/>
                        </Grid>
                    </syncfusion:AccordionItem.Header>
                    <syncfusion:AccordionItem.Content>
                        <Grid Padding="10,10,10,10" BackgroundColor="#FFFFFF">
                            <Label TextColor="#303030" Text="Hamburger accompanied with melted cheese. The term itself is a portmanteau of the words cheese and hamburger. The cheese is usually sliced, then added a short time before the hamburger finishes cooking to allow it to melt." HeightRequest="50" VerticalTextAlignment="Center"/>
                        </Grid>
                    </syncfusion:AccordionItem.Content>
                </syncfusion:AccordionItem>
                <syncfusion:AccordionItem>
                    <syncfusion:AccordionItem.Header>
                        <Grid>
                            <Label TextColor="#495F6E" Text="Veggie burger" HeightRequest="50" VerticalTextAlignment="Center"/>
                        </Grid>
                    </syncfusion:AccordionItem.Header>
                    <syncfusion:AccordionItem.Content>
                        <Grid Padding="10,10,10,10" BackgroundColor="#FFFFFF">
                            <Label TextColor="#303030" Text="Veggie burger, garden burger, or tofu burger uses a meat analogue, a meat substitute such as tofu, textured vegetable protein, seitan (wheat gluten), Quorn, beans, grains or an assortment of vegetables, which are ground up and formed into patties." HeightRequest="50" VerticalTextAlignment="Center"/>
                        </Grid>
                    </syncfusion:AccordionItem.Content>
                </syncfusion:AccordionItem>
                <syncfusion:AccordionItem>
                    <syncfusion:AccordionItem.Header>
                        <Grid>
                            <Label TextColor="#495F6E" Text="Barbecue burger" HeightRequest="50" VerticalTextAlignment="Center"/>
                        </Grid>
                    </syncfusion:AccordionItem.Header>
                    <syncfusion:AccordionItem.Content>
                        <Grid Padding="10,10,10,10" BackgroundColor="#FFFFFF">
                            <Label TextColor="#303030" Text="Prepared with ground beef, mixed with onions and barbecue sauce, and then grilled. Once the meat has been turned once, barbecue sauce is spread on top and grilled until the sauce caramelizes." HeightRequest="50" VerticalTextAlignment="Center"/>
                        </Grid>
                    </syncfusion:AccordionItem.Content>
                </syncfusion:AccordionItem>
                <syncfusion:AccordionItem>
                    <syncfusion:AccordionItem.Header>
                        <Grid>
                            <Label TextColor="#495F6E" Text="Chili burger" HeightRequest="50" VerticalTextAlignment="Center"/>
                        </Grid>
                    </syncfusion:AccordionItem.Header>
                    <syncfusion:AccordionItem.Content>
                        <Grid Padding="10,10,10,10" BackgroundColor="#FFFFFF">
                            <Label TextColor="#303030" Text="Consists of a hamburger, with the patty topped with chili con carne." HeightRequest="50" VerticalTextAlignment="Center"/>
                        </Grid>
                    </syncfusion:AccordionItem.Content>
                </syncfusion:AccordionItem>
            </syncfusion:SfAccordion.Items>
        </syncfusion:SfAccordion> 
    </ContentPage.Content>  
</ContentPage>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}
using Syncfusion.Maui.Accordion;

namespace GettingStarted;

public partial class MainPage : ContentPage
{
    SfAccordion accordion;
	public MainPage()
	{
		InitializeComponent();
        accordion = new SfAccordion();
        CreateAccordionItem();
        this.Content = accordion;
    }

    private void CreateAccordionItem()
    {
        var accordionItem = new AccordionItem();
        var headerGrid = new Grid()
        {
            new Label(){ Text="Cheese burger", HeightRequest=50, VerticalTextAlignment=TextAlignment.Center, TextColor=Color.FromArgb("#495F6E") }
        };
        accordionItem.Header = headerGrid;

        var contentGrid = new Grid()
        {
            new Label(){ Text="Hamburger accompanied with melted cheese. The term itself is a portmanteau of the words cheese and hamburger. The cheese is usually sliced, then added a short time before the hamburger finishes cooking to allow it to melt.", HeightRequest=50, VerticalTextAlignment=TextAlignment.Center, TextColor=Color.FromArgb("#303030") }
        };
        contentGrid.Padding = new Thickness(10);
        contentGrid.BackgroundColor = Color.FromArgb("#FFFFFF");
        accordionItem.Content = contentGrid;

        var accordionItem1 = new AccordionItem();
        var headerGrid1 = new Grid()
        {
            new Label(){ Text="Veggie burger", HeightRequest=50, VerticalTextAlignment=TextAlignment.Center, TextColor=Color.FromArgb("#495F6E") }
        };
        accordionItem1.Header = headerGrid1;

        var contentGrid1 = new Grid()
        {
            new Label(){ Text="Veggie burger, garden burger, or tofu burger uses a meat analogue, a meat substitute such as tofu, textured vegetable protein, seitan (wheat gluten), Quorn, beans, grains or an assortment of vegetables, which are ground up and formed into patties.", HeightRequest=50, VerticalTextAlignment=TextAlignment.Center, TextColor=Color.FromArgb("#303030") }
        };
        contentGrid1.Padding = new Thickness(10);
        contentGrid1.BackgroundColor = Color.FromArgb("#FFFFFF");
        accordionItem1.Content = contentGrid1;

        var accordionItem2 = new AccordionItem();
        var headerGrid2 = new Grid()
        {
            new Label(){ Text="Barbecue burger", HeightRequest=50, VerticalTextAlignment=TextAlignment.Center, TextColor=Color.FromArgb("#495F6E") }
        };
        accordionItem2.Header = headerGrid2;

        var contentGrid2 = new Grid()
        {
            new Label(){ Text="Prepared with ground beef, mixed with onions and barbecue sauce, and then grilled. Once the meat has been turned once, barbecue sauce is spread on top and grilled until the sauce caramelizes.", HeightRequest=50, VerticalTextAlignment=TextAlignment.Center, TextColor=Color.FromArgb("#303030") }
        };
        contentGrid2.Padding = new Thickness(10);
        contentGrid2.BackgroundColor = Color.FromArgb("#FFFFFF");
        accordionItem2.Content = contentGrid2;

        var accordionItem3 = new AccordionItem();
        var headerGrid3 = new Grid()
        {
            new Label(){ Text="Chili burger", HeightRequest=50, VerticalTextAlignment=TextAlignment.Center, TextColor=Color.FromArgb("#495F6E") }
        };
        accordionItem3.Header = headerGrid3;

        var contentGrid3 = new Grid()
        {
            new Label(){ Text="Consists of a hamburger, with the patty topped with chili con carne.", HeightRequest=50, VerticalTextAlignment=TextAlignment.Center, TextColor=Color.FromArgb("#303030") }
        };
        contentGrid3.Padding = new Thickness(10);
        contentGrid3.BackgroundColor = Color.FromArgb("#FFFFFF");
        accordionItem3.Content = contentGrid3;

        accordion.Items.Add(accordionItem);
        accordion.Items.Add(accordionItem1);
        accordion.Items.Add(accordionItem2);
        accordion.Items.Add(accordionItem3);
    }
}
{% endhighlight %}
{% endtabs %}

Now, run the application to render the following output.

![Defining accordion items](Images/getting-started//maui-accordion-with-defining-accordion-items.png)

N> When adding the template control inside the `StackLayout` or `Grid` with a height set to `Auto`, the child element will not receive the height changes at runtime. Since the `SfAccordion` is a template-based control, the default height value cannot be determined. Therefore, it is recommended to provide the `HorizontalOptions` and `VerticalOptions` as `FillAndExpand` options for the control.

## Animation duration

The `SfAccordion`allows you to customize the expanding and collapsing of accordion items by using the `AnimationDuration` property. By default, the animation duration is set to `250 milliseconds`. 

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
    <syncfusion:SfAccordion x:Name="accordion" AnimationDuration="150" /> 
{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}
    accordion.AnimationDuration = 150;
{% endhighlight %}
{% endtabs %}

## Animation easing

The `SfAccordion` allows you to customize the rate of change of a parameter over time or the animation style of an accordion item by using the `AnimationEasing` property. By default, the animation easing is set to `Linear`.  

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
         <syncfusion:SfAccordion x:Name="accordion" AnimationEasing="SinOut" />        
{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}
    accordion.AnimationEasing = Syncfusion.Maui.Expander.AnimationEasing.SinOut;
{% endhighlight %}
{% endtabs %}

## Auto scroll position

The `SfAccordion` allows you to customize the scroll position of the expanded accordion item using the `AutoScrollPosition` property.  By default, the auto scroll position is set to `MakeVisible`.  

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
    <syncfusion:SfAccordion x:Name="accordion" AutoScrollPosition="Top"/>    
{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}
    accordion.AutoScrollPosition = Syncfusion.Maui.Accordion.AutoScrollPosition.Top;
{% endhighlight %}
{% endtabs %}

## Expand mode

The `SfAccordion` allows you to expand single or multiple items by using the `ExpandMode` property. By default, the expand mode is set to `Single`.  

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
    <syncfusion:SfAccordion x:Name="accordion" ExpandMode="Multiple" />         
{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}
    accordion.ExpandMode = Syncfusion.Maui.Accordion.ExpandMode.Multiple;
{% endhighlight %}
{% endtabs %}

## Item spacing

The `SfAccordion` allows you to customize the vertical spacing between the accordion items by using the `ItemSpacing` property. The default value is `6.0d`. 

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
    <syncfusion:SfAccordion x:Name="accordion" ItemSpacing="8.0d" />        
{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}
    accordion.ItemSpacing = 8.0d;
{% endhighlight %}
{% endtabs %}
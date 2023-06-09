---
layout: post
title: Getting started | SfAccordion | MAUI | Syncfusion
description: This section describes getting started with MAUI Accordion (SfAccordion) control and more details.
platform: MAUI
control: SfAccordion
documentation: ug
---

# Getting Started with MAUI Accordion (SfAccordion)

This section provides a quick overview of how to get started with the .NET Maui Accordion (SfAccordion) for Maui. Walk-through the entire process of creating the real world SfAccordion.

## Creating an application using the .NET MAUI Accordion

 1. Create a new .NET MAUI application in Visual Studio.
 2. Syncfusion .NET MAUI components are available on [nuget.org](https://www.nuget.org/). To add SfPopup to your project, open the NuGet package manager in Visual Studio, search for `Syncfusion.Maui.Expander` and install it.
 3. Import the control namespace `Syncfusion.Maui.Accordion` in XAML or C# code.
 4. Initialize the `SfAccordion` control.
 
{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="6" %}

<ContentPage   
    . . .
      xmlns:syncfusion="clr-namespace:Syncfusion.Maui.Accordion;assembly=Syncfusion.Maui.Expander">

    <syncfusion:SfAccordion />
</ContentPage>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="10" %}

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
3. Create an instance of accordion control and add it as content. 

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="9" %}

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
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="12" %}

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

The `SfAccordion` is a layout control with a vertically stacked list of accordion `Items` that comprise of the `Header` and `Content`.Load any View in the `Header` and `Content`. Users can expand or collapse the Content view by tapping `Header`. 

Here, the Grid is loaded in the Header and Content of accordion items.

N> When loading Label as direct children of `Header` or `Content` of `AccordionItem`, then it will lead to an exception. So, load `Label` inside `Grid` to overcome the crash.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="10" %}

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
                        <Grid  HeightRequest="48">
                            <Label Text="Robin Rane" Margin="16,14,0,14" CharacterSpacing="0.25" FontFamily="Roboto-Regular"  FontSize="14" />
                        </Grid>
                    </syncfusion:AccordionItem.Header>
                    <syncfusion:AccordionItem.Content>
                        <Grid ColumnSpacing="10" RowSpacing="2" BackgroundColor="#f4f4f4"  >
                            <Grid Margin="16,6,0,0">
                                <Grid.Resources>
                                    <Style TargetType="Label">
                                        <Setter Property="FontFamily" Value="Roboto-Regular"/>
                                    </Style>
                                </Grid.Resources>
                                <Grid.RowDefinitions >
                                    <RowDefinition Height="25"/>
                                    <RowDefinition Height="25"/>
                                    <RowDefinition Height="25"/>
                                    <RowDefinition Height="25"/>
                                    <RowDefinition Height="{OnPlatform Default=90,Android=90,WinUI=70, iOS=100,MacCatalyst=70 }"/>
                                    <RowDefinition Height="Auto"/>
                                </Grid.RowDefinitions>
                                <Grid.ColumnDefinitions>
                                    <ColumnDefinition Width="100"/>
                                    <ColumnDefinition Width="100"/>
                                    <ColumnDefinition Width="*"/>
                                </Grid.ColumnDefinitions>
                                <Frame  Grid.RowSpan="4" BorderColor="Transparent" Grid.Row="0" Grid.Column="0"  Padding="0" Margin="0,0,0,7">
                                    <Image  Source="emp_01.png"/>
                                </Frame>
                                <Label Text="Position" Grid.Column="1" Grid.Row="0" Margin="6,0,0,0"/>
                                <Label Text="Chairman" Grid.Row="0" Grid.Column="2"/>
                                <Label Text="Organization " Grid.Row="1" Grid.Column="1" Margin="6,0,0,0"/>
                                <Label Text="ABC Inc." Grid.Row="1" Grid.Column="2"/>
                                <Label Text="Date Of Birth " Grid.Row="2" Grid.Column="1" Margin="6,0,0,0"/>
                                <Label Text="09/17/1973" Grid.Row="2" Grid.Column="2"/>
                                <Label Text="Location " Grid.Row="3" Grid.Column="1" Margin="6,0,0,0"/>
                                <Label Text="Boston" Grid.Row="3" Grid.Column="2"/>
                                <Label Padding="0,10,0,10" Grid.Row="4" Grid.ColumnSpan="3"  LineBreakMode="WordWrap"  
                                            FontSize="14" CharacterSpacing="0.25" VerticalTextAlignment="Center" 
                                                Text="Robin Rane, Chairman of ABC Inc., leads with dedication and vision.Under his guidance, the company thrives and continues to make a significant impact in the industry.">
                                </Label>
                                <StackLayout Grid.Row="5" Orientation="Horizontal" Margin="0,0,0,12">
                                    <Label Text="&#xe700;" FontSize="16" Margin="0,2,2,2"
                                                   FontFamily='{OnPlatform Android=AccordionFontIcons.ttf#,WinUI=AccordionFontIcons.ttf#AccordionFontIcons,MacCatalyst=AccordionFontIcons,iOS=AccordionFontIcons}'
                                                   VerticalOptions="Center" VerticalTextAlignment="Center"/>
                                    <Label Text="(617) 555-1234" Grid.Column="1" VerticalOptions="Center" CharacterSpacing="0.25" FontSize="14"/>
                                </StackLayout>
                            </Grid>
                        </Grid>
                    </syncfusion:AccordionItem.Content>
                </syncfusion:AccordionItem>
                ..........................
            </syncfusion:SfAccordion.Items>
        </syncfusion:SfAccordion>
    </ContentPage.Content>
</ContentPage>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="97" %}
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
            new Label(){ Text = "Robin Rane", Margin = new Thickness(16,14,0,14), CharacterSpacing = 0.25, FontFamily = "Roboto-Regular", FontSize = 14 }
        };
        headerGrid.HeightRequest = 48;
        accordionItem.Header = headerGrid;

        var content = new Grid();
        content.ColumnSpacing = 10;
        content.RowSpacing = 2;
        content.BackgroundColor = Color.FromArgb("#f4f4f4");
        var contentGrid = new Grid();
        contentGrid.Margin = new Thickness(16, 6, 0, 0);
        contentGrid.RowDefinitions.Add(new RowDefinition() { Height = 25 });
        contentGrid.RowDefinitions.Add(new RowDefinition() { Height = 25 });
        contentGrid.RowDefinitions.Add(new RowDefinition() { Height = 25 });
        contentGrid.RowDefinitions.Add(new RowDefinition() { Height = 25 });
        contentGrid.RowDefinitions.Add(new RowDefinition() { Height = DeviceInfo.Platform == DevicePlatform.WinUI || DeviceInfo.Platform == DevicePlatform.MacCatalyst ? 70 : DeviceInfo.Platform == DevicePlatform.Android ? 90 : DeviceInfo.Platform == DevicePlatform.iOS ? 100 : 90 });
        contentGrid.RowDefinitions.Add(new RowDefinition() { Height = GridLength.Auto });
        contentGrid.ColumnDefinitions.Add(new ColumnDefinition() { Width = 100 });
        contentGrid.ColumnDefinitions.Add(new ColumnDefinition() { Width = 100 });
        contentGrid.ColumnDefinitions.Add(new ColumnDefinition() { Width = GridLength.Star });
        var image = new Image() { Source = "emp_01.png" };
        var frame = new Frame() { BorderColor = Colors.Transparent, Padding = 0, Margin = new Thickness(0, 0, 0, 7)};
        frame.Content = image;
        contentGrid.SetRowSpan(frame, 4);
        contentGrid.SetRow(frame, 0);
        contentGrid.SetColumn(frame, 0);
        contentGrid.Children.Add(frame);
        var position = new Label() { Text = "Position", Margin = new Thickness(6, 0, 0, 0) };
        contentGrid.SetColumn(position, 1);
        contentGrid.SetRow(position, 0);
        contentGrid.Children.Add(position);
        var positionVal = new Label() { Text = "Chairman" };
        contentGrid.SetColumn(positionVal, 2);
        contentGrid.SetRow(positionVal, 0);
        contentGrid.Children.Add(positionVal);
        var organization = new Label() { Text = "Organization", Margin = new Thickness(6, 0, 0, 0) };
        contentGrid.SetColumn(organization, 1);
        contentGrid.SetRow(organization, 1);
        contentGrid.Children.Add(organization);
        var organizationVal = new Label() { Text = "ABC Inc." };
        contentGrid.SetColumn(organizationVal, 2);
        contentGrid.SetRow(organizationVal, 1);
        contentGrid.Children.Add(organizationVal);
        var dob = new Label() { Text = "Date Of Birth", Margin = new Thickness(6, 0, 0, 0) };
        contentGrid.SetColumn(dob, 1);
        contentGrid.SetRow(dob, 2);
        contentGrid.Children.Add(dob);
        var dobVal = new Label() { Text = "09/17/1973" };
        contentGrid.SetColumn(dobVal, 2);
        contentGrid.SetRow(dobVal, 2);
        contentGrid.Children.Add(dobVal);
        var location = new Label() { Text = "Location", Margin = new Thickness(6, 0, 0, 0) };
        contentGrid.SetColumn(location, 1);
        contentGrid.SetRow(location, 3);
        contentGrid.Children.Add(location);
        var locationVal = new Label() { Text = "Boston" };
        contentGrid.SetColumn(locationVal, 2);
        contentGrid.SetRow(locationVal, 3);
        contentGrid.Children.Add(locationVal);
        var description = new Label() { Text = "Robin Rane, Chairman of ABC Inc., leads with dedication and vision.Under his guidance, the company thrives and continues to make a significant impact in the industry.", Padding = new Thickness(0, 10, 0, 10), LineBreakMode = LineBreakMode.WordWrap, FontSize = 14, CharacterSpacing = 0.25, VerticalTextAlignment = TextAlignment.Center };
        contentGrid.SetRow(description, 4);
        contentGrid.SetColumnSpan(description, 3);
        contentGrid.Children.Add(description);
        var stack = new StackLayout()
        {

            new Label() { Text="\ue700", FontSize=16, Margin = new Thickness(0,2,2,2), VerticalOptions = LayoutOptions.Center, VerticalTextAlignment = TextAlignment.Center,
                                                   FontFamily = DeviceInfo.Platform == DevicePlatform.WinUI ? "AccordionFontIcons.ttf#AccordionFontIcons" : DeviceInfo.Platform == DevicePlatform.Android ? "AccordionFontIcons.ttf#" : DeviceInfo.Platform == DevicePlatform.iOS ? "AccordionFontIcons" : "AccordionFontIcons"},
            new Label(){ Text = "(617) 555-1234", CharacterSpacing = 0.25, FontSize = 14, VerticalOptions = LayoutOptions.Center}
        };
        stack.Orientation = StackOrientation.Horizontal;
        stack.Margin = new Thickness(0, 0, 0, 12);
        contentGrid.SetRow(stack, 5);
        contentGrid.Children.Add(stack);
        content.Children.Add(contentGrid);
        accordionItem.Content = contentGrid;
        accordion.Items.Add(accordionItem);
        ...................................
    }
}
{% endhighlight %}
{% endtabs %}

Now, run the application to render the following output.

![Defining accordion items](Images/getting-started//maui-accordion-with-defining-accordion-items.png)

N> When adding the template control inside the `StackLayout` or `Grid` with a height set to `Auto`, the child element will not receive the height changes at runtime. Since the `SfAccordion` is a template-based control, the default height value cannot be determined. Therefore, it is recommended to provide the `HorizontalOptions` and `VerticalOptions` as `FillAndExpand` options for the control.

## Animation duration

The `SfAccordion` allows you to customize the expanding and collapsing of accordion items by using the `AnimationDuration` property. By default, the animation duration is set to `250 milliseconds`. 

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}
    <syncfusion:SfAccordion x:Name="accordion" 
                            AnimationDuration="150" /> 
{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="1" %}
    accordion.AnimationDuration = 150;
{% endhighlight %}
{% endtabs %}

## Animation easing

The `SfAccordion` allows you to customize the rate of change of a parameter over time or the animation style of an accordion item by using the `AnimationEasing` property. By default, the animation easing is set to `Linear`.  

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}
         <syncfusion:SfAccordion x:Name="accordion"
                                AnimationEasing="SinOut" />
{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="1" %}
    accordion.AnimationEasing = Syncfusion.Maui.Expander.AnimationEasing.SinOut;
{% endhighlight %}
{% endtabs %}

## Auto scroll position

The `SfAccordion` allows you to customize the scroll position of the expanded accordion item using the `AutoScrollPosition` property. By default, the auto-scroll position is set to `MakeVisible`.  

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}
    <syncfusion:SfAccordion x:Name="accordion"
                             AutoScrollPosition="Top"/>
{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="1" %}
    accordion.AutoScrollPosition = Syncfusion.Maui.Accordion.AutoScrollPosition.Top;
{% endhighlight %}
{% endtabs %}

## Expand mode

The `SfAccordion` allows you to expand single or multiple items using the `ExpandMode` property. By default, the expanded mode is set to `Single`.  

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}
    <syncfusion:SfAccordion x:Name="accordion" 
                            ExpandMode="Multiple" />
{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="1" %}
    accordion.ExpandMode = Syncfusion.Maui.Accordion.ExpandMode.Multiple;
{% endhighlight %}
{% endtabs %}

## Item spacing

The `SfAccordion` allows you to customize the vertical spacing between the accordion items by using the `ItemSpacing` property. The default value is `6.0d`. 

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}
    <syncfusion:SfAccordion x:Name="accordion" 
                            ItemSpacing="8.0d" />
{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="1" %}
    accordion.ItemSpacing = 8.0d;
{% endhighlight %}
{% endtabs %}
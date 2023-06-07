---
layout: post
title: Getting started | SfAccordion | MAUI | Syncfusion
description: This section describes getting started with MAUI Accordion (SfAccordion) control and more details.
platform: MAUI
control: SfAccordion
documentation: ug
---

# Getting Started with MAUI Accordion (SfAccordion)

The Accordion control allows content to be organized in a vertically stacked list of items that is collapsible, and each item can be expanded to reveal its associated content. This section provides a quick overview for working with the `SfAccordion` for Maui.

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

The `SfAccordion` is a layout control with a vertically stacked list of accordion `Items` that comprise of the `Header` and `Content`.  Load any View in the `Header` and `Content`. Users can expand or collapse the Content view by tapping `Header`. 

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
                <syncfusion:AccordionItem>
                    <syncfusion:AccordionItem.Header>
                        <Grid  HeightRequest="48">
                            <Label Text="Paul Vent" Margin="16,14,0,14" CharacterSpacing="0.25" FontFamily="Roboto-Regular"  FontSize="14" />
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
                                    <Image  Source="emp_02.png"/>
                                </Frame>
                                <Label Text="Position" Grid.Column="1" Grid.Row="0" Margin="6,0,0,0"/>
                                <Label Text="General Manager" Grid.Row="0" Grid.Column="2"/>
                                <Label Text="Organization " Grid.Row="1" Grid.Column="1" Margin="6,0,0,0"/>
                                <Label Text="XYZ Corp." Grid.Row="1" Grid.Column="2"/>
                                <Label Text="Date Of Birth " Grid.Row="2" Grid.Column="1" Margin="6,0,0,0"/>
                                <Label Text="05/27/1985" Grid.Row="2" Grid.Column="2"/>
                                <Label Text="Location " Grid.Row="3" Grid.Column="1" Margin="6,0,0,0"/>
                                <Label Text="New York" Grid.Row="3" Grid.Column="2"/>
                                <Label Padding="0,10,0,10" Grid.Row="4" Grid.ColumnSpan="3"  LineBreakMode="WordWrap"  
                                            FontSize="14" CharacterSpacing="0.25" VerticalTextAlignment="Center" 
                                                Text="Paul Vent, General Manager of XYZ Corp., oversees daily operations, ensuring the company's success and growth through strategic planning and effective management practices.">
                                </Label>
                                <StackLayout Grid.Row="5" Orientation="Horizontal" Margin="0,0,0,12">
                                    <Label Text="&#xe700;" FontSize="16" Margin="0,2,2,2"
                                                   FontFamily='{OnPlatform Android=AccordionFontIcons.ttf#,WinUI=AccordionFontIcons.ttf#AccordionFontIcons,MacCatalyst=AccordionFontIcons,iOS=AccordionFontIcons}'
                                                   VerticalOptions="Center" VerticalTextAlignment="Center"/>
                                    <Label Text="(212) 555-1234" Grid.Column="1" VerticalOptions="Center" CharacterSpacing="0.25" FontSize="14"/>
                                </StackLayout>
                            </Grid>
                        </Grid>
                    </syncfusion:AccordionItem.Content>
                </syncfusion:AccordionItem>
                <syncfusion:AccordionItem>
                    <syncfusion:AccordionItem.Header>
                        <Grid  HeightRequest="48">
                            <Label Text="Clara Venus" Margin="16,14,0,14" CharacterSpacing="0.25" FontFamily="Roboto-Regular"  FontSize="14" />
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
                                    <Image  Source="emp_03.png"/>
                                </Frame>
                                <Label Text="Position" Grid.Column="1" Grid.Row="0" Margin="6,0,0,0"/>
                                <Label Text="Assistant Manager" Grid.Row="0" Grid.Column="2"/>
                                <Label Text="Organization " Grid.Row="1" Grid.Column="1" Margin="6,0,0,0"/>
                                <Label Text="ABC Inc." Grid.Row="1" Grid.Column="2"/>
                                <Label Text="Date Of Birth " Grid.Row="2" Grid.Column="1" Margin="6,0,0,0"/>
                                <Label Text="07/22/1988" Grid.Row="2" Grid.Column="2"/>
                                <Label Text="Location " Grid.Row="3" Grid.Column="1" Margin="6,0,0,0"/>
                                <Label Text="California" Grid.Row="3" Grid.Column="2"/>
                                <Label Padding="0,10,0,10" Grid.Row="4" Grid.ColumnSpan="3"  LineBreakMode="WordWrap"  
                                            FontSize="14" CharacterSpacing="0.25" VerticalTextAlignment="Center" 
                                                Text="Clara Venus, Asst. Manager at ABC Inc., efficiently handles multiple tasks. With her strong skill set and dedication, she contributes significantly to the company's growth and success.">
                                </Label>
                                <StackLayout Grid.Row="5" Orientation="Horizontal" Margin="0,0,0,12">
                                    <Label Text="&#xe700;" FontSize="16" Margin="0,2,2,2"
                                                   FontFamily='{OnPlatform Android=AccordionFontIcons.ttf#,WinUI=AccordionFontIcons.ttf#AccordionFontIcons,MacCatalyst=AccordionFontIcons,iOS=AccordionFontIcons}'
                                                   VerticalOptions="Center" VerticalTextAlignment="Center"/>
                                    <Label Text="(415) 123-4567" Grid.Column="1" VerticalOptions="Center" CharacterSpacing="0.25" FontSize="14"/>
                                </StackLayout>
                            </Grid>
                        </Grid>
                    </syncfusion:AccordionItem.Content>
                </syncfusion:AccordionItem>
                <syncfusion:AccordionItem>
                    <syncfusion:AccordionItem.Header>
                        <Grid  HeightRequest="48">
                            <Label Text="Maria Even" Margin="16,14,0,14" CharacterSpacing="0.25" FontFamily="Roboto-Regular"  FontSize="14" />
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
                                    <Image  Source="emp_04.png"/>
                                </Frame>
                                <Label Text="Position" Grid.Column="1" Grid.Row="0" Margin="6,0,0,0"/>
                                <Label Text="Executive Manager" Grid.Row="0" Grid.Column="2"/>
                                <Label Text="Organization " Grid.Row="1" Grid.Column="1" Margin="6,0,0,0"/>
                                <Label Text="XYZ Corp." Grid.Row="1" Grid.Column="2"/>
                                <Label Text="Date Of Birth " Grid.Row="2" Grid.Column="1" Margin="6,0,0,0"/>
                                <Label Text="04/16/1970" Grid.Row="2" Grid.Column="2"/>
                                <Label Text="Location " Grid.Row="3" Grid.Column="1" Margin="6,0,0,0"/>
                                <Label Text="New York" Grid.Row="3" Grid.Column="2"/>
                                <Label Padding="0,10,0,10" Grid.Row="4" Grid.ColumnSpan="3"  LineBreakMode="WordWrap"  
                                            FontSize="14" CharacterSpacing="0.25" VerticalTextAlignment="Center" 
                                                Text="Maria Even, a highly experienced professional, holds the position of Executive Manager at XYZ Corp. She oversees crucial operations, enforcing company policies and practices.">
                                </Label>
                                <StackLayout Grid.Row="5" Orientation="Horizontal" Margin="0,0,0,12">
                                    <Label Text="&#xe700;" FontSize="16" Margin="0,2,2,2"
                                                   FontFamily='{OnPlatform Android=AccordionFontIcons.ttf#,WinUI=AccordionFontIcons.ttf#AccordionFontIcons,MacCatalyst=AccordionFontIcons,iOS=AccordionFontIcons}'
                                                   VerticalOptions="Center" VerticalTextAlignment="Center"/>
                                    <Label Text="(516) 345-6789" Grid.Column="1" VerticalOptions="Center" CharacterSpacing="0.25" FontSize="14"/>
                                </StackLayout>
                            </Grid>
                        </Grid>
                    </syncfusion:AccordionItem.Content>
                </syncfusion:AccordionItem>
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

        var accordionItem1 = new AccordionItem();
        var headerGrid1 = new Grid()
        {
            new Label(){ Text = "Paul Vent", Margin = new Thickness(16,14,0,14), CharacterSpacing = 0.25, FontFamily = "Roboto-Regular", FontSize = 14 }
        };
        headerGrid1.HeightRequest = 48;
        accordionItem1.Header = headerGrid1;

        var content1 = new Grid();
        content1.ColumnSpacing = 10;
        content1.RowSpacing = 2;
        content1.BackgroundColor = Color.FromArgb("#f4f4f4");
        var contentGrid1 = new Grid();
        contentGrid1.Margin = new Thickness(16, 6, 0, 0);
        contentGrid1.RowDefinitions.Add(new RowDefinition() { Height = 25 });
        contentGrid1.RowDefinitions.Add(new RowDefinition() { Height = 25 });
        contentGrid1.RowDefinitions.Add(new RowDefinition() { Height = 25 });
        contentGrid1.RowDefinitions.Add(new RowDefinition() { Height = 25 });
        contentGrid1.RowDefinitions.Add(new RowDefinition() { Height = DeviceInfo.Platform == DevicePlatform.WinUI || DeviceInfo.Platform == DevicePlatform.MacCatalyst ? 70 : DeviceInfo.Platform == DevicePlatform.Android ? 90 : DeviceInfo.Platform == DevicePlatform.iOS ? 100 : 90 });
        contentGrid1.RowDefinitions.Add(new RowDefinition() { Height = GridLength.Auto });
        contentGrid1.ColumnDefinitions.Add(new ColumnDefinition() { Width = 100 });
        contentGrid1.ColumnDefinitions.Add(new ColumnDefinition() { Width = 100 });
        contentGrid1.ColumnDefinitions.Add(new ColumnDefinition() { Width = GridLength.Star });
        var image1 = new Image() { Source = "emp_02.png" };
        var frame1 = new Frame() { BorderColor = Colors.Transparent, Padding = 0, Margin = new Thickness(0, 0, 0, 7) };
        frame1.Content = image1;
        contentGrid1.SetRowSpan(frame1, 4);
        contentGrid1.SetRow(frame1, 0);
        contentGrid1.SetColumn(frame1, 0);
        contentGrid1.Children.Add(frame1);
        var position1 = new Label() { Text = "Position", Margin = new Thickness(6, 0, 0, 0) };
        contentGrid1.SetColumn(position1, 1);
        contentGrid1.SetRow(position1, 0);
        contentGrid1.Children.Add(position1);
        var positionVal1 = new Label() { Text = "General Manager" };
        contentGrid1.SetColumn(positionVal1, 2);
        contentGrid1.SetRow(positionVal1, 0);
        contentGrid1.Children.Add(positionVal1);
        var organization1 = new Label() { Text = "Organization", Margin = new Thickness(6, 0, 0, 0) };
        contentGrid1.SetColumn(organization1, 1);
        contentGrid1.SetRow(organization1, 1);
        contentGrid1.Children.Add(organization1);
        var organizationVal1 = new Label() { Text = "XYZ Corp." };
        contentGrid1.SetColumn(organizationVal1, 2);
        contentGrid1.SetRow(organizationVal1, 1);
        contentGrid1.Children.Add(organizationVal1);
        var dob1 = new Label() { Text = "Date Of Birth", Margin = new Thickness(6, 0, 0, 0) };
        contentGrid1.SetColumn(dob1, 1);
        contentGrid1.SetRow(dob1, 2);
        contentGrid1.Children.Add(dob1);
        var dobVal1 = new Label() { Text = "05/27/1985" };
        contentGrid1.SetColumn(dobVal1, 2);
        contentGrid1.SetRow(dobVal1, 2);
        contentGrid1.Children.Add(dobVal1);
        var location1 = new Label() { Text = "Location", Margin = new Thickness(6, 0, 0, 0) };
        contentGrid1.SetColumn(location1, 1);
        contentGrid1.SetRow(location1, 3);
        contentGrid1.Children.Add(location1);
        var locationVal1 = new Label() { Text = "New York" };
        contentGrid1.SetColumn(locationVal1, 2);
        contentGrid1.SetRow(locationVal1, 3);
        contentGrid1.Children.Add(locationVal1);
        var description1 = new Label() { Text = "Paul Vent, General Manager of XYZ Corp., oversees daily operations, ensuring the company's success and growth through strategic planning and effective management practices.", Padding = new Thickness(0, 10, 0, 10), LineBreakMode = LineBreakMode.WordWrap, FontSize = 14, CharacterSpacing = 0.25, VerticalTextAlignment = TextAlignment.Center };
        contentGrid1.SetRow(description1, 4);
        contentGrid1.SetColumnSpan(description1, 3);
        contentGrid1.Children.Add(description1);
        var stack1 = new StackLayout()
        {

            new Label() { Text="\ue700", FontSize=16, Margin = new Thickness(0,2,2,2), VerticalOptions = LayoutOptions.Center, VerticalTextAlignment = TextAlignment.Center,
                                                   FontFamily = DeviceInfo.Platform == DevicePlatform.WinUI ? "AccordionFontIcons.ttf#AccordionFontIcons" : DeviceInfo.Platform == DevicePlatform.Android ? "AccordionFontIcons.ttf#" : DeviceInfo.Platform == DevicePlatform.iOS ? "AccordionFontIcons" : "AccordionFontIcons"},
            new Label(){ Text = "(212) 555-1234", CharacterSpacing = 0.25, FontSize = 14, VerticalOptions = LayoutOptions.Center}
        };
        stack1.Orientation = StackOrientation.Horizontal;
        stack1.Margin = new Thickness(0, 0, 0, 12);
        contentGrid1.SetRow(stack1, 5);
        contentGrid1.Children.Add(stack1);
        content1.Children.Add(contentGrid1);
        accordionItem1.Content = contentGrid1;
        accordion.Items.Add(accordionItem1);

        var accordionItem2 = new AccordionItem();
        var headerGrid2 = new Grid()
        {
            new Label(){ Text = "Clara Venus", Margin = new Thickness(16,14,0,14), CharacterSpacing = 0.25, FontFamily = "Roboto-Regular", FontSize = 14 }
        };
        headerGrid2.HeightRequest = 48;
        accordionItem2.Header = headerGrid2;

        var content2 = new Grid();
        content2.ColumnSpacing = 10;
        content2.RowSpacing = 2;
        content2.BackgroundColor = Color.FromArgb("#f4f4f4");
        var contentGrid2 = new Grid();
        contentGrid2.Margin = new Thickness(16, 6, 0, 0);
        contentGrid2.RowDefinitions.Add(new RowDefinition() { Height = 25 });
        contentGrid2.RowDefinitions.Add(new RowDefinition() { Height = 25 });
        contentGrid2.RowDefinitions.Add(new RowDefinition() { Height = 25 });
        contentGrid2.RowDefinitions.Add(new RowDefinition() { Height = 25 });
        contentGrid2.RowDefinitions.Add(new RowDefinition() { Height = DeviceInfo.Platform == DevicePlatform.WinUI || DeviceInfo.Platform == DevicePlatform.MacCatalyst ? 70 : DeviceInfo.Platform == DevicePlatform.Android ? 90 : DeviceInfo.Platform == DevicePlatform.iOS ? 100 : 90 });
        contentGrid2.RowDefinitions.Add(new RowDefinition() { Height = GridLength.Auto });
        contentGrid2.ColumnDefinitions.Add(new ColumnDefinition() { Width = 100 });
        contentGrid2.ColumnDefinitions.Add(new ColumnDefinition() { Width = 100 });
        contentGrid2.ColumnDefinitions.Add(new ColumnDefinition() { Width = GridLength.Star });
        var image2 = new Image() { Source = "emp_03.png" };
        var frame2 = new Frame() { BorderColor = Colors.Transparent, Padding = 0, Margin = new Thickness(0, 0, 0, 7) };
        frame2.Content = image2;
        contentGrid2.SetRowSpan(frame2, 4);
        contentGrid2.SetRow(frame2, 0);
        contentGrid2.SetColumn(frame2, 0);
        contentGrid2.Children.Add(frame2);
        var position2 = new Label() { Text = "Position", Margin = new Thickness(6, 0, 0, 0) };
        contentGrid2.SetColumn(position2, 1);
        contentGrid2.SetRow(position2, 0);
        contentGrid2.Children.Add(position2);
        var positionVal2 = new Label() { Text = "Assistant Manager" };
        contentGrid2.SetColumn(positionVal2, 2);
        contentGrid2.SetRow(positionVal2, 0);
        contentGrid2.Children.Add(positionVal2);
        var organization2 = new Label() { Text = "Organization", Margin = new Thickness(6, 0, 0, 0) };
        contentGrid2.SetColumn(organization2, 1);
        contentGrid2.SetRow(organization2, 1);
        contentGrid2.Children.Add(organization2);
        var organizationVal2 = new Label() { Text = "ABC Inc." };
        contentGrid2.SetColumn(organizationVal2, 2);
        contentGrid2.SetRow(organizationVal2, 1);
        contentGrid2.Children.Add(organizationVal2);
        var dob2 = new Label() { Text = "Date Of Birth", Margin = new Thickness(6, 0, 0, 0) };
        contentGrid2.SetColumn(dob2, 1);
        contentGrid2.SetRow(dob2, 2);
        contentGrid2.Children.Add(dob2);
        var dobVal2 = new Label() { Text = "07/22/1988" };
        contentGrid2.SetColumn(dobVal2, 2);
        contentGrid2.SetRow(dobVal2, 2);
        contentGrid2.Children.Add(dobVal2);
        var location2 = new Label() { Text = "Location", Margin = new Thickness(6, 0, 0, 0) };
        contentGrid2.SetColumn(location2, 1);
        contentGrid2.SetRow(location2, 3);
        contentGrid2.Children.Add(location2);
        var locationVal2 = new Label() { Text = "California" };
        contentGrid2.SetColumn(locationVal2, 2);
        contentGrid2.SetRow(locationVal2, 3);
        contentGrid2.Children.Add(locationVal2);
        var description2 = new Label() { Text = "Clara Venus, Asst. Manager at ABC Inc., efficiently handles multiple tasks. With her strong skill set and dedication, she contributes significantly to the company's growth and success.", Padding = new Thickness(0, 10, 0, 10), LineBreakMode = LineBreakMode.WordWrap, FontSize = 14, CharacterSpacing = 0.25, VerticalTextAlignment = TextAlignment.Center };
        contentGrid2.SetRow(description2, 4);
        contentGrid2.SetColumnSpan(description2, 3);
        contentGrid2.Children.Add(description2);
        var stack2 = new StackLayout()
        {

            new Label() { Text="\ue700", FontSize=16, Margin = new Thickness(0,2,2,2), VerticalOptions = LayoutOptions.Center, VerticalTextAlignment = TextAlignment.Center,
                                                   FontFamily = DeviceInfo.Platform == DevicePlatform.WinUI ? "AccordionFontIcons.ttf#AccordionFontIcons" : DeviceInfo.Platform == DevicePlatform.Android ? "AccordionFontIcons.ttf#" : DeviceInfo.Platform == DevicePlatform.iOS ? "AccordionFontIcons" : "AccordionFontIcons"},
            new Label(){ Text = "(415) 123-4567", CharacterSpacing = 0.25, FontSize = 14, VerticalOptions = LayoutOptions.Center}
        };
        stack2.Orientation = StackOrientation.Horizontal;
        stack2.Margin = new Thickness(0, 0, 0, 12);
        contentGrid2.SetRow(stack2, 5);
        contentGrid2.Children.Add(stack2);
        content2.Children.Add(contentGrid2);
        accordionItem2.Content = contentGrid2;
        accordion.Items.Add(accordionItem2);

        var accordionItem3 = new AccordionItem();
        var headerGrid3 = new Grid()
        {
            new Label(){ Text = "Maria Even", Margin = new Thickness(16,14,0,14), CharacterSpacing = 0.25, FontFamily = "Roboto-Regular", FontSize = 14 }
        };
        headerGrid3.HeightRequest = 48;
        accordionItem3.Header = headerGrid3;

        var content3 = new Grid();
        content3.ColumnSpacing = 10;
        content3.RowSpacing = 2;
        content3.BackgroundColor = Color.FromArgb("#f4f4f4");
        var contentGrid3 = new Grid();
        contentGrid3.Margin = new Thickness(16, 6, 0, 0);
        contentGrid3.RowDefinitions.Add(new RowDefinition() { Height = 25 });
        contentGrid3.RowDefinitions.Add(new RowDefinition() { Height = 25 });
        contentGrid3.RowDefinitions.Add(new RowDefinition() { Height = 25 });
        contentGrid3.RowDefinitions.Add(new RowDefinition() { Height = 25 });
        contentGrid3.RowDefinitions.Add(new RowDefinition() { Height = DeviceInfo.Platform == DevicePlatform.WinUI || DeviceInfo.Platform == DevicePlatform.MacCatalyst ? 70 : DeviceInfo.Platform == DevicePlatform.Android ? 90 : DeviceInfo.Platform == DevicePlatform.iOS ? 100 : 90 });
        contentGrid3.RowDefinitions.Add(new RowDefinition() { Height = GridLength.Auto });
        contentGrid3.ColumnDefinitions.Add(new ColumnDefinition() { Width = 100 });
        contentGrid3.ColumnDefinitions.Add(new ColumnDefinition() { Width = 100 });
        contentGrid3.ColumnDefinitions.Add(new ColumnDefinition() { Width = GridLength.Star });
        var image3 = new Image() { Source = "emp_04.png" };
        var frame3 = new Frame() { BorderColor = Colors.Transparent, Padding = 0, Margin = new Thickness(0, 0, 0, 7) };
        frame3.Content = image3;
        contentGrid3.SetRowSpan(frame3, 4);
        contentGrid3.SetRow(frame3, 0);
        contentGrid3.SetColumn(frame3, 0);
        contentGrid3.Children.Add(frame3);
        var position3 = new Label() { Text = "Position", Margin = new Thickness(6, 0, 0, 0) };
        contentGrid3.SetColumn(position3, 1);
        contentGrid3.SetRow(position3, 0);
        contentGrid3.Children.Add(position3);
        var positionVal13 = new Label() { Text = "Executive Manager" };
        contentGrid3.SetColumn(positionVal13, 2);
        contentGrid3.SetRow(positionVal13, 0);
        contentGrid3.Children.Add(positionVal13);
        var organization3 = new Label() { Text = "Organization", Margin = new Thickness(6, 0, 0, 0) };
        contentGrid3.SetColumn(organization3, 1);
        contentGrid3.SetRow(organization3, 1);
        contentGrid3.Children.Add(organization3);
        var organizationVal3 = new Label() { Text = "XYZ Corp." };
        contentGrid3.SetColumn(organizationVal3, 2);
        contentGrid3.SetRow(organizationVal3, 1);
        contentGrid3.Children.Add(organizationVal3);
        var dob3 = new Label() { Text = "Date Of Birth", Margin = new Thickness(6, 0, 0, 0) };
        contentGrid3.SetColumn(dob3, 1);
        contentGrid3.SetRow(dob3, 2);
        contentGrid3.Children.Add(dob3);
        var dobVal3 = new Label() { Text = "04/16/1970" };
        contentGrid3.SetColumn(dobVal3, 2);
        contentGrid3.SetRow(dobVal3, 2);
        contentGrid3.Children.Add(dobVal3);
        var location3 = new Label() { Text = "Location", Margin = new Thickness(6, 0, 0, 0) };
        contentGrid3.SetColumn(location3, 1);
        contentGrid3.SetRow(location3, 3);
        contentGrid3.Children.Add(location3);
        var locationVal3 = new Label() { Text = "New York" };
        contentGrid3.SetColumn(locationVal3, 2);
        contentGrid3.SetRow(locationVal3, 3);
        contentGrid3.Children.Add(locationVal3);
        var description3 = new Label() { Text = "Maria Even, a highly experienced professional, holds the position of Executive Manager at XYZ Corp. She oversees crucial operations, enforcing company policies and practices.", Padding = new Thickness(0, 10, 0, 10), LineBreakMode = LineBreakMode.WordWrap, FontSize = 14, CharacterSpacing = 0.25, VerticalTextAlignment = TextAlignment.Center };
        contentGrid3.SetRow(description3, 4);
        contentGrid3.SetColumnSpan(description3, 3);
        contentGrid3.Children.Add(description3);
        var stack3 = new StackLayout()
        {

            new Label() { Text="\ue700", FontSize=16, Margin = new Thickness(0,2,2,2), VerticalOptions = LayoutOptions.Center, VerticalTextAlignment = TextAlignment.Center,
                                                   FontFamily = DeviceInfo.Platform == DevicePlatform.WinUI ? "AccordionFontIcons.ttf#AccordionFontIcons" : DeviceInfo.Platform == DevicePlatform.Android ? "AccordionFontIcons.ttf#" : DeviceInfo.Platform == DevicePlatform.iOS ? "AccordionFontIcons" : "AccordionFontIcons"},
            new Label(){ Text = "(516) 345-6789", CharacterSpacing = 0.25, FontSize = 14, VerticalOptions = LayoutOptions.Center}
        };
        stack3.Orientation = StackOrientation.Horizontal;
        stack3.Margin = new Thickness(0, 0, 0, 12);
        contentGrid3.SetRow(stack3, 5);
        contentGrid3.Children.Add(stack3);
        content3.Children.Add(contentGrid3);
        accordionItem3.Content = contentGrid3;
        accordion.Items.Add(accordionItem3);
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
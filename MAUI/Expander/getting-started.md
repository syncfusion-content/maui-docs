---
layout: post
title: Getting Started with .NET MAUI Expander control | Syncfusion
description: Learn here about getting started with Syncfusion .NET MAUI Expander (SfExpander) control, its elements and more.
platform: MAUI
control: SfExpander
documentation: ug
---

# Getting Started with .NET MAUI Expander (SfExpander)

This section provides a quick overview of how to get started with the SfExpander for .NET MAUI. Walk-through the entire process of creating the real world of this control.

## Creating an application using the .NET MAUI Expander

 1. Create a new .NET MAUI application in Visual Studio.
 2. Syncfusion .NET MAUI components are available on [nuget.org](https://www.nuget.org/). To add SfExpander to your project, open the NuGet package manager in Visual Studio, and search for Syncfusion.Maui.Expander and install it.
 3. Import the control namespace `Syncfusion.Maui.Expander` in XAML or C# code.
 4. Initialize the `SfExpander` control.
 
{% tabs %}
{% highlight xaml %}

<ContentPage   
    . . .
    xmlns:syncfusion="clr-namespace:Syncfusion.Maui.Expander;assembly=Syncfusion.Maui.Expander">

    <syncfusion:SfExpander />
</ContentPage>

{% endhighlight %}
{% highlight c# %}

using Syncfusion.Maui.Expander;
. . .

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        SfExpander expander = new SfExpander();
    }
}

{% endhighlight %}
{% endtabs %}

## Register the handler

The `Syncfusion.Maui.Core` NuGet package is a dependency for all Syncfusion controls in .NET MAUI. In `the MauiProgram.cs` file, register the handler for Syncfusion Core.

{% tabs %}
{% highlight c# hl_lines="4 20" %}
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

### Defining expander 

The `SfExpander` is a layout control comprised of the Header and Content. Load any View in the `Header` and `Content`. Content visibility of the expander can be set by using the `IsExpanded` property of the `Expander`. Users can expand or collapse the Content view by tapping the Header.

Here, the Grid with Labels is loaded in the Header and Content of the expander. 

N> Loading the `Label` as direct children of the `Header` or `Content` of the Expander will lead to an exception. So, load the Label inside the Grid to overcome the crash.

{% tabs %}
{% highlight xaml %}

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:syncfusion="clr-namespace:Syncfusion.Maui.Expander;assembly=Syncfusion.Maui.Expander"
             x:Class="GettingStarted.MainPage">

    <ContentPage.Content>
        <ScrollView >
            <StackLayout  HorizontalOptions="{OnPlatform MacCatalyst=Center,WinUI=Center}"  >
                <Label Text="Invoice: #FRU037020142097"  Opacity="1.0" VerticalTextAlignment="Center" Margin="0,0,0,5" FontAttributes="Bold" VerticalOptions="Center" HorizontalOptions="CenterAndExpand"/>
                <Border StrokeShape="RoundRectangle 8,8,8,8" Margin="{OnPlatform Default='8,0,8,8',WinUI='8,0,6,8',MacCatalyst='8,0,6,8'}" Stroke="#CAC4D0"  StrokeThickness="{OnPlatform MacCatalyst=2,Default=1}" WidthRequest="{OnPlatform MacCatalyst=460,WinUI=340}">
                    <syncfusion:SfExpander AnimationDuration="200" IsExpanded="True" >
                        <syncfusion:SfExpander.Header>
                            <Grid >
                                <Grid.RowDefinitions>
                                    <RowDefinition Height="48"/>
                                </Grid.RowDefinitions>
                                <Grid.ColumnDefinitions>
                                    <ColumnDefinition Width="35"/>
                                    <ColumnDefinition Width="*"/>
                                </Grid.ColumnDefinitions>
                                <Label Text="&#xe703;" FontSize="16" Margin="14,2,2,2"
                                                   FontFamily='{OnPlatform Android=AccordionFontIcons.ttf#,WinUI=AccordionFontIcons.ttf#AccordionFontIcons,MacCatalyst=AccordionFontIcons,iOS=AccordionFontIcons}'
                                                   VerticalOptions="Center" VerticalTextAlignment="Center"/>
                                <Label CharacterSpacing="0.25" FontFamily="Roboto-Regular"  Text="Invoice Date" FontSize="14" Grid.Column="1" VerticalOptions="CenterAndExpand"/>
                            </Grid>
                        </syncfusion:SfExpander.Header>
                        <syncfusion:SfExpander.Content>
                            <Grid Padding="18,8,0,18" >
                                <Label CharacterSpacing="0.25" FontFamily="Roboto-Regular"  Text="11:03 AM, 15 January 2019" FontSize="14" VerticalOptions="CenterAndExpand"/>
                            </Grid>
                        </syncfusion:SfExpander.Content>
                    </syncfusion:SfExpander>
                </Border>
                <Border StrokeShape="RoundRectangle 8,8,8,8" Margin="{OnPlatform Default='8,0,8,8',WinUI='8,0,6,8',MacCatalyst='8,0,6,8'}" Stroke="#CAC4D0"  StrokeThickness="{OnPlatform MacCatalyst=2,Default=1}" WidthRequest="{OnPlatform MacCatalyst=460,WinUI=340}">
                    <syncfusion:SfExpander  AnimationDuration="200" IsExpanded="False">
                        <syncfusion:SfExpander.Header>
                            <Grid>
                                <Grid.RowDefinitions>
                                    <RowDefinition Height="48"/>
                                </Grid.RowDefinitions>
                                <Grid.ColumnDefinitions>
                                    <ColumnDefinition Width="35"/>
                                    <ColumnDefinition Width="*"/>
                                </Grid.ColumnDefinitions>
                                <Label Text="&#xe701;" FontSize="16" Margin="14,2,2,2"
                                                   FontFamily='{OnPlatform Android=AccordionFontIcons.ttf#,WinUI=AccordionFontIcons.ttf#AccordionFontIcons,MacCatalyst=AccordionFontIcons,iOS=AccordionFontIcons}'
                                                   VerticalOptions="Center" VerticalTextAlignment="Center"/>
                                <Label CharacterSpacing="0.25" FontFamily="Roboto-Regular"  Text="Item(s)" FontSize="14" Grid.Column="1" VerticalOptions="CenterAndExpand"/>
                            </Grid>
                        </syncfusion:SfExpander.Header>
                        <syncfusion:SfExpander.Content>
                            <Grid Padding="18,8,18,18">
                                <Grid.RowDefinitions>
                                    <RowDefinition Height="20"/>
                                    <RowDefinition Height="20"/>
                                    <RowDefinition Height="20"/>
                                    <RowDefinition Height="20"/>
                                    <RowDefinition Height="20"/>
                                    <RowDefinition Height="20"/>
                                    <RowDefinition Height="20"/>
                                </Grid.RowDefinitions>
                                <Grid.ColumnDefinitions>
                                    <ColumnDefinition Width="*"/>
                                    <ColumnDefinition Width="*"/>
                                </Grid.ColumnDefinitions>
                                <Label FontSize="14" CharacterSpacing="0.25"  Text="2018 Subaru Outback"/>
                                <Label FontSize="14" CharacterSpacing="0.25"  Text="All-Weather Mats" Grid.Row="1"/>
                                <Label FontSize="14" CharacterSpacing="0.25"  Text="Door Edge Guard Kit" Grid.Row="2"/>
                                <Label FontSize="14" CharacterSpacing="0.25"  Text="Rear Bumper Cover" Grid.Row="3"/>
                                <Label FontSize="14" CharacterSpacing="0.25"  Text="Wheel Locks" Grid.Row="4"/>
                                <Label FontSize="14" CharacterSpacing="0.25"  Text="Gas Full Tank" Grid.Row="5"/>
                                <Label FontSize="14" CharacterSpacing="0.25"  Text="Total Amount" TextColor="{StaticResource Primary}" Grid.Row="6"/>

                                <Label FontSize="14" CharacterSpacing="0.25"  HorizontalOptions="End" Text="$35,705.00" Grid.Row="0" Grid.Column="1"/>
                                <Label FontSize="14" CharacterSpacing="0.25"  HorizontalOptions="End" Text="$101.00" Grid.Row="1" Grid.Column="1"/>
                                <Label FontSize="14" CharacterSpacing="0.25"  HorizontalOptions="End" Text="$162.00" Grid.Row="2" Grid.Column="1"/>
                                <Label FontSize="14" CharacterSpacing="0.25"  HorizontalOptions="End" Text="$107.00" Grid.Row="3" Grid.Column="1"/>
                                <Label FontSize="14" CharacterSpacing="0.25"  HorizontalOptions="End" Text="$81.00" Grid.Row="4" Grid.Column="1"/>
                                <Label FontSize="14" CharacterSpacing="0.25"  HorizontalOptions="End" Text="$64.00" Grid.Row="5" Grid.Column="1"/>
                                <Label FontSize="14" CharacterSpacing="0.25"  HorizontalOptions="End" Text="$36,220.00" TextColor="{StaticResource Primary}" Grid.Row="6" Grid.Column="1"/>
                            </Grid>
                        </syncfusion:SfExpander.Content>
                    </syncfusion:SfExpander>
                </Border>
                <Border StrokeShape="RoundRectangle 8,8,8,8" Margin="{OnPlatform Default='8,0,8,8',WinUI='8,0,6,8',MacCatalyst='8,0,6,8'}" Stroke="#CAC4D0" StrokeThickness="{OnPlatform MacCatalyst=2,Default=1}" WidthRequest="{OnPlatform MacCatalyst=460,WinUI=340}">
                    <syncfusion:SfExpander AnimationDuration="200"  IsExpanded="False">
                        <syncfusion:SfExpander.Header>
                            <Grid>
                                <Grid.RowDefinitions>
                                    <RowDefinition Height="48"/>
                                </Grid.RowDefinitions>
                                <Grid.ColumnDefinitions>
                                    <ColumnDefinition Width="35"/>
                                    <ColumnDefinition Width="*"/>
                                </Grid.ColumnDefinitions>
                                <Label Text="&#xe702;" FontSize="16" Margin="14,2,2,2"
                                                   FontFamily='{OnPlatform Android=AccordionFontIcons.ttf#,WinUI=AccordionFontIcons.ttf#AccordionFontIcons,MacCatalyst=AccordionFontIcons,iOS=AccordionFontIcons}'
                                                   VerticalOptions="Center" VerticalTextAlignment="Center"/>
                                <Label CharacterSpacing="0.25" FontFamily="Roboto-Regular"  Text="Payment Details" FontSize="14" Grid.Column="1" VerticalOptions="CenterAndExpand"/>
                            </Grid>
                        </syncfusion:SfExpander.Header>
                        <syncfusion:SfExpander.Content>
                            <Grid Padding="18,8,18,18"  RowSpacing="6" >
                                <Grid.Resources>
                                    <Style TargetType="Label">
                                        <Setter Property="FontFamily" Value="Roboto-Regular"/>
                                    </Style>
                                </Grid.Resources>
                                <Grid.RowDefinitions>
                                    <RowDefinition Height="20"/>
                                    <RowDefinition Height="20"/>
                                    <RowDefinition Height="20"/>
                                </Grid.RowDefinitions>
                                <Grid.ColumnDefinitions>
                                    <ColumnDefinition Width="*"/>
                                    <ColumnDefinition Width="*"/>
                                </Grid.ColumnDefinitions>
                                <Label FontSize="14" CharacterSpacing="0.25"  Text="Card Payment"/>
                                <Label FontSize="14" CharacterSpacing="0.25"  Text="Third-Party coupons" Grid.Row="1"/>
                                <Label FontSize="14" CharacterSpacing="0.25"  Text="Total Amount Paid" TextColor="{StaticResource Primary}" Grid.Row="2"/>
                                <Label FontSize="14" CharacterSpacing="0.25"  HorizontalOptions="End" Text="$31,200.00" Grid.Column="1"/>
                                <Label FontSize="14" CharacterSpacing="0.25"  HorizontalOptions="End" Text="$5,000.00" Grid.Row="1" Grid.Column="1"/>
                                <Label FontSize="14" CharacterSpacing="0.25"  HorizontalOptions="End" Text="$36,200.00" TextColor="{StaticResource Primary}" Grid.Row="2" Grid.Column="1"/>
                            </Grid>
                        </syncfusion:SfExpander.Content>
                    </syncfusion:SfExpander>
                </Border>
                <Border StrokeShape="RoundRectangle 8,8,8,8" Margin="{OnPlatform Default='8,0,8,8',WinUI='8,0,6,8',MacCatalyst='8,0,6,8'}" Stroke="#CAC4D0" StrokeThickness="{OnPlatform MacCatalyst=2,Default=1}" WidthRequest="{OnPlatform MacCatalyst=460,WinUI=340}">
                    <syncfusion:SfExpander AnimationDuration="200" IsExpanded="True">
                        <syncfusion:SfExpander.Header>
                            <Grid>
                                <Grid.RowDefinitions>
                                    <RowDefinition Height="48"/>
                                </Grid.RowDefinitions>
                                <Grid.ColumnDefinitions>
                                    <ColumnDefinition Width="35"/>
                                    <ColumnDefinition Width="*"/>
                                </Grid.ColumnDefinitions>
                                <Label Text="&#xe704;" FontSize="16" Margin="14,2,2,2"
                                                   FontFamily='{OnPlatform Android=AccordionFontIcons.ttf#,WinUI=AccordionFontIcons.ttf#AccordionFontIcons,MacCatalyst=AccordionFontIcons,iOS=AccordionFontIcons}'
                                                   VerticalOptions="Center" VerticalTextAlignment="Center"/>
                                <Label CharacterSpacing="0.25" FontFamily="Roboto-Regular" FontSize="14" Text="Address" Grid.Column="1" VerticalOptions="CenterAndExpand"/>
                            </Grid>
                        </syncfusion:SfExpander.Header>
                        <syncfusion:SfExpander.Content>
                            <Grid Padding="18,8,18,18" Grid.Row="1" RowSpacing="1">
                                <Grid.Resources>
                                    <Style TargetType="Label">
                                        <Setter Property="FontFamily" Value="Roboto-Regular"/>
                                    </Style>
                                </Grid.Resources>
                                <Grid.RowDefinitions >
                                    <RowDefinition Height="Auto"/>
                                    <RowDefinition Height="Auto"/>
                                    <RowDefinition Height="Auto"/>
                                </Grid.RowDefinitions>
                                <Label CharacterSpacing="0.25"  FontSize="14" Text="Alex" FontAttributes="Bold"/>
                                <Label CharacterSpacing="0.25"  FontSize="14" Text="No.8 Blossom St, Washington, DC 20019" Grid.Row="1"/>
                                <Label CharacterSpacing="0.25"  FontSize="14" Text="(202) 547-3555" Grid.Row="2"/>
                            </Grid>
                        </syncfusion:SfExpander.Content>
                    </syncfusion:SfExpander>
                </Border>
            </StackLayout>
        </ScrollView>
    </ContentPage.Content>
</ContentPage>
{% endhighlight %}
{% endtabs %}

Now, run the application to render the desired output.

![.Net MAUI Expander](Images/maui-expander-with-gettingstarted.png)


## Animation duration

The `SfExpander` allows you to customize the expanding and collapsing duration by using the `AnimationDuration` property. By default, the animation duration is `200 milliseconds`.

{% tabs %}
{% highlight xaml %}
    <syncfusion:SfExpander x:Name="expander" AnimationDuration="250"/>
{% endhighlight %}
{% highlight c# %}
    expander.AnimationDuration = 250;
{% endhighlight %}
{% endtabs %}

## Animation easing

The `SfExpander` allows you to customize the rate of change of parameters over time or animation style by using the `AnimationEasing` property. By default, the animation easing is `Linear`.

{% tabs %}
{% highlight xaml %}
    <syncfusion:SfExpander x:Name="expander" AnimationEasing="SinOut"/>       
{% endhighlight %}
{% highlight c# %}
    expander.AnimationEasing = Syncfusion.Maui.Expander.AnimationEasing.SinOut;
{% endhighlight %}
{% endtabs %}

## Expand and collapse 

The `SfExpander` allows you to programmatically expand and collapse by using the `IsExpanded` property of the SfExpander. The user can control the expand and collapse interactions by handling the `Expanding` and `Collapsing` events.

{% tabs %}
{% highlight xaml %}
    <syncfusion:SfExpander x:Name="expander" IsExpanded="True"/>        
{% endhighlight %}
{% highlight c# %}
    expander.IsExpanded = true;
{% endhighlight %}
{% endtabs %}

### Customize the expander when collapsing or expanding

Customize the expander by using the `Collapsed` event. This event occurs after a `SfExpander` is collapsed when tapping on the header.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<syncfusion:SfExpander x:Name ="expander" Collapsed="Expander_Collapsed">
    <syncfusion:SfExpander.Header>
        <Grid>
            <Label x:Name="label"  Text="Veggie burger" FontSize="Large"/>
        </Grid>
    </syncfusion:SfExpander.Header>
	
    <syncfusion:SfExpander.Content>
        <Grid>
            <Label Text="Veggie burger, garden burger, or tofu burger uses a meat analogue, a meat substitute such as tofu, textured vegetable protein, seitan (wheat gluten), Quorn, beans, grains or an assortment of vegetables, which are ground up and formed into patties."/>
        </Grid>
    </syncfusion:SfExpander.Content>
</syncfusion:SfExpander> 
{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}
private void Expander_Collapsed(object sender, ExpandedAndCollapsedEventArgs e)
{
    label.Text = "Burger and Pizza";
    expander.HeaderBackground = Colors.Aqua;
}
{% endhighlight %}
{% endtabs %}

Customize the expander by using the `Expanded` event. It will occur after a `SfExpander` is expanded when tapping the header.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<syncfusion:SfExpander x:Name ="expander" Expanded="Expander_Expanded">
    <syncfusion:SfExpander.Header>
        <Grid >
            <Label x:Name="label"  Text="Veggie burger" FontSize="Large"/>
        </Grid>
    </syncfusion:SfExpander.Header>
	
    <syncfusion:SfExpander.Content>
        <Grid>
            <Label Text="Veggie burger, garden burger, or tofu burger uses a meat analogue, a meat substitute such as tofu, textured vegetable protein, seitan (wheat gluten), Quorn, beans, grains or an assortment of vegetables, which are ground up and formed into patties."/>
        </Grid>
    </syncfusion:SfExpander.Content>
</syncfusion:SfExpander>
{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}
private void Expander_Expanded(object sender, ExpandedAndCollapsedEventArgs e)
{
    label.Text = "Burger";
    expander.HeaderBackground = Colors.YellowGreen;
}
{% endhighlight %}
{% endtabs %}

### Restricting the expander while expanding and collapsing 

Prevent the Expander from being collapsed by handling the `Collapsing` event. This event occurs when a user attempts to collapse the `SfExpander` by tapping the header. Cancel the user action by setting the `Cancel` property of the `ExpandingAndCollapsingEventArgs`.
{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<syncfusion:SfExpander x:Name ="expander" Collapsing="Expander_Collapsing" >
</syncfusion:SfExpander>
{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}
private void Expander_Collapsing(object sender, ExpandingAndCollapsingEventArgs e)
{
   e.Cancel = true;
}
{% endhighlight %}
{% endtabs %}

Restrict the Expander being expanded by the `Expanding` event. This event occurs when a user tries to expand the `SfExpander` while tapping the header. Cancel the user action using the `Cancel` property of the `ExpandingAndCollapsingEventArgs`.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<syncfusion:SfExpander x:Name ="expander" Expanding="Expander_Expanding" >
</syncfusion:SfExpander>
{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}
private void Expander_Expanding(object sender, ExpandingAndCollapsingEventArgs e)
{
   e.Cancel = true;
}
{% endhighlight %}
{% endtabs %} 


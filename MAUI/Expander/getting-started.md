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

To get start quickly with .NET MAUI Expander, you can check on this video:
<style>#MAUIExpanderVideoTutorial{width : 90% !important; height: 400px !important }</style> <iframe id='MAUIExpanderVideoTutorial' src='https://www.youtube.com/watch?v=zTVbps0m8i0'></iframe>

## Creating an application using the .NET MAUI Expander

 1. Create a new .NET MAUI application in Visual Studio.
 2. Syncfusion .NET MAUI components are available on [nuget.org](https://www.nuget.org/). To add SfExpander to your project, open the NuGet package manager in Visual Studio, and search for Syncfusion.Maui.Expander and install it.
 3. Import the control namespace `Syncfusion.Maui.Expander` in XAML or C# code.
 4. Initialize the `SfExpander` control.
 
{% tabs %}
{% highlight xaml hl_lines="4"%}
<ContentPage   
    . . .
    xmlns:syncfusion="clr-namespace:Syncfusion.Maui.Expander;assembly=Syncfusion.Maui.Expander">
    <syncfusion:SfExpander />
</ContentPage>
{% endhighlight %}

{% highlight c# hl_lines="8"%}
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

## Defining expander 

The [SfExpander](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Expander.SfExpander.html) is a layout control comprised of the Header and Content. Load any View in the [Header](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Expander.SfExpander.html#Syncfusion_Maui_Expander_SfExpander_Header) and [Content](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Expander.SfExpander.html#Syncfusion_Maui_Expander_SfExpander_Content). Content visibility of the expander can be set by using the [IsExpanded](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Expander.SfExpander.html#Syncfusion_Maui_Expander_SfExpander_IsExpanded) property of the `Expander`. Users can expand or collapse the Content view by tapping the Header.

Here, the Grid with Labels is loaded in the Header and Content of the expander. 

N> Loading the `Label` as direct children of the `Header` or `Content` of the Expander will lead to an exception. So, load the Label inside the Grid to overcome the crash.

{% tabs %}
{% highlight xaml hl_lines="11"%}
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

![.NET MAUI Expander](Images/maui-expander-with-gettingstarted.gif)

N> [View Sample in GitHub](https://github.com/SyncfusionExamples/getting-started-with-.net-maui-expander).

## Animation duration

The [SfExpander](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Expander.SfExpander.html) allows you to customize the expanding and collapsing duration by using the [AnimationDuration](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Expander.SfExpander.html#Syncfusion_Maui_Expander_SfExpander_AnimationDuration) property. By default, the animation duration is `200 milliseconds`.

{% tabs %}
{% highlight xaml hl_lines="2" %}
    <syncfusion:SfExpander x:Name="expander" 
                           AnimationDuration="250"/>
{% endhighlight %}
{% highlight c# %}
    expander.AnimationDuration = 250;
{% endhighlight %}
{% endtabs %}

## Animation easing

The [SfExpander](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Expander.SfExpander.html) allows you to customize the rate of change of parameters over time or animation style by using the [AnimationEasing](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Expander.SfExpander.html#Syncfusion_Maui_Expander_SfExpander_AnimationEasing) property. By default, the animation easing is `Linear`.

{% tabs %}
{% highlight xaml hl_lines="2"%}
    <syncfusion:SfExpander x:Name="expander"
                           AnimationEasing="SinOut"/>       
{% endhighlight %}
{% highlight c# %}
    expander.AnimationEasing = ExpanderAnimationEasing.SinOut;
{% endhighlight %}
{% endtabs %}

## Expand and collapse 

The [SfExpander](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Expander.SfExpander.html) allows you to programmatically expand and collapse by using the [IsExpanded](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Expander.SfExpander.html#Syncfusion_Maui_Expander_SfExpander_IsExpanded) property of the SfExpander. The user can control the expand and collapse interactions by handling the `Expanding` and `Collapsing` events.

{% tabs %}
{% highlight xaml hl_lines="2"%}
    <syncfusion:SfExpander x:Name="expander" 
                           IsExpanded="True"/>        
{% endhighlight %}
{% highlight c# %}
    expander.IsExpanded = true;
{% endhighlight %}
{% endtabs %}

## Events 

There are four built-in events in the SfExpander control namely:

* [Expanding](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Expander.SfExpander.html#Syncfusion_Maui_Expander_SfExpander_Expanding)
* [Expanded](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Expander.SfExpander.html#Syncfusion_Maui_Expander_SfExpander_Expanded)
* [Collapsing](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Expander.SfExpander.html#Syncfusion_Maui_Expander_SfExpander_Collapsing)
* [Collapsed](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Expander.SfExpander.html#Syncfusion_Maui_Expander_SfExpander_Collapsed)

### Expanding Event

The [Expanding](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Expander.SfExpander.html#Syncfusion_Maui_Expander_SfExpander_Expanding) event will be triggered when the expander control is being expanded.It can cancel expansion with [ExpandingAndCollapsingEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Expander.ExpandingAndCollapsingEventArgs.html) that contains the following property:

* `Cancel`: Indicates that the expansion or collapse action should be cancelled.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<syncfusion:SfExpander Expanding="SfExpander_Expanding"/>
{% endhighlight %}

{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="3" %}
private void SfExpander_Expanding(object sender, ExpandingAndCollapsingEventArgs e)
{
    e.Cancel = true;
}
{% endhighlight %}
{% endtabs %}

### Expanded Event

The [Expanded](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Expander.SfExpander.html#Syncfusion_Maui_Expander_SfExpander_Expanded) event is triggered when the expander is fully expanded. You can execute your own code when this event occurs.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<syncfusion:SfExpander Expanded="SfExpander_Expanded"/>
{% endhighlight %}

{% highlight c# tabtitle="MainPage.xaml.cs" %}
private void SfExpander_Expanded(object sender, ExpandedAndCollapsedEventArgs e)
{
    // Codes that need to be executed once the expander is expanded.
}
{% endhighlight %}
{% endtabs %}

### Collapsing Event

The [Collapsing](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Expander.SfExpander.html#Syncfusion_Maui_Expander_SfExpander_Collapsing) event will be triggered when the expander control is being collapsed.It can cancel collapsing with [ExpandingAndCollapsingEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Expander.ExpandingAndCollapsingEventArgs.html) that contains the following property:

* `Cancel`: Indicates that the expansion or collapse action should be cancelled.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<syncfusion:SfExpander Collapsing="SfExpander_Collapsing"/>
{% endhighlight %}

{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="3" %}
private void SfExpander_Collapsing(object sender, ExpandingAndCollapsingEventArgs e)
{
    e.Cancel = true;
}
{% endhighlight %}
{% endtabs %}

### Collapsed Event 

The [Collapsed](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Expander.SfExpander.html#Syncfusion_Maui_Expander_SfExpander_Collapsed) event is triggered when the expander is collapsed. You can execute your own code when this event occurs.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<syncfusion:SfExpander Collapsed="SfExpander_Collapsed"/>
{% endhighlight %}

{% highlight c# tabtitle="MainPage.xaml.cs" %}
private void SfExpander_Collapsed(object sender, ExpandedAndCollapsedEventArgs e)
{
    // Codes that need to be executed once the expander is collapsed.
}
{% endhighlight %}
{% endtabs %}
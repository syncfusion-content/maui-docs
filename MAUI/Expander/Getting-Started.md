---
layout: post
title: Getting Started with .NET MAUI Expander control | Syncfusion
description: Learn here about getting started with Syncfusion .NET MAUI Expander (SfExpander) control, its elements and more.
platform: MAUI
control: SfExpander
documentation: ug
---

# Getting Started with .NET MAUI Expander (SfExpander)

The `.NET MAUI Expander` control provides a way to expand and collapse when tapping a header. This section provides a quick overview of working with the `SfExpander` for .NET MAUI. It covers the minimal features that you need to know to get started with the Expander.

## Creating an application using the .NET MAUI Expander

 1. Create a new .NET MAUI application in Visual Studio.
 2. Syncfusion .NET MAUI components are available on [nuget.org](https://www.nuget.org/). To add SfExpander to your project, open the NuGet package manager in Visual Studio, search for Syncfusion.Maui.Expander and install it.
 3. Import the control namespace `Syncfusion.Maui.Expander` in XAML or C# code.
 4. Initialize the `SfExpander` control.
 
{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

<ContentPage   
    . . .
    xmlns:syncfusion="clr-namespace:Syncfusion.Maui.Expander;assembly=Syncfusion.Maui.Expander">

    <syncfusion:SfExpander />
</ContentPage>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

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

### Defining expander 

The `SfExpander` is a layout control comprise of Header and Content. You can load any View in `Header` and `Content`. Content visibility of expander can be set by using the `IsExpanded` property of `Expander`. Users can expand or collapse the Content view by tapping Header.

Here, Grid with Labels are loaded in Header and Content of expander. 

N> When loading `Label` as direct children of `Header` or `Content` of Expander, then it will lead to exception. So, load `Label` inside `Grid` to overcome the crash.

{% tabs %}
{% highlight xaml %}

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:local="clr-namespace:GettingStarted"
             x:Class="GettingStarted.MainPage"
             xmlns:syncfusion="clr-namespace:Syncfusion.Maui.Expander;assembly=Syncfusion.Maui.Expander">
             <ContentPage.Content> 
                <ScrollView BackgroundColor="#EDF2F5" Grid.Row="1"> 
                    <StackLayout> 
                        <syncfusion:SfExpander> 
                            <syncfusion:SfExpander.Header> 
                                <Grid>
                                    <Label TextColor="#495F6E" Text="Veg Pizza" VerticalTextAlignment="Center" /> 
                                </Grid>
                            </syncfusion:SfExpander.Header> 
                            <syncfusion:SfExpander.Content> 
                                <Grid Padding="10,10,10,10" BackgroundColor="#FFFFFF"> 
                                    <Label TextColor="#303030" Text="Veg pizza is prepared with the items that meet vegetarian standards by not including any meat or animal tissue products." HeightRequest="50" VerticalTextAlignment="Center"/> 
                                </Grid> 
                            </syncfusion:SfExpander.Content> 
                        </syncfusion:SfExpander> 
                        <syncfusion:SfExpander> 
                            <syncfusion:SfExpander.Header> 
                                <Grid>
                                    <Label TextColor="#495F6E" Text="Non-veg Pizza" VerticalTextAlignment="Center" /> 
                                </Grid>
                            </syncfusion:SfExpander.Header> 
                            <syncfusion:SfExpander.Content> 
                                <Grid Padding="10,10,10,10" BackgroundColor="#FFFFFF"> 
                                    <Label TextColor="#303030" Text="Non-veg pizza is prepared by including the meat and animal tissue products." HeightRequest="50" VerticalTextAlignment="Center"/> 
                                </Grid> 
                            </syncfusion:SfExpander.Content> 
                        </syncfusion:SfExpander> 
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

The `SfExpander` allows you to customize the rate of change of parameter over time or animation style by using the `AnimationEasing` property. By default, the animation easing is `Linear`. 

{% tabs %}
{% highlight xaml %}
         <syncfusion:SfExpander x:Name="expander" AnimationEasing="SinOut"/>       
{% endhighlight %}
{% highlight c# %}
    expander.AnimationEasing = Syncfusion.Maui.Expander.AnimationEasing.SinOut;
{% endhighlight %}
{% endtabs %}

## Expand and Collapse 

The `SfExpander` allows you to programmatically expand and collapse by using the `IsExpanded` property of SfExpander. The user can control the expand and collapse interactions by handling the `Expanding` and `Collapsing` events.

{% tabs %}
{% highlight xaml %}
    <syncfusion:SfExpander x:Name="expander" IsExpanded="True"/>        
{% endhighlight %}
{% highlight c# %}
    expander.IsExpanded = true;
{% endhighlight %}
{% endtabs %}

### Customize the expander when collapsing or expanding the SfExpander

You can customize the expander by using the `Collapsed` event.This event occurs after a `SfExpander` is collapsed when tapping on the header. It provides information related to the `collapsed` event through the `ExpandedAndCollapsedEventArgs`.

{% tabs %}
{% highlight xaml %}
<syncfusion:SfExpander x:Name ="expander" Collapsed="Expander_Collapsed">
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
{% highlight c# %}
expander.Collapsed += Expander_Collapsed;
            
private void Expander_Collapsed(object sender, ExpandedAndCollapsedEventArgs e)
{
    label.Text = "Burger and Pizza";
    expander.Header.BackgroundColor = Color.Aqua;
}
{% endhighlight %}
{% endtabs %}

You can customize the expander by using the `Expanded` event. It will occur after a `SfExpander` is expanded when tapping on the header. It will provide the information related to the `Expanded` event by using the `ExpandedAndCollapsedEventArgs`.

{% tabs %}
{% highlight xaml %}
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
{% highlight c# %}
expander.Expanded += Expander_Expanded;
            
private void Expander_Expanded(object sender, ExpandedAndCollapsedEventArgs e)
{
    label.Text = "Burger";
    expander.Header.BackgroundColor = Color.YellowGreen;
}
{% endhighlight %}
{% endtabs %}

### Restricting the Expander while expanding and collapsing 

You can prevent the Expander from being collapsed by handling the `Collapsing` event. This event occurs when a user attempts to collapse the `SfExpander` by tapping on the header. You can cancel the user action by setting the `Cancel` property of `ExpandingAndCollapsingEventArgs`.
{% tabs %}
{% highlight xaml %}
<syncfusion:SfExpander x:Name ="expander" Collapsing="Expander_Collapsing" >
</syncfusion:SfExpander>
{% endhighlight %}
{% highlight c# %}
expander.Collapsing += Expander_Collapsing;

private void Expander_Collapsing(object sender, ExpandingAndCollapsingEventArgs e)
{
   e.Cancel = true;
}
{% endhighlight %}
{% endtabs %}

You can restrict the Expander being expanded by the `Expanding` event. This event occurs when an user tries to expand the `SfExpander` while tapping on the header. You can cancel the user action using the `Cancel` property of `ExpandingAndCollapsingEventArgs`.

{% tabs %}
{% highlight xaml %}
<syncfusion:SfExpander x:Name ="expander" Expanding="Expander_Expanding" >
</syncfusion:SfExpander>
{% endhighlight %}
{% highlight c# %}
expander.Expanding += Expander_Expanding;
            
private void Expander_Expanding(object sender, ExpandingAndCollapsingEventArgs e)
{
   e.Cancel = true;
}
{% endhighlight %}
{% endtabs %} 


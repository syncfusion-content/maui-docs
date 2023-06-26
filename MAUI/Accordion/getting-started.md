---
layout: post
title: Getting started | SfAccordion | MAUI | Syncfusion
description: Learn here about getting started with .NET MAUI Accordion (SfAccordion) control, its elements and more.
platform: MAUI
control: SfAccordion
documentation: ug
---

# Getting Started with MAUI Accordion (SfAccordion)

This section provides a quick overview of how to get started with the Accordion (SfAccordion) for .NET MAUI. Walk-through the entire process of creating the real world of this control.

## Creating an application using the .NET MAUI Accordion

 1. Create a new .NET MAUI application in Visual Studio.
 2. Syncfusion .NET MAUI components are available on [nuget.org](https://www.nuget.org/). To add SfPopup to your project, open the NuGet package manager in Visual Studio, search for `Syncfusion.Maui.Expander` and install it.
 3. Import the control namespace `Syncfusion.Maui.Accordion` in XAML or C# code.
 4. Initialize the `SfAccordion` control.
 
{% tabs %}
{% highlight xaml hl_lines="6" %}

<ContentPage   
    . . .
      xmlns:syncfusion="clr-namespace:Syncfusion.Maui.Accordion;assembly=Syncfusion.Maui.Expander">

    <syncfusion:SfAccordion />
</ContentPage>

{% endhighlight %}
{% highlight c# hl_lines="10" %}

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

## Defining accordion items 

The [SfAccordion](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.SfAccordion.html) is a layout control with a vertically stacked list of accordion [Items](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.SfAccordion.html#Syncfusion_Maui_Accordion_SfAccordion_Items) that comprise of the [Header](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.AccordionItem.html#Syncfusion_Maui_Accordion_AccordionItem_Header) and [Content](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.AccordionItem.html#Syncfusion_Maui_Accordion_AccordionItem_Content). You can load any view in the `Header` and `Content` sections. Users can expand or collapse the content view by tapping `Header`. 

Here, the Grid is loaded in the Header and Content of accordion items.

N> When loading Label as direct children of `Header` or `Content` of `AccordionItem`, then it will lead to an exception. So, load `Label` inside `Grid` to overcome the crash.

{% tabs %}
{% highlight xaml hl_lines="10" %}

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
{% endtabs %}

Now, run the application to render the following output.

![.NET MAUI Accordion with items](Images/getting-started/maui-accordion-with-defining-accordion-items.gif)

You can download accordion sample for .NET MAUI [here](https://github.com/SyncfusionExamples/getting-started-with-.net-maui-accordion).

N> When adding the template control inside the `StackLayout` or `Grid` with a height set to `Auto`, the child element will not receive the height changes at runtime. Since the `SfAccordion` is a template-based control, the default height value cannot be determined. Therefore, it is recommended to provide the `HorizontalOptions` and `VerticalOptions` as `FillAndExpand` options for the control.

## Animation duration

The `SfAccordion` allows you to customize the expanding and collapsing duration of accordion items by using the [AnimationDuration](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.SfAccordion.html#Syncfusion_Maui_Accordion_SfAccordion_AnimationDuration) property. By default, the animation duration is set to `200 milliseconds`. 

{% tabs %}
{% highlight xaml hl_lines="2" %}
    <syncfusion:SfAccordion x:Name="accordion" 
                            AnimationDuration="150" /> 
{% endhighlight %}
{% highlight c# %}
    accordion.AnimationDuration = 150;
{% endhighlight %}
{% endtabs %}

## Animation easing

You can customize the rate of change of a parameter over time or the animation style of an accordion item by using the [AnimationEasing](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.SfAccordion.html#Syncfusion_Maui_Accordion_SfAccordion_AnimationEasing) property. By default, the animation easing is set to `Linear`.  

{% tabs %}
{% highlight xaml hl_lines="2" %}
         <syncfusion:SfAccordion x:Name="accordion"
                                AnimationEasing="SinOut" />
{% endhighlight %}
{% highlight c# %}
    accordion.AnimationEasing = ExpanderAnimationEasing.SinOut;
{% endhighlight %}
{% endtabs %}

## Auto scroll position

The `SfAccordion` allows you to customize the scroll position of the expanded accordion item using the [AutoScrollPosition](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.SfAccordion.html#Syncfusion_Maui_Accordion_SfAccordion_AutoScrollPosition) property. By default, the auto-scroll position is set to `MakeVisible`.  

{% tabs %}
{% highlight xaml %}
    <syncfusion:SfAccordion x:Name="accordion"
                             AutoScrollPosition="Top"/>
{% endhighlight %}
{% highlight c# %}
    accordion.AutoScrollPosition = AccordionAutoScrollPosition.Top;
{% endhighlight %}
{% endtabs %}

## Bring an accordion item into view

The `BringIntoView` method is used to bring a specific item into view by scrolling to it programmatically.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<syncfusion:SfAccordion x:Name="accordion">
    <syncfusion:SfAccordion.Items>
        <syncfusion:AccordionItem>
            ...
            ...
        </syncfusion:AccordionItem>
    </syncfusion:SfAccordion.Items>
 </syncfusion:SfAccordion>
{% endhighlight %}

{% highlight c# tabtitle="MainPage.xaml.cs" %}
private void Button_Clicked(object sender, EventArgs e)
{
    accordion.BringIntoView(accordion.Items[15]);
}
{% endhighlight %}
{% endtabs %}

## Expand mode

You can expand single or multiple items using the [ExpandMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.SfAccordion.html#Syncfusion_Maui_Accordion_SfAccordion_ExpandMode) property. By default, the expanded mode is set to `Single`.  

{% tabs %}
{% highlight xaml %}
    <syncfusion:SfAccordion x:Name="accordion" 
                            ExpandMode="Multiple" />
{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="1" %}
    accordion.ExpandMode = AccordionExpandMode.Multiple;
{% endhighlight %}
{% endtabs %}

## Item spacing

The `SfAccordion` allows you to customize the vertical spacing between the accordion items by using the [ItemSpacing](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.SfAccordion.html#Syncfusion_Maui_Accordion_SfAccordion_ItemSpacing) property. 

{% tabs %}
{% highlight xaml %}
    <syncfusion:SfAccordion x:Name="accordion" 
                            ItemSpacing="6.0d" />
{% endhighlight %}
{% highlight c# %}
    accordion.ItemSpacing = 6.0d;
{% endhighlight %}
{% endtabs %}

## Events 

There are four built-in events in the SfAccordion control namely:

* [Expanding](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Accordion.SfAccordion.html#Syncfusion_XForms_Accordion_SfAccordion_Expanding)
* [Expanded](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Accordion.SfAccordion.html#Syncfusion_XForms_Accordion_SfAccordion_Expanded)
* [Collapsing](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Accordion.SfAccordion.html#Syncfusion_XForms_Accordion_SfAccordion_Collapsing)
* [Collapsed](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Accordion.SfAccordion.html#Syncfusion_XForms_Accordion_SfAccordion_Collapsed)

### Expanding Event

The [Expanding](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Accordion.SfAccordion.html#Syncfusion_XForms_Accordion_SfAccordion_Expanding) event will be triggered when the accordion item is being expanded. It can cancel expansion with [ExpandingAndCollapsingEventArgs](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Accordion.ExpandingAndCollapsingEventArgs.html) that contains the following property:

* `Cancel`:Indicates that the expansion or collapse action should be cancelled.
* [Index](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.ExpandingAndCollapsingEventArgs.html#Syncfusion_Maui_Accordion_ExpandingAndCollapsingEventArgs_Index):Gets the index of the current expanding accordion item.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<syncfusion:SfAccordion Expanding="SfAccordion_Expanding">
    <syncfusion:SfAccordion.Items>
        <syncfusion:AccordionItem>
            ...
            ...
        </syncfusion:AccordionItem>
    </syncfusion:SfAccordion.Items>
 </syncfusion:SfAccordion>
{% endhighlight %}

{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="3" %}
private void SfAccordion_Expanding(object sender, Syncfusion.Maui.Accordion.ExpandingAndCollapsingEventArgs e)
{
    if (e.Index == 2)
    {
        e.Cancel = true;
    }
}
{% endhighlight %}
{% endtabs %}

### Expanded Event

The [Expanded](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Accordion.SfAccordion.html#Syncfusion_XForms_Accordion_SfAccordion_Expanded) event is triggered when the accordion item is fully expanded. You can execute your own code when this event occurs.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<syncfusion:SfAccordion Expanded="SfAccordion_Expanded">
    <syncfusion:SfAccordion.Items>
        <syncfusion:AccordionItem>
            ...
            ...
        </syncfusion:AccordionItem>
    </syncfusion:SfAccordion.Items>
 </syncfusion:SfAccordion>
{% endhighlight %}

{% highlight c# tabtitle="MainPage.xaml.cs" %}
private void SfAccordion_Expanded(object sender, Syncfusion.Maui.Accordion.ExpandedAndCollapsedEventArgs e)
{
    // Get the index of current accordion item
    int index = e.Index;
}
{% endhighlight %}
{% endtabs %}

### Collapsing Event

The [Collapsing](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Accordion.SfAccordion.html#Syncfusion_XForms_Accordion_SfAccordion_Collapsing) event will be triggered when the expander control is being collapsed.It can cancel collapsing with [ExpandingAndCollapsingEventArgs](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Accordion.ExpandingAndCollapsingEventArgs.html) that contains the following property:

* `Cancel`: Indicates that the expansion or collapse action should be cancelled.
* [Index](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Accordion.ExpandingAndCollapsingEventArgs.html#Syncfusion_Maui_Accordion_ExpandingAndCollapsingEventArgs_Index):Gets the index of the current collapsing accordion item.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<syncfusion:SfAccordion Collapsing="SfAccordion_Collapsing">
    <syncfusion:SfAccordion.Items>
        <syncfusion:AccordionItem>
            ...
            ...
        </syncfusion:AccordionItem>
    </syncfusion:SfAccordion.Items>
 </syncfusion:SfAccordion>
{% endhighlight %}

{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="3" %}
private void SfAccordion_Collapsing(object sender, Syncfusion.Maui.Accordion.ExpandingAndCollapsingEventArgs e)
{
    if (e.Index == 2)
    {
        e.Cancel = true;
    }
}
{% endhighlight %}
{% endtabs %}

### Collapsed Event 

The [Collapsed](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Accordion.SfAccordion.html#Syncfusion_XForms_Accordion_SfAccordion_Collapsed) event is triggered when the accordion item is collapsed. You can execute your own code when this event occurs.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<syncfusion:SfAccordion Collapsed="SfAccordion_Collapsed">
    <syncfusion:SfAccordion.Items>
        <syncfusion:AccordionItem>
            ...
            ...
        </syncfusion:AccordionItem>
    </syncfusion:SfAccordion.Items>
 </syncfusion:SfAccordion>
{% endhighlight %}

{% highlight c# tabtitle="MainPage.xaml.cs" %}
private void SfAccordion_Collapsed(object sender, Syncfusion.Maui.Accordion.ExpandedAndCollapsedEventArgs e)
{
    // Get the index of current accordion item
    int index = e.Index;
}
{% endhighlight %}
{% endtabs %}

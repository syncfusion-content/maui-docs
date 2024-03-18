---
layout: post
title: Getting Started with .NET MAUI Step ProgressBar Control | Syncfusion
description: Learn here all about getting started with Syncfusion .NET MAUI Step ProgressBar (SfStepProgressBar) control and its basic features.
platform: maui
control: SfStepProgressBar
documentation: ug
---

# Getting started with .NET MAUI Step ProgressBar (SfStepProgressBar)
This section explains how to add the [.NET MAUI Step ProgressBar](https://www.syncfusion.com/maui-controls/maui-stepprogressbar) control. This section covers only the basic features needed to get started with Syncfusion Step ProgressBar.

## Creating an application using the .NET MAUI Step ProgressBar

1. Create a new .NET MAUI application in Visual Studio.

2. Syncfusion .NET MAUI components are available on [nuget.org](https://www.nuget.org/). To add `SfStepProgressBar` to your project, open the NuGet package manager in Visual Studio, search for [Syncfusion.Maui.ProgressBar](https://www.nuget.org/packages/Syncfusion.Maui.ProgressBar), and then install it.

3. To initialize the control, import the control namespace `Syncfusion.Maui.ProgressBar` in XAML or C# code.

4. Initialize `SfStepProgressBar.`

{% tabs %}
{% highlight xaml tabtitle="XAML" hl_lines="3 5" %}

<ContentPage   
    . . .
    xmlns:stepProgressBar="clr-namespace:Syncfusion.Maui.ProgressBar;assembly=Syncfusion.Maui.ProgressBar"

    <stepProgressBar:SfStepProgressBar />
</ContentPage>

{% endhighlight %}
{% highlight c# tabtitle="C#" hl_lines="1 9 10" %}

using Syncfusion.Maui.ProgressBar;
. . .

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        SfStepProgressBar stepProgressBar = new SfStepProgressBar();
        this.Content = stepProgressBar;
    }
}

{% endhighlight %}
{% endtabs %}

## Register the handler

The `Syncfusion.Maui.Core` NuGet is a dependent package for all Syncfusion controls of .NET MAUI. In the `MauiProgram.cs` file, register the handler for Syncfusion core.

{% tabs %}
{% highlight C# tabtitle="MauiProgram.cs" hl_lines="1 10" %}

using Syncfusion.Maui.Core.Hosting;
namespace GettingStarted
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();

            builder.ConfigureSyncfusionCore();
            builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("Segoe-mdl2.ttf", "SegoeMDL2");
            });

            return builder.Build();
        }
    }
}

{% endhighlight %}
{% endtabs %}

## Populating step progressbar items

You can use [ItemsSource](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.StepProgressBarItem.html#Syncfusion_Maui_ProgressBar_StepProgressBarItem_ImageSource) property of SfStepProgressBar to populate the step progressbar items. Hence, you must create a item collection and bind it to the progressbar control.

* Create a simple Observable Collection of the item for the step progressbar,

{% tabs %}
{% highlight c# tabtitle="ViewModel.cs" %}

public class ViewModel
{
    /// <summary>
    /// The Step progress bar item collection.
    /// </summary>
    private ObservableCollection<StepProgressBarItem> stepProgressItem;

    /// <summary>
    /// The Step progress bar item collection.
    /// </summary>
    public ObservableCollection<StepProgressBarItem> StepProgressItem
    {
        get
        {
            return stepProgressItem;
        }
        set
        {
            stepProgressItem = value;
        }
    }

    public ViewModel()
    {
        stepProgressItem = new ObservableCollection<StepProgressBarItem>();
        stepProgressItem.Add(new StepProgressBarItem() { PrimaryText = "Cart" });
        stepProgressItem.Add(new StepProgressBarItem() { PrimaryText = "Address" });
        stepProgressItem.Add(new StepProgressBarItem() { PrimaryText = "Delivery" });
        stepProgressItem.Add(new StepProgressBarItem() { PrimaryText = "Ordered" });
    }
}

{% endhighlight %}
{% endtabs %}

* Bind the Collection to step progressbar

The Step progressbar control allows you to bind item collection by setting the [ItemsSource](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.StepProgressBarItem.html#Syncfusion_Maui_ProgressBar_StepProgressBarItem_ImageSource) property from the [SfStepProgressBar](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.SfStepProgressBar.html). Bind item collection in both XAML and C#.

{% tabs %}
{% highlight xaml tabtitle="XAML" hl_lines="10" %}

<stepProgressBar:SfStepProgressBar
                    x:Name="stepProgress"
                    VerticalOptions="Center"
                    HorizontalOptions="Center"                                        
                    Orientation="Horizontal"                                                                                       
                    LabelSpacing="12"
                    ActiveStepIndex="2"
                    ActiveStepProgressValue="60"
                    ProgressAnimationDuration="2500"
                    ItemsSource="{Binding StepProgressItem}">
</stepProgressBar:SfStepProgressBar>                                                                                             

<ContentPage.BindingContext>
    <local:ViewModel />
</ContentPage.BindingContext>

{% endhighlight %}
{% highlight c# tabtitle="C#" hl_lines="11" %}

ViewModel viewModel = new ViewModel();
SfStepProgressBar stepProgressBar = new SfStepProgressBar()
{
    VerticalOptions = LayoutOptions.Center,
    HorizontalOptions = LayoutOptions.Center,
    Orientation = StepProgressBarOrientation.Horizontal,
    LabelSpacing = 12,
    ActiveStepIndex = 2,
    ActiveStepProgressValue = 60,
    ProgressAnimationDuration = 2500,               
    ItemsSource = viewModel.StepProgressItem,
};

this.Content = stepProgressBar;

{% endhighlight %}
{% endtabs %}

![Getting started of .NET MAUI StepProgressBar](images/getting-started/maui-stepprogressbar-getting-started.gif)

## ActiveStepIndex
The [ActiveStepIndex](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.SfStepProgressBar.html#Syncfusion_Maui_ProgressBar_SfStepProgressBar_ActiveStepIndex) property is used to represent index of the currently active step within the sequence of steps. The [ActiveStepProgressValue](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.SfStepProgressBar.html#Syncfusion_Maui_ProgressBar_SfStepProgressBar_ActiveStepProgressValue) property is used to add the progress value of the currently active step within a sequence.

{% tabs %}
{% highlight xaml tabtitle="XAML" hl_lines="3 4" %}

<stepProgressBar:SfStepProgressBar
                    x:Name="stepProgress"
                    ActiveStepIndex="3"
                    ActiveStepProgressValue="40">
</stepProgressBar:SfStepProgressBar>

{% endhighlight %}
{% highlight c# tabtitle="C#" hl_lines="3 4" %}

SfStepProgressBar stepProgressBar = new SfStepProgressBar()
{
    ActiveStepIndex = 3,
    ActiveStepProgressValue = 40,
};

{% endhighlight %}
{% endtabs %}

N> If `ActiveStepIndex` value is less than 0, first step will be marked as `NotStarted` step status. If `ActiveStepIndex` value is greater than the step count, all the steps will be marked as `Completed` step status.
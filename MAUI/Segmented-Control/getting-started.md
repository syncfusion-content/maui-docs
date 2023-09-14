---
layout: post
title: Getting Started with .NET MAUI Segmented control | Syncfusion
description: Learn about getting started with Syncfusion .NET MAUI Segmented control (SfSegmentedControl) in mobile and desktop applications from a single shared codebase.
platform: .NET MAUI
control: Segmented (SfSegmented) control
documentation: ug
---

# Getting Started with .NET MAUI Segmented Control (SfSegmentedControl)

This section provides a quick overview of how to get started with the `.NET MAUI Segmented control(SfSegmented)` for .NET MAUI and a walk-through to configure the .NET MAUI Segmented control in a real-time scenario.

## Creating an Application Using the .NET MAUI Segmented Control

1. Create a new .NET MAUI application in Visual Studio.

2. Syncfusion .NET MAUI components are available in [nuget.org](https://www.nuget.org/). To add the SfDataForm to your project, open the NuGet package manager in Visual Studio, search for `Syncfusion.Maui.Buttons`, then install it.

3. To initialize the control, import the control namespace `Syncfusion.Maui.Buttons` in XAML or C# code.

4. Initialize `SfSegmentedControl`.


{% tabs %}
{% highlight XAML %}

<ContentPage   
            
        xmlns:buttons="clr-namespace:Syncfusion.Maui.Buttons;assembly=Syncfusion.Maui.Buttons"

        <buttons:SfSegmentedControl />
</ContentPage>

{% endhighlight %}
{% highlight C# %}

using Syncfusion.Maui.Buttons;
. . .

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        SfSegmentedControl segmentedControl = new SfSegmentedControl();
        this.Content = segmentedControl;
    }
}

{% endhighlight %}
{% endtabs %}

## Register the Handler

The [Syncfusion.Maui.Core](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.html) NuGet is a dependent package for all Syncfusion controls of .NET MAUI. In the `MauiProgram.cs` file, register the handler for Syncfusion core.

{% tabs %}
{% highlight C# tabtitle="MauiProgram.cs" hl_lines="1 8" %}

    
    using Syncfusion.Maui.Core.Hosting;
    public static class MauiProgram
    {
	    public static MauiApp CreateMauiApp()
	    {
	        var builder = MauiApp.CreateBuilder();
		    builder
			    .ConfigureSyncfusionCore()
			    .UseMauiApp<App>()
			    .ConfigureFonts(fonts =>
			    {
				    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			    });

		    return builder.Build();
	    }
    }

{% endhighlight %}
{% endtabs %}

## Populating Segmented Items

You can use `ItemsSource` property of `SfSegmentedControl` to populate the segmented items.

{% tabs %}
{% highlight XAML %}

<ContentPage   
    xmlns:buttons="clr-namespace:Syncfusion.Maui.Buttons;assembly=Syncfusion.Maui.Buttons">
    <buttons:SfSegmentedControl x:Name="segmentedControl">
        <buttons:SfSegmentedControl.ItemsSource>
            <x:Array Type="{x:Type x:String}">
                <x:String>Day</x:String>
                <x:String>Week</x:String>
                <x:String>Month</x:String>
                <x:String>Year</x:String>
            </x:Array>
        </buttons:SfSegmentedControl.ItemsSource>
    </buttons:SfSegmentedControl>
</ContentPage>

{% endhighlight %}
{% highlight C# %}

using Syncfusion.Maui.Buttons;
. . .

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        SfSegmentedControl segmentedControl = new SfSegmentedControl();
        List<SfSegmentItem> itemList = new List<SfSegmentItem>
        {
            new SfSegmentItem() {Text = "Day"},
            new SfSegmentItem() {Text = "Week"},
            new SfSegmentItem() {Text = "Month"},
            new SfSegmentItem() {Text = "Year"},
        };
        segmentedControl.ItemsSource = itemList;
        this.Content = segmentedControl;
    }
}

{% endhighlight %}
{% endtabs %}
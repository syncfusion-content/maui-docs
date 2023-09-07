---
layout: post
title: Getting Started with .NET MAUI Segmented control | Syncfusion
description: Learn about getting started with Syncfusion .NET MAUI Segmented (SfSegmented) control in mobile and desktop applications from a single shared codebase.
platform: maui
control: SfSegmentedControl
documentation: ug
---

# Getting Started with .NET MAUI Segmented (SfSegmented) control

This section provides a quick overview of how to get started with the `.NET MAUI Segmented control(SfSegmented)` for .NET MAUI and a walk-through to configure the .NET MAUI Segmented control in a real-time scenario.

## Creating an application using the .NET MAUI Segmented control

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

## Register the handler

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

## Adding items to SfSegmentedControl

You can add the data inside the segmented control in three different ways: 

1. String data
2. SfSegmentItem
3. Custom View

Items inside the segmented control can be added using the `ItemsSource` property of `SfSegmentedControl`, which holds the collection/list of items.

#### Adding data as a String

You can add string data as `ItemsSource` to `SfSegmentedControl`.

{% tabs %}
{% highlight XAML tabtitle="MainPage.xaml" %}

<ContentPage   
            
    xmlns:buttons="clr-namespace:Syncfusion.Maui.Buttons;assembly=Syncfusion.Maui.Buttons"

    <buttons:SfSegmentedControl x:Name="segmentControl">
    </buttons:SfSegmentedControl>
</ContentPage>

{% endhighlight %}
{% highlight C# tabtitle="MainPage.xaml.cs" %}

using Syncfusion.Maui.Buttons;
. . .

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        SfSegmentedControl segmentedControl = new SfSegmentedControl();
        segmentedControl.Stroke = Colors.Black;
        segmentedControl.SelectedIndex = 1;
        segmentedControl.BackgroundColor = Colors.Transparent;
        segmentedControl.VisibleSegmentsCount = 6;
        List<string> list = new List<string>
                {
                    "1","2","3","4","5","6"
                };
        segmentedControl.ItemsSource = list;
        this.Content = segmentedControl;
    }
}

{% endhighlight %}
{% endtabs %}

#### Adding data as SfSegmentItem

You can add `SfSegmentItem` as `ItemsSource` to `SfSegmentedControl`.

{% tabs %}
{% highlight XAML %}

<ContentPage   
    xmlns:local="clr-namespace:SfSegmentSample"
    xmlns:buttons="clr-namespace:Syncfusion.Maui.Buttons;assembly=Syncfusion.Maui.Buttons">

    <ContentPage.BindingContext>
        <local:ViewModel/>
    </ContentPage.BindingContext>

        <buttons:SfSegmentedControl x:Name="segmentControl"
                                    Stroke="Black"
                                    SelectedIndex="1"
                                    BackgroundColor="Transparent"
                                    VisibleSegmentsCount="6"
                                    ItemsSource="{Binding ItemCollection}">
    </buttons:SfSegmentedControl>
</ContentPage>

{% endhighlight %}
{% highlight C# %}

using Syncfusion.Maui.Buttons;
. . .

public partial class MainPage : ContentPage
{
    ObservableCollection<SfSegmentItem> itemList = new ObservableCollection<SfSegmentItem>();

    public MainPage()
    {
        InitializeComponent();
        ViewModel viewModel = new ViewModel();
        SfSegmentedControl segmentedControl = new SfSegmentedControl();
        segmentedControl.Stroke = Colors.Black;
        segmentedControl.SelectedIndex = 1;
        segmentedControl.BackgroundColor = Colors.Transparent;
        segmentedControl.VisibleSegmentsCount = 6;
        segmentedControl.ItemsSource = viewModel.ItemCollection;
        this.Content = segmentedControl;
    }
}

{% endhighlight %}
{% highlight C# tabtitle="ViewModel.cs" %}

public class ViewModel
{
    private ObservableCollection<SfSegmentItem> itemCollection;

    public ViewModel()
    {
        itemCollection = new ObservableCollection<SfSegmentItem>()
        {
                new SfSegmentItem() {Text="Day"},
                new SfSegmentItem() {Text="Week"},
                new SfSegmentItem() {Text="Month"},
                new SfSegmentItem() {Text="Year"},
        };
    }

    public ObservableCollection<SfSegmentItem> ItemCollection
    {
        get { return itemCollection; }
        set { itemCollection = value; }
    }
}

{% endhighlight %}
{% endtabs %}

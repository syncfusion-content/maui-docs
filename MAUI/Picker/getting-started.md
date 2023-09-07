---
layout: post
title: Getting started with .NET MAUI Picker control | Syncfusion
description: Learn here all about getting started with Syncfusion .NET MAUI Picker (SfPicker) control and its basic features.
platform: maui
control: SfPicker
documentation: ug
---

# Getting started with .NET MAUI Picker (SfPicker)
This section explains how to add the Picker control. This section covers only the basic features needed to get started with Syncfusion Picker.

## Creating an application using the .NET MAUI Picker

1. Create a new .NET MAUI application in Visual Studio.

2. Syncfusion .NET MAUI components are available on [nuget.org](https://www.nuget.org/). To add `SfPicker` to your project, open the NuGet package manager in Visual Studio, search for [Syncfusion.Maui.Picker](https://www.nuget.org/packages/Syncfusion.Maui.Picker), and then install it.

3. To initialize the control, import the control namespace `Syncfusion.Maui.Picker` in XAML or C# code.

4. Initialize `SfPicker.`

{% tabs %}
{% highlight xaml tabtitle="XAML" hl_lines="3 5" %}

<ContentPage   
    . . .
    xmlns:picker="clr-namespace:Syncfusion.Maui.Picker;assembly=Syncfusion.Maui.Picker">

    <picker:SfPicker />
</ContentPage>

{% endhighlight %}
{% highlight c# tabtitle="C#" hl_lines="1 9 10" %}

using Syncfusion.Maui.Picker;
. . .

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        SfPicker picker = new SfPicker();
        this.Content = picker;
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

## Set header to the Picker

The SfPicker control allows you to add the header text by setting the [Text] property in the [PickerHeaderView]. To enable the header view by setting the [Height] property in [PickerHeaderView].

{% tabs %}
{% highlight xaml tabtitle="XAML" hl_lines="3" %}

<picker:SfPicker x:Name="picker">
    <picker:SfPicker.HeaderView>
        <picker:PickerHeaderView Text="Select a color" Height="40" />
    </picker:SfPicker.HeaderView>
</picker:SfPicker>

{% endhighlight %}
{% highlight c# tabtitle="C#" hl_lines="4 5" %}

SfPicker picker = new SfPicker();
picker.HeaderView = new PickerHeaderView()
{
    Text = "Select a color",
    Height = 40,
};

this.Content = picker;

{% endhighlight %}
{% endtabs %}

## Add picker items to the picker

The .NET MAUI Picker control is a data bounded control. Hence, you must create collection of data’s and bind it to the picker control.

* Create a simple Observable Collection of data for the picker,

{% tabs %}
{% highlight c# tabtitle="ItemInfo.cs" %}

public class ItemInfo
{
    private ObservableCollection<object> dataSource = new ObservableCollection<object>()
    {
        "Pink", "Green", "Blue", "Yellow", "Orange", "Purple", "SkyBlue", "PaleGreen"
    };

    public ObservableCollection<object> DataSource
    {
        get
        {
            return dataSource;
        }
        set
        {
            dataSource = value;
        }
    }

    public ItemInfo()
    {

    }
}

{% endhighlight %}
{% endtabs %}

* Bind the Collection to picker

Picker control allows you to bind the collection of data by setting the [ItemsSource] property from [PickerColumn]. You can bind the collection of data in both XAML or C#.

{% tabs %}
{% highlight xaml tabtitle="XAML" hl_lines="6 10 11 12" %}

<picker:SfPicker x:Name="picker">
    <picker:SfPicker.HeaderView>
        <picker:PickerHeaderView Text="Select a color" Height="40" />
    </picker:SfPicker.HeaderView>
    <picker:SfPicker.Columns>
        <picker:PickerColumn ItemsSource="{Binding DataSource}" />
    </picker:SfPicker.Columns>
</picker:SfPicker>

<ContentPage.BindingContext>
    <local:ItemInfo />
</ContentPage.BindingContext>

{% endhighlight %}
{% highlight c# tabtitle="C#" hl_lines="1 8" %}

ItemInfo itemInfo = new ItemInfo();
SfPicker picker = new SfPicker()
{
    Columns = new ObservableCollection<PickerColumn>()
    {
        new PickerColumn()
        {
            ItemsSource = itemInfo.DataSource,
        }
    }
};

this.Content = picker;

{% endhighlight %}
{% endtabs %}


## Set footer to the Picker

In SfPicker control, validation buttons (OK and Cancel) can be customized by setting the [OkButtonText] and [CancelButtonText] property in the [PickerFooterView]. It allows you to confirm or cancel the selected item.  The `OkButtonText` can be enabled by using the [ShowOkButton] property in [PickerFooterView].

{% tabs %}
{% highlight xaml tabtitle="XAML" hl_lines="3" %}

<picker:SfPicker x:Name="Picker">
    <picker:SfPicker.FooterView>
        <picker:PickerFooterView ShowOkButton="True" Height="40" />
    </picker:SfPicker.FooterView>
</picker:SfPicker>

{% endhighlight %}
{% highlight c# tabtitle="C#" hl_lines="4 5" %}

SfPicker picker = new SfPicker();
picker.FooterView= new PickerFooterView()
{  
    ShowOkButton = true,
    Height = 40,
};

this.Content = picker;

{% endhighlight %}  
{% endtabs %}

## Set column header to the Picker items

The SfPicker control allows you to the add the column header text by setting the [HeaderText] property in [PickerColumn] and you need to add the column header height by setting the [Height] property in [PickerColumnHeaderView]. Its text style and background color are customizable.

{% tabs %}
{% highlight xaml tabtitle="XAML" hl_lines="7 12" %}

<picker:SfPicker x:Name="picker">
<picker:SfPicker.HeaderView>
    <picker:PickerHeaderView Text="Select a color" Height="40" />
</picker:SfPicker.HeaderView>

<picker:SfPicker.Columns>
    <picker:PickerColumn HeaderText="Colors" 
                         ItemsSource="{Binding DataSource}" />
</picker:SfPicker.Columns>

<picker:SfPicker.ColumnHeaderView>
    <picker:PickerColumnHeaderView Height="40"
                                   Background="#6750A4">
        <picker:PickerColumnHeaderView.TextStyle>
            <picker:PickerTextStyle TextColor="White" FontSize="15" />
        </picker:PickerColumnHeaderView.TextStyle>
    </picker:PickerColumnHeaderView>
</picker:SfPicker.ColumnHeaderView>
</picker:SfPicker>

{% endhighlight %}
{% highlight c# tabtitle="C#" hl_lines="14 21" %}

ItemInfo itemInfo = new ItemInfo();
SfPicker picker = new SfPicker()
{
    HeaderView = new PickerHeaderView()
    {
        Text = "Select a color",
        Height = 50,
    },

    Columns = new ObservableCollection<PickerColumn>()
    {
        new PickerColumn()
        {
            HeaderText = "Colors",
            ItemsSource = itemInfo.DataSource,
        }
    },

    ColumnHeaderView = new PickerColumnHeaderView()
    {
        Height = 40,
        Background = Color.FromRgba("#6750A4"),
        TextStyle = new PickerTextStyle()
        {
            TextColor = Colors.White,
            FontSize = 15,
        },
    },
};

this.Content = picker;

{% endhighlight %}  
{% endtabs %}

## Set height and width to the Picker

The SfPicker control allows you to change the height and width by using the [HeightRequest] and [WidthRequest] property in [SfPicker].

{% tabs %}
{% highlight xaml tabtitle="XAML" hl_lines="2 3" %}

<picker:SfPicker x:Name="Picker" 
                    HeightRequest="280" 
                    WidthRequest="300">
</picker:SfPicker>

{% endhighlight %}
{% highlight c# tabtitle="C#" hl_lines="3 4" %}

SfPicker picker = new SfPicker()
{
    HeightRequest = 280,
    WidthRequest = 300,
};

this.Content = picker;

{% endhighlight %}  
{% endtabs %}
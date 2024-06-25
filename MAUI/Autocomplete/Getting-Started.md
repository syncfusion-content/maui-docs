---
layout: post
title: Getting Started with .NET MAUI Autocomplete | Syncfusion
description: Learn how to get started with Syncfusion .NET MAUI Autocomplete control and its suggestion list, as well as other topics in this section.
platform: maui
control: SfAutocomplete
documentation: ug
---

# Getting Started with .NET MAUI Autocomplete (SfAutocomplete)

This section explains how to add the Autocomplete control and bind data to it. This section covers only the basic features needed to get started with the Syncfusion [Autocomplete](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfAutocomplete.html) control.

To get start quickly with our .NET MAUI Autocomplete, you can check the below video.

{% youtube "https://www.youtube.com/watch?v=ontSh2NZvE4" %}

## Adding a .NET MAUI Autocomplete reference

Syncfusion .NET MAUI controls are available in [Nuget.org](https://www.nuget.org/). To add [.NET MAUI Autocomplete](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfAutocomplete.html) to your project, open the NuGet package manager in Visual Studio, search for [Syncfusion.Maui.Inputs](https://www.nuget.org/packages/Syncfusion.Maui.Inputs) and then install it.

## Handler registration 

 In the MauiProgram.cs file, register the handler for Syncfusion core.

{% highlight c# hl_lines="6 17" %}
using Microsoft.Maui;
using Microsoft.Maui.Hosting;
using Microsoft.Maui.Controls.Compatibility;
using Microsoft.Maui.Controls.Hosting;
using Microsoft.Maui.Controls.Xaml;
using Syncfusion.Maui.Core.Hosting;

namespace AutocompleteSample
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
            .UseMauiApp<App>()
            .ConfigureSyncfusionCore()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
            });

            return builder.Build();
        }      
    }
}   

{% endhighlight %} 

## Create a Simple .NET MAUI Autocomplete

The .NET MAUI Autocomplete control can be configured entirely using C# code or XAML markup. The following steps explain how to create a [.NET MAUI Autocomplete](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfAutocomplete.html) (SfAutocomplete) and configure its elements:

### Adding the .NET MAUI Autocomplete control

Step 1: Add the namespace as shown in the following code sample:

{% tabs %}

{% highlight xaml %}

    xmlns:editors="clr-namespace:Syncfusion.Maui.Inputs;assembly=Syncfusion.Maui.Inputs"
	
{% endhighlight %}

{% highlight c# %}

    using Syncfusion.Maui.Inputs;

{% endhighlight %}

{% endtabs %}

Step 2: Set the control as the content in a `ContentPage.`

{% tabs %}

{% highlight xaml %}


<ContentPage.Content>    
    <editors:SfAutocomplete x:Name="autocomplete" />
</ContentPage.Content>


{% endhighlight %}

{% highlight c# %}
          
SfAutocomplete autocomplete = new SfAutocomplete(); 
Content = autocomplete;  

{% endhighlight %}

{% endtabs %}

## Populating items using data binding

The [.NET MAUI Autocomplete](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfAutocomplete.html) control can be bound to an external data source using the [ItemsSource](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_ItemsSource) property. Now, let's create Model and ViewModel classes to populate items with social media details in the [Autocomplete](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfAutocomplete.html).

**Step 1:**  Create a simple model class called 'SocialMedia' with fields 'ID' and 'Name', and then populate social media data in the 'SocialMediaViewModel'.

{% tabs %}
{% highlight c# %}

//Model.cs
public class SocialMedia
{
    public string Name { get; set; }
    public int ID { get; set; }
}

//ViewModel.cs
public class SocialMediaViewModel
{
    public ObservableCollection<SocialMedia> SocialMedias { get; set; }
    public SocialMediaViewModel()
    {
        this.SocialMedias = new ObservableCollection<SocialMedia>();
        this.SocialMedias.Add(new SocialMedia() { Name = "Facebook", ID = 0 });
        this.SocialMedias.Add(new SocialMedia() { Name = "Google Plus", ID = 1 });
        this.SocialMedias.Add(new SocialMedia() { Name = "Instagram", ID = 2 });
        this.SocialMedias.Add(new SocialMedia() { Name = "LinkedIn", ID = 3 });
        this.SocialMedias.Add(new SocialMedia() { Name = "Skype", ID = 4 });
        this.SocialMedias.Add(new SocialMedia() { Name = "Telegram", ID = 5 });
        this.SocialMedias.Add(new SocialMedia() { Name = "Televzr", ID = 6 });
        this.SocialMedias.Add(new SocialMedia() { Name = "Tik Tok", ID = 7 });
        this.SocialMedias.Add(new SocialMedia() { Name = "Tout", ID = 8 });
        this.SocialMedias.Add(new SocialMedia() { Name = "Tumblr", ID = 9 });
        this.SocialMedias.Add(new SocialMedia() { Name = "Twitter", ID = 10 });
        this.SocialMedias.Add(new SocialMedia() { Name = "Vimeo", ID = 11 });
        this.SocialMedias.Add(new SocialMedia() { Name = "WhatsApp", ID = 12 });
        this.SocialMedias.Add(new SocialMedia() { Name = "YouTube", ID = 13 });
    }
}

{% endhighlight %}
{% endtabs %}

**Step 2:** Populate data in [.NET MAUI Autocomplete](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfAutocomplete.html). 

Now, populate this 'SocialMediaViewModel' data in the [Autocomplete](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfAutocomplete.html) control by binding to the [ItemsSource](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_ItemsSource) property.

{% tabs %}
{% highlight xaml %}

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:editors="clr-namespace:Syncfusion.Maui.Inputs;assembly=Syncfusion.Maui.Inputs"
             xmlns:local="clr-namespace:AutocompleteSample"             
             x:Class="AutocompleteSample.MainPage">

       <ContentPage.BindingContext>
            <local:SocialMediaViewModel />
       </ContentPage.BindingContext>

       <ContentPage.Content>
            <!--Setting ItemsSource-->
            <editors:SfAutocomplete x:Name="autocomplete" 
                                    WidthRequest="250"
                                    ItemsSource="{Binding SocialMedias}" />
        </ContentPage.Content>
</ContentPage>

{% endhighlight %}

{% highlight C# %}

SocialMediaViewModel socialMediaViewModel = new SocialMediaViewModel();
autocomplete.BindingContext = socialMediaViewModel;
autocomplete.ItemsSource = SocialMediaViewModel.SocialMedias;

{% endhighlight %}
{% endtabs %}

N> Set the 'SocialMediaViewModel' instance as the `BindingContext` of your control. This is done to bind the properties of 'SocialMediaViewModel' to the `Autocomplete`.

**Step 3:** Set the `TextMemberPath` and `DisplayMemberPath`.

The [.NET MAUI Autocomplete](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfAutocomplete.html) control is populated with a list of social media options. However, since the 'SocialMedia' model includes two properties, 'Name' and 'ID', it's necessary to specify which property should be used as the display value in both the selection box portion and the drop-down suggestion list of the Autocomplete control.

**TextMemberPath**: This property path is used to retrieve the value that will be displayed in the selection box portion of the [.NET MAUI Autocomplete](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfAutocomplete.html) control when an item is selected. The default value is `String.Empty`.

**DisplayMemberPath**: This property path is used to specify the name or path of the property that will be displayed for each data item in the drop-down list. The default value is `String.Empty`.

{% tabs %}
{% highlight xaml %}

<editors:SfAutocomplete x:Name="autocomplete"
                        WidthRequest="250" 
                        DisplayMemberPath = "Name"
                        TextMemberPath = "Name"
                        ItemsSource="{Binding SocialMedias}" />

{% endhighlight %}
{% highlight C# %}

autocomplete.DisplayMemberPath = "Name";
autocomplete.TextMemberPath = "Name";

{% endhighlight %}
{% endtabs %}

N> You can refer to our [.NET MAUI Autocomplete](https://www.syncfusion.com/maui-controls/maui-autocomplete) feature tour page for its groundbreaking feature representations. You can also explore our [.NET MAUI Autocomplete Example](https://github.com/SyncfusionExamples/maui-autocomplete-samples) that shows you how to render the Autocomplete in .NET MAUI.
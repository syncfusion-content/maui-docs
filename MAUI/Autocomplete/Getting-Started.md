---
layout: post
title: Getting Started with .NET MAUI Autocomplete | Syncfusion
description: Learn how to get started with Syncfusion .NET MAUI Autocomplete control and its suggestion list, as well as other topics, in this section.
platform: maui
control: SfAutocomplete
documentation: ug
---

# Getting Started with .NET MAUI Autocomplete (SfAutocomplete)

This section explains how to add the Autocomplete control and bind data to it. This section covers only the basic features needed to get started with the Syncfusion `Autocomplete` control.

## Adding a .NET MAUI Autocomplete reference

Syncfusion .NET MAUI controls are available in [Nuget.org](https://www.nuget.org/). To add .NET MAUI Autocomplete to your project, open the NuGet package manager in Visual Studio, search for `Syncfusion.Maui.Inputs` and then install it.

## Handler registration 

 In the MauiProgram.cs file, register the handler for Syncfusion core.

{% highlight c# hl_lines="6 7 18 19" %}
using Microsoft.Maui;
using Microsoft.Maui.Hosting;
using Microsoft.Maui.Controls.Compatibility;
using Microsoft.Maui.Controls.Hosting;
using Microsoft.Maui.Controls.Xaml;
using Syncfusion.Maui.Core.Hosting;
using Syncfusion.Maui.ListView.Hosting;

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
            .ConfigureSyncfusionListView()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
            });

            return builder.Build();
        }      
    }
}     

## Create a Simple .NET MAUI Autocomplete

The .NET MAUI Autocomplete control is configured entirely in C# code or by using XAML markup. The following steps explain how to create a .NET MAUI Autocomplete (SfAutocomplete) and configure its elements.

### Adding the .NET MAUI Autocomplete control

Step 1: Add the NuGet to the project as discussed in the above reference section. 

Step 2: Add the namespace as shown in the following code sample.

{% tabs %}

{% highlight xaml %}

    xmlns:editors="clr-namespace:Syncfusion.Maui.Inputs;assembly=Syncfusion.Maui.Inputs"
	
{% endhighlight %}

{% highlight c# %}

    using Syncfusion.Maui.Inputs;

{% endhighlight %}

{% endtabs %}

Step 3: Set the control to content in `ContentPage.`

{% tabs %}

{% highlight xaml %}


<ContentPage.Content>    
    <editors:SfAutocomplete x:Name="autocomplete />
</ContentPage.Content>


{% endhighlight %}

{% highlight c# %}
          
SfAutocomplete autocomplete = new SfAutocomplete(); 
Content = autocomplete;  

{% endhighlight %}

{% endtabs %}

## Populating items using data binding

The `Autocomplete` can be bound to an external data source using the `ItemsSource` property. Now, let us create Model and ViewModel classes to populate items with social media details in `Autocomplete`.

**Step 1:** Create a simple model class 'SocialMedia' with fields 'ID' and 'Name', and then populate social media data in the 'SocialMediaViewModel'.

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

**Step 2:** Populate data in `Autocomplete`. 

Now, populate this 'SocialMediaViewModel' data in the `Autocomplete` control by binding to the `ItemsSource` property.

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
                                    Width="250"
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

N> Set the 'SocialMediaViewModel' instance as the `BindingContext` of your control; this is done to bind properties of 'SocialMediaViewModel' to `Autocomplete`.

**Step 3:** Set the `TextMemberPath` and `DisplayMemberPath`.

The `Autocomplete` control is populated with the list of social media. However, because the 'SocialMedia' model contains two properties such as 'Name' and 'ID', it is necessary to intimate, which property should be a display value in the selection box portion and drop-down suggestion of the `Autocomplete` control.

`TextMemberPath` - This property path is used to get the value for displaying in the selection box portion of the `Autocomplete` control when an item is selected. The default value is `String.Empty`.

`DisplayMemberPath` - This property path is used to specify the name or path of the property displayed for each data item in the drop-down list. The default value is `String.Empty`.

{% tabs %}
{% highlight xaml %}

<editors:SfAutocomplete x:Name="autocomplete" 
                        DisplayMemberPath = "Name"
                        TextMemberPath = "Name"
                        ItemsSource="{Binding SocialMedias}" />

{% endhighlight %}
{% highlight C# %}

autocomplete.DisplayMemberPath = "Name";
autocomplete.TextMemberPath = "Name";

{% endhighlight %}
{% endtabs %}

## Selection

The `Autocomplete` allows the user to select item from the drop-down list by clicking the `Enter` key or losing focus from the text box.

{% tabs %}
{% highlight xaml %}

<editors:SfAutocomplete x:Name="autocomplete"
                        DisplayMemberPath = "Name"
                        TextMemberPath = "Name"
                        ItemsSource="{Binding SocialMedias}" />

{% endhighlight %}
{% highlight C# %}

autocomplete.DisplayMemberPath = "Name";
autocomplete.TextMemberPath = "Name";

{% endhighlight %}
{% endtabs %}

The following gif image illustrates the result of the above code.

![.NET MAUI Autocomplete with single selection mode](GettingStarted_images/AutocompleteGettingStarted.gif)

You can find the complete getting started sample of .NET MAUI Autocomplete from this [link.](https://github.com/SyncfusionExamples/maui-autocomplete-samples)



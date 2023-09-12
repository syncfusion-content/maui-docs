---
layout: post
title: Getting Started with .NET MAUI Radio Button control | Syncfusion
description: Learn here about getting started with Syncfusion Essential Studio .NET MAUI Radio Button control, its elements and more.
platform: Maui
control: Radio Button
documentation: ug
---

## Creating an application with .NET MAUI Radio Button

This section explains the steps required to work with the `SfRadioButton` control for .NET MAUI.

## Adding a .NET MAUI Radio Button reference

Syncfusion .NET MAUI controls are available in [Nuget.org](https://www.nuget.org/). To add `.NET MAUI Radio Button` to your project, open the NuGet package manager in Visual Studio, search for `Syncfusion.Maui.Buttons`, and install it.

## Handler registration 

In the MauiProgram.cs file, register the handler for the Syncfusion core.

{% highlight c# hl_lines="6 17" %}

using Microsoft.Maui;
using Microsoft.Maui.Hosting;
using Microsoft.Maui.Controls.Compatibility;
using Microsoft.Maui.Controls.Hosting;
using Microsoft.Maui.Controls.Xaml;
using Syncfusion.Maui.Core.Hosting;

namespace ButtonSample
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

## Create a Simple SfRadioButton

The [`SfRadioButton`] control is configured entirely in C# code or by using XAML markup. The following steps explain how to create a [`SfRadioButton`] and configure its elements.

### Add namespace for referred assemblies

{% tabs %}
{% highlight xaml %}

    xmlns:syncfusion="clr-namespace:Syncfusion.Maui.Buttons;assembly=Syncfusion.Maui.Buttons"

{% endhighlight %}
{% highlight c# %}

    using Syncfusion.Maui.Buttons;

{% endhighlight %}
{% endtabs %}

### Refer SfRadioButton control with declared suffix name for Namespace

{% tabs %}
{% highlight xaml %}

    <?xml version="1.0" encoding="utf-8">
    <ContentPage xmlns="http://xamarin.com/schemas/2014/forms"
                    xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
                    xmlns:local="clr-namespace:GettingStarted"
	                xmlns:syncfusion="clr-namespace:Syncfusion.Maui.Butons;assembly=Syncfusion.Maui.Buttons" 
	                x:Class="GettingStarted.MainPage">
        <ContentPage.Content>
            <StackLayout>
                <syncfusion:SfRadioButton x:Name="radioButton"/>        
            </StackLayout>
        </ContentPage.Content>
     </ContentPage>

{% endhighlight %}
{% highlight c# %}

    using Syncfusion.Maui.Buttons;

    namespace GettingStarted
    {
        public partial class MainPage : ContentPage
        {
            public MainPage()
            {
                InitializeComponent();
                StackLayout stackLayout = new StackLayout();
                SfRadioButton radioButton = new SfRadioButton();
                stackLayout.Children.Add(radioButton);
                this.Content = stackLayout;
            }
        }
    }

{% endhighlight %}
{% endtabs %}

## Setting caption

The radio button caption can be defined using the [`Text`] property of [`SfRadioButton`]. This caption normally describes the meaning of the radio button and it displays next to radio button.
 
{% tabs %}
{% highlight xaml %}

    <syncfusion:SfRadioButton x:Name="radioButton" Text="Radio Button"/>

{% endhighlight %}
{% highlight c# %}

    SfRadioButton radioButton = new SfRadioButton();
    radioButton.Text = "Radio Button";
    this.Content = radioButton;

{% endhighlight %}
{% endtabs %}

![.NET MAUI Radio Button](Images/Getting-Started/radiobutton.png)

This demo can be downloaded from this [link]

## Change the radio button state

The two different visual states of the [`SfRadioButton`] are:

* Checked
* Unchecked

You can change the state of the radio button using the [`IsChecked`] property of [`SfRadioButton`]. In the checked state, an inner circle is added to the visualization of radio button.
The radio buttons are used when there is a list of two or more options or group that are mutually exclusive and the user must select exactly one choice, such as “Select Gender” or “Choose the best option!”.

{% tabs %}
{% highlight xaml %}

    <syncfusion:SfRadioGroup x:Name="radioGroup">
         <syncfusion:SfRadioButton x:Name="male" Text="Male" IsChecked="True"/>
         <syncfusion:SfRadioButton x:Name="female" Text="Female"/>
    </syncfusion:SfRadioGroup>

{% endhighlight %}
{% highlight c# %}

    SfRadioGroup radioGroup = new SfRadioGroup();
    SfRadioButton male = new SfRadioButton();
    male.IsChecked = true;
    male.Text = "Male";
    SfRadioButton female = new SfRadioButton();
    female.Text = "Female";
    radioGroup.Children.Add(male);
    radioGroup.Children.Add(female);
    this.Content = radioGroup;

{% endhighlight %}
{% endtabs %}

N> [`SfRadioButtons`] are mutually exclusive among them when they are defined within [`SfRadioGroup`].

![.NET MAUI Radio Button](Images/Getting-Started/statechange.png)

---
layout: post
title: Getting Started with .NET MAUI Radio Button Control | Syncfusion
description: Learn here about getting started with Syncfusion Essential Studio .NET MAUI Radio Button control, its elements and more.
platform: maui
control: SfRadioButton
documentation: ug
keywords : .net maui radio button, maui radio button, maui radio button group, maui radio button state.
---

# Creating an application with .NET MAUI Radio Button

This section explains the steps required to work with the [SfRadioButton](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfRadioButton.html) control for .NET MAUI.

To get start quickly with our .NET MAUI Radio Button, you can check the below video.

{% youtube "https://www.youtube.com/watch?v=z5EwGpw0KTI" %}

## Adding a .NET MAUI Radio Button reference

Syncfusion .NET MAUI controls are available on [Nuget.org](https://www.nuget.org/). To add the [.NET MAUI Radio Button](https://www.syncfusion.com/maui-controls/maui-radio-button) to your project, open the NuGet Package Manager in Visual Studio, search for Syncfusion.Maui.Buttons, and install it.

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

## Create a Simple .NET MAUI SfRadioButton

Step 1: Add the NuGet to the project as discussed in the above reference section. 

Step 2: Add the namespace as shown in the following code sample, to initialize the .NET MAUI Radio Button.

{% tabs %}
{% highlight xaml %}

    xmlns:syncfusion="clr-namespace:Syncfusion.Maui.Buttons;assembly=Syncfusion.Maui.Buttons"

{% endhighlight %}
{% highlight c# %}

    using Syncfusion.Maui.Buttons;

{% endhighlight %}
{% endtabs %}

Step 3: Set the .NET MAUI Radio Button control as the content in the `ContentPage.`

{% tabs %}
{% highlight xaml %}

    <?xml version="1.0" encoding="utf-8">
    <ContentPage xmlns="http://xamarin.com/schemas/2014/forms"
                    xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
                    xmlns:local="clr-namespace:GettingStarted"
	                xmlns:syncfusion="clr-namespace:Syncfusion.Maui.Buttons;assembly=Syncfusion.Maui.Buttons" 
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

The .NET MAUI Radio Button caption can be defined using the [Text](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.ToggleButton.html#Syncfusion_Maui_Buttons_ToggleButton_Text) property. This caption typically describes the meaning of the radio button and is displayed next to the radio button.
 
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

## Change the Radio Button state

The two different visual states of the [.NET MAUI Radio Button](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfRadioButton.html) are:

* Checked
* Unchecked

To change the state of the .NET MAUI Radio Button, you can utilize the [IsChecked](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfRadioButton.html#Syncfusion_Maui_Buttons_SfRadioButton_IsChecked) property of [SfRadioButton](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfRadioButton.html). When the Radio Button is checked, an inner circle is added to its visualization.

The .NET MAUI Radio Buttons are used when there is a list of two or more options or groups that are mutually exclusive, and the user must select exactly one choice, such as "Select Gender" or "Choose the best option!".

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

N> [SfRadioButtons](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfRadioButton.html) are mutually exclusive when they are defined within [SfRadioGroup](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfRadioGroup.html).

![.NET MAUI Radio Button](Images/Getting-Started/statechange.png)

You can find the complete getting started sample of the .NET MAUI Radio Button from this [link.](https://github.com/SyncfusionExamples/maui-radiobutton-samples)

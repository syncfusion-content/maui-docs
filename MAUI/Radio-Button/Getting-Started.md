---
layout: post
title: Getting Started with .NET MAUI Radio Button Control | Syncfusion
description: Learn here about getting started with Syncfusion Essential Studio .NET MAUI Radio Button control, its elements and more.
platform: maui
control: SfRadioButton
documentation: ug
keywords : .net maui radio button, maui radio button, maui radio button group, maui radio button state.
---

# Getting Started with .NET MAUI RadioButton

This section guides you through setting up and configuring a [RadioButton](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfRadioButton.html) in your .NET MAUI application. Follow the steps below to add a basic RadioButton to your project.

## Prerequisites

Before proceeding, ensure the following are in place:
   
    1. Install .NET 7 SDK or later.
    2. Set up a .NET MAUI environment with Visual Studio 2022 (v17.3 or later) or VS Code. For VS Code users, ensure that the .NET MAUI workload is installed and configured as described here.

To get start quickly with our .NET MAUI Radio Button, you can check the below video.

{% youtube "https://www.youtube.com/watch?v=z5EwGpw0KTI" %}

## Step 1: Create a New MAUI Project

    1. Open Visual Studio or VS Code.
    2. Go to File > New > Project and choose the .NET MAUI App template.
    3. Name the project and choose a location, then click Create.

## Step 2: Install the Syncfusion MAUI Buttons NuGet Package

    1. In Solution Explorer, right-click the project and choose Manage NuGet Packages.
    2. Search for Syncfusion.Maui.Buttons and install the latest version.
    3. Ensure the necessary dependencies are installed correctly, and the project is restored.

## step 3: Register the Handler 

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

## Step 4: Add a Basic SfRadioButton

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


## Grouping RadioButtons with RadioGroup

You can group multiple radio buttons together by using RadioGroup. Only one button within a group can be selected at a time.

{% tabs %}
{% highlight xaml %}

    <syncfusion:SfRadioGroup x:Name="radioGroup">
         <syncfusion:SfRadioButton x:Name="male" Text="Male"/>
         <syncfusion:SfRadioButton x:Name="female" Text="Female" IsChecked="True"/>
    </syncfusion:SfRadioGroup>

{% endhighlight %}
{% highlight c# %}

    SfRadioGroup radioGroup = new SfRadioGroup();
    SfRadioButton male = new SfRadioButton();
    male.Text = "Male";
    SfRadioButton female = new SfRadioButton();
    female.IsChecked = true;
    female.Text = "Female";
    radioGroup.Children.Add(male);
    radioGroup.Children.Add(female);
    this.Content = radioGroup;

{% endhighlight %}
{% endtabs %}

N> [SfRadioButtons](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfRadioButton.html) are mutually exclusive when they are defined within [SfRadioGroup](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfRadioGroup.html).

![.NET MAUI Radio Button](Images/Getting-Started/statechange.png)

You can find the complete getting started sample of the .NET MAUI Radio Button from this [link.](https://github.com/SyncfusionExamples/maui-radiobutton-samples)

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

To get start quickly with our .NET MAUI Radio Button, you can check the below video.

{% youtube "https://www.youtube.com/watch?v=z5EwGpw0KTI" %}

## Prerequisites

Before proceeding, ensure the following are set up:
1. Install [.NET 7 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/7.0) or later is installed.
2. Set up a .NET MAUI environment with Visual Studio 2022 (v17.3 or later) or VS Code. For VS Code users, ensure that the .NET MAUI workload is installed and configured as described [here.](https://learn.microsoft.com/en-us/dotnet/maui/get-started/installation?view=net-maui-8.0&tabs=visual-studio-code)



## Step 1: Create a New MAUI Project

1. Launch Visual Studio or VS Code.
1. Navigate to **File > New > Project,** then select the **.NET MAUI App** template.
1. Name the project and choose a location, then click Create.

## Step 2: Install the Syncfusion MAUI Core NuGet Package

1. In **Solution Explorer,** right-click the project and choose **Manage NuGet Packages.**
1. Search for [Syncfusion.Maui.Buttons](https://www.nuget.org/packages/Syncfusion.Maui.Buttons/) and install the latest version.
1. Ensure the necessary dependencies are installed correctly, and the project is restored.

## Step 3: Register the handler

Syncfusion.Maui.Core NuGet is a dependent package for all Syncfusion controls of .NET MAUI. In the MauiProgram.cs file, register the handler for Syncfusion core.

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

## Step 4: Add a Basic RadioButton

 To initialize the control, import the Core namespace into your code.
1. Initialize [SfAvatarView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfAvatarView.html?tabs=tabid-1).

{% tabs %}

{% highlight xaml %}

<ContentPage
    . . .    
    xmlns:sfavatar="clr-namespace:Syncfusion.Maui.Buttons;assembly=Syncfusion.Maui.Buttons">
        <syncfusion:SfRadioButton x:Name="radioButton"/>     
</ContentPage>

{% endhighlight %}

{% highlight c# %}

    using Syncfusion.Maui.Buttons;
    namespace RadioButtonGettingStarted
    {
        public partial class MainPage : ContentPage
        {
            public MainPage()
            {
                InitializeComponent();           
                SfRadioButton radioButton = new SfRadioButton();
                this.Content=radioButton
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

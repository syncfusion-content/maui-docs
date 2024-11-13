---
layout: post
title: Getting Started with .NET MAUI CheckBox | Syncfusion
description: Learn here about getting started with Syncfusion .NET MAUI CheckBox (SfCheckBox) control, its elements and more.
platform: maui
control: CheckBox
documentation: ug
---

# Getting Started with .NET MAUI CheckBox

This section guides you through setting up and configuring a [CheckBox](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfCheckBox.html) in your .NET MAUI application. Follow the steps below to add a basic CheckBox to your project.

To quickly get started with the .NET MAUI CheckBox, watch this video.

{% youtube "https://www.youtube.com/watch?v=dgekGX8eYMo" %}

## Prerequisites

Before proceeding, ensure the following are set up:
1. Install [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/7.0) or later is installed.
2. Set up a .NET MAUI environment with Visual Studio 2022 (v17.3 or later) or Visual Studio Code. For Visual Studio Code users, ensure that the .NET MAUI workload is installed and configured as described [here.](https://learn.microsoft.com/en-us/dotnet/maui/get-started/installation?view=net-maui-8.0&tabs=visual-studio-code)


## Step 1: Create a New MAUI Project

### Visual Studio

1. Go to **File > New > Project** and choose the **.NET MAUI App** template.
1. Name the project and choose a location. Then, click **Next**.
1. Select the .NET framework version and click **Create**.

### Visual Studio Code

1. Open the command palette by pressing `Ctrl+Shift+P` and type **.NET:New Project** and enter.
1. Choose the **.NET MAUI App** template.
1. Select the project location, type the project name and press **Enter.**
1. Then choose **Create project.**

## Step 2: Install the Syncfusion MAUI Buttons NuGet Package

1. In **Solution Explorer,** right-click the project and choose **Manage NuGet Packages.**
1. Search for [Syncfusion.Maui.Buttons](https://www.nuget.org/packages/Syncfusion.Maui.Buttons/) and install the latest version.
1. Ensure the necessary dependencies are installed correctly, and the project is restored.

## Step 3: Register the handler

[Syncfusion.Maui.Core](https://www.nuget.org/packages/Syncfusion.Maui.Core/) is a dependent package for all Syncfusion controls of .NET MAUI. In the MauiProgram.cs file, register the handler for Syncfusion core.

{% highlight c# hl_lines="6 17" %}

using Microsoft.Maui;
using Microsoft.Maui.Hosting;
using Microsoft.Maui.Controls.Compatibility;
using Microsoft.Maui.Controls.Hosting;
using Microsoft.Maui.Controls.Xaml;
using Syncfusion.Maui.Core.Hosting;

namespace CheckBoxGettingStarted
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


## Step 4: Add a Basic SfCheckBox

1. To initialize the control, import the Buttons namespace into your code.
1. Initialize [SfCheckBox](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfCheckBox.html).

{% tabs %}

{% highlight xaml %}

<ContentPage
    . . .    
    xmlns:buttons="clr-namespace:Syncfusion.Maui.Buttons;assembly=Syncfusion.Maui.Buttons">
   <buttons:SfCheckBox x:Name="checkBox"/>
</ContentPage>

{% endhighlight %}

{% highlight c# %}

    using Syncfusion.Maui.Buttons;
    namespace CheckBoxGettingStarted
    {
        public partial class MainPage : ContentPage
        {
            public MainPage()
            {
                InitializeComponent();           
                SfCheckBox checkBox = new SfCheckBox();
                this.Content = checkBox;
            }
        }   
    }

{% endhighlight %}
{% endtabs %}

## Step 5: Set the CheckBox caption

You can set the caption of the CheckBox using the [Text](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.ToggleButton.html#Syncfusion_Maui_Buttons_ToggleButton_Text) property.This caption typically describes the meaning of the check box and is displayed next to the check box.

{% tabs %}
{% highlight xaml %}

    <buttons:SfCheckBox x:Name="checkBox" IsChecked="True" Text="CheckBox"/>

{% endhighlight %}
{% highlight c# %}

    SfCheckBox checkBox = new SfCheckBox();
    checkBox.IsChecked = true;
    checkBox.Text = "CheckBox";
    this.Content = checkBox;

{% endhighlight %}
{% endtabs %}

![.NET MAUI CheckBox](Images/Getting-Started/simplecheckbox.png) 

## Change the check box state

The three visual states of [`SfCheckBox`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfCheckBox.html) are: 

* Checked
* Unchecked
* Indeterminate

![.NET MAUI CheckBox](Images/Getting-Started/tristate.png) 

You can change the state of the check box using the [`IsChecked`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfCheckBox.html#Syncfusion_Maui_Buttons_SfCheckBox_IsChecked) [`SfCheckBox`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfCheckBox.html). In the checked state, a tick mark is added to the visualization of the check box.

<table>
<tr>
<td>
<b>State</b>
</td>
<td>
<b>Property</b>
</td>
<td>
<b>Value</b>
</td>
</tr>
<tr>
<td>
checked
</td>
<td>
IsChecked
</td>
<td>
true
</td>
</tr>
<tr>
<td>
unchecked
</td>
<td>
IsChecked
</td>
<td>
false
</td>
</tr>
<tr>
<td>
indeterminate
</td>
<td>
IsChecked
</td>
<td>
null
</td>
</tr>
</table>

N> For the check box, to report the indeterminate state, set the [`IsThreeState`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfCheckBox.html#Syncfusion_Maui_Buttons_SfCheckBox_IsThreeState) property to true.

The check box can be used as a single or as a group. A single check box mostly used for a binary yes/no choice, such as "Remember me?", login scenario, or a terms of service agreement.

{% tabs %}
{% highlight xaml %}

    <buttons:SfCheckBox x:Name="checkBox" Text="I agree to the terms of services for this site" IsChecked="True"/> 

{% endhighlight %}
{% highlight c# %}

    SfCheckBox checkBox = new SfCheckBox();
    checkBox.Text = "I agree to the terms of services for this site";
    checkBox.IsChecked = true;
    this.Content = checkBox;

{% endhighlight %}
{% endtabs %}

![.NET MAUI CheckBox](Images/Getting-Started/termsandconditions.png)


Multiple checkboxes can be used as a group for multi-select scenarios in which a user selects one or more items from the choices that are not mutually exclusive.

{% tabs %}
{% highlight xaml %}

    <StackLayout Padding="20">
        <Label x:Name="label" Text="Pizza Toppings" Margin="0,10"/>
        <buttons:SfCheckBox x:Name="pepperoni" Text="Pepperoni"/>
        <buttons:SfCheckBox x:Name="beef" Text="Beef" IsChecked="True"/>
        <buttons:SfCheckBox x:Name="mushroom" Text="Mushrooms"/>
        <buttons:SfCheckBox x:Name="onion" Text="Onions" IsChecked="True"/>
    </StackLayout>

{% endhighlight %}
{% highlight c# %}

        StackLayout stackLayout = new StackLayout() { Padding = 20 };
        Label label = new Label();
        label.Text = "Pizza Toppings";
        label.Margin = new Thickness(0,10);
        SfCheckBox pepperoni = new SfCheckBox();
        pepperoni.Text = "Pepperoni";
        SfCheckBox beef = new SfCheckBox();
        beef.Text = "Beef";
        beef.IsChecked = true;
        SfCheckBox mushroom = new SfCheckBox();
        mushroom.Text = "Mushrooms";
        SfCheckBox onion = new SfCheckBox();
        onion.Text = "Pepperoni";
        onion.IsChecked = true;
        stackLayout.Children.Add(label);
        stackLayout.Children.Add(pepperoni);
        stackLayout.Children.Add(beef);
        stackLayout.Children.Add(mushroom);
        stackLayout.Children.Add(onion);
        this.Content = stackLayout;

{% endhighlight %}
{% endtabs %}

![.NET MAUI CheckBox](Images/Getting-Started/pizzatoppings.png)

## Intermediate

The [SfCheckBox](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfCheckBox.html) allows an Intermediate state in addition to the checked and unchecked state. The Intermediate state of the check box is enabled by setting the [IsThreeState](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfCheckBox.html#Syncfusion_Maui_Buttons_SfCheckBox_IsThreeState) property of the control to `True`.

N> When the [IsThreeState](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfCheckBox.html#Syncfusion_Maui_Buttons_SfCheckBox_IsThreeState) property is set to `False` and [IsChecked](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfCheckBox.html#Syncfusion_Maui_Buttons_SfCheckBox_IsChecked) property is set to `null` then the check box will be in unchecked state.

The Intermediate state is used when a group of sub-choices has both checked and unchecked states. In the following example, the "Select all" checkbox has the [IsThreeState](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfCheckBox.html#Syncfusion_Maui_Buttons_SfCheckBox_IsThreeState) property set to `true`. The "Select all" checkbox is checked if all child elements are checked, unchecked if all the child elements are unchecked, and Intermediate otherwise.

{% tabs %}
{% highlight xaml %}

    <StackLayout Padding="20">
        <Label x:Name="label" Margin="10" Text="Pizza Toppings"/>
        <buttons:SfCheckBox x:Name="selectAll" Text="Select All" IsThreeState="True" StateChanged="SelectAll_StateChanged"/>
        <buttons:SfCheckBox x:Name="pepperoni" Text="Pepperoni" StateChanged="CheckBox_StateChanged" Margin="30,0"/>
        <buttons:SfCheckBox x:Name="beef" Text="Beef" IsChecked="True" StateChanged="CheckBox_StateChanged" Margin="30,0"/>
        <buttons:SfCheckBox x:Name="mushroom" Text="Mushrooms" StateChanged="CheckBox_StateChanged" Margin="30,0"/>
        <buttons:SfCheckBox x:Name="onion" Text="Onions" IsChecked="True" StateChanged="CheckBox_StateChanged" Margin="30,0"/>
    </StackLayout>

{% endhighlight %}
{% highlight c# %}

    StackLayout stackLayout = new StackLayout() { Padding = 20 };
    SfCheckBox selectAll, pepperoni, beef, mushroom, onion;
    Label label = new Label();
    label.Text = "Pizza Toppings";
    label.Margin = new Thickness(10);
    selectAll = new SfCheckBox();
    selectAll.StateChanged += SelectAll_StateChanged;
    selectAll.Text = "Select All";   
    selectAll.IsThreeState = true;
    pepperoni = new SfCheckBox();
    pepperoni.StateChanged += CheckBox_StateChanged;
    pepperoni.Text = "Pepperoni";
    pepperoni.Margin = new Thickness(30, 0);
    beef = new SfCheckBox();
    beef.StateChanged += CheckBox_StateChanged;
    beef.Text = "Beef";
    beef.IsChecked = true;
    beef.Margin = new Thickness(30, 0);
    mushroom = new SfCheckBox();
    mushroom.StateChanged += CheckBox_StateChanged;
    mushroom.Text = "Mushrooms";
    mushroom.Margin = new Thickness(30, 0);
    onion = new SfCheckBox();
    onion.StateChanged += CheckBox_StateChanged;
    onion.Text = "Onions";
    onion.Margin = new Thickness(30, 0);
    onion.IsChecked = true;
    stackLayout.Children.Add(label);
    stackLayout.Children.Add(selectAll);
    stackLayout.Children.Add(pepperoni);
    stackLayout.Children.Add(beef);
    stackLayout.Children.Add(mushroom);
    stackLayout.Children.Add(onion);
    this.Content = stackLayout;

{% endhighlight %}
{% endtabs %}

{% tabs %}
{% highlight c# %}

    bool skip = false;
    private void SelectAll_StateChanged(object sender, Syncfusion.Maui.Buttons.StateChangedEventArgs e)
    {
        if (!skip)
        {
           skip = true;
           pepperoni.IsChecked = beef.IsChecked = mushroom.IsChecked = onion.IsChecked = e.IsChecked;
           skip = false;
        }
    }

    private void CheckBox_StateChanged(object sender, Syncfusion.Maui.Buttons.StateChangedEventArgs e)
    {
        if (!skip)
        {
           skip = true;
           if (pepperoni.IsChecked.Value && beef.IsChecked.Value && mushroom.IsChecked.Value && onion.IsChecked.Value)
               selectAll.IsChecked = true;
           else if (!pepperoni.IsChecked.Value && !beef.IsChecked.Value && !mushroom.IsChecked.Value && !onion.IsChecked.Value)
	           selectAll.IsChecked = false;
           else
               selectAll.IsChecked = null;
           skip = false;
        }
    }
		
{% endhighlight %}
{% endtabs %}

![.NET MAUI CheckBox](Images/Getting-Started/picktoppings.png)

![.NET MAUI CheckBox](Images/Getting-Started/selectalltoppings.png)

You can find the complete getting started sample of the .NET MAUI CheckBox from this [link.](https://github.com/SyncfusionExamples/maui-checkbox-samples)

## See also 

[How to achieve intermediate state in .NET MAUI CheckBox using MVVM?](https://support.syncfusion.com/kb/article/16162/how-to-achieve-intermediate-state-in-net-maui-checkbox-using-mvvm)

[How to set intermediate state in the .NET MAUI CheckBox?](https://support.syncfusion.com/kb/article/14110/how-to-set-intermediate-state-in-the-net-maui-checkbox)
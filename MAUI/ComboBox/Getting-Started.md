---
layout: post
title: Getting Started with .NET MAUI ComboBox | Syncfusion®
description: Learn here about getting started with Syncfusion® .NET MAUI ComboBox (SfComboBox) control, its elements, and its features.
platform: maui
control: SfComboBox
documentation: ug
keywords: .net maui combobox, .net maui sfcombobox, syncfusion combobox, combobox maui, .net maui dropdown list, .net maui select menu.
---

# Getting Started with .NET MAUI ComboBox

This section guides you through setting up and configuring a [ComboBox](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfComboBox.html) in your .NET MAUI application. Follow the steps below to add a basic ComboBox to your project.

To quickly get started with the .NET MAUI ComboBox, watch this video.

{% youtube "https://www.youtube.com/watch?v=jcfaI0PFmSo" %}

{% tabcontents %}
{% tabcontent Visual Studio %}

## Prerequisites

Before proceeding, ensure the following are in place:

1. Install [.NET 9 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/9.0) or later.
2. Set up a .NET MAUI environment with Visual Studio 2022 v17.12 or later.

## Step 1: Create a New MAUI Project

1. Go to **File > New > Project** and choose the **.NET MAUI App** template.
2. Name the project and choose a location. Then, click **Next**.
3. Select the .NET framework version and click **Create**.

## Step 2: Install the Syncfusion<sup>®</sup> MAUI Inputs NuGet Package

1. In **Solution Explorer**, right-click the project and choose **Manage NuGet Packages**.
2. Search for [Syncfusion.Maui.Inputs](https://www.nuget.org/packages/Syncfusion.Maui.Inputs) and install the latest version.
3. Ensure the necessary dependencies are installed correctly, and the project is restored.

{% endtabcontent %}
{% tabcontent Visual Studio Code %}

## Prerequisites

Before proceeding, ensure the following are set up:

1. Install [.NET 9 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/9.0) or later.
2. Set up a .NET MAUI environment with Visual Studio Code.
3. Ensure that the .NET MAUI workloads are installed and configured as described [here](https://learn.microsoft.com/en-us/dotnet/maui/get-started/installation?view=net-maui-9.0&tabs=visual-studio-code).

## Step 1: Create a New MAUI Project

1. Open the Command Palette by pressing **Ctrl+Shift+P** and type **.NET:New Project** and press Enter.
2. Choose the **.NET MAUI App** template.
3. Select the project location, type the project name and press Enter.
4. Then choose **Create project**

## Step 2: Install the Syncfusion<sup>®</sup> MAUI Inputs NuGet Package

1. Press <kbd>Ctrl</kbd> + <kbd>`</kbd> (backtick) to open the integrated terminal in Visual Studio Code.
2. Ensure you're in the project root directory where your .csproj file is located.
3. Run the command `dotnet add package Syncfusion.Maui.Inputs` to install the Syncfusion<sup>®</sup> .NET MAUI Inputs package.
4. To ensure all dependencies are installed, run `dotnet restore`.

{% endtabcontent %}

{% tabcontent JetBrains Rider %}

## Prerequisites

Before proceeding, ensure the following are set up:

1. Install [.NET 9 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/9.0) or later.
2. Set up a .NET MAUI environment with JetBrains Rider 2024.3 or later.
3. Make sure the MAUI workloads are installed and configured as described [here.](https://www.jetbrains.com/help/rider/MAUI.html#before-you-start)

## Step 1: Create a new .NET MAUI project

1. Go to **File > New Solution**, select .NET (C#) and choose the **.NET MAUI App** template.
2. Enter the Project Name, Solution Name, and Location.
3. Select the .NET framework version and click **Create**.

## Step 2: Install the Syncfusion<sup>®</sup> MAUI Inputs NuGet Package

1. In **Solution Explorer**, right-click the project and choose **Manage NuGet Packages**.
2. Search for [Syncfusion.Maui.Inputs](https://www.nuget.org/packages/Syncfusion.Maui.Inputs) and install the latest version.
3. Ensure the necessary dependencies are installed correctly, and the project is restored.

{% endtabcontent %}

{% endtabcontents %}

## Step 3: Register Syncfusion handler
 
Make sure to add the namespace.
 
{% tabs %}
{% highlight c# %}
using Syncfusion.Maui.Core.Hosting;
{% endhighlight %}
{% endtabs %}
 
Register the Syncfusion core handler in your `CreateMauiApp` method of `MauiProgram.cs` file to use Syncfusion controls.
 
{% tabs %}
{% highlight c# %}
builder.ConfigureSyncfusionCore();
{% endhighlight %}
{% endtabs %}

## Step 4: Define Model and View Model

Define a simple model class SocialMedia with fields ID and name, and then populate social media data in the ViewModel.

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
    }
}

{% endhighlight %}
{% endtabs %}

## Step 5: Import the ComboBox namespace

Add the following namespace in your XAML or C#.

{% tabs %}
{% highlight xaml tabtitle="xaml" %}
xmlns:inputs="clr-namespace:Syncfusion.Maui.Inputs;assembly=Syncfusion.Maui.Inputs"
{% endhighlight %}
{% highlight c# tabtitle="C#" %}
using Syncfusion.Maui.Inputs;
{% endhighlight %}
{% endtabs %}

## Step 6: Add the ComboBox component

Create an instance and set it as the ComboBox's [ItemsSource]((https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_ItemsSource)) property.

The [ComboBox](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfComboBox.html) control is populated with a list of social media. But the SocialMedia model contains two properties, ID and Name, so it is necessary to intimate by which property it should display the value in the selection box portion of the `[ComboBox](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfComboBox.html) control when an item is selected.

[TextMemberPath](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_TextMemberPath)  - This property path is used to get the value for displaying in the selection box portion of the [ComboBox](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfComboBox.html) control when an item is selected. The default value is **String.Empty**.

[DisplayMemberPath](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_DisplayMemberPath) - This property path is used to the name or path of the property displayed for each data item in the drop-down list. The default value is **String.Empty**.

{% tabs %}
{% highlight xaml %}
<inputs:SfComboBox x:Name="comboBox" 
                    WidthRequest="250"
                    HeightRequest="50"
                    DisplayMemberPath = "Name"
                    TextMemberPath = "Name"
                    ItemsSource="{Binding SocialMedias}" />
    <inputs:SfComboBox.BindingContext>
        <local:SocialMediaViewModel />
    </inputs:SfComboBox.BindingContext>
</inputs:SfComboBox>
{% endhighlight %}

{% highlight C# %}
SocialMediaViewModel socialMediaViewModel = new SocialMediaViewModel();
SfComboBox comboBox = new SfComboBox
{
    WidthRequest = 250,
    HeightRequest = 50,
    DisplayMemberPath = "Name",
    TextMemberPath = "Name",
    ItemsSource = socialMediaViewModel.SocialMedias,
};
{% endhighlight %}
{% endtabs %}

The following screenshot illustrates the result of the above code.

![.NET MAUI ComboBox populating using data binding](Images/GettingStarted/NonEditableMode.gif)

You can download the ComboBox Getting Started sample from [GitHub](https://github.com/SyncfusionExamples/maui-combobox-samples)

N> When publishing in AOT mode on iOS, ensure [Preserve(AllMembers = true)] is added to the model class to maintain DisplayMemberPath binding

N> You can refer to our [.NET MAUI ComboBox](https://www.syncfusion.com/maui-controls/maui-combobox) feature tour page for its groundbreaking feature representations. You can also explore our [.NET MAUI ComboBox Example](https://github.com/syncfusion/maui-demos/tree/master/MAUI/Inputs/SampleBrowser.Maui.Inputs/Samples/ComboBox) that shows you how to render the ComboBox in .NET MAUI.

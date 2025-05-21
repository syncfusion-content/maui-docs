---
layout: post
title: Getting Started with .NET MAUI Text Input Layout Control | Syncfusion®
description: Learn about getting started with Syncfusion® .NET MAUI Text Input Layout (SfTextInputLayout) control, its elements, and more.
platform: maui
control: SfTextInputLayout
documentation: ug
keywords: .net maui text input layout, syncfusion text input layout, text input layout maui, .net maui hint label
---

# Getting Started with .NET MAUI TextInputLayout

This section guides you through setting up and configuring a [TextInputLayout](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfTextInputLayout.html) in your .NET MAUI application. Follow the steps below to add a basic TextInputLayout to your project.

To get started quickly with the .NET MAUI TextInputLayout, watch this video.

{% youtube "https://www.youtube.com/watch?v=VKo3vNBzNbw" %}

{% tabcontents %}
{% tabcontent Visual Studio %}

## Prerequisites

Before you proceed, ensure the following are in place:

1. Install [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0) or later.
2. Set up a .NET MAUI environment with Visual Studio 2022 (v17.8 or later).

## Step 1: Create a New .NET MAUI Project

1. Go to **File > New > Project** and select the **.NET MAUI App** template.
2. Name the project and choose a location. Click **Next**.
3. Select the desired .NET framework version and click **Create**.

## Step 2: Install the Syncfusion<sup>®</sup> MAUI Core NuGet Package

1. In **Solution Explorer**, right-click the project and select **Manage NuGet Packages**.
2. Search for [Syncfusion.Maui.Core](https://www.nuget.org/packages/Syncfusion.Maui.Core/) and install the latest version.
3. Ensure all necessary dependencies are installed correctly, and the project is restored.

## Step 3: Register the Handler

The [Syncfusion.Maui.Core](https://www.nuget.org/packages/Syncfusion.Maui.Core) NuGet package is required for all Syncfusion controls in .NET MAUI. Register the handler in the **MauiProgram.cs file**.

{% highlight c# hl_lines="6 17" %}   
using Microsoft.Maui;
using Microsoft.Maui.Hosting;
using Microsoft.Maui.Controls.Compatibility;
using Microsoft.Maui.Controls.Hosting;
using Microsoft.Maui.Controls.Xaml;
using Syncfusion.Maui.Core.Hosting;

namespace TextInputLayoutSample
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

## Step 4: Add a Basic TextInputLayout

**Step 1:** Add the namespace as shown in the following code sample.
Add the following namespace to add [.NET MAUI Text Input Layout](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfTextInputLayout.html).
Include the following namespace to add [.NET MAUI Text Input Layout](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfTextInputLayout.html).

{% tabs %}

{% highlight xaml %}

    xmlns:inputLayout="clr-namespace:Syncfusion.Maui.Core;assembly=Syncfusion.Maui.Core"
	
{% endhighlight %}

{% highlight c# %}

    using Syncfusion.Maui.Core;

{% endhighlight %}

{% endtabs %}

**Step 2:** Add any input view control such as [Entry](https://learn.microsoft.com/en-us/dotnet/maui/user-interface/controls/entry) and [Editor](https://learn.microsoft.com/en-us/dotnet/maui/user-interface/controls/editor), [SfAutocomplete](https://help.syncfusion.com/maui/autocomplete/overview), or [SfComboBox](https://help.syncfusion.com/maui/combobox/overview) controls, and add a hint label (floating label).

{% tabs %} 

{% highlight xaml %} 

<inputLayout:SfTextInputLayout>
   <Entry />
</inputLayout:SfTextInputLayout>  

{% endhighlight %}

{% highlight C# %} 

SfTextInputLayout inputLayout = new SfTextInputLayout();
inputLayout.Content = new Entry(); 

{% endhighlight %}

{% endtabs %}

{% endtabcontent %}
{% tabcontent Visual Studio Code %}

## Prerequisites

Before starting, ensure the following are set up:

1. Install [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0) or later.
2. Set up a .NET MAUI environment with Visual Studio Code.
3. Make sure the .NET MAUI extension is installed and configured [as described here](https://learn.microsoft.com/en-us/dotnet/maui/get-started/installation?view=net-maui-8.0&tabs=visual-studio-code).

## Step 1: Create a New .NET MAUI Project

1. Open the Command Palette by pressing **Ctrl+Shift+P**, type **.NET: New Project**, and press **Enter**.
2. Choose the **.NET MAUI App** template.
3. Select the project location, name the project, and press **Enter**.
4. Then click **Create Project**.


## Step 2: Install the Syncfusion<sup>®</sup> MAUI Core NuGet Package

1. Press **Ctrl + `** (backtick) to open the integrated terminal in Visual Studio Code.
2. Ensure you're in the project root directory where your `.csproj` file is located.
3. Run the command `dotnet add package Syncfusion.Maui.Core` to install the Syncfusion<sup>®</sup> .NET MAUI Core package.
4. To ensure all dependencies are installed, run `dotnet restore`.

## Step 3: Register the Handler

[Syncfusion.Maui.Core](https://www.nuget.org/packages/Syncfusion.Maui.Core) nuget is a dependent package for all Syncfusion<sup>®</sup> controls of .NET MAUI. In the **MauiProgram.cs file**, register the handler for Syncfusion<sup>®</sup> core.

{% highlight c# hl_lines="6 17" %}   
using Microsoft.Maui;
using Microsoft.Maui.Hosting;
using Microsoft.Maui.Controls.Compatibility;
using Microsoft.Maui.Controls.Hosting;
using Microsoft.Maui.Controls.Xaml;
using Syncfusion.Maui.Core.Hosting;

namespace TextInputLayoutSample
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

## Step 4: Add a Basic TextInputLayout

**Step 1:** Add the NuGet package to the project as discussed in the reference section above.

**Step 2:** Include the namespace as shown in the following code sample.

Include the following namespace to add [.NET MAUI Text Input Layout](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfTextInputLayout.html).

{% tabs %}

{% highlight xaml %}

    xmlns:inputLayout="clr-namespace:Syncfusion.Maui.Core;assembly=Syncfusion.Maui.Core"
	
{% endhighlight %}

{% highlight c# %}

    using Syncfusion.Maui.Core;

{% endhighlight %}

{% endtabs %}

**Step 3:** Add any input view control such as [Entry](https://learn.microsoft.com/en-us/dotnet/maui/user-interface/controls/entry) and [Editor](https://learn.microsoft.com/en-us/dotnet/maui/user-interface/controls/editor), [SfAutocomplete](https://help.syncfusion.com/maui/autocomplete/overview), or [SfComboBox](https://help.syncfusion.com/maui/combobox/overview) controls, and add a hint label (floating label).

{% tabs %} 

{% highlight xaml %} 

<inputLayout:SfTextInputLayout>
   <Entry />
</inputLayout:SfTextInputLayout>  

{% endhighlight %}

{% highlight C# %} 

SfTextInputLayout inputLayout = new SfTextInputLayout();
inputLayout.Content = new Entry(); 

{% endhighlight %}

{% endtabs %}

{% endtabcontent %}
{% endtabcontents %}

## Adding Hint

A floating label for the text input layout can be added by setting the [Hint](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfTextInputLayout.html#Syncfusion_Maui_Core_SfTextInputLayout_Hint) property. The visibility of the hint can be collapsed by setting the [ShowHint](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfTextInputLayout.html#Syncfusion_Maui_Core_SfTextInputLayout_ShowHint) property to `false`. By default, this property is set to `true`.

{% tabs %} 

{% highlight xaml %} 

<inputLayout:SfTextInputLayout Hint="Name">
   <Entry />
</inputLayout:SfTextInputLayout>  

{% endhighlight %}

{% highlight C# %} 

SfTextInputLayout inputLayout = new SfTextInputLayout();
inputLayout.Hint = "Name"; 
inputLayout.Content = new Entry(); 

{% endhighlight %}

{% endtabs %}

When focusing on the input view, the hint label will be moved to the top position. It will return to its original position when proceeding further (on unfocused) without entering any value.

Run the project, and verify that you get the following output to ensure the project is correctly configured to add the text input layout control.

![Adding hint](images/GettingStarted/GettingStarted.png)

## Enabling Password Visibility Toggle

The password visibility toggle is used to show or hide the characters in the input view added to the control. Enable this feature by setting the [EnablePasswordVisibilityToggle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfTextInputLayout.html#Syncfusion_Maui_Core_SfTextInputLayout_EnablePasswordVisibilityToggle) property to `true`.

{% tabs %} 

{% highlight xaml %} 

<inputLayout:SfTextInputLayout  Hint="Name" 
                                EnablePasswordVisibilityToggle="true">
    <Entry Text="1234"/>
</inputLayout:SfTextInputLayout>  
 
{% endhighlight %}

{% highlight C# %} 

SfTextInputLayout inputLayout = new SfTextInputLayout();
inputLayout.Hint = "Password";
inputLayout.EnablePasswordVisibilityToggle = true;
inputLayout.Content = new Entry() { Text = "1234" }; 

{% endhighlight %}

{% endtabs %}

![Enable password toggling image](images/GettingStarted/PasswordGettingStarted.png)

N> Password visibility toggle can be enabled only for the [Entry](https://learn.microsoft.com/en-us/dotnet/maui/user-interface/controls/entry) control.

You can find the complete getting started sample from this [link.](https://github.com/SyncfusionExamples/maui-textinputlayout-samples)

N> You can refer to our [.NET MAUI Text Input Layout](https://www.syncfusion.com/maui-controls/maui-textinputlayout) feature tour page for its groundbreaking feature representations. You can also explore our [.NET MAUI Text Input Layout Example](https://github.com/syncfusion/maui-demos/tree/master/MAUI/TextInputLayout) that shows you how to render the Text Input Layout in .NET MAUI.

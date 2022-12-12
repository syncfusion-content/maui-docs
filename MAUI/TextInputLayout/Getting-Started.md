---
layout: post
title: Getting Started with .NET MAUI Text Input Layout control | Syncfusion
description: Learn here about getting started with Syncfusion .NET MAUI Text Input Layout (SfTextInputLayout) control, its elements and more.
platform: maui
control: SfTextInputLayout
documentation: ug
---

# Getting Started with .NET MAUI Text Input Layout (SfTextInputLayout)

This section explains the steps required to configure the `.NET MAUI Text Input Layout` (SfTextInputLayout) control with floating label.

## Creating an application using the .NET MAUI Text Input Layout

This section explains the steps required to work with the `SfTextInputLayout` control for .NET MAUI.

## Adding .NET MAUI Text Input Layout reference

The Syncfusion .NET MAUI controls are available in [Nuget.org](https://www.nuget.org/). To add `.NET MAUI Text Input Layout` to your project, open the NuGet package manager in Visual Studio, search for [Syncfusion.Maui.Core](https://www.nuget.org/packages/Syncfusion.Maui.Core/) and then install it.

## Handler registration 

 In the MauiProgram.cs file, register the handler for Syncfusion core.

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


## Adding a namespace

Add the following namespace to add `.NET MAUI Text Input Layout.

{% tabs %}

{% highlight xaml %}

    xmlns:inputLayout="clr-namespace:Syncfusion.Maui.Core;assembly=Syncfusion.Maui.Core"
	
{% endhighlight %}

{% highlight c# %}

    using Syncfusion.Maui.Core;

{% endhighlight %}

{% endtabs %}

### Adding the .NET MAUI Text Input Layout control

Add any input view control such as [`Entry`](https://learn.microsoft.com/en-us/dotnet/maui/user-interface/controls/entry) and [`Editor`](https://learn.microsoft.com/en-us/dotnet/maui/user-interface/controls/editor), [`SfAutocomplete`](https://help.syncfusion.com/maui/autocomplete/overview), [`SfComboBox`](https://help.syncfusion.com/maui/combobox/overview) controls and add hint label (floating label).

{% tabs %} 

{% highlight xaml %} 

<inputLayout:SfTextInputLayout>
   <Entry />
</inputLayout:SfTextInputLayout>  

{% endhighlight %}

{% highlight C# %} 

var inputLayout = new SfTextInputLayout();
inputLayout.Content = new Entry(); 

{% endhighlight %}

{% endtabs %}

### Adding hint
Floating label for the text input layout can be added by setting the `Hint` property. Visibility of the hint can be collapsed by setting the `ShowHint` property to `false`. By default, this property is set to `true`.

{% tabs %} 

{% highlight xaml %} 

<inputLayout:SfTextInputLayout Hint="Name">
   <Entry />
</inputLayout:SfTextInputLayout>  

{% endhighlight %}

{% highlight C# %} 

var inputLayout = new SfTextInputLayout();
inputLayout.Hint = "Name"; 
inputLayout.Content = new Entry(); 

{% endhighlight %}

{% endtabs %}

When focusing the input view, the hint label will be moved to the top position; it will be returned to the original position when proceeding further (on unfocused) without entering any value.

Run the project, and check if you get following output to make sure that the project has been configured properly to add the text input layout control.

![Adding hint](images/GettingStarted/GettingStarted.png)

## Enabling password visibility toggle

The password visibility toggle is used to show or hide the visibility of characters in the input view added to the control. You can enable this toggle by setting the `EnablePasswordVisibilityToggle` property to `true`.

{% tabs %} 

{% highlight xaml %} 

<inputLayout:SfTextInputLayout	Hint="Password"
								EnablePasswordVisibilityToggle="true">
    <Entry Text="1234" />
</inputLayout:SfTextInputLayout>  
 
{% endhighlight %}

{% highlight C# %} 

var inputLayout = new SfTextInputLayout();
inputLayout.Hint = "Password";
inputLayout.EnablePasswordVisibilityToggle = true;
inputLayout.InputView = new Entry() { Text = "1234" }; 

{% endhighlight %}

{% endtabs %}

![Enable password toggling image](images/GettingStarted/PasswordGettingStarted.png)

N> Password visibility toggle can be enabled only for [Entry](https://learn.microsoft.com/en-us/dotnet/maui/user-interface/controls/entry) control.

You can find the complete getting started sample from this [link.]( https://github.com/SyncfusionExamples/Getting-started-SfTextInputLayout-.NET MAUI)



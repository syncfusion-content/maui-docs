---
layout: post
title: Essential® UI Kit for .NET MAUI | MAUI | Syncfusion® 
description: The Syncfusion® Essential® UI Kit for .NET MAUI extension provides predefined design screens for MAUI apps in JetBrains Rider.
platform: maui
control: Syncfusion® Extensions
documentation: ug
---

# Essential® UI Kit for .NET MAUI

The Essential® UI Kit for .NET MAUI provides ready-to-use XAML templates, making it easy to design user interfaces for cross-platform applications in JetBrains Rider. It follows a structured separation of View, ViewModel, and Model classes, simplifying the integration of business logic and the modification of existing views.

N> Before using the **Essential® UI Kit for .NET MAUI - Syncfusion®**, ensure that the extension is installed in JetBrains Rider. Check the Plugin list in **Settings/Preferences > Plugin**. If it is not installed, follow the steps in the [download and installation](download-and-installation) guide to install it.

## Include XAML templates in MAUI apps

1. Open a new or existing MAUI application.

2. In the Rider project view, right-click on your MAUI project's **.csproj** file and select **Essential® UI Kit for .NET MAUI - Syncfusion®**. If the project is not fully loaded yet, wait until Rider finishes indexing and project sync before using the action.

3. Choose the pages you want to add, enter a name for the page, and then click **Add**.

4. The selected pages will be added, including **View, ViewModel, Model** classes, resource files, and the **Syncfusion® NuGet package** reference.

5. A Syncfusion® licensing registration message box will be shown if you installed the trial setup or NuGet packages, since Syncfusion® introduced the licensing system from 2018 Volume 2 (v16.2.0.41) Essential Studio® release.

## Run the UI template item

To set your desired UI template as the startup page of your application, open the App.xaml.cs file in your MAUI project and update it accordingly.

Example: If you added a Login page, make the necessary changes.

{% tabs %}
{% highlight C# hl_lines="3 9" %}

// In .NET MAUI apps (.NET 8 and later), use the CreateWindow override:

protected override Window CreateWindow(IActivationState? activationState)
{
    return new Window(new Login());
}

{% endhighlight %}
{% endtabs %}

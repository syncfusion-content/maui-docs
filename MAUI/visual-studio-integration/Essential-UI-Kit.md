---
layout: post
title: Essential® UI Kit for .NET MAUI | MAUI | Syncfusion®
description: The Syncfusion® Essential® UI Kit for .NET MAUI extension provides the predefined design screens for the MAUI apps.
platform: MAUI
control: Syncfusion® Extensions
documentation: UG
---

# Essential<sup>®</sup> UI Kit for .NET MAUI

The Essential<sup>®</sup> UI Kit for .NET MAUI offers ready-to-use XAML templates, allowing you to effortlessly design user interfaces for cross-platform applications. It facilitates a clear separation of the View, ViewModel, and Model classes, making it simple to integrate your business logic and modify existing views.

## Installation of Essential<sup>®</sup> UI Kit for .NET MAUI Extension

To begin with the Essential<sup>®</sup> UI Kit for .NET MAUI, install the appropriate extension in Visual Studio by downloading it from the marketplace. As a result, you’ll be able to access and utilize the Syncfusion<sup>®</sup> Extension directly from the Syncfusion<sup>®</sup> menu within your project.

[Visual Studio 2022](https://marketplace.visualstudio.com/items?itemName=SyncfusionInc.Essential-UI-Kit-MAUI)


## Include XAML templates in MAUI apps

1.	Launch a new or existing MAUI application.

2.	Select the **Essential<sup>®</sup> UI Kit for .NET MAUI** from the **Solution Explorer** by right-clicking on your **MAUI** project

	![Syncfusion<sup>®</sup> Essential<sup>®</sup> UI Kit for .NET MAUI Context menu in MAUI](Essential_UI_Kit_images/visual-studio-intergration-context-menu.png)

	N> The .NET MAUI Essential<sup>®</sup> UI Kit add-in appears when the project has the MAUI NuGet package as a reference and also, MAUI project should be a .NET Standard project.

3.	The Category dialogue box will then appear, with its pre-defined templates.

	![Add new item dialog box in MAUI Visual studio Intergration](Essential_UI_Kit_images/visual-studio-intergration-item-dialog-box.png)

4.	Select the required pages from any of the specified categories then click 'Next'.

5.	Enter a name for the page, then click 'Add' to include the page and the necessary class files, resources, and NuGet package references to your project.

	![Edit page Name in MAUI Visual studio Intergration](Essential_UI_Kit_images/visual-studio-intergration-page-name.png)

6.	The selected pages will be added along with View, View Model, Model classes, resource files and Syncfusion<sup>®</sup> NuGet package reference,

	![Added MVVM files in MAUI Visual Studio Intergration](Essential_UI_Kit_images/visual-studio-intergration-mvvm-files.png)

	![Added NuGet in MAUI Visual Studio Intergration](Essential_UI_Kit_images/visual-studio-intergration-nuget.png)

	![Added Resources in MAUI Visual Studio Intergration](Essential_UI_Kit_images/visual-studio-intergration-resources.png)

7.	A Syncfusion<sup>®</sup> licensing registration required message box will display if you installed the trial setup or NuGet packages since Syncfusion<sup>®</sup> introduced the licensing system from 2018 Volume 2 (v16.2.0.41) Essential Studio<sup>®</sup> release. Navigate to the [help topic](https://help.syncfusion.com/common/essential-studio/licensing/overview#how-to-generate-syncfusion-license-key), which is shown in the licensing message box to generate and register the Syncfusion<sup>®</sup> license key to your project. Refer to this [blog](https://www.syncfusion.com/blogs/post/whats-new-in-2018-volume-2.aspx) post for understanding the licensing changes introduced in Essential Studio<sup>®</sup>. 

## Run the UI template item

To set your preferred UI Template as the start page of your application, simply open the App.xaml.cs file in your MAUI project and make the following changes.

Example: If you added a **Login With Social Icon** Page,

{% tabs %}
{% highlight C# hl_lines="3 9" %}

// For .NET 8 Use this Below Code Snippet

MainPage = new LoginWithSocialIcon();

// For .NET 9 Use this Below Code Snippet

protected override Window CreateWindow(IActivationState? activationState)
{
    return new Window(new LoginWithSocialIcon());
}

{% endhighlight %}
{% endtabs %}

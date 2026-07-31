---
layout: post
title: Essential® UI Kit for .NET MAUI | MAUI | Syncfusion®
description: The Syncfusion® Essential® UI Kit for .NET MAUI extension provides the predefined design Screens for the MAUI Apps.
platform: maui
control: Syncfusion<sup>®</sup> Extensions
documentation: ug
---

# Essential<sup>®</sup> UI Kit for .NET MAUI

Essential<sup>®</sup> UI Kit for .NET MAUI comes with ready-to-use XAML templates, enabling you to effortlessly design user interfaces for cross-platform applications. It follows a clear separation of the View, ViewModel, and Model classes, making it easy to integrate your business logic and modify existing views.

## Installation of Essential<sup>®</sup> UI Kit for .NET MAUI Extension

To get started with the Essential<sup>®</sup> UI Kit for .NET MAUI, first install the appropriate extension in Visual Studio by downloading it from the marketplace. This will allow you to access and use the Syncfusion<sup>®</sup> Extension directly from the Syncfusion<sup>®</sup> menu within your project.

[Visual Studio 2022 or later](https://marketplace.visualstudio.com/items?itemName=SyncfusionInc.MAUIVSExtension)


## Include XAML templates in MAUI apps

1.	Launch a new or existing MAUI application.

2.	Select the **Essential<sup>®</sup> UI Kit for .NET MAUI** option from the **Solution Explorer** by right-clicking on your **MAUI** project.

	![Syncfusion Essential UI Kit for .NET MAUI Context menu in MAUI](Essential_UI_Kit_images/visual-studio-intergration-context-menu.png)

	N> The .NET MAUI Essential<sup>®</sup> UI Kit add-in will be shown in the context menu when the project has the .NET MAUI workload and references the Syncfusion .NET MAUI NuGet packages.

3.	The Category dialogue box will then appear, with its pre-defined templates.

	![Add new item dialog box in MAUI Visual Studio Integration](Essential_UI_Kit_images/visual-studio-intergration-item-dialog-box.png)

4.	Now, select the required pages from any of the specified categories then click 'Next'.

5.	Now add a name for the page, then click 'Add' to add the page and the necessary class files, resources, and NuGet package references to your project.

	![Edit page Name in MAUI Visual Studio Integration](Essential_UI_Kit_images/visual-studio-intergration-page-name.png)

6.	The selected pages will be added along with View, ViewModel, Model classes, resource files and Syncfusion<sup>®</sup> NuGet package reference.

	![Added MVVM files in MAUI Visual Studio Integration](Essential_UI_Kit_images/visual-studio-intergration-mvvm-files.png)

	![Added NuGet in MAUI Visual Studio Integration](Essential_UI_Kit_images/visual-studio-intergration-nuget.png)

	![Added Resources in MAUI Visual Studio Integration](Essential_UI_Kit_images/visual-studio-intergration-resources.png)

7.	Then, Syncfusion<sup>®</sup> licensing registration required message box will be shown if you installed the trial setup or NuGet packages since Syncfusion<sup>®</sup> introduced the licensing system from 2018 Volume 2 (v16.2.0.41) Essential Studio<sup>®</sup> release. Navigate to the [help topic](https://help.syncfusion.com/common/essential-studio/licensing/overview#how-to-generate-syncfusion-license-key), which is shown in the licensing message box to generate and register the Syncfusion<sup>®</sup> license key to your project. Refer to this [blog](https://www.syncfusion.com/blogs/post/whats-new-in-2018-volume-2.aspx) post for understanding the licensing changes introduced in Essential Studio<sup>®</sup>. 

## Run the UI template item

To set your preferred UI template as the start page of your application, open the **App.xaml.cs** file in your .NET MAUI project and apply the following changes.

Example: If you added Login With Social Icon Page,

{% tabs %}
{% highlight C# %}

// For .NET 8, use the below code snippet.

MainPage = new LoginWithSocialIcon();

{% endhighlight %}
{% highlight C# %}

// For .NET 9 or later, use the below code snippet.

protected override Window CreateWindow(IActivationState? activationState)
{
    return new Window(new LoginWithSocialIcon());
}

{% endhighlight %}
{% endtabs %}

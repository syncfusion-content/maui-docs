---
layout: post
title: .NET MAUI Essential® UI Kit | MAUI | Syncfusion®
description: The Syncfusion® .NET MAUI Essential® UI Kit extension provides the predefined design Screens for the MAUI Apps.
platform: maui
control: Syncfusion® Extensions
documentation: ug
---

# .NET MAUI Essential® UI Kit

.NET MAUI Essential® UI Kit for MAUI comes with ready-to-use XAML templates, enabling you to effortlessly design user interfaces for cross-platform applications. With a clear separation of the View, View Model, and Model classes, which makes the integration of your business logic and making changes to existing views simple.

## Installation of .NET MAUI Essential® UI Kit Extension

To get started with the .NET MAUI Essential® UI Kit, first install the appropriate extension in Visual Studio by downloading it from the marketplace. As a result, you’ll be able to access and utilize the Syncfusion® Extension directly from the Syncfusion® menu within your project

[Visual Studio 2022](https://marketplace.visualstudio.com/items?itemName=SyncfusionInc.Essential-UI-Kit-Xamarin-Forms)


## Include XAML templates in MAUI apps

1.	Launch a new or existing MAUI application.

2.	Select the **.NET MAUI Essential® UI Kit** from the **Solution Explorer** by right-clicking on your **MAUI** project

	![Syncfusion .NET MAUI Essential UI Kit Context menu in MAUI](Essential_UI_Kit_images/visual-studio-intergration-context-menu.png)

	N> The .NET MAUI Essential® UI Kit add-in will be shown when the project has the MAUI NuGet package as a reference and also, MAUI project should be a NET Standard project.

3.	The Category dialogue box will then appear, with its pre-defined templates.

	![Add new item dialog box in MAUI Visual studio Intergration](Essential_UI_Kit_images/visual-studio-intergration-item-dialog-box.png)

4.	Now, select the required pages from any of the specified categories then click 'Next'.

5.	Now add an name for the page, then click 'Add' to add the page and The necessary class files, resources, and NuGet package references to your project.

	![Edit page Name in MAUI Visual studio Intergration](Essential_UI_Kit_images/visual-studio-intergration-page-name.png)

6.	The selected pages will be added along with View, View Model, Model classes, resource files and Syncfusion NuGet package reference,

	![MVVM files in MAUI Visual Studio Intergration](Essential_UI_Kit_images/visual-studio-intergration-mvvm-files.png)

	![Added NuGet in MAUI Visual Studio Intergration](Essential_UI_Kit_images/visual-studio-intergration-nuget.png)

	![Added Resources in MAUI Visual Studio Intergration](Essential_UI_Kit_images/visual-studio-intergration-resources.png)

7.	Then, Syncfusion® licensing registration required message box will be shown if you installed the trial setup or NuGet packages since Syncfusion® introduced the licensing system from 2018 Volume 2 (v16.2.0.41) Essential Studio release. Navigate to the [help topic](https://help.syncfusion.com/common/essential-studio/licensing/overview#how-to-generate-syncfusion-license-key), which is shown in the licensing message box to generate and register the Syncfusion® license key to your project. Refer to this [blog](https://www.syncfusion.com/blogs/post/whats-new-in-2018-volume-2.aspx) post for understanding the licensing changes introduced in Essential Studio. 

## Run the UI template item

To set your preferred UI Template as the start page of your application, simply open the App.xaml.cs file in your MAUI project and make the following changes.

{% highlight xaml %}

MainPage=new PageName();

{% endhighlight %}

Example: If you added Login With Social Icon Page,

{% highlight xaml %}

MainPage=new LoginWithSocialIcon();

{% endhighlight %}
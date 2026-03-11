---
layout: post
title: Create Projects using Project Templates via Extensions | Syncfusion®
description: Learn here about how to create syncfusion® .NET MAUI application using Syncfusion® .NET MAUI Extension for Visual Studio Code.
platform: MAUI
component: Common
documentation: ug
---

# Creating a Syncfusion<sup>®</sup> .NET MAUI application

Syncfusion<sup>®</sup> provides a .NET MAUI Project Template for building applications with Syncfusion<sup>®</sup> components in Visual Studio Code. This template includes all the necessary components, NuGet references, namespaces, and code snippets needed for development. It also features a project wizard that streamlines the process of creating .NET MAUI applications using Syncfusion<sup>®</sup> components.

N> Syncfusion<sup>®</sup> Visual Studio Code project templates now support .NET MAUI project templates starting from `v25.1.35`.

The following steps below will assist you to create your **Syncfusion<sup>®</sup> .NET MAUI Application** through **Visual Studio Code:**

1.	To create a Syncfusion<sup>®</sup> .NET MAUI application in Visual Studio Code, open the command palette by pressing **Ctrl+Shift+P**. Then, search for **Syncfusion<sup>®</sup>** in the Visual Studio Code palette to access the templates provided by Syncfusion<sup>®</sup>.

    ![CreateProjectPalette](images/CreateProjectPalette.png)

2.	Select **Syncfusion<sup>®</sup> .NET MAUI Template Studio: Launch** and press **Enter**. This will open the Template Studio wizard for configuring your Syncfusion<sup>®</sup> .NET MAUI application. Enter a unique **Project Name** to identify your app, then specify the **Project Location**—the directory where your project files will be saved. Make sure the selected location meets your project requirements.

    ![CreateProject](images/TemplateStudioWizard.png)

3.	To select a component, click the **Next** button or the **Components** tab. From there, you can add the desired Syncfusion<sup>®</sup> .NET MAUI components to your application. Simply choose the necessary Syncfusion<sup>®</sup> .NET MAUI components for your project.

    ![SelectComponents](images/MAUIControlSelection.gif)

    Select the required component(s) by clicking on the corresponding checkbox.

    Choose the required component(s) by clicking the corresponding component box.

    To unselect the added component(s), use either one of the following options:

    **Option 1:** Click the corresponding selected component checkbox.

    **Option 2:** Click **‘x’** button for the corresponding component in the component list from **Components Selected**.

    N> **Note:** Select at least one control to enable the **Features** tab.

4. The features for the selected controls will be displayed when you click the **Next** button or the **Features** tab. From there, you can select or unselect the desired features for your selected components.

    ![SelectFeatures](images/MAUIControlFeatureSelection.gif)

    **Project Summary section**

    In the **Project Summary** section, you can customize the **Project Name** to uniquely identify your application and specify the **Project Location**, which is the directory where your project files will be saved. You can also adjust the **Configuration Settings** by removing one or more controls from the **Components Selected** list. Additionally, choose your preferred **Core Version** (.NET 9.0 or .NET 10.0) and **Theme** (Material Light or Material Dark).

    ![ProjectSummary](images/MAUIProjectSummary.png)

5.	Click the **Create** button to generate the Syncfusion<sup>®</sup> .NET MAUI application. The created application includes the necessary Syncfusion<sup>®</sup> NuGet packages and rendering code for the selected Syncfusion<sup>®</sup>components.

6.  To view the Syncfusion<sup>®</sup> components in your application, run it by pressing **F5** or selecting **Run > Start Debugging**. Then, search for **.NET MAUI** and select it to launch the application.

    ![Debug](images/Debug.gif)

    N> **Note:** If the .NET MAUI extension is a preview version, the debugger will be listed as **.NET MAUI**. However, if the .NET MAUI extension is stable, this configuration will be replaced with **C#**.

7.	The Syncfusion<sup>®</sup> .NET MAUI application is configured with the latest NuGet package versions, namespaces, and component rendering code for Syncfusion<sup>®</sup> components.

8.	If you installed the trial setup or NuGet packages from nuget.org you must register the Syncfusion<sup>®</sup> license key to your application since Syncfusion<sup>®</sup> introduced the licensing system from 2018 Volume 2 (v16.2.0.41) Essential Studio<sup>®</sup> release. Navigate to the [help topic](https://help.syncfusion.com/common/essential-studio/licensing/overview#how-to-generate-syncfusion-license-key) to generate and register the Syncfusion® license key to your application. Refer to this [blog](https://www.syncfusion.com/blogs/post/whats-new-in-2018-volume-2.aspx?_ga=2.11237684.1233358434.1587355730-230058891.1567654773) post for understanding the licensing changes introduced in Essential Studio<sup>®</sup>.


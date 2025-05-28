---
layout: post
title: Create Projects using Project Templates via Extensions | Syncfusion®
description: Learn how to create syncfusion® .NET MAUI application using the Syncfusion® .NET MAUI Extension for Visual Studio Code.
platform: MAUI
component: Common
documentation: UG
---

# Creating a Syncfusion<sup>®</sup> .NET MAUI Application

Syncfusion<sup>®</sup> offers the .NET MAUI Project Template for building .NET MAUI applications using Syncfusion<sup>®</sup> components in Visual Studio Code. This template includes all the necessary Syncfusion<sup>®</sup> components, NuGet references, namespaces, and code snippets required for developing .NET MAUI applications with Syncfusion<sup>®</sup>. The **.NET MAUI Project Template** features a project wizard to streamline the application creation process using Syncfusion<sup>®</sup> components.

N> Syncfusion<sup>®</sup> Visual Studio Code project templates now support .NET MAUI project templates starting from `v25.1.35`.

The following steps below will assist you to create your **Syncfusion<sup>®</sup> .NET MAUI Application** through **Visual Studio Code:**

1.	**Open the Command Palette**: Launch Visual Studio Code and open the command palette by pressing **Ctrl+Shift+P**. Search for **Syncfusion<sup>®</sup>** to access the templates provided by Syncfusion<sup>®</sup>.

    ![CreateProjectPalette](images/CreateProjectPalette.png)

2.	**Launch Template Studio**: Select **Syncfusion<sup>®</sup> .NET MAUI Template Studio: Launch** and press **Enter**. This will open the Template Studio wizard for configuring the Syncfusion<sup>®</sup> .NET MAUI application. Enter a unique **Project Name** and specify the **Project Location**, ensuring it meets your project's requirements.

    ![CreateProject](images/TemplateStudioWizard.png)

3.	**Select Components**: Click the **Next** button or navigate to the **Components** tab to select the desired Syncfusion<sup>®</sup> .NET MAUI components for your application by clicking the relevant checkboxes.

    ![SelectComponents](images/MAUIControlSelection.gif)

    Select the required component(s) by clicking on the corresponding checkbox.

    Choose the required component(s) by clicking the corresponding component box.

    To unselect the added component(s), use either one of the following options:

    **Option 1:** Click the corresponding selected component checkbox.

    **Option 2:** Click **‘x’** button for the corresponding component in the component list from **Components Selected**.

    N> **Note:** Select at least one control to enable the **Features** tab.

4. **Select Features**: The features for the selected controls will appear when you click the **Next** button or go to the **Features** tab. From here, select or unselect the desired features for your components.

    ![SelectFeatures](images/MAUIControlFeatureSelection.gif)

    **Project Summary section**

    In the **Project Summary** section, you can customize the **Project Name** to uniquely identify your application and specify the **Project Location**, which is the directory where your project files will be saved. You can also adjust the **Configuration Settings** by removing one or more controls from the **Components Selected** list. Additionally, choose your preferred **Core Version** (.NET 8.0 or .NET 9.0) and **Theme** (Material Light or Material Dark).

    ![ProjectSummary](images/MAUIProjectSummary.png)

5.	**Generate the Application**: Click the **Create** button to generate the Syncfusion<sup>®</sup> .NET MAUI application. This application will include the required Syncfusion<sup>®</sup> NuGet packages and rendering code for your selected components.

6.  **Run the Application**: To view the Syncfusion<sup>®</sup> components in your application, run it by pressing **F5** or selecting **Run > Start Debugging**. Then, search for **.NET MAUI** and select it to launch the application.

    ![Debug](images/Debug.gif)

    N> **Note:** If the .NET MAUI extension is a preview version, the debugger will be listed as **.NET MAUI**. However, if the .NET MAUI extension is stable, this configuration will be replaced with **C#**.

7.	**Configured Application**: The Syncfusion<sup>®</sup> .NET MAUI application is automatically configured with the latest Syncfusion<sup>®</sup> .NET MAUI NuGet packages, namespaces, and component rendering code.

8.	**License Key Registration**: If you installed the trial setup or NuGet packages from nuget.org you must register the Syncfusion<sup>®</sup> license key to your application since Syncfusion<sup>®</sup> introduced the licensing system from 2018 Volume 2 (v16.2.0.41) Essential Studio<sup>®</sup> release. Navigate to the [help topic](https://help.syncfusion.com/common/essential-studio/licensing/overview#how-to-generate-syncfusion-license-key) to generate and register the Syncfusion® license key to your application. Refer to this [blog](https://www.syncfusion.com/blogs/post/whats-new-in-2018-volume-2.aspx?_ga=2.11237684.1233358434.1587355730-230058891.1567654773) post for understanding the licensing changes introduced in Essential Studio<sup>®</sup>.

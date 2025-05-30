---
layout: post
title: Code Snippets - .NET MAUI Extension Visual Studio Code | Syncfusion®
description: Learn here all about how to use code snippet utility of Syncfusion® .NET MAUI Extension for Visual Studio Code and much more.
platform: MAUI
component: Common
documentation: ug
---

# Add Syncfusion<sup>®</sup> .NET MAUI component in the .NET MAUI application

The Syncfusion<sup>®</sup> .NET MAUI Code Sample Utility for Visual Studio Code provides ready-to-use samples for easily inserting Syncfusion<sup>®</sup> .NET MAUI components with various features into the XAML editor of your .NET MAUI application.

N> The Syncfusion<sup>®</sup> .NET MAUI code sample is available from Essential Studio<sup>®</sup> 2024 Volume 1 (`v25.1.35`) onwards.

## Add a Syncfusion<sup>®</sup> .NET MAUI component

The following instructions outline the process of using the Syncfusion<sup>®</sup> .NET MAUI code snippet in your .NET MAUI application.

1.	In Visual Studio Code, either open an existing .NET MAUI application or create a new .NET MAUI Application.

2.	Open the XAML file you require and position the cursor where you want to add the Syncfusion<sup>®</sup> component.

3.	To access Syncfusion<sup>®</sup> .NET MAUI components with various features, type the **sf** word in the specified format.

```
sf<Syncfusion® component name>-<Syncfusion® component feature>
For Example, sf-datagrid-grouping
```

4.	Select the desired Syncfusion<sup>®</sup> component and press the **Enter** or **Tab** key to add the Syncfusion<sup>®</sup> .NET MAUI component to the XAML file. 

      ![Code Snippet](images/MAUI_CodeSnippets.gif)

5.	After adding the Syncfusion<sup>®</sup> .NET MAUI component to the XAML file, We've included instructions in the **TODO** section for your reference. This will guide you in determining whether to add the the View Model file or if only add namespace and NuGet entries to run the Syncfusion<sup>®</sup> components.

     ![Comment](images/Comment.png)

6.	You can also find a Syncfusion<sup>®</sup> help link at the top of the added sample to learn more about the new Syncfusion<sup>®</sup> .NET MAUI component feature.

     ![Help](images/Help.png)

## Configure .NET MAUI application with Syncfusion<sup>®</sup>

The Syncfusion<sup>®</sup> .NET MAUI snippet inserts code into the XAML file. However, you need to configure the .NET MAUI project with Syncfusion<sup>®</sup> by installing the Syncfusion<sup>®</sup> .NET MAUI NuGet package and adding the appropriate namespace. To configure, follow these steps:

1.	Open your .NET MAUI project file and manually add the required Syncfusion<sup>®</sup> .NET MAUI NuGet package(s) as package references for the components you want to use. We've provided commented code samples showing the corresponding NuGet entries for each component. Simply copy the relevant entry and paste it into your project file. The package will be automatically restored during the build or save process.

     ![NuGet Package](images/NuGetEntry.gif)

2.	To integrate Syncfusion<sup>®</sup> components into your application, open the XAML file and add the required Syncfusion<sup>®</sup> .NET MAUI namespace entries. We've provided commented code samples showing the appropriate namespace for each component. Simply copy the relevant entry and paste it into your XAML file.

    ![Namespace](images/NamespaceEntry.gif)
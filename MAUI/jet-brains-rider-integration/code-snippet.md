---
layout: post
title: Code Snippets - .NET MAUI Extension JetBrains Rider | Syncfusion®
description: Learn here all about how to use code snippet utility of Syncfusion® .NET MAUI Extension for JetBrains Rider and much more.
platform: MAUI
component: Common
documentation: ug
---

# Add Syncfusion® .NET MAUI component to your app

The Syncfusion® .NET MAUI Code Sample Utility for JetBrains Rider provides ready-to-use samples for easily inserting Syncfusion® .NET MAUI components with various features into the XAML editor of your .NET MAUI application.

N> The Syncfusion® .NET MAUI code sample is available from Essential Studio® 2024 Volume 1 (`v25.1.35`) onwards.

## Add a Syncfusion® .NET MAUI component

The following instructions outline the process of using the Syncfusion® .NET MAUI code snippet in your .NET MAUI application.

1. In JetBrains Rider, either open an existing .NET MAUI application or create a new .NET MAUI application.

2. Open the XAML file you require and position the cursor where you want to add the Syncfusion® component.

3. To access Syncfusion® .NET MAUI components with various features, type the **sf** word in the specified format.

```
sf<Syncfusion® component name>-<Syncfusion® component feature>
For Example, sf-datagrid-grouping
```

4. Select the desired Syncfusion® component and press the **Enter** or **Tab** key to add the Syncfusion® .NET MAUI component to the XAML file.

5. After adding the Syncfusion® .NET MAUI component to the XAML file, we've included instructions in the **TODO** section for your reference. This will guide you in determining whether to add the ViewModel file or if only namespace and NuGet entries are needed to run the Syncfusion® components.

6. You can also find a Syncfusion® help link at the top of the added sample to learn more about the new Syncfusion® .NET MAUI component feature.

## Configure .NET MAUI application with Syncfusion®

The Syncfusion® .NET MAUI snippet inserts code into the XAML file. However, you need to configure the .NET MAUI project with Syncfusion® by installing the Syncfusion® .NET MAUI NuGet package and adding the appropriate namespace. To configure, follow these steps:

1. Open your .NET MAUI project file and manually add the required Syncfusion® .NET MAUI NuGet package(s) as package references for the components you want to use. The appropriate package name(s) are indicated in the **TODO** instructions added above the inserted sample.

2. To integrate Syncfusion® components into your application, open the XAML file and add the required Syncfusion® .NET MAUI namespace entries.

---
layout: post
title: Essential UI Kit | MAUI | Syncfusion
description: The Syncfusion MAUI Essential UI Kit extension provides the predefined design for the MAUI.
platform: maui
control: Syncfusion Extensions
documentation: ug
---

# MAUI Essential UI Kit

Essential UI Kit for MAUI includes predefined XAML templates for MAUI apps. The UI kit allows to build a user interface in a cross-platform application. It clearly separates the View, View Model, and Model classes, making it simple to integrate your business logic and make changes to the existing view.  

## Installation of MAUI UI Kit Extension

Install the appropriate MAUI UI Kit Extension in Visual Studio by downloading them from the marketplace. As a result, you can use the Syncfusion Extension from your project's Syncfusion menu.

[Visual Studio 2022](https://marketplace.visualstudio.com/items?itemName=SyncfusionInc.Essential-UI-Kit-MAUI-VS-Extensions)

[Visual Studio 2019 or lower](https://marketplace.visualstudio.com/items?itemName=SyncfusionInc.Essential-UI-Kit-MAUI)

## Include XAML templates in MAUI apps

1.	Launch a new or existing MAUI application.

2.	Select the **Essential UI Kit for MAUI** from the **Solution Explorer** by right-clicking on your **MAUI** project

	![Syncfusion Essential UI Kit Context menu in MAUI](Essential_UI_Kit_images/visual-studio-intergration-context-menu.png)

	N> The Essential UI Kit for MAUI add-in will be shown when the project has the MAUI NuGet package as a reference and also, MAUI project should be a NET Standard project.

3.	The Category dialogue box will then appear, with its pre-defined template.

	![Add new item dialog box in MAUI Visual studio Intergration](Essential_UI_Kit_images/visual-studio-intergration-item-dialog-box.png)

4.	Now, select the required pages from any of the specified categories then click 'Next'.

5.	Now add an name for the page, then click 'Add' to add the page and The necessary class files, resources, and NuGet package references to your project.

	![Edit page Name in MAUI Visual studio Intergration](Essential_UI_Kit_images/visual-studio-intergration-page-name.png)

6.	The selected pages will be added along with View, View Model, Model classes, resource files and Syncfusion NuGet package reference,

	![MVVM files in MAUI Visual Studio Intergration](Essential_UI_Kit_images/visual-studio-intergration-mvvm-files.png)

	![Added NuGet in MAUI Visual Studio Intergration](Essential_UI_Kit_images/visual-studio-intergration-nuget.png)

	![Added Resources in MAUI Visual Studio Intergration](Essential_UI_Kit_images/visual-studio-intergration-resources.png)

7.	Then, Syncfusion licensing registration required message box will be shown if you installed the trial setup or NuGet packages since Syncfusion introduced the licensing system from 2018 Volume 2 (v16.2.0.41) Essential Studio release. Navigate to the [help topic](https://help.syncfusion.com/common/essential-studio/licensing/overview#how-to-generate-syncfusion-license-key), which is shown in the licensing message box to generate and register the Syncfusion license key to your project. Refer to this [blog](https://www.syncfusion.com/blogs/post/whats-new-in-2018-volume-2.aspx) post for understanding the licensing changes introduced in Essential Studio. 

## Run the UI template item

To set the desired UI Template item as the start page of your application, Open the **AppShell.xaml** of MAUI project and make the following changes.


1. Add the namespace as shown in the following code:
{% highlight xaml %}
xmlns:local="clr-namespace:ItemNameSpace"
{% endhighlight %} 
2. Set the template as Main Page by using the following code:
{% highlight xaml %}
<ShellContent
   Title="Home"
   ContentTemplate="{DataTemplate local:ItemName}"
   Route="ItemName" />
{% endhighlight %}

Example: If you added Login With Social Icon Page,

{% highlight xaml %}
<Shell
    . . . 
xmlns:local="clr-namespace:SampleFormsApplication.Views.Forms"/>
<ShellContent
   Title="Home"
   ContentTemplate="{DataTemplate local:LoginWithSocialIcon}"
   Route="LoginWithSocialIcon" />
{% endhighlight %}
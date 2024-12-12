---
layout: post
title: Getting Started with Essential® UI Kit for .NET MAUI | Syncfusion®
description: Learn here about getting started with Syncfusion® Essential® UI Kit for .NET MAUI control, its elements and more.
platform: maui
control: Essential® UI Kit for .NET MAUI
documentation: ug
---

# Getting Started with Essential® UI Kit for .NET MAUI

There are two ways for including the UI Kit screens into your application:

1. Using the Visual Studio extension's **Essential® UI Kit for .NET MAUI**.

2. Copying the files from our [GitHub repository](), which is open source.


## Essential® UI Kit for .NET MAUI Extension

This is the simplest way to integrate pre-defined screens into your application. Follow these steps to add screens to your app using our extension:

1. Open Visual Studio.

2. Go to **Extension**, and then click **Manage Extensions** as shown in the following screenshot.

   ![Visual Studio Extensions](UI-Kit-images/VS_Extensions.png)

3. Search for **Essential® UI Kit for .NET MAUI**, and then install it.

   ![Visual Studio Extensions and Updates](UI-Kit-images/Extension_Update.png)

4. Restart the Visual Studio and allow it to complete the installation. 

5. Now, open an existing MAUI application or create a new application as per your requirements.
 
6. Right-click the MAUI [NETStandard] project, and you can see the **Essential® UI Kit for .NET MAUI** option.

N> The **Essential® UI Kit for .NET MAUI** add-in will be shown when the project have the **MAUI** NuGet package as a reference and also, MAUI project should be a NETStandard project.

7. Select the category and pages you need to add in your application. In the following screenshot, the **Login with Social Icon** screen has been selected from the **Forms** category. 

   ![Visual Studio UIkit Category](UI-Kit-images/Essential_UIKit_Category.png)
8. Clicking the 'Next' button will navigate to the following page to add page name : 

   ![Visual Studio UIkit Category](UI-Kit-images/Essential_UIKit_PageName.png)

9. Clicking the 'Add' button will include the selected page to your project. The necessary class files, resources, and NuGet package references will automatically be added to your project as shown in the following screenshot.

   ![Visual Studio Ui Kit Resources](UI-Kit-images/Essential_UIKit_Resources.png)
   ![Visual Studio Ui Kit Resources](UI-Kit-images/Essential_UIKit_Nuget_Packages.png)
   ![Visual Studio Ui Kit Resources](UI-Kit-images/Essential_UIKit_ClassFiles.png)

## How to Render the Added Page?

In a MAUI demo application, to set the added page as the startup page, you need to define it in the **App.xaml.cs** file. For instance, if you’ve added the **Login with Social Icon Page**, you can set it as the startup page using the following code snippet:

{% tabs %}
{% highlight .NET 8 hl_lines="3" %}

MainPage = new LoginWithSocialIcon();

{% endhighlight %}

{% highlight .NET 9 hl_lines="3" %}

protected override Window CreateWindow(IActivationState? activationState)
{
    return new Window(new LoginWithSocialIcon());
}

{% endhighlight %}
{% endtabs %}

In real-world applications, you may need to do the following to use these XAML pages:
1. Update the services to fetch data from a remote server or local database.
2. Wire up the navigation and update the business logic in the view models.

## Requesting Screens and Reporting Bugs

If you would like to request a new screen or report a bug in existing screens, create a feature request or submit a bug through our [feedback portal](https://www.syncfusion.com/feedback/maui?control=ui-kit)
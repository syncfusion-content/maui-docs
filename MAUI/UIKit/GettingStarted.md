---
layout: post
title: Getting Started with Essential® UI Kit for .NET MAUI | Syncfusion®
description: Learn here about getting started with Syncfusion® Essential® UI Kit for .NET MAUI control, its elements and more.
platform: maui
control: Essential<sup>®</sup> UI Kit for .NET MAUI
documentation: ug
---

# Getting Started with Essential<sup>®</sup> UI Kit for .NET MAUI

There are two ways for including the UI Kit screens into your application:

1. Using the Visual Studio/Visual Studio Code extension's **Essential<sup>®</sup> UI Kit for .NET MAUI**.

2. Copying the files from our [GitHub repository](https://github.com/syncfusion/essential-ui-kit-for-.net-maui), which is open source.

To get start quickly with our **Essential<sup>®</sup> UI Kit for .NET MAUI**, you can check the below video.

{% youtube
"youtube:https://www.youtube.com/watch?v=WvlfHnXLOjI"%}

## Essential<sup>®</sup> UI Kit for .NET MAUI Extension

This is the simplest way to integrate pre-defined screens into your application. Follow these steps to add screens to your app using our extension:

{% tabcontents %}
{% tabcontent Visual Studio %}

1. Open Visual Studio.

2. Go to **Extension**, and then click **Manage Extensions** as shown in the following screenshot.

   ![Visual Studio Extensions](UI-Kit-images/VS_Extensions.png)

3. Search for **Essential<sup>®</sup> UI Kit for .NET MAUI**, and then install it.

   ![Visual Studio Extensions and Updates](UI-Kit-images/Extension_Update.png)

4. Restart the Visual Studio and allow it to complete the installation. 

5. Now, open an existing MAUI application or create a new application as per your requirements.
 
6. Right-click the MAUI [NETStandard] project, and you can see the **Essential<sup>®</sup> UI Kit for .NET MAUI** option.

N> The **Essential<sup>®</sup> UI Kit for .NET MAUI** add-in will be shown when the project have the **MAUI** NuGet package as a reference and also, MAUI project should be a NETStandard project.

7. Select the category and pages you need to add in your application. In the following screenshot, the **Login with Social Icon** screen has been selected from the **Forms** category. 

   ![Visual Studio UIkit Category](UI-Kit-images/Essential_UIKit_Category.png)
8. Clicking the 'Next' button will navigate to the following page to add page name : 

   ![Visual Studio UIkit Category](UI-Kit-images/Essential_UIKit_PageName.png)

9. Clicking the 'Add' button will include the selected page to your project. The necessary class files, resources, and NuGet package references will automatically be added to your project as shown in the following screenshot.

   ![Visual Studio Ui Kit Files](UI-Kit-images/Essential_UIKit_Files.png)

{% endtabcontent %}

{% tabcontent Visual Studio Code %}

1. Open Visual Studio Code.

2. Navigate to **View > Extensions**, and the Manage Extensions option will appear on the left side of the window. Alternatively, you can access the extensions by pressing **Ctrl+Shift+X**

    ![View-Tab](UI-Kit-images/Essential_UIKit_View.png)

3. By entering the keyword **Essential<sup>®</sup> UI Kit for .NET MAUI** in the search box, you can find the **Essential<sup>®</sup> UI Kit for .NET MAUI - Syncfusion<sup>®</sup>** Visual Studio Code extension in the Visual Studio Code Marketplace.

    ![Extensions](UI-Kit-images/Essential_UiKit_Extension.png)

4. Install the **Essential<sup>®</sup> UI Kit for .NET MAUI - Syncfusion<sup>®</sup>** extension by clicking the Install button.

5. After installation, reload Visual Studio Code using the **Reload Window** command in the Visual Studio Code command palette. You can access the command palette by pressing **Ctrl+Shift+P** and searching for Reload Window command.

    ![Reload-Window](UI-Kit-images/Reload-Window.png)

6. Now, open a new or existing MAUI application.

7. In File Explorer, right-click on your MAUI project's **.csproj** file and select **Essential<sup>®</sup>  UI Kit for .NET MAUI - Syncfusion<sup>®</sup>**. Alternatively, in **Solution Explorer**, right-click on your MAUI project's file, then select the same option for your MAUI project. Before launching the UI, ensure that the project is fully loaded, as this option will only be available if the project is fully loaded.

8. Choose the pages you want to add, enter a name for the page, and then click **Add**.

9. The selected pages will be added, including **View, ViewModel, Model** classes, resource files, and the **Syncfusion® NuGet package** reference.

   ![MAUI UI Kit Visual Studio Code](UI-Kit-images/visual-studio-code-maui-ui-kit.gif)

{% endtabcontent %}
{% endtabcontents %}

## How to Render the Added Page?

In a MAUI demo application, to set the added page as the startup page, you need to define it in the **App.xaml.cs** file. For instance, if you’ve added the **Login with Social Icon Page**, you can set it as the startup page using the following code snippet:

{% tabs %}
{% highlight C# hl_lines="3 9" %}

// For NET 8 Use this Below Code Snippet

MainPage = new LoginWithSocialIcon();

// For NET 9 Use this Below Code Snippet

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

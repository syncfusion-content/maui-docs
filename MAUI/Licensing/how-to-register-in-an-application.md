---
layout: post
title: About Essential Studio® .NET MAUI Licensing | Syncfusion®
description: Learn about Syncfusion® Essential Studio® .NET MAUI license key, including how to generate and register the license key.
platform: MAUI
control: Essential Studio<sup>®</sup>
documentation: UG
---


# License Key Registration

To ensure proper use of Syncfusion<sup>®</sup> controls, the generated license key needs to be registered before initiating any control. Use the following code snippet to register the license:

{% tabs %}
{% highlight c# %}
Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("YOUR LICENSE KEY");
{% endhighlight %}
{% endtabs %}

N> 
* Place the license key within double quotes.  
* Ensure that `Syncfusion.Licensing.dll` is referenced in your project where the license key is being registered.
* Syncfusion<sup>®</sup> license validation is done offline during application execution and does not require internet access.  Apps registered with a Syncfusion<sup>®</sup> license key can be deployed on any system that does not have an internet connection.

I> Syncfusion<sup>®</sup> license keys can be validated during the Continuous Integration (CI) processes to ensure proper licensing and prevent licensing errors during deployment. Refer to the [CI License Validation](https://help.syncfusion.com/maui/licensing/licensing-faq/ci-license-validation) section for detailed instructions on how to implement it.

### .NET MAUI

### 1. Registering license key in App.xaml.cs

You can register the license key in **App.xaml.cs** constructor before InitializeComponent(). If App constructor not available in **App.xaml.cs**, create the "App()" constructor in **App.xaml.cs** and register the license key inside the constructor.

{% tabs %}
{% highlight c# %}
public App()
{
	//Register Syncfusion<sup>®</sup> license
	Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("YOUR LICENSE KEY");
	
	InitializeComponent();
	
	MainPage = new AppShell();
}

{% endhighlight %}
{% endtabs %}


### 2. Registering license key in MauiProgram.cs

Register the license key in **MauiProgram.cs** when initializing or registering any Syncfusion<sup>®</sup> controls within this file. This ensures that all controls are fully licensed and functional from the moment the application starts. Add the license registration code inside the **CreateMauiApp** method in **MauiProgram.cs**.

{% tabs %}
{% highlight c# %}

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        // Register the Syncfusion license key
        Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("YOUR_LICENSE_KEY");
 
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureSyncfusionCore()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
            });

        return builder.Build();
    }
}

{% endhighlight %}
{% endtabs %}

N> For common licensing errors, refer to this [link](https://help.syncfusion.com/maui/licensing/licensing-errors).
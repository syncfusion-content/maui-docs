---
layout: post
title: About Essential Studio .NET MAUI Licensing | Syncfusion
description: Learn here about Syncfusion Essential Studio .NET MAUI license key, how to generate the license key, how to register the license key, and more details.
platform: MAUI
control: Essential Studio
documentation: ug
---


# License Key Registration

The generated license key is just a string that needs to be registered before any Syncfusion control is initiated. The following code is used to register the license.

{% tabs %}
{% highlight c# %}
Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("YOUR LICENSE KEY");
{% endhighlight %}
{% endtabs %}

N> * Place the license key between double quotes.  Also, ensure that Syncfusion.Licensing.dll is referenced in your project where the license key is being registered.
* Syncfusion license validation is done offline during application execution and does not require internet access.  Apps registered with a Syncfusion license key can be deployed on any system that does not have an internet connection.

I> Syncfusion license keys can be validated during the Continuous Integration (CI) processes to ensure proper licensing and prevent licensing errors during deployment. Refer to the [CI License Validation](https://help.syncfusion.com/maui/licensing/licensing-faq/ci-license-validation) section for detailed instructions on how to implement it.

### .NET MAUI

You can register the license key in **App.xaml.cs** constructor before InitializeComponent(). If App constructor not available in **App.xaml.cs**, create the "App()" constructor in **App.xaml.cs** and register the license key inside the constructor.

{% tabs %}
{% highlight c# %}
public App()
{
	//Register Syncfusion license
	Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("YOUR LICENSE KEY");
	
	InitializeComponent();
	
	MainPage = new AppShell();
}

{% endhighlight %}
{% endtabs %}



N> Refer to this [link](https://help.syncfusion.com/maui/licensing/licensing-errors) for common licensing errors
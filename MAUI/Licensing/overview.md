---
layout: post
title: About Essential Studio® .NET MAUI Licensing | Syncfusion®
description: Learn about Syncfusion® Essential Studio® .NET MAUI license key, how to generate the license key, how to register the license key, and more details.
platform: MAUI
control: Essential Studio<sup>®</sup>
documentation: UG
---


<style>
#license {
    font-size: .88em!important;
margin-top: 1.5em;     margin-bottom: 1.5em;
    background-color: #fbefca;
    padding: 10px 17px 14px;
}
</style>

# Syncfusion<sup>®</sup> Licensing in .NET MAUI

We have introduced a new licensing system starting with the version 20.2.0.x release of Essential Studio<sup>®</sup>. These modifications apply to all evaluators and paid customers who use NuGet packages from [nuget.org](https://www.nuget.org/). Starting with v20.2.0.x, if you use the evaluation installer or the NuGet feed to reference Syncfusion<sup>®</sup> assemblies, you must also include the corresponding platform and version license key in your projects.

## Difference between unlock key and license key

Please note that this license key is different from the installer unlock key that you might have used in the past and needs to be separately generated from Syncfusion<sup>®</sup> website. Refer to this KB [article](https://support.syncfusion.com/kb/article/7863/difference-between-the-unlock-key-and-licensing-key) to know more about the difference between the Syncfusion<sup>®</sup> Unlock Key and the Syncfusion<sup>®</sup> License Key.

Following licensing error will be shown if the license key is not registered in your projects, while using assemblies from evaluation installer or from the nuget.org.

<div id="license">

This application was built using a trial version of Syncfusion<sup>®</sup> Essential Studio<sup>®</sup>. Please include a valid license to permanently remove this license validation message. You can also obtain a free 30 day evaluation license to temporarily remove this message during the evaluation period. Please refer to this <a href="/maui/licensing/overview">help topic</a> for more information

</div>

## Registering Syncfusion<sup>®</sup> license keys in Build server

| Source of Syncfusion<sup>®</sup> assemblies | Details | License Key needs to be registered? | Where to get license key from |
| ------------- | ------------- | ------------- | ------------- |
| **NuGet package** | If the Syncfusion<sup>®</sup> assemblies used in the Build Server are from the Syncfusion<sup>®</sup> NuGet packages, there is no need to install any Syncfusion<sup>®</sup> installer. You can directly use the required Syncfusion<sup>®</sup> NuGet packages from [nuget.org](https://nuget.org/). <br><br>However, if using NuGet packages from the [nuget.org](https://www.nuget.org/packages?q=syncfusion), you must register the Syncfusion<sup>®</sup> license key in the application.| Yes | Use any developer license to [generate](https://help.syncfusion.com/maui/licensing/how-to-generate) keys for Build Environments as well. |
| **Trial installer** | If the Syncfusion<sup>®</sup> assemblies used in Build Server are from Trial Installer, you should register the license key in the application for the corresponding version and platforms, to avoid trial license warning. | Yes | Use any developer trial license to [generate](https://help.syncfusion.com/maui/licensing/how-to-generate) keys for Build Environments as well. |
| **Licensed installer** |If the Syncfusion<sup>®</sup> assemblies used in Build Server were from Licensed Installer, then there is no need to register the license keys.<br><br>You can [download](https://help.syncfusion.com/maui/installation/web-installer/how-to-download#download-the-license-version) and [install](https://help.syncfusion.com/maui/installation/web-installer/how-to-install) the licensed version of our installer. | No | Not applicable |

## See Also

* [How to Generate Syncfusion<sup>®</sup> .NET MAUI License Key?](https://help.syncfusion.com/maui/licensing/how-to-generate)
* [How to Register Syncfusion<sup>®</sup> License Key in the Application?](https://help.syncfusion.com/maui/licensing/how-to-register-in-an-application)

---
layout: post
title: About Essential Studio .NET MAUI Licensing | Syncfusion
description: Learn here about Syncfusion Essential Studio .NET MAUI license key, how to generate the license key, how to register the license key, and more details.
platform: MAUI
control: Essential Studio
documentation: ug
---


<style>
#license {
    font-size: .88em!important;
margin-top: 1.5em;     margin-bottom: 1.5em;
    background-color: #fbefca;
    padding: 10px 17px 14px;
}
</style>

# Syncfusion Licensing in .NET MAUI

We have introduced a new licensing system starting with version 20.2.0.x release of Essential Studio. These modifications apply to all evaluators and only to paid customers who use NuGet packages from [nuget.org](https://www.nuget.org/). Starting with v20.2.0.x, if you use the evaluation installer or the NuGet feed to reference Syncfusion assemblies, you must also include the corresponding platform and version license key in your projects.

## Difference between unlock key and license key

Please note that this license key is different from the installer unlock key that you might have used in the past and needs to be separately generated from Syncfusion website. Refer [this](https://www.syncfusion.com/kb/8950/difference-between-the-unlock-key-and-licensing-key) KB article to know more about difference between the Syncfusion Unlock Key and the Syncfusion License Key.

Following licensing error will be shown if the license key is not registered in your projects, while using assemblies from evaluation installer or from the nuget.org.

<div id="license">

This application was built using a trial version of Syncfusion Essential Studio. Please include a valid license to permanently remove this license validation message. You can also obtain a free 30 day evaluation license to temporarily remove this message during the evaluation period. Please refer to this <a href="/maui/licensing/overview">help topic</a> for more information

</div>

## Registering license keys in server

| Source of Syncfusion assemblies | Details | License Key needs to be registered? | Where to get license key from |
| ------------- | ------------- | ------------- | ------------- |
| **NuGet package** | If the Syncfusion assemblies used in the build server are downloaded via Syncfusion NuGet packages, then there is no need to install any installation. The required Syncfusion NuGet packages are available from [nuget.org](http://nuget.org/). <br><br>However, if we use NuGet packages from [nuget.org](http://nuget.org/), we must register the Syncfusion license key in the application. | Yes | Any developer license can be used to [generate license keys](https://help.syncfusion.com/maui/licensing/how-to-generate) for build environments also |
| **Trial installer** | If we used trial Syncfusion assemblies in the build server, we should register the corresponding version and platform license key in the application to avoid the trial license warning. | Yes | Any developer trial license can be used to [generate license keys](https://help.syncfusion.com/maui/licensing/how-to-generate) for build environments also |
| **Licensed installer** |There is no need to register the licence keys if the Syncfusion assemblies used in the build server were obtained from a licenced installer. <br><br>You can [download](https://help.syncfusion.com/common/essential-studio/installation/web-installer/how-to-download#download-the-license-version) and [install](https://help.syncfusion.com/maui/installation/web-installer/how-to-install) the licensed version of our installer. | No | Not applicable |

You can [download](https://help.syncfusion.com/maui/installation/web-installer/how-to-download#download-the-license-version) and [install](https://help.syncfusion.com/maui/installation/web-installer/how-to-install) the licensed version of our installer.

## See Also

* [How to Generate Syncfusion .NET MAUI License Key?](https://help.syncfusion.com/maui/licensing/how-to-generate)
* [How to Register Syncfusion License Key in the Application?](https://help.syncfusion.com/maui/licensing/how-to-register-in-an-application)

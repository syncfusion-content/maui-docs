---
layout: post
title: Telemetry Usage Details in .NET MAUI | Syncfusion
description: Syncfusion® Telemetry collects anonymous usage data in .NET MAUI to improve product quality, track feature adoption, and guide product planning.
platform: .NET MAUI
component: Common
documentation: ug
---

# Syncfusion<sup>&reg;</sup> Telemetry  

Syncfusion<sup>&reg;</sup> Telemetry library collects **anonymous usage data** to improve product quality and user experience. This data helps us better understand product usage, feature adoption, usage trends, and make informed decisions about future product planning. 

Telemetry is **enabled by default**. However, you can disable it at any time if required. 

N> Telemetry is automatically disabled in production environments. No data is collected from deployed applications or end users.

## Why do we collect telemetry? 

We collect telemetry data to: 

* Understand feature adoption and usage trends 
* Identify frequently used components and frameworks 
* Prioritize future product planning and investments.
* Detect compatibility trends across:  
    * .NET versions 
    * Operating systems 
    * Development environments 

## What data is collected? 

Syncfusion<sup>&reg;</sup> collects only a limited set of anonymous usage data during development to understand product usage and improve product planning. The following data is collected **only in development mode:** 

<table>
    <thead>
        <tr>
            <th><b>Field</b></th>
            <th><b>Description</b></th>
        </tr>
    </thead>
    <tbody>
        <tr>
            <td>Architecture</td>
            <td>System architecture information (for example, x64 or x86).</td>
        </tr>
        <tr>
            <td>Component Name</td>
            <td>Name of the Syncfusion component being used.</td>
        </tr>
        <tr>
            <td>Feature Name</td>
            <td>Name of the Syncfusion feature being used.</td>
        </tr>
        <tr>
            <td>Assembly Name</td>
            <td>Name of the Syncfusion assembly or package in use.</td>
        </tr>
        <tr>
            <td>SDK Name</td>
            <td>Name of the Syncfusion SDK being used.</td>
        </tr>
        <tr>
            <td>SDK Version</td>
            <td>Version of the SDK shipped with the product.</td>
        </tr>
        <tr>
            <td>Framework</td>
            <td>Target development framework (for example, .NET or .NET Core).</td>
        </tr>
        <tr>
            <td>Framework Version</td>
            <td>Version of the target framework (for example, .NET 10.0.9).</td>
        </tr>
        <tr>
            <td>Operating System</td>
            <td>Operating system used during development.</td>
        </tr>
        <tr>
            <td>Session ID</td>
            <td>Unique session identifier stored as a hashed value.</td>
        </tr>
        <tr>
            <td>Machine Name</td>
            <td>Hashed machine name value that cannot be traced back to the original machine.</td>
        </tr>
        <tr>
            <td>Event Name</td>
            <td>Name of the product event being tracked.</td>
        </tr>
    </tbody>
</table>

N> No user-generated content (e.g., code, files, or personal data) is collected. 

## Where Does Telemetry Apply? 

Telemetry applies only to the use of Syncfusion<sup>&reg;</sup> products during development. 

* It is limited to **developer environments** 
* It focuses on **product and feature usage**
* It does **not apply to production applications** 
* It does **not collect any data from end users** 

Telemetry is designed solely to help improve the development experience and product quality, without impacting productions applications or users. 

## Telemetry in Development Mode Only 

Telemetry is designed to run only in development environments. 
* Enabled by default during development 
* Automatically disabled in production builds 
* No data is collected from deployed applications 

This ensures that telemetry does not affect your application users or production systems

## What information is Not collected?

Syncfusion<sup>&reg;</sup> does not collect:

* Personal information (name, email address, customer ID, company information)
* Source code
* Documents or files
* Application data
* User-generated content
* Business data
* Prompts or AI conversations
* Authentication credentials
* License keys
* Any information that can directly identify an individual

## How to Disable Telemetry (Opt-out)? 

You can disable telemetry in Syncfusion<sup>&reg;</sup> .NET MAUI products by calling the `Telemetry.Disable()` API before using any Syncfusion<sup>&reg;</sup> product APIs in your application. 

### Step 1: Add the telemetry namespace 

Add the following namespace in the `MauiProgram.cs` file where your application starts using Syncfusion<sup>&reg;</sup> components: 

{% tabs %} 

{% highlight c# tabtitle="C#" %}
using Syncfusion.Telemetry;
{% endhighlight %}

{% endtabs %}


### Step 2: Disable telemetry at application startup

Call the `Telemetry.Disable()` in `MauiProgram.cs` file before initializing or rendering any Syncfusion<sup>&reg;</sup> component. 

{% tabs %} 

{% highlight c# tabtitle="C#" %}
using Syncfusion.Telemetry; 

// Disable Syncfusion telemetry data collection. 
Telemetry.Disable();  
// Your Syncfusion product code follows here after disabling the telemetry.
{% endhighlight %}

{% endtabs %}

Now, the telemetry is disabled, you can continue using Syncfusion<sup>&reg;</sup> .NET MAUI products based on your application requirements. The Syncfusion<sup>&reg;</sup> product will work normally, but telemetry data will not be collected or sent. 

N> The `Telemetry.Disable()` API should be called, before creating or using any Syncfusion<sup>&reg;</sup> components. 

## FAQs

### Why am I getting "System.Net.Http.HttpRequestException - No such host is known" error?

<table>
    <thead>
        <tr>
            <th style="font-size:14px; width:100px;">Exception</th>
            <th style="font-size:14px;">
                Why am I getting "System.Net.Http.HttpRequestException - No such host is known" error?
            </th>
        </tr>
    </thead>
    <tbody>
        <tr>
            <th style="font-size:14px; width:100px;">Reason</th>
            <td>
                <p>This error may occur in the following scenarios:</p>
                <ul>
                    <li>Your application does not have internet connectivity.</li>
                    <li>All the exception settings are enabled in your application.</li>
                </ul>
                <p>
                    When exception handling is enabled and the application lacks internet access,
                    the telemetry module attempts to send data to Azure Application Insights,
                    which can trigger this exception.
                </p>
            </td>
        </tr>
        <tr>
            <th style="font-size:14px; width:100px;">Solution</th>
            <td>
                <p>
                    To resolve this error and prevent the exception from being thrown,
                    you can #how-to-disable-telemetry-opt-out
                    in your application. This will turn off telemetry data collection entirely.
                </p>
            </td>
        </tr>
    </tbody>
</table>
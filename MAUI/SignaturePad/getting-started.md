---
layout: post
title: Getting started with .NET MAUI SignaturePad control | Syncfusion®
description: Learn here about getting started with .NET MAUI SignaturePad (SfSignaturePad) control, its elements, and more.
platform: maui
control: SfSignaturePad
documentation: ug
---

# Getting Started with .NET MAUI SignaturePad

This section guides you through setting up and configuring a [SignaturePad](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SignaturePad.SfSignaturePad.html) in your .NET MAUI application. Follow the steps below to add a basic SignaturePad to your project.

To quickly get started with the .NET MAUI SignaturePad, watch this video.

{% youtube "https://www.youtube.com/watch?v=gV2stNPCgYo" %}

{% tabcontents %}
{% tabcontent Visual Studio %}

## Prerequisites

Before proceeding, ensure the following are in place:

1. Install [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0) or later.
2. Set up a .NET MAUI environment with Visual Studio 2022 (v17.8 or later).

## Step 1: Create a New .NET MAUI Project

1. Go to **File > New > Project** and choose the **.NET MAUI App** template.
2. Name the project and choose a location. Then, click **Next**.
3. Select the .NET framework version and click **Create**.

## Step 2: Install the Syncfusion<sup>®</sup> MAUI SignaturePad NuGet Package

1. In **Solution Explorer**, right-click the project and choose **Manage NuGet Packages**.
2. Search for [Syncfusion.Maui.SignaturePad](https://www.nuget.org/packages/Syncfusion.Maui.SignaturePad) and install the latest version.
3. Ensure the necessary dependencies are installed correctly, and the project is restored.

## Step 3: Register the handler

 [Syncfusion.Maui.Core](https://www.nuget.org/packages/Syncfusion.Maui.Core) nuget is a dependent package for all Syncfusion<sup>®</sup> controls of .NET MAUI. In the MauiProgram.cs file, register the handler for Syncfusion<sup>®</sup> core.

{% highlight c# hl_lines="1 12" %} 
using Syncfusion.Maui.Core.Hosting;

namespace SignaturePadGettingStarted
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
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
}

{% endhighlight %}

## Step 4: Add a Basic SignaturePad

Import the [SfSignaturePad](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SignaturePad.SfSignaturePad.html) namespace and initialize the SignaturePad as shown below.

{% tabs %}

{% highlight xaml %}

<ContentPage
    . . .
    xmlns:signaturePad="clr-namespace:Syncfusion.Maui.SignaturePad;assembly=Syncfusion.Maui.SignaturePad">
        <signaturePad:SfSignaturePad />
</ContentPage>

{% endhighlight %}

{% highlight C# %}
using Syncfusion.Maui.SignaturePad;

namespace SignaturePadGettingStarted
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            // Creating a SignaturePad control.
            SfSignaturePad signaturePad = new SfSignaturePad();
            this.Content = signaturePad;
        }
    }
}

{% endhighlight %}

{% endtabs %}

{% endtabcontent %}
{% tabcontent Visual Studio Code %}

## Prerequisites

Before proceeding, ensure the following are set up:

1. Install [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0) or later is installed.
2. Set up a .NET MAUI environment with Visual Studio Code.
3. Ensure that the .NET MAUI extension is installed and configured as described [here.](https://learn.microsoft.com/en-us/dotnet/maui/get-started/installation?view=net-maui-8.0&tabs=visual-studio-code)

## Step 1: Create a New .NET MAUI Project

1. Open the Command Palette by pressing **Ctrl+Shift+P** and type **.NET:New Project** and press Enter.
2. Choose the **.NET MAUI App** template.
3. Select the project location, type the project name and press Enter.
4. Then choose **Create project**

## Step 2: Install the Syncfusion<sup>®</sup> MAUI SignaturePad NuGet Package

1. Press <kbd>Ctrl</kbd> + <kbd>`</kbd> (backtick) to open the integrated terminal in Visual Studio Code.
2. Ensure you're in the project root directory where your .csproj file is located.
3. Run the command `dotnet add package Syncfusion.Maui.SignaturePad` to install the Syncfusion<sup>®</sup> .NET MAUI SignaturePad package.
4. To ensure all dependencies are installed, run `dotnet restore`.

## Step 3: Register the handler

 [Syncfusion.Maui.Core](https://www.nuget.org/packages/Syncfusion.Maui.Core) nuget is a dependent package for all Syncfusion<sup>®</sup> controls of .NET MAUI. In the MauiProgram.cs file, register the handler for Syncfusion<sup>®</sup> core.

{% highlight c# hl_lines="1 12" %} 
using Syncfusion.Maui.Core.Hosting;

namespace SignaturePadGettingStarted
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
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
}

{% endhighlight %}

## Step 4: Add a Basic SignaturePad

Import the [SfSignaturePad](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SignaturePad.SfSignaturePad.html) namespace and initialize the SignaturePad as shown below.

{% tabs %}

{% highlight xaml %}

<ContentPage
    . . .
    xmlns:signaturePad="clr-namespace:Syncfusion.Maui.SignaturePad;assembly=Syncfusion.Maui.SignaturePad">
        <signaturePad:SfSignaturePad />
</ContentPage>

{% endhighlight %}

{% highlight C# %}

using Syncfusion.Maui.SignaturePad;

namespace SignaturePadGettingStarted
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            // Creating a SignaturePad control.
            SfSignaturePad signaturePad = new SfSignaturePad();
            this.Content = signaturePad;
        }
    }
}

{% endhighlight %}

{% endtabs %}

{% endtabcontent %}
{% endtabcontents %}

![SignaturePad default](images/getting-started/default.png)

## Customize signature stroke color

Customize the stroke color of the SignaturePad control by using the [StrokeColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SignaturePad.SfSignaturePad.html#Syncfusion_Maui_SignaturePad_SfSignaturePad_StrokeColor) property. The default stroke color is **Colors.Black**.

{% tabs %}

{% highlight xaml %}

<signaturePad:SfSignaturePad StrokeColor="Red" />

{% endhighlight %}

{% highlight C# %}

SfSignaturePad signaturePad = new SfSignaturePad();
signaturePad.StrokeColor = Colors.Red;

{% endhighlight %}

{% endtabs %}

![SignaturePad stroke color](images/getting-started/stroke-color.png)

## Customize signature stroke thickness

The thickness of the stroke drawn can be customized by setting the [MinimumStrokeThickness](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SignaturePad.SfSignaturePad.html#Syncfusion_Maui_SignaturePad_SfSignaturePad_MinimumStrokeThickness) and [MaximumStrokeThickness](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SignaturePad.SfSignaturePad.html#Syncfusion_Maui_SignaturePad_SfSignaturePad_MaximumStrokeThickness) properties. The [MinimumStrokeThickness](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SignaturePad.SfSignaturePad.html#Syncfusion_Maui_SignaturePad_SfSignaturePad_MinimumStrokeThickness) defines the minimum thickness of the stroke and the [MaximumStrokeThickness](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SignaturePad.SfSignaturePad.html#Syncfusion_Maui_SignaturePad_SfSignaturePad_MaximumStrokeThickness) defines the maximum thickness of the stroke that can be drawn based on the speed and impression we provide through gesture within its minimum and maximum stroke thickness ranges. So that the signature will be more realistic.

{% tabs %}

{% highlight xaml %}

<signaturePad:SfSignaturePad MinimumStrokeThickness="1"
                             MaximumStrokeThickness="6" />

{% endhighlight %}

{% highlight C# %}

SfSignaturePad signaturePad = new SfSignaturePad()
{
    MinimumStrokeThickness = 1,
    MaximumStrokeThickness = 6,
};

{% endhighlight %}

{% endtabs %}

![SignaturePad stroke thickness](images/getting-started/stroke-thickness.png)

## Saving the signature as an image

Save the signature drawn in the SignaturePad as an [ImageSource](https://learn.microsoft.com/en-us/dotnet/api/xamarin.forms.imagesource?view=xamarin-forms) using the [ToImageSource()](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SignaturePad.SfSignaturePad.html#Syncfusion_Maui_SignaturePad_SfSignaturePad_ToImageSource) method which can further be synchronized with your devices and documents that need your signature.

{% tabs %}

{% highlight xaml %}

<signaturePad:SfSignaturePad x:Name="signaturePad" />
<Button Text="Save"
        Clicked="OnSaveButtonClicked" />

{% endhighlight %}

{% highlight C# %}

SfSignaturePad signaturePad = new SfSignaturePad();
Button saveButton = new Button();
saveButton.Text="Save";
saveButton.Clicked += OnSaveButtonClicked;

private void OnSaveButtonClicked(object? sender, EventArgs e)
{
    ImageSource? source = signaturePad.ToImageSource();
}

{% endhighlight %}

{% endtabs %}

## Clear the existing signature in SignaturePad

Clear the signature drawn in the SignaturePad using the [Clear()](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SignaturePad.SfSignaturePad.html#Syncfusion_Maui_SignaturePad_SfSignaturePad_Clear) method as shown in the code snippet below:

{% tabs %}

{% highlight xaml %}

<signaturePad:SfSignaturePad x:Name="signaturePad" />
<Button Text="Clear"
        Clicked="OnClearButtonClicked" />

{% endhighlight %}

{% highlight C# %}

SfSignaturePad signaturePad = new SfSignaturePad();
Button clearButton = new Button();
clearButton.Text = "Clear";
clearButton.Clicked += OnClearButtonClicked;

private void OnClearButtonClicked(object? sender, EventArgs e)
{
    signaturePad.Clear();
}

{% endhighlight %}

{% endtabs %}

## Events

### DrawStarted

This event will be triggered when we start drawing in the SignaturePad. With this, [CancelEventArgs](https://learn.microsoft.com/en-us/dotnet/api/system.componentmodel.canceleventargs.-ctor?view=net-6.0#system-componentmodel-canceleventargs-ctor(system-boolean)) will be passed. Also, restrict the draw start action by setting [e.cancel](https://learn.microsoft.com/en-us/dotnet/api/system.componentmodel.canceleventargs.cancel?view=net-6.0#system-componentmodel-canceleventargs-cancel) as **true**.

{% tabs %}

{% highlight xaml %}

<signaturePad:SfSignaturePad DrawStarted="OnDrawStarted" />

{% endhighlight %}

{% highlight C# %}

SfSignaturePad signaturePad = new SfSignaturePad();
signaturePad.DrawStarted += OnDrawStarted;

private void OnDrawStarted(object? sender, CancelEventArgs e)
{
    e.Cancel = false;
}

{% endhighlight %}

{% endtabs %}

### DrawCompleted

This event will be triggered when we complete the drawing in the SignaturePad.

{% tabs %}

{% highlight xaml %}

<signaturePad:SfSignaturePad DrawCompleted="OnDrawCompleted" />

{% endhighlight %}

{% highlight C# %}

SfSignaturePad signaturePad = new SfSignaturePad();
signaturePad.DrawCompleted += OnDrawCompleted;

private void OnDrawCompleted(object? sender, EventArgs e)
{
}

{% endhighlight %}

{% endtabs %}

## Method

### Get Signature Points

Users can use the **GetSignaturePoints** method to retrieve the drawn signature points from the [SfSignaturePad](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SignaturePad.SfSignaturePad.html).

{% tabs %}
{% highlight xaml %}
<signaturePad:SfSignaturePad x:Name="signaturePad"
                             StrokeColor="Red"
                             MinimumStrokeThickness="1"
                             MaximumStrokeThickness="6" 
                             DrawCompleted="OnDrawCompleted"/>
{% endhighlight %}
{% highlight C# %}

SfSignaturePad signaturePad = new SfSignaturePad()
{
    StrokeColor = Colors.Red,
    MinimumStrokeThickness = 1,
    MaximumStrokeThickness = 6, 
    DrawCompleted += OnDrawCompleted
};

private void OnDrawCompleted(object? sender, EventArgs e)
{
    List<List<float>> pointsCollection = new List<List<float>>();
    pointsCollection = signaturePad.GetSignaturePoints();
}

{% endhighlight %}
{% endtabs %}

N> You can refer to our [.NET MAUI SignaturePad](https://www.syncfusion.com/maui-controls/maui-signaturepad) feature tour page for its groundbreaking feature representations. You can also explore our [.NET MAUI SignaturePad Example](https://github.com/syncfusion/maui-demos/tree/master/MAUI/SignaturePad) that shows you how to render the SignaturePad in .NET MAUI.
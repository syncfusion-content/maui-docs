---
layout: post
title: Getting started with .NET MAUI Signature Pad control | Syncfusion
description: Learn here about getting started with .NET MAUI Signature Pad (SfSignaturePad) control, its elements, and more.
platform: maui
control: SfSignaturePad
documentation: ug
---

# Getting Started with .NET MAUI SignaturePad 

This section explains the steps required to add the SignaturePad control and its elements such as minimum and maximum stroke thickness, and stroke color. This section also covers how to save the signature as image, clear the existing signature in SignaturePad and handle the `DrawStarted` and `DrawCompleted` callbacks in the SignaturePad control.

## Creating an application with .NET MAUI

Create a new .NET MAUI application in Visual Studio.

 ![Create MAUI Application](images/getting-started/create-project.png)

## Adding SfSignaturePad reference

 Syncfusion .NET MAUI components are available in [nuget.org](https://www.nuget.org/). To add SfSignaturePad to your project, open the NuGet package manager in Visual Studio, search for Syncfusion.Maui.SignaturePad and then install it.

 ![Create MAUI Application](images/getting-started/nuget-installation.png)


## Handler registration

In the MauiProgram.cs file, register the handler for Syncfusion core

{% highlight C# %}

using Syncfusion.Maui.Core.Hosting;
using Syncfusion.Maui.SignaturePad.Hosting;

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
            .ConfigureSyncfusionSignaturePad()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
            });

            return builder.Build();
        }
    }
}

{% endhighlight %}

## Initialize signature pad

Import the `SfSignaturePad` namespace and initialize the signature pad as shown below.

{% tabs %}

{% highlight xaml %}

<ContentPage
    . . .
    xmlns:signaturePad="clr-namespace:Syncfusion.Maui.SignaturePad;assembly=Syncfusion.Maui.SignaturePad">
    <Grid>
        <signaturePad:SfSignaturePad />
    </Grid>
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
            this.content = signaturePad;
        }
    }
}

{% endhighlight %}

{% endtabs %}

![SignaturePad default](images/getting-started/default.jpg)

## Customize signature stroke color

You can customize the stroke color of the SignaturePad control by using the `StrokeColor` property. The default stroke color is `Colors.Black`.

{% tabs %}

{% highlight xaml %}

<signaturePad:SfSignaturePad StrokeColor="Red" />

{% endhighlight %}

{% highlight C# %}

SfSignaturePad signaturePad = new SfSignaturePad()
{
    StrokeColor = Colors.Red,
};

{% endhighlight %}

{% endtabs %}

![SignaturePad stroke color](images/getting-started/stroke-color.jpg)

## Customize signature stroke thickness

The thickness of the stroke drawn can be customized by setting the `MinimumStrokeThickness` and `MaximumStrokeThickness` properties. The `MinimumStrokeThickness` defines the minimum thickness of the stroke and the `MaximumStrokeThickness` defines the maximum thickness of the stroke that can be draw based on the speed and impression we provide through gesture within its minimum and maximum stroke thickness ranges. So that the signature will be more realistic.

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

![SignaturePad stroke thickness](images/getting-started/stroke-thickness.jpg)

## Save signature as image

You can save the signature drawn in the SignaturePad as an [`ImageSource`](https://docs.microsoft.com/en-us/dotnet/api/xamarin.forms.imagesource?view=xamarin-forms) using the `ToImageSource()` method which can further be synchronized with your devices and documents that need your signature.

{% tabs %}

{% highlight xaml %}

<signaturePad:SfSignaturePad x:Name="signaturePad" />
<Button Text="Save"
        Clicked="OnSaveButtonClicked" />

{% endhighlight %}

{% highlight C# %}

SfSignaturePad signaturePad = new SfSignaturePad();
Button saveButton = new Button();
saveButton.Clicked += OnSaveButtonClicked;

private void OnSaveButtonClicked(object? sender, EventArgs e)
{
    ImageSource? source = signaturePad.ToImageSource();
}

{% endhighlight %}

{% endtabs %}

## Clear the existing signature in SignaturePad

You can clear the signature drawn in the SignaturePad using the `Clear()` method as show in the below code snippet.

{% tabs %}

{% highlight xaml %}

<signaturePad:SfSignaturePad x:Name="signaturePad" />
<Button Text="Clear"
        Clicked="OnClearButtonClicked" />

{% endhighlight %}

{% highlight C# %}

SfSignaturePad signaturePad = new SfSignaturePad();
Button clearButton = new Button();
clearButton.Clicked += OnClearButtonClicked;

private void OnClearButtonClicked(object? sender, EventArgs e)
{
    ImageSource? source = signaturePad.Clear();
}

{% endhighlight %}

{% endtabs %}

## Events

### DrawStarted

This event will be triggered when we starts drawing in the signature pad. With this, `CancelEventArgs` will be passed. You can restrict the draw start action by setting `e.cancel` as `true`.

{% tabs %}

{% highlight xaml %}

<signaturePad:SfSignaturePad DrawStarted="OnDrawStarted" />

{% endhighlight %}

{% highlight C# %}

SfSignaturePad signaturePad = new SfSignaturePad() {  DrawStarted += OnDrawStarted };
private void OnDrawStarted(object? sender, CancelEventArgs e)
{
    e.Cancel = false;
}

{% endhighlight %}

{% endtabs %}

### DrawCompleted

This event will be triggered when we completed drawing in the signature pad.

{% tabs %}

{% highlight xaml %}

<signaturePad:SfSignaturePad DrawCompleted="OnDrawCompleted" />

{% endhighlight %}

{% highlight C# %}

SfSignaturePad signaturePad = new SfSignaturePad() {  DrawCompleted += OnDrawCompleted };
private void OnDrawCompleted(object? sender, EventArgs e)
{
}

{% endhighlight %}

{% endtabs %}
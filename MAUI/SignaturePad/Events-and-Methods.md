---
layout: post
title: Events and Methods in .NET MAUI SignaturePad control | Syncfusion®
description: Learn here about Events and Methods in .NET MAUI SignaturePad (SfSignaturePad) control, its elements, and more.
platform: maui
control: SfSignaturePad
documentation: ug
---

# Events and Methods in .NET MAUI SignaturePad

This section covers the events and methods exposed by the .NET MAUI SignaturePad (SfSignaturePad) control:

* [Events](#events)
  * [DrawStarted](#drawstarted)
  * [DrawCompleted](#drawcompleted)
* [Methods](#methods)
  * [GetSignaturePoints](#getsignaturepoints)
  * [ToImageSource](#toimagesource)
  * [Clear](#clear)

For prerequisites and initial setup, refer to the [Getting Started with .NET MAUI SignaturePad](getting-started.md) documentation.

## Events

The SignaturePad control raises the following events to notify you of user interaction with the pad.

### DrawStarted

The [DrawStarted](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SignaturePad.SfSignaturePad.html#Syncfusion_Maui_SignaturePad_SfSignaturePad_DrawStarted) event is raised when the user starts a new stroke on the SignaturePad. The event handler receives a [CancelEventArgs](https://learn.microsoft.com/dotnet/api/system.componentmodel.canceleventargs) instance. Set `e.Cancel` to `true` to cancel the stroke before it is drawn.

{% tabs %}

{% highlight xaml %}

<ContentPage xmlns:signaturePad="clr-namespace:Syncfusion.Maui.SignaturePad;assembly=Syncfusion.Maui.SignaturePad">
    <signaturePad:SfSignaturePad DrawStarted="OnDrawStarted" />
</ContentPage>

{% endhighlight %}

{% highlight C# %}

using System.ComponentModel;
using Syncfusion.Maui.SignaturePad;

SfSignaturePad signaturePad = new SfSignaturePad();
signaturePad.DrawStarted += OnDrawStarted;
this.Content = signaturePad;

private void OnDrawStarted(object? sender, CancelEventArgs e)
{
    // Cancel the stroke so it is not drawn.
    e.Cancel = true;
}

{% endhighlight %}

{% endtabs %}

### DrawCompleted

The [DrawCompleted](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SignaturePad.SfSignaturePad.html#Syncfusion_Maui_SignaturePad_SfSignaturePad_DrawCompleted) event is raised when the user completes a stroke on the SignaturePad. The event handler receives an [EventArgs](https://learn.microsoft.com/dotnet/api/system.eventargs) instance.

{% tabs %}

{% highlight xaml %}

<ContentPage xmlns:signaturePad="clr-namespace:Syncfusion.Maui.SignaturePad;assembly=Syncfusion.Maui.SignaturePad">
    <signaturePad:SfSignaturePad DrawCompleted="OnDrawCompleted" />
</ContentPage>

{% endhighlight %}

{% highlight C# %}

using System.ComponentModel;
using Syncfusion.Maui.SignaturePad;

SfSignaturePad signaturePad = new SfSignaturePad();
signaturePad.DrawCompleted += OnDrawCompleted;
this.Content = signaturePad;

private void OnDrawCompleted(object? sender, EventArgs e)
{
    // Handle the completed stroke here.
}

{% endhighlight %}

{% endtabs %}

## Methods

The SignaturePad control exposes the following methods for reading, exporting, and clearing signature data.

### GetSignaturePoints

The [GetSignaturePoints()](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SignaturePad.SfSignaturePad.html#Syncfusion_Maui_SignaturePad_SfSignaturePad_GetSignaturePoints) method retrieves the points of every stroke drawn on the SignaturePad. It returns a `List<List<float>>` where each inner list represents the points of a single stroke in the order they were drawn. Coordinates are returned in the SignaturePad's local coordinate space, with the origin `(0, 0)` at the top-left corner of the pad.

{% tabs %}
{% highlight xaml %}
<ContentPage xmlns:signaturePad="clr-namespace:Syncfusion.Maui.SignaturePad;assembly=Syncfusion.Maui.SignaturePad">
    <VerticalStackLayout>
        <signaturePad:SfSignaturePad x:Name="signaturePad"
                                     StrokeColor="Red"
                                     MinimumStrokeThickness="1"
                                     MaximumStrokeThickness="6"
                                     DrawCompleted="OnDrawCompleted" />
    </VerticalStackLayout>
</ContentPage>
{% endhighlight %}
{% highlight C# %}

using System.Collections.Generic;
using Syncfusion.Maui.SignaturePad;

SfSignaturePad signaturePad = new SfSignaturePad()
{
    StrokeColor = Colors.Red,
    MinimumStrokeThickness = 1,
    MaximumStrokeThickness = 6,
};
signaturePad.DrawCompleted += OnDrawCompleted;
this.Content = signaturePad;

private void OnDrawCompleted(object? sender, EventArgs e)
{
    List<List<float>> pointsCollection = signaturePad.GetSignaturePoints();
}

{% endhighlight %}
{% endtabs %}

### ToImageSource

Use the [ToImageSource()](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SignaturePad.SfSignaturePad.html#Syncfusion_Maui_SignaturePad_SfSignaturePad_ToImageSource) method to save the signature drawn on the SignaturePad as a [Microsoft.Maui.Controls.ImageSource](https://learn.microsoft.com/dotnet/maui/user-interface/controls/image). The method returns a nullable `ImageSource?`; if the pad is empty, `null` is returned. The resulting `ImageSource` can be assigned to an `Image` control, exported to a file, or shared with other applications.

{% tabs %}

{% highlight xaml %}

<ContentPage xmlns:signaturePad="clr-namespace:Syncfusion.Maui.SignaturePad;assembly=Syncfusion.Maui.SignaturePad">
    <VerticalStackLayout>
        <signaturePad:SfSignaturePad x:Name="signaturePad" />
        <Button Text="Save"
                Clicked="OnSaveButtonClicked" />
    </VerticalStackLayout>
</ContentPage>

{% endhighlight %}

{% highlight C# %}

using Microsoft.Maui.Controls;
using Syncfusion.Maui.SignaturePad;

SfSignaturePad signaturePad = new SfSignaturePad();
Button saveButton = new Button { Text = "Save" };
saveButton.Clicked += OnSaveButtonClicked;
this.Content = new VerticalStackLayout { signaturePad, saveButton };

private void OnSaveButtonClicked(object? sender, EventArgs e)
{
    ImageSource? source = signaturePad.ToImageSource();
    if (source is not null)
    {
        // Use the image source, for example, assign it to an Image control.
    }
}

{% endhighlight %}

{% endtabs %}

### Clear

The [Clear()](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SignaturePad.SfSignaturePad.html#Syncfusion_Maui_SignaturePad_SfSignaturePad_Clear) method removes every stroke from the SignaturePad. The method is a no-op when the pad is already empty.

{% tabs %}

{% highlight xaml %}

<ContentPage xmlns:signaturePad="clr-namespace:Syncfusion.Maui.SignaturePad;assembly=Syncfusion.Maui.SignaturePad">
    <VerticalStackLayout>
        <signaturePad:SfSignaturePad x:Name="signaturePad" />
        <Button Text="Clear"
                Clicked="OnClearButtonClicked" />
    </VerticalStackLayout>
</ContentPage>

{% endhighlight %}

{% highlight C# %}

using Microsoft.Maui.Controls;
using Syncfusion.Maui.SignaturePad;

SfSignaturePad signaturePad = new SfSignaturePad();
Button clearButton = new Button { Text = "Clear" };
clearButton.Clicked += OnClearButtonClicked;
this.Content = new VerticalStackLayout { signaturePad, clearButton };

private void OnClearButtonClicked(object? sender, EventArgs e)
{
    signaturePad.Clear();
}

{% endhighlight %}

{% endtabs %}

N> You can refer to our [.NET MAUI SignaturePad](https://www.syncfusion.com/maui-controls/maui-signaturepad) feature tour page for its groundbreaking feature representations. You can also explore our [.NET MAUI SignaturePad Example](https://github.com/syncfusion/maui-demos/tree/master/MAUI/SignaturePad) that shows you how to render the SignaturePad in .NET MAUI.

## See Also

* [Getting Started with .NET MAUI SignaturePad](getting-started.md)
* [Customization in .NET MAUI SignaturePad](customization.md)
* [SfSignaturePad API reference](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SignaturePad.SfSignaturePad.html)
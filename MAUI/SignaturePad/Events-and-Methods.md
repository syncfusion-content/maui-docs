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

## Prerequisites

Before using the [SfSignaturePad](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SignaturePad.SfSignaturePad.html), ensure the following NuGet package is installed in your .NET MAUI project:

- `Syncfusion.Maui.SignaturePad`

For a step-by-step setup, refer to the [Getting Started](https://help.syncfusion.com/maui/signaturepad/getting-started) documentation.

## Events

The SignaturePad control raises the following events to notify you of user interaction with the pad.

### DrawStarted

The [DrawStarted](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SignaturePad.SfSignaturePad.html#Syncfusion_Maui_SignaturePad_SfSignaturePad_DrawStarted) event is raised when the user starts a new stroke on the SignaturePad. The event handler receives a `CancelEventArgs` instance. Set `e.Cancel` to `true` to cancel the stroke before it is drawn.

{% tabs %}

{% highlight xaml %}

<signaturePad:SfSignaturePad DrawStarted="OnDrawStarted" />

{% endhighlight %}

{% highlight C# %}

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

The [DrawCompleted](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SignaturePad.SfSignaturePad.html#Syncfusion_Maui_SignaturePad_SfSignaturePad_DrawCompleted) event is raised when the user completes a stroke on the SignaturePad. The event handler receives an `EventArgs` instance.

{% tabs %}

{% highlight xaml %}

<signaturePad:SfSignaturePad DrawCompleted="OnDrawCompleted" />

{% endhighlight %}

{% highlight C# %}

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
<VerticalStackLayout>
    <signaturePad:SfSignaturePad x:Name="signaturePad"
                                 StrokeColor="Red"
                                 MinimumStrokeThickness="1"
                                 MaximumStrokeThickness="6"
                                 DrawCompleted="OnDrawCompleted" />
</VerticalStackLayout>
{% endhighlight %}
{% highlight C# %}

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

Use the [ToImageSource()](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SignaturePad.SfSignaturePad.html#Syncfusion_Maui_SignaturePad_SfSignaturePad_ToImageSource) method to save the signature drawn on the SignaturePad as a `ImageSource`. The method returns a nullable `ImageSource?`; if the pad is empty, `null` is returned. The resulting `ImageSource` can be assigned to an `Image` control, exported to a file, or shared with other applications.

{% tabs %}

{% highlight xaml %}

<VerticalStackLayout>
    <signaturePad:SfSignaturePad x:Name="signaturePad" />
    <Button Text="Save"
            Clicked="OnSaveButtonClicked" />
</VerticalStackLayout>

{% endhighlight %}

{% highlight C# %}

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

<VerticalStackLayout>
    <signaturePad:SfSignaturePad x:Name="signaturePad" />
    <Button Text="Clear"
            Clicked="OnClearButtonClicked" />
</VerticalStackLayout>

{% endhighlight %}

{% highlight C# %}

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

* [Getting Started](https://help.syncfusion.com/maui/signaturepad/getting-started)
* [Customization](https://help.syncfusion.com/maui/signaturepad/customization)

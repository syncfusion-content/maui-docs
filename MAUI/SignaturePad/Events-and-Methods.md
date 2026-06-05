---
layout: post
title: Events and Methods in .NET MAUI SignaturePad control | Syncfusion®
description: Learn here about Events and Methods in .NET MAUI SignaturePad (SfSignaturePad) control, its elements, and more.
platform: maui
control: SfSignaturePad
documentation: ug
---
# Events and Methods in .NET MAUI Signature Pad

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
    // Trigger when the drawing is completed
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
};
signaturePad.DrawCompleted += OnDrawCompleted;

private void OnDrawCompleted(object? sender, EventArgs e)
{
    List<List<float>> pointsCollection = new List<List<float>>();
    pointsCollection = signaturePad.GetSignaturePoints();
}

{% endhighlight %}
{% endtabs %}

N> You can refer to our [.NET MAUI SignaturePad](https://www.syncfusion.com/maui-controls/maui-signaturepad) feature tour page for its groundbreaking feature representations. You can also explore our [.NET MAUI SignaturePad Example](https://github.com/syncfusion/maui-demos/tree/master/MAUI/SignaturePad) that shows you how to render the SignaturePad in .NET MAUI.

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
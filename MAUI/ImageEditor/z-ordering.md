---
layout: post
title: Z-Ordering in .NET MAUI Image Editor Control | Syncfusion®
description: Learn here all about the Z-Ordering support in Syncfusion® .NET MAUI Image Editor (SfImageEditor) control.
platform: MAUI
control: SfImageEditor
documentation: ug
---

# Z-Ordering in .NET MAUI Image Editor (SfImageEditor)

The .NET MAUI Image Editor allows you to change the position of annotations arranged over the image. This can be achieved using the following methods:

* `BringToFront`
* `SendToBack`
* `BringForward`
* `SendBackward`

## BringToFront

Brings the selected annotation to the front of all annotations over the image.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

<Grid RowDefinitions="0.9*, 0.1*">
    <imageEditor:SfImageEditor x:Name="imageEditor"
                               Source="image.jpeg" />
    <Button Grid.Row="1"
            Text="BringToFront"
            Clicked="OnBringToFrontClicked" />
</Grid>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

using Syncfusion.Maui.ImageEditor;

private void OnBringToFrontClicked(object sender, EventArgs e)
{
    this.imageEditor.BringToFront();
}

{% endhighlight %}
{% endtabs %}

## SendToBack

Sends the selected annotation to the back of all annotations.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

<Grid RowDefinitions="0.9*, 0.1*">
    <imageEditor:SfImageEditor x:Name="imageEditor"
                               Source="image.jpeg" />
    <Button Grid.Row="1"
            Text="SendToBack"
            Clicked="OnSendToBackClicked" />
</Grid>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

using Syncfusion.Maui.ImageEditor;

private void OnSendToBackClicked(object sender, EventArgs e)
{
    this.imageEditor.SendToBack();
}

{% endhighlight %}
{% endtabs %}

## BringForward

Brings the selected annotation one step forward over the image.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

<Grid RowDefinitions="0.9*, 0.1*">
    <imageEditor:SfImageEditor x:Name="imageEditor"
                               Source="image.jpeg" />
    <Button Grid.Row="1"
            Text="BringForward"
            Clicked="OnBringForwardClicked" />
</Grid>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

using Syncfusion.Maui.ImageEditor;

private void OnBringForwardClicked(object sender, EventArgs e)
{
    this.imageEditor.BringForward();
}

{% endhighlight %}
{% endtabs %}

## SendBackward

Sends the selected annotation one step backward over the image.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

<Grid RowDefinitions="0.9*, 0.1*">
    <imageEditor:SfImageEditor x:Name="imageEditor"
                               Source="image.jpeg" />
    <Button Grid.Row="1"
            Text="SendBackward"
            Clicked="OnSendBackwardClicked" />
</Grid>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

using Syncfusion.Maui.ImageEditor;

private void OnSendBackwardClicked(object sender, EventArgs e)
{
    this.imageEditor.SendBackward();
}

{% endhighlight %}
{% endtabs %}

![Z-Ordering in .NET MAUI Image Editor](images/z-ordering/imageeditor-z-ordering.gif)
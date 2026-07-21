---
layout: post
title: Working with .NET MAUI Image Editor Control | Syncfusion®
description: Learn here all about working with Syncfusion® .NET MAUI Image Editor (SfImageEditor) control and more.
platform: MAUI
control: SfImageEditor
documentation: ug
---

# Working with .NET MAUI Image Editor (SfImageEditor)

## Get the image stream

The [`GetImageStream`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.SfImageEditor.html#Syncfusion_Maui_ImageEditor_SfImageEditor_GetImageStream) method returns the edited image as a stream.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

<Grid RowDefinitions="0.9*, 0.1*">
    <imageEditor:SfImageEditor x:Name="imageEditor"
                               Source="image.jpeg" />
    <Button Grid.Row="1"
            Text="Get Image Stream"
            Clicked="OnGetStreamClicked" />
</Grid>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

using System.IO;
using Syncfusion.Maui.ImageEditor;

private void OnGetStreamClicked(object sender, EventArgs e)
{
    Stream stream = this.imageEditor.GetImageStream();
}

{% endhighlight %}
{% endtabs %}

N> The stream is available only after the image is loaded into the view.

## Get the image's original size

The [`OriginalImageSize`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.SfImageEditor.html#Syncfusion_Maui_ImageEditor_SfImageEditor_OriginalImageSize) property gets the image's original size.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

<Grid RowDefinitions="0.9*, 0.1*">
    <imageEditor:SfImageEditor x:Name="imageEditor"
                               Source="image.jpeg" />
    <Button Grid.Row="1"
            Text="Get Image Original Size"
            Clicked="OnGetImageOriginalSizeClicked" />
</Grid>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

using Microsoft.Maui.Graphics;
using Syncfusion.Maui.ImageEditor;

private void OnGetImageOriginalSizeClicked(object sender, EventArgs e)
{
    Size originalSize = this.imageEditor.OriginalImageSize;
}

{% endhighlight %}
{% endtabs %}

N> The size value is available only after the image is loaded into the view.

## Get the image's rendered size

The image editor uses `AspectFit` image scaling of the `Image` control to fit the entire image into the display area, adding blank space to the top or bottom depending on the image's aspect ratio. The [`ImageRenderedSize`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.SfImageEditor.html#Syncfusion_Maui_ImageEditor_SfImageEditor_ImageRenderedSize) property gets the current rendered size of the image within the display area.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

<Grid RowDefinitions="0.9*, 0.1*">
    <imageEditor:SfImageEditor x:Name="imageEditor"
                               Source="image.jpeg" />
    <Button Grid.Row="1"
            Text="Get Image Rendered Size"
            Clicked="OnGetImageRenderedSize" />
</Grid>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

using Microsoft.Maui.Graphics;
using Syncfusion.Maui.ImageEditor;

private void OnGetImageRenderedSize(object sender, EventArgs e)
{
    Size imageSize = this.imageEditor.ImageRenderedSize;
}

{% endhighlight %}
{% endtabs %}

N> The size value is available only after the image is loaded into the view.

## Check the image edited status

The [`IsImageEdited`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.SfImageEditor.html#Syncfusion_Maui_ImageEditor_SfImageEditor_IsImageEdited) property determines whether any editing action has been performed on the image.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

<Grid RowDefinitions="0.9*, 0.1*">
    <imageEditor:SfImageEditor x:Name="imageEditor"
                               Source="image.jpeg" />
    <Button Grid.Row="1"
            Text="IsImageEdited"
            Clicked="OnIsImageEditedClicked" />
</Grid>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

using Syncfusion.Maui.ImageEditor;

private void OnIsImageEditedClicked(object sender, EventArgs e)
{
    if (this.imageEditor.IsImageEdited)
    {
        this.imageEditor.Save();
    }
}

{% endhighlight %}
{% endtabs %}

## Change the image editor's background

Set the `Background` property to customize the background of the image editor.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

<imageEditor:SfImageEditor x:Name="imageEditor"
                           Source="imageeditordesktop.png"
                           Background="LightGreen" />

{% endhighlight %}
{% endtabs %}
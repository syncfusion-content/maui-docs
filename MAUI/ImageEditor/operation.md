---
layout: post
title: Operation in .NET MAUI Image Editor Control | Syncfusion
description: Learn here all about Working with Syncfusion<sup>&reg;</sup> .NET MAUI Image Editor(SfImageEditor) control and more.
platform: maui
control: SfImageEditor
documentation: ug
---

# Working with .NET MAUI Image Editor (SfImageEditor)

## Get the image stream

The [`GetImageStream`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.SfImageEditor.html#Syncfusion_Maui_ImageEditor_SfImageEditor_GetImageStream) method is used to get the edited image in form of a image stream.

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

    private void OnGetStreamClicked(object sender, EventArgs e)
    {
        this.imageEditor.GetImageStream();
    }

{% endhighlight %}
{% endtabs %}

## Get the Image Original Size
The [`OriginalImageSize`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.SfImageEditor.html#Syncfusion_Maui_ImageEditor_SfImageEditor_OriginalImageSize) property is used to get the image's original size.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

   <Grid RowDefinitions="0.9*, 0.1*">
        <imageEditor:SfImageEditor x:Name="imageEditor"
                                   Source="image.jpeg" />
        <Button Grid.Row="1"
                Text="Get Image Original Size"
                Clicked="OnGetImageOriginalSize" />
    </Grid>  

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

    private void OnGetImageOriginalSize(object sender, EventArgs e)
    {
        Size originalSize = this.imageEditor.OriginalImageSize;
    }

{% endhighlight %}
{% endtabs %}

N> The size value will only be available after the image has been loaded into view.

## Get the Image Rendered Size
The image editor utilizes the `AspectFit` image scaling of Image control to fit the entire image into the display area, with blank space added to the top or bottom sides depending on whether the image is wide or tall. The [`ImageRenderedSize`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.SfImageEditor.html#Syncfusion_Maui_ImageEditor_SfImageEditor_ImageRenderedSize) property is used to get the current rendered size of the image inside the display area.

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

    private void OnGetImageRenderedSize(object sender, EventArgs e)
    {
        Size imageSize = this.imageEditor.ImageRenderedSize;
    }

{% endhighlight %}
{% endtabs %}

N> The size value will only be available after the image has been loaded into view.

## Check image edited status

The [`IsImageEdited`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.SfImageEditor.html#Syncfusion_Maui_ImageEditor_SfImageEditor_IsImageEdited) property is used to determine whether any editing action has been performed on the image.

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

private void OnIsImageEditedClicked(object sender, EventArgs e)
{
    if (this.imageEditor.IsImageEdited)
    {
        this.imageEditor.Save();
    }
}

{% endhighlight %}
{% endtabs %}

## Change the image editor background
The background of the Image Editor can be customized by setting the `Background` property of the SfImageEditor.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

   <imageEditor:SfImageEditor x:Name="imageEditor"
                              Source="imageeditordesktop.png"
                              Background="LightGreen">
   </imageEditor:SfImageEditor>

{% endhighlight %}
{% endtabs %}
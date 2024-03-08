---
layout: post
title: Serialization in .NET MAUI Image Editor Control | Syncfusion
description: Learn about serialization support in the Syncfusion .NET MAUI ImageEditor(SfImageEditor) control and more.
platform: maui
control: SfImageEditor
documentation: ug
---

# Serialization in .NET MAUI Image Editor (SfImageEditor)

The Image Editor control provides support to serialize and deserialize the annotations, free hand drawing, text and toolbar settings. You can save the current state of the image editor and load it back when it is needed.

## Serialization

The Serialize() method is used to serialize the current edits of shapes. It allows you to store the SfImageEditor annotation settings with the help of `Serialize` method by passing the stream as parameter.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

   <Grid RowDefinitions="0.9*, 0.1*">
        <imageEditor:SfImageEditor x:Name="imageEditor"
                                   Source="image.jpeg" />
        <Button Grid.Row="1"
                Text="Serialize"
                Clicked="OnSerializeClicked" />
    </Grid>  

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

    private void OnSerializeClicked(object sender, EventArgs e)
    {
        this.imageEditor.AddShape(AnnotationShape.Arrow)
    }

{% endhighlight %}
{% endtabs %}

You can save stream into .txt format file. If you save stream as .txt format file to deserialize the shapes, then set the Build action to `Embedded resource` in project.

Sample text file: [ImageEditor.txt](https://s3.amazonaws.com/files2.syncfusion.com/dtsupport/directtrac/general/txt/Chart677841499.txt?AWSAccessKeyId=AKIAWH6GYCX3TZ4I4YVB&Expires=1695709055&Signature=9L6xHfsas4aolVJk5ps3IkVEdBk%3D).

## Deserialization

The Deserialize() method is used to deserialize the edits over an image. It allows you to reload the SfPivotGrid control with the settings available in the stream.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

   <Grid RowDefinitions="0.9*, 0.1*">
        <imageEditor:SfImageEditor x:Name="imageEditor"
                                   Source="image.jpeg" />
        <Button Grid.Row="1"
                Text="Deserialize"
                Clicked="OnDeserializeClicked" />
    </Grid>  

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

    private void OnDeserializeClicked(object sender, EventArgs e)
    {
        this.imageEditor.AddShape(AnnotationShape.Arrow)
    }

{% endhighlight %}
{% endtabs %}


{% endhighlight %}

{% endtabs %}

N> [View sample in GitHub]()
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

The `Serialize()` method is used to serialize the current edits of shapes. It allows you to store the SfImageEditor annotation settings by passing the stream as a parameter to the `Serialize` method.

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
    
    MemoryStream memoryStream;
    private void OnSerializeClicked(object sender, EventArgs e)
    {
        this.memoryStream = new MemoryStream();
        this.imageEditor.Serialize(memoryStream);
    }

{% endhighlight %}
{% endtabs %}

## Deserialization

The Deserialize() method is used to deserialize the edits over an image. It allows you to reload the SfImageEditor control with the settings available in the stream.

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
        if (this.memoryStream != null)
        {
            this.imageEditor.Deserialize(this.memoryStream);
        }
    }

{% endhighlight %}
{% endtabs %}

{% endhighlight %}

{% endtabs %}

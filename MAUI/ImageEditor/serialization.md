---
layout: post
title: Serialization in .NET MAUI Image Editor Control | Syncfusion
description: Learn about serialization support in the Syncfusion .NET MAUI ImageEditor(SfImageEditor) control and more.
platform: maui
control: SfImageEditor
documentation: ug
---

# Serialization in .NET MAUI Image Editor (SfImageEditor)

The Image Editor control provides support to serialize and deserialize the shape, text and pen annotations along with their settings. You can save the current state of the image editor annotations and load it back when it is needed.

## Serialization

The `Serialize` method is used to serialize the current edits of annotations. It allows you to store the `SfImageEditor` annotations to the stream by passing the stream as a parameter to the `Serialize` method.

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
        string filePath = Path.Combine(FileSystem.Current.CacheDirectory, "ImageEditor.xml");
        using (var fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write))
        {
            this.imageEditor.Serialize(fileStream);
        }
    }

{% endhighlight %}
{% endtabs %}

## Deserialization

The `Deserialize` method is used to deserialize the annotations over an image. It allows you to reload the `SfImageEditor` control with the annotations available in the stream.

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

    private async void OnDeserializeClicked(object sender, EventArgs e)
    {
        var result = await FilePicker.PickAsync();
    
        if (result != null)
        {
            using (Stream stream = await result.OpenReadAsync())
            {
                this.imageEditor.Deserialize(stream);
            }
        }
    }

{% endhighlight %}
{% endtabs %}

N> Serialization is not applicable to custom annotations.
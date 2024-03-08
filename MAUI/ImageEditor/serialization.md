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
        MemoryStream memoryStream = new MemoryStream();
        this.imageEditor.Serialize(memoryStream);
        string filePath = Path.Combine("D:\\", "yourfile.xml");
        if (!File.Exists(filePath))
        {
            using (FileStream fs = File.Create(filePath))
            {
            }
        }
        using (var fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write))
        {
            memoryStream.CopyTo(fileStream);
        }
    }

{% endhighlight %}
{% endtabs %}

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
        var result = await FilePicker.PickAsync(new PickOptions
        {
            PickerTitle = "Select an XML file"
        });
        
        if (result != null)
        {
            MemoryStream memoryStream = new MemoryStream();
            using (Stream stream = await result.OpenReadAsync())
            {
                await stream.CopyToAsync(memoryStream);
            }
        
            this.imageEditor.Deserialize(memoryStream);
        }
    }

{% endhighlight %}
{% endtabs %}

{% endhighlight %}

{% endtabs %}

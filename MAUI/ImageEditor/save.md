---
layout: post
title: Save in .NET MAUI ImageEditor control | Syncfusion
description: Learn here all about save support in the Syncfusion .NET MAUI ImageEditor(SfImageEditor) control.
platform: .NET MAUI
control: SfImageEditor
documentation: ug
---

# Save in .NET MAUI ImageEditor (SfImageEditor)

The Image Editor control in .NET MAUI allows you to save the edited image as PNG and JPEG.

To save the modified image, you can use the `Save` method, which accepts parameters such as file name, file type, file path, and image size. The supported file types for saving are PNG and JPEG. You can also save the image by clicking the save button on the toolbar.

{% tabs %}

{% highlight C# tabtitle="C#" %}

              imageEditor.Save(ImageFileType.Png, "D:\\Syncfusion\\Pictures", "Syncfusion");

{% endhighlight %}

{% endtabs %}

## Save events

The Image Editor has events when performing the save operation, such as `ImageSaving` and `ImageSaved`.

### ImageSaving

This `ImageSaving` event occurs before saving the image.

`Cancel`: You can control the save functionality by setting the `Cancel` argument to `true`. When `Cancel` is set to `true`, it restricts saving the image to the default location.

{% tabs %}

{% highlight xaml tabtitle="XAML" %}

            <imageEditor:SfImageEditor Source="{Binding Image}" ImageSaving="OnImageSaving" />

{% endhighlight %}

{% highlight C# tabtitle="C#" %}
            
            private void OnImageSaving(object sender, ImageSavingEventArgs args)
            {
                args.Cancel = true;  
            }

{% endhighlight %}

{% endtabs %}

`ImageStream` : You can access the current image edits as a stream using the `ImageStream` argument.

{% tabs %}

{% highlight C# tabtitle="C#" %}
           
    private void SfImageEditor_ImageSaving(object sender, ImageSavingEventArgs args)
    {
        var stream = args.ImageStream;
    }

{% endhighlight %}

{% endtabs %}

`FileName`: You can save the edited image in the specified name. 

{% tabs %}

{% highlight c# tabtitle="C#" %}

    private void SfImageEditor_ImageSaving(object sender, ImageSavingEventArgs args)
    {
        args.FileName = "SavedImage";
    }

{% endhighlight %}

{% endtabs %}

`FileType`: You can specify the file type of the saved image.

{% tabs %}

{% highlight c# tabtitle="C#" %}

    private void SfImageEditor_ImageSaving(object sender, ImageSavingEventArgs args)
    {
        args.FileType = ImageFileType.Png;
    }

{% endhighlight %}

{% endtabs %}

### ImageSaved

The `ImageSaved` event occurs after the image has been saved. To get the location of the saved image, use the `Location` argument as shown in the following code.

{% tabs %}

{% highlight C# tabtitle="C#" %}

    public MainPage()
    {               
                    . . .

        imageEditor.ImageSaved += imageEditor_ImageSaved;

                    . . .
    }

    private void imageEditor_ImageSaved(object sender, ImageSavedEventArgs args)
    {
        string savedLocation = args.Location; 
    }

{% endhighlight %}

{% endtabs %}
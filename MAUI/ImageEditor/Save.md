---
layout: post
title: Annotation in .NET MAUI ImageEditor control | Syncfusion
description: Learn here all about the save feature of Syncfusion .NET MAUI ImageEditor (SfImageEditor) control and more.
platform: MAUI
control: SfImageEditor
documentation: ug
---

# Save in .NET MAUI ImageEditor (SfImageEditor)

## Save

The Image Editor control saves the edited image as PNG and JPEG.

The `Save` method is used to save the modified image as an image, and it accepts a file name, file type, file path, image size as parameters. The file type parameter supports PNG and JPEG. It also saves an image by clicking the save button from the toolbar and the supported file types are PNG and JPEG.

{% highlight C# %}

              imageEditor.Save(ImageFileType.Png, "D:\\Syncfusion\\Pictures", "Syncfusion");

{% endhighlight %}

## Save events

The SfImageEditor has events when performing the save operation, such as `ImageSaving` and `ImageSaved`.

### ImageSaving

This event occurs before saving the image.

`Cancel` : You can control the save functionality using the `Cancel` argument.

It restricts saving image to the default location when set `Cancel` value to `true`.

{% tabs %}

{% highlight xaml %}

            <imageEditor:SfImageEditor Source="{Binding Image}" ImageSaving="imageEditor_ImageSaving" />

{% endhighlight %}

{% highlight C# %}
            
            private void imageEditor_ImageSaving(object sender, ImageSavingEventArgs args)
            {
                args.Cancel = true;  
            }

{% endhighlight %}

{% endtabs %}

`Stream` : You can get current image edits as stream using this argument.

{% highlight C# %}
           
    private void SfImageEditor_ImageSaving(object sender, ImageSavingEventArgs args)
    {
        var stream = args.Stream;
    }

{% endhighlight %}

`FileName`: You can save the edited image in the specified name. 

{% highlight c# %}

    private void SfImageEditor_ImageSaving(object sender, ImageSavingEventArgs args)
    {
        args.FileName = "SavedImage";
    }

{% endhighlight %}

### ImageSaved

This event occurs after the image has been saved. To get the location of the saved image, use the location argument as shown in the following code.

{% highlight C# %}

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



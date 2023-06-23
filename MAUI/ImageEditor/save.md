---
layout: post
title: Image save in .NET MAUI ImageEditor control | Syncfusion
description: Learn here all about save support in the Syncfusion .NET MAUI ImageEditor(SfImageEditor) control and more.
platform: .NET MAUI
control: SfImageEditor
documentation: ug
---

# Save in .NET MAUI ImageEditor (SfImageEditor)

The Image Editor control in .NET MAUI allows you to save the edited image as PNG and JPEG.

To save the modified image, you can use the [`Save`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.SfImageEditor.html#Syncfusion_Maui_ImageEditor_SfImageEditor_Save_System_Nullable_Syncfusion_Maui_ImageEditor_ImageFileType__System_String_System_String_System_Nullable_Microsoft_Maui_Graphics_Size__) method, which accepts parameters such as file name, file type, file path, and image size. The supported file types for saving are PNG and JPEG. You can also save the image by clicking the save button on the toolbar.

{% tabs %}

{% highlight C# tabtitle="C#" %}

              imageEditor.Save(ImageFileType.Png, "D:\\Syncfusion\\Pictures", "Syncfusion");

{% endhighlight %}

{% endtabs %}

The saved image will be added to the device for each platform in the following locations:

## Windows, MacCatalyst and iOS

For Windows, MacCatalyst, and iOS platforms, you can save the image to the following location:

`System.Environment.SpecialFolder.MyPictures`

Please refer to the [System.Environment.SpecialFolder](https://learn.microsoft.com/en-us/dotnet/api/system.environment.specialfolder?view=net-7.0) documentation for more information.

### Windows device Location: 

On a Windows device, the image should be saved to:

`C:\Users\your name\Pictures`

### MacCatalyst device Location:

On a MacCatalyst device, the image should be saved to: 

`/Users/your name/Documents/Pictures`

### iOS device location:

On an iOS device, the image should be saved to:

`/Photos/Pictures`

## Android

### API 29 and above: 

For devices running Android API 29 and above, you can save the image to the `Pictures` folder using the following relative path:

 `Android.Provider.MediaStore.IMediaColumns.RelativePath`

Please refer to the [MediaStore.MediaColumns](https://developer.android.com/reference/android/provider/MediaStore.MediaColumns#RELATIVE_PATH) documentation for more details.

### API 28 and below:

For devices running Android API 28 and below, you can save the image using the following URI:

`Android.Provider.MediaStore.Images.Media.ExternalContentUri`

Please refer to the [MediaStore.Images.Media](https://developer.android.com/reference/android/provider/MediaStore.Images.Media#EXTERNAL_CONTENT_URI) documentation for further information.

### Device location: 

On an Android device, the image should be saved to:

`\Internal storage\Pictures`

N> For android should include permission in AndroidManifest.xml file. Please refer to the [App Model Permissions](https://learn.microsoft.com/en-us/dotnet/maui/platform-integration/appmodel/permissions?tabs=android) documentation for more details.

## Save events

The Image Editor has events when performing the save operation, such as [`ImageSaving`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.SfImageEditor.html#Syncfusion_Maui_ImageEditor_SfImageEditor_ImageSaving) and [`ImageSaved`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.SfImageEditor.html#Syncfusion_Maui_ImageEditor_SfImageEditor_ImageSaved).

## ImageSaving

This [`ImageSaving`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.SfImageEditor.html#Syncfusion_Maui_ImageEditor_SfImageEditor_ImageSaving) event occurs before saving the image.

[`Cancel`](https://learn.microsoft.com/en-us/dotnet/api/system.componentmodel.canceleventargs.cancel?view=net-6.0): You can control the save functionality by setting the [`Cancel`](https://learn.microsoft.com/en-us/dotnet/api/system.componentmodel.canceleventargs.cancel?view=net-6.0) argument to `true`. 

[`Cancel`](https://learn.microsoft.com/en-us/dotnet/api/system.componentmodel.canceleventargs.cancel?view=net-6.0): It restricts the saving of the image to the default location.

{% tabs %}

{% highlight xaml tabtitle="MainPage.xaml" %}

            <imageEditor:SfImageEditor x:Name="imageEditor" Source="image.png" ImageSaving="OnImageSaving" />

{% endhighlight %}

{% highlight C# tabtitle="MainPage.xaml.cs" %}
            
        private void OnImageSaving(object sender, ImageSavingEventArgs args)
        {
            if (!this.imageEditor.IsImageEdited)
            {
               args.Cancel = true;
            }
        }

{% endhighlight %}

{% endtabs %}

[`ImageStream`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.ImageSavingEventArgs.html#Syncfusion_Maui_ImageEditor_ImageSavingEventArgs_ImageStream) : You can access the current image edits as a stream using the [`ImageStream`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.ImageSavingEventArgs.html#Syncfusion_Maui_ImageEditor_ImageSavingEventArgs_ImageStream) argument.

{% tabs %}

{% highlight C# tabtitle="C#" %}
           
   private void OnImageSaving(object sender, ImageSavingEventArgs args)
   {
       stream = args.ImageStream;
   }

{% endhighlight %}

{% endtabs %}

[`FileName`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.ImageSavingEventArgs.html#Syncfusion_Maui_ImageEditor_ImageSavingEventArgs_FileName): You can save the edited image in the specified name. 

{% tabs %}

{% highlight c# tabtitle="C#" %}

    private void SfImageEditor_ImageSaving(object sender, ImageSavingEventArgs args)
    {
        args.FileName = "SavedImage";
    }

{% endhighlight %}

{% endtabs %}

[`FileType`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.ImageSavingEventArgs.html#Syncfusion_Maui_ImageEditor_ImageSavingEventArgs_FileType): You can change the file type of the saved image to [`ImageFileType.Png`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.ImageFileType.html#Syncfusion_Maui_ImageEditor_ImageFileType_Png) or [`ImageFileType.Jpeg`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.ImageFileType.html#Syncfusion_Maui_ImageEditor_ImageFileType_Jpeg).

{% tabs %}

{% highlight c# tabtitle="C#" %}

    private void SfImageEditor_ImageSaving(object sender, ImageSavingEventArgs args)
    {
        args.FileType = ImageFileType.Png;
    }

{% endhighlight %}

{% endtabs %}

## ImageSaved

The [`ImageSaved`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.SfImageEditor.html#Syncfusion_Maui_ImageEditor_SfImageEditor_ImageSaved) event occurs after the image has been saved. To get the location of the saved image, use the [`Location`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.ImageSavedEventArgs.html#Syncfusion_Maui_ImageEditor_ImageSavedEventArgs_Location) argument as shown in the following code.

{% tabs %}

{% highlight C# tabtitle="C#" %}

    public MainPage()
    {               
                    . . .

        imageEditor.ImageSaved += OnImageSaved;

                    . . .
    }

    private void OnImageSaved(object sender, ImageSavedEventArgs args)
    {
        string savedLocation = args.Location; 
    }

{% endhighlight %}

{% endtabs %}
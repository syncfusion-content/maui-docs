---
layout: post
title: Save image .NET MAUI Image Editor Control | Syncfusion
description: Learn about save support and various other features in the Syncfusion .NET MAUI ImageEditor(SfImageEditor) control.
platform: MAUI
control: SfImageEditor
documentation: ug
---

# Save image using .NET MAUI Image Editor (SfImageEditor)

The Image Editor control in .NET MAUI allows you to save the edited image as PNG, JPG, JPEG, and BMP.

## Save method

To save the modified image, use the [`Save`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.SfImageEditor.html#Syncfusion_Maui_ImageEditor_SfImageEditor_Save_System_Nullable_Syncfusion_Maui_ImageEditor_ImageFileType__System_String_System_String_System_Nullable_Microsoft_Maui_Graphics_Size__) method, which accepts parameters such as file name, file type, file path, and image size. The supported file types for saving are [`PNG`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.ImageFileType.html#Syncfusion_Maui_ImageEditor_ImageFileType_Png), [`JPG`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.ImageFileType.html#Syncfusion_Maui_ImageEditor_ImageFileType_Jpg), [`JPEG`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.ImageFileType.html#Syncfusion_Maui_ImageEditor_ImageFileType_Jpeg) and [`BMP`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.ImageFileType.html#Syncfusion_Maui_ImageEditor_ImageFileType_Bmp). You can save the image by clicking Save on the toolbar.

{% tabs %}
{% highlight xaml tabtitle="XAML" %}

<Grid RowDefinitions="0.9*, 0.1*">
    <imageEditor:SfImageEditor x:Name="imageEditor"
                               Source="image.jpeg" />
    <Button Grid.Row="1"
            Text="Save"
            Clicked="OnSaveImageClicked" />
</Grid>

{% endhighlight %}
{% highlight c# tabtitle="C#" %}

using Syncfusion.Maui.ImageEditor;

private void OnSaveImageClicked(object sender, EventArgs e)
{
    this.imageEditor.Save(ImageFileType.Png, "D:\\Syncfusion\\Pictures", "Syncfusion");
}

{% endhighlight %}
{% endtabs %}

N> `JPG` format is supported only on `Android` and `Windows`. It is not supported on `macOS` or `iOS`.

The saved image will be added to the device for each platform in the following locations:

### Windows, MacCatalyst, and iOS

In Windows, MacCatalyst, and iOS platforms, the image will be saved in the following location:

`System.Environment.SpecialFolder.MyPictures`

For more information, see the [System.Environment.SpecialFolder](https://learn.microsoft.com/en-us/dotnet/api/system.environment.specialfolder?view=net-7.0) documentation.

On a Windows device, the image will be saved to:

`C:\Users\your name\Pictures`

On a MacCatalyst device, the image will be saved to:

`/Users/your name/Documents/Pictures`

On an iOS device, the image will be saved to:

`/Photos/Pictures`

### Enable file access permission

For MacCatalyst devices, include the following permission in the `Entitlements.plist` file.

{% tabs %}
{% highlight xml tabtitle="Entitlements.plist" %}

<key>com.apple.security.files.user-selected.read-write</key>
<true/>

{% endhighlight %}
{% endtabs %}

### Add photo library usage description

For MacCatalyst devices, include the following permission in the `Info.plist` file.

{% tabs %}
{% highlight xml tabtitle="Info.plist" %}

<key>NSPhotoLibraryUsageDescription</key>
<string>Pick Photos</string>

{% endhighlight %}
{% endtabs %}

### Android

#### API 29 and above

For devices running Android API 29 and above, the image is saved to the `Pictures` folder using the following relative path:

`Android.Provider.MediaStore.IMediaColumns.RelativePath`

For more details, see the [MediaStore.MediaColumns](https://developer.android.com/reference/android/provider/MediaStore.MediaColumns#RELATIVE_PATH) documentation.

#### API 28 and below

For devices running Android API 28 and below, the image is saved using the following URI:

`Android.Provider.MediaStore.Images.Media.ExternalContentUri`

For more details, see the [MediaStore.Images.Media](https://developer.android.com/reference/android/provider/MediaStore.Images.Media#EXTERNAL_CONTENT_URI) documentation.

On an Android device, the image will be saved to:

`\Internal storage\Pictures`

N> For Android, include the required permission in the `AndroidManifest.xml` file. For more details, see the [App Model Permissions](https://learn.microsoft.com/en-us/dotnet/maui/platform-integration/appmodel/permissions?tabs=android) documentation.

{% tabs %}
{% highlight xml tabtitle="AndroidManifest.xml" %}

<uses-permission android:name="android.permission.WRITE_EXTERNAL_STORAGE" />
<uses-permission android:name="android.permission.READ_EXTERNAL_STORAGE" />

{% endhighlight %}
{% endtabs %}

![Image save in .NET MAUI ImageEditor](images/save/imageeditor-save-image.png)

## Image save action events

The Image Editor has events when performing the save operation, such as [`ImageSaving`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.SfImageEditor.html#Syncfusion_Maui_ImageEditor_SfImageEditor_ImageSaving) and [`ImageSaved`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.SfImageEditor.html#Syncfusion_Maui_ImageEditor_SfImageEditor_ImageSaved).

### Image saving event

The [`ImageSaving`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.SfImageEditor.html#Syncfusion_Maui_ImageEditor_SfImageEditor_ImageSaving) event occurs before saving the image.

#### Cancel

Control the save functionality by setting the [`Cancel`](https://learn.microsoft.com/en-us/dotnet/api/system.componentmodel.canceleventargs.cancel?view=net-6.0) argument to `true`. It restricts the image save to the default location.

{% tabs %}

{% highlight xaml tabtitle="XAML" %}

<imageEditor:SfImageEditor x:Name="imageEditor"
                           Source="image.png"
                           ImageSaving="OnImageSaving" />

{% endhighlight %}

{% highlight C# tabtitle="C#" %}

using Syncfusion.Maui.ImageEditor;

private void OnImageSaving(object sender, ImageSavingEventArgs args)
{
    if (!this.imageEditor.IsImageEdited)
    {
        args.Cancel = true;
    }
}

{% endhighlight %}

{% endtabs %}

#### ImageStream

Access the current image edits as a stream using the [`ImageStream`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.ImageSavingEventArgs.html#Syncfusion_Maui_ImageEditor_ImageSavingEventArgs_ImageStream) argument.

{% tabs %}

{% highlight C# tabtitle="C#" %}

using System.IO;
using Syncfusion.Maui.ImageEditor;

public partial class MainPage : ContentPage
{
    private Stream stream;

    public MainPage()
    {
        InitializeComponent();
        imageEditor.ImageSaving += OnImageSaving;
    }

    private void OnImageSaving(object sender, ImageSavingEventArgs args)
    {
        stream = args.ImageStream;
    }
}

{% endhighlight %}

{% endtabs %}

#### FileName

Save the edited image with the specified name using the [`FileName`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.ImageSavingEventArgs.html#Syncfusion_Maui_ImageEditor_ImageSavingEventArgs_FileName) argument.

{% tabs %}

{% highlight C# tabtitle="C#" %}

using Syncfusion.Maui.ImageEditor;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        imageEditor.ImageSaving += OnImageSaving;
    }

    private void OnImageSaving(object sender, ImageSavingEventArgs args)
    {
        args.FileName = "SavedImage";
    }
}

{% endhighlight %}

{% endtabs %}

#### FileType

Change the file type of the saved image to [`ImageFileType.Png`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.ImageFileType.html#Syncfusion_Maui_ImageEditor_ImageFileType_Png), [`ImageFileType.Jpeg`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.ImageFileType.html#Syncfusion_Maui_ImageEditor_ImageFileType_Jpeg), or `BMP` using the [`FileType`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.ImageSavingEventArgs.html#Syncfusion_Maui_ImageEditor_ImageSavingEventArgs_FileType) argument.

{% tabs %}

{% highlight C# tabtitle="C#" %}

using Syncfusion.Maui.ImageEditor;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        imageEditor.ImageSaving += OnImageSaving;
    }

    private void OnImageSaving(object sender, ImageSavingEventArgs args)
    {
        args.FileType = ImageFileType.Png;
    }
}

{% endhighlight %}

{% endtabs %}

#### Compression Quality

Optimize the saved image's file size on Android, iOS, and MacCatalyst devices, when the [`FileType`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.ImageSavingEventArgs.html#Syncfusion_Maui_ImageEditor_ImageSavingEventArgs_FileType) is set to [`ImageFileType.Jpeg`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.ImageFileType.html#Syncfusion_Maui_ImageEditor_ImageFileType_Jpeg).

{% tabs %}

{% highlight C# tabtitle="C#" %}

using Syncfusion.Maui.ImageEditor;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        imageEditor.ImageSaving += OnImageSaving;
    }

    private void OnImageSaving(object sender, ImageSavingEventArgs args)
    {
        #if ANDROID || IOS || MACCATALYST
        args.CompressionQuality = 0.5F;
        #endif
    }
}

{% endhighlight %}

{% endtabs %}

### Image saved event

The [`ImageSaved`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.SfImageEditor.html#Syncfusion_Maui_ImageEditor_SfImageEditor_ImageSaved) event occurs after the image has been saved. To get the location of the saved image, use the [`Location`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.ImageSavedEventArgs.html#Syncfusion_Maui_ImageEditor_ImageSavedEventArgs_Location) argument as shown in the following code.

{% tabs %}

{% highlight xaml tabtitle="XAML" %}

<imageEditor:SfImageEditor Source="image.png" 
                           ImageSaved="OnImageSaved" />

{% endhighlight %}

{% highlight C# tabtitle="C#" %}

using Syncfusion.Maui.ImageEditor;

private void OnImageSaved(object sender, ImageSavedEventArgs args)
{
    string savedLocation = args.Location;
}

{% endhighlight %}

{% endtabs %}

### Save picker opening event

The [`SavePickerOpening`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.SfImageEditor.html#Syncfusion_Maui_ImageEditor_SfImageEditor_SavePickerOpening) event occurs when the save picker opens on clicking the save icon in the toolbar.

#### Cancel

Restrict the save picker opening by setting the `Cancel` argument to `true`. If the save picker is disabled, the image will be saved in the default location. For more information, see the [Save method](save#save-method) section.

{% tabs %}

{% highlight xaml tabtitle="XAML" %}

<imageEditor:SfImageEditor Source="image.png" 
                           SavePickerOpening="OnSavePickerOpening" />

{% endhighlight %}

{% highlight C# tabtitle="C#" %}

using System.ComponentModel;
using Syncfusion.Maui.ImageEditor;

private void OnSavePickerOpening(object sender, CancelEventArgs args)
{
    args.Cancel = true;
}

{% endhighlight %}

{% endtabs %}

## Check unsaved annotation edits

The Image Editor notifies whether there are unsaved edits or drawn annotations using the following properties.

### HasUnsavedEdits

The [`HasUnsavedEdits`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.SfImageEditor.html#Syncfusion_Maui_ImageEditor_SfImageEditor_HasUnsavedEdits) property notifies whether there are unsaved edits such as crop, effects, shapes, text, and pen annotations in the image editor.

{% tabs %}

{% highlight xaml tabtitle="XAML" %}

<Grid RowDefinitions="0.9*, 0.1*">
    <imageEditor:SfImageEditor x:Name="imageEditor" Source="image.jpeg" />
    <Button Grid.Row="1"
            Text="HasUnsavedEdits"
            Clicked="OnHasUnsavedEditsClicked"
            HorizontalOptions="Center" />
</Grid>

{% endhighlight %}

{% highlight C# tabtitle="C#" %}

private void OnHasUnsavedEditsClicked(object sender, EventArgs e)
{
    if (this.imageEditor.HasUnsavedEdits)
    {
        this.imageEditor.SaveEdits();
    }
}

{% endhighlight %}

{% endtabs %}

### HasUnsavedDrawnAnnotations

The [`HasUnsavedDrawnAnnotations`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.SfImageEditor.html#Syncfusion_Maui_ImageEditor_SfImageEditor_HasUnsavedDrawnAnnotations) property notifies whether there are unsaved pen, polygon, and polyline annotations drawn in the image editor.

{% tabs %}

{% highlight xaml tabtitle="XAML" %}

<Grid RowDefinitions="0.9*, 0.1*">
    <imageEditor:SfImageEditor x:Name="imageEditor" Source="image.jpeg" />
    <Button Grid.Row="1"
            Text="HasUnsavedDrawnAnnotations"
            Clicked="OnHasUnsavedDrawnAnnotationsClicked"
            HorizontalOptions="Center" />
</Grid>

{% endhighlight %}

{% highlight C# tabtitle="C#" %}

private void OnHasUnsavedDrawnAnnotationsClicked(object sender, EventArgs e)
{
    if (this.imageEditor.HasUnsavedDrawnAnnotations)
    {
        this.imageEditor.SaveEdits();
    }
}

{% endhighlight %}

{% endtabs %}

N> [View sample in GitHub](https://github.com/SyncfusionExamples/maui-image-editor-examples/tree/master/ImageSavingSample)

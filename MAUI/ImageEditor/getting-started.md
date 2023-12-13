---
layout: post
title: Getting Started with .NET MAUI Image Editor control | Syncfusion
description: Learn about getting started with Syncfusion .NET MAUI ImageEditor(SfImageEditor) control.
platform: maui
control: SfImageEditor
documentation: ug
---

# Getting Started with .NET MAUI ImageEditor (SfImageEditor)

This section explains the steps to create and load an image to the [.Net MAUI ImageEditor(SfImageEditor)](https://www.syncfusion.com/maui-controls/maui-image-editor) control.

## Creating an application using the .NET MAUI ImageEditor

1. Create a new .NET MAUI application in Visual Studio.

2. Syncfusion .NET MAUI components are available in [nuget.org](https://www.nuget.org/). To add the SfImageEditor to your project, open the NuGet package manager in Visual Studio, search for [Syncfusion.Maui.ImageEditor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.html) and install it.

3. To initialize the control, import the control namespace [Syncfusion.Maui.ImageEditor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.html) in XAML or C# code.

4. Initialize [SfImageEditor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.SfImageEditor.html).

{% tabs %}
{% highlight XAML hl_lines="3 5" %}

<ContentPage   
    . . .
    xmlns:imageEditor="clr-namespace:Syncfusion.Maui.ImageEditor;assembly=Syncfusion.Maui.ImageEditor">

    <imageEditor:SfImageEditor />
</ContentPage>

{% endhighlight %}
{% highlight C# hl_lines="1 9 10" %}

using Syncfusion.Maui.ImageEditor;
. . .

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        SfImageEditor imageEditor = new SfImageEditor();
        this.Content = imageEditor;
    }
}

{% endhighlight %}
{% endtabs %}

## Register the handler

The [Syncfusion.Maui.Core](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.html) nuget is a dependent package for all Syncfusion controls of .NET MAUI. In the `MauiProgram.cs` file, register the handler for Syncfusion core.

{% tabs %}
{% highlight C# tabtitle="MauiProgram.cs" hl_lines="1 10" %}

using Syncfusion.Maui.Core.Hosting;
namespace GettingStarted
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();

            builder.ConfigureSyncfusionCore();
            builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("Segoe-mdl2.ttf", "SegoeMDL2");
            });

            return builder.Build();
        }
    }
}

{% endhighlight %}
{% endtabs %}

## Loading an image to image editor

The [Source](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.SfImageEditor.html#Syncfusion_Maui_ImageEditor_SfImageEditor_Source) property is used to load images from different sources:

N> You can load image formats such as JPEG, PNG, and BMP to the image editor.

### Loading a local file

To load an image from a local path. The following code shows adding an image to the image editor control with the format as "JPEG" and name as "image."

{% tabs %}
{% highlight xaml hl_lines="3" %}

<ContentPage 
            . . .
            <imageEditor:SfImageEditor Source="D:\images\image.jpeg"/>

</ContentPage>

{% endhighlight %}
{% highlight C# hl_lines="9 10 11" %}

using Syncfusion.Maui.ImageEditor;
namespace SyncfusionImageEditor;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
        InitializeComponent();
        SfImageEditor imageEditor = new SfImageEditor();
        imageEditor.Source = ImageSource.FromFile("D:\\images\\image.jpeg");
        this.content = imageEditor;
    }
}
{% endhighlight %}
{% endtabs %}

### Load an image from URI

To load an image from a remote URI, you can use the following code example.

{% tabs %}
{% highlight xaml %}

<ContentPage 
            . . .
            <imageEditor:SfImageEditor Source="https://dummyimage.com/300x200/000/fff.png"/>

</ContentPage>

{% endhighlight %}
{% highlight C#  %}

using Syncfusion.Maui.ImageEditor;
namespace SyncfusionImageEditor;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
        InitializeComponent();
        SfImageEditor imageEditor = new SfImageEditor();
        imageEditor.Source = ImageSource.FromUri(new Uri("https://dummyimage.com/300x200/000/fff.png"));
        this.content = imageEditor;
    }
}
{% endhighlight %}
{% endtabs %}

### Load an image from Resource folder

To load an image from a resource file.

Refer to the following steps to add an image to the project:

1. Locate the "Resources" folder in your .NET MAUI project. This folder is typically located in the project's root directory.
2. Right-click on the "Resources" folder in the project structure view or Solution Explorer.
3. From the context menu, select "Add" and then "Existing Item." This will open a file selection dialog.
4. Browse to the location on your computer where the image file is stored.
5. Select the image file you want to add to the "Resources" folder.
6. Click "Add" to add the image file to the project.
7. Assign the image name, including its extension, to the [Source](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.SfImageEditor.html#Syncfusion_Maui_ImageEditor_SfImageEditor_Source) property of the image editor control.

The following code shows adding an image to the image editor control.

{% tabs %}
{% highlight xaml %}

<ContentPage 
            . . .
            <imageEditor:SfImageEditor Source="image.jpeg"/>

</ContentPage>

{% endhighlight %}
{% highlight C#  %}

using Syncfusion.Maui.ImageEditor;
namespace SyncfusionImageEditor;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
        InitializeComponent();
        SfImageEditor imageEditor = new SfImageEditor();
        imageEditor.Source =  ImageSource.FromResource("MyProject.Resources.Images.image.jpeg");
        this.content = imageEditor;
    }
}
{% endhighlight %}
{% endtabs %}

### Load an image from stream

To load an image from a byte array, use the provided code example for stream-based loading.

{% tabs %}
{% highlight C#  %}

using Syncfusion.Maui.ImageEditor;
using System.Reflection;
namespace SyncfusionImageEditor;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
        InitializeComponent();
        SfImageEditor imageEditor = new SfImageEditor();
        Assembly assembly = Assembly.GetExecutingAssembly();
        imageEditor.Source = ImageSource.FromStream(() => assembly.GetManifestResourceStream("MyProject.Resources.Images.image.jpeg"))
        this.content = imageEditor;
    }
}
{% endhighlight %}
{% endtabs %}

![GettingStarted in .NET Maui ImageEditor](images\getting-started\imageeditor-gettingstarted.png)

N> If you set the Stream source with a local variable, the stream will be closed after the image uses it, and you cannot process the stream again. So, we recommend using stream images by creating a new stream instance inside the Lamba function so that you can process them whenever needed.

imageEditor.Source = ImageSource.FromStream(() => new MemoryStream(imageBytes))

N> [View sample in GitHub](https://github.com/SyncfusionExamples/maui-image-editor-examples/tree/master/GettingStarted)

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

### Verify Image Editing Status

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

## ImageEditor inside stack layout

#### Vertical StackLayout

When the image editor is placed inside a vertical stack layout, users must define the required `MinimumHeightRequest` value. By default, this `MinimumHeightRequest` is set to 100.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

<VerticalStackLayout>
    <imageEditor:SfImageEditor x:Name="imageEditor"
                               MinimumHeightRequest="400"
                               Source="image.jpeg">
    </imageEditor:SfImageEditor>
</VerticalStackLayout>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

public MainPage()
{
    InitializeComponent();
    VerticalStackLayout verticalLayout = new VerticalStackLayout();
    SfImageEditor imageEditor = new SfImageEditor();
    imageEditor.Source = ImageSource.FromResource("MyProject.Resources.Images.image.jpeg");
    imageEditor.MinimumHeightRequest = 400;
    verticalLayout.Add(imageEditor);
    this.Content = verticalLayout;
}

{% endhighlight %}
{% endtabs %}

#### Horizontal StackLayout

When the image editor is placed inside a horizontal stack layout, users must define the required `MinimumWidthRequest` value. By default, this `MinimumWidthRequest` is set to 100.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

<HorizontalStackLayout>
    <imageEditor:SfImageEditor x:Name="imageEditor"
                               MinimumWidthRequest="400"
                               Source="image.jpeg">
    </imageEditor:SfImageEditor>
</HorizontalStackLayout>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

public MainPage()
{
    InitializeComponent();
    HorizontalStackLayout horizontalLayout = new HorizontalStackLayout();
    SfImageEditor imageEditor = new SfImageEditor();
    imageEditor.Source = ImageSource.FromResource("MyProject.Resources.Images.image.jpeg");
    imageEditor.MinimumWidthRequest = 400;
    horizontalLayout.Add(imageEditor);
    this.Content = horizontalLayout;
}

{% endhighlight %}
{% endtabs %}
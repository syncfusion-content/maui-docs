---
layout: post
title: Getting Started with .NET MAUI Image Editor control | Syncfusion
description: Learn here all about getting started with Syncfusion<sup>&reg;</sup> .NET MAUI ImageEditor(SfImageEditor) control and more.
platform: maui
control: SfImageEditor
documentation: ug
keywords: .net maui imageEditor, .net maui image editing, image view maui.
---

# Getting Started with the .NET MAUI ImageEditor

This section explains the steps to create and load an image to the [.Net MAUI ImageEditor(SfImageEditor)](https://www.syncfusion.com/maui-controls/maui-image-editor) control. Follow the steps below to add .NET MAUI ImageEditor control to your project.

To get start quickly with our .NET MAUI ImageEditor, you can check the below video.

{% youtube
"youtube:https://youtu.be/Gkkh52xSehM?si=_WKWcnGgob0DofXe"%}

{% tabcontents %}
{% tabcontent Visual Studio %}

## Prerequisites

Before proceeding, ensure the following are set up:

1. Install [.NET 9 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/9.0) or later.
2. Set up a .NET MAUI environment with Visual Studio 2022 v17.12 or later.

## Step 1: Create a New .NET MAUI Project

1. Go to **File > New > Project** and choose the **.NET MAUI App** template.
2. Name the project and choose a location. Then click **Next**.
3. Select the .NET framework version and click **Create**.

## Step 2: Install the Syncfusion<sup>&reg;</sup> .NET MAUI ImageEditor NuGet Package

1. In **Solution Explorer,** right-click the project and choose **Manage NuGet Packages.**
2. Search for [Syncfusion.Maui.ImageEditor](https://www.nuget.org/packages/Syncfusion.Maui.ImageEditor/) and install the latest version.
3. Ensure the necessary dependencies are installed correctly, and the project is restored.

## Step 3: Register the handler

The [Syncfusion.Maui.Core](https://www.nuget.org/packages/Syncfusion.Maui.Core/) NuGet is a dependent package for all Syncfusion<sup>&reg;</sup> .NET MAUI controls. In the **MauiProgram.cs** file, register the handler for Syncfusion<sup>&reg;</sup> core.

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

## Step 4: Add .NET MAUI ImageEditor control

1. To initialize the control, import the `Syncfusion.Maui.ImageEditor` namespace into your code.
2. Initialize [SfImageEditor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.SfImageEditor.html).

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

{% endtabcontent %}
{% tabcontent Visual Studio Code %}

## Prerequisites

Before proceeding, ensure the following are set up:

1. Install [.NET 9 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/9.0) or later.
2. Set up a .NET MAUI environment with Visual Studio Code.
3. Ensure that the .NET MAUI workloads are installed and configured as described [here](https://learn.microsoft.com/en-us/dotnet/maui/get-started/installation?view=net-maui-9.0&tabs=visual-studio-code).

## Step 1: Create a New .NET MAUI Project

1. Open the command palette by pressing `Ctrl+Shift+P` and type **.NET:New Project** and enter.
2. Choose the **.NET MAUI App** template.
3. Select the project location, type the project name and press **Enter**.
4. Then choose **Create project.**

## Step 2: Install the Syncfusion<sup>&reg;</sup> .NET MAUI ImageEditor NuGet Package

1. Press <kbd>Ctrl</kbd> + <kbd>`</kbd> (backtick) to open the integrated terminal in Visual Studio Code.
2. Ensure you're in the project root directory where your .csproj file is located.
3. Run the command `dotnet add package Syncfusion.Maui.ImageEditor` to install the Syncfusion<sup>®</sup> .NET MAUI ImageEditor NuGet package.
4. To ensure all dependencies are installed, run `dotnet restore`.

## Step 3: Register the handler

The [Syncfusion.Maui.Core](https://www.nuget.org/packages/Syncfusion.Maui.Core/) NuGet is a dependent package for all Syncfusion<sup>&reg;</sup> .NET MAUI controls. In the **MauiProgram.cs** file, register the handler for Syncfusion<sup>&reg;</sup> core.

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

## Step 4: Add .NET MAUI ImageEditor control

1. To initialize the control, import the `Syncfusion.Maui.ImageEditor` namespace into your code.
2. Initialize [SfImageEditor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.SfImageEditor.html).

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

{% endtabcontent %}

{% tabcontent JetBrains Rider %}

## Prerequisites

Before proceeding, ensure the following are set up:

1. Install [.NET 9 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/9.0) or later.
2. Set up a .NET MAUI environment with JetBrains Rider 2024.3 or later.
3. Make sure the MAUI workloads are installed and configured as described [here.](https://www.jetbrains.com/help/rider/MAUI.html#before-you-start)

## Step 1: Create a new .NET MAUI Project

1. Go to **File > New Solution,** Select .NET (C#) and choose the .NET MAUI App template.
2. Enter the Project Name, Solution Name, and Location.
3. Select the .NET framework version and click Create.

## Step 2: Install the Syncfusion<sup>®</sup> MAUI ImageEditor NuGet Package

1. In **Solution Explorer,** right-click the project and choose **Manage NuGet Packages.**
2. Search for [Syncfusion.Maui.ImageEditor](https://www.nuget.org/packages/Syncfusion.Maui.ImageEditor/) and install the latest version.
3. Ensure the necessary dependencies are installed correctly, and the project is restored. If not, Open the Terminal in Rider and manually run: `dotnet restore`

## Step 3: Register the handler

The [Syncfusion.Maui.Core](https://www.nuget.org/packages/Syncfusion.Maui.Core/) NuGet is a dependent package for all Syncfusion<sup>&reg;</sup> .NET MAUI controls. In the **MauiProgram.cs** file, register the handler for Syncfusion<sup>&reg;</sup> core.

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

## Step 4: Add .NET MAUI ImageEditor control

1. To initialize the control, import the `Syncfusion.Maui.ImageEditor` namespace into your code.
2. Initialize [SfImageEditor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.SfImageEditor.html).

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

{% endtabcontent %}
{% endtabcontents %}

## Step 5: Loading an image to image editor

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

N> To load an URI image on iOS platform, you need to set the [App Transport Security (ATS)](https://developer.apple.com/documentation/bundleresources/information-property-list/nsapptransportsecurity) configuration in the Info.plist file.

{% tabs %}
{% highlight C# tabtitle="Info.plist" %}

<key>NSAppTransportSecurity</key>
<dict>
	<key>NSAllowsArbitraryLoads</key>
	<true/>
</dict>

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

The following screenshot illustrates the result of the above code.

![GettingStarted in .NET Maui ImageEditor](images\getting-started\imageeditor-gettingstarted.png)

N> If you set the Stream source with a local variable, the stream will be closed after the image uses it, and you cannot process the stream again. So, we recommend using stream images by creating a new stream instance inside the Lambda function so that you can process them whenever needed.
imageEditor.Source = ImageSource.FromStream(() => new MemoryStream(imageBytes))

N> [View sample in GitHub](https://github.com/SyncfusionExamples/maui-image-editor-examples/tree/master/GettingStarted). You can also explore our [.NET MAUI Image Editor Example](https://github.com/syncfusion/maui-demos/tree/master/MAUI/ImageEditor) that shows you how to render the Image Editor in .NET MAUI.
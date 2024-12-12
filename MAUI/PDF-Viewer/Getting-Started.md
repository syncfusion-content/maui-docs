---
layout: post
title: Getting Started with .NET MAUI PDF Viewer control | Syncfusion®
description: Learn here about getting started with Syncfusion® .NET MAUI PDF Viewer (SfPdfViewer) control, its elements, and more.
platform: MAUI
control: SfPdfViewer
documentation: ug
---

# Getting Started with .NET MAUI PDF Viewer

This section guides you through setting up and configuring PDF viewer in your .NET MAUI application. Follow the steps below to add the PDF viewer to your project and load a PDF document.

To get started quickly, you can also check out our video tutorial below. 

<style>#MAUISfPdfViewerVideoTutorial{width : 90% !important; height: 400px !important }</style> <iframe id='MAUISfPdfViewerVideoTutorial' src='https://www.youtube.com/embed/KdXoeL5wvkA'></iframe>

## Prerequisites

Before proceeding, ensure the following are in place:

1.	Install [.NET 7 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/7.0) or later.
2.	Set up a .NET MAUI environment with Visual Studio 2022 (v17.3 or later) or VS Code. For VS Code users, ensure that the .NET MAUI workload is installed and configured as described [here](https://learn.microsoft.com/en-us/dotnet/maui/get-started/installation?view=net-maui-8.0&tabs=visual-studio-code).

## Step 1: Create a New MAUI Project

### Visual Studio

1.  Go to **File > New > Project** and choose the **.NET MAUI App** template.
2.  Name the project and choose a location, then click **Next**.
3.  Select the .NET framework version and click **Create**.

### Visual Studio Code

1.  Open the command palette by pressing `Ctrl+Shift+P`` and type **.NET:New Project** and enter.
2.  Choose the **.NET MAUI App** template.
3.  Select the project location, type the project name and press enter.
4.  Then choose **Create project**

## Step 2: Install the Syncfusion® MAUI PDF Viewer NuGet Package

1.  In **Solution Explorer**, right click the project and choose **Manage NuGet Packages** for Visual Studio and **Add NuGet Package** for Visual Studio Code.
2.  Search for [Syncfusion.Maui.PdfViewer](https://www.nuget.org/packages/Syncfusion.Maui.PdfViewer) and install the latest version.`
3.  Ensure the necessary dependencies are installed correctly, and the project is restored.

## Step 3: Register the Syncfusion® Core Handler

[Syncfusion.Maui.Core](https://www.nuget.org/packages/Syncfusion.Maui.Core/) is a dependency for all MAUI Syncfusion controls. This package will be automatically installed as a dependency when [Syncfusion.Maui.PdfViewer](https://www.nuget.org/packages/Syncfusion.Maui.PdfViewer) NuGet is installed. Register the Syncfusion® core handler in the `MauiProgram.cs` file.

{% tabs %}
{% highlight c# tabtitle="MauiProgram.cs" hl_lines="1 17" %}

using Syncfusion.Maui.Core.Hosting;

namespace PdfViewerExample
{
    public class MauiProgram 
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                });

           builder.ConfigureSyncfusionCore();
           return builder.Build();
        }
    }
}
{% endhighlight %} 
{% endtabs %}

## Step 4: Add PDF Viewer to the Project

Open the `MainPage.xaml` file and follow the steps below. 

1.  Import the control namespace `Syncfusion.Maui.PdfViewer`, and then add the [SfPdfViewer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html) control inside the `<ContentPage.Content>` tag as follows.
2.  Name the PDF viewer control as `pdfViewer`.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:syncfusion="clr-namespace:Syncfusion.Maui.PdfViewer;assembly=Syncfusion.Maui.PdfViewer"
             x:Class="PdfViewerExample.MainPage">

    <ContentPage.Content>
        <syncfusion:SfPdfViewer x:Name="pdfViewer">
        </syncfusion:SfPdfViewer>
    </ContentPage.Content>
</ContentPage>

{% endhighlight %} 
{% endtabs %}

## Step 5: Load a PDF Document

1.  From the solution explorer of the project, add a new folder to the project named `Assets` and add the PDF document you need to load in the PDF viewer. Here, a PDF document named `PDF_Succinctly.pdf` is used.`
2.  In Visual Studio, right click the added PDF document and set its `Build Action` as `Embedded Resource`. In VS Code, open the `.csproj` file and add the following code snippet to embed the PDF document as a resource.

{% tabs %}
{% highlight xml tabtitle="PdfViewerExample.csproj" %}

<ItemGroup>
	<EmbeddedResource Include="Assets\PDF_Succinctly.pdf" />
</ItemGroup>

{% endhighlight %} 
{% endtabs %}

3.  In this example, we will load the PDF document through MVVM binding. Create a new C# file named `PdfViewerViewModel.cs` and add the following code snippet.

{% tabs %}
{% highlight c# tabtitle="PdfViewerViewModel.cs" %}

using System.Reflection;
using System.ComponentModel;

namespace PdfViewerExample
{
    class PdfViewerViewModel : INotifyPropertyChanged
    {
        private Stream pdfDocumentStream;

        /// <summary>
        /// Occurs when a property value changes.
        /// </summary>
        public event PropertyChangedEventHandler? PropertyChanged;

        /// <summary>
        /// Gets or sets the stream of the currently loaded PDF document.
        /// </summary>
        public Stream PdfDocumentStream
        {
            get
            {
                return pdfDocumentStream;
            }
            set
            {
                pdfDocumentStream = value;
                OnPropertyChanged(nameof(PdfDocumentStream));
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PdfViewerViewModel"/> class.
        /// </summary>
        public PdfViewerViewModel()
        {
            // Load the embedded PDF document stream.
            pdfDocumentStream = typeof(App).GetTypeInfo().Assembly.GetManifestResourceStream("PdfViewerExample.Assets.PDF_Succinctly.pdf");
        }

        /// <summary>
        /// Raises the <see cref="PropertyChanged"/> event for the specified property name.
        /// </summary>
        /// <param name="name">The name of the property that changed.</param>
        public void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        } 
    }
}

{% endhighlight %} 
{% endtabs %}

4.  Open the `MainPage.xaml` file again and add the default namespace of the created .NET MAUI project and name it as `local`. Here the default namespace of the demo sample `PdfViewerExample` is used.
5.  Set an instance of the `PdfViewerViewModel` class as the `BindingContext` of the `ContentPage`.
6.  Bind the PDF viewer's [DocumentSource](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_DocumentSource) to the `PdfDocumentStream` property of the `PdfViewerViewModel` class.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:syncfusion="clr-namespace:Syncfusion.Maui.PdfViewer;assembly=Syncfusion.Maui.PdfViewer"
             x:Class="PdfViewerExample.MainPage">

    <ContentPage.BindingContext>
        <local:PdfViewerViewModel x:Name="viewModel" />
    </ContentPage.BindingContext>

    <ContentPage.Content>
        <syncfusion:SfPdfViewer x:Name="pdfViewer" DocumentSource="{Binding PdfDocumentStream}">
        </syncfusion:SfPdfViewer>
    </ContentPage.Content>
</ContentPage>

{% endhighlight %} 
{% endtabs %}

N> 1. While changing or opening different documents on the same page, the previously loaded document will be unloaded automatically by the [SfPdfViewer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html). 
N> 2. And, if you are using multiple pages in your application, then make sure to unload the document from the [SfPdfViewer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html) while leaving the page that has it to release the memory and resources consumed by the PDF document that is loaded.  The unloading of documents can be done by calling the [UnloadDocument](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_UnloadDocument) method. 

## Step 6: Running the Application

1.  Select the target framework, device or emulator.
2.  Press `F5` to run the application.
3.  The PDF document will be loaded in the PDF viewer control as shown in the following screenshot.

![Getting started with .NET MAUI PDF Viewer](Images\Getting-Started\maui-pdf-viewer-getting-started.png)

The **Getting Started** example project for the.NET MAUI PDF Viewer can be downloaded [here](https://github.com/SyncfusionExamples/maui-pdf-viewer-examples). 

N> You can refer to our [.NET MAUI PDF Viewer](https://www.syncfusion.com/maui-controls/maui-pdf-viewer) feature tour page for its groundbreaking feature representations. You can also explore our [.NET MAUI PDF Viewer Example](https://github.com/syncfusion/maui-demos/tree/master/MAUI/PdfViewer) that shows you how to render the PDF Viewer in .NET MAUI.
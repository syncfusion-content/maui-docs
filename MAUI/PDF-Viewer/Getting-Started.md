---
layout: post
title: Getting Started with .NET MAUI PDF Viewer control | Syncfusion
description: Learn here about getting started with Syncfusion .NET MAUI PDF Viewer (SfPdfViewer) control, its elements, and more.
platform: MAUI
control: SfPdfViewer
documentation: ug
---

# Getting Started with .NET MAUI PDF Viewer (SfPdfViewer)

This section walks you through the process of viewing or displaying a PDF document in a.NET MAUI application using the [SfPdfViewer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html) control.

To get started quickly with .NET MAUI SfPdfViewer, you can check on this video:

<style>#MAUISfPdfViewerVideoTutorial{width : 90% !important; height: 400px !important }</style> <iframe id='MAUISfPdfViewerVideoTutorial' src='https://www.youtube.com/embed/KdXoeL5wvkA'></iframe>

## Creating an application using the .NET MAUI PDF Viewer

**Step 1:** Create a new .NET MAUI application in Visual Studio.

**Step 2:** Add the `Syncfusion.Maui.PdfViewer` nuget package reference to your project from [nuget.org](https://www.nuget.org/).

**Step 3:** In the `MauiProgram.cs` file, register the Syncfusion core handler.

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

**Step 4:** Add a new folder to the project named `Assets` and add the PDF document you need to display in the PDF viewer; here, a PDF file named “PDF_Succinctly.pdf” has been used.

N>You can also load files from local storage or URLs. 

**Step 5:** In this example, we will be following the MVVM binding. So, create a new view model class named `PdfViewerViewModel.cs` and add the below code snippet to it.

{% tabs %}
{% highlight c# tabtitle="PdfViewerViewModel.cs" %}

using System.Reflection;
using System.ComponentModel;

namespace PdfViewerExample
{
    class PdfViewerViewModel : INotifyPropertyChanged
    {
        private Stream? m_pdfDocumentStream;

        /// <summary>
        /// An event to detect the change in the value of a property.
        /// </summary>
        public event PropertyChangedEventHandler? PropertyChanged;

        /// <summary>
        /// The PDF document stream that is loaded into the instance of the PDF viewer. 
        /// </summary>
        public Stream PdfDocumentStream
        {
            get
            {
                return m_pdfDocumentStream;
            }
            set
            {
                m_pdfDocumentStream = value;
                OnPropertyChanged("PdfDocumentStream");
            }
        }

        /// <summary>
        /// Constructor of the view model class
        /// </summary>
        public PdfViewerViewModel()
        {
            //Accessing the PDF document that is added as embedded resource as stream.
            m_pdfDocumentStream = typeof(App).GetTypeInfo().Assembly.GetManifestResourceStream("PdfViewerExample.Assets.PDF_Succinctly.pdf");
        }

        public void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        } 
    }
}
{% endhighlight %} 
{% endtabs %}

**Step 6:** In the `MainPage.xaml`, import the control namespace `Syncfusion.Maui.PdfViewer`, and then initialize the `SfPdfViewer` control and bind the `PdfDocumentStream` created to the [DocumentSource](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_DocumentSource)` property. The following code snippet explains the same.

N>`DocumentSource` property supports both `Stream` and `byte[]` objects.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:syncfusion="clr-namespace:Syncfusion.Maui.PdfViewer;assembly=Syncfusion.Maui.PdfViewer"
             xmlns:local="clr-namespace:PdfViewerExample"
             x:Class="PdfViewerExample.MainPage">

    <ContentPage.BindingContext>
        <local:PdfViewerViewModel x:Name="viewModel" />
    </ContentPage.BindingContext>

    <ContentPage.Content>
        <syncfusion:SfPdfViewer x:Name="PdfViewer"
                               DocumentSource="{Binding PdfDocumentStream}">
        </syncfusion:SfPdfViewer>
    </ContentPage.Content>
</ContentPage>

{% endhighlight %} 
{% endtabs %}

N> 1. While changing or opening different documents on the same page, the previously loaded document will be unloaded automatically by the [SfPdfViewer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html). 
N> 2. And, if you are using multiple pages in your application, then make sure to unload the document from the [SfPdfViewer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html) while leaving the page that has it to release the memory and resources consumed by the PDF document that is loaded.  The unloading of documents can be done by calling the [UnloadDocument](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_UnloadDocument) method. 

**Step 7:** Finally, run the application to obtain the following output.

![Getting started with .NET MAUI PDF Viewer](Images\Getting-Started\maui-pdf-viewer-getting-started.png)

The **Getting Started** example project for the.NET MAUI PDF Viewer can be downloaded [here](https://github.com/SyncfusionExamples/maui-pdf-viewer-examples). 

N> You can refer to our [.NET MAUI PDF Viewer](https://www.syncfusion.com/maui-controls/maui-pdf-viewer) feature tour page for its groundbreaking feature representations. You can also explore our [.NET MAUI PDF Viewer Example](https://github.com/syncfusion/maui-demos/tree/master/MAUI/PdfViewer) that shows you how to render the PDF Viewer in .NET MAUI.
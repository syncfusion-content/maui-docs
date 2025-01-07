---
layout: post
title: Open a PDF From Local Storage in .NET MAUI PDF Viewer | Syncfusion
description: Learn here about opening a PDF document from local storage in Syncfusion<sup>®</sup> .NET MAUI PDF Viewer (SfPdfViewer) control.
platform: MAUI
control: SfPdfViewer
documentation: ug
---

# Open a PDF From Local Storage in .NET MAUI PDF Viewer (SfPdfViewer)

A PDF document can be opened in the [SfPdfViewer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html) from the local storage by reading the file as `Stream` and assigning the obtained `Stream` to the [DocumentSource](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_DocumentSource) property.

Just by making a few changes to the `MainPage.xaml` and `PdfViewerViewModel.cs` shared in the getting started example, you can easily open a document from the local storage with the help of [File Picker](https://learn.microsoft.com/en-us/dotnet/maui/platform-integration/storage/file-picker?view=net-maui-7.0&tabs=ios) as one of the options. 

In `MainPage.xaml`, add a new button to open a PDF document from the local storage using `File Picker` when pressed. Refer to the following code:

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             x:Class="OpenLocalFile.MainPage"
             xmlns:local="clr-namespace:OpenLocalFile"
             xmlns:syncfusion="clr-namespace:Syncfusion.Maui.PdfViewer;assembly=Syncfusion.Maui.PdfViewer">
    <ContentPage.BindingContext>
        <local:PdfViewerViewModel/>
    </ContentPage.BindingContext>
    <Grid>
        <Grid.RowDefinitions>
            <RowDefinition Height="Auto"/>
            <RowDefinition Height="*"/>
        </Grid.RowDefinitions>
        <Grid
            Grid.Row="0" BackgroundColor="#FFF6F6F6" Padding="8"
            IsVisible="{OnPlatform MacCatalyst=False}">
            <Label FontSize="Medium" TextColor="Black" VerticalOptions="Center" Text="Choose File"></Label>
            <ImageButton 
                Source="openfile.png" 
                BackgroundColor="#FFF6F6F6"
                VerticalOptions="Center" HorizontalOptions="End" 
                Aspect="Center" Command="{Binding OpenDocumentCommand}"/>
        </Grid>
        <syncfusion:SfPdfViewer Grid.Row="1" DocumentSource="{Binding PdfDocumentStream}"/>
    </Grid>
</ContentPage>

{% endhighlight %} 
{% endtabs %}

In `PdfViewerViewModel.cs`, implement the functionalities of the `File picker` to choose a PDF document and read its stream, which can be assigned to the [DocumentSource](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html#Syncfusion_Maui_PdfViewer_SfPdfViewer_DocumentSource) property of the [SfPdfViewer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PdfViewer.SfPdfViewer.html) to view the document. Refer to the following code:

{% tabs %}
{% highlight c# tabtitle="PdfViewerViewModel.cs" %}

using System.ComponentModel;
using System.Reflection;
using System.Windows.Input;

namespace OpenLocalFile
{
    internal class PdfViewerViewModel : INotifyPropertyChanged
    {
        private Stream m_pdfDocumentStream;
        private ICommand m_openDocumentCommand;

        /// <summary>
        /// An event to detect the change in the value of a property.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Command to open document using a file picker.
        /// </summary>
        public ICommand OpenDocumentCommand
        {
            get
            {
                if (m_openDocumentCommand == null)
                    m_openDocumentCommand = new Command<object>(OpenDocument);
                return m_openDocumentCommand;
            }
        }

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
            m_pdfDocumentStream = typeof(App).GetTypeInfo().Assembly.GetManifestResourceStream("OpenLocalFile.Assets.PDF_Succinctly.pdf");
        }

        public void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        /// <summary>
        /// Opens a document using file picker.
        /// </summary>
        async void OpenDocument(object commandParameter)
        {
            //Create file picker with file type as PDF.
            FilePickerFileType pdfFileType = new FilePickerFileType(new Dictionary<DevicePlatform, IEnumerable<string>>{
                        { DevicePlatform.iOS, new[] { "public.pdf" } },
                        { DevicePlatform.Android, new[] { "application/pdf" } },
                        { DevicePlatform.WinUI, new[] { "pdf" } },
                        { DevicePlatform.MacCatalyst, new[] { "pdf" } },
                    });

            //Provide picker title if required.
            PickOptions options = new()
            {
                PickerTitle = "Please select a PDF file",
                FileTypes = pdfFileType,
            };
            await PickAndShow(options);
        }

        /// <summary>
        /// Picks the file from local storage and store as stream.
        /// </summary>
        public async Task PickAndShow(PickOptions options)
        {
            try
            {
                //Pick the file from local storage.
                var result = await FilePicker.Default.PickAsync(options);
                if (result != null)
                {
                    //Store the resultant PDF as stream.
                    PdfDocumentStream = await result.OpenReadAsync();
                }
            }
            catch (Exception ex)
            {
                //Display error when file picker failed to open files.
                string message;
                if (ex != null && string.IsNullOrEmpty(ex.Message) == false)
                    message = ex.Message;
                else
                    message = "File open failed.";
                Application.Current?.MainPage?.DisplayAlert("Error", message, "OK");
            }
        }
    }
}

{% endhighlight %} 
{% endtabs %}

The example project to open a PDF document from local storage using `File Picker` can be downloaded [here](https://github.com/SyncfusionExamples/maui-pdf-viewer-examples). 

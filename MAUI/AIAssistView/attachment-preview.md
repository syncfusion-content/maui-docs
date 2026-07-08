---
layout: post
title: Attachment Preview Editor in .NET MAUI AI AssistView | Syncfusion®
description: Learn how to preview attachments in the Syncfusion .NET MAUI AI AssistView (SfAIAssistView) using the Attachments property to display files and images.
platform: MAUI
control: SfAIAssistView
documentation: ug
---

# How to Preview Attachments in .NET MAUI SfAIAssistView Editor?

Previewing attachments in the [SfAIAssistView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.html) editor allows users to view files and images before sending them. This improves usability by providing a clear representation of the attached content within the chat interface.

## Working with Attachment Preview in AI AssistView

The `SfAIAssistView` allows you to add files and images as attachments in the editor using [Attachments](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_Attachments) property. This feature lets you show the preview for attachments added in the editor. `Attachments` are added as [AssistAttachment](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.AssistAttachment.html) which has the following members:

* [FileName](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.AssistAttachment.html#Syncfusion_Maui_AIAssistView_AssistAttachment_FileName) : Displays the name of the file.
* [FileSize](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.AssistAttachment.html#Syncfusion_Maui_AIAssistView_AssistAttachment_FileSize) : Contains the size of the file in bytes (requires a value converter to format for display).
* [FilePath](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.AssistAttachment.html#Syncfusion_Maui_AIAssistView_AssistAttachment_FilePath) : Displays the local path of the file.
* [FileExtension](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.AssistAttachment.html#Syncfusion_Maui_AIAssistView_AssistAttachment_FileExtension) : Displays the type of the file using the extension.
* [FileContent](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.AssistAttachment.html#Syncfusion_Maui_AIAssistView_AssistAttachment_FileContent) : Displays the content of the file.
* [FilePreviewIcon](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.AssistAttachment.html#Syncfusion_Maui_AIAssistView_AssistAttachment_FilePreviewIcon) : Displays the preview icon for the file.

{% tabs %}
{% highlight xaml hl_lines="2" %}

<ContentPage.BindingContext>
    <local:ViewModel/>
</ContentPage.BindingContext>

<syncfusion:SfAIAssistView x:Name="sfAIAssistView"
                           Attachments="{Binding Attachments}"/>
{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Windows.Input;
using Syncfusion.Maui.AIAssistView;

public class ViewModel : INotifyPropertyChanged
{
    private ObservableCollection<IAttachment>? attachments;

    public event PropertyChangedEventHandler? PropertyChanged;

    public ViewModel()
    {
        Attachments = new ObservableCollection<IAttachment>();
        UploadCommand = new Command(async () => await UploadFilesAsync());
    }

    public ObservableCollection<IAttachment>? Attachments
    {
        get => attachments;
        set
        {
            if (attachments != value)
            {
                attachments = value;
                OnPropertyChanged(nameof(Attachments));
            }
        }
    }

    public ICommand UploadCommand { get; }

    private void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    private async Task UploadFilesAsync()
    {
        try
        {
            var results = await FilePicker.Default.PickMultipleAsync();
            if (results == null) return;

            foreach (var file in results)
            {
                Stream stream = await file.OpenReadAsync();

                long size;
                if (stream.CanSeek)
                {
                    size = stream.Length;
                }
                else
                {
                    using var ms = new MemoryStream();
                    await stream.CopyToAsync(ms);
                    size = ms.Length;
                    stream.Dispose();
                    stream = new MemoryStream(ms.ToArray());
                }

                Attachments?.Add(new AssistAttachment
                {
                    FileName = file.FileName,
                    FileSize = size,
                    FilePath = file.FullPath ?? string.Empty,
                    FileExtension = Path.GetExtension(file.FileName) ?? string.Empty,
                    FileContent = stream,
                });
            }
        }
        catch (Exception ex)
        {
            // Handle exceptions such as file picker cancellation or read errors.
        }
    }
}
{% endhighlight %}
{% endtabs %}

### Setting the maximum number of attachments in SfAIAssistView

The `SfAIAssistView` control allows you to control the number of attachments using the [MaxAttachmentCount](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_MaxAttachmentCount) property. This feature allows us to restrict the number of attachments that can be added to the `Attachments`. The default value is 10.

{% tabs %}
{% highlight xaml hl_lines="7" %}
<ContentPage.BindingContext>
    <local:ViewModel/>
</ContentPage.BindingContext>

<syncfusion:SfAIAssistView x:Name = "sfAIAssistView"
                           Attachments = "{Binding Attachments}"
                           MaxAttachmentCount = 8/>
{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="12" %}

using Syncfusion.Maui.AIAssistView;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        var viewModel = new ViewModel();
        this.BindingContext = viewModel;
        SfAIAssistView sfAIAssistView = new SfAIAssistView();
        sfAIAssistView.Attachments = viewModel.Attachments;
        sfAIAssistView.MaxAttachmentCount = 8;
        Content = sfAIAssistView;
    }
}
{% endhighlight %}
{% endtabs %}

### Attachment preview customization

The `SfAIAssistView` control allows you to customize the preview for the attachments by using the [AttachmentItemTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_AttachmentItemTemplate) property. This property lets you define a custom layout for the attachment preview UI.

{% tabs %}
{% highlight xaml hl_lines="44" %}
<ContentPage.BindingContext>
    <local:ViewModel/>
</ContentPage.BindingContext>

<ContentPage.Resources>
    <ResourceDictionary>
        <DataTemplate x:Key = "attachmentItemTemplate">
            <Grid Padding="8" ColumnSpacing="10">
                <Grid.ColumnDefinitions>
                    <ColumnDefinition Width="Auto"/>
                    <ColumnDefinition Width="*"/>
                    <ColumnDefinition Width="Auto"/>
                </Grid.ColumnDefinitions>

                <!-- File Icon -->
                <Image WidthRequest="32" HeightRequest="32">
                    <Image.Source>
                         <FontImageSource Glyph="&#xe76c;"
                           FontFamily="MauiMaterialAssets"
                           Color="Black" />
                    </Image.Source>
                </Image>

                <!-- File Details -->
                <StackLayout Grid.Column="1" Spacing="2">
                     <!-- File Name -->
                     <Label Text="{Binding FileName}"
                            FontAttributes="Bold"
                            FontSize="14"
                            LineBreakMode="TailTruncation"/>

                    <!-- File Size -->
                    <Label Text="{Binding FileSize}"
                           FontSize="12"
                           TextColor="Gray"/>
                </StackLayout>
            </Grid>
        </DataTemplate>
    </ResourceDictionary>
</ContentPage.Resources>

<syncfusion:SfAIAssistView x:Name = "sfAIAssistView"
                           Attachments = "{Binding Attachments}"
                           AttachmentItemTemplate = "{StaticResource attachmentItemTemplate}"/>
{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}
using Syncfusion.Maui.AIAssistView;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        var viewModel = new ViewModel();
        this.BindingContext = viewModel;
        SfAIAssistView sfAIAssistView = new SfAIAssistView();
        sfAIAssistView.Attachments = viewModel.Attachments;
        sfAIAssistView.AttachmentItemTemplate = CreateAttachmentItemTemplate();
        Content = sfAIAssistView;
    }

    private DataTemplate CreateAttachmentItemTemplate()
    {
        return new DataTemplate(() =>
        {
            var grid = new Grid
            {
                Padding = new Thickness(8),
                ColumnSpacing = 10,
                ColumnDefinitions =
                {
                    new ColumnDefinition { Width = GridLength.Auto },
                    new ColumnDefinition { Width = GridLength.Star },
                    new ColumnDefinition { Width = GridLength.Auto }
                }
            };

            var image = new Image
            {
                WidthRequest = 32,
                HeightRequest = 32,
                Source = new FontImageSource
                {
                    Glyph = "\ue76c",
                    FontFamily = "MauiMaterialAssets",
                    Color = Colors.Black
                }
            };

            var fileNameLabel = new Label
            {
                FontAttributes = FontAttributes.Bold,
                FontSize = 14,
                LineBreakMode = LineBreakMode.TailTruncation
            };

            fileNameLabel.SetBinding(Label.TextProperty, "FileName");

            var fileSizeLabel = new Label
            {
                FontSize = 12,
                TextColor = Colors.Gray
            };

            fileSizeLabel.SetBinding(Label.TextProperty, "FileSize");

            var detailsLayout = new StackLayout
            {
                Spacing = 2,
                Children =
                {
                   fileNameLabel,
                   fileSizeLabel
                }
            };

            grid.Add(image, 0, 0);
            grid.Add(detailsLayout, 1, 0);

            return grid;
        });
    }
}
{% endhighlight %}
{% endtabs %}

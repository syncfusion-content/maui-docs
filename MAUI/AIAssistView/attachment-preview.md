---
layout: post
title: Attachment Preview in .NET MAUI AI AssistView control | Syncfusion
description: Learn here all about Attachment Preview support in Syncfusion .NET MAUI AI AssistView (SfAIAssistView) control, and more.
platform: MAUI
control: SfAIAssistView
documentation: ug
---

# Attachment Preview in EditorView

The `SfAIAssistView` allows you to add files and images as attachments in the editor using [Attachments](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_Attachments) property. This feature lets you show the preview for attachments added in the editor. `Attachments` are added as [AssistAttachment](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.AssistAttachment.html) which has the following members:

* [FileName](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.AssistAttachment.html#Syncfusion_Maui_AIAssistView_AssistAttachment_FileName) : Displays the name of the file.
* [FileSize](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.AssistAttachment.html#Syncfusion_Maui_AIAssistView_AssistAttachment_FileSize) : Displays the size of the file.
* [FilePath](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.AssistAttachment.html#Syncfusion_Maui_AIAssistView_AssistAttachment_FilePath) : Displays the local path of the file.
* [FileExtension](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.AssistAttachment.html#Syncfusion_Maui_AIAssistView_AssistAttachment_FileExtension) : Displays the type of the file using the extension.
* [FileContent](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.AssistAttachment.html#Syncfusion_Maui_AIAssistView_AssistAttachment_FileContent) : Displays the content of the file.
* [FilePreviewIcon](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.AssistAttachment.html#Syncfusion_Maui_AIAssistView_AssistAttachment_FilePreviewIcon) : Displays the preview icon for the file.

{% tabs %}
{% highlight xaml hl_lines="3" %}

<ContentPage.Content>
      <syncfusion:SfAIAssistView x:Name = "sfAIAssistView"
                                 Attachments = "{Binding Attachments}">
      </syncfusion:SfSfAIAssistView>
</ContentPage.Content>

{% endhighlight %}
{% highlight c# tabtitle="ViewModel.cs" %}

using Syncfusion.Maui.AIAssistView;

internal class ViewModel : INotifyPropertyChanged
{
    private ObservableCollection<IAttachment>? attachments;

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
            }
        }
    }

    public ICommand UploadCommand { get; }

    private async Task UploadFilesAsync()
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
}

{% endhighlight %}
{% endtabs %}

![Preview support in .NET MAUI AI AssistView](Images/attachment-preview/maui-aiassistview-preview.gif)

### Max Attachment Count

The `SfAIAssistView` control allows you to control the number of attachments using the [MaxAttachmentCount](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_MaxAttachmentCount) property. This feature allows us to restrict the number of attachments that can be added to the `Attachments`. The default value is 10.

{% tabs %}
{% highlight xaml hl_lines="4" %}

<ContentPage.Content>
      <syncfusion:SfAIAssistView x:Name = "sfAIAssistView"
                                 Attachments = "{Binding Attachments}"
                                 MaxAttachmentCount = 8>                 
      </syncfusion:SfSfAIAssistView>
</ContentPage.Content>

{% endhighlight %}
{% highlight c# hl_lines="11" %}

using Syncfusion.Maui.AIAssistView;

public partial class MainPage : ContentPage
{
    SfAIAssistView sfAIAssistView;
    public MainPage()
    {
        InitializeComponent();
        sfAIAssistView = new SfAIAssistView();
        sfAIAssistView.Attachment = viewModel.Attachments;
        sfAIAssistView.MaxAttachmentCount = 8;
        this.Content = sfAIAssistView;
    }
}

{% endhighlight %}
{% endtabs %}

### Attachment Item Template

The `SfAIAssistView` control allows you to customize the preview for the attachments by using the [AttachmentItemTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_AttachmentItemTemplate) property. This property lets you define a custom layout for the attachment preview UI.

{% tabs %}
{% highlight xaml hl_lines="13" %}

<ContentPage.Resources>
    <ResourceDictionary>
        <DataTemplate x:Key = "attachmentItemTemplate">
            <Grid>
                ...
            </Grid>
        </DataTemplate>
    </ResourceDictionary>
</ContentPage.Resources>
<ContentPage.Content>
      <syncfusion:SfAIAssistView x:Name = "sfAIAssistView"
                                 Attachments = "{Binding Attachments}"
                                 AttachmentItemTemplate = "{StaticResource attachmentItemTemplate}">
      </syncfusion:SfSfAIAssistView>
</ContentPage.Content>

{% endhighlight %}
{% highlight c# hl_lines="11" %}

using Syncfusion.Maui.AIAssistView;

public partial class MainPage : ContentPage
{
    SfAIAssistView sfAIAssistView;
    public MainPage()
    {
        InitializeComponent();
        sfAIAssistView = new SfAIAssistView();
        SfAIAssistView.Attachments = viewModel.Attachments;
        sfAIAssistView.AttachmentItemTemplate = CreateAttachmentItemTemplate();
        this.Content = sfAIAssistView;
    }

    private DataTemplate CreateAttachmentItemTemplate()
    {
        return new DataTemplate(() =>
        {
            ...
        });
    }
}

{% endhighlight %}
{% endtabs %}
---
layout: post
title: AI-Powered Formatting in .NET MAUI Rich Text Editor | Syncfusion
description: Learn how to use Azure OpenAI to format unstructured content into structured business documents in Syncfusion® .NET MAUI Rich Text Editor applications.
platform: MAUI
control: SfRichTextEditor
documentation: ug
---

# AI-Powered Smart Formatting in .NET MAUI Rich Text Editor

This document demonstrates how to integrate Azure OpenAI with the Syncfusion [.NET MAUI Rich Text Editor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.RichTextEditor.SfRichTextEditor.html) control to transform raw or semi-structured content into a professional, structured business document. The sample accepts user-provided notes, sends them to an AI model, and then renders the output as rich HTML inside the editor.

The implementation is designed for practical business scenarios such as meeting notes, support tickets, project updates, and interview transcripts. It automatically creates polished headings, paragraphs, bullet points, numbered steps, and action items while preserving the source information.

N> **Prerequisite:** Before starting, ensure that the required Syncfusion NuGet packages are installed, the .NET MAUI project is configured correctly, and the [Rich Text Editor getting started](https://help.syncfusion.com/maui/rich-text-editor/getting-started) steps are completed.

## Step 1: Create a .NET MAUI app

Open Visual Studio and create a new .NET MAUI app. Choose a blank or basic project template and then add the Syncfusion .NET MAUI Rich Text Editor control to the project.

For this sample, the app can be structured in a simple way:

- A `Models` folder for the structured AI response
- A `Services` folder for the AI formatting logic
- A `ViewModels` folder for the page logic and data binding
- A main page for the input and output UI

This keeps the sample easy to follow and makes it easier for beginners to understand the responsibilities of each file. The sample follows the MVVM (Model-View-ViewModel) pattern, which is the recommended approach for building maintainable .NET MAUI applications.

## Step 2: Install the required packages

This sample uses the Syncfusion Rich Text Editor control and the built-in .NET HTTP stack to call the Azure OpenAI REST endpoint.

Install the following package if it is not already available in the project:

- Syncfusion .NET MAUI Rich Text Editor package

You do not need a large AI SDK for this example because the code calls the Azure OpenAI chat completions API directly using `HttpClient`.

N> If you are using this sample in a real environment, replace the placeholder values with your Azure OpenAI endpoint, deployment name, and API key.

## Step 3: Create the model for the AI response

The AI service returns JSON data in a strict format. To make that response easy to handle, create a model that matches the JSON structure expected by the app.

This document model contains information such as the document title and individual sections. Each section can include paragraphs, bullet points, numbered items, action items, keywords, notes, quotes, code snippets, and tables so that a wide variety of source content, such as technical notes or documentation, can be represented accurately.

{% tabs %}
{% highlight c# %}
using System.Text.Json.Serialization;

namespace SmartRTEFormatter.Models;

public sealed class FormattedDocument
{
    [JsonPropertyName("title")]
    public string Title { get; set; } = string.Empty;

    [JsonPropertyName("sections")]
    public List<FormattedSection> Sections { get; set; } = new();
}

public sealed class FormattedSection
{
    [JsonPropertyName("heading")]
    public string Heading { get; set; } = string.Empty;

    [JsonPropertyName("paragraphs")]
    public List<string> Paragraphs { get; set; } = new();

    [JsonPropertyName("bulletItems")]
    public List<string> BulletItems { get; set; } = new();

    [JsonPropertyName("numberedItems")]
    public List<string> NumberedItems { get; set; } = new();

    [JsonPropertyName("actionItems")]
    public List<string> ActionItems { get; set; } = new();

    [JsonPropertyName("keywords")]
    public List<string> Keywords { get; set; } = new();

    [JsonPropertyName("notes")]
    public List<string> Notes { get; set; } = new();

    [JsonPropertyName("quotes")]
    public List<string> Quotes { get; set; } = new();

    [JsonPropertyName("codeSnippets")]
    public List<CodeSnippet> CodeSnippets { get; set; } = new();

    [JsonPropertyName("tables")]
    public List<FormattedTable> Tables { get; set; } = new();
}

public sealed class CodeSnippet
{
    [JsonPropertyName("language")]
    public string Language { get; set; } = string.Empty;

    [JsonPropertyName("code")]
    public string Code { get; set; } = string.Empty;
}

public sealed class FormattedTable
{
    [JsonPropertyName("headers")]
    public List<string> Headers { get; set; } = new();

    [JsonPropertyName("rows")]
    public List<List<string>> Rows { get; set; } = new();
}

public sealed class FormattingResult
{
    public required string HtmlContent { get; init; }

    public required string StructuredJson { get; init; }
}
{% endhighlight %}
{% endtabs %}

This model is simple and clear. It keeps the application logic readable and helps avoid errors when parsing the response returned by Azure OpenAI. The `Keywords`, `Notes`, `Quotes`, `CodeSnippets`, and `Tables` collections are available for future extensions. The current prompt and HTML conversion use the title, section headings, paragraphs, bullet items, numbered items, and action items defined in the JSON contract.

## Step 4: Define the formatter contract

The UI should not directly depend on Azure OpenAI logic. To keep the application clean, create an interface that defines the method used to format text.

{% tabs %}
{% highlight c# %}
using SmartRTEFormatter.Models;

namespace SmartRTEFormatter.Services;

public interface IAIFormattingService
{
    Task<FormattingResult> FormatAsync(string content, CancellationToken cancellationToken = default);
}
{% endhighlight %}
{% endtabs %}

This gives you a clear separation between:

- the user interface
- the AI formatting service
- the structured data model

That separation makes the sample easier to maintain and easier to extend later.

## Step 5: Add the Azure OpenAI formatter service

Create a service class that accepts user content, sends it to Azure OpenAI, and then converts the model response into the document model. The service is responsible for the actual communication with the AI.

The sample includes a strict prompt that tells the model to return valid JSON only. It preserves each source phrase exactly as entered and only moves it to an appropriate document section. The formatter must not correct spelling or grammar, paraphrase, summarize, merge, or split the source text. This prevents malformed output and keeps the generated document faithful to what the user typed.

{% tabs %}
{% highlight c# %}
using System.Text;
using System.Text.Json;
using SmartRTEFormatter.Models;

namespace SmartRTEFormatter.Services;

public sealed class AzureOpenAIFormattingService : IAIFormattingService
{
    private const string BaseEndpoint = "https://YOUR_RESOURCE_NAME.services.ai.azure.com/openai/v1";
    private const string DeploymentName = "gpt-4o-mini";
    private readonly string? apiKey = "YOUR_AZURE_OPENAI_KEY";
    private readonly HttpClient httpClient = new();

    private const string SystemPrompt =
    """
    You are an enterprise-grade document formatting assistant.

    Transform any unstructured or semi-structured content into a professional documentation structure.

    Your ONLY job is to move text into the right structural slot. You must NEVER change the wording.

    Rules:

    1. Return ONLY valid JSON.
    2. Do not return HTML.
    3. Do not return Markdown.
    4. Do not return explanations.
    5. Preserve every piece of source information exactly once.
    6. Do not invent facts or missing content.
    7. Create concise headings that describe the content; generated headings are structure, not rewritten source content.
    8. Copy each source sentence, phrase, or item character-for-character exactly as written, including grammar, spelling, punctuation, capitalization, word order, and tense, even if it looks incorrect or informal.
    9. Do not rewrite, paraphrase, summarize, correct grammar, fix spelling, change tense, substitute words, or improve the user's text in any way.
    10. Do not merge two source sentences into one, and do not split one source sentence into two in a way that changes its wording.
    11. Only reorganize the source content into the JSON categories below; the reorganization itself is the only allowed change.
    11. Use paragraphs for prose, explanations, descriptions, standalone statements, commands, code, configuration, quoted text, and table data when no dedicated field exists.
    12. Use bulletItems for unordered facts, features, requirements, highlights, metrics, keywords, and items.
    13. Use numberedItems only when the source expresses an ordered procedure, sequence, or steps.
    14. Use actionItems only for explicit tasks, responsibilities, follow-ups, or work to be completed.
    15. Preserve code, commands, configuration, SQL, JSON, XML, markup, paths, identifiers, and code-like text character-for-character inside paragraphs or list items.
    16. Preserve quoted text verbatim inside paragraphs or bulletItems.
    17. Keep related content together in one section per logical topic.
    18. Never place the same source sentence or item in more than one output array.
    20. Use empty arrays when a category does not apply.

    Return exactly this JSON structure:

    {
      "title":"string",
      "sections":[
        {
          "heading":"string",
          "paragraphs":["string"],
          "bulletItems":["string"],
          "numberedItems":["string"],
          "actionItems":["string"]
        }
      ]
    }
    """;

    public async Task<FormattingResult> FormatAsync(
        string content,
        CancellationToken cancellationToken = default)
    {
        if (string.IsNullOrWhiteSpace(apiKey))
        {
            var demoDocument = CreateDemoDocument(content);

            return new FormattingResult
            {
                HtmlContent = CreateHtml(demoDocument),
                StructuredJson = SerializeDocument(demoDocument)
            };
        }

        var requestUri = $"{BaseEndpoint}/chat/completions";

        using var request = new HttpRequestMessage(
            HttpMethod.Post,
            requestUri);

        request.Headers.Add("api-key", apiKey);

        request.Content = new StringContent(
            JsonSerializer.Serialize(new
            {
                model = DeploymentName,
                messages = new[]
                {
                    new
                    {
                        role = "system",
                        content = SystemPrompt
                    },
                    new
                    {
                        role = "user",
                        content =
                        $"""
                        Convert the following content into a structured documentation document.

                        Requirements:

                        - Create logical sections.
                        - Preserve every source fact and preserve the original wording, grammar, punctuation, capitalization, spelling, and sentence formation exactly.
                        - Do not rewrite, paraphrase, summarize, correct grammar, or improve the user's text.
                        - Only restructure the content into title, sections, paragraphs, bulletItems, numberedItems, and actionItems.
                        - Use paragraphs for prose, explanations, descriptions, commands, code, configuration, quoted text, and table data.
                        - Use bulletItems for unordered content, features, requirements, highlights, metrics, and keywords.
                        - Use numberedItems only for ordered procedures or sequences.
                        - Use actionItems only for explicit tasks or responsibilities.
                        - Keep related content together, do not duplicate source items, and do not invent missing information.
                        - Use empty arrays when a category does not apply.
                        - Return valid JSON only with exactly the requested schema.

                        Content:

                        {content}
                        """
                    }
                },
                max_completion_tokens = 2500,
                reasoning_effort = "minimal"
            }),
            Encoding.UTF8,
            "application/json");

        using var response =
            await httpClient.SendAsync(request, cancellationToken);

        var responseBody =
            await response.Content.ReadAsStringAsync(cancellationToken);

        if (!response.IsSuccessStatusCode)
        {
            throw new HttpRequestException(
                $"HTTP {(int)response.StatusCode}: {responseBody}");
        }

        using var responseDocument =
            JsonDocument.Parse(responseBody);

        var structuredContent =
            responseDocument.RootElement
                .GetProperty("choices")[0]
                .GetProperty("message")
                .GetProperty("content")
                .GetString();

        if (string.IsNullOrWhiteSpace(structuredContent))
        {
            throw new InvalidOperationException(
                "Azure OpenAI returned no formatted content.");
        }

        var cleanedJson = RemoveCodeFence(structuredContent);

        var formattedDocument =
            JsonSerializer.Deserialize<FormattedDocument>(
                cleanedJson,
                new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });

        if (formattedDocument is null)
        {
            throw new JsonException(
                "Azure OpenAI returned an invalid structured document.");
        }

        return new FormattingResult
        {
            HtmlContent = CreateHtml(formattedDocument),
            StructuredJson = SerializeDocument(formattedDocument)
        };
    }

    private static string RemoveCodeFence(string content)
    {
        return content
            .Replace("```json", string.Empty, StringComparison.OrdinalIgnoreCase)
            .Replace("```", string.Empty, StringComparison.OrdinalIgnoreCase)
            .Trim();
    }

    private static FormattedDocument CreateDemoDocument(string content)
    {
        return new FormattedDocument
        {
            Title = "Formatted Document",
            Sections =
            [
                new FormattedSection
                {
                    Heading = "Content",
                    Paragraphs = content
                        .Split(
                            ['\r', '\n'],
                            StringSplitOptions.RemoveEmptyEntries)
                        .Select(x => x.Trim())
                        .ToList(),
                    BulletItems = [],
                    NumberedItems = [],
                    ActionItems = []
                }
            ]
        };
    }

    private static string SerializeDocument(FormattedDocument document)
    {
        return JsonSerializer.Serialize(
            document,
            new JsonSerializerOptions
            {
                WriteIndented = true
            });
    }

    private static string CreateHtml(FormattedDocument document)
    {
        var html = new StringBuilder();

        AppendHeading(html, document.Title, 1);

        foreach (var section in document.Sections)
        {
            AppendHeading(html, section.Heading, 2);

            AppendParagraphs(html, section.Paragraphs);

            if (section.BulletItems.Count > 0)
            {
                AppendSectionList(html, null, section.BulletItems, "ul");
            }

            if (section.NumberedItems.Count > 0)
            {
                AppendSectionList(html, null, section.NumberedItems, "ol");
            }

            if (section.ActionItems.Count > 0)
            {
                AppendSectionList(html, null, section.ActionItems, "ul", "action-items");
            }
        }

        return html.ToString();
    }

    private static void AppendHeading(
        StringBuilder html,
        string text,
        int level)
    {
        if (string.IsNullOrWhiteSpace(text))
            return;

        html.Append(
            $"<h{level}>{System.Net.WebUtility.HtmlEncode(text)}</h{level}>");
    }

    private static void AppendParagraphs(
        StringBuilder html,
        IEnumerable<string> paragraphs)
    {
        foreach (var paragraph in paragraphs
                     .Where(x => !string.IsNullOrWhiteSpace(x)))
        {
            html.Append(
                $"<p>{System.Net.WebUtility.HtmlEncode(paragraph)}</p>");
        }
    }

    private static void AppendSectionList(
        StringBuilder html,
        string? title,
        IEnumerable<string> items,
        string tag,
        string? cssClass = null)
    {
        var values = items
            .Where(x => !string.IsNullOrWhiteSpace(x))
            .ToList();

        if (values.Count == 0)
            return;

        if (!string.IsNullOrWhiteSpace(title))
        {
            html.Append($"<h3>{System.Net.WebUtility.HtmlEncode(title)}</h3>");
        }

        if (string.IsNullOrWhiteSpace(cssClass))
        {
            html.Append($"<{tag}>");
        }
        else
        {
            html.Append($"<{tag} class=\"{cssClass}\">");
        }

        foreach (var item in values)
        {
            html.Append(
                $"<li>{System.Net.WebUtility.HtmlEncode(item)}</li>");
        }

        html.Append($"</{tag}>");
    }
}
{% endhighlight %}
{% endtabs %}

The important part of this service is the strict JSON contract. The AI model is instructed to return a consistent document schema without rewriting the user's original wording, which reduces parsing issues and makes the Rich Text Editor output predictable and faithful to the source text.

N> Never hardcode a real Azure OpenAI API key in source code, as shown here for illustration only. Store the key securely, for example, in a secrets manager, environment variable, or secure configuration provider, and load it at runtime.

## Step 6: Register the formatter and page in the app

In a .NET MAUI app, the simplest and most maintainable pattern is dependency injection. Register the formatter service, the `MainPageViewModel`, and the `MainPage` in `MauiProgram.cs` so that they can be resolved and injected automatically.

{% tabs %}
{% highlight c# %}
using SmartRTEFormatter.Services;
using SmartRTEFormatter.ViewModels;

namespace SmartRTEFormatter;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>();

        builder.Services.AddSingleton<IAIFormattingService, AzureOpenAIFormattingService>();
        builder.Services.AddTransient<MainPageViewModel>();
        builder.Services.AddTransient<MainPage>();

        return builder.Build();
    }
}
{% endhighlight %}
{% endtabs %}

This step is important because the `MainPage` constructor expects an instance of `MainPageViewModel`, which in turn expects an instance of `IAIFormattingService`.

## Step 7: Create the page ViewModel

With MVVM, the page logic lives in a ViewModel instead of the code-behind file. Create a `MainPageViewModel` class that holds the input text, the formatted HTML, a busy flag, and an error message, and exposes a `FormatCommand` that the button binds to.

{% tabs %}
{% highlight c# %}
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using SmartRTEFormatter.Services;

namespace SmartRTEFormatter.ViewModels;

public sealed class MainPageViewModel : INotifyPropertyChanged
{
    private readonly IAIFormattingService formattingService;
    private string inputText = string.Empty;
    private string formattedHtml = string.Empty;
    private string rawOutput = string.Empty;
    private bool isFormatting;
    private string errorMessage = string.Empty;

    public MainPageViewModel(IAIFormattingService formattingService)
    {
        this.formattingService = formattingService;
        FormatCommand = new Command(
            async () => await FormatAsync(),
            () => !IsFormatting && !string.IsNullOrWhiteSpace(InputText));
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    public string InputText
    {
        get => inputText;
        set
        {
            if (SetProperty(ref inputText, value))
            {
                ((Command)FormatCommand).ChangeCanExecute();
            }
        }
    }

    public string FormattedHtml
    {
        get => formattedHtml;
        private set => SetProperty(ref formattedHtml, value);
    }

    public string RawOutput
    {
        get => rawOutput;
        private set => SetProperty(ref rawOutput, value);
    }

    public bool IsFormatting
    {
        get => isFormatting;
        private set
        {
            if (SetProperty(ref isFormatting, value))
            {
                OnPropertyChanged(nameof(IsFormatButtonVisible));
                ((Command)FormatCommand).ChangeCanExecute();
            }
        }
    }

    public bool IsFormatButtonVisible => !IsFormatting;

    public string ErrorMessage
    {
        get => errorMessage;
        private set => SetProperty(ref errorMessage, value);
    }

    public ICommand FormatCommand { get; }

    private async Task FormatAsync()
    {
        var input = InputText?.Trim();
        if (string.IsNullOrWhiteSpace(input))
        {
            return;
        }

        IsFormatting = true;
        ErrorMessage = string.Empty;

        try
        {
            var result = await formattingService.FormatAsync(input);
            FormattedHtml = result.HtmlContent;
            RawOutput = result.StructuredJson;

            // Refresh the binding when the same content is formatted again.
            OnPropertyChanged(nameof(FormattedHtml));
            OnPropertyChanged(nameof(RawOutput));
        }
        catch (Exception exception)
        {
            ErrorMessage = exception.Message;
        }
        finally
        {
            IsFormatting = false;
        }
    }

    private bool SetProperty<T>(ref T storage, T value, [CallerMemberName] string? propertyName = null)
    {
        if (EqualityComparer<T>.Default.Equals(storage, value))
        {
            return false;
        }

        storage = value;
        OnPropertyChanged(propertyName);
        return true;
    }

    private void OnPropertyChanged(string? propertyName) =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
}
{% endhighlight %}
{% endtabs %}

The `FormatCommand` is disabled automatically while a request is in progress or when the input is empty, so the button cannot be tapped twice or with no content. The `IsFormatButtonVisible` property hides the button and reveals the busy indicator while the AI call is running. `RawOutput` retains the formatted document JSON returned by the service; the current page does not bind it to a visual element, but it is available for diagnostics, storage, or a future JSON preview.

## Step 8: Add the Rich Text Editor input page

Create the page layout with the `SfRichTextEditor` control bound directly to the ViewModel. The editor's `Text` property is bound two-way to `InputText` so the raw content the user types is captured, and its `HtmlText` property is bound to `FormattedHtml` so the AI-generated document replaces the content once formatting completes.

{% tabs %}
{% highlight xaml %}
<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:rte="clr-namespace:Syncfusion.Maui.RichTextEditor;assembly=Syncfusion.Maui.RichTextEditor"
             xmlns:viewModels="clr-namespace:SmartRTEFormatter.ViewModels"
             x:DataType="viewModels:MainPageViewModel"
             x:Class="SmartRTEFormatter.MainPage">
    <ScrollView Orientation="Vertical">
        <Grid RowDefinitions="Auto,Auto,*" Padding="24" RowSpacing="10">
            <VerticalStackLayout Spacing="4">
                <Label Text="AI Powered RichTextEditor" FontSize="22" FontAttributes="Bold" HorizontalOptions="Start" />
            </VerticalStackLayout>

            <HorizontalStackLayout Grid.Row="1" Spacing="8" HorizontalOptions="End">
                <Button x:Name="FormatButton"
                    Text="Format text"
                    Command="{Binding FormatCommand}"
                    IsVisible="{Binding IsFormatButtonVisible}"
                    IsEnabled="{Binding IsFormatButtonVisible}"
                    SemanticProperties.Hint="Formats the entered text with Azure OpenAI." />
                <ActivityIndicator x:Name="ButtonLoadingIndicator"
                           IsVisible="{Binding IsFormatting}"
                           IsRunning="{Binding IsFormatting}"
                           InputTransparent="True"
                           HorizontalOptions="Center"
                           VerticalOptions="Center" />
            </HorizontalStackLayout>

            <VerticalStackLayout Grid.Row="2" Spacing="8">

                <rte:SfRichTextEditor x:Name="RichTextEditor"
                                      ShowToolbar="True"
                                      HeightRequest="400"
                                      Text="{Binding InputText, Mode=TwoWay}"
                                      HtmlText="{Binding FormattedHtml}"
                                      Placeholder="Paste or enter unformatted text here. Click 'Format text' to transform it into structured content." />
            </VerticalStackLayout>

        </Grid>
    </ScrollView>
</ContentPage>
{% endhighlight %}
{% endtabs %}

This layout is intentionally simple so that beginners can focus on the AI data flow instead of being distracted by complex UI logic. Notice that the `Format text` button and busy indicator toggle visibility purely through data binding, without any code-behind event handlers.

## Step 9: Connect the page to the ViewModel

With the `MainPageViewModel` registered in dependency injection, the code-behind file only needs to set the `BindingContext`. All the formatting logic already lives in the ViewModel from the previous step.

{% tabs %}
{% highlight c# %}
using SmartRTEFormatter.ViewModels;

namespace SmartRTEFormatter
{
    public partial class MainPage : ContentPage
    {
        public MainPage(MainPageViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = viewModel;
        }
    }
}
{% endhighlight %}
{% endtabs %}

This is the core interaction of the sample. The flow is simple:

1. The user enters raw text in the `SfRichTextEditor`, which updates `InputText` through the two-way binding.
2. The user taps **Format text**, which runs the `FormatCommand` on the ViewModel.
3. The ViewModel calls `FormatAsync` on the injected `IAIFormattingService`.
4. Azure OpenAI returns a well-structured JSON document, which the service converts to HTML.
5. The ViewModel updates `FormattedHtml`, and the `SfRichTextEditor` displays the formatted result through its `HtmlText` binding.

## Step 10: Understand what the sample produces

When the user enters unstructured notes, the AI service organizes the content into a clean document structure.

The result typically includes:

- a professional title
- meaningful section headings
- short paragraphs for context, commands, code, configuration, and table data
- bullet items for unordered facts, features, requirements, and highlights
- numbered items when order matters
- action items for responsibilities or follow-up tasks

This is useful for workflows such as:

- meeting summaries
- interview notes
- support ticket cleanup
- technical documentation drafting
- internal knowledge base articles

## Step 11: Run the sample

After assembling the files and configuring the Azure OpenAI credentials, run the application on an emulator, simulator, or device.

- Type or paste unstructured content directly into the `SfRichTextEditor`.
- Tap **Format text**.
- The app sends the content to Azure OpenAI through the `MainPageViewModel`.
- The generated HTML replaces the editor content through the `HtmlText` binding.
- You can continue editing the output using the editor toolbar.

If the API key is missing, the sample automatically falls back to a demo document so the UI remains usable during testing or development.

## Output and behavior

When the user enters unstructured notes and taps **Format text**, the sample sends the data to Azure OpenAI. The AI model identifies the document structure and returns a JSON payload that includes:

- The final document title.
- Logical sections with meaningful headings.
- Concise paragraphs for prose, commands, code, configuration, and table data.
- Unordered facts, features, and highlights grouped in `bulletItems`.
- Ordered steps in `numberedItems` when sequence matters.
- Follow-up tasks and responsibilities in `actionItems`.

The generated HTML is then bound to the `SfRichTextEditor`, enabling the user to review and edit the final result in a rich text environment. If the request fails, the ViewModel captures the exception message in `ErrorMessage` instead of interrupting the editing experience.

![AI powered Smart .NET MAUI RTE](images/AI-Powered-RTE-formatter.gif)

You can find the complete sample from this [link](https://github.com/syncfusion/maui-ai-usecase-demos/tree/master).

## See also

- [Getting Started](https://help.syncfusion.com/maui/rich-text-editor/getting-started) explains how to configure the Rich Text Editor control in a .NET MAUI application.
- [Overview](https://help.syncfusion.com/maui/rich-text-editor/overview) provides the core capabilities and features of the Rich Text Editor.
- [Smart Text Editor](https://help.syncfusion.com/maui/smarttexteditor/overview) helps when you need AI-assisted editing and predictive text entry in .NET MAUI apps.
- [Smart AI Solutions](https://help.syncfusion.com/maui/SmartAISolutions/Overview) showcases related AI-powered sample implementations across Syncfusion .NET MAUI controls.

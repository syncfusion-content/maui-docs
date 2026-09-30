---
layout: post
title: AI-Powered Dynamic Form Generation in .NET MAUI DataForm | Syncfusion®
description: Learn how to transform free-text input into a dynamic and editable Syncfusion .NET MAUI DataForm using Azure OpenAI.
platform: maui
control: SfDataForm
documentation: ug
---

# AI-Powered Dynamic Form Generation in .NET MAUI DataForm

This guide demonstrates how to use Azure OpenAI with the Syncfusion® .NET MAUI DataForm (https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html) to transform free-text input into a dynamic and editable form.

The user enters unstructured content, and Azure OpenAI analyzes the content to identify meaningful field names, values, and field types. Based on the AI response, corresponding DataForm editors are created dynamically.

## Integrating Azure OpenAI with .NET MAUI DataForm

Before proceeding, configure an Azure OpenAI resource with a valid endpoint, API key, and deployment name.

The sample uses `AzureOpenAIClient` to communicate with Azure OpenAI and retrieve a structured JSON response containing the fields required to generate the DataForm dynamically.

### Step 1: Define the AI response model

Create models to represent each generated field and the complete AI response.

{% tabs %}
{% highlight c# %}

public class AIField
{
    public string FieldName { get; set; } = string.Empty;

    public string Value { get; set; } = string.Empty;

    public string FieldType { get; set; } = "Text";
}

public class AIFormResponse
{
    public List<AIField> Fields { get; set; } = new();
}

{% endhighlight %}
{% endtabs %}

## Step 2: Configure Azure OpenAI

Create an options class to store and validate the Azure OpenAI configuration.

{% tabs %}
{% highlight c# %}

public class AzureOpenAiOptions
{
    public const string Endpoint =
        "https://YOUR-RESOURCE.openai.azure.com/";

    public const string DeploymentName =
        "YOUR-DEPLOYMENT-NAME";

    public const string Key =
        "YOUR-AZURE-OPENAI-KEY";

    public string EndpointValue { get; }

    public string DeploymentNameValue { get; }

    public string KeyValue { get; }

    public AzureOpenAiOptions()
    {
        EndpointValue =
            (Environment.GetEnvironmentVariable(
                "AZURE_OPENAI_ENDPOINT") ?? Endpoint).Trim();

        DeploymentNameValue =
            (Environment.GetEnvironmentVariable(
                "AZURE_OPENAI_DEPLOYMENT") ?? DeploymentName).Trim();

        KeyValue =
            (Environment.GetEnvironmentVariable(
                "AZURE_OPENAI_KEY") ?? Key).Trim();
    }

    public string? ValidateCredentials()
    {
        if (string.IsNullOrWhiteSpace(EndpointValue) ||
            string.IsNullOrWhiteSpace(DeploymentNameValue) ||
            string.IsNullOrWhiteSpace(KeyValue))
        {
            return "Invalid Azure OpenAI configuration.";
        }

        return null;
    }
}

{% endhighlight %}
{% endtabs %}

> **NOTE**
> Avoid committing Azure OpenAI credentials to source control. Use a secure configuration mechanism for application credentials.

## Step 3: Create the Azure OpenAI service

Define an interface for generating the form.

{% tabs %}
{% highlight c# %}

public interface IAIFormService
{
    Task<AIFormResponse?> GenerateFormAsync(
        string userInput,
        CancellationToken cancellationToken = default);
}

{% endhighlight %}
{% endtabs %}

Create the Azure OpenAI implementation.

{% tabs %}
{% highlight c# %}

using Azure;
using Azure.AI.OpenAI;
using OpenAI.Chat;
using System.ClientModel;
using System.Text.Json;

public class AzureFormAIService : IAIFormService
{
    private readonly AzureOpenAiOptions options;

    private ChatClient? chatClient;

    private static readonly JsonSerializerOptions SerializerOptions =
        new()
        {
            PropertyNameCaseInsensitive = true
        };

    public AzureFormAIService()
    {
        options = new AzureOpenAiOptions();
    }

    public async Task<AIFormResponse?> GenerateFormAsync(
        string userInput,
        CancellationToken cancellationToken = default)
    {
        if (string.IsNullOrWhiteSpace(userInput))
        {
            return null;
        }

        string? validationError =
            options.ValidateCredentials();

        if (!string.IsNullOrWhiteSpace(validationError))
        {
            throw new InvalidOperationException(
                validationError);
        }

        EnsureChatClient();

        string systemPrompt =
            """
            You are a strict Dynamic Form Generation Engine.

            Analyze the user's free-text content and convert
            it into a structured form definition.

            Return ONLY valid JSON.

            Allowed FieldType values:

            Text
            Number
            Email
            Phone

            Extract a value only when the user actually
            provides one.

            Never use the field name itself as the value.

            If the user specifies a field without a value,
            return an empty string for Value.

            Do not invent or infer missing information.

            Example input:

            name karthi age 34 school

            Correct output:

            {
                "Fields": [
                    {
                        "FieldName": "Name",
                        "Value": "karthi",
                        "FieldType": "Text"
                    },
                    {
                        "FieldName": "Age",
                        "Value": "34",
                        "FieldType": "Number"
                    },
                    {
                        "FieldName": "School",
                        "Value": "",
                        "FieldType": "Text"
                    }
                ]
            }

            Return JSON only.
            """;

        string userPrompt =
            $$"""
            Analyze the following content and generate the form.

            If a field is mentioned without a value,
            keep its Value empty.

            User Content:

            {{userInput}}
            """;

        List<ChatMessage> messages =
        [
            new SystemChatMessage(systemPrompt),
            new UserChatMessage(userPrompt)
        ];

        ChatCompletionOptions chatOptions =
            new()
            {
                ResponseFormat =
                    ChatResponseFormat.CreateJsonObjectFormat()
            };

        ClientResult<ChatCompletion> result =
            await chatClient!.CompleteChatAsync(
                messages,
                chatOptions,
                cancellationToken);

        string rawJson =
            string.Concat(
                result.Value.Content.Select(
                    part => part.Text ?? string.Empty));

        if (string.IsNullOrWhiteSpace(rawJson))
        {
            return null;
        }

        AIFormResponse? response =
            JsonSerializer.Deserialize<AIFormResponse>(
                rawJson,
                SerializerOptions);

        if (response?.Fields == null ||
            response.Fields.Count == 0)
        {
            return null;
        }

        foreach (AIField field in response.Fields)
        {
            NormalizeField(field);
        }

        return response;
    }

    private void EnsureChatClient()
    {
        if (chatClient != null)
        {
            return;
        }

        AzureOpenAIClient client =
            new(
                new Uri(options.EndpointValue),
                new AzureKeyCredential(options.KeyValue));

        chatClient =
            client.GetChatClient(
                options.DeploymentNameValue);
    }

    private static void NormalizeField(
        AIField field)
    {
        field.FieldName =
            field.FieldName?.Trim() ?? string.Empty;

        field.Value =
            field.Value?.Trim() ?? string.Empty;

        field.FieldType =
            field.FieldType?.Trim() ?? "Text";

        // Prevent a field name from being used as its value
        // when the user supplies only the field name.
        if (string.Equals(
            field.FieldName,
            field.Value,
            StringComparison.OrdinalIgnoreCase))
        {
            field.Value = string.Empty;
        }
    }
}

{% endhighlight %}
{% endtabs %}

The prompt instructs Azure OpenAI to extract only values explicitly provided by the user. For example, if the user enters `school` without specifying a school name, the `School` field is generated with an empty value.

## Step 4: Generate the form using the ViewModel

The ViewModel sends the user's content to the Azure OpenAI service and stores the generated fields.

{% tabs %}
{% highlight c# %}

public partial class FormViewModel : ObservableObject
{
    private readonly IAIFormService aiFormService;

    private CancellationTokenSource? cancellationTokenSource;

    public FormViewModel()
    {
        aiFormService =
            new AzureFormAIService();

        GeneratedFields =
            new ObservableCollection<AIField>();
    }

    [ObservableProperty]
    private string userInput = string.Empty;

    [ObservableProperty]
    private bool isBusy;

    [ObservableProperty]
    private bool showForm;

    public ObservableCollection<AIField>
        GeneratedFields { get; }

    private int formGenerationVersion;

    public int FormGenerationVersion
    {
        get => formGenerationVersion;

        private set =>
            SetProperty(
                ref formGenerationVersion,
                value);
    }

    [RelayCommand]
    public async Task GenerateFormAsync()
    {
        if (string.IsNullOrWhiteSpace(UserInput))
        {
            return;
        }

        IsBusy = true;
        ShowForm = false;

        try
        {
            cancellationTokenSource?.Cancel();

            cancellationTokenSource =
                new CancellationTokenSource();

            AIFormResponse? response =
                await aiFormService.GenerateFormAsync(
                    UserInput,
                    cancellationTokenSource.Token);

            if (response == null ||
                response.Fields.Count == 0)
            {
                return;
            }

            GeneratedFields.Clear();

            foreach (AIField field in response.Fields)
            {
                GeneratedFields.Add(field);
            }

            ShowForm = true;

            FormGenerationVersion++;
        }
        finally
        {
            IsBusy = false;
        }
    }
}

{% endhighlight %}
{% endtabs %}

`FormGenerationVersion` notifies the View when a new AI-generated field collection is available so that the DataForm items can be rebuilt.

## Step 5: Create DataForm items dynamically

The Azure OpenAI response determines which type of DataForm editor should be created.

{% tabs %}
{% highlight c# %}

private static DataFormItem CreateDataFormItem(
    AIField field,
    string fieldName)
{
    switch (field.FieldType?.ToLowerInvariant())
    {
        case "number":

            return new DataFormNumericItem
            {
                FieldName = fieldName,
                LabelText = field.FieldName,
                PlaceholderText =
                    $"Enter {field.FieldName}"
            };

        case "phone":

            return new DataFormMaskedTextItem
            {
                FieldName = fieldName,
                LabelText = field.FieldName,
                PlaceholderText =
                    $"Enter {field.FieldName}"
            };

        case "email":

            return new DataFormTextItem
            {
                FieldName = fieldName,
                LabelText = field.FieldName,
                PlaceholderText =
                    $"Enter {field.FieldName}"
            };

        case "text":

        default:

            return new DataFormTextItem
            {
                FieldName = fieldName,
                LabelText = field.FieldName,
                PlaceholderText =
                    $"Enter {field.FieldName}"
            };
    }
}

{% endhighlight %}
{% endtabs %}

This approach enables the Syncfusion® .NET MAUI DataForm to adapt dynamically to unstructured user content while keeping the generated fields fully editable.

The AI identifies the structure and extracts only the information supplied by the user. Fields without values remain empty, allowing the user to complete the missing information directly in the generated DataForm.

![AI-Powered Dynamic Form Generation in .NET MAUI DataForm](images/smart-ai-samples/c:\Users\SudarsanMuthuselvan\Downloads\AI-Powered-Smart-Form-Generation-DataForm.gif)

You can download the complete sample from this [link]().
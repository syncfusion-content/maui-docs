---
layout: post
title: AI-Powered Dynamic Form Generation in .NET MAUI DataForm | Syncfusion®
description: Learn how to transform free-text input into a dynamic and editable Syncfusion .NET MAUI DataForm using Azure OpenAI.
platform: maui
control: SfDataForm
documentation: ug
---

# AI-Powered Dynamic Form Generation in .NET MAUI DataForm

This guide explains how to implement AI-powered dynamic form generation in a .NET MAUI application using Syncfusion® DataForm (`SfDataForm`) and Azure OpenAI. Users can provide free-form content such as employee details, student records, registration information, or survey data. Azure OpenAI analyzes the content, identifies meaningful fields, extracts values, determines appropriate editor types, and automatically generates a fully editable DataForm.

## Integrating AI-Powered Dynamic Form Generation in .NET MAUI DataForm

Before proceeding, ensure that Azure OpenAI is configured and integrated with your .NET MAUI application. Refer to the **Azure OpenAI integration prerequisites** and complete the required setup steps.

## Step 1: Design the User Interface

Use an `Editor` control to collect free-form user content and an `SfButton` to trigger form generation.

{% tabs %}
{% highlight xaml %}

<core:SfTextInputLayout ContainerType="Filled"
                        ShowHint="False"
                        HeightRequest="180"
                        ContainerBackground="#F5F6FF"
                        OutlineCornerRadius="8">

    <Editor Text="{Binding UserInput}"
            HeightRequest="160"
            Placeholder="Paste or type your content here..."
            FontSize="13" />

</core:SfTextInputLayout>

<buttons:SfButton Text="Generate Form"
                  Command="{Binding GenerateFormCommand}"
                  WidthRequest="200"
                  Background="#0878D1"
                  TextColor="White"
                  FontAttributes="Bold"
                  HeightRequest="48"
                  CornerRadius="9" />

{% endhighlight %}
{% endtabs %}

The `SfBusyIndicator` provides visual feedback while Azure OpenAI analyzes the content and generates the form definition.

{% tabs %}
{% highlight xaml %}

<core:SfBusyIndicator IsRunning="{Binding IsBusy}"
                      HeightRequest="100"
                      WidthRequest="100"
                      AnimationType="CircularMaterial"
                      HorizontalOptions="Center"
                      VerticalOptions="Start" />

{% endhighlight %}
{% endtabs %}

The generated form fields are displayed using `SfDataForm`.

{% tabs %}
{% highlight xaml %}

<dataForm:SfDataForm x:Name="GeneratedDataForm"
                     AutoGenerateItems="False"
                     WidthRequest="360"
                     HorizontalOptions="Fill">

    <dataForm:SfDataForm.DefaultLayoutSettings>
        <dataForm:DataFormDefaultLayoutSettings
            LabelPosition="{OnIdiom Default='Left', Phone='Top'}" />
    </dataForm:SfDataForm.DefaultLayoutSettings>

</dataForm:SfDataForm>

{% endhighlight %}
{% endtabs %}

## Step 2: Generate Form Definitions using Azure OpenAI

When the user clicks the Generate Form button, the entered content is sent to Azure OpenAI. The AI analyzes the text and generates a collection of fields describing the form structure.

{% tabs %}
{% highlight c# %}

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

FormGenerationVersion++;

{% endhighlight %}
{% endtabs %}

The `FormGenerationVersion` property is updated whenever a new AI response is received. This notifies the view that a new form definition is available.

## Step 3: Regenerate the DataForm when AI Results Change

The page listens for changes to `FormGenerationVersion` and rebuilds the DataForm whenever Azure OpenAI generates a new collection of form fields.

{% tabs %}
{% highlight c# %}

private void ViewModel_PropertyChanged(
    object? sender,
    PropertyChangedEventArgs e)
{
    if (e.PropertyName ==
        nameof(FormViewModel.FormGenerationVersion))
    {
        MainThread.BeginInvokeOnMainThread(
            GenerateDataForm);
    }
}

{% endhighlight %}
{% endtabs %}

This ensures the generated form is refreshed automatically whenever a new AI response is received.

## Step 4: Bind Dynamic Values using DataFormItemManager

Since the form structure is generated dynamically, a fixed model class cannot be used. Instead, a custom `DataFormItemManager` stores and retrieves field values from a dictionary.

{% tabs %}
{% highlight c# %}

public class DynamicDataFormItemManager :
    DataFormItemManager
{
    private readonly Dictionary<string, object>
        _formData;

    public DynamicDataFormItemManager(
        Dictionary<string, object> formData)
    {
        _formData = formData;
    }

    public override object GetValue(
        DataFormItem dataFormItem)
    {
        if (_formData.TryGetValue(
            dataFormItem.FieldName,
            out var value))
        {
            return value;
        }

        return string.Empty;
    }

    public override void SetValue(
        DataFormItem dataFormItem,
        object value)
    {
        _formData[dataFormItem.FieldName] =
            value;
    }
}

{% endhighlight %}
{% endtabs %}

The `DynamicDataFormItemManager` allows the DataForm to bind dynamically generated fields without requiring a predefined business object.

## Step 5: Create DataForm Items Dynamically

The AI-generated field type determines which DataForm editor should be created.

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

## Step 6: Generate the Dynamic DataForm

The `GenerateDataForm` method rebuilds the DataForm using the field definitions returned by Azure OpenAI.

{% tabs %}
{% highlight c# %}

private void GenerateDataForm()
{
    GeneratedDataForm.Items.Clear();

    _formData.Clear();

    foreach (var field in
        _viewModel.GeneratedFields)
    {
        string fieldName =
            GetValidPropertyName(
                field.FieldName);

        object value =
            ConvertFieldValue(field);

        _formData[fieldName] =
            value;
    }

    GeneratedDataForm.ItemManager =
        new DynamicDataFormItemManager(
            _formData);

    foreach (var field in
        _viewModel.GeneratedFields)
    {
        string fieldName =
            GetValidPropertyName(
                field.FieldName);

        DataFormItem item =
            CreateDataFormItem(
                field,
                fieldName);

        GeneratedDataForm.Items.Add(item);
    }
}

{% endhighlight %}
{% endtabs %}

The generated fields and values are stored in a dictionary and connected to the DataForm through the custom item manager. The corresponding DataForm editors are then created dynamically and displayed to the user.

## Step 7: Convert AI Values to DataForm Values

The generated field values are converted into the appropriate data types before being assigned to the DataForm.

{% tabs %}
{% highlight c# %}

private static object? ConvertFieldValue(
    AIField field)
{
    string value =
        field.Value ?? string.Empty;

    switch (field.FieldType?.ToLowerInvariant())
    {
        case "number":

            if (double.TryParse(
                value,
                out double number))
            {
                return number;
            }

            return 0d;

        default:

            return value;
    }
}

{% endhighlight %}
{% endtabs %}

This ensures that numeric fields are displayed using numeric editors while text-based fields remain as strings.

With these implementations, the DataForm becomes AI-powered, enabling users to generate dynamic forms directly from natural language content.

Azure OpenAI analyzes the input, extracts meaningful information, identifies field types, and produces a structured form definition. The Syncfusion® DataForm then renders the appropriate editors dynamically, allowing users to review and modify the generated content before saving or submitting the form.

![AI-Powered Dynamic Form Generation in .NET MAUI DataForm](images/smart-ai-samples/AI-Powered-Smart-Form-Generation-DataForm.gif)

You can download the complete sample from this [link]().
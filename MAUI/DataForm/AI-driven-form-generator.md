---
layout: post
title: AI-Driven Form Generation in .NET MAUI DataForm | Syncfusion
description: Learn how to integrate AI-driven form generation with the Syncfusion® .NET MAUI DataForm using Azure OpenAI to dynamically create education-related forms from natural language prompts.
platform: MAUI
control: SfDataForm
documentation: ug
appliesto: UI Component Suite
---

# AI-Driven Form Generation in .NET MAUI DataForm

This document provides a comprehensive guide to implementing AI-driven form generation with the Syncfusion [.NET MAUI DataForm](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html). It demonstrates how to integrate Azure OpenAI services to interpret a natural language description of a form, generate the appropriate field list, and render the result as a fully editable [SfDataForm](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html) that users can review, edit, and submit.

The sample focuses on the education domain. A user types a request such as *"Create a student enrollment form"* or *"Create a course feedback form with rating and comments"*, Azure OpenAI returns a JSON description of the fields, and the application dynamically maps each field to the best matching `DataFormItem` type so that the form is rendered inside `SfDataForm` in real time.

## Integrating AI-Driven Form Generation in .NET MAUI DataForm

Before proceeding, ensure that Azure OpenAI is configured and integrated with your .NET MAUI application. Refer to the [Azure OpenAI integration prerequisites]() and complete the required setup steps.

The `GetResultsFromAI` method sends the user's prompt to the Azure OpenAI service and retrieves the AI-generated response. It processes the request asynchronously, supports cancellation, and includes exception handling to ensure reliable communication with the AI model.

{% tabs %}
{% highlight c# %}

public async Task<string?> GetResultsFromAI(string prompt)
{
    if (IsCredentialValid)
    {
        try
        {
            ChatHistory = string.Empty;

            if (ChatHistory != null)
            {                    
                // Add the user's prompt as a user message to the conversation.
                ChatHistory = ChatHistory + "You are a form generation assistant.";
                // Add the user's prompt as a user message to the conversation.
                ChatHistory = ChatHistory + prompt;
                if (Client != null)
                {
                    //// Send the chat completion request to the OpenAI API and await the response.
                    var response = await Client.CompleteAsync(ChatHistory);
                    return response.ToString();
                }
            }
            return null;

        }
        catch
        {
            return null;
        }
    }
    else
    {
        return null;
    }
}

{% endhighlight %}
{% endtabs %}

After completing the Azure OpenAI setup, use the `.NET MAUI DataForm` control to display the AI-generated education form. The AI service interprets the user's description, decides on the most appropriate field types (such as text, numeric, date, picker, or checkbox), and produces a JSON payload that the application deserializes and maps to `SfDataForm` items. The generated form is then rendered live inside `SfDataForm`, where the user can enter values, apply validation, and submit the data.

Before proceeding, review the [.NET MAUI DataForm overview](https://www.syncfusion.com/maui-controls/maui-dataform).

### Step 1: Create the DataForm Layout

Create a layout that lets the user describe the form they want, trigger AI generation, and display the resulting form. The page contains a prompt editor at the top, an action button that sends the prompt to Azure OpenAI, a busy indicator for visual feedback, and an `SfDataForm` that renders the generated fields.

{% tabs %}
{% highlight xaml %}

<Grid RowDefinitions="Auto,Auto,Auto,*">

    <!-- Prompt editor for describing the form -->
    <Editor Grid.Row="0"
            x:Name="PromptEditor"
            AutoSize="TextChanges"
            Placeholder="Describe the education form you want, e.g. Create a student enrollment form"
            Margin="16,16,16,8"/>

    <!-- Send button -->
    <Button Grid.Row="1"
            x:Name="GenerateButton"
            Text="Generate Form"
            Clicked="OnGenerateButtonClicked"
            HorizontalOptions="End"
            Margin="16,0,16,8"/>

    <!-- Busy indicator shown while the AI is generating fields -->
    <core:SfBusyIndicator Grid.Row="2"
                          x:Name="BusyIndicator"
                          IsRunning="False"
                          IsVisible="False"
                          AnimationType="Cupertino"
                          HorizontalOptions="Center"
                          HeightRequest="40"/>

    <!-- Generated form -->
    <dataform:SfDataForm Grid.Row="3"
                         x:Name="EducationForm"
                         AutoGenerateItems="False"
                         ValidationMode="PropertyChanged"
                         LayoutType="TextInputLayout"
                         HorizontalOptions="Fill"
                         VerticalOptions="Fill">
        <dataform:SfDataForm.TextInputLayoutSettings>
            <dataform:TextInputLayoutSettings ShowHelperText="True"/>
        </dataform:SfDataForm.TextInputLayoutSettings>
    </dataform:SfDataForm>

</Grid>

{% endhighlight %}
{% endtabs %}

### Step 2: Generate Form Fields Using AI

When the user taps **Generate Form**, the prompt is sent to Azure OpenAI with explicit instructions on the required JSON schema. The AI responds with a JSON object whose keys are the field names and whose values are the recommended `DataForm` item types (for example, `DataFormTextItem`, `DataFormNumericItem`, `DataFormDateItem`, `DataFormPickerItem`, `DataFormCheckBoxItem`). The JSON is cleaned of any wrapping markdown fences and deserialized before being mapped to `DataFormViewItem` objects.

{% tabs %}
{% highlight c# %}

private async void OnGenerateButtonClicked(object? sender, EventArgs e)
{
    if (string.IsNullOrWhiteSpace(PromptEditor?.Text))
        return;

    try
    {
        BusyIndicator.IsVisible = true;
        BusyIndicator.IsRunning = true;
        GenerateButton.IsEnabled = false;

        string condition =
            "Property names must be in PascalCase. " +
            "Map each property to the most appropriate DataForm item type. " +
            "Allowed item types: DataFormTextItem, DataFormMultiLineTextItem, " +
            "DataFormPasswordItem, DataFormNumericItem, DataFormMaskedTextItem, " +
            "DataFormDateItem, DataFormTimeItem, DataFormCheckBoxItem, " +
            "DataFormSwitchItem, DataFormPickerItem, DataFormComboBoxItem, " +
            "DataFormAutoCompleteItem, DataFormRadioGroupItem, DataFormSegmentItem. " +
            "Return JSON ONLY with property name as key and item type as value. " +
            "Do not include backticks, newlines, or extra spaces.";

        string userPrompt = $"Generate a data form based on the user prompt: {PromptEditor.Text}.";

        var aiResponse = await AzureBaseService.GetResultsFromAI(userPrompt + condition);
        if (string.IsNullOrEmpty(aiResponse))
        {
            await DisplayAlert("Error", "AI did not return a form. Please try again.", "OK");
            return;
        }

        // Strip the markdown fences the model may wrap around the JSON.
        aiResponse = aiResponse.Replace("```json", "").Replace("```", "").Trim();

        ApplyGeneratedForm(aiResponse);
    }
    finally
    {
        BusyIndicator.IsRunning = false;
        BusyIndicator.IsVisible = false;
        GenerateButton.IsEnabled = true;
    }
}

{% endhighlight %}
{% endtabs %}

### Step 3: Populate the Generated Fields in SfDataForm

The deserialized dictionary is iterated, and each entry is converted into a `DataFormItem` using the type name returned by the AI. The resulting collection is assigned to the `SfDataForm.Items` property, which causes `SfDataForm` to render the generated fields live.

{% tabs %}
{% highlight c# %}

private void ApplyGeneratedForm(string aiResponse)
{
    var fieldMap = JsonConvert.DeserializeObject<Dictionary<string, object>>(aiResponse);
    if (fieldMap == null || fieldMap.Count == 0)
        return;

    var items = new ObservableCollection<DataFormItem>();
    foreach (var entry in fieldMap)
    {
        var item = CreateDataFormItem(entry.Value?.ToString(), entry.Key);
        if (item != null)
            items.Add(item);
    }

    if (items.Count > 0)
        EducationForm.Items = items;
}

private DataFormItem? CreateDataFormItem(string? itemType, string propertyName)
{
    if (string.IsNullOrEmpty(itemType))
        return null;

    return itemType switch
    {
        "DataFormTextItem"           => new DataFormTextItem { Name = propertyName },
        "DataFormMultiLineTextItem"  => new DataFormMultiLineTextItem { Name = propertyName },
        "DataFormPasswordItem"       => new DataFormPasswordItem { Name = propertyName },
        "DataFormNumericItem"        => new DataFormNumericItem { Name = propertyName },
        "DataFormMaskedTextItem"     => new DataFormMaskedTextItem { Name = propertyName },
        "DataFormDateItem"           => new DataFormDateItem { Name = propertyName },
        "DataFormTimeItem"           => new DataFormTimeItem { Name = propertyName },
        "DataFormCheckBoxItem"       => new DataFormCheckBoxItem { Name = propertyName },
        "DataFormSwitchItem"         => new DataFormSwitchItem { Name = propertyName },
        "DataFormPickerItem"         => new DataFormPickerItem { Name = propertyName },
        "DataFormComboBoxItem"       => new DataFormComboBoxItem { Name = propertyName },
        "DataFormAutoCompleteItem"   => new DataFormAutoCompleteItem { Name = propertyName },
        "DataFormRadioGroupItem"     => new DataFormRadioGroupItem { Name = propertyName },
        "DataFormSegmentItem"        => new DataFormSegmentItem { Name = propertyName },
        _ => new DataFormTextItem { Name = propertyName }
    };
}

{% endhighlight %}
{% endtabs %}

Because `SfDataForm` is bound to the resulting `DataFormItem` collection, the control automatically:

- Renders the appropriate editor for each generated field (text entry, numeric up/down, date picker, drop-down, checkbox, and so on).
- Applies the `TextInputLayout` style so every field is displayed with a floating label and helper text, matching the modern MAUI design language.
- Activates `PropertyChanged` validation, so user input is validated the moment a value is entered.

### Step 4: Review and Edit Generated Form Data

Once the form is generated, the user can interact with it directly. Each generated field can be edited, the validation indicators appear live, and the entered values are accessible through the underlying `SfDataForm.DataObject`. The user can correct any field that the AI placed in a sub-optimal category by editing the value, or refine the entire form by re-issuing a new prompt to regenerate the fields.

A typical review interaction looks like this:

1. The user reads the AI-generated form, verifies the fields, and fills in the values. Required fields enforce validation through the `PropertyChanged` mode, so missing or invalid values are highlighted immediately.
2. If a field type is not appropriate, the user simply edits the prompt and taps **Generate Form** again. The new JSON from the AI replaces the previous `SfDataForm.Items` collection, and `SfDataForm` re-renders the new fields without restarting the page.
3. When the user is satisfied with the data, the underlying `EducationForm.DataObject` can be read from code-behind for further processing, persistence, or submission to a backend service.

This end-to-end workflow — *prompt → AI → JSON → `DataFormItem` → live `SfDataForm`* — lets developers add AI-assisted data entry to any education-related scenario, from student enrollment and course feedback to admissions and scholarship applications, with no manual form layout work.

![AI driven smart form generation .NET MAUI DataForm](Images\smart-ai-solutions\ai-driven-form-generation.gif)

You can find the complete sample from this [link](https://github.com/syncfusion/maui-ai-usecase-demos/tree/MAUI-Data-Form-Form-Generator).
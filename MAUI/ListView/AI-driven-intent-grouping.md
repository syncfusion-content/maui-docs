---
layout: post
title: AI-Driven Intent Grouping in .NET MAUI ListView | Syncfusion
description: Learn how to integrate AI-driven intent grouping with the Syncfusion® .NET MAUI ListView using Azure OpenAI to classify user input into intent categories and visually group items in SfListView.
platform: MAUI
control: SfListView
documentation: ug
appliesto: UI Component Suite, ListView SDK
---

# AI-Driven Intent Grouping in .NET MAUI ListView

This document provides a comprehensive guide to implementing AI-driven intent grouping with the Syncfusion [.NET MAUI ListView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html). It demonstrates how to integrate Azure OpenAI services to analyze user-supplied text, identify the underlying intent of each entry, and automatically group the items by intent inside `SfListView` in real time.

## Integrating AI-Driven Intent Grouping in .NET MAUI ListView

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
                ChatHistory = ChatHistory + "You are an intent classification assistant.";
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

After completing the Azure OpenAI setup, use the `.NET MAUI ListView` control to display the list of items and visualize the AI-generated intent grouping. The AI service analyzes each text entry supplied by the user, infers the most appropriate intent category (for example, *Billing*, *Technical Support*, *Sales*, *Account*, or *General Inquiry*), and applies the detected intent as the grouping key for the `SfListView`. Items that share the same intent are visually clustered together with a header that represents the intent label, allowing users to quickly review related items.

Before proceeding, review the [.NET MAUI ListView overview](https://www.syncfusion.com/maui-controls/maui-listview).

### Step 1: Create the ListView Layout

Create an `SfListView` with a `GroupHeaderTemplate` and an `ItemTemplate`. The control is bound to the items collection that is updated by the AI intent classification. The `GroupHeaderTemplate` displays the AI-detected intent label, and the `ItemTemplate` renders the user-supplied text for each entry.

{% tabs %}
{% highlight xaml %}

<syncfusion:SfListView x:Name="IntentListView"
                       Grid.Row="1"
                       ItemsSource="{Binding Items}"
                       ItemSize="72"
                       IsStickyGroupHeader="True"
                       AllowGroupExpandCollapse="True"
                       SelectionMode="Single"
                       BackgroundColor="White">

    <syncfusion:SfListView.GroupHeaderTemplate>
        <DataTemplate x:DataType="syncfusion:GroupResult">
            <Grid BackgroundColor="#F1F5F9"
                  Padding="16,8">
                <Label Text="{Binding Key}"
                       FontSize="14"
                       FontAttributes="Bold"
                       TextColor="#0F172A"
                       VerticalTextAlignment="Center"/>
            </Grid>
        </DataTemplate>
    </syncfusion:SfListView.GroupHeaderTemplate>

    <syncfusion:SfListView.ItemTemplate>
        <DataTemplate x:DataType="models:IntentItem">
            <Grid Padding="16,12" ColumnDefinitions="*,Auto">
                <Label Grid.Column="0"
                       Text="{Binding Text}"
                       FontSize="14"
                       TextColor="#0F172A"
                       VerticalTextAlignment="Center"
                       LineBreakMode="WordWrap"/>
                <Border Grid.Column="1"
                        BackgroundColor="{Binding Intent, Converter={StaticResource IntentPillColor}}"
                        StrokeThickness="0"
                        StrokeShape="RoundRectangle 6"
                        Padding="8,3"
                        HorizontalOptions="End"
                        VerticalOptions="Center">
                    <Label Text="{Binding Intent}"
                           TextColor="{Binding Intent, Converter={StaticResource IntentPillTextColor}}"
                           FontSize="12"
                           FontAttributes="Bold"/>
                </Border>
            </Grid>
        </DataTemplate>
    </syncfusion:SfListView.ItemTemplate>

</syncfusion:SfListView>

{% endhighlight %}
{% endtabs %}

### Step 2: Enable AI-Powered Intent Classification

Create a method in the ViewModel that takes the user's text entries, builds a prompt describing the desired JSON schema, and sends the request to Azure OpenAI. The AI model analyzes each text entry, infers the most appropriate intent, and returns a JSON response. The response is deserialized, the intent is written back to each item, and the `SfListView` is grouped by intent using a `GroupDescriptor` with a `KeySelector`.

{% tabs %}
{% highlight c# %}

private async Task ClassifyIntentsAsync()
{
    if (IsBusy)
        return;

    try
    {
        IsBusy = true;
        StatusMessage = "Sending items to Azure OpenAI...";

        string prompt =
            "Classify each of the following text entries into an intent category. " +
            "Allowed intents: Billing, Technical Support, Sales, Account, General Inquiry. " +
            "Return JSON ONLY, no explanation. " +
            "Schema: { \"Items\": [ { \"Id\": number, \"Intent\": \"string\" } ] }. " +
            "Remove ```json and ``` if they are present.";

        var json = SerializeItems(Items);
        string userInput = BuildPrompt(prompt, json);

        var result = await _aiService.GetResultsFromAI(userInput);
        result = result.Replace("```json", "").Replace("```", "").Trim();

        var classified = DeserializeIntents(result);
        if (classified?.Items != null)
        {
            foreach (var entry in classified.Items)
            {
                var match = Items.FirstOrDefault(i => i.Id == entry.Id);
                if (match != null)
                    match.Intent = entry.Intent;
            }
        }

        ApplyIntentGrouping();
        StatusMessage = $"Done. {Items.Count} items classified.";
    }
    catch (Exception ex)
    {
        StatusMessage = "Error: " + ex.Message;
    }
    finally
    {
        IsBusy = false;
    }
}

{% endhighlight %}
{% endtabs %}

### Step 3: Group Items by AI-Detected Intent

After the AI returns the intent for each item, add a `GroupDescriptor` to the `SfListView.DataSource.GroupDescriptors` collection. Use a `KeySelector` that returns the `Intent` property of every item, so `SfListView` automatically rebuilds its groups and renders the appropriate group headers.

{% tabs %}
{% highlight c# %}

private void ApplyIntentGrouping()
{
    IntentListView.DataSource.GroupDescriptors.Clear();

    IntentListView.DataSource.GroupDescriptors.Add(new GroupDescriptor()
    {
        PropertyName = "Intent",
        KeySelector = (object obj) =>
        {
            var item = obj as IntentItem;
            return item?.Intent ?? "Unclassified";
        },
        Comparer = new IntentGroupComparer()
    });
}

{% endhighlight %}
{% endtabs %}

A custom `IComparer<object>` is used to control the order in which the AI-generated intent groups are displayed. This lets you prioritize the most common business-relevant intents first, while still falling back to alphabetical order for any intents the model introduces that are not predefined.

{% tabs %}
{% highlight c# %}

using System.Collections.Generic;

public class IntentGroupComparer : IComparer<object>
{
    private static readonly string[] OrderedIntents =
    {
        "Billing",
        "Technical Support",
        "Sales",
        "Account",
        "General Inquiry"
    };

    public int Compare(object x, object y)
    {
        var left = x?.ToString() ?? string.Empty;
        var right = y?.ToString() ?? string.Empty;

        int leftIndex = System.Array.IndexOf(OrderedIntents, left);
        int rightIndex = System.Array.IndexOf(OrderedIntents, right);

        if (leftIndex >= 0 && rightIndex >= 0)
            return leftIndex.CompareTo(rightIndex);

        if (leftIndex >= 0) return -1;
        if (rightIndex >= 0) return 1;

        return string.Compare(left, right, System.StringComparison.OrdinalIgnoreCase);
    }
}

{% endhighlight %}
{% endtabs %}

### Step 4: Display the Intent-Grouped Results

Once grouping is applied, `SfListView` automatically renders an expandable group header for every distinct intent that the AI model returned. Items that share the same intent are clustered under that header, giving users an at-a-glance view of how their text entries are categorized.

The grouped results can be presented in two complementary ways:

- **Group header** – Each group header is rendered using the `GroupHeaderTemplate` and displays the AI-assigned intent label (for example, *Billing*, *Technical Support*).
- **Item template** – Each item shows the original text together with a colored intent pill that mirrors the header label, reinforcing the connection between the item and its inferred intent.

Because `IsStickyGroupHeader` is enabled, the active group header remains pinned to the top of the view while the user scrolls, so the current intent category is always visible. When the user adds a new entry or edits an existing one, simply call `ClassifyIntentsAsync` again to re-evaluate the affected items and refresh the grouping. The `SfListView` will immediately reflect the new intent labels and re-organize the items into the appropriate group.

![AI driven intent grouping .NET MAUI ListView](Images\smart-ai-solutions\intent-grouping-listview.gif)

You can find the complete sample from this [link](https://github.com/syncfusion/maui-ai-usecase-demos/tree/Grouping-the-items-by-intent-in-SfListView-using-AI).
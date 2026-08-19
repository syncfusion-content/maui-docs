---
layout: post
title: Prompt Composition in .NET MAUI AI AssistView control | Syncfusion®
description: Learn here all about Prompt Composition support in Syncfusion® .NET MAUI AI AssistView (SfAIAssistView) control, its elements, and more.
platform: MAUI
control: SfAIAssistView
documentation: ug
---

# Prompt Composition in .NET MAUI AI AssistView (SfAIAssistView)

`SfAIAssistView` exposes a structured prompt composition pipeline that combines global system instructions, application context, dynamic prompt parts, and the user input into a single deterministic prompt. The control merges these sources in a fixed order, exposes the final composed prompt through the `PromptComposing` event, and uses an internal `PromptComposer` helper to perform the composition.

## Overview

The prompt composition pipeline combines the following inputs into a single prompt string that is sent to the AI:

* **SystemPrompt** - global instructions for the AI service, such as persona, safety rules, and behavior constraints.
* **ContextPrompt** - application or workspace context for the AI service, such as the current document, selected text, or session metadata.
* **PromptParts** - discrete, ordered fragments contributed by application logic, tools, or plugin. Each part exposes an `Order` and an `IsEnabled` flag.
* **User input** - the message typed in the request editor.

The user input is always appended as the last segment. The `PromptComposing` event is raised immediately before the request is sent to the AI service.

## Composition order

When the user submits a request, `SfAIAssistView` merges the available prompt sources in the following deterministic order:

1. `SystemPrompt` - included if it is not null or empty.
2. Selected agent context - included when a selected `AssistAgent` provides context.
3. `ContextPrompt` - included if it is not null or empty.
4. `PromptParts` - only parts with `IsEnabled = true` and non-empty `Content`, sorted by `Order` in ascending order.
5. User input - the message typed in the request editor.

Null or empty segments are skipped gracefully. Disabled parts are excluded entirely.

## SystemPrompt

The [SystemPrompt](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_SystemPrompt) property defines global AI instructions - persona, safety rules, and behavior constraints - that apply to every request. It is the first segment in the composed prompt. The default value is `null`.

{% tabs %}
{% highlight xaml tabtitle="XAML" hl_lines="2" %}

<syncfusion:SfAIAssistView x:Name="sfAIAssistView"
                           SystemPrompt="Provide clear, professional, and outcome-driven guidance based on available information"/>

{% endhighlight %}
{% highlight c# tabtitle="C#" hl_lines="10" %}

using Syncfusion.Maui.AIAssistView;

public partial class MainPage : ContentPage
{
    SfAIAssistView sfAIAssistView;
    public MainPage()
    {
        InitializeComponent();
        this.sfAIAssistView = new SfAIAssistView();
        this.sfAIAssistView.SystemPrompt = "Provide clear, professional, and outcome-driven guidance based on available information";
        this.Content = sfAIAssistView;
    }
}

{% endhighlight %}
{% endtabs %}

## ContextPrompt

The [ContextPrompt](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_ContextPrompt) property carries application-specific context such as the current document, workspace, or session metadata. It appears after `SystemPrompt` and before any prompt parts. The default value is `null`.

{% tabs %}
{% highlight xaml tabtitle="XAML" hl_lines="2" %}

<syncfusion:SfAIAssistView x:Name="sfAIAssistView"
                           ContextPrompt="Leverage conversation context and user goals to deliver personalized and effective responses"/>

{% endhighlight %}
{% highlight c# tabtitle="C#" hl_lines="10" %}

using Syncfusion.Maui.AIAssistView;

public partial class MainPage : ContentPage
{
    SfAIAssistView sfAIAssistView;
    public MainPage()
    {
        InitializeComponent();
        this.sfAIAssistView = new SfAIAssistView();
        this.sfAIAssistView.ContextPrompt = "Leverage conversation context and user goals to deliver personalized and effective responses.";
        this.Content = sfAIAssistView;
    }
}

{% endhighlight %}
{% endtabs %}

## PromptParts collection

The [PromptParts](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_PromptParts) collection holds discrete, dynamically added prompt fragments contributed by application logic, tools, or plugin. The collection is an `IList<AssistPromptPart>` that supports data binding, so parts can be added, removed, or reordered from a view model.

### AssistPromptPart model

Each item in the `PromptParts` collection is an [AssistPromptPart](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.AssistPromptPart.html) instance. The model exposes the following members:

<table>
<tr>
<td>{{'[Content](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.AssistPromptPart.html#Syncfusion_Maui_AIAssistView_AssistPromptPart_Content)'| markdownify }}</td>
<td>Gets or sets the text of the prompt part. Null or empty content is skipped during composition.</td>
</tr>
<tr>
<td>{{'[Order](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.AssistPromptPart.html#Syncfusion_Maui_AIAssistView_AssistPromptPart_Order)'| markdownify }}</td>
<td>Gets or sets the sort order applied within the PromptParts collection. Lower values are placed first; parts with the same order retain their insertion order.</td>
</tr>
<tr>
<td>{{'[IsEnabled](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.AssistPromptPart.html#Syncfusion_Maui_AIAssistView_AssistPromptPart_IsEnabled)'| markdownify }}</td>
<td>Gets or sets a value indicating whether the part is included in the composed prompt. The default value is <code>true</code>.</td>
</tr>
</table>

### Adding a prompt part

Add an [AssistPromptPart](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.AssistPromptPart.html) to the [PromptParts](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_PromptParts) collection to contribute a discrete fragment to the composed prompt.

{% tabs %}
{% highlight c# tabtitle="C#" hl_lines="10" %}

using Syncfusion.Maui.AIAssistView;

public partial class MainPage : ContentPage
{
    SfAIAssistView sfAIAssistView;
    public MainPage()
    {
        InitializeComponent();
        this.sfAIAssistView = new SfAIAssistView();
        this.sfAIAssistView.PromptParts = new System.Collections.Generic.List<AssistPromptPart>
        {
           new AssistPromptPart
           {
                Content = "Available tools: Search, KnowledgeBase, Calendar, Email, Calculator, Weather, Translation.",
                Order = 1,
                IsEnabled = true
           },
           new AssistPromptPart
           {
                Content = "Select the best tool when needed and provide concise, accurate, context-aware responses.",
                Order = 2,
                IsEnabled = false
           },
        };

        this.Content = sfAIAssistView;
    }
}

{% endhighlight %}
{% endtabs %}

## PromptComposing event

The [PromptComposing](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_PromptComposing) event is raised after all prompt sources have been merged and just before the request is sent. It provides a read-only view of the final composed prompt and the enabled parts that contributed to it. The [PromptComposingEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.PromptComposingEventArgs.html) exposes the following members:

 * [ComposedPrompt](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.PromptComposingEventArgs.html#Syncfusion_Maui_AIAssistView_PromptComposingEventArgs_ComposedPrompt) - The fully composed prompt string that will be sent to the AI.
 * [Parts](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.PromptComposingEventArgs.html#Syncfusion_Maui_AIAssistView_PromptComposingEventArgs_Parts) - The enabled prompt parts in composition order.

{% tabs %}
{% highlight xaml tabtitle="XAML" hl_lines="2" %}

<syncfusion:SfAIAssistView x:Name="sfAIAssistView"
                           PromptComposing="OnPromptComposing" />

{% endhighlight %}
{% highlight c# tabtitle="C#" hl_lines="9" %}

using Syncfusion.Maui.AIAssistView;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        SfAIAssistView sfAIAssistView = new SfAIAssistView();
        sfAIAssistView.PromptComposing += OnPromptComposing;
        this.Content = sfAIAssistView;
    }

    private void OnPromptComposing(object sender, PromptComposingEventArgs e)
    {
        // Use the PromptComposing event to access the merged SystemPrompt, ContextPrompt, agent context, and enabled PromptParts through e.ComposedPrompt and e.Parts.
    }
}

{% endhighlight %}
{% endtabs %}

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

* **SystemPrompt** - global AI instructions such as persona, safety rules, and behavior constraints.
* **ContextPrompt** - application or workspace context such as the current document, selected text, or session metadata.
* **PromptParts** - discrete, ordered fragments contributed by application logic, tools, or plugin. Each part exposes an `Order` and an `IsEnabled` flag.
* **User input** - the message typed in the request editor.

The user input is always appended as the last segment. Non-empty segments are joined with a newline (`Environment.NewLine`) delimiter, and the `PromptComposing` event is raised immediately before the request is sent.

## Composition order

When the user submits a request, `SfAIAssistView` merges the available prompt sources in the following deterministic order:

1. `SystemPrompt` - included if it is not null or empty.
2. Selected agent context - included when an `AssistAgent` is selected and exposes context.
3. `ContextPrompt` - included if it is not null or empty.
4. `PromptParts` - only parts with `IsEnabled = true` and non-empty `Content`, sorted by `Order` in ascending order.
5. User input - the message typed in the request editor.

Null or empty segments are skipped gracefully. Disabled parts are excluded entirely.

N>
* If `SystemPrompt`, `ContextPrompt`, and `PromptParts` are all unset, the composed prompt is identical to the legacy behavior - the user's message is sent on its own.
* Changes to `SystemPrompt`, `ContextPrompt`, or `PromptParts` only affect subsequent requests. The control does not retroactively modify the conversation history.

## SystemPrompt

The [SystemPrompt](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_SystemPrompt) property defines global AI instructions - persona, safety rules, and behavior constraints - that apply to every request. It is the first segment in the composed prompt. The default value is `null`.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}

<syncfusion:SfAIAssistView x:Name="sfAIAssistView"
                           SystemPrompt="You are a helpful, concise assistant. Always respond in Markdown."/>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="6" %}

SfAIAssistView sfAIAssistView;
public MainPage()
{
    InitializeComponent();
    this.sfAIAssistView = new SfAIAssistView();
    this.sfAIAssistView.SystemPrompt = "You are a helpful, concise assistant. Always respond in Markdown.";
    this.Content = sfAIAssistView;
}

{% endhighlight %}
{% endtabs %}

## ContextPrompt

The [ContextPrompt](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_ContextPrompt) property carries application-specific context such as the current document, workspace, or session metadata. It appears after `SystemPrompt` and before any prompt parts. The default value is `null`.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}

<syncfusion:SfAIAssistView x:Name="sfAIAssistView"
                           ContextPrompt="Document: Sales Report Q1 2026. Selected cell: B7."/>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="6" %}

SfAIAssistView sfAIAssistView;
public MainPage()
{
    InitializeComponent();
    this.sfAIAssistView = new SfAIAssistView();
    this.sfAIAssistView.ContextPrompt = "Document: Sales Report Q1 2026. Selected cell: B7.";
    this.Content = sfAIAssistView;
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
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="7" %}

SfAIAssistView sfAIAssistView;
public MainPage()
{
    InitializeComponent();
    this.sfAIAssistView = new SfAIAssistView();
    this.sfAIAssistView.PromptParts = new System.Collections.Generic.List<AssistPromptPart>
    {
        new AssistPromptPart
        {
            Content = "Available tools: Calculator, Search, Translate.",
            Order = 10,
            IsEnabled = true
        }
    };
    this.Content = sfAIAssistView;
}

{% endhighlight %}
{% endtabs %}

### Ordering of parts

Parts are sorted by the `Order` property in ascending order before they are joined into the prompt. Lower values are placed first; parts with the same `Order` value retain their insertion order. `Order` only controls the relative position of parts within the `PromptParts` block - it does not move a part before `SystemPrompt` or after the user input.

{% tabs %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="9" %}

this.sfAIAssistView.PromptParts = new System.Collections.Generic.List<AssistPromptPart>
{
    new AssistPromptPart { Content = "Tone: friendly and direct.", Order = 5 },
    new AssistPromptPart { Content = "Available tools: Calculator, Search.", Order = 10 },
    new AssistPromptPart { Content = "Output format: bullet list.", Order = 20 }
};

{% endhighlight %}
{% endtabs %}

### Enabling and disabling parts

Set [IsEnabled](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.AssistPromptPart.html#Syncfusion_Maui_AIAssistView_AssistPromptPart_IsEnabled) to `false` to exclude a part from composition without removing it from the collection. The default value is `true`.

{% tabs %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="7" %}

this.sfAIAssistView.PromptPartsthis.sfAIAssistView.PromptParts = new System.Collections.Generic.List<AssistPromptPart>()
{
    new AssistPromptPart
    {
        Content = "Include detailed citations in every response.",
        Order = 50,
        IsEnabled = false
    },
};

{% endhighlight %}
{% endtabs %}

## PromptComposing event

The [PromptComposing](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_PromptComposing) event is raised after all prompt sources have been merged and just before the request is sent. It provides a read-only view of the final composed prompt and the enabled parts that contributed to it. The [PromptComposingEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.PromptComposingEventArgs.html) exposes the following members:

 * [ComposedPrompt](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.PromptComposingEventArgs.html#Syncfusion_Maui_AIAssistView_PromptComposingEventArgs_ComposedPrompt) - The fully composed prompt string that will be sent to the AI.
 * [Parts](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.PromptComposingEventArgs.html#Syncfusion_Maui_AIAssistView_PromptComposingEventArgs_Parts) - The enabled prompt parts in composition order.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}

<syncfusion:SfAIAssistView x:Name="sfAIAssistView"
                           PromptComposing="sfAIAssistView_PromptComposing" />

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="1" %}

sfAIAssistView.PromptComposing += SfAIAssistView_PromptComposing;

private void SfAIAssistView_PromptComposing(object sender, PromptComposingEventArgs e)
{
    
}

{% endhighlight %}
{% endtabs %}

## PromptComposer helper

The composition is performed by the internal `PromptComposer` class, which is a static helper that combines all prompt sources in a deterministic order and returns the composed string along with the enabled parts.

### ComposePrompt method

The `ComposePrompt` method merges `SystemPrompt`, the selected agent context, `ContextPrompt`, the enabled `PromptParts`, and the user input. Null or empty segments are skipped, and parts with `IsEnabled = false` are excluded. All included segments are joined with `Environment.NewLine`.

### Return value

Returns a tuple containing:

* `ComposedPrompt` - the composed prompt string with all segments joined by newlines.
* `EnabledParts` - a read-only list of the enabled `AssistPromptPart` instances in composition order.

N>
* The `PromptComposer` is an internal helper that runs synchronously on the UI thread. It is platform-agnostic - Android, iOS, Windows, and macOS produce the same composed prompt for the same input.
* Prompt composition changes are not applied retroactively to the conversation history. They affect the next request that is sent.
* Developers are responsible for sanitizing any content that is added to `SystemPrompt`, `ContextPrompt`, or `PromptParts` to prevent prompt injection.

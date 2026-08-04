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

The prompt composition pipeline combines the following inputs into a single prompt string that is sent to the AI backend:

* **SystemPrompt** - global AI instructions such as persona, safety rules, and behavior constraints.
* **ContextPrompt** - application or workspace context such as the current document, selected text, or session metadata.
* **PromptParts** - discrete, ordered fragments contributed by application logic, tools, or plugins. Each part exposes an `Order` and an `IsEnabled` flag.
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

The [PromptParts](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_PromptParts) collection holds discrete, dynamically added prompt fragments contributed by application logic, tools, or plugins. The collection is an `IList<AssistPromptPart>` that supports data binding, so parts can be added, removed, or reordered from a view model.

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
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}

<syncfusion:SfAIAssistView x:Name="sfAIAssistView">
    <syncfusion:SfAIAssistView.PromptParts>
        <syncfusion:AssistPromptPart Content="Available tools: Calculator, Search, Translate."
                                     Order="10"
                                     IsEnabled="True"/>
    </syncfusion:SfAIAssistView.PromptParts>
</syncfusion:SfAIAssistView>

{% endhighlight %}
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
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="6" %}

var verbosePart = new AssistPromptPart
{
    Content = "Include detailed citations in every response.",
    Order = 50,
    IsEnabled = false
};
this.sfAIAssistView.PromptParts.Add(verbosePart);

{% endhighlight %}
{% endtabs %}

### Modifying parts at runtime

Because `PromptParts` supports data binding, parts can be added, removed, or replaced at runtime from a view model. The control picks up the change on the next request that is sent.

{% tabs %}
{% highlight c# tabtitle="ViewModel.cs" hl_lines="14" %}

public class PromptViewModel : INotifyPropertyChanged
{
    public ObservableCollection<AssistPromptPart> PromptParts { get; }
        = new ObservableCollection<AssistPromptPart>();

    public PromptViewModel()
    {
        PromptParts.Add(new AssistPromptPart { Content = "Language: English.", Order = 1 });
        PromptParts.Add(new AssistPromptPart { Content = "Style: formal.", Order = 2 });

        // Toggle inclusion at runtime
        PromptParts[1].IsEnabled = false;
    }
}

{% endhighlight %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="4" %}

<syncfusion:SfAIAssistView x:Name="sfAIAssistView"
                           PromptParts="{Binding PromptParts}"/>

{% endhighlight %}
{% endtabs %}

## PromptComposing event

The [PromptComposing](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_PromptComposing) event is raised after all prompt sources have been merged and just before the request is sent. It provides a read-only view of the final composed prompt and the enabled parts that contributed to it. The [PromptComposingEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.PromptComposingEventArgs.html) exposes the following members:

 * [ComposedPrompt](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.PromptComposingEventArgs.html#Syncfusion_Maui_AIAssistView_PromptComposingEventArgs_ComposedPrompt) - The fully composed prompt string that will be sent to the AI backend.
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
    System.Diagnostics.Debug.WriteLine($"Composed prompt length: {e.ComposedPrompt.Length}");
    System.Diagnostics.Debug.WriteLine($"Enabled parts: {e.Parts.Count}");
}

{% endhighlight %}
{% endtabs %}

## PromptComposer helper

The composition is performed by the internal `PromptComposer` class, which is a static helper that combines all prompt sources in a deterministic order and returns the composed string along with the enabled parts.

### ComposePrompt method

The `ComposePrompt` method merges `SystemPrompt`, the selected agent context, `ContextPrompt`, the enabled `PromptParts`, and the user input. Null or empty segments are skipped, and parts with `IsEnabled = false` are excluded. All included segments are joined with `Environment.NewLine`.

{% tabs %}
{% highlight c# tabtitle="PromptComposer.cs" %}

internal static class PromptComposer
{
    public static (string ComposedPrompt, IList<AssistPromptPart> EnabledParts) ComposePrompt(
        string systemPrompt,
        string contextPrompt,
        IList<AssistPromptPart> promptParts,
        string userPrompt,
        AssistAgent? assistAgent = null)
    {
        int estimatedCapacity = 4 + (promptParts?.Count ?? 0);
        List<string> segments = new List<string>(estimatedCapacity);
        List<AssistPromptPart> enabledParts = new List<AssistPromptPart>(promptParts?.Count ?? 0);

        // 1. Add system prompt (if not null/empty)
        if (!string.IsNullOrEmpty(systemPrompt))
        {
            segments.Add(systemPrompt);
        }

        // 2. Add agent context (if agent and its instructions are set)
        if (assistAgent != null)
        {
            string? agentContext = assistAgent.GetAgentContext();
            if (!string.IsNullOrEmpty(agentContext))
            {
                segments.Add(agentContext);
            }
        }

        // 3. Add context prompt (if not null/empty)
        if (!string.IsNullOrEmpty(contextPrompt))
        {
            segments.Add(contextPrompt);
        }

        // 4. Add enabled prompt parts sorted by Order (single filtering pass)
        if (promptParts != null && promptParts.Count > 0)
        {
            enabledParts = promptParts
                .Where(p => p.IsEnabled && !string.IsNullOrEmpty(p.Content))
                .OrderBy(p => p.Order)
                .ToList();

            foreach (var part in enabledParts)
            {
                segments.Add(part.Content);
            }
        }

        // 5. Add user prompt (if not null/empty)
        if (!string.IsNullOrEmpty(userPrompt))
        {
            segments.Add(userPrompt);
        }

        // Join with newline delimiter and return both composed prompt and enabled parts
        string composedPrompt = string.Join(Environment.NewLine, segments);
        return (composedPrompt, enabledParts.AsReadOnly());
    }
}

{% endhighlight %}
{% endtabs %}

### Parameters

The `ComposePrompt` method accepts the following parameters:

<table>
<tr>
<td>systemPrompt</td>
<td>The global system instructions. Can be null or empty.</td>
</tr>
<tr>
<td>contextPrompt</td>
<td>The application context. Can be null or empty.</td>
</tr>
<tr>
<td>promptParts</td>
<td>The collection of dynamic prompt parts. Cannot be null, but can be empty.</td>
</tr>
<tr>
<td>userPrompt</td>
<td>The user's input message. Can be null or empty.</td>
</tr>
<tr>
<td>assistAgent</td>
<td>The selected agent information. Can be null.</td>
</tr>
</table>

### Return value

Returns a tuple containing:

* `ComposedPrompt` - the composed prompt string with all segments joined by newlines.
* `EnabledParts` - a read-only list of the enabled `AssistPromptPart` instances in composition order.

N>
* The `PromptComposer` is an internal helper that runs synchronously on the UI thread. It is platform-agnostic - Android, iOS, Windows, and macOS produce the same composed prompt for the same input.
* Prompt composition changes are not applied retroactively to the conversation history. They affect the next request that is sent.
* Developers are responsible for sanitizing any content that is added to `SystemPrompt`, `ContextPrompt`, or `PromptParts` to prevent prompt injection.

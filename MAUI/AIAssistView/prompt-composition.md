---
layout: post
title: Prompt Composition in .NET MAUI AI AssistView control | Syncfusion®
description: Learn about prompt composition support in Syncfusion® .NET MAUI AI AssistView (SfAIAssistView) control, its composition order, prompt parts, and more.
platform: MAUI
control: SfAIAssistView
documentation: ug
---

# Prompt Composition in .NET MAUI AI AssistView (SfAIAssistView)

The `SfAIAssistView` control supports prompt composition by combining system instructions, application context, prompt parts, and user input into a single prompt before sending it to the AI service.

## Composition order

When a request is submitted, `SfAIAssistView` combines the available prompt sources in the following order:

- `SystemPrompt` - Included when the value is not null or empty.
- Selected agent context - Includes the context from the selected `AssistAgent`, when available.
- `ContextPrompt` - Included when the value is not null or empty.
- `PromptParts` - Includes parts with non-empty `Content` and `IsEnabled` set to `true`, sorted by `Order` in ascending order.
- User input - Includes the message entered in the request editor as the final segment.

Null or empty segments are skipped, and disabled prompt parts are excluded from the composed prompt.

## SystemPrompt

The [SystemPrompt](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_SystemPrompt) property defines global instructions, such as persona, safety rules, and behavior constraints, that apply to every request. It is included as the first segment of the composed prompt. The default value is `null`.

{% tabs %}
{% highlight xaml hl_lines="2" %}

<syncfusion:SfAIAssistView x:Name="sfAIAssistView"
                           SystemPrompt="Provide clear, professional, and outcome-driven guidance based on available information"/>

{% endhighlight %}
{% highlight c# hl_lines="10" %}

using Syncfusion.Maui.AIAssistView;

public partial class MainPage : ContentPage
{
    SfAIAssistView sfAIAssistView;
    public MainPage()
    {
        InitializeComponent();
        this.sfAIAssistView = new SfAIAssistView();
        this.sfAIAssistView.SystemPrompt = "Provide clear, professional, and outcome-driven guidance based on available information";
        this.Content = this.sfAIAssistView;
    }
}

{% endhighlight %}
{% endtabs %}

## ContextPrompt

The [ContextPrompt](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_ContextPrompt) property provides application-specific context, such as the current document, workspace, or session metadata. It is included after `SystemPrompt` and before `PromptParts`. The default value is `null`.

{% tabs %}
{% highlight xaml hl_lines="2" %}

<syncfusion:SfAIAssistView x:Name="sfAIAssistView"
                           ContextPrompt="Leverage conversation context and user goals to deliver personalized and effective responses."/>

{% endhighlight %}
{% highlight c# hl_lines="10" %}

using Syncfusion.Maui.AIAssistView;

public partial class MainPage : ContentPage
{
    SfAIAssistView sfAIAssistView;
    public MainPage()
    {
        InitializeComponent();
        this.sfAIAssistView = new SfAIAssistView();
        this.sfAIAssistView.ContextPrompt = "Leverage conversation context and user goals to deliver personalized and effective responses.";
        this.Content = this.sfAIAssistView;
    }
}

{% endhighlight %}
{% endtabs %}

## PromptParts collection

The [PromptParts](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_PromptParts) collection contains discrete prompt fragments contributed by application logic, tools, or plugins. The `PromptParts` property accepts an `IList<AssistPromptPart>` and can be bound to a collection in the view model.

### AssistPromptPart model

Each item in the `PromptParts` collection is an [AssistPromptPart](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.AssistPromptPart.html) instance. It contains the following properties:

- [Content](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.AssistPromptPart.html#Syncfusion_Maui_AIAssistView_AssistPromptPart_Content) - Specifies the content of the prompt part.
- [Order](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.AssistPromptPart.html#Syncfusion_Maui_AIAssistView_AssistPromptPart_Order)` - Specifies the order in which the prompt part is included in the composed prompt.
- [IsEnabled](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.AssistPromptPart.html#Syncfusion_Maui_AIAssistView_AssistPromptPart_IsEnabled) - Specifies whether the prompt part is included in the composed prompt.

### Add prompt parts

Add [AssistPromptPart](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.AssistPromptPart.html) instances to the [PromptParts](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_PromptParts) collection to include application-specific prompt fragments in the composed prompt.

{% tabs %}
{% highlight c# hl_lines="10" %}

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

Only prompt parts with non-empty `Content` and `IsEnabled` set to `true` are included in the composed prompt. The enabled parts are arranged according to their `Order` value in ascending order.

## PromptComposing event

The [PromptComposing](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_PromptComposing) event is raised after the prompt sources are combined and before the AI request is processed. It provides a read-only view of the final composed prompt and the enabled parts that contributed to it. The [PromptComposingEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.PromptComposingEventArgs.html) exposes the following properties:

 * [ComposedPrompt](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.PromptComposingEventArgs.html#Syncfusion_Maui_AIAssistView_PromptComposingEventArgs_ComposedPrompt) - Provides the final composed prompt generated for the AI request.
 * [Parts](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.PromptComposingEventArgs.html#Syncfusion_Maui_AIAssistView_PromptComposingEventArgs_Parts) - Provides the enabled prompt parts in composition order.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}

<syncfusion:SfAIAssistView x:Name="sfAIAssistView"
                           PromptComposing="OnPromptComposing" />

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="15 16" %}

using Syncfusion.Maui.AIAssistView;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void OnPromptComposing(object sender, PromptComposingEventArgs e)
    {
        // Use the PromptComposing event to access the merged SystemPrompt, ContextPrompt, agent context, and enabled PromptParts through e.ComposedPrompt and e.Parts.
        string composedPrompt = e.ComposedPrompt;
        var promptParts = e.Parts;
    }
}

{% endhighlight %}
{% endtabs %}
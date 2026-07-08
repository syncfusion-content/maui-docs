---
layout: post
title: Highlighting matched text in .NET MAUI ComboBox | Syncfusion®
description: Learn about highlighting matched text in the Syncfusion® .NET MAUI ComboBox (SfComboBox) control.
platform: maui
control: SfComboBox
documentation: ug
keywords: .net maui combobox, .net maui sfcombobox, syncfusion combobox, combobox maui, .net maui dropdown list, .net maui select menu.
---

# Highlighting matched text in .NET MAUI ComboBox

The [SfComboBox](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfComboBox.html) control can highlight the characters that match the text typed into the editor, making items in the drop-down easier to identify. Highlighting is enabled through the `TextHighlightMode` property and is applied only when `IsEditable` and `IsFilteringEnabled` are `true`.

## Prerequisites

Before proceeding, ensure the following are set up:

1. Install [.NET 9 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/9.0) or later and the .NET MAUI workload. For setup details, see [Install .NET MAUI](https://learn.microsoft.com/en-us/dotnet/maui/get-started/installation?view=net-maui-9.0).
2. Create a [.NET MAUI project](Getting-Started.md#step-1-create-a-new-net-maui-project).
3. Install the [Syncfusion.Maui.Inputs](https://www.nuget.org/packages/Syncfusion.Maui.Inputs) NuGet package in your .NET MAUI project.
4. Register the Syncfusion core handler in the `CreateMauiApp` method of `MauiProgram.cs`:

    ```csharp
    using Syncfusion.Maui.Core.Hosting;

    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureSyncfusionCore();
            return builder.Build();
        }
    }
    ```

5. Add the following namespace declaration to your XAML page and `using` directive to your C# files:

    ```xml
    xmlns:editors="clr-namespace:Syncfusion.Maui.Inputs;assembly=Syncfusion.Maui.Inputs"
    ```

    ```csharp
    using Syncfusion.Maui.Inputs;
    ```

For a step-by-step setup, refer to the [Getting Started](Getting-Started.md) documentation.

## Define the model and view model

The samples below use the `SocialMedia` model and `SocialMediaViewModel` defined in [Getting Started](Getting-Started.md#step-4-define-model-and-view-model). Use a `BindingContext` on the page so that `{Binding SocialMedias}` resolves correctly.

## Highlight modes

The [TextHighlightMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfComboBox.html#Syncfusion_Maui_Inputs_SfComboBox_TextHighlightMode) property controls how the matched text is highlighted. The available modes are:

* `FirstOccurrence` - Highlights only the first occurrence of the matched characters in each item.
* `MultipleOccurrence` - Highlights every occurrence of the matched characters in each item. Typically used with [TextSearchMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfComboBox.html#Syncfusion_Maui_Inputs_SfComboBox_TextSearchMode) set to `Contains`, but also works with `StartsWith` (only the leading characters are matched).

The default value of `TextHighlightMode` is `FirstOccurrence`.

## Highlight style

The highlight style can be customized using the following properties:

* `HighlightedTextColor` - Sets the color of the highlighted characters. Type: `Color`. Default: the theme accent color.
* `HighlightedTextFontAttributes` - Sets the font attributes (such as `Bold` or `Italic`) of the highlighted characters. Type: `FontAttributes`. Default: `None`. Multiple attributes can be combined using the `|` operator (for example, `Bold, Italic`).

N> Highlighting is applied only when `IsEditable` is `true` and `IsFilteringEnabled` is `true`. If either is `false`, the matched text is not highlighted even if `TextHighlightMode` is set.

## First occurrence

Highlights only the first occurrence of the matched characters in each item of the drop-down.

{% tabs %}

{% highlight xaml %}

<editors:SfComboBox x:Name="comboBox"
                    ItemsSource="{Binding SocialMedias}"
                    DisplayMemberPath="Name"
                    TextMemberPath="Name"
                    IsEditable="True"
                    IsFilteringEnabled="True"
                    TextHighlightMode="FirstOccurrence"
                    HighlightedTextColor="Red"
                    HighlightedTextFontAttributes="Bold">
    <editors:SfComboBox.BindingContext>
        <local:SocialMediaViewModel />
    </editors:SfComboBox.BindingContext>
</editors:SfComboBox>

{% endhighlight %}

{% highlight c# %}

using Syncfusion.Maui.Inputs;

SocialMediaViewModel socialMediaViewModel = new SocialMediaViewModel();

SfComboBox comboBox = new SfComboBox
{
    ItemsSource = socialMediaViewModel.SocialMedias,
    DisplayMemberPath = "Name",
    TextMemberPath = "Name",
    IsEditable = true,
    IsFilteringEnabled = true,
    TextHighlightMode = OccurrenceMode.FirstOccurrence,
    HighlightedTextColor = Colors.Red,
    HighlightedTextFontAttributes = FontAttributes.Bold,
    BindingContext = socialMediaViewModel,
};

{% endhighlight %}
{% endtabs %}

![First Occurrence highlight in the .NET MAUI ComboBox drop-down](images/HighlightingText/firstoccurence1.png)

## Multiple occurrence

Highlights every occurrence of the matched characters in each item. This mode is most useful when combined with [TextSearchMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfComboBox.html#Syncfusion_Maui_Inputs_SfComboBox_TextSearchMode) set to `Contains`, because the matched substring can appear anywhere in the item.

{% tabs %}

{% highlight xaml %}

<editors:SfComboBox x:Name="comboBox"
                    ItemsSource="{Binding SocialMedias}"
                    DisplayMemberPath="Name"
                    TextMemberPath="Name"
                    IsEditable="True"
                    IsFilteringEnabled="True"
                    TextHighlightMode="MultipleOccurrence"
                    TextSearchMode="Contains"
                    HighlightedTextColor="Red"
                    HighlightedTextFontAttributes="Bold">
    <editors:SfComboBox.BindingContext>
        <local:SocialMediaViewModel />
    </editors:SfComboBox.BindingContext>
</editors:SfComboBox>

{% endhighlight %}

{% highlight c# %}

using Syncfusion.Maui.Inputs;

SocialMediaViewModel socialMediaViewModel = new SocialMediaViewModel();

SfComboBox comboBox = new SfComboBox
{
    ItemsSource = socialMediaViewModel.SocialMedias,
    DisplayMemberPath = "Name",
    TextMemberPath = "Name",
    IsEditable = true,
    IsFilteringEnabled = true,
    TextHighlightMode = OccurrenceMode.MultipleOccurrence,
    TextSearchMode = ComboBoxTextSearchMode.Contains,
    HighlightedTextColor = Colors.Red,
    HighlightedTextFontAttributes = FontAttributes.Bold,
    BindingContext = socialMediaViewModel,
};

{% endhighlight %}
{% endtabs %}

![Multiple Occurrence highlight in the .NET MAUI ComboBox drop-down](images/HighlightingText/multipleoccurence2.png)

## See Also

* [Getting started with .NET MAUI ComboBox](getting-started.md)
* [Searching in .NET MAUI ComboBox](Searching.md)
* [Editing in .NET MAUI ComboBox](Editing.md)
* [Filtering in .NET MAUI ComboBox](Filtering.md)
* [Selection in .NET MAUI ComboBox](Selection.md)
* [SfComboBox API reference](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfComboBox.html)
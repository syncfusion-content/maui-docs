---
layout: post
title: Searching in .NET MAUI ComboBox control | Syncfusion®
description: Learn how to perform the searching operation in the Syncfusion® .NET MAUI ComboBox (SfComboBox) control.
platform: maui
control: SfComboBox
documentation: ug
keywords: .net maui combobox, .net maui sfcombobox, syncfusion combobox, combobox maui, .net maui dropdown list, .net maui select menu, .net maui combobox searching.
---

# Searching in .NET MAUI ComboBox

The [SfComboBox](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfComboBox.html) control provides rich text searching functionality. Use the [TextSearchMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfComboBox.html#Syncfusion_Maui_Inputs_SfComboBox_TextSearchMode) property to control how the drop-down is filtered when the user types into the editor.

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

N> Searching only applies when `IsFilteringEnabled` is `true` and `IsEditable` is `true`. The `TextSearchMode` setting has no effect if filtering is disabled.

## Define the model and view model

The samples below use the `SocialMedia` model and `SocialMediaViewModel` defined in [Getting Started](Getting-Started.md#step-4-define-model-and-view-model). Use a `BindingContext` on the page so that `{Binding SocialMedias}` resolves correctly.

## Search based on member path

The [DisplayMemberPath](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_DisplayMemberPath) and [TextMemberPath](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_TextMemberPath) properties specify which property path is used to display and search items when a custom data type is bound to the [ItemsSource](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_ItemsSource) property.

* `DisplayMemberPath` - Specifies the property path whose value is displayed as text in the drop-down. The default value is `string.Empty`.
* `TextMemberPath` - Specifies the property path whose value is used to perform searching based on user input in the editor. The default value is `string.Empty`. When `TextMemberPath` is `null` or `string.Empty`, searching is performed based on `DisplayMemberPath`.

N> `DisplayMemberPath` and `TextMemberPath` apply only when the bound collection item has two or more properties.

N> When both `DisplayMemberPath` and `TextMemberPath` are `null` or `string.Empty`, searching is performed against the class name (with namespace) of the item.

## Edit mode searching based on TextMemberPath

In edit mode, searching is performed against the [TextMemberPath](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_TextMemberPath) value as the user types into the editor. When `TextMemberPath` is `null` or `string.Empty`, searching falls back to [DisplayMemberPath](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_DisplayMemberPath).

{% tabs %}
{% highlight xaml %}

<editors:SfComboBox x:Name="comboBox"
                    IsEditable="true"
                    IsFilteringEnabled="true"
                    ItemsSource="{Binding SocialMedias}"
                    TextMemberPath="ID"
                    DisplayMemberPath="Name">
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
    IsEditable = true,
    IsFilteringEnabled = true,
    ItemsSource = socialMediaViewModel.SocialMedias,
    TextMemberPath = "ID",
    DisplayMemberPath = "Name",
    BindingContext = socialMediaViewModel,
};

{% endhighlight %}
{% endtabs %}

The following image illustrates the result of the above code:

![.NET MAUI ComboBox search based on TextMemberPath](Images/Searching/SearchTextMemberPath.png)

N> Auto-appending of text is supported only in `Editable` mode and when `TextSearchMode` is `StartsWith`.

## Text search mode

The [TextSearchMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfComboBox.html#Syncfusion_Maui_Inputs_SfComboBox_TextSearchMode) property of the [SfComboBox](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfComboBox.html) controls how the drop-down is filtered when the user types. The default value is `StartsWith`. Matching is case-insensitive and accent-insensitive. For a complete walkthrough of the available modes, see [Filtering in .NET MAUI ComboBox](Filtering.md#filter-mode).

The available modes are:

* `StartsWith` - Filters items whose value starts with the typed text. The first match is auto-appended to the editor (in editable mode).
* `Contains` - Filters items whose value contains the typed text anywhere. The first match is highlighted but not auto-appended.

### Search with beginning text

Set [TextSearchMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfComboBox.html#Syncfusion_Maui_Inputs_SfComboBox_TextSearchMode) to [StartsWith](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.ComboBoxTextSearchMode.html#Syncfusion_Maui_Inputs_ComboBoxTextSearchMode_StartsWith) to filter items whose `DisplayMemberPath` value starts with the typed text. The first match is highlighted in the drop-down.

{% tabs %}
{% highlight xaml %}

<editors:SfComboBox x:Name="comboBox"
                    IsEditable="true"
                    IsFilteringEnabled="true"
                    TextSearchMode="StartsWith"
                    ItemsSource="{Binding SocialMedias}"
                    DisplayMemberPath="Name"
                    TextMemberPath="Name">
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
    IsEditable = true,
    IsFilteringEnabled = true,
    TextSearchMode = ComboBoxTextSearchMode.StartsWith,
    ItemsSource = socialMediaViewModel.SocialMedias,
    TextMemberPath = "Name",
    DisplayMemberPath = "Name",
    BindingContext = socialMediaViewModel,
};

{% endhighlight %}
{% endtabs %}

The following image illustrates the result of the above code:

![.NET MAUI ComboBox TextSearchMode StartsWith](Images/Searching/TextSearchModeStartsWith.gif)

### Search with contains text

Set [TextSearchMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfComboBox.html#Syncfusion_Maui_Inputs_SfComboBox_TextSearchMode) to [Contains](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.ComboBoxTextSearchMode.html#Syncfusion_Maui_Inputs_ComboBoxTextSearchMode_Contains) to filter items whose `DisplayMemberPath` value contains the typed text anywhere. The first match is highlighted in the drop-down but is not auto-appended to the editor.

{% tabs %}
{% highlight xaml %}

<editors:SfComboBox x:Name="comboBox"
                    IsEditable="true"
                    IsFilteringEnabled="true"
                    TextSearchMode="Contains"
                    ItemsSource="{Binding SocialMedias}"
                    TextMemberPath="Name"
                    DisplayMemberPath="Name">
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
    IsEditable = true,
    IsFilteringEnabled = true,
    TextSearchMode = ComboBoxTextSearchMode.Contains,
    ItemsSource = socialMediaViewModel.SocialMedias,
    TextMemberPath = "Name",
    DisplayMemberPath = "Name",
    BindingContext = socialMediaViewModel,
};

{% endhighlight %}
{% endtabs %}

The following image illustrates the result of the above code:

![.NET MAUI ComboBox TextSearchMode Contains](Images/Searching/TextSearchModeContains.gif)

## Minimum prefix characters

By default, the suggestion list is updated on every character entry. Use the [MinimumPrefixCharacters](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_MinimumPrefixCharacters) `int` property to defer the update until the user has typed the specified number of characters. The default value is `1` (filtering starts immediately).

{% tabs %}
{% highlight xaml %}

<editors:SfComboBox x:Name="comboBox"
                    IsFilteringEnabled="True"
                    IsEditable="True"
                    ItemsSource="{Binding SocialMedias}"
                    MinimumPrefixCharacters="3"
                    DisplayMemberPath="Name"
                    TextMemberPath="Name">
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
    IsFilteringEnabled = true,
    IsEditable = true,
    ItemsSource = socialMediaViewModel.SocialMedias,
    MinimumPrefixCharacters = 3,
    TextMemberPath = "Name",
    DisplayMemberPath = "Name",
    BindingContext = socialMediaViewModel,
};

{% endhighlight %}
{% endtabs %}

The following image illustrates the result of the above code:

![.NET MAUI ComboBox MinimumPrefixCharacters](Images/Searching/MinimumPrefixCharacters.png)

## See Also

* [Getting started with .NET MAUI ComboBox](getting-started.md)
* [Highlighting matched text in .NET MAUI ComboBox](Highlighting-matched-text.md)
* [Editing in .NET MAUI ComboBox](Editing.md)
* [Filtering in .NET MAUI ComboBox](Filtering.md)
* [Selection in .NET MAUI ComboBox](Selection.md)
* [SfComboBox API reference](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfComboBox.html)
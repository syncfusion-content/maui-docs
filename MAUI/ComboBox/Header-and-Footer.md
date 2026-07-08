---
layout: post
title: Header and Footer in .NET MAUI ComboBox control | Syncfusion®
description: Learn about Header and Footer support in the Syncfusion® .NET MAUI ComboBox (SfComboBox) control.
platform: maui
control: SfComboBox
documentation: ug
keywords: .net maui combobox, .net maui sfcombobox, syncfusion combobox, combobox maui, .net maui dropdown list, .net maui select menu.
---

# Header and Footer support in .NET MAUI ComboBox

The [SfComboBox](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfComboBox.html) control supports adding custom header and footer views to the drop-down. Use the header to display content such as a title or filter above the items, and the footer to display content such as an action button below the items.

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


## Show or hide the header and footer

To show a header or footer in the [SfComboBox](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfComboBox.html) drop-down, set the [ShowDropdownHeaderView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_ShowDropdownHeaderView) and [ShowDropdownFooterView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_ShowDropdownFooterView) `bool` properties to `true`. Both default to `false`.

N> A `DropdownHeaderView` or `DropdownFooterView` is only rendered when its corresponding `ShowDropDownHeaderView` or `ShowDropDownFooterView` property is `true`.

## Define the model and view model

The samples below use the `SocialMedia` model and `SocialMediaViewModel` defined in [Getting Started](Getting-Started.md#step-4-define-model-and-view-model). Use a `BindingContext` on the page so that `{Binding SocialMedias}` resolves correctly.

## Header content

Use the [DropdownHeaderView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_DropdownHeaderView) property to set the content of the header. It accepts any `View` and is displayed at the top of the drop-down while it is open. Adjust the header height with the [DropdownHeaderViewHeight](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_DropdownHeaderViewHeight) `double` property, which defaults to the view's measured height.

{% tabs %}

{% highlight xaml %}

    <StackLayout VerticalOptions="Start" HorizontalOptions="Start" Padding="30">
        <editors:SfComboBox x:Name="comboBox"
                        IsEditable="true"
                        IsFilteringEnabled="true"
                        ItemsSource="{Binding SocialMedias}"
                        DisplayMemberPath="Name"
                        TextMemberPath="Name"
                        ShowDropdownHeaderView="True"
                        DropdownHeaderViewHeight="50">
            <editors:SfComboBox.BindingContext>
                <local:SocialMediaViewModel />
            </editors:SfComboBox.BindingContext>
            <editors:SfComboBox.DropdownHeaderView>
                <StackLayout BackgroundColor="#f0f0f0">
                    <Label Text="Header View"
                       FontSize="20"
                       HorizontalOptions="Center"
                       VerticalOptions="Center"
                       TextColor="#006bcd" />
                </StackLayout>
            </editors:SfComboBox.DropdownHeaderView>
        </editors:SfComboBox>
    </StackLayout>

{% endhighlight %}

{% highlight c# %}

    using Syncfusion.Maui.Inputs;

    // Run this code in a ContentPage code-behind file.
    SocialMediaViewModel socialMediaViewModel = new SocialMediaViewModel();

    StackLayout layout = new StackLayout
    {
        VerticalOptions = LayoutOptions.Start,
        HorizontalOptions = LayoutOptions.Start,
        Padding = new Thickness(30),
    };

    SfComboBox comboBox = new SfComboBox
    {
        ShowDropdownHeaderView = true,
        ItemsSource = socialMediaViewModel.SocialMedias,
        IsEditable = true,
        IsFilteringEnabled = true,
        DisplayMemberPath = "Name",
        TextMemberPath = "Name",
        DropdownHeaderViewHeight = 50,
        BindingContext = socialMediaViewModel,
    };

    StackLayout customHeaderView = new StackLayout
    {
        BackgroundColor = Color.FromArgb("#f0f0f0"),
    };

    Label headerLabel = new Label
    {
        Text = "Header View",
        FontSize = 20,
        HorizontalOptions = LayoutOptions.Center,
        VerticalOptions = LayoutOptions.Center,
        TextColor = Color.FromArgb("#006bcd"),
    };

    customHeaderView.Children.Add(headerLabel);
    comboBox.DropdownHeaderView = customHeaderView;
    layout.Children.Add(comboBox);
    Content = layout;

{% endhighlight %}

{% endtabs %}

![Header view at the top of the .NET MAUI ComboBox drop-down](Images/HeaderFooter/headertemplate.png)

## Footer content

Use the [DropdownFooterView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_DropdownFooterView) property to set the content of the footer. It accepts any `View` and is displayed at the bottom of the drop-down while it is open. Adjust the footer height with the [DropdownFooterViewHeight](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_DropdownFooterViewHeight) `double` property, which defaults to the view's measured height.

{% tabs %}

{% highlight xaml %}

    <StackLayout VerticalOptions="Start" HorizontalOptions="Start" Padding="30">
        <editors:SfComboBox x:Name="comboBox"
                        IsEditable="true"
                        IsFilteringEnabled="true"
                        ItemsSource="{Binding SocialMedias}"
                        DisplayMemberPath="Name"
                        TextMemberPath="Name"
                        ShowDropdownFooterView="True"
                        DropdownFooterViewHeight="50">
            <editors:SfComboBox.BindingContext>
                <local:SocialMediaViewModel />
            </editors:SfComboBox.BindingContext>
            <editors:SfComboBox.DropdownFooterView>
                <StackLayout BackgroundColor="#f0f0f0">
                    <Label Text="Add New"
                       BackgroundColor="#f0f0f0"
                       TextColor="#006bcd"
                       VerticalOptions="Center"
                       HorizontalTextAlignment="Center"
                       FontSize="20" />
                </StackLayout>
            </editors:SfComboBox.DropdownFooterView>
        </editors:SfComboBox>
    </StackLayout>

{% endhighlight %}

{% highlight c# %}

    using Syncfusion.Maui.Inputs;

    // Run this code in a ContentPage code-behind file.
    SocialMediaViewModel socialMediaViewModel = new SocialMediaViewModel();

    StackLayout layout = new StackLayout
    {
        VerticalOptions = LayoutOptions.Start,
        HorizontalOptions = LayoutOptions.Start,
        Padding = new Thickness(30),
    };

    SfComboBox comboBox = new SfComboBox
    {
        ShowDropdownFooterView = true,
        ItemsSource = socialMediaViewModel.SocialMedias,
        IsEditable = true,
        IsFilteringEnabled = true,
        DisplayMemberPath = "Name",
        TextMemberPath = "Name",
        DropdownFooterViewHeight = 50,
        BindingContext = socialMediaViewModel,
    };

    StackLayout customFooterView = new StackLayout
    {
        BackgroundColor = Color.FromArgb("#f0f0f0"),
    };

    Label footerLabel = new Label
    {
        Text = "Footer View",
        BackgroundColor = Color.FromArgb("#f0f0f0"),
        TextColor = Color.FromArgb("#006bcd"),
        HorizontalOptions = LayoutOptions.Center,
        VerticalOptions = LayoutOptions.Center,
        FontSize = 20,
    };

    customFooterView.Children.Add(footerLabel);
    comboBox.DropdownFooterView = customFooterView;
    layout.Children.Add(comboBox);
    Content = layout;

{% endhighlight %}

{% endtabs %}

![Footer view at the bottom of the .NET MAUI ComboBox drop-down](Images/HeaderFooter/footertemplate.png)

## See Also

* [Getting started with .NET MAUI ComboBox](getting-started.md)
* [Selection in .NET MAUI ComboBox](Selection.md)
* [Filtering in .NET MAUI ComboBox](Filtering.md)
* [No results found in .NET MAUI ComboBox](No-Results-Found.md)
* [UI customization in .NET MAUI ComboBox](UI-Customization.md)
* [SfComboBox API reference](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfComboBox.html)
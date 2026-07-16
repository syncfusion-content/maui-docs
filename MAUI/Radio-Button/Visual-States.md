---
layout: post
title: Visual States in .NET MAUI Radio Button Control | Syncfusion®
description: Learn about Visual States support in Syncfusion® .NET MAUI Radio Button (SfRadioButton) control.
platform: MAUI
control: SfRadioButton
documentation: UG
---

# Visual States in .NET MAUI Radio Button (SfRadioButton)

The visual appearance of the .NET MAUI Radio Button can be customized reactively using the `VisualStateManager` and `VisualState` types. The [`SfRadioButton`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfRadioButton.html) control exposes the following two visual states:

* [Checked](#checked-state)
* [Unchecked](#unchecked-state)

Visual states are applied automatically whenever the [`IsChecked`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfRadioButton.html#Syncfusion_Maui_Buttons_SfRadioButton_IsChecked) property changes (whether by user interaction or programmatically), so no event handler is required.

> **When to use visual states vs. `CheckedColor`/`UncheckedColor`:** the dedicated [`CheckedColor`](Visual-Customization.md#state-colors) and [`UncheckedColor`](Visual-Customization.md#state-colors) properties are the simplest way to change the circle color per state. Use **visual states** when you need to change more than one property at once (for example, text color, background color, and circle color) or when the changes are conditional (e.g., a different background only when checked).

> **Prerequisites:** Add the `Syncfusion.Maui.Buttons` NuGet package to your project and register the handler in `MauiProgram.cs`:
>
> ```csharp
> using Syncfusion.Maui.Buttons.Hosting;
> builder.ConfigureSyncfusionButtons();
> ```
>
> Add the namespace to your XAML page:
>
> ```xaml
> xmlns:syncfusion="clr-namespace:Syncfusion.Maui.Buttons;assembly=Syncfusion.Maui.Buttons"
> ```

> **Version compatibility:** Visual-state support is available starting with `Syncfusion.Maui.Buttons` package version 19.4.0.x and requires .NET MAUI (.NET 6 or later).

## Common Visual State Group

Both states are defined inside a single `VisualStateGroup` named `CommonStates`. The group is attached to `SfRadioButton` through the `VisualStateManager.VisualStateGroups` attached property (XAML) or the `VisualStateManager.SetVisualStateGroups` static method (C#). Inside each `VisualState.Setters` block you can change any bindable property of `SfRadioButton` — common targets include `TextColor`, `BackgroundColor`, `CheckedColor`, `UncheckedColor`, `StrokeThickness`, `FontAttributes`, and `FontSize`.

{% tabs %}
{% highlight xaml %}

<ContentPage xmlns:syncfusion="clr-namespace:Syncfusion.Maui.Buttons;assembly=Syncfusion.Maui.Buttons">
    <syncfusion:SfRadioButton Text="Radio Button">
        <VisualStateManager.VisualStateGroups>
            <VisualStateGroup x:Name="CommonStates">
                <VisualState x:Name="Checked">
                    <VisualState.Setters>
                        <Setter Property="TextColor" Value="Blue"/>
                        <Setter Property="BackgroundColor" Value="#8bc5fb"/>
                        <Setter Property="CheckedColor" Value="Blue"/>
                    </VisualState.Setters>
                </VisualState>
                <VisualState x:Name="Unchecked">
                    <VisualState.Setters>
                        <Setter Property="TextColor" Value="#ea3737"/>
                        <Setter Property="BackgroundColor" Value="#f6acac"/>
                        <Setter Property="UncheckedColor" Value="#ea3737"/>
                    </VisualState.Setters>
                </VisualState>
            </VisualStateGroup>
        </VisualStateManager.VisualStateGroups>
    </syncfusion:SfRadioButton>
</ContentPage>

{% endhighlight %}
{% highlight c# %}

using Syncfusion.Maui.Buttons;
using Microsoft.Maui;
using Microsoft.Maui.Controls;

SfRadioButton radioButton = new SfRadioButton { Text = "Radio Button" };

VisualStateGroupList visualStateGroupList = new VisualStateGroupList();
VisualStateGroup commonStateGroup = new VisualStateGroup { Name = "CommonStates" };

VisualState checkedState = new VisualState { Name = "Checked" };
checkedState.Setters.Add(new Setter { Property = SfRadioButton.TextColorProperty, Value = Colors.Blue });
checkedState.Setters.Add(new Setter { Property = SfRadioButton.BackgroundColorProperty, Value = Color.FromHex("#8bc5fb") });
checkedState.Setters.Add(new Setter { Property = SfRadioButton.CheckedColorProperty, Value = Colors.Blue });

VisualState uncheckedState = new VisualState { Name = "Unchecked" };
uncheckedState.Setters.Add(new Setter { Property = SfRadioButton.TextColorProperty, Value = Color.FromHex("#ea3737") });
uncheckedState.Setters.Add(new Setter { Property = SfRadioButton.BackgroundColorProperty, Value = Color.FromHex("#f6acac") });
uncheckedState.Setters.Add(new Setter { Property = SfRadioButton.UncheckedColorProperty, Value = Color.FromHex("#ea3737") });

commonStateGroup.States.Add(checkedState);
commonStateGroup.States.Add(uncheckedState);

visualStateGroupList.Add(commonStateGroup);
VisualStateManager.SetVisualStateGroups(radioButton, visualStateGroupList);
this.Content = radioButton;

{% endhighlight %}
{% endtabs %}

## Checked State

The `Checked` state is applied when [`IsChecked`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfRadioButton.html#Syncfusion_Maui_Buttons_SfRadioButton_IsChecked) is `true`. The setters in this state run whenever the button transitions into the checked state.

**Checked visual state**

![Visual state of checked state](Images/VisualState/checkedvisualstate.png)

## Unchecked State

The `Unchecked` state is applied when [`IsChecked`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfRadioButton.html#Syncfusion_Maui_Buttons_SfRadioButton_IsChecked) is `false`. The setters in this state run whenever the button transitions into the unchecked state.

**Unchecked visual state**

![Visual state of unchecked state](Images/VisualState/uncheckedvisualstate.png)

## Visual States in an `SfRadioGroup`

In a typical scenario multiple `SfRadioButton` instances are wrapped in an [`SfRadioGroup`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfRadioGroup.html). The same `VisualStateManager` markup can be applied to every child button (or via a `Style` with a `BasedOn` resource) so the same visuals are reused across the group.

{% tabs %}
{% highlight xaml %}

<ContentPage xmlns:syncfusion="clr-namespace:Syncfusion.Maui.Buttons;assembly=Syncfusion.Maui.Buttons">
    <syncfusion:SfRadioGroup>
        <syncfusion:SfRadioButton Text="Net banking" IsChecked="True">
            <VisualStateManager.VisualStateGroups>
                <VisualStateGroup x:Name="CommonStates">
                    <VisualState x:Name="Checked">
                        <VisualState.Setters>
                            <Setter Property="TextColor" Value="White"/>
                            <Setter Property="BackgroundColor" Value="#2e7d32"/>
                        </VisualState.Setters>
                    </VisualState>
                    <VisualState x:Name="Unchecked">
                        <VisualState.Setters>
                            <Setter Property="TextColor" Value="#2e7d32"/>
                            <Setter Property="BackgroundColor" Value="Transparent"/>
                        </VisualState.Setters>
                    </VisualState>
                </VisualStateGroup>
            </VisualStateManager.VisualStateGroups>
        </syncfusion:SfRadioButton>
        <syncfusion:SfRadioButton Text="Debit card">
            <VisualStateManager.VisualStateGroups>
                <VisualStateGroup x:Name="CommonStates">
                    <VisualState x:Name="Checked">
                        <VisualState.Setters>
                            <Setter Property="TextColor" Value="White"/>
                            <Setter Property="BackgroundColor" Value="#2e7d32"/>
                        </VisualState.Setters>
                    </VisualState>
                    <VisualState x:Name="Unchecked">
                        <VisualState.Setters>
                            <Setter Property="TextColor" Value="#2e7d32"/>
                            <Setter Property="BackgroundColor" Value="Transparent"/>
                        </VisualState.Setters>
                    </VisualState>
                </VisualStateGroup>
            </VisualStateManager.VisualStateGroups>
        </syncfusion:SfRadioButton>
    </syncfusion:SfRadioGroup>
</ContentPage>

{% endhighlight %}
{% endtabs %}

> **Tip:** to avoid duplicating the `VisualStateManager` markup on every Radio Button, define it once in a `Style` (via `Style.Setters` plus `VisualStateManager.VisualStateGroups`) and apply the style to all children of the `SfRadioGroup`.

## Troubleshooting

* **Visual state never changes** - Verify the `VisualState` `Name` matches one of the names recognized by the control (`Checked` or `Unchecked`). Misspelled names are silently ignored.
* **`VisualStateGroup.Name` not set in C#** - The runtime uses the group's `Name` to identify which state set is active. Always set `Name = "CommonStates"` (or a custom name) on the `VisualStateGroup` instance so the manager can match it.
* **Setters compile but don't apply** - In C#, the `Property` of a `Setter` must reference a `BindableProperty` identifier (for example, `SfRadioButton.TextColorProperty`), not the CLR property name. In XAML, the string form `"TextColor"` is resolved by the XAML parser.
* **C# samples fail to compile** - Add `using Syncfusion.Maui.Buttons;`, `using Microsoft.Maui;` (for `Colors`/`Color`) and `using Microsoft.Maui.Controls;` (for `VisualStateManager`, `VisualStateGroupList`, `VisualStateGroup`, `VisualState`, `Setter`) to the code-behind file. The XAML snippet must be placed inside a `ContentPage` (or another `IView` host) so `this.Content` resolves.
* **Mixing `Color.FromHex` and `Colors.*`** - Both are valid, but mixing them in a single state makes the code harder to read. Pick one form and use it throughout a single state.


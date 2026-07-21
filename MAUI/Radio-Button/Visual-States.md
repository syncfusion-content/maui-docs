---
layout: post
title: Visual States in .NET MAUI Radio Button Control | Syncfusion®
description: Learn how to use visual states to customize the .NET MAUI Radio Button (SfRadioButton) control's appearance per state.
platform: MAUI
control: SfRadioButton
documentation: UG
---

# Visual States in .NET MAUI Radio Button (SfRadioButton)

## Prerequisites

Before using the [`SfRadioButton`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfRadioButton.html), ensure the following NuGet package is installed in your .NET MAUI project:

- `Syncfusion.Maui.Buttons`

For a step-by-step setup, refer to the [Getting Started](https://help.syncfusion.com/maui/radio-button/getting-started) documentation.

The visual appearance of the .NET MAUI Radio Button can be customized reactively using the `VisualStateManager` and `VisualState` types. The `SfRadioButton` control exposes the following two visual states:

* [Checked](#checked-state)
* [Unchecked](#unchecked-state)

Visual states are applied automatically whenever the [`IsChecked`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfRadioButton.html#Syncfusion_Maui_Buttons_SfRadioButton_IsChecked) property changes (whether by user interaction or programmatically), so no event handler is required.

## Common Visual State Group

Both states are defined inside a single `VisualStateGroup` named `CommonStates`. The group is attached to `SfRadioButton` through the `VisualStateManager.VisualStateGroups` attached property (XAML) or the `VisualStateManager.SetVisualStateGroups` static method (C#). Inside each `VisualState.Setters` block you can change any bindable property of `SfRadioButton` — common targets include `TextColor`, `BackgroundColor`, `CheckedColor`, `UncheckedColor`, `StrokeThickness`, `FontAttributes`, and `FontSize`.

{% tabs %}
{% highlight xaml %}

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

{% endhighlight %}
{% highlight c# %}

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

{% endhighlight %}
{% endtabs %}

> **Tip:** to avoid duplicating the `VisualStateManager` markup on every Radio Button, define it once in a `Style` (via `Style.Setters` plus `VisualStateManager.VisualStateGroups`) and apply the style to all children of the `SfRadioGroup`.


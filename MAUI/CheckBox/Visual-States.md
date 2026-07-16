---
layout: post
title: Visual States in .NET MAUI CheckBox Control | Syncfusion®
description: Learn about Visual States support in Syncfusion® Essential Studio® .NET MAUI CheckBox (SfCheckBox) control and more.
platform: MAUI
control: SfCheckBox
documentation: UG
---

# Visual States in .NET MAUI CheckBox (SfCheckBox)

**Requirements:** .NET MAUI workload installed; `Syncfusion.Maui.Buttons` NuGet package added to the project; Syncfusion .NET MAUI controls registered via `.ConfigureSyncfusionCore()` / `UseSyncfusion*()` in `MauiProgram.cs`. Targets: .NET MAUI 7.0+ and Syncfusion<sup>®</sup> Essential Studio<sup>®</sup> MAUI `Syncfusion.Maui.Buttons` package.

XAML examples use the following namespace declaration on the page root:

xmlns:syncfusion="clr-namespace:Syncfusion.Maui.Buttons;assembly=Syncfusion.Maui.Buttons"

C# examples require the following imports:

using Syncfusion.Maui.Buttons;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Graphics;

The visual appearance of the CheckBox can be customized using the **Visual State Manager** (VSM). The [`SfCheckBox`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfCheckBox.html) control includes the following three visual states:

* `Checked`
* `Unchecked`
* `Intermediate`

You can change the state of the CheckBox by setting the [`IsChecked`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfCheckBox.html#Syncfusion_Maui_Buttons_SfCheckBox_IsChecked) property on the [`SfCheckBox`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfCheckBox.html) (or by user tap). In the checked state, a tick mark is displayed inside the CheckBox.

| State | Property | Value |
| --- | --- | --- |
| Checked | [`IsChecked`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfCheckBox.html#Syncfusion_Maui_Buttons_SfCheckBox_IsChecked) | `true` |
| Unchecked | [`IsChecked`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfCheckBox.html#Syncfusion_Maui_Buttons_SfCheckBox_IsChecked) | `false` |
| Intermediate | [`IsChecked`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfCheckBox.html#Syncfusion_Maui_Buttons_SfCheckBox_IsChecked) | `null` (requires [`IsThreeState`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfCheckBox.html#Syncfusion_Maui_Buttons_SfCheckBox_IsThreeState) = `true`) |

N> The indeterminate state is only reported when the [`IsThreeState`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfCheckBox.html#Syncfusion_Maui_Buttons_SfCheckBox_IsThreeState) property is `true`. Without it, `IsChecked` is treated as `false` and the CheckBox never enters the `Intermediate` state.

## Defining visual states

`SfCheckBox` exposes its three states through a single [`VisualStateGroup`](https://learn.microsoft.com/dotnet/maui/user-interface/visual-states) named `CommonStates`. Each `VisualState` (`Checked`, `Unchecked`, `Intermediate`) contains a list of `Setter` objects that target bindable properties on the CheckBox. Common target properties are `TextColor`, `CheckedColor`, `UncheckedColor`, and `Text`.

{% tabs %}
{% highlight xaml %}

<syncfusion:SfCheckBox Text="CheckBox" IsThreeState="True">
    <VisualStateManager.VisualStateGroups>
        <VisualStateGroup x:Name="CommonStates">
            <!-- Checked: blue text and box fill. -->
            <VisualState x:Name="Checked">
                <VisualState.Setters>
                    <Setter Property="TextColor" Value="Blue"/>
                    <Setter Property="CheckedColor" Value="Blue"/>
                </VisualState.Setters>
            </VisualState>
            <!-- Unchecked: red text and box stroke. -->
            <VisualState x:Name="Unchecked">
                <VisualState.Setters>
                    <Setter Property="TextColor" Value="#ea3737"/>
                    <Setter Property="UncheckedColor" Value="#ea3737"/>
                </VisualState.Setters>
            </VisualState>
            <!-- Intermediate: blue fill and a custom caption. -->
            <VisualState x:Name="Intermediate">
                <VisualState.Setters>
                    <Setter Property="CheckedColor" Value="Blue"/>
                    <Setter Property="Text" Value="Intermediate State"/>
                </VisualState.Setters>
            </VisualState>
        </VisualStateGroup>
    </VisualStateManager.VisualStateGroups>
</syncfusion:SfCheckBox>

{% endhighlight %}
{% highlight c# %}

// Enable the indeterminate state.
SfCheckBox checkBox = new SfCheckBox() { Text = "CheckBox", IsThreeState = true };
VisualStateGroupList visualStateGroupList = new VisualStateGroupList();
VisualStateGroup commonStateGroup = new VisualStateGroup();

// Checked: blue text and box fill.
VisualState checkedState = new VisualState { Name = "Checked" };
checkedState.Setters.Add(new Setter { Property = SfCheckBox.TextColorProperty, Value = Colors.Blue });
checkedState.Setters.Add(new Setter { Property = SfCheckBox.CheckedColorProperty, Value = Colors.Blue });

// Unchecked: red text and box stroke.
VisualState uncheckedState = new VisualState { Name = "Unchecked" };
uncheckedState.Setters.Add(new Setter { Property = SfCheckBox.TextColorProperty, Value = Color.FromHex("#ea3737") });
uncheckedState.Setters.Add(new Setter { Property = SfCheckBox.UncheckedColorProperty, Value = Color.FromHex("#ea3737") });

// Intermediate: blue fill and a custom caption.
VisualState intermediateState = new VisualState { Name = "Intermediate" };
intermediateState.Setters.Add(new Setter { Property = SfCheckBox.TextProperty, Value = "Intermediate State" });
intermediateState.Setters.Add(new Setter { Property = SfCheckBox.CheckedColorProperty, Value = Colors.Blue });

commonStateGroup.States.Add(checkedState);
commonStateGroup.States.Add(uncheckedState);
commonStateGroup.States.Add(intermediateState);

visualStateGroupList.Add(commonStateGroup);
VisualStateManager.SetVisualStateGroups(checkBox, visualStateGroupList);
this.Content = checkBox;

{% endhighlight %}
{% endtabs %}

## Result

### Checked visual state

![.NET MAUI CheckBox in the Checked visual state with blue text and fill](Images/VisualStates/checkedvs.png)

### Unchecked visual state

![.NET MAUI CheckBox in the Unchecked visual state with red text and stroke](Images/VisualStates/uncheckedvs.png)

### Intermediate visual state

![.NET MAUI CheckBox in the Intermediate visual state with blue fill and 'Intermediate State' caption](Images/VisualStates/intermediatevs.png)

N> Troubleshooting: if a state is not applied, verify that the `VisualStateGroup` is named `CommonStates` and that each `VisualState` uses the exact names `Checked`, `Unchecked`, and `Intermediate`. Also confirm `IsThreeState` is `true` if you need the `Intermediate` state, and that the `xmlns:syncfusion` namespace maps to `Syncfusion.Maui.Buttons`. Wrap any code that changes `IsChecked` in a try/catch so a handler error does not interrupt the state transition.
---
layout: post
title: Visual States in .NET MAUI CheckBox Control | Syncfusion®
description: Learn about Visual States support in Syncfusion® Essential Studio® .NET MAUI CheckBox (SfCheckBox) control and more.
platform: MAUI
control: SfCheckBox
documentation: UG
---

# Visual States in .NET MAUI CheckBox (SfCheckBox)

The visual appearance of the [.NET MAUI CheckBox](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfCheckBox.html) can be customized using the **Visual State Manager** (VSM). The CheckBox control includes the following three visual states:

* `Checked`
* `Unchecked`
* `Intermediate`

You can change the state of the CheckBox by setting the [`IsChecked`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfCheckBox.html#Syncfusion_Maui_Buttons_SfCheckBox_IsChecked) property on the CheckBox (or by user tap). In the checked state, a tick mark is displayed inside the CheckBox.

| State | Property | Value |
| --- | --- | --- |
| Checked | `IsChecked` | `true` |
| Unchecked | `IsChecked` | `false` |
| Intermediate | `IsChecked` | `null` (requires `IsThreeState = true`) |

N> The Intermediate state is only reported when the `IsThreeState` property is `true`. Without it, `IsChecked` is treated as `false` and the CheckBox never enters the `Intermediate` state.

## Prerequisites

Before using the [SfCheckBox](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfCheckBox.html), ensure the following NuGet package is installed in your .NET MAUI project:

- `Syncfusion.Maui.Buttons`

For a step-by-step setup, refer to the [Getting Started](https://help.syncfusion.com/maui/checkbox/getting-started) documentation.

## Defining visual states

`SfCheckBox` exposes its three states through a single `VisualStateGroup` named `CommonStates`. Each `VisualState` (`Checked`, `Unchecked`, `Intermediate`) contains a list of `Setter` objects that target bindable properties on the CheckBox. Common target properties are `TextColor`, `CheckedColor`, `UncheckedColor`, and `Text`.

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

### Checked visual state

![.NET MAUI CheckBox in the Checked visual state with blue text and fill](Images/VisualStates/checkedvs.png)

### Unchecked visual state

![.NET MAUI CheckBox in the Unchecked visual state with red text and stroke](Images/VisualStates/uncheckedvs.png)

### Intermediate visual state

![.NET MAUI CheckBox in the Intermediate visual state with blue fill and Intermediate State caption](Images/VisualStates/intermediatevs.png)

## See Also

- [Visual customization in .NET MAUI CheckBox](https://help.syncfusion.com/maui/checkbox/visual-customization)
- [Multiple choice with .NET MAUI CheckBox](https://help.syncfusion.com/maui/checkbox/multiple-choice)
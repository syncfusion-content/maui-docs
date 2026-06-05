---
layout: post
title: Visual States in .NET MAUI CheckBox Control | Syncfusion®
description: Learn about Visual States support in Syncfusion® MAUI CheckBox (SfCheckBox) control and more.
platform: MAUI
control: SfCheckBox
documentation: UG
---

# Visual States in .NET MAUI CheckBox (SfCheckBox)

The visual appearance of the CheckBox can be customized using `VisualStates`. The [`SfCheckBox`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfCheckBox.html) control includes the following three visual states:

* Checked
* Unchecked
* Intermediate

You can change the state of the CheckBox using the [`IsChecked`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfCheckBox.html#Syncfusion_Maui_Buttons_SfCheckBox_IsChecked) property of the [`SfCheckBox`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfCheckBox.html). In the checked state, a tick mark is added to the visualization of the CheckBox.

<table>
<tr>
<td>
<b>State</b>
</td>
<td>
<b>Property</b>
</td>
<td>
<b>Value</b>
</td>
</tr>
<tr>
<td>
checked
</td>
<td>
IsChecked
</td>
<td>
true
</td>
</tr>
<tr>
<td>
unchecked
</td>
<td>
IsChecked
</td>
<td>
false
</td>
</tr>
<tr>
<td>
indeterminate
</td>
<td>
IsChecked
</td>
<td>
null
</td>
</tr>
</table>

N> To report the indeterminate state for the CheckBox, set the [`IsThreeState`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfCheckBox.html#Syncfusion_Maui_Buttons_SfCheckBox_IsThreeState) property to true.

{% tabs %}
{% highlight xaml %}

    <syncfusion:SfCheckBox Text="CheckBox" IsThreeState="True">
        <VisualStateManager.VisualStateGroups>
            <VisualStateGroup x:Name="CommonStates">
                <VisualState x:Name="Checked">
                    <VisualState.Setters>
                        <Setter Property="TextColor" Value="Blue"/>
                        <Setter Property="CheckedColor" Value="Blue"/>
                    </VisualState.Setters>
                </VisualState>
                <VisualState x:Name="Unchecked">
                    <VisualState.Setters>
                        <Setter Property="TextColor" Value="#ea3737"/>
                        <Setter Property="UncheckedColor" Value="#ea3737"/>
                    </VisualState.Setters>
                </VisualState>
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

        SfCheckBox checkBox = new SfCheckBox() { Text = "CheckBox", IsThreeState = true };
        VisualStateGroupList visualStateGroupList = new VisualStateGroupList();
        VisualStateGroup commonStateGroup = new VisualStateGroup();

        VisualState checkedState = new VisualState
        {
            Name = "Checked"
        };

        checkedState.Setters.Add(new Setter { Property = SfCheckBox.TextColorProperty, Value = Colors.Blue });
        checkedState.Setters.Add(new Setter { Property = SfCheckBox.CheckedColorProperty, Value = Colors.Blue });

        VisualState uncheckedState = new VisualState
        {
            Name = "Unchecked"
        };
        uncheckedState.Setters.Add(new Setter { Property = SfCheckBox.TextColorProperty, Value = Color.FromHex("#ea3737") });
        uncheckedState.Setters.Add(new Setter { Property = SfCheckBox.UncheckedColorProperty, Value = Color.FromHex("#ea3737") });

        VisualState intermediateState = new VisualState
        {
            Name = "Intermediate"
        };

        intermediateState.Setters.Add(new Setter { Property = SfCheckBox.TextProperty, Value = "Intermediate State" });
        intermediateState.Setters.Add(new Setter { Property = SfCheckBox.CheckedColorProperty, Value = Colors.Blue});

        commonStateGroup.States.Add(checkedState);
        commonStateGroup.States.Add(uncheckedState);
        commonStateGroup.States.Add(intermediateState);

        visualStateGroupList.Add(commonStateGroup);
        VisualStateManager.SetVisualStateGroups(checkBox, visualStateGroupList);
        this.Content = checkBox;

{% endhighlight %}
{% endtabs %}

**Checked visual state:**

![.NET MAUI CheckBox](Images/VisualStates/checkedvs.png)

**Unchecked visual state:**

![.NET MAUI CheckBox](Images/VisualStates/uncheckedvs.png)

**Intermediate visual state:**

![.NET MAUI CheckBox](Images/VisualStates/intermediatevs.png)

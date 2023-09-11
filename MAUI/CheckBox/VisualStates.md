---
layout: post
title: Visual States in .NET MAUI CheckBox control | Syncfusion
description: Learn here all about Visual States support in Syncfusion MAUI CheckBox (SfCheckBox) control and more.
platform: xamarin
control: SfCheckBox
documentation: ug
---

## Visual States in MAUI CheckBox (SfCheckBox)

The visual of CheckBox can be customized using `VisualStates`. The [`SfCheckBox`] control contains the following three visual states:

* Checked
* Unchecked
* Intermediate

{% tabs %}
{% highlight xaml %}

    <buttons:SfCheckBox Text="CheckBox" IsThreeState="True">
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
    </buttons:SfCheckBox>

{% endhighlight %}
{% highlight c# %}

    SfCheckBox checkBox = new SfCheckBox() { Text = "CheckBox", IsThreeState = "True" };
    VisualStateGroupList visualStateGroupList = new VisualStateGroupList();
    VisualStateGroup commonStateGroup = new VisualStateGroup();

    VisualState checkedState = new VisualState
    {
        Name = "Checked"
    };

    checkedState.Setters.Add(new Setter { Property = SfCheckBox.TextColorProperty, Value = Color.Blue });
    checkedState.Setters.Add(new Setter { Property = SfCheckBox.CheckedColorProperty, Value = Color.Blue });

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

    intermediateState.Setters.Add(new Setter { Property = SfCheckBox.TextProperty, Value = "Intermediate State") });
    intermediateState.Setters.Add(new Setter { Property = SfCheckBox.CheckedColorProperty, Value = Color.Blue });

    commonStateGroup.States.Add(checkedState);
    commonStateGroup.States.Add(uncheckedState);
    commonStateGroup.States.Add(intermediateState);

    visualStateGroupList.Add(commonStateGroup);
    VisualStateManager.SetVisualStateGroups(checkBox, visualStateGroupList);

{% endhighlight %}
{% endtabs %}

**Checked visual state:**

![.NET MAUI CheckBox](Images/VisualStates/checkedstate.png)

**Unchecked visual state:**

![.NET MAUI CheckBox](Images/VisualStates/uncheckedstate.png)

**Intermediate visual state:**

![.NET MAUI CheckBox](Images/VisualStates/intermediatestate.png)

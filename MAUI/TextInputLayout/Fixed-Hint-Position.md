---
layout: post
title: Fixed Hint Position in .NET MAUI Text Input Layout | Syncfusion®
description: Learn how to keep the hint label always at the top (always-floated) position in the Syncfusion® .NET MAUI Text Input Layout control.
platform: maui
control: SfTextInputLayout
documentation: ug
keywords: .net maui textinputlayout ishintalwaysfloated, syncfusion text input layout fixed hint maui, sftextinputlayout always floated hint maui, .net maui text input layout hint position, sftextinputlayout hint floating maui
---

# Fixed Hint Position in .NET MAUI Text Input Layout

By default, the hint label in [Text Input Layout](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfTextInputLayout.html) floats to the top of the input line only when the input view is focused or contains a value. When the input is empty and unfocused, the hint sits in the input line as a placeholder. Set the [IsHintAlwaysFloated](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfTextInputLayout.html#Syncfusion_Maui_Core_SfTextInputLayout_IsHintAlwaysFloated) property to `true` to keep the hint label permanently at the top, regardless of focus or value state.

N> The default value of `IsHintAlwaysFloated` is `false`.

## Prerequisites

Before using the [SfTextInputLayout](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfTextInputLayout.html), ensure the following NuGet package is installed in your .NET MAUI project:

- `Syncfusion.Maui.Core`

For a step-by-step setup, refer to the [Getting Started](https://help.syncfusion.com/maui/textinputlayout/getting-started) documentation.

## Always-floated hint with Filled container

The hint label position of the input view will be set always at the top for the [Filled](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.ContainerType.html#Syncfusion_Maui_Core_ContainerType_Filled) container type.

{% tabs %}
{% highlight xaml %}

<inputLayout:SfTextInputLayout Hint="Name"
                               IsHintAlwaysFloated="True"
                               ContainerType="Filled">
    <Entry />
</inputLayout:SfTextInputLayout>

{% endhighlight %}
{% highlight C# %}

SfTextInputLayout inputLayout = new SfTextInputLayout
{
    Hint = "Name",
    IsHintAlwaysFloated = true,
    ContainerType = ContainerType.Filled,
    Content = new Entry()
};
Content = inputLayout;

{% endhighlight %}
{% endtabs %}

![Filled SfTextInputLayout with the hint label always floated at the top](images/FixedHintPosition/HintPositionFilled.png)

## Always-floated hint with Outlined container

The hint label position of the input view will be set always at the top for the [Outlined](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.ContainerType.html#Syncfusion_Maui_Core_ContainerType_Outlined) container type.

{% tabs %}
{% highlight xaml %}

<inputLayout:SfTextInputLayout Hint="Name"
                               IsHintAlwaysFloated="True"
                               ContainerType="Outlined">
    <Entry />
</inputLayout:SfTextInputLayout>

{% endhighlight %}
{% highlight C# %}

SfTextInputLayout inputLayout = new SfTextInputLayout
{
    Hint = "Name",
    IsHintAlwaysFloated = true,
    ContainerType = ContainerType.Outlined,
    Content = new Entry()
};
Content = inputLayout;

{% endhighlight %}
{% endtabs %}

![Outlined SfTextInputLayout with the hint label always floated at the top](images/FixedHintPosition/HintPositionOutlined.png)

## Always-floated hint with None container

{% tabs %}
{% highlight xaml %}

<inputLayout:SfTextInputLayout Hint="Name"
                               IsHintAlwaysFloated="True"
                               ContainerType="None">
    <Entry />
</inputLayout:SfTextInputLayout>

{% endhighlight %}
{% highlight C# %}

SfTextInputLayout inputLayout = new SfTextInputLayout
{
    Hint = "Name",
    IsHintAlwaysFloated = true,
    ContainerType = ContainerType.None,
    Content = new Entry()
};
Content = inputLayout;

{% endhighlight %}
{% endtabs %}

![None-container SfTextInputLayout with the hint label always floated at the top](images/FixedHintPosition/HintPositionNone.png)

## See Also

- [Container Types](https://help.syncfusion.com/maui/textinputlayout/container-type)
- [Assistive Labels](https://help.syncfusion.com/maui/textinputlayout/assistive-labels)
- [Custom Font](https://help.syncfusion.com/maui/textinputlayout/custom-font)
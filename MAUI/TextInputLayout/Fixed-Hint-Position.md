---
layout: post
title: Fixed Hint Position in .NET MAUI Text Input Layout Control | Syncfusion®
description: Learn about Fixed Hint Position support in Syncfusion® .NET MAUI Text Input Layout (SfTextInputLayout) control and more.
platform: maui
control: SfTextInputLayout
documentation: ug
keywords: .net maui text input layout, syncfusion text input layout, text input layout maui, .net maui hint label
---

# Fixed Hint Position in .NET MAUI Text Input Layout (SfTextInputLayout)

The hint label for the text input layout is positioned at the top permanently, which allows users to see the hint label even when the input view is not focused. Enable this feature by setting the [IsHintAlwaysFloated](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfTextInputLayout.html#Syncfusion_Maui_Core_SfTextInputLayout_IsHintAlwaysFloated) property.

> **NOTE**
> The default value of `IsHintAlwaysFloated` is `false`.

## Filled

For the [Filled](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.ContainerType.html#Syncfusion_Maui_Core_ContainerType_Filled) container type, the hint label position will always be at the top.
{% tabs %} 

{% highlight xaml %} 

<inputLayout:SfTextInputLayout Hint="Name"
                               IsHintAlwaysFloated="true" 
                               ContainerType="Filled">
        <Entry />
</inputLayout:SfTextInputLayout>

{% endhighlight %}

{% highlight C# %} 

SfTextInputLayout inputLayout = new SfTextInputLayout();
inputLayout.Hint = "Name";
inputLayout.IsHintAlwaysFloated = true;
inputLayout.ContainerType = ContainerType.Filled;
inputLayout.Content = new Entry(); 

{% endhighlight %}

{% endtabs %}

![Filled type](images/FixedHintPosition/HintPositionFilled.png)

## Outlined

For the [Outlined](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.ContainerType.html#Syncfusion_Maui_Core_ContainerType_Outlined) container type, the hint label position will also always be at the top.
{% tabs %} 

{% highlight xaml %} 

<inputLayout:SfTextInputLayout Hint="Name"
                               IsHintAlwaysFloated="true" 
                               ContainerType="Outlined">
        <Entry />
</inputLayout:SfTextInputLayout>
 
{% endhighlight %}

{% highlight C# %} 

SfTextInputLayout inputLayout = new SfTextInputLayout();
inputLayout.Hint = "Name";
inputLayout.IsHintAlwaysFloated = true;
inputLayout.ContainerType = ContainerType.Outlined;
inputLayout.Content = new Entry(); 

{% endhighlight %}

{% endtabs %}

![Outlined type](images/FixedHintPosition/HintPositionOutlined.png)

## None

For the [None](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.ContainerType.html#Syncfusion_Maui_Core_ContainerType_None) container type, the hint label also remains fixed at the top.
{% tabs %} 

{% highlight xaml %} 

<inputLayout:SfTextInputLayout Hint="Name"
                               IsHintAlwaysFloated="true" 
                               ContainerType="None">
        <Entry />
</inputLayout:SfTextInputLayout> 
 
{% endhighlight %}

{% highlight C# %} 

SfTextInputLayout inputLayout = new SfTextInputLayout();
inputLayout.Hint = "Name";
inputLayout.IsHintAlwaysFloated = true;
inputLayout.ContainerType = ContainerType.None;
inputLayout.Content = new Entry(); 

{% endhighlight %}

{% endtabs %}

![None type](images/FixedHintPosition/HintPositionNone.png)

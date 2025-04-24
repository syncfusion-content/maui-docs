---
layout: post
title: Fixed Hint Position in .NET MAUI TextInputLayout control | Syncfusion®
description: Learn here all about Fixed Hint Position support in Syncfusion® .NET MAUI Text Input Layout (SfTextInputLayout) control and more.
platform: maui
control: SfTextInputLayout
documentation: ug
keywords: .net maui text input layout, syncfusion text input layout, text input layout maui, .net maui hint label.
---

# Fixed Hint Position in .NET MAUI Text Input Layout (SfTextInputLayout)

Hint label for the text input layout is always fixed at the top position. This helps users make the hint label float even when the input view is not focused. It can be enabled by setting the [IsHintAlwaysFloated](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfTextInputLayout.html#Syncfusion_Maui_Core_SfTextInputLayout_IsHintAlwaysFloated) property.

>**NOTE**
The default value of the `IsHintAlwaysFloated` is `false`.

## Filled

The hint label position of the input view will be set always at the top for the [Filled](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.ContainerType.html#Syncfusion_Maui_Core_ContainerType_Filled) container type. 

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

The hint label position of the input view will be set always at the top for the [Outlined](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.ContainerType.html#Syncfusion_Maui_Core_ContainerType_Outlined) container type.

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

The hint label position of the input view will be set always at the top for the [None](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.ContainerType.html#Syncfusion_Maui_Core_ContainerType_None) container type.

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
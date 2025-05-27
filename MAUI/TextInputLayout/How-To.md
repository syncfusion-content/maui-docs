---
layout: post
title: How to Customize Stroke Thickness | SfTextInputLayout | .NET MAUI | Syncfusion®
description: Learn about stroke thickness customization in Syncfusion® .NET MAUI Text Input Layout (SfTextInputLayout) control and more.
platform: maui
control: SfTextInputLayout
documentation: ug
keywords: .net maui text input layout, syncfusion text input layout, text input layout maui
--- 
# How to Customize the Thickness of Stroke

## Customizing Stroke Thickness
The stroke width for the [Outlined](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.ContainerType.html#Syncfusion_Maui_Core_ContainerType_Outlined) container type and the line thickness for the [Filled](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.ContainerType.html#Syncfusion_Maui_Core_ContainerType_Filled) and [None](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.ContainerType.html#Syncfusion_Maui_Core_ContainerType_None) container types can be customized based on the focus state of the input view by setting the [FocusedStrokeThickness](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfTextInputLayout.html#Syncfusion_Maui_Core_SfTextInputLayout_FocusedStrokeThickness) and [UnfocusedStrokeThickness](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfTextInputLayout.html#Syncfusion_Maui_Core_SfTextInputLayout_UnfocusedStrokeThickness) properties.

{% tabs %}

{% highlight xaml %}

<inputLayout:SfTextInputLayout  Hint="Name" 
                                ContainerType="Outlined"
                                FocusedStrokeThickness="4"
                                UnfocusedStrokeThickness="2">
    <Entry />
</inputLayout:SfTextInputLayout>
		
{% endhighlight %}

{% highlight c# %}

SfTextInputLayout inputLayout = new SfTextInputLayout();
inputLayout.Hint = "Name";
inputLayout.ContainerType = ContainerType.Outlined;
inputLayout.FocusedStrokeThickness = 4;
inputLayout.UnfocusedStrokeThickness = 2;
inputLayout.Content = new Entry(); 

{% endhighlight %}

{% endtabs %}

![StrokeThickness img](images/HowTo/StrokeThickness.png)

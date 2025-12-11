---
layout: post
title: Assistive Labels in .NET MAUI Text Input Layout control | Syncfusion®
description: Learn here all about Assistive Labels support in Syncfusion® .NET MAUI Text Input Layout (SfTextInputLayout) control and more.
platform: maui
control: SfTextInputLayout
documentation: ug
keywords: .net maui text input layout, syncfusion text input layout, text input layout maui, .net maui error label, .net maui hint label.
---

# Assistive Labels in .NET MAUI Text Input Layout (SfTextInputLayout)

Assistive labels provide additional information about text entered in the input view controls.

## Helper text

Helper text conveys additional guidance about the input field, such as how it will be used. It can be set using the [HelperText](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfTextInputLayout.html#Syncfusion_Maui_Core_SfTextInputLayout_HelperText) property.

{% tabs %} 

{% highlight xaml %} 

<inputLayout:SfTextInputLayout Hint="Name"
                               HelperText="Enter your name">
    <Entry />
</inputLayout:SfTextInputLayout>   

{% endhighlight %}

{% highlight C# %} 

SfTextInputLayout inputLayout = new SfTextInputLayout();
inputLayout.Hint = "Name";
inputLayout.HelperText = "Enter your name";
inputLayout.Content = new Entry(); 

{% endhighlight %}

{% endtabs %}

The visibility of the helper text can be disabled by setting the [ShowHelperText](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfTextInputLayout.html#Syncfusion_Maui_Core_SfTextInputLayout_ShowHelperText) property to false. By default, it is set to true.

![maui-textinputlayout-helpertext label](images/AssistiveLabels/Maui-TextInputLayout-HelperText.jpg)

## Error message

When the text input is not accepted, an error message will display instructions to fix it. Error messages will be displayed below the input line till entering the correct text. It can be set using the [ErrorText](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfTextInputLayout.html#Syncfusion_Maui_Core_SfTextInputLayout_ErrorText) property, but it will be displayed only when the [HasError](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfTextInputLayout.html#Syncfusion_Maui_Core_SfTextInputLayout_HasError) property is set to `true.`

{% tabs %} 

{% highlight xaml %} 

<inputLayout:SfTextInputLayout Hint="Email" ContainerType="Outlined"
                               HelperText="Enter your email address"
                               ErrorText="Invalid email"
                               HasError="true">
    <Entry />
</inputLayout:SfTextInputLayout>  
 

{% endhighlight %}

{% highlight C# %} 

SfTextInputLayout inputLayout = new SfTextInputLayout();
inputLayout.Hint = "Email";
inputLayout.ContainerType= ContainerType.Outlined;
inputLayout.HelperText = "Enter your email address";
inputLayout.ErrorText = "Invalid email";
inputLayout.HasError = true; 
inputLayout.Content = new Entry(); 

{% endhighlight %}

{% endtabs %}

![maui-textinputlayout-error label](images/AssistiveLabels/Maui-TextInputLayout-ErrorLabel.jpg)

N> Error validations should be done in the application level.

## Character counter

Character counter is used when you need to limit the characters. Character limit can be set using the [CharMaxLength](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfTextInputLayout.html#Syncfusion_Maui_Core_SfTextInputLayout_CharMaxLength) property.The character counter can be enabled by setting the [ShowCharCount]() property to true.

{% tabs %} 

{% highlight xaml %} 

<inputLayout:SfTextInputLayout Hint="Password" 
                               ShowCharCount="true"
                               CharMaxLength="8"
                               ContainerType="Outlined"
                               HelperText="Enter 5 to 8 characters">
    <Entry />
</inputLayout:SfTextInputLayout> 
  

{% endhighlight %}

{% highlight C# %} 

SfTextInputLayout inputLayout = new SfTextInputLayout();
inputLayout.Hint = "Password";
inputLayout.CharMaxLength = 8;
inputLayout.ShowCharCount = true;
inputLayout.ContainerType= ContainerType.Outlined;
inputLayout.HelperText = "Enter 5 to 8 characters";
inputLayout.Content = new Entry(); 

{% endhighlight %}

{% endtabs %}

![Character Maximum Length](images/AssistiveLabels/textinputlayout_showchar.gif)

N> When character count reaches the maximum character length, the error color will be applied to hint, border, and counter label.

## Reserve spaces for assistive labels

The reserved spaces for assistive labels can be removed by setting the [ReserveSpaceForAssistiveLabels](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfTextInputLayout.html#Syncfusion_Maui_Core_SfTextInputLayout_ReserveSpaceForAssistiveLabels) property to false.

{% tabs %}

{% highlight xaml %}

<inputLayout:SfTextInputLayout ContainerType="Outlined" 
                               Hint="Name" 
                               ReserveSpaceForAssistiveLabels="False">
    <Entry />
</inputLayout:SfTextInputLayout>

{% endhighlight %}

{% highlight c# %}

SfTextInputLayout inputLayout = new SfTextInputLayout();
inputLayout.Hint = "Name";
inputLayout.ContainerType = ContainerType.Outlined;
inputLayout.ReserveSpaceForAssistiveLabels = false;
inputLayout.Content = new Entry(); 

{% endhighlight %}

{% endtabs %}

![Reserve space for assistive label image](images/AssistiveLabels/ReserveSpace.png)

---
layout: post
title: Container Type in .NET MAUI Text Input Layout Control | Syncfusion®
description: Learn all about Container Type support in Syncfusion® .NET MAUI Text Input Layout (SfTextInputLayout) control and more.
platform: maui
control: SfTextInputLayout
documentation: ug
keywords: .net maui text input layout, syncfusion text input layout, text input layout maui
---

# Container Type in .NET MAUI Text Input Layout (SfTextInputLayout)

Containers enhance the discoverability of input views by creating a visual contrast between the input field and assistive elements.

## Filled

When the background of the input view is filled with container color, the stroke color and thickness at the bottom edge change based on the state. Enable this by setting the [ContainerType](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfTextInputLayout.html#Syncfusion_Maui_Core_SfTextInputLayout_ContainerType) property to [Filled](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.ContainerType.html#Syncfusion_Maui_Core_ContainerType_Filled).

{% tabs %} 

{% highlight xaml %} 

<inputLayout:SfTextInputLayout Hint="Name"
                               HelperText="Enter the name"
                               ContainerType="Filled">
    <Entry Text="John" />
</inputLayout:SfTextInputLayout>  

{% endhighlight %}

{% highlight C# %} 

SfTextInputLayout inputLayout = new SfTextInputLayout();
inputLayout.Hint = "Name";
inputLayout.HelperText = "Enter the name";
inputLayout.ContainerType = ContainerType.Filled;
inputLayout.Content = new Entry() { Text = "John" }; 

{% endhighlight %}

{% endtabs %}

![Filled type](images/ContainerType/Filled_Focused.jpg)

## Outlined

Set the [ContainerType](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfTextInputLayout.html#Syncfusion_Maui_Core_SfTextInputLayout_ContainerType) property to [Outlined](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.ContainerType.html#Syncfusion_Maui_Core_ContainerType_Outlined) to surround the container with an outlined rounded-corner border.

{% tabs %} 

{% highlight xaml %} 

<inputLayout:SfTextInputLayout Hint="Name"
                               HelperText="Enter the name"
                               ContainerType="Outlined">
    <Entry Text="John" />
</inputLayout:SfTextInputLayout>  
 

{% endhighlight %}

{% highlight C# %} 

SfTextInputLayout inputLayout = new SfTextInputLayout();
inputLayout.Hint = "Name";
inputLayout.HelperText = "Enter the name";
inputLayout.ContainerType = ContainerType.Outlined;
inputLayout.Content = new Entry() { Text = "John" }; 

{% endhighlight %}

{% endtabs %}

![Outlined type](images/ContainerType/Outlined.png)

### Customize the Corner Radius of the Outline Border

Customize the corner radius by setting the [OutlineCornerRadius](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfTextInputLayout.html#Syncfusion_Maui_Core_SfTextInputLayout_OutlineCornerRadius) property.

{% tabs %}

{% highlight xaml %}

<inputLayout:SfTextInputLayout Hint="Name" 
                               ContainerType="Outlined"
                               OutlineCornerRadius="8">
    <Entry />
</inputLayout:SfTextInputLayout>  
			
{% endhighlight %}

{% highlight c# %}

SfTextInputLayout inputLayout = new SfTextInputLayout();
inputLayout.Hint = "Name";
inputLayout.ContainerType = ContainerType.Outlined;
inputLayout.OutlineCornerRadius = 8;
inputLayout.Content = new Entry(); 

{% endhighlight %}

{% endtabs %}

![OutlineCornerRadius img](images/ContainerType/CornerRadius.png)

> **NOTE**: This is applicable for the outline border when the container type is set to outlined.

### Custom Padding

Customize spaces around the input view by setting the `InputViewPadding` property to a [Thickness](https://learn.microsoft.com/en-us/dotnet/api/microsoft.maui.thickness?view=net-maui-7.0) value.

{% tabs %} 

{% highlight xaml %} 

<inputLayout:SfTextInputLayout Hint="Padding"
                               InputViewPadding="0,5,0,5" 
                               ContainerType="Outlined"
                               HelperText="Top and bottom padding is 5">
    <Entry />
 </inputLayout:SfTextInputLayout> 

{% endhighlight %}

{% highlight C# %} 

SfTextInputLayout inputLayout = new SfTextInputLayout();
inputLayout.Hint = "Padding";
inputLayout.InputViewPadding = new Thickness(0,5,0,5);
inputLayout.ContainerType = ContainerType.Outlined;
inputLayout.HelperText = "Top and bottom padding is 5";
inputLayout.Content = new Entry(); 

{% endhighlight %}

{% endtabs %}

![Padding customization around the input view](images/ContainerType/padingg.png)

## None

For an unstyled container with a plain background and ample spacing, set the [ContainerType](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfTextInputLayout.html#Syncfusion_Maui_Core_SfTextInputLayout_ContainerType) property to [None](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.ContainerType.html#Syncfusion_Maui_Core_ContainerType_None).

{% tabs %} 

{% highlight xaml %} 

<inputLayout:SfTextInputLayout Hint="Name"
                               HelperText="Enter the name" 
                               ContainerType="None">
    <Entry Text="John" />
</inputLayout:SfTextInputLayout>  
 

{% endhighlight %}

{% highlight C# %} 

SfTextInputLayout inputLayout = new SfTextInputLayout();
inputLayout.Hint = "Name";
inputLayout.HelperText = "Enter the name";
inputLayout.ContainerType = ContainerType.None;
inputLayout.Content = new Entry() { Text = "John" }; 

{% endhighlight %}

{% endtabs %}

![None type](images/ContainerType/None_focused.jpg)
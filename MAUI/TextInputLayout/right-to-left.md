---
layout: post
title: Right-to-Left in .NET MAUI Text Input Layout control | Syncfusion
description: Learn about Right-to-Left support in Syncfusion .NET MAUI Text Input Layout (SfTextInputLayout) control and more.
platform: maui
control: SfTextInputLayout
documentation: ug
keywords: .net maui text input layout, syncfusion text input layout, text input layout maui.
---

# Right-to-Left in .NET MAUI Text Input Layout (SfTextInputLayout)

The TextInputLayout supports to changing the flow of text to the right-to-left direction by setting the [FlowDirection](https://learn.microsoft.com/en-us/dotnet/api/microsoft.maui.controls.device.flowdirection?view=net-maui-7.0) to `RightToLeft.`

{% tabs %}
{% highlight xaml %}

<inputLayout:SfTextInputLayout x:Name="inputLayout" 
                                FlowDirection="RightToLeft"
                                ContainerType="Outlined"
                                Hint="نام"
                                HelperText="نام درج کریں" >
        <Entry />
</inputLayout:SfTextInputLayout>

{% endhighlight %}
{% highlight c# %}

var inputLayout = new SfTextInputLayout();
inputLayout.FlowDirection = FlowDirection.RightToLeft;
inputLayout.ContainerType = ContainerType.Outlined;
inputLayout.Hint = "نام";
inputLayout.HelperText = " نام درج کریں";
inputLayout.Content = new Entry(); 

{% endhighlight %}
{% endtabs %}

![.NET MAUI TextInputLayout with right to left](images/RightToLeft/RTL.png)


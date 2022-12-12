---
layout: post
title: Right-to-Left in .NET MAUI Text Input Layout control | Syncfusion
description: Learn here all about Right-to-Left support in Syncfusion .NET MAUI Text Input Layout (SfTextInputLayout) control and more.
platform: maui
control: SfTextInputLayout
documentation: ug
---

# Right-to-Left in .NET MAUI Text Input Layout (SfTextInputLayout)

The TextInputLayout supports to change the flow of text to the right-to-left direction by setting the [FlowDirection](https://learn.microsoft.com/en-us/dotnet/api/microsoft.maui.controls.device.flowdirection?view=net-maui-7.0) to `RightToLeft`.

{% tabs %}
{% highlight xaml %}

<inputLayout:SfTextInputLayout x:Name="textinputlayout" 
                                FlowDirection="RightToLeft"
                                ContainerType="Outlined"
                                Hint="نام"
                                HelperText="نام درج کریں" >
        <Entry />
</inputLayout:SfTextInputLayout>

{% endhighlight %}
{% highlight c# %}

textinputlayout.FlowDirection = FlowDirection.RightToLeft;
textinputlayout.ContainerType = ContainerType.Outlined;
textinputlayout.Hint = "نام";
textinputlayout.HelperText = " نام درج کریں";
textinputlayout.Content = new Entry(); 

{% endhighlight %}
{% endtabs %}

![.NET MAUI TextInputLayout with right to left](images/RightToLeft/RTL.png)


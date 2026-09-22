---
layout: post
title: Right-to-Left in .NET MAUI DataForm | Syncfusion®
description: Learn about right-to-left (RTL) flow direction support in Syncfusion® .NET MAUI DataForm (SfDataForm) for language and cultural customization.
platform: maui
control: SfDataForm
documentation: ug
---

# Right-to-Left in .NET MAUI DataForm

The `SfDataForm` supports changing the flow direction of the text to the right-to-left direction by setting the `FlowDirection` to `RightToLeft`.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<ContentPage 
...
xmlns:dataForm="clr-namespace:Syncfusion.Maui.DataForm;assembly=Syncfusion.Maui.DataForm">
    <dataForm:SfDataForm
        x:Name="dataForm"
        FlowDirection="RightToLeft">
    </dataForm:SfDataForm>
</ContentPage>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

SfDataForm dataForm = new SfDataForm();
dataForm.FlowDirection = FlowDirection.RightToLeft;
this.Content = dataForm;

{% endhighlight %}
{% endtabs %}

![Right to left in .NET MAUI DataForm.](images/right-to-left/right-to-left.png)
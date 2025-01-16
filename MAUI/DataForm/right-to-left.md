---
layout: post
title: Right To Left FlowDirection in .NET MAUI DataForm control | Syncfusion<sup>&reg;</sup>
description: Learn about Right To Left support in Syncfusion<sup>&reg;</sup> .NET MAUI DataForm (SfDataForm) control in mobile and desktop applications from a single shared codebase
platform: maui
control: SfDataForm
documentation: ug
---

# Right To Left Flow Direction in .NET MAUI DataForm (SfDataForm)

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
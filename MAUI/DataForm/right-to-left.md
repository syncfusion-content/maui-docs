---
layout: post
title: Right-to-Left FlowDirection in .NET MAUI DataForm | Syncfusion®
description: Learn about Right-to-Left (RTL) support in Syncfusion® .NET MAUI DataForm (SfDataForm) for mobile and desktop apps using a shared codebase.
platform: maui
control: SfDataForm
documentation: ug
---

# Right-to-Left Flow Direction in .NET MAUI DataForm (SfDataForm)

The `SfDataForm` supports right-to-left text flow by setting the `FlowDirection` to `RightToLeft`.

{% tabs %}
{% highlight XAML tabtitle="MainPage.xaml" %}
<ContentPage 
...
xmlns:dataForm="clr-namespace:Syncfusion.Maui.DataForm;assembly=Syncfusion.Maui.DataForm">
    <dataForm:SfDataForm
        x:Name="dataForm"
        FlowDirection="RightToLeft">
    </dataForm:SfDataForm>
</ContentPage>

{% endhighlight %}
{% highlight C# tabtitle="MainPage.xaml.cs" %}

SfDataForm dataForm = new SfDataForm();
dataForm.FlowDirection = FlowDirection.RightToLeft;
this.Content = dataForm;

{% endhighlight %}
{% endtabs %}

![Right-to-left in .NET MAUI DataForm.](images/right-to-left/right-to-left.png)
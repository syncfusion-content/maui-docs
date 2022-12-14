---
layout: post
title: Right To Left in .NET MAUI DataForm control | Syncfusion
description: Learn here all about Right To Left support in Syncfusion .NET MAUI DataForm(SfDataForm) control and more.
platform: maui
control: SfDataForm
documentation: ug
---

# Right To Left in .NET MAUI DataForm (SfDataForm)

`SfDataForm` supports changing the flow of text to the right-to-left direction by setting the `FlowDirection` to `RightToLeft`

{% tabs %}
{% highlight XAML %}
<ContentPage 
...
             xmlns:dataForm="clr-namespace:Syncfusion.Maui.DataForm;assembly=Syncfusion.Maui.DataForm">
    <dataForm:SfDataForm
        x:Name="dataForm"
        FlowDirection="RightToLeft">
    </dataForm:SfDataForm>
</ContentPage>

{% endhighlight %}
{% highlight C# %}

this.dataForm.FlowDirection = FlowDirection.RightToLeft;

{% endhighlight %}
{% endtabs %}
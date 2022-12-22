---
layout: post
title: Right To Left FlowDirection in .NET MAUI DataForm control | Syncfusion
description: Learn about Right To Left support in Syncfusion .NET MAUI DataForm (SfDataForm) control in mobile and desktop applications from a single shared codebase
platform: maui
control: SfDataForm
documentation: ug
---

# Right To Left Flow Direction in .NET MAUI DataForm (SfDataForm)

`SfDataForm` supports changing the flow direction of text to the right-to-left direction by setting the `FlowDirection` to `RightToLeft`

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
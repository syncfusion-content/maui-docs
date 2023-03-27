---
layout: post
title: Right To Left FlowDirection in .NET MAUI DataForm control | Syncfusion
description: Learn about Right To Left support in Syncfusion .NET MAUI DataForm (SfDataForm) control in mobile and desktop applications from a single shared codebase
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
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="1 9 11" %}

using Syncfusion.Maui.DataForm;
. . .

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        SfDataForm dataForm = new SfDataForm();
        this.Content = dataForm;
        this.dataForm.FlowDirection = FlowDirection.RightToLeft;
    }
}

{% endhighlight %}
{% endtabs %}

![Right to left in .NET MAUI DataForm.](images/right-to-left/right-to-left.png)
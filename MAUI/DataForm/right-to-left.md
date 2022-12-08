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
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="4" %}

<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:DataForm="clr-namespace:Syncfusion.Maui.DataForm;assembly=Syncfusion.Maui.DataForm"             
             x:Class="CommitMode.MainPage">

    <DataForm:SfDataForm
        x:Name="DataForm"
        FlowDirection="RightToLeft"> 
    </DataForm:SfDataForm>
</ContentPage>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

this.DataForm.FlowDirection = FlowDirection.RightToLeft;

{% endhighlight %}
{% endtabs %}
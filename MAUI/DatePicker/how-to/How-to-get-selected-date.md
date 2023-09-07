---
layout: post
title: Selection changed event using Syncfusion DatePicker for .NET MAUI
description: Learn how to handle selection changed event with old and new values in syncfusion DatePicker for .NET MAUI (SfDatePicker)
platform: maui
control: SfDatePicker
documentation: ug
---

# How to handle date changed using the SelectionChanged event

You can perform an operation when selecting a date using the [`SelectionChanged`]() event. The [`SelectionChanged`]() event returns the following arguments:

<table>
<tr>
<th>Members</th>
<th>Description</th>
</tr>
<tr>
<td>NewValue</td>
<td>Shows recently selected date in DatePicker.</td>
</tr>
<tr>
<td>OldValue</td>
<td>Shows previously selected date in DatePicker.</td>
</tr>
</table>

{% tabs %}

{% highlight xaml %}

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:local="clr-namespace:DatePickerSample"
             xmlns:syncfusion="clr-namespace:Syncfusion.Maui.Picker;assembly=Syncfusion.Maui.Picker"
             x:Class="DatePickerSample.MainPage">
    <ContentPage.Content>
        <syncfusion:SfDatePicker x:Name="datepicker"
                                 SelectionChanged="Datepicker_SelectionChanged"/>
    </ContentPage.Content>
</ContentPage>

{% endhighlight %}

{% highlight c# %}  

using Syncfusion.Maui.Picker;

namespace DatePickerSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            SfDatePicker datePicker = new SfDatePicker();
            datePicker.SelectionChanged += Datepicker_SelectionChanged;
            this.Content = datePicker;
        }

        private void Datepicker_SelectionChanged(object sender, Syncfusion.Maui.Picker.DatePickerSelectionChangedEventArgs e)
        {
            DisplayAlert("DateChanged", "NewDate: " + e.NewValue + "\n" + "OldDate: " + e.OldValue, "Ok");
        }
    }
}

{% endhighlight %}

{% endtabs %}
---
layout: post
title: DatePicker Events in .NET MAUI DatePicker control | Syncfusion
description: Learn here all about DatePicker Events support in Syncfusion .NET MAUI Date Picker (SfDatePicker) control and more.
platform: maui
control: SfDatePicker
documentation: ug
---

# Events in .NET MAUI DatePicker (SfDatePicker)

Three events are used when the [`SfDatePicker`]() is in [`Dialog`]() mode.

 * [`Opened`]()
 * [`Closing`]()
 * [`Closed`]()

## Opened event

The [`Opened`]() event occurs when the DatePicker is opened. 

## Closing event 

The [`Closing`]() event occurs when the DatePicker closes.

Drop-down close can be restricted by setting `e.cancel` to true.

## Closed event

The [`Closed`]() event was triggered, after the DatePicker was closed.

{% tabs %}

{% highlight xaml %}

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:syncfusion="clr-namespace:Syncfusion.Maui.Picker;assembly=Syncfusion.Maui.Picker"
             x:Class="DatePickerSample.MainPage">    
     ...
    <syncfusion:SfDatePicker x:Name="datePicker" PickerMode="Dialog"
                                 Opened="SfDatePicker_Opened"
                                 Closing="SfDatePicker_Closing"
                                 Closed="SfDatePicker_Closed">           
    </datePicker:SfDatePicker>
    </ContentPage>

{% endhighlight %}

{% highlight C# %}
      
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            datePicker.Opened += SfDatePicker_Opened;
            datePicker.Closing += SfDatePicker_Closing;
            datePicker.Closed += SfDatePicker_Closed;
        }

        private void SfDatePicker_Opened(object sender, EventArgs e)
        {
        }

        private void SfDatePicker_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            //To restrict the datepicker get close, set e.Cancel to true.
            e.Cancel = true;
        }

        private void SfDatePicker_Closed(object sender, EventArgs e)
        {
        }
    }
    

{% endhighlight %}

{% endtabs %}



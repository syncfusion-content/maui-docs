---
layout: post
title: TimePicker Events in .NET MAUI TimePicker control | Syncfusion
description: Learn here all about TimePicker Events support in Syncfusion .NET MAUI Time Picker (SfTimePicker) control and more.
platform: maui
control: SfTimePicker
documentation: ug
---

# Events in .NET MAUI TimePicker (SfTimePicker)

Three events are used when the [`SfTimePicker`]() is in [`Dialog`]() mode.

 * [`Opened`]()
 * [`Closing`]()
 * [`Closed`]()

## Opened event

The [`Opened`]() event occurs when the TimePicker is opened. 

## Closing event 

The [`Closing`]() event occurs when the TimePicker closes.

Drop-down close can be restricted by setting `e.cancel` to true.

## Closed event

The [`Closed`]() event was triggered, after the TimePicker was closed.

{% tabs %}

{% highlight xaml %}

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:syncfusion="clr-namespace:Syncfusion.Maui.Picker;assembly=Syncfusion.Maui.Picker"
             x:Class="TimePickerSample.MainPage">    
     ...
    <syncfusion:SfTimePicker x:Name="TimePicker" PickerMode="Dialog"
                                 Opened="SfTimePicker_Opened"
                                 Closing="SfTimePicker_Closing"
                                 Closed="SfTimePicker_Closed">           
    </TimePicker:SfTimePicker>
    </ContentPage>

{% endhighlight %}

{% highlight C# %}
      
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            TimePicker.Opened += SfTimePicker_Opened;
            TimePicker.Closing += SfTimePicker_Closing;
            TimePicker.Closed += SfTimePicker_Closed;
        }

        private void SfTimePicker_Opened(object sender, EventArgs e)
        {
        }

        private void SfTimePicker_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            //To restrict the TimePicker get close, set e.Cancel to true.
            e.Cancel = true;
        }

        private void SfTimePicker_Closed(object sender, EventArgs e)
        {
        }
    }
    

{% endhighlight %}

{% endtabs %}
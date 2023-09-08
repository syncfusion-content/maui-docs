---
layout: post
title: Filtering in .NET MAUI ComboBox control | Syncfusion
description: Learn all about the events in the ComboBox (SfComboBox) control.
platform: maui
control: SfComboBox
documentation: ug
---

# Events in .NET MAUI ComboBox

## DropDownClosed Event

The `DropDownClosed` event occurs when the SfComboBox drop-down is closed.

{% tabs %}

{% highlight xaml %}

    <combobox:SfComboBox HeightRequest="40"
                             x:Name="comboBox"
                             DataSource="{Binding EmployeeCollection}"
                             DropDownClosed="SfComboBox_DropDownClosed"
                             />

{% endhighlight %}

{% highlight C# %}

     public MainPage()
     {
       InitializeComponent();
     }

     private void SfComboBox_DropDownClosed(object sender, EventArgs e)
     {
            // Invoke your desired action here
     }

{% endhighlight %}

{% endtabs %}


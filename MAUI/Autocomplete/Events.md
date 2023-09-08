---
layout: post
title: Filtering in .NET MAUI Autocomplete control | Syncfusion
description: Learn all about the events in the Autocomplete (SfAutocomplete) control.
platform: maui
control: SfAutocomplete
documentation: ug
---

# Events in .NET MAUI Autocomplete

## DropDownClosed Event

The `DropDownClosed` event occurs when the SfAutocomplete drop-down is closed.

{% tabs %}

{% highlight xaml %}

    <combobox:SfAutocomplete HeightRequest="40"
                             x:Name="comboBox"
                             DataSource="{Binding EmployeeCollection}"
                             DropDownClosed="SfAutocomplete_DropDownClosed"
                             />

{% endhighlight %}

{% highlight C# %}

     public MainPage()
     {
       InitializeComponent();
     }

     private void SfAutocomplete_DropDownClosed(object sender, EventArgs e)
     {
            // Invoke your desired action here
     }

{% endhighlight %}

{% endtabs %}


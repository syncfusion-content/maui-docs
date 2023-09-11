---
layout: post
title: Show a dialog using Syncfusion DatePicker for .NET MAUI
description: Learn how to show the DatePicker as dialog mode using button click in syncfusion DatePicker for .NET MAUI (SfDatePicker)
platform: maui
control: SfDatePicker
documentation: ug
---

# How to show as a Dialog in .NET MAUI DatePicker(SfDatePicker)

DatePicker can be rendered as a dialog by setting the [SfDatePicker.Mode]() property to [Dialog]() or [RelativeDialog](). The default value of [SfDatePicker.Mode]() property is ["Default"](). 

{% tabs %}

{% highlight xaml tabtitle="XAML" hl_lines="2" %}

<picker:SfDatePicker x:Name="DatePicker" IsOpen="True"
                        Mode="Dialog"/>

{% endhighlight %}

{% highlight c# tabtitle="C#" hl_lines="4" %}

SfDatePicker datePicker = new SfDatePicker()
{
    IsOpen = true,
    Mode = PickerMode.Dialog
};

this.Content = datePicker;

{% endhighlight %}

{% endtabs %}

The DatePicker can be opened programmatically by setting the [SfDatePicker.IsOpen]() property to true. Default value of [SfDatePicker.IsOpen]() is "false".

Note: This property is automatically changed to false when you close the dialog by clicking outside of the dialog.

{% tabs %}

{% highlight xaml tabtitle="MainPage.xaml" %}

<ContentPage>
    <Grid>
        <picker:SfDatePicker x:Name="datepicker"
                                Mode="Dialog"/>
        <Button Text="Open Picker" 
                x:Name="pickerButton"
                Clicked="Button_Clicked"
                HorizontalOptions="Center"
                VerticalOptions="Center"
                HeightRequest="50" 
                WidthRequest="100"/>
    </Grid>
</ContentPage>

{% endhighlight %}

{% highlight c# tabtitle="MainPage.xaml.cs" %}

namespace DatePickerSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, System.EventArgs e)
        {
            this.datepicker.IsOpen = true;
        }
    }
}

{% endhighlight %}

{% endtabs %}

# How to show as a Relative Dialog and customization position in .NET MAUI DatePicker(SfDatePicker)

DatePicker can be rendered as a relative dialog by setting the [SfDatePicker.Mode]() property to [RelativeDialog](). The default position of [RelativeDialog]() is [PickerRelativePosition.AlignTop]().

{% tabs %}

{% highlight xaml tabtitle="XAML" hl_lines="2" %}

<picker:SfDatePicker x:Name="datePicker"
                        IsOpen="True",
                        Mode="RelativeDialog"
                        RelativePosition="AlignBottom"/>

{% endhighlight %}

{% highlight c# tabtitle="C#" hl_lines="4" %}

SfDatePicker datePicker = new SfDatePicker()
{
    IsOpen = true,
    Mode = PickerMode.RelativeDialog,
    RelativePosition = PickerRelativePosition.AlignBottom,
};

this.Content = datePicker;

{% endhighlight %}

{% endtabs %}

## How to set an interval

### How to set an interval between days

DatePicker provides an option to give an interval between days using the [SfDatePicker.DayInterval]() property.

{% tabs %}

{% highlight xaml tabtitle="XAML" hl_lines="2" %}

<picker:SfDatePicker x:Name="datePicker" DayInterval="2"/>

{% endhighlight %}

{% highlight c# tabtitle="C#" hl_lines="4" %}  

SfDatePicker datePicker = new SfDatePicker()
{
    DayInterval = 2
};

this.Content = datePicker;

{% endhighlight %}

{% endtabs %}

### How to set an interval between months

DatePicker provides an option to give an interval between months using the [SfDatePicker.MonthInterval]() property.

{% tabs %}

{% highlight xaml tabtitle="XAML" hl_lines="2" %}

<picker:SfDatePicker x:Name="datePicker" MonthInterval="2"/>

{% endhighlight %}

{% highlight c# tabtitle="C#" hl_lines="4" %}  

SfDatePicker datePicker = new SfDatePicker()
{
    MonthInterval = 2
};

this.Content = datePicker;

{% endhighlight %}

{% endtabs %}

### How to set an interval between years

DatePicker provides an option to give an interval between years using the [SfDatePicker.YearInterval]() property.

{% tabs %}

{% highlight xaml tabtitle="XAML" hl_lines="2" %}

<picker:SfDatePicker x:Name="datePicker" YearInterval="2"/>

{% endhighlight %}

{% highlight c# tabtitle="C#" hl_lines="4" %}  

SfDatePicker datePicker = new SfDatePicker()
{
    YearInterval = 2
};

this.Content = datePicker;

{% endhighlight %}

{% endtabs %}
---
layout: post
title: Show a dialog using Syncfusion Date Picker for .NET MAUI
description: Learn how to show the date picker as dialog mode using button click in syncfusion Date Picker for .NET MAUI (SfDatePicker)
platform: maui
control: SfDatePicker
documentation: ug
---

# Mode in .NET MAUI Date Picker(SfDatePicker)

The Date Picker [Mode]() has the `Default`, `Dialog`, `RelativeDialog` in [.NET MAUI Date Picker]().

## Dialog Mode

DatePicker can be rendered as a dialog by setting the [Mode]() property to [Dialog]() of [SfDatePicker](). The default value of [Mode]() property is ["Default"]().

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

The DatePicker can be opened programmatically by setting the [IsOpen]() property of [SfDatePicker]() is true. The default value of [IsOpen]() of [SfDatePicker]() is "false".

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

## Relative Dialog Mode

DatePicker can be rendered as a relative dialog by setting the [Mode]() property to [RelativeDialog]() of [SfDatePicker](). The default position of [RelativeDialog]() is [PickerRelativePosition.AlignTop]().

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
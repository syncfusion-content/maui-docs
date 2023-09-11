---
layout: post
title: Mode using Syncfusion Time Picker for .NET MAUI
description: Learn how to show time picker as dialog using button and perform an operation while changing its time in Syncfusion Time Picker for .NET MAUI.
platform: maui
control: SfTimePicker
documentation: ug
---

# Mode in .NET MAUI Time Picker(SfTimePicker)

The Time Picker [Mode]() has the `Default`, `Dialog`, `RelativeDialog` in [.NET MAUI Time Picker]().

## Dialog mode

Time Picker can be rendered as a dialog by setting the [Mode]() property to [Dialog]() of [SfTimePicker](). The default value of the [Mode]() property is ["Default"](). 

{% tabs %}

{% highlight xaml tabtitle="XAML" hl_lines="2" %}

<picker:SfTimePicker x:Name="timePicker" IsOpen="True"
                        Mode="Dialog"/>

{% endhighlight %}

{% highlight c# tabtitle="C#" hl_lines="4" %}

SfTimePicker timePicker = new SfTimePicker()
{
    IsOpen = true,
    Mode = PickerMode.Dialog
};

this.Content = timePicker;

{% endhighlight %}

{% endtabs %}

The Time Picker can be opened programmatically by setting the [IsOpen]() property of [SfTimePicker]() is true. The default value of [IsOpen]() is "false".

Note: This property is automatically changed to false when you close the dialog by clicking outside of the dialog.

{% tabs %}

{% highlight xaml tabtitle="MainPage.xaml" %}

<ContentPage>
    <Grid>
        <picker:SfTimePicker x:Name="timePicker"
                                    Mode="Dialog"/>
        <Button Text="Open Picker" 
                x:Name="pickerButton"
                Clicked="Button_Clicked"
                HorizontalOptions="Center"
                VerticalOptions="Center"
                HeightRequest="50" 
                WidthRequest="100"/>
    </Grid>
</contentPage>

{% endhighlight %}

{% highlight c# tabtitle="MainPage.xaml.cs" %}

namespace TimePickerSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, System.EventArgs e)
        {
            this.timePicker.IsOpen = true;
        }
    }
}

{% endhighlight %}

{% endtabs %}

## Relative Dialog

Time Picker can be rendered as a relative dialog by setting the [Mode]() property to [RelativeDialog]() of [SfTimePicker](). The default position of [RelativeDialog]() is [PickerRelativePosition.AlignTop]().

{% tabs %}

{% highlight xaml  %}

<picker:SfTimePicker x:Name="timePicker" IsOpen="True"
                        Mode="RelativeDialog"
                        RelativePosition="AlignBottom"/>

{% endhighlight %}

{% highlight c# tabtitle="C#" hl_lines="4" %}

SfTimePicker timePicker = new SfTimePicker()
{
    IsOpen = true,
    Mode = PickerMode.RelativeDialog,
    RelativePosition = PickerRelativePosition.AlignBottom,
};

this.Content = timePicker;

{% endhighlight %}

{% endtabs %}
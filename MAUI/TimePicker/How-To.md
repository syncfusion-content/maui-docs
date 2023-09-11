---
layout: post
title: Events using Syncfusion TimePicker for .NET MAUI
description: Learn how to show TimePicker as dialog using button and perform an operation while changing its time in Syncfusion TimePicker for .NET MAUI.
platform: maui
control: SfTimePicker
documentation: ug
---

# How to show as a Dialog in .NET MAUI TimePicker(SfTimePicker)

TimePicker can be rendered as a dialog by setting the [SfTimePicker.Mode]() property to [Dialog]() or [RelativeDialog](). The Default value of the [SfTimePicker.Mode]() property is ["Default"](). 

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

The TimePicker can be opened programmatically by setting the [SfTimePicker.IsOpen]() property to true. Default value of [SfTimePicker.IsOpen]() is "false".

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

# How to show as a Relative Dialog and customization position in .NET MAUI TimePicker(SfTimePicker)

TimePicker can be rendered as a relative dialog by setting the [SfTimePicker.Mode]() property to [RelativeDialog](). The default position of [RelativeDialog]() is [PickerRelativePosition.AlignTop]().

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

## How to set an interval

### How to set an interval between hours

TimePicker provides an option to give an interval between hours using the [SfTimePicker.HourInterval]() property.

{% tabs %}

{% highlight xaml tabtitle="XAML" hl_lines="2" %}

<picker:SfTimePicker x:Name="timePicker" HourInterval="2"/>

{% endhighlight %}

{% highlight c# tabtitle="C#" hl_lines="4" %}  

SfTimePicker timePicker = new SfTimePicker()
{
    HourInterval = 2
};

this.Content = timePicker;

{% endhighlight %}

{% endtabs %}

### How to set an interval between minutes

TimePicker provides an option to give an interval between minutes using the [SfTimePicker.MinuteInterval]() property.

{% tabs %}

{% highlight xaml tabtitle="XAML" hl_lines="2" %}

<picker:SfTimePicker x:Name="timePicker" MinuteInterval="2"/>

{% endhighlight %}

{% highlight c# tabtitle="C#" hl_lines="4" %}  

SfTimePicker timePicker = new SfTimePicker()
{
    MinuteInterval = 2
};

this.Content = timePicker;

{% endhighlight %}

{% endtabs %}

### How to set an interval between seconds

TimePicker provides an option to give an interval between seconds using the [SfTimePicker.SecondInterval]() property.

{% tabs %}

{% highlight xaml tabtitle="XAML" hl_lines="2" %}

<picker:SfTimePicker x:Name="timePicker" SecondInterval="2"/>

{% endhighlight %}

{% highlight c# tabtitle="C#" hl_lines="4" %}  

SfTimePicker timePicker = new SfTimePicker()
{
    SecondInterval = 2
};

this.Content = timePicker;

{% endhighlight %}

{% endtabs %}

![TimeInterval]()
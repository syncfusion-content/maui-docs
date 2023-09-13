---
layout: post
title: Time Picker modes in .NET MAUI Time Picker | Syncfusion
description: Learn about the time picker modes in Syncfusion Time Picker for .NET MAUI (SfTimePicker) control and its basic features.
platform: maui
control: SfTimePicker
documentation: ug
---

# Time Picker mode in .NET MAUI Time Picker(SfTimePicker)

The Time picker mode is specified in the picker property enumeration, which is used to show the time picker based on the modes. It provides three modes such as `Default`, `Dialog`, and `RelativeDialog`. The default picker mode is `Default` in the [SfTimePicker].

## Dialog Mode

The dialog mode is used to show the time picker in a pop up by setting the [Mode] property to [`Dialog`] in [SfTimePicker].

{% tabs %}

{% highlight xaml tabtitle="XAML" hl_lines="2" %}

<picker:SfTimePicker x:Name="timePicker"
                     Mode="Dialog"/>

{% endhighlight %}

{% highlight c# tabtitle="C#" hl_lines="3" %}

SfTimePicker timePicker = new SfTimePicker()
{
    Mode = PickerMode.Dialog
};

this.Content = timePicker;

{% endhighlight %}

{% endtabs %}

The Time Picker can be opened programmatically by setting the [IsOpen] property to `true` of [SfTimePicker]. By default, the `IsOpen` property is `false`.

Note: This property is automatically changed to `false` when you close the dialog by clicking outside of the dialog.

{% tabs %}

{% highlight xaml tabtitle="MainPage.xaml" %}

<Grid>
    <picker:SfTimePicker x:Name="timepicker"
                         Mode="Dialog"/>
    <Button Text="Open Picker" 
            x:Name="pickerButton"
            Clicked="Button_Clicked"
            HorizontalOptions="Center"
            VerticalOptions="Center"
            HeightRequest="50" 
            WidthRequest="100">
    </Button>
</Grid>

{% endhighlight %}

{% highlight c# tabtitle="MainPage.xaml.cs" %}

private void Button_Clicked(object sender, System.EventArgs e)
{
    this.timepicker.IsOpen = true;
}

{% endhighlight %}

{% endtabs %}

## Relative Dialog Mode

The relative dialog mode is used to show the time picker in a pop up by setting the [Mode] property to [`RelativeDialog`]. It is used to align the picker in a specific position. You can set the position by setting the [RelativePosition] property in the [SfTimePicker].

The [RelativePosition] is specified in the picker property enumeration, which is used to align the picker in a specific position. It provides eight position such as `AlignTop`, `AlignToLeftOf`, `AlignToRightOf`, `AlignBottom`, `AlignTopLeft`, `AlignTopRight`, `AlignBottomLeft`, and `AlignBottomRight`. The default relative position is `AlignTop` in the [SfTimePicker].

{% tabs %}

{% highlight xaml tabtitle="XAML" hl_lines="2 3" %}

<picker:SfTimePicker x:Name="timePicker"
                     Mode="RelativeDialog"
                     RelativePosition="AlignBottom"/>

{% endhighlight %}

{% highlight c# tabtitle="C#" hl_lines="3 4" %}

SfTimePicker timePicker = new SfTimePicker()
{
    Mode = PickerMode.RelativeDialog,
    RelativePosition = PickerRelativePosition.AlignBottom,
};

this.Content = timePicker;

{% endhighlight %}

{% endtabs %}

The Time Picker can be opened programmatically by setting the [`IsOpen`] property to `true` of [SfTimePicker]. By default, the `IsOpen` property is `false`.

Note: This property is automatically changed to `false` when you close the dialog by clicking outside of the dialog.

{% tabs %}

{% highlight xaml tabtitle="MainPage.xaml"%}

<Grid>
    <picker:SfTimePicker x:Name="timePicker" 
                         Mode="RelativeDialog"
                         RelativePosition="AlignTopLeft">
    </picker:SfTimePicker>
    <Button Text="Open picker" 
            x:Name="pickerButton"
            Clicked="Button_Clicked"
            HorizontalOptions="Center"
            VerticalOptions="Center"
            HeightRequest="50" 
            WidthRequest="100">
    </Button>
</Grid>

{% endhighlight %}

{% highlight c# tabtitle="MainPage.xaml.cs"%}

private void Button_Clicked(object sender, System.EventArgs e)
{
    this.timepicker.IsOpen = true;
}

{% endhighlight %} 
 
{% endtabs %}
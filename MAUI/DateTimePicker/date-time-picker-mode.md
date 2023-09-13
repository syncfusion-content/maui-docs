---
layout: post
title: Date Time picker mode in .NET MAUI Date Time Picker control | Syncfusion
description: Learn about date time picker mode in Syncfusion .NET MAUI Date Time Picker (SfDateTimePicker) control and its basic features.
platform: maui
control: SfDateTimePicker
documentation: ug
---

# Date Time picker mode in .NET MAUI Date Time Picker (SfDateTimePicker)
The Date Time picker mode is specified in the picker property enumeration, which is used to show the date time picker based on the modes. It provides three modes such as `Default`, `Dialog` and `RelativeDialog`. The default picker mode is `Default` in the [SfDateTimePicker].


## Dialog mode

The dialog mode is used to show the date time picker in a pop up by setting the [Mode] property to [`Dialog`] in [SfDateTimePicker].

{% tabs %}
{% highlight xaml tabtitle="XAML" hl_lines="2" %}

<picker:SfDateTimePicker x:Name="Picker"
                         Mode="Dialog">
</picker:SfDateTimePicker>

{% endhighlight %}
{% highlight c# tabtitle="C#" hl_lines="2" %}

SfDateTimePicker picker = new SfDateTimePicker();
picker.Mode = PickerMode.Dialog;
this.Content = picker;

{% endhighlight %}  
{% endtabs %}

The Date Time picker can be opened programmatically by setting the [`IsOpen`] property to `true` of [SfDateTimePicker]. By default, the `IsOpen` property is `false`.

Note: This property is automatically changed to `false` when you close the dialog by clicking outside of the dialog.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml"%}

<Grid>
    <picker:SfDateTimePicker x:Name="Picker" 
                             Mode="Dialog">
    </picker:SfDateTimePicker>
    <Button Text="Open Date Time picker" 
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

private void Button_Clicked(object sender, EventArgs e)
{
    this.Picker.IsOpen = true;
}

{% endhighlight %}  
{% endtabs %}

## Relative dialog mode

The relative dialog mode is used to show the date time picker in a pop up by setting the [Mode] property to [`RelativeDialog`]. It is used to align the picker in a specific position. You can set the position by setting the [RelativePosition] property in the [SfDateTimePicker].

The [RelativePosition] is specified in the picker property enumeration, which is used to align the picker in a specific position. It provides eight position such as `AlignTop`, `AlignToLeftOf`, `AlignToRightOf`, `AlignBottom`, `AlignTopLeft`, `AlignTopRight`, `AlignBottomLeft`, and `AlignBottomRight`. The default relative position is `AlignTop` in the [SfDateTimePicker].

{% tabs %}
{% highlight xaml tabtitle="XAML" hl_lines="2 3" %}

<picker:SfDateTimePicker x:Name="Picker"
                         Mode="RelativeDialog"
                         RelativePosition="AlignTopLeft">
</picker:SfDateTimePicker>

{% endhighlight %}
{% highlight c# tabtitle="C#" hl_lines="2 3" %}

SfDateTimePicker picker = new SfDateTimePicker();
picker.Mode = PickerMode.RelativeDialog;
this.Picker.RelativePosition = PickerRelativePosition.AlignTopLeft;
this.Content = picker;

{% endhighlight %}  
{% endtabs %}

The Date Time picker can be opened programmatically by setting the [`IsOpen`] property to `true` of [SfDateTimePicker]. By default, the `IsOpen` property is `false`.

Note: This property is automatically changed to `false` when you close the dialog by clicking outside of the dialog.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml"%}

<Grid>
    <picker:SfDateTimePicker x:Name="Picker" 
                             Mode="RelativeDialog"
                             RelativePosition="AlignTopLeft">
    </picker:SfDateTimePicker>
    <Button Text="Open Date Time picker" 
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

private void Button_Clicked(object sender, EventArgs e)
{
    this.Picker.IsOpen = true;
}

{% endhighlight %}  
{% endtabs %}
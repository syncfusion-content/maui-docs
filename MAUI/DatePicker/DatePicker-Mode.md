---
layout: post
title: Date Picker modes in .NET MAUI Date Picker | Syncfusion
description: Learn about the date picker modes in Syncfusion Date Picker for .NET MAUI (SfDatePicker) control and its features.
platform: maui
control: SfDatePicker
documentation: ug
---

# Date Picker mode in .NET MAUI Date Picker(SfDatePicker)

The date picker mode is specified in the picker property enumeration, which is used to show the date picker based on the modes. It provides three modes such as `Default`, `Dialog` and `RelativeDialog`. The default picker mode is `Default` in the [SfDatePicker]().

## Dialog Mode

The dialog mode is used to show the date picker in a pop up by setting the [Mode]() property to [`Dialog`]() in [SfDatePicker]().

{% tabs %}

{% highlight xaml tabtitle="XAML" hl_lines="2" %}

<picker:SfDatePicker x:Name="DatePicker"
                        Mode="Dialog"/>

{% endhighlight %}

{% highlight c# tabtitle="C#" hl_lines="2" %}

SfDatePicker datePicker = new SfDatePicker()
{
    Mode = PickerMode.Dialog
};

this.Content = datePicker;

{% endhighlight %}

{% endtabs %}

The Date Picker can be opened programmatically by setting the [IsOpen]() property to true of [SfDatePicker](). By default, the `IsOpen` property is "false".

Note: This property is automatically changed to false when you close the dialog by clicking outside of the dialog.

{% tabs %}

{% highlight xaml tabtitle="MainPage.xaml" %}

<Grid>
    <picker:SfDatePicker x:Name="datepicker"
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

The relative dialog mode is used to show the date picker in a pop up by setting the [Mode]() property to [`RelativeDialog`](). It is used to align the picker in a specific position. You can set the position by setting the [RelativePosition]() property in the [SfDatePicker]().

The [RelativePosition]() is specified in the picker property enumeration, which is used to align the picker in a specific position. It provides eight position such as `AlignTop`, `AlignToLeftOf`, `AlignToRightOf`, `AlignBottom`, `AlignTopLeft`, `AlignTopRight`, `AlignBottomLeft` and `AlignBottomRight`. The default relative position is `AlignTop` in the [SfDatePicker]().

{% tabs %}

{% highlight xaml tabtitle="XAML" hl_lines="2" %}

<picker:SfDatePicker x:Name="datePicker"
                        Mode="RelativeDialog"
                        RelativePosition="AlignBottom"/>

{% endhighlight %}

{% highlight c# tabtitle="C#" hl_lines="2" %}

SfDatePicker datePicker = new SfDatePicker()
{
    Mode = PickerMode.RelativeDialog,
    RelativePosition = PickerRelativePosition.AlignBottom,
};

this.Content = datePicker;

{% endhighlight %}

{% endtabs %}

The Date Picker can be opened programmatically by setting the [`IsOpen`]() property to true of [SfDatePicker](). By default, the `IsOpen` property is "false".

Note: This property is automatically changed to false when you close the dialog by clicking outside of the dialog.

{% tabs %}

{% highlight xaml tabtitle="MainPage.xaml"%}

<Grid>
    <picker:SfDatePicker x:Name="datePicker" 
                             Mode="RelativeDialog"
                             RelativePosition="AlignTopLeft">
    </picker:SfDatePicker>
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
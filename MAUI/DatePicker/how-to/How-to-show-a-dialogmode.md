---
layout: post
title: Show a dialog using Syncfusion DatePicker for .NET MAUI
description: Learn how to show the DatePicker as dialog mode using button click in syncfusion DatePicker for .NET MAUI (SfDatePicker)
platform: maui
control: SfDatePicker
documentation: ug
---

# How to show as a Dialog in .NET MAUI DatePicker(SfPicker)

DatePicker can be rendered as a dialog by setting the [`SfDatePicker.Mode`]() property to [`Dialog`]() or [`RelativeDialog`](). The default value of [`SfDatePicker.Mode`]() property is [`"Default"`](). 

{% tabs %}

{% highlight xaml %}

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:local="clr-namespace:DatePickerSample"
             xmlns:syncfusion="clr-namespace:Syncfusion.Maui.Picker;assembly=Syncfusion.Maui.Picker"
             x:Class="DatePickerSample.MainPage">
    <ContentPage.Content>
        <syncfusion:SfDatePicker x:Name="DatePicker"
                                Mode="Dialog"/>
    </ContentPage.Content>
</ContentPage>

{% endhighlight %}

{% highlight c# %}

using Syncfusion.Maui.Picker;

namespace DatePickerSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            SfDatePicker datePicker = new SfDatePicker()
            {
                Mode = PickerMode.Dialog
            };

            this.Content = datePicker;
        }
    }
}

{% endhighlight %}

{% endtabs %}

The DatePicker can be opened programmatically by setting the [`SfDatePicker.IsOpen`]() property to true. Default value of [`SfDatePicker.IsOpen`]() is "false".

Note: This property is automatically changed to false when you close the dialog by clicking outside of the dialog.

{% tabs %}

{% highlight xaml %}

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:local="clr-namespace:DatePickerSample"
             xmlns:syncfusion="clr-namespace:Syncfusion.Maui.Picker;assembly=Syncfusion.Maui.Picker"
             x:Class="DatePickerSample.MainPage">
    <ContentPage.Content>
        <Grid>
        <syncfusion:SfDatePicker x:Name="datepicker"
                                Mode="Dialog"/>
        <Button Text="Open Picker" 
                x:Name="pickerButton"
                Clicked="Button_Clicked"
                HorizontalOptions="Center"
                VerticalOptions="Center"
                HeightRequest="50" 
                WidthRequest="100"/>
        </Grid>
    </ContentPage.Content>
</ContentPage>

{% endhighlight %}

{% highlight c# %}

using Syncfusion.Maui.Picker;

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
            datepicker.IsOpen = true;
        }
    }
}

{% endhighlight %}

{% endtabs %}

# How to show as a Relative Dialog and customization position in .NET MAUI DatePicker(SfDatePicker)

DatePicker can be rendered as a relative dialog by setting the [`SfDatePicker.Mode`]() property to [`RelativeDialog`](). The default position of [`RelativeDialog`]() is [`PickerRelativePosition.AlignTop`]().

{% tabs %}

{% highlight xaml %}

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:local="clr-namespace:DatePickerSample"
             xmlns:syncfusion="clr-namespace:Syncfusion.Maui.Picker;assembly=Syncfusion.Maui.Picker"
             x:Class="DatePickerSample.MainPage">
    <ContentPage.Content>
        <syncfusion:SfDatePicker x:Name="datePicker"
                                Mode="RelativeDialog"
                                RelativePosition="AlignBottom"/>
    </ContentPage.Content>
</ContentPage>

{% endhighlight %}

{% highlight c# %}

using Syncfusion.Maui.Picker;

namespace DatePickerSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            SfDatePicker datePicker = new SfDatePicker()
            {
                Mode = PickerMode.RelativeDialog,
                RelativePosition = PickerRelativePosition.AlignBottom,
            };

            this.Content = datePicker;
        }
    }
}

{% endhighlight %}

{% endtabs %}
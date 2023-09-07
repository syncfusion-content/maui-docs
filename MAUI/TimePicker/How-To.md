---
layout: post
title: Events using Syncfusion TimePicker for .NET MAUI
description: Learn how to show TimePicker as dialog using button and perform an operation while changing its time in Syncfusion TimePicker for .NET MAUI.
platform: maui
control: SfTimePicker
documentation: ug
---

# How to section in .NET MAUI TimePicker

## How to show as a Dialog

TimePicker can be rendered as a dialog by setting the [`SfTimePicker.Mode`]() property to Dialog or [`RelativeDialog`](). Default value of the [`SfTimePicker.Mode`]() property is "Default". 

{% tabs %}

{% highlight xaml %}

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:local="clr-namespace:TimePickerSample"
             xmlns:syncfusion="clr-namespace:Syncfusion.Maui.Picker;assembly=Syncfusion.Maui.Picker"
             x:Class="TimePickerSample.MainPage">
    <ContentPage.Content>
        <syncfusion:SfTimePicker x:Name="timePicker"
                                 Mode="Dialog"/>
    </ContentPage.Content>
</ContentPage>

{% endhighlight %}

{% highlight c# %}

using Syncfusion.Maui.Picker;

namespace TimePickerSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            SfTimePicker timePicker = new SfTimePicker()
            {
                Mode = PickerMode.Dialog
            };

            this.Content = timePicker;
        }
    }
}

{% endhighlight %}

{% endtabs %}

The TimePicker can be opened programmatically by setting the [`SfTimePicker.IsOpen`]() property to true. Default value of [`SfTimePicker.IsOpen`]() is "false".

Note: This property is automatically changed to false when you close the dialog by clicking outside of the dialog.

{% tabs %}

{% highlight xaml %}

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:local="clr-namespace:TimePickerSample"
             xmlns:syncfusion="clr-namespace:Syncfusion.Maui.Picker;assembly=Syncfusion.Maui.Picker"
             x:Class="TimePickerSample.MainPage">
    <ContentPage.Content>
        <Grid>
        <syncfusion:SfTimePicker x:Name="timePicker"
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
            timePicker.IsOpen = true;
        }
    }
}

{% endhighlight %}

{% endtabs %}

# How to show as a Relative Dialog and customization position in .NET MAUI TimePicker(SfTimePicker)

TimePicker can be rendered as a relative dialog by setting the [`SfTimePicker.Mode`]() property to [`RelativeDialog`](). The default position of [`RelativeDialog`]() is [`PickerRelativePosition.AlignTop`]().

{% tabs %}

{% highlight xaml %}

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:local="clr-namespace:TimePickerSample"
             xmlns:syncfusion="clr-namespace:Syncfusion.Maui.Picker;assembly=Syncfusion.Maui.Picker"
             x:Class="TimePickerSample.MainPage">
    <ContentPage.Content>
        <syncfusion:SfTimePicker x:Name="timePicker"
                                Mode="RelativeDialog"
                                RelativePosition="AlignBottom"/>
    </ContentPage.Content>
</ContentPage>

{% endhighlight %}

{% highlight c# %}

using Syncfusion.Maui.Picker;

namespace TimePickerSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            SfTimePicker timePicker = new SfTimePicker()
            {
                Mode = PickerMode.RelativeDialog,
                RelativePosition = PickerRelativePosition.AlignBottom,
            };

            this.Content = timePicker;
        }
    }
}

{% endhighlight %}

{% endtabs %}

## How to handle time changed using the SelectionChanged event

You can perform an operation when selecting time using the [`SelectionChanged`]() event. The SelectionChanged event returns the following arguments:

<table>
<tr>
<th>Members</th>
<th>Description</th>
</tr>
<tr>
<td>NewValue</td>
<td>Shows recently selected time in TimePicker.</td>
</tr>
<tr>
<td>OldValue</td>
<td>Shows previously selected time in TimePicker.</td>
</tr>
</table>

{% tabs %}

{% highlight xaml %}

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:local="clr-namespace:TimePickerSample"
             xmlns:syncfusion="clr-namespace:Syncfusion.Maui.Picker;assembly=Syncfusion.Maui.Picker"
             x:Class="TimePickerSample.MainPage">
    <ContentPage.Content>
        <syncfusion:SfTimePicker x:Name="timePicker"
                                 SelectionChanged="TimePicker_SelectionChanged"/>
    </ContentPage.Content>
</ContentPage>

{% endhighlight %}

{% highlight c# %}  

using Syncfusion.Maui.Picker;

namespace TimePickerSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            SfTimePicker timePicker = new SfTimePicker();
            timePicker.SelectionChanged += TimePicker_SelectionChanged;
            this.Content = timePicker;
        }

        private void TimePicker_SelectionChanged(object sender, TimePickerSelectionChangedEventArgs e)
        {
           DisplayAlert("TimeChanged", "NewValue: " + e.NewValue + "\n" + "OldValue: " + e.OldValue, "Ok");
        }
    }
}

{% endhighlight %}

{% endtabs %}

![Event]()

## How to set an interval

### How to set an interval between hours

TimePicker provides an option to give an interval between hours using the [`SfTimePicker.HourInterval`]() property.

{% tabs %}

{% highlight xaml %}

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:local="clr-namespace:TimePickerSample"
             xmlns:syncfusion="clr-namespace:Syncfusion.Maui.Picker;assembly=Syncfusion.Maui.Picker"
             x:Class="TimePickerSample.MainPage">
    <ContentPage.Content>
        <syncfusion:SfTimePicker x:Name="timePicker"
                                 HourInterval="2"/>
    </ContentPage.Content>
</ContentPage>

{% endhighlight %}

{% highlight c# %}  

using Syncfusion.Maui.Picker;

namespace TimePickerSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            SfTimePicker timePicker = new SfTimePicker()
            {
                HourInterval = 2
            };

            this.Content = timePicker;
        }
    }
}

{% endhighlight %}

{% endtabs %}

### How to set an interval between minutes

TimePicker provides an option to give an interval between minutes using the [`SfTimePicker.MinuteInterval`]() property.

{% tabs %}

{% highlight xaml %}

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:local="clr-namespace:TimePickerSample"
             xmlns:syncfusion="clr-namespace:Syncfusion.Maui.Picker;assembly=Syncfusion.Maui.Picker"
             x:Class="TimePickerSample.MainPage">
    <ContentPage.Content>
        <syncfusion:SfTimePicker x:Name="timePicker"
                                 MinuteInterval="2"/>
    </ContentPage.Content>
</ContentPage>

{% endhighlight %}

{% highlight c# %}  

using Syncfusion.Maui.Picker;

namespace TimePickerSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            SfTimePicker timePicker = new SfTimePicker()
            {
                MinuteInterval = 2
            };

            this.Content = timePicker;
        }
    }
}

{% endhighlight %}

{% endtabs %}

### How to set an interval between seconds

TimePicker provides an option to give an interval between seconds using the [`SfTimePicker.SecondInterval`]() property.

{% tabs %}

{% highlight xaml %}

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:local="clr-namespace:TimePickerSample"
             xmlns:syncfusion="clr-namespace:Syncfusion.Maui.Picker;assembly=Syncfusion.Maui.Picker"
             x:Class="TimePickerSample.MainPage">
    <ContentPage.Content>
        <syncfusion:SfTimePicker x:Name="timePicker"
                                 SecondInterval="2"/>
    </ContentPage.Content>
</ContentPage>

{% endhighlight %}

{% highlight c# %}  

using Syncfusion.Maui.Picker;

namespace TimePickerSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            SfTimePicker timePicker = new SfTimePicker()
            {
                SecondInterval = 2
            };

            this.Content = timePicker;
        }
    }
}

{% endhighlight %}

{% endtabs %}

![TimeInterval]()
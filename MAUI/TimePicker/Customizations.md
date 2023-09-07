---
layout: post
title: Customizations in .NET MAUI TimePicker control | Syncfusion
description: Learn here all about Customizations support in Syncfusion .NET MAUI TimePicker (SfTimePicker) control and more.
platform: maui
control: SfTimePicker
documentation: ug
---

# Customizations in .NET MAUI TimePicker (SfTimePicker)

You can customize the header, column header, footer, selected item of the [`SfTimePicker`]().

## Header customization

[`SfTimePicker`]() allows customizing the header's background, text color, and fonts.

### Set header text

[`SfTimePicker`]() allows providing custom text to its header by setting the [`SfTimePicker.HeaderView`]() property.

{% tabs %}

{% highlight xaml %}

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:local="clr-namespace:TimePickerSample"
             xmlns:syncfusion="clr-namespace:Syncfusion.Maui.Picker;assembly=Syncfusion.Maui.Picker"
             x:Class="TimePickerSample.MainPage">
    <ContentPage.Content>
        <syncfusion:SfTimePicker x:Name="TimePicker" >
            <syncfusion:SfTimePicker.HeaderView >
                <syncfusion:PickerHeaderView Height="40" Text="Time Picker"/>
            </syncfusion:SfTimePicker.HeaderView>
        </syncfusion.SfTimePicker>
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
            timePicker.HeaderView = new PickerHeaderView()
            {
                Height = 40,
                Text = "Time Picker"
            };

            this.Content = timePicker;
        }
    }
}

{% endhighlight %}

{% endtabs %}

### Background

Background color of the header can be customized by setting the [`SfTimePicker.HeaderView`]() property.

{% tabs %}

{% highlight xaml %}

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:local="clr-namespace:TimePickerSample"
             xmlns:syncfusion="clr-namespace:Syncfusion.Maui.Picker;assembly=Syncfusion.Maui.Picker"
             x:Class="TimePickerSample.MainPage">
    <ContentPage.Content>
        <syncfusion:SfTimePicker x:Name="TimePicker" >
            <syncfusion:SfTimePicker.HeaderView >
                <syncfusion:PickerHeaderView Height="40" Text="Time Picker" Background="Orange"/>
            </syncfusion:SfTimePicker.HeaderView>
        </syncfusion.SfTimePicker>
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
            timePicker.HeaderView = new PickerHeaderView()
            {
                Height = 40,
                Text = "Time Picker",
                Background = Colors.Orange,
            };

            this.Content = timePicker;
        }
    }
}

{% endhighlight %}

{% endtabs %}

### Divider Color

Divider color of the header can be customized by setting the [`SfTimePicker.HeaderView`]() property.

{% tabs %}

{% highlight xaml %}

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:local="clr-namespace:TimePickerSample"
             xmlns:syncfusion="clr-namespace:Syncfusion.Maui.Picker;assembly=Syncfusion.Maui.Picker"
             x:Class="TimePickerSample.MainPage">
    <ContentPage.Content>
        <syncfusion:SfTimePicker x:Name="TimePicker" >
            <syncfusion:SfTimePicker.HeaderView >
                <syncfusion:PickerHeaderView Height="40" Text="Time Picker" DividerColor="Blue"/>
            </syncfusion:SfTimePicker.HeaderView>
        </syncfusion.SfTimePicker>
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
            timePicker.HeaderView = new PickerHeaderView()
            {
                Height = 40,
                Text = "Time Picker",
                DividerColor = Colors.Blue,
            };

            this.Content = timePicker;
        }
    }
}

{% endhighlight %}

{% endtabs %}

### Text color 

Text color of the header can be customized by setting the [`SfTimePicker.HeaderView`]() property.

{% tabs %}

{% highlight xaml %}

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:local="clr-namespace:TimePickerSample"
             xmlns:syncfusion="clr-namespace:Syncfusion.Maui.Picker;assembly=Syncfusion.Maui.Picker"
             x:Class="TimePickerSample.MainPage">
    <ContentPage.Content>
        <syncfusion:SfTimePicker x:Name="TimePicker" >
            <syncfusion:SfTimePicker.HeaderView >
                <syncfusion:PickerHeaderView Height="40" Text="Time Picker" >
                    <syncfusion:PickerHeaderView.TextStyle >
                        <syncfusion:PickerTextStyle TextColor="Violet" />
                    </syncfusion:PickerHeaderView.TextStyle>
                </syncfusion:PickerHeaderView>
            </syncfusion:SfTimePicker.HeaderView>
        </syncfusion.SfTimePicker>
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
            timePicker.HeaderView = new PickerHeaderView()
            {
                Height = 40,
                Text = "Time Picker",
                TextStyle = new PickerTextStyle()
                {
                    TextColor = Colors.Violet,
                }
            };

            this.Content = timePicker;
        }
    }
}

{% endhighlight %}

{% endtabs %}

### Font 

This section explains the Font customization of header text.

#### FontFamily

FontFamily of the header text can be customized by setting the [`SfTimePicker.HeaderView`]() property.

{% tabs %}

{% highlight xaml %}

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:local="clr-namespace:TimePickerSample"
             xmlns:syncfusion="clr-namespace:Syncfusion.Maui.Picker;assembly=Syncfusion.Maui.Picker"
             x:Class="TimePickerSample.MainPage">
    <ContentPage.Content>
        <syncfusion:SfTimePicker x:Name="TimePicker" >
            <syncfusion:SfTimePicker.HeaderView >
                <syncfusion:PickerHeaderView Height="40" Text="Time Picker" >
                    <syncfusion:PickerHeaderView.TextStyle >
                        <syncfusion:PickerTextStyle FontFamily="Times New Roman" />
                    </syncfusion:PickerHeaderView.TextStyle>
                </syncfusion:PickerHeaderView>
            </syncfusion:SfTimePicker.HeaderView>
        </syncfusion.SfTimePicker>
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
            timePicker.HeaderView = new PickerHeaderView()
            {
                Height = 40,
                Text = "Time Picker",
                TextStyle = new PickerTextStyle()
                {
                    FontFamily = "Times New Roman",
                }
            };

            this.Content = timePicker;
        }
    }
}

{% endhighlight %}

{% endtabs %}

#### FontSize

FontSize of the header text can be customized by setting the [`SfTimePicker.HeaderView`]() property.

{% tabs %}

{% highlight xaml %}

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:local="clr-namespace:TimePickerSample"
             xmlns:syncfusion="clr-namespace:Syncfusion.Maui.Picker;assembly=Syncfusion.Maui.Picker"
             x:Class="TimePickerSample.MainPage">
    <ContentPage.Content>
        <syncfusion:SfTimePicker x:Name="TimePicker" >
            <syncfusion:SfTimePicker.HeaderView >
                <syncfusion:PickerHeaderView Height="40" Text="Time Picker" >
                    <syncfusion:PickerHeaderView.TextStyle >
                        <syncfusion:PickerTextStyle FontSize="12" />
                    </syncfusion:PickerHeaderView.TextStyle>
                </syncfusion:PickerHeaderView>
            </syncfusion:SfTimePicker.HeaderView>
        </syncfusion.SfTimePicker>
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
            timePicker.HeaderView = new PickerHeaderView()
            {
                Height = 40,
                Text = "Time Picker",
                TextStyle = new PickerTextStyle()
                {
                    FontSize = 12,
                }
            };

            this.Content = timePicker;
        }
    }
}

{% endhighlight %}

{% endtabs %}   

#### FontAttribute

FontAttribute of the header text can be customized by setting the [`SfTimePicker.HeaderView`]() property.

{% tabs %}

{% highlight xaml %}

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:local="clr-namespace:TimePickerSample"
             xmlns:syncfusion="clr-namespace:Syncfusion.Maui.Picker;assembly=Syncfusion.Maui.Picker"
             x:Class="TimePickerSample.MainPage">
    <ContentPage.Content>
        <syncfusion:SfTimePicker x:Name="TimePicker" >
            <syncfusion:SfTimePicker.HeaderView >
                <syncfusion:PickerHeaderView Height="40" Text="Time Picker" >
                    <syncfusion:PickerHeaderView.TextStyle >
                        <syncfusion:PickerTextStyle FontAttributes="Italic" />
                    </syncfusion:PickerHeaderView.TextStyle>
                </syncfusion:PickerHeaderView>
            </syncfusion:SfTimePicker.HeaderView>
        </syncfusion.SfTimePicker>
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
            timePicker.HeaderView = new PickerHeaderView()
            {
                Height = 40,
                Text = "Time Picker",
                TextStyle = new PickerTextStyle()
                {
                    FontAttributes = FontAttributes.Italic,
                }
            };

            this.Content = timePicker;
        }
    }
}

{% endhighlight %}

{% endtabs %}

## Column header customization

[`SfTimePicker`]() allows customizing the column header's background, text color, and fonts.

### Set custom column header 

[`SfTimePicker`]() allows providing custom text to its column header by setting the [`SfTimePicker.ColumnHeaderView`](). And its contain [`ColumnHeaderView.HourHeaderText`]() [`ColumnHeaderView.MinuteHeaderText`](), and [`ColumnHeaderView.SecondHeaderText`]() properties. Default value of [`ColumnHeaderView.HourHeaderText`]() property is "Hour", [`ColumnHeaderView.MinuteHeaderText`]() is "Minute", and [`ColumnHeaderView.SecondHeaderText`]() is "Second".

{% tabs %}

{% highlight xaml %}

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:local="clr-namespace:TimePickerSample"
             xmlns:syncfusion="clr-namespace:Syncfusion.Maui.Picker;assembly=Syncfusion.Maui.Picker"
             x:Class="TimePickerSample.MainPage">
    <ContentPage.Content>
        <syncfusion:SfTimePicker x:Name="TimePicker" >
            <syncfusion:SfTimePicker.ColumnHeaderView >
                <syncfusion:TimePickerColumnHeaderView HourHeaderText="Hour Column"
                                                        MinuteHeaderText="Minute Column"
                                                        SecondHeaderText="Second Column"/>
            </syncfusion:SfTimePicker.ColumnHeaderView>
        </syncfusion.SfTimePicker>
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
            timePicker.ColumnHeaderView = new TimePickerColumnHeaderView()
            {
                HourHeaderText = "Hour Column",
                MinuteHeaderText = "Minute Column",
                SecondHeaderText = "Second Column"
            };

            this.Content = timePicker;
        }
    }
}

{% endhighlight %}

{% endtabs %}

### Background

Background color of the column header can be customized by setting the [`SfTimePicker.ColumnHeaderView`]() property.

{% tabs %}

{% highlight xaml %}

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:local="clr-namespace:TimePickerSample"
             xmlns:syncfusion="clr-namespace:Syncfusion.Maui.Picker;assembly=Syncfusion.Maui.Picker"
             x:Class="TimePickerSample.MainPage">
    <ContentPage.Content>
        <syncfusion:SfTimePicker x:Name="TimePicker" >
            <syncfusion:SfTimePicker.ColumnHeaderView >
                <syncfusion:TimePickerColumnHeaderView Background="Orange"/>
            </syncfusion:SfTimePicker.ColumnHeaderView>
        </syncfusion.SfTimePicker>
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
            timePicker.ColumnHeaderView = new TimePickerColumnHeaderView()
            {
                Background = Colors.Orange,
            };

            this.Content = timePicker;
        }
    }
}

{% endhighlight %}

{% endtabs %}

### Divider Color

Divider color of the column header can be customized by setting the [`SfTimePicker.ColumnHeaderView`]() property.

{% tabs %}

{% highlight xaml %}

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:local="clr-namespace:TimePickerSample"
             xmlns:syncfusion="clr-namespace:Syncfusion.Maui.Picker;assembly=Syncfusion.Maui.Picker"
             x:Class="TimePickerSample.MainPage">
    <ContentPage.Content>
        <syncfusion:SfTimePicker x:Name="TimePicker" >
            <syncfusion:SfTimePicker.ColumnHeaderView >
                <syncfusion:TimePickerColumnHeaderView DividerColor="Blue"/>
            </syncfusion:SfTimePicker.ColumnHeaderView>
        </syncfusion.SfTimePicker>
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
            timePicker.ColumnHeaderView = new TimePickerColumnHeaderView()
            {
                DividerColor = Colors.Blue,
            };

            this.Content = timePicker;
        }
    }
}

{% endhighlight %}

{% endtabs %}

### Text color 

Text color of the column header can be customized by setting the [`SfTimePicker.ColumnHeaderView`]() property.

{% tabs %}

{% highlight xaml %}

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:local="clr-namespace:TimePickerSample"
             xmlns:syncfusion="clr-namespace:Syncfusion.Maui.Picker;assembly=Syncfusion.Maui.Picker"
             x:Class="TimePickerSample.MainPage">
    <ContentPage.Content>
        <syncfusion:SfTimePicker x:Name="TimePicker" >
            <syncfusion:SfTimePicker.ColumnHeaderView >
                <syncfusion:TimePickerColumnHeaderView >
                    <syncfusion:TimePickerColumnHeaderView.TextStyle >
                        <syncfusion:PickerTextStyle TextColor="Violet"/>
                    </syncfusion:TimePickerColumnHeaderView.TextStyle>
                </syncfusion:TimePickerColumnHeaderView>
            </syncfusion:SfTimePicker.ColumnHeaderView>
        </syncfusion.SfTimePicker>
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
            timePicker.ColumnHeaderView = new TimePickerColumnHeaderView()
            {
                TextStyle = new PickerTextStyle()
                {
                    TextColor = Colors.Violet,
                }
            };

            this.Content = timePicker;
        }
    }
}

{% endhighlight %}

{% endtabs %}

### Font 

This section explains the Font customization of column header text.

#### FontFamily

FontFamily of the column header text can be customized by setting the [`SfTimePicker.ColumnHeaderView`]() property.

{% tabs %}

{% highlight xaml %}

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:local="clr-namespace:TimePickerSample"
             xmlns:syncfusion="clr-namespace:Syncfusion.Maui.Picker;assembly=Syncfusion.Maui.Picker"
             x:Class="TimePickerSample.MainPage">
    <ContentPage.Content>
        <syncfusion:SfTimePicker x:Name="TimePicker" >
            <syncfusion:SfTimePicker.ColumnHeaderView >
                <syncfusion:TimePickerColumnHeaderView >
                    <syncfusion:TimePickerColumnHeaderView.TextStyle >
                        <syncfusion:PickerTextStyle FontFamily="Times New Roman"/>
                    </syncfusion:TimePickerColumnHeaderView.TextStyle>
                </syncfusion:TimePickerColumnHeaderView>
            </syncfusion:SfTimePicker.ColumnHeaderView>
        </syncfusion.SfTimePicker>
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
            timePicker.ColumnHeaderView = new TimePickerColumnHeaderView()
            {
                TextStyle = new PickerTextStyle()
                {
                    FontFamily = "Times New Roman",
                }
            };

            this.Content = timePicker;
        }
    }
}

{% endhighlight %}

{% endtabs %}

#### FontSize

FontSize of the column header text can be customized by setting the [`SfTimePicker.ColumnHeaderView`]() property.

{% tabs %}

{% highlight xaml %}

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:local="clr-namespace:TimePickerSample"
             xmlns:syncfusion="clr-namespace:Syncfusion.Maui.Picker;assembly=Syncfusion.Maui.Picker"
             x:Class="TimePickerSample.MainPage">
    <ContentPage.Content>
        <syncfusion:SfTimePicker x:Name="TimePicker" >
            <syncfusion:SfTimePicker.ColumnHeaderView >
                <syncfusion:TimePickerColumnHeaderView >
                    <syncfusion:TimePickerColumnHeaderView.TextStyle >
                        <syncfusion:PickerTextStyle FontSize="12"/>
                    </syncfusion:TimePickerColumnHeaderView.TextStyle>
                </syncfusion:TimePickerColumnHeaderView>
            </syncfusion:SfTimePicker.ColumnHeaderView>
        </syncfusion.SfTimePicker>
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
            timePicker.ColumnHeaderView = new TimePickerColumnHeaderView()
            {
                TextStyle = new PickerTextStyle()
                {
                    FontSize = 12,
                }
            };

            this.Content = timePicker;
        }
    }
}

{% endhighlight %}

{% endtabs %}   

#### FontAttribute

FontAttribute of the column header text can be customized by setting the [`SfTimePicker.ColumnHeaderView`]() property.

{% tabs %}

{% highlight xaml %}

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:local="clr-namespace:TimePickerSample"
             xmlns:syncfusion="clr-namespace:Syncfusion.Maui.Picker;assembly=Syncfusion.Maui.Picker"
             x:Class="TimePickerSample.MainPage">
    <ContentPage.Content>
        <syncfusion:SfTimePicker x:Name="TimePicker" >
            <syncfusion:SfTimePicker.ColumnHeaderView >
                <syncfusion:TimePickerColumnHeaderView >
                    <syncfusion:TimePickerColumnHeaderView.TextStyle >
                        <syncfusion:PickerTextStyle FontAttributes="Italic"/>
                    </syncfusion:TimePickerColumnHeaderView.TextStyle>
                </syncfusion:TimePickerColumnHeaderView>
            </syncfusion:SfTimePicker.ColumnHeaderView>
        </syncfusion.SfTimePicker>
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
            timePicker.ColumnHeaderView = new TimePickerColumnHeaderView()
            {
                TextStyle = new PickerTextStyle()
                {
                    FontAttributes = FontAttributes.Italic,
                }
            };

            this.Content = timePicker;
        }
    }
}

{% endhighlight %}

{% endtabs %}

## Footer customization

[`SfTimePicker`]() allows customizing background, text color of the OK and Cancel buttons of the footer.

### OK and Cancel buttons customizations

[`SfTimePicker`]() allows providing custom text to its column header by setting the [`SfTimePicker.FooterView`](). And its contain [`FooterView.OkButtonText`]() [`FooterView.CancelButtonText`]() properties. Default value of [`FooterView.OkButtonText`]() property is "OK", [`FooterView.CancelButtonText`]() is "Cancel".

{% tabs %}

{% highlight xaml %}

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:local="clr-namespace:TimePickerSample"
             xmlns:syncfusion="clr-namespace:Syncfusion.Maui.Picker;assembly=Syncfusion.Maui.Picker"
             x:Class="TimePickerSample.MainPage">
    <ContentPage.Content>
        <syncfusion:SfTimePicker x:Name="TimePicker" >
            <syncfusion:SfTimePicker.FooterView >
                <syncfusion:PickerFooterView Height="40" OkButtonText="Ok Button"
                                            CancelButtonText="Cancel Button"/>
            </syncfusion:SfTimePicker.FooterView>
        </syncfusion.SfTimePicker>
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
            timePicker.FooterView = new PickerFooterView()
            {
                Height = 40,
                OkButtonText = "Ok Button",
                CancelButtonText = "Cancel Button",
            };

            this.Content = timePicker;
        }
    }
}

{% endhighlight %}

{% endtabs %}

#### Background

Background color of the OK and Cancel buttons can be customized by setting the [`SfTimePicker.FooterView`]() properties.

{% tabs %}

{% highlight xaml %}

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:local="clr-namespace:TimePickerSample"
             xmlns:syncfusion="clr-namespace:Syncfusion.Maui.Picker;assembly=Syncfusion.Maui.Picker"
             x:Class="TimePickerSample.MainPage">
    <ContentPage.Content>
        <syncfusion:SfTimePicker x:Name="TimePicker" >
            <syncfusion:SfTimePicker.FooterView >
                <syncfusion:PickerFooterView Background="Orange">
                </syncfusion:PickerFooterView>
            </syncfusion:SfTimePicker.FooterView>
        </syncfusion.SfTimePicker>
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
            SfTimePicker timePicker = new SfTimePicker;
            timePicker.FooterView = new PickerFooterView()
            {
                Background = Colors.Violet,
            };

            this.Content = timePicker;
        }
    }
}

{% endhighlight %}

{% endtabs %}

#### Divider Color

Divider color of the OK and Cancel buttons can be customized by setting the [`SfTimePicker.FooterView`]() properties.

{% tabs %}

{% highlight xaml %}

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:local="clr-namespace:TimePickerSample"
             xmlns:syncfusion="clr-namespace:Syncfusion.Maui.Picker;assembly=Syncfusion.Maui.Picker"
             x:Class="TimePickerSample.MainPage">
    <ContentPage.Content>
        <syncfusion:SfTimePicker x:Name="TimePicker" >
            <syncfusion:SfTimePicker.FooterView >
                <syncfusion:PickerFooterView DividerColor="Blue">
                </syncfusion:PickerFooterView>
            </syncfusion:SfTimePicker.FooterView>
        </syncfusion.SfTimePicker>
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
            SfTimePicker timePicker = new SfTimePicker;
            timePicker.FooterView = new PickerFooterView()
            {
                DividerColor = Colors.Blue,
            };

            this.Content = timePicker;
        }
    }
}

{% endhighlight %}

{% endtabs %}

#### Text-Color 

Text colors of the OK and Cancel buttons can be customized by setting the [`SfTimePicker.FooterView`]() properties.

{% tabs %}

{% highlight xaml %}

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:local="clr-namespace:TimePickerSample"
             xmlns:syncfusion="clr-namespace:Syncfusion.Maui.Picker;assembly=Syncfusion.Maui.Picker"
             x:Class="TimePickerSample.MainPage">
    <ContentPage.Content>
        <syncfusion:SfTimePicker x:Name="TimePicker" >
            <syncfusion:SfTimePicker.FooterView >
                <syncfusion:PickerFooterView >
                    <syncfusion:PickerFooterView.TextStyle >
                        <syncfusion:PickerTextStyle TextColor="Violet"/>
                    </syncfusion:PickerFooterView.TextStyle>
                </syncfusion:PickerFooterView>
            </syncfusion:SfTimePicker.FooterView>
        </syncfusion.SfTimePicker>
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
            timePicker.FooterView = new PickerFooterView()
            {
                TextStyle = new PickerTextStyle()
                {
                    TextColor = Colors.Violet,
                }
            };

            this.Content = timePicker;
        }
    }
}

{% endhighlight %}

{% endtabs %}

### Font 

This section explains the Font customization of footer text.

#### FontFamily

FontFamily of the footer text can be customized by setting the [`SfTimePicker.FooterView`]() property.

{% tabs %}

{% highlight xaml %}

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:local="clr-namespace:TimePickerSample"
             xmlns:syncfusion="clr-namespace:Syncfusion.Maui.Picker;assembly=Syncfusion.Maui.Picker"
             x:Class="TimePickerSample.MainPage">
    <ContentPage.Content>
        <syncfusion:SfTimePicker x:Name="TimePicker" >
            <syncfusion:SfTimePicker.FooterView >
                <syncfusion:PickerFooterView >
                    <syncfusion:PickerFooterView.TextStyle >
                        <syncfusion:PickerTextStyle FontFamily="Times New Roman"/>
                    </syncfusion:PickerFooterView.TextStyle>
                </syncfusion:PickerFooterView>
            </syncfusion:SfTimePicker.FooterView>
        </syncfusion.SfTimePicker>
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
            timePicker.FooterView = new PickerFooterView()
            {
                TextStyle = new PickerTextStyle()
                {
                    FontFamily = "Times New Roman",
                }
            };

            this.Content = timePicker;
        }
    }
}

{% endhighlight %}

{% endtabs %}

#### FontSize

FontSize of the footer text can be customized by setting the [`SfTimePicker.FooterView`]() property.

{% tabs %}

{% highlight xaml %}

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:local="clr-namespace:TimePickerSample"
             xmlns:syncfusion="clr-namespace:Syncfusion.Maui.Picker;assembly=Syncfusion.Maui.Picker"
             x:Class="TimePickerSample.MainPage">
    <ContentPage.Content>
        <syncfusion:SfTimePicker x:Name="TimePicker" >
            <syncfusion:SfTimePicker.FooterView >
                <syncfusion:PickerFooterView >
                    <syncfusion:PickerFooterView.TextStyle >
                        <syncfusion:PickerTextStyle FontSize="12"/>
                    </syncfusion:PickerFooterView.TextStyle>
                </syncfusion:PickerFooterView>
            </syncfusion:SfTimePicker.FooterView>
        </syncfusion.SfTimePicker>
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
            timePicker.FooterView = new PickerFooterView()
            {
                TextStyle = new PickerTextStyle()
                {
                    FontSize = 12,
                }
            };

            this.Content = timePicker;
        }
    }
}

{% endhighlight %}

{% endtabs %}   

#### FontAttribute

FontAttribute of the footer text can be customized by setting the [`SfTimePicker.FooterView`]() property.

{% tabs %}

{% highlight xaml %}

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:local="clr-namespace:TimePickerSample"
             xmlns:syncfusion="clr-namespace:Syncfusion.Maui.Picker;assembly=Syncfusion.Maui.Picker"
             x:Class="TimePickerSample.MainPage">
    <ContentPage.Content>
        <syncfusion:SfTimePicker x:Name="TimePicker" >
            <syncfusion:SfTimePicker.FooterView >
                <syncfusion:PickerFooterView >
                    <syncfusion:PickerFooterView.TextStyle >
                        <syncfusion:PickerTextStyle FontAttributes="Italic"/>
                    </syncfusion:PickerFooterView.TextStyle>
                </syncfusion:PickerFooterView>
            </syncfusion:SfTimePicker.FooterView>
        </syncfusion.SfTimePicker>
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
            timePicker.FooterView = new PickerFooterView()
            {
                TextStyle = new PickerTextStyle()
                {
                    FontAttributes = FontAttributes.Italic,
                }
            };

            this.Content = timePicker;
        }
    }
}

{% endhighlight %}

{% endtabs %}

## Selected item customization

[`SfTimePicker`]() allows customizing the SelectedItem's background, text color, and fonts.

### Corner Radius

The corner radius of the SelectedItem can be customized by setting the [`SfTimePicker.SelectionView`]() property.

{% tabs %}

{% highlight xaml %}

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:local="clr-namespace:TimePickerSample"
             xmlns:syncfusion="clr-namespace:Syncfusion.Maui.Picker;assembly=Syncfusion.Maui.Picker"
             x:Class="TimePickerSample.MainPage">
    <ContentPage.Content>
        <syncfusion:SfTimePicker x:Name="TimePicker" >
            <syncfusion:SfTimePicker.SelectionView >
                <syncfusion:PickerSelectionView CornerRadius="5">
                </syncfusion:PickerSelectionView>
            </syncfusion:SfTimePicker.SelectionView>
        </syncfusion.SfTimePicker>
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
            timePicker.SelectionView = new PickerSelectionView()
            {
                CornerRadius = 5,
            };

            this.Content = timePicker;
        }
    }
}

{% endhighlight %}

{% endtabs %}

### Padding

The padding of the SelectedItem can be customized by setting the [`SfTimePicker.SelectionView`]() property.

{% tabs %}

{% highlight xaml %}

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:local="clr-namespace:TimePickerSample"
             xmlns:syncfusion="clr-namespace:Syncfusion.Maui.Picker;assembly=Syncfusion.Maui.Picker"
             x:Class="TimePickerSample.MainPage">
    <ContentPage.Content>
        <syncfusion:SfTimePicker x:Name="TimePicker" >
            <syncfusion:SfTimePicker.SelectionView >
                <syncfusion:PickerSelectionView Padding="5, 10, 5, 10">
                </syncfusion:PickerSelectionView>
            </syncfusion:SfTimePicker.SelectionView>
        </syncfusion.SfTimePicker>
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
            timePicker.SelectionView = new PickerSelectionView()
            {
                Padding = new Thickness(5, 10, 5, 10),
            };

            this.Content = timePicker;
        }
    }
}

{% endhighlight %}

{% endtabs %}

### Background

The background color of the SelectedItem can be customized by setting the [`SfTimePicker.SelectionView`]() property.

{% tabs %}

{% highlight xaml %}

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:local="clr-namespace:TimePickerSample"
             xmlns:syncfusion="clr-namespace:Syncfusion.Maui.Picker;assembly=Syncfusion.Maui.Picker"
             x:Class="TimePickerSample.MainPage">
    <ContentPage.Content>
        <syncfusion:SfTimePicker x:Name="TimePicker" >
            <syncfusion:SfTimePicker.SelectionView >
                <syncfusion:PickerSelectionView Background="Orange">
                </syncfusion:PickerSelectionView>
            </syncfusion:SfTimePicker.SelectionView>
        </syncfusion.SfTimePicker>
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
            timePicker.SelectionView = new PickerSelectionView()
            {
                Background = Colors.Violet,
            };

            this.Content = timePicker;
        }
    }
}

{% endhighlight %}

{% endtabs %}

### Stroke color 

Stroke color of the SelectedItem can be customized by setting the [`SfTimePicker.SelectionView`]() property.

{% tabs %}

{% highlight xaml %}

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:local="clr-namespace:TimePickerSample"
             xmlns:syncfusion="clr-namespace:Syncfusion.Maui.Picker;assembly=Syncfusion.Maui.Picker"
             x:Class="TimePickerSample.MainPage">
    <ContentPage.Content>
        <syncfusion:SfTimePicker x:Name="TimePicker" >
            <syncfusion:SfTimePicker.SelectionView >
                <syncfusion:PickerSelectionView StrokeColor="Violet"/>
                </syncfusion:PickerSelectionView>
            </syncfusion:SfTimePicker.SelectionView>
        </syncfusion.SfTimePicker>
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
            timePicker.SelectionView = new PickerSelectionView()
            {
                StrokeColor = Colors.Violet,
            };

            this.Content = timePicker;
        }
    }
}

{% endhighlight %}

{% endtabs %}
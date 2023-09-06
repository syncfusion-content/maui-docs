---
layout: post
title: Customizations in .NET MAUI DatePicker control | Syncfusion
description: Learn here all about Customizations support in Syncfusion .NET MAUI DatePicker (SfDatePicker) control and more.
platform: maui
control: SfDatePicker
documentation: ug
---

# Customizations in .NET MAUI DatePicker (SfDatePicker)

You can customize the header, column header, footer, selected item of the [`SfDatePicker`]().

## Header customization

[`SfDatePicker`]() allows customizing the header's background, text color, and fonts.

### Set header text

[`SfDatePicker`]() allows providing custom text to its header by setting the [`SfDatePicker.HeaderView`]() property.

{% tabs %}

{% highlight xaml %}

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:local="clr-namespace:DatePickerSample"
             xmlns:syncfusion="clr-namespace:Syncfusion.Maui.Picker;assembly=Syncfusion.Maui.Picker"
             x:Class="DatePickerSample.MainPage">
    <ContentPage.Content>
        <syncfusion:SfDatePicker x:Name="datepicker" >
            <syncfusion:SfDatePicker.HeaderView >
                <syncfusion:PickerHeaderView Height="40" Text="Date Picker"/>
            </syncfusion:SfDatePicker.HeaderView>
        </syncfusion.SfDatePicker>
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
            SfDatePicker datePicker = new SfDatePicker();
            datepicker.HeaderView = new PickerHeaderView()
            {
                Height = 40,
                Text = "Date Picker"
            };

            this.Content = datePicker;
        }
    }
}

{% endhighlight %}

{% endtabs %}

### Background

Background color of the header can be customized by setting the [`SfDatePicker.HeaderView`]() property.

{% tabs %}

{% highlight xaml %}

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:local="clr-namespace:DatePickerSample"
             xmlns:syncfusion="clr-namespace:Syncfusion.Maui.Picker;assembly=Syncfusion.Maui.Picker"
             x:Class="DatePickerSample.MainPage">
    <ContentPage.Content>
        <syncfusion:SfDatePicker x:Name="datepicker" >
            <syncfusion:SfDatePicker.HeaderView >
                <syncfusion:PickerHeaderView Height="40" Text="Date Picker" Background="Orange"/>
            </syncfusion:SfDatePicker.HeaderView>
        </syncfusion.SfDatePicker>
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
            SfDatePicker datePicker = new SfDatePicker();
            datepicker.HeaderView = new PickerHeaderView()
            {
                Height = 40,
                Text = "Date Picker",
                Background = Colors.Orange,
            };

            this.Content = datePicker;
        }
    }
}

{% endhighlight %}

{% endtabs %}

### Text color 

Text color of the header can be customized by setting the [`SfDatePicker.HeaderView`]() property.

{% tabs %}

{% highlight xaml %}

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:local="clr-namespace:DatePickerSample"
             xmlns:syncfusion="clr-namespace:Syncfusion.Maui.Picker;assembly=Syncfusion.Maui.Picker"
             x:Class="DatePickerSample.MainPage">
    <ContentPage.Content>
        <syncfusion:SfDatePicker x:Name="datepicker" >
            <syncfusion:SfDatePicker.HeaderView >
                <syncfusion:PickerHeaderView Height="40" Text="Date Picker" >
                    <syncfusion:PickerHeaderView.TextStyle >
                        <syncfusion:PickerTextStyle TextColor="Violet" />
                    </syncfusion:PickerHeaderView.TextStyle>
                </syncfusion:PickerHeaderView>
            </syncfusion:SfDatePicker.HeaderView>
        </syncfusion.SfDatePicker>
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
            SfDatePicker datePicker = new SfDatePicker();
            datepicker.HeaderView = new PickerHeaderView()
            {
                Height = 40,
                Text = "Date Picker",
                TextStyle = new PickerTextStyle()
                {
                    TextColor = Colors.Violet,
                }
            };

            this.Content = datePicker;
        }
    }
}

{% endhighlight %}

{% endtabs %}

### Font 

This section explains the Font customization of header text.

#### FontFamily

FontFamily of the header text can be customized by setting the [`SfDatePicker.HeaderView`]() property.

{% tabs %}

{% highlight xaml %}

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:local="clr-namespace:DatePickerSample"
             xmlns:syncfusion="clr-namespace:Syncfusion.Maui.Picker;assembly=Syncfusion.Maui.Picker"
             x:Class="DatePickerSample.MainPage">
    <ContentPage.Content>
        <syncfusion:SfDatePicker x:Name="datepicker" >
            <syncfusion:SfDatePicker.HeaderView >
                <syncfusion:PickerHeaderView Height="40" Text="Date Picker" >
                    <syncfusion:PickerHeaderView.TextStyle >
                        <syncfusion:PickerTextStyle FontFamily="Times New Roman" />
                    </syncfusion:PickerHeaderView.TextStyle>
                </syncfusion:PickerHeaderView>
            </syncfusion:SfDatePicker.HeaderView>
        </syncfusion.SfDatePicker>
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
            SfDatePicker datePicker = new SfDatePicker();
            datepicker.HeaderView = new PickerHeaderView()
            {
                Height = 40,
                Text = "Date Picker",
                TextStyle = new PickerTextStyle()
                {
                    FontFamily = "Times New Roman",
                }
            };

            this.Content = datePicker;
        }
    }
}

{% endhighlight %}

{% endtabs %}

#### FontSize

FontSize of the header text can be customized by setting the [`SfDatePicker.HeaderView`]() property.

{% tabs %}

{% highlight xaml %}

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:local="clr-namespace:DatePickerSample"
             xmlns:syncfusion="clr-namespace:Syncfusion.Maui.Picker;assembly=Syncfusion.Maui.Picker"
             x:Class="DatePickerSample.MainPage">
    <ContentPage.Content>
        <syncfusion:SfDatePicker x:Name="datepicker" >
            <syncfusion:SfDatePicker.HeaderView >
                <syncfusion:PickerHeaderView Height="40" Text="Date Picker" >
                    <syncfusion:PickerHeaderView.TextStyle >
                        <syncfusion:PickerTextStyle FontSize="12" />
                    </syncfusion:PickerHeaderView.TextStyle>
                </syncfusion:PickerHeaderView>
            </syncfusion:SfDatePicker.HeaderView>
        </syncfusion.SfDatePicker>
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
            SfDatePicker datePicker = new SfDatePicker();
            datepicker.HeaderView = new PickerHeaderView()
            {
                Height = 40,
                Text = "Date Picker",
                TextStyle = new PickerTextStyle()
                {
                    FontSize = 12,
                }
            };

            this.Content = datePicker;
        }
    }
}

{% endhighlight %}

{% endtabs %}   

#### FontAttribute

FontAttribute of the header text can be customized by setting the [`SfDatePicker.HeaderView`]() property.

{% tabs %}

{% highlight xaml %}

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:local="clr-namespace:DatePickerSample"
             xmlns:syncfusion="clr-namespace:Syncfusion.Maui.Picker;assembly=Syncfusion.Maui.Picker"
             x:Class="DatePickerSample.MainPage">
    <ContentPage.Content>
        <syncfusion:SfDatePicker x:Name="datepicker" >
            <syncfusion:SfDatePicker.HeaderView >
                <syncfusion:PickerHeaderView Height="40" Text="Date Picker" >
                    <syncfusion:PickerHeaderView.TextStyle >
                        <syncfusion:PickerTextStyle FontAttributes="Italic" />
                    </syncfusion:PickerHeaderView.TextStyle>
                </syncfusion:PickerHeaderView>
            </syncfusion:SfDatePicker.HeaderView>
        </syncfusion.SfDatePicker>
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
            SfDatePicker datePicker = new SfDatePicker();
            datepicker.HeaderView = new PickerHeaderView()
            {
                Height = 40,
                Text = "Date Picker",
                TextStyle = new PickerTextStyle()
                {
                    FontAttributes = FontAttributes.Italic,
                }
            };

            this.Content = datePicker;
        }
    }
}

{% endhighlight %}

{% endtabs %}

## Column header customization

[`SfDatePicker`]() allows customizing the column header's background, text color, and fonts.

### Set custom column header 

[`SfDatePicker`]() allows providing custom text to its column header by setting the [`SfDatePicker.ColumnHeaderView`](). And its contain [`ColumnHeaderView.DayHeaderText`]() [`ColumnHeaderView.MonthHeaderText`](), and [`ColumnHeaderView.YearHeaderText`]() properties. Default value of [`ColumnHeaderView.DayHeaderText`]() property is "Day", [`ColumnHeaderView.MonthHeaderText`]() is "Month", and [`ColumnHeaderView.YearHeaderText`]() is "Year".

{% tabs %}

{% highlight xaml %}

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:local="clr-namespace:DatePickerSample"
             xmlns:syncfusion="clr-namespace:Syncfusion.Maui.Picker;assembly=Syncfusion.Maui.Picker"
             x:Class="DatePickerSample.MainPage">
    <ContentPage.Content>
        <syncfusion:SfDatePicker x:Name="datepicker" >
            <syncfusion:SfDatePicker.ColumnHeaderView >
                <syncfusion:DatePickerColumnHeaderView DayHeaderText="Day Column"
                                                        MonthHeaderText="Month Column"
                                                        YearHeaderText="YearColumn"/>
            </syncfusion:SfDatePicker.ColumnHeaderView>
        </syncfusion.SfDatePicker>
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
            SfDatePicker datePicker = new SfDatePicker();
            datepicker.ColumnHeaderView = new DatePickerColumnHeaderView()
            {
                DayHeaderText = "Day Column",
                MonthHeaderText = "Month Column",
                YearHeaderText = "Year Column"
            };

            this.Content = datePicker;
        }
    }
}

{% endhighlight %}

{% endtabs %}

### Background

Background color of the column header can be customized by setting the [`SfDatePicker.ColumnHeaderView`]() property.

{% tabs %}

{% highlight xaml %}

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:local="clr-namespace:DatePickerSample"
             xmlns:syncfusion="clr-namespace:Syncfusion.Maui.Picker;assembly=Syncfusion.Maui.Picker"
             x:Class="DatePickerSample.MainPage">
    <ContentPage.Content>
        <syncfusion:SfDatePicker x:Name="datepicker" >
            <syncfusion:SfDatePicker.ColumnHeaderView >
                <syncfusion:DatePickerColumnHeaderView Background="Orange"/>
            </syncfusion:SfDatePicker.ColumnHeaderView>
        </syncfusion.SfDatePicker>
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
            SfDatePicker datePicker = new SfDatePicker();
            datepicker.ColumnHeaderView = new DatePickerColumnHeaderView()
            {
                Background = Colors.Orange,
            };

            this.Content = datePicker;
        }
    }
}

{% endhighlight %}

{% endtabs %}

### Text color 

Text color of the column header can be customized by setting the [`SfDatePicker.ColumnHeaderView`]() property.

{% tabs %}

{% highlight xaml %}

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:local="clr-namespace:DatePickerSample"
             xmlns:syncfusion="clr-namespace:Syncfusion.Maui.Picker;assembly=Syncfusion.Maui.Picker"
             x:Class="DatePickerSample.MainPage">
    <ContentPage.Content>
        <syncfusion:SfDatePicker x:Name="datepicker" >
            <syncfusion:SfDatePicker.ColumnHeaderView >
                <syncfusion:DatePickerColumnHeaderView >
                    <syncfusion:DatePickerColumnHeaderView.TextStyle >
                        <syncfusion:PickerTextStyle TextColor="Violet"/>
                    </syncfusion:DatePickerColumnHeaderView.TextStyle>
                </syncfusion:DatePickerColumnHeaderView>
            </syncfusion:SfDatePicker.ColumnHeaderView>
        </syncfusion.SfDatePicker>
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
            SfDatePicker datePicker = new SfDatePicker();
            datepicker.ColumnHeaderView = new DatePickerColumnHeaderView()
            {
                TextStyle = new PickerTextStyle()
                {
                    TextColor = Colors.Violet,
                }
            };

            this.Content = datePicker;
        }
    }
}

{% endhighlight %}

{% endtabs %}

### Font 

This section explains the Font customization of column header text.

#### FontFamily

FontFamily of the column header text can be customized by setting the [`SfDatePicker.ColumnHeaderView`]() property.

{% tabs %}

{% highlight xaml %}

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:local="clr-namespace:DatePickerSample"
             xmlns:syncfusion="clr-namespace:Syncfusion.Maui.Picker;assembly=Syncfusion.Maui.Picker"
             x:Class="DatePickerSample.MainPage">
    <ContentPage.Content>
        <syncfusion:SfDatePicker x:Name="datepicker" >
            <syncfusion:SfDatePicker.ColumnHeaderView >
                <syncfusion:DatePickerColumnHeaderView >
                    <syncfusion:DatePickerColumnHeaderView.TextStyle >
                        <syncfusion:PickerTextStyle FontFamily="Times New Roman"/>
                    </syncfusion:DatePickerColumnHeaderView.TextStyle>
                </syncfusion:DatePickerColumnHeaderView>
            </syncfusion:SfDatePicker.ColumnHeaderView>
        </syncfusion.SfDatePicker>
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
            SfDatePicker datePicker = new SfDatePicker();
            datepicker.ColumnHeaderView = new DatePickerColumnHeaderView()
            {
                TextStyle = new PickerTextStyle()
                {
                    FontFamily = "Times New Roman",
                }
            };

            this.Content = datePicker;
        }
    }
}

{% endhighlight %}

{% endtabs %}

#### FontSize

FontSize of the column header text can be customized by setting the [`SfDatePicker.ColumnHeaderView`]() property.

{% tabs %}

{% highlight xaml %}

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:local="clr-namespace:DatePickerSample"
             xmlns:syncfusion="clr-namespace:Syncfusion.Maui.Picker;assembly=Syncfusion.Maui.Picker"
             x:Class="DatePickerSample.MainPage">
    <ContentPage.Content>
        <syncfusion:SfDatePicker x:Name="datepicker" >
            <syncfusion:SfDatePicker.ColumnHeaderView >
                <syncfusion:DatePickerColumnHeaderView >
                    <syncfusion:DatePickerColumnHeaderView.TextStyle >
                        <syncfusion:PickerTextStyle FontSize="12"/>
                    </syncfusion:DatePickerColumnHeaderView.TextStyle>
                </syncfusion:DatePickerColumnHeaderView>
            </syncfusion:SfDatePicker.ColumnHeaderView>
        </syncfusion.SfDatePicker>
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
            SfDatePicker datePicker = new SfDatePicker();
            datepicker.ColumnHeaderView = new DatePickerColumnHeaderView()
            {
                TextStyle = new PickerTextStyle()
                {
                    FontSize = 12,
                }
            };

            this.Content = datePicker;
        }
    }
}

{% endhighlight %}

{% endtabs %}   

#### FontAttribute

FontAttribute of the column header text can be customized by setting the [`SfDatePicker.ColumnHeaderView`]() property.

{% tabs %}

{% highlight xaml %}

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:local="clr-namespace:DatePickerSample"
             xmlns:syncfusion="clr-namespace:Syncfusion.Maui.Picker;assembly=Syncfusion.Maui.Picker"
             x:Class="DatePickerSample.MainPage">
    <ContentPage.Content>
        <syncfusion:SfDatePicker x:Name="datepicker" >
            <syncfusion:SfDatePicker.ColumnHeaderView >
                <syncfusion:DatePickerColumnHeaderView >
                    <syncfusion:DatePickerColumnHeaderView.TextStyle >
                        <syncfusion:PickerTextStyle FontAttributes="Italic"/>
                    </syncfusion:DatePickerColumnHeaderView.TextStyle>
                </syncfusion:DatePickerColumnHeaderView>
            </syncfusion:SfDatePicker.ColumnHeaderView>
        </syncfusion.SfDatePicker>
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
            SfDatePicker datePicker = new SfDatePicker();
            datepicker.ColumnHeaderView = new DatePickerColumnHeaderView()
            {
                TextStyle = new PickerTextStyle()
                {
                    FontAttributes = FontAttributes.Italic,
                }
            };

            this.Content = datePicker;
        }
    }
}

{% endhighlight %}

{% endtabs %}

## Footer customization

[`SfDatePicker`]() allows customizing background, text color of the OK and Cancel buttons of the footer.

### OK and Cancel buttons customizations

[`SfDatePicker`]() allows providing custom text to its column header by setting the [`SfDatePicker.FooterView`](). And its contain [`FooterView.OkButtonText`]() [`FooterView.CancelButtonText`]() properties. Default value of [`FooterView.OkButtonText`]() property is "OK", [`FooterView.CancelButtonText`]() is "Cancel".

{% tabs %}

{% highlight xaml %}

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:local="clr-namespace:DatePickerSample"
             xmlns:syncfusion="clr-namespace:Syncfusion.Maui.Picker;assembly=Syncfusion.Maui.Picker"
             x:Class="DatePickerSample.MainPage">
    <ContentPage.Content>
        <syncfusion:SfDatePicker x:Name="datepicker" >
            <syncfusion:SfDatePicker.FooterView >
                <syncfusion:PickerFooterView Height="40" OkButtonText="Ok Button"
                                            CancelButtonText="Cancel Button"/>
            </syncfusion:SfDatePicker.FooterView>
        </syncfusion.SfDatePicker>
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
            SfDatePicker datePicker = new SfDatePicker();
            datepicker.FooterView = new PickerFooterView()
            {
                Height = 40,
                OkButtonText = "Ok Button",
                CancelButtonText = "Cancel Button",
            };

            this.Content = datePicker;
        }
    }
}

{% endhighlight %}

{% endtabs %}

#### Background

Background colors of the OK and Cancel buttons can be customized by setting the [`SfDatePicker.FooterView`]() properties.

{% tabs %}

{% highlight xaml %}

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:local="clr-namespace:DatePickerSample"
             xmlns:syncfusion="clr-namespace:Syncfusion.Maui.Picker;assembly=Syncfusion.Maui.Picker"
             x:Class="DatePickerSample.MainPage">
    <ContentPage.Content>
        <syncfusion:SfDatePicker x:Name="datepicker" >
            <syncfusion:SfDatePicker.FooterView >
                <syncfusion:PickerFooterView Background="Orange">
                </syncfusion:PickerFooterView>
            </syncfusion:SfDatePicker.FooterView>
        </syncfusion.SfDatePicker>
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
            datepicker.FooterView = new PickerFooterView()
            {
                Background = Colors.Violet,
            };

            this.Content = datePicker;
        }
    }
}

{% endhighlight %}

{% endtabs %}

#### Text-Color 

Text colors of the OK and Cancel buttons can be customized by setting the [`SfDatePicker.FooterView`]() properties.

{% tabs %}

{% highlight xaml %}

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:local="clr-namespace:DatePickerSample"
             xmlns:syncfusion="clr-namespace:Syncfusion.Maui.Picker;assembly=Syncfusion.Maui.Picker"
             x:Class="DatePickerSample.MainPage">
    <ContentPage.Content>
        <syncfusion:SfDatePicker x:Name="datepicker" >
            <syncfusion:SfDatePicker.FooterView >
                <syncfusion:PickerFooterView >
                    <syncfusion:PickerFooterView.TextStyle >
                        <syncfusion:PickerTextStyle TextColor="Violet"/>
                    </syncfusion:PickerFooterView.TextStyle>
                </syncfusion:PickerFooterView>
            </syncfusion:SfDatePicker.FooterView>
        </syncfusion.SfDatePicker>
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
            SfDatePicker datePicker = new SfDatePicker();
            datepicker.FooterView = new PickerFooterView()
            {
                TextStyle = new PickerTextStyle()
                {
                    TextColor = Colors.Violet,
                }
            };

            this.Content = datePicker;
        }
    }
}

{% endhighlight %}

{% endtabs %}

### Font 

This section explains the Font customization of footer text.

#### FontFamily

FontFamily of the footer text can be customized by setting the [`SfDatePicker.FooterView`]() property.

{% tabs %}

{% highlight xaml %}

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:local="clr-namespace:DatePickerSample"
             xmlns:syncfusion="clr-namespace:Syncfusion.Maui.Picker;assembly=Syncfusion.Maui.Picker"
             x:Class="DatePickerSample.MainPage">
    <ContentPage.Content>
        <syncfusion:SfDatePicker x:Name="datepicker" >
            <syncfusion:SfDatePicker.FooterView >
                <syncfusion:PickerFooterView >
                    <syncfusion:PickerFooterView.TextStyle >
                        <syncfusion:PickerTextStyle FontFamily="Times New Roman"/>
                    </syncfusion:PickerFooterView.TextStyle>
                </syncfusion:PickerFooterView>
            </syncfusion:SfDatePicker.FooterView>
        </syncfusion.SfDatePicker>
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
            SfDatePicker datePicker = new SfDatePicker();
            datepicker.FooterView = new PickerFooterView()
            {
                TextStyle = new PickerTextStyle()
                {
                    FontFamily = "Times New Roman",
                }
            };

            this.Content = datePicker;
        }
    }
}

{% endhighlight %}

{% endtabs %}

#### FontSize

FontSize of the footer text can be customized by setting the [`SfDatePicker.FooterView`]() property.

{% tabs %}

{% highlight xaml %}

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:local="clr-namespace:DatePickerSample"
             xmlns:syncfusion="clr-namespace:Syncfusion.Maui.Picker;assembly=Syncfusion.Maui.Picker"
             x:Class="DatePickerSample.MainPage">
    <ContentPage.Content>
        <syncfusion:SfDatePicker x:Name="datepicker" >
            <syncfusion:SfDatePicker.FooterView >
                <syncfusion:PickerFooterView >
                    <syncfusion:PickerFooterView.TextStyle >
                        <syncfusion:PickerTextStyle FontSize="12"/>
                    </syncfusion:PickerFooterView.TextStyle>
                </syncfusion:PickerFooterView>
            </syncfusion:SfDatePicker.FooterView>
        </syncfusion.SfDatePicker>
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
            SfDatePicker datePicker = new SfDatePicker();
            datepicker.FooterView = new PickerFooterView()
            {
                TextStyle = new PickerTextStyle()
                {
                    FontSize = 12,
                }
            };

            this.Content = datePicker;
        }
    }
}

{% endhighlight %}

{% endtabs %}   

#### FontAttribute

FontAttribute of the footer text can be customized by setting the [`SfDatePicker.FooterView`]() property.

{% tabs %}

{% highlight xaml %}

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:local="clr-namespace:DatePickerSample"
             xmlns:syncfusion="clr-namespace:Syncfusion.Maui.Picker;assembly=Syncfusion.Maui.Picker"
             x:Class="DatePickerSample.MainPage">
    <ContentPage.Content>
        <syncfusion:SfDatePicker x:Name="datepicker" >
            <syncfusion:SfDatePicker.FooterView >
                <syncfusion:PickerFooterView >
                    <syncfusion:PickerFooterView.TextStyle >
                        <syncfusion:PickerTextStyle FontAttributes="Italic"/>
                    </syncfusion:PickerFooterView.TextStyle>
                </syncfusion:PickerFooterView>
            </syncfusion:SfDatePicker.FooterView>
        </syncfusion.SfDatePicker>
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
            SfDatePicker datePicker = new SfDatePicker();
            datepicker.FooterView = new PickerFooterView()
            {
                TextStyle = new PickerTextStyle()
                {
                    FontAttributes = FontAttributes.Italic,
                }
            };

            this.Content = datePicker;
        }
    }
}

{% endhighlight %}

{% endtabs %}

## Selected item customization

[`SfDatePicker`]() allows customizing the SelectedItem's background, text color, and fonts.

### Corner Radius

The corner radius of the SelectedItem can be customized by setting the [`SfDatePicker.SelectionView`]() property.

{% tabs %}

{% highlight xaml %}

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:local="clr-namespace:DatePickerSample"
             xmlns:syncfusion="clr-namespace:Syncfusion.Maui.Picker;assembly=Syncfusion.Maui.Picker"
             x:Class="DatePickerSample.MainPage">
    <ContentPage.Content>
        <syncfusion:SfDatePicker x:Name="datepicker" >
            <syncfusion:SfDatePicker.SelectionView >
                <syncfusion:PickerSelectionView CornerRadius="5">
                </syncfusion:PickerSelectionView>
            </syncfusion:SfDatePicker.SelectionView>
        </syncfusion.SfDatePicker>
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
            datepicker.SelectionView = new PickerSelectionView()
            {
                CornerRadius = 5,
            };

            this.Content = datePicker;
        }
    }
}

{% endhighlight %}

{% endtabs %}

### Padding

The padding of the SelectedItem can be customized by setting the [`SfDatePicker.SelectionView`]() property.

{% tabs %}

{% highlight xaml %}

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:local="clr-namespace:DatePickerSample"
             xmlns:syncfusion="clr-namespace:Syncfusion.Maui.Picker;assembly=Syncfusion.Maui.Picker"
             x:Class="DatePickerSample.MainPage">
    <ContentPage.Content>
        <syncfusion:SfDatePicker x:Name="datepicker" >
            <syncfusion:SfDatePicker.SelectionView >
                <syncfusion:PickerSelectionView Padding="5, 10, 5, 10">
                </syncfusion:PickerSelectionView>
            </syncfusion:SfDatePicker.SelectionView>
        </syncfusion.SfDatePicker>
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
            datepicker.SelectionView = new PickerSelectionView()
            {
                Padding = new Thickness(5, 10, 5, 10),
            };

            this.Content = datePicker;
        }
    }
}

{% endhighlight %}

{% endtabs %}

### Background

The background color of the SelectedItem can be customized by setting the [`SfDatePicker.SelectionView`]() property.

{% tabs %}

{% highlight xaml %}

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:local="clr-namespace:DatePickerSample"
             xmlns:syncfusion="clr-namespace:Syncfusion.Maui.Picker;assembly=Syncfusion.Maui.Picker"
             x:Class="DatePickerSample.MainPage">
    <ContentPage.Content>
        <syncfusion:SfDatePicker x:Name="datepicker" >
            <syncfusion:SfDatePicker.SelectionView >
                <syncfusion:PickerSelectionView Background="Orange">
                </syncfusion:PickerSelectionView>
            </syncfusion:SfDatePicker.SelectionView>
        </syncfusion.SfDatePicker>
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
            datepicker.SelectionView = new PickerSelectionView()
            {
                Background = Colors.Violet,
            };

            this.Content = datePicker;
        }
    }
}

{% endhighlight %}

{% endtabs %}

### Stroke color 

Stroke color of the SelectedItem can be customized by setting the [`SfDatePicker.SelectionView`]() property.

{% tabs %}

{% highlight xaml %}

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:local="clr-namespace:DatePickerSample"
             xmlns:syncfusion="clr-namespace:Syncfusion.Maui.Picker;assembly=Syncfusion.Maui.Picker"
             x:Class="DatePickerSample.MainPage">
    <ContentPage.Content>
        <syncfusion:SfDatePicker x:Name="datepicker" >
            <syncfusion:SfDatePicker.SelectionView >
                <syncfusion:PickerSelectionView StrokeColor="Violet"/>
                </syncfusion:PickerSelectionView>
            </syncfusion:SfDatePicker.SelectionView>
        </syncfusion.SfDatePicker>
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
            SfDatePicker datePicker = new SfDatePicker();
            datepicker.SelectionView = new PickerSelectionView()
            {
                StrokeColor = Colors.Violet,
            };

            this.Content = datePicker;
        }
    }
}

{% endhighlight %}

{% endtabs %}
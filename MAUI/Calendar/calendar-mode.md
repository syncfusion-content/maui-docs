---
layout: post
title: Calendar Modes in .NET MAUI Calendar Control | Syncfusion
description: Learn about the calendar modes in Syncfusion Calendar for .NET MAUI (SfCalendar) control and its basic features.
platform: maui
control: SfCalendar
documentation: ug
---

# Calendar mode in .NET MAUI Calendar (SfCalendar)

The Calendar mode is specified in the calendar property enumeration, which is used to display the calendar based on the modes. It offers three modes: `Default`, `Dialog`, and `RelativeDialog`. The default calendar mode in the `SfCalendar` is `Default`.

## Dialog Mode

The dialog mode is used to display the calendar in a pop-up by setting the `Mode` property to `Dialog` in `SfCalendar`.

{% tabs %}

{% highlight xaml tabtitle="XAML" hl_lines="2" %}

<calendar:SfCalendar x:Name="calendar"
                     Mode="Dialog"/>

{% endhighlight %}

{% highlight c# tabtitle="C#" hl_lines="3" %}

SfCalendar calendar = new SfCalendar()
{
    Mode = CalendarMode.Dialog
};

this.Content = calendar;

{% endhighlight %}

{% endtabs %}

The Calendar can be opened programmatically by setting the `IsOpen` property to `true` of `SfCalendar`. By default, the `IsOpen` property is `false`.

N> This property is automatically changed to `false` when you close the dialog by clicking outside of it.

{% tabs %}

{% highlight xaml tabtitle="MainPage.xaml" %}

<Grid>
    <calendar:SfCalendar x:Name="calendar"
                         Mode="Dialog"/>
    <Button Text="Open Calendar" 
            x:Name="calendarButton"
            Clicked="Button_Clicked"
            HorizontalOptions="Center"
            VerticalOptions="Center"
            HeightRequest="50" 
            WidthRequest="150">
    </Button>
</Grid>

{% endhighlight %}

{% highlight c# tabtitle="MainPage.xaml.cs" %}

private void Button_Clicked(object sender, System.EventArgs e)
{
    this.calendar.IsOpen = true;
}

{% endhighlight %}

{% endtabs %}

![Dialog mode in .NET MAUI Calendar.](images/calendar-mode/calendar-dialog-demo.gif)


## Relative Dialog Mode

The relative dialog mode displays the calendar in a pop-up by setting the `Mode` property to `RelativeDialog`. It is used to align the calendar in a specific position. You can set the position by using the `RelativePosition` property in the `SfCalendar`.

### Relative position

The `RelativePosition` is specified in the calendar property enumeration, which is used to align the calendar in a specific position. It provides eight positions such as `AlignTop`, `AlignToLeftOf`, `AlignToRightOf`, `AlignBottom`, `AlignTopLeft`, `AlignTopRight`, `AlignBottomLeft`, and `AlignBottomRight`. The default relative position in the `SfCalendar` is `AlignTop`.

The Calendar can be opened programmatically by setting the `IsOpen` property to `true` of `SfCalendar`. By default, the `IsOpen` property is `false`.

N> This property is automatically changed to `false` when you close the dialog by clicking outside of it.

{% tabs %}

{% highlight xaml tabtitle="MainPage.xaml"%}

<Grid>
    <calendar:SfCalendar x:Name="calendar" 
                         Mode="RelativeDialog"
                         RelativePosition="AlignTopLeft">
    </calendar:SfCalendar>
    <Button Text="Open calendar" 
            x:Name="calendarButton"
            Clicked="Button_Clicked"
            HorizontalOptions="Center"
            VerticalOptions="Center"
            HeightRequest="50" 
            WidthRequest="150">
    </Button>
</Grid>

{% endhighlight %}

{% highlight c# tabtitle="MainPage.xaml.cs"%}

private void Button_Clicked(object sender, System.EventArgs e)
{
    this.calendar.IsOpen = true;
}

{% endhighlight %} 
 
{% endtabs %}

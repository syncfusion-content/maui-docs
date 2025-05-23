---
layout: post
title: Headers in .NET MAUI calendar control | Syncfusion<sup>&reg;</sup> | calendar
description: Learn here all about Headers feature of Syncfusion<sup>&reg;</sup> .NET MAUI calendar (SfCalendar) control and more.
platform: maui
control: SfCalendar
documentation: ug
---

# Headers in .NET MAUI calendar (SfCalendar)
You can customize all the properties of the Header view using [HeaderView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.calendar.SfCalendar.html#Syncfusion_Maui_Calendar_SfCalendar_HeaderView). By using this property, you can customize the Background, Height, TextFormat, TextStyle, and ShowNavigationArrows of the calendar.

## Customize the header height
You can customize the header height `calendar` by using the `Height` property.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

<calendar:SfCalendar  x:Name="calendar"
                      View="Month">
            <calendar:SfCalendar.HeaderView>
                <calendar:CalendarHeaderView Height="70" />
            </calendar:SfCalendar.HeaderView>
</calendar:SfCalendar>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

this.calendar.HeaderView.Height = 70;

{% endhighlight %}
{% endtabs %}

![Month view Header height Changed in .NET MAUI calendar.](images/header/maui-month-view-header-height-changed.png)

## Header appearance
You can customize the header style of the `calendar` by using the [Background](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.calendar.CalendarHeaderView.html#Syncfusion_Maui_Calendar_CalendarHeaderView_Background), [TextStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.calendar.CalendarHeaderView.html#Syncfusion_Maui_Calendar_CalendarHeaderView_TextStyle), and [TextFormat](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.calendar.CalendarHeaderView.html#Syncfusion_Maui_Calendar_CalendarHeaderView_TextFormat) properties of [ShowNavigationArrows](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.calendar.CalendarHeaderView.html#Syncfusion_Maui_Calendar_CalendarHeaderView_ShowNavigationArrows).

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

<calendar:SfCalendar  x:Name="calendar"
                      View="Month">
            <calendar:SfCalendar.HeaderView>
                <calendar:CalendarHeaderView Background="Grey" TextFormat="MMM yy" ShowNavigationArrows="True">
                    <calendar:CalendarHeaderView.TextStyle>
                        <calendar:CalendarTextStyle TextColor="Black" FontSize="14" />
                    </calendar:CalendarHeaderView.TextStyle>
                </calendar:CalendarHeaderView>
            </calendar:SfCalendar.HeaderView>
</calendar:SfCalendar>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

CalendarTextStyle textStyle = new CalendarTextStyle()
{
    TextColor = Colors.Black,
    FontSize = 14,
};

this.calendar.HeaderView = new CalendarHeaderView()
{
    Background = Colors.Grey,
    TextFormat = "MMM yy",
    ShowNavigationArrows = true,
    TextStyle = textStyle,
};

{% endhighlight %}
{% endtabs %}

![Month view Header appearance Changed in .NET MAUI calendar.](images/header/maui-month-view-header-appearance-changed.png)

## Header appearance using DataTemplate

You can customize the header appearance by using the [HeaderTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.calendar.SfCalendar.html#Syncfusion_Maui_Calendar_SfCalendar_HeaderTemplate) in the [SfCalendar](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.calendar.SfCalendar.html). 

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="3 17" %}

  <calendar:SfCalendar x:Name="calendar" 
                         View="Month">
        <calendar:SfCalendar.HeaderTemplate>
            <DataTemplate>
                <Grid Background = "#987D9A">
                    <Label x:Name="label" TextColor="White" HorizontalOptions="Center" VerticalOptions="Start">
                        <Label.Text>
                            <MultiBinding StringFormat = "{}{0:MMM dd, yyyy} - {1:MMM dd, yyyy}">
                                <Binding Path="StartDateRange" />
                                <Binding Path = "EndDateRange" />
                            </MultiBinding>
                        </Label.Text>
                    </Label>
                    <Label  HorizontalOptions="Center" VerticalOptions="End" Text="{Binding Text}" TextColor="White" />
                </Grid>
            </DataTemplate>
        </calendar:SfCalendar.HeaderTemplate>
 </calendar:SfCalendar>

{% endhighlight %}
{% endtabs %}

![Month view Header appearance changed using template .NET MAUI calendar.](images/header/maui-month-view-header-data-template.png)

## Header appearance using DataTemplateSelector

You can customize the header appearance by using the [HeaderTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.calendar.SfCalendar.html#Syncfusion_Maui_Calendar_SfCalendar_HeaderTemplate) in the [SfCalendar](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.calendar.SfCalendar.html). The `DataTemplateSelector` allows you to choose a `DataTemplate` at runtime based on the value bound to the calendar header. This lets you select a different data template for each header and customize the appearance of a specific header based on certain conditions.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="33" %}

 <Grid>
    <Grid.Resources>
        <DataTemplate x:Key="todayDatesTemplate">
            <Grid Background = "LightBlue" >
                <Label x:Name="label" HorizontalOptions="Center" VerticalOptions="Center">
                    <Label.Text>
                        <MultiBinding StringFormat = "{}{0:MMM dd, yyyy} - {1:MMM dd, yyyy}" >
                            <Binding Path="StartDateRange" />
                            <Binding Path = "EndDateRange" />
                        </MultiBinding>
                    </Label.Text>
                </Label>
                <Label HorizontalOptions="Center" VerticalOptions="End" Text="{Binding Text}" TextColor="Red" />
            </Grid>
        </DataTemplate>
        <DataTemplate x:Key="normaldatesTemplate">
            <Grid Background = "LightGreen" >
                <Label x:Name="label" HorizontalOptions="Center" VerticalOptions="Center">
                    <Label.Text>
                        <MultiBinding StringFormat = "{}{0:MMM dd, yyyy} - {1:MMM dd, yyyy}" >
                            <Binding Path="StartDateRange" />
                            <Binding Path = "EndDateRange" />
                        </MultiBinding>
                    </Label.Text>
                </Label>
                <Label HorizontalOptions="Center" VerticalOptions="End" Text="{Binding Text}" TextColor="Orange" />
            </Grid>
        </DataTemplate>
        <local:HeaderTemplateSelector x:Key="headerTemplateSelector" TodayDatesTemplate="{StaticResource todayDatesTemplate}"  NormaldatesTemplate="{StaticResource normaldatesTemplate}" />
    </Grid.Resources>
    <calendar:SfCalendar x:Name="calendar"
                           View="Month"
                           HeaderTemplate ="{StaticResource headerTemplateSelector}">
    </calendar:SfCalendar>
 </Grid>

{% endhighlight %}
{% highlight c# tabtitle="HeaderTemplateSelector.cs" %}

public class HeaderTemplateSelector : DataTemplateSelector
{
    public HeaderTemplateSelector()
    {
    }
    public DataTemplate TodayDatesTemplate { get; set; }
    public DataTemplate NormaldatesTemplate { get; set; }
    protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
    {
        var headerDetails = item as CalendarHeaderDetails;
        if (headerDetails != null)
        {
            if (headerDetails.StartDateRange.Date <= DateTime.Now.Date && headerDetails.EndDateRange >= DateTime.Now.Date)
                return TodayDatesTemplate;
        }
        return NormaldatesTemplate;
    }
}

{% endhighlight %}  
{% endtabs %}

N>
* When using data template selector, performance issues occur as the conversion template views take time within the framework.

## View header
You can customize all the properties of the View Header using [HeaderView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.calendar.CalendarMonthView.html#Syncfusion_Maui_Calendar_CalendarMonthView_HeaderView). By using this property, you can customize the Background, Height, TextFormat, and TextStyle of the calendar.

### Customize view header height
You can customize the view Header height `calendar` by using the `Height` property.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

<calendar:SfCalendar  x:Name="calendar"
                      View="Month">
            <calendar:SfCalendar.MonthView>
                <calendar:CalendarMonthView>
                    <calendar:CalendarMonthView.HeaderView>
                        <calendar:CalendarMonthHeaderView Height="50" />
                    </calendar:CalendarMonthView.HeaderView>
                </calendar:CalendarMonthView>
            </calendar:SfCalendar.MonthView>
</calendar:SfCalendar>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

this.calendar.MonthView.HeaderView.Height = 50;

{% endhighlight %}
{% endtabs %}

![Month view View Header Height Changed in .NET MAUI calendar.](images/header/maui-month-view-view-header-height-changed.png)

### View header appearance
You can customize the view header style of the `calendar` by using the [Background](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.calendar.CalendarMonthHeaderView.html#Syncfusion_Maui_Calendar_CalendarMonthHeaderView_Background), [TextStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.calendar.CalendarMonthHeaderView.html#Syncfusion_Maui_Calendar_CalendarMonthHeaderView_TextStyle), and [TextFormat](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.calendar.CalendarMonthHeaderView.html#Syncfusion_Maui_Calendar_CalendarMonthHeaderView_TextFormat) properties.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

<calendar:SfCalendar  x:Name="calendar"
                      View="Month">
            <calendar:SfCalendar.MonthView>
                <calendar:CalendarMonthView>
                    <calendar:CalendarMonthView.HeaderView>
                        <calendar:CalendarMonthHeaderView Background="Grey" TextFormat="ddd">
                            <calendar:CalendarMonthHeaderView.TextStyle>
                                <calendar:CalendarTextStyle TextColor="Black" FontSize="14" />
                            </calendar:CalendarMonthHeaderView.TextStyle>
                        </calendar:CalendarMonthHeaderView>
                    </calendar:CalendarMonthView.HeaderView>
                </calendar:CalendarMonthView>
            </calendar:SfCalendar.MonthView>
</calendar:SfCalendar>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

CalendarTextStyle textStyle = new CalendarTextStyle()
{
    TextColor = Colors.Black,
    FontSize = 14,
};

this.calendar.MonthView.HeaderView = new CalendarMonthHeaderView
{
    Background = Colors.Grey,
    TextFormat = "ddd",
    TextStyle = textStyle,
};

{% endhighlight %}
{% endtabs %}

![Month view View Header appearance Changed in .NET MAUI calendar.](images/header/maui-month-view-view-header-appearance-changed.png)

### View header appearance using DataTemplate

You can customize the view header appearance by using the [MonthViewHeaderTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.calendar.SfCalendar.html#Syncfusion_Maui_Calendar_SfCalendar_MonthViewHeaderTemplate) in the [SfCalendar](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.calendar.SfCalendar.html).

{% tabs %}  
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="3 9" %}

 <calendar:SfCalendar x:Name="calendar"
                        View="Month">
        <calendar:SfCalendar.MonthViewHeaderTemplate>
            <DataTemplate>
                <Grid Background ="#BB9AB1" >
                    <Label x:Name="label" HorizontalOptions="Center" VerticalOptions="Center" Text="{Binding StringFormat='{0:ddd}'}" TextColor="White" FontSize="14" FontFamily="Bold" />
                </Grid>
            </DataTemplate>
        </calendar:SfCalendar.MonthViewHeaderTemplate>
 </calendar:SfCalendar>

{% endhighlight %}
{% endtabs %}

![Month view View Header appearance changed using template in .NET MAUI calendar.](images/header/maui-month-view-view-header-data-template.png)

### View header appearance using DataTemplateSelector

You can customize the view header appearance by using the [MonthViewHeaderTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.calendar.SfCalendar.html#Syncfusion_Maui_Calendar_SfCalendar_MonthViewHeaderTemplate) in the [SfCalendar](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.calendar.SfCalendar.html). The `DataTemplateSelector` allows you to choose a `DataTemplate` at runtime based on the value bound to the calendar view header. This lets you select a different data template for each view header and customize the appearance of a specific view header based on certain conditions.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="17" %}

 <Grid>
    <Grid.Resources>
        <DataTemplate x:Key="normaldatesTemplate">
            <Grid Background = "lightBlue">
                <Label x:Name="label" HorizontalOptions="Center" VerticalOptions="Center" Text="{Binding StringFormat='{0:ddd}'}"  TextColor="Red" />
            </Grid>
        </DataTemplate>
        <DataTemplate x:Key="todayDatesTemplate">
            <Grid Background = "LightGreen" >
                <Label x:Name="label" HorizontalOptions="Center" VerticalOptions="Center" Text="{Binding StringFormat='{0:ddd}'}"  TextColor="Orange" />
            </Grid>
        </DataTemplate>
        <local:MonthViewHeaderTemplateSelector x:Key="monthViewHeaderTemplateSelector"  TodayDatesTemplate="{StaticResource todayDatesTemplate}"  NormaldatesTemplate="{StaticResource normaldatesTemplate}" />
    </Grid.Resources>
    <calendar:SfCalendar x:Name="calendar"
                           View="Month"
                           MonthViewHeaderTemplate ="{StaticResource monthViewHeaderTemplateSelector}">
    </calendar:SfCalendar>
 </Grid>

{% endhighlight %}
{% highlight c# tabtitle="MonthViewHeaderTemplateSelector.cs" %}

public class MonthViewHeaderTemplateSelector : DataTemplateSelector
{
    public MonthViewHeaderTemplateSelector()
    {
    }
    public DataTemplate TodayDatesTemplate { get; set; }
    public DataTemplate NormaldatesTemplate { get; set; }
    protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
    {
        var viewHeaderDetails = (DateTime)item;
        if (viewHeaderDetails.Date.Month == DateTime.Today)
            return TodayDatesTemplate;
        return NormaldatesTemplate;
    }
}

{% endhighlight %}  
{% endtabs %}

N>
* When using data template selector, performance issues occur as the conversion template views take time within the framework.
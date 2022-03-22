---
layout: post
title: Month View in .NET MAUI Scheduler control | Syncfusion
description: Learn here all about how to customize the appearance and change the date format for month view in Syncfusion .NET MAUI Scheduler (SfScheduler) control and more.
platform: maui
control: SfScheduler
documentation: ug
---

# Month View in .NET MAUI Scheduler (SfScheduler)

By default, the Month view displays the entire days of a particular month and current month initially. The current date color is differentiated from other dates of the current month, and also the color differentiation for dates will be applicable for the previous and next month dates.

By default, when an appointment is tried to create through Month view, it is considered to be created for an entire day.

N> The appointment views for each month cells will be updated depends on the month cells height. While resizing the layout, the following actions would be performed,
* If the appointment views overlaps with month cell dates or do not fit into the month cell height then the appointment view is changed from `AppointmentDisplayMode.Text` to `AppointmentDisplayMode.Indicator` view.
* If the indicator views overlaps with month cell dates, then the indicator view is changed from `AppointmentDisplayMode.Indicator` to `AppointmentDisplayMode.None.`

## Appointment display mode

The scheduler month view appointment display can be handled by using the `AppointmentDisplayMode` property of `MonthView.` By default, `AppointmentDisplayMode` is set to `Text,` using the `AppointmentDisplayMode.` 

You can set the month view appointments display as follows.

* [None](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerMonthAppointmentDisplayMode.html#Syncfusion_Maui_Scheduler_SchedulerMonthAppointmentDisplayMode_None):  Appointment will not be displayed.
* [Indicator](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerMonthAppointmentDisplayMode.html#Syncfusion_Maui_Scheduler_SchedulerMonthAppointmentDisplayMode_Indicator):  Appointment will be denoted as the circle.
* [Text](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerMonthAppointmentDisplayMode.html#Syncfusion_Maui_Scheduler_SchedulerMonthAppointmentDisplayMode_Text):  Appointment subject will be displayed in the month cell.

{% tabs %}  
{% highlight xaml %}

<scheduler:SfScheduler x:Name="Scheduler" 
                       View="Month">
    <scheduler:SfScheduler.MonthView>
        <scheduler:SchedulerMonthView 
                       AppointmentDisplayMode="Indicator"/>
    </scheduler:SfScheduler.MonthView>
</scheduler:SfScheduler>

{% endhighlight %}
{% highlight c# %}

this.Scheduler.View = SchedulerView.Month;
this.Scheduler.MonthView.AppointmentDisplayMode = SchedulerMonthAppointmentDisplayMode.Indicator;

{% endhighlight %}  
{% endtabs %}

![change-appointment-display-mode-in-maui-scheduler](images/month-view/change-appointment-display-mode-in-maui-scheduler.png)

N>
* [View scheduler appointment sample in GitHub](https://github.com/SyncfusionExamples/maui-scheduler-examples/tree/main/GettingStarted)

* [View business object sample in GitHub](https://github.com/SyncfusionExamples/maui-scheduler-examples/tree/main/BusinessObject)

## Hide leading and trailing dates

The previous and next month dates from a Scheduler month view can be hidden by using the `ShowLeadingAndTrailingDates` property in the `MonthView.` The `ShowLeadingAndTrailingDates` property defaults to `true.`

{% tabs %}  
{% highlight xaml %}

 <scheduler:SfScheduler x:Name="Scheduler" 
                        View="Month">
    <scheduler:SfScheduler.MonthView>
        <scheduler:SchedulerMonthView  
                       ShowLeadingAndTrailingDates="False"/>
    </scheduler:SfScheduler.MonthView>
 </scheduler:SfScheduler>

{% endhighlight %}
{% highlight c# %}

this.Scheduler.View = SchedulerView.Month;
this.Scheduler.MonthView.ShowLeadingAndTrailingDates = false;

{% endhighlight %}  
{% endtabs %}

![show-or-hide-leading-and-trailing-days-appearence-customization-in-maui-scheduler](images/month-view/show-or-hide-leading-and-trailing-days-appearence-customization-in-maui-scheduler.png)

## Change day format of view header

Customize the day format of Scheduler view header by using the `DayFormat` property of `ViewHeaderSettings` in `MonthView.`

{% tabs %}  
{% highlight xaml %}

<scheduler:SfScheduler x:Name="Scheduler" 
                       View="Month">
    <scheduler:SfScheduler.MonthView>
        <scheduler:SchedulerMonthView>
            <scheduler:SchedulerMonthView.ViewHeaderSettings>
                <scheduler:SchedulerViewHeaderSettings DayFormat="dddd" />
            </scheduler:SchedulerMonthView.ViewHeaderSettings>
        </scheduler:SchedulerMonthView>
    </scheduler:SfScheduler.MonthView>
</scheduler:SfScheduler>

{% endhighlight %}
{% highlight c# %}

this.Scheduler.View = SchedulerView.Month;
this.Scheduler.MonthView.ViewHeaderSettings.DayFormat = "dddd";

{% endhighlight %}  
{% endtabs %}

![change-day-text-format-of-month-view-header-in-maui-scheduler](images/month-view/change-day-text-format-of-month-view-header-in-maui-scheduler.png)

### View header height

The height of the ViewHeader can be customized by setting the `Height` property of `ViewHeaderSettings` in `MonthView.`

{% tabs %}
{% highlight xaml %}

 <scheduler:SfScheduler x:Name="Scheduler" 
                        View="Month">
    <scheduler:SfScheduler.MonthView>
        <scheduler:SchedulerMonthView>
            <scheduler:SchedulerMonthView.ViewHeaderSettings>
                <scheduler:SchedulerViewHeaderSettings Height="100" />
            </scheduler:SchedulerMonthView.ViewHeaderSettings>
        </scheduler:SchedulerMonthView>
    </scheduler:SfScheduler.MonthView>
 </scheduler:SfScheduler>

{% endhighlight %}
{% highlight c# %}

this.Scheduler.View = SchedulerView.Month;
this.Scheduler.MonthView.ViewHeaderSettings.Height = 100;

{% endhighlight %}
{% endtabs %}

![customize-view-header-height-in-month-view-in-maui-scheduler](images/month-view/customize-view-header-height-in-month-view-in-maui-scheduler.png)

### Customize view header appearance using text style

Customize the month view header day text style, day format and background color by using the `DayTextStyle,` `DayFormat` and `Background` of `ViewHeaderSettings` properties of `MonthView` respectively.

{% tabs %}  
{% highlight xaml %}

 <scheduler:SfScheduler x:Name="Scheduler" 
                        View="Month">
    <scheduler:SfScheduler.MonthView>
        <scheduler:SchedulerMonthView>
            <scheduler:SchedulerMonthView.ViewHeaderSettings>
                <scheduler:SchedulerViewHeaderSettings DayFormat="dddd"
                                                       Background="LightSkyBlue"/>
            </scheduler:SchedulerMonthView.ViewHeaderSettings>
        </scheduler:SchedulerMonthView>
    </scheduler:SfScheduler.MonthView>
</scheduler:SfScheduler>

{% endhighlight %}
{% highlight c# %}

var dayTextStyle = new SchedulerTextStyle()
{
    TextColor = Colors.DarkBlue,
    FontSize = 14,
};
this.Scheduler.View = SchedulerView.Month;
this.Scheduler.MonthView.ViewHeaderSettings.Background = Brush.LightSkyBlue;
this.Scheduler.MonthView.ViewHeaderSettings.DayFormat = "dddd";
this.Scheduler.MonthView.ViewHeaderSettings.DayTextStyle = dayTextStyle;

{% endhighlight %}  
{% endtabs %}

![customize-day-text-format-appearence-of-month-view-header-in-maui-scheduler](images/month-view/customize-day-text-format-appearence-of-month-view-header-in-maui-scheduler.png)

### Customize view header appearance using DataTemplate

You can customize the view header appearance by using the `ViewHeaderTemplate` property of `MonthView` in the `SfScheduler.`

{% tabs %}  
{% highlight xaml %}    

 <scheduler:SfScheduler x:Name="Scheduler" 
                        View="Month">
    <scheduler:SfScheduler.MonthView>
        <scheduler:SchedulerMonthView>
            <scheduler:SchedulerMonthView.ViewHeaderTemplate>
                <DataTemplate>
                    <Grid Background = "BlueViolet" >
                        <Label x:Name="label" HorizontalOptions="Center" VerticalOptions="Center" Text="{Binding StringFormat='{0:ddd}'}" TextColor="White" FontSize="Subtitle" FontFamily="Bold" />
                    </Grid>
                </DataTemplate>
            </scheduler:SchedulerMonthView.ViewHeaderTemplate>
        </scheduler:SchedulerMonthView>
    </scheduler:SfScheduler.MonthView>
 </scheduler:SfScheduler>

{% endhighlight %}
{% endtabs %}

![customize-view-header-appearance-using-template-in-month-view-in-maui-scheduler](images/month-view/customize-view-header-appearance-using-template-in-month-view-in-maui-scheduler.png)

### Customize view header appearance using DataTemplateSelector

You can customize the view header appearance by using the `ViewHeaderTemplate` property of `MonthView` in the `SfScheduler.` The `DataTemplateSelector` can choose a `DataTemplate` at runtime based on the value of a data-bound to scheduler view header by using the `ViewHeaderTemplate.` It allows you to choose a different data template for each view header, as well as customize the appearance of a particular view header based on certain conditions.

{% tabs %}
{% highlight xaml %}

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
    <scheduler:SfScheduler x:Name="Scheduler" 
                           View="Month">
        <scheduler:SfScheduler.MonthView>
            <scheduler:SchedulerMonthView ViewHeaderTemplate = "{StaticResource monthViewHeaderTemplateSelector}"/>
        </scheduler:SfScheduler.MonthView>
    </scheduler:SfScheduler>
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
        if (viewHeaderDetails.Date.Month == DateTime.Today.Month)
            return TodayDatesTemplate;
        return NormaldatesTemplate;
    }
}

{% endhighlight %}  
{% endtabs %}

N>
* When using data template selector, performance issues occur as the conversion template views take time within the framework.

## Month cell appearance

The month cell can be customized by using the `MonthView` property of the `SfScheduler.`

### Customize month cell appearance using text style

By using the `CellStyle` property of `MonthView,` the month properties such as `Background,` `TodayBackground,` `TrailingMonthBackground,` `LeadingMonthBackground,` `TextStyle,` `TrailingMonthTextStyle,` and `LeadingMonthTextStyle` can be customized.

{% tabs %}  
{% highlight xaml %}

<scheduler:SfScheduler x:Name="Scheduler" 
                       View="Month">
</scheduler:SfScheduler>

{% endhighlight %}
{% highlight c# %}

this.Scheduler.View = SchedulerView.Month;
var textStyle = new SchedulerTextStyle()
{
    TextColor = Colors.DarkBlue,
    FontSize = 14,
};

var leadingMonthTextStyle = new SchedulerTextStyle()
{
    TextColor = Colors.Red,
    FontSize = 14,
};

var trailingMonthTextStyle = new SchedulerTextStyle()
{
    TextColor = Colors.Red,
    FontSize = 14,
};

var monthCellStyle = new SchedulerMonthCellStyle()
{
    Background = Brush.LightSkyBlue,
    TodayBackground = Brush.LightBlue,
    LeadingMonthBackground = Brush.LightGreen,
    TrailingMonthBackground = Brush.LightYellow,
    TextStyle = textStyle,
    LeadingMonthTextStyle = leadingMonthTextStyle,
    TrailingMonthTextStyle = trailingMonthTextStyle
};

this.Scheduler.MonthView.CellStyle = monthCellStyle;

{% endhighlight %}  
{% endtabs %}

![customize-month-cell-appearance-in-maui-scheduler](images/month-view/customize-month-cell-appearance-in-maui-scheduler.png)

### Customize month cell appearance using DataTemplate

You can customize the month cell appearance by using the `CellTemplate` property of `MonthView` in the `SfScheduler.`

{% tabs %}
{% highlight xaml %}

 <scheduler:SfScheduler x:Name="Scheduler" 
                        View="Month">
    <scheduler:SfScheduler.MonthView>
        <scheduler:SchedulerMonthView>
            <scheduler:SchedulerMonthView.CellTemplate>
                <DataTemplate>
                    <Border Background = "BlueViolet">
                        <Label HorizontalTextAlignment="Center" TextColor="White" Text="{Binding DateTime.Day}"/>
                    </Border>
                </DataTemplate>
            </scheduler:SchedulerMonthView.CellTemplate>
        </scheduler:SchedulerMonthView>
    </scheduler:SfScheduler.MonthView>
 </scheduler:SfScheduler>

{% endhighlight %}
{% endtabs %}

![customize-month-cell-appearance-using-template-in-month-view-in-maui-scheduler](images/month-view/customize-month-cell-appearance-using-template-in-month-view-in-maui-scheduler.png)

N>
* The BindingContext of the `CellTemplate` is the `SchedulerMonthCellDetails.`

### Customize month cell appearance using DataTemplateSelector

You can customize the month cell appearance by using the `CellTemplate` property of `MonthView` in the `SfScheduler.` The `DataTemplateSelector` can choose a `DataTemplate` at runtime based on the value of a data-bound to scheduler month cells by using the `CellTemplate.` It allows you to choose a different data template for each month cell, as well as customize the appearance of a particular month cell based on certain conditions.

{% tabs %}
{% highlight xaml %}

<Grid>
    <Grid.Resources>
        <DataTemplate x:Key="normalDateTemplate">
            <Border Background = "BlueViolet">
                <Label HorizontalTextAlignment="Center" TextColor="White" Text="{Binding DateTime.Day}"/>
            </Border>
        </DataTemplate>
        <DataTemplate x:Key="todayDateTemplate">
            <Border Background = "BlueViolet">
                <Label HorizontalTextAlignment="Center" TextColor="Yellow" Text="{Binding DateTime.Day}"/>
            </Border>
        </DataTemplate>
        <local:MonthCellTemplateSelector x:Key="monthCellTemplateSelector" TodayDateTemplate="{StaticResource todayDateTemplate}" NormalDateTemplate="{StaticResource normalDateTemplate}"/>
    </Grid.Resources>
    <scheduler:SfScheduler x:Name="Scheduler" 
                           View="Month" >
        <scheduler:SfScheduler.MonthView>
            <scheduler:SchedulerMonthView CellTemplate="{StaticResource monthCellTemplateSelector}" />
        </scheduler:SfScheduler.MonthView>
    </scheduler:SfScheduler>
 </Grid>

{% endhighlight %}
{% highlight c# tabtitle="MonthCellTemplateSelector.cs" %}

public class MonthCellTemplateSelector : DataTemplateSelector
{
    public MonthCellTemplateSelector()
    {
    }
    public DataTemplate NormalDateTemplate { get; set; }
    public DataTemplate TodayDateTemplate { get; set; }
    protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
    {
        var monthCellDetails = item as SchedulerMonthCellDetails;
        if (monthCellDetails.DateTime.Date == DateTime.Today.Date)
            return TodayDateTemplate;
        else
            return NormalDateTemplate;
    }
}

{% endhighlight %}  
{% highlight c# %}

this.Scheduler.View = SchedulerView.Month;

{% endhighlight %} 
{% endtabs %}

N>
* The BindingContext of the `CellTemplate` is the `SchedulerMonthCellDetails.`
* When using data template selector, performance issues occur as the conversion template views take time within the framework.
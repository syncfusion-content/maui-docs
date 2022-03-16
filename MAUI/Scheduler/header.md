---
layout: post
title: Header in .NET MAUI Scheduler control | Syncfusion
description: Learn here all about to customize header height, date format and appearance of Syncfusion .NET MAUI Scheduler (SfScheduler) control and more. 
platform: maui
control: SfScheduler
documentation: ug
---

# Header in .NET MAUI Scheduler (SfScheduler)

You can learn about SfScheduler's header height, date format, and appearance support of the SfScheduler.

## Customize header height in scheduler

You can customize the default `Height` property of the `HeaderView` in the `SfScheduler.` By default, the header height is `50.`

{% tabs %}  
{% highlight xaml %}

<scheduler:SfScheduler x:Name="Scheduler" 
                       View="Week">
    <scheduler:SfScheduler.HeaderView>
        <scheduler:SchedulerHeaderView Height="100">
        </scheduler:SchedulerHeaderView>
    </scheduler:SfScheduler.HeaderView>
</scheduler:SfScheduler>

{% endhighlight %}
{% highlight c# %}

this.Scheduler.View = SchedulerView.Week;
this.Scheduler.HeaderView.Height = 100;

{% endhighlight %}  
{% endtabs %}

## Header date format

The header date format can be customized by using the `TextFormat` property of the `SfScheduler.` By default, the header text format is `MMMM yyyy.`

{% tabs %}  
{% highlight xaml %}

<scheduler:SfScheduler x:Name="Scheduler" 
                       View="Week">
    <scheduler:SfScheduler.HeaderView>
        <scheduler:SchedulerHeaderView TextFormat="MMM yy">
        </scheduler:SchedulerHeaderView>
    </scheduler:SfScheduler.HeaderView>
</scheduler:SfScheduler>

{% endhighlight %}
{% highlight c# %}

this.Scheduler.View = SchedulerView.Week;
this.Scheduler.HeaderView.TextFormat = "MMM yy";

{% endhighlight %}
{% endtabs %}

## Header appearance

The header can be customized by using the `HeaderView` property of the `SfScheduler.`

### Customize header appearance using Style

You can style the background color, and textStyle by using the properties such as `Background,` and `TextStyle` properties of `HeaderView.`

{% tabs %}
{% highlight xaml %}

 <scheduler:SfScheduler x:Name="Scheduler" 
                        View="Week">
    <scheduler:SfScheduler.HeaderView>
        <scheduler:SchedulerHeaderView Background="LightGreen">
        </scheduler:SchedulerHeaderView>
    </scheduler:SfScheduler.HeaderView>
 </scheduler:SfScheduler>

{% endhighlight %}
{% highlight c# %}

var textStyle = new SchedulerTextStyle()
{
    TextColor = Colors.DarkBlue,
    FontSize = 14,
};

this.Scheduler.View = SchedulerView.Week;
this.Scheduler.HeaderView.TextStyle = textStyle;
this.Scheduler.HeaderView.Background = Brush.LightGreen;

{% endhighlight %}  
{% endtabs %}

### Customize header appearance using DataTemplate

You can customize the header appearance of scheduler by using the `HeaderTemplate` property of `HeaderView.`

{% tabs %}
{% highlight xaml %}

  <scheduler:SfScheduler x:Name="Scheduler" 
                         View="Week">
    <scheduler:SfScheduler.HeaderView>
        <scheduler:SchedulerHeaderView>
            <scheduler:SchedulerHeaderView.HeaderTemplate>
                <DataTemplate>
                    <Grid Background = "LightBlue">
                        <Label x:Name="label" HorizontalOptions="Center" VerticalOptions="Center">
                            <Label.Text>
                                <MultiBinding StringFormat = "{}{0:MMM dd, yyyy} - {1:MMM dd, yyyy}">
                                    <Binding Path="StartDate" />
                                    <Binding Path = "EndDate" />
                                </MultiBinding>
                            </Label.Text>
                        </Label>
                        <Label  HorizontalOptions="Center" VerticalOptions="End" Text="{Binding Text}" TextColor="Red" />
                    </Grid>
                </DataTemplate>
            </scheduler:SchedulerHeaderView.HeaderTemplate>
        </scheduler:SchedulerHeaderView>
    </scheduler:SfScheduler.HeaderView>
 </scheduler:SfScheduler>

{% endhighlight %}
{% endtabs %}

### Customize header appearance using DataTemplateSelector

You can customize the header appearance of scheduler by using the `HeaderTemplate` property of `HeaderView.` The `DataTemplateSelector` can choose a `DataTemplate` at runtime based on the value of a data-bound to scheduler header by using the `HeaderTemplate.` It lets to choose a different data template for each header, customizing the appearance of a particular header based on certain conditions.

{% tabs %}
{% highlight xaml %}

 <Grid>
    <Grid.Resources>
        <DataTemplate x:Key="todayDatesTemplate">
            <Grid Background = "LightBlue" >
                <Label x:Name="label" HorizontalOptions="Center" VerticalOptions="Center">
                    <Label.Text>
                        <MultiBinding StringFormat = "{}{0:MMM dd, yyyy} - {1:MMM dd, yyyy}" >
                            <Binding Path="StartDate" />
                            <Binding Path = "EndDate" />
                        </MultiBinding >
                    </Label.Text >
                </Label >
                <Label  HorizontalOptions="Center" VerticalOptions="End" Text="{Binding Text}" TextColor="Red" />
            </Grid>
        </DataTemplate>
        <DataTemplate x:Key="normaldatesTemplate">
            <Grid Background = "LightGreen" >
                <Label x:Name="label" HorizontalOptions="Center" VerticalOptions="Center">
                    <Label.Text>
                        <MultiBinding StringFormat = "{}{0:MMM dd, yyyy} - {1:MMM dd, yyyy}" >
                            <Binding Path="StartDate" />
                            <Binding Path = "EndDate" />
                        </MultiBinding >
                    </Label.Text >
                </Label>
                <Label  HorizontalOptions="Center" VerticalOptions="End" Text="{Binding Text}" TextColor="Orange" />
            </Grid>
        </DataTemplate>
        <local:HeaderTemplateSelector x:Key="headerTemplateSelector" TodayDatesTemplate="{StaticResource todayDatesTemplate}"  NormaldatesTemplate="{StaticResource normaldatesTemplate}" />
    </Grid.Resources>
    <scheduler:SfScheduler x:Name="Scheduler" 
                           View="Week">
        <scheduler:SfScheduler.HeaderView>
            <scheduler:SchedulerHeaderView HeaderTemplate = "{StaticResource headerTemplateSelector}" />
        </scheduler:SfScheduler.HeaderView>
    </scheduler:SfScheduler>
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
        var headerDetails = item as SchedulerHeaderDetails;
        if (headerDetails != null)
        {
            if (headerDetails.StartDate.Date <= DateTime.Now.Date && headerDetails.EndDate >= DateTime.Now.Date)
                return TodayDatesTemplate;
        }
        return NormaldatesTemplate;
    }
}

{% endhighlight %}  
{% endtabs %}
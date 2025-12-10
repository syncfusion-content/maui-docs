---
layout: post
title: Working with .NET MAUI Smart Scheduler control | Syncfusion®
description: Learn here all about working with Syncfusion<sup>&reg;</sup> .NET MAUI Smart Scheduler(SfSmartScheduler) control.
platform: maui
control: SfSmartScheduler
documentation: ug
keywords : .net maui smart scheduler  
---

# Working with .NET MAUI Smart Scheduler (SfSmartScheduler)

## Enable assist button

The `.NET MAUI Smart Scheduler` assist button interaction can be enabled or disabled by setting the `EnableAssistButton` property of the `SfSmartScheduler` control. By default, the `EnableAssistButton` property is set to true.

{% tabs %}
{% highlight XAML hl_lines="2" %}

 <smartScheduler:SfSmartScheduler x:Name="Scheduler" EnableAssistButton="False"/>

{% endhighlight %}
{% highlight C# hl_lines="3" %}

SfSmartScheduler scheduler = new SfSmartScheduler();
smartScheduler.EnableAssistButton = false;
this.Content = scheduler;

{% endhighlight %}
{% endtabs %}

## Customize assist button appearance using DataTemplate

The assist button appearance can be customized by using the `AssistButtonTemplate` property of `SfSmartScheduler` control.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="3 4 5 6 7 8 9 10 11 12 13" %}

 <smartScheduler:SfSmartScheduler x:Name="Scheduler">
    <smartScheduler:SfSmartScheduler.AssistButtonTemplate>
     <DataTemplate>
         <Grid BackgroundColor="#6750A4">
             <Label Text="AI"
                FontAttributes="Bold"
                TextColor="#FFFFFF"
                VerticalOptions="Center"
                HorizontalOptions="Center" />
         </Grid>
     </DataTemplate>
 </smartScheduler:SfSmartScheduler.AssistButtonTemplate>
 </scheduler:SfSmartScheduler>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

SfSmartScheduler smartScheduler = new SfSmartScheduler();
smartScheduler.AssistButtonTemplate = new DataTemplate(() =>
{
    var grid = new Grid
    {
        BackgroundColor = Color.FromArgb("#6750A4")
    };

    var label = new Label
    {
        Text = "AI",
        FontAttributes = FontAttributes.Bold,
        TextColor = Color.FromArgb("#FFFFFF"),
        HorizontalOptions = LayoutOptions.Center,
        VerticalOptions = LayoutOptions.Center
    };

    grid.Add(label);
    return grid;
});
this.Content = smartScheduler;

{% endhighlight %}
{% endtabs %}
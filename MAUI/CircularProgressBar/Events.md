---
layout: post
title: Events in .NET MAUI Circular ProgressBar control | Syncfusion<sup>&reg;</sup>Syncfusion<sup>&reg;</sup>
description: Learn here all about Events support in Syncfusion<sup>&reg;</sup> .NET MAUI Circular ProgressBar control, its elements and more.
platform: MAUI
control: SfCircularProgressBar
documentation: ug
---

# Events in .NET MAUI Circular ProgressBar (SfCircularProgressBar)

## ProgressChanged

This event is triggered when the progress value is changed. This event contains the following event argument.

* [`Progress:`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.ProgressValueEventArgs.html#Syncfusion_Maui_ProgressBar_ProgressValueEventArgs_Progress) Represents the progress value.

The following code sample demonstrates how to customize the color of a progress indicator based on progress using this event. 

{% tabs %} 

{% highlight xaml %}

<progressBar:SfCircularProgressBar x:Name="circularProgressBar" 
                                   ProgressChanged="CircularProgressBar_ProgressChanged"
                                   Progress="100" />

{% endhighlight %}

{% highlight c# %}

private void CircularProgressBar_ProgressChanged(object sender, ProgressValueEventArgs e)
{
    if (e.Progress < 50)
    {
        this.circularProgressBar.ProgressFill = Colors.Red;
    }
    else
    {
        this.circularProgressBar.ProgressFill = Colors.Green;
    }
}

{% endhighlight %}

{% endtabs %} 

## ProgressCompleted

This event is triggered when the [`Progress`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.ProgressBarBase.html#Syncfusion_Maui_ProgressBar_ProgressBarBase_Progress) attains the [`Maximum`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.ProgressBarBase.html#Syncfusion_Maui_ProgressBar_ProgressBarBase_Maximum) value. This event contains the following argument.

* [`Progress:`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.ProgressValueEventArgs.html#Syncfusion_Maui_ProgressBar_ProgressValueEventArgs_Progress) Represents the progress value.

The following code sample demonstrates how to customize the progress bar when the progress reaches maximum using this event. 

{% tabs %} 

{% highlight xaml %}

<progressBar:SfCircularProgressBar Minimum="100" 
                                   Maximum="500" 
                                   ProgressCompleted="CircularProgressBar_ProgressCompleted" 
                                   Progress="500">
    <progressBar:SfCircularProgressBar.Content>
        <Grid WidthRequest="150">
            <Label x:Name="Label" 
                   Text="Start" 
                   FontSize="15"
                   HorizontalTextAlignment="Center" 
                   VerticalTextAlignment="Center" />
        </Grid>
    </progressBar:SfCircularProgressBar.Content>
</progressBar:SfCircularProgressBar>

{% endhighlight %}

{% highlight c# %}

private void CircularProgressBar_ProgressCompleted(object sender, ProgressValueEventArgs e)
{
    this.Label.Text = "Completed";
}

{% endhighlight %}

{% endtabs %} 

N> Refer to our [.NET MAUI Circular ProgressBar](https://www.syncfusion.com/maui-controls/maui-progressbar) feature tour page for its groundbreaking feature representations. Also explore our [.NET MAUI Circular ProgressBar example](https://github.com/syncfusion/maui-demos/) that shows how to configure a SfCircularProgressBar in .NET MAUI.
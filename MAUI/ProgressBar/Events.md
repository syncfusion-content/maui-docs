---
layout: post
title: Events in .NET MAUI ProgressBar control | Syncfusion
description: Learn here all about Events support in Syncfusion .NET MAUI ProgressBar control, its elements and more.
platform: MAUI
control: ProgressBar
documentation: ug
---

# Events in .NET MAUI ProgressBar (Progress Bar)

## ProgressChanged

This event is triggered when the progress value is changed. This event contains the following event argument.

* `Progress:` Represents the progress value.

The following code sample demonstrates how to customize the color of a progress indicator based on progress using this event. 

{% tabs %} 

{% highlight xaml %}

<progressBar:SfLinearProgressBar x:Name="LinearProgressBar" 
                                 ProgressChanged="LinearProgressBar_ProgressChanged" 
                                 Progress="100" />

{% endhighlight %}

{% highlight c# %}

private void LinearProgressBar_ProgressChanged(object sender, ProgressValueEventArgs e)
{
    if (e.Progress < 50)
    {
        this.LinearProgressBar.ProgressFill = Colors.Red;
    }
    else if (e.Progress >= 50)
    {
        this.LinearProgressBar.ProgressFill = Colors.Green;
    }
}

{% endhighlight %}

{% endtabs %} 

## ProgressCompleted

This event is triggered when the `Progress` attains the `Maximum` value. This event contains the following argument.

* `Progress:` Represents the progress value.

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

N> You can refer to our `.NET MAUI ProgressBar` feature tour page for its groundbreaking feature representations. You can also explore our [.NET MAUI ProgressBar example](https://github.com/syncfusion/maui-demos/) that shows how to configure a ProgressBar in .NET MAUI.
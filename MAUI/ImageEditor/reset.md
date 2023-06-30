---
layout: post
title: Reset image .NET MAUI ImageEditor control | Syncfusion
description: Learn about reset support in the Syncfusion .NET MAUI ImageEditor(SfImageEditor) control and more.
platform: .NET MAUI
control: SfImageEditor
documentation: ug
---

# Reset image using .NET MAUI Image Editor (SfImageEditor)

The [`Reset`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.SfImageEditor.html#Syncfusion_Maui_ImageEditor_SfImageEditor_Reset) method, resets an image to its original state by discarding the changes performed to it. You can start fresh and explore different creative possibilities. The complete set of changes made in the image and also resets the image to the original loaded image.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

   <Grid RowDefinitions="0.9*, 0.1*">
        <imageEditor:SfImageEditor x:Name="imageEditor"
                                   Source="image.jpeg" />
        <Button Grid.Row="1"
                Text="Reset"
                Clicked="OnResetClicked" />
    </Grid>  

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

    private void OnResetClicked(object sender, EventArgs e)
    {
        this.imageEditor.Reset();
    }

{% endhighlight %}
{% endtabs %}

## Reset image event

This [`BeginReset`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.SfImageEditor.html#Syncfusion_Maui_ImageEditor_SfImageEditor_BeginReset) event occurs before resetting the changes made in an image. You can control the reset functionality using the cancel argument.

{% tabs %}

{% highlight xaml tabtitle="MainPage.xaml" %}

    <imageEditor:SfImageEditor Source="image.png" BeginReset = "OnBeginReset" />

{% endhighlight %}

{% highlight C# tabtitle="MainPage.xaml.cs" %}
            
    private void OnBeginReset(object sender, CancelEventArgs e)
    {
         e.Cancel = true;
    }

{% endhighlight %}

{% endtabs %}

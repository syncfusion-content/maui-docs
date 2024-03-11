---
layout: post
title: Z-Ordering in .NET MAUI Image Editor control | Syncfusion
description: Learn here all about Z-Ordering support in Syncfusion .NET MAUI Image Editor(SfImageEditor) control.
platform: maui
control: ImageEditor
documentation: ug
---

# Z-Ordering in .NET MAUI Image Editor (SfImageEditor)

The image editor control allows to change the position of annotations that are arranged over the editor. This can be achieved using the following methods:

1. BringToFront
2. SendToBack
3. BringForward
4. SendBackward

## BringToFront

The `BringToFront` method is used to bring the selected annotation to the front of a group of elements over an image.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

   <Grid RowDefinitions="0.9*, 0.1*">
        <imageEditor:SfImageEditor x:Name="imageEditor"
                                   Source="image.jpeg" />
        <Button Grid.Row="1"
                Text = "BringToFront"  
                Clicked="OnBringToFrontClicked" />
    </Grid>  

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

   private void OnBringToFrontClicked(object sender, EventArgs e)
   {
      this.imageEditor.BringToFront();
   }

{% endhighlight %}
{% endtabs %}

## SendToBack

The `SendToBack` method is used to send the selected annotation to the back of a group of elements over an image.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

   <Grid RowDefinitions="0.9*, 0.1*">
        <imageEditor:SfImageEditor x:Name="imageEditor"
                                   Source="image.jpeg" />
        <Button Grid.Row="1"
                Text = "SendToBack"  
                Clicked="OnSendToBackClicked" />
    </Grid>  

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

   private void OnSendToBackClicked(object sender, EventArgs e)
   {
      this.imageEditor.SendToBack();
   }

{% endhighlight %}
{% endtabs %}

## BringForward

The `BringForward` method is used to bring the selected annotation to one step front of a group of elements over an image.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

   <Grid RowDefinitions="0.9*, 0.1*">
        <imageEditor:SfImageEditor x:Name="imageEditor"
                                   Source="image.jpeg" />
        <Button Grid.Row="1"
                Text = "BringForward"  
                Clicked="OnBringForwardClicked" />
    </Grid>  

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

   private void OnBringForwardClicked(object sender, EventArgs e)
   {
      this.imageEditor.BringForward();
   }

{% endhighlight %}
{% endtabs %}

## SendBackward

The `SendBackward` method is used to send the selected annotation to one step backward of a group of elements over an image.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

   <Grid RowDefinitions="0.9*, 0.1*">
        <imageEditor:SfImageEditor x:Name="imageEditor"
                                   Source="image.jpeg" />
        <Button Grid.Row="1"
                Text = "SendBackward"  
                Clicked="OnSendBackwardClicked" />
    </Grid>  

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

   private void OnSendBackwardClicked(object sender, EventArgs e)
   {
      this.imageEditor.SendBackward();
   }

{% endhighlight %}
{% endtabs %}


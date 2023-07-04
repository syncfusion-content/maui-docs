---
layout: post
title: Undo Redo editing in .NET MAUI Image Editor Control | Syncfusion
description: Learn about Undo Redo support in the Syncfusion .NET MAUI ImageEditor(SfImageEditor) control and more.
platform: .NET MAUI
control: SfImageEditor
documentation: ug
---

# Undo Redo in .NET MAUI Image Editor (SfImageEditor)

One of the important features of the image editor control is to perform `Undo` and `Redo` to revert the edited changes.

## Undo

The [`Undo`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.SfImageEditor.html#Syncfusion_Maui_ImageEditor_SfImageEditor_Undo) method is used to revert the changes done previously over an image.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

   <Grid RowDefinitions="0.9*, 0.1*">
        <imageEditor:SfImageEditor x:Name="imageEditor"
                                   Source="image.jpeg" />
        <Button Grid.Row="1"
                Text="Save"
                Clicked="OnUndoClicked" />
    </Grid>  

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

    private void OnUndoClicked(object sender, EventArgs e)
    {
        this.imageEditor.Undo();
    }

{% endhighlight %}
{% endtabs %}

## Redo

The [`Redo`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.SfImageEditor.html#Syncfusion_Maui_ImageEditor_SfImageEditor_Redo) method is used to redo the changes that are reverted by undo operation.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

   <Grid RowDefinitions="0.9*, 0.1*">
        <imageEditor:SfImageEditor x:Name="imageEditor"
                                   Source="image.jpeg" />
        <Button Grid.Row="1"
                Text="Save"
                Clicked="OnRedoClicked" />
    </Grid>  

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

    private void OnRedoClicked(object sender, EventArgs e)
    {
        this.imageEditor.Redo();
    }

{% endhighlight %}
{% endtabs %}

---
layout: post
title: Events in .NET MAUI Rotator control | Syncfusion®
description: Learn about Events support in Syncfusion® .NET MAUI Rotator (SfRotator) control, its elements, and more.
platform: maui
control: Rotator
documentation: ug
---

# Events in .NET MAUI Rotator (SfRotator)

## Prerequisites

Before using the [SfRotator](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Rotator.SfRotator.html), ensure the following NuGet package is installed in your .NET MAUI project:

- `Syncfusion.Maui.Rotator`

For step-by-step setup, refer to the [Getting Started](https://help.syncfusion.com/maui/rotator/getting-started) documentation.

## Overview

The [`SfRotator`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Rotator.SfRotator.html) control exposes events that you can handle to respond to user interaction and selection changes. This page covers:

* **SelectedIndexChanged** — raised when the selected item changes.
* **ItemTapped** — raised when an item is tapped.

## Events Reference

| Event | EventArgs | Description |
|-------|-----------|-------------|
| `SelectedIndexChanged` | [`SelectedIndexChangedEventArgs`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Rotator.SelectedIndexChangedEventArgs.html) | Raised when the selected item changes (by swipe, tap, or by setting the `SelectedIndex` property). |
| `ItemTapped` | `EventArgs` | Raised when an item is tapped. Use the `SelectedIndex` property to identify the tapped item. |


## SelectedIndexChanged Event

The [`SelectedIndexChanged`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Rotator.SfRotator.html#Syncfusion_Maui_Rotator_SfRotator_SelectedIndexChanged) event is raised when the selected item changes, either by swiping between items, by tapping a thumbnail or dot, or by setting the [`SelectedIndex`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Rotator.SfRotator.html#Syncfusion_Maui_Rotator_SfRotator_SelectedIndex) property programmatically.

The [`SelectedIndexChangedEventArgs`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Rotator.SelectedIndexChangedEventArgs.html) provides the following members:

| Member | Type | Description |
|--------|------|-------------|
| `Index` | `int` | The currently selected index. |
| `OldIndex` | `int` | The previously selected index. |

{% tabs %}

{% highlight xaml %}


<rotator:SfRotator x:Name="rotator"
                    ItemsSource="{Binding ImageCollection}"
                    SelectedIndexChanged="Rotator_SelectedIndexChanged"
                    VerticalOptions="Start">
    <rotator:SfRotator.ItemTemplate>
        <DataTemplate>
            <Image Source="{Binding Image}" />
        </DataTemplate>
    </rotator:SfRotator.ItemTemplate>
</rotator:SfRotator>
    
{% endhighlight %}
{% highlight C# %}
    
 RotatorViewModel rotatorViewModel = new RotatorViewModel();
 SfRotator rotator = new SfRotator()
 {
    VerticalOptions = LayoutOptions.Start,
    ItemsSource = rotatorViewModel.ImageCollection,
    ItemTemplate = new DataTemplate(() =>
    {
        var image = new Image();
        image.SetBinding(Image.SourceProperty, "Image");
        return image;
    }),
};
rotator.SelectedIndexChanged += Rotator_SelectedIndexChanged;

private void Rotator_SelectedIndexChanged(object sender, SelectedIndexChangedEventArgs e)
{
    // e.Index is the new index; e.OldIndex is the previous index.
    DisplayAlert("Notification",
        $"Selected index changed from {e.OldIndex} to {e.Index}",
        "OK");
}
 
{% endhighlight %}
{% highlight c# tabtitle="ViewModel" %}

// Model
public class RotatorModel
{
    public RotatorModel(string imageString)
    {
        Image = imageString;
    }
    private string _image;
    public string Image
    {
        get { return _image; }
        set { _image = value; }
    }
}

// ViewModel
public class RotatorViewModel
{
    public RotatorViewModel()
    {
        imageCollection = new List<RotatorModel>
        {
            new RotatorModel("image1.png"),
            new RotatorModel("image2.png"),
            new RotatorModel("image3.png"),
            new RotatorModel("image4.png"),
            new RotatorModel("image5.png")
        };
    }
    private List<RotatorModel> imageCollection;
    public List<RotatorModel> ImageCollection
    {
        get { return imageCollection; }
        set { imageCollection = value; }
    }
}

{% endhighlight %}
{% endtabs %}


![SfRotator SelectedIndexChanged event](images/SelectedIndexChanged.png)

## ItemTapped Event

The [`ItemTapped`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Rotator.SfRotator.html#Syncfusion_Maui_Rotator_SfRotator_ItemTapped) event is raised when an item in the [`SfRotator`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Rotator.SfRotator.html) is tapped. The event does not provide item data; use the [`SelectedIndex`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Rotator.SfRotator.html#Syncfusion_Maui_Rotator_SfRotator_SelectedIndex) property to identify the tapped item and retrieve the corresponding data from the `ItemsSource` collection.

{% tabs %}

{% highlight xaml %}

<rotator:SfRotator x:Name="rotator"
                    ItemsSource="{Binding ImageCollection}"
                    ItemTapped="Rotator_ItemTapped"
                    VerticalOptions="Start">
    <rotator:SfRotator.ItemTemplate>
        <DataTemplate>
            <Image Source="{Binding Image}" />
        </DataTemplate>
    </rotator:SfRotator.ItemTemplate>
</rotator:SfRotator>

{% endhighlight %}

{% highlight C# %}
    
 RotatorViewModel rotatorViewModel = new RotatorViewModel();
 SfRotator rotator = new SfRotator()
 {
    VerticalOptions = LayoutOptions.Start,
    ItemsSource = rotatorViewModel.ImageCollection,
    ItemTemplate = new DataTemplate(() =>
    {
        var image = new Image();
        image.SetBinding(Image.SourceProperty, "Image");
        return image;
    }),
};
rotatorItemTapped += Rotator_ItemTapped;

private void Rotator_ItemTapped(object sender, EventArgs e)
{
    DisplayAlert("Notification", "Rotator Item is Tapped", "Ok");
}
 
{% endhighlight %}
{% highlight c# tabtitle="ViewModel" %}

// Model
public class RotatorModel
{
    public RotatorModel(string imageString)
    {
        Image = imageString;
    }
    private string _image;
    public string Image
    {
        get { return _image; }
        set { _image = value; }
    }
}

// ViewModel
public class RotatorViewModel
{
    public RotatorViewModel()
    {
        imageCollection = new List<RotatorModel>
        {
            new RotatorModel("image1.png"),
            new RotatorModel("image2.png"),
            new RotatorModel("image3.png"),
            new RotatorModel("image4.png"),
            new RotatorModel("image5.png")
        };
    }
    private List<RotatorModel> imageCollection;
    public List<RotatorModel> ImageCollection
    {
        get { return imageCollection; }
        set { imageCollection = value; }
    }
}

{% endhighlight %}
{% endtabs %}

![SfRotator ItemTapped event](images/ItemTapped.png)

## Unsubscribing from Events

To avoid memory leaks, unsubscribe from `SfRotator` events when the page is no longer in use. Override `OnDisappearing` in the page and remove the handlers.

{% tabs %}

{% highlight C# %}
protected override void OnDisappearing()
{
    base.OnDisappearing();
    rotator.SelectedIndexChanged -= Rotator_SelectedIndexChanged;
    rotator.ItemTapped -= Rotator_ItemTapped;
}
{% endhighlight %}
{% endtabs %}

## See Also

- [Getting Started with .NET MAUI Rotator (SfRotator)](https://help.syncfusion.com/maui/Rotator/getting-started)
- [Navigation Customization in .NET MAUI Rotator](https://help.syncfusion.com/maui/rotator/navigation-customization)
- [Navigation Mode in .NET MAUI Rotator](https://help.syncfusion.com/maui/rotator/navigation-modes)
- [Populating data in .NET MAUI Rotator](https://help.syncfusion.com/maui/rotator/populating-data)
- [Placement Modes in.NET MAUI Rotator](https://help.syncfusion.com/maui/rotator/placement-modes)

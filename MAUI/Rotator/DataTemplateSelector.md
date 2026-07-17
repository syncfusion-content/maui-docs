---
layout: post
title: DataTemplateSelector in .NET MAUI Rotator control | Syncfusion®
description: Learn how to use a DataTemplateSelector to choose a DataTemplate per item in the Syncfusion® .NET MAUI Rotator (SfRotator) control.
platform: maui 
control: Rotator 
documentation: ug
---

# DataTemplateSelector in .NET MAUI Rotator (SfRotator)

## Prerequisites

Before using the [SfRotator](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Rotator.SfRotator.html), ensure the following NuGet package is installed in your .NET MAUI project:

- `Syncfusion.Maui.Rotator`

For step-by-step setup, refer to the [Getting Started](https://help.syncfusion.com/maui/rotator/getting-started) documentation.

## Overview

The [`SfRotator`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Rotator.SfRotator.html) supports [`DataTemplateSelector`](https://learn.microsoft.com/en-us/dotnet/maui/fundamentals/datatemplate?view=net-maui-10.0#create-a-datatemplateselector), with which you can choose a [`DataTemplate`](https://learn.microsoft.com/en-us/dotnet/maui/fundamentals/datatemplate?view=net-maui-10.0) based on the underlying data object for each item.

## How it Works

`DataTemplateSelector` exposes a single over ridable method, `OnSelectTemplate`, which is invoked by the `SfRotator` once per item. The method receives the data object (`item`) and the parent `BindableObject` (`container`), and must return the `DataTemplate` to use for that item.

| Member | Type | Description |
|--------|------|-------------|
| `DefaultTemplate` | `DataTemplate` | The template returned when no specific template matches. |
| `SpecificTemplate` | `DataTemplate` | A template applied when the data object matches a specific condition. |
| `OnSelectTemplate(item, container)` | `DataTemplate` | Overridden method that returns the template to use for the given `item`. |

## Creating the DataTemplateSelector

Define a class that derives from `DataTemplateSelector` and overrides `OnSelectTemplate` to return a template based on the data object:

{% tabs %}

{% highlight C# %}

public class DataTemplateViewModel : DataTemplateSelector
{
    public DataTemplate DefaultTemplate { get; set; }
    public DataTemplate SpecificTemplate { get; set; }

    protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
    {
        var rotatorModel = item as Model;
        if (rotatorModel == null)
            return DefaultTemplate;

        // Apply the SpecificTemplate for a specific condition, e.g., check the image name or any other property
        if (rotatorModel.Image == "image2.png")
        {
            return SpecificTemplate;
        }

        return DefaultTemplate;
    }
}

{% endhighlight %}

{% endtabs %}

## Applying the DataTemplateSelector

The following examples show how to apply the `DataTemplateViewModel` selector to the `SfRotator` and supply the `DefaultTemplate` / `SpecificTemplate` resources.

{% tabs %}

{% highlight xaml %}

<ContentPage.Resources>
    <ResourceDictionary>
        <DataTemplate x:Key="DefaultTemplate">
            <Grid>
            <Image Source="{Binding Image}" HorizontalOptions="Center" VerticalOptions="Center"/>
            </Grid>
        </DataTemplate>
        <DataTemplate x:Key="SpecificTemplate">
            <Grid>
            <Label Text="Not Available" FontSize="50" HorizontalOptions="Center" VerticalOptions="Center"/> 
            <Image Source="{Binding Image}" Opacity="0.5" >
            </Grid>
        </DataTemplate>
    </ResourceDictionary>
</ContentPage.Resources>

<ContentPage.Content>      
    <Grid >
        <syncfusion:SfRotator x:Name="sfRotator" 
                ItemsSource="{Binding ImageCollection}" >
            <syncfusion:SfRotator.ItemTemplate>
            <local:DataTemplateViewModel DefaultTemplate="{StaticResource DefaultTemplate}" SpecificTemplate="{StaticResource SpecificTemplate}"/>
            </syncfusion:SfRotator.ItemTemplate>
        </syncfusion:SfRotator>
    </Grid>
  </ContentPage.Content>


{% endhighlight %}
{% highlight C# %}

RotatorViewModel rotatorViewModel = new RotatorViewModel();
DataTemplate defaultTemplate = new DataTemplate(() =>
{
    Grid grid = new Grid();
    Image image = new Image();
    image.SetBinding(Image.SourceProperty, "Image");
    grid.Children.Add(image);
    return grid;
});

DataTemplate specifictempalte = new DataTemplate(() =>
{
    Grid grid = new Grid();
    Image image = new Image();
    Label label = new Label();

    image.SetBinding(Image.SourceProperty, "Image");
    image.Opacity = 0.5;

    label.Text = "Not Available";
    label.FontSize = 50;
    label.HorizontalOptions = LayoutOptions.Center;
    label.VerticalOptions = LayoutOptions.Center;

    grid.Children.Add(image);
    grid.Children.Add(label);

    return grid;
});

SfRotator rotator = new SfRotator()
{
    NavigationDirection = NavigationDirection.Horizontal,
    NavigationStripMode = NavigationStripMode.Thumbnail,
    BackgroundColor = Colors.White,
    ItemsSource = rotatorViewModel.ImageCollection,
    ItemTemplate = new DataTemplateViewModel()
    {
        DefaultTemplate = defaultTemplate,
        SpecificTemplate = specifictempalte
    }
};

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


N> The `DataTemplateSelector` is invoked once per item. To update the selected template when the underlying data changes, recreate the selector and reassign `ItemTemplate`.

The following screenshot illustrates the output of the above code:

![DataTemplateSelector](Images/DataTemplateSelector.png)

## Troubleshooting

| Issue | Likely Cause | Suggested Fix |
|-------|--------------|---------------|
| The selector is never invoked. | The `ItemTemplate` is set to a `DataTemplate` instead of a `DataTemplateSelector`. | Assign a `DataTemplateSelector` instance to `ItemTemplate`. |
| All items render with the same template. | The condition in `OnSelectTemplate` never matches. | Verify the property used in the comparison (e.g., `Image == "image2.png"`) matches the actual data. |
| The `DefaultTemplate` resource is not found. | Missing or mismatched `x:Key`. | Ensure the `x:Key` matches the `StaticResource` reference. |

## See Also

- [Getting Started with .NET MAUI Rotator (SfRotator)](https://help.syncfusion.com/maui/Rotator/getting-started)
- [Navigation Customization in .NET MAUI Rotator](https://help.syncfusion.com/maui/rotator/navigation-customization)
- [Navigation Mode in .NET MAUI Rotator](https://help.syncfusion.com/maui/rotator/navigation-modes)
- [Populating data in .NET MAUI Rotator](https://help.syncfusion.com/maui/rotator/populating-data)
- [Events in .NET MAUI Rotator](https://help.syncfusion.com/maui/rotator/events)
- [Placement Modes in.NET MAUI Rotator](https://help.syncfusion.com/maui/rotator/placement-modes)


Find the complete `DataTemplateSelector` sample on [GitHub](https://github.com/SyncfusionExamples/data-template-selector-rotator/tree/main/DataTemplateSelectorSample).

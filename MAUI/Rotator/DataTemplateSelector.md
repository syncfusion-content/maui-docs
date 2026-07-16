---
layout: post
title: DataTemplateSelector in .NET MAUI Rotator control | Syncfusion®
description: Learn how to use a DataTemplateSelector to choose a DataTemplate per item in the Syncfusion® .NET MAUI Rotator (SfRotator) control.
platform: maui 
control: Rotator 
documentation: ug
---

# DataTemplateSelector in .NET MAUI Rotator (SfRotator)

The [`SfRotator`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Rotator.SfRotator.html?tabs=tabid-1) supports [`DataTemplateSelector`](https://learn.microsoft.com/dotnet/maui/fundamentals/datatemplate), with which you can choose a [`DataTemplate`](https://learn.microsoft.com/dotnet/maui/fundamentals/datatemplate) based on the underlying data object for each item.

## Prerequisites

Before proceeding, ensure the following are in place:

1. Install the [Syncfusion.Maui.Rotator](https://www.nuget.org/packages/Syncfusion.Maui.Rotator) NuGet package in your .NET MAUI project.
2. Register the Rotator handler in `MauiProgram.cs`:

    ```csharp
    builder.ConfigureSyncfusionRotator();
    ```

3. Add the required image assets (e.g., `image1.png` through `image5.png`) to the `Resources/Images` folder of your project.
4. Define the `Model` (data class) and `ViewModel` used to supply the image collection. For example:

    ```csharp
    using System.Collections.ObjectModel;

    public class Model
    {
        public Model(string imageString)
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

    public class ViewModel
    {
        public ObservableCollection<Model> ImageCollection { get; set; }

        public ViewModel()
        {
            ImageCollection = new ObservableCollection<Model>
            {
                new Model("image1.png"),
                new Model("image2.png"),
                new Model("image3.png"),
                new Model("image4.png"),
                new Model("image5.png")
            };
        }
    }
    ```

> **Note:** For complete setup steps, refer to the [Getting Started with .NET MAUI Rotator](https://help.syncfusion.com/maui/Rotator/getting-started) documentation.

## How it Works

`DataTemplateSelector` exposes a single overridable method, `OnSelectTemplate`, which is invoked by the `SfRotator` once per item. The method receives the data object (`item`) and the parent `BindableObject` (`container`), and must return the `DataTemplate` to use for that item.

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

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
            xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
            xmlns:syncfusion="clr-namespace:Syncfusion.Maui.Rotator;assembly=Syncfusion.Maui.Rotator"
            xmlns:local="clr-namespace:Rotator"
            x:Class="Rotator.MainPage">
    <ContentPage.Resources>
        <ResourceDictionary>
            <DataTemplate x:Key="DefaultTemplate">
                <Grid>
                    <Image Source="{Binding Image}" HorizontalOptions="Center" VerticalOptions="Center"/>
                </Grid>
            </DataTemplate>
            <DataTemplate x:Key="SpecificTemplate">
                <Grid>
                    <Image Source="{Binding Image}" Opacity="0.5"/>
                    <Label Text="Not Available" FontSize="50" HorizontalOptions="Center" VerticalOptions="Center"/>
                </Grid>
            </DataTemplate>
        </ResourceDictionary>
    </ContentPage.Resources>

    <ContentPage.Content>
        <Grid>
            <syncfusion:SfRotator x:Name="sfRotator"
                    ItemsSource="{Binding ImageCollection}">
                <syncfusion:SfRotator.ItemTemplate>
                    <local:DataTemplateViewModel DefaultTemplate="{StaticResource DefaultTemplate}" SpecificTemplate="{StaticResource SpecificTemplate}"/>
                </syncfusion:SfRotator.ItemTemplate>
            </syncfusion:SfRotator>
        </Grid>
    </ContentPage.Content>
</ContentPage>

{% endhighlight %}

{% highlight C# %}

using System.Collections.Generic;
using System.Collections.ObjectModel;
using Microsoft.Maui.Controls;
using Syncfusion.Maui.Rotator;

public partial class MainPage : ContentPage
{
    DataTemplate defaultTemplate;
    DataTemplate specificTemplate;

    public MainPage()
    {
        InitializeComponent();
        this.BindingContext = new ViewModel();
        SfRotator rotator = new SfRotator();

        defaultTemplate = new DataTemplate(() =>
        {
            Grid grid = new Grid();
            Image image = new Image();
            image.SetBinding(Image.SourceProperty, "Image");
            grid.Children.Add(image);
            return grid;
        });

        specificTemplate = new DataTemplate(() =>
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

        var ImageCollection = new List<Model> {
            new Model ("image1.png"),
            new Model ("image2.png"),
            new Model ("image3.png"),
            new Model ("image4.png"),
            new Model ("image5.png")
        };
        rotator.NavigationDirection = NavigationDirection.Horizontal;
        rotator.NavigationStripMode = NavigationStripMode.Thumbnail;
        rotator.BackgroundColor = Colors.White;
        rotator.ItemsSource = ImageCollection;
        rotator.ItemTemplate = new DataTemplateViewModel { DefaultTemplate = defaultTemplate, SpecificTemplate = specificTemplate };
        this.Content = rotator;
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
- [DataTemplate and DataTemplateSelector in .NET MAUI](https://learn.microsoft.com/dotnet/maui/fundamentals/datatemplate)
- [.NET MAUI Rotator Release Notes](https://help.syncfusion.com/maui/Rotator/release-notes)

Find the complete `DataTemplateSelector` sample on [GitHub](https://github.com/SyncfusionExamples/data-template-selector-rotator/tree/main/DataTemplateSelectorSample).

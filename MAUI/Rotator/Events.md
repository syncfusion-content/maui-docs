---
layout: post
title: Events in .NET MAUI Rotator control | Syncfusion®
description: Learn about Events support in Syncfusion® .NET MAUI Rotator (SfRotator) control, its elements, and more.
platform: maui 
control: Rotator 
documentation: ug
---

# Events in .NET MAUI Rotator (SfRotator)

This section explains the events supported by the [SfRotator](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Rotator.SfRotator.html) control and how to handle them in your .NET MAUI application. Before proceeding, ensure you have completed the setup described in [Getting Started with .NET MAUI Rotator](Getting-started.md).

**Requirements:** .NET 9 SDK or later and the [Syncfusion.Maui.Rotator](https://www.nuget.org/packages/Syncfusion.Maui.Rotator) NuGet package.

## Selected Index Changed Event

The [`SelectedIndexChanged`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Rotator.SfRotator.html#Syncfusion_Maui_Rotator_SfRotator_SelectedIndexChanged) event is raised when the selection changes by swiping between items or by setting the [`SelectedIndex`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Rotator.SfRotator.html#Syncfusion_Maui_Rotator_SfRotator_SelectedIndex) property programmatically. The event provides a [`SelectedIndexChangedEventArgs`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Rotator.SelectedIndexChangedEventArgs.html) instance with the following members:

| Member | Type | Description |
|--------|------|-------------|
| `Index` | `int` | Gets the currently selected index. |
| `OldIndex` | `int` | Gets the previously selected index. |

> **NOTE:** The images referenced in the following examples (image1.png through image5.png) should be added to the **Resources/Images** folder of your .NET MAUI project.

{% tabs %}

{% highlight xaml %}

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
            xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
            xmlns:syncfusion="clr-namespace:Syncfusion.Maui.Rotator;assembly=Syncfusion.Maui.Rotator"
            xmlns:local="clr-namespace:Rotator"
            x:Class="Rotator.Rotator">
    <ContentPage.BindingContext>
        <local:RotatorViewModel/>
    </ContentPage.BindingContext>
    <ContentPage.Content>
        <Grid HorizontalOptions="FillAndExpand" VerticalOptions="Fill">
            <syncfusion:SfRotator x:Name="rotator"
                        SelectedIndexChanged="Rotator_SelectedIndexChanged"
                        ItemsSource="{Binding ImageCollection}"
                        VerticalOptions="Start">
                <syncfusion:SfRotator.ItemTemplate>
                    <DataTemplate>
                        <Image Source="{Binding Image}" />
                    </DataTemplate>
                </syncfusion:SfRotator.ItemTemplate>
            </syncfusion:SfRotator>
        </Grid>
    </ContentPage.Content>
</ContentPage>

{% endhighlight %}

{% highlight C# %}

using System.Collections.ObjectModel;
using Syncfusion.Maui.Rotator;

namespace Rotator
{
    public partial class Rotator : ContentPage
    {
        RotatorViewModel viewModel = new RotatorViewModel();

        public Rotator()
        {
            InitializeComponent();
            StackLayout layout = new StackLayout();
            SfRotator rotator = new SfRotator();
            rotator.SelectedIndexChanged += Rotator_SelectedIndexChanged;
            rotator.ItemsSource = viewModel.ImageCollection;
            var itemTemplate = new DataTemplate(() =>
            {
                var grid = new Grid();
                var nameLabel = new Image();
                nameLabel.SetBinding(Image.SourceProperty, "Image");
                grid.Children.Add(nameLabel);
                return grid;
            });
            rotator.ItemTemplate = itemTemplate;
            layout.Children.Add(rotator);
            this.Content = layout;
            this.BindingContext = viewModel;
        }

        private void Rotator_SelectedIndexChanged(object sender, SelectedIndexChangedEventArgs e)
        {
            DisplayAlert("Notification", "Selected Index is Changed", "Ok");
        }
    }

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

    public class RotatorViewModel
    {
        public RotatorViewModel()
        {
            ImageCollection.Add(new RotatorModel("image1.png"));
            ImageCollection.Add(new RotatorModel("image2.png"));
            ImageCollection.Add(new RotatorModel("image3.png"));
            ImageCollection.Add(new RotatorModel("image4.png"));
            ImageCollection.Add(new RotatorModel("image5.png"));
        }

        private ObservableCollection<RotatorModel> imageCollection = new ObservableCollection<RotatorModel>();
        public ObservableCollection<RotatorModel> ImageCollection
        {
            get { return imageCollection; }
            set { imageCollection = value; }
        }
    }
}

{% endhighlight %}

{% endtabs %}

![Rotator_SelectedIndexChanged](images/SelectedIndexChanged.png)

## Item Tapped Event

The [`ItemTapped`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Rotator.SfRotator.html#Syncfusion_Maui_Rotator_SfRotator_ItemTapped) event is raised when an item in the SfRotator is tapped. The event provides a standard `EventArgs` instance, since the tapped item's data can be retrieved through the `SfRotator.ItemsSource` collection using the currently selected index.

{% tabs %}

{% highlight xaml %}

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
            xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
            xmlns:syncfusion="clr-namespace:Syncfusion.Maui.Rotator;assembly=Syncfusion.Maui.Rotator"
            xmlns:local="clr-namespace:Rotator"
            x:Class="Rotator.Rotator">
    <ContentPage.BindingContext>
        <local:RotatorViewModel/>
    </ContentPage.BindingContext>
    <ContentPage.Content>
        <Grid HorizontalOptions="FillAndExpand" VerticalOptions="Fill">
            <syncfusion:SfRotator x:Name="rotator"
                            ItemTapped="Rotator_ItemTapped"
                        ItemsSource="{Binding ImageCollection}"
                        VerticalOptions="Start">
                <syncfusion:SfRotator.ItemTemplate>
                    <DataTemplate>
                        <Image Source="{Binding Image}" />
                    </DataTemplate>
                </syncfusion:SfRotator.ItemTemplate>
            </syncfusion:SfRotator>
        </Grid>
    </ContentPage.Content>
</ContentPage>

{% endhighlight %}

{% highlight C# %}

using System.Collections.ObjectModel;
using Syncfusion.Maui.Rotator;

namespace Rotator
{
    public partial class Rotator : ContentPage
    {
        RotatorViewModel viewModel = new RotatorViewModel();

        public Rotator()
        {
            InitializeComponent();
            StackLayout layout = new StackLayout();
            SfRotator rotator = new SfRotator();
            rotator.ItemTapped += Rotator_ItemTapped;
            rotator.ItemsSource = viewModel.ImageCollection;
            var itemTemplate = new DataTemplate(() =>
            {
                var grid = new Grid();
                var nameLabel = new Image();
                nameLabel.SetBinding(Image.SourceProperty, "Image");
                grid.Children.Add(nameLabel);
                return grid;
            });
            rotator.ItemTemplate = itemTemplate;
            layout.Children.Add(rotator);
            this.Content = layout;
            this.BindingContext = viewModel;
        }

        private void Rotator_ItemTapped(object sender, EventArgs e)
        {
            DisplayAlert("Notification", "Rotator Item is Tapped", "Ok");
        }
    }

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

    public class RotatorViewModel
    {
        public RotatorViewModel()
        {
            ImageCollection.Add(new RotatorModel("image1.png"));
            ImageCollection.Add(new RotatorModel("image2.png"));
            ImageCollection.Add(new RotatorModel("image3.png"));
            ImageCollection.Add(new RotatorModel("image4.png"));
            ImageCollection.Add(new RotatorModel("image5.png"));
        }

        private ObservableCollection<RotatorModel> imageCollection = new ObservableCollection<RotatorModel>();
        public ObservableCollection<RotatorModel> ImageCollection
        {
            get { return imageCollection; }
            set { imageCollection = value; }
        }
    }
}

{% endhighlight %}

{% endtabs %}

![Rotator_ItemTapped](images/ItemTapped.png)

## See also

- [Getting Started with .NET MAUI Rotator](Getting-started.md)
- [Populating Data in .NET MAUI Rotator](Populating-Data.md)
- [SelectedIndexChangedEventArgs API reference](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Rotator.SelectedIndexChangedEventArgs.html)
- [SfRotator API reference](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Rotator.SfRotator.html)




   





---
layout: post
title: DataTemplateSelector in .NET MAUI Rotator control | Syncfusion®
description: Learn about DataTemplateSelector support in the Syncfusion® .NET MAUI Rotator (SfRotator) control and more.
platform: maui 
control: Rotator 
documentation: ug
---

# DataTemplateSelector in .NET MAUI Rotator (SfRotator)

The [`SfRotator`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Rotator.SfRotator.html?tabs=tabid-1) supports `DataTemplateSelector`, allowing you to choose a `DataTemplate` based on the data object.

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
</ContentPage>

{% endhighlight %}

{% highlight C# %}

public partial class MainPage : ContentPage
    {
    DataTemplate defaultTemplate;
    DataTemplate specifictempalte;

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

        specifictempalte = new DataTemplate(() =>
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
        rotator.ItemTemplate = new DataTemplateViewModel { DefaultTemplate = defaultTemplate, SpecificTemplate = specifictempalte};
        this.Content = rotator;
    }
}

{% endhighlight %}

{% endtabs %}

### OnSelectTemplate

The OnSelectTemplate is an overridden method to return a particular DataTemplate, which is shown in the following code:

{% tabs %}

{% highlight C# %}
	
public class DataTemplateViewModel : DataTemplateSelector
{
    public DataTemplate DefaultTemplate { get; set; }
    public DataTemplate SpecificTemplate { get; set; }

    protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
    {
        var rotatorModel = item as RotatorModel;
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

The following screenshot illustrates the output of above code.

![DataTemplateSelector](images/DataTemplateSelector.png)

Find the complete DataTemplateSelector sample from this [link.](https://github.com/SyncfusionExamples/data-template-selector-rotator/tree/main/DataTemplateSelectorSample)

---
layout: post
title: Visual State Manager in .NET MAUI Tab View (SfTabView) | Syncfusion®
description: Learn how to use the Visual State Manager to customize the appearance of tabs based on their visual state in the Syncfusion® .NET MAUI Tab View control.
platform: MAUI
control: SfTabView
documentation: UG
---

# Visual State Manager in .NET MAUI Tab View (SfTabView)

## Prerequisites

Before using the [SfTabView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TabView.SfTabView.html), ensure the following NuGet package is installed in your .NET MAUI project:

- `Syncfusion.Maui.TabView`

For step-by-step setup, refer to the [Getting Started](https://help.syncfusion.com/maui/tabview/getting-started) documentation.


# Visual State Manager

Use the `Visual State Manager (VSM)` to change `SfTabItem` properties declaratively in XAML or programmatically in code-behind, based on the tab's visual state. The applicable visual states are `Selected`, `Normal`, and `Disabled`.

Use VSM when you need to apply different appearance values to the same tab depending on its current state—for example, a different `TextColor` when the tab is selected vs. when it is not. For simple, single-state appearance changes, set the properties directly on the `SfTabItem` (see [Tab Item Customization](Thttps://help.syncfusion.com/maui/tabview/tab-item-customization)).

## Minimal VSM example

Use the visual state manager to change the .NET MAUI tab properties based on the visual states set from code. The applicable visual states are `Selected`, `Normal`, and `Disable`.

{% tabs %}
{% highlight xaml %}

<tabView:SfTabView>
    <tabView:SfTabView.Resources>
        <ResourceDictionary>
            <Style TargetType="tabView:SfTabItem">
                <Setter Property="VisualStateManager.VisualStateGroups">
                    <VisualStateGroupList>
                        <VisualStateGroup>
                            <VisualState x:Name="Normal">
                                <VisualState.Setters>
                                    <Setter Property="TextColor" Value="Black" />
                                    <Setter Property="FontFamily" Value="Roboto" />
                                </VisualState.Setters>
                            </VisualState>
                            <VisualState x:Name="Selected">
                                <VisualState.Setters>
                                    <Setter Property="TextColor" Value="#6200EE" />
                                    <Setter Property="FontFamily" Value="Roboto" />
                                </VisualState.Setters>
                            </VisualState>
                        </VisualStateGroup>
                    </VisualStateGroupList>
                </Setter>
            </Style>
        </ResourceDictionary>
    </tabView:SfTabView.Resources>

    <tabView:SfTabItem Header="FAVOURITES">
        <tabView:SfTabItem.Content>
            <ListView RowHeight="50">
                <ListView.ItemsSource>
                    <x:Array Type="{x:Type x:String}">
                        <x:String>James</x:String>
                        <x:String>Richard</x:String>
                        <x:String>Clara</x:String>
                        <x:String>Michael</x:String>
                        <x:String>Alex</x:String>
                    </x:Array>
                </ListView.ItemsSource>
                <ListView.ItemTemplate>
                    <DataTemplate>
                        <ViewCell>
                            <Grid ColumnDefinitions="48,*,48,48" Margin="10,5">
                                <Image Grid.Column="0"
                                       WidthRequest="35"
                                       HeightRequest="35"
                                       VerticalOptions="Center"
                                       HorizontalOptions="Center"
                                       Aspect="AspectFit"
                                       Source="contact_image.png" />
                                <Label Grid.Column="1"
                                       VerticalOptions="Center"
                                       HorizontalOptions="Start"
                                       Margin="5,0"
                                       TextColor="#666666"
                                       FontSize="16"
                                       Text="{Binding}" />
                                <Image Grid.Column="2"
                                       WidthRequest="35"
                                       HeightRequest="35"
                                       VerticalOptions="Center"
                                       HorizontalOptions="Center"
                                       Aspect="AspectFit"
                                       Source="mail.png" />
                                <Image Grid.Column="3"
                                       WidthRequest="35"
                                       HeightRequest="35"
                                       VerticalOptions="Center"
                                       HorizontalOptions="Center"
                                       Aspect="AspectFit"
                                       Source="call1.png" />
                            </Grid>
                        </ViewCell>
                    </DataTemplate>
                </ListView.ItemTemplate>
            </ListView>
        </tabView:SfTabItem.Content>
    </tabView:SfTabItem>

    <tabView:SfTabItem Header="RECENTS">
        <tabView:SfTabItem.Content>
            <Grid BackgroundColor="Green" />
        </tabView:SfTabItem.Content>
    </tabView:SfTabItem>

    <tabView:SfTabItem Header="CONTACTS">
        <tabView:SfTabItem.Content>
            <Grid BackgroundColor="Blue" />
        </tabView:SfTabItem.Content>
    </tabView:SfTabItem>
</tabView:SfTabView>

{% endhighlight %}

{% highlight C# %}

SfTabView tabView = new SfTabView();
ListView listView = new ListView
{
    RowHeight = 50,
    ItemsSource = new string[] { "James", "Richard", "Clara", "Michael", "Alex", "Clara" },
    ItemTemplate = new DataTemplate(() =>
    {
        var grid = new Grid
        {
            ColumnDefinitions =
            {
                new ColumnDefinition { Width = new GridLength(48) },
                new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                new ColumnDefinition { Width = new GridLength(48) },
                new ColumnDefinition { Width = new GridLength(48) }
            },
            Margin = new Thickness(10, 5)
        };

        var image1 = new Image
        {
            WidthRequest = 35,
            HeightRequest = 35,
            VerticalOptions = LayoutOptions.Center,
            HorizontalOptions = LayoutOptions.Center,
            Aspect = Aspect.AspectFit,
            Source = "contact_image"
        };
        var label = new Label
        {
            VerticalOptions = LayoutOptions.Center,
            HorizontalOptions = LayoutOptions.Start,
            Margin = new Thickness(5, 0),
            TextColor = Color.FromHex("#666666"),
            FontSize = 16
        };
        label.SetBinding(Label.TextProperty, ".");
        var image2 = new Image
        {
            WidthRequest = 35,
            HeightRequest = 35,
            VerticalOptions = LayoutOptions.Center,
            HorizontalOptions = LayoutOptions.Center,
            Aspect = Aspect.AspectFit,
            Source = "mail"
        };
        var image3 = new Image
        {
            WidthRequest = 35,
            HeightRequest = 35,
            VerticalOptions = LayoutOptions.Center,
            HorizontalOptions = LayoutOptions.Center,
            Aspect = Aspect.AspectFit,
            Source = "call1"
        };

        Grid.SetColumn(image1, 0);
        Grid.SetColumn(label, 1);
        Grid.SetColumn(image2, 2);
        Grid.SetColumn(image3, 3);

        grid.Children.Add(image1);
        grid.Children.Add(label);
        grid.Children.Add(image2);
        grid.Children.Add(image3);

        return new ViewCell { View = grid };
    })
};

Grid favoritesGrid = new Grid { };
favoritesGrid.Children.Add(listView);
Grid recentsGrid = new Grid { BackgroundColor = Colors.Green };
Grid contactsGrid = new Grid { BackgroundColor = Colors.Blue };
var tabItems = new TabItemCollection
{
    new CustomTabItem()
    {
        Header = "FAVOURITES",
        Content = favoritesGrid
    },
    new CustomTabItem()
    {
        Header = "RECENTS",
        Content = recentsGrid
    },
    new CustomTabItem()
    {
        Header = "CONTACTS",
        Content = contactsGrid
    }
};

tabView.Items = tabItems;

//Custom SfTabItem
public class CustomTabItem : SfTabItem
{
    public CustomTabItem()
    {
        VisualStateGroupList visualStateGroupList = new VisualStateGroupList();
        VisualStateGroup commonStateGroup = new VisualStateGroup();

        VisualState normalState = new VisualState
        {
            Name = "Normal"
        };

        normalState.Setters.Add(new Setter { Property = SfTabItem.TextColorProperty, Value = Colors.Black });

        VisualState selectedState = new VisualState
        {
            Name = "Selected"
        };
        selectedState.Setters.Add(new Setter { Property = SfTabItem.TextColorProperty, Value = Color.FromHex("#6750A4") });

        commonStateGroup.States.Add(normalState);
        commonStateGroup.States.Add(selectedState);

        visualStateGroupList.Add(commonStateGroup);

        VisualStateManager.SetVisualStateGroups(this, visualStateGroupList);
    }
}
{% endhighlight %}

{% endtabs %}

![Visual state manager applied to the .NET MAUI Tab View](images/Visual-state-manager.png)

> **Note** View the [VisualStateManagerTabView sample](https://github.com/SyncfusionExamples/maui-tabview-samples/tree/main/VisualStateManagerTabView) on GitHub.

## See also

* [Selection Indicator Customization in .NET MAUI Tab View](https://help.syncfusion.com/maui/tabview/selection-indicator-customization)
* [Tab Item Customization in .NET MAUI Tab View](Thttps://help.syncfusion.com/maui/tabview/tab-item-customization)
* [Tab bar Customization in .NET MAUI Tab View](https://help.syncfusion.com/maui/tabview/tab-bar-customization)
* [Populating ItemsSource in .NET MAUI Tab View](https://help.syncfusion.com/maui/tabview/populating-itemssource)
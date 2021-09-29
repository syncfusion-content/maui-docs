---
layout: post
title: Populating tab items in .NET MAUI TabView control | Syncfusion
description: Learn here all about the populating tab items support in Syncfusion MAUI TabView (SfTabView) control and more.
platform: maui
control: TabView
documentation: ug
---

# Populating tab items to .NET MAUI Tab View (SfTabView)

Tab items can be added to the control using the `Items` property of `SfTabView`.

{% tabs %}

{% highlight xaml %}

<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             x:Class="TabViewMauiSample.MainPage"
             xmlns:tabView="http://schemas.syncfusion.com/maui"
             BackgroundColor="{DynamicResource SecondaryColor}">
    <ContentPage.Content>
        <tabView:SfTabView BackgroundColor="Aqua">
                    <tabView:SfTabItem Header="Call">
                        <tabView:SfTabItem.Content>
                            <Grid BackgroundColor="Red" x:Name="AllContactsGrid" />
                        </tabView:SfTabItem.Content>
                    </tabView:SfTabItem>
                    <tabView:SfTabItem Header="Favorites">
                        <tabView:SfTabItem.Content>
                            <Grid BackgroundColor="Green" x:Name="FavoritesGrid" />
                        </tabView:SfTabItem.Content>
                    </tabView:SfTabItem>
                    <tabView:SfTabItem Header="Contacts">
                        <tabView:SfTabItem.Content>
                            <Grid BackgroundColor="Blue" x:Name="ContactsGrid" />
                        </tabView:SfTabItem.Content>
                    </tabView:SfTabItem>
        </tabView:SfTabView>
    </ContentPage.Content>
</ContentPage>

{% endhighlight %}

{% highlight C# %}

using Syncfusion.Maui.TabView;

namespace TabViewMauiSample
{
	public partial class TabView : ContentPage
	{
        SfTabView tabView;
		public TabView ()
		{
			InitializeComponent ();
            var tabView = new SfTabView();
            Grid allContactsGrid = new Grid {BackgroundColor = Color.Red};
            Grid favoritesGrid = new Grid {BackgroundColor = Color.Green};
            Grid contactsGrid = new Grid {BackgroundColor = Color.Blue};
            var tabItems = new TabItemCollection
            {
                new SfTabItem()
                {
                    Header = "Calls",
                    Content = allContactsGrid
                },
                new SfTabItem()
                {
                    Header = "Favorites",
                    Content = favoritesGrid
                },
                new SfTabItem()
                {
                    Header = "Contacts",
                    Content = contactsGrid
                }
            };

            tabView.Items = tabItems;
            this.Content = tabView;
		}
	}
}

{% endhighlight %}

{% endtabs %}

Bind the items source of the `ListView`, and set the required appearance in its `ItemTemplate` property in which the list view can be hosted within the content region of tab item. 

{% highlight xaml %}

<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             x:Class="TabViewMauiSample.MainPage"
             xmlns:tabView="http://schemas.syncfusion.com/maui"
             BackgroundColor="{DynamicResource SecondaryColor}">
    <ContentPage.Content>
        <Grid>
            <tabView:SfTabView x:Name="tabView"
                                TabBarBackground="#FDF8F6"
                                TabWidthMode="Default"
                                TabBarPlacement="Bottom"
                                BackgroundColor="Transparent"
                                IndicatorBackground="#6200EE"
                                IndicatorPlacement="Top" >
                <tabView:SfTabView.Items>
                    <tabView:SfTabItem Header="FAVOURITES">
                    <tabView:SfTabItem.Content>
                        <Grid>
                            <Grid GridLayout.Row="1" VerticalOptions="End" HeightRequest="20">
                                <Grid.Background>
                                    <LinearGradientBrush EndPoint="0,1">
                                        <GradientStop Color="Transparent" Offset="0.1" />
                                        <GradientStop Color="#EAEAEA" Offset="0.8" />
                                        <GradientStop Color="#E5E5E5" Offset="1.0" />
                                    </LinearGradientBrush>
                                </Grid.Background>
                        </Grid>
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
                                        <Image GridLayout.Column="0"
                                                WidthRequest="35"
                                                HeightRequest="35"
                                                VerticalOptions="Center"
                                                HorizontalOptions="Center"
                                                Aspect="AspectFit"
                                                Source="contact_image"/>
                                        <Label GridLayout.Column="1"
                                                VerticalOptions="Center"
                                                HorizontalOptions="Start"
                                                Margin="5,0"
                                                TextColor="#666666"
                                                FontSize="16"
                                                Text="{Binding}"/>
                                        <Image GridLayout.Column="2"
                                                WidthRequest="35"
                                                HeightRequest="35"
                                                VerticalOptions="Center"
                                                HorizontalOptions="Center"
                                                Aspect="AspectFit"
                                                Source="mail"/>
                                        <Image GridLayout.Column="3"
                                                WidthRequest="35"
                                                HeightRequest="35"
                                                VerticalOptions="Center"
                                                HorizontalOptions="Center"
                                                Aspect="AspectFit"
                                                Source="call1"/>
                                    </Grid>
                                </ViewCell>
                            </DataTemplate>
                        </ListView.ItemTemplate>
                    </ListView>
                </Grid>
            </tabView:SfTabItem.Content>
        </tabView:SfTabItem>

        <tabView:SfTabItem Header="RECENTS">
            <tabView:SfTabItem.Content>
                <Grid>
                    <Grid GridLayout.Row="1" VerticalOptions="End" HeightRequest="20">
                        <Grid.Background>
                            <LinearGradientBrush EndPoint="0,1">
                                <GradientStop Color="#FFFFFF" Offset="0.1" />
                                <GradientStop Color="#EAEAEA" Offset="0.8" />
                                <GradientStop Color="#E5E5E5" Offset="1.0" />
                            </LinearGradientBrush>
                        </Grid.Background>
                    </Grid>
                    <ListView RowHeight="50">
                        <ListView.ItemsSource>
                            <x:Array Type="{x:Type x:String}">
                            <x:String>James</x:String>
                            <x:String>Richard</x:String>
                            <x:String>Michael</x:String>
                            <x:String>Alex</x:String>
                            <x:String>Clara</x:String>
                            <x:String>Steve</x:String>
                            <x:String>James</x:String>
                            <x:String>Alex</x:String>
                            <x:String>James</x:String>
                            <x:String>James</x:String>
                            <x:String>Richard</x:String>
                            <x:String>Michael</x:String>
                            <x:String>Alex</x:String>
                            <x:String>Clara</x:String>
                            <x:String>Steve</x:String>
                            <x:String>James</x:String>
                            <x:String>Alex</x:String>
                            <x:String>James</x:String>
                            </x:Array>
                        </ListView.ItemsSource>
                        <ListView.ItemTemplate>
                            <DataTemplate>
                                <ViewCell>
                                    <Grid ColumnDefinitions="48,*,48" Margin="10,5">
                                        <Image GridLayout.Column="0"
                                            WidthRequest="35"
                                            HeightRequest="35"
                                            VerticalOptions="Center"
                                            HorizontalOptions="Center"
                                            Aspect="AspectFit"
                                            Source="incoming"/>
                                        <Label GridLayout.Column="1"
                                            VerticalOptions="Center"
                                            HorizontalOptions="Start"
                                            TextColor="#666666"
                                            FontSize="16"
                                            Text="{Binding}"/>
                                        <Image GridLayout.Column="2"
                                            WidthRequest="40"
                                            HeightRequest="40"
                                            VerticalOptions="Center"
                                            HorizontalOptions="Center"
                                            Aspect="AspectFit"
                                            Source="sim"/>
                                    </Grid>
                                </ViewCell>
                            </DataTemplate>
                        </ListView.ItemTemplate>
                    </ListView>
                </Grid>
            </tabView:SfTabItem.Content>
        </tabView:SfTabItem>

        <tabView:SfTabItem Header="CONTACTS">
            <tabView:SfTabItem.Content>
                <Grid>
                    <Grid GridLayout.Row="1" VerticalOptions="End" HeightRequest="20">
                        <Grid.Background>
                            <LinearGradientBrush EndPoint="0,1">
                                <GradientStop Color="Transparent" Offset="0.1" />
                                <GradientStop Color="#EAEAEA" Offset="0.8" />
                                <GradientStop Color="#E5E5E5" Offset="1.0" />
                            </LinearGradientBrush>
                        </Grid.Background>
                    </Grid>
                    <ListView RowHeight="50">
                        <ListView.ItemsSource>
                            <x:Array Type="{x:Type x:String}">
                            <x:String>James</x:String>
                            <x:String>Richard</x:String>
                            <x:String>Michael</x:String>
                            <x:String>Alex</x:String>
                            <x:String>Clara</x:String>
                            <x:String>Steve</x:String>
                            <x:String>David</x:String>
                            <x:String>Stephen</x:String>
                            <x:String>James</x:String>
                            <x:String>James</x:String>
                            <x:String>Richard</x:String>
                            <x:String>Michael</x:String>
                            <x:String>Alex</x:String>
                            <x:String>Clara</x:String>
                            <x:String>Steve</x:String>
                            <x:String>James</x:String>
                            <x:String>Alex</x:String>
                            <x:String>James</x:String>
                            </x:Array>
                        </ListView.ItemsSource>
                        <ListView.ItemTemplate>
                            <DataTemplate>
                                <ViewCell>
                                    <Grid ColumnDefinitions="48,*,48,48" Margin="10,5">
                                        <Image GridLayout.Column="0"
                                            WidthRequest="35"
                                            HeightRequest="35"
                                            VerticalOptions="Center"
                                            HorizontalOptions="Center"
                                            Aspect="AspectFit"
                                            Source="contact_image"/>
                                        <Label GridLayout.Column="1"
                                            VerticalOptions="Center"
                                            HorizontalOptions="Start"
                                            Margin="5,0"
                                            TextColor="#666666"
                                            FontSize="16"
                                            Text="{Binding}"/>
                                        <Image GridLayout.Column="2"
                                            WidthRequest="35"
                                            HeightRequest="35"
                                            VerticalOptions="Center"
                                            HorizontalOptions="Center"
                                            Aspect="AspectFit"
                                            Source="mail"/>
                                        <Image GridLayout.Column="3"
                                            WidthRequest="35"
                                            HeightRequest="35"
                                            VerticalOptions="Center"
                                            HorizontalOptions="Center"
                                            Aspect="AspectFit"
                                            Source="call1"/>
                                    </Grid>
                                </ViewCell>
                            </DataTemplate>
                        </ListView.ItemTemplate>
                    </ListView>
                </Grid>
            </tabView:SfTabItem.Content>
        </tabView:SfTabItem>
        </tabView:SfTabView.Items>
        </tabView:SfTabView>
    </Grid>
    </ContentPage.Content>
</ContentPage>
	
{% endhighlight %}

Similarly, content region for other tabs also can be configured.

![LisViewImage](images/ListView.png)
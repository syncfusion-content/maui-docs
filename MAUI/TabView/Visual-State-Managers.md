---
layout: post
title: Visual state manager in .NET MAUI Tab View (SfTabView) | Syncfusion
description: Learn here all about handling of visual state manager in Syncfusion .NET MAUI Tab View (SfTabView) control and more.
platform: MAUI
control: TabView
documentation: ug
---

# Visual State Manager in .NET MAUI Tab View (SfTabView)

Use the visual state manager to change the .NET MAUI tab properties based on the visual states set from code. The applicable visual states are selected, normal, and disable.

{% highlight xaml %}

<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             x:Class="TabViewMauiSample.MainPage"
             xmlns:tabView="clr-namespace:Syncfusion.Maui.TabView;assembly=Syncfusion.Maui.TabView"
             BackgroundColor="{DynamicResource SecondaryColor}">
    <ContentPage.Content>
        <Grid>
            <Grid.Resources>
                <Style x:Key="tabButton" TargetType="{x:Type Button}">
                    <Setter Property="FontSize" Value="30" />
                    <Setter Property="BackgroundColor" Value="White" />
                    <Setter Property="TextColor" Value="#666666" />
                    <Setter Property="FontAttributes" Value="Bold" />
                    <Setter Property="Margin" Value="{OnPlatform Android='-5', Default='0'}" />
                </Style>
                <Style TargetType="tabView:SfTabItem">
                    <Setter Property="VisualStateManager.VisualStateGroups">
                        <VisualStateGroupList>
                            <VisualStateGroup>
                                <VisualState x:Name="Normal" >
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
            </Grid.Resources>
            <tabView:SfTabView>
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
                                    <x:String>Clara</x:String>
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
                    <Grid BackgroundColor="Green" x:Name="FavoritesGrid" />
                </tabView:SfTabItem.Content>
            </tabView:SfTabItem>
            <tabView:SfTabItem Header="CONTACTS">
                <tabView:SfTabItem.Content>
                    <Grid BackgroundColor="Blue" x:Name="ContactsGrid" />
                </tabView:SfTabItem.Content>
            </tabView:SfTabItem>
        </tabView:SfTabView>
    </Grid>
 </ContentPage.Content>
 </ContentPage>

{% endhighlight %}

![Visual state manager in .NET MAUI Tab View](images/maui-tab-view-visual-state-manager.png) 

N> View [sample](https://github.com/SyncfusionExamples/maui-tabview-samples/tree/main/VisualStateManagerTabView) in GitHub
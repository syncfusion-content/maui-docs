---
layout: post
title: Visual state manager in MAUI TabView control | Syncfusion
description: Learn here all about Handling of visual state manager in Syncfusion MAUI TabView (SfTabView) control and more.
platform: MAUI
control: TabView
documentation: ug
---

# Visual State Manager in MAUI TabView (SfTabView)

Use the visual state manager to make changes to the .NET MAUI tab properties based on the visual states set from code. The applicable visual states are selected, normal, enable and disable.

{% highlight xaml %}

<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             x:Class="TabViewMauiSample.MainPage"
             xmlns:tabView="http://schemas.syncfusion.com/maui"
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
        </Grid>
    </ContentPage.Content>
</ContentPage>

{% endhighlight %}

![Visual state manager](images/Visual_State_Manager.jpg) 
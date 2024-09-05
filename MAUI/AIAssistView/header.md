---
layout: post
title: Header in .NET MAUI AI Assist View control | Syncfusion
description: Learn here all about Header support in Syncfusion .NET MAUI AI Assist View (SfAIAssistView) control and more.
platform: MAUI
control: SfAIAssistView
documentation: ug
---

# Header in .NET MAUI AI Assist View (SfAIAssistView)

This section explains how to define and customize the header in the `SfAIAssistView`.

## Show Header in AI Assist View

The `SfAIAssistView` shows default header by setting the `ShowHeader` property to `true`. 

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="3" %}
         <sfAIAssistView:SfAIAssistView x:Name="sfAIAssistView"
                                        AssistItems="{Binding AssistItems}"
                                        ShowHeader="True"/>  

{% highlight c# hl_lines="7" %} 

    SfAIAssistView sfAIAssistView; 
    public MainPage() 
    { 
        InitializeComponent(); 
        this.sfAIAssistView = new SfAIAssistView();
        this.sfAIAssistView.AssistItems = viewModel.AssistItems; 
        this.sfAIAssistView.ShowHeader = true;
        this.Content = sfAIAssistView; 
     } 

{% endhighlight %}
{% endtabs %}


## Customized Header Text in AI Assist View

In `SfAIAssistView`, the `HeaderText` property provides customized text as the header.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="3" %}
         <sfAIAssistView:SfAIAssistView x:Name="sfAIAssistView"
                                        AssistItems="{Binding AssistItems}"
                                        HeaderText="Ask AI"
                                        ShowHeader="True"/>  

{% endhighlight %} 

{% highlight c# hl_lines="7" %} 

    SfAIAssistView sfAIAssistView; 
    public MainPage() 
    { 
        InitializeComponent(); 
        this.sfAIAssistView = new SfAIAssistView();
        this.sfAIAssistView.AssistItems = viewModel.AssistItems; 
        this.sfAIAssistView.HeaderText = "Ask AI";
        this.sfAIAssistView.ShowHeader = true;
        this.Content = sfAIAssistView; 
     } 

{% endhighlight %}
{% endtabs %}

## Header customization

You can customize the header's appearance in `SfAIAssistView` by using the `HeaderTemplate` property.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="46" %}

 <ContentPage.Resources>
        <ResourceDictionary>
            <DataTemplate x:Key="headerTemplate">
                <Grid RowDefinitions="45,30,Auto" RowSpacing="10" Padding="0,18,0,0">
                    <Image  Source="aiassistview.png" HorizontalOptions="Center"/>                 
                    <Label Padding="0,5,0,0" Text="Ask AI Anything!" HorizontalOptions="Center" Grid.Row="1" FontSize="16"/>
                    <FlexLayout x:Name="headerlayout"
                                BindableLayout.ItemsSource="{Binding HeaderInfoCollection}"
                                Grid.Row="2"
                                Wrap="Wrap"
                                JustifyContent="Center"
                                Direction="Row"
                                Padding="10">
                        <BindableLayout.ItemTemplate>
                            <DataTemplate>
                                <Grid RowDefinitions="*,Auto,10" Padding="10">
                                    <Grid.GestureRecognizers>
                                        <TapGestureRecognizer Command="{Binding Path=BindingContext.HeaderItemTappedCommand, Source={x:Reference headerlayout}}" CommandParameter="{x:Reference label}"/>
                                    </Grid.GestureRecognizers>
                                    <Border WidthRequest="132" Stroke="#CAC4D0"  HeightRequest="130" Grid.RowSpan="2" HorizontalOptions="Center">
                                        <Border.StrokeShape>
                                            <RoundRectangle CornerRadius="12"/>
                                        </Border.StrokeShape>
                                        <Image Source="{Binding Image}" Aspect="AspectFill" HeightRequest="130" WidthRequest="130" HorizontalOptions="Center"/>
                                    </Border>
                                    <Border BackgroundColor="#FFFBFE" Stroke="#CAC4D0" Opacity="0.8" HorizontalOptions="Center" VerticalOptions="End" WidthRequest="120" Grid.Row="1" Grid.RowSpan="2">
                                        <Border.StrokeShape>
                                            <RoundRectangle CornerRadius="12"/>
                                        </Border.StrokeShape>
                                        <Label Text="{Binding HeaderMessage}" x:Name="label"  TextColor="Black" FontFamily="Roboto-Regular" FontSize="14" Padding="10"
                                               LineBreakMode="WordWrap" HorizontalOptions="Center"
                                               HorizontalTextAlignment="Center" VerticalTextAlignment="Center" />
                                    </Border>
                                </Grid>
                            </DataTemplate>
                        </BindableLayout.ItemTemplate>
                    </FlexLayout>
                </Grid>
            </DataTemplate>
        </ResourceDictionary>
    </ContentPage.Resources>
<ContentPage.Content>
      <syncfusion:SfAIAssistView x:Name="sfAIAssistView"
                                 AssistItems="{Binding AssistItems}"
                                 ShowHeader="True"
                                 HeaderTemplate="{StaticResource headerTemplate}">
      </syncfusion:SfSfAIAssistView>
</ContentPage.Content>

{% endhighlight %}
{% endtabs %}

![Header View customization in .NET MAUI AI Assist View](Images/maui-aiassistview-header-customization.png)



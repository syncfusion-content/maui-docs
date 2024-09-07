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

The `SfAIAssistView` control allows you to display a default header by configuring the `ShowHeader` property. When this property is set to `true`, the default header will be shown at the top of the assist view.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}
         <sfAIAssistView:SfAIAssistView x:Name="sfAIAssistView"
                                        ShowHeader="True"/>  

{% highlight c# hl_lines="6" %} 

    SfAIAssistView sfAIAssistView; 
    public MainPage() 
    { 
        InitializeComponent(); 
        this.sfAIAssistView = new SfAIAssistView();
        this.sfAIAssistView.ShowHeader = true;
        this.Content = sfAIAssistView; 
     } 

{% endhighlight %}
{% endtabs %}


## Customized Header Text in AI Assist View

The `SfAIAssistView` control allows you to customize the header text using the `HeaderText` property.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}
         <sfAIAssistView:SfAIAssistView x:Name="sfAIAssistView"
                                        HeaderText="Ask AI"
                                        ShowHeader="True"/>  

{% endhighlight %} 

{% highlight c# hl_lines="6" %} 

    SfAIAssistView sfAIAssistView; 
    public MainPage() 
    { 
        InitializeComponent(); 
        this.sfAIAssistView = new SfAIAssistView();
        this.sfAIAssistView.HeaderText = "Ask AI";
        this.sfAIAssistView.ShowHeader = true;
        this.Content = sfAIAssistView; 
     } 

{% endhighlight %}
{% endtabs %}

## Header customization

The `SfAIAssistView` control allows you to fully customize the header's appearance by using the `HeaderTemplate` property. This property lets you define a custom layout and style for the header.

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



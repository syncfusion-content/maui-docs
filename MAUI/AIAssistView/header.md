---
layout: post
title: .NET MAUI AI AssistView Header Customization | Syncfusion®
description: Learn how to customize the header in the Syncfusion® .NET MAUI AI AssistView control to enhance layout, branding, and user experience.
platform: MAUI
control: SfAIAssistView
documentation: ug
---

# How to Customize Header in .NET MAUI SfAIAssistView?

The [SfAIAssistView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.html) control allows you to customize the header to enhance layout, branding, and overall user experience in chat interfaces.

## Controlling header display in SfAIAssistView

The [SfAIAssistView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.html) control allows you to display a header using the [ShowHeader](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_ShowHeader)  property. By default, the value of ShowHeader is `true`, so the header is displayed at the top of the assist view.
If the ShowHeader property is set to `false`, the header will not be displayed.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}
         <syncfusion:SfAIAssistView x:Name="sfAIAssistView"
                                    ShowHeader="False"/>  

{% endhighlight %} 
{% highlight c# hl_lines="2" %} 

    SfAIAssistView sfAIAssistView = new SfAIAssistView();
    sfAIAssistView.ShowHeader = false;

{% endhighlight %}
{% endtabs %}

## Customizing header text in SfAIAssistView

The `SfAIAssistView` control allows you to customize the header text using the [HeaderText](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_HeaderText) property.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}
    <syncfusion:SfAIAssistView x:Name="sfAIAssistView"
                               HeaderText="Ask AI"
                               ShowHeader="True"/>  

{% endhighlight %} 

{% highlight c# hl_lines="2" %} 

    SfAIAssistView sfAIAssistView = new SfAIAssistView();
    sfAIAssistView.HeaderText = "Ask AI";
    sfAIAssistView.ShowHeader = true;

{% endhighlight %}
{% endtabs %}

## Header customization

The [SfAIAssistView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.html) control allows you to fully customize the header's appearance by using the [HeaderTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_HeaderTemplate) property. This property lets you define a custom layout and style for the header.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="19" %}

 <ContentPage.Resources>
    <ResourceDictionary>
        <DataTemplate x:Key="headerTemplate">
            <Grid RowDefinitions="Auto,30,Auto"
              RowSpacing="2"
              Padding="0,2,0,0">

                <Image Source="aiassistview.png"
                   HeightRequest="40"
                   WidthRequest="40"
                   HorizontalOptions="Center" />

                <Label Grid.Row="1"
                   Text="Ask AI Anything!"
                   FontSize="16"
                   FontAttributes="Bold"
                   HorizontalOptions="Center"
                   Padding="0,5,0,0" />

                <FlexLayout Grid.Row="2"
                        Wrap="Wrap"
                        JustifyContent="Center"
                        AlignItems="Start"
                        Margin="2"
                        BindableLayout.ItemsSource="{Binding HeaderInfoCollection}">

                    <BindableLayout.ItemTemplate>
                        <DataTemplate>
                            <Border WidthRequest="130"
                                HeightRequest="88"
                                StrokeShape="RoundRectangle 10"
                                BackgroundColor="#E6E8F5"
                                Margin="2">

                                <Grid>
                                    <Image Source="{Binding Image}"
                                       Aspect="AspectFill" />

                                    <Border VerticalOptions="End"
                                        BackgroundColor="#CCFFFFFF"
                                        StrokeShape="RoundRectangle 10"
                                        Margin="2"
                                        Padding="2">

                                        <Label Text="{Binding Title}"
                                           FontSize="14"
                                           HorizontalOptions="Center"
                                           HorizontalTextAlignment="Center" />
                                    </Border>
                                </Grid>
                            </Border>
                        </DataTemplate>
                    </BindableLayout.ItemTemplate>
                </FlexLayout>
            </Grid>
        </DataTemplate>
    </ResourceDictionary>
</ContentPage.Resources>

<ContentPage.Content>
      <syncfusion:SfAIAssistView x:Name="sfAIAssistView"
                                 ShowHeader="True"
                                 HeaderTemplate="{StaticResource headerTemplate}">
      </syncfusion:SfAIAssistView>
</ContentPage.Content>

{% endhighlight %}
{% endtabs %}

![Syncfusion .NET MAUI AI AssistView Header View customization](Images/maui-aiassistview-header-customization.png)

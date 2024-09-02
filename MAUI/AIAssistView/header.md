---
layout: post
title: Header in .NET MAUI AIAssistView control | Syncfusion
description: Learn here all about Header support in Syncfusion .NET MAUI AIAssistView (SfAIAssistView) control and more.
platform: MAUI
control: SfAIAssistView
documentation: ug
---

# Header in .NET MAUI AIAssistView (SfAIAssistView)

This section explains how to define and customize the header in the `SfAIAssistView`.

## Header customization

The `SfAIAssistView` allows you to add and customize appearance of the header setting the `SfAIAssistView.HeaderTemplate` property.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="4" %}
    <syncfusion:SfAIAssistView x:Name="sfAIAssistView"
                               AssistItems="{Binding AssistItems}"
                               ShowHeader="True">
        <syncfusion:SfSfAIAssistView.HeaderTemplate>
            <DataTemplate>
              <Grid BackgroundColor="Blue" HeightRequest="100">
                <Label LineBreakMode="NoWrap" Text="How May I Assist You Today?" FontAttributes="Bold"
                       FontSize="20" TextColor="White" HorizontalOptions="Center"   VerticalOptions="Center"/>
              </Grid>
            </DataTemplate>
        </syncfusion:SfSfAIAssistView.HeaderTemplate>
    </syncfusion:SfSfAIAssistView>
</ContentPage>
{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="1" %}
listView.HeaderTemplate = new DataTemplate(() =>
{
   var grid = new Grid();
   grid.BackgroundColor = Colors.Blue;
   var headerLabel = new Label
   {
       TextColor = Colors.White,
       FontSize = 20,
       FontAttributes = FontAttributes.Bold,
       Text = "How May I Assist You Today?"
   };

   grid.Children.Add(headerLabel);

   return grid;
});
{% endhighlight %}
{% endtabs %}

![Header View customization in .NET MAUI AI Assist View](Images/maui-aiassistview-header-customization.png)

## Header Text

In `SfAIAssistView`, you can use the HeaderText property  to provide customized text as the header.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
         <sfAIAssistView:SfAIAssistView x:Name="sfAIAssistView"
                                        AssistItems="{Binding AssistItems}"
                                        HeaderText="Ask AI"/>  

{% endhighlight %}
{% endtabs %}

## Show Header

The `SfAIAssistView` shows default header if `ShowHeader` property is set to true. 

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
         <sfAIAssistView:SfAIAssistView x:Name="sfAIAssistView"
                                        AssistItems="{Binding AssistItems}"
                                        ShowHeader="True"/>  

{% endhighlight %}
{% endtabs %}

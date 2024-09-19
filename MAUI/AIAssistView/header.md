---
layout: post
title: Header customization in .NET MAUI AI AssistView control | Syncfusion
description: Learn here all about Header support in Syncfusion .NET MAUI AI AssistView (SfAIAssistView) control and more.
platform: MAUI
control: SfAIAssistView
documentation: ug
---

# Header customization in .NET MAUI AI AssistView (SfAIAssistView)

This section explains how to define and customize the header in the [SfAIAssistView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.html).

## Show/hide header

The [SfAIAssistView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.html) control allows you to display a default header by configuring the [ShowHeader](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_ShowHeader) property. When this property is set to `true`, the default header will be shown at the top of the assist view. The default value of the [ShowHeader](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_ShowHeader) property is `false`.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}
         <syncfusion:SfAIAssistView x:Name="sfAIAssistView"
                                    ShowHeader="True"/>  

{% endhighlight %} 
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


## Header text

The `SfAIAssistView` control allows you to customize the header text using the [HeaderText](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_HeaderText) property.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}
         <syncfusion:SfAIAssistView x:Name="sfAIAssistView"
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

The [SfAIAssistView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.html) control allows you to fully customize the header's appearance by using the [HeaderTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_HeaderTemplate) property. This property lets you define a custom layout and style for the header.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="19" %}

 <ContentPage.Resources>
        <ResourceDictionary>
            <DataTemplate x:Key="headerTemplate">
                <Grid RowDefinitions="45,30,Auto" RowSpacing="10" Padding="0,18,0,0">
                    <Image  Source="aiassistview.png" HorizontalOptions="Center"/>                 
                    <Label Padding="0,5,0,0" Text="Ask AI Anything!" HorizontalOptions="Center" Grid.Row="1" FontSize="16"/>
                    <FlexLayout x:Name="headerlayout"
                                BindableLayout.ItemsSource="{Binding HeaderInfoCollection}">
                        ...
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

![Header View customization in .NET MAUI AI AssistView](Images/maui-aiassistview-header-customization.png)

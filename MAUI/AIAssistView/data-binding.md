---
layout: post
title: Data Binding in .NET MAUI AI Assist View Control | Syncfusion
description: Learn here all about Data Binding support in Syncfusion .NET MAUI AI Assist View (SfAIAssistView) control, its elements, and more.
platform: MAUI
control: SfAIAssistView
documentation: ug
---

# Data Binding in .NET MAUI AI Assist View (SfAIAssistView)

## Binding user requests in .NET MAUI AI Assist View (SfAIAssistView)

The `SfAIAssistView` control allows you to handle user requests by binding them to the `RequestCommand` property. This command is triggered whenever the user sends a request in the assist view.

{% tabs %}
{% highlight xaml hl_lines="15" %}
    
    <?xml version="1.0" encoding="utf-8" ?>
    <ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
                 xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
                 xmlns:sfAIAssistView="clr-namespace:Syncfusion.Maui.AIAssistView;assembly=Syncfusion.Maui.AIAssistView"
                 xmlns:local="clr-namespace:MauiAIAssistView.ViewModel"
                 x:Class="MauiAIAssistView.MainPage">

        <ContentPage.BindingContext>
            <local:ViewModel/>
        </ContentPage.BindingContext>

        <ContentPage.Content>
            <sfAIAssistView:SfAIAssistView x:Name="sfAIAssistView"
                                           AssistItems="{Binding AssistItems}" 
                                           RequestCommand="{Binding AssistViewRequestCommand}"/>
        </ContentPage.Content>
    </ContentPage>

{% endhighlight %}
{% highlight c# hl_lines="16" %}
    
    using MauiAIAssistView.ViewModel;
    using Syncfusion.Maui.SfAIAssistView;

    namespace MauiAIAssistView
    {
        public partial class MainPage : ContentPage
        {
            SfAIAssistView sfAIAssistView;
            ViewModel viewModel;
            public MainPage()
            {
                InitializeComponent();
                sfAIAssistView = new SfAIAssistView();
                viewModel = new ViewModel();
                this.sfAIAssistView.AssistItems = viewModel.AssistItems;
                sfAIAssistView.SetBinding(SfAIAssistView.RequestCommandProperty, new Binding("AssistViewRequestCommand"));
                this.Content = sfAIAssistView;
            }       
        }
    }
{% endhighlight %}
{% endtabs %}

{% tabs %}
{% highlight c# tabtitle="ViewModel.cs" hl_lines="8" %}

 public class ViewModel : INotifyPropertyChanged
 {
     ...

    public ViewModel()
    {
        this.assistItems = new ObservableCollection<object>();
        this.AssistViewRequestCommand = new Command<object>(ExecuteRequestCommand);
    }

    private async void ExecuteRequestCommand(object obj)
    {
        var request = (obj as Syncfusion.Maui.AIAssistView.RequestEventArgs).RequestItem;
        // logic for getting response from the AI.
    }

    ....

}

{% endhighlight %}
{% endtabs %}


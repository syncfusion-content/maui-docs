---
layout: post
title: Data Binding in .NET MAUI AI Assist View Control | Syncfusion
description: Learn here all about Data Binding support in Syncfusion .NET MAUI AI Assist View (SfAIAssistView) control, its elements, and more.
platform: MAUI
control: SfAIAssistView
documentation: ug
---

# Data Binding in .NET MAUI AI Assist View (SfAIAssistView)

## Generate the assist request & response items

Create AssistItem instance, set values for Profile details, Text and IsRequest properties and add it to ViewModel.AssistItems collection. `IsRequest` property is used to identify or differentiate whether an item is requesting item added by user or is response item received from AI service. When user sends the request through editor and clicking suggestion, its IsRequest property value is set to True automatically.If users want to add the request item manually in code behind, need to set `IsRequest` property to `True``.

{% tabs %}
{% highlight c# tabtitle="ViewModel.cs" %}

public class ViewModel : INotifyPropertyChanged
{
       . . .

       public ObservableCollection<object> AssistItems
       {
           get
           {
               return this.assistItems;
           }
 
           set
           {
               this.assistItems = value;
                RaisePropertyChanged("AssistItems");
           }
       }

        private async void ExecuteRequestCommand(object obj)
       {
           var request = (obj as Syncfusion.Maui.AIAssistView.RequestEventArgs).RequestItem;
           await this.GetResult(request).ConfigureAwait(true);
       }
 
       private async Task GetResult(object inputQuery)
       {
           await Task.Delay(1000).ConfigureAwait(true);
           AssistItem request = (AssistItem)inputQuery;
           if (request != null)
           {
               // Generating response from AI

                var userAIPrompt = this.GetUserAIPrompt(request.Text);
               var response = await azureAIService!.GetResultsFromAI(request.Text, userAIPrompt).ConfigureAwait(true);
               response = response.Replace("\n", "<br>");
 
               // Creating response item using response received from AI

                AssistItem responseItem = new AssistItem() { Text = response };
               responseItem.RequestItem = inputQuery;
 
                this.AssistItems.Add(responseItem);
           }
       }

   ...

}

{% endhighlight %}
{% endtabs %}

## Bind the AssistItems property

{% tabs %}
{% highlight xaml hl_lines="7" %}
    
<ContentPage.BindingContext>
    <local:ViewModel/>
</ContentPage.BindingContext>
 
<ContentPage.Content>  
        <syncfusion:SfAIAssistView x:Name="assistView"
                       AssistItems  ="{Binding AssistItems}"
                       RequestCommand="{Binding AssistViewRequestCommand}"/>
 </ContentPage.Content>

{% endhighlight %}
{% endtabs %}

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


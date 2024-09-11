---
layout: post
title: Control Template in .NET MAUI AI Assist View control | Syncfusion
description: Learn here all about Control Template support in Syncfusion .NET MAUI AI Assist View (SfAIAssistView) control, its elements and more.
platform: MAUI
control: SfAIAssistView
documentation: ug
---

# Control Template in .NET MAUI AI Assist View (SfAIAssistView)

The `ControlTemplate` in AI Assist View allows you to define and reuse the visual structure of a control. This flexible structure enables to fully customize the appearance and behavior of the AI Assist View. By using a `ControlTemplate` with the AI Assist View, you can create a highly customized and interactive interface, as demonstrated below.

{% tabs %}
{% highlight xaml hl_lines="14" %}

     <ContentPage.Resources>
        <ResourceDictionary>
            <DataTemplate x:Key="headerTemplate">
                
                ...

            </DataTemplate>
        </ResourceDictionary>
    </ContentPage.Resources>

    <ContentPage.Content>
            ...      
        <local:CustomAssistView x:Name="assistView" Grid.Row="1" ShowHeader="{Binding ShowHeader}" ItemCopyCommand="{Binding CopyCommand}" RequestCommand="{Binding AssistViewRequestCommand}" ItemRetryCommand="{Binding RetryCommand}" HeaderTemplate="{StaticResource headerTemplate}" AssistItems="{Binding AssistMessages}">
            <local:CustomAssistView.ControlTemplate>
                     <ControlTemplate>
                        <ContentView>
                            <ContentView.Content>
                                 <Grid>
                                    <ContentView IsVisible="{Binding IsActiveChatView}" Content="{TemplateBinding AssistChatView}" BindingContext="{TemplateBinding BindingContext}" />
                                    <local:ComposeView  IsVisible="{Binding IsActiveComposeView}" BindingContext="{TemplateBinding BindingContext}"/>
                                </Grid>
                            </ContentView.Content>
                        </ContentView>
                    </ControlTemplate>
            </local:CustomAssistView.ControlTemplate>
        </local:CustomAssistView>
            ...
    </ContentPage.Content>
</ContentPage>

{% endhighlight %}
{% highlight c# hl_lines="33" %}

public class CustomAssistPage : ContentPage
{
    public CustomAssistPage()
    {
        var resourceDictionary = new ResourceDictionary();
        var headerTemplate = new DataTemplate(() =>
        {
            // Define the header template
            return new ContentView();
        });

        resourceDictionary.Add("headerTemplate", headerTemplate);

        this.Resources = resourceDictionary;

        var rootGrid = new Grid
        {
            RowDefinitions =
            {
                new RowDefinition { Height = new GridLength(50) }, 
                new RowDefinition { Height = GridLength.Star }      
            }
        };

        var assistView = new CustomAssistView
        {
            HeaderTemplate = (DataTemplate)this.Resources["headerTemplate"],
            AssistItems = new Binding("AssistMessages"),
            ShowHeader = new Binding("ShowHeader"),
            ItemCopyCommand = new Binding("CopyCommand"),
            RequestCommand = new Binding("AssistViewRequestCommand"),
            ItemRetryCommand = new Binding("RetryCommand"),
            ControlTemplate = new ControlTemplate(() =>
            {
                var grid = new Grid();

                var chatContent = new ContentView
                {
                    IsVisible = new Binding("IsActiveChatView"),
                    Content = new Binding("AssistChatView"),
                    BindingContext = new TemplateBinding("BindingContext")
                };

                var composeContent = new ComposeView
                {
                    IsVisible = new Binding("IsActiveComposeView"),
                    BindingContext = new TemplateBinding("BindingContext")
                };

                grid.Children.Add(chatContent);
                grid.Children.Add(composeContent);

                var contentView = new ContentView
                {
                    Content = grid
                };

                return contentView;
            })
        };

        rootGrid.Children.Add(assistView, 0, 1);

        Content = rootGrid;
    }
}

{% endhighlight %}
{% endtabs %}

## CreateAssistChat Override in AI Assist View

The `CreateAssistChat` method allows for the customization of the chat view functionality within the AI Assist View control. By overriding this method, can create their own custom implementation of the chat view, allowing for greater control over the appearance and behavior of chat interactions.It provides the flexibility to modify how chat messages are displayed, how user interactions are handled.
Here’s how to override the CreateAssistChat method to return a custom instance of AssistViewChat.

{% tabs %} 
{% highlight c# %} 

protected virtual AssistViewChat CreateAssistChat()
{
    // Returning a custom implementation of AssistViewChat
    return new CustomAssistViewChat(this);
}

{% endhighlight %} 
{% endtabs %}

The `CustomAssistViewChat `class inherits from AssistViewChat and can be used to further customize the chat view.

{% tabs %} 
{% highlight c# %} 

    public CustomAssistViewChat(SfAIAssistView assistView) : base(assistView)
    {
        // Custom logic can be added here
    }

{% endhighlight %} 
{% endtabs %}
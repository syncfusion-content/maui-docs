---
layout: post
title: Control Template in .NET MAUI AI AssistView control | Syncfusion
description: Learn here all about Control Template support in Syncfusion .NET MAUI AI AssistView (SfAIAssistView) control, its elements and more.
platform: MAUI
control: SfAIAssistView
documentation: ug
---

# Control Template in .NET MAUI AI AssistView (SfAIAssistView)

The `ControlTemplate` in AI AssistView allows you to define and reuse the visual structure of a control. This flexible structure enables to fully customize the appearance and behavior of the AI AssistView. By using a `ControlTemplate` with the AI AssistView, you can create a highly customized and interactive interface, as demonstrated below.

{% tabs %}
{% highlight xaml hl_lines="5" %}

    <ContentPage.Content>
            ...      
        <local:CustomAssistView x:Name="sfAIAssistView"
                                AssistItems="{Binding AssistMessages}">
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

{% endhighlight %}
{% highlight c# hl_lines="8" %}

public class CustomAssistPage : ContentPage
{
    public CustomAssistPage()
    {
        ...

        var assistView = new CustomAssistView
        {
            AssistItems = new Binding("AssistMessages"),
            ControlTemplate = new ControlTemplate(() =>
            {
                var grid = new Grid();

                var chatContent = new ContentView();
                chatContent.SetBinding(ContentView.IsVisibleProperty, "IsActiveChatView");
                chatContent.SetBinding(ContentView.ContentProperty, new TemplateBinding("AssistChatView"));
                chatContent.SetBinding(BindingContextProperty, new TemplateBinding("BindingContext"));

                var composeContent = new ComposeView();
                composeContent.SetBinding(ComposeView.IsVisibleProperty, "IsActiveComposeView");
                composeContent.SetBinding(BindingContextProperty, new TemplateBinding("BindingContext"));

                grid.Children.Add(chatContent);
                grid.Children.Add(composeContent);

                var contentView = new ContentView
                {
                    Content = grid
                };

                return contentView;
            })
        };

        ...

        Content = assistView;
    }
}

{% endhighlight %}
{% endtabs %}

## CreateAssistChat Override in AI AssistView

The `CreateAssistChat` method allows for the customization of the chat view functionality within the AI AssistView control. By overriding this method, can create their own custom implementation of the chat view, allowing for greater control over the appearance and behavior of chat interactions. It provides the flexibility to modify how chat messages are displayed, how user interactions are handled. Here’s how to override the `CreateAssistChat` method to return a custom instance of `AssistViewChat`.

{% tabs %} 
{% highlight c# %} 

   public class CustomAIAssiststView : SfAIAssistView
   {
       public CustomAIAssiststView() { }

       protected override AssistViewChat CreateAssistChat()
       {
           // Returning custom implementation of AssistViewChat
           return new CustomassistViewchat(this);
       }
   }

{% endhighlight %} 
{% endtabs %}

The `CustomAssistViewChat `class inherits from `AssistViewChat` and can be used to further customize the chat view.

{% tabs %} 
{% highlight c# %} 

   public class CustomassistViewchat : AssistViewChat
   {
      public CustomassistViewchat(SfAIAssistView assistView) : base(assistView)
       {
           //Customize the AssistViewChat
           this.ShowMessageInputView = false;   
       }
   }

{% endhighlight %} 
{% endtabs %}
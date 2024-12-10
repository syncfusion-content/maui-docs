---
layout: post
title: Working with AI AssistView in .NET MAUI | Syncfusion
description: Learn here all about Working with AI AssistView support in Syncfusion .NET MAUI  AI AssistView control and more.
platform: MAUI
control: SfAIAssistView
documentation: ug
---

# Working with AI AssistView in .NET MAUI AI AssistView (SfAIAssistView)

## Stop Responding in .NET MAUI AI AssistView (SfAIAssistView)

The [SfAIAssistView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html) control provides `Stop Responding` feature that allows you to cancel an ongoing AI response by clicking the Stop Responding button. This feature ensures that users can stop if a response is no longer needed.
By default, the Stop Responding button is displayed, to disable this set the `EnableStopResponding` property to `false`.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}

    <syncfusion:SfAIAssistView x:Name="sfAIAssistView"
                               EnableStopResponding="False"/>  

{% endhighlight %} 
{% highlight c# hl_lines="6" %}

    SfAIAssistView sfAIAssistView; 
    public MainPage() 
    { 
        InitializeComponent(); 
        this.sfAIAssistView = new SfAIAssistView();
        this.sfAIAssistView.EnableStopResponding = false;
        this.Content = sfAIAssistView; 
     } 

{% endhighlight %}
{% endtabs %}

### Stop Responding Event and Command

The `SfAIAssistView` control includes a built-in event called `StopResponding` and a command named `StopRespondingCommand`. These are triggered when the `Stop Responding` button is clicked.
To cancel the response using the `StopRespondingCommand` or `StopResponding` event, you can include logic to stop the ongoing response as shown below. 

#### StopResponding Event

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}

    <syncfusion:SfAIAssistView x:Name="sfAIAssistView"
                               StopResponding="SfAIAssistView_StopResponding" />

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="1" %}

    sfAIAssistView.StopResponding += SfAIAssistView_StopResponding;

    private void SfAIAssistView_StopResponding(object sender, EventArgs e)
    {
       // Handle the Stop Responding action
    }

{% endhighlight %}
{% endtabs %}

#### StopResponding Command

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}

    <syncfusion:SfAIAssistView x:Name="sfAIAssistView"  
                               StopRespondingCommand="{Binding StopRespondingCommand}" />

{% endhighlight %}
{% highlight c# tabtitle="ViewModel.cs" hl_lines="10" %}

    public class ViewModel : INotifyPropertyChanged
    {
        public ICommand StopRespondingCommand { get; set; }

        public ViewModel()
        {
            StopRespondingCommand = new Command(ExecuteStopResponding);
        }

        private void ExecuteStopResponding()
        {
            // logic to handle the Stop Responding action
            this.CancelResponse = true;
        } 
        
        private void GetResult()
        {
           if (!CancelResponse)
           {
              // generating the response if it has not been canceled.
           }  
        }      
    }

{% endhighlight %}
{% endtabs %}

![Stop Responding in .NET MAUI AI AssistView](Images/working-with-aiassistview/maui-aiassistview-stopresponding.gif)

## Control Template in .NET MAUI AI AssistView (SfAIAssistView)

The `ControlTemplate` in AI AssistView allows you to define and reuse the visual structure of a control. This flexible structure enables to fully customize the appearance and behavior of the AI AssistView. By using `ControlTemplate` with the AI AssistView, you can create a highly customized and interactive interface, as demonstrated below.

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
{% highlight c# hl_lines="10" %}

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

### Custom chat view

The `CreateAssistChat` method allows for the customization of the chat view functionality within the AI AssistView control. By overriding this method, can create their own custom implementation of the chat view, allowing for greater control over the appearance and behavior of chat interactions. It provides the flexibility to modify how chat messages are displayed, how user interactions are handled. Here’s how to override the `CreateAssistChat` method to return a custom instance of `AssistViewChat`.

{% tabs %} 
{% highlight c# %}

   public class CustomAIAssiststView : SfAIAssistView
   {
       public CustomAIAssiststView() { }

       protected override AssistViewChat CreateAssistChat()
       {
           // Returning custom implementation of AssistViewChat
           return new CustomAssistViewChat(this);
       }
   }

{% endhighlight %} 
{% endtabs %}

The `CustomAssistViewChat `class inherits from `AssistViewChat` and can be used to further customize the chat view, here  the input view is removed by setting `ShowMessageInputView` to `false` as shown below.

{% tabs %}
{% highlight c# %}

   public class CustomAssistViewChat : AssistViewChat
   {
      public CustomAssistViewChat(SfAIAssistView assistView) : base(assistView)
       {
           //Customize the AssistViewChat
           this.ShowMessageInputView = false;   
       }
   }

{% endhighlight %} 
{% endtabs %}

N> [View sample in GitHub](https://github.com/SyncfusionExamples/custom-control-template-in-.net-maui-aiassistview)

## EditorView Template in .NET MAUI AI AssistView (SfAIAssistView)

The `SfAIAssistView` control allows you to fully customize the editor's appearance by using the `EditorViewTemplate` property. This property lets you define a custom layout and style for the editor.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="13" %}

 <ContentPage.Resources>
        <ResourceDictionary>
            <DataTemplate x:Key="editorViewTemplate">
                 <Grid>
                    <Editor x:Name="editor" Placeholder="Type Message...">
                        ...
                </Grid>
           </DataTemplate>
       </ResourceDictionary>
 </ContentPage.Resources>
<ContentPage.Content>
      <syncfusion:SfAIAssistView x:Name="sfAIAssistView"
                                 EditorViewTemplate="{StaticResource editorViewTemplate}">
      </syncfusion:SfSfAIAssistView>
</ContentPage.Content>

{% endhighlight %}
{% highlight c# hl_lines="10" %}

using Syncfusion.Maui.AIAssistView;

    public partial class MainPage : ContentPage
    {
        SfAIAssistView sfAIAssistView;
        public MainPage()
        {
            InitializeComponent();
            sfAIAssistView = new SfAIAssistView();
            sfAIAssistView.EditorViewTemplate = CreateEditorViewTemplate();
            this.Content = sfAIAssistView;
        }

        private DataTemplate CreateEditorViewTemplate()
        {
            return new DataTemplate(() =>
            {
                var grid = new Grid { };

                var editor = new Editor
                {
                    Placeholder = "Type Message...",
                };

                .......

                grid.Children.Add(editor);

                return grid;
            });
        }
    }

{% endhighlight %}
{% endtabs %}

![EditorView Template in .NET MAUI AI AssistView](Images/working-with-aiassistview/maui-aiassistview-editorviewtemplate.png)
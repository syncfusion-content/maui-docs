---
layout: post
title: Time Break in .NET MAUI Chat Control | Syncfusion
description: Learn here all about Time break support in Syncfusion .NET MAUI Chat (SfChat) control, its elements and more.
platform: MAUI
control: Chat
documentation: ug
---
# Time break in .Net MAUI Chat (SfChat)

The chat control offers a user-friendly method for organizing messages by their creation date and time, facilitating easy identification of messages in chronological order. To activate the time break view in `SfChat`, simply set the [SfChat.ShowTimeBreak]() property to `true`.

{% tabs %}
{% highlight xaml %}
  
    <ContentPage.BindingContext>
        <local:GettingStartedViewModel/>
    </ContentPage.BindingContext>
    
     <ContentPage.Content>
         <sfChat:SfChat x:Name="sfChat"
                       ShowTimeBreak="True"
                       Messages="{Binding Messages}"
                       CurrentUser="{Binding CurrentUser}" />
     </ContentPage.Content>

{% endhighlight %}
{% highlight c# %}

     namespace GettingStarted
     {
       public partial class MainPage : ContentPage
       {
          SfChat sfChat;
          GettingStartedViewModel viewModel;
          public MainPage()
          {
             InitializeComponent();
             sfChat = new SfChat();
             viewModel = new GettingStartedViewModel();
             this.sfChat.Messages = viewModel.Messages;
             this.sfChat.CurrentUser = viewModel.CurrentUser;
             this.sfChat.ShowTimeBreak = true;
             this.Content = sfChat;
           }
        }
     }

{% endhighlight %}
{% endtabs %}

![.NET MAUI chat time break]()

## Stick time break view

To keep the time break view visible, enable the [SfChat.StickyTimeBreak]() property. When `StickyTimeBreak` is set to true, the time break view will remain displayed until the preceding time break view is no longer visible. Additionally, the time break will adjust its position as another time break appears while scrolling.

{% tabs %}
{% highlight xaml %}


     <?xml version="1.0" encoding="utf-8" ?>
    <ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:sfChat="clr-namespace:Syncfusion.XForms.Chat;assembly=Syncfusion.SfChat.XForms"
             xmlns:local="clr-namespace:GettingStarted"
             x:Class="GettingStarted.MainPage">
               <ContentPage.BindingContext>
        <local:GettingStartedViewModel/>

      </ContentPage.BindingContext>
         <local:GettingStartedViewModel/>
      </ContentPage.BindingContext>
     
       <ContentPage.Content>
           <sfChat:SfChat x:Name="sfChat"
                       ShowTimeBreak="True"
                       StickyTimeBreak="True"
                       Messages="{Binding Messages}"
                       CurrentUser="{Binding CurrentUser}"
                       ShowOutgoingMessageAvatar="True" />
       </ContentPage.Content>
    </ContentPage

    {% endhighlight %}
{% highlight c# %}


    namespace GettingStarted
    {
      public partial class MainPage : ContentPage
      {
           SfChat sfChat;
           GettingStartedViewModel viewModel;
           public MainPage()
           {
             InitializeComponent();
             sfChat = new SfChat();
             viewModel = new GettingStartedViewModel();
             this.sfChat.Messages = viewModel.Messages;
             this.sfChat.CurrentUser = viewModel.CurrentUser;
             this.sfChat.ShowOutgoingMessageAvatar = true;
             this.sfChat.ShowTimeBreak = true;
             this.sfChat.StickyTimeBreak = true;
             this.Content = sfChat;
            }
       }
    }

    public class GettingStartedViewModel : INotifyPropertyChanged
     {
         /// <summary>
        /// Collection of messages or conversation.
       /// </summary>
       private ObservableCollection<object> messages;

      /// <summary>
     /// current user of chat.
     /// </summary>
     private Author currentUser;

     public GettingStartedViewModel()
     {
        this.messages = new ObservableCollection<object>();
        this.currentUser = new Author() { Name = "Nancy", Avatar = "People_Circle16.png" };
        this.GenerateMessages();
     }

    /// <summary>
    /// Gets or sets the message conversation.
    /// </summary>
    public ObservableCollection<object> Messages
    {
        get
        {
            return this.messages;
        }

        set
        {
            this.messages = value;
        }
    }

    /// <summary>
    /// Gets or sets the current user.
    /// </summary>
    public Author CurrentUser
    {
        get
        {
        return this.currentUser;
        }
        set
        {
            this.currentUser = value;
            RaisePropertyChanged("CurrentUser");
        }
    }

     /// <summary>
     /// Property changed handler.
     /// </summary>
     public event PropertyChangedEventHandler PropertyChanged;

     /// <summary>
     /// Occurs when property is changed.
     /// </summary>
     /// <param name="propName">changed property name</param>
     public void RaisePropertyChanged(string propName)
     {
         if (this.PropertyChanged != null)
         {
             this.PropertyChanged(this, new PropertyChangedEventArgs(propName));
         }
     }

     private void GenerateMessages()
     {
         this.Messages.Add(new TextMessage()
         {
            Author = CurrentUser,
            Text = "Hi guys, good morning! I'm very delighted to share with you the news that our team is going to launch a new mobile application.",
            DateTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day - 1),
         });

         this.Messages.Add(new TextMessage()
         {
             Author = new Author() { Name = "Andrea", Avatar = "People_Circle2.png" },
             Text = "Oh! That's great.",
         });

         this.Messages.Add(new TextMessage()
         {
             Author = new Author() { Name = "Harrison", Avatar = "People_Circle14.png" },
             Text = "That is good news.",
         });

         this.Messages.Add(new TextMessage()
         {
             Author = new Author() { Name = "Margaret", Avatar = "People_Circle7.png" },
             Text = "What kind of application is it and when are we going to launch?",
          });
       }
    }

{% endhighlight %}
{% endtabs %}

## Template for time break view


To utilize a custom template for the time break view in `SfChat`, utilize the [SfChat.TimeBreakTemplate]() property. Below is an example code snippet demonstrating how to apply a custom `TimeBreakTemplate` in SfChat:

{% tabs %}
{% highlight xaml %}
<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:sfChat="clr-namespace:Syncfusion.Maui.Chat;assembly=Syncfusion.Maui.Chat"
             xmlns:local="clr-namespace:GettingStarted"
             x:Class="GettingStarted.MainPage">

    <ContentPage.Resources>
        <local:TimeBreakTemplateSelector x:Key="timeBreakTemplateSelector"/>
    </ContentPage.Resources>
    
    <ContentPage.BindingContext>
        <local:GettingStartedViewModel/>
    </ContentPage.BindingContext>

    <ContentPage.Content>
        <sfChat:SfChat x:Name="sfChat"
                       ShowTimeBreak="True"
                       TimeBreakTemplate="{StaticResource timeBreakTemplateSelector}"
                       Messages="{Binding Messages}"
                       CurrentUser="{Binding CurrentUser}" />
    </ContentPage.Content>
</ContentPage>


{% endhighlight %}

{% highlight c# %}

using Syncfusion.XForms.Chat;
using Xamarin.Forms;

namespace GettingStarted
{
    public partial class MainPage : ContentPage
    {
        SfChat sfChat;
        GettingStartedViewModel viewModel;
        public MainPage()
        {
            InitializeComponent();
            sfChat = new SfChat();
            viewModel = new GettingStartedViewModel();
            this.sfChat.Messages = viewModel.Messages;
            this.sfChat.CurrentUser = viewModel.CurrentUser;
            this.sfChat.ShowTimeBreak="True"
            this.sfChat.TimeBreakTemplate = new TimeBreakTemplateSelector();
            this.Content = sfChat;
        }
    }
}

internal class TimeBreakTemplateSelector : DataTemplateSelector
{
    /// <summary>
    /// Returns the template based on the message's date time.
    /// </summary>
    /// <param name="item">The <see cref="GroupResult"/> of the grouped row.</param>
    /// <param name="container">The <see cref="ChatListView"/> as <see cref="BindableObject"/>.</param>
    /// <returns>The <see cref="SfBorder"/> control which contains templates for the grouped row.</returns>
    protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
    {
    string dateString = (item as GroupResult).Key.ToString();
    DateTime groupedDate = DateTime.ParseExact(dateString, "d/M/yyyy", CultureInfo.InvariantCulture);
    string formatDate = string.Format("{0:dd MMMM yyyy}", groupedDate);

    Grid grid = new Grid();
    grid.Padding = new Thickness(3, 4, 2, 0);

    grid.RowDefinitions = new RowDefinitionCollection()
{
    new RowDefinition(){Height = 20},
};

    grid.ColumnDefinitions = new ColumnDefinitionCollection()
{
    new ColumnDefinition(){ Width = GridLength.Star},
    new ColumnDefinition(){ Width = GridLength.Auto},
    new ColumnDefinition(){ Width = GridLength.Star},
};

    Border border = new Border();
    border.VerticalOptions = LayoutOptions.Center;
    border.HorizontalOptions = LayoutOptions.Center;
    border.Stroke = Color.FromHex("#FDE490");
   
    Label label = new Label();
    label.FontSize = 11;
    label.VerticalOptions = LayoutOptions.Center;
    label.HorizontalOptions = LayoutOptions.Center;
    label.HorizontalTextAlignment = TextAlignment.Center;
    label.TextColor = Color.FromHex("#98770E");
    label.FontAttributes = FontAttributes.Bold;
    label.BackgroundColor = Color.FromHex("#FDF4D6");

    border.Content = label;

    grid.Children.Add(new StackLayout() { HeightRequest = 1, Background = Colors.LightGray, VerticalOptions = LayoutOptions.Center, Margin= 5 });
    var boxview = new StackLayout() { HeightRequest = 1, Background = Colors.LightGray, VerticalOptions = LayoutOptions.Center, Margin = 5 };
    grid.Children.Add(boxview);
    Grid.SetColumn(boxview, 2);

    if (groupedDate.Date == DateTime.Now.Date)
    {
        label.WidthRequest = 60;
        label.Text = "TODAY";
        grid.Children.Add(border);
        Grid.SetColumn(border, 1);
        return new DataTemplate(() =>
        {
            return grid;
        });
    }
    else if (groupedDate.Date == new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day - 1))
    {
        label.WidthRequest = 80;
        label.Text = "Yesterday";
        grid.Children.Add(border);
        Grid.SetColumn(border, 1);
        return new DataTemplate(() =>
        {
            return grid;
        });
    }
    else
    {
        label.WidthRequest = 120;
        label.Text = formatDate;
        grid.Children.Add(border);
        Grid.SetColumn(border, 1);
        return new DataTemplate(() =>
        {
            return grid;
        });
    }
    }
}

{% endhighlight %}
{% endtabs %}

![.NET MAUI chat time break template](SfChat_images/xamarin-forms-chat-time-break-template.png)

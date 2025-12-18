---
layout: post
title: Items in .NET MAUI AI AssistView control | Syncfusion
description: Learn here all about Items support in Syncfusion .NET MAUI AI AssistView (SfAIAssistView) control, its elements, and more.
platform: MAUI
control: SfAIAssistView
documentation: ug
---

# Items in .NET MAUI AI AssistView (SfAIAssistView)

## Configuring common settings for the AssistItem

<table>
<tr>
<td>{{'[Text](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.AssistItem.html#Syncfusion_Maui_AIAssistView_AssistItem_Text)'| markdownify }}</td>
<td>Displays the content of the assist item in the AI Assist view.</td>
</tr>
<tr>
<td>{{'[Profile](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.AssistItem.html#Syncfusion_Maui_AIAssistView_AssistItem_Profile)'| markdownify }}</td>
<td>Specify the avatar and name of the user using {{'[Profile.Avatar](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.Profile.html#Syncfusion_Maui_AIAssistView_Profile_Avatar)'| markdownify }} and {{'[Profile.Name](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.Profile.html#Syncfusion_Maui_AIAssistView_Profile_Name)'| markdownify }} properties respectively.</td>
</tr>
<tr>
<td>{{'[DateTime](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.AssistItem.html#Syncfusion_Maui_AIAssistView_AssistItem_DateTime)'| markdownify }}</td>
<td>Displays the time when the item was sent or received.</td>
</tr>
<tr>
<td>{{'[RequestItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.AssistItem.html#Syncfusion_Maui_AIAssistView_AssistItem_RequestItem)'| markdownify }}</td>
<td>Gets the data associated with the request sent by the user for which the response is generated.</td>
</tr>
<tr>
<td>{{'[Suggestion](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.AssistItem.html#Syncfusion_Maui_AIAssistView_AssistItem_Suggestion)'| markdownify }}</td>
<td>Displays list of {{'[AssistSuggestion](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.AssistSuggestion.html)'| markdownify }} as a response to a request.</td>
</tr>
<tr>
<td>{{'[ShowAssistItemFooter](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.AssistItem.html#Syncfusion_Maui_AIAssistView_AssistItem_ShowAssistItemFooter)'| markdownify }}</td>
<td>Determines whether the footer, which includes Copy, Retry, Like, Dislike, should be displayed for the assist item.</td>
</tr>
</table>


## Text item

The [AssistItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.AssistItem.html) is used to display plain text as a item, which is used to represent text-based content.

{% tabs %}
{% highlight xaml %}
    
    <?xml version="1.0" encoding="utf-8" ?>
    <ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
                xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
                xmlns:syncfusion="clr-namespace:Syncfusion.Maui.AIAssistView;assembly=Syncfusion.Maui.AIAssistView"
                xmlns:local="clr-namespace:MauiAIAssistView"             
                x:Class="MauiAIAssistView.MainPage">

        <ContentPage.BindingContext>
            <local:ViewModel/>
        </ContentPage.BindingContext>

        <ContentPage.Content>
            <syncfusion:SfAIAssistView x:Name="sfAIAssistView"
                                       AssistItems="{Binding AssistItems}"/>
        </ContentPage.Content>
    </ContentPage>

{% endhighlight %}
{% highlight c# %}

    using Syncfusion.Maui.AIAssistView;

    namespace MauiAIAssistView
    {
        public partial class MainPage : ContentPage
        {
            SfAiAssistView sfAIAssistView;
            ViewModel viewModel;
            public MainPage()
            {
                InitializeComponent();
                this.sfAIAssistView = new SfAIAssistView();
                this.viewModel = new ViewModel();
                this.sfAIAssistView.AssistItems = viewModel.AssistItems;
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

        private void GenerateAssistItems()
        {
            AssistItem requestItem = new AssistItem()
            {
               // Adding a user request as a text item
               Text = "Hey AI, can you tell me what MAUI is? Could you provide a link to learn more about .NET MAUI?",
               IsRequested = true
            };

            this.AssistItems.Add(requestItem);

            // Generating response item
            await GetResult(requestItem);
        }
           
        private async Task GetResult(AssistItem requestItem)
        {
           await Task.Delay(1000).ConfigureAwait(true);
 
           AssistItem responseItem = new AssistItem()
           {
             // Adding a text item as a response from the AI service
             Text = "Sure! MAUI stands for .NET Multi-platform App UI. It’s a framework that allows you to create cross-platform applications using a single codebase.This powerful framework is an evolution of Xamarin.Forms and is designed to streamline the development process by allowing you to write code once and deploy it across multiple platforms.",
,
           };
 
           // Add the response item to the collection
           this.AssistItems.Add(responseItem);

        }
    }
    
{% endhighlight %}
{% endtabs %}

## Hyperlink item

The [AssistHyperlinkItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.AssistHyperlinkItem.html) is used to send a [URL](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.AssistHyperlinkItem.html#Syncfusion_Maui_AIAssistView_AssistHyperlinkItem_Url) as a item. Along with the link, the thumbnail, title, and description of the URL are automatically fetched and displayed.

{% tabs %}
{% highlight c# tabtitle="ViewModel.cs" hl_lines="23" %}

    public class ViewModel : INotifyPropertyChanged
    {
        ...

        private void GenerateAssistItems()
        {
            AssistItem requestItem = new AssistItem()
            {
               Text = "Hey AI, can you tell me what MAUI is? Could you provide a link to learn more about .NET MAUI?",
               IsRequested = true
            };

            this.AssistItems.Add(requestItem);
        
            // Generating response item
            await GetResult(requestItem);
        }

        private async Task GetResult(AssistItem requestItem)
        {
           await Task.Delay(1000).ConfigureAwait(true);

            AssistItem responseItem = new AssistHyperlinkItem()
            {
                // Adding a hyperlink item as a response from the AI service.
                Text = "MAUI stands for .NET Multi-platform App UI. It's a .NET framework for building cross-platform apps with a single C# codebase for iOS, Android, macOS, and Windows. Sure! Here's a link to learn more about .NET MAUI",
                Url = "https://dotnet.microsoft.com/en-us/apps/maui",
            };

           // Add the response item to the collection
           this.AssistItems.Add(responseItem);
        }

        ...
    } 

{% endhighlight %}
{% endtabs %}

## Image item

The [AssistImageItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.AssistImageItem.html) is used to display an image as a item. Using the [Source](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.AssistImageItem.html#Syncfusion_Maui_AIAssistView_AssistImageItem_Source), [Size](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.AssistImageItem.html#Syncfusion_Maui_AIAssistView_AssistImageItem_Size), and [Aspect](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.AssistImageItem.html#Syncfusion_Maui_AIAssistView_AssistImageItem_Aspect) properties, you can display the desired image in the desired height and width as a item in the AI AssistView control.

{% tabs %}
{% highlight c# tabtitle="ViewModel.cs" hl_lines="24" %}

    public class ViewModel : INotifyPropertyChanged
    {
        ...

        private void GenerateAssistItems()
        {
            AssistItem requestItem = new AssistItem()
            {
                 Text = "Hey AI, Please share an image of bird.",
                 IsRequested = true
            };

            this.AssistItems.Add(requestItem);
            
            // Generating response item
            await GetResult(requestItem);
        }
        
        private async Task GetResult(AssistItem requestItem)
        {
            await Task.Delay(1000).ConfigureAwait(true);
            
            // Adding image item as a response from the AI service.
            AssistItem responseItem = newnew AssistImageItem()
            {
                  Aspect = Aspect.AspectFit,
                  Text = "Here's an image of a bird.",
                  Source = "bird01.png"          
            };

            // Add the response item to the collection
           this.AssistItems.Add(responseItem);
        }

        ...
    }

{% endhighlight %}
{% endtabs %}

## ImageTapped Event and Command

The [SfAIAssistView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.html) control includes a built-in event called [ImageTapped](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_ImageTapped) and a command named [ImageTappedCommand](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_ImageTappedCommand). These are triggered when an image is tapped. The tapped image item is accessible through the [ImageTappedEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.ImageTappedEventArgs.html). The `ImageTappedEventArgs` has the following member:

 * [ImageItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.ImageTappedEventArgs.html#Syncfusion_Maui_AIAssistView_ImageTappedEventArgs_ImageItem) : Refers to the tapped image item.

### ImageTapped Event

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}

    <syncfusion:SfAIAssistView x:Name="sfAIAssistView"
                               ImageTapped="sfAIAssistView_ImageTapped" />

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="1" %}
      
    sfAIAssistView.ImageTapped += SfAIAssistView_ImageTapped;

    private void SfAIAssistView_ImageTapped(object sender, ImageTappedEventArgs e)
    {  
       DisplayAlert("Image", " Tapped on image :" + e.ImageItem.Source, "Ok");                  
    }

{% endhighlight %}
{% endtabs %}

### ImageTapped Command

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}   

    <syncfusion:SfAIAssistView x:Name="sfAIAssistView"  
                               ImageTappedCommand="{Binding TappedCommand}" />

{% endhighlight %}
{% highlight c# tabtitle="ViewModel.cs" hl_lines="16" %}

    public class ViewModel : INotifyPropertyChanged
    {
        public Command<object> tappedCommand;

        public ViewModel()
        {
            TappedCommand = new Command<object>(ImageTapped);
        }
        
        public Command<object> TappedCommand
        {
            get { return tappedCommand; }
            set { tappedCommand = value; }
        }

        private void ImageTapped(object obj)
        {
           var ImageTappedArgs = obj as ImageTappedEventArgs;
           DisplayAlert("Image", " Tapped on Image item :" + ImageTappedArgs.ImageItem.Source, "Ok");                  
        }    
      
    }

{% endhighlight %}
{% endtabs %}

## Card item

In AI AssistView, to display a list of interactive cards, each card can contain an image, a list of buttons, and text (title, subtitle, and description) that align with the design used in popular bot frameworks. The [Card.Image](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.Card.html#Syncfusion_Maui_AIAssistView_Card_Image), [Card.Title](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.Card.html#Syncfusion_Maui_AIAssistView_Card_Title), [Card.Subtitle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.Card.html#Syncfusion_Maui_AIAssistView_Card_Subtitle), and [Card.Description](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.Card.html#Syncfusion_Maui_AIAssistView_Card_Description) properties are used to define and display the image, title, subtitle, and description within each card.
 
{% tabs %}
{% highlight c# tabtitle="ViewModel.cs" hl_lines="57" %}

    public class ViewModel : INotifyPropertyChanged
    {
        ...
        public ViewModel()
        {
            this.assistItems = new ObservableCollection<IAssistItem>();

            //Generate card items
            this.GenerateCards();

            //Generate assist items with card responses
            this.GenerateAssistItems();
        }

        private void GenerateCards()
        {
            cardsCollection = new ObservableCollection<Card>();
            Card card1 = new Card()
            {
                Title = "Miami",
                Description = "Miami, officially the City of Miami, is the seat of Miami-Dade County and the cultural, economic and financial center of South Florida in the United States. The city covers an area of about 56 square miles between the Everglades to the west and Biscayne Bay to the east.",
                Image = "miami.png",
            };
            card1.Buttons.Add(new CardButton() { Title = "Choose", Value = "Miammi" });

            Card card2 = new Card()
            {
                Title = "A popular tourist destination, San Francisco is known for its cool summers, fog, steep rolling hills, eclectic mix of architecture, and landmarks, including the Golden Gate Bridge, cable cars, the former Alcatraz Federal Penitentiary, Fisherman's Wharf, and its Chinatown district.",
                Image = "sanfrancisco.png",
            };
            card2.Buttons.Add(new CardButton() { Title = "Choose", Value = "San Francisco" });

            Card card3 = new Card()
            {
                Title = "Las Vegas",
                Description = "Las Vegas is an internationally renowned major resort city, known primarily for its gambling, shopping, fine dining, entertainment, and nightlife. The Las Vegas Valley as a whole serves as the leading financial, commercial, and cultural center for Nevada.",
                Image = "lasvegas.png",
            };
            card3.Buttons.Add(new CardButton() { Title = "Choose", Value = "Las Vegas" });

            Card card4 = new Card()
            {
                Title = "Dallas",
                Description = "Dallas, a modern metropolis in north Texas, is a commercial and cultural hub of the region. The Downtown Sixth Floor Museum at Dealey Plaza commemorates the site of President John F. Kennedy's assassination in 1963. In the Arts District, the Dallas Museum of Art and the Crow Collection of Asian Art cover thousands of years of art. The sleek Nasher Sculpture Center showcases contemporary sculpture.",
                Image = "dallas.png",
            };
            card4.Buttons.Add(new CardButton() { Title = "Choose", Value = "Dallas" });

            this.CardsCollection.Add(card1);
            this.CardsCollection.Add(card2);
            this.CardsCollection.Add(card3);
            this.CardsCollection.Add(card4);
        }   
        
        private void GenerateAssistItems()
        {
            AssistItems.Add(new AssistCardItem()
            {
                Cards = CardsCollection,
            });
        }
        ...  
    }

{% endhighlight %}
{% endtabs %}

## CardTapped Event and Command

The `SfAIAssistView` control includes a built-in event called [CardTapped](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_CardTapped) and a command named [CardTappedCommand](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.SfAIAssistView.html#Syncfusion_Maui_AIAssistView_SfAIAssistView_CardTappedCommand). These are triggered when a card is tapped. The tapped card item is accessible through the [CardTappedEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.CardTappedEventArgs.html). The `CardTappedEventArgs` has the following members:

 * [Card](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.CardTappedEventArgs.html#Syncfusion_Maui_AIAssistView_CardTappedEventArgs_Card) : Represents the selected card from the card collection.
 * [Action](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.CardTappedEventArgs.html#Syncfusion_Maui_AIAssistView_CardTappedEventArgs_Action) : Holds the information about the selected action when a user taps a button on a card.
 * [CardItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.CardTappedEventArgs.html#Syncfusion_Maui_AIAssistView_CardTappedEventArgs_CardItem) : Refers to the current assist view card item.
 * [Handled](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.CardTappedEventArgs.html#Syncfusion_Maui_AIAssistView_CardTappedEventArgs_Handled) : Indicates whether the event is handled or not.

### CardTapped Event

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}

    <syncfusion:SfAIAssistView x:Name="sfAIAssistView"
                               CardTapped="sfAIAssistView_CardTapped" />

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="1" %}
      
    sfAIAssistView.CardTapped += SfAIAssistView_CardTapped;

    private void SfAIAssistView_CardTapped(object sender, CardTappedEventArgs e)
    {  
       DisplayAlert("Card", " Tapped on card :" + e.Card.Title, "Ok");                  
    }

{% endhighlight %}
{% endtabs %}

### CardTapped Command

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}   

    <syncfusion:SfAIAssistView x:Name="sfAIAssistView"  
                               CardTappedCommand="{Binding TappedCommand}" />

{% endhighlight %}
{% highlight c# tabtitle="ViewModel.cs" hl_lines="16" %}

    public class ViewModel : INotifyPropertyChanged
    {
        public Command<object> tappedCommand;

        public ViewModel()
        {
            TappedCommand = new Command<object>(CardTapped);
        }
        
        public Command<object> TappedCommand
        {
            get { return tappedCommand; }
            set { tappedCommand = value; }
        }

        private void CardTapped(object obj)
        {
           var CardTappedArgs = obj as CardTappedEventArgs;
           DisplayAlert("Card", " Tapped on Card item :" + CardTappedArgs.Card.Title, "Ok");                  
        }    
      
    }

{% endhighlight %}
{% endtabs %}

## Show error response

The `SfAIAssistView` allows to display error responses by setting the error text to the [AssistItem.ErrorMessage](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.IAssistItem.html#Syncfusion_Maui_AIAssistView_IAssistItem_ErrorMessage) property, ensuring clear notification when an error occurs during AI interactions.

{% tabs %}
{% highlight c# tabtitle="ViewModel.cs" hl_lines="36" %}
    
public class ViewModel : INotifyPropertyChanged
{

    ...

    private void GenerateAssistItems()
    {
        AssistItem requestItem = new AssistItem()
        {
            Text = "Types of listening",
            IsRequested = true
        };

        this.AssistItems.Add(requestItem);

        await GetResult(requestItem);
    }
        
    private async Task GetResultAsync(AssistItem requestItem)
    {
       try
       {
           await Task.Delay(1000);
           // If successful, add the normal response
           AssistItem responseItem = new AssistItem()
           {
              Text = "Active Listening – Fully focusing and responding to the speaker with attention and empathy. Passive Listening – Hearing without reacting or engaging with the speaker. Empathetic Listening – Understanding the speaker’s emotions and feelings deeply.",
              IsRequested = false,
           };
           this.AssistItems.Add(responseItem);
        }
        catch (Exception ex)
        {
            AssistItem errorItem = new AssistItem()
            {
               ErrorMessage = "An error occurred. Either the engine you requested does not exist or there was another issue processing your request.",
               IsRequested = false,
            };
            this.AssistItems.Add(errorItem);
        }
    }
}
    
{% endhighlight %}
{% endtabs %}

![Error message in .NET MAUI AI AssistView](images/maui-aiassistview-error-message.png)

## Customizable views

The `SfAIAssistView` allows you to customize specific parts of request and response items without changing the entire UI. You can apply styles, templates, or subclass these views to create custom visuals and behavior.

The following views can be customized individually:

### Request Views

<table>
<tr>
<th> View </th>
<th> Description </th>
</tr>
<tr>
<td> {{ '[RequestTextView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.RequestTextView.html)'| markdownify }} </td>
<td> Represents the user request text content. </td>
</tr>
<tr>
<td> {{ '[RequestAssistImageView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.RequestAssistImageView.html)'| markdownify }} </td>
<td> Represents the user request image content. </td>
</tr>
<tr>
<td> {{ '[RequestHyperlinkUrlLabelView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.RequestHyperlinkUrlLabelView.html)'| markdownify }} </td>
<td> Represents the user request URL label area. </td>
</tr>
<tr>
<td> {{ '[RequestHyperLinkDetailsViewFrameView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.RequestHyperLinkDetailsViewFrameView.html)'| markdownify }} </td>
<td> Represents the user request URL details/preview frame area. </td>
</tr>
</table>

### Response Views

<table>
<tr>
<th> View </th>
<th> Description </th>
</tr>
<tr>
<td> {{ '[ResponseTextView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.ResponseTextView.html)'| markdownify }} </td>
<td> Represents the AI response text content. </td>
</tr>
<tr>
<td> {{ '[ResponseAssistImageView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.ResponseAssistImageView.html)'| markdownify }} </td>
<td> Represents the AI response image content. </td>
</tr>
<tr>
<td> {{ '[ResponseHyperlinkUrlLabelView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.ResponseHyperlinkUrlLabelView.html)'| markdownify }} </td>
<td> Represents the AI response URL label area. </td>
</tr>
<tr>
<td> {{ '[ResponseHyperLinkDetailsViewFrameView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.ResponseHyperLinkDetailsViewFrameView.html)'| markdownify }} </td>
<td> Represents the AI response URL details/preview frame area. </td>
</tr>
<tr>
<td> {{ '[ResponseCardView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.ResponseCardView.html)'| markdownify }} </td>
<td> Represents the container for card-based AI responses. </td>
</tr>
<tr>
<td> {{ '[CardItemView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.CardItemView.html)'| markdownify }} </td>
<td> Represents a single card item within a response. </td>
</tr>
<tr>
<td> {{ '[CardButtonView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.AIAssistView.CardButtonView.html)'| markdownify }} </td>
<td> Represents an action button inside a card item; exposes Title and Value bindable properties. </td>
</tr>
</table>

{% tabs %}
{% highlight xaml hl_lines="14 30" %}

<?xml version="1.0" encoding="utf-8"?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
    xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
    xmlns:syncfusion="clr-namespace:Syncfusion.Maui.AIAssistView;assembly=Syncfusion.Maui.AIAssistView"
    x:Class="MauiAIAssistView.MainPage">

    <ContentPage.BindingContext>
            <local:ViewModel/>
    </ContentPage.BindingContext>

    <ContentPage.Resources>
        <ResourceDictionary>
            <!-- Request text customization -->
            <Style TargetType="syncfusion:RequestTextView">
                <Setter Property="ControlTemplate">
                    <Setter.Value>
                        <ControlTemplate>
                            <Grid Padding="8" BackgroundColor="{DynamicResource SecondaryContainer}">
                                <Label
                                    Text="{Binding Text}"
                                    FontSize="13"
                                    TextColor="{DynamicResource OnSecondaryContainer}" />
                            </Grid>
                        </ControlTemplate>
                    </Setter.Value>
                </Setter>
            </Style>

            <!-- Response text customization -->
            <Style TargetType="syncfusion:ResponseTextView">
                <Setter Property="ControlTemplate">
                    <Setter.Value>
                        <ControlTemplate>
                            <Grid Padding="10" BackgroundColor="{DynamicResource PrimaryContainer}">
                                <Label
                                    Text="{Binding Text}"
                                    FontSize="13"
                                    FontAttributes="Italic"
                                    TextColor="{DynamicResource OnPrimaryContainer}" />
                            </Grid>
                        </ControlTemplate>
                    </Setter.Value>
                </Setter>
            </Style>
            ...
        </ResourceDictionary>
    </ContentPage.Resources>

    <ContentPage.Content>
        <syncfusion:SfAIAssistView x:Name="AssistView"
                                   AssistItems="{Binding AssistItems}" />
    </ContentPage.Content>
</ContentPage>

{% endhighlight %}
{% highlight c# hl_lines="23 47" %}

using Syncfusion.Maui.AIAssistView;

namespace MauiAIAssistView
{
    public partial class MainPage : ContentPage
    {
        SfAIAssistView assistView;
        ViewModel viewModel;

        public MainPage()
        {
            InitializeComponent();
            viewModel = new ViewModel();

            assistView = new SfAIAssistView
            {
                AssistItems = viewModel.AssistItems;
            };
            
            var resources = new ResourceDictionary();

            // Request text customization
            var requestTextStyle = new Style(typeof(RequestTextView))
            {
                Setters =
                {
                    new Setter
                    {
                        Property = RequestTextView.ControlTemplateProperty,
                        Value = new ControlTemplate(() =>
                        {
                            var grid = new Grid { Padding = 8, BackgroundColor = Colors.Beige };
                            var label = new Label
                            {
                                FontSize = 13,
                                TextColor = Colors.Black
                            };
                            label.SetBinding(Label.TextProperty, "Text");
                            grid.Children.Add(label);
                            return grid;
                        })
                    }
                }
            };

            // Response text customization 
            var responseTextStyle = new Style(typeof(ResponseTextView))
            {
                Setters =
                {
                    new Setter
                    {
                        Property = ResponseTextView.ControlTemplateProperty,
                        Value = new ControlTemplate(() =>
                        {
                            var grid = new Grid { Padding = 10, BackgroundColor = Colors.LightSkyBlue };
                            var label = new Label
                            {
                                FontSize = 13,
                                FontAttributes = FontAttributes.Italic,
                                TextColor = Colors.White
                            };
                            label.SetBinding(Label.TextProperty, "Text");
                            grid.Children.Add(label);
                            return grid;
                        })
                    }
                }
            };

            ...

            resources.Add(requestTextStyle);
            resources.Add(responseTextStyle);

            this.Resources = resources;
            this.Content = assistView;
            this.BindingContext = viewModel;
        }
    }
}

{% endhighlight %}
{% endtabs %}